# DynamoDB DataModel

The DynamoDB DataModel (object persistence) API lives in
`sdk/src/Services/DynamoDBv2/Custom/DataModel/`. This file captures the non-obvious structure and the
traps that have repeatedly produced bugs — it is not a full inventory of the API.

## Files

- `Context.cs` / `ContextInternal.cs` — `DynamoDBContext`: save, load, and the document/object conversion.
  The synchronous and asynchronous entry points are split into `_bcl/`, `_async/` and `_netstandard/`.
- `InternalModel.cs` — the configuration model (`ItemStorageConfig`, `StorageConfig`, `PropertyStorage`)
  and `ItemStorageConfigCache`, which builds and caches it.
- `Utils.cs` — reflection helpers: member discovery, instantiation, constructor selection.
- `Attributes.cs` — the public `DynamoDB*Attribute` surface.
- `ContextBuilder.cs` / `IDynamoDBContextBuilder.cs` — `DynamoDBContextBuilder`, including
  `AddDefaultConverter`.
- `Configs.cs` plus the per-operation `*Config.cs` files — V4 replaced the generic
  `DynamoDBOperationConfig` with operation-specific config objects.
- `TransactWrite.cs` / `TransactGet.cs` / `BatchGet.cs` / `BatchWrite.cs` — batch and transaction paths.

## Configuration build order

`ItemStorageConfigCache.CreateStorageConfig` runs, in order:

1. `PopulateConfigFromType` — reads attributes, builds `PropertyStorage` per member.
2. `PopulateConfigFromMappings` — applies `AWSConfigsDynamoDB.Context.TypeMappings`.
3. `PopulateConfigFromTable` — applies table metadata (skipped when `DisableFetchingTableMetadata`).
4. `Denormalize` — validates each property (`PropertyStorage.Validate`) and builds the attribute-name
   mappings.

Ordering rules that follow from this:

- Validation that depends on member flags (version, counter, ignore) must run **after** step 2, because
  a `TypeMapping` can set them.
- Validation that depends on the **effective converter** must run **after** step 4. `Validate` is what
  assigns `PropertyStorage.Converter`, and it is the only place `DynamoDBContext.ConverterCache` is
  consulted, so a converter registered with `DynamoDBContextBuilder.AddDefaultConverter` is invisible
  before then. `ConverterType` alone only covers attribute and type-mapping converters.
- A throw during `CreateStorageConfig` leaves nothing cached; the config is only stored after it returns.

## Constructor selection

`Utils.TryGetBindingConstructor` decides whether a type is populated by binding stored values to a
parameterized constructor, or by the older instantiate-then-assign path. It is the most contested piece
of logic in this area. Rules, in order:

1. Abstract, interface, open generic and **byref-like** types never bind, so the existing
   `CanInstantiate` unsupported-type error stays authoritative instead of a raw reflection failure later.
2. Only **public instance** constructors are considered. The compiler-generated record copy constructor
   is non-public, so it needs no special-casing.
3. `[DynamoDBConstructor]` wins if present; two of them is an error.
4. For **reference types**, a public parameterless constructor (or one taking a `DynamoDBContext`)
   suppresses binding. This is what keeps existing models on the old path.
5. For **value types** a parameterless constructor does not suppress binding, because `CanInstantiate`
   rejects value types outright.
6. Exactly one remaining bindable constructor is selected. More than one is an error **unless** the type
   is a value type whose persisted members are all writable, in which case none is needed.

Two invariants worth holding on to:

- **A value type needs a binding constructor only when it has constructor-only members**, meaning
  get-only properties matching a constructor parameter. Otherwise zero-initialization plus member
  assignment populates it completely, so an ambiguity between constructors is irrelevant and must not be
  reported. `init` counts as writable, so positional record structs qualify.
- **Ignored members never make a constructor necessary.** Exclude `[DynamoDBIgnore]` members before
  deciding, or an ignored get-only property that happens to share a name with a parameter forces binding
  or reports a false ambiguity. Only the attribute is visible at that point; a `TypeMapping`-level ignore
  is applied later and is not covered.

### Storage compatibility across target frameworks

