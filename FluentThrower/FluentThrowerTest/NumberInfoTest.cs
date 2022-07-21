using Rem.Core.Utilities.FluentThrower.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rem.CoreTest.Utilities.FluentThrower;

/// <summary>
/// Tests of the <see cref="INumberInfo{T}"/> interface, descendant interfaces, and classes defined using the interfaces.
/// </summary>
[TestClass]
public class NumberInfoTest
{
    public const string ImplementationsCategory = "INumberInfoImplementations";

    /// <summary>
    /// Tests the <see cref="INumberInfo{T}"/>-only implementations.
    /// </summary>
    [TestMethod, TestCategory(ImplementationsCategory)]
    public void TestNumberInfoImplementations()
    {
        Assert.IsTrue(NumberInfo.Byte.IsZero(0));
        Assert.IsFalse(NumberInfo.Byte.IsZero(1));

        Assert.IsTrue(NumberInfo.UShort.IsZero(0));
        Assert.IsFalse(NumberInfo.UShort.IsZero(1));

        Assert.IsTrue(NumberInfo.UInt.IsZero(0));
        Assert.IsFalse(NumberInfo.UInt.IsZero(1));

        Assert.IsTrue(NumberInfo.ULong.IsZero(0));
        Assert.IsFalse(NumberInfo.ULong.IsZero(1));
    }

    /// <summary>
    /// Tests the <see cref="ISignInfo{T}"/>-only implementations.
    /// </summary>
    [TestMethod, TestCategory(ImplementationsCategory)]
    public void TestSignInfoImplementations()
    {
        Assert.IsTrue(NumberInfo.SByte.IsZero(0));
        Assert.IsFalse(NumberInfo.SByte.IsZero(1));
        Assert.AreEqual(1, NumberInfo.SByte.Sign(2));
        Assert.AreEqual(0, NumberInfo.SByte.Sign(0));
        Assert.AreEqual(-1, NumberInfo.SByte.Sign(-3));

        Assert.IsTrue(NumberInfo.Short.IsZero(0));
        Assert.IsFalse(NumberInfo.Short.IsZero(1));
        Assert.AreEqual(1, NumberInfo.Short.Sign(2));
        Assert.AreEqual(0, NumberInfo.Short.Sign(0));
        Assert.AreEqual(-1, NumberInfo.Short.Sign(-3));

        Assert.IsTrue(NumberInfo.Int.IsZero(0));
        Assert.IsFalse(NumberInfo.Int.IsZero(1));
        Assert.AreEqual(1, NumberInfo.Int.Sign(2));
        Assert.AreEqual(0, NumberInfo.Int.Sign(0));
        Assert.AreEqual(-1, NumberInfo.Int.Sign(-3));

        Assert.IsTrue(NumberInfo.Long.IsZero(0));
        Assert.IsFalse(NumberInfo.Long.IsZero(1));
        Assert.AreEqual(1, NumberInfo.Long.Sign(2));
        Assert.AreEqual(0, NumberInfo.Long.Sign(0));
        Assert.AreEqual(-1, NumberInfo.Long.Sign(-3));

        Assert.IsTrue(NumberInfo.BigInteger.IsZero(0));
        Assert.IsFalse(NumberInfo.BigInteger.IsZero(1));
        Assert.AreEqual(1, NumberInfo.BigInteger.Sign(2));
        Assert.AreEqual(0, NumberInfo.BigInteger.Sign(0));
        Assert.AreEqual(-1, NumberInfo.BigInteger.Sign(-3));

        Assert.IsTrue(NumberInfo.Decimal.IsZero(0));
        Assert.IsFalse(NumberInfo.Decimal.IsZero(1));
        Assert.AreEqual(1, NumberInfo.Decimal.Sign(2));
        Assert.AreEqual(0, NumberInfo.Decimal.Sign(0));
        Assert.AreEqual(-1, NumberInfo.Decimal.Sign(-3));
    }

    /// <summary>
    /// Tests the <see cref="IFloatInfo{T}"/> implementations.
    /// </summary>
    [TestMethod, TestCategory(ImplementationsCategory)]
    public void TestFloatInfoImplementations()
    {
        Assert.IsTrue(NumberInfo.Float.IsZero(0));
        Assert.IsFalse(NumberInfo.Float.IsZero(1));
        Assert.AreEqual(1, NumberInfo.Float.Sign(2));
        Assert.AreEqual(0, NumberInfo.Float.Sign(0));
        Assert.AreEqual(-1, NumberInfo.Float.Sign(-3));
        Assert.IsTrue(NumberInfo.Float.IsFinite(9));
        Assert.IsFalse(NumberInfo.Float.IsFinite(float.NegativeInfinity));
        Assert.IsTrue(NumberInfo.Float.IsNaN(float.NaN));
        Assert.IsFalse(NumberInfo.Float.IsNaN(4));

        Assert.IsTrue(NumberInfo.Double.IsZero(0));
        Assert.IsFalse(NumberInfo.Double.IsZero(1));
        Assert.AreEqual(1, NumberInfo.Double.Sign(2));
        Assert.AreEqual(0, NumberInfo.Double.Sign(0));
        Assert.AreEqual(-1, NumberInfo.Double.Sign(-3));
        Assert.IsTrue(NumberInfo.Double.IsFinite(9));
        Assert.IsFalse(NumberInfo.Double.IsFinite(double.NegativeInfinity));
        Assert.IsTrue(NumberInfo.Double.IsNaN(double.NaN));
        Assert.IsFalse(NumberInfo.Double.IsNaN(4));

        Assert.IsTrue(NumberInfo.Half.IsZero((Half)0));
        Assert.IsFalse(NumberInfo.Half.IsZero((Half)1));
        Assert.AreEqual(1, NumberInfo.Half.Sign((Half)2));
        Assert.AreEqual(0, NumberInfo.Half.Sign((Half)0));
        Assert.AreEqual(-1, NumberInfo.Half.Sign((Half)(-3)));
        Assert.IsTrue(NumberInfo.Half.IsFinite((Half)9));
        Assert.IsFalse(NumberInfo.Half.IsFinite(Half.NegativeInfinity));
        Assert.IsTrue(NumberInfo.Half.IsNaN(Half.NaN));
        Assert.IsFalse(NumberInfo.Half.IsNaN((Half)4));
    }
}
