using Rem.Core.ComponentModel;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Rem.Core.Utilities.FluentThrower.Extensions;

/// <summary>
/// A series of extension methods offering a simple fluent API for throwing exceptions relating to comparable values.
/// </summary>
public static class ComparisonThrowerExtensions
{
    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is greater than the maximum
    /// value passed in.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="max">The maximum value to check against.</param>
    /// <param name="paramValue">The value of the parameter to test.</param>
    /// <param name="paramName">The name of the parameter to test.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The argument value was greater than the maximum.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TNumber IfArgGreaterThan<TNumber>(
        this IComparisonThrower _, in TNumber max, in TNumber paramValue, string paramName, string? message = null)
        where TNumber : IComparable<TNumber>
        => paramValue.CompareTo(max) > 0
            ? throw new ArgumentOutOfRangeException(
                paramName,
                paramValue,
                message ?? $"Value must be greater than {max}.")
            : paramValue;

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is greater than or equal
    /// to the maximum value passed in.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="max">The maximum value to check against.</param>
    /// <param name="paramValue">The value of the parameter to test.</param>
    /// <param name="paramName">The name of the parameter to test.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The argument value was greater than or equal to the maximum.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TNumber IfArgGreaterThanOrEqualTo<TNumber>(
        this IComparisonThrower _, in TNumber max, in TNumber paramValue, string paramName, string? message = null)
        where TNumber : IComparable<TNumber>
        => paramValue.CompareTo(max) >= 0
            ? throw new ArgumentOutOfRangeException(
                paramName,
                paramValue,
                message ?? $"Value must be greater than {max}.")
            : paramValue;

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is less than or equal
    /// to the minimum value passed in.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="min">The minimum value to check against.</param>
    /// <param name="paramValue">The value of the parameter to test.</param>
    /// <param name="paramName">The name of the parameter to test.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The argument value was less than or equal to the minimum.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TNumber IfArgLessThanOrEqualTo<TNumber>(
        this IComparisonThrower _, in TNumber min, in TNumber paramValue, string paramName, string? message = null)
        where TNumber : IComparable<TNumber>
        => paramValue.CompareTo(min) <= 0
            ? throw new ArgumentOutOfRangeException(
                paramName,
                paramValue,
                message ?? $"Value must be greater than {min}.")
            : paramValue;

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is less than the minimum
    /// value passed in.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="min">The minimum value to check against.</param>
    /// <param name="paramValue">The value of the parameter to test.</param>
    /// <param name="paramName">The name of the parameter to test.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The argument value was less than the minimum.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TNumber IfArgLessThan<TNumber>(
        this IComparisonThrower _, in TNumber min, in TNumber paramValue, string paramName, string? message = null)
        where TNumber : IComparable<TNumber>
        => paramValue.CompareTo(min) < 0
            ? throw new ArgumentOutOfRangeException(
                paramName,
                paramValue,
                message ?? $"Value must be greater than {min}.")
            : paramValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is greater than the
    /// maximum value passed in.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="max">The maximum value to check against.</param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">
    /// The property set value was greater than the maximum.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TNumber IfPropSetGreaterThan<TNumber>(
        this IComparisonThrower _,
        in TNumber max, in TNumber propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        where TNumber : IComparable<TNumber>
        => propSetValue.CompareTo(max) > 0
            ? throw new PropertySetOutOfRangeException(
                message ?? $"Value must be greater than {max}.",
                propName!,
                propSetValue)
            : propSetValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is greater than or
    /// equal to the maximum value passed in.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="max">The maximum value to check against.</param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">
    /// The property set value was greater than or equal to the maximum.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TNumber IfPropSetGreaterThanOrEqualTo<TNumber>(
        this IComparisonThrower _,
        in TNumber max, in TNumber propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        where TNumber : IComparable<TNumber>
        => propSetValue.CompareTo(max) >= 0
            ? throw new PropertySetOutOfRangeException(
                message ?? $"Value must be greater than {max}.",
                propName!,
                propSetValue)
            : propSetValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is less than or equal
    /// to the minimum value passed in.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="min">The minimum value to check against.</param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">
    /// The property set value was less than or equal to the minimum.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TNumber IfPropSetLessThanOrEqualTo<TNumber>(
        this IComparisonThrower _,
        in TNumber min, in TNumber propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        where TNumber : IComparable<TNumber>
        => propSetValue.CompareTo(min) <= 0
            ? throw new PropertySetOutOfRangeException(
                message ?? $"Value must be greater than {min}.",
                propName!,
                propSetValue)
            : propSetValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is less than the
    /// minimum value passed in.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="min">The minimum value to check against.</param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// The property set value was less than the minimum.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TNumber IfPropSetLessThan<TNumber>(
        this IComparisonThrower _,
        in TNumber min, in TNumber propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        where TNumber : IComparable<TNumber>
        => propSetValue.CompareTo(min) < 0
            ? throw new PropertySetOutOfRangeException(
                message ?? $"Value must be greater than {min}.",
                propName!,
                propSetValue)
            : propSetValue;
}

