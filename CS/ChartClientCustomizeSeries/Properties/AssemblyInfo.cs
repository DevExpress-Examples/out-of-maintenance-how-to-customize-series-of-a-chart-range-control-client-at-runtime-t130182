// Developer Express Code Central Example:
// How to bind a numeric chart range control client to a list of custom objects
// 
// This example shows how to bind a numeric chart range control client to a
// System.Collections.Generic.List containing NumericItem objects.
// 
// In order to
// provide data to a chart numeric range control client, you need to access the
// ChartRangeControlClientDataProvider object using the
// ChartRangeControlClientBase.DataProvider property and assign a data source to
// the ChartRangeControlClientDataProvider.DataSource property.
// 
// Each NumericItem
// object contains Argument, Value and Series properties, to which a numeric chart
// range control client is bound via its
// ChartRangeControlClientDataProvider.ArgumentDataMember,
// ChartRangeControlClientDataProvider.ValueDataMember, and
// ChartRangeControlClientDataProvider.SeriesDataMember (optional) properties. In
// addition, this example shows how to customize chart client common settings
// (e.g., change the numeric range, customize template view and grid options).
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=T125956

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("NumericChartClient")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("NumericChartClient")]
[assembly: AssemblyCopyright("Copyright ©  2014")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("76772831-c46d-4adf-8df2-7cf23754083a")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
