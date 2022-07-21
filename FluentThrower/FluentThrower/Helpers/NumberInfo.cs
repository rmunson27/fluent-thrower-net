using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Rem.Core.Utilities.FluentThrower.Helpers;

#if NET5_0_OR_GREATER
using half = Half;
#endif

#region Interface Implementations
/// <summary>
/// <see cref="INumberInfo{T}"/> constants for various common .NET numeric types.
/// </summary>
public static class NumberInfo
{
    #region Constants
    /// <summary>
    /// An instance of an <see cref="INumberInfo{T}"/> implementation for <see cref="byte"/> instances.
    /// </summary>
    public static readonly ByteInfo Byte = new();

    /// <summary>
    /// An instance of an <see cref="ISignInfo{T}"/> implementation for <see cref="sbyte"/> instances.
    /// </summary>
    public static readonly SByteInfo SByte = new();

    /// <summary>
    /// An instance of an <see cref="ISignInfo{T}"/> implementation for <see cref="short"/> instances.
    /// </summary>
    public static readonly ShortInfo Short = new();

    /// <summary>
    /// An instance of an <see cref="INumberInfo{T}"/> implementation for <see cref="ushort"/> instances.
    /// </summary>
    public static readonly UShortInfo UShort = new();

    /// <summary>
    /// An instance of an <see cref="ISignInfo{T}"/> implementation for <see cref="int"/> instances.
    /// </summary>
    public static readonly IntInfo Int = new();

    /// <summary>
    /// An instance of an <see cref="INumberInfo{T}"/> implementation for <see cref="uint"/> instances.
    /// </summary>
    public static readonly UIntInfo UInt = new();

    /// <summary>
    /// An instance of an <see cref="ISignInfo{T}"/> implementation for <see cref="long"/> instances.
    /// </summary>
    public static readonly LongInfo Long = new();

    /// <summary>
    /// An instance of an <see cref="INumberInfo{T}"/> implementation for <see cref="ulong"/> instances.
    /// </summary>
    public static readonly ULongInfo ULong = new();

    /// <summary>
    /// An instance of an <see cref="ISignInfo{T}"/> implementation for
    /// <see cref="System.Numerics.BigInteger"/> instances.
    /// </summary>
    public static readonly BigIntegerInfo BigInteger = new();

    /// <summary>
    /// An instance of an <see cref="ISignInfo{T}"/> implementation for <see cref="decimal"/> instances.
    /// </summary>
    public static readonly DecimalInfo Decimal = new();

    /// <summary>
    /// An instance of an <see cref="IFloatInfo{T}"/> implementation for <see cref="double"/> instances.
    /// </summary>
    public static readonly DoubleInfo Double = new();

    /// <summary>
    /// An instance of an <see cref="IFloatInfo{T}"/> implementation for <see cref="float"/> instances.
    /// </summary>
    public static readonly FloatInfo Float = new();

#if NET5_0_OR_GREATER
    /// <summary>
    /// An instance of an <see cref="IFloatInfo{T}"/> implementation for <see cref="System.Half"/> instances.
    /// </summary>
    public static readonly HalfInfo Half = new();
#endif
    #endregion

    #region Implementing Classes
    #region IZeroInfo
    /// <summary>
    /// An <see cref="INumberInfo{T}"/> implementation for <see cref="byte"/> instances.
    /// </summary>
    public sealed class ByteInfo : INumberInfo<byte>
    {
        /// <summary>
        /// This class should be a singleton with the only instance stored by <see cref="NumberInfo"/>.
        /// </summary>
        internal ByteInfo() { }

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsZero(byte value) => value == 0;
    }

    /// <summary>
    /// An <see cref="INumberInfo{T}"/> implementation for <see cref="ushort"/> instances.
    /// </summary>
    public sealed class UShortInfo : INumberInfo<ushort>
    {
        /// <summary>
        /// This class should be a singleton with the only instance stored by <see cref="NumberInfo"/>.
        /// </summary>
        internal UShortInfo() { }

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsZero(ushort value) => value == 0;
    }

    /// <summary>
    /// An <see cref="INumberInfo{T}"/> implementation for <see cref="uint"/> instances.
    /// </summary>
    public sealed class UIntInfo : INumberInfo<uint>
    {
        /// <summary>
        /// This class should be a singleton with the only instance stored by <see cref="NumberInfo"/>.
        /// </summary>
        internal UIntInfo() { }

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsZero(uint value) => value == 0;
    }

    /// <summary>
    /// An <see cref="INumberInfo{T}"/> implementation for <see cref="ulong"/> instances.
    /// </summary>
    public sealed class ULongInfo : INumberInfo<ulong>
    {
        /// <summary>
        /// This class should be a singleton with the only instance stored by <see cref="NumberInfo"/>.
        /// </summary>
        internal ULongInfo() { }

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsZero(ulong value) => value == 0;
    }
    #endregion

    #region ISignInfo
    /// <summary>
    /// An <see cref="ISignInfo{T}"/> implementation for <see cref="sbyte"/> instances.
    /// </summary>
    public sealed class SByteInfo : ISignInfo<sbyte>
    {
        /// <summary>
        /// This class should be a singleton with the only instance stored by <see cref="NumberInfo"/>.
        /// </summary>
        internal SByteInfo() { }

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsZero(sbyte value) => value == 0;

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Sign(sbyte value) => Math.Sign(value);
    }

    /// <summary>
    /// An <see cref="ISignInfo{T}"/> implementation for <see cref="short"/> instances.
    /// </summary>
    public sealed class ShortInfo : ISignInfo<short>
    {
        /// <summary>
        /// This class should be a singleton with the only instance stored by <see cref="NumberInfo"/>.
        /// </summary>
        internal ShortInfo() { }

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsZero(short value) => value == 0;

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Sign(short value) => Math.Sign(value);
    }

