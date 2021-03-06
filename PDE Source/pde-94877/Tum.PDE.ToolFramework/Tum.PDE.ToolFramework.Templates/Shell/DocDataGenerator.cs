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
    
    
    #line 1 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\DocDataGenerator.tt"
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "10.0.0.0")]
    public partial class DocDataGenerator : BaseTemplate
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
            
            #line 9 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\DocDataGenerator.tt"

	string dslName = this.MetaModel.Name;

            
            #line default
            #line hidden
            this.Write(@"
using DslShell = global::Microsoft.VisualStudio.Modeling.Shell;
using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslValidation = global::Microsoft.VisualStudio.Modeling.Validation;
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;
using VSShellInterop = global::Microsoft.VisualStudio.Shell.Interop;

using DslEditorModeling = global::Tum.PDE.ToolFramework.Modeling;
using DslEditorShell = global::Tum.PDE.ToolFramework.Modeling.Shell;

using global::System.Linq;

namespace ");
            
            #line 24 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\DocDataGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.MetaModel.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n\t/// <summary>\r\n\t/// Double-derived class to allow easier code customization" +
                    ".\r\n\t/// </summary>\r\n\tinternal partial class ");
            
            #line 29 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\DocDataGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dslName));
            
            #line default
            #line hidden
            this.Write("DocData : ");
            
            #line 29 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\DocDataGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dslName));
            
            #line default
            #line hidden
            this.Write("DocDataBase\r\n\t{\r\n\t\t/// <summary>\r\n\t\t/// Constructs a new ");
            
            #line 32 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\DocDataGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dslName));
            
            #line default
            #line hidden
            this.Write("DocData.\r\n\t\t/// </summary>\r\n        /// <param name=\"modelData\">Model data.</para" +
                    "m>\r\n        /// <param name=\"serviceProvider\">Service Provider</param>\r\n        " +
                    "/// <param name=\"editorFactoryId\">EditorFactory id.</param>\r\n\t\tpublic ");
            
            #line 37 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\DocDataGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dslName));
            
            #line default
            #line hidden
            this.Write("DocData(DslEditorModeling::ModelData modelData, global::System.IServiceProvider s" +
                    "erviceProvider, global::System.Guid editorFactoryId) \r\n\t\t\t: base(modelData, serv" +
                    "iceProvider, editorFactoryId)\r\n\t\t{\r\n\t\t}\r\n\t}\r\n\r\n\t/// <summary>\r\n\t/// Class which " +
                    "represents a ");
            
            #line 44 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\DocDataGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dslName));
            
            #line default
            #line hidden
            this.Write(" document in memory.\r\n\t/// </summary>\r\n\tinternal abstract partial class ");
            
            #line 46 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\DocDataGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dslName));
            
            #line default
            #line hidden
            this.Write("DocDataBase : DslEditorShell::ModelShellData\r\n\t{\r\n\t\t/// <summary>\r\n\t\t/// Construc" +
                    "ts a new ");
            
            #line 49 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\DocDataGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dslName));
            
            #line default
            #line hidden
            this.Write("DocDataBase.\r\n\t\t/// </summary>\r\n\t\t/// <param name=\"modelData\">Model data.</param>" +
                    "\r\n        /// <param name=\"serviceProvider\">Service Provider</param>\r\n        //" +
                    "/ <param name=\"editorFactoryId\">EditorFactory id.</param>\r\n\t\tprotected ");
            
            #line 54 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\Shell\DocDataGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dslName));
            
            #line default
            #line hidden
            this.Write("DocDataBase(DslEditorModeling::ModelData modelData, global::System.IServiceProvid" +
                    "er serviceProvider, global::System.Guid editorFactoryId)\r\n\t\t\t: base(modelData, s" +
                    "erviceProvider, editorFactoryId)\r\n\t\t{\r\n\t\t}\r\n\t}\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
