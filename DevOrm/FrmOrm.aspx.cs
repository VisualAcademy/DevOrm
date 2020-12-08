using Dapper;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace DevOrm
{
    public partial class FrmOrm : System.Web.UI.Page
    {
        private SqlConnection con;

        public FrmOrm()
        {
            //con = new SqlConnection(@"
            //    Data Source=(localdb)\MSSQLLocalDB;
            //    AttachDbFilename=|DataDirectory|DevOrm.mdf;
            //    Initial Catalog=DevOrm;
            //    Integrated Security=True;");
            con = new SqlConnection("server=(localdb)\\mssqllocaldb;database=DevOrm;Trusted_Connection=True;"); 
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                DisplayData();
            }
        }

        private void DisplayData()
        {
            string sql = @"
                    Select Id, Name, Description, Address, Phone, Coordinate 
                    From Warehouses Order By Id Desc";

            var list = con.Query<Warehouse>(sql).ToList();

            lstWarehouses.DataSource = list;
            lstWarehouses.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Warehouse model = new Warehouse();
            model.Name = txtName.Text;
            model.Description = txtDescription.Text;
            model.Address = txtAddress.Text;
            model.Phone = txtPhone.Text;
            model.Coordinate = String.Empty;

            string sql = @"
                Insert Into Warehouses 
                    (Name, Description, Address, Phone, Coordinate) 
                Values 
                    (@Name, @Description, @Address, @Phone, @Coordinate);";

            con.Execute(sql, model);

            DisplayData(); 
        }
    }

    public class Warehouse
    {
        public int Id { get; set; }
        public string Name  { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Coordinate { get; set; }
    }
}
