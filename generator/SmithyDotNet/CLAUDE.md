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
- CRLF on disk (run `unix2dos`).
- No null-forgiving `!` - use `?? throw` or pattern matching.
- Braces on all `if`/`return`.
- net10.0, nullable enabled, xUnit v3 (tests pass `TestContext.Current.CancellationToken`).

## Source of truth

The skills under `skills/` are authoritative for the rules: `sdk-conventions` (the public-API
contract — what must match vs. what can differ), `type-mapping`, and `smithy-ast-model`.
Read them before writing a writer; update them when behavior changes.

## Orchestrating workflows

- Inject these conventions into every agent's shared context.
- Adversarially verify implementations: independent reviewers, verifiers default to "refuted"
  unless they can prove a finding is real.
- Add a "simplicity & conventions" review dimension alongside correctness.
- Don't tell verifiers to ignore "cosmetic" diffs wholesale - real doc/whitespace bugs hide there.
- Skip the multi-angle design panel when the target output is already pinned; use it only when
  the solution space is genuinely open.
