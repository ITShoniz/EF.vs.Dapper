using DevExpress.Xpf.Charts;
using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace ORMS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
      
        private void btnEF_Click(object sender, RoutedEventArgs e)
        {
            Chart.Series[0].Points.Clear();
            Benchmark<EntityFreamwork6Repository.Order> benchmark = new Benchmark<EntityFreamwork6Repository.Order>();
            var BenchmarkTime = benchmark.GetBench(new EntityFreamwork6Repository.OrderRepository(),int.Parse(txtTop.Text));
            Chart.Series[0].Points.Add(new SeriesPoint("FirstLoad", BenchmarkTime));
            BenchmarkTime = benchmark.GetBench(new EntityFreamwork6Repository.OrderRepository(), int.Parse(txtTop.Text));
            Chart.Series[0].Points.Add(new SeriesPoint("Secend Time", BenchmarkTime));
            BenchmarkTime = benchmark.GetBench(new EntityFreamwork6Repository.OrderRepository(), int.Parse(txtTop.Text));
            Chart.Series[0].Points.Add(new SeriesPoint("Third Time", BenchmarkTime));
        }
        private void btnEFAsync_Click(object sender, RoutedEventArgs e)
        {
            Chart.Series[1].Points.Clear();
            Benchmark<EntityFreamwork6Repository.Order> benchmark = new Benchmark<EntityFreamwork6Repository.Order>();
            var BenchmarkTime = benchmark.GetBench(new EntityFreamwork6Repository.OrderRepositoryAsno(), int.Parse(txtTop.Text));
            Chart.Series[1].Points.Add(new SeriesPoint("FirstLoad", BenchmarkTime));
            BenchmarkTime = benchmark.GetBench(new EntityFreamwork6Repository.OrderRepositoryAsno(), int.Parse(txtTop.Text));
            Chart.Series[1].Points.Add(new SeriesPoint("Secend Time", BenchmarkTime));
            BenchmarkTime = benchmark.GetBench(new EntityFreamwork6Repository.OrderRepositoryAsno(), int.Parse(txtTop.Text));
            Chart.Series[1].Points.Add(new SeriesPoint("Third Time", BenchmarkTime));
        }
        private void btnEFCash_Click(object sender, RoutedEventArgs e)
        {
            Chart.Series[2].Points.Clear();
            Benchmark<EntityFreamwork6Repository.Order> benchmark = new Benchmark<EntityFreamwork6Repository.Order>();
            var rep = new EntityFreamwork6Repository.OrderRepository();
            var BenchmarkTime = benchmark.GetBench(rep, int.Parse(txtTop.Text));
            Chart.Series[2].Points.Add(new SeriesPoint("FirstLoad", BenchmarkTime));
            BenchmarkTime = benchmark.GetBench(rep, int.Parse(txtTop.Text));
            Chart.Series[2].Points.Add(new SeriesPoint("Secend Time", BenchmarkTime));
            BenchmarkTime = benchmark.GetBench(rep, int.Parse(txtTop.Text));
            Chart.Series[2].Points.Add(new SeriesPoint("Third Time", BenchmarkTime));
        }
        private void btnEFCore_Click(object sender, RoutedEventArgs e)
        {
            Chart.Series[3].Points.Clear();
            Benchmark<EntityFreamworkCore.Orders> benchmark = new Benchmark<EntityFreamworkCore.Orders>();
            var BenchmarkTime = benchmark.GetBench(new EntityFreamworkCore.OrderRepository(), int.Parse(txtTop.Text));
            Chart.Series[3].Points.Add(new SeriesPoint("FirstLoad", BenchmarkTime));
            BenchmarkTime = benchmark.GetBench(new EntityFreamworkCore.OrderRepository(), int.Parse(txtTop.Text));
            Chart.Series[3].Points.Add(new SeriesPoint("Secend Time", BenchmarkTime));
            BenchmarkTime = benchmark.GetBench(new EntityFreamworkCore.OrderRepository(), int.Parse(txtTop.Text));
            Chart.Series[3].Points.Add(new SeriesPoint("Third Time", BenchmarkTime));


        }
        private void btnEFCoewAsyn_Click(object sender, RoutedEventArgs e)
        {
            Chart.Series[4].Points.Clear();
            Benchmark<EntityFreamworkCore.Orders> benchmark = new Benchmark<EntityFreamworkCore.Orders>();
            var BenchmarkTime = benchmark.GetBench(new EntityFreamworkCore.OrderRepositoryAsno(), int.Parse(txtTop.Text));
            Chart.Series[4].Points.Add(new SeriesPoint("FirstLoad", BenchmarkTime));
            BenchmarkTime = benchmark.GetBench(new EntityFreamworkCore.OrderRepositoryAsno(), int.Parse(txtTop.Text));
            Chart.Series[4].Points.Add(new SeriesPoint("Secend Time", BenchmarkTime));
            BenchmarkTime = benchmark.GetBench(new EntityFreamworkCore.OrderRepositoryAsno(), int.Parse(txtTop.Text));
            Chart.Series[4].Points.Add(new SeriesPoint("Third Time", BenchmarkTime));

        }
        private void btnEFCoerCash_Click(object sender, RoutedEventArgs e)
        {
            Chart.Series[5].Points.Clear();
            Benchmark<EntityFreamworkCore.Orders> benchmark = new Benchmark<EntityFreamworkCore.Orders>();
            var rep = new EntityFreamworkCore.OrderRepository();
            var BenchmarkTime = benchmark.GetBench(rep, int.Parse(txtTop.Text));
            Chart.Series[5].Points.Add(new SeriesPoint("FirstLoad", BenchmarkTime));
            BenchmarkTime = benchmark.GetBench(rep, int.Parse(txtTop.Text));
            Chart.Series[5].Points.Add(new SeriesPoint("Secend Time", BenchmarkTime));
            BenchmarkTime = benchmark.GetBench(rep, int.Parse(txtTop.Text));
            Chart.Series[5].Points.Add(new SeriesPoint("Third Time", BenchmarkTime));
        }
        private void btnDapper_Click(object sender, RoutedEventArgs e)
        {
            Chart.Series[6].Points.Clear();
            Benchmark<DapperRepository.Order> benchmark = new Benchmark<DapperRepository.Order>();
            var BenchmarkTime = benchmark.GetBench(new DapperRepository.OrderRepository(), int.Parse(txtTop.Text));
            Chart.Series[6].Points.Add(new SeriesPoint("FirstLoad", BenchmarkTime));
            BenchmarkTime = benchmark.GetBench(new DapperRepository.OrderRepository(), int.Parse(txtTop.Text));
            Chart.Series[6].Points.Add(new SeriesPoint("Secend Time", BenchmarkTime));
            BenchmarkTime = benchmark.GetBench(new DapperRepository.OrderRepository(), int.Parse(txtTop.Text));
            Chart.Series[6].Points.Add(new SeriesPoint("Third Time", BenchmarkTime));
        }
        private void btnADONetTable_Click(object sender, RoutedEventArgs e)
        {
            Chart.Series[7].Points.Clear();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection("data source=.;initial catalog=WideWorldImporters;integrated security=True;MultipleActiveResultSets=True;App=ADOTable");
            SqlCommand com = new SqlCommand("Select top "+ txtTop .Text+ " * From Sales.Orders ", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            sw.Stop();
            Chart.Series[7].Points.Add(new SeriesPoint("FirstLoad", sw.ElapsedMilliseconds));
            sw.Restart();
            dt = new DataTable();
            con = new SqlConnection("data source=.;initial catalog=WideWorldImporters;integrated security=True;MultipleActiveResultSets=True;App=ADOTable");
            com = new SqlCommand("Select top " + txtTop.Text + "  * From Sales.Orders ", con);
            da = new SqlDataAdapter(com);
            da.Fill(dt);
            sw.Stop();
            Chart.Series[7].Points.Add(new SeriesPoint("Secend Time", sw.ElapsedMilliseconds));
            sw.Restart();
            dt = new DataTable();
            con = new SqlConnection("data source=.;initial catalog=WideWorldImporters;integrated security=True;MultipleActiveResultSets=True;App=ADOTable");
            com = new SqlCommand("Select top " + txtTop.Text + "  * From Sales.Orders ", con);
            da = new SqlDataAdapter(com);
            da.Fill(dt);
            sw.Stop();
            Chart.Series[7].Points.Add(new SeriesPoint("Third Time", sw.ElapsedMilliseconds));

        }
        private void btnADONetHandedCode_Click(object sender, RoutedEventArgs e)
        {
            Chart.Series[8].Points.Clear();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            SqlConnection con = new SqlConnection("data source=.;initial catalog=WideWorldImporters;integrated security=True;MultipleActiveResultSets=True;App=ADOReader");
            SqlCommand com = new SqlCommand("Select  top " + txtTop.Text + " * From Sales.Orders ", con);
            con.Open();
            List<DapperRepository.Order> orders = new List<DapperRepository.Order>();
            SqlDataReader rd = com.ExecuteReader();
            GetOrderFromreader(rd);
            con.Close();
            sw.Stop();
            Chart.Series[8].Points.Add(new SeriesPoint("FirstLoad", sw.ElapsedMilliseconds));
            sw.Restart();
            con = new SqlConnection("data source=.;initial catalog=WideWorldImporters;integrated security=True;MultipleActiveResultSets=True;App=ADOReader");
            com = new SqlCommand("Select top " + txtTop.Text + "  * From Sales.Orders ", con);
            con.Open();
            rd = com.ExecuteReader();
            GetOrderFromreader(rd);
            con.Close();
            sw.Stop();
            Chart.Series[8].Points.Add(new SeriesPoint("Secend Time", sw.ElapsedMilliseconds));
            sw.Restart();
            con = new SqlConnection("data source=.;initial catalog=WideWorldImporters;integrated security=True;MultipleActiveResultSets=True;App=ADOReader");
            com = new SqlCommand("Select top " + txtTop.Text + "  * From Sales.Orders ", con);
            con.Open();
            rd = com.ExecuteReader();
            GetOrderFromreader(rd);
            con.Close();
            sw.Stop();
            Chart.Series[8].Points.Add(new SeriesPoint("Third Time", sw.ElapsedMilliseconds));
        }

        private void SimpleButton_Click_5(object sender, RoutedEventArgs e)
        {
            Chart.Series[9].Points.Clear();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            SqlConnection con = new SqlConnection("data source=.;initial catalog=WideWorldImporters;integrated security=True;MultipleActiveResultSets=True;App=ADOReader");
            SqlCommand com = new SqlCommand("Select top " + txtTop.Text + "  * From Sales.Orders ", con);
            con.Open();
            List<DapperRepository.Order> orders = new List<DapperRepository.Order>();
            SqlDataReader rd = com.ExecuteReader();
            var t = ConvertToObject<DapperRepository.Order>(rd);

            con.Close();
            sw.Stop();
            Chart.Series[9].Points.Add(new SeriesPoint("FirstLoad", sw.ElapsedMilliseconds));
            sw.Restart();
            con = new SqlConnection("data source=.;initial catalog=WideWorldImporters;integrated security=True;MultipleActiveResultSets=True;App=ADOReader");
            com = new SqlCommand("Select top " + txtTop.Text + "  * From Sales.Orders ", con);

            con.Open();
            rd = com.ExecuteReader();

            t = ConvertToObject<DapperRepository.Order>(rd);

            con.Close();
            sw.Stop();
            Chart.Series[9].Points.Add(new SeriesPoint("Secend Time", sw.ElapsedMilliseconds));
            sw.Restart();
            con = new SqlConnection("data source=.;initial catalog=WideWorldImporters;integrated security=True;MultipleActiveResultSets=True;App=ADOReader");
            com = new SqlCommand("Select  top " + txtTop.Text + " * From Sales.Orders ", con);

            con.Open();
            rd = com.ExecuteReader();

            t = ConvertToObject<DapperRepository.Order>(rd);

            con.Close();
            sw.Stop();
            Chart.Series[9].Points.Add(new SeriesPoint("Third Time", sw.ElapsedMilliseconds));
        }
        private void SimpleButton_Click_6(object sender, RoutedEventArgs e)
        {
            Chart.Series[10].Points.Clear();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            SqlConnection con = new SqlConnection("data source=.;initial catalog=WideWorldImporters;integrated security=True;MultipleActiveResultSets=True;App=ADOReader");
            SqlCommand com = new SqlCommand("Select top " + txtTop.Text + "  * From Sales.Orders ", con);
            con.Open();
            List<DapperRepository.Order> orders = new List<DapperRepository.Order>();
            SqlDataReader rd = com.ExecuteReader();
            var t = ConvertToObjectAsync<DapperRepository.Order>(rd);

            t.AsParallel().ForAll(item => { orders.Add(item); });
            con.Close();
            sw.Stop();
            Chart.Series[10].Points.Add(new SeriesPoint("FirstLoad", sw.ElapsedMilliseconds));
            sw.Restart();
            con = new SqlConnection("data source=.;initial catalog=WideWorldImporters;integrated security=True;MultipleActiveResultSets=True;App=ADOReader");
            com = new SqlCommand("Select top " + txtTop.Text + "  * From Sales.Orders ", con);

            con.Open();
            rd = com.ExecuteReader();

            t = ConvertToObjectAsync<DapperRepository.Order>(rd);
            t.AsParallel().ForAll(item => { orders.Add(item); });
            con.Close();
            sw.Stop();
            Chart.Series[10].Points.Add(new SeriesPoint("Secend Time", sw.ElapsedMilliseconds));
            sw.Restart();
            con = new SqlConnection("data source=.;initial catalog=WideWorldImporters;integrated security=True;MultipleActiveResultSets=True;App=ADOReader");
            com = new SqlCommand("Select top " + txtTop.Text + "  * From Sales.Orders ", con);

            con.Open();
            rd = com.ExecuteReader();

            t = ConvertToObjectAsync<DapperRepository.Order>(rd);
            t.AsParallel().ForAll(item => { orders.Add(item); });

            con.Close();
            sw.Stop();
            Chart.Series[10].Points.Add(new SeriesPoint("Third Time", sw.ElapsedMilliseconds));
        }
        private void SimpleButton_Click_8(object sender, RoutedEventArgs e)
        {
            Chart.Series[11].Points.Clear();
            MethodInfo function = CreateFunction();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            SqlConnection con = new SqlConnection("data source=.;initial catalog=WideWorldImporters;integrated security=True;MultipleActiveResultSets=True;App=ADOReader");
            SqlCommand com = new SqlCommand("Select top " + txtTop.Text + "  * From Sales.Orders ", con);
            con.Open();
            List<DapperRepository.Order> orders = new List<DapperRepository.Order>();
            SqlDataReader rd = com.ExecuteReader();

            var result = function.Invoke(null, new object[] { rd });

            con.Close();
            sw.Stop();
            Chart.Series[11].Points.Add(new SeriesPoint("FirstLoad", sw.ElapsedMilliseconds));
            sw.Restart();
            con = new SqlConnection("data source=.;initial catalog=WideWorldImporters;integrated security=True;MultipleActiveResultSets=True;App=ADOReader");
            com = new SqlCommand("Select top " + txtTop.Text + "  * From Sales.Orders ", con);

            con.Open();
            rd = com.ExecuteReader();

            result = function.Invoke(null, new object[] { rd });
            con.Close();
            sw.Stop();
            Chart.Series[11].Points.Add(new SeriesPoint("Secend Time", sw.ElapsedMilliseconds));
            sw.Restart();
            con = new SqlConnection("data source=.;initial catalog=WideWorldImporters;integrated security=True;MultipleActiveResultSets=True;App=ADOReader");
            com = new SqlCommand("Select top " + txtTop.Text + "   * From Sales.Orders ", con);

            con.Open();
            rd = com.ExecuteReader();

            result = function.Invoke(null, new object[] { rd });

            con.Close();
            sw.Stop();
            Chart.Series[11].Points.Add(new SeriesPoint("Third Time", sw.ElapsedMilliseconds));
        }
        public List<DapperRepository.Order> GetOrderFromreader(SqlDataReader datareader)
        {
            List<DapperRepository.Order> orders = new List<DapperRepository.Order>();

            while (datareader.Read())
            {
                DapperRepository.Order o = new DapperRepository.Order();
                o.OrderID = datareader.GetInt32(0);
                o.CustomerID = datareader.GetInt32(1);
                o.SalespersonPersonID = datareader.GetInt32(2);
                o.PickedByPersonID = datareader.IsDBNull(3) ? null : (int?)datareader.GetInt32(3);
                o.ContactPersonID = datareader.GetInt32(4);
                o.BackorderOrderID = datareader.IsDBNull(5) ? null : (int?)datareader.GetInt32(5);
                o.OrderDate = (DateTime)datareader.GetValue(6);
                o.ExpectedDeliveryDate = (DateTime)datareader.GetValue(7);
                o.CustomerPurchaseOrderNumber = datareader.GetString(8);
                o.IsUndersupplyBackordered = datareader.GetBoolean(9);
                o.Comments = datareader.IsDBNull(10) ? null : datareader.GetString(10);
                o.DeliveryInstructions = datareader.IsDBNull(11) ? null : datareader.GetString(11);
                o.InternalComments = datareader.IsDBNull(12) ? null : datareader.GetString(12);
                o.PickingCompletedWhen = datareader.IsDBNull(12) ? null : (DateTime?)datareader.GetDateTime(13);
                o.LastEditedBy = datareader.GetInt32(14);
                o.LastEditedWhen = (DateTime)datareader.GetValue(15);
                orders.Add(o);
            }
            return orders;
        }
        public List<T> ConvertToObject<T>(SqlDataReader rd) where T : class, new()
        {
            List<T> ret = new List<T>();
            Type type = typeof(T);
            var members = type.GetMembers();
            var t = new T();
            while (rd.Read())
            {
                T valut = new T();
                for (int i = 0; i < rd.FieldCount; i++)
                {
                    if (!rd.IsDBNull(i))
                    {
                        string fieldName = rd.GetName(i);
                        valut.GetType().GetProperty(fieldName).SetValue(valut, rd.GetValue(i));

                    }
                }

                ret.Add(valut);
            }

            return ret;
        }

        public IEnumerable<T> ConvertToObjectAsync<T>(SqlDataReader rd) where T : class, new()
        {
            List<T> ret = new List<T>();
            Type type = typeof(T);
            var members = type.GetMembers();
            var t = new T();

            while (rd.Read())
            {
                T valut = new T();
                for (int i = 0; i < rd.FieldCount; i++)
                {
                    if (!rd.IsDBNull(i))
                    {
                        string fieldName = rd.GetName(i);
                        valut.GetType().GetProperty(fieldName).SetValue(valut, rd.GetValue(i));

                    }
                }

                yield return valut;
            }



        }
        public static MethodInfo CreateFunction()
        {
            string code = @"
   
               using System;
               using System.Collections.Generic;
               using System.Data;
               using System.Data.SqlClient;
               using System.Diagnostics;
               using System.Linq;
            
              namespace UserFunctions
                {     
                     public partial class Order
                       {
                        
                     
                     
                           public int OrderID { get; set; }
                           public int CustomerID { get; set; }
                           public int SalespersonPersonID { get; set; }
                           public Nullable<int> PickedByPersonID { get; set; }
                           public int ContactPersonID { get; set; }
                           public Nullable<int> BackorderOrderID { get; set; }
                           public System.DateTime OrderDate { get; set; }
                           public System.DateTime ExpectedDeliveryDate { get; set; }
                           public string CustomerPurchaseOrderNumber { get; set; }
                           public bool IsUndersupplyBackordered { get; set; }
                           public string Comments { get; set; }
                           public string DeliveryInstructions { get; set; }
                           public string InternalComments { get; set; }
                           public Nullable<System.DateTime> PickingCompletedWhen { get; set; }
                           public int LastEditedBy { get; set; }
                           public System.DateTime LastEditedWhen { get; set; }
                       }
                 public class Test
                       {                
                          public static List<Order> GetOrderFromreader(SqlDataReader datareader)
                              {
                                  List<Order> orders = new List<Order>();
                         
                                  while (datareader.Read())
                                  {
                                       Order o = new Order();
                                       o.OrderID = datareader.GetInt32(0);
                                       o.CustomerID = datareader.GetInt32(1);
                                       o.SalespersonPersonID = datareader.GetInt32(2);
                                       o.PickedByPersonID = datareader.IsDBNull(3) ? null : (int?)datareader.GetInt32(3);
                                       o.ContactPersonID = (int)datareader.GetInt32(4);
                                       o.BackorderOrderID = datareader.IsDBNull(5) ? null : (int?)datareader.GetInt32(5);
                                       o.OrderDate = (DateTime)datareader.GetValue(6);
                                       o.ExpectedDeliveryDate = (DateTime)datareader.GetValue(7);
                                       o.CustomerPurchaseOrderNumber = (string)datareader.GetString(8);
                                       o.IsUndersupplyBackordered = (bool)datareader.GetBoolean(9);
                                       o.Comments = datareader.IsDBNull(10) ? null : (string)datareader.GetString(10);
                                       o.DeliveryInstructions = datareader.IsDBNull(11) ? null : datareader.GetString(11);
                                       o.InternalComments = datareader.IsDBNull(12) ? null : datareader.GetString(12);
                                       o.PickingCompletedWhen = datareader.IsDBNull(12) ? null : (DateTime?)datareader.GetDateTime(13);
                                       o.LastEditedBy = (int)datareader.GetInt32(14);
                                       o.LastEditedWhen = (DateTime)datareader.GetValue(15);
                                       orders.Add(o);
                                   }
                                  return orders;
                             }
                       }
                 }
            ";

            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerParameters cm = new CompilerParameters();
            cm.ReferencedAssemblies.Add("System.dll");
            cm.ReferencedAssemblies.Add("System.Data.dll");
            cm.ReferencedAssemblies.Add("System.Linq.dll");
            CompilerResults results = provider.CompileAssemblyFromSource(cm, code);

            Type binaryFunction = results.CompiledAssembly.GetType("UserFunctions.Test");
            return binaryFunction.GetMethod("GetOrderFromreader");
        }
        private void SimpleButton_Click_7(object sender, RoutedEventArgs e)
        {
            Chart.Series[0].Points.Clear();
            Chart.Series[1].Points.Clear();
            Chart.Series[2].Points.Clear();
            Chart.Series[3].Points.Clear();
            Chart.Series[4].Points.Clear();
            Chart.Series[5].Points.Clear();
            Chart.Series[6].Points.Clear();
            Chart.Series[7].Points.Clear();
            Chart.Series[8].Points.Clear();
            Chart.Series[9].Points.Clear();
            Chart.Series[10].Points.Clear();
            Chart.Series[11].Points.Clear();
        }

    }
}
