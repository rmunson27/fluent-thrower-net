using Rem.Core.Attributes;
using Rem.Core.Utilities.FluentThrower.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Rem.Core.Utilities.FluentThrower.Extensions;

#pragma warning disable 1573 // Doc comments are inherited except for the supplied <param> tag
/// <summary>
/// A series of extension methods offering a simple fluent API for throwing exceptions relating to invalid
/// numerical ranges.
/// </summary>
public static class NumericRangeThrowerExtensions
{
    #region INumberInfo
    #region Byte
    /// <inheritdoc cref="NumberInfoThrow.IfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonZero]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte IfArgZero(
        this INumericRangeThrower _,
        byte paramValue, string paramName, string? message = null)
        => NumberInfoThrow.IfArgZero(NumberInfo.Byte, paramValue, paramName, message);

    /// <inheritdoc cref="NumberInfoThrow.IfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonZero]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte IfPropSetZero(
        this INumericRangeThrower _,
        byte propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => NumberInfoThrow.IfPropSetZero(NumberInfo.Byte, propSetValue, propName!, message);
    #endregion

    #region UShort
    /// <inheritdoc cref="NumberInfoThrow.IfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonZero]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort IfArgZero(
        this INumericRangeThrower _,
        ushort paramValue, string paramName, string? message = null)
        => NumberInfoThrow.IfArgZero(NumberInfo.UShort, paramValue, paramName, message);

    /// <inheritdoc cref="NumberInfoThrow.IfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonZero]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort IfPropSetZero(
        this INumericRangeThrower _,
        ushort propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => NumberInfoThrow.IfPropSetZero(NumberInfo.UShort, propSetValue, propName!, message);
    #endregion

    #region UInt
    /// <inheritdoc cref="NumberInfoThrow.IfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonZero]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint IfArgZero(
        this INumericRangeThrower _,
        uint paramValue, string paramName, string? message = null)
        => NumberInfoThrow.IfArgZero(NumberInfo.UInt, paramValue, paramName, message);

    /// <inheritdoc cref="NumberInfoThrow.IfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonZero]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint IfPropSetZero(
        this INumericRangeThrower _,
        uint propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => NumberInfoThrow.IfPropSetZero(NumberInfo.UInt, propSetValue, propName!, message);
    #endregion

    #region ULong
    /// <inheritdoc cref="NumberInfoThrow.IfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonZero]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ulong IfArgZero(
        this INumericRangeThrower _,
        ulong paramValue, string paramName, string? message = null)
        => NumberInfoThrow.IfArgZero(NumberInfo.ULong, paramValue, paramName, message);

    /// <inheritdoc cref="NumberInfoThrow.IfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonZero]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ulong IfPropSetZero(
        this INumericRangeThrower _,
        ulong propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => NumberInfoThrow.IfPropSetZero(NumberInfo.ULong, propSetValue, propName!, message);
    #endregion
    #endregion

    #region ISignInfo
    #region SByte
    #region Arguments
    /// <inheritdoc cref="SignInfoThrow.IfArgNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonNegative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte IfArgNegative(
        this INumericRangeThrower _,
        sbyte paramValue, string paramName, string? message = null)
        => SignInfoThrow.IfArgNegative(NumberInfo.SByte, paramValue, paramName, message);

    /// <inheritdoc cref="SignInfoThrow.IfArgNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Positive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte IfArgNotPositive(
        this INumericRangeThrower _,
        sbyte paramValue, string paramName, string? message = null)
        => SignInfoThrow.IfArgNotPositive(NumberInfo.SByte, paramValue, paramName, message);

    /// <inheritdoc cref="NumberInfoThrow.IfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonZero]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte IfArgZero(
        this INumericRangeThrower _,
        sbyte paramValue, string paramName, string? message = null)
        => NumberInfoThrow.IfArgZero(NumberInfo.SByte, paramValue, paramName, message);

    /// <inheritdoc cref="SignInfoThrow.IfArgNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Negative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte IfArgNotNegative(
        this INumericRangeThrower _,
        sbyte paramValue, string paramName, string? message = null)
        => SignInfoThrow.IfArgNotNegative(NumberInfo.SByte, paramValue, paramName, message);

    /// <inheritdoc cref="SignInfoThrow.IfArgPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonPositive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte IfArgPositive(
        this INumericRangeThrower _,
        sbyte paramValue, string paramName, string? message = null)
        => SignInfoThrow.IfArgPositive(NumberInfo.SByte, paramValue, paramName, message);
    #endregion

    #region Properties
    /// <inheritdoc cref="SignInfoThrow.IfPropSetNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonNegative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte IfPropSetNegative(
        this INumericRangeThrower _,
        sbyte propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => SignInfoThrow.IfPropSetNegative(NumberInfo.SByte, propSetValue, propName!, message);

    /// <inheritdoc cref="SignInfoThrow.IfPropSetNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Positive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte IfPropSetNotPositive(
        this INumericRangeThrower _,
        sbyte propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => SignInfoThrow.IfPropSetNotPositive(NumberInfo.SByte, propSetValue, propName!, message);

    /// <inheritdoc cref="NumberInfoThrow.IfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonZero]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte IfPropSetZero(
        this INumericRangeThrower _,
        sbyte propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => NumberInfoThrow.IfPropSetZero(NumberInfo.SByte, propSetValue, propName!, message);

    /// <inheritdoc cref="SignInfoThrow.IfPropSetNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Negative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte IfPropSetNotNegative(
        this INumericRangeThrower _,
        sbyte propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => SignInfoThrow.IfPropSetNotNegative(NumberInfo.SByte, propSetValue, propName!, message);

    /// <inheritdoc cref="SignInfoThrow.IfPropSetPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonPositive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte IfPropSetPositive(
        this INumericRangeThrower _,
        sbyte propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => SignInfoThrow.IfPropSetPositive(NumberInfo.SByte, propSetValue, propName!, message);
    #endregion
    #endregion

    #region Short
    #region Arguments
    /// <inheritdoc cref="SignInfoThrow.IfArgNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonNegative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short IfArgNegative(
        this INumericRangeThrower _,
        short paramValue, string paramName, string? message = null)
        => SignInfoThrow.IfArgNegative(NumberInfo.Short, paramValue, paramName, message);

    /// <inheritdoc cref="SignInfoThrow.IfArgNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Positive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short IfArgNotPositive(
        this INumericRangeThrower _,
        short paramValue, string paramName, string? message = null)
        => SignInfoThrow.IfArgNotPositive(NumberInfo.Short, paramValue, paramName, message);

    /// <inheritdoc cref="NumberInfoThrow.IfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonZero]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short IfArgZero(
        this INumericRangeThrower _,
        short paramValue, string paramName, string? message = null)
        => NumberInfoThrow.IfArgZero(NumberInfo.Short, paramValue, paramName, message);

    /// <inheritdoc cref="SignInfoThrow.IfArgNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Negative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short IfArgNotNegative(
        this INumericRangeThrower _,
        short paramValue, string paramName, string? message = null)
        => SignInfoThrow.IfArgNotNegative(NumberInfo.Short, paramValue, paramName, message);

    /// <inheritdoc cref="SignInfoThrow.IfArgPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonPositive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short IfArgPositive(
        this INumericRangeThrower _,
        short paramValue, string paramName, string? message = null)
        => SignInfoThrow.IfArgPositive(NumberInfo.Short, paramValue, paramName, message);
    #endregion

    #region Properties
    /// <inheritdoc cref="SignInfoThrow.IfPropSetNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonNegative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short IfPropSetNegative(
        this INumericRangeThrower _,
        short propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => SignInfoThrow.IfPropSetNegative(NumberInfo.Short, propSetValue, propName!, message);

    /// <inheritdoc cref="SignInfoThrow.IfPropSetNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Positive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short IfPropSetNotPositive(
        this INumericRangeThrower _,
        short propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => SignInfoThrow.IfPropSetNotPositive(NumberInfo.Short, propSetValue, propName!, message);

    /// <inheritdoc cref="NumberInfoThrow.IfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonZero]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short IfPropSetZero(
        this INumericRangeThrower _,
        short propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => NumberInfoThrow.IfPropSetZero(NumberInfo.Short, propSetValue, propName!, message);

    /// <inheritdoc cref="SignInfoThrow.IfPropSetNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Negative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short IfPropSetNotNegative(
        this INumericRangeThrower _,
        short propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => SignInfoThrow.IfPropSetNotNegative(NumberInfo.Short, propSetValue, propName!, message);

    /// <inheritdoc cref="SignInfoThrow.IfPropSetPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonPositive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short IfPropSetPositive(
        this INumericRangeThrower _,
        short propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => SignInfoThrow.IfPropSetPositive(NumberInfo.Short, propSetValue, propName!, message);
    #endregion
    #endregion

    #region Int
    #region Arguments
    /// <inheritdoc cref="SignInfoThrow.IfArgNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonNegative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IfArgNegative(
        this INumericRangeThrower _,
        int paramValue, string paramName, string? message = null)
        => SignInfoThrow.IfArgNegative(NumberInfo.Int, paramValue, paramName, message);

    /// <inheritdoc cref="SignInfoThrow.IfArgNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Positive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IfArgNotPositive(
        this INumericRangeThrower _,
        int paramValue, string paramName, string? message = null)
        => SignInfoThrow.IfArgNotPositive(NumberInfo.Int, paramValue, paramName, message);

    /// <inheritdoc cref="NumberInfoThrow.IfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonZero]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IfArgZero(
        this INumericRangeThrower _,
        int paramValue, string paramName, string? message = null)
        => NumberInfoThrow.IfArgZero(NumberInfo.Int, paramValue, paramName, message);

    /// <inheritdoc cref="SignInfoThrow.IfArgNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Negative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IfArgNotNegative(
        this INumericRangeThrower _,
        int paramValue, string paramName, string? message = null)
        => SignInfoThrow.IfArgNotNegative(NumberInfo.Int, paramValue, paramName, message);

    /// <inheritdoc cref="SignInfoThrow.IfArgPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonPositive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IfArgPositive(
        this INumericRangeThrower _,
        int paramValue, string paramName, string? message = null)
        => SignInfoThrow.IfArgPositive(NumberInfo.Int, paramValue, paramName, message);
    #endregion

    #region Properties
    /// <inheritdoc cref="SignInfoThrow.IfPropSetNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonNegative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IfPropSetNegative(
        this INumericRangeThrower _,
        int propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => SignInfoThrow.IfPropSetNegative(NumberInfo.Int, propSetValue, propName!, message);

    /// <inheritdoc cref="SignInfoThrow.IfPropSetNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Positive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IfPropSetNotPositive(
        this INumericRangeThrower _,
        int propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => SignInfoThrow.IfPropSetNotPositive(NumberInfo.Int, propSetValue, propName!, message);

    /// <inheritdoc cref="NumberInfoThrow.IfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonZero]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IfPropSetZero(
        this INumericRangeThrower _,
        int propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => NumberInfoThrow.IfPropSetZero(NumberInfo.Int, propSetValue, propName!, message);

    /// <inheritdoc cref="SignInfoThrow.IfPropSetNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Negative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IfPropSetNotNegative(
        this INumericRangeThrower _,
        int propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => SignInfoThrow.IfPropSetNotNegative(NumberInfo.Int, propSetValue, propName!, message);

    /// <inheritdoc cref="SignInfoThrow.IfPropSetPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonPositive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IfPropSetPositive(
        this INumericRangeThrower _,
        int propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => SignInfoThrow.IfPropSetPositive(NumberInfo.Int, propSetValue, propName!, message);
    #endregion
    #endregion

    #region Long
    #region Arguments
    /// <inheritdoc cref="SignInfoThrow.IfArgNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonNegative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long IfArgNegative(
        this INumericRangeThrower _,
        long paramValue, string paramName, string? message = null)
        => SignInfoThrow.IfArgNegative(NumberInfo.Long, paramValue, paramName, message);

    /// <inheritdoc cref="SignInfoThrow.IfArgNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Positive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long IfArgNotPositive(
        this INumericRangeThrower _,
        long paramValue, string paramName, string? message = null)
        => SignInfoThrow.IfArgNotPositive(NumberInfo.Long, paramValue, paramName, message);

    /// <inheritdoc cref="NumberInfoThrow.IfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonZero]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long IfArgZero(
        this INumericRangeThrower _,
        long paramValue, string paramName, string? message = null)
        => NumberInfoThrow.IfArgZero(NumberInfo.Long, paramValue, paramName, message);

    /// <inheritdoc cref="SignInfoThrow.IfArgNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Negative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long IfArgNotNegative(
        this INumericRangeThrower _,
        long paramValue, string paramName, string? message = null)
        => SignInfoThrow.IfArgNotNegative(NumberInfo.Long, paramValue, paramName, message);

    /// <inheritdoc cref="SignInfoThrow.IfArgPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonPositive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long IfArgPositive(
        this INumericRangeThrower _,
        long paramValue, string paramName, string? message = null)
        => SignInfoThrow.IfArgPositive(NumberInfo.Long, paramValue, paramName, message);
    #endregion

    #region Properties
    /// <inheritdoc cref="SignInfoThrow.IfPropSetNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonNegative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long IfPropSetNegative(
        this INumericRangeThrower _,
        long propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => SignInfoThrow.IfPropSetNegative(NumberInfo.Long, propSetValue, propName!, message);

    /// <inheritdoc cref="SignInfoThrow.IfPropSetNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Positive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long IfPropSetNotPositive(
        this INumericRangeThrower _,
        long propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => SignInfoThrow.IfPropSetNotPositive(NumberInfo.Long, propSetValue, propName!, message);

    /// <inheritdoc cref="NumberInfoThrow.IfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonZero]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long IfPropSetZero(
        this INumericRangeThrower _,
        long propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => NumberInfoThrow.IfPropSetZero(NumberInfo.Long, propSetValue, propName!, message);

    /// <inheritdoc cref="SignInfoThrow.IfPropSetNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Negative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long IfPropSetNotNegative(
        this INumericRangeThrower _,
        long propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => SignInfoThrow.IfPropSetNotNegative(NumberInfo.Long, propSetValue, propName!, message);

    /// <inheritdoc cref="SignInfoThrow.IfPropSetPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonPositive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long IfPropSetPositive(
        this INumericRangeThrower _,
        long propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => SignInfoThrow.IfPropSetPositive(NumberInfo.Long, propSetValue, propName!, message);
    #endregion
    #endregion

    #region BigInteger
    #region Arguments
    /// <inheritdoc cref="SignInfoThrow.IfArgNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonNegative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BigInteger IfArgNegative(
        this INumericRangeThrower _,
        in BigInteger paramValue, string paramName, string? message = null)
        => SignInfoThrow.IfArgNegative(NumberInfo.BigInteger, paramValue, paramName, message);

    /// <inheritdoc cref="SignInfoThrow.IfArgNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Positive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BigInteger IfArgNotPositive(
        this INumericRangeThrower _,
        BigInteger paramValue, string paramName, string? message = null)
        => SignInfoThrow.IfArgNotPositive(NumberInfo.BigInteger, paramValue, paramName, message);

    /// <inheritdoc cref="NumberInfoThrow.IfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonZero]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BigInteger IfArgZero(
        this INumericRangeThrower _,
        BigInteger paramValue, string paramName, string? message = null)
        => NumberInfoThrow.IfArgZero(NumberInfo.BigInteger, paramValue, paramName, message);

    /// <inheritdoc cref="SignInfoThrow.IfArgNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Negative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BigInteger IfArgNotNegative(
        this INumericRangeThrower _,
        BigInteger paramValue, string paramName, string? message = null)
        => SignInfoThrow.IfArgNotNegative(NumberInfo.BigInteger, paramValue, paramName, message);

    /// <inheritdoc cref="SignInfoThrow.IfArgPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonPositive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BigInteger IfArgPositive(
        this INumericRangeThrower _,
        BigInteger paramValue, string paramName, string? message = null)
        => SignInfoThrow.IfArgPositive(NumberInfo.BigInteger, paramValue, paramName, message);
    #endregion

    #region Properties
    /// <inheritdoc cref="SignInfoThrow.IfPropSetNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonNegative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BigInteger IfPropSetNegative(
        this INumericRangeThrower _,
        BigInteger propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => SignInfoThrow.IfPropSetNegative(NumberInfo.BigInteger, propSetValue, propName!, message);

    /// <inheritdoc cref="SignInfoThrow.IfPropSetNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Positive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BigInteger IfPropSetNotPositive(
        this INumericRangeThrower _,
        BigInteger propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => SignInfoThrow.IfPropSetNotPositive(NumberInfo.BigInteger, propSetValue, propName!, message);

    /// <inheritdoc cref="NumberInfoThrow.IfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonZero]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BigInteger IfPropSetZero(
        this INumericRangeThrower _,
        BigInteger propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => NumberInfoThrow.IfPropSetZero(NumberInfo.BigInteger, propSetValue, propName!, message);

    /// <inheritdoc cref="SignInfoThrow.IfPropSetNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Negative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BigInteger IfPropSetNotNegative(
        this INumericRangeThrower _,
        BigInteger propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => SignInfoThrow.IfPropSetNotNegative(NumberInfo.BigInteger, propSetValue, propName!, message);

    /// <inheritdoc cref="SignInfoThrow.IfPropSetPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonPositive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BigInteger IfPropSetPositive(
        this INumericRangeThrower _,
        BigInteger propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => SignInfoThrow.IfPropSetPositive(NumberInfo.BigInteger, propSetValue, propName!, message);
    #endregion
    #endregion

    #region Decimal
    #region Arguments
    /// <inheritdoc cref="SignInfoThrow.IfArgNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonNegative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static decimal IfArgNegative(
        this INumericRangeThrower _,
        decimal paramValue, string paramName, string? message = null)
        => SignInfoThrow.IfArgNegative(NumberInfo.Decimal, paramValue, paramName, message);

    /// <inheritdoc cref="SignInfoThrow.IfArgNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Positive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static decimal IfArgNotPositive(
        this INumericRangeThrower _,
        decimal paramValue, string paramName, string? message = null)
        => SignInfoThrow.IfArgNotPositive(NumberInfo.Decimal, paramValue, paramName, message);

    /// <inheritdoc cref="NumberInfoThrow.IfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonZero]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static decimal IfArgZero(
        this INumericRangeThrower _,
        decimal paramValue, string paramName, string? message = null)
        => NumberInfoThrow.IfArgZero(NumberInfo.Decimal, paramValue, paramName, message);

    /// <inheritdoc cref="SignInfoThrow.IfArgNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Negative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static decimal IfArgNotNegative(
        this INumericRangeThrower _,
        decimal paramValue, string paramName, string? message = null)
        => SignInfoThrow.IfArgNotNegative(NumberInfo.Decimal, paramValue, paramName, message);

    /// <inheritdoc cref="SignInfoThrow.IfArgPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonPositive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static decimal IfArgPositive(
        this INumericRangeThrower _,
        decimal paramValue, string paramName, string? message = null)
        => SignInfoThrow.IfArgPositive(NumberInfo.Decimal, paramValue, paramName, message);
    #endregion

    #region Properties
    /// <inheritdoc cref="SignInfoThrow.IfPropSetNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonNegative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static decimal IfPropSetNegative(
        this INumericRangeThrower _,
        decimal propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => SignInfoThrow.IfPropSetNegative(NumberInfo.Decimal, propSetValue, propName!, message);

    /// <inheritdoc cref="SignInfoThrow.IfPropSetNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Positive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static decimal IfPropSetNotPositive(
        this INumericRangeThrower _,
        decimal propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => SignInfoThrow.IfPropSetNotPositive(NumberInfo.Decimal, propSetValue, propName!, message);

    /// <inheritdoc cref="NumberInfoThrow.IfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonZero]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static decimal IfPropSetZero(
        this INumericRangeThrower _,
        decimal propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => NumberInfoThrow.IfPropSetZero(NumberInfo.Decimal, propSetValue, propName!, message);

    /// <inheritdoc cref="SignInfoThrow.IfPropSetNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Negative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static decimal IfPropSetNotNegative(
        this INumericRangeThrower _,
        decimal propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => SignInfoThrow.IfPropSetNotNegative(NumberInfo.Decimal, propSetValue, propName!, message);

    /// <inheritdoc cref="SignInfoThrow.IfPropSetPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonPositive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static decimal IfPropSetPositive(
        this INumericRangeThrower _,
        decimal propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => SignInfoThrow.IfPropSetPositive(NumberInfo.Decimal, propSetValue, propName!, message);
    #endregion
    #endregion
    #endregion

    #region IFloatInfo
    #region Float
    #region Arguments
    /// <inheritdoc cref="NaNValueInfoThrow.IfArgNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonNegative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfArgNegative(
        this INumericRangeThrower _,
        float paramValue, string paramName, string? message = null)
        => NaNValueInfoThrow.IfArgNegative(NumberInfo.Float, paramValue, paramName, message);

    /// <inheritdoc cref="NaNValueInfoThrow.IfArgNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Positive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfArgNotPositive(
        this INumericRangeThrower _,
        float paramValue, string paramName, string? message = null)
        => NaNValueInfoThrow.IfArgNotPositive(NumberInfo.Float, paramValue, paramName, message);

    /// <inheritdoc cref="NumberInfoThrow.IfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonZero]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfArgZero(
        this INumericRangeThrower _,
        float paramValue, string paramName, string? message = null)
        => NumberInfoThrow.IfArgZero(NumberInfo.Float, paramValue, paramName, message);

    /// <inheritdoc cref="NaNValueInfoThrow.IfArgNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Negative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfArgNotNegative(
        this INumericRangeThrower _,
        float paramValue, string paramName, string? message = null)
        => NaNValueInfoThrow.IfArgNotNegative(NumberInfo.Float, paramValue, paramName, message);

    /// <inheritdoc cref="NaNValueInfoThrow.IfArgPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonPositive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfArgPositive(
        this INumericRangeThrower _,
        float paramValue, string paramName, string? message = null)
        => NaNValueInfoThrow.IfArgPositive(NumberInfo.Float, paramValue, paramName, message);

    /// <inheritdoc cref="FiniteInfoThrow.IfArgNotFinite{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Finite]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfArgNotFinite(
        this INumericRangeThrower _,
        float paramValue, string paramName, string? message = null)
        => FiniteInfoThrow.IfArgNotFinite(NumberInfo.Float, paramValue, paramName, message);

    /// <inheritdoc cref="NaNValueInfoThrow.IfArgNaN{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NotNaN]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfArgNaN(
        this INumericRangeThrower _,
        float paramValue, string paramName, string? message = null)
        => NaNValueInfoThrow.IfArgNaN(NumberInfo.Float, paramValue, paramName, message);
    #endregion

    #region Properties
    /// <inheritdoc cref="SignInfoThrow.IfPropSetNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonNegative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfPropSetNegative(
        this INumericRangeThrower _,
        float propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => NaNValueInfoThrow.IfPropSetNegative(NumberInfo.Float, propSetValue, propName!, message);

    /// <inheritdoc cref="SignInfoThrow.IfPropSetNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Positive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfPropSetNotPositive(
        this INumericRangeThrower _,
        float propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => NaNValueInfoThrow.IfPropSetNotPositive(NumberInfo.Float, propSetValue, propName!, message);

    /// <inheritdoc cref="NumberInfoThrow.IfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonZero]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfPropSetZero(
        this INumericRangeThrower _,
        float propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => NumberInfoThrow.IfPropSetZero(NumberInfo.Float, propSetValue, propName!, message);

    /// <inheritdoc cref="NaNValueInfoThrow.IfPropSetNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Negative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfPropSetNotNegative(
        this INumericRangeThrower _,
        float propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => NaNValueInfoThrow.IfPropSetNotNegative(NumberInfo.Float, propSetValue, propName!, message);

    /// <inheritdoc cref="SignInfoThrow.IfPropSetPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonPositive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfPropSetPositive(
        this INumericRangeThrower _,
        float propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => NaNValueInfoThrow.IfPropSetPositive(NumberInfo.Float, propSetValue, propName!, message);

    /// <inheritdoc cref="FiniteInfoThrow.IfPropSetNotFinite{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Finite]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfPropSetNotFinite(
        this INumericRangeThrower _,
        float propSetValue, string propName, string? message = null)
        => FiniteInfoThrow.IfPropSetNotFinite(NumberInfo.Float, propSetValue, propName, message);

    /// <inheritdoc cref="NaNValueInfoThrow.IfPropSetNaN{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NotNaN]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfPropSetNaN(
        this INumericRangeThrower _,
        float propSetValue, string propName, string? message = null)
        => NaNValueInfoThrow.IfPropSetNaN(NumberInfo.Float, propSetValue, propName, message);
    #endregion
    #endregion

    #region Double
    #region Arguments
    /// <inheritdoc cref="NaNValueInfoThrow.IfArgNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonNegative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfArgNegative(
        this INumericRangeThrower _,
        double paramValue, string paramName, string? message = null)
        => NaNValueInfoThrow.IfArgNegative(NumberInfo.Double, paramValue, paramName, message);

    /// <inheritdoc cref="NaNValueInfoThrow.IfArgNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Positive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfArgNotPositive(
        this INumericRangeThrower _,
        double paramValue, string paramName, string? message = null)
        => NaNValueInfoThrow.IfArgNotPositive(NumberInfo.Double, paramValue, paramName, message);

    /// <inheritdoc cref="NumberInfoThrow.IfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonZero]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfArgZero(
        this INumericRangeThrower _,
        double paramValue, string paramName, string? message = null)
        => NumberInfoThrow.IfArgZero(NumberInfo.Double, paramValue, paramName, message);

    /// <inheritdoc cref="NaNValueInfoThrow.IfArgNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Negative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfArgNotNegative(
        this INumericRangeThrower _,
        double paramValue, string paramName, string? message = null)
        => NaNValueInfoThrow.IfArgNotNegative(NumberInfo.Double, paramValue, paramName, message);

    /// <inheritdoc cref="NaNValueInfoThrow.IfArgPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonPositive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfArgPositive(
        this INumericRangeThrower _,
        double paramValue, string paramName, string? message = null)
        => NaNValueInfoThrow.IfArgPositive(NumberInfo.Double, paramValue, paramName, message);

    /// <inheritdoc cref="FiniteInfoThrow.IfArgNotFinite{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Finite]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfArgNotFinite(
        this INumericRangeThrower _,
        double paramValue, string paramName, string? message = null)
        => FiniteInfoThrow.IfArgNotFinite(NumberInfo.Double, paramValue, paramName, message);

    /// <inheritdoc cref="NaNValueInfoThrow.IfArgNaN{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NotNaN]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfArgNaN(
        this INumericRangeThrower _,
        double paramValue, string paramName, string? message = null)
        => NaNValueInfoThrow.IfArgNaN(NumberInfo.Double, paramValue, paramName, message);
    #endregion

    #region Properties
    /// <inheritdoc cref="SignInfoThrow.IfPropSetNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonNegative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfPropSetNegative(
        this INumericRangeThrower _,
        double propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => NaNValueInfoThrow.IfPropSetNegative(NumberInfo.Double, propSetValue, propName!, message);

    /// <inheritdoc cref="SignInfoThrow.IfPropSetNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Positive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfPropSetNotPositive(
        this INumericRangeThrower _,
        double propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => NaNValueInfoThrow.IfPropSetNotPositive(NumberInfo.Double, propSetValue, propName!, message);

    /// <inheritdoc cref="NumberInfoThrow.IfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonZero]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfPropSetZero(
        this INumericRangeThrower _,
        double propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => NumberInfoThrow.IfPropSetZero(NumberInfo.Double, propSetValue, propName!, message);

    /// <inheritdoc cref="NaNValueInfoThrow.IfPropSetNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Negative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfPropSetNotNegative(
        this INumericRangeThrower _,
        double propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => NaNValueInfoThrow.IfPropSetNotNegative(NumberInfo.Double, propSetValue, propName!, message);

    /// <inheritdoc cref="SignInfoThrow.IfPropSetPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonPositive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfPropSetPositive(
        this INumericRangeThrower _,
        double propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => NaNValueInfoThrow.IfPropSetPositive(NumberInfo.Double, propSetValue, propName!, message);

    /// <inheritdoc cref="FiniteInfoThrow.IfPropSetNotFinite{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Finite]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfPropSetNotFinite(
        this INumericRangeThrower _,
        double propSetValue, string propName, string? message = null)
        => FiniteInfoThrow.IfPropSetNotFinite(NumberInfo.Double, propSetValue, propName, message);

    /// <inheritdoc cref="NaNValueInfoThrow.IfPropSetNaN{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NotNaN]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfPropSetNaN(
        this INumericRangeThrower _,
        double propSetValue, string propName, string? message = null)
        => NaNValueInfoThrow.IfPropSetNaN(NumberInfo.Double, propSetValue, propName, message);
    #endregion
    #endregion

