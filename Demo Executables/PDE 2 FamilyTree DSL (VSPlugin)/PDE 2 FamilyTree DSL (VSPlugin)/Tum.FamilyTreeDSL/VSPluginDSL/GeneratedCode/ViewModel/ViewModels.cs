 
using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslEditorModeling = global::Tum.PDE.ToolFramework.Modeling;
using DslEditorVisualization = global::Tum.PDE.ToolFramework.Modeling.Visualization;
using DslEditorViewModel = global::Tum.PDE.ToolFramework.Modeling.Visualization.ViewModel;
using DslEditorViewModelContracts = global::Tum.PDE.ToolFramework.Modeling.Visualization.Contracts.ViewModel;
using DslEditorViewModelData = global::Tum.PDE.ToolFramework.Modeling.Visualization.ViewModel.Data;
using DslEditorViewModelModelTree = global::Tum.PDE.ToolFramework.Modeling.Visualization.ViewModel.ModelTree;
using DslEditorViewModelPropertyGrid = global::Tum.PDE.ToolFramework.Modeling.Visualization.ViewModel.PropertyGrid;
using DslEditorViewModelServices = global::Tum.PDE.ToolFramework.Modeling.Visualization.ViewModel.Services;
using DslEditorViewDiagrams = global::Tum.PDE.ToolFramework.Modeling.Visualization.ViewModel.DiagramSurface;
using DslEditorCommands = Tum.PDE.ToolFramework.Modeling.Visualization.Commands;

using DslEditorShell = global::Tum.PDE.ToolFramework.Modeling.Shell;
using DslEditorViewShell = global::Tum.PDE.ToolFramework.Modeling.Visualization.Shell;
using DslEditorViewModelShell = global::Tum.PDE.ToolFramework.Modeling.Visualization.Shell.ViewModel;

namespace Tum.FamilyTreeDSL.ViewModel
{
	/// <summary>
	/// This class represents the main view model of the FamilyTreeDSL.
	/// 
	/// Double-derived class to allow easier code customization.
	/// </summary>
	public partial class FamilyTreeDSLMainViewModel : FamilyTreeDSLMainViewModelBase
	{
		#region Constructor
		/// <summary>
        /// Constuctor.
        /// </summary>
        /// <param name="modelData">Document data.</param>
		/// <param name="package">Package.</param>
        public FamilyTreeDSLMainViewModel(DslEditorModeling::ModelData modelData, DslEditorShell::ModelPackage package)
            : this(new FamilyTreeDSLViewModelStore(modelData), package)
        {
        }
		
		/// <summary>
        /// Constuctor.
        /// </summary>
        /// <param name="viewModelStore">View model store containing this view model.</param>
		/// <param name="package">Package.</param>
        public FamilyTreeDSLMainViewModel(FamilyTreeDSLViewModelStore viewModelStore, DslEditorShell::ModelPackage package)
            : base(viewModelStore, package)
        {
        }
		#endregion
	}
	
	/// <summary>
	/// This class represents the main view model of the FamilyTreeDSL.
	/// 
	/// This is the abstract base class.
	/// </summary>
	public abstract class FamilyTreeDSLMainViewModelBase : DslEditorViewModelShell::ShellMainViewModel
	{
		#region Constructor
		/// <summary>
        /// Constuctor.
        /// </summary>
        /// <param name="viewModelStore">View model store containing this view model.</param>
		/// <param name="package">Package.</param>
        protected FamilyTreeDSLMainViewModelBase(FamilyTreeDSLViewModelStore viewModelStore, DslEditorShell::ModelPackage package)
            : base(viewModelStore, package)
        {

        }
		#endregion
		
