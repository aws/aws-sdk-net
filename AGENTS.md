# AGENTS.md

Guidance for AI coding agents working in the AWS SDK for .NET repository.

## Required guidance

Read and follow:

- `.github/copilot-instructions.md` for repository-wide rules.
- `CONTRIBUTING.md` for contribution and DevConfig requirements.

## Task-specific guidance

Before modifying SDK source, read:

- `.agents/skills/aws-sdk-net-maintainer/SKILL.md`

For DevConfig work, also read:

- `.agents/skills/aws-sdk-net-devconfig/SKILL.md`

Do not edit generated source directly. Follow the maintainer skill to determine whether a change
belongs in handwritten code, a generator, or a service model.

## Smithy generator

When working under `generator/SmithyDotNet/`, also follow:

- `generator/SmithyDotNet/CLAUDE.md`
