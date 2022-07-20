using Rem.Core.Attributes;
using Rem.Core.ComponentModel;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Rem.Core.Utilities.FluentThrowerExtensions;

/// <summary>
/// A series of extension methods offering a simple fluent API for throwing exceptions relating to invalid
/// numerical ranges.
/// </summary>
public static class NumericRangeFluentThrowerExtensions
{
    #region Signs
    #region Signs.Byte
    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was zero.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonZero]
    public static byte IfArgZero(this INumericRangeFluentThrower _, byte argValue, string argName, string? message = null)
        => argValue == 0
            ? throw new ArgumentOutOfRangeException(argName, message ?? "Value cannot be zero.")
            : argValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was zero.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonZero]
    public static byte IfPropSetZero(
        this INumericRangeFluentThrower _,
        byte propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue == 0
            ? throw new PropertySetOutOfRangeException(message ?? "Value cannot be zero.", propName!)
            : propSetValue;
    #endregion

    #region Signs.SByte
    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonNegative]
    public static sbyte IfArgNegative(this INumericRangeFluentThrower _, sbyte argValue, string argName, string? message = null)
        => argValue < 0
            ? throw new ArgumentOutOfRangeException(
                argName, argValue, message ?? "Value cannot be negative.")
            : argValue;

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is non-positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was not positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Positive]
    public static sbyte IfArgNotPositive(
        this INumericRangeFluentThrower _, sbyte argValue, string argName, string? message = null)
        => argValue > 0
            ? argValue
            : throw new ArgumentOutOfRangeException(
                argName, argValue, message ?? "Value must be positive.");

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was zero.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonZero]
    public static sbyte IfArgZero(this INumericRangeFluentThrower _, sbyte argValue, string argName, string? message = null)
        => argValue == 0
            ? throw new ArgumentOutOfRangeException(argName, message ?? "Value cannot be zero.")
            : argValue;

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is non-negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was not negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Negative]
    public static sbyte IfArgNotNegative(
        this INumericRangeFluentThrower _, sbyte argValue, string argName, string? message = null)
        => argValue < 0
            ? argValue
            : throw new ArgumentOutOfRangeException(argName, argValue, message ?? "Value must be negative.");

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonPositive]
    public static sbyte IfArgPositive(this INumericRangeFluentThrower _, sbyte argValue, string argName, string? message = null)
        => argValue > 0
            ? throw new ArgumentOutOfRangeException(argName, argValue, message ?? "Value cannot be positive.")
            : argValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonNegative]
    public static sbyte IfPropSetNegative(
        this INumericRangeFluentThrower _, sbyte propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue < 0
            ? throw new PropertySetOutOfRangeException(
                message ?? "Value cannot be negative.", propName!, propSetValue)
            : propSetValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is non-positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was not positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Positive]
    public static sbyte IfPropSetNotPositive(
        this INumericRangeFluentThrower _, sbyte propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue > 0
            ? propSetValue
            : throw new PropertySetOutOfRangeException(
                message ?? "Value must be positive.", propName!, propSetValue);

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was zero.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonZero]
    public static sbyte IfPropSetZero(
        this INumericRangeFluentThrower _, sbyte propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue == 0
            ? throw new PropertySetOutOfRangeException(message ?? "Value cannot be zero.", propName!)
            : propSetValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is non-negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was not negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Negative]
    public static sbyte IfPropSetNotNegative(
        this INumericRangeFluentThrower _, sbyte propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue < 0
            ? propSetValue
            : throw new PropertySetOutOfRangeException(
                message ?? "Value must be negative.", propName!, propSetValue);

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonPositive]
    public static sbyte IfPropSetPositive(
        this INumericRangeFluentThrower _, sbyte propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue > 0
            ? throw new PropertySetOutOfRangeException(
                message ?? "Value cannot be positive.", propName!, propSetValue)
            : propSetValue;
    #endregion

    #region Signs.Short
    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonNegative]
    public static short IfArgNegative(this INumericRangeFluentThrower _, short argValue, string argName, string? message = null)
        => argValue < 0
            ? throw new ArgumentOutOfRangeException(
                argName, argValue, message ?? "Value cannot be negative.")
            : argValue;

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is non-positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was not positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Positive]
    public static short IfArgNotPositive(
        this INumericRangeFluentThrower _, short argValue, string argName, string? message = null)
        => argValue > 0
            ? argValue
            : throw new ArgumentOutOfRangeException(
                argName, argValue, message ?? "Value must be positive.");

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was zero.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonZero]
    public static short IfArgZero(this INumericRangeFluentThrower _, short argValue, string argName, string? message = null)
        => argValue == 0
            ? throw new ArgumentOutOfRangeException(argName, message ?? "Value cannot be zero.")
            : argValue;

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is non-negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was not negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Negative]
    public static short IfArgNotNegative(
        this INumericRangeFluentThrower _, short argValue, string argName, string? message = null)
        => argValue < 0
            ? argValue
            : throw new ArgumentOutOfRangeException(argName, argValue, message ?? "Value must be negative.");

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonPositive]
    public static short IfArgPositive(this INumericRangeFluentThrower _, short argValue, string argName, string? message = null)
        => argValue > 0
            ? throw new ArgumentOutOfRangeException(argName, argValue, message ?? "Value cannot be positive.")
            : argValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonNegative]
    public static short IfPropSetNegative(
        this INumericRangeFluentThrower _, short propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue < 0
            ? throw new PropertySetOutOfRangeException(
                message ?? "Value cannot be negative.", propName!, propSetValue)
            : propSetValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is non-positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was not positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Positive]
    public static short IfPropSetNotPositive(
        this INumericRangeFluentThrower _, short propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue > 0
            ? propSetValue
            : throw new PropertySetOutOfRangeException(
                message ?? "Value must be positive.", propName!, propSetValue);

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was zero.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonZero]
    public static short IfPropSetZero(
        this INumericRangeFluentThrower _, short propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue == 0
            ? throw new PropertySetOutOfRangeException(message ?? "Value cannot be zero.", propName!)
            : propSetValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is non-negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was not negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Negative]
    public static short IfPropSetNotNegative(
        this INumericRangeFluentThrower _, short propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue < 0
            ? propSetValue
            : throw new PropertySetOutOfRangeException(
                message ?? "Value must be negative.", propName!, propSetValue);

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonPositive]
    public static short IfPropSetPositive(
        this INumericRangeFluentThrower _, short propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue > 0
            ? throw new PropertySetOutOfRangeException(
                 message ?? "Value cannot be positive.", propName!, propSetValue)
            : propSetValue;
    #endregion

    #region Signs.UShort
    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was zero.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonZero]
    public static ushort IfArgZero(
        this INumericRangeFluentThrower _, ushort argValue, string argName, string? message = null)
        => argValue == 0
            ? throw new ArgumentOutOfRangeException(argName, message ?? "Value cannot be zero.")
            : argValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was zero.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonZero]
    public static ushort IfPropSetZero(
        this INumericRangeFluentThrower _, ushort propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue == 0
            ? throw new PropertySetOutOfRangeException(message ?? "Value cannot be zero.", propName!)
            : propSetValue;
    #endregion

    #region Signs.Int
    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonNegative]
    public static int IfArgNegative(this INumericRangeFluentThrower _, int argValue, string argName, string? message = null)
        => argValue < 0
            ? throw new ArgumentOutOfRangeException(
                argName, argValue, message ?? "Value cannot be negative.")
            : argValue;

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is non-positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was not positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Positive]
    public static int IfArgNotPositive(this INumericRangeFluentThrower _, int argValue, string argName, string? message = null)
        => argValue > 0
            ? argValue
            : throw new ArgumentOutOfRangeException(
                argName, argValue, message ?? "Value must be positive.");

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was zero.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonZero]
    public static int IfArgZero(this INumericRangeFluentThrower _, int argValue, string argName, string? message = null)
        => argValue == 0
            ? throw new ArgumentOutOfRangeException(argName, message ?? "Value cannot be zero.")
            : argValue;

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is non-negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was not negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Negative]
    public static int IfArgNotNegative(this INumericRangeFluentThrower _, int argValue, string argName, string? message = null)
        => argValue < 0
            ? argValue
            : throw new ArgumentOutOfRangeException(argName, argValue, message ?? "Value must be negative.");

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonPositive]
    public static int IfArgPositive(this INumericRangeFluentThrower _, int argValue, string argName, string? message = null)
        => argValue > 0
            ? throw new ArgumentOutOfRangeException(argName, argValue, message ?? "Value cannot be positive.")
            : argValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonNegative]
    public static int IfPropSetNegative(
        this INumericRangeFluentThrower _, int propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue < 0
            ? throw new PropertySetOutOfRangeException(
                 message ?? "Value cannot be negative.", propName!, propSetValue)
            : propSetValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is non-positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was not positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Positive]
    public static int IfPropSetNotPositive(
        this INumericRangeFluentThrower _, int propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue > 0
            ? propSetValue
            : throw new PropertySetOutOfRangeException(
                message ?? "Value must be positive.", propName!, propSetValue);

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was zero.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonZero]
    public static int IfPropSetZero(this INumericRangeFluentThrower _, int propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue == 0
            ? throw new PropertySetOutOfRangeException(message ?? "Value cannot be zero.", propName!)
            : propSetValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is non-negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was not negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Negative]
    public static int IfPropSetNotNegative(
        this INumericRangeFluentThrower _, int propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue < 0
            ? propSetValue
            : throw new PropertySetOutOfRangeException(
                message ?? "Value must be negative.", propName!, propSetValue);

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonPositive]
    public static int IfPropSetPositive(
        this INumericRangeFluentThrower _, int propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue > 0
            ? throw new PropertySetOutOfRangeException(
                message ?? "Value cannot be positive.", propName!, propSetValue)
            : propSetValue;
    #endregion

    #region Signs.UInt
    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was zero.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonZero]
    public static uint IfArgZero(this INumericRangeFluentThrower _, uint argValue, string argName, string? message = null)
        => argValue == 0
            ? throw new ArgumentOutOfRangeException(argName, message ?? "Value cannot be zero.")
            : argValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was zero.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonZero]
    public static uint IfPropSetZero(this INumericRangeFluentThrower _, uint propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue == 0
            ? throw new PropertySetOutOfRangeException(message ?? "Value cannot be zero.", propName!)
            : propSetValue;
    #endregion

    #region Signs.Long
    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonNegative]
    public static long IfArgNegative(this INumericRangeFluentThrower _, long argValue, string argName, string? message = null)
        => argValue < 0
            ? throw new ArgumentOutOfRangeException(
                argName, argValue, message ?? "Value cannot be negative.")
            : argValue;

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is non-positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was not positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Positive]
    public static long IfArgNotPositive(this INumericRangeFluentThrower _, long argValue, string argName, string? message = null)
        => argValue > 0
            ? argValue
            : throw new ArgumentOutOfRangeException(
                argName, argValue, message ?? "Value must be positive.");

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was zero.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonZero]
    public static long IfArgZero(this INumericRangeFluentThrower _, long argValue, string argName, string? message = null)
        => argValue == 0
            ? throw new ArgumentOutOfRangeException(argName, message ?? "Value cannot be zero.")
            : argValue;

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is non-negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was not negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Negative]
    public static long IfArgNotNegative(this INumericRangeFluentThrower _, long argValue, string argName, string? message = null)
        => argValue < 0
            ? argValue
            : throw new ArgumentOutOfRangeException(argName, argValue, message ?? "Value must be negative.");

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonPositive]
    public static long IfArgPositive(this INumericRangeFluentThrower _, long argValue, string argName, string? message = null)
        => argValue > 0
            ? throw new ArgumentOutOfRangeException(argName, argValue, message ?? "Value cannot be positive.")
            : argValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonNegative]
    public static long IfPropSetNegative(
        this INumericRangeFluentThrower _, long propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue < 0
            ? throw new PropertySetOutOfRangeException(
                message ?? "Value cannot be negative.", propName!, propSetValue)
            : propSetValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is non-positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was not positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Positive]
    public static long IfPropSetNotPositive(
        this INumericRangeFluentThrower _, long propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue > 0
            ? propSetValue
            : throw new PropertySetOutOfRangeException(
                message ?? "Value must be positive.", propName!, propSetValue);

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was zero.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonZero]
    public static long IfPropSetZero(
        this INumericRangeFluentThrower _, long propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue == 0
            ? throw new PropertySetOutOfRangeException(message ?? "Value cannot be zero.", propName!)
            : propSetValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is non-negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was not negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Negative]
    public static long IfPropSetNotNegative(
        this INumericRangeFluentThrower _, long propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue < 0
            ? propSetValue
            : throw new PropertySetOutOfRangeException(
                message ?? "Value must be negative.", propName!, propSetValue);

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonPositive]
    public static long IfPropSetPositive(
        this INumericRangeFluentThrower _, long propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue > 0
            ? throw new PropertySetOutOfRangeException(
                message ?? "Value cannot be positive.", propName!, propSetValue)
            : propSetValue;
    #endregion

    #region Signs.ULong
    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was zero.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonZero]
    public static ulong IfArgZero(this INumericRangeFluentThrower _, ulong argValue, string argName, string? message = null)
        => argValue == 0
            ? throw new ArgumentOutOfRangeException(argName, message ?? "Value cannot be zero.")
            : argValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was zero.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonZero]
    public static ulong IfPropSetZero(
        this INumericRangeFluentThrower _, ulong propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue == 0
            ? throw new PropertySetOutOfRangeException(message ?? "Value cannot be zero.", propName!)
            : propSetValue;
    #endregion

    #region Signs.Float
    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonNegative]
    public static float IfArgNegative(this INumericRangeFluentThrower _, float argValue, string argName, string? message = null)
        => argValue < 0
            ? throw new ArgumentOutOfRangeException(
                argName, argValue, message ?? "Value cannot be negative.")
            : argValue;

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is non-positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was not positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Positive]
    public static float IfArgNotPositive(
        this INumericRangeFluentThrower _, float argValue, string argName, string? message = null)
        => argValue > 0
            ? argValue
            : throw new ArgumentOutOfRangeException(
                argName, argValue, message ?? "Value must be positive.");

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was zero.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonZero]
    public static float IfArgZero(this INumericRangeFluentThrower _, float argValue, string argName, string? message = null)
        => argValue == 0
            ? throw new ArgumentOutOfRangeException(argName, message ?? "Value cannot be zero.")
            : argValue;

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is non-negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was not negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Negative]
    public static float IfArgNotNegative(
        this INumericRangeFluentThrower _, float argValue, string argName, string? message = null)
        => argValue < 0
            ? argValue
            : throw new ArgumentOutOfRangeException(argName, argValue, message ?? "Value must be negative.");

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonPositive]
    public static float IfArgPositive(this INumericRangeFluentThrower _, float argValue, string argName, string? message = null)
        => argValue > 0
            ? throw new ArgumentOutOfRangeException(argName, argValue, message ?? "Value cannot be positive.")
            : argValue;

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is not finite.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was not finite.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Finite]
    public static float IfArgNotFinite(this INumericRangeFluentThrower _, float argValue, string argName, string? message = null)
        => argValue.IsFinite()
            ? argValue
            : throw new ArgumentOutOfRangeException(argName, argValue, message ?? "Value must be finite.");

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is not a number
    /// (<see cref="float.NaN"/>).
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was not a number.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NotNaN]
    public static float IfArgNaN(this INumericRangeFluentThrower _, float argValue, string argName, string? message = null)
        => float.IsNaN(argValue)
            ? throw new ArgumentOutOfRangeException(
                argName, message ?? "Floating-point not-a-number values are not permitted.")
            : argValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonNegative]
    public static float IfPropSetNegative(
        this INumericRangeFluentThrower _, float propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue < 0
            ? throw new PropertySetOutOfRangeException(
                message ?? "Value cannot be negative.", propName!, propSetValue)
            : propSetValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is non-positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was not positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Positive]
    public static float IfPropSetNotPositive(
        this INumericRangeFluentThrower _, float propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue > 0
            ? propSetValue
            : throw new PropertySetOutOfRangeException(
                message ?? "Value must be positive.", propName!, propSetValue);

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was zero.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonZero]
    public static float IfPropSetZero(
        this INumericRangeFluentThrower _, float propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue == 0
            ? throw new PropertySetOutOfRangeException(message ?? "Value cannot be zero.", propName!)
            : propSetValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is non-negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was not negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Negative]
    public static float IfPropSetNotNegative(
        this INumericRangeFluentThrower _, float propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue < 0
            ? propSetValue
            : throw new PropertySetOutOfRangeException(
                message ?? "Value must be negative.", propName!, propSetValue);

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonPositive]
    public static float IfPropSetPositive(
        this INumericRangeFluentThrower _, float propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue > 0
            ? throw new PropertySetOutOfRangeException(
                message ?? "Value cannot be positive.", propName!, propSetValue)
            : propSetValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is not finite.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was not finite.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Finite]
    public static float IfPropSetNotFinite(
        this INumericRangeFluentThrower _, float propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue.IsFinite()
            ? propSetValue
            : throw new PropertySetOutOfRangeException(message ?? "Value must be finite.", propName!, propSetValue);

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the argument value passed in is not a number
    /// (<see cref="float.NaN"/>).
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was not a number.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NotNaN]
    public static float IfPropSetNaN(
        this INumericRangeFluentThrower _, float propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => float.IsNaN(propSetValue)
            ? throw new PropertySetOutOfRangeException(
                message ?? "Floating-point not-a-number values are not permitted.", propName!)
            : propSetValue;
    #endregion

    #region Signs.Double
    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonNegative]
    public static double IfArgNegative(this INumericRangeFluentThrower _, double argValue, string argName, string? message = null)
        => argValue < 0
            ? throw new ArgumentOutOfRangeException(
                argName, argValue, message ?? "Value cannot be negative.")
            : argValue;

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is non-positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was not positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Positive]
    public static double IfArgNotPositive(
        this INumericRangeFluentThrower _, double argValue, string argName, string? message = null)
        => argValue > 0
            ? argValue
            : throw new ArgumentOutOfRangeException(
                argName, argValue, message ?? "Value must be positive.");

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was zero.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonZero]
    public static double IfArgZero(this INumericRangeFluentThrower _, double argValue, string argName, string? message = null)
        => argValue == 0
            ? throw new ArgumentOutOfRangeException(argName, message ?? "Value cannot be zero.")
            : argValue;

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is non-negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was not negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Negative]
    public static double IfArgNotNegative(
        this INumericRangeFluentThrower _, double argValue, string argName, string? message = null)
        => argValue < 0
            ? argValue
            : throw new ArgumentOutOfRangeException(argName, argValue, message ?? "Value must be negative.");

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonPositive]
    public static double IfArgPositive(this INumericRangeFluentThrower _, double argValue, string argName, string? message = null)
        => argValue > 0
            ? throw new ArgumentOutOfRangeException(argName, argValue, message ?? "Value cannot be positive.")
            : argValue;

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is not finite.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was not finite.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Finite]
    public static double IfArgNotFinite(
        this INumericRangeFluentThrower _, double argValue, string argName, string? message = null)
        => argValue.IsFinite()
            ? argValue
            : throw new ArgumentOutOfRangeException(argName, argValue, message ?? "Value must be finite.");

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is not a number
    /// (<see cref="double.NaN"/>).
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was not a number.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NotNaN]
    public static double IfArgNaN(this INumericRangeFluentThrower _, double argValue, string argName, string? message = null)
        => double.IsNaN(argValue)
            ? throw new ArgumentOutOfRangeException(
                argName, message ?? "Floating-point not-a-number values are not permitted.")
            : argValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonNegative]
    public static double IfPropSetNegative(
        this INumericRangeFluentThrower _, double propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue < 0
            ? throw new PropertySetOutOfRangeException(
                message ?? "Value cannot be negative.", propName!, propSetValue)
            : propSetValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is non-positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was not positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Positive]
    public static double IfPropSetNotPositive(
        this INumericRangeFluentThrower _, double propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue > 0
            ? propSetValue
            : throw new PropertySetOutOfRangeException(
                message ?? "Value must be positive.", propName!, propSetValue);

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was zero.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonZero]
    public static double IfPropSetZero(
        this INumericRangeFluentThrower _, double propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue == 0
            ? throw new PropertySetOutOfRangeException(message ?? "Value cannot be zero.", propName!)
            : propSetValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is non-negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was not negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Negative]
    public static double IfPropSetNotNegative(
        this INumericRangeFluentThrower _, double propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue < 0
            ? propSetValue
            : throw new PropertySetOutOfRangeException(
                message ?? "Value must be negative.", propName!, propSetValue);

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonPositive]
    public static double IfPropSetPositive(
        this INumericRangeFluentThrower _, double propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue > 0
            ? throw new PropertySetOutOfRangeException(
                message ?? "Value cannot be positive.", propName!, propSetValue)
            : propSetValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is not finite.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was not finite.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Finite]
    public static double IfPropSetNotFinite(
        this INumericRangeFluentThrower _, double propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue.IsFinite()
            ? propSetValue
            : throw new PropertySetOutOfRangeException(message ?? "Value must be finite.", propName!, propSetValue);

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the argument value passed in is not a number
    /// (<see cref="double.NaN"/>).
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was not a number.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NotNaN]
    public static double IfPropSetNaN(
        this INumericRangeFluentThrower _, double propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => double.IsNaN(propSetValue)
            ? throw new PropertySetOutOfRangeException(
                message ?? "Floating-point not-a-number values are not permitted.", propName!)
            : propSetValue;
    #endregion

    #region Signs.Decimal
    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonNegative]
    public static decimal IfArgNegative(
        this INumericRangeFluentThrower _, decimal argValue, string argName, string? message = null)
        => argValue < 0
            ? throw new ArgumentOutOfRangeException(
                argName, argValue, message ?? "Value cannot be negative.")
            : argValue;

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is non-positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was not positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Positive]
    public static decimal IfArgNotPositive(
        this INumericRangeFluentThrower _, decimal argValue, string argName, string? message = null)
        => argValue > 0
            ? argValue
            : throw new ArgumentOutOfRangeException(
                argName, argValue, message ?? "Value must be positive.");

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was zero.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonZero]
    public static decimal IfArgZero(
        this INumericRangeFluentThrower _, decimal argValue, string argName, string? message = null)
        => argValue == 0
            ? throw new ArgumentOutOfRangeException(argName, message ?? "Value cannot be zero.")
            : argValue;

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is non-negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was not negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Negative]
    public static decimal IfArgNotNegative(
        this INumericRangeFluentThrower _, decimal argValue, string argName, string? message = null)
        => argValue < 0
            ? argValue
            : throw new ArgumentOutOfRangeException(argName, argValue, message ?? "Value must be negative.");

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonPositive]
    public static decimal IfArgPositive(
        this INumericRangeFluentThrower _, decimal argValue, string argName, string? message = null)
        => argValue > 0
            ? throw new ArgumentOutOfRangeException(argName, argValue, message ?? "Value cannot be positive.")
            : argValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonNegative]
    public static decimal IfPropSetNegative(
        this INumericRangeFluentThrower _, decimal propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue < 0
            ? throw new PropertySetOutOfRangeException(
                message ?? "Value cannot be negative.", propName!, propSetValue)
            : propSetValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is non-positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was not positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Positive]
    public static decimal IfPropSetNotPositive(
        this INumericRangeFluentThrower _, decimal propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue > 0
            ? propSetValue
            : throw new PropertySetOutOfRangeException(
                message ?? "Value must be positive.", propName!, propSetValue);

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was zero.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonZero]
    public static decimal IfPropSetZero(
        this INumericRangeFluentThrower _, decimal propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue == 0
            ? throw new PropertySetOutOfRangeException(message ?? "Value cannot be zero.", propName!)
            : propSetValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is non-negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was not negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Negative]
    public static decimal IfPropSetNotNegative(
        this INumericRangeFluentThrower _, decimal propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue < 0
            ? propSetValue
            : throw new PropertySetOutOfRangeException(
                message ?? "Value must be negative.", propName!, propSetValue);

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonPositive]
    public static decimal IfPropSetPositive(
        this INumericRangeFluentThrower _, decimal propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue > 0
            ? throw new PropertySetOutOfRangeException(
                message ?? "Value cannot be positive.", propName!, propSetValue)
            : propSetValue;
    #endregion

    #region Signs.BigInteger
    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonNegative]
    public static BigInteger IfArgNegative(
        this INumericRangeFluentThrower _, in BigInteger argValue, string argName, string? message = null)
        => argValue < 0
            ? throw new ArgumentOutOfRangeException(
                argName, argValue, message ?? "Value cannot be negative.")
            : argValue;

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is non-positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was not positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Positive]
    public static BigInteger IfArgNotPositive(
        this INumericRangeFluentThrower _, in BigInteger argValue, string argName, string? message = null)
        => argValue > 0
            ? argValue
            : throw new ArgumentOutOfRangeException(
                argName, argValue, message ?? "Value must be positive.");

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was zero.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonZero]
    public static BigInteger IfArgZero(
        this INumericRangeFluentThrower _, in BigInteger argValue, string argName, string? message = null)
        => argValue == 0
            ? throw new ArgumentOutOfRangeException(argName, message ?? "Value cannot be zero.")
            : argValue;

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is non-negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was not negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Negative]
    public static BigInteger IfArgNotNegative(
        this INumericRangeFluentThrower _, in BigInteger argValue, string argName, string? message = null)
        => argValue < 0
            ? argValue
            : throw new ArgumentOutOfRangeException(argName, argValue, message ?? "Value must be negative.");

    /// <summary>
    /// Throws an <see cref="ArgumentOutOfRangeException"/> if the argument value passed in is positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The argument value was positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonPositive]
    public static BigInteger IfArgPositive(
        this INumericRangeFluentThrower _, in BigInteger argValue, string argName, string? message = null)
        => argValue > 0
            ? throw new ArgumentOutOfRangeException(argName, argValue, message ?? "Value cannot be positive.")
            : argValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonNegative]
    public static BigInteger IfPropSetNegative(
        this INumericRangeFluentThrower _, in BigInteger propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue < 0
            ? throw new PropertySetOutOfRangeException(
                message ?? "Value cannot be negative.", propName!, propSetValue)
            : propSetValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is non-positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was not positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Positive]
    public static BigInteger IfPropSetNotPositive(
        this INumericRangeFluentThrower _, in BigInteger propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue > 0
            ? propSetValue
            : throw new PropertySetOutOfRangeException(
                 message ?? "Value must be positive.", propName!, propSetValue);

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is zero.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was zero.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonZero]
    public static BigInteger IfPropSetZero(
        this INumericRangeFluentThrower _, in BigInteger propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue == 0
            ? throw new PropertySetOutOfRangeException(message ?? "Value cannot be zero.", propName!)
            : propSetValue;

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is non-negative.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was not negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: Negative]
    public static BigInteger IfPropSetNotNegative(
        this INumericRangeFluentThrower _, in BigInteger propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue < 0
            ? propSetValue
            : throw new PropertySetOutOfRangeException(
                message ?? "Value must be negative.", propName!, propSetValue);

    /// <summary>
    /// Throws a <see cref="PropertySetOutOfRangeException"/> if the property set value passed in is positive.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetOutOfRangeException">The property set value was positive.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonPositive]
    public static BigInteger IfPropSetPositive(
        this INumericRangeFluentThrower _, in BigInteger propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue > 0
            ? throw new PropertySetOutOfRangeException(
                message ?? "Value cannot be positive.", propName!, propSetValue)
            : propSetValue;
    #endregion
    #endregion

    #region Helpers
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool IsFinite(this float f) => !(float.IsInfinity(f) || float.IsNaN(f));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool IsFinite(this double d) => !(double.IsInfinity(d) || double.IsNaN(d));
    #endregion
}

