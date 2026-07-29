# BigDecimal Design Notes

This document captures the background and rationale behind the `BigDecimal` implementation in this
package. It is developer-facing documentation only — it is intentionally **not** copied to the build
output and **not** included in the NuGet package (see the `design.md` `None` item in
`AWSSDK.Extensions.Numerics.csproj`). For consumer-facing documentation, see `README.md`.

## Motivation

The AWS SDK for .NET had no way to carry decimal numbers at arbitrary precision. Values flowed
through `double` or `decimal`, both of which lose precision:

- `double` is binary floating point and cannot represent common decimal fractions exactly (`0.1` is
  not exactly one tenth).
- `decimal` is exact for decimal fractions but is capped at 28–29 significant digits.

Some services already work around this: DynamoDB sends its `N` (number) attribute as a *string*
specifically to avoid loss across languages, and CBOR has bignum / decimal-fraction tags that the
SDK does not yet exploit. `BigDecimal` provides a single, lossless, general-purpose decimal type that
can represent any of these values without truncation, for use as a request/response value across any
service and protocol. The wire representation (CBOR, JSON, etc.) is out of scope for this type.

## Representation

A value is stored as:

```
value = unscaledValue × 10^(-scale)
```

- `_unscaledValue` — a `System.Numerics.BigInteger` holding the significant digits, including sign.
- `_scale` — a 32-bit `int`. A positive scale is the number of digits to the right of the decimal
  point; a negative scale multiplies the unscaled value by a positive power of ten.

This mirrors Java's `BigDecimal` and .NET's own `decimal`. The type is a `readonly struct` so it is
immutable and allocation-light.

### Why one BigInteger + int, not two BigIntegers

An earlier idea was to use two `BigInteger`s — one for the integer part and one for the fractional
part, or one for the mantissa and one for the exponent. Both were rejected:

- **Integer part / fractional part** is ambiguous without an additional digit-count field (`0.5` and
  `0.05` would both store a fractional part of `5`), makes sign handling awkward (where does the sign
  of `-0.5` live when the integer part is `0`?), and requires manual carry/borrow between the two
  parts on every add and multiply.
- **A `BigInteger` exponent** buys a range that is physically unusable — `10^(2^31)` already cannot
  fit in memory — while making every operation slower. A 32-bit `int` scale (as Java uses) is more
  than sufficient.

The mantissa-plus-scale form lets `BigInteger` handle all carrying for free, keeps the sign in one
place, and makes multiply trivial (`multiply mantissas, add scales`).

## Key semantic decisions

- **Storage fidelity.** Trailing zeros are preserved: `2.0` (scale 1) and `2.00` (scale 2) keep their
  distinct scales so `Scale` and `ToString` round-trip wire values faithfully. Normalization only
  happens inside `GetHashCode` and the explicit `StripTrailingZeros()`.
- **Numeric equality.** `Equals`/`==` are numeric, so `2.0` equals `2.00`, and `Equals` is consistent
  with `CompareTo`. This deliberately differs from Java's scale-sensitive `BigDecimal.equals`; the
  divergence is documented on the public members because it is a known surprise for Java developers.
- **`GetHashCode` consistency.** Because equal values can have different `(mantissa, scale)` pairs,
  the hash is computed over a canonical form with trailing zeros stripped, guaranteeing
  `a.Equals(b) ⇒ a.GetHashCode() == b.GetHashCode()`.
- **Division default.** Following Java's `divide(divisor)`, the parameterless `Divide` and `operator /`
  return the exact quotient if it terminates and otherwise throw `ArithmeticException`. Inexact
  division is explicit, through `Divide(divisor, MathContext)` or
  `Divide(divisor, int scale, RoundingMode)`.
- **Culture.** Parsing and formatting are culture-aware via `IFormatProvider` / `NumberFormatInfo` so
  third parties can reuse the package. The SDK's own serialization passes
  `CultureInfo.InvariantCulture` explicitly.

## Algorithms

- **Add / Subtract** — align both operands to `max(scaleA, scaleB)` by multiplying the smaller-scale
  mantissa by a power of ten, then add/subtract mantissas. Always exact.
