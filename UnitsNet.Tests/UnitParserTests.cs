﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Globalization;
using UnitsNet.Tests.CustomQuantities;
using UnitsNet.Units;
using Xunit;

namespace UnitsNet.Tests
{
    public class UnitParserTests
    {
        [Theory]
        [InlineData("m^^2", AreaUnit.SquareMeter)]
        [InlineData("cm^^2", AreaUnit.SquareCentimeter)]
        public void Parse_ReturnsUnitMappedByCustomAbbreviation(string customAbbreviation, AreaUnit expected)
        {
            var abbrevCache = new UnitAbbreviationsCache();
            abbrevCache.MapUnitToAbbreviation(expected, customAbbreviation);
            var parser = new UnitParser(abbrevCache);

            var actual = parser.Parse<AreaUnit>(customAbbreviation);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Parse_AbbreviationCaseInsensitive_Lowercase_years()
        {
            var abbreviation = "years";
            var expected = DurationUnit.Year365;
            var parser = UnitsNetSetup.Default.UnitParser;

            var actual = parser.Parse<DurationUnit>(abbreviation);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Parse_AbbreviationCaseInsensitive_Uppercase_Years()
        {
            var abbreviation = "Years";
            var expected = DurationUnit.Year365;
            var parser = UnitsNetSetup.Default.UnitParser;

            var actual = parser.Parse<DurationUnit>(abbreviation);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Parse_GivenAbbreviationsThatAreAmbiguousWhenLowerCase_ReturnsCorrectUnit()
        {
            Assert.Equal(PressureUnit.Megabar, Pressure.ParseUnit("Mbar"));
            Assert.Equal(PressureUnit.Millibar, Pressure.ParseUnit("mbar"));
        }

        [Fact]
        public void Parse_UnknownAbbreviationThrowsUnitNotFoundException()
        {
            Assert.Throws<UnitNotFoundException>(() => UnitsNetSetup.Default.UnitParser.Parse<AreaUnit>("nonexistingunit"));
        }

        [Theory]
        [InlineData("m", typeof(LengthUnit), LengthUnit.Meter)]
        [InlineData("m^1", typeof(LengthUnit), LengthUnit.Meter)]
        [InlineData("m²", typeof(AreaUnit), AreaUnit.SquareMeter)]
        [InlineData("m^2", typeof(AreaUnit), AreaUnit.SquareMeter)]
        [InlineData("m³", typeof(VolumeUnit), VolumeUnit.CubicMeter)]
        [InlineData("m^3", typeof(VolumeUnit), VolumeUnit.CubicMeter)]
        [InlineData("m⁴", typeof(AreaMomentOfInertiaUnit), AreaMomentOfInertiaUnit.MeterToTheFourth)]
        [InlineData("m^4", typeof(AreaMomentOfInertiaUnit), AreaMomentOfInertiaUnit.MeterToTheFourth)]
        [InlineData("K⁻¹", typeof(CoefficientOfThermalExpansionUnit), CoefficientOfThermalExpansionUnit.PerKelvin)]
        [InlineData("K^-1", typeof(CoefficientOfThermalExpansionUnit), CoefficientOfThermalExpansionUnit.PerKelvin)]
        [InlineData("kg·s⁻¹·m⁻²", typeof(MassFluxUnit), MassFluxUnit.KilogramPerSecondPerSquareMeter)]
        [InlineData("kg·s^-1·m^-2", typeof(MassFluxUnit), MassFluxUnit.KilogramPerSecondPerSquareMeter)]
        public void Parse_CanParseUnitsWithPowers(string unitAbbreviation, Type unitType, Enum resultUnitType)
        {
            Assert.Equal(resultUnitType, UnitsNetSetup.Default.UnitParser.Parse(unitAbbreviation, unitType));
        }

        [Theory]
        [InlineData("kg·s⁻¹·m⁻²", typeof(MassFluxUnit), MassFluxUnit.KilogramPerSecondPerSquareMeter)]
        [InlineData("kg*s⁻¹*m⁻²", typeof(MassFluxUnit), MassFluxUnit.KilogramPerSecondPerSquareMeter)]
        [InlineData("kg·s⁻¹*m⁻²", typeof(MassFluxUnit), MassFluxUnit.KilogramPerSecondPerSquareMeter)]
        public void Parse_CanParseMultiplySigns(string unitAbbreviation, Type unitType, Enum resultUnitType)
        {
            Assert.Equal(resultUnitType, UnitsNetSetup.Default.UnitParser.Parse(unitAbbreviation, unitType));
        }

        [Theory]
        [InlineData(" kg·s⁻¹·m⁻²", typeof(MassFluxUnit), MassFluxUnit.KilogramPerSecondPerSquareMeter)]
        [InlineData("kg·s⁻¹·m⁻² ", typeof(MassFluxUnit), MassFluxUnit.KilogramPerSecondPerSquareMeter)]
        [InlineData("k g · s ⁻ ¹ · m ⁻ ² ", typeof(MassFluxUnit), MassFluxUnit.KilogramPerSecondPerSquareMeter)]
        [InlineData("   k   g   ·   s   ⁻   ¹   ·   m   ⁻   ²   ", typeof(MassFluxUnit), MassFluxUnit.KilogramPerSecondPerSquareMeter)]
        public void Parse_CanParseWithWithspacesInUnit(string unitAbbreviation, Type unitType, Enum resultUnitType)
        {
            Assert.Equal(resultUnitType, UnitsNetSetup.Default.UnitParser.Parse(unitAbbreviation, unitType));
        }

        [Fact]
        public void Parse_AmbiguousUnitsThrowsException()
        {
            // Act 1
            var exception1 = Assert.Throws<AmbiguousUnitParseException>(() => UnitsNetSetup.Default.UnitParser.Parse<LengthUnit>("pt"));

            // Act 2
            var exception2 = Assert.Throws<AmbiguousUnitParseException>(() => Length.Parse("1 pt", CultureInfo.InvariantCulture));

            // Assert
            Assert.Equal("Cannot parse \"pt\" since it could be either of these: DtpPoint, PrinterPoint", exception1.Message);
            Assert.Equal("Cannot parse \"pt\" since it could be either of these: DtpPoint, PrinterPoint", exception2.Message);
        }

        [Theory]
        [InlineData("ng", "en-US", MassUnit.Nanogram)]
        [InlineData("нг", "ru-RU", MassUnit.Nanogram)]
        [InlineData("g", "en-US", MassUnit.Gram)]
        [InlineData("г", "ru-RU", MassUnit.Gram)]
        [InlineData("kg", "en-US", MassUnit.Kilogram)]
        [InlineData("кг", "ru-RU", MassUnit.Kilogram)]
        public void ParseMassUnit_GivenCulture(string str, string cultureName, Enum expectedUnit)
        {
            Assert.Equal(expectedUnit, UnitsNetSetup.Default.UnitParser.Parse<MassUnit>(str, CultureInfo.GetCultureInfo(cultureName)));
        }

        [Fact]
        public void Parse_MappedCustomUnit()
        {
            var unitAbbreviationsCache = new UnitAbbreviationsCache();
            unitAbbreviationsCache.MapUnitToAbbreviation(HowMuchUnit.Some, "fooh");
            var unitParser = new UnitParser(unitAbbreviationsCache);

            var parsedUnit = unitParser.Parse<HowMuchUnit>("fooh");

            Assert.Equal(HowMuchUnit.Some, parsedUnit);
        }

        [Fact]
        public void Parse_LengthUnit_MM_ThrowsExceptionDescribingTheAmbiguity()
        {
            var ex = Assert.Throws<AmbiguousUnitParseException>(() => UnitsNetSetup.Default.UnitParser.Parse<LengthUnit>("MM"));
            Assert.Contains("Cannot parse \"MM\" since it matched multiple units [Millimeter, Megameter] with case-insensitive comparison, but zero units with case-sensitive comparison. To resolve the ambiguity, pass a unit abbreviation with the correct casing.", ex.Message);
        }

    }
}
