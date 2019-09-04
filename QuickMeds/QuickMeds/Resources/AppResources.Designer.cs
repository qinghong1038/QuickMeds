﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuickMeds.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class AppResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AppResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("QuickMeds.Resources.AppResources", typeof(AppResources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Press the key that matches the first letter of the patient&apos;s condition..
        /// </summary>
        public static string ConditionSearchText {
            get {
                return ResourceManager.GetString("ConditionSearchText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Search for a Condition.
        /// </summary>
        public static string ConditionSearchTitle {
            get {
                return ResourceManager.GetString("ConditionSearchTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Press the key that matches the first letter of the patient&apos;s medication..
        /// </summary>
        public static string MedicationSearchText {
            get {
                return ResourceManager.GetString("MedicationSearchText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Search for a Medication.
        /// </summary>
        public static string MedicationSearchTitle {
            get {
                return ResourceManager.GetString("MedicationSearchTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You pressed {0}!.
        /// </summary>
        public static string PressCheckText {
            get {
                return ResourceManager.GetString("PressCheckText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Press Check!.
        /// </summary>
        public static string PressCheckTitle {
            get {
                return ResourceManager.GetString("PressCheckTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Quick Prescription Medication Reference for Emergency Medical Service (EMS) Providers.
        /// </summary>
        public static string Subtitle {
            get {
                return ResourceManager.GetString("Subtitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to QUICKMEDS FOR EMS.
        /// </summary>
        public static string Title {
            get {
                return ResourceManager.GetString("Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updated for 2017.
        /// </summary>
        public static string UpdateYear {
            get {
                return ResourceManager.GetString("UpdateYear", resourceCulture);
            }
        }
    }
}