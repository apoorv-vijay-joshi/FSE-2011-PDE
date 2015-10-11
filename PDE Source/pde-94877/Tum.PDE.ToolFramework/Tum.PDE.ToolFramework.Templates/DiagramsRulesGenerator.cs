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
    using Microsoft.VisualStudio.Modeling;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System;
    
    
    #line 1 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "10.0.0.0")]
    public partial class DiagramsRulesGenerator : BaseTemplate
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
            this.Write("using DslModeling = global::Microsoft.VisualStudio.Modeling;\r\nusing DslEditorDiag" +
                    "rams = global::Tum.PDE.ToolFramework.Modeling.Diagrams;\r\n\r\n");
            
            #line 12 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"

	List<DomainClass> ruleOnElementsAdd = new List<DomainClass>();
	List<DomainRelationship> ruleOnLinksChange = new List<DomainRelationship>();
	List<DomainClass> ruleOnElementsDelete = new List<DomainClass>();
	
	foreach(DiagramClass diagram in this.MetaModel.AllDiagramClasses)
	{
		foreach (PresentationElementClass element in diagram.PresentationElements)
		{
        	if (element is ShapeClass)
        	{
				ShapeClass shapeClass = element as ShapeClass;
				DomainClass domainClass = shapeClass.DomainClass;

				if( domainClass == null )
					continue;
				
				if( !diagram.IsCustom )
				{
					if( !ruleOnElementsAdd.Contains(domainClass) )
						ruleOnElementsAdd.Add(domainClass);
					/*
					if (diagram.VisualizationBehavior != DiagramVisualizationBehavior.Extended)
					{
						if( !ruleOnElementsAdd.Contains(domainClass) )
							ruleOnElementsAdd.Add(domainClass);
					}
					else if( shapeClass.Parent != null )
					{
						if( !ruleOnElementsAdd.Contains(domainClass) )
							ruleOnElementsAdd.Add(domainClass);
					}
					*/
				}
				
				if( !ruleOnElementsDelete.Contains(domainClass) )
					ruleOnElementsDelete.Add(domainClass);
			}
		}
	}
	
	foreach(DomainClass d in ruleOnElementsAdd)
	{
		foreach(DomainRole rolesPlayed in d.RolesPlayed)
		{
			if( rolesPlayed.Relationship.Target == rolesPlayed && 
				rolesPlayed.Relationship is EmbeddingRelationship && 
				rolesPlayed.Relationship.InheritanceModifier != InheritanceModifier.Abstract)
			{
				if( !ruleOnLinksChange.Contains(rolesPlayed.Relationship))
					ruleOnLinksChange.Add(rolesPlayed.Relationship);
			}
		}
	}
	MetaModel dm = this.MetaModel;

            
            #line default
            #line hidden
            this.Write("namespace ");
            
            #line 68 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dm.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n");
            
            #line 70 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"

	if( CodeGenerationUtilities.NeedsShapeAddRule(dm) )
	{

            
            #line default
            #line hidden
            this.Write("\t/// <summary>\r\n    /// This AddRule is for monitoring element creation that we n" +
                    "eed to reflect\r\n\t/// onto the diagram surface by creating its specified shape cl" +
                    "ass.\r\n    /// </summary>\r\n");
            
            #line 78 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"

	foreach(AttributedDomainElement domainElement in ruleOnElementsAdd )
	{

            
            #line default
            #line hidden
            this.Write("\t[DslModeling::RuleOn(typeof(");
            
            #line 82 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(domainElement.GetFullName(true)));
            
            #line default
            #line hidden
            this.Write("), FireTime = DslModeling::TimeToFire.LocalCommit)]\r\n");
            
            #line 83 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"

	}

            
            #line default
            #line hidden
            this.Write("    public partial class ");
            
            #line 86 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));
            
            #line default
            #line hidden
            this.Write("ElementForShapesAdded : DslEditorDiagrams::ModelLinkAddRuleForShapes\r\n    {\r\n\t\t//" +
                    "/ <summary>\r\n        /// Constructor.\r\n        /// </summary>\r\n\t\tpublic ");
            
            #line 91 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));
            
            #line default
            #line hidden
            this.Write("ElementForShapesAdded() \r\n\t\t\t: base(");
            
            #line 92 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));
            
            #line default
            #line hidden
            this.Write("ElementForShapesFactoryHelper.Instance)\r\n\t\t{\r\n\t\t}\r\n\t\t\r\n\t\t/// <summary>\r\n        /" +
                    "// Helper class for model element creation.\r\n        /// </summary>\r\n        pub" +
                    "lic partial class ");
            
            #line 99 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));
            
            #line default
            #line hidden
            this.Write("ElementForShapesFactoryHelper : DslEditorDiagrams::ModelLinkAddRuleForShapes.Shap" +
                    "esFactoryHelper\r\n        {\r\n\t\t\tprivate static ");
            
            #line 101 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));
            
            #line default
            #line hidden
            this.Write("ElementForShapesFactoryHelper instanceHolder = null;\r\n\r\n    \t    /// <summary>\r\n " +
                    "   \t    /// Gets a singleton instance.\r\n    \t    /// </summary>\r\n    \t    public" +
                    " static ");
            
            #line 106 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));
            
            #line default
            #line hidden
            this.Write("ElementForShapesFactoryHelper Instance\r\n    \t    {\r\n    \t        get\r\n    \t      " +
                    "  {\r\n    \t            if (instanceHolder == null)\r\n    \t                instance" +
                    "Holder = new ");
            
            #line 111 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));
            
            #line default
            #line hidden
            this.Write(@"ElementForShapesFactoryHelper();

    	            return instanceHolder;
    	        }
    	    }
		}
	}

    /// <summary>
    /// This RolePlayerChangeRule is for monitoring embedding relationship changes that we need to reflect
	/// onto the diagram surface by removing and recreating its specified shape class if necessary.
    /// </summary>	
