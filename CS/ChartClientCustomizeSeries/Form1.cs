
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ChartClientCustomizeSeries {
    public partial class Form1 : Form {

        const int pointCount = 20;
        const int seriesCount = 3;
        Random rand = new Random();
        List<NumericItem> data = new List<NumericItem>();

        public Form1() {
            InitializeComponent();
            SetUpNumericChartRangeControlClient();
        }

        private void numericChartRangeControlClient1_CustomizeSeries(object sender, ClientDataSourceProviderCustomizeSeriesEventArgs e) {

            // Change the default Line view of the chart client to Area. 
            AreaChartRangeControlClientView areaView = new AreaChartRangeControlClientView();
            e.View = areaView;

            // Customize the Area view properties.
            areaView.AreaOpacity = 30;
            areaView.LineWidth = 1;
            areaView.ShowMarkers = true;
            areaView.MarkerColor = Color.Purple;
            areaView.MarkerSize = 3;

            // Change the Area series color.  
            if (e.DataSourceValue.ToString() == "Series0") {
                e.View.Color = Color.Red;
            }
            if (e.DataSourceValue.ToString() == "Series1") {
                e.View.Color = Color.Blue;
            }
            if (e.DataSourceValue.ToString() == "Series2") {
                e.View.Color = Color.Orange;
            }
        }

        private void SetUpNumericChartRangeControlClient() {

            // Assign a numeric chart client to the Range control. 
            rangeControl1.Client = numericChartRangeControlClient1;

            // Generate a list of NumericItem objects and bind the numeric chart client to it.
            numericChartRangeControlClient1.DataProvider.DataSource = GenerateNumericData();

            // Handle the CustomizeSeries event.
            numericChartRangeControlClient1.CustomizeSeries += numericChartRangeControlClient1_CustomizeSeries;

            // Specify data members to bind the chart client.         
            numericChartRangeControlClient1.DataProvider.ArgumentDataMember = "Argument";
            numericChartRangeControlClient1.DataProvider.ValueDataMember = "Value";
            numericChartRangeControlClient1.DataProvider.SeriesDataMember = "Series";

            // Customize the grid options of the numeric chart range control client.          
            numericChartRangeControlClient1.GridOptions.GridSpacing = 2;
            numericChartRangeControlClient1.GridOptions.SnapSpacing = 1;
        }

        List<NumericItem> GenerateNumericData() {

            for (int seriesIndex = 0; seriesIndex < seriesCount; seriesIndex++) {
                for (int i = 0; i < pointCount; i++) {
                    data.Add(new NumericItem() {
                        Argument = i,
                        Value = rand.Next(0, 30) + i,
                        Series = "Series" + seriesIndex.ToString()
                    });
                }
            }
            return data;
        }
    }

    public class NumericItem {
        public double Argument { get; set; }
        public double Value { get; set; }
        public string Series { get; set; }
    }
}