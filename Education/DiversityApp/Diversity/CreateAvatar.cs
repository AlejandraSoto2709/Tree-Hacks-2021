using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diversity
{
    public partial class CreateAvatar : Form
    {
        ThotEntities3 context = new ThotEntities3();
        public CreateAvatar()
        {
            InitializeComponent();
        }

        private void CreateAvatar_Load(object sender, EventArgs e)
        {
            //ComboBox Race and Ethnic. 
            foreach (RaceEthnic a in context.RaceEthnics)
                cbRaEt.Items.Add(a.nombre);
            //ComboBox Family Type. 
            foreach (FamilyType a in context.FamilyTypes)
                cbFaTy.Items.Add(a.nombre);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = txUser.Text;

            Avatar a = new Avatar(username, txpssw.Text, txName.Text, Convert.ToInt32(cbAge.SelectedItem.ToString()), cbRaEt.SelectedItem.ToString(), cbFaTy.SelectedItem.ToString(), " ");
            context.Avatars.Add(a);
            context.SaveChanges();
            user.username = username;
            user.passw = a.passw;
            user.name = a.name;
            user.age = a.age;
            user.raEth = a.raEth;
            user.faTy = a.faTy;
            user.idTy = " ";
            Boolean none = true;
            
            if (rbADHD.Checked)
            {
                AvDi ad = new AvDi(2, username);
                context.AvDis.Add(ad);
                context.SaveChanges();
                none = false;
                dis[2] = true;

            }
            if (rbAsthma.Checked)
            {
                AvDi ad = new AvDi(5, username);

                context.AvDis.Add(ad);
                context.SaveChanges();
                none = false;
                dis[5] = true;
            }
            if (rbAutism.Checked)
            {
                AvDi ad = new AvDi(7, username);
                context.AvDis.Add(ad);
                context.SaveChanges();
                none = false;
                dis[7] = true;
            }
            if (rbBlind.Checked)
            {
                AvDi ad = new AvDi(4, username);
                context.AvDis.Add(ad);
                context.SaveChanges();
                none = false;
                dis[4] = true;
            }

            if (rbDeaf.Checked)
            {
                AvDi ad = new AvDi(8, username);
                context.AvDis.Add(ad);
                context.SaveChanges();
                none = false;
                dis[8] = true;
            }
            if (rbDyslexia.Checked)
            {
                AvDi ad = new AvDi(3, username);
                context.AvDis.Add(ad);
                context.SaveChanges();
                none = false;
                dis[3] = true;
            }
            if (rbParaplegic.Checked)
            {
                AvDi ad = new AvDi(6, username);
                context.AvDis.Add(ad);
                context.SaveChanges();
                none = false;
                dis[6] = true;
            }

            if (rbOther.Checked)
            {
                AvDi ad = new AvDi(9, username);
                context.AvDis.Add(ad);
                context.SaveChanges();
                none = false;
                dis[9] = true;
            }
            if (none)
            {
                AvDi ad = new AvDi(1, username);
                context.AvDis.Add(ad);
                context.SaveChanges();
                none = false;
            }
            dis[0] = none;

            MainWindow w = new MainWindow();
            w.Show();
        }
        public static Avatar user = new Avatar();
        public static Boolean[] dis = new Boolean[9];


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cadSQL;
            cadSQL = $"select * from Avatar where username = '{txUser.Text}'";
            List<Avatar> lsA = context.Avatars.SqlQuery(cadSQL).ToList();

            //Verifing that the information is correct
            if (lsA.Count != 0)
            {
                lbNo.Visible = true;
                bEnter.Enabled = false;
            }
            else
            {
                lbNo.Visible = false;
                bEnter.Enabled = true;
            }

        }
    }
}
