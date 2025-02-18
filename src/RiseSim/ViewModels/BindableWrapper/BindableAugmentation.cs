﻿using Prism.Mvvm;
using SimModel.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiseSim.ViewModels.BindableWrapper
{
    internal class BindableAugmentation : BindableBase
    {
        // 管理用装備名(GUID)
        public string Name { get; set; } = string.Empty;

        // 表示用装備名
        public string DispName { get; set; } = string.Empty;

        // 装備種類
        public EquipKind Kind { get; set; }

        // 装備種類(文字列)
        public string KindStr { get; set; }

        // ベース装備名
        public string BaseName { get; set; } = string.Empty;

        // スロット1つ目
        public int Slot1 { get; set; }

        // スロット2つ目
        public int Slot2 { get; set; }

        // スロット3つ目
        public int Slot3 { get; set; }

        // スロット表示
        public string SlotDisp { get; set; }

        // 防御力増減
        public int Def { get; set; }

        // 火耐性増減
        public int Fire { get; set; }

        // 水耐性増減
        public int Water { get; set; }

        // 雷耐性増減
        public int Thunder { get; set; }

        // 氷耐性増減
        public int Ice { get; set; }

        // 龍耐性増減
        public int Dragon { get; set; }

        // 追加スキル
        public ObservableCollection<BindableSkill> Skills { get; set; } = new();

        // スキルのCSV形式
        public string SkillsDisp { get; set; }

        // オリジナル
        public Augmentation Original { get; set; }

        // コンストラクタ
        public BindableAugmentation(Augmentation aug)
        {
            Name = aug.Name;
            DispName = aug.DispName;
            Kind = aug.Kind;
            KindStr = aug.KindStr;
            BaseName = aug.BaseName;
            Slot1 = aug.Slot1;
            Slot2 = aug.Slot2;
            Slot3 = aug.Slot3;
            SlotDisp = aug.SlotDisp;
            Def = aug.Def;
            Fire = aug.Fire;
            Water = aug.Water;
            Thunder = aug.Thunder;
            Ice = aug.Ice;
            Dragon = aug.Dragon;
            Skills = BindableSkill.BeBindableList(aug.Skills);
            SkillsDisp = aug.SkillsDisp;
            Original = aug;
        }

        // リストをまとめてバインド用クラスに変換
        static public ObservableCollection<BindableAugmentation> BeBindableList(List<Augmentation> list)
        {
            ObservableCollection<BindableAugmentation> bindableList = new ObservableCollection<BindableAugmentation>();
            foreach (var aug in list)
            {
                bindableList.Add(new BindableAugmentation(aug));
            }
            return bindableList;
        }
    }
}