		#region Initialization
        /// <summary>
        /// This method is used to initialize the view model and can be overriden for customization.
        /// </summary>
        protected override void Initialize()
        {
			base.Initialize();
			RegisterImportedLibrariesRessources();
			
			// register services
			FamilyTreeDSLServiceRegistrar.Instance.RegisterServices(this.ViewModelStore);

			// ensure context menu provider are initialized
			if( Tum.FamilyTreeDSL.ViewModel.ModelTree.FamilyTreeDSLModelTreeContextMenuProvider.Instance == null )
				throw new System.ArgumentNullException("Context menu provider");
		

			foreach(DslEditorModeling::ModelContext modelContext in this.ModelData.AvailableModelContexts)
			{
				if( modelContext.Name == "DefaultContext")
				{
					DefaultContextModelContextViewModel mDefaultContext = new DefaultContextModelContextViewModel(this.ViewModelStore, modelContext, this);
					mDefaultContext.InitializeMC();
					this.AvailableModelModelContextViewModels.Add(mDefaultContext);
					this.SelectedModelContextViewModel = mDefaultContext;
				}
			}
			
			this.ModelTreeModel = new FamilyTreeDSLModelTreeViewModel(ViewModelStore as FamilyTreeDSLViewModelStore);
			AddViewModel(ModelTreeModel);

			this.ErrorListModel = new FamilyTreeDSLErrorListViewModel(ViewModelStore as FamilyTreeDSLViewModelStore);
			AddViewModel(ErrorListModel);

			this.PropertyGridModel = new FamilyTreeDSLPropertyGridViewModel(ViewModelStore as FamilyTreeDSLViewModelStore);
			AddViewModel(PropertyGridModel);

			this.DependenciesModel = new FamilyTreeDSLDependenciesViewModel(ViewModelStore as FamilyTreeDSLViewModelStore);
			AddViewModel(DependenciesModel);

			this.SearchModel = new FamilyTreeDSLSearchViewModel(ViewModelStore as FamilyTreeDSLViewModelStore);			
			AddViewModel(SearchModel);
			AddViewModel(SearchModel.SearchResultViewModel);	

			#region Credits + Further Readings
			this.CreditsViewModel = new DslEditorViewModelData::CreditsViewModel(this.ViewModelStore);
			this.FurtherReadingViewModel = new DslEditorViewModelData::FurtherReadingViewModel(this.ViewModelStore);

	
			#endregion
		}	
		
        /// <summary>
        /// Registers imported libraries main ressource dictionaries.
        /// </summary>
        protected virtual void RegisterImportedLibrariesRessources()
        {
            FamilyTreeDSLMainViewModelBase.RegisterImportedLibrariesRessources(new System.Collections.Generic.List<string>());
        }		
		
		/// <summary>
        /// Registers imported libraries main ressource dictionaries.
        /// </summary>
        /// <param name="handledLibraries">Already handled libraries.</param>
        public static void RegisterImportedLibrariesRessources(System.Collections.Generic.List<string> handledLibraries)
		{
			if( handledLibraries.Contains("FamilyTreeDSL") )
				return;
			else
				handledLibraries.Add("FamilyTreeDSL");
			
			System.Windows.Application.Current.Resources.MergedDictionaries.Add(new System.Windows.ResourceDictionary() 
            {
                Source = new System.Uri("pack://application:,,,/" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ";component/Resources.xaml") 
            });			
	
		}
		#endregion

		#region Methods
        /// <summary>
        /// Called after the document has been saved.
        /// </summary>
		/// <remarks>
		/// This was generated because of Validation.UseSave = true.
		/// </remarks>
        protected override void OnDocumentSaved()
        {
			this.ValidateAllCommandExecuted();

            if (this.ErrorListModel != null)
                if (this.ErrorListModel.ErrorsCount > 0)
				{
					DslEditorViewModelServices::IMessageBoxService messageBox = this.GlobalServiceProvider.Resolve<DslEditorViewModelServices::IMessageBoxService>();
                    if (messageBox.ShowYesNoCancel("Validation founds errors. Are you sure you want to save the model?", DslEditorViewModelServices.CustomDialogIcons.Exclamation) != DslEditorViewModelServices.CustomDialogResults.Yes)
                        return;
                }
			
			base.OnDocumentSaved();
		}
		#endregion
	}
	
	#region DefaultContext
	/// <summary>
    /// This is a view model for the model context DefaultContext.
	/// 
	/// Double-derived class to allow easier code customization.	
    /// </summary>
	public partial class DefaultContextModelContextViewModel : DefaultContextModelContextViewModelBase
	{
		#region Constructor
        /// <summary>
        /// Constuctor.
        /// </summary>
        /// <param name="viewModelStore">The store this view model belongs to.</param>
        /// <param name="modelContext">Hosted model context.</param>
        /// <param name="mainViewModel">Main view model.</param>	
        public DefaultContextModelContextViewModel(DslEditorViewModelData::ViewModelStore viewModelStore, DslEditorModeling::ModelContext modelContext, DslEditorViewModel::BaseMainViewModel mainViewModel)
            : base(viewModelStore, modelContext, mainViewModel)
        {

        }	
		#endregion
	}
	
