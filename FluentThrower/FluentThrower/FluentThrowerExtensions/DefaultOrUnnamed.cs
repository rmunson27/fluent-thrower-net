﻿using Rem.Core.Attributes;
using Rem.Core.ComponentModel;
using Rem.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace Rem.Core.Utilities.FluentThrowerExtensions;

/// <summary>
/// A series of extension methods offering a simple fluent API for throwing exceptions relating to invalid default
/// values or invalid enumeration values.
/// </summary>
public static class DefaultOrUnnamedFluentThrowerExtensions
{
    #region Structs
    /// <summary>
    /// Throws a <see cref="StructArgumentDefaultException"/> if the argument value passed in is the default
    /// value of type <typeparamref name="TStruct"/>.
    /// </summary>
    /// <typeparam name="TStruct"></typeparam>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional error message to construct an exception with, or <see langword="null"/> to use a
    /// default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="StructArgumentDefaultException">
    /// <paramref name="argValue"/> was the default value of type <typeparamref name="TStruct"/>.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NonDefaultableStruct]
    public static TStruct IfStructArgDefault<TStruct>(
        this IDefaultOrUnnamedFluentThrower _, in TStruct argValue, string argName, string? message = null)
        where TStruct : struct, IDefaultableStruct
        => argValue.IsDefault ? throw StructArgDefault(argName, message) : argValue;

    /// <summary>
    /// Throws a <see cref="StructArgumentDefaultException"/> if the <see cref="ImmutableArray{T}"/> argument value
    /// passed in is the default.
    /// </summary>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional error message to construct an exception with, or <see langword="null"/> to use a
    /// default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="StructArgumentDefaultException"><paramref name="argValue"/> was the default.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NotDefault]
    public static ImmutableArray<T> IfStructArgDefault<T>(
        this IDefaultOrUnnamedFluentThrower _, in ImmutableArray<T> argValue, string argName, string? message = null)
        => argValue.IsDefault
            ? throw new StructArgumentDefaultException(
                argName, message ?? "Immutable array argument was default.")
            : argValue;

