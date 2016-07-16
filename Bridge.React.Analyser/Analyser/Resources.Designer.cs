﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bridge.React.Analyser {
    using System;
    using System.Reflection;
    
    
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Bridge.React.Analyser.Resources", typeof(Resources).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to React components must have empty constructors, due to the way that React instantiates them.
        /// </summary>
        internal static string ComponentAnalyserTitle {
            get {
                return ResourceManager.GetString("ComponentAnalyserTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Class {0} is derived from {1} and so must not have a constructor body as it will not be executed (due to the way that React initialise component classes).
        /// </summary>
        internal static string ComponentWithNonEmptyConstructorMessageFormat {
            get {
                return ResourceManager.GetString("ComponentWithNonEmptyConstructorMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ReactElement may not be used as a type parameter for an object instantiation as it is an [External] type that will not be available at runtime (for creating sets of components, the ToChildComponentArray extension method may help).
        /// </summary>
        internal static string InvalidReactElementInstantiation {
            get {
                return ResourceManager.GetString("InvalidReactElementInstantiation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ReactElement is an [External] type and may not be used anywhere that would require a reference to its type at runtime.
        /// </summary>
        internal static string InvalidReactElementUsage {
            get {
                return ResourceManager.GetString("InvalidReactElementUsage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Be careful to use the appropriate &quot;Value&quot; or &quot;Values&quot; SelectAttributes property, depending upon the &quot;Multiple&quot; property&apos;s value.
        /// </summary>
        internal static string SelectAttributesMisuse {
            get {
                return ResourceManager.GetString("SelectAttributesMisuse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not try to set the SelectAttributes &apos;Values&apos; property when &apos;Multiple&apos; is false, use the &apos;Value&apos; scalar property instead.
        /// </summary>
        internal static string SelectAttributesValuesButNonMultiple {
            get {
                return ResourceManager.GetString("SelectAttributesValuesButNonMultiple", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not try to set the SelectAttributes &apos;Value&apos; property when &apos;Multiple&apos; is true, use the &apos;Values&apos; array property instead.
        /// </summary>
        internal static string SelectAttributeValueWithMultiple {
            get {
                return ResourceManager.GetString("SelectAttributeValueWithMultiple", resourceCulture);
            }
        }
    }
}