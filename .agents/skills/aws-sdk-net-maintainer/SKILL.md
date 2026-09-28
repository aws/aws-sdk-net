---
name: aws-sdk-net-maintainer
description: Use when working on the AWS SDK for .NET source code itself, including Core runtime changes, service client implementations, generator or model changes, repo-specific build and validation flows, and V3/V4 branch-targeting decisions.
---

# AWS SDK for .NET Maintainer

Use this skill when working on the AWS SDK for .NET source code itself.

## Use this skill when

- changing Core runtime or service client implementations
- working on the generator, templates, or service models
- adding new AWS service support
- working on a handwritten (`Custom/`) service library such as the DynamoDB DataModel
- using the SDK build/validation and testing flows
- managing version bumping and changelog generation (use the `aws-sdk-net-devconfig` skill for DevConfig creation)

## Skip this skill when

- only using the SDK as a consumer
- working on application code that uses the SDK
- working on customer migration from V3 to V4
- working on documentation or external tooling only

## References

- `references/repo-overview.md`
  SDK identity, target frameworks, version history, the V3/V4 compatibility constraint, and the key V4 behavioral change (full list in `technical-context.md`).

- `references/code-structure.md`
  Repository map, service layout, and placement rules for where changes belong.

- `references/build-and-validate.md`
  Build tools, packaging, code generation integration, testing framework, and CI/CD stages.

- `references/technical-context.md`
  Technical context and system patterns related to generation, runtime architecture, and implementation paths.

- `references/dynamodb-datamodel.md`
  DynamoDB DataModel (object persistence) internals: configuration build order, constructor selection,
  the member-collection and `[DynamoDBFlatten]` traps, save/load symmetry, reflection-binder behavior,
  Native AOT constraints, and how to test it.

- `references/dual-support.md`
  Dual-support branch structure, labels, and pull request targeting.
