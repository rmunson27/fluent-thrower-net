using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Rem.Core.Utilities.FluentThrower.Extensions;

/// <summary>
/// A series of extension methods offering a simple fluent API for throwing general exceptions.
/// </summary>
public static class GeneralThrowerExtensions
{
    /// <summary>
    /// Throws a <see cref="NotImplementedException"/>.
    /// </summary>
    /// <remarks>
    /// This method allows a variable definition to throw a <see cref="NotImplementedException"/> in contexts in
    /// which a <see langword="throw"/> expression is not permitted.
    /// </remarks>
    /// <typeparam name="T"></typeparam>
    /// <param name="message">
    /// An error message to throw the exception with, or <see langword="null"/> to not include a message in the
    /// thrown exception.
    /// </param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    [DoesNotReturn]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T NotImplemented<T>(string? message = null)
        => message is null ? throw new NotImplementedException() : throw new NotImplementedException(message);
}