	/// <summary>
    /// This is a view model for the model context DefaultContext.
	/// 
	/// This is the abstract base class.
    /// </summary>
	public abstract class DefaultContextModelContextViewModelBase : DslEditorViewModel::ModelContextViewModel
	{
		#region Constructor
        /// <summary>
        /// Constuctor.
        /// </summary>
        /// <param name="viewModelStore">The store this view model belongs to.</param>
        /// <param name="modelContext">Hosted model context.</param>
        /// <param name="mainViewModel">Main view model.</param>	
        public DefaultContextModelContextViewModelBase(DslEditorViewModelData::ViewModelStore viewModelStore, DslEditorModeling::ModelContext modelContext, DslEditorViewModel::BaseMainViewModel mainViewModel)
            : base(viewModelStore, modelContext, mainViewModel)
        {

        }	
		#endregion
	
		#region Initialization
        /// <summary>
        /// This method is used to initialize the view model and can be overriden for customization.
        /// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
        protected override void Initialize()
        {
			base.Initialize();
			
            this.EditorTitle = "FamilyTreeDSL";			
			
			// diagram surface vm
			this.DiagramSurfaceModel = new FamilyTreeDSLDesignerDiagramSurfaceViewModel(ViewModelStore as FamilyTreeDSLViewModelStore, this.ModelContext);
			AddAdditionalViewModel(DiagramSurfaceModel);
			
		
			
			
		}
		#endregion
	
	}
	#endregion
	
	#region ModelTree
	/// <summary>
	/// This class represents the model tree view model of the FamilyTreeDSL.
	/// 
	/// Double-derived class to allow easier code customization.
	/// </summary>
	public partial class FamilyTreeDSLModelTreeViewModel : FamilyTreeDSLModelTreeViewModelBase
	{
		#region Constructor
		/// <summary>
        /// Constuctor.
        /// </summary>
        /// <param name="viewModelStore">View model store containing this view model.</param>
        public FamilyTreeDSLModelTreeViewModel(FamilyTreeDSLViewModelStore viewModelStore)
            : base(viewModelStore)
        {
        }
		#endregion
	}
	
	/// <summary>
	/// This class represents the model tree view model of the FamilyTreeDSL.
	/// 
	/// This is the abstract base class.
	/// </summary>
	public abstract class FamilyTreeDSLModelTreeViewModelBase : DslEditorViewModel::MainModelTreeViewModel
	{
		#region Constructor
		/// <summary>
        /// Constuctor.
        /// </summary>
        /// <param name="viewModelStore">View model store containing this view model.</param>
        protected FamilyTreeDSLModelTreeViewModelBase(FamilyTreeDSLViewModelStore viewModelStore)
            : base(viewModelStore)
        {
        }
		#endregion
	
		#region Initialize

		
		/// <summary>
        /// Initialize.
        /// </summary>
        protected override void Initialize()
        {
            base.Initialize();
        }
		#endregion
	
	    #region IDockableViewModel
		/// <summary>
		/// Gets the docking pane anchor style. 
		/// </summary>
        public override DslEditorViewModel.DockingPaneAnchorStyle DockingPaneAnchorStyle
        {
            get
            {
                return DslEditorViewModel.DockingPaneAnchorStyle.Left;
            }
        }
		
		/// <summary>
        /// Gets the context change kind. 
        /// </summary>
        public override DslEditorViewModel.DockingContextChangeKind DockingContextChangeKind
        {
            get
            {
                return DslEditorViewModel.DockingContextChangeKind.PreviewMouseUp;
            }
        }
        #endregion
	}
	#endregion

	#region PropertyGrid
	/// <summary>
	/// This class represents the property grid view model of the FamilyTreeDSL.
	/// 
	/// Double-derived class to allow easier code customization.
	/// </summary>
	public partial class FamilyTreeDSLPropertyGridViewModel : FamilyTreeDSLPropertyGridViewModelBase
	{
		#region Constructor
		/// <summary>
        /// Constuctor.
        /// </summary>
        /// <param name="viewModelStore">View model store containing this view model.</param>
        public FamilyTreeDSLPropertyGridViewModel(FamilyTreeDSLViewModelStore viewModelStore)
            : base(viewModelStore)
        {	
        }
		#endregion
	}
	
