﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StatisticsAnalysisTool.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.0.3.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Languages")]
        public string LanguageDirectoryName {
            get {
                return ((string)(this["LanguageDirectoryName"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ImageResources")]
        public string ImageResources {
            get {
                return ((string)(this["ImageResources"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ItemList.json")]
        public string ItemListFileName {
            get {
                return ((string)(this["ItemListFileName"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=LEM458PZ4FV4" +
            "C&source=url")]
        public string DonateUrl {
            get {
                return ((string)(this["DonateUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://raw.githubusercontent.com/broderickhyman/ao-bin-dumps/master/formatted/it" +
            "ems.json")]
        public string DefaultItemListSourceUrl {
            get {
                return ((string)(this["DefaultItemListSourceUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://raw.githubusercontent.com/Triky313/AlbionOnline-StatisticsAnalysis/master" +
            "/src/StatisticsAnalysisTool/ao-update-check.xml")]
        public string AutoUpdateConfigUrl {
            get {
                return ((string)(this["AutoUpdateConfigUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("en-US")]
        public string DefaultLanguageCultureName {
            get {
                return ((string)(this["DefaultLanguageCultureName"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UpgradeRequired {
            get {
                return ((bool)(this["UpgradeRequired"]));
            }
            set {
                this["UpgradeRequired"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("PlayerModeInformation.txt")]
        public string PlayerModeUpdateFileName {
            get {
                return ((string)(this["PlayerModeUpdateFileName"]));
            }
            set {
                this["PlayerModeUpdateFileName"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://github.com/Triky313/AlbionOnline-StatisticsAnalysis")]
        public string GitHubRepoUrl {
            get {
                return ((string)(this["GitHubRepoUrl"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Sounds")]
        public string SoundDirectoryName {
            get {
                return ((string)(this["SoundDirectoryName"]));
            }
            set {
                this["SoundDirectoryName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ActiveAlerts.json")]
        public string ActiveAlertsFileName {
            get {
                return ((string)(this["ActiveAlertsFileName"]));
            }
            set {
                this["ActiveAlertsFileName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("world.json")]
        public string WorldDataFileName {
            get {
                return ((string)(this["WorldDataFileName"]));
            }
            set {
                this["WorldDataFileName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://raw.githubusercontent.com/Triky313/AlbionOnline-StatisticsAnalysis/master" +
            "/src/StatisticsAnalysisTool/GameFiles/world.json")]
        public string WorldDataSourceUrl {
            get {
                return ((string)(this["WorldDataSourceUrl"]));
            }
            set {
                this["WorldDataSourceUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("7")]
        public int UpdateWorldDataByDays {
            get {
                return ((int)(this["UpdateWorldDataByDays"]));
            }
            set {
                this["UpdateWorldDataByDays"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DungeonRuns.json")]
        public string DungeonRunsFileName {
            get {
                return ((string)(this["DungeonRunsFileName"]));
            }
            set {
                this["DungeonRunsFileName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("lootchests.json")]
        public string LootChestDataFileName {
            get {
                return ((string)(this["LootChestDataFileName"]));
            }
            set {
                this["LootChestDataFileName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://raw.githubusercontent.com/Triky313/AlbionOnline-StatisticsAnalysis/master" +
            "/src/StatisticsAnalysisTool/GameFiles/lootchests.json")]
        public string LootChestDataSourceUrl {
            get {
                return ((string)(this["LootChestDataSourceUrl"]));
            }
            set {
                this["LootChestDataSourceUrl"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://discord.com/invite/sahSrSPmaJ")]
        public string DiscordUrl {
            get {
                return ((string)(this["DiscordUrl"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("FavoriteItems.json")]
        public string FavoriteItemsFileName {
            get {
                return ((string)(this["FavoriteItemsFileName"]));
            }
            set {
                this["FavoriteItemsFileName"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://www.albion-online-data.com/api/v2/stats/prices/")]
        public string CityPricesApiUrlDefault {
            get {
                return ((string)(this["CityPricesApiUrlDefault"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://www.albion-online-data.com/api/v2/stats/history/")]
        public string CityPricesHistoryApiUrlDefault {
            get {
                return ((string)(this["CityPricesHistoryApiUrlDefault"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://www.albion-online-data.com/api/v2/stats/Gold")]
        public string GoldStatsApiUrlDefault {
            get {
                return ((string)(this["GoldStatsApiUrlDefault"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("GameFiles")]
        public string GameFilesDirectoryName {
            get {
                return ((string)(this["GameFilesDirectoryName"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Settings.json")]
        public string SettingsFileName {
            get {
                return ((string)(this["SettingsFileName"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ItemSpriteToJournal.json")]
        public string ItemSpriteToJournalFileName {
            get {
                return ((string)(this["ItemSpriteToJournalFileName"]));
            }
            set {
                this["ItemSpriteToJournalFileName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://raw.githubusercontent.com/broderickhyman/ao-bin-dumps/master/items.json")]
        public string DefaultItemsJsonSourceUrl {
            get {
                return ((string)(this["DefaultItemsJsonSourceUrl"]));
            }
            set {
                this["DefaultItemsJsonSourceUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Items.json")]
        public string ItemsJsonFileName {
            get {
                return ((string)(this["ItemsJsonFileName"]));
            }
            set {
                this["ItemsJsonFileName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://raw.githubusercontent.com/Triky313/AlbionOnline-StatisticsAnalysis/master" +
            "/src/StatisticsAnalysisTool/ao-pre-release-update-check.xml")]
        public string AutoUpdatePreReleaseConfigUrl {
            get {
                return ((string)(this["AutoUpdatePreReleaseConfigUrl"]));
            }
            set {
                this["AutoUpdatePreReleaseConfigUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Stats.json")]
        public string StatsFileName {
            get {
                return ((string)(this["StatsFileName"]));
            }
            set {
                this["StatsFileName"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("90")]
        public int KeepDashboardStatisticsForDays {
            get {
                return ((int)(this["KeepDashboardStatisticsForDays"]));
            }
        }
    }
}
