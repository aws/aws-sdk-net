# SmithyDotNet Generator - conventions

Smithy-native C# generator producing AWS SDK for .NET code API-compatible with the
current SDK. Reads the Smithy AST directly - no C2J concepts internally.

## Design stance

- **Smithy-native first.** Model the AST and traits on their own terms; don't import
  C2J-shaped abstractions.
- **C2J is a cross-check, not a template.** `generator/ServiceClientGeneratorLib/` defines
  correct *output* (doc sanitization, naming, type mapping, `[AWSProperty]`). Match its output
  where the public API surface requires it; don't mirror its internals or carry its cruft forward.

## Code style

- **Keep it simple.** Always reach for the plainest construct that works. No speculative
  abstraction or ceremony; extract a helper only when a *second* caller exists.
- **When told to simplify, apply it directly** - don't re-ask, offer a trade-off menu, or
  reach for a fancier construct.
- **Be concise.** Code, comments, docs, and commit messages alike. No fluff.
- **Comments explain *why*, not *what*.** A comment that paraphrases the code earns nothing —
  assume the reader can read the body. Say why the code exists or what isn't obvious from it, in
  plain language that lands on first read. If something is provisional (a simplification, a
  one-case-only path), make it a visible `TODO` rather than burying it in prose.
- CRLF on disk (run `unix2dos`).
- No null-forgiving `!` - use `?? throw` or pattern matching.
- Braces on all `if`/`return`.
- Prefer raw string literals (`"""..."""`) over `\"` escaping wherever a literal contains quotes —
  including interpolated (`$"""..."""`). Only reach for `$$"""..."""` when the *emitted* text has
  literal braces, and if the triple/quadruple braces get hard to read, hoist the token into a local
  (`var t = "{" + name + "}";`) and interpolate that instead.
- net8.0, nullable enabled, xUnit v3 (tests pass `TestContext.Current.CancellationToken`).

## Source of truth

The skills under `skills/` are authoritative over anything inferred from code. Before editing
these areas, read the matching skill first; update it when behavior changes:

- Any writer under `Writers/` -> `skills/sdk-conventions/SKILL.md` (the public-API contract —
  what must match vs. what can differ)
- Marshaller/unmarshaller writers -> `skills/marshalling/SKILL.md` as well
- `TypeMapper` / member resolution -> `skills/type-mapping/SKILL.md`
- `Model/` (ShapeConverter, ServiceIndex, shapes, traits) -> `skills/smithy-ast-model/SKILL.md`

Add a skill only for areas with recurring work (marshalling grows with every protocol). A
finished area doesn't get one — its known gaps live as TODOs in the code, where the next
change will find them, not in a skill that would go stale.

## Orchestrating workflows

- Inject these conventions into every agent's shared context.
- Adversarially verify implementations: independent reviewers, verifiers default to "refuted"
  unless they can prove a finding is real.
- Add a "simplicity & conventions" review dimension alongside correctness.
- Don't tell verifiers to ignore "cosmetic" diffs wholesale - real doc/whitespace bugs hide there.
- Skip the multi-angle design panel when the target output is already pinned; use it only when
  the solution space is genuinely open.

## Testing

Run `dotnet test SmithyDotNet.Generator.sln` before reporting a change as done.

- A test class covers one subject and is named after it. A test asserting on a writer's output
  goes in that writer's test class, whatever feature motivated it.
- One fixture model per subject under `TestData/`; grow it rather than build shapes in code.
- A subject's throws are one `[Theory]` of scalar inputs plus the expected message.
- Build inputs as a local plus indexer assignments, never nested `new() { [k] = ... }`.
- No inline JSON in tests except in loader tests.
- Don't add a case that proves what an existing one already does.
