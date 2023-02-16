using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{       
        
    internal class PanelBilder:Panel
    {   
        Panel panel = new Panel();
        
        System.Drawing.Drawing2D.GraphicsPath gPath = new System.Drawing.Drawing2D.GraphicsPath();
        
        public Panel PanelInit(int index,int stepleft , int stepTop)
        {
            this.panel.AutoScroll = true;
            this.panel.AutoSize = true;
            this.panel.TabIndex = index;
            this.panel.BackColor= Color.Transparent;
            this.panel.BackgroundImage =Properties.Resources.banana;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel.Name = $"panel{index}";
            this.panel.Tag = "0";
            this.panel.Location = new System.Drawing.Point(stepleft, stepTop);                    
            this.panel.Size = new System.Drawing.Size(104, 85);  
            
            gPath.AddEllipse(-5, -5, this.panel.Width+10, this.panel.Height+10);
            this.panel.Region = new Region(gPath);

                                  
            return this.panel;
        }


        

    }
}
