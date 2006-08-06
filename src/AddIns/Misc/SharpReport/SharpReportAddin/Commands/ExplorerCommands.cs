//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2032
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Windows.Forms;
using ICSharpCode.Core;
using ICSharpCode.SharpDevelop.Gui;
using SharpReportCore;
/// <summary>
/// This class'es handles all the commands used by the
/// <see cref="ReportExplorer"></see>
/// </summary>
/// <remarks>
/// 	created by - Forstmeier Peter
/// 	created on - 07.06.2005 11:49:54
/// </remarks>

namespace SharpReportAddin.Commands {
	/// <summary>
	/// Fill and BringToFront
	/// </summary>
	public class ShowAndFillExplorer : AbstractExplorerCommand{
		ReportModel reportModel;
		
		public override void Run(){
			if (this.reportModel == null) {
				throw new ArgumentNullException("reportModel");
			}
			base.ReportExplorerPad.BringPadToFront();
			base.ReportExplorer.ReportModel = this.reportModel;
		}
		
		public ReportModel ReportModel {
			set {
				reportModel = value;
			}
		}
		
	}
	
	/// <summary>
	/// ShutDown Explorer
	/// </summary>
	public class HideExplorer:AbstractExplorerCommand{
		
		public override void Run(){
			WorkbenchSingleton.Workbench.WorkbenchLayout.HidePad(base.ReportExplorerPad);
		}
		
	}
	
	/// <summary>
	/// Clear and rebuild the ExplorerTree
	/// </summary>
	public class ClearAndRebuildExplorer : AbstractExplorerCommand{
		
		public override void Run()
		{
			base.ReportExplorer.ClearAndRebuildTree();
		}
		
	}
	
	///<summary>
	/// Clear the selected Section (Grouping/Sorting)
	/// </summary>
	
	public class ClearNodes : AbstractExplorerCommand{
		public ClearNodes() {
		}
		
		public override void Run() {
			try {
				base.ReportExplorer.ClearNodes();
			} catch (Exception) {
				throw;
			}
		}
		
	} 
	
	
 	/// <summary>
	/// Toggle the SortOrder
	/// </summary>
	public class ToogleOrder : AbstractExplorerCommand{
		public ToogleOrder() {
		}
		
		public override void Run() {
			try {
				base.ReportExplorer.ToggleOrder();
			} catch (Exception) {
				throw;
			}
		}
		
	} 
	
	/// <summary>
	/// Remove the Selected Node from the Collection
	/// </summary>
	public class RemoveNode : AbstractExplorerCommand{
		public RemoveNode() {
			
		}
		public override void Run() {
			try {
				base.ReportExplorer.RemoveNode();
			} catch (Exception) {
				throw;
			}
		}
		
	} // End
 	
	
}
