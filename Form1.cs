using DBUtil;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace LiveChartsAPI
{
    public partial class Form1 : Form
    {
        OracleConnection conn;
        int total = 0;
        bool lineChartSelected = false;
        public Form1()
        {
            InitializeComponent();
            conn = DBUtils.GetDBConnection(txtUsername.Text, txtPassword.Text);
            Start();
            InitializeDashboard();

            FillPieSlicer();
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;


            FillLineSlicer();

            //Angular
            FillCombowithProducts();

        }

        void FillLineSlicer()
        {

            var ds = new DataSet();
            var sql = " select distinct extract(year from order_date) as YEAR from orders;";
            ds = DBUtils.GetSQLDataSet(sql, conn);


            comboBox3.DataSource = ds.Tables[0];
            comboBox3.DisplayMember = "YEAR";
            comboBox3.SelectedIndex = 0;

        }

        void FillPieSlicer()
        {
            try
            {
                var ds = new DataSet();
                var sql = " select * from lkup_years_for_orders;";
                ds = DBUtils.GetSQLDataSet(sql, conn);

                comboBox1.DataSource = ds.Tables[0];
                comboBox1.DisplayMember = "YEAR";
                comboBox1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Slicer error: " + ex.ToString());
            }

        }

        void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PieDisplay(((ComboBox)sender).Text);
        }

        void InitializeDashboard()
        {
            angularGauge1.Hide(); //Hide angular chart on form load for formatting
            angularGauge2.Hide();

        }

        //Login
        private void button1_Click(object sender, EventArgs e)
        {
            //Start();
        }

        void Start()
        {
            conn.Open();
            conn.Close();


            lblStatus.Text = "Connected";
            //button1.Enabled = false;
        }

        void Display()
        {

            cartesianChart1.Show();
            cartesianChart1.Series.Clear();

            SeriesCollection sc = new SeriesCollection();
            sc.Add(
            new LineSeries
            {
                Title = "2017",
                Values = new ChartValues<double> { 125, 230, 32, 90 },
                DataLabels = true
            }
            );
            cartesianChart1.Series = sc;
            cartesianChart1.AxisX.Add(new Axis
            {
                MinValue = 0,
                MaxValue = 4,
                Labels = new ChartValues<string> { "Jan", "Feb", "March", "April" },
                Separator = new Separator
                {
                    Step = 1,
                    IsEnabled = false
                }
            });
        }


        private void button2_Click(object sender, EventArgs e)
        {
            cartesianChart1.Show();
            cartesianChart1.Series.Clear();

            var sc = new SeriesCollection();
            sc.Add(
            new LineSeries
            {
                Title = "2017",
                Values = new ChartValues<double> { 125, 230, 32, 90 },
                DataLabels = true

            }
            );
            sc.Add(new LineSeries
            {
                Title = "2018",
                Values = new ChartValues<double> { 10, 50, 350, 320 },
                DataLabels = true
            });
            cartesianChart1.Series = sc;
            cartesianChart1.AxisX.Add(new Axis
            {
                MinValue = 0,
                MaxValue = 500,
                Labels = new ChartValues<string> { "Q1", "Q2", "Q3", "Q4" },
                Separator = new Separator
                {
                    Step = 100,
                    IsEnabled = false
                }
            });

        }

        //Pie chart
        private void button5_Click(object sender, EventArgs e)
        {

        }


        //Try where all
        void PieDisplay(string year = null)
        {

            try
            {

                var ds = new DataSet();
                var sql = new StringBuilder();
                sql.Append("select company_name ,count(order_id) as Amount ,Extract(Year from shipped_date) as Year ");
                sql.Append("from orders, shippers ");
                sql.Append("where orders.SHIP_VIA = shippers.shipper_id and ");
                sql.AppendFormat("Extract(Year from shipped_date) = {0} ", year);
                sql.Append("group by company_name,Extract(Year from shipped_date)");


                ds = DBUtils.GetSQLDataSet(sql.ToString(), conn);
                pieChart1 = DBUtils.InitialisePieChart(pieChart1);

                //select column -2,3
                pieChart1 = DBUtils.GetPieChartDataSeries(pieChart1, 0, 1, 0, ds, "*");
                //pieChart1.Series
            }
            catch
            {

            }



            //view version
            ////try
            ////{
            //var ds = new DataSet();
            //var sql = string.Format("select * from vw_shipping_order_per_year where \"years\"={0}", year);

            //ds = DBUtils.GetSQLDataSet(sql.ToString(), conn);
            //pieChart1 = DBUtils.InitialisePieChart(pieChart1);

            ////select column -2,3
            //pieChart1 = DBUtils.GetPieChartDataSeries(pieChart1, 0, 1, 0, ds, "*");
            ////pieChart1.Series
            ////}
            ////catch
            ////{

            ////}

            #region junk
            //var sc = new SeriesCollection
            //{
            //new PieSeries
            //{
            //Title = "Bananas",
            //Values = new ChartValues<double> { 50 },
            //DataLabels = true
            //},
            //new PieSeries
            //{
            //Title = "Apples",
            //Values = new ChartValues<double> { 50 },
            //DataLabels = true
            //},
            //new PieSeries
            //{
            //Title = "Pears",
            //Values = new ChartValues<double> { 30 },
            //DataLabels = true
            //},
            //new PieSeries
            //{
            //Title = "Bacon",
            //Values = new ChartValues<double> { 25 },
            //DataLabels = true
            //}
            //};
            //pieChart1.Series = sc;
            #endregion
        }


        //Column 1
        private void button3_Click(object sender, EventArgs e)
        {
            cartesianChart2.Show();
            cartesianChart2.Series.Clear();

            var sc = new SeriesCollection();
            sc.Add(
            new ColumnSeries
            {
                Title = "2017",
                Values = new ChartValues<double> { 125, 230, 32, 90 },
                DataLabels = true
            }
            );
            cartesianChart2.Series = sc;
            cartesianChart2.AxisX.Add(new Axis
            {
                MinValue = 0,
                MaxValue = 4,
                Labels = new ChartValues<string> { "Jan", "Feb", "March", "April" },
                Separator = new Separator
                {
                    Step = 1,
                    IsEnabled = false
                }
            });
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            populateinDataGrid("select * from customers;");
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            populateinDataGrid("select * from suppliers;");
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            populateinDataGrid("select * from products;");
        }

        void populateinDataGrid(string sql)
        {
            try
            {
                var ds = new DataSet();
                ds = DBUtils.GetSQLDataSet(sql, conn);

                dataGridView1.DataSource = ds.Tables[0];
            }
            catch
            {
                lblStatus.Text = "Error connecting";

            }
        }

        private void btnLineChart2_Click(object sender, EventArgs e)
        {
            BindLineChart(comboBox3.Text);
            lineChartSelected = true;
        }


        void BindLineChart(string year)
        {

            var sql = string.Empty;
            try
            {
                var ds = new DataSet();
                sql = string.Format("select p.product_name as \"Product\",sum(od.quantity) as \"Quantity\",extract(year from o.order_date) as \"Year\" from orders o,order_details"
                    + " od,products p where o.order_ID=od.order_ID and od.product_ID=p.product_ID "
                    + "and extract(year from o.order_date) = {0}"
                    + " group by  p.product_name, extract(year from o.order_date) order by extract(year from o.order_date)", year);


                ds = DBUtils.GetSQLDataSet(sql, conn);

                cartesianChart1 = DBUtils.InitialiseCartesianChart(cartesianChart1);

                //first series, ds, last arg : how many
                cartesianChart1 = DBUtils.GetLineChartSingleDataSeries(cartesianChart1, 0, "Product Name", 1, ds, "10");

                //amt- no:of values
                //0- Product name
                //1-unit_price

                //datavalue- plot against
            }
            catch (Exception ex)
            {
                lblStatus.Text = "ERROR: Loading " + sql;
                MessageBox.Show(ex.ToString());

            }
        }

        //Column chart 2
        private void btnColumnChart2_Click(object sender, EventArgs e)
        {
            var sql = string.Empty;
            try
            {
                var ds = new DataSet();
                sql = "select product_name,unit_price,units_in_stock from products order by unit_price desc";
                ds = DBUtils.GetSQLDataSet(sql, conn);

                cartesianChart2 = DBUtils.InitialiseCartesianChart(cartesianChart2);
                // cartesianChart2 = DBUtils.GetColumnChartSingleDataSeries(cartesianChart2, 0, "Unit Price", 1, ds, "10");
                cartesianChart2 = DBUtils.GetColumnChartDoubleDataSeries(cartesianChart2, 0, 1, 2, "$", "No:", ds, "5");

            }
            catch (Exception ex)
            {
                lblStatus.Text = "ERROR: Loading " + sql;
                MessageBox.Show(ex.ToString());

            }
        }

        //row chart 2
        private void btnRowChart2_Click(object sender, EventArgs e)
        {
            var sql = string.Empty;
            try
            {
                var ds = new DataSet();
                sql = "select product_name,unit_price,units_in_stock from products order by unit_price desc";
                ds = DBUtils.GetSQLDataSet(sql, conn);

                cartesianChart3 = DBUtils.InitialiseCartesianChart(cartesianChart3);
                //cartesianChart3 = DBUtils.GetRowChartSingleDataSeries(cartesianChart3, 0, "$", 1, ds, "10");
                cartesianChart3 = DBUtils.GetRowChartDoubleDataSeries(cartesianChart3, 0, 1, 2, "Price $", "No:of stock", ds, "10");


            }
            catch (Exception ex)
            {


            }
        }

        private void btnAngularChart2_Click(object sender, EventArgs e)
        {
            #region comments
            //1. Set bgcolor to any solid color
            //2. Hide Chart on form load

            // For plotting single value
            #endregion

            var sql = string.Empty;
            try
            {
                //var ds = new DataSet();
                //sql = "select units_in_stock from products where product_name='Chai'";
                //ds = DBUtils.GetSQLDataSet(sql, conn);

                //var dt = ds.Tables[0];
                //int angularValue = (int)dt.Rows[0][0];

                //DBUtils.SetAngularChart(angularGauge1, angularValue, 200);

                //angularGauge1.Show();

                Products_SpeedoMeter(comboBox2.Text);

            }
            catch (Exception ex)
            {

                lblStatus.Text = " ERROR: Loading " + sql;
                MessageBox.Show(ex.ToString());
            }
            conn.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PieDisplay(comboBox1.Text);
        }


        //Create slicer for angular- products

        bool changeProducts = false;
        string productName = string.Empty;

        void FillCombowithProducts()
        {
            try
            {
                var ds = new DataSet();
                var sql = " select distinct product_name as Product from products";
                ds = DBUtils.GetSQLDataSet(sql, conn);

                comboBox2.DataSource = ds.Tables[0];
                comboBox2.DisplayMember = "Product";
                comboBox2.SelectedIndex = 0;
                changeProducts = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Slicer error: " + ex.ToString());
            }

        }


        private void btnAngular_Click(object sender, EventArgs e)
        {
            if (changeProducts)
                Products_SpeedoMeter(comboBox2.Text);






        }


        private void Products_SpeedoMeter(string _productName)
        {
            try
            {
                DataSet ds = new DataSet();
                string sql = "SELECT product_name, units_in_stock, units_on_order"
                + " FROM products"
                + " WHERE product_name = '" + _productName + "'";
                ds = DBUtils.GetSQLDataSet(sql, conn);
                DataTable dt = ds.Tables[0]; // Create a datatable to get a value from the dataset
                int angularValue = int.Parse(dt.Rows[0][1].ToString()); // Get products value from the 1st row, 2nd col datatable
                angularGauge1 = DBUtils.SetAngularChart(angularGauge1, angularValue, 200); // Set the Angular Chart
                angularGauge1.Show(); // Display the chart

                int angularValue2 = int.Parse(dt.Rows[0][2].ToString()); // Get products value from the 1st row, 2nd col datatable
                angularGauge2 = DBUtils.SetAngularChart(angularGauge2, angularValue2, 200); // Set the Angular Chart
                angularGauge2.Show();


                total = angularValue + angularValue2;


                if (total > 0)
                    lblTotal.Text = string.Format("Total is {0}", total);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Products Lookup Combobox Failed: " + ex.ToString());
                // lblStatusMsg.Text = "ERROR: In Slicer Combobox";
            }
            conn.Close();
        }


        void Products_Speedo_Fill()
        {

            try
            {
                var ds = new DataSet();
                var sql = " select product_name as Product,units_in_stock " +
                          "from products " +
                          "where product_name='" + productName + "'";


                ds = DBUtils.GetSQLDataSet(sql, conn);

                angularGauge1 = DBUtils.InitialiseAngularGauge(angularGauge1);
                // angularGauge1=DBUtils.SetAngularChart(angularGauge1,)

            }
            catch (Exception ex)
            {
                MessageBox.Show("Slicer error: " + ex.ToString());
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (changeProducts)
                Products_SpeedoMeter(comboBox2.Text.Replace("'", "''"));



            // DBUtils.GetSQLQuoteInputFilter
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lineChartSelected)
                BindLineChart(comboBox3.Text);
        }
    }
}
