﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace RimTrans {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RimTrans.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;configuration&gt;
        ///  
        ///  &lt;!-- App Config - RimTrans --&gt;
        ///  
        ///  &lt;!-- Directory 目录 --&gt;
        ///  &lt;TargetLanguage&gt;ChineseSimplified&lt;/TargetLanguage&gt;
        ///  &lt;DirSteamApps&gt;D:\Game\Steam\steamapps&lt;/DirSteamApps&gt;
        ///  &lt;DirRimWorld&gt;D:\A15Translating\RimWorld&lt;/DirRimWorld&gt;
        ///  &lt;SelectedMod&gt;Core&lt;/SelectedMod&gt;
        ///  &lt;SelectedWhere&gt;Direct&lt;/SelectedWhere&gt;
        ///
        ///  &lt;!-- Typesetting 排版 --&gt;
        ///  &lt;IndentNumber&gt;2&lt;/IndentNumber&gt;
        ///  &lt;IsCommentExtract&gt;true&lt;/IsCommentExtract&gt;
        ///  &lt;IsCommentTypesetting&gt;true&lt;/IsComm [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string DefaultConfig {
            get {
                return ResourceManager.GetString("DefaultConfig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;LanguageData&gt;
        ///
        ///&lt;/LanguageData&gt; 的本地化字符串。
        /// </summary>
        internal static string EmptyDoc {
            get {
                return ResourceManager.GetString("EmptyDoc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;LanguageData&gt;
        ///
        ///  &lt;!-- SPECIAL: These Recipes from ThingDef with &lt;recipeMaker&gt;, generate by RimTrans --&gt;
        ///
        ///&lt;/LanguageData&gt; 的本地化字符串。
        /// </summary>
        internal static string Recipes_Add {
            get {
                return ResourceManager.GetString("Recipes_Add", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;LanguageData&gt;
        ///
        ///  &lt;!-- SPECIAL: Floors from natural stones --&gt;
        ///
        ///  &lt;Sandstone_Rough.label&gt;rough sandstone&lt;/Sandstone_Rough.label&gt;
        ///  &lt;Sandstone_RoughHewn.label&gt;rough-hewn sandstone&lt;/Sandstone_RoughHewn.label&gt;
        ///  &lt;Sandstone_Smooth.label&gt;smooth sandstone&lt;/Sandstone_Smooth.label&gt;
        ///  
        ///  &lt;Granite_Rough.label&gt;rough granite&lt;/Granite_Rough.label&gt;
        ///  &lt;Granite_RoughHewn.label&gt;rough-hewn granite&lt;/Granite_RoughHewn.label&gt;
        ///  &lt;Granite_Smooth.label&gt;smooth granite&lt;/Granite_Smoo [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string Terrain_Add {
            get {
                return ResourceManager.GetString("Terrain_Add", resourceCulture);
            }
        }
    }
}