	/// <summary>
	/// This class represents the property grid view model of the FamilyTreeDSL.
	/// 
	/// This is the abstract base class.
	/// </summary>
	public abstract class FamilyTreeDSLPropertyGridViewModelBase : DslEditorViewModel::MainPropertyGridViewModel
	{
		#region Constructor
		/// <summary>
        /// Constuctor.
        /// </summary>
        /// <param name="viewModelStore">View model store containing this view model.</param>
        protected FamilyTreeDSLPropertyGridViewModelBase(FamilyTreeDSLViewModelStore viewModelStore)
            : base(viewModelStore)
        {  
        }
		#endregion
		
        #region IDockableViewModel
		/// <summary>
		/// Gets the docking pane anchor style. 
		/// </summary>
        public override DslEditorViewModel.DockingPaneAnchorStyle DockingPaneAnchorStyle
        {
            get
            {
                return DslEditorViewModel.DockingPaneAnchorStyle.Right;
            }
        }
        #endregion		
		
        /// <summary>
        /// This method needs to overriden in the actual instances of this class to create contextual
        /// or regular ribbon bars if required.
        /// </summary>
        /// <param name="ribbonMenu">Main ribbon menu.</param>
        public override void CreateRibbonMenuBarForEditors(Fluent.Ribbon ribbonMenu)
        {
            base.CreateRibbonMenuBarForEditors(ribbonMenu);
			
	
        }
		
		/// <summary>
        /// Creates ribbon menu for property grid editors.
        /// </summary>
        /// <param name="ribbonMenu">Main ribbon menu.</param>
        public static void CreateRibbonMenuBarForEditorsHelper(Fluent.Ribbon ribbonMenu)
		{
	
		}
	}
	#endregion

	#region ErrorList
	/// <summary>
	/// This class represents the error list view model of the FamilyTreeDSL.
	/// 
	/// Double-derived class to allow easier code customization.
	/// </summary>
	public partial class FamilyTreeDSLErrorListViewModel : FamilyTreeDSLErrorListViewModelBase
	{
		#region Constructor
		/// <summary>
        /// Constuctor.
        /// </summary>
        /// <param name="viewModelStore">View model store containing this view model.</param>
        public FamilyTreeDSLErrorListViewModel(FamilyTreeDSLViewModelStore viewModelStore)
            : base(viewModelStore)
        {
        }
		#endregion
	}
	
	/// <summary>
	/// This class represents the error list view model of the FamilyTreeDSL.
	/// 
	/// This is the abstract base class.
	/// </summary>
	public abstract class FamilyTreeDSLErrorListViewModelBase : DslEditorViewModel::MainErrorListViewModel
	{
		#region Constructor
		/// <summary>
        /// Constuctor.
        /// </summary>
        /// <param name="viewModelStore">View model store containing this view model.</param>
        protected FamilyTreeDSLErrorListViewModelBase(FamilyTreeDSLViewModelStore viewModelStore)
            : base(viewModelStore)
        {
        }
		#endregion
		
        #region IDockableViewModel
		/// <summary>
		/// Gets the docking pane anchor style. 
		/// </summary>
        public override DslEditorViewModel.DockingPaneAnchorStyle DockingPaneAnchorStyle
        {
            get
            {
                return DslEditorViewModel.DockingPaneAnchorStyle.Bottom;
            }
        }
        #endregion		
	}
	#endregion

	#region Dependencies
	/// <summary>
	/// This class represents the dependencies view model of the FamilyTreeDSL.
	/// 
	/// Double-derived class to allow easier code customization.
	/// </summary>
	public partial class FamilyTreeDSLDependenciesViewModel : FamilyTreeDSLDependenciesViewModelBase
	{
		#region Constructor
		/// <summary>
        /// Constuctor.
        /// </summary>
        /// <param name="viewModelStore">View model store containing this view model.</param>
        public FamilyTreeDSLDependenciesViewModel(FamilyTreeDSLViewModelStore viewModelStore)
            : base(viewModelStore)
        {
        }
		#endregion
	}
	
	/// <summary>
	/// This class represents the dependencies view model of the FamilyTreeDSL.
	/// 
	/// This is the abstract base class.
	/// </summary>
	public abstract class FamilyTreeDSLDependenciesViewModelBase : DslEditorViewModel::MainDependenciesViewModel
	{
		#region Constructor
		/// <summary>
        /// Constuctor.
        /// </summary>
        /// <param name="viewModelStore">View model store containing this view model.</param>
        protected FamilyTreeDSLDependenciesViewModelBase(FamilyTreeDSLViewModelStore viewModelStore)
            : base(viewModelStore)
        {
        }
		#endregion
		
