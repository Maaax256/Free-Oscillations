using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace FREE_OSCILLATIONS
{
    public partial class Form1 : Form
    {
        Device d3d;
        private Form2 Frm2;
        public static double  k, T;

        Mesh prujina;
        

        Mesh cylinder_1, cylinder_2;
        Material Cylinder1_Material, Cylinder2_Material;

        Mesh cyl1, cyl2, cyl3, cyl_osnovanie;
        Material cyl_Material, cyl2_Material;
      


        int Count_T = 0, count_write;
        // float hsp = 0.1f;
        // float asp = 0.2f;
        float L = 4.0f, Psi_vscrol, l_prujiny = 0.7f - 0.03f, x_shaiby0, x_shaiby1, x_cylindra1,  x_cylindra2, z=10f;
        
        bool karkas = false, fl_draw=false;

        double A = 12.6, B = 78, C = 1944, D = 684, E = 3888;
        double fi0 = 0.5, fi1, dfi0, dfi1;

        double m1=20, m2=40, c=10, alfa_koef=0.03, f=0.1, R=0.3, t_0=0,t=0, dt=0.0051;

        StreamWriter sw1 = new StreamWriter("Count_file.txt", false);

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Psi_vscrol =(float)(vScrollBar1.Value*Math.PI/180);
        }

        

        public Form1()
        {
            InitializeComponent();
            d3d = null;
            cyl1 = null;

            cylinder_1 = null;
            cylinder_2=null;
           

            cyl1 = null;
            cyl2 = null;
            cyl3 = null;
            cyl_osnovanie = null;
            prujina = null;
            
            
            //cyl11 = null;
            //cyl2 = null;
            //Cylinder = null;

            SetStyle(ControlStyles.Opaque, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
                       
            //sw1.Close();
        }
       
        
        private void SetupProekcii()
        {// Устанавливаем параметры источника освещения
            d3d.Lights[0].Enabled = true; // Включаем нулевой источник освещения
            d3d.Lights[0].Diffuse = Color.White; // Цвет источника освещения
            d3d.Lights[0].Position = new Vector3(0, 0, 0); // Задаем координаты
          //  d3d.Transform.Projection = Matrix.PerspectiveFovLH((float)Math.PI / 4, this.Width / this.Height, 1.0f, 50.0f);


            /////Чтобы mesh-объект не растягивался по ширине экрана 

            d3d.Transform.World = Matrix.Identity;

            // Настройка проекции с правильным соотношением сторон
            float aspectRatio = (float)d3d.Viewport.Width / (float)d3d.Viewport.Height;
            d3d.Transform.Projection = Matrix.PerspectiveFovLH(
                (float)Math.PI / 4, // угол обзора
                aspectRatio, // соотношение сторон
                1.0f, // ближняя плоскость отсечения
                1000.0f // дальняя плоскость отсечения
            );                       
        }


        public void OnIdle(object sender, EventArgs e)
        {
            Invalidate();
        }
       
        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)////////////////
        {
            try
            {
                PresentParameters d3dpp = new PresentParameters();
                d3dpp.BackBufferCount = 1;
                d3dpp.SwapEffect = SwapEffect.Discard;
                d3dpp.Windowed = true; // Выводим графику в окно
                d3dpp.MultiSample = MultiSampleType.None; // Выключаем антиалиасинг
                d3dpp.EnableAutoDepthStencil = true; // Разрешаем создание z-буфера
                d3dpp.AutoDepthStencilFormat = DepthFormat.D16; // Z-буфер в 16 бит
                d3d = new Device(0, // D3D_ADAPTER_DEFAULT - видеоадаптер по
                                    // умолчанию
                DeviceType.Hardware, // Тип устройства - аппаратный ускоритель
                this, // Окно для вывода графики
                CreateFlags.SoftwareVertexProcessing,
                d3dpp);
            }
            catch (Exception exc)
            {
                MessageBox.Show(this, exc.Message, "Ошибка инициализации");
                Close(); // Закрываем окно
            }

            cyl1 = Mesh.Cylinder(d3d,0.04f,0.04f,0.7f,5,5);///  
            cyl2 = Mesh.Cylinder(d3d, 0.6f , 0.1f*5,0.03f , 10, 5); // shayba
            cyl3 = Mesh.Cylinder(d3d, 0.04f, 0.04f, 0.2f+0.05f*4+0.7f*2+0.02f*4, 10, 10);

            cyl_Material = new Material();
            cyl_Material.Diffuse = Color.DarkBlue;
            cyl_Material.Specular = Color.White;

            cylinder_1 = Mesh.Cylinder(d3d, 0.2f, 0.2f, 4.0f, 25, 25);
            cylinder_2 = Mesh.Cylinder(d3d, (float)0.3f*3, (float)0.3f * 3, 0.25f, 25, 25);// Radius

            Cylinder1_Material= new Material();
            Cylinder1_Material.Diffuse = Color.Gray;
            Cylinder1_Material.Specular = Color.White;

             cyl2_Material = new Material();
            cyl2_Material.Diffuse = Color.Yellow;
            cyl2_Material.Specular = Color.White;

            

            Cylinder2_Material = new Material();
            Cylinder2_Material.Diffuse = Color.DarkOliveGreen;
            Cylinder2_Material.Specular = Color.Gray;

            cyl_osnovanie = Mesh.Box(d3d, L, 0.3f, 0.25f);
            prujina = Mesh.Cylinder(d3d, 0.1f * 5, 0.1f, l_prujiny, 2, 5);
            func_Parametry();
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        { Painter();
           
        }
        
        public void Painter()
        {
            //Очищаем буфер глубины и дублирующий буфер
            d3d.Clear(ClearFlags.Target | ClearFlags.ZBuffer, Color.DeepSkyBlue, 1.0f, 0);

            d3d.BeginScene();
            SetupProekcii();

            x_shaiby0 = L / 2 + 0.05f;
            
            if (karkas)
                d3d.RenderState.FillMode = FillMode.WireFrame;
            else
                d3d.RenderState.FillMode = FillMode.Solid;
            if (fl_draw == true)
            {
                float vertical_rotat = (float)((vScrollBar1.Value * Math.PI / 90));
                //telo 1
                d3d.Material = Cylinder1_Material;
                d3d.Transform.World=Matrix.RotationX((float)(Math.PI / 2))
                    *Matrix.RotationZ((float)(Math.PI / 2))
                    * Matrix.Translation(0, 1.1f, 0)
                    *Matrix.RotationX(Psi_vscrol)
                * Matrix.Translation(x_cylindra1, 0, z);
                cylinder_1.DrawSubset(0);


                //telo 2 koleso
                d3d.Material = Cylinder2_Material;
                d3d.Transform.World = 
                   Matrix.RotationZ(-(float)fi0/2)*
                    Matrix.RotationX(Psi_vscrol)
                    * Matrix.Translation(x_cylindra2, 0, z);
                cylinder_2.DrawSubset(0);

                //horizontal
                d3d.Material = cyl_Material;
                d3d.Transform.World = Matrix.RotationX((float)(Math.PI / 2))
                    * Matrix.Translation(0, -(float)0.295f * 3 - 0.135f, 0)
                    * Matrix.RotationX(Psi_vscrol)
                    * Matrix.Translation(0, 0, z);
                cyl_osnovanie.DrawSubset(0);

                //shaiby
                //pravaya 
                d3d.Material = cyl2_Material;
                d3d.RenderState.FillMode = FillMode.Solid;

                if ((x_shaiby1+x_shaiby0) >= x_shaiby0)// x_shaiby polojitelna
                {                            // x_shaiby1 = (float)(R * Math.Tan(fi0));  x_shaiby0 = L / 2 + 0.05f;
                  
                    d3d.Transform.World = Matrix.RotationY((float)(Math.PI / 2))
                        * Matrix.Translation(0, 1.1f, 0)
                        * Matrix.Translation(x_shaiby1+x_shaiby0, 0, 0)
                        * Matrix.RotationX(Psi_vscrol)
                        * Matrix.Translation(0, 0, z);
                    cyl2.DrawSubset(0);
                    
                    prujina = Mesh.Cylinder(d3d, 0.1f * 5, 0.1f, l_prujiny-x_shaiby1+0.01f, 2, 5);
                    d3d.RenderState.FillMode = FillMode.WireFrame;
                    
                    d3d.Transform.World = Matrix.RotationY((float)(-Math.PI / 2))
                        * Matrix.Translation(0, 1.1f, 0)
                        * Matrix.Translation(L / 2 + 0.05f + 0.1f * 5 / 2+x_shaiby1-0.01f, 0, 0)
                        * Matrix.RotationX(Psi_vscrol)
                        * Matrix.Translation(0, 0, z);
                    prujina.DrawSubset(0);
                }
                else
                {                    
                    d3d.RenderState.FillMode = FillMode.Solid; 
                    d3d.Material = cyl2_Material;
                    d3d.Transform.World = Matrix.RotationY((float)(Math.PI / 2))
                        * Matrix.Translation(0, 1.1f, 0)
                        * Matrix.Translation(x_shaiby0, 0, 0)
                        * Matrix.RotationX(Psi_vscrol)
                        * Matrix.Translation(0, 0, z);
                    cyl2.DrawSubset(0);

                    prujina = Mesh.Cylinder(d3d, 0.1f * 5, 0.1f, l_prujiny +0.01f, 2, 5);
                    d3d.RenderState.FillMode = FillMode.WireFrame;
                   
                    d3d.Transform.World = Matrix.RotationY((float)(-Math.PI / 2))
                          * Matrix.Translation(0, 1.1f, 0)
                        * Matrix.Translation(L / 2 + 0.05f + 0.1f * 5 / 2 , 0, 0)
                        * Matrix.RotationX(Psi_vscrol)
                        * Matrix.Translation(0, 0, z);
                    prujina.DrawSubset(0);
                }
                    d3d.RenderState.FillMode = FillMode.Solid;
                    d3d.Material = cyl2_Material;
                if (-(x_shaiby1+x_shaiby0) >= -x_shaiby0)//x_shaiby otrizatelna
                {//levaya
                    
                    d3d.Transform.World = Matrix.RotationY((float)(Math.PI / 2))
                      * Matrix.Translation(0, 1.1f, 0)
                      * Matrix.Translation(x_shaiby1-x_shaiby0+0.01f, 0, 0)
                      * Matrix.RotationX(Psi_vscrol)
                      * Matrix.Translation(0, 0, z);
                    cyl2.DrawSubset(0);

                    //prujiny
                    prujina = Mesh.Cylinder(d3d, 0.1f * 5, 0.1f, l_prujiny + x_shaiby1 + 0.01f, 2, 5);
                    d3d.RenderState.FillMode = FillMode.WireFrame;
                   
                    d3d.Transform.World = Matrix.RotationY((float)(Math.PI / 2))
                      * Matrix.Translation(0, 1.1f, 0)
                    * Matrix.Translation(-(L / 2 + 0.05f + 0.1f * 5 / 2)+x_shaiby1, 0, 0)
                    * Matrix.RotationX(Psi_vscrol)
                    * Matrix.Translation(0, 0, z);
                prujina.DrawSubset(0);
                }
                else 
                {
                    d3d.RenderState.FillMode = FillMode.Solid;
                    d3d.Material = cyl2_Material;
                    d3d.Transform.World = Matrix.RotationY((float)(Math.PI / 2))
                    * Matrix.Translation(0, 1.1f, 0)
                    * Matrix.Translation(-x_shaiby0, 0, 0)
                    *Matrix.RotationX(Psi_vscrol)
                    * Matrix.Translation(0, 0, z);
                cyl2.DrawSubset(0);

                    prujina = Mesh.Cylinder(d3d, 0.1f * 5, 0.1f, l_prujiny + 0.01f, 2, 5);
                   
                    d3d.RenderState.FillMode = FillMode.WireFrame;
                    d3d.Transform.World = Matrix.RotationY((float)(Math.PI / 2))
                      * Matrix.Translation(0, 1.1f, 0)
                    * Matrix.Translation(-(L / 2 + 0.05f + 0.1f * 5 / 2), 0, 0)
                    * Matrix.RotationX(Psi_vscrol)
                    * Matrix.Translation(0, 0, z);
                    prujina.DrawSubset(0);
                }

                //kanal leviy
                d3d.RenderState.FillMode = FillMode.Solid;
                d3d.Material = cyl_Material;
                d3d.Transform.World = Matrix.RotationX((float)(Math.PI / 2))
                    * Matrix.Translation(-L/2, 1.1f+0.7f/2+0.2f+0.05f, 0)
                     * Matrix.RotationX(Psi_vscrol)
                    * Matrix.Translation(0, 0, z);
                cyl1.DrawSubset(0);

                d3d.Material = cyl_Material;//horiz verh1 
                d3d.Transform.World = Matrix.RotationY((float)(Math.PI / 2))
                    * Matrix.Translation(-L / 2+ 0.7f / 2, 1.1f + 0.2f + 0.05f, 0)
                     * Matrix.RotationX((float)(vScrollBar1.Value * Math.PI / 180))
                    * Matrix.Translation(0, 0, z);
                cyl1.DrawSubset(0);

                d3d.Material = cyl_Material;//horiz verh2 
                d3d.Transform.World = Matrix.RotationY((float)(Math.PI / 2))
                    * Matrix.Translation(-L / 2 + 0.7f / 2-0.7f, 1.1f + 0.2f + 0.05f+0.7f, 0)
                    * Matrix.RotationX(Psi_vscrol)
                    * Matrix.Translation(0, 0, z);
                cyl1.DrawSubset(0);

                //-------------otrajenie

                d3d.Transform.World = Matrix.RotationX((float)(Math.PI / 2))
                    * Matrix.Translation(0, 1.1f-0.05f/2+0.02f , 0)
                  * Matrix.Translation(-(L / 2 )-0.7f, 0, 0)

                   //* Matrix.Translation(0, -(float)R * 3 - 0.135f, 0)
                   * Matrix.RotationX(Psi_vscrol)
                  * Matrix.Translation(0, 0, z);
                cyl3.DrawSubset(0);
                //------

                d3d.Material = cyl_Material;
                d3d.Transform.World = Matrix.RotationX((float)(Math.PI / 2))
                    * Matrix.Translation(-L / 2, 1.1f - 0.7f / 2 - 0.2f - 0.05f, 0)// 1.1f + 0.7f / 2 + 0.2f + 0.05f
                     * Matrix.RotationX(Psi_vscrol)
                    * Matrix.Translation(0, 0, z);
                cyl1.DrawSubset(0);

                d3d.Material = cyl_Material;//horiz niz1
                d3d.Transform.World = Matrix.RotationY((float)(Math.PI / 2))
                    * Matrix.Translation(-L / 2+ 0.7f / 2, 1.1f  - 0.2f - 0.05f, 0)
                   * Matrix.RotationX(Psi_vscrol)
                    * Matrix.Translation(0, 0, z);
                cyl1.DrawSubset(0);

                d3d.Material = cyl_Material;//horiz niz2 
                d3d.Transform.World = Matrix.RotationY((float)(Math.PI / 2))
                    * Matrix.Translation(-L / 2 + 0.7f / 2-0.7f, 1.1f - 0.2f -0.05f-0.7f, 0)
                     * Matrix.RotationX(Psi_vscrol)
                    * Matrix.Translation(0, 0, z);
                cyl1.DrawSubset(0);



                //kanal prav
                d3d.Material = cyl_Material;
                d3d.Transform.World = Matrix.RotationX((float)(Math.PI / 2))
                   * Matrix.Translation(L/2, 1.1f + 0.7f / 2 + 0.2f + 0.05f, 0) //(-L/2, 1.1f+0.7f/2+0.2f+0.05f, 0)
                    * Matrix.RotationX(Psi_vscrol)
                    * Matrix.Translation(0, 0, z);
                cyl1.DrawSubset(0);

                d3d.Material = cyl_Material;
                d3d.Transform.World = Matrix.RotationY((float)(-Math.PI / 2))
                   * Matrix.Translation(L / 2-0.7f / 2, 1.1f   + 0.2f + 0.05f, 0)
                     * Matrix.RotationX(Psi_vscrol)
                    * Matrix.Translation(0, 0, z);
                cyl1.DrawSubset(0);

                d3d.Material = cyl_Material;//horiz verh2 
                d3d.Transform.World = Matrix.RotationY((float)(Math.PI / 2))
                    * Matrix.Translation(L / 2 - 0.7f / 2 + 0.7f, 1.1f + 0.2f + 0.05f + 0.7f, 0)
                   * Matrix.RotationX(Psi_vscrol)
                    * Matrix.Translation(0, 0, z);
                cyl1.DrawSubset(0);

                //-------otrajenie
                d3d.Transform.World = Matrix.RotationX((float)(Math.PI / 2))
                     * Matrix.Translation(0, 1.1f - 0.05f / 2 + 0.02f, 0)
                   * Matrix.Translation((L / 2) +0.7f, 0, 0)
                    * Matrix.RotationX(Psi_vscrol)
                   * Matrix.Translation(0, 0, z);
                cyl3.DrawSubset(0);
                //-------

                d3d.Material = cyl_Material;
                d3d.Transform.World = Matrix.RotationX((float)(Math.PI / 2))
                   * Matrix.Translation(L / 2, 1.1f - 0.7f / 2 - 0.2f - 0.05f, 0) // (-L / 2, 1.1f - 0.7f / 2 - 0.2f + 0.05f, 0)
                    * Matrix.RotationX(Psi_vscrol)
                   * Matrix.Translation(0, 0, z);
                cyl1.DrawSubset(0);

                d3d.Material = cyl_Material;
                d3d.Transform.World = Matrix.RotationY((float)(-Math.PI / 2))
                   * Matrix.Translation(L / 2 - 0.7f / 2, 1.1f -0.2f - 0.05f, 0)
                     * Matrix.RotationX(Psi_vscrol)
                    * Matrix.Translation(0, 0, z);
                cyl1.DrawSubset(0);

                d3d.Material = cyl_Material;//horiz niz2 
                d3d.Transform.World = Matrix.RotationY((float)(Math.PI / 2))
                    * Matrix.Translation(L / 2 - 0.7f / 2 + 0.7f, 1.1f - 0.2f - 0.05f - 0.7f, 0)
                    * Matrix.RotationX(Psi_vscrol)
                    * Matrix.Translation(0, 0, z);
                cyl1.DrawSubset(0);
            }

            d3d.EndScene();
            //Показываем содержимое дублирующего буфера
            d3d.Present();

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
           // L = Convert.ToSingle(numericUpDown4.Value);
        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            f = Convert.ToDouble(numericUpDown9.Value);
            func_Parametry();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            karkas = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            count_write++;

            RungeKutta(fi0, dfi0, ref fi1, ref dfi1);
            if (fi0>=0 && fi1<=0 && Count_T==0)
            { T = 4*(t+dt/2); k = 2 * Math.PI / T; Count_T = 1; }
            fi0 = fi1; dfi0 = dfi1;//перевизнач кути
            x_shaiby1 = (float)((R + 0.1f) * Math.Tan(fi0));
            x_cylindra1 = x_shaiby1;
            x_cylindra2 = (float)(R * Math.Tan(fi0));
            t = t + dt;
           
            //if (count_write % 5 == 1)
            //using (StreamWriter writer = new StreamWriter("Count_file.txt", true))
            //{
            //    writer.WriteLine("{0:F3} {1:F7}", t, fi0);//пишемо
            //}
           sw1.WriteLine("{0:F3} {1:F7}", t, fi0);//пишемо
             fl_draw = true;
            Painter();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            karkas = true;
            this.Invalidate();
        }

        private void рухатиToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //sw1 = new StreamWriter("Count_file.txt", false);
            sw1 = new StreamWriter("Count_file.txt", true);
            timer2.Enabled = true;
                   
            графікКоливаньToolStripMenuItem.Enabled = false;
            стертиToolStripMenuItem.Enabled = false;
            рухатиToolStripMenuItem.Enabled = false;
            намалюватиToolStripMenuItem.Enabled = false;
            зупинитиToolStripMenuItem.Enabled = true;
        }

        private void зупинитиToolStripMenuItem_Click_1(object sender, EventArgs e)
        {    
           
            timer2.Enabled = false;

            
           // sw1 = new StreamWriter("Count_file.txt", false);
            sw1.Close();
            графікКоливаньToolStripMenuItem.Enabled = true;
            стертиToolStripMenuItem.Enabled = true;
            зупинитиToolStripMenuItem.Enabled = false;
            рухатиToolStripMenuItem.Enabled = true;
        }

        private void намалюватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fl_draw = true;
            t = 0;
            func_Parametry();
            Painter();
            стертиToolStripMenuItem.Enabled = true;
            рухатиToolStripMenuItem.Enabled = true;
            намалюватиToolStripMenuItem.Enabled = false;
            зупинитиToolStripMenuItem.Enabled = false;
            графікКоливаньToolStripMenuItem.Enabled = false;

            sw1.Close();
        }

        private void стертиToolStripMenuItem_Click(object sender, EventArgs e)
        {
           fl_draw = false;

            намалюватиToolStripMenuItem.Enabled = true;
            стертиToolStripMenuItem.Enabled = false;
            рухатиToolStripMenuItem.Enabled = false;
            зупинитиToolStripMenuItem.Enabled = false;
            графікКоливаньToolStripMenuItem.Enabled = false;

            sw1 = new StreamWriter("Count_file.txt", false);
            sw1.Close();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            R= Convert.ToDouble(numericUpDown3.Value);
            func_Parametry();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            m2 = Convert.ToDouble(numericUpDown2.Value);
            func_Parametry();
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            t_0=  Convert.ToDouble(numericUpDown7.Value);
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            c= Convert.ToDouble(numericUpDown5.Value);
            func_Parametry();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            alfa_koef = Convert.ToDouble(numericUpDown6.Value);
            func_Parametry();
        }

        
        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            fi0= Convert.ToDouble(numericUpDown8.Value);
            func_Parametry();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            m1 = Convert.ToDouble(numericUpDown1.Value);
            func_Parametry();
        }

        private void графікКоливаньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm2 = new Form2();
            Frm2.Activate(); Frm2.Show();
        }
        
        

           

        private void RungeKutta(double y0, double dy0, ref double y1, ref double dy1)
        {
            double dt = 0.01;
            double k1, k2, k3;
            k1 = dt * func_DU(y0);
            k2 = dt * func_DU(y0 + dt * dy0 / 2 + dt * k1 / 8);
            k3 = dt * func_DU(y0 + dt * dy0 + dt * k2 / 2);
            y1 = y0 + dt * (dy0 + (k1 + 2 * k2) / 6);
            dy1 = dy0 + (k1 + 4 * k2 + k3) / 6;
        }
        private void func_Parametry()
        {
            double P0 = 1000.0 * f + alfa_koef * 1000000.0 * f * f * f;
            A = Math.Round((4 * m1 + 1.5 * m2) * R * R, 2);
            B = 2 * R * P0;
            C = 8 * (3 * alfa_koef*1000000 * f) * R * R * R;
            D = 4 * R * R * (c*100 + 3 * alfa_koef*1000000 * f * f);
            E = 16 * alfa_koef*1000000 * Math.Pow(R, 4);
            DU_label.Text = "f= -(" + B + "+" + C + "*q^2)*q/|q|+" + D + "*q+" + E + "*q^3)/"+Math.Round(A,2);
        }
        private double func_DU(double fi)
        {
          return (-(B+C*fi*fi)*fi/Math.Abs(fi)-D*fi+E*Math.Pow(fi,3))/A;
        }
    }
}