- **Multiply** — `unscaled = uA × uB`, `scale = sA + sB`. Always exact.
- **Materialization backstop (DoS resistance)** — a value can be parsed or constructed cheaply with an
  extreme scale (`"1E2000000000"` is a handful of bytes yet stores an unscaled value of `1` with a
  two-billion scale). The cost is only paid when an operation realizes `10^scale` as actual digits:
  scale alignment (`Add`/`Subtract`/`Remainder`), the integer and `decimal` conversions,
  `SetScale`, the `MovePoint*` family, and plain-string formatting. Left unbounded, those paths allocate
  gigabytes and terminate the process with `OutOfMemoryException` from tiny, attacker-controlled input —
  the same class of issue the Java/JSON ecosystem hardened at the deserialization boundary. Two choke
  points cover every such path: `PowerOfTen` (the universal `10^n` funnel) and `FormatPlain`'s
  zero-padding. Both call the shared `GuardMaterializedDigits` helper, which throws a clear, catchable
  `OverflowException` once a single operation would materialize more than `MaxMaterializedDigits`
  (100,000,000) digits — far beyond any real AWS wire value. This is a deliberate divergence from Java,
  whose `BigDecimal` leaves these operations unbounded. The caller-supplied `Pow(int)` exponent keeps
  Java's own `0..999999999` bound rather than this limit, since it is an explicit argument, not
  attacker-influenced scale; however `Pow(int)` additionally guards its *projected result size*
  (`DigitCount(unscaledValue) × n`) through the same `GuardMaterializedDigits` helper, because the base
  can come from untrusted input and a modest base with a large exponent would otherwise OOM. A base whose
  magnitude is `0` or `1` is exempt, since it cannot grow.
- **Scale-difference overflow** — every operation that rescales an operand computes the scale
  difference in `long` and validates it against the `int` range via the shared `CheckScaleRange`
  helper, throwing `OverflowException` on overflow. This covers `Multiply` (scale sum), `AlignScales`
  (Add/Subtract/Remainder), `SetScale`, `Pow`, and the `MovePoint*` / `ScaleByPowerOfTen`
  family. Without this a difference of two opposite-signed extreme scales would wrap and surface deeper
  as a confusing "negative exponent" error. (Java raises `ArithmeticException` here; this package uses
  `OverflowException` to stay consistent with its own pre-existing multiply-overflow behavior.)
