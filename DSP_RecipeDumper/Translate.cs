﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSP_RecipeDumper
{
    public static class Translate
    {
        static Dictionary<string, string> _dict = new Dictionary<string, string>
        {
            {"item1001",    "iron-ore"},
            {"item1002",    "copper-ore"},
            {"item1003",    "silicium-ore"},
            {"item1004",    "titanium-ore"},
            {"item1005",    "stone-ore"},
            {"item1006",    "coal-ore"},
            {"item1030",    "wood"},
            {"item1031",    "plant-fuel"},
            {"item1011",    "gas-hydrate"},
            {"item1012",    "diamond-ore"},
            {"item1013",    "fractal-silica"},
            {"item1014",    "grating-ore"},
            {"item1015",    "bamboo-crystal"},
            {"item1016",    "mono-mag-ore"},
            {"item1101",    "iron-plate"},
            {"item1104",    "copper-plate"},
            {"item1105",    "silicium-single-crystal"},
            {"item1106",    "titanium-plate"},
            {"item1108",    "stone-brick"},
            {"item1109",    "graphite"},
            {"item1103",    "steel-plate"},
            {"item1107",    "titanium-alloy"},
            {"item1110",    "glass"},
            {"item1119",    "titan-glass"},
            {"item1111",    "prism"},
            {"item1112",    "diamond"},
            {"item1113",    "silicium-high-purity"},
            {"item1201",    "gear-wheel"},
            {"item1102",    "magnet"},
            {"item1202",    "magnetism-wire"},
            {"item1203",    "electric-motor"},
            {"item1204",    "mag-turbine"},
            {"item1205",    "hyper-magnetism-ring"},
            {"item1206",    "partical-capacitor"},
            {"item1127",    "strange-matter-generator"},
            {"item1301",    "circuit-board"},
            {"item1303",    "processor"},
            {"item1305",    "quantum-processor"},
            {"item1302",    "micro-component"},
            {"item1304",    "plane-filter"},
            {"item1402",    "particle-wide-band"},
            {"item1401",    "plasma-generator"},
            {"item1404",    "photo-shifter"},
            {"item1501",    "solar-collector"},
            {"item1000",    "water"},
            {"item1007",    "oil"},
            {"item1114",    "refined-oil"},
            {"item1116",    "sulphuric-acid"},
            {"item1120",    "hydrogen"},
            {"item1121",    "deuterium"},
            {"item1122",    "anti-matter"},
            {"item1208",    "photon-capacitor-full"},
            {"item1801",    "hydrogen-energy-fuel"},
            {"item1802",    "deuterium-energy-fuel"},
            {"item1803",    "antimatter-energy-fuel"},
            {"item1115",    "plastic"},
            {"item1123",    "graphene"},
            {"item1124",    "nanotube"},
            {"item1117",    "crystal-rubber"},
            {"item1118",    "titan-crystal"},
            {"item1126",    "casimir-crystal"},
            {"item1209",    "gravity-lens"},
            {"item1210",    "space-warper"},
            {"item1403",    "fusion-capacitor"},
            {"item1405",    "fuel-thruster"},
            {"item1406",    "ion-thruster"},
            {"item5001",    "logistic-drone"},
            {"item5002",    "logistic-vessel"},
            {"item1125",    "frame-material"},
            {"item1502",    "dyson-sphere-component"},
            {"item1503",    "rocket"},
            {"item1131",    "terrain-tool"},
            {"item1141",    "accelerator-1"},
            {"item1142",    "accelerator-2"},
            {"item1143",    "accelerator-3"},
            {"item2001",    "belt-1"},
            {"item2002",    "belt-2"},
            {"item2003",    "belt-3"},
            {"item2011",    "inserter-1"},
            {"item2012",    "inserter-2"},
            {"item2013",    "inserter-3"},
            {"item2020",    "splitter-4dir"},
            {"item2101",    "storage-1"},
            {"item2102",    "storage-2"},
            {"item2106",    "storage-tank"},
            {"item2303",    "assembler-1"},
            {"item2304",    "assembler-2"},
            {"item2305",    "assembler-3"},
            {"item2201",    "tesla-coil"},
            {"item2202",    "charging-pole"},
            {"item2212",    "orbital-substation"},
            {"item2203",    "wind-turbine"},
            {"item2204",    "fuel-plant"},
            {"item2211",    "fusion-power-station"},
            {"item2301",    "mining-drill"},
            {"item2302",    "smelter"},
            {"item2307",    "oil-extractor"},
            {"item2308",    "oil-refinery"},
            {"item2306",    "water-pump"},
            {"item2309",    "chemical-plant"},
            {"item2314",    "fractionator"},
            {"item2313",    "spray-coater"},
            {"item2205",    "solar-panel"},
            {"item2206",    "accumulator"},
            {"item2207",    "accumulator-full"},
            {"item2311",    "em-rail-ejector"},
            {"item2208",    "ray-receiver"},
            {"item2312",    "vertical-launching-silo"},
            {"item2209",    "energy-exchanger"},
            {"item2310",    "hadron-collider"},
            {"item2210",    "fusion-reactor"},
            {"item2103",    "logistic-station"},
            {"item2104",    "interstellar-logistic-station"},
            {"item2105",    "orbital-collector"},
            {"item2901",    "lab"},
            {"item6001",    "t-matrix"},
            {"item6002",    "e-matrix"},
            {"item6003",    "c-matrix"},
            {"item6004",    "i-matrix"},
            {"item6005",    "g-matrix"},
            {"item6006",    "u-matrix"},
            {"recipe1",     "iron-plate"},
            {"recipe2",     "magnet"},
            {"recipe3",     "copper-plate"},
            {"recipe4",     "stone-brick"},
            {"recipe5",     "gear-wheel"},
            {"recipe6",     "magnetism-wire"},
            {"recipe7",     "wind-turbine"},
            {"recipe8",     "tesla-coil"},
            {"recipe9",     "t-matrix"},
            {"recipe10",    "lab"},
            {"recipe11",    "prism"},
            {"recipe12",    "plasma-generator"},
            {"recipe13",    "charging-pole"},
            {"recipe14",    "oil-extractor"},
            {"recipe15",    "oil-refinery"},
            {"recipe16",    "plasma-refining"},
            {"recipe17",    "graphite"},
            {"recipe18",    "e-matrix"},
            {"recipe19",    "hydrogen-energy-fuel"},
            {"recipe20",    "fuel-thruster"},
            {"recipe21",    "ion-thruster"},
            {"recipe22",    "chemical-plant"},
            {"recipe23",    "plastic"},
            {"recipe24",    "sulphuric-acid"},
            {"recipe25",    "crystal-rubber"},
            {"recipe26",    "titan-crystal"},
            {"recipe27",    "c-matrix"},
            {"recipe28",    "casimir-crystal"},
            {"recipe29",    "casimir-crystal-lv2"},
            {"recipe30",    "titan-glass"},
            {"recipe31",    "graphene"},
            {"recipe32",    "graphene-lv2"},
            {"recipe33",    "nanotube"},
            {"recipe34",    "silicium-ore"},
            {"recipe35",    "nanotube-lv2"},
            {"recipe36",    "particle-wide-band"},
            {"recipe37",    "silicium-high-purity"},
            {"recipe38",    "plane-filter"},
            {"recipe39",    "hadron-collider"},
            {"recipe40",    "deuterium"},
            {"recipe41",    "deuterium-energy-fuel"},
            {"recipe42",    "fusion-capacitor"},
            {"recipe43",    "fusion-reactor"},
            {"recipe44",    "antimatter-energy-fuel"},
            {"recipe45",    "assembler-1"},
            {"recipe46",    "assembler-2"},
            {"recipe47",    "assembler-3"},
            {"recipe48",    "mining-drill"},
            {"recipe49",    "water-pump"},
            {"recipe50",    "circuit-board"},
            {"recipe51",    "processor"},
            {"recipe52",    "quantum-processor"},
            {"recipe53",    "micro-component"},
            {"recipe54",    "crystal-rubber-lv0"},
            {"recipe55",    "i-matrix"},
            {"recipe56",    "smelter"},
            {"recipe57",    "glass"},
            {"recipe58",    "x-ray"},
            {"recipe59",    "silicium-single-crystal"},
            {"recipe60",    "diamond"},
            {"recipe61",    "diamond-lv2"},
            {"recipe62",    "silicium-high-purity-lv2"},
            {"recipe63",    "steel-plate"},
            {"recipe64",    "fuel-plant"},
            {"recipe65",    "titanium-plate"},
            {"recipe66",    "titanium-alloy"},
            {"recipe67",    "solar-panel"},
            {"recipe68",    "photo-shifter"},
            {"recipe69",    "photo-shifter-lv2"},
            {"recipe70",    "solar-collector"},
            {"recipe71",    "em-rail-ejector"},
            {"recipe72",    "ray-receiver"},
            {"recipe73",    "orbital-substation"},
            {"recipe74",    "photon-formula"},
            {"recipe75",    "u-matrix"},
            {"recipe76",    "accumulator"},
            {"recipe77",    "energy-exchanger"},
            {"recipe78",    "space-warper"},
            {"recipe79",    "space-warper-lv2"},
            {"recipe80",    "frame-material"},
            {"recipe81",    "dyson-sphere-component"},
            {"recipe82",    "vertical-launching-silo"},
            {"recipe83",    "rocket"},
            {"recipe84",    "belt-1"},
            {"recipe85",    "inserter-1"},
            {"recipe86",    "storage-1"},
            {"recipe87",    "splitter-4dir"},
            {"recipe88",    "inserter-2"},
            {"recipe89",    "belt-2"},
            {"recipe90",    "inserter-3"},
            {"recipe91",    "storage-2"},
            {"recipe92",    "belt-3"},
            {"recipe93",    "logistic-station"},
            {"recipe94",    "logistic-drone"},
            {"recipe95",    "interstellar-logistic-station"},
            {"recipe96",    "logistic-vessel"},
            {"recipe97",    "electric-motor"},
            {"recipe98",    "mag-turbine"},
            {"recipe99",    "partical-capacitor"},
            {"recipe100",   "partical-capacitor-lv2"},
            {"recipe101",   "gravity-lens"},
            {"recipe102",   "g-matrix"},
            {"recipe103",   "hyper-magnetism-ring"},
            {"recipe104",   "strange-matter-generator"},
            {"recipe106",   "accelerator-1"},
            {"recipe107",   "accelerator-2"},
            {"recipe108",   "accelerator-3"},
            {"recipe109",   "spray-coater"},
            {"recipe110",   "fractionator"},
            {"recipe111",   "orbital-collector"},
            {"recipe112",   "terrain-tool"},
            {"recipe113",   "fusion-power-station"},
            {"recipe114",   "storage-tank"},
            {"recipe115",   "deuterium-formula"},
            {"miner1",      "water" },
            {"miner2",      "vein" },
            {"miner3",      "oil" },
            {"assemble1",   "smelt" },
            {"assemble2",   "chemical" },
            {"assemble3",   "refine" },
            {"assemble4",   "assemble" },
            {"assemble5",   "particle" },
            {"assemble6",   "exchange" },
            {"assemble7",   "photonstore" },
            {"assemble8",   "fractionate" },
            {"assemble15",  "research" }
        };

        public static string Get(string key)
        {
            string result;
            return _dict.TryGetValue(key, out result) ? result : key;
        }
    }
}
