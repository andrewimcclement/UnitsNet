//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;

#if NET7_0_OR_GREATER
using System.Numerics;
#endif

#nullable enable

namespace UnitsNet.NumberExtensions.NumberToElectricApparentPower
{
    /// <summary>
    /// A number to ElectricApparentPower Extensions
    /// </summary>
    public static class NumberToElectricApparentPowerExtensions
    {
        /// <inheritdoc cref="ElectricApparentPower.FromGigavoltamperes(double)" />
        public static ElectricApparentPower Gigavoltamperes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => ElectricApparentPower.FromGigavoltamperes(double.CreateChecked(value));
#else
            , IConvertible
            => ElectricApparentPower.FromGigavoltamperes(value.ToDouble(null));
#endif

        /// <inheritdoc cref="ElectricApparentPower.FromKilovoltamperes(double)" />
        public static ElectricApparentPower Kilovoltamperes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => ElectricApparentPower.FromKilovoltamperes(double.CreateChecked(value));
#else
            , IConvertible
            => ElectricApparentPower.FromKilovoltamperes(value.ToDouble(null));
#endif

        /// <inheritdoc cref="ElectricApparentPower.FromMegavoltamperes(double)" />
        public static ElectricApparentPower Megavoltamperes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => ElectricApparentPower.FromMegavoltamperes(double.CreateChecked(value));
#else
            , IConvertible
            => ElectricApparentPower.FromMegavoltamperes(value.ToDouble(null));
#endif

        /// <inheritdoc cref="ElectricApparentPower.FromMicrovoltamperes(double)" />
        public static ElectricApparentPower Microvoltamperes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => ElectricApparentPower.FromMicrovoltamperes(double.CreateChecked(value));
#else
            , IConvertible
            => ElectricApparentPower.FromMicrovoltamperes(value.ToDouble(null));
#endif

        /// <inheritdoc cref="ElectricApparentPower.FromMillivoltamperes(double)" />
        public static ElectricApparentPower Millivoltamperes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => ElectricApparentPower.FromMillivoltamperes(double.CreateChecked(value));
#else
            , IConvertible
            => ElectricApparentPower.FromMillivoltamperes(value.ToDouble(null));
#endif

        /// <inheritdoc cref="ElectricApparentPower.FromVoltamperes(double)" />
        public static ElectricApparentPower Voltamperes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => ElectricApparentPower.FromVoltamperes(double.CreateChecked(value));
#else
            , IConvertible
            => ElectricApparentPower.FromVoltamperes(value.ToDouble(null));
#endif

    }
}
