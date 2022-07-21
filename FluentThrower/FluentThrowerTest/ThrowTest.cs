using Rem.Core.ComponentModel;
using Rem.Core.Utilities.FluentThrower;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rem.CoreTest.Utilities.FluentThrower;

/// <summary>
/// A basic test that the library works.
/// </summary>
[TestClass]
public class ThrowTest
{
    #region NumericRange
    /// <summary>
    /// Tests the extension methods available to the <see cref="INumericRangeThrower"/> interface implemented
    /// by the <see cref="Thrower"/> class.
    /// </summary>
    [TestMethod]
    public void TestNumericRange()
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => Throw.IfArgNegative(-3, "intArg"));
        Throw.IfArgNegative(0, "intArg"); // Should not throw
        Assert.ThrowsException<PropertySetOutOfRangeException>(() => Throw.IfPropSetNegative(-3, "IntProp"));
        Throw.IfPropSetNegative(2, "IntProp"); // Should not throw
    }
    #endregion

    #region DefaultOrUnnamed
    /// <summary>
    /// Tests the <see langword="enum"/> extension methods available to the
    /// <see cref="IDefaultOrUnnamedThrower"/> interface implemented by the <see cref="Thrower"/> class.
    /// </summary>
    [TestMethod, TestCategory(nameof(IDefaultOrUnnamedThrower))]
    public void TestDefaultOrUnnamed_Enums()
    {
        Assert.ThrowsException<InvalidEnumArgumentException>(() => Throw.IfEnumArgUnnamed(UnnamedE, "enumVal"));
        Throw.IfEnumArgUnnamed(E.Value0, "enumVal"); // Should not throw
        Assert.ThrowsException<InvalidEnumPropertySetException>(() => Throw.IfEnumPropSetUnnamed(UnnamedE, "EnumVal"));
        Throw.IfEnumPropSetUnnamed(E.Value0, "EnumVal"); // Should not throw
    }

    /// <summary>
    /// Tests the <see langword="struct"/> extension methods available to the
    /// <see cref="IDefaultOrUnnamedThrower"/> interface implemented by the <see cref="Thrower"/> class.
    /// </summary>
    [TestMethod, TestCategory(nameof(IDefaultOrUnnamedThrower))]
    public void TestDefaultOrUnnamed_Structs()
    {
        // General IDefaultableStruct implementations
        Assert.ThrowsException<StructArgumentDefaultException>(() => Throw.IfStructArgDefault(default(S), "structVal"));
        Throw.IfStructArgDefault(new S(new()), "structVal"); // Should not throw
        Assert.ThrowsException<StructPropertySetDefaultException>(
            () => Throw.IfStructPropSetDefault(default(S), "StructVal"));
        Throw.IfStructPropSetDefault(new S(new()), "StructVal"); // Should not throw

        // ImmutableArray
        Assert.ThrowsException<StructArgumentDefaultException>(
            () => Throw.IfStructArgDefault(default(ImmutableArray<int>), "arr"));
        Throw.IfStructArgDefault(ImmutableArray<int>.Empty, "arr"); // Should not throw
        Assert.ThrowsException<StructPropertySetDefaultException>(
            () => Throw.IfStructPropSetDefault(default(ImmutableArray<int>), "Array"));
        Throw.IfStructPropSetDefault(ImmutableArray<int>.Empty, "Array");
    }

    /// <summary>
    /// Tests the nullability extension methods available to the <see cref="IDefaultOrUnnamedThrower"/> interface
    /// implemented by the <see cref="Thrower"/> class.
    /// </summary>
    [TestMethod, TestCategory(nameof(IDefaultOrUnnamedThrower))]
    public void TestDefaultOrUnnamed_Null()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Throw.IfArgNull(default(Version), "version"));
        Throw.IfArgNull(new object(), "obj"); // Should not throw
        Assert.ThrowsException<ArgumentNullException>(() => Throw.IfArgNull(default(int?), "nullableInt"));
        Throw.IfArgNull(new int?(4), "nullableInt"); // Should not throw

        Assert.ThrowsException<PropertySetNullException>(() => Throw.IfPropSetNull(default(Version), "Version"));
        Throw.IfPropSetNull(new object(), "Object"); // Should not throw
        Assert.ThrowsException<PropertySetNullException>(() => Throw.IfPropSetNull(default(int?), "nullableInt"));
        Throw.IfPropSetNull(new int?(4), "nullableInt"); // Should not throw
    }
    #endregion

    #region Comparison
    /// <summary>
    /// Tests the extension methods available to the <see cref="IComparisonThrower"/> interface implemented
    /// by the <see cref="Thrower"/> class.
    /// </summary>
    [TestMethod]
    public void TestComparison()
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => Throw.IfArgGreaterThan(1, 2, "arg"));
        Throw.IfArgGreaterThan(1, 1, "arg"); // Should not throw
        Assert.ThrowsException<PropertySetOutOfRangeException>(() => Throw.IfPropSetGreaterThan(1, 2, "Prop"));
        Throw.IfPropSetGreaterThan(1, 1, "Prop"); // Should not throw

        Assert.ThrowsException<ArgumentOutOfRangeException>(
            () => Throw.IfArgGreaterThan(new Version(1, 1), new Version(1, 2), "Version"));
        Throw.IfArgGreaterThan(new Version(1, 1), new Version(1, 1), "Version"); // Should not throw
    }
    #endregion

    #region Helpers
    private const E UnnamedE = (E)1;

    private enum E
    {
        Value0
    }

    private readonly struct S : IDefaultableStruct
    {
        public bool IsDefault => O is null;

        public object O { get; }

        public S(object O) { this.O = O; }
    }
    #endregion
}
