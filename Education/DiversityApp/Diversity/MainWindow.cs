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
    public partial class MainWindow : Form
    {
        ThotEntities3 context = new ThotEntities3();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (Form1.username != "")
            {
                imAvatar.ImageIndex = 27;
                //User
                string cadSQLUser;
                cadSQLUser = $"select * from Avatar where username = '{Form1.username}'";
                List<Avatar> lsA = context.Avatars.SqlQuery(cadSQLUser).ToList();

                //Diables
                string cadSQLDis;
                cadSQLDis = $"select * from Character where idC in (select distinct idC from CharDis where idDi in (select idDi from AvDis where username = '{lsA[0].username}' " +
                    $"and idDi != 1)) ";
                List<Character> lsDis = context.Characters.SqlQuery(cadSQLDis).ToList();

                ////Ethnics
                string queryEt;
                queryEt = $"select * from Character where raEth  = '{lsA[0].raEth}'";
                List<Character> lsCEt = context.Characters.SqlQuery(queryEt).ToList();
                //Family
                string queryFam;
                queryFam = $"select * from Character where faTy  = '{lsA[0].faTy}' order by idC desc";
                List<Character> lsCFam = context.Characters.SqlQuery(queryFam).ToList();
                int cant1 = lsDis.Count;
                switch (cant1)
                {
                    case 0:
                        int Et = (int)lsCEt[0].idC - 1;
                        lbIm1.ImageIndex = Et;
                        lb1.Text = lsCEt[0].descrip;
                        lbEth.Text = lsCEt[0].raEth;


                        int Fam;
                        if ((int)lsCFam[0].idC == (int)lsCEt[0].idC)
                        {
                            Fam = (int)lsCFam[1].idC - 1;
                            lb2.Text = lsCFam[1].descrip;
                            lbFam.Text = lsCFam[1].faTy;
                        }
                        else
                        {
                            Fam = (int)lsCFam[0].idC - 1;
                            lb2.Text = lsCFam[0].descrip;
                            lbFam.Text = lsCFam[0].faTy;
                        }

                        lbIm2.ImageIndex = Fam;

                        string sqlEdFam;
                        sqlEdFam = $"select* from Character where (raEth = '{lsA[0].raEth}' or faTy = '{lsA[0].faTy}')" +
                            $"and idC != '{Et + 1}' and idC != {Fam + 1} order by idC desc";

                        List<Character> lsEdFam = context.Characters.SqlQuery(sqlEdFam).ToList();
                        int cant2 = lsEdFam.Count;
                        if (cant2 > 2)
                        {
                            int i = 0;

                            int ter1 = (int)lsEdFam[i].idC - 1;
                            lb3.Text = lsEdFam[i].descrip;
                            lbIm3.ImageIndex = ter1;
                            if (lsEdFam[i].raEth.Equals(lsA[0].raEth))
                            {
                                dis1.Text = lsEdFam[i].raEth;
                            }
                            else
                            {
                                dis1.Text = lsEdFam[i].faTy;
                            }
                            i++;

                            int four1 = (int)lsEdFam[i].idC - 1;
                            lb4.Text = lsEdFam[i].descrip;
                            lbIm4.ImageIndex = four1;
                            if (lsEdFam[i].raEth.Equals(lsA[0].raEth))
                            {
                                dis2.Text = lsEdFam[i].raEth;
                            }
                            else
                            {
                                dis2.Text = lsEdFam[i].faTy;
                            }

                        }

                        break;
                    case 1:
                        int ter = (int)lsDis[0].idC - 1;
                        string sqldis11;
                        sqldis11 = $"select * from DisabilityTypes where idDi in (select distinct idDi from CharDis where idDi in (select idDi from AvDis where username = '{lsA[0].username}') and idC = '{ter + 1}')";
                        List<DisabilityType> lsDisa11 = context.DisabilityTypes.SqlQuery(sqldis11).ToList();
                        dis1.Text = lsDisa11[0].nombre;
                        lbIm3.ImageIndex = ter;
                        lb3.Text = lsDis[0].descrip;
                        int Et1;

                        if ((int)lsCEt[0].idC == (int)lsDis[0].idC)
                        {
                            Et1 = (int)lsCEt[1].idC - 1;
                            lb1.Text = lsCEt[1].descrip;
                            lbEth.Text = lsCEt[1].raEth;
                        }
                        else
                        {
                            Et1 = (int)lsCEt[0].idC - 1;
                            lb1.Text = lsCEt[0].descrip;
                            lbEth.Text = lsCEt[0].raEth;
                        }
                        lbIm1.ImageIndex = Et1;
                        int farm;
                        if ((int)lsCFam[0].idC == (int)lsCEt[0].idC || (int)lsCFam[0].idC == Et1 + 1)
                        {
                            if ((int)lsCFam[1].idC == (int)lsCEt[0].idC || (int)lsCFam[1].idC == Et1 + 1)
                            {
                                farm = (int)lsCFam[2].idC - 1;
                                lb2.Text = lsCFam[2].descrip;
                                lbFam.Text = lsCFam[2].faTy;
                            }
                            else
                            {
                                farm = (int)lsCFam[1].idC - 1;
                                lb2.Text = lsCFam[1].descrip;
                                lbFam.Text = lsCFam[1].faTy;
                            }


                        }
                        else
                        {
                            farm = (int)lsCFam[0].idC - 1;
                            lb2.Text = lsCFam[0].descrip;
                            lbFam.Text = lsCFam[0].faTy;
                        }

                        lbIm2.ImageIndex = farm;

                        string sqlEdFam1;
                        sqlEdFam1 = $"select * from Character where idC in (select distinct idC from CharDis where " +
                            $"idC in (select idC from Character where raEth = '{lsA[0].raEth}' or faTy = '{lsA[0].faTy}'))";

                        List<Character> lsEdFam1 = context.Characters.SqlQuery(sqlEdFam1).ToList();
                        int cant21 = lsEdFam1.Count;
                        if (cant21 > 2)
                        {
                            int i = 0;
                            while (i < cant21 && ((int)lsEdFam1[i].idC - 1 == Et1 || (int)lsEdFam1[i].idC - 1 == farm || (int)lsEdFam1[i].idC - 1 == ter))
                                i++;

                            int four1 = (int)lsEdFam1[i].idC - 1;
                            lb4.Text = lsEdFam1[i].descrip;
                            lbIm4.ImageIndex = four1;
                            if (lsEdFam1[i].raEth.Equals(lsA[0].raEth))
                            {
                                dis2.Text = lsEdFam1[i].raEth;
                            }
                            else
                            {
                                dis2.Text = lsEdFam1[i].faTy;
                            }
                        }

                        break;
                    default:
                        int ter2 = (int)lsDis[0].idC - 1;
                        string sqldis1;
                        sqldis1 = $"select * from DisabilityTypes where idDi in (select distinct idDi from CharDis where idDi in (select idDi from AvDis where username = '{lsA[0].username}') and idC = '{ter2 + 1}')";
                        List<DisabilityType> lsDisa1 = context.DisabilityTypes.SqlQuery(sqldis1).ToList();

                        lb3.Text = lsDis[0].descrip;
                        lbIm3.ImageIndex = ter2;
                        dis1.Text = lsDisa1[0].nombre;
                        int four2 = (int)lsDis[1].idC - 1;
                        string sqldis2;
                        sqldis2 = $"select * from DisabilityTypes where idDi in (select distinct idDi from CharDis where idDi in (select idDi from AvDis where username = '{lsA[0].username}') and idC = '{four2 + 1}')";
                        List<DisabilityType> lsDisa2 = context.DisabilityTypes.SqlQuery(sqldis2).ToList();

                        lb4.Text = lsDis[1].descrip;
                        lbIm4.ImageIndex = four2;
                        dis2.Text = lsDisa2[0].nombre;
                        int Et2;
                        if ((int)lsCEt[0].idC == (int)lsDis[0].idC || (int)lsCEt[0].idC == (int)lsDis[1].idC)
                        {
                            if ((int)lsCEt[1].idC == (int)lsDis[0].idC || (int)lsCEt[0].idC == (int)lsDis[1].idC)
                            {
                                Et2 = (int)lsCEt[2].idC - 1;
                                lb1.Text = lsCEt[2].descrip;
                                lbEth.Text = lsCEt[2].raEth;

                            }
                            else
                            {
                                Et2 = (int)lsCEt[1].idC - 1;
                                lb1.Text = lsCEt[1].descrip;
                                lbEth.Text = lsCEt[1].raEth;
                            }


                        }
                        else
                        {
                            Et2 = (int)lsCEt[0].idC - 1;
                            lb1.Text = lsCEt[0].descrip;
                            lbEth.Text = lsCEt[0].raEth;
                        }
                        lbIm1.ImageIndex = Et2;
                        int Fam2;
                        if ((int)lsCFam[0].idC == (int)lsCEt[0].idC || (int)lsCFam[0].idC == (int)lsCEt[1].idC || (int)lsCFam[0].idC == Et2 + 1)
                        {
                            if ((int)lsCFam[1].idC == (int)lsCEt[0].idC || (int)lsCFam[0].idC == (int)lsCEt[1].idC || (int)lsCFam[1].idC == Et2 + 1)
                            {
                                if ((int)lsCFam[1].idC == (int)lsCEt[0].idC || (int)lsCFam[0].idC == (int)lsCEt[1].idC || (int)lsCFam[1].idC == Et2 + 1)
                                {
                                    Fam2 = (int)lsCFam[3].idC - 1;
                                    lb2.Text = lsCFam[3].descrip;
                                    lbFam.Text = lsCFam[3].faTy;
                                }
                                else
                                {
                                    Fam2 = (int)lsCFam[2].idC - 1;
                                    lb2.Text = lsCFam[2].descrip;
                                    lbFam.Text = lsCFam[2].faTy;
                                }

                            }
                            else
                            {
                                Fam2 = (int)lsCFam[1].idC - 1;
                                lb2.Text = lsCFam[1].descrip;
                                lbFam.Text = lsCFam[1].faTy;
                            }
                        }
                        else
                        {
                            Fam2 = (int)lsCFam[0].idC - 1;
                            lb2.Text = lsCFam[0].descrip;
                            lbFam.Text = lsCFam[0].faTy;
                        }

                        lbIm2.ImageIndex = Fam2;

                        break;


                }





            }
            else
            {

                imAvatar.ImageIndex = 26;
                //User
                string cadSQLUser;
                cadSQLUser = $"select * from Avatar where username = '{CreateAvatar.user.username}'";
                List<Avatar> lsA = context.Avatars.SqlQuery(cadSQLUser).ToList();

                //Diables
                string cadSQLDis;
                cadSQLDis = $"select * from Character where idC in (select distinct idC from CharDis where idDi in (select idDi from AvDis where username = '{lsA[0].username}' " +
                    $"and idDi != 1)) ";
                List<Character> lsDis = context.Characters.SqlQuery(cadSQLDis).ToList();

                ////Ethnics
                string queryEt;
                queryEt = $"select * from Character where raEth  = '{lsA[0].raEth}'";
                List<Character> lsCEt = context.Characters.SqlQuery(queryEt).ToList();
                //Family
                string queryFam;
                queryFam = $"select * from Character where faTy  = '{lsA[0].faTy}' order by idC desc";
                List<Character> lsCFam = context.Characters.SqlQuery(queryFam).ToList();
                int cant1 = lsDis.Count;
                switch (cant1)
                {
                    case 0:
                        int Et = (int)lsCEt[0].idC - 1;
                        lbIm1.ImageIndex = Et;
                        lb1.Text = lsCEt[0].descrip;
                        lbEth.Text = lsCEt[0].raEth;


                        int Fam;
                        if ((int)lsCFam[0].idC == (int)lsCEt[0].idC)
                        {
                            Fam = (int)lsCFam[1].idC - 1;
                            lb2.Text = lsCFam[1].descrip;
                            lbFam.Text = lsCFam[1].faTy;
                        }
                        else
                        {
                            Fam = (int)lsCFam[0].idC - 1;
                            lb2.Text = lsCFam[0].descrip;
                            lbFam.Text = lsCFam[0].faTy;
                        }

                        lbIm2.ImageIndex = Fam;

                        string sqlEdFam;
                        sqlEdFam = $"select* from Character where (raEth = '{lsA[0].raEth}' or faTy = '{lsA[0].faTy}')" +
                            $"and idC != '{Et + 1}' and idC != {Fam + 1} order by idC desc";

                        List<Character> lsEdFam = context.Characters.SqlQuery(sqlEdFam).ToList();
                        int cant2 = lsEdFam.Count;
                        if (cant2 > 2)
                        {
                            int i = 0;

                            int ter1 = (int)lsEdFam[i].idC - 1;
                            lb3.Text = lsEdFam[i].descrip;
                            lbIm3.ImageIndex = ter1;
                            if (lsEdFam[i].raEth.Equals(lsA[0].raEth))
                            {
                                dis1.Text = lsEdFam[i].raEth;
                            }
                            else
                            {
                                dis1.Text = lsEdFam[i].faTy;
                            }
                            i++;

                            int four1 = (int)lsEdFam[i].idC - 1;
                            lb4.Text = lsEdFam[i].descrip;
                            lbIm4.ImageIndex = four1;
                            if (lsEdFam[i].raEth.Equals(lsA[0].raEth))
                            {
                                dis2.Text = lsEdFam[i].raEth;
                            }
                            else
                            {
                                dis2.Text = lsEdFam[i].faTy;
                            }

                        }

                        break;
                    case 1:
                        int ter = (int)lsDis[0].idC - 1;
                        string sqldis11;
                        sqldis11 = $"select * from DisabilityTypes where idDi in (select distinct idDi from CharDis where idDi in (select idDi from AvDis where username = '{lsA[0].username}') and idC = '{ter + 1}')";
                        List<DisabilityType> lsDisa11 = context.DisabilityTypes.SqlQuery(sqldis11).ToList();
                        dis1.Text = lsDisa11[0].nombre;
                        lbIm3.ImageIndex = ter;
                        lb3.Text = lsDis[0].descrip;
                        int Et1;

                        if ((int)lsCEt[0].idC == (int)lsDis[0].idC)
                        {
                            Et1 = (int)lsCEt[1].idC - 1;
                            lb1.Text = lsCEt[1].descrip;
                            lbEth.Text = lsCEt[1].raEth;
                        }
                        else
                        {
                            Et1 = (int)lsCEt[0].idC - 1;
                            lb1.Text = lsCEt[0].descrip;
                            lbEth.Text = lsCEt[0].raEth;
                        }
                        lbIm1.ImageIndex = Et1;
                        int farm;
                        if ((int)lsCFam[0].idC == (int)lsCEt[0].idC || (int)lsCFam[0].idC == Et1 + 1)
                        {
                            if ((int)lsCFam[1].idC == (int)lsCEt[0].idC || (int)lsCFam[1].idC == Et1 + 1)
                            {
                                farm = (int)lsCFam[2].idC - 1;
                                lb2.Text = lsCFam[2].descrip;
                                lbFam.Text = lsCFam[2].faTy;
                            }
                            else
                            {
                                farm = (int)lsCFam[1].idC - 1;
                                lb2.Text = lsCFam[1].descrip;
                                lbFam.Text = lsCFam[1].faTy;
                            }


                        }
                        else
                        {
                            farm = (int)lsCFam[0].idC - 1;
                            lb2.Text = lsCFam[0].descrip;
                            lbFam.Text = lsCFam[0].faTy;
                        }

                        lbIm2.ImageIndex = farm;

                        string sqlEdFam1;
                        sqlEdFam1 = $"select * from Character where idC in (select distinct idC from CharDis where " +
                            $"idC in (select idC from Character where raEth = '{lsA[0].raEth}' or faTy = '{lsA[0].faTy}'))";

                        List<Character> lsEdFam1 = context.Characters.SqlQuery(sqlEdFam1).ToList();
                        int cant21 = lsEdFam1.Count;
                        if (cant21 > 2)
                        {
                            int i = 0;
                            while (i < cant21 && ((int)lsEdFam1[i].idC - 1 == Et1 || (int)lsEdFam1[i].idC - 1 == farm || (int)lsEdFam1[i].idC - 1 == ter))
                                i++;

                            int four1 = (int)lsEdFam1[i].idC - 1;
                            lb4.Text = lsEdFam1[i].descrip;
                            lbIm4.ImageIndex = four1;
                            if (lsEdFam1[i].raEth.Equals(lsA[0].raEth))
                            {
                                dis2.Text = lsEdFam1[i].raEth;
                            }
                            else
                            {
                                dis2.Text = lsEdFam1[i].faTy;
                            }
                        }

                        break;
                    default:
                        int ter2 = (int)lsDis[0].idC - 1;
                        string sqldis1;
                        sqldis1 = $"select * from DisabilityTypes where idDi in (select distinct idDi from CharDis where idDi in (select idDi from AvDis where username = '{lsA[0].username}') and idC = '{ter2 + 1}')";
                        List<DisabilityType> lsDisa1 = context.DisabilityTypes.SqlQuery(sqldis1).ToList();

                        lb3.Text = lsDis[0].descrip;
                        lbIm3.ImageIndex = ter2;
                        dis1.Text = lsDisa1[0].nombre;
                        int four2 = (int)lsDis[1].idC - 1;
                        string sqldis2;
                        sqldis2 = $"select * from DisabilityTypes where idDi in (select distinct idDi from CharDis where idDi in (select idDi from AvDis where username = '{lsA[0].username}') and idC = '{four2 + 1}')";
                        List<DisabilityType> lsDisa2 = context.DisabilityTypes.SqlQuery(sqldis2).ToList();

                        lb4.Text = lsDis[1].descrip;
                        lbIm4.ImageIndex = four2;
                        dis2.Text = lsDisa2[0].nombre;
                        int Et2;
                        if ((int)lsCEt[0].idC == (int)lsDis[0].idC || (int)lsCEt[0].idC == (int)lsDis[1].idC)
                        {
                            if ((int)lsCEt[1].idC == (int)lsDis[0].idC || (int)lsCEt[0].idC == (int)lsDis[1].idC)
                            {
                                Et2 = (int)lsCEt[2].idC - 1;
                                lb1.Text = lsCEt[2].descrip;
                                lbEth.Text = lsCEt[2].raEth;

                            }
                            else
                            {
                                Et2 = (int)lsCEt[1].idC - 1;
                                lb1.Text = lsCEt[1].descrip;
                                lbEth.Text = lsCEt[1].raEth;
                            }


                        }
                        else
                        {
                            Et2 = (int)lsCEt[0].idC - 1;
                            lb1.Text = lsCEt[0].descrip;
                            lbEth.Text = lsCEt[0].raEth;
                        }
                        lbIm1.ImageIndex = Et2;
                        int Fam2;
                        if ((int)lsCFam[0].idC == (int)lsCEt[0].idC || (int)lsCFam[0].idC == (int)lsCEt[1].idC || (int)lsCFam[0].idC == Et2 + 1)
                        {
                            if ((int)lsCFam[1].idC == (int)lsCEt[0].idC || (int)lsCFam[0].idC == (int)lsCEt[1].idC || (int)lsCFam[1].idC == Et2 + 1)
                            {
                                if ((int)lsCFam[1].idC == (int)lsCEt[0].idC || (int)lsCFam[0].idC == (int)lsCEt[1].idC || (int)lsCFam[1].idC == Et2 + 1)
                                {
                                    Fam2 = (int)lsCFam[3].idC - 1;
                                    lb2.Text = lsCFam[3].descrip;
                                    lbFam.Text = lsCFam[3].faTy;
                                }
                                else
                                {
                                    Fam2 = (int)lsCFam[2].idC - 1;
                                    lb2.Text = lsCFam[2].descrip;
                                    lbFam.Text = lsCFam[2].faTy;
                                }

                            }
                            else
                            {
                                Fam2 = (int)lsCFam[1].idC - 1;
                                lb2.Text = lsCFam[1].descrip;
                                lbFam.Text = lsCFam[1].faTy;
                            }
                        }
                        else
                        {
                            Fam2 = (int)lsCFam[0].idC - 1;
                            lb2.Text = lsCFam[0].descrip;
                            lbFam.Text = lsCFam[0].faTy;
                        }

                        lbIm2.ImageIndex = Fam2;

                        break;


                }

            }

        }     
    }
}