    /// <summary>
    /// Throws a <see cref="StructPropertySetDefaultException"/> if the property set value passed in is the
    /// default value of type <typeparamref name="TStruct"/>.
    /// </summary>
    /// <typeparam name="TStruct"></typeparam>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional error message to construct an exception with, or <see langword="null"/> to use a
    /// default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="StructPropertySetDefaultException">
    /// <paramref name="propSetValue"/> was the default value of type <typeparamref name="TStruct"/>.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NotDefault]
    public static TStruct IfStructPropSetDefault<TStruct>(
        this IDefaultOrUnnamedFluentThrower _,
        in TStruct propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        where TStruct : struct, IDefaultableStruct
        => propSetValue.IsDefault ? throw StructPropSetDefault(propName!, message) : propSetValue;

    /// <summary>
    /// Throws a <see cref="StructPropertySetDefaultException"/> if the property set value passed in is the
    /// default value of type <typeparamref name="TStruct"/>.
    /// </summary>
    /// <typeparam name="TStruct"></typeparam>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional error message to construct an exception with, or <see langword="null"/> to use a
    /// default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="StructPropertySetDefaultException">
    /// <paramref name="propSetValue"/> was the default value of type <typeparamref name="TStruct"/>.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NotDefault]
    public static ImmutableArray<T> IfStructPropSetDefault<T>(
        this IDefaultOrUnnamedFluentThrower _,
        in ImmutableArray<T> propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        => propSetValue.IsDefault ? throw StructPropSetDefault(propName!, message) : propSetValue;
    #endregion

    #region Enums
    /// <summary>
    /// Throws an <see cref="InvalidEnumArgumentException"/> if the argument passed in is not a named, defined
    /// value of type <typeparamref name="TEnum"/>.
    /// </summary>
    /// <typeparam name="TEnum"></typeparam>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional error message to construct an exception with, or <see langword="null"/> to use a
    /// default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="InvalidEnumArgumentException">
    /// <paramref name="argValue"/> was not a named, defined value of type <typeparamref name="TEnum"/>.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NamedEnum]
    public static TEnum IfEnumArgUnnamed<TEnum>(
        this IDefaultOrUnnamedFluentThrower _, TEnum argValue, string argName, string? message = null)
        where TEnum : struct, Enum
        => Enums.IsDefined(argValue)
            ? argValue
            : throw new InvalidEnumArgumentException(
                message is null
                    ? $"Parameter '{argName}' must be a named, defined value of type {typeof(TEnum)}."
                    : $"{message} (Parameter '{argName}')");

    /// <summary>
    /// Throws an <see cref="InvalidEnumArgumentException"/> if the argument passed in is not either
    /// <see langword="null"/> or a named, defined value of type <typeparamref name="TEnum"/>.
    /// </summary>
    /// <typeparam name="TEnum"></typeparam>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional error message to construct an exception with, or <see langword="null"/> to use a
    /// default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="InvalidEnumArgumentException">
    /// <paramref name="argValue"/> was not either <see langword="null"/> or a named, defined value of
    /// type <typeparamref name="TEnum"/>.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NamedEnum]
    public static TEnum? IfEnumArgUnnamed<TEnum>(
        this IDefaultOrUnnamedFluentThrower _, TEnum? argValue, string argName, string? message = null)
        where TEnum : struct, Enum
    {
        if (argValue is TEnum actualEnumValue)
        {
            return Enums.IsDefined(actualEnumValue)
                    ? argValue
                    : throw new InvalidEnumArgumentException(
                        message is null
                            ? $"Parameter '{argName}' must be either null or a named, defined"
                                + $" value of type {typeof(TEnum)}."
                            : $"{message} (Parameter '{argName}')");
        }
        else return null;
    }

    /// <summary>
    /// Throws an <see cref="InvalidEnumPropertySetException"/> if the property set value passed in is not a
    /// named, defined value of type <typeparamref name="TEnum"/>.
    /// </summary>
    /// <typeparam name="TEnum"></typeparam>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="InvalidEnumPropertySetException">
    /// <paramref name="propSetValue"/> was not a named, defined value of type <typeparamref name="TEnum"/>.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NamedEnum]
    public static TEnum IfEnumPropSetUnnamed<TEnum>(
        this IDefaultOrUnnamedFluentThrower _,
        TEnum propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        where TEnum : struct, Enum
        => Enums.IsDefined(propSetValue)
            ? propSetValue
            : throw new InvalidEnumPropertySetException(
                message is null
                    ? $"Property '{propName}' cannot be set to an unnamed value of type {typeof(TEnum)}."
                    : $"{message} (Property '{propName}')");

    /// <summary>
    /// Throws an <see cref="InvalidEnumPropertySetException"/> if the property set value passed in is not either
    /// <see langword="null"/> or a named, defined value of type <typeparamref name="TEnum"/>.
    /// </summary>
    /// <typeparam name="TEnum"></typeparam>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="InvalidEnumPropertySetException">
    /// <paramref name="propSetValue"/> was not either <see langword="null"/> or a named, defined value of
    /// type <typeparamref name="TEnum"/>.
    /// </exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NamedEnum]
    public static TEnum? IfEnumPropSetUnnamed<TEnum>(
        this IDefaultOrUnnamedFluentThrower _,
        TEnum? propSetValue, [CallerMemberName] string? propName = null, string? message = null)
        where TEnum : struct, Enum
    {
        if (propSetValue is TEnum actualEnumValue)
        {
            return Enums.IsDefined(actualEnumValue)
                    ? propSetValue
                    : throw new InvalidEnumPropertySetException(
                        message is null
                            ? $"Property '{propName}' must be set to either null or a named, defined"
                                + $" value of type {typeof(TEnum)}."
                            : $"{message} (Property '{propName}')");
        }
        else return null;
    }
    #endregion

    #region Nullable
    /// <summary>
    /// Throws an <see cref="ArgumentNullException"/> if the argument value passed in is <see langword="null"/>.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="argValue">The value of the argument.</param>
    /// <param name="argName">The name of the argument.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="ArgumentNullException">The argument value was <see langword="null"/>.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NotNull]
    public static T IfArgNull<T>(
        this IDefaultOrUnnamedFluentThrower _, T argValue, string argName, string? message = null)
    {
        if (argValue is null)
        {
            ArgumentNullException ex = message is null ? new(argName) : new(argName, message);
            throw ex;
        }
        return argValue;
    }

    /// <summary>
    /// Throws a <see cref="PropertySetNullException"/> if the property set value passed in
    /// is <see langword="null"/>.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="propSetValue">The value the property is being set to.</param>
    /// <param name="propName">The name of the property.</param>
    /// <param name="message">
    /// An optional message to construct the exception with, or <see langword="null"/> to use a default message.
    /// </param>
    /// <returns>The value passed in.</returns>
    /// <exception cref="PropertySetNullException">The property set value was <see langword="null"/>.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NotNull]
    public static T IfPropSetNull<T>(
        this IDefaultOrUnnamedFluentThrower _,
        T propSetValue, [CallerMemberName] string? propName = null, string? message = null)
    {
        if (propSetValue is null)
        {
            PropertySetNullException ex = message is null ? new(propName!) : new(propName!, message);
            throw ex;
        }
        return propSetValue;
    }
    #endregion

    #region Helpers
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static StructArgumentDefaultException StructArgDefault(string paramName, string? message)
        => message is null ? new(paramName) : new(paramName, message);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static StructPropertySetDefaultException StructPropSetDefault(string paramName, string? message)
        => message is null ? new(paramName) : new(paramName, message);

    #endregion
}

