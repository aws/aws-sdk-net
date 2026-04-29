---
name: aws-sdk-net-maintainer
description: Use when working on the AWS SDK for .NET source code itself, including Core runtime changes, service client implementations, generator or model changes, repo-specific build and validation flows, and V3/V4 branch-targeting decisions.
---

# AWS SDK for .NET Maintainer

Use this skill when working on the AWS SDK for .NET source code itself.

## Use this skill when

- contributing to AWS SDK for .NET source code
- understanding SDK internal architecture and patterns
- making changes to core SDK functionality
- adding new AWS service support
- modifying existing service implementations
- working with the SDK build system and tooling
- understanding SDK testing strategies
- managing version bumping and changelog generation in the SDK (use the `aws-sdk-net-devconfig` skill for DevConfig creation)

## Skip this skill when

- only using the SDK as a consumer
- working on application code that uses the SDK
- working on customer migration from V3 to V4
- working on documentation or external tooling only

## References

- `references/repo-overview.md`
  SDK identity, target frameworks, version history, V3/V4 compatibility constraint, and key V4 behavioral changes.

- `references/code-structure.md`
  Repository organization, generator structure, service structure, code generation, and generated vs custom code.

- `references/build-and-validate.md`
  Build tools, packaging, code generation integration, testing framework, and CI/CD stages.

- `references/technical-context.md`
  Technical context and system patterns related to generation, runtime architecture, and implementation paths.

- `references/dual-support.md`
  Dual-support branch structure, labels, pull request targeting, and branch renaming workflow.