        #region IDockableViewModel
		/// <summary>
		/// Gets the docking pane anchor style. 
		/// </summary>
        public override DslEditorViewModel.DockingPaneAnchorStyle DockingPaneAnchorStyle
        {
            get
            {
                return DslEditorViewModel.DockingPaneAnchorStyle.Bottom;
            }
        }
        #endregion		
	}
	#endregion
	
	#region Search
	/// <summary>
	/// This class represents the search view model of the FamilyTreeDSL.
	/// 
	/// Double-derived class to allow easier code customization.
	/// </summary>
	public partial class FamilyTreeDSLSearchViewModel : FamilyTreeDSLSearchViewModelBase
	{
		#region Constructor
		/// <summary>
        /// Constuctor.
        /// </summary>
        /// <param name="viewModelStore">View model store containing this view model.</param>
        public FamilyTreeDSLSearchViewModel(FamilyTreeDSLViewModelStore viewModelStore)
            : base(viewModelStore)
        {
        }
		#endregion
	}
	
	/// <summary>
	/// This class represents the search view model of the FamilyTreeDSL.
	/// 
	/// This is the abstract base class.
	/// </summary>
	public abstract class FamilyTreeDSLSearchViewModelBase : DslEditorViewModel::MainSearchViewModel
	{
		#region Constructor
		/// <summary>
        /// Constuctor.
        /// </summary>
        /// <param name="viewModelStore">View model store containing this view model.</param>
        protected FamilyTreeDSLSearchViewModelBase(FamilyTreeDSLViewModelStore viewModelStore)
            : base(viewModelStore)
        {
        }
		#endregion
		
		#region Initialization
        /// <summary>
        /// This method is used to initialize the view model and can be overriden for customization.
        /// </summary>
        protected override void PreInitialize()
        {
			base.PreInitialize();
			
			this.SearchResultViewModel = new FamilyTreeDSLSearchResultViewModel(this.ViewModelStore as FamilyTreeDSLViewModelStore);
		}
		#endregion
		
        #region IDockableViewModel
		/// <summary>
		/// Gets the docking pane anchor style. 
		/// </summary>
        public override DslEditorViewModel.DockingPaneAnchorStyle DockingPaneAnchorStyle
        {
            get
            {
                return DslEditorViewModel.DockingPaneAnchorStyle.Right;
            }
        }
		
		/*
		/// <summary>
		/// Gets the docking pane style. 
		/// </summary>
		public override DslEditorViewModel.DockingPaneStyle DockingPaneStyle
        {
            get
            {
                return DslEditorViewModel.DockingPaneStyle.Floating;
            }
        }*/
        #endregion		
	}
	
	/// <summary>
	/// This class represents a search result view model of the FamilyTreeDSL.
	/// 
	/// Double-derived class to allow easier code customization.
	/// </summary>
	public partial class FamilyTreeDSLSearchResultViewModel : FamilyTreeDSLSearchResultViewModelBase
	{
		#region Constructor
		/// <summary>
        /// Constuctor.
        /// </summary>
        /// <param name="viewModelStore">View model store containing this view model.</param>
        public FamilyTreeDSLSearchResultViewModel(FamilyTreeDSLViewModelStore viewModelStore)
            : base(viewModelStore)
        {
        }
		#endregion
	}
	
	/// <summary>
	/// This class represents a search result view model of the FamilyTreeDSL.
	/// 
	/// This is the abstract base class.
	/// </summary>
	public abstract class FamilyTreeDSLSearchResultViewModelBase : DslEditorViewModel::Search.SearchResultViewModel
	{
		#region Constructor
		/// <summary>
        /// Constuctor.
        /// </summary>
        /// <param name="viewModelStore">View model store containing this view model.</param>
        protected FamilyTreeDSLSearchResultViewModelBase(FamilyTreeDSLViewModelStore viewModelStore)
            : base(viewModelStore)
        {
        }
		#endregion
		
        #region IDockableViewModel
		/// <summary>
		/// Gets the docking pane anchor style. 
		/// </summary>
        public override DslEditorViewModel.DockingPaneAnchorStyle DockingPaneAnchorStyle
        {
            get
            {
                return DslEditorViewModel.DockingPaneAnchorStyle.Bottom;
            }
        }
        #endregion		
	}
	
	#endregion
}