Constructor binding exists only on the .NET 8 and later build (`#if NET8_0_OR_GREATER`). Rule 4 is what
makes that safe: a reference type with a public parameterless constructor is the only shape older builds
can populate, and it never binds unless the application opts in with `[DynamoDBConstructor]`, which does
not exist below .NET 8. Everything else that binds is a shape older builds rejected outright. So
retargeting an application to .NET 8 cannot change how an existing item is read or written.
`DataModelStorageCompatibilityTests` pins this by asserting the exact stored attribute set on every
target framework.

Not all of this logic is gated, though — `CreateFlattenedMember` is shared, so changes there affect
.NET Framework and .NET Standard as well.

## The three member collections are not interchangeable

This distinction is the single largest source of bugs in this area.

| Collection | Contains ignored members? | Built by |
|---|---|---|
| `StorageConfig.Properties` | **yes** | `PopulateConfigFromType` |
| `StorageConfig.AllPropertyStorage` | no | `Denormalize` (skips `IsIgnored`) |
| `PropertyStorage.FlattenProperties` | **yes** | `PopulateConfigFromType`, raw |

Any scan over `Properties` or `FlattenProperties` must filter `IsIgnored` itself. Forgetting to has
produced: ignored counters reaching update expressions, ignored `[DynamoDBIgnore]` members being
populated on load, a `KeyNotFoundException` looking up an ignored version attribute, and false
validation failures.

## [DynamoDBFlatten] is asymmetric between save and load

- **Save** serializes the flattened member through *its own* `StorageConfig`
  (`ToDynamoDBEntry` → `SerializeToDocument` → `GetConfig`), then copies the resulting document's
  entries into the parent document.
- **Load** uses the parent's `FlattenProperties` and never builds the child's config
  (`CreateFlattenedMember`).

Consequences:

- Validation on the child type's own config runs on save only. A model can load successfully and then
  fail on save, or the reverse. Mirror any such validation in the parent's configuration so both
  directions agree.
- Nested flatten works because each level hoists its leaves to the top of its own serialized document,
  so leaves land at the item's top level however deep the chain. Load has to recurse to match.
- A flattened member is never stored under its own attribute name, only its leaves are.

## Defaults and schema evolution

A constructor parameter with no stored value falls back to the parameter's declared default, otherwise to
`default(T)`. Matching is by **name**, not position, so reordering or inserting positional parameters does
not break existing mappings. Three cases must agree:

- **Attribute absent** — use the declared default. This is what makes adding a member to an existing type
  safe.
- **Attribute stored as DynamoDB NULL, non-nullable value-type parameter** — also use the declared
  default. `ShouldSave` treats NULL as present, so without this an explicit NULL silently discards the
  declared default and yields `default(T)` while a missing attribute honours it.
- **Attribute stored as DynamoDB NULL, nullable or reference parameter** — pass the null. An explicit
  null wins over a default, matching a settable member on a mutable type.

For a flattened parameter, "absent" means **none of its persisted child attributes are present**, so that
check must recurse through nested flatten and skip ignored children. Materializing a child when only an
ignored attribute survives from an older item is wrong.

An ignored member that supplies a constructor parameter has no stored value by definition, so the
parameter always takes its default rather than the configuration being rejected.

## [DynamoDBIgnore] excludes a member on load as well as on save

`Denormalize` keeps ignored members out of `AllPropertyStorage`, so the top-level load path already skips
them. Anything iterating `FlattenProperties` has to skip them explicitly, or an attribute left in an older
item — from before the member was ignored, or written by another producer — gets populated back onto the
object. The same applies to the collectors that build update expressions: an ignored atomic counter or
`UpdateBehavior.IfNotExists` member reaching `GetCounterProperties` or
`GetUpdateIfNotExistsAttributeNames` changes server-side state for an attribute the model says is not
persisted.

## Post-save write-back cannot reach a value type

`SaveHelper<T>(T value)` calls `ApplyPostUpdate(ItemStorage, object value, …)`, which calls
`PopulateInstance` to assign server-produced values through reflection. A struct is **boxed** at that
`object` parameter, so the assignment updates a copy and the caller's value keeps the stale value.
`TransactWrite` has the same shape via `ObjectWithItemStorage.OriginalObject`.

This affects `[DynamoDBVersion]`, `[DynamoDBAtomicCounter]`, `[DynamoDBAutoGeneratedTimestamp]` and
`UpdateBehavior.IfNotExists`, which is why those members are rejected on value types and as
constructor arguments.

### The general rule: a server-managed member must be reachable for write-back

