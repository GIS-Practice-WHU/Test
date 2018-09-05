using DevExpress.XtraCharts;
using DevExpress.XtraEditors.Controls;
using ESRI.ArcGIS.Geodatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form_ana : Form
    {
        DataTable open;
        DataTable popluation;
        DataTable land;
        DataTable economy;
        DataTable rainfail;
        List<int> ind = new List<int>();
        List<int> ser = new List<int>();
        public Form_ana(DataTable table_open, DataTable table_popluation, DataTable table_land, DataTable table_economy, DataTable table_rainfail)
        {
            InitializeComponent();
            open = table_open;
            popluation = table_popluation;
            land = table_land;
            economy = table_economy;
            rainfail = table_rainfail;
            SetTable(table_open, table_popluation, table_land, table_economy, table_rainfail);
            //tabNavigationPage1.PageText = "";
            //tabPane1.ima
            ind.Add(0);
        }
        public Form_ana()
        {
            
            InitializeComponent();
            tableset();
        }

        private void Form_ana_Load(object sender, EventArgs e)
        {
            
            // Add the chart to the form.
            //chartControl1.Dock = DockStyle.Fill;

        }
        private void SetTable(DataTable table_open, DataTable table_popluation, DataTable table_land, DataTable table_economy, DataTable table_rainfail)
        {
            Series series_sum_area = new Series("SUM", ViewType.Area);
            checkedListBoxControl1.Items.Add(new CheckedListBoxItem("SUM", true));
            for (int i = 0; i < table_open.Columns.Count; i++)
            {
                int sum = 0;
                if(table_open.Columns[i].ColumnName == "城市名")
                {
                    //checkedListBoxControl1.DataSource = table_open.Columns[i];
                    for (int j = 0; j < table_open.Rows.Count; j++)
                        checkedListBoxControl1.Items.Add(new CheckedListBoxItem(table_open.Rows[j][i].ToString(), false));
                }
                else if((table_open.Columns[i].ColumnName == "FID") || (table_open.Columns[i].ColumnName == "Shape") || (table_open.Columns[i].ColumnName == "NAME_1"))
                {
                    continue;
                }
                else
                {
                    for (int j = 0; j < table_open.Rows.Count; j++)
                    {
                        sum += Convert.ToInt16(table_open.Rows[j][i].ToString());
                    }
                    series_sum_area.Points.Add(new SeriesPoint(table_open.Columns[i].ColumnName, sum));

                }

            }
            series_sum_area.LegendText = "SUM";
            chartControl1.Series.Add(series_sum_area);
            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "受灾程度";
            chartControl1.Titles.Add(chartTitle1);

            

            Series series_first_bar = new Series("SUM", ViewType.Bar);
            for (int i = 0; i < table_open.Columns.Count; i++)
            {
                int sum = 0;
                if (table_open.Columns[i].ColumnName == "城市名")
                {
                    checkedListBoxControl1.DataSource = table_open.Columns[i];
                }
                else if ((table_open.Columns[i].ColumnName == "FID") || (table_open.Columns[i].ColumnName == "Shape") || (table_open.Columns[i].ColumnName == "NAME_1"))
                {
                    continue;
                }
                else
                {
                    for (int j = 0; j < table_open.Rows.Count; j++)
                    {
                        sum += Convert.ToInt16(table_open.Rows[j][i].ToString());
                    }
                    series_first_bar.Points.Add(new SeriesPoint(table_open.Columns[i].ColumnName, sum));

                }


            }
            series_first_bar.LegendText = "SUM";
            chartControl2.Series.Add(series_first_bar);
            ChartTitle chartTitle2 = new ChartTitle();
            chartTitle2.Text = "受灾的XX";
            chartControl2.Titles.Add(chartTitle2);

        }
        
        private void tableset()
        {
            Series series1 = new Series("Side-by-Side Bar Series 1", ViewType.Bar);
            series1.Points.Add(new SeriesPoint("A", 10));
            series1.Points.Add(new SeriesPoint("B", 12));
            series1.Points.Add(new SeriesPoint("C", 14));
            series1.Points.Add(new SeriesPoint("D", 17));
            series1.LegendText = "1_1";
            series1.ValueDataMembers[0] = "1_2";//纵坐标  


            // Create the second side-by-side bar series and add points to it.
            Series series2 = new Series("Side-by-Side Bar Series 2", ViewType.Bar);
            series2.Points.Add(new SeriesPoint("A", 15));
            series2.Points.Add(new SeriesPoint("B", 18));
            series2.Points.Add(new SeriesPoint("C", 25));
            series2.Points.Add(new SeriesPoint("D", 33));
            series2.LegendText = "2_1";
            series2.ValueDataMembers[0] = "2_2";//纵坐标  

            // Add the series to the chart.
            chartControl1.Series.Add(series1);
            chartControl1.Series.Add(series2);

            // Hide the legend (if necessary).
            //chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            // Rotate the diagram (if necessary).
            //((XYDiagram)sideBySideBarChart.Diagram).Rotated = true;

            // Add a title to the chart (if necessary).
            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "Side-by-Side Bar Chart";
            chartControl1.Titles.Add(chartTitle1);

        }
        public static DataTable ToDataTable(ITable mTable)
        {
            try
            {
                DataTable pTable = new DataTable();
                for (int i = 0; i < mTable.Fields.FieldCount; i++)
                {
                    pTable.Columns.Add(mTable.Fields.get_Field(i).Name);
                }
                ICursor pCursor = mTable.Search(null, false);
                IRow pRrow = pCursor.NextRow();
                while (pRrow != null)
                {
                    DataRow pRow = pTable.NewRow();
                    string[] StrRow = new string[pRrow.Fields.FieldCount];
                    for (int i = 0; i < pRrow.Fields.FieldCount; i++)
                    {
                        StrRow[i] = pRrow.get_Value(i).ToString();
                    }
                    pRow.ItemArray = StrRow;
                    pTable.Rows.Add(pRow);
                    pRrow = pCursor.NextRow();
                }
                return pTable;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private void chartControl2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxControl1_DisplayMemberChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxControl1_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxControl1_SelectedValueChanged(object sender, EventArgs e)
        {
            //checkedListBoxControl1.SelectedValue
        }

        private void checkedListBoxControl1_ValueMemberChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxControl1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBoxControl1_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {

            dic_con(e.Index, e.State == System.Windows.Forms.CheckState.Checked);

        }

        private void dic_con(int index, bool v)
        {
            if(v)
            {
                int temp = ind.Count;
                ind.Add(index);
                Series series = new Series(checkedListBoxControl1.Items[index].Value.ToString(), ViewType.Area);
                series.LegendText = checkedListBoxControl1.Items[index].Value.ToString();
                int i;
                for (i = 0; i < open.Rows.Count; i++)
                {
                    if (open.Rows[i][3].ToString() == checkedListBoxControl1.Items[index].Value.ToString())
                        break;
                }
                for (int j = 0; j < open.Columns.Count; j++)
                {
                    if (j == 3) continue;
                    if ((open.Columns[j].ColumnName == "FID") || (open.Columns[j].ColumnName == "Shape") || (open.Columns[j].ColumnName == "NAME_1"))
                    {
                        continue;
                    }
                    else
                    {
                        int V = Convert.ToInt16(open.Rows[i][j].ToString());
                        series.Points.Add(new SeriesPoint(open.Columns[j].ColumnName, V));
                    }
                        
                }
                chartControl1.Series.Add(series);

            }
            else
            {
                int i;
                for(i = 0; i<ind.Count; i++)
                {
                    if(ind[i] == index)
                    {
                        ind.Remove(index);
                        break;
                    }
                }
                chartControl1.Series.RemoveAt(i);

            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;
            for (int i = 0; i < checkedListBoxControl1.Items.Count; i++)
            {
                if (checkedListBoxControl1.Items[i].Value.ToString() == textBox1.Text)

                {
                    checkedListBoxControl1.SelectedIndex = i;
                    return;
                }
            }
        }
    }
}
