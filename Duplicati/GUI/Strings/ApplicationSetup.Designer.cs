﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3082
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Duplicati.GUI.Strings {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ApplicationSetup {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ApplicationSetup() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Duplicati.GUI.Strings.ApplicationSetup", typeof(ApplicationSetup).Assembly);
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
        ///   Looks up a localized string similar to Cache size: {0}.
        /// </summary>
        internal static string CacheSize {
            get {
                return ResourceManager.GetString("CacheSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Calculating cache size ....
        /// </summary>
        internal static string CalculatingCacheSize {
            get {
                return ResourceManager.GetString("CalculatingCacheSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete signature files in the folder: \n{0}.
        /// </summary>
        internal static string ConfirmCacheDelete {
            get {
                return ResourceManager.GetString("ConfirmCacheDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to System language, {0}.
        /// </summary>
        internal static string DefaultLanguage {
            get {
                return ResourceManager.GetString("DefaultLanguage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception occured while examining the folder: {0}.\r\nDo you want to use that folder anyway?.
        /// </summary>
        internal static string ErrorWhileExaminingFolder {
            get {
                return ResourceManager.GetString("ErrorWhileExaminingFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The folder selected does not contain the file: {0}.\r\nDo you want to use that folder anyway?.
        /// </summary>
        internal static string FolderIsMissingFile {
            get {
                return ResourceManager.GetString("FolderIsMissingFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The language has changed. This will take effect after you restart Duplicati..
        /// </summary>
        internal static string LanguageChangedWarning {
            get {
                return ResourceManager.GetString("LanguageChangedWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cancelled.
        /// </summary>
        internal static string OperationCancelled {
            get {
                return ResourceManager.GetString("OperationCancelled", resourceCulture);
            }
        }
    }
}