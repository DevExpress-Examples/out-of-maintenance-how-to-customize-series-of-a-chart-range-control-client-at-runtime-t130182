Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace ChartClientCustomizeSeries
	Partial Public Class Form1
		Inherits Form

		Private Const pointCount As Integer = 20
		Private Const seriesCount As Integer = 3
		Private rand As New Random()
		Private data As New List(Of NumericItem)()

		Public Sub New()
			InitializeComponent()
			SetUpNumericChartRangeControlClient()
		End Sub

		Private Sub numericChartRangeControlClient1_CustomizeSeries(ByVal sender As Object, ByVal e As ClientDataSourceProviderCustomizeSeriesEventArgs)

			' Change the default Line view of the chart client to Area. 
			Dim areaView As New AreaChartRangeControlClientView()
			e.View = areaView

			' Customize the Area view properties.
			areaView.AreaOpacity = 30
			areaView.LineWidth = 1
			areaView.ShowMarkers = True
			areaView.MarkerColor = Color.Purple
			areaView.MarkerSize = 3

			' Change the Area series color.  
			If e.DataSourceValue.ToString() = "Series0" Then
				e.View.Color = Color.Red
			End If
			If e.DataSourceValue.ToString() = "Series1" Then
				e.View.Color = Color.Blue
			End If
			If e.DataSourceValue.ToString() = "Series2" Then
				e.View.Color = Color.Orange
			End If
		End Sub

		Private Sub SetUpNumericChartRangeControlClient()

			' Assign a numeric chart client to the Range control. 
			rangeControl1.Client = numericChartRangeControlClient1

			' Generate a list of NumericItem objects and bind the numeric chart client to it.
			numericChartRangeControlClient1.DataProvider.DataSource = GenerateNumericData()

			' Handle the CustomizeSeries event.
			AddHandler numericChartRangeControlClient1.CustomizeSeries, AddressOf numericChartRangeControlClient1_CustomizeSeries

			' Specify data members to bind the chart client.         
			numericChartRangeControlClient1.DataProvider.ArgumentDataMember = "Argument"
			numericChartRangeControlClient1.DataProvider.ValueDataMember = "Value"
			numericChartRangeControlClient1.DataProvider.SeriesDataMember = "Series"

			' Customize the grid options of the numeric chart range control client.          
			numericChartRangeControlClient1.GridOptions.GridSpacing = 2
			numericChartRangeControlClient1.GridOptions.SnapSpacing = 1
		End Sub

		Private Function GenerateNumericData() As List(Of NumericItem)

			For seriesIndex As Integer = 0 To seriesCount - 1
				For i As Integer = 0 To pointCount - 1
					data.Add(New NumericItem() With {.Argument = i, .Value = rand.Next(0, 30) + i, .Series = "Series" & seriesIndex.ToString()})
				Next i
			Next seriesIndex
			Return data
		End Function
	End Class

	Public Class NumericItem
		Private privateArgument As Double
		Public Property Argument() As Double
			Get
				Return privateArgument
			End Get
			Set(ByVal value As Double)
				privateArgument = value
			End Set
		End Property
		Private privateValue As Double
		Public Property Value() As Double
			Get
				Return privateValue
			End Get
			Set(ByVal value As Double)
				privateValue = value
			End Set
		End Property
		Private privateSeries As String
		Public Property Series() As String
			Get
				Return privateSeries
			End Get
			Set(ByVal value As String)
				privateSeries = value
			End Set
		End Property
	End Class
End Namespace