Boxing is one way reachability fails. The others:

- **A constructor-bound member** cannot be written after construction at all, so it can never receive
  the new value.
- **A member under a constructor-bound flattened parent** is unreachable for the same reason, because
  `PopulateInstance` skips the whole parent. Validation therefore has to recurse through flattened
  descendants, not just check the member itself.
- **A flattened value-type member owned by a reference type** has its children enumerated into the
  parent's configuration, so the parent's own value-type check never sees them. Validate the flattened
  member's subtree from the owning configuration too, otherwise the model loads and fails only on save.

Conversely, capturing a server-managed value on save must reach as far as the model allows:
`storage.CurrentVersion` is read out of the serialized document during `PopulateItemStorage`, and that
lookup has to **recurse the whole flatten chain**. Missing a version two levels down leaves
`CurrentVersion` null, which silently degrades the optimistic-locking condition to
`attribute_not_exists` so every update of an existing item fails its condition check.

## Validation must be symmetric between save and load

Most defects in this area have been asymmetry rather than an outright wrong answer: the model saves and
then fails on every load, or loads and fails on every save. Either is worse than a clean rejection,
because the item can end up written and unreadable.

When adding a check, confirm both directions produce the **identical** error, and prefer rejecting at
configuration time in `CreateStorageConfig`, which both paths run through. Several tests assert
`Assert.AreEqual(onSave.Message, onLoad.Message)` for exactly this reason.

The opposite failure is over-strictness. A check that rejects a model which would actually have worked
is more damaging than a missing check, so bias a new rule toward reporting only combinations that can
never succeed, and add a complement test proving the near-miss case still round-trips.

### Remediation text has to be true for the types that reach it

Two separate findings were about nothing but misleading advice in an error message, so it is worth
treating as its own risk. The unsupported-type error told every type without a parameterless constructor
to retarget to .NET 8, which does not help an abstract, interface or open-generic type, since those
deliberately never bind. The type-mismatch error told users to pick a type the member's type "converts to
implicitly", while the validator rejects C# implicit conversions the reflection binder does not perform.
Both sent users toward a model that would still be rejected.

When a message names a remediation, check it against the set of types that can actually reach that throw,
and assert the wording in a test so it cannot drift back.

## Reflection binder behavior (measured, not assumed)

`ConstructorInfo.Invoke` is used to populate immutable types. Its binder:

- Performs **CLR widening only**, which is narrower than C# implicit conversions. Nothing widens to
  `decimal` (it is not a CLR primitive), so `int` → `decimal` fails. `byte`/`ushort`/`char` interchange.
- Substitutes `default(T)` when `null` is passed for a non-nullable value-type parameter.
- Accepts a boxed `T` for a `T?` parameter; a non-null `Nullable<T>` boxes as `T`, so nullability on
  either side does not affect whether the call succeeds.
- Accepts an enum for its underlying primitive type and vice versa.

A stored attribute is deserialized as its **member's** type and then handed to `Invoke`, so a parameter
type the binder cannot accept from that member type is a model that saves and never loads. Two
consequences that are easy to get wrong:

- A parameter type **derived** from the member type is normally unreachable, because the deserializer
  reconstructs the member's declared type. It is only valid when a `[DynamoDBPolymorphicType]` mapping
  lets the loader produce a compatible type. Those mappings come from two places: the attribute on the
  **member** populates `PropertyStorage`, while the attribute on the member's **declared type** does not
  and has to be read separately.
- A member with a converter says nothing about the run-time type, since the converter decides it. Skip
  the check entirely when an effective converter is present.

Other measured facts:

- `ParameterInfo.HasDefaultValue` is `true` while `DefaultValue` is `null` for a struct parameter
  declared `= default` (`DateTime`, `Guid`, a `readonly record struct`). Invoke handles it.
- An `init` accessor reports `CanWrite == true`, including on a `readonly record struct`, and
  reflection `SetValue` works on a boxed struct. So a positional record struct is fully assignable
  without its constructor.
- The compiler-generated record copy constructor is non-public (protected on a `record class`, private
  on a `sealed record`), so `GetConstructors(BindingFlags.Instance | BindingFlags.Public)` already
  excludes it. No special-casing needed.

## Native AOT

