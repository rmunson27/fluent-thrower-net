using Rem.Core.Utilities.FluentThrowerHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Rem.Core.Utilities.FluentThrowerExtensions;

using static NumberInfoThrowHelpers;
using FloatHelpers = FloatInfoThrowHelpers;

/// <summary>
/// A series of extension methods offering a simple fluent API for throwing exceptions relating to invalid
/// numerical ranges.
/// </summary>
public static class NumericRangeFluentThrowerExtensions
{
    #region INumberInfo
    #region Byte
    /// <inheritdoc cref="ThrowIfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte IfArgZero(
        this INumericRangeFluentThrower _,
        byte paramValue, string paramName, string? message = null)
        => ThrowIfArgZero(NumberInfo.Byte, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte IfPropSetZero(
        this INumericRangeFluentThrower _,
        byte propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetZero(NumberInfo.Byte, propSetValue, propName!, message);
    #endregion

    #region UShort
    /// <inheritdoc cref="ThrowIfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort IfArgZero(
        this INumericRangeFluentThrower _,
        ushort paramValue, string paramName, string? message = null)
        => ThrowIfArgZero(NumberInfo.UShort, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort IfPropSetZero(
        this INumericRangeFluentThrower _,
        ushort propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetZero(NumberInfo.UShort, propSetValue, propName!, message);
    #endregion

    #region UInt
    /// <inheritdoc cref="ThrowIfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint IfArgZero(
        this INumericRangeFluentThrower _,
        uint paramValue, string paramName, string? message = null)
        => ThrowIfArgZero(NumberInfo.UInt, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint IfPropSetZero(
        this INumericRangeFluentThrower _,
        uint propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetZero(NumberInfo.UInt, propSetValue, propName!, message);
    #endregion

    #region ULong
    /// <inheritdoc cref="ThrowIfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ulong IfArgZero(
        this INumericRangeFluentThrower _,
        ulong paramValue, string paramName, string? message = null)
        => ThrowIfArgZero(NumberInfo.ULong, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ulong IfPropSetZero(
        this INumericRangeFluentThrower _,
        ulong propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetZero(NumberInfo.ULong, propSetValue, propName!, message);
    #endregion
    #endregion

    #region ISignInfo
    #region SByte
    #region Arguments
    /// <inheritdoc cref="ThrowIfArgNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte IfArgNegative(
        this INumericRangeFluentThrower _,
        sbyte paramValue, string paramName, string? message = null)
        => ThrowIfArgNegative(NumberInfo.SByte, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte IfArgNotPositive(
        this INumericRangeFluentThrower _,
        sbyte paramValue, string paramName, string? message = null)
        => ThrowIfArgNotPositive(NumberInfo.SByte, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte IfArgZero(
        this INumericRangeFluentThrower _,
        sbyte paramValue, string paramName, string? message = null)
        => ThrowIfArgZero(NumberInfo.SByte, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte IfArgNotNegative(
        this INumericRangeFluentThrower _,
        sbyte paramValue, string paramName, string? message = null)
        => ThrowIfArgNotNegative(NumberInfo.SByte, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte IfArgPositive(
        this INumericRangeFluentThrower _,
        sbyte paramValue, string paramName, string? message = null)
        => ThrowIfArgPositive(NumberInfo.SByte, paramValue, paramName, message);
    #endregion

    #region Properties
    /// <inheritdoc cref="ThrowIfPropSetNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte IfPropSetNegative(
        this INumericRangeFluentThrower _,
        sbyte propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNegative(NumberInfo.SByte, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte IfPropSetNotPositive(
        this INumericRangeFluentThrower _,
        sbyte propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNotPositive(NumberInfo.SByte, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte IfPropSetZero(
        this INumericRangeFluentThrower _,
        sbyte propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetZero(NumberInfo.SByte, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte IfPropSetNotNegative(
        this INumericRangeFluentThrower _,
        sbyte propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNotNegative(NumberInfo.SByte, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte IfPropSetPositive(
        this INumericRangeFluentThrower _,
        sbyte propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetPositive(NumberInfo.SByte, propSetValue, propName!, message);
    #endregion
    #endregion

    #region Short
    #region Arguments
    /// <inheritdoc cref="ThrowIfArgNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short IfArgNegative(
        this INumericRangeFluentThrower _,
        short paramValue, string paramName, string? message = null)
        => ThrowIfArgNegative(NumberInfo.Short, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short IfArgNotPositive(
        this INumericRangeFluentThrower _,
        short paramValue, string paramName, string? message = null)
        => ThrowIfArgNotPositive(NumberInfo.Short, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short IfArgZero(
        this INumericRangeFluentThrower _,
        short paramValue, string paramName, string? message = null)
        => ThrowIfArgZero(NumberInfo.Short, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short IfArgNotNegative(
        this INumericRangeFluentThrower _,
        short paramValue, string paramName, string? message = null)
        => ThrowIfArgNotNegative(NumberInfo.Short, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short IfArgPositive(
        this INumericRangeFluentThrower _,
        short paramValue, string paramName, string? message = null)
        => ThrowIfArgPositive(NumberInfo.Short, paramValue, paramName, message);
    #endregion

    #region Properties
    /// <inheritdoc cref="ThrowIfPropSetNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short IfPropSetNegative(
        this INumericRangeFluentThrower _,
        short propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNegative(NumberInfo.Short, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short IfPropSetNotPositive(
        this INumericRangeFluentThrower _,
        short propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNotPositive(NumberInfo.Short, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short IfPropSetZero(
        this INumericRangeFluentThrower _,
        short propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetZero(NumberInfo.Short, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short IfPropSetNotNegative(
        this INumericRangeFluentThrower _,
        short propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNotNegative(NumberInfo.Short, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short IfPropSetPositive(
        this INumericRangeFluentThrower _,
        short propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetPositive(NumberInfo.Short, propSetValue, propName!, message);
    #endregion
    #endregion

    #region Int
    #region Arguments
    /// <inheritdoc cref="ThrowIfArgNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IfArgNegative(
        this INumericRangeFluentThrower _,
        int paramValue, string paramName, string? message = null)
        => ThrowIfArgNegative(NumberInfo.Int, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IfArgNotPositive(
        this INumericRangeFluentThrower _,
        int paramValue, string paramName, string? message = null)
        => ThrowIfArgNotPositive(NumberInfo.Int, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IfArgZero(
        this INumericRangeFluentThrower _,
        int paramValue, string paramName, string? message = null)
        => ThrowIfArgZero(NumberInfo.Int, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IfArgNotNegative(
        this INumericRangeFluentThrower _,
        int paramValue, string paramName, string? message = null)
        => ThrowIfArgNotNegative(NumberInfo.Int, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IfArgPositive(
        this INumericRangeFluentThrower _,
        int paramValue, string paramName, string? message = null)
        => ThrowIfArgPositive(NumberInfo.Int, paramValue, paramName, message);
    #endregion

    #region Properties
    /// <inheritdoc cref="ThrowIfPropSetNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IfPropSetNegative(
        this INumericRangeFluentThrower _,
        int propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNegative(NumberInfo.Int, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IfPropSetNotPositive(
        this INumericRangeFluentThrower _,
        int propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNotPositive(NumberInfo.Int, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IfPropSetZero(
        this INumericRangeFluentThrower _,
        int propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetZero(NumberInfo.Int, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IfPropSetNotNegative(
        this INumericRangeFluentThrower _,
        int propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNotNegative(NumberInfo.Int, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IfPropSetPositive(
        this INumericRangeFluentThrower _,
        int propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetPositive(NumberInfo.Int, propSetValue, propName!, message);
    #endregion
    #endregion

    #region Long
    #region Arguments
    /// <inheritdoc cref="ThrowIfArgNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long IfArgNegative(
        this INumericRangeFluentThrower _,
        long paramValue, string paramName, string? message = null)
        => ThrowIfArgNegative(NumberInfo.Long, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long IfArgNotPositive(
        this INumericRangeFluentThrower _,
        long paramValue, string paramName, string? message = null)
        => ThrowIfArgNotPositive(NumberInfo.Long, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long IfArgZero(
        this INumericRangeFluentThrower _,
        long paramValue, string paramName, string? message = null)
        => ThrowIfArgZero(NumberInfo.Long, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long IfArgNotNegative(
        this INumericRangeFluentThrower _,
        long paramValue, string paramName, string? message = null)
        => ThrowIfArgNotNegative(NumberInfo.Long, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long IfArgPositive(
        this INumericRangeFluentThrower _,
        long paramValue, string paramName, string? message = null)
        => ThrowIfArgPositive(NumberInfo.Long, paramValue, paramName, message);
    #endregion

    #region Properties
    /// <inheritdoc cref="ThrowIfPropSetNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long IfPropSetNegative(
        this INumericRangeFluentThrower _,
        long propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNegative(NumberInfo.Long, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long IfPropSetNotPositive(
        this INumericRangeFluentThrower _,
        long propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNotPositive(NumberInfo.Long, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long IfPropSetZero(
        this INumericRangeFluentThrower _,
        long propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetZero(NumberInfo.Long, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long IfPropSetNotNegative(
        this INumericRangeFluentThrower _,
        long propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNotNegative(NumberInfo.Long, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long IfPropSetPositive(
        this INumericRangeFluentThrower _,
        long propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetPositive(NumberInfo.Long, propSetValue, propName!, message);
    #endregion
    #endregion

    #region BigInteger
    #region Arguments
    /// <inheritdoc cref="ThrowIfArgNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BigInteger IfArgNegative(
        this INumericRangeFluentThrower _,
        in BigInteger paramValue, string paramName, string? message = null)
        => ThrowIfArgNegative(NumberInfo.BigInteger, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BigInteger IfArgNotPositive(
        this INumericRangeFluentThrower _,
        BigInteger paramValue, string paramName, string? message = null)
        => ThrowIfArgNotPositive(NumberInfo.BigInteger, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BigInteger IfArgZero(
        this INumericRangeFluentThrower _,
        BigInteger paramValue, string paramName, string? message = null)
        => ThrowIfArgZero(NumberInfo.BigInteger, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BigInteger IfArgNotNegative(
        this INumericRangeFluentThrower _,
        BigInteger paramValue, string paramName, string? message = null)
        => ThrowIfArgNotNegative(NumberInfo.BigInteger, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BigInteger IfArgPositive(
        this INumericRangeFluentThrower _,
        BigInteger paramValue, string paramName, string? message = null)
        => ThrowIfArgPositive(NumberInfo.BigInteger, paramValue, paramName, message);
    #endregion

    #region Properties
    /// <inheritdoc cref="ThrowIfPropSetNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BigInteger IfPropSetNegative(
        this INumericRangeFluentThrower _,
        BigInteger propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNegative(NumberInfo.BigInteger, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BigInteger IfPropSetNotPositive(
        this INumericRangeFluentThrower _,
        BigInteger propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNotPositive(NumberInfo.BigInteger, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BigInteger IfPropSetZero(
        this INumericRangeFluentThrower _,
        BigInteger propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetZero(NumberInfo.BigInteger, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BigInteger IfPropSetNotNegative(
        this INumericRangeFluentThrower _,
        BigInteger propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNotNegative(NumberInfo.BigInteger, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BigInteger IfPropSetPositive(
        this INumericRangeFluentThrower _,
        BigInteger propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetPositive(NumberInfo.BigInteger, propSetValue, propName!, message);
    #endregion
    #endregion

    #region Decimal
    #region Arguments
    /// <inheritdoc cref="ThrowIfArgNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static decimal IfArgNegative(
        this INumericRangeFluentThrower _,
        decimal paramValue, string paramName, string? message = null)
        => ThrowIfArgNegative(NumberInfo.Decimal, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static decimal IfArgNotPositive(
        this INumericRangeFluentThrower _,
        decimal paramValue, string paramName, string? message = null)
        => ThrowIfArgNotPositive(NumberInfo.Decimal, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static decimal IfArgZero(
        this INumericRangeFluentThrower _,
        decimal paramValue, string paramName, string? message = null)
        => ThrowIfArgZero(NumberInfo.Decimal, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static decimal IfArgNotNegative(
        this INumericRangeFluentThrower _,
        decimal paramValue, string paramName, string? message = null)
        => ThrowIfArgNotNegative(NumberInfo.Decimal, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static decimal IfArgPositive(
        this INumericRangeFluentThrower _,
        decimal paramValue, string paramName, string? message = null)
        => ThrowIfArgPositive(NumberInfo.Decimal, paramValue, paramName, message);
    #endregion

    #region Properties
    /// <inheritdoc cref="ThrowIfPropSetNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static decimal IfPropSetNegative(
        this INumericRangeFluentThrower _,
        decimal propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNegative(NumberInfo.Decimal, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static decimal IfPropSetNotPositive(
        this INumericRangeFluentThrower _,
        decimal propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNotPositive(NumberInfo.Decimal, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static decimal IfPropSetZero(
        this INumericRangeFluentThrower _,
        decimal propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetZero(NumberInfo.Decimal, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static decimal IfPropSetNotNegative(
        this INumericRangeFluentThrower _,
        decimal propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNotNegative(NumberInfo.Decimal, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static decimal IfPropSetPositive(
        this INumericRangeFluentThrower _,
        decimal propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetPositive(NumberInfo.Decimal, propSetValue, propName!, message);
    #endregion
    #endregion
    #endregion

    #region IFloatInfo
    #region Float
    #region Arguments
    /// <inheritdoc cref="FloatHelpers.ThrowIfArgNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfArgNegative(
        this INumericRangeFluentThrower _,
        float paramValue, string paramName, string? message = null)
        => FloatHelpers.ThrowIfArgNegative(NumberInfo.Float, paramValue, paramName, message);

    /// <inheritdoc cref="FloatHelpers.ThrowIfArgNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfArgNotPositive(
        this INumericRangeFluentThrower _,
        float paramValue, string paramName, string? message = null)
        => FloatHelpers.ThrowIfArgNotPositive(NumberInfo.Float, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfArgZero(
        this INumericRangeFluentThrower _,
        float paramValue, string paramName, string? message = null)
        => ThrowIfArgZero(NumberInfo.Float, paramValue, paramName, message);

    /// <inheritdoc cref="FloatHelpers.ThrowIfArgNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfArgNotNegative(
        this INumericRangeFluentThrower _,
        float paramValue, string paramName, string? message = null)
        => FloatHelpers.ThrowIfArgNotNegative(NumberInfo.Float, paramValue, paramName, message);

    /// <inheritdoc cref="FloatHelpers.ThrowIfArgPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfArgPositive(
        this INumericRangeFluentThrower _,
        float paramValue, string paramName, string? message = null)
        => FloatHelpers.ThrowIfArgPositive(NumberInfo.Float, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgNotFinite{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    public static float IfArgNotFinite(
        this INumericRangeFluentThrower _,
        float paramValue, string paramName, string? message = null)
        => ThrowIfArgNotFinite(NumberInfo.Float, paramValue, paramName, message);

    /// <inheritdoc cref="FloatHelpers.ThrowIfArgNaN{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    public static float IfArgNaN(
        this INumericRangeFluentThrower _,
        float paramValue, string paramName, string? message = null)
        => FloatHelpers.ThrowIfArgNaN(NumberInfo.Float, paramValue, paramName, message);
    #endregion

    #region Properties
    /// <inheritdoc cref="ThrowIfPropSetNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfPropSetNegative(
        this INumericRangeFluentThrower _,
        float propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => FloatHelpers.ThrowIfPropSetNegative(NumberInfo.Float, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfPropSetNotPositive(
        this INumericRangeFluentThrower _,
        float propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => FloatHelpers.ThrowIfPropSetNotPositive(NumberInfo.Float, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfPropSetZero(
        this INumericRangeFluentThrower _,
        float propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetZero(NumberInfo.Float, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfPropSetNotNegative(
        this INumericRangeFluentThrower _,
        float propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => FloatHelpers.ThrowIfPropSetNotNegative(NumberInfo.Float, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfPropSetPositive(
        this INumericRangeFluentThrower _,
        float propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => FloatHelpers.ThrowIfPropSetPositive(NumberInfo.Float, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotFinite{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    public static float IfPropSetNotFinite(
        this INumericRangeFluentThrower _,
        float propSetValue, string propName, string? message = null)
        => ThrowIfPropSetNotFinite(NumberInfo.Float, propSetValue, propName, message);

    /// <inheritdoc cref="FloatHelpers.ThrowIfPropSetNaN{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    public static float IfPropSetNaN(
        this INumericRangeFluentThrower _,
        float propSetValue, string propName, string? message = null)
        => FloatHelpers.ThrowIfPropSetNaN(NumberInfo.Float, propSetValue, propName, message);
    #endregion
    #endregion

    #region Double
    #region Arguments
    /// <inheritdoc cref="FloatHelpers.ThrowIfArgNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfArgNegative(
        this INumericRangeFluentThrower _,
        double paramValue, string paramName, string? message = null)
        => FloatHelpers.ThrowIfArgNegative(NumberInfo.Double, paramValue, paramName, message);

    /// <inheritdoc cref="FloatHelpers.ThrowIfArgNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfArgNotPositive(
        this INumericRangeFluentThrower _,
        double paramValue, string paramName, string? message = null)
        => FloatHelpers.ThrowIfArgNotPositive(NumberInfo.Double, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfArgZero(
        this INumericRangeFluentThrower _,
        double paramValue, string paramName, string? message = null)
        => ThrowIfArgZero(NumberInfo.Double, paramValue, paramName, message);

    /// <inheritdoc cref="FloatHelpers.ThrowIfArgNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfArgNotNegative(
        this INumericRangeFluentThrower _,
        double paramValue, string paramName, string? message = null)
        => FloatHelpers.ThrowIfArgNotNegative(NumberInfo.Double, paramValue, paramName, message);

    /// <inheritdoc cref="FloatHelpers.ThrowIfArgPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfArgPositive(
        this INumericRangeFluentThrower _,
        double paramValue, string paramName, string? message = null)
        => FloatHelpers.ThrowIfArgPositive(NumberInfo.Double, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgNotFinite{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    public static double IfArgNotFinite(
        this INumericRangeFluentThrower _,
        double paramValue, string paramName, string? message = null)
        => ThrowIfArgNotFinite(NumberInfo.Double, paramValue, paramName, message);

    /// <inheritdoc cref="FloatHelpers.ThrowIfArgNaN{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    public static double IfArgNaN(
        this INumericRangeFluentThrower _,
        double paramValue, string paramName, string? message = null)
        => FloatHelpers.ThrowIfArgNaN(NumberInfo.Double, paramValue, paramName, message);
    #endregion

    #region Properties
    /// <inheritdoc cref="ThrowIfPropSetNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfPropSetNegative(
        this INumericRangeFluentThrower _,
        double propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => FloatHelpers.ThrowIfPropSetNegative(NumberInfo.Double, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfPropSetNotPositive(
        this INumericRangeFluentThrower _,
        double propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => FloatHelpers.ThrowIfPropSetNotPositive(NumberInfo.Double, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfPropSetZero(
        this INumericRangeFluentThrower _,
        double propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetZero(NumberInfo.Double, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfPropSetNotNegative(
        this INumericRangeFluentThrower _,
        double propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => FloatHelpers.ThrowIfPropSetNotNegative(NumberInfo.Double, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfPropSetPositive(
        this INumericRangeFluentThrower _,
        double propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => FloatHelpers.ThrowIfPropSetPositive(NumberInfo.Double, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotFinite{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    public static double IfPropSetNotFinite(
        this INumericRangeFluentThrower _,
        double propSetValue, string propName, string? message = null)
        => ThrowIfPropSetNotFinite(NumberInfo.Double, propSetValue, propName, message);

    /// <inheritdoc cref="FloatHelpers.ThrowIfPropSetNaN{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    public static double IfPropSetNaN(
        this INumericRangeFluentThrower _,
        double propSetValue, string propName, string? message = null)
        => FloatHelpers.ThrowIfPropSetNaN(NumberInfo.Double, propSetValue, propName, message);
    #endregion
    #endregion

#if NET5_0_OR_GREATER
    #region Half
    #region Arguments
    /// <inheritdoc cref="FloatHelpers.ThrowIfArgNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfArgNegative(
        this INumericRangeFluentThrower _,
        Half paramValue, string paramName, string? message = null)
        => FloatHelpers.ThrowIfArgNegative(NumberInfo.Half, paramValue, paramName, message);

    /// <inheritdoc cref="FloatHelpers.ThrowIfArgNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfArgNotPositive(
        this INumericRangeFluentThrower _,
        Half paramValue, string paramName, string? message = null)
        => FloatHelpers.ThrowIfArgNotPositive(NumberInfo.Half, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfArgZero(
        this INumericRangeFluentThrower _,
        Half paramValue, string paramName, string? message = null)
        => ThrowIfArgZero(NumberInfo.Half, paramValue, paramName, message);

    /// <inheritdoc cref="FloatHelpers.ThrowIfArgNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfArgNotNegative(
        this INumericRangeFluentThrower _,
        Half paramValue, string paramName, string? message = null)
        => FloatHelpers.ThrowIfArgNotNegative(NumberInfo.Half, paramValue, paramName, message);

    /// <inheritdoc cref="FloatHelpers.ThrowIfArgPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfArgPositive(
        this INumericRangeFluentThrower _,
        Half paramValue, string paramName, string? message = null)
        => FloatHelpers.ThrowIfArgPositive(NumberInfo.Half, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgNotFinite{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    public static Half IfArgNotFinite(
        this INumericRangeFluentThrower _,
        Half paramValue, string paramName, string? message = null)
        => ThrowIfArgNotFinite(NumberInfo.Half, paramValue, paramName, message);

    /// <inheritdoc cref="FloatHelpers.ThrowIfArgNaN{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    public static Half IfArgNaN(
        this INumericRangeFluentThrower _,
        Half paramValue, string paramName, string? message = null)
        => FloatHelpers.ThrowIfArgNaN(NumberInfo.Half, paramValue, paramName, message);
    #endregion

    #region Properties
    /// <inheritdoc cref="ThrowIfPropSetNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfPropSetNegative(
        this INumericRangeFluentThrower _,
        Half propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => FloatHelpers.ThrowIfPropSetNegative(NumberInfo.Half, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfPropSetNotPositive(
        this INumericRangeFluentThrower _,
        Half propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => FloatHelpers.ThrowIfPropSetNotPositive(NumberInfo.Half, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfPropSetZero(
        this INumericRangeFluentThrower _,
        Half propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetZero(NumberInfo.Half, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfPropSetNotNegative(
        this INumericRangeFluentThrower _,
        Half propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => FloatHelpers.ThrowIfPropSetNotNegative(NumberInfo.Half, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfPropSetPositive(
        this INumericRangeFluentThrower _,
        Half propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => FloatHelpers.ThrowIfPropSetPositive(NumberInfo.Half, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotFinite{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    public static Half IfPropSetNotFinite(
        this INumericRangeFluentThrower _,
        Half propSetValue, string propName, string? message = null)
        => ThrowIfPropSetNotFinite(NumberInfo.Half, propSetValue, propName, message);

    /// <inheritdoc cref="FloatHelpers.ThrowIfPropSetNaN{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    public static Half IfPropSetNaN(
        this INumericRangeFluentThrower _,
        Half propSetValue, string propName, string? message = null)
        => FloatHelpers.ThrowIfPropSetNaN(NumberInfo.Half, propSetValue, propName, message);
    #endregion
    #endregion
#endif
#endregion
}
