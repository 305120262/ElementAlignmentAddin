using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;

namespace ElementAlignmentAddin
{
    public class AlignElementCommand : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public AlignElementCommand()
        {
        }

        protected override void OnClick()
        {
            //
            //  TODO: Sample code showing how to access button host
            //
            ArcMap.Application.CurrentTool = null;
            ElementListForm frm = new ElementListForm();
            frm.AlignHandler = new AlignElementDelegate(AlignElementMethod);
            IGraphicsContainer cont = ArcMap.Document.ActiveView as IGraphicsContainer;
            cont.Reset();
            IElement ele = cont.Next();
            while(ele!=null)
            {
                IElementProperties3 pros = ele as IElementProperties3;
                if(pros.Name!="")
                {
                    frm.AddItem(pros.Name);
                }
                ele = cont.Next();
            }
            frm.ShowDialog();

        }

        void AlignElementMethod(string name, string h, string v,string hDirection,string vDirection)
        {
            IElement targetEle=null;
            IGraphicsContainer cont = ArcMap.Document.ActiveView as IGraphicsContainer;
            cont.Reset();
            IElement ele = cont.Next();
            while (ele != null)
            {
                IElementProperties3 pros = ele as IElementProperties3;
                if (pros.Name == name)
                {
                    targetEle = ele;
                    break;
                }
                ele = cont.Next();
            }

            if (targetEle == null) return;
            IEnvelope targetEnv = new EnvelopeClass() as IEnvelope;
            targetEle.QueryBounds(ArcMap.Document.ActiveView.ScreenDisplay, targetEnv);
            double xmin = targetEnv.XMin;
            double xmax = targetEnv.XMax;
            double ymin = targetEnv.YMin;
            double ymax = targetEnv.YMax;

            double vH = 0;
            double vV = 0;
            bool bH = double.TryParse(h,out vH);
            bool bV = double.TryParse(v, out vV);

            IGraphicsContainerSelect contAlign = ArcMap.Document.ActiveView as IGraphicsContainerSelect;
            IEnumElement enumEle = contAlign.SelectedElements;
            IElement eleSel = enumEle.Next();
            while (eleSel != null)
            {
                IElementProperties3 pros = eleSel as IElementProperties3;
                IEnvelope env = new EnvelopeClass() as IEnvelope;
                eleSel.QueryBounds(ArcMap.Document.ActiveView.ScreenDisplay, env);
                double dx = 0;
                double dy = 0;
                if(bH)
                { 
                    if (hDirection == "左侧")
                    {
                        dx = xmin - env.XMin - vH;
                    }
                    else
                    {
                        dx = xmax - env.XMax + vH;
                    }
                }
                if (bV)
                {
                    if (vDirection == "上侧")
                    {
                        dy = ymax - env.YMax + vV;
                    }
                    else
                    {
                        dy = ymin - env.YMin - vV;
                    }
                }
                ITransform2D trans = eleSel.Geometry as ITransform2D;
                trans.Move(dx, dy);
                eleSel.Geometry = trans as IGeometry;
                cont.UpdateElement(eleSel);
                eleSel = enumEle.Next();
            }
            ArcMap.Document.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGraphics | esriViewDrawPhase.esriViewGraphicSelection, null, null);
        }

        protected override void OnUpdate()
        {
            Enabled = ArcMap.Application != null;
        }

    }

}
