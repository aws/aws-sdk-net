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

namespace Amazon.Synthetics
{
    /// <summary>
    /// Constants used for properties of type BrowserType.
    /// </summary>
    public class BrowserType : ConstantClass
    {
        /// <summary>
        /// Constant CHROME for BrowserType
        /// </summary>
        public static readonly BrowserType CHROME = new BrowserType("CHROME");

        /// <summary>
        /// Constant FIREFOX for BrowserType
        /// </summary>
        public static readonly BrowserType FIREFOX = new BrowserType("FIREFOX");

        /// <summary>
        /// Constructs a custom BrowserType for a value not among the defined constants.
        /// </summary>
        public BrowserType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BrowserType FindValue(string value)
        {
            return FindValue<BrowserType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BrowserType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type CanaryRunState.
    /// </summary>
    public class CanaryRunState : ConstantClass
    {
        /// <summary>
        /// Constant FAILED for CanaryRunState
        /// </summary>
        public static readonly CanaryRunState FAILED = new CanaryRunState("FAILED");

        /// <summary>
        /// Constant PASSED for CanaryRunState
        /// </summary>
        public static readonly CanaryRunState PASSED = new CanaryRunState("PASSED");

        /// <summary>
        /// Constant RUNNING for CanaryRunState
        /// </summary>
        public static readonly CanaryRunState RUNNING = new CanaryRunState("RUNNING");

        /// <summary>
        /// Constructs a custom CanaryRunState for a value not among the defined constants.
        /// </summary>
        public CanaryRunState(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CanaryRunState FindValue(string value)
        {
            return FindValue<CanaryRunState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CanaryRunState(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type CanaryRunStateReasonCode.
    /// </summary>
    public class CanaryRunStateReasonCode : ConstantClass
    {
        /// <summary>
        /// Constant CANARY_FAILURE for CanaryRunStateReasonCode
        /// </summary>
        public static readonly CanaryRunStateReasonCode CANARY_FAILURE = new CanaryRunStateReasonCode("CANARY_FAILURE");

        /// <summary>
        /// Constant EXECUTION_FAILURE for CanaryRunStateReasonCode
        /// </summary>
        public static readonly CanaryRunStateReasonCode EXECUTION_FAILURE = new CanaryRunStateReasonCode("EXECUTION_FAILURE");

        /// <summary>
        /// Constructs a custom CanaryRunStateReasonCode for a value not among the defined constants.
        /// </summary>
        public CanaryRunStateReasonCode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CanaryRunStateReasonCode FindValue(string value)
        {
            return FindValue<CanaryRunStateReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CanaryRunStateReasonCode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type CanaryRunTestResult.
    /// </summary>
    public class CanaryRunTestResult : ConstantClass
    {
        /// <summary>
        /// Constant FAILED for CanaryRunTestResult
        /// </summary>
        public static readonly CanaryRunTestResult FAILED = new CanaryRunTestResult("FAILED");

        /// <summary>
        /// Constant PASSED for CanaryRunTestResult
        /// </summary>
        public static readonly CanaryRunTestResult PASSED = new CanaryRunTestResult("PASSED");

        /// <summary>
        /// Constant UNKNOWN for CanaryRunTestResult
        /// </summary>
        public static readonly CanaryRunTestResult UNKNOWN = new CanaryRunTestResult("UNKNOWN");

        /// <summary>
        /// Constructs a custom CanaryRunTestResult for a value not among the defined constants.
        /// </summary>
        public CanaryRunTestResult(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CanaryRunTestResult FindValue(string value)
        {
            return FindValue<CanaryRunTestResult>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CanaryRunTestResult(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type CanaryState.
    /// </summary>
    public class CanaryState : ConstantClass
    {
        /// <summary>
        /// Constant CREATING for CanaryState
        /// </summary>
        public static readonly CanaryState CREATING = new CanaryState("CREATING");

        /// <summary>
        /// Constant DELETING for CanaryState
        /// </summary>
        public static readonly CanaryState DELETING = new CanaryState("DELETING");

        /// <summary>
        /// Constant ERROR for CanaryState
        /// </summary>
        public static readonly CanaryState ERROR = new CanaryState("ERROR");

        /// <summary>
        /// Constant READY for CanaryState
        /// </summary>
        public static readonly CanaryState READY = new CanaryState("READY");

        /// <summary>
        /// Constant RUNNING for CanaryState
        /// </summary>
        public static readonly CanaryState RUNNING = new CanaryState("RUNNING");

        /// <summary>
        /// Constant STARTING for CanaryState
        /// </summary>
        public static readonly CanaryState STARTING = new CanaryState("STARTING");

        /// <summary>
        /// Constant STOPPED for CanaryState
        /// </summary>
        public static readonly CanaryState STOPPED = new CanaryState("STOPPED");

        /// <summary>
        /// Constant STOPPING for CanaryState
        /// </summary>
        public static readonly CanaryState STOPPING = new CanaryState("STOPPING");

        /// <summary>
        /// Constant UPDATING for CanaryState
        /// </summary>
        public static readonly CanaryState UPDATING = new CanaryState("UPDATING");

        /// <summary>
        /// Constructs a custom CanaryState for a value not among the defined constants.
        /// </summary>
        public CanaryState(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CanaryState FindValue(string value)
        {
            return FindValue<CanaryState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CanaryState(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type CanaryStateReasonCode.
    /// </summary>
    public class CanaryStateReasonCode : ConstantClass
    {
        /// <summary>
        /// Constant CREATE_FAILED for CanaryStateReasonCode
        /// </summary>
        public static readonly CanaryStateReasonCode CREATE_FAILED = new CanaryStateReasonCode("CREATE_FAILED");

        /// <summary>
        /// Constant CREATE_IN_PROGRESS for CanaryStateReasonCode
        /// </summary>
        public static readonly CanaryStateReasonCode CREATE_IN_PROGRESS = new CanaryStateReasonCode("CREATE_IN_PROGRESS");

        /// <summary>
        /// Constant CREATE_PENDING for CanaryStateReasonCode
        /// </summary>
        public static readonly CanaryStateReasonCode CREATE_PENDING = new CanaryStateReasonCode("CREATE_PENDING");

        /// <summary>
        /// Constant DELETE_FAILED for CanaryStateReasonCode
        /// </summary>
        public static readonly CanaryStateReasonCode DELETE_FAILED = new CanaryStateReasonCode("DELETE_FAILED");

        /// <summary>
        /// Constant DELETE_IN_PROGRESS for CanaryStateReasonCode
        /// </summary>
        public static readonly CanaryStateReasonCode DELETE_IN_PROGRESS = new CanaryStateReasonCode("DELETE_IN_PROGRESS");

        /// <summary>
        /// Constant INVALID_PERMISSIONS for CanaryStateReasonCode
        /// </summary>
        public static readonly CanaryStateReasonCode INVALID_PERMISSIONS = new CanaryStateReasonCode("INVALID_PERMISSIONS");

        /// <summary>
        /// Constant ROLLBACK_COMPLETE for CanaryStateReasonCode
        /// </summary>
        public static readonly CanaryStateReasonCode ROLLBACK_COMPLETE = new CanaryStateReasonCode("ROLLBACK_COMPLETE");

        /// <summary>
        /// Constant ROLLBACK_FAILED for CanaryStateReasonCode
        /// </summary>
        public static readonly CanaryStateReasonCode ROLLBACK_FAILED = new CanaryStateReasonCode("ROLLBACK_FAILED");

        /// <summary>
        /// Constant SYNC_DELETE_IN_PROGRESS for CanaryStateReasonCode
        /// </summary>
        public static readonly CanaryStateReasonCode SYNC_DELETE_IN_PROGRESS = new CanaryStateReasonCode("SYNC_DELETE_IN_PROGRESS");

        /// <summary>
        /// Constant UPDATE_COMPLETE for CanaryStateReasonCode
        /// </summary>
        public static readonly CanaryStateReasonCode UPDATE_COMPLETE = new CanaryStateReasonCode("UPDATE_COMPLETE");

        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for CanaryStateReasonCode
        /// </summary>
        public static readonly CanaryStateReasonCode UPDATE_IN_PROGRESS = new CanaryStateReasonCode("UPDATE_IN_PROGRESS");

        /// <summary>
        /// Constant UPDATE_PENDING for CanaryStateReasonCode
        /// </summary>
        public static readonly CanaryStateReasonCode UPDATE_PENDING = new CanaryStateReasonCode("UPDATE_PENDING");

        /// <summary>
        /// Constructs a custom CanaryStateReasonCode for a value not among the defined constants.
        /// </summary>
        public CanaryStateReasonCode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CanaryStateReasonCode FindValue(string value)
        {
            return FindValue<CanaryStateReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CanaryStateReasonCode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DependencyType.
    /// </summary>
    public class DependencyType : ConstantClass
    {
        /// <summary>
        /// Constant LambdaLayer for DependencyType
        /// </summary>
        public static readonly DependencyType LambdaLayer = new DependencyType("LambdaLayer");

        /// <summary>
        /// Constructs a custom DependencyType for a value not among the defined constants.
        /// </summary>
        public DependencyType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DependencyType FindValue(string value)
        {
            return FindValue<DependencyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DependencyType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type EncryptionMode.
    /// </summary>
    public class EncryptionMode : ConstantClass
    {
        /// <summary>
        /// Constant SSE_KMS for EncryptionMode
        /// </summary>
        public static readonly EncryptionMode SSE_KMS = new EncryptionMode("SSE_KMS");

        /// <summary>
        /// Constant SSE_S3 for EncryptionMode
        /// </summary>
        public static readonly EncryptionMode SSE_S3 = new EncryptionMode("SSE_S3");

        /// <summary>
        /// Constructs a custom EncryptionMode for a value not among the defined constants.
        /// </summary>
        public EncryptionMode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionMode FindValue(string value)
        {
            return FindValue<EncryptionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionMode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type LocationType.
    /// </summary>
    public class LocationType : ConstantClass
    {
        /// <summary>
        /// Constant Primary for LocationType
        /// </summary>
        public static readonly LocationType Primary = new LocationType("Primary");

        /// <summary>
        /// Constant Replica for LocationType
        /// </summary>
        public static readonly LocationType Replica = new LocationType("Replica");

        /// <summary>
        /// Constructs a custom LocationType for a value not among the defined constants.
        /// </summary>
        public LocationType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LocationType FindValue(string value)
        {
            return FindValue<LocationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LocationType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ProvisionedResourceCleanupSetting.
    /// </summary>
    public class ProvisionedResourceCleanupSetting : ConstantClass
    {
        /// <summary>
        /// Constant AUTOMATIC for ProvisionedResourceCleanupSetting
        /// </summary>
        public static readonly ProvisionedResourceCleanupSetting AUTOMATIC = new ProvisionedResourceCleanupSetting("AUTOMATIC");

        /// <summary>
        /// Constant OFF for ProvisionedResourceCleanupSetting
        /// </summary>
        public static readonly ProvisionedResourceCleanupSetting OFF = new ProvisionedResourceCleanupSetting("OFF");

        /// <summary>
        /// Constructs a custom ProvisionedResourceCleanupSetting for a value not among the defined constants.
        /// </summary>
        public ProvisionedResourceCleanupSetting(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProvisionedResourceCleanupSetting FindValue(string value)
        {
            return FindValue<ProvisionedResourceCleanupSetting>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProvisionedResourceCleanupSetting(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ReplicationState.
    /// </summary>
    public class ReplicationState : ConstantClass
    {
        /// <summary>
        /// Constant InProgress for ReplicationState
        /// </summary>
        public static readonly ReplicationState InProgress = new ReplicationState("InProgress");

        /// <summary>
        /// Constant InSync for ReplicationState
        /// </summary>
        public static readonly ReplicationState InSync = new ReplicationState("InSync");

        /// <summary>
        /// Constant Inconsistent for ReplicationState
        /// </summary>
        public static readonly ReplicationState Inconsistent = new ReplicationState("Inconsistent");

        /// <summary>
        /// Constructs a custom ReplicationState for a value not among the defined constants.
        /// </summary>
        public ReplicationState(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicationState FindValue(string value)
        {
            return FindValue<ReplicationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicationState(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ResourceToTag.
    /// </summary>
    public class ResourceToTag : ConstantClass
    {
        /// <summary>
        /// Constant LambdaFunction for ResourceToTag
        /// </summary>
        public static readonly ResourceToTag LambdaFunction = new ResourceToTag("lambda-function");

        /// <summary>
        /// Constructs a custom ResourceToTag for a value not among the defined constants.
        /// </summary>
        public ResourceToTag(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceToTag FindValue(string value)
        {
            return FindValue<ResourceToTag>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceToTag(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type RunType.
    /// </summary>
    public class RunType : ConstantClass
    {
        /// <summary>
        /// Constant CANARY_RUN for RunType
        /// </summary>
        public static readonly RunType CANARY_RUN = new RunType("CANARY_RUN");

        /// <summary>
        /// Constant DRY_RUN for RunType
        /// </summary>
        public static readonly RunType DRY_RUN = new RunType("DRY_RUN");

        /// <summary>
        /// Constructs a custom RunType for a value not among the defined constants.
        /// </summary>
        public RunType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RunType FindValue(string value)
        {
            return FindValue<RunType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RunType(string value)
        {
            return FindValue(value);
        }
    }
}
