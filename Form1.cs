using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Threading;

namespace bucata_unu
{  
    public partial class Form1 : Form
    {
        private List<string> fierari = new List<string>();
        private List<string> aston = new List<string>();
        private List<string> redbl = new List<string>();
        private List<string> mcl = new List<string>();
        private List<string> mercedes = new List<string>();
        private List<string> has = new List<string>();
        private List<string> wiliam = new List<string>();
        private List<string> sauber = new List<string>();
        private List<string> rbt = new List<string>();
        private List<string> alpine = new List<string>();
        private List<string> campion = new List<string>();
        private List<string> spaniol = new List<string>();
        string numeech,btn3text,btn4text,btn5text,btn6text,btn7text,btn8text;
        int tura = 0;
        int c;
        int turn=1;
        int f;
        Image neales = new Bitmap("neales.png");
        Image x = new Bitmap("x.png");
        Image o = new Bitmap("0.png");
        Image echneales = new Bitmap("echneales.png");
        Image Aston_Martin = new Bitmap("am.jpeg");
        int btn3dez = 0, btn4dez = 0, btn5dez = 0, btn6dez = 0, btn7dez = 0, btn8dez = 0;

        public Form1()
        {
            IncarcaListe();
            InitializeComponent();
            button9.Visible=false;
            button1.Visible=false;
            ms.Visible=false;
            jd.Visible=false;
            js.Visible=false;
            mj.Visible=false;
            dm.Visible=false;
            sm.Visible=false;
            cen.Visible =false;
            ds.Visible=false;
            if (turn==1)
                textBox1.Text="X";
            else
                textBox1.Text="0";
           

        }
        private void IncarcaListe()
        {
            fierari = File.ReadAllLines("ferrarif1.txt").ToList();
            aston = File.ReadAllLines("astonmartinf1.txt").ToList();
            redbl = File.ReadAllLines("redbull.txt").ToList();
            mcl = File.ReadAllLines("mclaren.txt").ToList();
            mercedes = File.ReadAllLines("mercedes.txt").ToList();
            has = File.ReadAllLines("has.txt").ToList();
            wiliam = File.ReadAllLines("wiliams.txt").ToList();
            sauber = File.ReadAllLines("kick.txt").ToList();
            rbt = File.ReadAllLines("rb.txt").ToList();
            alpine = File.ReadAllLines("alp.txt").ToList();
            campion = File.ReadAllLines("wcc.txt").ToList();
            spaniol =File.ReadAllLines("spain.txt").ToList();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Green;
            ms.FlatStyle = FlatStyle.Flat;
            ms.BackColor = Color.Transparent;
            ms.FlatAppearance.MouseDownBackColor = Color.Transparent;
            ms.FlatAppearance.MouseOverBackColor = Color.Green;
            js.FlatStyle = FlatStyle.Flat;
            js.BackColor = Color.Transparent;
            js.FlatAppearance.MouseDownBackColor = Color.Transparent;
            js.FlatAppearance.MouseOverBackColor = Color.Green;
            ds.FlatStyle = FlatStyle.Flat;
            ds.BackColor = Color.Transparent;
            ds.FlatAppearance.MouseDownBackColor = Color.Transparent;
            ds.FlatAppearance.MouseOverBackColor = Color.Green;
            cen.FlatStyle = FlatStyle.Flat;
            cen.BackColor = Color.Transparent;
            cen.FlatAppearance.MouseDownBackColor = Color.Transparent;
            cen.FlatAppearance.MouseOverBackColor = Color.Green;
            mj.FlatStyle = FlatStyle.Flat;
            mj.BackColor = Color.Transparent;
            mj.FlatAppearance.MouseDownBackColor = Color.Transparent;
            mj.FlatAppearance.MouseOverBackColor = Color.Green;
            sm.FlatStyle = FlatStyle.Flat;
            sm.BackColor = Color.Transparent;
            sm.FlatAppearance.MouseDownBackColor = Color.Transparent;
            sm.FlatAppearance.MouseOverBackColor = Color.Green;
            dm.FlatStyle = FlatStyle.Flat;
            dm.BackColor = Color.Transparent;
            dm.FlatAppearance.MouseDownBackColor = Color.Transparent;
            dm.FlatAppearance.MouseOverBackColor = Color.Green;
            jd.FlatStyle = FlatStyle.Flat;
            jd.BackColor = Color.Transparent;
            jd.FlatAppearance.MouseDownBackColor = Color.Transparent;
            jd.FlatAppearance.MouseOverBackColor = Color.Green;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            button1.Text = "";
            ms.Text= "";
            js.Text= "";
            ds.Text= "";
            cen.Text= "";
            mj.Text= "";
            sm.Text= "";
            dm.Text= "";
            jd.Text= "";
            comboBox1.Text= "Alege un Șofer";
            comboBox2.Text="Alege echipa";
            button3.Text = "";
            button3.Image= echneales;
            button3.FlatStyle = FlatStyle.Flat;
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.MouseDownBackColor = Color.Green;
            button3.FlatAppearance.MouseOverBackColor = Color.Green;
            button4.Text="";
            button4.Image= echneales;
            button4.FlatStyle = FlatStyle.Flat;
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.MouseDownBackColor = Color.Green;
            button4.FlatAppearance.MouseOverBackColor = Color.Green;
            button5.Text="";
            button5.Image= echneales;
            button5.FlatStyle = FlatStyle.Flat;
            button5.BackColor = Color.Transparent;
            button5.FlatAppearance.MouseDownBackColor = Color.Green;
            button5.FlatAppearance.MouseOverBackColor = Color.Green;
            button5.BackColor= Color.Transparent;
            button6.Text="";
            button6.FlatStyle = FlatStyle.Flat;
            button6.BackColor = Color.Transparent;
            button6.FlatAppearance.MouseDownBackColor = Color.Green;
            button6.FlatAppearance.MouseOverBackColor = Color.Green;
            button6.Image= echneales;
            button6.BackColor= Color.Transparent;
            button7.Text="";
            button7.Image= echneales;
            button7.FlatStyle = FlatStyle.Flat;
            button7.BackColor = Color.Transparent;
            button7.FlatAppearance.MouseDownBackColor = Color.Green;
            button7.FlatAppearance.MouseOverBackColor = Color.Green;
            button7.BackColor= Color.Transparent;
            button8.Text="";
            button8.FlatStyle = FlatStyle.Flat;
            button8.BackColor = Color.Transparent;
            button8.FlatAppearance.MouseDownBackColor = Color.Green;
            button8.FlatAppearance.MouseOverBackColor = Color.Green;
            button8.Image= echneales;
            button8.BackColor= Color.Transparent;
            button10.Visible=false;
        }
        

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        public void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            f=1;


        }

