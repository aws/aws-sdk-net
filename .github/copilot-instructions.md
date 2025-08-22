# Copilot Instructions for Pull Request Review

## Purpose
These instructions guide Copilot and contributors in reviewing pull requests for the AWS .NET SDK library. The goal is to maintain high code quality, ensure backward compatibility, and follow best practices for library development.

## Review Checklist

### 1. API Compatibility
- Ensure **no breaking changes** are introduced in public APIs.
- All public methods, classes, and interfaces must remain backward compatible unless a major version bump is justified.

### 2. Behavioral Changes
- Check for **changes in behavior** (e.g., logic, side effects, error handling).
- If behavior changes, ensure it is documented and justified in the PR description.

### 3. Dev Config and Versioning
- Every PR must include a **dev config file** with the correct patch, minor, or major notation.
- The dev config should accurately reflect the scope of the change:
	- **Patch**: Bug fixes, no API or behavior change.
	- **Minor**: New features, backward compatible.
	- **Major**: Breaking changes (should be rare).
 - Please reference https://github.com/aws/aws-sdk-net/blob/main/CONTRIBUTING.md for details on dev configs.

### 4. Platform Compatibility
- Ensure changes do not break support for the following .NET versions:
	- .NET Standard 2.0
	- .NET Core 3.1
	- .NET 8.0
	- .NET Framework 4.7.2

### 5. General Best Practices
- Follow .NET and AWS SDK coding standards.
- Avoid introducing unused code, dependencies, or files.
- Ensure all code is properly formatted and linted.

### 6. Generator Changes
- When replacing handwritten code with generated code, ensure the generated code is functionally equivalent to the original.
- Document any differences, edge cases, or limitations in the PR description.
- If possible, provide a comparison or summary of key behaviors between the old and new implementations.

 ### 7. General Review Practices
 - Review code for bugs, flaws in logic, and potential edge cases.
 - Check for correct error handling and input validation.
 - Ensure code is maintainable, readable, and follows best practices.
 - Look for opportunities to simplify or optimize code where appropriate.
 - Look for security vulnerabilities.

## Automated Checks
- Copilot should flag PRs that:
 	- Introduce breaking changes without a major version bump.
 	- Lack a dev config file when its required (see https://github.com/aws/aws-sdk-net/blob/main/CONTRIBUTING.md)
 	- Change public APIs without documentation or tests.
 	- Have failing unit or integration tests.
 	- Reduce test coverage for affected code.
 	- Introduce unhandled exceptions, missing error handling, or poor input validation.
 	- Increase code complexity or reduce maintainability.
 	- Do not document or justify changes in logic, edge cases, or optimizations.
 	- For changes related to migrating custom code to generated code, where evidence of equivalence (e.g., missing test results, behavioral comparison, or documentation) is not provided.
    
