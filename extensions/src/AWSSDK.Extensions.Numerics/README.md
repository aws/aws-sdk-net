# AWSSDK.Extensions.Numerics

This package provides `BigDecimal`, an immutable, arbitrary-precision signed decimal number for .NET. Unlike `double` it has no binary rounding error (it can represent `0.1` exactly), and unlike `decimal` it has no fixed digit limit. This makes it suitable for carrying high-precision numeric values — such as those exchanged with AWS services — without losing any digits.

A value is represented as an arbitrary-precision unscaled value (a `System.Numerics.BigInteger`) and a 32-bit integer scale, where the numeric value equals `unscaledValue × 10^(-scale)`.

The type lives in the `Amazon.Extensions.Numerics` namespace.

# Features

- Exact, arbitrary-precision arithmetic: add, subtract, multiply, divide, remainder, negate, and absolute value.
- Operator overloads (`+ - * / %`, unary `+`/`-`) plus implicit conversions from the built-in numeric types, so mixed expressions like `value + 10` work naturally.
- Numeric equality and comparison: `2.0` equals `2.00` (note this differs from Java's scale-sensitive `BigDecimal.equals`).
- Configurable rounding via `MathContext` and `RoundingMode` (modeled on Java's `BigDecimal`).
- Culture-aware parsing and formatting, with Java-style scientific notation for very large or very small magnitudes.
- On .NET 8 and later, `BigDecimal` implements the .NET Generic Math interfaces (`INumber<BigDecimal>`, `ISignedNumber<BigDecimal>`), so it can be used with generic constraints such as `where T : INumber<T>`.

# Examples

## Basic arithmetic

```csharp
using Amazon.Extensions.Numerics;

var price = BigDecimal.Parse("19.99");
var quantity = new BigDecimal(3);

var total = price * quantity;   // 59.97
total = total + 10;             // 69.97 (int converts implicitly)
```

## Division and rounding

By default, division requires an exact, terminating result and throws `ArithmeticException` otherwise (matching Java's `BigDecimal.divide`). For inexact division, supply a `MathContext` or an explicit scale and `RoundingMode`:

```csharp
var exact = BigDecimal.Parse("10").Divide(BigDecimal.Parse("4")); // 2.5

// 1/3 does not terminate, so the parameterless Divide would throw.
// Provide precision and a rounding mode instead:
var approx = BigDecimal.Parse("1").Divide(
    BigDecimal.Parse("3"),
    new MathContext(5, RoundingMode.HalfUp));   // 0.33333

// Or round to a fixed scale:
var rounded = BigDecimal.Parse("10").Divide(
    BigDecimal.Parse("3"), scale: 4, RoundingMode.HalfEven); // 3.3333
```

## Parsing and formatting

```csharp
using System.Globalization;

var value = BigDecimal.Parse("1.5E-10", CultureInfo.InvariantCulture);
string text = value.ToString(CultureInfo.InvariantCulture); // "1.5E-10"
string plain = value.ToPlainString(CultureInfo.InvariantCulture); // "0.00000000015"

if (BigDecimal.TryParse("123.45", CultureInfo.InvariantCulture, out var parsed))
{
    // use parsed
}
```

## Generic Math (.NET 8 and later)

```csharp
using System.Numerics;
using Amazon.Extensions.Numerics;

static T Sum<T>(T a, T b) where T : INumber<T> => a + b;

var result = Sum(BigDecimal.Parse("2.5"), BigDecimal.Parse("2.5")); // 5
```