        public void button2_Click(object sender, EventArgs e)
        {   
            comboBox1.Visible = false;
            comboBox2.Visible= false;
            if (comboBox2.Text!="Alege echipa")
            {
                numeech=comboBox2.Text;

                if (numeech=="Aston Martin")
                {
                    numeech="am";
                }
                if (numeech=="Red Bull")
                {
                    numeech="redbull";
                }
                if (numeech=="Campion Mondial")
                {
                    numeech="champ";
                }
                if (numeech=="RB Cash App")
                {
                    numeech="rbc";
                }
                if (numeech=="Kick Sauber")
                {
                    numeech="kick";
                }
                if (numeech=="Spain")
                {

                    numeech="spain";
                }
                numeech=numeech + ".png";
                Image noua = new Bitmap(numeech);
                if (c==1)
                {

                    if (verificare_grila(comboBox2.Text))
                    {
                        btn3text=comboBox2.Text;
                        button3.Image=noua;
                        btn3dez=1;
                        button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
                        button3.FlatAppearance.MouseOverBackColor = Color.Transparent;


                    }
                    else
                    {
                        btn3text=comboBox2.Text;
                        MessageBox.Show("Alege altă echipă");

                    }
                }
                if (c==2)
                {

                    if (verificare_grila(comboBox2.Text))
                    {
                        btn4text=comboBox2.Text;
                        button4.Image=noua;
                        btn4dez=1;
                        button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
                        button4.FlatAppearance.MouseOverBackColor = Color.Transparent;

                    }
                    else
                    {
                        btn4text=comboBox2.Text;
                        MessageBox.Show("Alege altă echipă");

                    }
                }
                if (c==3)
                {

                    if (verificare_grila(comboBox2.Text))
                    {
                        btn5text=comboBox2.Text;
                        button5.Image=noua;
                        btn5dez=1;
                        button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
                        button5.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    }
                    else
                    {
                        btn5text=comboBox2.Text;
                        MessageBox.Show("Alege altă echipă");

                    }
                }
                if (c==4)
                {

                    if (verificare_grila(comboBox2.Text))
                    {
                        btn6text=comboBox2.Text;
                        button6.Image=noua;
                        btn6dez=1;
                        button6.FlatAppearance.MouseDownBackColor = Color.Transparent;
                        button6.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    }
                    else
                    {
                        btn6text=comboBox2.Text;
                        MessageBox.Show("Alege altă echipă");

                    }
                }
                if (c==5)
                {

                    if (verificare_grila(comboBox2.Text))
                    {
                        btn7text=comboBox2.Text;
                        button7.Image=noua;
                        btn7dez=1;
                        button7.FlatAppearance.MouseDownBackColor = Color.Transparent;
                        button7.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    }
                    else
                    {
                        btn7text=comboBox2.Text;
                        MessageBox.Show("Alege altă echipă");

                    }
                }
                if (c==6)
                {

                    if (verificare_grila(comboBox2.Text))
                    {
                        btn8text=comboBox2.Text;
                        button8.Image=noua;
                        btn8dez=1;
                        button8.FlatAppearance.MouseDownBackColor = Color.Transparent;
                        button8.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    }
                    else
                    {
                        btn8text=comboBox2.Text;
                        MessageBox.Show("Alege altă echipă");

                    }
                }
                if (turn==1)
                {
                    textBox1.Text="0";
                    turn=0;
                }
                else
                {
                    textBox1.Text="X";
                    turn=1;
                }
                comboBox2.Text="Alege echipa";
                if (btn3dez==1 && btn4dez==1 && btn5dez==1 && btn6dez==1 && btn7dez==1 && btn8dez==1)
                {
                    button3.BackColor=Color.Transparent;
                    button4.BackColor=Color.Transparent;
                    button5.BackColor=Color.Transparent;
                    button6.BackColor=Color.Transparent;
                    button7.BackColor=Color.Transparent;
                    button8.BackColor=Color.Transparent;
                    button1.BackgroundImage=neales;
                    ms.BackgroundImage=neales;
                    js.BackgroundImage=neales;
                    ds.BackgroundImage=neales;
                    cen.BackgroundImage =neales;
                    mj.BackgroundImage=neales;
                    sm.BackgroundImage=neales;
                    dm.BackgroundImage=neales;
                    jd.BackgroundImage=neales;
                    button1.Visible=true;
                    ms.Visible=true;
                    jd.Visible=true;
                    js.Visible=true;
                    mj.Visible=true;
                    dm.Visible=true;
                    sm.Visible=true;
                    cen.Visible =true;
                    ds.Visible=true;
                    button2.Visible=false;
                    c=20;
                    button9.Visible=true;
                }
            }
           

        
        }


