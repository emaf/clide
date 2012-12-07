﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Clide.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Clide.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In order to register command instance &apos;{command}&apos;, it must have a [Command] attribute..
        /// </summary>
        internal static string CommandManager_CommandAttributeMissing {
            get {
                return ResourceManager.GetString("CommandManager_CommandAttributeMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In order to register command filter instance &apos;{filter}&apos;, it must have a [CommandFilter] attribute..
        /// </summary>
        internal static string CommandManager_CommandFilterAttributeMissing {
            get {
                return ResourceManager.GetString("CommandManager_CommandFilterAttributeMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command type &apos;{type}&apos; does not have the required attribute &apos;{attribute}&apos;..
        /// </summary>
        internal static string CommandManager_OwningPackageAttributeRequired {
            get {
                return ResourceManager.GetString("CommandManager_OwningPackageAttributeRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command type &apos;{type}&apos; specifies owning package with id &apos;{packageId}&apos; but it could not be found or loaded..
        /// </summary>
        internal static string CommandManager_OwningPackageNotFound {
            get {
                return ResourceManager.GetString("CommandManager_OwningPackageNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command type &apos;{type}&apos; specifies owning package with id &apos;{packageId}&apos; which is not a valid service provider..
        /// </summary>
        internal static string CommandManager_OwningPackageNotServiceProvider {
            get {
                return ResourceManager.GetString("CommandManager_OwningPackageNotServiceProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In order to register all commands for a given package automatically, the owning package &apos;{package}&apos; must have a [Guid] attribute applied, which must match the commands&apos; corresponding [Command] attribute..
        /// </summary>
        internal static string CommandManager_PackageGuidMissing {
            get {
                return ResourceManager.GetString("CommandManager_PackageGuidMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to create output window for diagnostics traces..
        /// </summary>
        internal static string Diagnostics_FailedToCreateOutputWindow {
            get {
                return ResourceManager.GetString("Diagnostics_FailedToCreateOutputWindow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hosting package &apos;{packageType}&apos; does not have the required [Guid] attribute..
        /// </summary>
        internal static string HostingPackage_MissingGuidAttribute {
            get {
                return ResourceManager.GetString("HostingPackage_MissingGuidAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The hosting package for the runtime must inherit from &apos;{baseClass}&apos;..
        /// </summary>
        internal static string HostingPackage_PackageBaseRequired {
            get {
                return ResourceManager.GetString("HostingPackage_PackageBaseRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .NET runtime changed. Please upgrade Clide..
        /// </summary>
        internal static string HostingPackage_UnsupportedRuntime {
            get {
                return ResourceManager.GetString("HostingPackage_UnsupportedRuntime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Clide.
        /// </summary>
        internal static string OutputPaneTitle {
            get {
                return ResourceManager.GetString("OutputPaneTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Object has already been initialized..
        /// </summary>
        internal static string Settings_AlreadyInitialized {
            get {
                return ResourceManager.GetString("Settings_AlreadyInitialized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to EndEdit invoked without corresponding BeginEdit..
        /// </summary>
        internal static string Settings_EndEditWithoutBeginEdit {
            get {
                return ResourceManager.GetString("Settings_EndEditWithoutBeginEdit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to EndInit invoked without corresponding BeginInit..
        /// </summary>
        internal static string Settings_EndInitWithoutBeginInit {
            get {
                return ResourceManager.GetString("Settings_EndInitWithoutBeginInit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot persist setting value of type &apos;{0}&apos; from property &apos;{1}.{2}&apos;. An appropriate type converter that can convert the value to a string is required..
        /// </summary>
        internal static string SettingsManager_CannotSaveAsString {
            get {
                return ResourceManager.GetString("SettingsManager_CannotSaveAsString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to read settings class &apos;{0}&apos; from the settings store..
        /// </summary>
        internal static string SettingsManager_FailedToRead {
            get {
                return ResourceManager.GetString("SettingsManager_FailedToRead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot assign value of type &apos;{0}&apos; to property &apos;{1}.{2}&apos; of type &apos;{3}&apos;. An appropriate type converter is required..
        /// </summary>
        internal static string SettingsManager_InvalidValue {
            get {
                return ResourceManager.GetString("SettingsManager_InvalidValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The solution file is invalid..
        /// </summary>
        internal static string SolutionNode_InvalidSolutionFile {
            get {
                return ResourceManager.GetString("SolutionNode_InvalidSolutionFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempted to execute command &apos;{commandText}&apos; ({commandType}) but current command status does not allow it..
        /// </summary>
        internal static string VsCommandExtensionAdapter_CannotExecute {
            get {
                return ResourceManager.GetString("VsCommandExtensionAdapter_CannotExecute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command did not execute successfully due to an unexpected exception. Please check the output window for additional information..
        /// </summary>
        internal static string VsCommandExtensionAdapter_ExecuteShieldMessage {
            get {
                return ResourceManager.GetString("VsCommandExtensionAdapter_ExecuteShieldMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Executing command &apos;{commandText}&apos; ({commandType})..
        /// </summary>
        internal static string VsCommandExtensionAdapter_ExecutingCommand {
            get {
                return ResourceManager.GetString("VsCommandExtensionAdapter_ExecutingCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command could not determine its current status due to an unexpected exception. Please check the output window for additional information..
        /// </summary>
        internal static string VsCommandExtensionAdapter_QueryStatusShieldMessage {
            get {
                return ResourceManager.GetString("VsCommandExtensionAdapter_QueryStatusShieldMessage", resourceCulture);
            }
        }
    }
}
