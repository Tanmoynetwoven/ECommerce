﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KVConnector.Properties {
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
    internal class SqlResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SqlResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("KVConnector.Properties.SqlResource", typeof(SqlResource).Assembly);
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
        ///   Looks up a localized string similar to update UserMaster set PwdHash = @newPwdHash where email = @email and PwdHash = @oldPwdHash.
        /// </summary>
        internal static string ChangePasswordHash {
            get {
                return ResourceManager.GetString("ChangePasswordHash", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select Role,PwdHash from UserMaster where Email = @email;.
        /// </summary>
        internal static string GetHashAndRole {
            get {
                return ResourceManager.GetString("GetHashAndRole", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select 0 from UserMaster where Email = @email and PwdHash = @oldPwdHash;.
        /// </summary>
        internal static string IsEmailAndHashExist {
            get {
                return ResourceManager.GetString("IsEmailAndHashExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select 0 from UserMaster where Email = @email;.
        /// </summary>
        internal static string IsEmailExist {
            get {
                return ResourceManager.GetString("IsEmailExist", resourceCulture);
            }
        }
    }
}