#if NET5_0_OR_GREATER
    #region Half
    #region Arguments
    /// <inheritdoc cref="NaNValueInfoThrow.IfArgNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonNegative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfArgNegative(
        this INumericRangeThrower _,
        Half paramValue, string paramName, string? message = null)
        => NaNValueInfoThrow.IfArgNegative(NumberInfo.Half, paramValue, paramName, message);

    /// <inheritdoc cref="NaNValueInfoThrow.IfArgNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Positive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfArgNotPositive(
        this INumericRangeThrower _,
        Half paramValue, string paramName, string? message = null)
        => NaNValueInfoThrow.IfArgNotPositive(NumberInfo.Half, paramValue, paramName, message);

    /// <inheritdoc cref="NumberInfoThrow.IfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonZero]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfArgZero(
        this INumericRangeThrower _,
        Half paramValue, string paramName, string? message = null)
        => NumberInfoThrow.IfArgZero(NumberInfo.Half, paramValue, paramName, message);

    /// <inheritdoc cref="NaNValueInfoThrow.IfArgNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Negative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfArgNotNegative(
        this INumericRangeThrower _,
        Half paramValue, string paramName, string? message = null)
        => NaNValueInfoThrow.IfArgNotNegative(NumberInfo.Half, paramValue, paramName, message);

    /// <inheritdoc cref="NaNValueInfoThrow.IfArgPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonPositive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfArgPositive(
        this INumericRangeThrower _,
        Half paramValue, string paramName, string? message = null)
        => NaNValueInfoThrow.IfArgPositive(NumberInfo.Half, paramValue, paramName, message);

    /// <inheritdoc cref="FiniteInfoThrow.IfArgNotFinite{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Finite]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfArgNotFinite(
        this INumericRangeThrower _,
        Half paramValue, string paramName, string? message = null)
        => FiniteInfoThrow.IfArgNotFinite(NumberInfo.Half, paramValue, paramName, message);

    /// <inheritdoc cref="NaNValueInfoThrow.IfArgNaN{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NotNaN]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfArgNaN(
        this INumericRangeThrower _,
        Half paramValue, string paramName, string? message = null)
        => NaNValueInfoThrow.IfArgNaN(NumberInfo.Half, paramValue, paramName, message);
    #endregion

    #region Properties
    /// <inheritdoc cref="SignInfoThrow.IfPropSetNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonNegative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfPropSetNegative(
        this INumericRangeThrower _,
        Half propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => NaNValueInfoThrow.IfPropSetNegative(NumberInfo.Half, propSetValue, propName!, message);

    /// <inheritdoc cref="SignInfoThrow.IfPropSetNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Positive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfPropSetNotPositive(
        this INumericRangeThrower _,
        Half propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => NaNValueInfoThrow.IfPropSetNotPositive(NumberInfo.Half, propSetValue, propName!, message);

    /// <inheritdoc cref="NumberInfoThrow.IfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonZero]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfPropSetZero(
        this INumericRangeThrower _,
        Half propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => NumberInfoThrow.IfPropSetZero(NumberInfo.Half, propSetValue, propName!, message);

    /// <inheritdoc cref="NaNValueInfoThrow.IfPropSetNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Negative]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfPropSetNotNegative(
        this INumericRangeThrower _,
        Half propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => NaNValueInfoThrow.IfPropSetNotNegative(NumberInfo.Half, propSetValue, propName!, message);

    /// <inheritdoc cref="SignInfoThrow.IfPropSetPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NonPositive]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfPropSetPositive(
        this INumericRangeThrower _,
        Half propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => NaNValueInfoThrow.IfPropSetPositive(NumberInfo.Half, propSetValue, propName!, message);

    /// <inheritdoc cref="FiniteInfoThrow.IfPropSetNotFinite{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: Finite]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfPropSetNotFinite(
        this INumericRangeThrower _,
        Half propSetValue, string propName, string? message = null)
        => FiniteInfoThrow.IfPropSetNotFinite(NumberInfo.Half, propSetValue, propName, message);

    /// <inheritdoc cref="NaNValueInfoThrow.IfPropSetNaN{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [return: NotNaN]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfPropSetNaN(
        this INumericRangeThrower _,
        Half propSetValue, string propName, string? message = null)
        => NaNValueInfoThrow.IfPropSetNaN(NumberInfo.Half, propSetValue, propName, message);
    #endregion
    #endregion
#endif
#endregion
}
#pragma warning restore 1573
