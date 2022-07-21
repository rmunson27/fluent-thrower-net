using Rem.Core.Utilities.FluentThrower.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Rem.Core.Utilities.FluentThrower.Extensions;

using static NumberInfoThrowers;
using FloatThrowers = FloatInfoThrowers;

/// <summary>
/// A series of extension methods offering a simple fluent API for throwing exceptions relating to invalid
/// numerical ranges.
/// </summary>
public static class NumericRangeThrowerExtensions
{
    #region INumberInfo
    #region Byte
    /// <inheritdoc cref="ThrowIfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte IfArgZero(
        this INumericRangeThrower _,
        byte paramValue, string paramName, string? message = null)
        => ThrowIfArgZero(NumberInfo.Byte, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte IfPropSetZero(
        this INumericRangeThrower _,
        byte propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetZero(NumberInfo.Byte, propSetValue, propName!, message);
    #endregion

    #region UShort
    /// <inheritdoc cref="ThrowIfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort IfArgZero(
        this INumericRangeThrower _,
        ushort paramValue, string paramName, string? message = null)
        => ThrowIfArgZero(NumberInfo.UShort, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort IfPropSetZero(
        this INumericRangeThrower _,
        ushort propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetZero(NumberInfo.UShort, propSetValue, propName!, message);
    #endregion

    #region UInt
    /// <inheritdoc cref="ThrowIfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint IfArgZero(
        this INumericRangeThrower _,
        uint paramValue, string paramName, string? message = null)
        => ThrowIfArgZero(NumberInfo.UInt, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint IfPropSetZero(
        this INumericRangeThrower _,
        uint propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetZero(NumberInfo.UInt, propSetValue, propName!, message);
    #endregion

    #region ULong
    /// <inheritdoc cref="ThrowIfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ulong IfArgZero(
        this INumericRangeThrower _,
        ulong paramValue, string paramName, string? message = null)
        => ThrowIfArgZero(NumberInfo.ULong, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ulong IfPropSetZero(
        this INumericRangeThrower _,
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
        this INumericRangeThrower _,
        sbyte paramValue, string paramName, string? message = null)
        => ThrowIfArgNegative(NumberInfo.SByte, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte IfArgNotPositive(
        this INumericRangeThrower _,
        sbyte paramValue, string paramName, string? message = null)
        => ThrowIfArgNotPositive(NumberInfo.SByte, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte IfArgZero(
        this INumericRangeThrower _,
        sbyte paramValue, string paramName, string? message = null)
        => ThrowIfArgZero(NumberInfo.SByte, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte IfArgNotNegative(
        this INumericRangeThrower _,
        sbyte paramValue, string paramName, string? message = null)
        => ThrowIfArgNotNegative(NumberInfo.SByte, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte IfArgPositive(
        this INumericRangeThrower _,
        sbyte paramValue, string paramName, string? message = null)
        => ThrowIfArgPositive(NumberInfo.SByte, paramValue, paramName, message);
    #endregion

    #region Properties
    /// <inheritdoc cref="ThrowIfPropSetNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte IfPropSetNegative(
        this INumericRangeThrower _,
        sbyte propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNegative(NumberInfo.SByte, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte IfPropSetNotPositive(
        this INumericRangeThrower _,
        sbyte propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNotPositive(NumberInfo.SByte, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte IfPropSetZero(
        this INumericRangeThrower _,
        sbyte propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetZero(NumberInfo.SByte, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte IfPropSetNotNegative(
        this INumericRangeThrower _,
        sbyte propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNotNegative(NumberInfo.SByte, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static sbyte IfPropSetPositive(
        this INumericRangeThrower _,
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
        this INumericRangeThrower _,
        short paramValue, string paramName, string? message = null)
        => ThrowIfArgNegative(NumberInfo.Short, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short IfArgNotPositive(
        this INumericRangeThrower _,
        short paramValue, string paramName, string? message = null)
        => ThrowIfArgNotPositive(NumberInfo.Short, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short IfArgZero(
        this INumericRangeThrower _,
        short paramValue, string paramName, string? message = null)
        => ThrowIfArgZero(NumberInfo.Short, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short IfArgNotNegative(
        this INumericRangeThrower _,
        short paramValue, string paramName, string? message = null)
        => ThrowIfArgNotNegative(NumberInfo.Short, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short IfArgPositive(
        this INumericRangeThrower _,
        short paramValue, string paramName, string? message = null)
        => ThrowIfArgPositive(NumberInfo.Short, paramValue, paramName, message);
    #endregion

    #region Properties
    /// <inheritdoc cref="ThrowIfPropSetNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short IfPropSetNegative(
        this INumericRangeThrower _,
        short propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNegative(NumberInfo.Short, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short IfPropSetNotPositive(
        this INumericRangeThrower _,
        short propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNotPositive(NumberInfo.Short, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short IfPropSetZero(
        this INumericRangeThrower _,
        short propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetZero(NumberInfo.Short, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short IfPropSetNotNegative(
        this INumericRangeThrower _,
        short propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNotNegative(NumberInfo.Short, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short IfPropSetPositive(
        this INumericRangeThrower _,
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
        this INumericRangeThrower _,
        int paramValue, string paramName, string? message = null)
        => ThrowIfArgNegative(NumberInfo.Int, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IfArgNotPositive(
        this INumericRangeThrower _,
        int paramValue, string paramName, string? message = null)
        => ThrowIfArgNotPositive(NumberInfo.Int, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IfArgZero(
        this INumericRangeThrower _,
        int paramValue, string paramName, string? message = null)
        => ThrowIfArgZero(NumberInfo.Int, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IfArgNotNegative(
        this INumericRangeThrower _,
        int paramValue, string paramName, string? message = null)
        => ThrowIfArgNotNegative(NumberInfo.Int, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IfArgPositive(
        this INumericRangeThrower _,
        int paramValue, string paramName, string? message = null)
        => ThrowIfArgPositive(NumberInfo.Int, paramValue, paramName, message);
    #endregion

    #region Properties
    /// <inheritdoc cref="ThrowIfPropSetNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IfPropSetNegative(
        this INumericRangeThrower _,
        int propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNegative(NumberInfo.Int, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IfPropSetNotPositive(
        this INumericRangeThrower _,
        int propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNotPositive(NumberInfo.Int, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IfPropSetZero(
        this INumericRangeThrower _,
        int propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetZero(NumberInfo.Int, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IfPropSetNotNegative(
        this INumericRangeThrower _,
        int propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNotNegative(NumberInfo.Int, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int IfPropSetPositive(
        this INumericRangeThrower _,
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
        this INumericRangeThrower _,
        long paramValue, string paramName, string? message = null)
        => ThrowIfArgNegative(NumberInfo.Long, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long IfArgNotPositive(
        this INumericRangeThrower _,
        long paramValue, string paramName, string? message = null)
        => ThrowIfArgNotPositive(NumberInfo.Long, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long IfArgZero(
        this INumericRangeThrower _,
        long paramValue, string paramName, string? message = null)
        => ThrowIfArgZero(NumberInfo.Long, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long IfArgNotNegative(
        this INumericRangeThrower _,
        long paramValue, string paramName, string? message = null)
        => ThrowIfArgNotNegative(NumberInfo.Long, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long IfArgPositive(
        this INumericRangeThrower _,
        long paramValue, string paramName, string? message = null)
        => ThrowIfArgPositive(NumberInfo.Long, paramValue, paramName, message);
    #endregion

    #region Properties
    /// <inheritdoc cref="ThrowIfPropSetNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long IfPropSetNegative(
        this INumericRangeThrower _,
        long propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNegative(NumberInfo.Long, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long IfPropSetNotPositive(
        this INumericRangeThrower _,
        long propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNotPositive(NumberInfo.Long, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long IfPropSetZero(
        this INumericRangeThrower _,
        long propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetZero(NumberInfo.Long, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long IfPropSetNotNegative(
        this INumericRangeThrower _,
        long propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNotNegative(NumberInfo.Long, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long IfPropSetPositive(
        this INumericRangeThrower _,
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
        this INumericRangeThrower _,
        in BigInteger paramValue, string paramName, string? message = null)
        => ThrowIfArgNegative(NumberInfo.BigInteger, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BigInteger IfArgNotPositive(
        this INumericRangeThrower _,
        BigInteger paramValue, string paramName, string? message = null)
        => ThrowIfArgNotPositive(NumberInfo.BigInteger, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BigInteger IfArgZero(
        this INumericRangeThrower _,
        BigInteger paramValue, string paramName, string? message = null)
        => ThrowIfArgZero(NumberInfo.BigInteger, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BigInteger IfArgNotNegative(
        this INumericRangeThrower _,
        BigInteger paramValue, string paramName, string? message = null)
        => ThrowIfArgNotNegative(NumberInfo.BigInteger, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BigInteger IfArgPositive(
        this INumericRangeThrower _,
        BigInteger paramValue, string paramName, string? message = null)
        => ThrowIfArgPositive(NumberInfo.BigInteger, paramValue, paramName, message);
    #endregion

    #region Properties
    /// <inheritdoc cref="ThrowIfPropSetNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BigInteger IfPropSetNegative(
        this INumericRangeThrower _,
        BigInteger propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNegative(NumberInfo.BigInteger, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BigInteger IfPropSetNotPositive(
        this INumericRangeThrower _,
        BigInteger propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNotPositive(NumberInfo.BigInteger, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BigInteger IfPropSetZero(
        this INumericRangeThrower _,
        BigInteger propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetZero(NumberInfo.BigInteger, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BigInteger IfPropSetNotNegative(
        this INumericRangeThrower _,
        BigInteger propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNotNegative(NumberInfo.BigInteger, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BigInteger IfPropSetPositive(
        this INumericRangeThrower _,
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
        this INumericRangeThrower _,
        decimal paramValue, string paramName, string? message = null)
        => ThrowIfArgNegative(NumberInfo.Decimal, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static decimal IfArgNotPositive(
        this INumericRangeThrower _,
        decimal paramValue, string paramName, string? message = null)
        => ThrowIfArgNotPositive(NumberInfo.Decimal, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static decimal IfArgZero(
        this INumericRangeThrower _,
        decimal paramValue, string paramName, string? message = null)
        => ThrowIfArgZero(NumberInfo.Decimal, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static decimal IfArgNotNegative(
        this INumericRangeThrower _,
        decimal paramValue, string paramName, string? message = null)
        => ThrowIfArgNotNegative(NumberInfo.Decimal, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static decimal IfArgPositive(
        this INumericRangeThrower _,
        decimal paramValue, string paramName, string? message = null)
        => ThrowIfArgPositive(NumberInfo.Decimal, paramValue, paramName, message);
    #endregion

    #region Properties
    /// <inheritdoc cref="ThrowIfPropSetNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static decimal IfPropSetNegative(
        this INumericRangeThrower _,
        decimal propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNegative(NumberInfo.Decimal, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static decimal IfPropSetNotPositive(
        this INumericRangeThrower _,
        decimal propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNotPositive(NumberInfo.Decimal, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static decimal IfPropSetZero(
        this INumericRangeThrower _,
        decimal propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetZero(NumberInfo.Decimal, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static decimal IfPropSetNotNegative(
        this INumericRangeThrower _,
        decimal propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetNotNegative(NumberInfo.Decimal, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static decimal IfPropSetPositive(
        this INumericRangeThrower _,
        decimal propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetPositive(NumberInfo.Decimal, propSetValue, propName!, message);
    #endregion
    #endregion
    #endregion

    #region IFloatInfo
    #region Float
    #region Arguments
    /// <inheritdoc cref="FloatThrowers.ThrowIfArgNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfArgNegative(
        this INumericRangeThrower _,
        float paramValue, string paramName, string? message = null)
        => FloatThrowers.ThrowIfArgNegative(NumberInfo.Float, paramValue, paramName, message);

    /// <inheritdoc cref="FloatThrowers.ThrowIfArgNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfArgNotPositive(
        this INumericRangeThrower _,
        float paramValue, string paramName, string? message = null)
        => FloatThrowers.ThrowIfArgNotPositive(NumberInfo.Float, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfArgZero(
        this INumericRangeThrower _,
        float paramValue, string paramName, string? message = null)
        => ThrowIfArgZero(NumberInfo.Float, paramValue, paramName, message);

    /// <inheritdoc cref="FloatThrowers.ThrowIfArgNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfArgNotNegative(
        this INumericRangeThrower _,
        float paramValue, string paramName, string? message = null)
        => FloatThrowers.ThrowIfArgNotNegative(NumberInfo.Float, paramValue, paramName, message);

    /// <inheritdoc cref="FloatThrowers.ThrowIfArgPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfArgPositive(
        this INumericRangeThrower _,
        float paramValue, string paramName, string? message = null)
        => FloatThrowers.ThrowIfArgPositive(NumberInfo.Float, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgNotFinite{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    public static float IfArgNotFinite(
        this INumericRangeThrower _,
        float paramValue, string paramName, string? message = null)
        => ThrowIfArgNotFinite(NumberInfo.Float, paramValue, paramName, message);

    /// <inheritdoc cref="FloatThrowers.ThrowIfArgNaN{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    public static float IfArgNaN(
        this INumericRangeThrower _,
        float paramValue, string paramName, string? message = null)
        => FloatThrowers.ThrowIfArgNaN(NumberInfo.Float, paramValue, paramName, message);
    #endregion

    #region Properties
    /// <inheritdoc cref="ThrowIfPropSetNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfPropSetNegative(
        this INumericRangeThrower _,
        float propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => FloatThrowers.ThrowIfPropSetNegative(NumberInfo.Float, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfPropSetNotPositive(
        this INumericRangeThrower _,
        float propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => FloatThrowers.ThrowIfPropSetNotPositive(NumberInfo.Float, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfPropSetZero(
        this INumericRangeThrower _,
        float propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetZero(NumberInfo.Float, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfPropSetNotNegative(
        this INumericRangeThrower _,
        float propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => FloatThrowers.ThrowIfPropSetNotNegative(NumberInfo.Float, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float IfPropSetPositive(
        this INumericRangeThrower _,
        float propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => FloatThrowers.ThrowIfPropSetPositive(NumberInfo.Float, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotFinite{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    public static float IfPropSetNotFinite(
        this INumericRangeThrower _,
        float propSetValue, string propName, string? message = null)
        => ThrowIfPropSetNotFinite(NumberInfo.Float, propSetValue, propName, message);

    /// <inheritdoc cref="FloatThrowers.ThrowIfPropSetNaN{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    public static float IfPropSetNaN(
        this INumericRangeThrower _,
        float propSetValue, string propName, string? message = null)
        => FloatThrowers.ThrowIfPropSetNaN(NumberInfo.Float, propSetValue, propName, message);
    #endregion
    #endregion

    #region Double
    #region Arguments
    /// <inheritdoc cref="FloatThrowers.ThrowIfArgNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfArgNegative(
        this INumericRangeThrower _,
        double paramValue, string paramName, string? message = null)
        => FloatThrowers.ThrowIfArgNegative(NumberInfo.Double, paramValue, paramName, message);

    /// <inheritdoc cref="FloatThrowers.ThrowIfArgNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfArgNotPositive(
        this INumericRangeThrower _,
        double paramValue, string paramName, string? message = null)
        => FloatThrowers.ThrowIfArgNotPositive(NumberInfo.Double, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfArgZero(
        this INumericRangeThrower _,
        double paramValue, string paramName, string? message = null)
        => ThrowIfArgZero(NumberInfo.Double, paramValue, paramName, message);

    /// <inheritdoc cref="FloatThrowers.ThrowIfArgNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfArgNotNegative(
        this INumericRangeThrower _,
        double paramValue, string paramName, string? message = null)
        => FloatThrowers.ThrowIfArgNotNegative(NumberInfo.Double, paramValue, paramName, message);

    /// <inheritdoc cref="FloatThrowers.ThrowIfArgPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfArgPositive(
        this INumericRangeThrower _,
        double paramValue, string paramName, string? message = null)
        => FloatThrowers.ThrowIfArgPositive(NumberInfo.Double, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgNotFinite{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    public static double IfArgNotFinite(
        this INumericRangeThrower _,
        double paramValue, string paramName, string? message = null)
        => ThrowIfArgNotFinite(NumberInfo.Double, paramValue, paramName, message);

    /// <inheritdoc cref="FloatThrowers.ThrowIfArgNaN{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    public static double IfArgNaN(
        this INumericRangeThrower _,
        double paramValue, string paramName, string? message = null)
        => FloatThrowers.ThrowIfArgNaN(NumberInfo.Double, paramValue, paramName, message);
    #endregion

    #region Properties
    /// <inheritdoc cref="ThrowIfPropSetNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfPropSetNegative(
        this INumericRangeThrower _,
        double propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => FloatThrowers.ThrowIfPropSetNegative(NumberInfo.Double, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfPropSetNotPositive(
        this INumericRangeThrower _,
        double propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => FloatThrowers.ThrowIfPropSetNotPositive(NumberInfo.Double, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfPropSetZero(
        this INumericRangeThrower _,
        double propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetZero(NumberInfo.Double, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfPropSetNotNegative(
        this INumericRangeThrower _,
        double propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => FloatThrowers.ThrowIfPropSetNotNegative(NumberInfo.Double, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double IfPropSetPositive(
        this INumericRangeThrower _,
        double propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => FloatThrowers.ThrowIfPropSetPositive(NumberInfo.Double, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotFinite{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    public static double IfPropSetNotFinite(
        this INumericRangeThrower _,
        double propSetValue, string propName, string? message = null)
        => ThrowIfPropSetNotFinite(NumberInfo.Double, propSetValue, propName, message);

    /// <inheritdoc cref="FloatThrowers.ThrowIfPropSetNaN{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    public static double IfPropSetNaN(
        this INumericRangeThrower _,
        double propSetValue, string propName, string? message = null)
        => FloatThrowers.ThrowIfPropSetNaN(NumberInfo.Double, propSetValue, propName, message);
    #endregion
    #endregion

#if NET5_0_OR_GREATER
    #region Half
    #region Arguments
    /// <inheritdoc cref="FloatThrowers.ThrowIfArgNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfArgNegative(
        this INumericRangeThrower _,
        Half paramValue, string paramName, string? message = null)
        => FloatThrowers.ThrowIfArgNegative(NumberInfo.Half, paramValue, paramName, message);

    /// <inheritdoc cref="FloatThrowers.ThrowIfArgNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfArgNotPositive(
        this INumericRangeThrower _,
        Half paramValue, string paramName, string? message = null)
        => FloatThrowers.ThrowIfArgNotPositive(NumberInfo.Half, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfArgZero(
        this INumericRangeThrower _,
        Half paramValue, string paramName, string? message = null)
        => ThrowIfArgZero(NumberInfo.Half, paramValue, paramName, message);

    /// <inheritdoc cref="FloatThrowers.ThrowIfArgNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfArgNotNegative(
        this INumericRangeThrower _,
        Half paramValue, string paramName, string? message = null)
        => FloatThrowers.ThrowIfArgNotNegative(NumberInfo.Half, paramValue, paramName, message);

    /// <inheritdoc cref="FloatThrowers.ThrowIfArgPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfArgPositive(
        this INumericRangeThrower _,
        Half paramValue, string paramName, string? message = null)
        => FloatThrowers.ThrowIfArgPositive(NumberInfo.Half, paramValue, paramName, message);

    /// <inheritdoc cref="ThrowIfArgNotFinite{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    public static Half IfArgNotFinite(
        this INumericRangeThrower _,
        Half paramValue, string paramName, string? message = null)
        => ThrowIfArgNotFinite(NumberInfo.Half, paramValue, paramName, message);

    /// <inheritdoc cref="FloatThrowers.ThrowIfArgNaN{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    public static Half IfArgNaN(
        this INumericRangeThrower _,
        Half paramValue, string paramName, string? message = null)
        => FloatThrowers.ThrowIfArgNaN(NumberInfo.Half, paramValue, paramName, message);
    #endregion

    #region Properties
    /// <inheritdoc cref="ThrowIfPropSetNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfPropSetNegative(
        this INumericRangeThrower _,
        Half propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => FloatThrowers.ThrowIfPropSetNegative(NumberInfo.Half, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfPropSetNotPositive(
        this INumericRangeThrower _,
        Half propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => FloatThrowers.ThrowIfPropSetNotPositive(NumberInfo.Half, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetZero{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfPropSetZero(
        this INumericRangeThrower _,
        Half propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => ThrowIfPropSetZero(NumberInfo.Half, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotNegative{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfPropSetNotNegative(
        this INumericRangeThrower _,
        Half propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => FloatThrowers.ThrowIfPropSetNotNegative(NumberInfo.Half, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetPositive{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <propSet name="_"></propSet>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Half IfPropSetPositive(
        this INumericRangeThrower _,
        Half propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => FloatThrowers.ThrowIfPropSetPositive(NumberInfo.Half, propSetValue, propName!, message);

    /// <inheritdoc cref="ThrowIfPropSetNotFinite{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    public static Half IfPropSetNotFinite(
        this INumericRangeThrower _,
        Half propSetValue, string propName, string? message = null)
        => ThrowIfPropSetNotFinite(NumberInfo.Half, propSetValue, propName, message);

    /// <inheritdoc cref="FloatThrowers.ThrowIfPropSetNaN{TInfo, TValue}(TInfo, TValue, string, string?)"/>
    /// <param name="_"></param>
    public static Half IfPropSetNaN(
        this INumericRangeThrower _,
        Half propSetValue, string propName, string? message = null)
        => FloatThrowers.ThrowIfPropSetNaN(NumberInfo.Half, propSetValue, propName, message);
    #endregion
    #endregion
#endif
#endregion
}
