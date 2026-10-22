/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using Amazon.Runtime;

namespace Amazon.Continuum
{
    /// <summary>
    /// Constants used for properties of type ArtifactHttpMethod.
    /// </summary>
    public class ArtifactHttpMethod : ConstantClass
    {
        /// <summary>
        /// Constant DELETE for ArtifactHttpMethod
        /// </summary>
        public static readonly ArtifactHttpMethod DELETE = new ArtifactHttpMethod("DELETE");

        /// <summary>
        /// Constant GET for ArtifactHttpMethod
        /// </summary>
        public static readonly ArtifactHttpMethod GET = new ArtifactHttpMethod("GET");

        /// <summary>
        /// Constant HEAD for ArtifactHttpMethod
        /// </summary>
        public static readonly ArtifactHttpMethod HEAD = new ArtifactHttpMethod("HEAD");

        /// <summary>
        /// Constant OPTIONS for ArtifactHttpMethod
        /// </summary>
        public static readonly ArtifactHttpMethod OPTIONS = new ArtifactHttpMethod("OPTIONS");

        /// <summary>
        /// Constant PATCH for ArtifactHttpMethod
        /// </summary>
        public static readonly ArtifactHttpMethod PATCH = new ArtifactHttpMethod("PATCH");

        /// <summary>
        /// Constant POST for ArtifactHttpMethod
        /// </summary>
        public static readonly ArtifactHttpMethod POST = new ArtifactHttpMethod("POST");

        /// <summary>
        /// Constant PUT for ArtifactHttpMethod
        /// </summary>
        public static readonly ArtifactHttpMethod PUT = new ArtifactHttpMethod("PUT");

