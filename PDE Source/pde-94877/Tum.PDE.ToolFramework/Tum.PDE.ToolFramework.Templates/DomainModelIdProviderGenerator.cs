// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 10.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Tum.PDE.ToolFramework.Templates
{
    using Tum.PDE.LanguageDSL;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System;
    
    
    #line 1 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "10.0.0.0")]
    public partial class DomainModelIdProviderGenerator : BaseTemplate
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
            this.Write("using DslModeling = global::Microsoft.VisualStudio.Modeling;\r\nusing DslEditorMode" +
                    "ling = global::Tum.PDE.ToolFramework.Modeling;\r\n\r\n");
            
            #line 11 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
 
GenerateDomainModelIdProvider(this.MetaModel);

            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        #line 14 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
 
public void GenerateDomainModelIdProvider(MetaModel dm)
{

        
        #line default
        #line hidden
        
        #line 17 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write("namespace ");

        
        #line default
        #line hidden
        
        #line 18 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(dm.Namespace));

        
        #line default
        #line hidden
        
        #line 18 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write("\r\n{\r\n\t/// <summary>\r\n\t/// This class provides an id generator to be used in the d" +
        "omain model.\r\n\t/// This is the concrete type of the double-derived implementatio" +
        "n.\r\n\t/// </summary>\r\n\tpublic partial class ");

        
        #line default
        #line hidden
        
        #line 24 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));

        
        #line default
        #line hidden
        
        #line 24 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write("DomainModelIdProvider : ");

        
        #line default
        #line hidden
        
        #line 24 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));

        
        #line default
        #line hidden
        
        #line 24 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write("DomainModelIdProviderBase\r\n\t{\r\n\t\t#region Singleton Instance\r\n\t\t/// <summary>\r\n\t\t/" +
        "// Singleton instance.\r\n\t\t/// </summary>\r\n\t\tprivate static ");

        
        #line default
        #line hidden
        
        #line 30 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));

        
        #line default
        #line hidden
        
        #line 30 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write("DomainModelIdProvider instance;\r\n\t\t/// <summary>\r\n\t\t/// Singleton instance.\r\n\t\t//" +
        "/ </summary>\r\n\t\t[global::System.Diagnostics.DebuggerBrowsable(global::System.Dia" +
        "gnostics.DebuggerBrowsableState.Never)] // Will trigger creation otherwise.\r\n\t\tp" +
        "ublic static ");

        
        #line default
        #line hidden
        
        #line 35 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));

        
        #line default
        #line hidden
        
        #line 35 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write("DomainModelIdProvider Instance\r\n\t\t{\r\n\t\t\t[global::System.Diagnostics.DebuggerStepT" +
        "hrough]\r\n\t\t\tget\r\n\t\t\t{\r\n\t\t\t\tif (");

        
        #line default
        #line hidden
        
        #line 40 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));

        
        #line default
        #line hidden
        
        #line 40 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write("DomainModelIdProvider.instance == null)\r\n\t\t\t\t\t");

        
        #line default
        #line hidden
        
        #line 41 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));

        
        #line default
        #line hidden
        
        #line 41 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write("DomainModelIdProvider.instance = new ");

        
        #line default
        #line hidden
        
        #line 41 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));

        
        #line default
        #line hidden
        
        #line 41 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write("DomainModelIdProvider();\r\n\t\t\t\treturn ");

        
        #line default
        #line hidden
        
        #line 42 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));

        
        #line default
        #line hidden
        
        #line 42 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write("DomainModelIdProvider.instance;\r\n\t\t\t}\r\n\t\t}\r\n\t\tprivate ");

        
        #line default
        #line hidden
        
        #line 45 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));

        
        #line default
        #line hidden
        
        #line 45 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write("DomainModelIdProvider(){}\r\n\t\t#endregion\r\n\t}\r\n\t\r\n\t/// <summary>\r\n\t/// This class p" +
        "rovides an id generator to be used in the domain model.\r\n\t/// This is the abstra" +
        "ct base of the double-derived implementation.\r\n\t/// </summary>\r\n\tpublic abstract" +
        " class ");

        
        #line default
        #line hidden
        
        #line 53 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));

        
        #line default
        #line hidden
        
        #line 53 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write(@"DomainModelIdProviderBase : DslEditorModeling::IModelElementIdProvider
	{
		private System.Collections.Generic.List<System.Guid> IDList;
		private System.Collections.Generic.List<System.Guid> ExcludedIDList;
	
		/// <summary>
		/// Constructor.
		/// </summary>
		protected ");

        
        #line default
        #line hidden
        
        #line 61 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));

        
        #line default
        #line hidden
        
        #line 61 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write("DomainModelIdProviderBase()\r\n\t\t{\r\n\t\t\tIDList = new System.Collections.Generic.List" +
        "<System.Guid>();\t\t\r\n\t\t\tExcludedIDList = new System.Collections.Generic.List<Syst" +
        "em.Guid>();\t\t\r\n\t\t}\r\n\t\t\r\n\t\t/// <summary>\r\n        /// Generates a new unique key." +
        "\r\n        /// </summary>\r\n        /// <returns>New Key as a System.Guid.</return" +
        "s>\r\n\t\tpublic virtual System.Guid GenerateNewKey()\r\n        {\r\n            System" +
        ".Guid guid = System.Guid.NewGuid();\r\n            while (HasKey(guid))\r\n         " +
        "   {\r\n                System.Windows.MessageBox.Show(\"!!! ID already used !!! Ne" +
        "w id will be generated\");\r\n                guid = System.Guid.NewGuid();\r\n      " +
        "      }\r\n            // IDList.Add(guid);  // no need to add here, just generate" +
        " new key\r\n\r\n            return guid;\r\n        }\r\n\r\n        /// <summary>\r\n      " +
        "  /// Adds a new key to the ID list. \r\n        /// </summary>\r\n        /// <para" +
        "m name=\"modelElement\">Domain model element to add the Id for.</param>\r\n        p" +
        "ublic virtual void AddKey(DslModeling::ModelElement modelElement)\r\n        {\r\n  " +
        "      \t//if( HasKey(modelElement.Id ))\r\n            //    throw new System.Argum" +
        "entException(\"Duplicate ID: modelElementId already in IDList for \" + modelElemen" +
        "t.ToString());\r\n\t\t\t\r\n\t\t\tif( modelElement is DslEditorModeling::IDableElement )  " +
        "          \r\n            \tIDList.Add(modelElement.Id);\r\n        }\r\n\t\t\r\n        //" +
        "/ <summary>\r\n        /// Removes a specific key.\r\n        /// </summary>\r\n      " +
        "  /// <param name=\"modelElement\">Domain model element to remove the key for.</pa" +
        "ram>\r\n        public virtual void RemoveKey(DslModeling::ModelElement modelEleme" +
        "nt)\r\n\t\t{\r\n\t\t\tRemoveKey(modelElement, new System.Collections.Generic.List<DslEdit" +
        "orModeling::IDomainModelServices>());\r\n\t\t}\r\n\t\t\r\n        /// <summary>\r\n        /" +
        "// Removes a specific key.\r\n        /// </summary>\r\n        /// <param name=\"mod" +
        "elElement\">Domain model element to remove the key for.</param>\r\n        /// <par" +
        "am name=\"servicesToDiscard\">Services to ignore.</param>\r\n        public virtual " +
        "bool RemoveKey(DslModeling::ModelElement modelElement, System.Collections.Generi" +
        "c.List<DslEditorModeling::IDomainModelServices> servicesToDiscard)\r\n\t\t{\r\n\t\t\t//if" +
        "( IDList.Contains(modelElement.Id) )\r\n\t\t\t//\tIDList.Remove(modelElement.Id);\r\n\t\t\t" +
        "try\r\n\t\t\t{\r\n\t\t\t\tif( modelElement is DslEditorModeling::IDableElement )\t\t\t\r\n\t\t\t\t\tI" +
        "DList.Remove(modelElement.Id);\r\n\t\t\t\t\t\r\n\t\t\t\treturn true;\r\n\t\t\t}\r\n\t\t\tcatch{}\t\t\r\n\t\t\t" +
        "\r\n\t\t\t// extern services\r\n\t\t\tSystem.Collections.Generic.List<DslEditorModeling::I" +
        "DomainModelServices> discard = new System.Collections.Generic.List<DslEditorMode" +
        "ling::IDomainModelServices>();\r\n\t\t\tdiscard.AddRange(servicesToDiscard);\r\n\t\t\tdisc" +
        "ard.Add(");

        
        #line default
        #line hidden
        
        #line 127 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));

        
        #line default
        #line hidden
        
        #line 127 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write("DomainModelServices.Instance);\r\n\r\n\t\t\tforeach(DslEditorModeling::IDomainModelServi" +
        "ces externService in ");

        
        #line default
        #line hidden
        
        #line 129 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));

        
        #line default
        #line hidden
        
        #line 129 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write("DomainModelExtensionServices.Instance.ExternServices)\r\n\t\t\t{\r\n\t\t\t\tif( discard.Cont" +
        "ains(externService) )\r\n\t\t\t\t\tcontinue;\r\n\t\t\t\r\n\t\t\t\tbool bRemoved = externService.El" +
        "ementIdProvider.RemoveKey(modelElement, discard);\r\n\t\t\t\tif( bRemoved )\r\n\t\t\t\t\tretu" +
        "rn true;\r\n\t\t\t}\r\n\t\t\r\n\t\t\treturn false;\r\n\t\t}\r\n\t\t\r\n\t\t /// <summary>\r\n        /// Get" +
        "s whether a certain key has already been assigned.\r\n        /// </summary>\r\n    " +
        "    /// <param name=\"modelElementId\">Domain model element Id.</param>\r\n        /" +
        "// <returns>True if the given id has already been assigned; false otherwise.</re" +
        "turns>\r\n        public virtual bool HasKey(System.Guid modelElementId)\r\n\t\t{\r\n\t\t\t" +
        "return HasKey(modelElementId, new System.Collections.Generic.List<DslEditorModel" +
        "ing::IDomainModelServices>());\r\n\t\t}\r\n\t\t\r\n        /// <summary>\r\n        /// Gets" +
        " whether a certain key has already been assigned.\r\n        /// </summary>\r\n     " +
        "   /// <param name=\"modelElementId\">Domain model element Id.</param>\r\n        //" +
        "/ <param name=\"servicesToDiscard\">Services to ignore.</param>\r\n        /// <retu" +
        "rns>True if the given id has already been assigned; false otherwise.</returns>\r\n" +
        "        public virtual bool HasKey(System.Guid modelElementId, System.Collection" +
        "s.Generic.List<DslEditorModeling::IDomainModelServices> servicesToDiscard)\r\n\t\t{\r" +
        "\n\t\t\tif( IDList.Contains(modelElementId) )\r\n\t\t\t\treturn true;\r\n\t\t\t\t\r\n\t\t\tif( Exclud" +
        "edIDList.Contains(modelElementId) )\r\n\t\t\t\treturn true;\r\n\t\t\r\n\t\t\t// extern services" +
        "\r\n\t\t\tSystem.Collections.Generic.List<DslEditorModeling::IDomainModelServices> di" +
        "scard = new System.Collections.Generic.List<DslEditorModeling::IDomainModelServi" +
        "ces>();\r\n\t\t\tdiscard.AddRange(servicesToDiscard);\r\n\t\t\tdiscard.Add(");

        
        #line default
        #line hidden
        
        #line 169 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));

        
        #line default
        #line hidden
        
        #line 169 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write("DomainModelServices.Instance);\r\n\r\n\t\t\tforeach(DslEditorModeling::IDomainModelServi" +
        "ces externService in ");

        
        #line default
        #line hidden
        
        #line 171 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));

        
        #line default
        #line hidden
        
        #line 171 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write(@"DomainModelExtensionServices.Instance.ExternServices)
			{
				if( discard.Contains(externService) )
					continue;
			
				bool bHasKey = externService.ElementIdProvider.HasKey(modelElementId, discard);
				if( bHasKey )
					return true;
			}
		
			return false;
		}
		
		/// <summary>
        /// Resets the id provider.
        /// </summary>
        public virtual void Reset()
		{
			Reset(new System.Collections.Generic.List<DslEditorModeling::IDomainModelServices>());
		}
		
        /// <summary>
        /// Resets the id provider.
        /// </summary>
        /// <param name=""servicesToDiscard"">Services to ignore.</param>
        public virtual void Reset(System.Collections.Generic.List<DslEditorModeling::IDomainModelServices> servicesToDiscard)
		{
			IDList.Clear();
			
			// extern services
			System.Collections.Generic.List<DslEditorModeling::IDomainModelServices> discard = new System.Collections.Generic.List<DslEditorModeling::IDomainModelServices>();
			discard.AddRange(servicesToDiscard);
			discard.Add(");

        
        #line default
        #line hidden
        
        #line 203 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));

        
        #line default
        #line hidden
        
        #line 203 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write("DomainModelServices.Instance);\r\n\r\n\t\t\tforeach(DslEditorModeling::IDomainModelServi" +
        "ces externService in ");

        
        #line default
        #line hidden
        
        #line 205 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));

        
        #line default
        #line hidden
        
        #line 205 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"
this.Write("DomainModelExtensionServices.Instance.ExternServices)\r\n\t\t\t{\r\n\t\t\t\tif( discard.Cont" +
        "ains(externService) )\r\n\t\t\t\t\tcontinue;\r\n\t\t\t\r\n\t\t\t\texternService.ElementIdProvider." +
        "Reset(discard);\r\n\t\t\t}\r\n\t\t}\r\n\t\t\r\n\t\t/// <summary>\r\n        /// Adds a property ass" +
        "ignment containing the new id value if there is non yet in the array.\r\n        /" +
        "// </summary>\r\n        /// <param name=\"propertyAssignments\">Element property as" +
        "signments.</param>\r\n        /// <returns>Element property assignments containing" +
        " an id property assignment.</returns>\r\n        public virtual DslModeling::Prope" +
        "rtyAssignment[] AssignId(DslModeling::PropertyAssignment[] propertyAssignments)\r" +
        "\n        {\r\n            bool bHasKey = false;\r\n            if (propertyAssignmen" +
        "ts != null)\r\n                foreach (DslModeling::PropertyAssignment p in prope" +
        "rtyAssignments)\r\n                    if (p.PropertyId == DslModeling::ElementFac" +
        "tory.IdPropertyAssignment)\r\n                    {\r\n                        bHasK" +
        "ey = true;\r\n                        break;\r\n                    }\r\n\r\n           " +
        " if (!bHasKey)\r\n            {\r\n                int length = 1;\r\n                " +
        "if (propertyAssignments != null)\r\n                    length += propertyAssignme" +
        "nts.Length;\r\n\r\n                DslModeling::PropertyAssignment[] propertyAssignm" +
        "entsWithKey = new DslModeling::PropertyAssignment[length];\r\n                prop" +
        "ertyAssignmentsWithKey[length-1] = new DslModeling::PropertyAssignment(DslModeli" +
        "ng::ElementFactory.IdPropertyAssignment,\r\n                    GenerateNewKey());" +
        "\r\n\r\n                if (propertyAssignments != null)\r\n                    for (i" +
        "nt i = 0; i < propertyAssignments.Length; ++i)\r\n                        property" +
        "AssignmentsWithKey[i] = propertyAssignments[i];\r\n\r\n                return proper" +
        "tyAssignmentsWithKey;\r\n            }\r\n            else\r\n                return p" +
        "ropertyAssignments;\r\n        }\r\n\t\t\r\n\t\t        /// <summary>\r\n        /// Adds a " +
        "property assignment containing the new id value if there is non yet in the array" +
        ".\r\n        /// </summary>\r\n        /// <returns>Element property assignments con" +
        "taining an id property assignment.</returns>\r\n        public virtual DslModeling" +
        "::PropertyAssignment[] CreateId()\r\n\t\t{\r\n\t\t\tDslModeling::PropertyAssignment[] pro" +
        "pertyAssignmentsWithKey = new DslModeling::PropertyAssignment[1];\r\n            p" +
        "ropertyAssignmentsWithKey[0] = new DslModeling::PropertyAssignment(DslModeling::" +
        "ElementFactory.IdPropertyAssignment,\r\n                    GenerateNewKey());\r\n\t\t" +
        "\treturn propertyAssignmentsWithKey;\r\n\t\t}\r\n\t}\r\n}\r\n\r\n");

        
        #line default
        #line hidden
        
        #line 264 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DomainModelIdProviderGenerator.tt"

}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
