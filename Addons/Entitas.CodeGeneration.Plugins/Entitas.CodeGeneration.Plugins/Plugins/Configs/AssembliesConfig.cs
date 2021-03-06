﻿using System.Collections.Generic;
using Entitas.Utils;

namespace Entitas.CodeGeneration.Plugins {

    public class AssembliesConfig : AbstractConfigurableConfig {

        const string ASSEMBLIES_KEY = "Entitas.CodeGeneration.Plugins.Assemblies";

        public override Dictionary<string, string> defaultProperties {
            get {
                return new Dictionary<string, string> {
                    { ASSEMBLIES_KEY, "Library/ScriptAssemblies/Assembly-CSharp.dll" }
                };
            }
        }

        public string[] assemblies {
            get { return properties[ASSEMBLIES_KEY].ArrayFromCSV(); }
        }
    }
}
