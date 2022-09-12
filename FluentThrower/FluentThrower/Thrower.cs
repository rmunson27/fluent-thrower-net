using System;
using System.Collections.Generic;
using System.Text;

namespace Rem.Core.Utilities.FluentThrower;

/// <summary>
/// A class offering a simple fluent interface for throwing exceptions using the extension methods defined in
/// this namespace.
/// </summary>
/// 
/// <remarks>
/// <para>
/// This class is mainly intended to offer a less verbose way of throwing exceptions in cases that commonly arise
/// in code.
/// It has no functionality of its own; rather, the <see cref="Extensions"/> namespace contains basic extension
/// methods providing the functionality, so that users can extend the functionality by providing their own
/// extension methods.
/// </para>
/// 
/// <para>
/// The extension methods are provided on the <see cref="Thrower"/> class via interfaces enabling them, allowing
/// users to create a different fluent thrower class or extend the one provided as desired, choosing the exact
/// functionality they need, and allowing them to leave out anything else.
/// </para>
/// 
/// <para>
/// Instances of the type can be used to throw exceptions as follows (assuming the contents of the
/// <see cref="Extensions"/> namespace have been properly imported):
/// <code>
/// <see langword="var"/> throw = <see langword="new"/> <see cref="Thrower"/>();
/// throw.IfArgNull(arg, <see langword="nameof"/>(arg)); // Will throw an ArgumentNullException if arg is null
/// </code>
/// 
/// The values passed in to the argument or property set exception methods will also be returned by the methods:
/// <code>
/// <see langword="var"/> x = throw.IfArgNull(arg, <see langword="nameof"/>(arg));
/// </code>
/// </para>
/// 
/// <para>
/// The property set methods provided have their <c>propName</c> arguments decorated with instances of
/// <see cref="System.Runtime.CompilerServices.CallerMemberNameAttribute"/>, and so will infer the name of the
/// property they are called in.  Therefore, the argument can usually be left out:
/// 
/// <code>
/// throw.IfPropSetNull(value);
/// </code>
/// </para>
/// </remarks>
public class Thrower : IGeneralThrower, IDefaultOrUnnamedThrower, INumericRangeThrower, IComparisonThrower { }

/// <summary>
/// Wraps a <see cref="Thrower"/> instance that can be imported to allow throwing exceptions using the interface
/// this library provides.
/// </summary>
/// <remarks>
/// The instance can be imported as follows:
/// <code>
/// <see langword="using"/> <see cref="Extensions"/>; // Imports the extension methods needed
/// 
/// // Exposes the 'Throw' property stored on this class
/// <para />
/// <see langword="using"/> <see langword="static"/> <see cref="ThrowerInstanceWrapper"/>;
/// </code>
/// 
/// Of course, the classes in the extension namespace can be statically imported individually if some extensions are
/// not wanted.
/// </remarks>
public static class ThrowerInstanceWrapper
{
    /// <summary>
    /// An object that can be used to fluently throw exceptions.
    /// </summary>
    public static readonly Thrower Throw = new();
}