");
            
            #line 123 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"

	}
	if( CodeGenerationUtilities.NeedsShapeChangeRule(dm) )
	{
		
	foreach(AttributedDomainElement domainElement in ruleOnLinksChange )
	{

            
            #line default
            #line hidden
            this.Write("\t[DslModeling::RuleOn(typeof(");
            
            #line 131 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(domainElement.GetFullName(true)));
            
            #line default
            #line hidden
            this.Write("), FireTime = DslModeling::TimeToFire.LocalCommit)]\r\n");
            
            #line 132 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"

	}

            
            #line default
            #line hidden
            this.Write("    public partial class ");
            
            #line 135 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));
            
            #line default
            #line hidden
            this.Write("ElementForShapesChanged : DslEditorDiagrams::ModelLinkRolePlayerChangeRuleForShap" +
                    "es\r\n    {\r\n\t\t/// <summary>\r\n        /// Constructor.\r\n        /// </summary>\r\n\t\t" +
                    "public ");
            
            #line 140 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));
            
            #line default
            #line hidden
            this.Write("ElementForShapesChanged() \r\n\t\t\t: base(");
            
            #line 141 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));
            
            #line default
            #line hidden
            this.Write("RolePlayerChangeHelper.Instance)\r\n\t\t{\r\n\t\t}\t\r\n\t\t\r\n\t\t/// <summary>\r\n        /// Hel" +
                    "per class for model element creation.\r\n        /// </summary>\r\n        public pa" +
                    "rtial class ");
            
            #line 148 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));
            
            #line default
            #line hidden
            this.Write("RolePlayerChangeHelper : DslEditorDiagrams::ModelLinkRolePlayerChangeRuleForShape" +
                    "s.RolePlayerChangeHelper\r\n        {\r\n\t\t\tprivate static ");
            
            #line 150 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));
            
            #line default
            #line hidden
            this.Write("RolePlayerChangeHelper instanceHolder = null;\r\n\r\n    \t    /// <summary>\r\n    \t   " +
                    " /// Gets a singleton instance.\r\n    \t    /// </summary>\r\n    \t    public static" +
                    " ");
            
            #line 155 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));
            
            #line default
            #line hidden
            this.Write("RolePlayerChangeHelper Instance\r\n    \t    {\r\n    \t        get\r\n    \t        {\r\n  " +
                    "  \t            if (instanceHolder == null)\r\n    \t                instanceHolder " +
                    "= new ");
            
            #line 160 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));
            
            #line default
            #line hidden
            this.Write("RolePlayerChangeHelper();\r\n\r\n    \t            return instanceHolder;\r\n    \t      " +
                    "  }\r\n    \t    }\r\n\t\t\r\n\t\t\t/// <summary>\r\n        \t/// Constructor.\r\n        \t/// <" +
                    "/summary>\r\n\t\t\tpublic ");
            
            #line 169 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));
            
            #line default
            #line hidden
            this.Write("RolePlayerChangeHelper() \r\n\t\t\t\t: base(");
            
            #line 170 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));
            
            #line default
            #line hidden
            this.Write("ElementForShapesAdded.");
            
            #line 170 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));
            
            #line default
            #line hidden
            this.Write("ElementForShapesFactoryHelper.Instance,\r\n\t\t\t\t\t   ");
            
            #line 171 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));
            
            #line default
            #line hidden
            this.Write("ElementForShapesDeleted.");
            
            #line 171 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));
            
            #line default
            #line hidden
            this.Write("ShapeDeletionHelper.Instance)\t\t\r\n\t\t\t{\r\n\t\t\t}\r\n\t\t}\t\t\r\n\t}\t\r\n");
            
            #line 176 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"

	}
	
	if( CodeGenerationUtilities.NeedsShapeDeleteRule(dm) )
	{

            
            #line default
            #line hidden
            this.Write("\r\n\t/// <summary>\r\n    /// This DeleteRule is for monitoring element deletin that " +
                    "we need to reflect\r\n\t/// onto the diagram surface by creating its specified shap" +
                    "e class.\r\n    /// </summary>\r\n");
            
            #line 187 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"

	foreach(AttributedDomainElement domainElement in ruleOnElementsDelete )
	{

            
            #line default
            #line hidden
            this.Write("\t[DslModeling::RuleOn(typeof(");
            
            #line 191 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(domainElement.GetFullName(true)));
            
            #line default
            #line hidden
            this.Write("), FireTime = DslModeling::TimeToFire.LocalCommit)]\r\n");
            
            #line 192 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"

	}

            
            #line default
            #line hidden
            this.Write("    public partial class ");
            
            #line 195 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));
            
            #line default
            #line hidden
            this.Write("ElementForShapesDeleted : DslEditorDiagrams::ModelElementDeletingRuleForShapes\r\n " +
                    "   {\r\n\t\t/// <summary>\r\n        /// Constructor.\r\n        /// </summary>\r\n\t\tpubli" +
                    "c ");
            
            #line 200 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));
            
            #line default
            #line hidden
            this.Write("ElementForShapesDeleted() \r\n\t\t\t: base(");
            
            #line 201 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));
            
            #line default
            #line hidden
            this.Write("ShapeDeletionHelper.Instance)\r\n\t\t{\r\n\t\t}\r\n\t\t\r\n\t\t/// <summary>\r\n        /// Helper " +
                    "class for model element creation.\r\n        /// </summary>\r\n        public partia" +
                    "l class ");
            
            #line 208 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));
            
            #line default
            #line hidden
            this.Write("ShapeDeletionHelper : DslEditorDiagrams::ModelElementDeletingRuleForShapes.ShapeD" +
                    "eletionHelper\r\n        {\r\n\t\t\tprivate static ");
            
            #line 210 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));
            
            #line default
            #line hidden
            this.Write("ShapeDeletionHelper instanceHolder = null;\r\n\r\n    \t    /// <summary>\r\n    \t    //" +
                    "/ Gets a singleton instance.\r\n    \t    /// </summary>\r\n    \t    public static ");
            
            #line 215 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));
            
            #line default
            #line hidden
            this.Write("ShapeDeletionHelper Instance\r\n    \t    {\r\n    \t        get\r\n    \t        {\r\n    \t" +
                    "            if (instanceHolder == null)\r\n    \t                instanceHolder = n" +
                    "ew ");
            
            #line 220 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(dm.Name));
            
            #line default
            #line hidden
            this.Write("ShapeDeletionHelper();\r\n\r\n    \t            return instanceHolder;\r\n    \t        }" +
                    "\r\n    \t    }\r\n\t\t}\r\n\t}\r\n");
            
            #line 227 "J:\Uni\CC Processes\Werkzeuge\PDE 2\Tum.PDE.ToolFramework\Tum.PDE.ToolFramework.Templates\DiagramsRulesGenerator.tt"

	}
	

            
            #line default
            #line hidden
            this.Write("}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
