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

namespace UnitsNet.NumberExtensions.NumberToAngle
{
    /// <summary>
    /// A number to Angle Extensions
    /// </summary>
    public static class NumberToAngleExtensions
    {
        /// <inheritdoc cref="Angle.FromArcminutes(double)" />
        public static Angle Arcminutes<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Angle.FromArcminutes(double.CreateChecked(value));
#else
            , IConvertible
            => Angle.FromArcminutes(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Angle.FromArcseconds(double)" />
        public static Angle Arcseconds<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Angle.FromArcseconds(double.CreateChecked(value));
#else
            , IConvertible
            => Angle.FromArcseconds(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Angle.FromCentiradians(double)" />
        public static Angle Centiradians<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Angle.FromCentiradians(double.CreateChecked(value));
#else
            , IConvertible
            => Angle.FromCentiradians(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Angle.FromDeciradians(double)" />
        public static Angle Deciradians<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Angle.FromDeciradians(double.CreateChecked(value));
#else
            , IConvertible
            => Angle.FromDeciradians(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Angle.FromDegrees(double)" />
        public static Angle Degrees<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Angle.FromDegrees(double.CreateChecked(value));
#else
            , IConvertible
            => Angle.FromDegrees(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Angle.FromGradians(double)" />
        public static Angle Gradians<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Angle.FromGradians(double.CreateChecked(value));
#else
            , IConvertible
            => Angle.FromGradians(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Angle.FromMicrodegrees(double)" />
        public static Angle Microdegrees<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Angle.FromMicrodegrees(double.CreateChecked(value));
#else
            , IConvertible
            => Angle.FromMicrodegrees(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Angle.FromMicroradians(double)" />
        public static Angle Microradians<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Angle.FromMicroradians(double.CreateChecked(value));
#else
            , IConvertible
            => Angle.FromMicroradians(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Angle.FromMillidegrees(double)" />
        public static Angle Millidegrees<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Angle.FromMillidegrees(double.CreateChecked(value));
#else
            , IConvertible
            => Angle.FromMillidegrees(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Angle.FromMilliradians(double)" />
        public static Angle Milliradians<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Angle.FromMilliradians(double.CreateChecked(value));
#else
            , IConvertible
            => Angle.FromMilliradians(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Angle.FromNanodegrees(double)" />
        public static Angle Nanodegrees<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Angle.FromNanodegrees(double.CreateChecked(value));
#else
            , IConvertible
            => Angle.FromNanodegrees(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Angle.FromNanoradians(double)" />
        public static Angle Nanoradians<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Angle.FromNanoradians(double.CreateChecked(value));
#else
            , IConvertible
            => Angle.FromNanoradians(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Angle.FromNatoMils(double)" />
        public static Angle NatoMils<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Angle.FromNatoMils(double.CreateChecked(value));
#else
            , IConvertible
            => Angle.FromNatoMils(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Angle.FromRadians(double)" />
        public static Angle Radians<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Angle.FromRadians(double.CreateChecked(value));
#else
            , IConvertible
            => Angle.FromRadians(value.ToDouble(null));
#endif

        /// <inheritdoc cref="Angle.FromRevolutions(double)" />
        public static Angle Revolutions<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
            => Angle.FromRevolutions(double.CreateChecked(value));
#else
            , IConvertible
            => Angle.FromRevolutions(value.ToDouble(null));
#endif

    }
}
