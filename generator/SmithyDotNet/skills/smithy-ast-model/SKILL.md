---
name: smithy-ast-model
description: The Smithy JSON AST facts and model invariants the SmithyDotNet generator relies on. Use when touching Model/ (shapes, traits, the service index).
---
# Skill: Smithy AST Model

The model layer is a typed, read-only view of the [Smithy JSON AST](https://smithy.io/2.0/spec/json-ast.html):
`smithy` (version `"2.0"`), `shapes` (keyed by absolute shape ID), `metadata`. How it is deserialized is an
implementation detail documented in the code; this skill records what the rest of the generator may assume.

## Shape IDs

Every shape has an absolute ID, `com.amazonaws.cloudtraildata#AuditEvent`; members append `$member`
(`...#AuditEvent$id`). Parsing follows the [spec](https://smithy.io/2.0/spec/model.html#shape-id): exactly
one `#`, an optional `$member`, every segment non-empty. The trap is the two string forms: the
**absolute name omits** `$member` (it is the `shapes` dictionary key), while the canonical string form
includes it.

A shape ID appears as a value in two JSON forms: a plain string (`"target": "..."` inside a member) and a
wrapper object (`"input": { "target": "..." }` for operation input/output and service operation lists).
Both resolve to the same shape ID type.

## Shapes and Traits

- `union` derives from `structure` (same members) and is generated as a plain structure, unless it is
  `@streaming` (an event stream, see sdk-conventions).
- `enum`/`intEnum` member traits carry `@enumValue`; the wire value, not the member name, drives generation.
  A `string` shape carrying the legacy `smithy.api#enum` trait is normalized to an `enum` shape at load;
  nothing downstream sees `smithy.api#enum`.
- An unknown shape `type` deserializes to `null` with a stderr warning (forward compatibility).
- Traits stay as raw JSON on every shape, keyed by full trait ID (`smithy.api#required`, `aws.api#service`),
  and are read through typed accessors. [Annotation traits](https://smithy.io/2.0/spec/model.html#annotation-trait)
  have an empty object as their value. Structured trait records tolerate unknown properties.
- After load, only the customization transform mutates the model, and it runs before the service index is
  built. Downstream of the index the model is read-only.

## Prelude Shapes

Shapes in namespace `smithy.api` (`smithy.api#String`, `smithy.api#Integer`, ...) are implicit: not in the
model JSON, skipped by the service index's traversal (they are not part of a service's own closure), but
still resolvable, so a member's target maps without special-casing. The Smithy 1.0 `Primitive*` shapes
(`PrimitiveLong`, `PrimitiveBoolean`, ...) resolve to the same shapes as their plain counterparts; 1.0-era
models reference them and the SDK types both identically.

`smithy.api#Unit` is the one prelude shape that can emit code: when a union member targets it, a per-service
empty `Unit` model class is generated (C2J ships one, and member properties reference it). Operation
input/output references to Unit do **not** count; those emit empty `{Op}Request`/`{Op}Response` classes.

## Key Invariants

- A valid model has exactly one service shape.
- Operation input and output default to `smithy.api#Unit` when absent.
- Member names in a structure's member map are the **Smithy member names** (camelCase), not .NET names.
- `@jsonName` overrides the wire name; the member key stays the model name.
- Mixins are not resolved (production models arrive pre-flattened). A shape reachable from the service that
  declares `mixins` fails loud; unreachable consumers (the `smithy.test`/`aws.protocols` trait definitions
  in the raw protocol-test models) are ignored. The restJson1 test model has no reachable consumers; the
  restXml one does, so it needs flattening or mixin support before it can generate.
- Enum collection skips enums that are unreachable *and* outside the service's namespace, so
  trait-definition enums like `smithy.test#AppliesTo` don't become `ConstantClass`es. Unreachable enums in
  the service's own namespace still emit, matching C2J's orphan `*ExceptionReason` enums.
- Input/output structures are recognized two ways, and both matter: the `@input`/`@output` traits keep a
  structure out of the plain model classes, and the reference from an operation's `input`/`output`
  identifies the request/response pair (some models lack the traits). Error shapes are identified by `@error`.

## Validating Models with the Smithy CLI

`smithy validate --allow-unknown-traits <model.json>` validates a model; `smithy select --selector '<sel>'
--show type --allow-unknown-traits <model.json>` queries shapes
([selectors](https://smithy.io/2.0/spec/selectors.html), e.g. `service > operation`,
`structure > member > string`). `--allow-unknown-traits` is needed because the AWS trait definitions are
not bundled with the CLI.
