using Rem.Core.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Rem.Core.Utilities.FluentThrowerHelpers;

/// <summary>
/// Helper methods for throwing exceptions using <see cref="INumberInfo{T}"/> instances.
/// </summary>
public static class NumberInfoThrowHelpers
{
    #region Arguments
    /// <summary>
    /// Throws an exception if the argument value passed in is negative.
    /// </summary>
    /// <typeparam name="TInfo"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="info"></param>
    /// <param name="paramValue">The value of the parameter to test.</param>
    /// <param name="paramName">The name of the parameter to test.</param>
    /// <param name="message">An optional error message, or <see langword="null"/> to use a default message.</param>
    /// <returns><paramref name="paramValue"/></returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="paramValue"/> was negative.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TValue ThrowIfArgNegative<TInfo, TValue>(
        TInfo info, TValue paramValue, string paramName, string? message)
        where TInfo : ISignInfo<TValue>
        => info.Sign(paramValue) < 0
            ? throw new ArgumentOutOfRangeException(paramName, paramValue, message ?? "Value cannot be negative.")
            : paramValue;

    /// <summary>
    /// Throws an exception if the argument value passed in is not positive.
    /// </summary>
    /// <typeparam name="TInfo"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="info"></param>
    /// <param name="paramValue">The value of the parameter to test.</param>
    /// <param name="paramName">The name of the parameter to test.</param>
    /// <param name="message">An optional error message, or <see langword="null"/> to use a default message.</param>
    /// <returns><paramref name="paramValue"/></returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="paramValue"/> was not positive.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TValue ThrowIfArgNotPositive<TInfo, TValue>(
        TInfo info, TValue paramValue, string paramName, string? message)
        where TInfo : ISignInfo<TValue>
        => info.Sign(paramValue) <= 0
            ? throw new ArgumentOutOfRangeException(paramName, paramValue, message ?? "Value must be positive.")
            : paramValue;

    /// <summary>
    /// Throws an exception if the argument value passed in is zero.
    /// </summary>
    /// <typeparam name="TInfo"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="paramValue">The value of the parameter to test.</param>
    /// <param name="paramName">The name of the parameter to test.</param>
    /// <param name="message">An optional error message, or <see langword="null"/> to use a default message.</param>
    /// <returns><paramref name="paramValue"/></returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="paramValue"/> was zero.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TValue ThrowIfArgZero<TInfo, TValue>(
        TInfo info, TValue paramValue, string paramName, string? message)
        where TInfo : INumberInfo<TValue>
        => info.IsZero(paramValue)
            ? throw new ArgumentOutOfRangeException(paramName, message ?? "Value cannot be zero.")
            : paramValue;

    /// <summary>
    /// Throws an exception if the argument value passed in is not negative.
    /// </summary>
    /// <typeparam name="TInfo"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="info"></param>
    /// <param name="paramValue">The value of the parameter to test.</param>
    /// <param name="paramName">The name of the parameter to test.</param>
    /// <param name="message">An optional error message, or <see langword="null"/> to use a default message.</param>
    /// <returns><paramref name="paramValue"/></returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="paramValue"/> was not negative.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TValue ThrowIfArgNotNegative<TInfo, TValue>(
        TInfo info, TValue paramValue, string paramName, string? message)
        where TInfo : ISignInfo<TValue>
        => info.Sign(paramValue) >= 0
            ? throw new ArgumentOutOfRangeException(paramName, paramValue, message ?? "Value must be negative.")
            : paramValue;

    /// <summary>
    /// Throws an exception if the argument value passed in is positive.
    /// </summary>
    /// <typeparam name="TInfo"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="info"></param>
    /// <param name="paramValue">The value of the parameter to test.</param>
    /// <param name="paramName">The name of the parameter to test.</param>
    /// <param name="message">An optional error message, or <see langword="null"/> to use a default message.</param>
    /// <returns><paramref name="paramValue"/></returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="paramValue"/> was positive.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TValue ThrowIfArgPositive<TInfo, TValue>(
        TInfo info, TValue paramValue, string paramName, string? message)
        where TInfo : ISignInfo<TValue>
        => info.Sign(paramValue) > 0
            ? throw new ArgumentOutOfRangeException(paramName, paramValue, message ?? "Value cannot be positive.")
            : paramValue;

    /// <summary>
    /// Throws an exception if the argument value passed in is not finite.
    /// </summary>
    /// <typeparam name="TInfo"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="paramValue">The value of the parameter to test.</param>
    /// <param name="paramName">The name of the parameter to test.</param>
    /// <param name="message">An optional error message, or <see langword="null"/> to use a default message.</param>
    /// <returns><paramref name="paramValue"/></returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="paramValue"/> was not finite.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TValue ThrowIfArgNotFinite<TInfo, TValue>(
        TInfo info, TValue paramValue, string paramName, string? message)
        where TInfo : IFiniteInfo<TValue>
        => info.IsFinite(paramValue)
            ? paramValue
            : throw new ArgumentOutOfRangeException(
                paramName, paramValue, message ?? "Infinite values are not permitted.");
    #endregion

    #region Properties
    /// <summary>
    /// Throws an exception if the property set value passed in is negative.
    /// </summary>
    /// <typeparam name="TInfo"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="info"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property to test.</param>
    /// <param name="message">An optional error message, or <see langword="null"/> to use a default message.</param>
    /// <returns><paramref name="propSetValue"/></returns>
    /// <exception cref="PropertySetOutOfRangeException">
    /// <paramref name="propSetValue"/> was negative.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TValue ThrowIfPropSetNegative<TInfo, TValue>(
        TInfo info, TValue propSetValue, string propName, string? message)
        where TInfo : ISignInfo<TValue>
        => info.Sign(propSetValue) < 0
            ? throw new PropertySetOutOfRangeException(message ?? "Value cannot be negative.", propName, propSetValue)
            : propSetValue;

    /// <summary>
    /// Throws an exception if the property set value passed in is not positive.
    /// </summary>
    /// <typeparam name="TInfo"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="info"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property to test.</param>
    /// <param name="message">An optional error message, or <see langword="null"/> to use a default message.</param>
    /// <returns><paramref name="propSetValue"/></returns>
    /// <exception cref="PropertySetOutOfRangeException">
    /// <paramref name="propSetValue"/> was not positive.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TValue ThrowIfPropSetNotPositive<TInfo, TValue>(
        TInfo info, TValue propSetValue, string propName, string? message)
        where TInfo : ISignInfo<TValue>
        => info.Sign(propSetValue) <= 0
            ? throw new PropertySetOutOfRangeException(message ?? "Value must be positive.", propName, propSetValue)
            : propSetValue;

    /// <summary>
    /// Throws an exception if the property set value passed in is zero.
    /// </summary>
    /// <typeparam name="TInfo"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property to test.</param>
    /// <param name="message">An optional error message, or <see langword="null"/> to use a default message.</param>
    /// <returns><paramref name="propSetValue"/></returns>
    /// <exception cref="PropertySetOutOfRangeException">
    /// <paramref name="propSetValue"/> was zero.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TValue ThrowIfPropSetZero<TInfo, TValue>(
        TInfo info, TValue propSetValue, string propName, string? message)
        where TInfo : INumberInfo<TValue>
        => info.IsZero(propSetValue)
            ? throw new PropertySetOutOfRangeException(message ?? "Value cannot be zero.", propName, propSetValue)
            : propSetValue;

    /// <summary>
    /// Throws an exception if the property set value passed in is not negative.
    /// </summary>
    /// <typeparam name="TInfo"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="info"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property to test.</param>
    /// <param name="message">An optional error message, or <see langword="null"/> to use a default message.</param>
    /// <returns><paramref name="propSetValue"/></returns>
    /// <exception cref="PropertySetOutOfRangeException">
    /// <paramref name="propSetValue"/> was not negative.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TValue ThrowIfPropSetNotNegative<TInfo, TValue>(
        TInfo info, TValue propSetValue, string propName, string? message)
        where TInfo : ISignInfo<TValue>
        => info.Sign(propSetValue) >= 0
            ? throw new PropertySetOutOfRangeException(message ?? "Value must be negative.", propName, propSetValue)
            : propSetValue;

    /// <summary>
    /// Throws an exception if the property set value passed in is positive.
    /// </summary>
    /// <typeparam name="TInfo"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="info"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property to test.</param>
    /// <param name="message">An optional error message, or <see langword="null"/> to use a default message.</param>
    /// <returns><paramref name="propSetValue"/></returns>
    /// <exception cref="PropertySetOutOfRangeException">
    /// <paramref name="propSetValue"/> was positive.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TValue ThrowIfPropSetPositive<TInfo, TValue>(
        TInfo info, TValue propSetValue, string propName, string? message)
        where TInfo : ISignInfo<TValue>
        => info.Sign(propSetValue) > 0
            ? throw new PropertySetOutOfRangeException(message ?? "Value cannot be positive.", propName, propSetValue)
            : propSetValue;

    /// <summary>
    /// Throws an exception if the property set value passed in is not finite.
    /// </summary>
    /// <typeparam name="TInfo"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property to test.</param>
    /// <param name="message">An optional error message, or <see langword="null"/> to use a default message.</param>
    /// <returns><paramref name="propSetValue"/></returns>
    /// <exception cref="PropertySetOutOfRangeException">
    /// <paramref name="propSetValue"/> was not finite.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TValue ThrowIfPropSetNotFinite<TInfo, TValue>(
        TInfo info, TValue propSetValue, string propName, string? message)
        where TInfo : IFiniteInfo<TValue>
        => info.IsFinite(propSetValue)
            ? propSetValue
            : throw new PropertySetOutOfRangeException(
                propName, message ?? "Non-finite values are not permitted.", propSetValue);
    #endregion
}

