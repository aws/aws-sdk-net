# Dual Support

Use this reference only for tasks involving both V3 and V4 maintenance workflows.

## Branch model

- `aws-sdk-net-v3.7`
  V3 release branch
- `aws-sdk-net-v3.7-development`
  V3 development branch
- `main`
  V4 release branch
- `development`
  V4 development branch

## PR targeting

- V3-only changes target `aws-sdk-net-v3.7-development`.
- V4-only changes target `development`.
- Changes affecting both versions often start in the V3 branch and are then synced to V4.
- When implementations differ significantly, separate version-specific PRs are usually cleaner.

## Labels

- use `v3` for V3-only issues and PRs
- use `v4` for V4-only issues and PRs
- use both when the work applies to both versions

## Working rules

- Do not mix V3-only and V4-only work in the wrong target branch.
- Use version labels consistently.
- If both versions are affected, decide whether the same implementation can be synced cleanly or whether separate PRs are needed.