- **Divide** — reject a zero divisor. The exact/`Unlimited` path reduces the divisor's prime factors
  to 2 and 5; if anything remains the expansion is non-terminating and it throws. The rounded path
  scales the dividend so the quotient carries the requested precision with a guard digit, divides via
  `BigInteger.DivRem`, then applies the rounding engine with a sticky bit for hidden lower-order
  digits. When the `MathContext` quotient turns out exact, the surplus trailing zeros are stripped
  down toward the preferred scale (`this.scale − divisor.scale`) rather than padded out to the full
  precision, so `1 / 8` at precision 5 is `0.125`, not `0.12500` (matching Java's `divide(divisor, mc)`).
  When rounding carries into an extra digit (e.g. `9.95` to precision 2 → `100`), the carried trailing
  zero is dropped so the result never exceeds the requested precision, mirroring `Round`. Both the exact
  and `MathContext` paths preserve the preferred scale `this.scale − divisor.scale` even when it is
  negative (`1 / 0.001` is `1E+3`, unscaled `1` at scale `−3`; `100 / 1` at precision 1 is `1E+2`): the
  negative scale is **not** folded into the unscaled value, matching Java's `divide` and the type's own
  scale-fidelity contract (the `MovePoint*` family still folds, because Java defines those to keep the
  scale non-negative).
- **`Pow`** — `Pow(int)` is exact: `unscaled^n`, `scale = this.scale × n`, with the exponent restricted
  to `0..999999999` as in Java. `Pow(int, MathContext)` follows Java's iterative binary-exponentiation
  algorithm with a guard-digit working context and the ANSI X3.274 rule (exponent digit count must not
  exceed the context precision); a negative exponent computes the reciprocal power.
- **`DivideToIntegralValue` / `DivideAndRemainder`** — the integer quotient (truncated toward zero) at
  the preferred scale `this.scale − divisor.scale`; `DivideAndRemainder` additionally returns
  `this − divisor × integerPart` (sign of the dividend) through an `out` parameter, the .NET shape of
  Java's two-element-array return.
- **`MovePointLeft` / `MovePointRight`** adjust the scale and fold any resulting negative scale back
  into the unscaled value, so the result scale is never negative (matching Java). `ScaleByPowerOfTen`
  only shifts the scale and may therefore leave it negative.
- **`Divide(divisor, RoundingMode)`** is the convenience overload rounding to the dividend's own scale;
  instance **`Min` / `Max`** select by numeric comparison and preserve the chosen operand's scale.
- **Add / Subtract / Multiply / Negate / Abs with `MathContext`** — thin overloads that perform the
  exact operation and then `Round` to the context, mirroring Java's `add(x, mc)` family.
- **Rounding engine** — given a truncated-toward-zero quotient magnitude, the remainder, and the
  divisor, it decides whether to increment the magnitude. `Half*` modes compare `2 × |remainder|` to
  `|divisor|`, with exact ties resolved per mode (`HalfEven` rounds to even). `Ceiling`/`Floor` are
  sign-directed; `Up`/`Down` are away/toward zero; `Unnecessary` throws when a non-zero remainder
  would require rounding. `Round`, `SetScale`, and the rounded `Divide` overloads all reuse it.
- **Remainder** — `this − divisor × truncate(this / divisor)`, taking the sign of the dividend, which
  matches Java's `BigDecimal.remainder`.
- **CompareTo** — numeric comparison following Java's `compareMagnitude`. After settling on sign (and
  treating any two zeros as equal), it compares the operands' *adjusted exponents* (`precision − scale`):
  a value's magnitude lies in `[10^(ae−1), 10^ae)`, so unequal adjusted exponents place the magnitudes
  in disjoint ranges and settle the result with no alignment. Only when the adjusted exponents are equal
  does it align to the larger scale — and there `scaleDiff == precisionDiff`, so the alignment multiply is
  bounded by the real digit-count difference rather than the raw (possibly extreme) scale. This is why
  `CompareTo` (unlike `Add`/`Subtract`/`Remainder`) never trips the materialization backstop or the
  scale-difference overflow check: it can correctly compare a cheaply-stored `1E−2000000000` against
  `1E2000000000` without realizing any digits.
- **ToString** — Java-style layout: scale 0 prints as an integer; a positive scale with adjusted
  exponent ≥ −6 prints in plain decimal; otherwise scientific notation (`1.5E-10`).
  `ToPlainString` never uses an exponent.
- **`DigitCount` (precision)** — magnitudes that fit in a `ulong` take a fast path that estimates the
  digit count from the bit length and corrects it against a small `ulong` power-of-ten table, avoiding
  the `BigInteger.ToByteArray` allocation and `BigInteger` comparison the general path needs. Larger
  magnitudes fall through to the original `BigInteger` estimate-and-correct path. Both paths produce the
  same result; the boundary at `ulong.MaxValue` is covered explicitly by tests. This matters because
  `DigitCount` is recomputed on every `Precision` access and sits on the hot path of `Round` and the
  rounded division. (Java instead caches `precision` in a mutable field, which a `readonly struct`
  cannot do without abandoning immutability.)

## Conversions to and from binary floating point

- **`FromDouble` / `(BigDecimal)double`** capture the *exact binary value* of the `double` (so `0.1`
  becomes `0.1000…0555`), matching Java's `new BigDecimal(double)`. These stay explicit because the
  result is rarely what a caller eyeballing the literal expects.
- **`FromDoubleRoundTrip` / `FromSingleRoundTrip`** are the .NET-idiomatic counterpart to Java's
  `BigDecimal.valueOf(double)`: they route through the shortest round-trippable string (`ToString("R")`),
  so `0.1` becomes `0.1`. This is the preferred conversion when the value originated as a decimal. We
  add a named factory rather than flipping the cast operator, because silently rounding inside a
  "lossless" type would undercut its premise — and `System.Decimal` already establishes that a *cast*
  from `double` rounds, so both behaviors have .NET precedent under distinct entry points.