/// <summary>
/// Helper methods for throwing exceptions using <see cref="IFloatInfo{T}"/> instances.
/// </summary>
public static class FloatInfoThrowHelpers
{
    #region Arguments
    /// <summary>
    /// Throws an exception if the argument value passed in is negative.
    /// </summary>
    /// <typeparam name="TInfo"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="info"></param>
    /// <param name="paramValue">The value of the parameter to test.</param>
    /// <param name="paramName">The name of the parameter to test.</param>
    /// <param name="message">An optional message, or <see langword="null"/> to use a default message.</param>
    /// <returns><paramref name="paramValue"/></returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="paramValue"/> was negative.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TValue ThrowIfArgNegative<TInfo, TValue>(
        TInfo info, TValue paramValue, string paramName, string? message)
        where TInfo : IFloatInfo<TValue>
        => info.Sign(paramValue) < 0
            ? throw new ArgumentOutOfRangeException(paramName, paramValue, message ?? "Value cannot be negative.")
            : paramValue;

    /// <summary>
    /// Throws an exception if the argument value passed in is not positive.
    /// </summary>
    /// <typeparam name="TInfo"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="info"></param>
    /// <param name="paramValue">The value of the parameter to test.</param>
    /// <param name="paramName">The name of the parameter to test.</param>
    /// <param name="message">An optional error message, or <see langword="null"/> to use a default message.</param>
    /// <returns><paramref name="paramValue"/></returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="paramValue"/> was not positive.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TValue ThrowIfArgNotPositive<TInfo, TValue>(
        TInfo info, TValue paramValue, string paramName, string? message)
        where TInfo : IFloatInfo<TValue>
        => info.Sign(paramValue) <= 0
            ? throw new ArgumentOutOfRangeException(paramName, paramValue, message ?? "Value must be positive.")
            : paramValue;

    /// <summary>
    /// Throws an exception if the argument value passed in is not negative.
    /// </summary>
    /// <typeparam name="TInfo"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="info"></param>
    /// <param name="paramValue">The value of the parameter to test.</param>
    /// <param name="paramName">The name of the parameter to test.</param>
    /// <param name="message">An optional error message, or <see langword="null"/> to use a default message.</param>
    /// <returns><paramref name="paramValue"/></returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="paramValue"/> was not negative.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TValue ThrowIfArgNotNegative<TInfo, TValue>(
        TInfo info, TValue paramValue, string paramName, string? message)
        where TInfo : IFloatInfo<TValue>
        => info.Sign(paramValue) >= 0
            ? throw new ArgumentOutOfRangeException(paramName, paramValue, message ?? "Value must be negative.")
            : paramValue;

    /// <summary>
    /// Throws an exception if the argument value passed in is positive.
    /// </summary>
    /// <typeparam name="TInfo"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="info"></param>
    /// <param name="paramValue">The value of the parameter to test.</param>
    /// <param name="paramName">The name of the parameter to test.</param>
    /// <param name="message">An optional message, or <see langword="null"/> to use a default message.</param>
    /// <returns><paramref name="paramValue"/></returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="paramValue"/> was positive.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TValue ThrowIfArgPositive<TInfo, TValue>(
        TInfo info, TValue paramValue, string paramName, string? message)
        where TInfo : IFloatInfo<TValue>
        => info.Sign(paramValue) > 0
            ? throw new ArgumentOutOfRangeException(paramName, paramValue, message ?? "Value cannot be positive.")
            : paramValue;

    /// <summary>
    /// Throws an exception if the argument value passed in is a not-a-number (NaN) value.
    /// </summary>
    /// <typeparam name="TInfo"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="info"></param>
    /// <param name="paramValue">The value of the parameter to test.</param>
    /// <param name="paramName">The name of the parameter to test.</param>
    /// <param name="message">An optional error message, or <see langword="null"/> to use a default message.</param>
    /// <returns><paramref name="paramValue"/></returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// <paramref name="paramValue"/> was NaN.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TValue ThrowIfArgNaN<TInfo, TValue>(
        TInfo info, TValue paramValue, string paramName, string? message)
        where TInfo : IFloatInfo<TValue>
        => info.IsNaN(paramValue)
            ? throw new ArgumentOutOfRangeException(
                paramName, message ?? "Floating point not-a-number values are not permitted.")
            : paramValue;
    #endregion

    #region Properties
    /// <summary>
    /// Throws an exception if the property set value passed in is negative.
    /// </summary>
    /// <typeparam name="TInfo"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="info"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property to test.</param>
    /// <param name="message">An optional message, or <see langword="null"/> to use a default message.</param>
    /// <returns><paramref name="propSetValue"/></returns>
    /// <exception cref="PropertySetOutOfRangeException">
    /// <paramref name="propSetValue"/> was negative.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TValue ThrowIfPropSetNegative<TInfo, TValue>(
        TInfo info, TValue propSetValue, string propName, string? message)
        where TInfo : IFloatInfo<TValue>
        => info.Sign(propSetValue) < 0
            ? throw new PropertySetOutOfRangeException(message ?? "Value cannot be negative.", propName, propSetValue)
            : propSetValue;

    /// <summary>
    /// Throws an exception if the property set value passed in is not positive.
    /// </summary>
    /// <typeparam name="TInfo"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="info"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property to test.</param>
    /// <param name="message">An optional error message, or <see langword="null"/> to use a default message.</param>
    /// <returns><paramref name="propSetValue"/></returns>
    /// <exception cref="PropertySetOutOfRangeException">
    /// <paramref name="propSetValue"/> was not positive.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TValue ThrowIfPropSetNotPositive<TInfo, TValue>(
        TInfo info, TValue propSetValue, string propName, string? message)
        where TInfo : IFloatInfo<TValue>
        => info.Sign(propSetValue) <= 0
            ? throw new PropertySetOutOfRangeException(message ?? "Value must be positive.", propName, propSetValue)
            : propSetValue;

    /// <summary>
    /// Throws an exception if the property set value passed in is not negative.
    /// </summary>
    /// <typeparam name="TInfo"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="info"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property to test.</param>
    /// <param name="message">An optional error message, or <see langword="null"/> to use a default message.</param>
    /// <returns><paramref name="propSetValue"/></returns>
    /// <exception cref="PropertySetOutOfRangeException">
    /// <paramref name="propSetValue"/> was not negative.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TValue ThrowIfPropSetNotNegative<TInfo, TValue>(
        TInfo info, TValue propSetValue, string propName, string? message)
        where TInfo : IFloatInfo<TValue>
        => info.Sign(propSetValue) >= 0
            ? throw new PropertySetOutOfRangeException(message ?? "Value must be negative.", propName, propSetValue)
            : propSetValue;

    /// <summary>
    /// Throws an exception if the property set value passed in is positive.
    /// </summary>
    /// <typeparam name="TInfo"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="info"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property to test.</param>
    /// <param name="message">An optional message, or <see langword="null"/> to use a default message.</param>
    /// <returns><paramref name="propSetValue"/></returns>
    /// <exception cref="PropertySetOutOfRangeException">
    /// <paramref name="propSetValue"/> was positive.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TValue ThrowIfPropSetPositive<TInfo, TValue>(
        TInfo info, TValue propSetValue, string propName, string? message)
        where TInfo : IFloatInfo<TValue>
        => info.Sign(propSetValue) > 0
            ? throw new PropertySetOutOfRangeException(message ?? "Value cannot be positive.", propName, propSetValue)
            : propSetValue;

    /// <summary>
    /// Throws an exception if the property set value passed in is a not-a-number (NaN) value.
    /// </summary>
    /// <typeparam name="TInfo"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="info"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property to test.</param>
    /// <param name="message">An optional error message, or <see langword="null"/> to use a default message.</param>
    /// <returns><paramref name="propSetValue"/></returns>
    /// <exception cref="PropertySetOutOfRangeException">
    /// <paramref name="propSetValue"/> was NaN.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TValue ThrowIfPropSetNaN<TInfo, TValue>(
        TInfo info, TValue propSetValue, string propName, string? message)
        where TInfo : IFloatInfo<TValue>
        => info.IsNaN(propSetValue)
            ? throw new PropertySetOutOfRangeException(message ?? "Not-a-number values are not permitted.", propName)
            : propSetValue;
    #endregion
}
