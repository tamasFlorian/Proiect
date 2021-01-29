using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Proiect
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string connetionString;
        SqlConnection cnn;


        public MainWindow()
        {
            InitializeComponent();

            connetionString = @"Data Source=.\sqlexpress;Initial Catalog=FARMACIE;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            // MessageBox.Show("ok");
        }

        private void BtnAdauga_Click(object sender, RoutedEventArgs e)
        {
            String denumireComerciala = txtDenComerciala.Text;
            String substMedicamentoasa = txtSubst.Text;

            if (denumireComerciala != null && !denumireComerciala.Equals(""))
            {
                if (substMedicamentoasa != null && !substMedicamentoasa.Equals(""))
                {

                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "INSERT INTO [dbo].[Medicamente] ([strDenumireComerciala],[strSubstanta])" +
                        "VALUES('" + denumireComerciala + "','" + substMedicamentoasa + "')";
                    cmd.Connection = cnn;

                    //cnn.Open();
                    cmd.ExecuteNonQuery();
                    ///cnn.Close();
                    MessageBox.Show("Ati adaugat un medicament");
                }
            }
        }
        /*
       

        
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }*/

        private void clickBtnVizLista(object sender, RoutedEventArgs e)
        {


            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "Select [strDenumireComerciala] AS 'Denumire comerciala', [strSubstanta] AS 'Substanta medicamentoasa' from Medicamente";
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtMedicamente = new DataTable();
            sqlDataAdap.Fill(dtMedicamente);

            dataGridMedicam.ItemsSource = dtMedicamente.DefaultView;

        }

        private void btnEditPacienti1(object sender, RoutedEventArgs e)
        {

        }

        private void btnAdaugaPacienti1(object sender, RoutedEventArgs e)
        {
            String numePacient = txtPacienti.Text;

            if (numePacient != null && !numePacient.Equals(""))
            {

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO [dbo].[Pacienti] ([strPacient]) VALUES(' " + numePacient + "')";
                cmd.Connection = cnn;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Ati adaugat un pacient");
            }
        }
        /*
        private void btnAdaugaPacienti(object sender, RoutedEventArgs e)
        {

        }*/

        private void btnVizListaPacienti1(object sender, RoutedEventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "Select [strPacient] AS 'Pacienti' from Pacienti";
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtPacienti = new DataTable();
            sqlDataAdap.Fill(dtPacienti);
            dataGridMedicam.ItemsSource = dtPacienti.DefaultView;
        }

        private void btnStergePacienti1(object sender, RoutedEventArgs e)
        {

        }
        /*
private void BtnStergeReteta(object sender, RoutedEventArgs e)
{

}

private void clickBtnVizListaReteta(object sender, RoutedEventArgs e)
{
SqlCommand sqlCmd = new SqlCommand();
sqlCmd.Connection = cnn;
sqlCmd.CommandType = CommandType.Text;
sqlCmd.CommandText = "Select [strMedicament] AS 'Medicament' from Retete";
SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

DataTable dtMedicamente = new DataTable();
sqlDataAdap.Fill(dtMedicamente);
dataGridMedicam.ItemsSource = dtMedicamente.DefaultView;
}

private void btnAdaugaPacienti(object sender, RoutedEventArgs e)
{
String numePacient = txtPacienti.Text;

if (numePacient != null && !numePacient.Equals(""))
{
System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
cmd.CommandType = System.Data.CommandType.Text;
cmd.CommandText = "INSERT INTO [dbo].[Pacienti] ([strPacient]" +
"VALUES('" + numePacient + "')";
cmd.Connection = cnn;

//cnn.Open();
cmd.ExecuteNonQuery();
///cnn.Close();

}
}

private void btnAdaugaReteta(object sender, RoutedEventArgs e)
{
//int nrReteta = txtNrReteta.Text;
String medicament = txtMedicament.Text;

//if (nrReteta != null && !nrReteta.Equals(""))
//{
if (medicament != null && !medicament.Equals(""))
{

//Medicament medDeInserat = new Medicament(nrReteta, medicament);
System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
cmd.CommandType = System.Data.CommandType.Text;
cmd.CommandText = "INSERT INTO [dbo].[Retete] ([strMedicament])" +
"VALUES('" + medicament + "')";
cmd.Connection = cnn;

//cnn.Open();
cmd.ExecuteNonQuery();
///cnn.Close();
// }
}
}

private void btnVizListaPacienti(object sender, RoutedEventArgs e)
{
SqlCommand sqlCmd = new SqlCommand();
sqlCmd.Connection = cnn;
sqlCmd.CommandType = CommandType.Text;
sqlCmd.CommandText = "Select [strPacient] AS 'Pacienti' from Pacieti";
SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

DataTable dtMedicamente = new DataTable();
sqlDataAdap.Fill(dtMedicamente);
dataGridMedicam.ItemsSource = dtMedicamente.DefaultView;
}

private void BtnPacientiMedicam_Click(object sender, RoutedEventArgs e)
{
SqlCommand sqlCmd = new SqlCommand();
sqlCmd.Connection = cnn;
sqlCmd.CommandType = CommandType.Text;
sqlCmd.CommandText = "Select [strPacient] AS 'Pacienti', [strMedicament] AS 'Medicament' from Medicamente INNER JOIN Pacienti ";
SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

DataTable dtMedicamente = new DataTable();
sqlDataAdap.Fill(dtMedicamente);
dataGridMedicam.ItemsSource = dtMedicamente.DefaultView;
}

private void btnAdaugaRetetaa(object sender, RoutedEventArgs e)
{

}*/
        /*
                private void btnStergePacienti1(object sender, RoutedEventArgs e)
                {

                }
                */
        private void btnEditReteta1(object sender, RoutedEventArgs e)
        {

        }

        private void btnAdaugaReteta1(object sender, RoutedEventArgs e)
        {

            String medicament = txtMedicament.Text;
            String nrReteta = txtNrReteta.Text;

            if (medicament != null && !medicament.Equals(""))
            {
                if (nrReteta != null && !nrReteta.Equals(""))

                {
                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.Connection = cnn;
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = "Select [strDenumireComerciala] , [id_medicament] from [dbo].[Medicamente]";
                    SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                    DataTable dtMedicamente = new DataTable();
                    sqlDataAdap.Fill(dtMedicamente);

                    string med = dtMedicamente.Rows[0]["strDenumireComerciala"].ToString();
                    string idmed = dtMedicamente.Rows[0]["id_Medicament"].ToString();
                    if (med != null)
                    {

                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = "INSERT INTO [dbo].[Retete] ([strMedicament], [idReteta]) VALUES('" + medicament + "','" + nrReteta + "')";
                        cmd.Connection = cnn;

                        cmd.ExecuteNonQuery();

                    }
                    else
                    {
                        MessageBox.Show("Medicamentul nu se gaseste in tabela medicamente");
                    }
                }
            }
        }

        private void clickBtnVizListaReteta1(object sender, RoutedEventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "Select [strMedicament] AS 'Medicament' from Retete";
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtRetete = new DataTable();
            sqlDataAdap.Fill(dtRetete);
            dataGridMedicam.ItemsSource = dtRetete.DefaultView;
        }

        private void BtnStergeReteta1(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPacientiMedicam_Click1(object sender, RoutedEventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "Select [strPacient] AS 'Pacienti', [strMedicament] AS 'Medicament' from Pacienti INNER JOIN Retete  on Pacienti.idReteta=Retete.idReteta ";
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtMedicamentePacient = new DataTable();
            sqlDataAdap.Fill(dtMedicamentePacient);
            dataGridMedicam.ItemsSource = dtMedicamentePacient.DefaultView;
        }
        /*
        private void clickBtnMedicamReteta(object sender, RoutedEventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "Select [strPacient] AS 'Pacienti', [strMedicament] AS 'Medicament' from Pacienti INNER JOIN Retete  on Pacienti.idReteta=Retete.idReteta ";
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtMedicamenteReteta = new DataTable();
            sqlDataAdap.Fill(dtMedicamenteReteta);
            dataGridMedicam.ItemsSource = dtMedicamenteReteta.DefaultView;
        }/*
        void DisplayData()
        {
            cnn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Medicamente", cnn);
            adapt.Fill(dt);
            dataGridMedicam.ItemsSource = dt.DefaultView;
            cnn.Close();
        }
        void ClearData()
        {
            txtDenComerciala.Text = "";
            txtSubst.Text = "";
            id = 0;
        }
        private void dataGridMedicam_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(dataGridMedicam.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtDenComerciala.Text = dataGridMedicam.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSubst.Text = dataGridMedicam.Rows[e.RowIndex].Cells[2].Value.ToString();
        }*/
        private void BtnSterge_Click(object sender, RoutedEventArgs e)
        {/*
            if (id != 0)
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd = new SqlCommand("delete Medicamente where id=@id_medicament", cnn);
                cnn.Open();
                sqlCmd.Parameters.AddWithValue("@id_medicament", id);
                sqlCmd.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Record Deleted Successfully!");
                
                DisplayData();
                
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }*/
        }

        private void btnEdit(object sender, RoutedEventArgs e)
        {

        }

        private void btnEdit1(object sender, RoutedEventArgs e)
        {
            String denumireComerciala = txtDenComerciala.Text;
            String substMedicamentoasa = txtSubst.Text;
            String denumireComercialaNoua = txtDenComercialaNoua.Text;
            String substMedicamentoasaNoua = txtSubstNoua.Text;

            if (denumireComerciala != null && !denumireComerciala.Equals(""))
            {
                if (substMedicamentoasa != null && !substMedicamentoasa.Equals(""))
                {


                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "UPDATE [dbo].[Medicamente] SET [strDenumireComerciala] = '" + denumireComercialaNoua + "',[strSubstanta] = '" + substMedicamentoasaNoua +
                        "' WHERE [strDenumireComerciala] ='" + denumireComerciala + "' AND  [strSubstanta] ='" + substMedicamentoasa + "'";
                    cmd.Connection = cnn;

                    cmd.ExecuteNonQuery();

                }
            }

            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "Select [strPacient] AS 'Pacienti' from Pacienti";
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtPacienti = new DataTable();
            sqlDataAdap.Fill(dtPacienti);
            dataGridMedicam.ItemsSource = dtPacienti.DefaultView;
        }
        /*
        private void DataGridMedicam_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            id = Convert.ToInt32(dataGridMedicam.Items[].ToStringCells[0].Value.ToString());
            txtDenComerciala.Text = dataGridMedicam.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSubst.Text = dataGridMedicam.Rows[e.RowIndex].Cells[2].Value.ToString();
        }*/
        private void BtnMedicamReteta_Click(object sender, RoutedEventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "Select [strPacient] AS 'Pacienti', [strMedicament] AS 'Medicament' from Pacienti INNER JOIN Retete  on Pacienti.idReteta=Retete.idReteta ";
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtMedicamenteReteta = new DataTable();
            sqlDataAdap.Fill(dtMedicamenteReteta);
            dataGridMedicam.ItemsSource = dtMedicamenteReteta.DefaultView;
        }
    }
}