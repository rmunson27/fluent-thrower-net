using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rem.Core.Utilities.FluentThrower;

/// <summary>
/// Exposes an implementing type to fluent thrower extension methods relating to invalid default values or enum
/// values.
/// </summary>
public interface IDefaultOrUnnamedThrower { }

/// <summary>
/// Exposes an implementing type to fluent thrower extension methods relating to comparison results.
/// </summary>
public interface IComparisonThrower { }

/// <summary>
/// Exposes an implementing type to fluent thrower extension methods relating to numeric signs and ranges.
/// </summary>
public interface INumericRangeThrower { }

/// <summary>
/// Exposes an implementing type to general-purpose fluent thrower extension methods.
/// </summary>
public interface IGeneralThrower { }