- **Trim-clean is not AOT-clean.** `AWSSDK.Core` and the service projects set `IsTrimmable=true` for
  .NET 8 and later, so the trim analyzer (IL2xxx) runs; Core additionally escalates `IL2026,IL2075` to
  errors via `WarningsAsErrors`, service projects do not. **No project in the repository sets
  `IsAotCompatible` or `EnableAotAnalyzer`**, so the AOT analyzer (IL3xxx) never runs in a normal build.
  A clean trim build says nothing about AOT.
- `Array.CreateInstance(Type, int)` carries `RequiresDynamicCodeAttribute` (IL3050). Use
  `RuntimeHelpers.GetUninitializedObject` to obtain a boxed zero-initialized value type. Note it demands
  `PublicConstructors | NonPublicConstructors`, which `StorageConfig.TargetType` does not carry; a
  value type needs no constructor metadata to be zero-initialized, so this is a legitimate
  `UnconditionalSuppressMessage` for IL2067.
- Turning on `EnableAotAnalyzer` repo-wide is currently blocked by two pre-existing IL3050s in
  `AWSSDK.Core` (`Amazon.Runtime/ClientContext.cs`, `Amazon.Runtime/Documents/Document.cs`, both
  `JsonSerializer.Serialize`).
- Types reached **only by reflection** are trimmed: nested complex members, flattened child types,
  collection element types, and polymorphic derived types. The application must root them with
  `[DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof(T))]`. The `StorageConfig`
  unsupported-type error already says this. The top-level type passed to `Save`/`Load` is rooted by the
  `DynamicallyAccessedMembers` annotation; nothing below it is.
- **`[DynamoDBPolymorphicType]` does not work under Native AOT** — the `$type` discriminator is never
  written. Verified with a plain mutable class hierarchy against an unmodified checkout, so it is not
  caused by any recent change. Do not claim polymorphic support under AOT.

### Running an AOT check

Put `PublishAot` and `RuntimeIdentifier` in the test app's csproj, **not** on the `dotnet publish`
command line: as global properties they propagate into the SDK's `ProjectReference`s and fail with
`NETSDK1207` on the `netstandard2.0` target. `vswhere.exe` must be on `PATH`
(`%ProgramFiles(x86)%\Microsoft Visual Studio\Installer`) or the native link step fails with
`MSB3073`. Set `TrimmerSingleWarn=false` to get per-call-site warnings.

## Testing this area

- `ToDocument` / `FromDocument` exercise conversion only. They never reach `PrepareUpdateOperation` or
  `ApplyPostUpdate`, so condition expressions, update expressions, atomic counters and
  `UpdateBehavior.IfNotExists` require a mocked client and a real `SaveAsync`. See
  `DataModelSaveExpressionTests`.
- Use `SaveAsync` / `UpdateItemAsync` in tests that must run on all targets; the synchronous `Save` and
  `IAmazonDynamoDB.UpdateItem` overloads are .NET Framework only.
- The mock's `UpdateItemResponse` must carry `Attributes` when the model has a counter or an
  `IfNotExists` member, because those set `ReturnValues.AllNewAttributes` and `ApplyPostUpdate` then
  calls `PopulateInstance` on the returned document.
- `DisableFetchingTableMetadata = true` avoids `DescribeTable`. A **nullable** range key combined with
  it throws, because key-type inference converts `default(int?)` to a `Primitive`.
- In the unit test project, unqualified `Utils` resolves to a different type. Fully qualify
  `Amazon.DynamoDBv2.DataModel.Utils`.
- Unit tests run on multiple .NET targets (`SdkMSTestAllTestTargets`). Code not inside
  `#if NET8_0_OR_GREATER` needs coverage that runs on the older targets too.
- After swapping a source file back and forth, `dotnet test` can build against a stale SDK assembly.
  Use `--no-incremental` when verifying that a fix is load-bearing.

## Attribute casing (AttributeCasing / CaseMode)

Covers how the DynamoDB Object Persistence Model (the `DynamoDBContext` / `[DynamoDBTable]` mapping)
decides the casing of DynamoDB attribute names, and the `AttributeCasing` / `CaseMode` feature that
extends it. Handwritten code lives under
`sdk/src/Services/DynamoDBv2/Custom/DataModel/`.

### Where casing is decided

- `DynamoDBTableAttribute` (`Custom/DataModel/Attributes.cs`) carries the casing configuration for a
  mapped type.