        public void button3_Click(object sender, EventArgs e)
        {   if (btn3dez==0)
            {
                button3.BackColor=Color.Red;
                button4.BackColor=Color.Transparent;
;               button5.BackColor=Color.Transparent;
                button6.BackColor=Color.Transparent;
                button7.BackColor=Color.Transparent;
                button8.BackColor=Color.Transparent;
                comboBox2.Visible = true;
                c=1;
            }
         
        }

        public void button4_Click(object sender, EventArgs e)
        {
            if (btn4dez==0)
            {
                button3.BackColor=Color.Transparent;
                button4.BackColor=Color.Red;
                button5.BackColor=Color.Transparent;
                button6.BackColor=Color.Transparent;
                button7.BackColor=Color.Transparent;
                button8.BackColor=Color.Transparent;
                comboBox2.Visible = true;
                c=2;
            }
        }
        public void button5_Click(object sender, EventArgs e)
        {
            if (btn5dez==0)
            {
                button3.BackColor=Color.Transparent;
                button4.BackColor=Color.Transparent;
                button5.BackColor=Color.Red;
                button6.BackColor=Color.Transparent;
                button7.BackColor=Color.Transparent;
                button8.BackColor=Color.Transparent;
                comboBox2.Visible = true;
                c=3;
        }
        }

