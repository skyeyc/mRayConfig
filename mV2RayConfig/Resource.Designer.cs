﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace mV2RayConfig {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("mV2RayConfig.Resource", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
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
        ///   查找类似 {&quot;header&quot;:{&quot;type&quot;:&quot;http&quot;,&quot;response&quot;:{&quot;version&quot;:&quot;1.1&quot;,&quot;status&quot;:&quot;200&quot;,&quot;reason&quot;:&quot;OK&quot;,&quot;headers&quot;:{&quot;Content-Type&quot;:[&quot;application/octet-stream&quot;,&quot;application/x-msdownload&quot;,&quot;text/html&quot;,&quot;application/x-shockwave-flash&quot;],&quot;Transfer-Encoding&quot;:[&quot;chunked&quot;],&quot;Connection&quot;:[&quot;keep-alive&quot;],&quot;Pragma&quot;:&quot;no-cache&quot;}}}} 的本地化字符串。
        /// </summary>
        public static string httpFake {
            get {
                return ResourceManager.GetString("httpFake", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 [{&quot;protocol&quot;:&quot;blackhole&quot;,&quot;settings&quot;:{},&quot;tag&quot;:&quot;blocked&quot;}] 的本地化字符串。
        /// </summary>
        public static string outboundDetour {
            get {
                return ResourceManager.GetString("outboundDetour", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {&quot;strategy&quot;:&quot;rules&quot;,&quot;settings&quot;:{&quot;rules&quot;:[{&quot;type&quot;:&quot;field&quot;,&quot;ip&quot;:[&quot;0.0.0.0/8&quot;,&quot;10.0.0.0/8&quot;,&quot;100.64.0.0/10&quot;,&quot;127.0.0.0/8&quot;,&quot;169.254.0.0/16&quot;,&quot;172.16.0.0/12&quot;,&quot;192.0.0.0/24&quot;,&quot;192.0.2.0/24&quot;,&quot;192.168.0.0/16&quot;,&quot;198.18.0.0/15&quot;,&quot;198.51.100.0/24&quot;,&quot;203.0.113.0/24&quot;,&quot;::1/128&quot;,&quot;fc00::/7&quot;,&quot;fe80::/10&quot;],&quot;outboundTag&quot;:&quot;blocked&quot;}]}} 的本地化字符串。
        /// </summary>
        public static string routing {
            get {
                return ResourceManager.GetString("routing", resourceCulture);
            }
        }
    }
}
