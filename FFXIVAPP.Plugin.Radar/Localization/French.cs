﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="French.cs" company="SyndicatedLife">
//   Copyright© 2007 - 2021 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (https://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   French.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.Plugin.Radar.Localization {
    using System.Collections.Generic;
    using System.Windows;

    public abstract class French {
        private static readonly ResourceDictionary Dictionary = new ResourceDictionary();

        private static readonly List<string> RankA = new List<string> {
            "Griffe Des Enfers Magitek",
            "Unktehi",
            "Vogaal Ja",
            "Cornu",
            "Marberry",
            "Nahn",
            "Forneus",
            "Fondu",
            "Girtab",
            "Guédé Ti-Malice",
            "Marraco",
            "Pampa Ballerine",
            "Maahes",
            "Dernière Flamme De Dalvag",
            "Zanig'oh",
            "Alectryon",
            "Kurrea",

            // Heavensward Rank A
            "Mirka",
            "Lyuba",
            "Bune",
            "Agathos",
            "Pirlasta",
            "Seigneur Des Wyvernes",
            "Slipkinx Joints-d'acier",
            "Stolas",
            "Campacti",
            "Fleur Nauséabonde",
            "Enkélados",
            "Sisiutl",

            // Stormblood Rank A
            "Angada",
            "Aqrabuamelu",
            "Erle",
            "Funa Yurei",
            "Gajasura",
            "Girimekhala",
            "Luminare",
            "Mahisha",
            "Oni Yumemi",
            "Orcus",
            "Sum",
            "Vochstein",
        };

        private static readonly List<string> RankB = new List<string> {
            "Albin Le Blafard",
            "Barbastelle",
            "Mary La Sanglante",
            "Casque Noir",
            "Sergent-major Dalvag",
            "Acanthor",
            "Roi Des Sangsues",
            "Agrion Ogre Monarque",
            "Myradrosh",
            "Naul",
            "Ovjang",
            "Phecda",
            "Syrop D'égout",
            "Skogs Fru",
            "Sophie La Dardante",
            "Vuokho",
            "Joker Blanc",

            // Heavensward Rank B
            "Altek",
            "Gigantopithèque",
            "Gnathe Myrmicomète",
            "Kreutzet",
            "Lycidas",
            "Omni",
            "Pterygotus",
            "Sanu Vali",
            "Scitalis",
            "Squonk",
            "Dracosaure Primus",
            "Texta",

            // Stormblood Rank B
            "Aswang",
            "Bucca-boo",
            "Deidar",
            "Gauka La Lame Forte",
            "Guhuo Niao",
            "Gwas-y-neidr",
            "Gyorai Le Vif",
            "Kiwa",
            "Kurma",
            "Manes",
            "Ouzelum",
            "Yamini La Nocturne",
        };

        private static readonly List<string> RankS = new List<string> {
            "Garlok",
            "Croabéros",
            "Croque-Mitaine",
            "Czernobog",
            "Nandi",
            "Bonnacon",
            "Laideronnette",
            "Wulgaru",
            "Theda La Tripoteuse",
            "Flagelleur Mental",
            "Safat",
            "Brontes",
            "Balaur",
            "Minhocao",
            "Nunyunuwi",
            "Zona Seeker",
            "Agrippa the Mighty",

            // Heavensward Rank S
            "Béhémoth Empereur",
            "Gandharva",
            "Sênmurw",
            "Cavalier Pâle",
            "Leucrotta",
            "Oiseau De Paradis",

            // Stormblood Rank S
            "Gamma",
            "Mangeur D'os",
            "Okina",
            "Orghana",
            "Salaclux",
            "Udumbara",
        };

        /// <summary>
        /// </summary>
        /// <returns> </returns>
        public static ResourceDictionary Context() {
            Dictionary.Clear();
            Dictionary.Add("radar_", "*PH*");
            Dictionary.Add("radar_RadarWidgetHeader", "Radar Widget");
            Dictionary.Add("radar_OpenNowButtonText", "Open Now");
            Dictionary.Add("radar_ResetPositionButtonText", "Reset Settings");
            Dictionary.Add("radar_EnableClickThroughHeader", "Enable Click-Through On Radar");
            Dictionary.Add("radar_WidgetOpacityHeader", "Widget Opacity");
            Dictionary.Add("radar_ShowTitlesOnRadarHeader", "Show Titles On Radar");
            Dictionary.Add("radar_UIScaleHeader", "UI Scale");
            Dictionary.Add("radar_RadarSettingsTabHeader", "Radar Settings");
            Dictionary.Add("radar_PCShowHeader", "PC Show");
            Dictionary.Add("radar_PCShowNameHeader", "PC Show Name");
            Dictionary.Add("radar_PCShowHPPercentHeader", "PC Show HP Percent");
            Dictionary.Add("radar_PCShowJobHeader", "PC Show Job");
            Dictionary.Add("radar_PCShowDistanceHeader", "PC Show Distance");
            Dictionary.Add("radar_NPCShowHeader", "NPC Show");
            Dictionary.Add("radar_NPCShowNameHeader", "NPC Show Name");
            Dictionary.Add("radar_NPCShowHPPercentHeader", "NPC Show HP Percent");
            Dictionary.Add("radar_NPCShowDistanceHeader", "NPC Show Distance");
            Dictionary.Add("radar_MonsterShowHeader", "Monster Show");
            Dictionary.Add("radar_MonsterShowNameHeader", "Monster Show Name");
            Dictionary.Add("radar_MonsterShowHPPercentHeader", "Monster Show HP Percent");
            Dictionary.Add("radar_MonsterShowDistanceHeader", "Monster Show Distance");
            Dictionary.Add("radar_GatheringShowHeader", "Gathering Show");
            Dictionary.Add("radar_GatheringShowNameHeader", "Gathering Show Name");
            Dictionary.Add("radar_GatheringShowHPPercentHeader", "Gathering Show HP Percent");
            Dictionary.Add("radar_GatheringShowDistanceHeader", "Gathering Show Distance");
            Dictionary.Add("radar_OtherShowHeader", "Other Show");
            Dictionary.Add("radar_OtherShowNameHeader", "Other Show Name");
            Dictionary.Add("radar_OtherShowHPPercentHeader", "Other Show HP Percent");
            Dictionary.Add("radar_OtherShowDistanceHeader", "Other Show Distance");
            Dictionary.Add("radar_GitHubButtonText", "Open Project Source (GitHub)");
            Dictionary.Add("radar_PCFontSizeHeader", "PC Font Size");
            Dictionary.Add("radar_PCFontColorHeader", "PC Font Color");
            Dictionary.Add("radar_NPCFontSizeHeader", "NPC Font Size");
            Dictionary.Add("radar_NPCFontColorHeader", "NPC Font Color");
            Dictionary.Add("radar_MonsterFontSizeHeader", "Monster Font Size");
            Dictionary.Add("radar_MonsterFontColorHeader", "Monster Font Color");
            Dictionary.Add("radar_GatheringFontSizeHeader", "Gathering Font Size");
            Dictionary.Add("radar_GatheringFontColorHeader", "Gathering Font Color");
            Dictionary.Add("radar_OtherFontSizeHeader", "Other Font Size");
            Dictionary.Add("radar_OtherFontColorHeader", "Other Font Color");

            Dictionary.Add("radar_MonsterShowRankColorHeader", "Show Ranked Monsters In Color");
            Dictionary.Add("radar_MonsterShowBRankHeader", "Monster Show (B Rank)");
            Dictionary.Add("radar_MonsterShowARankHeader", "Monster Show (A Rank)");
            Dictionary.Add("radar_MonsterShowSRankHeader", "Monster Show (S Rank)");
            Dictionary.Add("radar_MonsterFontColorBRankHeader", "Monster Font Color (B Rank)");
            Dictionary.Add("radar_MonsterFontColorARankHeader", "Monster Font Color (A Rank)");
            Dictionary.Add("radar_MonsterFontColorSRankHeader", "Monster Font Color (S Rank)");
            Dictionary.Add("radar_FilterOptionsHeader", "Filter Options");
            Dictionary.Add("radar_KeyLabel", "Key:");
            Dictionary.Add("radar_LevelLabel", "Level:");
            Dictionary.Add("radar_TypeLabel", "Type:");
            Dictionary.Add("radar_DeleteFilterButton", " - ");
            Dictionary.Add("radar_AddorUpdateFilterButton", "Add Or Update Filter");
            Dictionary.Add("radar_SettingsRadarHeader", "Settings:Radar");
            Dictionary.Add("radar_CompasModeLabel", "Compass Mode");
            Dictionary.Add("radar_FilterRadarItemsLabel", "Filter Radar Items");
            Dictionary.Add("radar_ShowEntityDebugLabel", "Show Entity Debug Information");
            Dictionary.Add("radar_RadarUIScaleLabel", "UI Scale");
            Dictionary.Add("radar_SettingsRadarPCHeader", "Settings:Radar:PC");
            Dictionary.Add("radar_SettingsRadarNPCHeader", "Settings:Radar:NPC");
            Dictionary.Add("radar_SettingsRadarMonsterHeader", "Settings:Radar:Monster");
            Dictionary.Add("radar_SettingsRadarGatheringHeader", "Settings:Radar:Gathering");
            Dictionary.Add("radar_SettingsRadarOtherHeader", "Settings:Radar:Other");
            Dictionary.Add("radar_RadarTitleBar", "[RADAR]");

            return Dictionary;
        }

        public static List<string> GetRankedMonster(string name) {
            List<string> monsters;
            switch (name) {
                case "B":
                    monsters = RankB;
                    break;
                case "A":
                    monsters = RankA;
                    break;
                case "S":
                    monsters = RankS;
                    break;
                default:
                    monsters = new List<string>();
                    monsters.AddRange(RankB);
                    monsters.AddRange(RankA);
                    monsters.AddRange(RankS);
                    break;
            }

            return monsters;
        }
    }
}