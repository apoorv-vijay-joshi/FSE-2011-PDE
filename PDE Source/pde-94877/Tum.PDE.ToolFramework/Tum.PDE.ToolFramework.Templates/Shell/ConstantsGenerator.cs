﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 10.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Tum.PDE.ToolFramework.Templates.Shell
{
    using Tum.PDE.LanguageDSL;
    using Microsoft.VisualStudio.Modeling;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System;
    
    
    #line 1 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\ConstantsGenerator.tt"
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "10.0.0.0")]
    public partial class ConstantsGenerator : BaseTemplate
    {
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
        public override string TransformText()
        {
            this.GenerationEnvironment = null;
            this.Write(" \r\n");
            
            #line 9 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\ConstantsGenerator.tt"

	string dslName = this.MetaModel.Name;

            
            #line default
            #line hidden
            this.Write("namespace ");
            
            #line 12 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\ConstantsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.MetaModel.Namespace));
            
            #line default
            #line hidden
            this.Write(@"
{
	/// <summary>
    /// Constants.
    /// </summary>
	internal static partial class Constants
	{
		/// <summary>
        /// Extension of this DSL.
        /// </summary>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage(""Microsoft.Performance"", ""CA1823:AvoidUnusedPrivateFields"")]
		public const string DesignerFileExtension = """);
            
            #line 23 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\ConstantsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.MetaModel.CustomExtension));
            
            #line default
            #line hidden
            this.Write("\";\r\n\t\t\r\n\t\t/// <summary>\r\n        /// Product name.\r\n        /// </summary>\r\n\t\t[gl" +
                    "obal::System.Diagnostics.CodeAnalysis.SuppressMessage(\"Microsoft.Performance\", \"" +
                    "CA1823:AvoidUnusedPrivateFields\")]\r\n\t\tpublic const string ProductName = @\"");
            
            #line 29 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\ConstantsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.MetaModel.ProductName.Replace("\"","\"\"")));
            
            #line default
            #line hidden
            this.Write("\";\r\n\t\t\r\n\t\t/// <summary>\r\n        /// Company name.\r\n        /// </summary>\r\n\t\t[gl" +
                    "obal::System.Diagnostics.CodeAnalysis.SuppressMessage(\"Microsoft.Performance\", \"" +
                    "CA1823:AvoidUnusedPrivateFields\")]\r\n\t\tpublic const string CompanyName = @\"");
            
            #line 35 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\ConstantsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.MetaModel.CompanyName.Replace("\"","\"\"")));
            
            #line default
            #line hidden
            this.Write("\";\r\n\t\t\r\n\t\t/// <summary>\r\n        /// Product version.\r\n        /// </summary>\r\n\t\t" +
                    "[global::System.Diagnostics.CodeAnalysis.SuppressMessage(\"Microsoft.Performance\"" +
                    ", \"CA1823:AvoidUnusedPrivateFields\")]\r\n\t\tpublic const string ProductVersion = \"");
            
            #line 41 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\ConstantsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.MetaModel.MajorVersion));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 41 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\ConstantsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.MetaModel.MinorVersion));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 41 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\ConstantsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.MetaModel.Build));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 41 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\ConstantsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.MetaModel.Revision));
            
            #line default
            #line hidden
            this.Write("\";\r\n\r\n\t\t/// <summary>\r\n        /// Package identifier \r\n        /// </summary>\r\n\t" +
                    "\tpublic const string ");
            
            #line 46 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\ConstantsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dslName));
            
            #line default
            #line hidden
            this.Write("PackageId = \"");
            
            #line 46 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\ConstantsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.MetaModel.PackageGuid));
            
            #line default
            #line hidden
            this.Write("\";\r\n\t\t\r\n\t\t/// <summary>\r\n        /// Editor factory identifier \r\n        /// </su" +
                    "mmary>\r\n\t\tpublic const string ");
            
            #line 51 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\ConstantsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dslName));
            
            #line default
            #line hidden
            this.Write("EditorFactoryId = \"");
            
            #line 51 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\ConstantsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.MetaModel.CustomExtensionGuid));
            
            #line default
            #line hidden
            this.Write("\";\r\n\t\t\r\n\t\t\r\n\t\t/// <summary>\r\n        /// Editor factory identifier \r\n        /// " +
                    "</summary>\r\n\t\tpublic const string DefaultDiagramExtension = \".diagram\";\r\n\t\t\r\n\t}\r" +
                    "\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