    /// <summary>
    /// An <see cref="ISignInfo{T}"/> implementation for <see cref="int"/> instances.
    /// </summary>
    public sealed class IntInfo : ISignInfo<int>
    {
        /// <summary>
        /// This class should be a singleton with the only instance stored by <see cref="NumberInfo"/>.
        /// </summary>
        internal IntInfo() { }

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsZero(int value) => value == 0;

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Sign(int value) => Math.Sign(value);
    }

    /// <summary>
    /// An <see cref="ISignInfo{T}"/> implementation for <see cref="sbyte"/> instances.
    /// </summary>
    public sealed class LongInfo : ISignInfo<long>
    {
        /// <summary>
        /// This class should be a singleton with the only instance stored by <see cref="NumberInfo"/>.
        /// </summary>
        internal LongInfo() { }

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsZero(long value) => value == 0;

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Sign(long value) => Math.Sign(value);
    }

    /// <summary>
    /// An <see cref="ISignInfo{T}"/> implementation for <see cref="BigInteger"/> instances.
    /// </summary>
    public sealed class BigIntegerInfo : ISignInfo<BigInteger>
    {
        /// <summary>
        /// This class should be a singleton with the only instance stored by <see cref="NumberInfo"/>.
        /// </summary>
        internal BigIntegerInfo() { }

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsZero(BigInteger value) => value == 0;

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Sign(BigInteger value) => value.Sign;
    }

    /// <summary>
    /// An <see cref="ISignInfo{T}"/> implementation for <see cref="decimal"/> instances.
    /// </summary>
    public sealed class DecimalInfo : ISignInfo<decimal>
    {
        /// <summary>
        /// This class should be a singleton with the only instance stored by <see cref="NumberInfo"/>.
        /// </summary>
        internal DecimalInfo() { }

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsZero(decimal value) => value == 0;

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Sign(decimal value) => Math.Sign(value);
    }
    #endregion

    #region IFloatInfo
    /// <summary>
    /// An <see cref="IFloatInfo{T}"/> implementation for <see cref="double"/> instances.
    /// </summary>
    public sealed class DoubleInfo : IFloatInfo<double>
    {
        /// <summary>
        /// This class should be a singleton with the only instance stored by <see cref="NumberInfo"/>.
        /// </summary>
        internal DoubleInfo() { }

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsFinite(double value) => !(IsInfinity(value) || IsNaN(value));

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsInfinity(double value) => double.IsInfinity(value);

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int? Sign(double value) => IsNaN(value) ? null : Math.Sign(value);

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsNaN(double value) => double.IsNaN(value);

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsZero(double value) => value == 0;
    }

    /// <summary>
    /// An <see cref="IFloatInfo{T}"/> implementation for <see cref="float"/> instances.
    /// </summary>
    public sealed class FloatInfo : IFloatInfo<float>
    {
        /// <summary>
        /// This class should be a singleton with the only instance stored by <see cref="NumberInfo"/>.
        /// </summary>
        internal FloatInfo() { }

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsFinite(float value) => !(IsInfinity(value) || IsNaN(value));

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsInfinity(float value) => float.IsInfinity(value);

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int? Sign(float value) => IsNaN(value) ? null : Math.Sign(value);

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsNaN(float value) => float.IsNaN(value);

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsZero(float value) => value == 0;
    }

#if NET5_0_OR_GREATER
    /// <summary>
    /// An <see cref="IFloatInfo{T}"/> implementation for <see cref="half"/> instances.
    /// </summary>
    public sealed class HalfInfo : IFloatInfo<half>
    {
        /// <summary>
        /// This class should be a singleton with the only instance stored by <see cref="NumberInfo"/>.
        /// </summary>
        internal HalfInfo() { }

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsFinite(half value) => !(IsInfinity(value) || IsNaN(value));

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsInfinity(half value) => half.IsInfinity(value);

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int? Sign(half value) => IsNaN(value) ? null : Math.Sign((float)value);

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsNaN(half value) => half.IsNaN(value);

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsZero(half value) => value == (half)0;
    }
#endif
    #endregion
    #endregion
}
#endregion

#region Interfaces
/// <summary>
/// An interface for types that can provide info about instances of a given numeric type.
/// </summary>
/// <typeparam name="T"></typeparam>
public interface INumberInfo<T>
{
    /// <summary>
    /// Gets whether or not the supplied value is zero.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public bool IsZero(T value);
}

/// <summary>
/// An interface for types that can provide sign info for a given type.
/// </summary>
/// <typeparam name="T"></typeparam>
public interface ISignInfo<T> : INumberInfo<T>
{
    /// <summary>
    /// Gets the sign of the supplied value.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public int Sign(T value);
}

/// <summary>
/// An interface for types that can provide finiteness info for a given type.
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IFiniteInfo<T> : INumberInfo<T>
{
    /// <summary>
    /// Gets whether or not the supplied value is finite.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public bool IsFinite(T value);

    /// <summary>
    /// Gets whether or not the supplied value is infinity.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public bool IsInfinity(T value);
}

/// <summary>
/// An interface for types that can provide sign and finiteness info for a given float type.
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IFloatInfo<T> : IFiniteInfo<T>, INumberInfo<T>
{
    /// <summary>
    /// Gets the sign of the supplied value, or <see langword="null"/> if the supplied value is NaN.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public int? Sign(T value);

    /// <summary>
    /// Gets whether or not the supplied value is NaN.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public bool IsNaN(T value);
}
#endregion