        /// <summary>
        /// Constructs a custom ArtifactHttpMethod for a value not among the defined constants.
        /// </summary>
        public ArtifactHttpMethod(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArtifactHttpMethod FindValue(string value)
        {
            return FindValue<ArtifactHttpMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArtifactHttpMethod(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type CollectorStatus.
    /// </summary>
    public class CollectorStatus : ConstantClass
    {
        /// <summary>
        /// Constant ACTIVE for CollectorStatus
        /// </summary>
        public static readonly CollectorStatus ACTIVE = new CollectorStatus("ACTIVE");

        /// <summary>
        /// Constant PENDING_DELETION for CollectorStatus
        /// </summary>
        public static readonly CollectorStatus PENDING_DELETION = new CollectorStatus("PENDING_DELETION");

        /// <summary>
        /// Constructs a custom CollectorStatus for a value not among the defined constants.
        /// </summary>
        public CollectorStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CollectorStatus FindValue(string value)
        {
            return FindValue<CollectorStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CollectorStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type CollectorType.
    /// </summary>
    public class CollectorType : ConstantClass
    {
        /// <summary>
        /// Constant AWS_COLLECTOR for CollectorType
        /// </summary>
        public static readonly CollectorType AWS_COLLECTOR = new CollectorType("AWS_COLLECTOR");

        /// <summary>
        /// Constructs a custom CollectorType for a value not among the defined constants.
        /// </summary>
        public CollectorType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CollectorType FindValue(string value)
        {
            return FindValue<CollectorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CollectorType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DeliveryReason.
    /// </summary>
    public class DeliveryReason : ConstantClass
    {
        /// <summary>
        /// Constant ARTIFACT_READ_FAILED for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason ARTIFACT_READ_FAILED = new DeliveryReason("ARTIFACT_READ_FAILED");

        /// <summary>
        /// Constant ARTIFACT_SOURCE_MISMATCH for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason ARTIFACT_SOURCE_MISMATCH = new DeliveryReason("ARTIFACT_SOURCE_MISMATCH");

        /// <summary>
        /// Constant ARTIFACT_SOURCE_MISSING for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason ARTIFACT_SOURCE_MISSING = new DeliveryReason("ARTIFACT_SOURCE_MISSING");

        /// <summary>
        /// Constant BUILD_NOT_FOUND for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason BUILD_NOT_FOUND = new DeliveryReason("BUILD_NOT_FOUND");

        /// <summary>
        /// Constant BUILD_READ_FAILED for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason BUILD_READ_FAILED = new DeliveryReason("BUILD_READ_FAILED");

        /// <summary>
        /// Constant BUILD_RESULT_SCOPE_MISMATCH for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason BUILD_RESULT_SCOPE_MISMATCH = new DeliveryReason("BUILD_RESULT_SCOPE_MISMATCH");

        /// <summary>
        /// Constant DELIVERY_NOT_CONFIGURED for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason DELIVERY_NOT_CONFIGURED = new DeliveryReason("DELIVERY_NOT_CONFIGURED");

        /// <summary>
        /// Constant DELIVERY_SOURCE_KIND_CHANGED for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason DELIVERY_SOURCE_KIND_CHANGED = new DeliveryReason("DELIVERY_SOURCE_KIND_CHANGED");

        /// <summary>
        /// Constant DUPLICATE_LOGICAL_REPOSITORY for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason DUPLICATE_LOGICAL_REPOSITORY = new DeliveryReason("DUPLICATE_LOGICAL_REPOSITORY");

        /// <summary>
        /// Constant DUPLICATE_OR_INVALID_REPOSITORY for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason DUPLICATE_OR_INVALID_REPOSITORY = new DeliveryReason("DUPLICATE_OR_INVALID_REPOSITORY");

        /// <summary>
        /// Constant ENVIRONMENT_DELETED for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason ENVIRONMENT_DELETED = new DeliveryReason("ENVIRONMENT_DELETED");

        /// <summary>
        /// Constant ENVIRONMENT_NOT_ACTIVE for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason ENVIRONMENT_NOT_ACTIVE = new DeliveryReason("ENVIRONMENT_NOT_ACTIVE");

        /// <summary>
        /// Constant ENVIRONMENT_NOT_FOUND for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason ENVIRONMENT_NOT_FOUND = new DeliveryReason("ENVIRONMENT_NOT_FOUND");

        /// <summary>
        /// Constant ENVIRONMENT_READ_FAILED for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason ENVIRONMENT_READ_FAILED = new DeliveryReason("ENVIRONMENT_READ_FAILED");

        /// <summary>
        /// Constant EXPORT_CREDENTIALS_MISSING for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason EXPORT_CREDENTIALS_MISSING = new DeliveryReason("EXPORT_CREDENTIALS_MISSING");

        /// <summary>
        /// Constant EXPORT_CREDENTIAL_EXPIRY_INVALID for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason EXPORT_CREDENTIAL_EXPIRY_INVALID = new DeliveryReason("EXPORT_CREDENTIAL_EXPIRY_INVALID");

        /// <summary>
        /// Constant EXPORT_DESTINATION_INVALID for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason EXPORT_DESTINATION_INVALID = new DeliveryReason("EXPORT_DESTINATION_INVALID");

        /// <summary>
        /// Constant EXPORT_EXISTING_OBJECT_MISMATCH for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason EXPORT_EXISTING_OBJECT_MISMATCH = new DeliveryReason("EXPORT_EXISTING_OBJECT_MISMATCH");

        /// <summary>
        /// Constant EXPORT_PUT_FAILED for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason EXPORT_PUT_FAILED = new DeliveryReason("EXPORT_PUT_FAILED");

        /// <summary>
        /// Constant EXPORT_RECONCILIATION_READ_FAILED for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason EXPORT_RECONCILIATION_READ_FAILED = new DeliveryReason("EXPORT_RECONCILIATION_READ_FAILED");

        /// <summary>
        /// Constant EXPORT_ROLE_ASSUMPTION_FAILED for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason EXPORT_ROLE_ASSUMPTION_FAILED = new DeliveryReason("EXPORT_ROLE_ASSUMPTION_FAILED");

        /// <summary>
        /// Constant GITHUB_ACCESS_DENIED for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason GITHUB_ACCESS_DENIED = new DeliveryReason("GITHUB_ACCESS_DENIED");

        /// <summary>
        /// Constant GITHUB_BASE_NOT_FOUND for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason GITHUB_BASE_NOT_FOUND = new DeliveryReason("GITHUB_BASE_NOT_FOUND");

        /// <summary>
        /// Constant GITHUB_BRANCH_CONFLICT for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason GITHUB_BRANCH_CONFLICT = new DeliveryReason("GITHUB_BRANCH_CONFLICT");

        /// <summary>
        /// Constant GITHUB_NOT_FOUND for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason GITHUB_NOT_FOUND = new DeliveryReason("GITHUB_NOT_FOUND");

        /// <summary>
        /// Constant GITHUB_RATE_LIMITED for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason GITHUB_RATE_LIMITED = new DeliveryReason("GITHUB_RATE_LIMITED");

        /// <summary>
        /// Constant GITHUB_REPOSITORY_CHANGED for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason GITHUB_REPOSITORY_CHANGED = new DeliveryReason("GITHUB_REPOSITORY_CHANGED");

        /// <summary>
        /// Constant GITHUB_REPOSITORY_NOT_FOUND for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason GITHUB_REPOSITORY_NOT_FOUND = new DeliveryReason("GITHUB_REPOSITORY_NOT_FOUND");

        /// <summary>
        /// Constant GITHUB_REQUEST_FAILED for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason GITHUB_REQUEST_FAILED = new DeliveryReason("GITHUB_REQUEST_FAILED");

        /// <summary>
        /// Constant GITHUB_REQUEST_REJECTED for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason GITHUB_REQUEST_REJECTED = new DeliveryReason("GITHUB_REQUEST_REJECTED");

        /// <summary>
        /// Constant GITHUB_RESPONSE_INVALID for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason GITHUB_RESPONSE_INVALID = new DeliveryReason("GITHUB_RESPONSE_INVALID");

        /// <summary>
        /// Constant GREEN_ATTEMPT_NOT_SUCCESSFUL for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason GREEN_ATTEMPT_NOT_SUCCESSFUL = new DeliveryReason("GREEN_ATTEMPT_NOT_SUCCESSFUL");

        /// <summary>
        /// Constant GREEN_COMPLETION_NOT_OBSERVED for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason GREEN_COMPLETION_NOT_OBSERVED = new DeliveryReason("GREEN_COMPLETION_NOT_OBSERVED");

        /// <summary>
        /// Constant Github_destination_not_enabled for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason Github_destination_not_enabled = new DeliveryReason("github_destination_not_enabled");

        /// <summary>
        /// Constant INCOMPLETE_SOURCE_REFERENCE for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason INCOMPLETE_SOURCE_REFERENCE = new DeliveryReason("INCOMPLETE_SOURCE_REFERENCE");

        /// <summary>
        /// Constant INVALID_ARCHIVE_DIGEST for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason INVALID_ARCHIVE_DIGEST = new DeliveryReason("INVALID_ARCHIVE_DIGEST");

        /// <summary>
        /// Constant INVALID_ARTIFACT_SOURCE for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason INVALID_ARTIFACT_SOURCE = new DeliveryReason("INVALID_ARTIFACT_SOURCE");

        /// <summary>
        /// Constant INVALID_COMPLETED_MANIFEST for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason INVALID_COMPLETED_MANIFEST = new DeliveryReason("INVALID_COMPLETED_MANIFEST");

        /// <summary>
        /// Constant INVALID_EXPORT_RECEIPT for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason INVALID_EXPORT_RECEIPT = new DeliveryReason("INVALID_EXPORT_RECEIPT");

        /// <summary>
        /// Constant INVALID_GITHUB_PROVENANCE for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason INVALID_GITHUB_PROVENANCE = new DeliveryReason("INVALID_GITHUB_PROVENANCE");

        /// <summary>
        /// Constant INVALID_S3_DESTINATION for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason INVALID_S3_DESTINATION = new DeliveryReason("INVALID_S3_DESTINATION");

        /// <summary>
        /// Constant INVALID_SERVICE_RECEIPT for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason INVALID_SERVICE_RECEIPT = new DeliveryReason("INVALID_SERVICE_RECEIPT");

        /// <summary>
        /// Constant INVALID_SOURCE_INVENTORY for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason INVALID_SOURCE_INVENTORY = new DeliveryReason("INVALID_SOURCE_INVENTORY");

        /// <summary>
        /// Constant INVALID_SOURCE_MANIFEST for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason INVALID_SOURCE_MANIFEST = new DeliveryReason("INVALID_SOURCE_MANIFEST");

        /// <summary>
        /// Constant INVALID_SOURCE_REFERENCE for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason INVALID_SOURCE_REFERENCE = new DeliveryReason("INVALID_SOURCE_REFERENCE");

        /// <summary>
        /// Constant ISSUE_INTEGRITY_FAILURE for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason ISSUE_INTEGRITY_FAILURE = new DeliveryReason("ISSUE_INTEGRITY_FAILURE");

        /// <summary>
        /// Constant ISSUE_NOT_FOUND for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason ISSUE_NOT_FOUND = new DeliveryReason("ISSUE_NOT_FOUND");

        /// <summary>
        /// Constant MANIFEST_INVENTORY_MISMATCH for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason MANIFEST_INVENTORY_MISMATCH = new DeliveryReason("MANIFEST_INVENTORY_MISMATCH");

        /// <summary>
        /// Constant MANIFEST_PROVENANCE_CHANGED for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason MANIFEST_PROVENANCE_CHANGED = new DeliveryReason("MANIFEST_PROVENANCE_CHANGED");

        /// <summary>
        /// Constant MANIFEST_REPOSITORY_SET_MISMATCH for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason MANIFEST_REPOSITORY_SET_MISMATCH = new DeliveryReason("MANIFEST_REPOSITORY_SET_MISMATCH");

        /// <summary>
        /// Constant MANIFEST_SCOPE_OR_VERSION_MISMATCH for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason MANIFEST_SCOPE_OR_VERSION_MISMATCH = new DeliveryReason("MANIFEST_SCOPE_OR_VERSION_MISMATCH");

        /// <summary>
        /// Constant MISSING_BUILD_RESULT for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason MISSING_BUILD_RESULT = new DeliveryReason("MISSING_BUILD_RESULT");

        /// <summary>
        /// Constant MISSING_COMPLETED_MANIFEST for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason MISSING_COMPLETED_MANIFEST = new DeliveryReason("MISSING_COMPLETED_MANIFEST");

        /// <summary>
        /// Constant MISSING_RESULT_DIGEST for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason MISSING_RESULT_DIGEST = new DeliveryReason("MISSING_RESULT_DIGEST");

        /// <summary>
        /// Constant MISSING_SOURCE_MANIFEST for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason MISSING_SOURCE_MANIFEST = new DeliveryReason("MISSING_SOURCE_MANIFEST");

        /// <summary>
        /// Constant MISSING_SOURCE_TARGET for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason MISSING_SOURCE_TARGET = new DeliveryReason("MISSING_SOURCE_TARGET");

        /// <summary>
        /// Constant PATCH_NOT_APPLICABLE for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason PATCH_NOT_APPLICABLE = new DeliveryReason("PATCH_NOT_APPLICABLE");

        /// <summary>
        /// Constant PATCH_NOT_SELECTED for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason PATCH_NOT_SELECTED = new DeliveryReason("PATCH_NOT_SELECTED");

        /// <summary>
        /// Constant PATCH_STORAGE_IDENTITY_MISSING for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason PATCH_STORAGE_IDENTITY_MISSING = new DeliveryReason("PATCH_STORAGE_IDENTITY_MISSING");

        /// <summary>
        /// Constant PATCH_UNSUPPORTED for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason PATCH_UNSUPPORTED = new DeliveryReason("PATCH_UNSUPPORTED");

        /// <summary>
        /// Constant PUBLICATION_OUTCOME_UNKNOWN_AFTER_RETRY_LIMIT for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason PUBLICATION_OUTCOME_UNKNOWN_AFTER_RETRY_LIMIT = new DeliveryReason("PUBLICATION_OUTCOME_UNKNOWN_AFTER_RETRY_LIMIT");

        /// <summary>
        /// Constant PUBLISHER_DEADLINE_EXCEEDED for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason PUBLISHER_DEADLINE_EXCEEDED = new DeliveryReason("PUBLISHER_DEADLINE_EXCEEDED");

        /// <summary>
        /// Constant Patch_creation_policy_disabled for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason Patch_creation_policy_disabled = new DeliveryReason("patch_creation_policy_disabled");

        /// <summary>
        /// Constant RESULT_COMPLETED_MANIFEST_MISMATCH for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason RESULT_COMPLETED_MANIFEST_MISMATCH = new DeliveryReason("RESULT_COMPLETED_MANIFEST_MISMATCH");

        /// <summary>
        /// Constant RESULT_SOURCE_BINDING_MISMATCH for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason RESULT_SOURCE_BINDING_MISMATCH = new DeliveryReason("RESULT_SOURCE_BINDING_MISMATCH");

        /// <summary>
        /// Constant S3_ACCESS_DENIED for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason S3_ACCESS_DENIED = new DeliveryReason("S3_ACCESS_DENIED");

        /// <summary>
        /// Constant S3_SOURCE_PREFIX_OVERLAP for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason S3_SOURCE_PREFIX_OVERLAP = new DeliveryReason("S3_SOURCE_PREFIX_OVERLAP");

        /// <summary>
        /// Constant SERVICE_COPY_DIGEST_MISMATCH for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason SERVICE_COPY_DIGEST_MISMATCH = new DeliveryReason("SERVICE_COPY_DIGEST_MISMATCH");

        /// <summary>
        /// Constant SERVICE_OBJECT_READ_FAILED for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason SERVICE_OBJECT_READ_FAILED = new DeliveryReason("SERVICE_OBJECT_READ_FAILED");

        /// <summary>
        /// Constant SERVICE_OBJECT_TOO_LARGE for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason SERVICE_OBJECT_TOO_LARGE = new DeliveryReason("SERVICE_OBJECT_TOO_LARGE");

        /// <summary>
        /// Constant SERVICE_RECEIPT_OUTSIDE_ISSUE for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason SERVICE_RECEIPT_OUTSIDE_ISSUE = new DeliveryReason("SERVICE_RECEIPT_OUTSIDE_ISSUE");

        /// <summary>
        /// Constant SOURCE_INTEGRATION_CHANGED for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason SOURCE_INTEGRATION_CHANGED = new DeliveryReason("SOURCE_INTEGRATION_CHANGED");

        /// <summary>
        /// Constant SOURCE_INTEGRATION_INVALID for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason SOURCE_INTEGRATION_INVALID = new DeliveryReason("SOURCE_INTEGRATION_INVALID");

        /// <summary>
        /// Constant SOURCE_INTEGRATION_READ_FAILED for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason SOURCE_INTEGRATION_READ_FAILED = new DeliveryReason("SOURCE_INTEGRATION_READ_FAILED");

        /// <summary>
        /// Constant SOURCE_INTEGRATION_UNRESOLVED for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason SOURCE_INTEGRATION_UNRESOLVED = new DeliveryReason("SOURCE_INTEGRATION_UNRESOLVED");

        /// <summary>
        /// Constant SOURCE_OBJECT_DIGEST_MISMATCH for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason SOURCE_OBJECT_DIGEST_MISMATCH = new DeliveryReason("SOURCE_OBJECT_DIGEST_MISMATCH");

        /// <summary>
        /// Constant SOURCE_REFERENCE_OUTSIDE_BUILD for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason SOURCE_REFERENCE_OUTSIDE_BUILD = new DeliveryReason("SOURCE_REFERENCE_OUTSIDE_BUILD");

        /// <summary>
        /// Constant SOURCE_TARGET_BUILD_MISMATCH for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason SOURCE_TARGET_BUILD_MISMATCH = new DeliveryReason("SOURCE_TARGET_BUILD_MISMATCH");

        /// <summary>
        /// Constant UNKNOWN_REPOSITORY for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason UNKNOWN_REPOSITORY = new DeliveryReason("UNKNOWN_REPOSITORY");

        /// <summary>
        /// Constant UNKNOWN_SOURCE_PROVIDER for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason UNKNOWN_SOURCE_PROVIDER = new DeliveryReason("UNKNOWN_SOURCE_PROVIDER");

        /// <summary>
        /// Constant UNSUPPORTED_ENVIRONMENT_SCHEMA for DeliveryReason
        /// </summary>
        public static readonly DeliveryReason UNSUPPORTED_ENVIRONMENT_SCHEMA = new DeliveryReason("UNSUPPORTED_ENVIRONMENT_SCHEMA");

        /// <summary>
        /// Constructs a custom DeliveryReason for a value not among the defined constants.
        /// </summary>
        public DeliveryReason(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeliveryReason FindValue(string value)
        {
            return FindValue<DeliveryReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeliveryReason(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DeliveryStatus.
    /// </summary>
    public class DeliveryStatus : ConstantClass
    {
        /// <summary>
        /// Constant ABANDONED for DeliveryStatus
        /// </summary>
        public static readonly DeliveryStatus ABANDONED = new DeliveryStatus("ABANDONED");

        /// <summary>
        /// Constant FAILED for DeliveryStatus
        /// </summary>
        public static readonly DeliveryStatus FAILED = new DeliveryStatus("FAILED");

        /// <summary>
        /// Constant PENDING for DeliveryStatus
        /// </summary>
        public static readonly DeliveryStatus PENDING = new DeliveryStatus("PENDING");

        /// <summary>
        /// Constant SKIPPED for DeliveryStatus
        /// </summary>
        public static readonly DeliveryStatus SKIPPED = new DeliveryStatus("SKIPPED");

        /// <summary>
        /// Constant SUCCEEDED for DeliveryStatus
        /// </summary>
        public static readonly DeliveryStatus SUCCEEDED = new DeliveryStatus("SUCCEEDED");

        /// <summary>
        /// Constructs a custom DeliveryStatus for a value not among the defined constants.
        /// </summary>
        public DeliveryStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeliveryStatus FindValue(string value)
        {
            return FindValue<DeliveryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeliveryStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type EnvironmentStatus.
    /// </summary>
    public class EnvironmentStatus : ConstantClass
    {
        /// <summary>
        /// Constant ACTIVE for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus ACTIVE = new EnvironmentStatus("ACTIVE");

        /// <summary>
        /// Constructs a custom EnvironmentStatus for a value not among the defined constants.
        /// </summary>
        public EnvironmentStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentStatus FindValue(string value)
        {
            return FindValue<EnvironmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnvironmentStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ExploitEffect.
    /// </summary>
    public class ExploitEffect : ConstantClass
    {
        /// <summary>
        /// Constant BEHAVIOR_CHANGED for ExploitEffect
        /// </summary>
        public static readonly ExploitEffect BEHAVIOR_CHANGED = new ExploitEffect("BEHAVIOR_CHANGED");

        /// <summary>
        /// Constant DATA_LEAKED for ExploitEffect
        /// </summary>
        public static readonly ExploitEffect DATA_LEAKED = new ExploitEffect("DATA_LEAKED");

        /// <summary>
        /// Constant ERROR_REVEALED for ExploitEffect
        /// </summary>
        public static readonly ExploitEffect ERROR_REVEALED = new ExploitEffect("ERROR_REVEALED");

        /// <summary>
        /// Constant NO_EFFECT for ExploitEffect
        /// </summary>
        public static readonly ExploitEffect NO_EFFECT = new ExploitEffect("NO_EFFECT");

        /// <summary>
        /// Constructs a custom ExploitEffect for a value not among the defined constants.
        /// </summary>
        public ExploitEffect(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExploitEffect FindValue(string value)
        {
            return FindValue<ExploitEffect>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExploitEffect(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ExploitabilityVerdict.
    /// </summary>
    public class ExploitabilityVerdict : ConstantClass
    {
        /// <summary>
        /// Constant EXPLOITABLE for ExploitabilityVerdict
        /// </summary>
        public static readonly ExploitabilityVerdict EXPLOITABLE = new ExploitabilityVerdict("EXPLOITABLE");

        /// <summary>
        /// Constant NOT_EXPLOITABLE for ExploitabilityVerdict
        /// </summary>
        public static readonly ExploitabilityVerdict NOT_EXPLOITABLE = new ExploitabilityVerdict("NOT_EXPLOITABLE");

        /// <summary>
        /// Constant UNCERTAIN for ExploitabilityVerdict
        /// </summary>
        public static readonly ExploitabilityVerdict UNCERTAIN = new ExploitabilityVerdict("UNCERTAIN");

        /// <summary>
        /// Constructs a custom ExploitabilityVerdict for a value not among the defined constants.
        /// </summary>
        public ExploitabilityVerdict(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExploitabilityVerdict FindValue(string value)
        {
            return FindValue<ExploitabilityVerdict>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExploitabilityVerdict(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type FindingBlockingReason.
    /// </summary>
    public class FindingBlockingReason : ConstantClass
    {
        /// <summary>
        /// Constant EXCLUDED for FindingBlockingReason
        /// </summary>
        public static readonly FindingBlockingReason EXCLUDED = new FindingBlockingReason("EXCLUDED");

        /// <summary>
        /// Constant MISCLASSIFIED for FindingBlockingReason
        /// </summary>
        public static readonly FindingBlockingReason MISCLASSIFIED = new FindingBlockingReason("MISCLASSIFIED");

        /// <summary>
        /// Constant NONE for FindingBlockingReason
        /// </summary>
        public static readonly FindingBlockingReason NONE = new FindingBlockingReason("NONE");

        /// <summary>
        /// Constant NOT_FEASIBLE for FindingBlockingReason
        /// </summary>
        public static readonly FindingBlockingReason NOT_FEASIBLE = new FindingBlockingReason("NOT_FEASIBLE");

        /// <summary>
        /// Constant PROTECTED for FindingBlockingReason
        /// </summary>
        public static readonly FindingBlockingReason PROTECTED = new FindingBlockingReason("PROTECTED");

        /// <summary>
        /// Constant RISK_MITIGATED for FindingBlockingReason
        /// </summary>
        public static readonly FindingBlockingReason RISK_MITIGATED = new FindingBlockingReason("RISK_MITIGATED");

        /// <summary>
        /// Constant UNREACHABLE for FindingBlockingReason
        /// </summary>
        public static readonly FindingBlockingReason UNREACHABLE = new FindingBlockingReason("UNREACHABLE");

        /// <summary>
        /// Constructs a custom FindingBlockingReason for a value not among the defined constants.
        /// </summary>
        public FindingBlockingReason(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingBlockingReason FindValue(string value)
        {
            return FindValue<FindingBlockingReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingBlockingReason(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type FindingDiscardReason.
    /// </summary>
    public class FindingDiscardReason : ConstantClass
    {
        /// <summary>
        /// Constant COMPENSATING_CONTROL_PRESENT for FindingDiscardReason
        /// </summary>
        public static readonly FindingDiscardReason COMPENSATING_CONTROL_PRESENT = new FindingDiscardReason("COMPENSATING_CONTROL_PRESENT");

        /// <summary>
        /// Constant DUPLICATE_OF_CLOSED_ISSUE for FindingDiscardReason
        /// </summary>
        public static readonly FindingDiscardReason DUPLICATE_OF_CLOSED_ISSUE = new FindingDiscardReason("DUPLICATE_OF_CLOSED_ISSUE");

        /// <summary>
        /// Constant DUPLICATE_OF_OPEN_ISSUE for FindingDiscardReason
        /// </summary>
        public static readonly FindingDiscardReason DUPLICATE_OF_OPEN_ISSUE = new FindingDiscardReason("DUPLICATE_OF_OPEN_ISSUE");

        /// <summary>
        /// Constant FALSE_POSITIVE_VALIDATED_AGAINST_CONTEXT for FindingDiscardReason
        /// </summary>
        public static readonly FindingDiscardReason FALSE_POSITIVE_VALIDATED_AGAINST_CONTEXT = new FindingDiscardReason("FALSE_POSITIVE_VALIDATED_AGAINST_CONTEXT");

        /// <summary>
        /// Constant INSUFFICIENT_EVIDENCE for FindingDiscardReason
        /// </summary>
        public static readonly FindingDiscardReason INSUFFICIENT_EVIDENCE = new FindingDiscardReason("INSUFFICIENT_EVIDENCE");

        /// <summary>
        /// Constant OUT_OF_SCOPE for FindingDiscardReason
        /// </summary>
        public static readonly FindingDiscardReason OUT_OF_SCOPE = new FindingDiscardReason("OUT_OF_SCOPE");

        /// <summary>
        /// Constant PROCESSING_FAILED for FindingDiscardReason
        /// </summary>
        public static readonly FindingDiscardReason PROCESSING_FAILED = new FindingDiscardReason("PROCESSING_FAILED");

        /// <summary>
        /// Constant SCANNER_NEEDS_REVIEW for FindingDiscardReason
        /// </summary>
        public static readonly FindingDiscardReason SCANNER_NEEDS_REVIEW = new FindingDiscardReason("SCANNER_NEEDS_REVIEW");

        /// <summary>
        /// Constant SCANNER_VALIDATED_FALSE_POSITIVE for FindingDiscardReason
        /// </summary>
        public static readonly FindingDiscardReason SCANNER_VALIDATED_FALSE_POSITIVE = new FindingDiscardReason("SCANNER_VALIDATED_FALSE_POSITIVE");

        /// <summary>
        /// Constant SOURCE_REPO_NOT_FOUND for FindingDiscardReason
        /// </summary>
        public static readonly FindingDiscardReason SOURCE_REPO_NOT_FOUND = new FindingDiscardReason("SOURCE_REPO_NOT_FOUND");

        /// <summary>
        /// Constructs a custom FindingDiscardReason for a value not among the defined constants.
        /// </summary>
        public FindingDiscardReason(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingDiscardReason FindValue(string value)
        {
            return FindValue<FindingDiscardReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingDiscardReason(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type FindingOcsfClass.
    /// </summary>
    public class FindingOcsfClass : ConstantClass
    {
        /// <summary>
        /// Constant APPLICATION_SECURITY_POSTURE_FINDING for FindingOcsfClass
        /// </summary>
        public static readonly FindingOcsfClass APPLICATION_SECURITY_POSTURE_FINDING = new FindingOcsfClass("APPLICATION_SECURITY_POSTURE_FINDING");

        /// <summary>
        /// Constant VULNERABILITY_FINDING for FindingOcsfClass
        /// </summary>
        public static readonly FindingOcsfClass VULNERABILITY_FINDING = new FindingOcsfClass("VULNERABILITY_FINDING");

        /// <summary>
        /// Constructs a custom FindingOcsfClass for a value not among the defined constants.
        /// </summary>
        public FindingOcsfClass(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingOcsfClass FindValue(string value)
        {
            return FindValue<FindingOcsfClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingOcsfClass(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type FindingSeverityAdjustment.
    /// </summary>
    public class FindingSeverityAdjustment : ConstantClass
    {
        /// <summary>
        /// Constant CRITICAL for FindingSeverityAdjustment
        /// </summary>
        public static readonly FindingSeverityAdjustment CRITICAL = new FindingSeverityAdjustment("CRITICAL");

        /// <summary>
        /// Constant HIGH for FindingSeverityAdjustment
        /// </summary>
        public static readonly FindingSeverityAdjustment HIGH = new FindingSeverityAdjustment("HIGH");

        /// <summary>
        /// Constant INFORMATIONAL for FindingSeverityAdjustment
        /// </summary>
        public static readonly FindingSeverityAdjustment INFORMATIONAL = new FindingSeverityAdjustment("INFORMATIONAL");

        /// <summary>
        /// Constant LOW for FindingSeverityAdjustment
        /// </summary>
        public static readonly FindingSeverityAdjustment LOW = new FindingSeverityAdjustment("LOW");

        /// <summary>
        /// Constant MEDIUM for FindingSeverityAdjustment
        /// </summary>
        public static readonly FindingSeverityAdjustment MEDIUM = new FindingSeverityAdjustment("MEDIUM");

        /// <summary>
        /// Constant UNCHANGED for FindingSeverityAdjustment
        /// </summary>
        public static readonly FindingSeverityAdjustment UNCHANGED = new FindingSeverityAdjustment("UNCHANGED");

        /// <summary>
        /// Constructs a custom FindingSeverityAdjustment for a value not among the defined constants.
        /// </summary>
        public FindingSeverityAdjustment(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingSeverityAdjustment FindValue(string value)
        {
            return FindValue<FindingSeverityAdjustment>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingSeverityAdjustment(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type FindingSeverityId.
    /// </summary>
    public class FindingSeverityId : ConstantClass
    {
        /// <summary>
        /// Constant CRITICAL for FindingSeverityId
        /// </summary>
        public static readonly FindingSeverityId CRITICAL = new FindingSeverityId("CRITICAL");

        /// <summary>
        /// Constant FATAL for FindingSeverityId
        /// </summary>
        public static readonly FindingSeverityId FATAL = new FindingSeverityId("FATAL");

        /// <summary>
        /// Constant HIGH for FindingSeverityId
        /// </summary>
        public static readonly FindingSeverityId HIGH = new FindingSeverityId("HIGH");

        /// <summary>
        /// Constant INFORMATIONAL for FindingSeverityId
        /// </summary>
        public static readonly FindingSeverityId INFORMATIONAL = new FindingSeverityId("INFORMATIONAL");

        /// <summary>
        /// Constant LOW for FindingSeverityId
        /// </summary>
        public static readonly FindingSeverityId LOW = new FindingSeverityId("LOW");

        /// <summary>
        /// Constant MEDIUM for FindingSeverityId
        /// </summary>
        public static readonly FindingSeverityId MEDIUM = new FindingSeverityId("MEDIUM");

        /// <summary>
        /// Constant OTHER for FindingSeverityId
        /// </summary>
        public static readonly FindingSeverityId OTHER = new FindingSeverityId("OTHER");

        /// <summary>
        /// Constant UNKNOWN for FindingSeverityId
        /// </summary>
        public static readonly FindingSeverityId UNKNOWN = new FindingSeverityId("UNKNOWN");

        /// <summary>
        /// Constructs a custom FindingSeverityId for a value not among the defined constants.
        /// </summary>
        public FindingSeverityId(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingSeverityId FindValue(string value)
        {
            return FindValue<FindingSeverityId>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingSeverityId(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type FindingStatus.
    /// </summary>
    public class FindingStatus : ConstantClass
    {
        /// <summary>
        /// Constant CONFIRMED for FindingStatus
        /// </summary>
        public static readonly FindingStatus CONFIRMED = new FindingStatus("CONFIRMED");

        /// <summary>
        /// Constant DISCARDED for FindingStatus
        /// </summary>
        public static readonly FindingStatus DISCARDED = new FindingStatus("DISCARDED");

        /// <summary>
        /// Constant SUBMITTED for FindingStatus
        /// </summary>
        public static readonly FindingStatus SUBMITTED = new FindingStatus("SUBMITTED");

        /// <summary>
        /// Constant VALIDATING for FindingStatus
        /// </summary>
        public static readonly FindingStatus VALIDATING = new FindingStatus("VALIDATING");

        /// <summary>
        /// Constructs a custom FindingStatus for a value not among the defined constants.
        /// </summary>
        public FindingStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingStatus FindValue(string value)
        {
            return FindValue<FindingStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type FindingType.
    /// </summary>
    public class FindingType : ConstantClass
    {
        /// <summary>
        /// Constant CONTINUUM_CODE_VULN for FindingType
        /// </summary>
        public static readonly FindingType CONTINUUM_CODE_VULN = new FindingType("CONTINUUM_CODE_VULN");

        /// <summary>
        /// Constant CUSTOMER_CODE_VULN for FindingType
        /// </summary>
        public static readonly FindingType CUSTOMER_CODE_VULN = new FindingType("CUSTOMER_CODE_VULN");

        /// <summary>
        /// Constructs a custom FindingType for a value not among the defined constants.
        /// </summary>
        public FindingType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingType FindValue(string value)
        {
            return FindValue<FindingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type FindingVerdict.
    /// </summary>
    public class FindingVerdict : ConstantClass
    {
        /// <summary>
        /// Constant BENIGN_TRUE_POSITIVE for FindingVerdict
        /// </summary>
        public static readonly FindingVerdict BENIGN_TRUE_POSITIVE = new FindingVerdict("BENIGN_TRUE_POSITIVE");

        /// <summary>
        /// Constant FALSE_POSITIVE for FindingVerdict
        /// </summary>
        public static readonly FindingVerdict FALSE_POSITIVE = new FindingVerdict("FALSE_POSITIVE");

        /// <summary>
        /// Constant NEEDS_REVIEW for FindingVerdict
        /// </summary>
        public static readonly FindingVerdict NEEDS_REVIEW = new FindingVerdict("NEEDS_REVIEW");

        /// <summary>
        /// Constant TRUE_POSITIVE for FindingVerdict
        /// </summary>
        public static readonly FindingVerdict TRUE_POSITIVE = new FindingVerdict("TRUE_POSITIVE");

        /// <summary>
        /// Constructs a custom FindingVerdict for a value not among the defined constants.
        /// </summary>
        public FindingVerdict(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingVerdict FindValue(string value)
        {
            return FindValue<FindingVerdict>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingVerdict(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type FlowVerdictValue.
    /// </summary>
    public class FlowVerdictValue : ConstantClass
    {
        /// <summary>
        /// Constant CONFIRMED for FlowVerdictValue
        /// </summary>
        public static readonly FlowVerdictValue CONFIRMED = new FlowVerdictValue("CONFIRMED");

        /// <summary>
        /// Constant DENIED for FlowVerdictValue
        /// </summary>
        public static readonly FlowVerdictValue DENIED = new FlowVerdictValue("DENIED");

        /// <summary>
        /// Constant INCONCLUSIVE for FlowVerdictValue
        /// </summary>
        public static readonly FlowVerdictValue INCONCLUSIVE = new FlowVerdictValue("INCONCLUSIVE");

        /// <summary>
        /// Constructs a custom FlowVerdictValue for a value not among the defined constants.
        /// </summary>
        public FlowVerdictValue(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FlowVerdictValue FindValue(string value)
        {
            return FindValue<FlowVerdictValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FlowVerdictValue(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type GitLabTargetType.
    /// </summary>
    public class GitLabTargetType : ConstantClass
    {
        /// <summary>
        /// Constant GROUP for GitLabTargetType
        /// </summary>
        public static readonly GitLabTargetType GROUP = new GitLabTargetType("GROUP");

        /// <summary>
        /// Constant PROJECT for GitLabTargetType
        /// </summary>
        public static readonly GitLabTargetType PROJECT = new GitLabTargetType("PROJECT");

        /// <summary>
        /// Constructs a custom GitLabTargetType for a value not among the defined constants.
        /// </summary>
        public GitLabTargetType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GitLabTargetType FindValue(string value)
        {
            return FindValue<GitLabTargetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GitLabTargetType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type GitLabTokenRotation.
    /// </summary>
    public class GitLabTokenRotation : ConstantClass
    {
        /// <summary>
        /// Constant AUTOMATIC for GitLabTokenRotation
        /// </summary>
        public static readonly GitLabTokenRotation AUTOMATIC = new GitLabTokenRotation("AUTOMATIC");

        /// <summary>
        /// Constant NONE for GitLabTokenRotation
        /// </summary>
        public static readonly GitLabTokenRotation NONE = new GitLabTokenRotation("NONE");

        /// <summary>
        /// Constructs a custom GitLabTokenRotation for a value not among the defined constants.
        /// </summary>
        public GitLabTokenRotation(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GitLabTokenRotation FindValue(string value)
        {
            return FindValue<GitLabTokenRotation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GitLabTokenRotation(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type IntegrationAuthorizationProviderType.
    /// </summary>
    public class IntegrationAuthorizationProviderType : ConstantClass
    {
        /// <summary>
        /// Constant GITHUB for IntegrationAuthorizationProviderType
        /// </summary>
        public static readonly IntegrationAuthorizationProviderType GITHUB = new IntegrationAuthorizationProviderType("GITHUB");

        /// <summary>
        /// Constructs a custom IntegrationAuthorizationProviderType for a value not among the defined constants.
        /// </summary>
        public IntegrationAuthorizationProviderType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IntegrationAuthorizationProviderType FindValue(string value)
        {
            return FindValue<IntegrationAuthorizationProviderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IntegrationAuthorizationProviderType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type IntegrationType.
    /// </summary>
    public class IntegrationType : ConstantClass
    {
        /// <summary>
        /// Constant GITHUB for IntegrationType
        /// </summary>
        public static readonly IntegrationType GITHUB = new IntegrationType("GITHUB");

        /// <summary>
        /// Constant GITLAB for IntegrationType
        /// </summary>
        public static readonly IntegrationType GITLAB = new IntegrationType("GITLAB");

        /// <summary>
        /// Constant S3 for IntegrationType
        /// </summary>
        public static readonly IntegrationType S3 = new IntegrationType("S3");

        /// <summary>
        /// Constructs a custom IntegrationType for a value not among the defined constants.
        /// </summary>
        public IntegrationType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IntegrationType FindValue(string value)
        {
            return FindValue<IntegrationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IntegrationType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type IssueArtifactType.
    /// </summary>
    public class IssueArtifactType : ConstantClass
    {
        /// <summary>
        /// Constant AGENT_COMMUNICATION for IssueArtifactType
        /// </summary>
        public static readonly IssueArtifactType AGENT_COMMUNICATION = new IssueArtifactType("AGENT_COMMUNICATION");

        /// <summary>
        /// Constant DECISION for IssueArtifactType
        /// </summary>
        public static readonly IssueArtifactType DECISION = new IssueArtifactType("DECISION");

        /// <summary>
        /// Constant EVIDENCE for IssueArtifactType
        /// </summary>
        public static readonly IssueArtifactType EVIDENCE = new IssueArtifactType("EVIDENCE");

        /// <summary>
        /// Constant PATCH for IssueArtifactType
        /// </summary>
        public static readonly IssueArtifactType PATCH = new IssueArtifactType("PATCH");

        /// <summary>
        /// Constant REMEDIATION_PROPOSAL for IssueArtifactType
        /// </summary>
        public static readonly IssueArtifactType REMEDIATION_PROPOSAL = new IssueArtifactType("REMEDIATION_PROPOSAL");

        /// <summary>
        /// Constant VALIDATION_EVIDENCE for IssueArtifactType
        /// </summary>
        public static readonly IssueArtifactType VALIDATION_EVIDENCE = new IssueArtifactType("VALIDATION_EVIDENCE");

        /// <summary>
        /// Constructs a custom IssueArtifactType for a value not among the defined constants.
        /// </summary>
        public IssueArtifactType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IssueArtifactType FindValue(string value)
        {
            return FindValue<IssueArtifactType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IssueArtifactType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type IssueEvidenceAvailability.
    /// </summary>
    public class IssueEvidenceAvailability : ConstantClass
    {
        /// <summary>
        /// Constant AVAILABLE for IssueEvidenceAvailability
        /// </summary>
        public static readonly IssueEvidenceAvailability AVAILABLE = new IssueEvidenceAvailability("AVAILABLE");

        /// <summary>
        /// Constant NONE for IssueEvidenceAvailability
        /// </summary>
        public static readonly IssueEvidenceAvailability NONE = new IssueEvidenceAvailability("NONE");

        /// <summary>
        /// Constructs a custom IssueEvidenceAvailability for a value not among the defined constants.
        /// </summary>
        public IssueEvidenceAvailability(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IssueEvidenceAvailability FindValue(string value)
        {
            return FindValue<IssueEvidenceAvailability>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IssueEvidenceAvailability(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type IssuePatchDeliveryStatus.
    /// </summary>
    public class IssuePatchDeliveryStatus : ConstantClass
    {
        /// <summary>
        /// Constant FAILED for IssuePatchDeliveryStatus
        /// </summary>
        public static readonly IssuePatchDeliveryStatus FAILED = new IssuePatchDeliveryStatus("FAILED");

        /// <summary>
        /// Constant PENDING for IssuePatchDeliveryStatus
        /// </summary>
        public static readonly IssuePatchDeliveryStatus PENDING = new IssuePatchDeliveryStatus("PENDING");

        /// <summary>
        /// Constant SKIPPED for IssuePatchDeliveryStatus
        /// </summary>
        public static readonly IssuePatchDeliveryStatus SKIPPED = new IssuePatchDeliveryStatus("SKIPPED");

        /// <summary>
        /// Constant SUCCEEDED for IssuePatchDeliveryStatus
        /// </summary>
        public static readonly IssuePatchDeliveryStatus SUCCEEDED = new IssuePatchDeliveryStatus("SUCCEEDED");

        /// <summary>
        /// Constructs a custom IssuePatchDeliveryStatus for a value not among the defined constants.
        /// </summary>
        public IssuePatchDeliveryStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IssuePatchDeliveryStatus FindValue(string value)
        {
            return FindValue<IssuePatchDeliveryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IssuePatchDeliveryStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type IssuePhase.
    /// </summary>
    public class IssuePhase : ConstantClass
    {
        /// <summary>
        /// Constant PRIORITIZATION for IssuePhase
        /// </summary>
        public static readonly IssuePhase PRIORITIZATION = new IssuePhase("PRIORITIZATION");

        /// <summary>
        /// Constant REMEDIATION for IssuePhase
        /// </summary>
        public static readonly IssuePhase REMEDIATION = new IssuePhase("REMEDIATION");

        /// <summary>
        /// Constant VALIDATION for IssuePhase
        /// </summary>
        public static readonly IssuePhase VALIDATION = new IssuePhase("VALIDATION");

        /// <summary>
        /// Constructs a custom IssuePhase for a value not among the defined constants.
        /// </summary>
        public IssuePhase(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IssuePhase FindValue(string value)
        {
            return FindValue<IssuePhase>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IssuePhase(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type IssueSeverity.
    /// </summary>
    public class IssueSeverity : ConstantClass
    {
        /// <summary>
        /// Constant CRITICAL for IssueSeverity
        /// </summary>
        public static readonly IssueSeverity CRITICAL = new IssueSeverity("CRITICAL");

        /// <summary>
        /// Constant HIGH for IssueSeverity
        /// </summary>
        public static readonly IssueSeverity HIGH = new IssueSeverity("HIGH");

        /// <summary>
        /// Constant LOW for IssueSeverity
        /// </summary>
        public static readonly IssueSeverity LOW = new IssueSeverity("LOW");

        /// <summary>
        /// Constant MEDIUM for IssueSeverity
        /// </summary>
        public static readonly IssueSeverity MEDIUM = new IssueSeverity("MEDIUM");

        /// <summary>
        /// Constructs a custom IssueSeverity for a value not among the defined constants.
        /// </summary>
        public IssueSeverity(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IssueSeverity FindValue(string value)
        {
            return FindValue<IssueSeverity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IssueSeverity(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type IssueStatus.
    /// </summary>
    public class IssueStatus : ConstantClass
    {
        /// <summary>
        /// Constant COMPLETED for IssueStatus
        /// </summary>
        public static readonly IssueStatus COMPLETED = new IssueStatus("COMPLETED");

        /// <summary>
        /// Constant CREATED for IssueStatus
        /// </summary>
        public static readonly IssueStatus CREATED = new IssueStatus("CREATED");

        /// <summary>
        /// Constant FAILED for IssueStatus
        /// </summary>
        public static readonly IssueStatus FAILED = new IssueStatus("FAILED");

        /// <summary>
        /// Constant IN_PROGRESS for IssueStatus
        /// </summary>
        public static readonly IssueStatus IN_PROGRESS = new IssueStatus("IN_PROGRESS");

        /// <summary>
        /// Constructs a custom IssueStatus for a value not among the defined constants.
        /// </summary>
        public IssueStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IssueStatus FindValue(string value)
        {
            return FindValue<IssueStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IssueStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type IssueStatusReason.
    /// </summary>
    public class IssueStatusReason : ConstantClass
    {
        /// <summary>
        /// Constant INTERNAL_ERROR for IssueStatusReason
        /// </summary>
        public static readonly IssueStatusReason INTERNAL_ERROR = new IssueStatusReason("INTERNAL_ERROR");

        /// <summary>
        /// Constant REMEDIATION_FAILED for IssueStatusReason
        /// </summary>
        public static readonly IssueStatusReason REMEDIATION_FAILED = new IssueStatusReason("REMEDIATION_FAILED");

        /// <summary>
        /// Constructs a custom IssueStatusReason for a value not among the defined constants.
        /// </summary>
        public IssueStatusReason(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IssueStatusReason FindValue(string value)
        {
            return FindValue<IssueStatusReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IssueStatusReason(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type OAuthCodeChallengeMethod.
    /// </summary>
    public class OAuthCodeChallengeMethod : ConstantClass
    {
        /// <summary>
        /// Constant S256 for OAuthCodeChallengeMethod
        /// </summary>
        public static readonly OAuthCodeChallengeMethod S256 = new OAuthCodeChallengeMethod("S256");

        /// <summary>
        /// Constructs a custom OAuthCodeChallengeMethod for a value not among the defined constants.
        /// </summary>
        public OAuthCodeChallengeMethod(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OAuthCodeChallengeMethod FindValue(string value)
        {
            return FindValue<OAuthCodeChallengeMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OAuthCodeChallengeMethod(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type PatchCreationPolicy.
    /// </summary>
    public class PatchCreationPolicy : ConstantClass
    {
        /// <summary>
        /// Constant DISABLED for PatchCreationPolicy
        /// </summary>
        public static readonly PatchCreationPolicy DISABLED = new PatchCreationPolicy("DISABLED");

        /// <summary>
        /// Constant ENABLED for PatchCreationPolicy
        /// </summary>
        public static readonly PatchCreationPolicy ENABLED = new PatchCreationPolicy("ENABLED");

        /// <summary>
        /// Constructs a custom PatchCreationPolicy for a value not among the defined constants.
        /// </summary>
        public PatchCreationPolicy(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PatchCreationPolicy FindValue(string value)
        {
            return FindValue<PatchCreationPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PatchCreationPolicy(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type PatchFormat.
    /// </summary>
    public class PatchFormat : ConstantClass
    {
        /// <summary>
        /// Constant GIT_BINARY_DIFF for PatchFormat
        /// </summary>
        public static readonly PatchFormat GIT_BINARY_DIFF = new PatchFormat("GIT_BINARY_DIFF");

        /// <summary>
        /// Constant GIT_DIFF for PatchFormat
        /// </summary>
        public static readonly PatchFormat GIT_DIFF = new PatchFormat("GIT_DIFF");

        /// <summary>
        /// Constant GIT_MAILBOX_PATCH for PatchFormat
        /// </summary>
        public static readonly PatchFormat GIT_MAILBOX_PATCH = new PatchFormat("GIT_MAILBOX_PATCH");

        /// <summary>
        /// Constructs a custom PatchFormat for a value not among the defined constants.
        /// </summary>
        public PatchFormat(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PatchFormat FindValue(string value)
        {
            return FindValue<PatchFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PatchFormat(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ScanFailureStage.
    /// </summary>
    public class ScanFailureStage : ConstantClass
    {
        /// <summary>
        /// Constant BUILDING for ScanFailureStage
        /// </summary>
        public static readonly ScanFailureStage BUILDING = new ScanFailureStage("BUILDING");

        /// <summary>
        /// Constant SCANNING for ScanFailureStage
        /// </summary>
        public static readonly ScanFailureStage SCANNING = new ScanFailureStage("SCANNING");

        /// <summary>
        /// Constant SUBMITTED for ScanFailureStage
        /// </summary>
        public static readonly ScanFailureStage SUBMITTED = new ScanFailureStage("SUBMITTED");

        /// <summary>
        /// Constant WAITING_FOR_BUILD for ScanFailureStage
        /// </summary>
        public static readonly ScanFailureStage WAITING_FOR_BUILD = new ScanFailureStage("WAITING_FOR_BUILD");

        /// <summary>
        /// Constant WAITING_FOR_SCAN for ScanFailureStage
        /// </summary>
        public static readonly ScanFailureStage WAITING_FOR_SCAN = new ScanFailureStage("WAITING_FOR_SCAN");

        /// <summary>
        /// Constructs a custom ScanFailureStage for a value not among the defined constants.
        /// </summary>
        public ScanFailureStage(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScanFailureStage FindValue(string value)
        {
            return FindValue<ScanFailureStage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScanFailureStage(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ScanOrigin.
    /// </summary>
    public class ScanOrigin : ConstantClass
    {
        /// <summary>
        /// Constant MANUAL for ScanOrigin
        /// </summary>
        public static readonly ScanOrigin MANUAL = new ScanOrigin("MANUAL");

        /// <summary>
        /// Constant SCHEDULED for ScanOrigin
        /// </summary>
        public static readonly ScanOrigin SCHEDULED = new ScanOrigin("SCHEDULED");

        /// <summary>
        /// Constructs a custom ScanOrigin for a value not among the defined constants.
        /// </summary>
        public ScanOrigin(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScanOrigin FindValue(string value)
        {
            return FindValue<ScanOrigin>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScanOrigin(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ScanStatus.
    /// </summary>
    public class ScanStatus : ConstantClass
    {
        /// <summary>
        /// Constant BUILDING for ScanStatus
        /// </summary>
        public static readonly ScanStatus BUILDING = new ScanStatus("BUILDING");

        /// <summary>
        /// Constant FAILED for ScanStatus
        /// </summary>
        public static readonly ScanStatus FAILED = new ScanStatus("FAILED");

        /// <summary>
        /// Constant SCANNING for ScanStatus
        /// </summary>
        public static readonly ScanStatus SCANNING = new ScanStatus("SCANNING");

        /// <summary>
        /// Constant SUBMITTED for ScanStatus
        /// </summary>
        public static readonly ScanStatus SUBMITTED = new ScanStatus("SUBMITTED");

        /// <summary>
        /// Constant SUCCEEDED for ScanStatus
        /// </summary>
        public static readonly ScanStatus SUCCEEDED = new ScanStatus("SUCCEEDED");

        /// <summary>
        /// Constant WAITING_FOR_BUILD for ScanStatus
        /// </summary>
        public static readonly ScanStatus WAITING_FOR_BUILD = new ScanStatus("WAITING_FOR_BUILD");

        /// <summary>
        /// Constant WAITING_FOR_SCAN for ScanStatus
        /// </summary>
        public static readonly ScanStatus WAITING_FOR_SCAN = new ScanStatus("WAITING_FOR_SCAN");

        /// <summary>
        /// Constructs a custom ScanStatus for a value not among the defined constants.
        /// </summary>
        public ScanStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScanStatus FindValue(string value)
        {
            return FindValue<ScanStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScanStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SignalAccessLevel.
    /// </summary>
    public class SignalAccessLevel : ConstantClass
    {
        /// <summary>
        /// Constant ANY_AUTHENTICATED for SignalAccessLevel
        /// </summary>
        public static readonly SignalAccessLevel ANY_AUTHENTICATED = new SignalAccessLevel("ANY_AUTHENTICATED");

        /// <summary>
        /// Constant NONE for SignalAccessLevel
        /// </summary>
        public static readonly SignalAccessLevel NONE = new SignalAccessLevel("NONE");

        /// <summary>
        /// Constant PRIVILEGED for SignalAccessLevel
        /// </summary>
        public static readonly SignalAccessLevel PRIVILEGED = new SignalAccessLevel("PRIVILEGED");

        /// <summary>
        /// Constructs a custom SignalAccessLevel for a value not among the defined constants.
        /// </summary>
        public SignalAccessLevel(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SignalAccessLevel FindValue(string value)
        {
            return FindValue<SignalAccessLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SignalAccessLevel(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SignalAttackerGains.
    /// </summary>
    public class SignalAttackerGains : ConstantClass
    {
        /// <summary>
        /// Constant EXECUTE for SignalAttackerGains
        /// </summary>
        public static readonly SignalAttackerGains EXECUTE = new SignalAttackerGains("EXECUTE");

        /// <summary>
        /// Constant MODIFY_COSMETIC for SignalAttackerGains
        /// </summary>
        public static readonly SignalAttackerGains MODIFY_COSMETIC = new SignalAttackerGains("MODIFY_COSMETIC");

        /// <summary>
        /// Constant MODIFY_DATA for SignalAttackerGains
        /// </summary>
        public static readonly SignalAttackerGains MODIFY_DATA = new SignalAttackerGains("MODIFY_DATA");

        /// <summary>
        /// Constant MODIFY_PRIVILEGED for SignalAttackerGains
        /// </summary>
        public static readonly SignalAttackerGains MODIFY_PRIVILEGED = new SignalAttackerGains("MODIFY_PRIVILEGED");

        /// <summary>
        /// Constant NEITHER for SignalAttackerGains
        /// </summary>
        public static readonly SignalAttackerGains NEITHER = new SignalAttackerGains("NEITHER");

        /// <summary>
        /// Constant READ for SignalAttackerGains
        /// </summary>
        public static readonly SignalAttackerGains READ = new SignalAttackerGains("READ");

        /// <summary>
        /// Constructs a custom SignalAttackerGains for a value not among the defined constants.
        /// </summary>
        public SignalAttackerGains(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SignalAttackerGains FindValue(string value)
        {
            return FindValue<SignalAttackerGains>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SignalAttackerGains(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SignalBand.
    /// </summary>
    public class SignalBand : ConstantClass
    {
        /// <summary>
        /// Constant HIGH for SignalBand
        /// </summary>
        public static readonly SignalBand HIGH = new SignalBand("HIGH");

        /// <summary>
        /// Constant LOW for SignalBand
        /// </summary>
        public static readonly SignalBand LOW = new SignalBand("LOW");

        /// <summary>
        /// Constant MODERATE for SignalBand
        /// </summary>
        public static readonly SignalBand MODERATE = new SignalBand("MODERATE");

        /// <summary>
        /// Constant VERY_LOW for SignalBand
        /// </summary>
        public static readonly SignalBand VERY_LOW = new SignalBand("VERY_LOW");

        /// <summary>
        /// Constructs a custom SignalBand for a value not among the defined constants.
        /// </summary>
        public SignalBand(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SignalBand FindValue(string value)
        {
            return FindValue<SignalBand>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SignalBand(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SignalBasis.
    /// </summary>
    public class SignalBasis : ConstantClass
    {
        /// <summary>
        /// Constant CODE for SignalBasis
        /// </summary>
        public static readonly SignalBasis CODE = new SignalBasis("CODE");

        /// <summary>
        /// Constant FINDING for SignalBasis
        /// </summary>
        public static readonly SignalBasis FINDING = new SignalBasis("FINDING");

        /// <summary>
        /// Constant GRAPH for SignalBasis
        /// </summary>
        public static readonly SignalBasis GRAPH = new SignalBasis("GRAPH");

        /// <summary>
        /// Constant INFERRED for SignalBasis
        /// </summary>
        public static readonly SignalBasis INFERRED = new SignalBasis("INFERRED");

        /// <summary>
        /// Constant NO_EVIDENCE_DEFAULT for SignalBasis
        /// </summary>
        public static readonly SignalBasis NO_EVIDENCE_DEFAULT = new SignalBasis("NO_EVIDENCE_DEFAULT");

        /// <summary>
        /// Constructs a custom SignalBasis for a value not among the defined constants.
        /// </summary>
        public SignalBasis(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SignalBasis FindValue(string value)
        {
            return FindValue<SignalBasis>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SignalBasis(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SignalBlastRadius.
    /// </summary>
    public class SignalBlastRadius : ConstantClass
    {
        /// <summary>
        /// Constant CROSS_TENANT for SignalBlastRadius
        /// </summary>
        public static readonly SignalBlastRadius CROSS_TENANT = new SignalBlastRadius("CROSS_TENANT");

        /// <summary>
        /// Constant OTHER_USERS_IN_TENANT for SignalBlastRadius
        /// </summary>
        public static readonly SignalBlastRadius OTHER_USERS_IN_TENANT = new SignalBlastRadius("OTHER_USERS_IN_TENANT");

        /// <summary>
        /// Constant OWN_SCOPE for SignalBlastRadius
        /// </summary>
        public static readonly SignalBlastRadius OWN_SCOPE = new SignalBlastRadius("OWN_SCOPE");

        /// <summary>
        /// Constructs a custom SignalBlastRadius for a value not among the defined constants.
        /// </summary>
        public SignalBlastRadius(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SignalBlastRadius FindValue(string value)
        {
            return FindValue<SignalBlastRadius>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SignalBlastRadius(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SignalDimension.
    /// </summary>
    public class SignalDimension : ConstantClass
    {
        /// <summary>
        /// Constant BLAST_RADIUS for SignalDimension
        /// </summary>
        public static readonly SignalDimension BLAST_RADIUS = new SignalDimension("BLAST_RADIUS");

        /// <summary>
        /// Constant CODE_CONTEXT for SignalDimension
        /// </summary>
        public static readonly SignalDimension CODE_CONTEXT = new SignalDimension("CODE_CONTEXT");

        /// <summary>
        /// Constant EXPLOITABILITY for SignalDimension
        /// </summary>
        public static readonly SignalDimension EXPLOITABILITY = new SignalDimension("EXPLOITABILITY");

        /// <summary>
        /// Constant IMPACT_ASSESSMENT for SignalDimension
        /// </summary>
        public static readonly SignalDimension IMPACT_ASSESSMENT = new SignalDimension("IMPACT_ASSESSMENT");

        /// <summary>
        /// Constant LIKELIHOOD_ASSESSMENT for SignalDimension
        /// </summary>
        public static readonly SignalDimension LIKELIHOOD_ASSESSMENT = new SignalDimension("LIKELIHOOD_ASSESSMENT");

        /// <summary>
        /// Constant NETWORK_EXPOSURE for SignalDimension
        /// </summary>
        public static readonly SignalDimension NETWORK_EXPOSURE = new SignalDimension("NETWORK_EXPOSURE");

        /// <summary>
        /// Constant PRECONDITION for SignalDimension
        /// </summary>
        public static readonly SignalDimension PRECONDITION = new SignalDimension("PRECONDITION");

        /// <summary>
        /// Constructs a custom SignalDimension for a value not among the defined constants.
        /// </summary>
        public SignalDimension(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SignalDimension FindValue(string value)
        {
            return FindValue<SignalDimension>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SignalDimension(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SignalStrength.
    /// </summary>
    public class SignalStrength : ConstantClass
    {
        /// <summary>
        /// Constant MODERATE for SignalStrength
        /// </summary>
        public static readonly SignalStrength MODERATE = new SignalStrength("MODERATE");

        /// <summary>
        /// Constant NONE for SignalStrength
        /// </summary>
        public static readonly SignalStrength NONE = new SignalStrength("NONE");

        /// <summary>
        /// Constant STRONG for SignalStrength
        /// </summary>
        public static readonly SignalStrength STRONG = new SignalStrength("STRONG");

        /// <summary>
        /// Constant WEAK for SignalStrength
        /// </summary>
        public static readonly SignalStrength WEAK = new SignalStrength("WEAK");

        /// <summary>
        /// Constructs a custom SignalStrength for a value not among the defined constants.
        /// </summary>
        public SignalStrength(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SignalStrength FindValue(string value)
        {
            return FindValue<SignalStrength>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SignalStrength(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SignalTargetValue.
    /// </summary>
    public class SignalTargetValue : ConstantClass
    {
        /// <summary>
        /// Constant HIGH for SignalTargetValue
        /// </summary>
        public static readonly SignalTargetValue HIGH = new SignalTargetValue("HIGH");

        /// <summary>
        /// Constant LOW for SignalTargetValue
        /// </summary>
        public static readonly SignalTargetValue LOW = new SignalTargetValue("LOW");

        /// <summary>
        /// Constant MEDIUM for SignalTargetValue
        /// </summary>
        public static readonly SignalTargetValue MEDIUM = new SignalTargetValue("MEDIUM");

        /// <summary>
        /// Constructs a custom SignalTargetValue for a value not among the defined constants.
        /// </summary>
        public SignalTargetValue(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SignalTargetValue FindValue(string value)
        {
            return FindValue<SignalTargetValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SignalTargetValue(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ValidationConfidenceTier.
    /// </summary>
    public class ValidationConfidenceTier : ConstantClass
    {
        /// <summary>
        /// Constant BUILD_PROVEN for ValidationConfidenceTier
        /// </summary>
        public static readonly ValidationConfidenceTier BUILD_PROVEN = new ValidationConfidenceTier("BUILD_PROVEN");

        /// <summary>
        /// Constant RUNTIME_PROVEN for ValidationConfidenceTier
        /// </summary>
        public static readonly ValidationConfidenceTier RUNTIME_PROVEN = new ValidationConfidenceTier("RUNTIME_PROVEN");

        /// <summary>
        /// Constant SOURCE_READ for ValidationConfidenceTier
        /// </summary>
        public static readonly ValidationConfidenceTier SOURCE_READ = new ValidationConfidenceTier("SOURCE_READ");

        /// <summary>
        /// Constant STATIC_PROVEN for ValidationConfidenceTier
        /// </summary>
        public static readonly ValidationConfidenceTier STATIC_PROVEN = new ValidationConfidenceTier("STATIC_PROVEN");

        /// <summary>
        /// Constructs a custom ValidationConfidenceTier for a value not among the defined constants.
        /// </summary>
        public ValidationConfidenceTier(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationConfidenceTier FindValue(string value)
        {
            return FindValue<ValidationConfidenceTier>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationConfidenceTier(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ValidationTerminalStatus.
    /// </summary>
    public class ValidationTerminalStatus : ConstantClass
    {
        /// <summary>
        /// Constant COMPLETED for ValidationTerminalStatus
        /// </summary>
        public static readonly ValidationTerminalStatus COMPLETED = new ValidationTerminalStatus("COMPLETED");

        /// <summary>
        /// Constant FAILED for ValidationTerminalStatus
        /// </summary>
        public static readonly ValidationTerminalStatus FAILED = new ValidationTerminalStatus("FAILED");

        /// <summary>
        /// Constant NO_SOURCE_AVAILABLE for ValidationTerminalStatus
        /// </summary>
        public static readonly ValidationTerminalStatus NO_SOURCE_AVAILABLE = new ValidationTerminalStatus("NO_SOURCE_AVAILABLE");

        /// <summary>
        /// Constant PARTIAL for ValidationTerminalStatus
        /// </summary>
        public static readonly ValidationTerminalStatus PARTIAL = new ValidationTerminalStatus("PARTIAL");

        /// <summary>
        /// Constructs a custom ValidationTerminalStatus for a value not among the defined constants.
        /// </summary>
        public ValidationTerminalStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationTerminalStatus FindValue(string value)
        {
            return FindValue<ValidationTerminalStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationTerminalStatus(string value)
        {
            return FindValue(value);
        }
    }
}
