// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Diagnostics;

namespace CodeGen.JsonTypes
{
    [DebuggerDisplay("{Name}")]
    internal record Quantity
    {
        // 0649 Field is never assigned to
#pragma warning disable 0649

        public BaseDimensions BaseDimensions = new(); // Default to empty
        public required string BaseUnit;
        public bool GenerateArithmetic = true;
        public bool Logarithmic = false;
        public int LogarithmicScalingFactor = 1;
        public required string Name { get; init; }
        public Unit[] Units = [];
        public QuantityRelation[] Relations = [];
        public string? XmlDocRemarks;
        public required string XmlDocSummary;
        public string? ObsoleteText;

        // 0649 Field is never assigned to
#pragma warning restore 0649
    }
}