- `ItemStorageConfig` (`Custom/DataModel/InternalModel.cs`) is the per-type resolved config. Attribute
  names are **baked into each `PropertyStorage.AttributeName` at config-build time** (in
  `PopulateConfigFromType` via `GetAccurateCase`) and then cached per type by `ItemStorageConfigCache`.
  Casing is therefore not re-evaluated on every serialize/deserialize — it is fixed when the config is
  first built.
- `GetAccurateCase` is the single application point during config build: it delegates to
  `Utils.ApplyCasing(config.AttributeCasing, name)`, which is the extension point that maps each
  `CaseMode` to its transform (e.g. `CamelCase`/`LegacyCamelCase` camelCase the first character via
  `Utils.ToLowerCamelCase`; `PascalCase`/`Unset` return the name unchanged). Add new casings there, not
  in `GetAccurateCase`.

### CaseMode and AttributeCasing

`CaseMode` (in `Attributes.cs`) has four values:

- `Unset = 0` — no casing specified (the default). Behaves as `PascalCase` at the root, but a **nested**
  type left `Unset` **inherits** an enclosing type's casing (e.g. `CamelCase`). This sentinel is what
  lets an explicit `PascalCase` be distinguished from "not specified"; it mirrors the existing
  `ConversionSchema.Unset` pattern on this attribute. Because it is the zero value, an undecorated type
  is treated as "not specified" with no behavior change from prior SDK versions.
- `PascalCase` — attribute names match .NET property names unchanged, at every level (root and nested
  Maps). Set **explicitly** on a nested type, it **blocks** inheritance of an enclosing `CamelCase`
  (this is the difference from `Unset`).