- **`ToDouble` / `ToSingle`** saturate an out-of-range magnitude to `±Infinity` instead of throwing, so
  behavior is uniform across `netstandard2.0` (where the underlying parse throws `OverflowException`)
  and `net8.0`, and matches how the binary types represent an unrepresentable magnitude.
- **`*Exact` conversions** (`ToBigIntegerExact`, `ToInt32Exact`, `ToInt64Exact`) throw
  `ArithmeticException` on a non-zero fractional part instead of truncating, for callers validating that
  a wire value really is integral.

## netstandard2.0 constraints

The library targets `netstandard2.0` (consumed broadly across the SDK) and `net8.0`. Several .NET
features that would have simplified the code are unavailable on `netstandard2.0` and shaped the
implementation:

- No static abstract interface members, so the classic operators plus `IComparable` / `IEquatable` /
  `IFormattable` are the only interface surface on that target.
- `BigInteger.Parse(ReadOnlySpan<char>)` does not exist, so parsing works from `string`.
- `BigInteger.DivRem(dividend, divisor, out remainder)` and `BigInteger.Pow(value, int)` are present
  and are used for division and power-of-ten scaling (with a small cached table of common powers).

## Generic Math (net8.0 and later)

.NET 7+ Generic Math is built on static abstract interface members (C# 11 / .NET 7+), which do not
exist on `netstandard2.0`. Rather than drop the `netstandard2.0` target, the project multi-targets
and implements the Generic Math interfaces only for the modern target, in
`BigDecimal.GenericMath.cs`, guarded by `#if NET8_0_OR_GREATER`. The `_OR_GREATER` form is used
intentionally so that adding future targets (net9.0, net10.0, …) includes the code automatically.

On `net8.0` and later, `BigDecimal` implements `INumber<BigDecimal>` (the full hierarchy) and
`ISignedNumber<BigDecimal>`, so it can be used with generic constraints like
`where T : INumber<T>`. Notable points:

- `IMinMaxValue<T>` is **not** implemented — `BigDecimal` is unbounded and has no `MinValue`/`MaxValue`.
- `BigDecimal` is always finite, so the predicates report `IsFinite`/`IsCanonical`/`IsRealNumber` as
  true and `IsNaN`/`IsInfinity`/`IsSubnormal`/`IsComplexNumber`/`IsImaginaryNumber` as false.
- The `%` / `Remainder` members exist on **both** targets (required by `IModulusOperators`) so the
  public API does not diverge between the `netstandard2.0` and `net8.0` builds.
- `Sign` and `IsZero` are explicit interface implementations because the type already exposes
  instance members of the same name.
- Converting *into* `BigDecimal` never overflows (it is unbounded), so the checked/saturating/
  truncating "from" converters are identical; converting *out* to a bounded type delegates to that
  type's own `Create*` so its range rules are honored.

## File layout

The struct is split across partial-class files by concern:

- `BigDecimal.cs` — fields, constructors, core properties, well-known values, shared helpers.
- `BigDecimal.Arithmetic.cs` — add/subtract/multiply/divide/remainder, negate/abs, operators.
- `BigDecimal.Rounding.cs` — the rounding engine, `Round`, `SetScale`, `StripTrailingZeros`.
- `BigDecimal.Equality.cs` — `CompareTo`, `Equals`, `GetHashCode`, comparison operators.
- `BigDecimal.Conversions.cs` — conversion operators and named `To*`/`From*` methods.
- `BigDecimal.Parsing.cs` — `Parse`/`TryParse` and the culture-aware scanner.
- `BigDecimal.Formatting.cs` — `ToString` variants and `ToPlainString`.
- `BigDecimal.GenericMath.cs` — the `net8.0`+ Generic Math implementation.
- `MathContext.cs`, `RoundingMode.cs` — the supporting precision/rounding types.
