# GitHub Copilot Instructions

Use the repository skills for maintainer-specific workflows:

- `.agents/skills/aws-sdk-net-maintainer`
- `.agents/skills/aws-sdk-net-devconfig`

These instructions are for repository-wide guidance that should apply even when the maintainer skills are not loaded.

## Support and issue routing

- Use GitHub issues for bug reports and feature requests.
- Do not direct general SDK usage questions to issues if they belong in support channels or documentation.
- Keep issue reports actionable. Include SDK version, runtime or framework details, platform details, stack traces, and a reduced repro when possible.

## Public API and compatibility

- The SDK is modularized. Service packages depend on `AWSSDK.Core`.
- Preserve public API stability and backward compatibility unless a change is intentionally breaking.
- Treat namespaces containing `Internal` as SDK-internal implementation details even if types are publicly visible.
- Do not introduce new guidance that implies V3 and V4 packages can be mixed in the same application.
- When a PR replaces handwritten code with generated code, require evidence that the generated output is functionally equivalent, not just structurally similar.
- PRs that modify code generally require a DevConfig file; limited exceptions include docs-only, tests-only, and build-script-only changes. See `CONTRIBUTING.md` and the `aws-sdk-net-devconfig` skill for the spec.

## Consumer-facing package guidance

- Some optional functionality requires AWS Common Runtime bindings through `AWSSDK.Extensions.CrtIntegration`.
- Keep consumer-facing guidance aligned with the SDK developer guide and published AWS support policy.

## Testing safety

- Do not run integration tests against production accounts.
- Assume integration tests may create and delete AWS resources and may incur charges.
- Be explicit about credential and profile assumptions when discussing integration test execution.

## Scope of these instructions

- Prefer stable repository facts here. Put maintainer workflows, internal build details, DevConfig guidance, and SDK implementation context in skills instead of duplicating them here.
- If a statement is time-sensitive, verify it before adding it here.
