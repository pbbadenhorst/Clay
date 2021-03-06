﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SourceCode.Clay.AspNetCore.Middleware.Correlation.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SourceCode.Clay.AspNetCore.Middleware.Correlation.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Adding correlation ID to response: {0}..
        /// </summary>
        internal static string AddCorrelationIdToResponse {
            get {
                return ResourceManager.GetString("AddCorrelationIdToResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument is null or empty..
        /// </summary>
        internal static string ArgumentNullOrEmpty {
            get {
                return ResourceManager.GetString("ArgumentNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument is null or white space..
        /// </summary>
        internal static string ArgumentNullOrWhitespace {
            get {
                return ResourceManager.GetString("ArgumentNullOrWhitespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A correlation ID was already added to response. Header: {0}, Value Found: {1},  Value Generated: {2}.
        /// </summary>
        internal static string CorrelationIdAlreadyAddedToResponse {
            get {
                return ResourceManager.GetString("CorrelationIdAlreadyAddedToResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Existing correlation id found: {0}.
        /// </summary>
        internal static string ExistingRequestCorrelationIDFound {
            get {
                return ResourceManager.GetString("ExistingRequestCorrelationIDFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No existing correlation id found, generated: {0}.
        /// </summary>
        internal static string NoExistingRequestCorrelationIDFound {
            get {
                return ResourceManager.GetString("NoExistingRequestCorrelationIDFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find the required services. You must call the AddCorrelationId method in ConfigureServices in the application startup code..
        /// </summary>
        internal static string RequireServiceCorrelationContextAccessorIsMissing {
            get {
                return ResourceManager.GetString("RequireServiceCorrelationContextAccessorIsMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find the required services. You must call add a service of type Microsoft.Extensions.Logging.ILogger&lt;CorrelationIdMiddleware&gt;..
        /// </summary>
        internal static string RequireServiceILoggerOfCorrelationIdMiddleIsMissing {
            get {
                return ResourceManager.GetString("RequireServiceILoggerOfCorrelationIdMiddleIsMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating TraceIdentifier from: {0} to: {1}..
        /// </summary>
        internal static string UpdatingHttpContextTraceIdentifier {
            get {
                return ResourceManager.GetString("UpdatingHttpContextTraceIdentifier", resourceCulture);
            }
        }
    }
}
