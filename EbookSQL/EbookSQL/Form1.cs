using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EbookSQL
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-1CNSP5FH\HUYCHE;Initial Catalog=Ebook;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Book ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        // // // //

        public void LoadDataKey()
        {
            command = connection.CreateCommand();
            command.CommandText = $@"select * from [dbo].[Book] where NameBook like '%{cmdKey.Text}%'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }

        // // // //

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDSach.ReadOnly = true;
            int i;
            i = dgv.CurrentRow.Index;
            IDSach.Text = dgv.Rows[i].Cells[0].Value.ToString();
            GiaGoc.Text = dgv.Rows[i].Cells[1].Value.ToString();
            TenSach.Text = dgv.Rows[i].Cells[2].Value.ToString();
            MoTaSach.Text = dgv.Rows[i].Cells[3].Value.ToString();
            GiaBan.Text = dgv.Rows[i].Cells[4].Value.ToString();
            TenTacGia.Text = dgv.Rows[i].Cells[5].Value.ToString();
            NamXuatBan.Text = dgv.Rows[i].Cells[6].Value.ToString();
            NamBan.Text = dgv.Rows[i].Cells[7].Value.ToString();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = $@"insert into [dbo].[Book]
                                   ([IDBook]
                                   ,[CurrentBookPrice]
                                   ,[NameBook]
                                   ,[BookSummary]
                                   ,[BookPrice]
                                   ,[BNamePublisher]
                                   ,[PublisherYear]
                                   ,[PublisherTime])
		                            values( '{IDSach.Text}', '{ GiaGoc.Text }', '{TenSach.Text}', '{MoTaSach.Text }', '{GiaBan.Text }', '{ TenTacGia.Text }', '{ NamXuatBan.Text }', '{ NamBan.Value:yyyy/MM/dd}')";
            command.ExecuteNonQuery();
            loadData();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = $@"update [dbo].[Book] set CurrentBookPrice = '{ GiaGoc.Text }', NameBook = '{TenSach.Text}', BookSummary = '{MoTaSach.Text }', BookPrice = '{GiaBan.Text }', BNamePublisher = '{ TenTacGia.Text }', PublisherYear = '{ NamXuatBan.Text }', PublisherTime = '{ NamBan.Value:yyyy/MM/dd}' where IDBook = '{IDSach.Text}'";                      
            command.ExecuteNonQuery();
            loadData();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = $@"delete from [dbo].[Book] where IDBook = '{IDSach.Text }'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void bt_khoitao_Click(object sender, EventArgs e)
        {
            IDSach.Text = "";
            TenSach.Text = "";
            GiaGoc.Text = "";
            MoTaSach.Text = "";
            GiaBan.Text = "";
            TenTacGia.Text = "";
            NamXuatBan.Text = "";
        }

        private void TimSach_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdTim_Click(object sender, EventArgs e)
        {
            LoadDataKey();
        }

        private void deleteTim_Click(object sender, EventArgs e)
        {
            cmdKey.Text = "";
        }
    }
}
