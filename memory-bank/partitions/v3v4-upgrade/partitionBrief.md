# V3 to V4 Upgrade Partition Brief

## Purpose
Provides comprehensive guidance for migrating applications from AWS SDK for .NET V3 to V4.

## When to Use This Partition
- Upgrading existing V3 applications to V4
- Fixing V3 to V4 breaking changes in code
- Understanding migration strategies and patterns
- Troubleshooting upgrade-related issues
- Planning V3 to V4 migration approach

## Key Breaking Changes Covered
- Collections null by default (vs empty in V3)
- Nullable value types in request/response classes
- DynamoDB Streams moved to separate package
- DynamoDBContext constructor changes (builder pattern)
- S3 encryption package separation
- DateTime handling (consistent UTC)

## Skip This Partition If
- Working with V4-only applications (no migration needed)
- Working with V3-only applications (no upgrade planned)
- Not dealing with breaking changes or compatibility issues