- `CamelCase` — camelCase at every level. Nested objects left `Unset` inherit this, so their Map keys
  are also camelCased. This is the recommended value and closes the long-standing gap (GitHub issue
  #1162) where nested objects stayed PascalCase.
- `LegacyCamelCase` — reproduces the exact asymmetric behavior of the obsolete
  `LowerCamelCaseProperties = true`: camelCase root, PascalCase nested. Marked `[Obsolete]`; exists only
  as a compatibility escape hatch for data already written under that behavior. Does **not** propagate
  to nested objects.

`DynamoDBTableAttribute.AttributeCasing` (a non-nullable `CaseMode` defaulting to `Unset`) selects the
mode. It cannot be a nullable `CaseMode?` because C# does not allow `Nullable<T>` as a named attribute
argument — hence the `Unset` sentinel. `LowerCamelCaseProperties` is now `[Obsolete]` and maps to
`LegacyCamelCase` when `true`.

`DynamoDBTableAttribute` also has constructors `(string tableName, CaseMode attributeCasing)` and
`(string tableName, CaseMode attributeCasing, ConversionSchema conversion)` so callers can set casing
positionally. The two constructors that take a `bool lowerCamelCaseProperties` are `[Obsolete]` and
point at the `CaseMode` overloads. The parameterless-casing constructor `(string tableName)` chains to
the `CaseMode` overload with `CaseMode.Unset` so it does not route through an obsolete member.

### Precedence (ResolveCaseMode in InternalModel.cs)

1. `AttributeCasing != Unset` wins (any explicit value, including an explicit `PascalCase`), and the
   type is recorded as declaring its own casing.
2. Otherwise, obsolete `LowerCamelCaseProperties == true` → `LegacyCamelCase` (also declares own casing).
3. Otherwise (`Unset`, no legacy flag) → `PascalCase`, and the type does **not** declare its own casing,
   so a nested instance may inherit an enclosing casing.

`ResolveCaseMode` also reports whether the type declared its own casing; this is stored on
`ItemStorageConfig.DeclaresOwnCasing` and is what the inheritance gate keys off (not the resolved mode
value), so an explicit `PascalCase` correctly blocks inheritance.

### Nested-object inheritance

Because attribute names are baked per-type and the config cache is keyed by `Type`, inheritance cannot
be done purely at build time (a nested type used under both a camelCase and a PascalCase parent would
need two different baked configs). It also cannot be done by mutating a shared config at serialize time.

The implementation:

- Two per-mode policies are centralized in `Utils` so no serialization/config code hard-codes specific
  modes:
  - `Utils.ApplyCasing(CaseMode, name)` — the actual name transform (used by `GetAccurateCase`).
  - `Utils.GetInheritableCasing(CaseMode)` — the casing a type propagates to undecorated nested types.
    It cascades every casing EXCEPT `LegacyCamelCase` (which returns `null` because it is root-only by
    definition); the special case is confined to that one obsolete value. Used at both propagation sites
    and by the `ShouldInheritCasing` gate.
  - `Utils.IsNameTransformingCasing(CaseMode)` — false for the pass-through casings (`Unset`/`PascalCase`).
    `ShouldInheritCasing` uses it to skip building a config variant whose baked names would be identical
    to the base, so no redundant config is created for those.
  Adding a new casing (e.g. `SnakeCase`) means: add the enum value and add one arm to `ApplyCasing`. It
  cascades to nested objects automatically — `GetInheritableCasing` only excludes `LegacyCamelCase`, so no
  changes to `ContextInternal.cs`, `GetAccurateCase`, or the inheritance gate are needed.
- `DynamoDBFlatConfig.InheritedAttributeCasing` (nullable `CaseMode`) carries the enclosing type's
  inheritable casing down the object graph while (de)serializing. It is set (via
  `Utils.GetInheritableCasing`) and restored (try/finally) around member iteration in
  `PopulateItemStorage` (serialize) and `PopulateInstance` (deserialize) in
  `Custom/DataModel/ContextInternal.cs`. `PascalCase`/`Unset` are carried as their own (non-null) values
  and treated as no-ops by `ShouldInheritCasing` (via `IsNameTransformingCasing`), so they build no
  variant; only `LegacyCamelCase` is mapped to `null` by `GetInheritableCasing` and thus never cascades.
- `ItemStorageConfigCache.ConfigTableCache` keeps `InheritedCasingConfigs`, a
  `Dictionary<CaseMode, ItemStorageConfig>` of variants built with a forced casing. When a nested type
  does not declare its own casing (`DeclaresOwnCasing == false`) and an inheritable casing
  applies, `ResolveInheritedCasingConfig` builds/returns a variant with the names re-baked in that casing.
  `CreateStorageConfig` / `PopulateConfigFromType` take an optional `forcedCasing` that only applies to
  types without their own explicit casing. In `GetConfig`'s read-lock fast path, a `conversionOnly`
  lookup that needs an inherited variant which isn't cached yet must **not** fall through to the
  table-cache lookup: if the nested type was previously converted as a root, its base (PascalCase) table
  config is already cached and would be returned with the wrong casing. The read-lock path is gated so
  `conversionOnly` drops to the write lock (which builds the variant) instead.

Three non-serialization paths also honor inheritance so attribute names stay consistent:

- Filter/update **expressions**: `ResolveNestedPropertyStorage` (used by `ConvertScan` etc.) descends a
  property path like `e => e.ShippingAddress.City`. It seeds `InheritedAttributeCasing` from the root
  `ItemStorageConfig.AttributeCasing` and updates it from each nested config as it descends (with
  save/restore), so a `CamelCase` root emits `shippingAddress.city`, matching what is stored. Without
  this the expression would resolve the nested type's PascalCase base config and emit `City`. The
  resolver also reports the casing that encloses the resolved property, and `SetExpressionValueNode`
  seeds it (save/restore) before serializing a comparison **value**, so `e.ShippingAddress == someAddress`
  serializes the nested value's Map keys as `street`/`city` too — otherwise the value would be written
  PascalCase and never match the stored item. When the path descends through a `[DynamoDBFlatten]` member
  to a flattened complex leaf (e.g. `e => e.Contact.HomeAddress == target`), the resolver returns that
  flattened leaf and reports its `FlattenedEffectiveCasing` as the value casing (mirroring
  `ConditionValueCasing` for scan/query), so the value uses the flattened child's casing rather than the
  enclosing root's.
- **Condition-based queries/scans** (`ScanCondition` / `QueryCondition` / `QueryFilter`): a condition
  targets a top-level property of the root **or a flattened complex leaf**. Both the scan path
  (`ComposeScanFilter`) and the query path (`ComposeQueryFilterHelper` → `ConvertConditionValues`) seed
  `InheritedAttributeCasing` (restored afterward) before serializing each condition value, deriving the
  casing from the **shared** `ConditionValueCasing(conditionProperty, storageConfig)` helper: the resolved
  flattened leaf's `FlattenedEffectiveCasing` when the property is a flattened leaf, otherwise the root's
  `storageConfig.AttributeCasing`. This matters when a condition targets a flattened complex leaf whose
  effective casing differs from the root (e.g. a `PascalCase` `[DynamoDBFlatten]` child under a `CamelCase`
  root) — the value's Map keys must match what save wrote, not the root's casing. Primitive key values are
  unaffected. Keeping both paths on the one helper prevents scan/query drift.
- **Immutable / constructor-bound members** (net8+): `InstantiateWithConstructor` binds stored values to
  a type's constructor parameters *before* `PopulateInstance` runs, so it seeds `InheritedAttributeCasing`
  from the root `ItemStorageConfig.AttributeCasing` (restored afterward) before deserializing each
  argument. Without this, an undecorated nested object passed as a constructor argument of a `CamelCase`
  root would resolve PascalCase names, and — because a constructor-bound member is never revisited by
  `PopulateInstance` — the mismatch would be unrepairable.
- **Flattened members** (`[DynamoDBFlatten]`): on save, a flattened child is serialized through its own
  resolved config (`ToDynamoDBEntry` → `SerializeToDocument`), so its attribute names use the child's
  **effective** casing — the child's own declared casing if it has one, otherwise the parent's casing
  inherited into an undecorated child. On load, `CreateFlattenedMember` reads via the parent
  `PropertyStorage.FlattenProperties`. To keep save and load symmetric, `PopulateConfigFromType` bakes
  `FlattenProperties` names with the child's **effective** casing (not blindly the parent's). This
  matters when a flattened child declares its own casing (e.g. a `PascalCase` child under a `CamelCase`
  parent): both sides then use the child's PascalCase names, so no value is lost on round-trip. The
  child's effective casing for an *undecorated* child is `Utils.GetInheritableCasing(parent)` (falling
  back to `PascalCase`), so a non-propagating parent mode (`LegacyCamelCase`/`PascalCase`/`Unset`) yields
  a PascalCase child on both sides. A non-flattened complex object *inside* a flattened child is handled
  too: the flattening `PropertyStorage.FlattenedEffectiveCasing` is recorded at build time and
  `CreateFlattenedMember` seeds it while populating leaves, so the nested Map resolves with the same
  casing on load that save wrote. The effective casing is also stamped onto each individual flattened
  **leaf** (`FlattenedEffectiveCasing` on the leaf `PropertyStorage`) so scan/query/expression paths can
  recover the right value casing for a condition/comparison that targets a flattened complex leaf by name.
  For a **nested** `[DynamoDBFlatten]` chain, a nested flatten node computes its own effective casing
  recursively, so the stamping only applies to *true* leaves (`!ShouldFlattenChildProperties`) — it must
  not overwrite a nested flatten node's own casing, or a complex leaf inside that nested node would be
  (de)serialized with the wrong casing.