        public void button6_Click(object sender, EventArgs e)
        {
            if (btn6dez==0)
            {
                button3.BackColor=Color.Transparent;
                button4.BackColor=Color.Transparent;
                button5.BackColor=Color.Transparent;
                button6.BackColor=Color.Red;
                button7.BackColor=Color.Transparent;
                button8.BackColor=Color.Transparent;
                comboBox2.Visible = true;
                c=4;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (btn7dez == 0)
            {
                button3.BackColor=Color.Transparent;
                button4.BackColor=Color.Transparent;
                button5.BackColor=Color.Transparent;
                button6.BackColor=Color.Transparent;
                button7.BackColor=Color.Red; 
                button8.BackColor=Color.Transparent;
                comboBox2.Visible = true;
                c=5;
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (btn8dez == 0)
            {
                button3.BackColor=Color.Transparent;
                button4.BackColor=Color.Transparent;
                button5.BackColor=Color.Transparent;
                button6.BackColor=Color.Transparent;
                button7.BackColor=Color.Transparent;
                button8.BackColor=Color.Red;
                comboBox2.Visible = true;
                c=6;

            }
        }
        public  void textBox1_TextChanged(object sender, EventArgs e)
        { 
            
        }
        public bool verificare_grila(string a)
        { 
            if (c!=1 && a==btn3text)
               return false;
            if (c!=2 && a==btn4text)
               return false;
            if(c!=3 && a==btn5text)
               return false;
            if(c!=4 && a==btn6text)
               return false;
            if(c!=5 && a==btn7text)
               return false;
            if(c!=6 && a==btn8text)
               return false;
            if(a=="Alege echipa")
                return false;

          return true;          
        }

        private void button9_Click(object sender, EventArgs e)
        {


            if (f==1)
            {
              int a=asimilarenr(btn3text);
              int b=asimilarenr(btn6text);

                string c = comboBox1.Text;
                if (verificarecond(a, b, c))
                {
                    tura++;
                    button1.Text=comboBox1.Text;
                    if (turn==1)
                    {
                        button1.BackgroundImage=x;
                        button1.Enabled=false;
                    }
                    else
                    {
                        button1.BackgroundImage=o;
                        button1.Enabled=false;
                    }
                }
                else
                    button1.Text="Gresit";
            }
            if (f==2)
            {
                
                int a = asimilarenr(btn4text);
                int b = asimilarenr(btn6text);

                string c = comboBox1.Text;
                if (verificarecond(a, b, c))
                {
                    tura++;
                    ms.Text=comboBox1.Text;
                    if (turn==1)
                    {
                        ms.BackgroundImage=x;
                        ms.Enabled=false;
                    }
                    else
                    {
                        ms.BackgroundImage=o;
                        ms.Enabled=false;
                    }
                }
                else
                    ms.Text="Gresit";
            }
            if (f==3)
            {   
                int a = asimilarenr(btn5text);
                int b = asimilarenr(btn6text);

                string c = comboBox1.Text;
                if (verificarecond(a, b, c))
                {
                    tura++;
                    ds.Text=comboBox1.Text;
                    if (turn==1)
                    {
                        ds.BackgroundImage=x;
                        ds.Enabled=false;
                    }
                    else
                    {
                        ds.BackgroundImage=o;
                        ds.Enabled=false;
                    }
                }
                else
                    ds.Text="Gresit";
            }
            if (f==4)
            {
                int a = asimilarenr(btn3text);
                int b = asimilarenr(btn7text);

                string c = comboBox1.Text;
                if (verificarecond(a, b, c))
                {
                    tura++;
                    sm.Text=comboBox1.Text;
                    if (turn==1)
                    {
                        sm.BackgroundImage=x;
                        sm.Enabled=false;
                    }
                    else
                    {
                        sm.BackgroundImage=o;
                        sm.Enabled=false;
                    }
                }
                else
                    sm.Text="Gresit";
            }
            if (f==5)
            {
                
                int a = asimilarenr(btn4text);
                int b = asimilarenr(btn7text);

                string c = comboBox1.Text;
                if (verificarecond(a, b, c))
                {
                    tura++;
                    cen.Text=comboBox1.Text;
                    if (turn==1)
                    {
                        cen.BackgroundImage=x;
                        cen.Enabled=false;
                    }
                    else
                    {
                        cen.BackgroundImage=o;
                        cen.Enabled=false;
                    }
                }
                else
                    cen.Text="Gresit";
            }
            if (f==6)
            {
                int a = asimilarenr(btn5text);
                int b = asimilarenr(btn7text);

                string c = comboBox1.Text;
                if (verificarecond(a, b, c))
                {
                    tura++;
                    dm.Text=comboBox1.Text;
                    if (turn==1)
                    {
                        dm.BackgroundImage=x;
                        dm.Enabled=false;
                    }
                    else
                    {
                         dm.BackgroundImage=o;
                        dm.Enabled=false;
                    }
                }
                else
                    dm.Text="Gresit";
            }
            if (f==7)
            {
                int a = asimilarenr(btn3text);
                int b = asimilarenr(btn8text);

                string c = comboBox1.Text;
                if (verificarecond(a, b, c))
                {
                    tura++;
                    js.Text=comboBox1.Text;
                    if (turn==1)
                    {
                        js.BackgroundImage=x;
                        js.Enabled=false;
                    }
                    else
                    {
                        js.BackgroundImage=o;
                        js.Enabled=false;
                    }
                }
                else
                    js.Text="Gresit";
            }
            if (f==8)
            {   
                int a = asimilarenr(btn4text);
                int b = asimilarenr(btn8text);

                string c = comboBox1.Text;
                if (verificarecond(a, b, c))
                {
                    tura++;
                    mj.Text=comboBox1.Text;
                    if (turn==1)
                    {
                        mj.BackgroundImage=x;
                        mj.Enabled=false;
                    }
                    else
                    {
                        mj.BackgroundImage=o;
                        mj.Enabled=false;
                    }
                }
                else
                    mj.Text="Gresit";
            }
            if (f==9)
            {
                int a = asimilarenr(btn5text);
                int b = asimilarenr(btn8text);

                string c = comboBox1.Text;
                if (verificarecond(a, b, c))
                {
                    tura++;
                    jd.Text=comboBox1.Text;
                    if (turn==1)
                    {
                        jd.BackgroundImage=x;
                        jd.Enabled=false;
                    }
                    else
                    {
                        jd.BackgroundImage=o;
                        jd.Enabled=false;
                    }
                }
                else
                    jd.Text="Gresit";
            }
            f=0;
            if (button1.BackgroundImage==ms.BackgroundImage && ms.BackgroundImage==ds.BackgroundImage && button1.BackgroundImage!=neales)
            {
                if (turn==1)
                {
                    MessageBox.Show("A castigat X");
                    resetaregrile();
                }
                else if (turn==0)
                {
                    MessageBox.Show("A castigat 0");
                    resetaregrile();
                }    
            }
            if (button1.BackgroundImage==sm.BackgroundImage && sm.BackgroundImage==js.BackgroundImage && button1.BackgroundImage!=neales)
            {
                if (turn==1)
                {
                    MessageBox.Show("A castigat X");
                    resetaregrile();
                }
                else if (turn==0)
                {
                    MessageBox.Show("A castigat 0");
                    resetaregrile();
                }
            }
            if (button1.BackgroundImage==cen.BackgroundImage && cen.BackgroundImage==jd.BackgroundImage && button1.BackgroundImage!=neales)
            {
                if (turn==1)
                {
                    MessageBox.Show("A castigat X");
                    resetaregrile();
                }
                else if (turn==0)
                {
                    MessageBox.Show("A castigat 0");
                    resetaregrile();
                }
            }
            if (sm.BackgroundImage==cen.BackgroundImage && cen.BackgroundImage==dm.BackgroundImage && sm.BackgroundImage!=neales)
            {
                if (turn==1)
                {
                    MessageBox.Show("A castigat X");
                    resetaregrile();
                }
                else if (turn==0)
                {
                    MessageBox.Show("A castigat 0");
                    resetaregrile();
                }
            }
            if (js.BackgroundImage==mj.BackgroundImage && mj.BackgroundImage==jd.BackgroundImage && jd.BackgroundImage!=neales)
            {
                if (turn==1)
                {
                    MessageBox.Show("A castigat X");
                    resetaregrile();
                }
                else if (turn==0)
                {
                    MessageBox.Show("A castigat 0");
                    resetaregrile();
                }
            }
            if (ms.BackgroundImage==mj.BackgroundImage && mj.BackgroundImage==cen.BackgroundImage && ms.BackgroundImage!=neales)
            {
                if (turn==1)
                {
                    MessageBox.Show("A castigat X");
                    resetaregrile();
                }
                else if (turn==0)
                {
                    MessageBox.Show("A castigat 0");
                    resetaregrile();
                }
            }
            if (ds.BackgroundImage==dm.BackgroundImage && dm.BackgroundImage==jd.BackgroundImage && ds.BackgroundImage!=neales)
            {
                if (turn==1)
                {
                    MessageBox.Show("A castigat X");
                    resetaregrile();
                }
                else if (turn==0)
                {
                    MessageBox.Show("A castigat 0");
                    resetaregrile();
                }
            }
            if (js.BackgroundImage==cen.BackgroundImage && cen.BackgroundImage==ds.BackgroundImage && js.BackgroundImage!=neales)
            {
                if (turn==1)
                {
                    MessageBox.Show("A castigat X");
                    resetaregrile();
                }
                else if (turn==0)
                {
                    MessageBox.Show("A castigat 0");
                    resetaregrile();
                }
            }
            if(tura==3)
                button10.Visible=true;
            if (tura==9)
            {     MessageBox.Show("egalitate");
                resetaregrile();
             

            }
            comboBox1.Visible = false;
            if (turn==1)
            {
                textBox1.Text="0";
                turn=0;
            }
            else
            {
                textBox1.Text="X";
                turn=1;
            }
            comboBox1.Text="Alege un Șofer";

        }

        int asimilarenr(string b)
        {
            if (b=="Ferrari")
            { return 2; }
            else if (b=="Red Bull")
            { return 1; }
            else if (b=="Mclaren")
            { return 3; }
            else if (b=="Mercedes")
            { return 4; }
            else if (b=="Aston Martin")
            { return 5; }
            else if (b=="Haas")
            { return 6; }
            else if (b=="Williams")
            { return 7; }
            else if (b=="Kick Sauber")
            { return 8; }
            else if (b=="RB Cash App")
            { return 9; }
            else if (b=="Alpine")
            { return 10; }
            else if(b=="Campion Mondial")
            { return 11; }
            else if(b=="Spain")
            {
                return 12;
            }
            else    
            {
                return 23;
            }
        }

        bool verificarecond(int a, int b, string c)
        {   
            int aux;
            if (a>b)
            {
                aux=a;
                a=b;
                b=aux;
            }
    
            if (a==1)
            {
                if (b==2)
                { if (redbl.Contains(c) && fierari.Contains(c))
                    {
                        return true;
                    }

                }
                if (b==3)
                {
                    if (mcl.Contains(c) && redbl.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==4)
                {
                    if (mercedes.Contains(c) && redbl.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==5)
                {
                    if (redbl.Contains(c) && aston.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==6)
                {
                    if (redbl.Contains(c) && has.Contains(c))
                    {
                        return true;
                    }
                }
                if(b==7)
                {
                    if (redbl.Contains(c) && wiliam.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==8)
                {
                    if (redbl.Contains(c) && sauber.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==9)
                {
                    if (redbl.Contains(c) && rbt.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==10)
                {
                    if (redbl.Contains(c) && alpine.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==11)
                {
                    if (redbl.Contains(c) && campion.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==12)
                {
                    if (redbl.Contains(c) && spaniol.Contains(c))
                    {
                        return true;
                    }
                }
            }
                
            if (a==2)
            {     if (b==3)
                {
                    if (mcl.Contains(c) && fierari.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==4)
                {
                    if (mercedes.Contains(c) && fierari.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==5)
                { 
                    if(fierari.Contains(c) && aston.Contains(c))
                    {
                        return true; 
                    }
                }
                if (b==6)
                {
                    if (fierari.Contains(c) && has.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==7)
                {
                    if (fierari.Contains(c) && wiliam.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==8)
                {
                    if (fierari.Contains(c) && sauber.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==9)
                {
                    if (fierari.Contains(c) && rbt.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==10)
                {
                    if (fierari.Contains(c) && alpine.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==11)
                {
                    if (fierari.Contains(c) && campion.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==12)
                {
                    if (fierari.Contains(c) && spaniol.Contains(c))
                    {
                        return true;
                    }
                }
            }
            if (a==3)
            {
                if (b==4)
                {
                    if (mercedes.Contains(c) && mcl.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==5)
                {
                    if (mcl.Contains(c) && aston.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==6)
                {
                    if (mcl.Contains(c) && has.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==7)
                {
                    if (mcl.Contains(c) && wiliam.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==8)
                {
                    if (mcl.Contains(c) && sauber.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==9)
                {
                    if (mcl.Contains(c) && rbt.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==10)
                {
                    if (mcl.Contains(c) && alpine.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==11)
                {
                    if (mcl.Contains(c) && campion.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==12)
                {
                    if (mcl.Contains(c) && spaniol.Contains(c))
                    {
                        return true;
                    }
                }
            }
            if (a==4)
            {
                if (b==5)
                {
                    if (mercedes.Contains(c) && aston.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==6)
                {
                    if (mercedes.Contains(c) && has.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==7)
                {
                    if (mercedes.Contains(c) && wiliam.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==8)
                {
                    if (mercedes.Contains(c) && sauber.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==9)
                {
                    if (mercedes.Contains(c) && rbt.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==10)
                {
                    if (mercedes.Contains(c) && alpine.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==11)
                {
                    if (mercedes.Contains(c) && campion.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==12)
                {
                    if (mercedes.Contains(c) && spaniol.Contains(c))
                    {
                        return true;
                    }
                }
            }
            if (a==5)
            {
                if (b==6)
                {
                    if (aston.Contains(c) && has.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==7)
                {
                    if (aston.Contains(c) && wiliam.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==8)
                {
                    if (aston.Contains(c) && sauber.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==9)
                {
                    if (aston.Contains(c) && rbt.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==10)
                {
                    if (aston.Contains(c) && alpine.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==11)
                {
                    if (aston.Contains(c) && campion.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==12)
                {
                    if (aston.Contains(c) && spaniol.Contains(c))
                    {
                        return true;
                    }
                }
            }
            if (a==6)
            {
                if (b==7)
                {
                    if (has.Contains(c) && wiliam.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==8)
                {
                    if (has.Contains(c) && sauber.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==9)
                {
                    if (has.Contains(c) && rbt.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==10)
                {
                    if (has.Contains(c) && alpine.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==11)
                {
                    if (has.Contains(c) && campion.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==12)
                {
                    if (has.Contains(c) && spaniol.Contains(c))
                    {
                        return true;
                    }
                }
            }
            if (a==7)
            {
                if (b==8)
                {
                    if (wiliam.Contains(c) && sauber.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==9)
                {
                    if (wiliam.Contains(c) && rbt.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==10)
                {
                    if (wiliam.Contains(c) && alpine.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==11)
                {
                    if (wiliam.Contains(c) && campion.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==12)
                {
                    if (wiliam.Contains(c) && spaniol.Contains(c))
                    {
                        return true;
                    }
                }
            }
            if (a==8)
            {
                if (b==9)
                {
                    if (sauber.Contains(c) && rbt.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==10)
                {
                    if (sauber.Contains(c) && alpine.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==11)
                {
                    if (sauber.Contains(c) && campion.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==12)
                {
                    if (sauber.Contains(c) && spaniol.Contains(c))
                    {
                        return true;
                    }
                }
            }
            if (a==9)
            {
                if (b==10)
                {
                    if (rbt.Contains(c) && alpine.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==11)
                {
                    if (rbt.Contains(c) && campion.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==12)
                {
                    if (rbt.Contains(c) && spaniol.Contains(c))
                    {
                        return true;
                    }
                }
            }
            if (a==10)
            {
                if (b==11)
                {
                    if (alpine.Contains(c) && campion.Contains(c))
                    {
                        return true;
                    }
                }
                if (b==12)
                {
                    if (alpine.Contains(c) && spaniol.Contains(c))
                    {
                        return true;
                    }
                }
            }
            if(a==11)
            {
                if (b==12)
                {
                    if (campion.Contains(c) && spaniol.Contains(c))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void jd_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            f=9;
        }

        private void ms_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            f=2;
        }

        private void cen_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            f=5;
        }

        private void sm_Click(object sender, EventArgs e)
        {
            f=4;
            comboBox1.Visible=true; 
        }

        private void ds_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            f=3;
        }

        private void dm_Click(object sender, EventArgs e)
        {
            f=6;
            comboBox1.Visible=true;
        }

        private void js_Click(object sender, EventArgs e)
        {
            f=7;
            comboBox1.Visible=true;
        }

        private void mj_Click(object sender, EventArgs e)
        {
            f=8;
            comboBox1.Visible=true;
        }
        public void resetaregrile()
        {
            button2.Visible=true;
            button9.Visible=false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            button3.Image= echneales;
            button4.Image= echneales;
            button5.Image= echneales;
            button6.Image= echneales;
            button7.Image= echneales;
            button8.Image= echneales;
            comboBox2.Text="Alege Echipa";
            button3.Text = "";
            button4.Text="";
            button5.Text="";
            button6.Text="";
            button7.Text="";
            button8.Text="";
            btn3dez = 0;
            btn4dez = 0;
            btn5dez = 0; 
            btn6dez = 0; 
            btn7dez = 0; 
            btn8dez = 0;
            button1.Enabled=false;
            button1.Visible=false;
            ms.Visible=false;
            jd.Visible=false;
            js.Visible=false;
            mj.Visible=false;
            dm.Visible=false;
            sm.Visible=false;
            cen.Visible =false;
            ds.Visible=false;
            button1.Enabled = true;
            ms.Enabled = true;
            jd.Enabled = true;
            js.Enabled = true;
            mj.Enabled = true;
            dm.Enabled = true;
            sm.Enabled = true;
            cen.Enabled = true;
            ds.Enabled = true;
            button1.Text ="";
            ms.Text ="";
            jd.Text ="";
            js.Text ="";
            mj.Text ="";
            dm.Text ="";
            sm.Text ="";
            cen.Text ="";
            ds.Text ="";
            tura=0;
            button10.Visible=false;
            button3.FlatAppearance.MouseDownBackColor = Color.Green;
            button3.FlatAppearance.MouseOverBackColor = Color.Green;
            button4.FlatAppearance.MouseDownBackColor = Color.Green;
            button4.FlatAppearance.MouseOverBackColor = Color.Green;;
            button5.FlatAppearance.MouseDownBackColor = Color.Green;
            button5.FlatAppearance.MouseOverBackColor = Color.Green;
            button6.FlatAppearance.MouseDownBackColor = Color.Green;
            button6.FlatAppearance.MouseOverBackColor = Color.Green;
            button7.FlatAppearance.MouseDownBackColor = Color.Green;
            button7.FlatAppearance.MouseOverBackColor = Color.Green;
            button8.FlatAppearance.MouseDownBackColor = Color.Green;
            button8.FlatAppearance.MouseOverBackColor = Color.Green;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            resetaregrile();
        }

    }
}
//daca ai vazut asta te salut cu mult respect//