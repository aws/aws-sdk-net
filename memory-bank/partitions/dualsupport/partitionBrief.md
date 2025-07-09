# Dual Support Partition Brief

## Purpose
Manages simultaneous support for AWS SDK for .NET V3 and V4 in the same GitHub repository.

## When to Use This Partition
- Working with GitHub issues, PRs, or branches
- Understanding branch structure and naming conventions
- Managing version-specific development workflows
- Handling cross-version synchronization
- Setting up build pipelines or CI/CD processes

## Key Concepts
- V3 branches: `aws-sdk-net-v3.7` (release), `aws-sdk-net-v3.7-development` (dev)
- V4 branches: `main` (release), `development` (dev)
- Version labels: `v3`, `v4` for issues and PRs
- Branch flipping occurred after V4 GA release
- Separate workflows for version-specific changes

## Skip This Partition If
- Working on code changes only (not repository management)
- Not dealing with branch targeting or PR management
- Working in single-version context