### Explicit opt-out of inheritance

A nested type can force PascalCase under a `CamelCase` parent by explicitly setting
`AttributeCasing = CaseMode.PascalCase`. Because the attribute defaults to `Unset` (not `PascalCase`),
an explicit `PascalCase` is distinguishable from "not specified" and therefore **blocks** inheritance,
while leaving the nested type `Unset` allows it. (An earlier iteration used `PascalCase == 0` as both
default and sentinel, which could not express this; the `Unset` sentinel resolves it. Making the
attribute property a nullable `CaseMode?` was considered but is not possible — C# rejects `Nullable<T>`
as a named attribute argument.)

### Backward compatibility

The default is unchanged: undecorated types and types left `Unset` behave exactly as before (PascalCase
root, PascalCase nested), so existing data round-trips on upgrade. `CamelCase`'s nested behavior is
opt-in. `LegacyCamelCase` exists so that callers relying on the old asymmetric
`LowerCamelCaseProperties = true` output are not silently re-cased.

### Tests

`sdk/test/Services/DynamoDBv2/UnitTests/Custom/DataModel/AttributeCasingTests.cs` uses a mocked
`IAmazonDynamoDB` with `DisableFetchingTableMetadata = true` (no AWS calls) and exercises
`ToDocument` / `FromDocument` for PascalCase, CamelCase (root + nested + round-trip), LegacyCamelCase,
the obsolete-bool equivalence, a nested type left `Unset` inheriting `CamelCase`, and an explicit
`PascalCase` nested type blocking that inheritance.
