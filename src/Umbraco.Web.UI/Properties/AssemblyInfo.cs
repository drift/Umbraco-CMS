using System.Reflection;
using System.Runtime.CompilerServices;

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//
[assembly: AssemblyTitle("Umbraco.Web.UI")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyProduct("Umbraco.Web.UI")]

//tg forcing .NET 2.0 security rules, since otherwise it wasn't possible to run in medium trust
//(got an inheritance security rules violated by type error)
[assembly: System.Security.SecurityRules(System.Security.SecurityRuleSet.Level1)]