using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using static FantomasVs.OptionsProvider;
using Task = System.Threading.Tasks.Task;

namespace FantomasVs
{

    // DO NOT REMOVE THIS MAGICAL INCANTATION NO MATTER HOW MUCH VS WARNS YOU OF DEPRECATION    
    // --------------------------------------------------------------------------------------
    [InstalledProductRegistration("F# Formatting", "F# source code formatting using Fantomas.", "1.0", IconResourceID = 400)]
    // --------------------------------------------------------------------------------------

    // Package registration attributes
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [Guid(FantomasVsPackage.PackageGuidString)]

    // Auto load only if a solution is open, this is important too
    //[ProvideAutoLoad(UIContextGuids80.SolutionExists, PackageAutoLoadFlags.BackgroundLoad)]

    // Options page
    [ProvideProfile(typeof(OptionsProvider.FormattingOptions), "F# Tools", "Formatting", 0, 0, true)]
    [ProvideOptionPage(typeof(OptionsProvider.FormattingOptions), "F# Tools", "Formatting", 0, 0, supportsAutomation: true)]

    public sealed partial class FantomasVsPackage : AsyncPackage
    {
        /// <summary>
        /// FantomasVsPackage GUID string.
        /// </summary>
        public const string PackageGuidString = "74927147-72e8-4b47-a80d-5568807d6878";

        #region Package Members

        /// <summary>
        /// Initialization of the package; this method is called right after the package is sited, so this is the place
        /// where you can put all the initialization code that rely on services provided by VisualStudio.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token to monitor for initialization cancellation, which can occur when VS is shutting down.</param>
        /// <param name="progress">A provider for progress updates.</param>
        /// <returns>A task representing the async work of package initialization, or an already completed task if there is none. Do not return null from this method.</returns>
        protected override async Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
        {            
            Trace.WriteLine("Fantomas Vs Package Loaded");
        }

        #endregion
    }
}
