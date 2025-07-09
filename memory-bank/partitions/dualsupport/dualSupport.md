# Dual Support for AWS SDK for .NET V3/V4

## Overview
This document outlines the process for supporting both V3 and V4 versions of the AWS SDK for .NET in the same GitHub repository, ensuring proper issue management, branch organization, and developer workflows.

## GitHub Structure

### Branches
After V4 GA release, branches were reorganized (Option 1 - Branch Flipping):
- `aws-sdk-net-v3.7` (formerly `main`) - V3 release branch
- `aws-sdk-net-v3.7-development` (formerly `main-staging`) - V3 development branch
- `main` (formerly `v4-release`) - V4 release branch
- `development` (formerly `v4-development`) - V4 development branch

### Issues and Discussions
- V3-specific issues labeled with `v3`
- V4-specific issues labeled with `v4`
- Issues affecting both versions labeled with both `v3` and `v4`
- Pre-V4 GA issues without version labels treated as undefined until labeled

### Pull Requests
- V3-only PRs target `aws-sdk-net-v3.7-development` with `v3` label
- V4-only PRs target `development` with `v4` label
- PRs affecting both versions typically target V3 branch first, then synced to V4
- For significantly different implementations, separate version-specific PRs recommended

## SIM (Simple Issue Manager)

### Backlog Items
- V3 and V4 labels applied to backlog items
- Labels visible on sprint boards as squares with hover text

### Ticketing
- `.NET v3`, `.NET v4`, `PS v4`, `PS v5` labels used for ticket categorization
- Labels added during ticket triage

## Branch Renaming Procedure

1. Prepare and set `master` as default branch
2. Rename `main` to `aws-sdk-net-v3.7` (without redirects)
3. Rename `main-staging` to `aws-sdk-net-v3.7-development` (with redirects)
4. Rename `master` to `main` (correcting redirect issues)
5. Force push `v4-release` to `main`
6. Rename `v4-development` to `development` (with redirects)
7. Update branch protection rules
8. Clean up temporary branches

## Build System Considerations

### Update Process
1. Update build system configurations to reference new branch names
2. Block pipelines from promoting beta to prod during transition
3. Throttle preview builds to zero
4. Perform branch swap
5. Unblock pipelines
6. Verify correct repository connections with dry-runs
7. Restore throttle limits
8. Update documentation references

## Developer Guidelines

- Cannot mix V3 and V4 PRs - use appropriate target branches
- Use version labels consistently on all issues and PRs
- For changes affecting both versions, consider using the sync script
- Create separate PRs for significantly different implementations
- Add `CONTRIBUTING.md` file to explain branch structure to contributors
- Pin explanatory issue in public repository about branch renaming

## Documentation
- Update all references from `main-staging` to `development`
- Ensure runbooks reflect current branch structure
- Maintain clear labeling in both GitHub and SIM