namespace Tum.FamilyTreeDSL.ViewModel
{
	/// <summary>
    /// This class is used to create new as well as store and restore layout of existing avalondock windows.
	///
	/// Double-derived class to allow easier code customization.
    /// </summary>
	public class FamilyTreeDSLDockingLayoutManager : FamilyTreeDSLDockingLayoutManagerBase
	{
		#region Constructor
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="package">Package.</param>
		/// <param name="c">Shell package controller.</param>
		public FamilyTreeDSLDockingLayoutManager(DslEditorShell::ModelPackage package, DslEditorViewShell::ShellPackageController c)
			: base(package, c)
		{
		}
		#endregion
		
		/*
		/// <summary>
        /// Shows a docking window for a given view.  
        /// If is has been shown before, restore its position. Otherwise dock it to the right side.
        /// </summary>
        /// <param name="view">View to dock.</param>
        /// <param name="dockingStyle">Docking style.</param>
        /// <param name="dockingAnchorStyle">Docking anchor style. Only usefull for DockingPaneStyle.Docked.</param>
        /// <param name="dockedInDocumentPane">True if this view should be shown in the document pane window. False otherwise.</param>
		public override void ShowWindow(DslEditorViewModelContracts.IDockableViewModel view, DslEditorViewModel.DockingPaneStyle dockingStyle, DslEditorViewModel.DockingPaneAnchorStyle dockingAnchorStyle, bool dockedInDocumentPane)
        {
            if( view is VSPluginDSLDesignerDiagramSurfaceViewModel || view is VSPluginDSLSpecificElementsDiagramTemplateSurfaceViewModel || 
                view is VSPluginDSLModalDiagramTemplateSurfaceViewModel )
                base.ShowWindow(view, dockingStyle, dockingAnchorStyle, false);
            else
                base.ShowWindow(view, dockingStyle, dockingAnchorStyle, dockedInDocumentPane);
        }
		*/
	}

	/// <summary>
    /// This class is used to create new as well as store and restore layout of existing avalondock windows.
	///
	/// This is the abstract base class.
    /// </summary>
	public abstract class FamilyTreeDSLDockingLayoutManagerBase : DslEditorViewModelShell::ShellDockingManager
	{
		#region Constructor
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="package">Package.</param>
		/// <param name="c">Shell package controller.</param>
		protected FamilyTreeDSLDockingLayoutManagerBase(DslEditorShell::ModelPackage package, DslEditorViewShell::ShellPackageController c) 
			: base(package, c)
		{
		}
		#endregion
		
		#region Properties
		/// <summary>
        /// FilePath to save all the visible docking panes to.
        /// </summary>
        public override string SaveDockingPanesFilePath 
		{
			get
			{
				return FamilyTreeDSLModelDataOptions.Instance.AppDataDirectory + System.IO.Path.DirectorySeparatorChar + "LayoutManagerDV.txt";
			}
		}

        /// <summary>
        /// FilePath to save the layout to.
        /// </summary>
        public override string SaveLayoutFilePath
		{ 
			get
			{
				return FamilyTreeDSLModelDataOptions.Instance.AppDataDirectory + System.IO.Path.DirectorySeparatorChar + "LayoutManagerLayout.xml";
			}
		}
		
		/// <summary>
        /// Directory to save the layouts to.
        /// </summary>
        public override string SaveLayoutDirectory
		{ 
			get
			{
				return FamilyTreeDSLModelDataOptions.Instance.AppDataDirectory;
			}
		}
		
		/// <summary>
        /// FilePath to save the layout to.
        /// </summary>
        public override string SaveConfigurationFilePath
		{ 
			get
			{
				return FamilyTreeDSLModelDataOptions.Instance.AppDataDirectory + System.IO.Path.DirectorySeparatorChar + "LayoutManagerConfig.xml";
			}
		}
		
        /// <summary>
        /// Path to the embedded default layout file. By default: /GeneratedCode/UI/LayoutManagerLayout.xml.
        /// </summary>
        public override string EmbeddedLayoutFilePath
		{
			get
			{
				return "Tum.FamilyTreeDSL." + "GeneratedCode.ViewModel.WPFApplication.LayoutManagerLayout.xml";
			}
		}

        /// <summary>
        /// Path to the embedded dfault visible docking panes files. By default: /GeneratedCode/UI/LayoutManagerDV.txt.
        /// </summary>
        public override string EmbeddedDockingPanesFilePath
		{
			get
			{
				return "Tum.FamilyTreeDSL." + "GeneratedCode.ViewModel.WPFApplication.LayoutManagerDV.txt";
			}
		}
		#endregion
	}
}
