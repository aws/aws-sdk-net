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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SimpleSystemsManagement
{

    /// <summary>
    /// Constants used for properties of type AssociationComplianceSeverity.
    /// </summary>
    public class AssociationComplianceSeverity : ConstantClass
    {

        /// <summary>
        /// Constant CRITICAL for AssociationComplianceSeverity
        /// </summary>
        public static readonly AssociationComplianceSeverity CRITICAL = new AssociationComplianceSeverity("CRITICAL");
        /// <summary>
        /// Constant HIGH for AssociationComplianceSeverity
        /// </summary>
        public static readonly AssociationComplianceSeverity HIGH = new AssociationComplianceSeverity("HIGH");
        /// <summary>
        /// Constant LOW for AssociationComplianceSeverity
        /// </summary>
        public static readonly AssociationComplianceSeverity LOW = new AssociationComplianceSeverity("LOW");
        /// <summary>
        /// Constant MEDIUM for AssociationComplianceSeverity
        /// </summary>
        public static readonly AssociationComplianceSeverity MEDIUM = new AssociationComplianceSeverity("MEDIUM");
        /// <summary>
        /// Constant UNSPECIFIED for AssociationComplianceSeverity
        /// </summary>
        public static readonly AssociationComplianceSeverity UNSPECIFIED = new AssociationComplianceSeverity("UNSPECIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssociationComplianceSeverity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssociationComplianceSeverity FindValue(string value)
        {
            return FindValue<AssociationComplianceSeverity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssociationComplianceSeverity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssociationExecutionFilterKey.
    /// </summary>
    public class AssociationExecutionFilterKey : ConstantClass
    {

        /// <summary>
        /// Constant CreatedTime for AssociationExecutionFilterKey
        /// </summary>
        public static readonly AssociationExecutionFilterKey CreatedTime = new AssociationExecutionFilterKey("CreatedTime");
        /// <summary>
        /// Constant ExecutionId for AssociationExecutionFilterKey
        /// </summary>
        public static readonly AssociationExecutionFilterKey ExecutionId = new AssociationExecutionFilterKey("ExecutionId");
        /// <summary>
        /// Constant Status for AssociationExecutionFilterKey
        /// </summary>
        public static readonly AssociationExecutionFilterKey Status = new AssociationExecutionFilterKey("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssociationExecutionFilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssociationExecutionFilterKey FindValue(string value)
        {
            return FindValue<AssociationExecutionFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssociationExecutionFilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssociationExecutionTargetsFilterKey.
    /// </summary>
    public class AssociationExecutionTargetsFilterKey : ConstantClass
    {

        /// <summary>
        /// Constant ResourceId for AssociationExecutionTargetsFilterKey
        /// </summary>
        public static readonly AssociationExecutionTargetsFilterKey ResourceId = new AssociationExecutionTargetsFilterKey("ResourceId");
        /// <summary>
        /// Constant ResourceType for AssociationExecutionTargetsFilterKey
        /// </summary>
        public static readonly AssociationExecutionTargetsFilterKey ResourceType = new AssociationExecutionTargetsFilterKey("ResourceType");
        /// <summary>
        /// Constant Status for AssociationExecutionTargetsFilterKey
        /// </summary>
        public static readonly AssociationExecutionTargetsFilterKey Status = new AssociationExecutionTargetsFilterKey("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssociationExecutionTargetsFilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssociationExecutionTargetsFilterKey FindValue(string value)
        {
            return FindValue<AssociationExecutionTargetsFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssociationExecutionTargetsFilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssociationFilterKey.
    /// </summary>
    public class AssociationFilterKey : ConstantClass
    {

        /// <summary>
        /// Constant AssociationId for AssociationFilterKey
        /// </summary>
        public static readonly AssociationFilterKey AssociationId = new AssociationFilterKey("AssociationId");
        /// <summary>
        /// Constant AssociationName for AssociationFilterKey
        /// </summary>
        public static readonly AssociationFilterKey AssociationName = new AssociationFilterKey("AssociationName");
        /// <summary>
        /// Constant AssociationStatusName for AssociationFilterKey
        /// </summary>
        public static readonly AssociationFilterKey AssociationStatusName = new AssociationFilterKey("AssociationStatusName");
        /// <summary>
        /// Constant InstanceId for AssociationFilterKey
        /// </summary>
        public static readonly AssociationFilterKey InstanceId = new AssociationFilterKey("InstanceId");
        /// <summary>
        /// Constant LastExecutedAfter for AssociationFilterKey
        /// </summary>
        public static readonly AssociationFilterKey LastExecutedAfter = new AssociationFilterKey("LastExecutedAfter");
        /// <summary>
        /// Constant LastExecutedBefore for AssociationFilterKey
        /// </summary>
        public static readonly AssociationFilterKey LastExecutedBefore = new AssociationFilterKey("LastExecutedBefore");
        /// <summary>
        /// Constant Name for AssociationFilterKey
        /// </summary>
        public static readonly AssociationFilterKey Name = new AssociationFilterKey("Name");
        /// <summary>
        /// Constant ResourceGroupName for AssociationFilterKey
        /// </summary>
        public static readonly AssociationFilterKey ResourceGroupName = new AssociationFilterKey("ResourceGroupName");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssociationFilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssociationFilterKey FindValue(string value)
        {
            return FindValue<AssociationFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssociationFilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssociationFilterOperatorType.
    /// </summary>
    public class AssociationFilterOperatorType : ConstantClass
    {

        /// <summary>
        /// Constant EQUAL for AssociationFilterOperatorType
        /// </summary>
        public static readonly AssociationFilterOperatorType EQUAL = new AssociationFilterOperatorType("EQUAL");
        /// <summary>
        /// Constant GREATER_THAN for AssociationFilterOperatorType
        /// </summary>
        public static readonly AssociationFilterOperatorType GREATER_THAN = new AssociationFilterOperatorType("GREATER_THAN");
        /// <summary>
        /// Constant LESS_THAN for AssociationFilterOperatorType
        /// </summary>
        public static readonly AssociationFilterOperatorType LESS_THAN = new AssociationFilterOperatorType("LESS_THAN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssociationFilterOperatorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssociationFilterOperatorType FindValue(string value)
        {
            return FindValue<AssociationFilterOperatorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssociationFilterOperatorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssociationStatusName.
    /// </summary>
    public class AssociationStatusName : ConstantClass
    {

        /// <summary>
        /// Constant Failed for AssociationStatusName
        /// </summary>
        public static readonly AssociationStatusName Failed = new AssociationStatusName("Failed");
        /// <summary>
        /// Constant Pending for AssociationStatusName
        /// </summary>
        public static readonly AssociationStatusName Pending = new AssociationStatusName("Pending");
        /// <summary>
        /// Constant Success for AssociationStatusName
        /// </summary>
        public static readonly AssociationStatusName Success = new AssociationStatusName("Success");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssociationStatusName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssociationStatusName FindValue(string value)
        {
            return FindValue<AssociationStatusName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssociationStatusName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssociationSyncCompliance.
    /// </summary>
    public class AssociationSyncCompliance : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for AssociationSyncCompliance
        /// </summary>
        public static readonly AssociationSyncCompliance AUTO = new AssociationSyncCompliance("AUTO");
        /// <summary>
        /// Constant MANUAL for AssociationSyncCompliance
        /// </summary>
        public static readonly AssociationSyncCompliance MANUAL = new AssociationSyncCompliance("MANUAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssociationSyncCompliance(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssociationSyncCompliance FindValue(string value)
        {
            return FindValue<AssociationSyncCompliance>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssociationSyncCompliance(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AttachmentHashType.
    /// </summary>
    public class AttachmentHashType : ConstantClass
    {

        /// <summary>
        /// Constant Sha256 for AttachmentHashType
        /// </summary>
        public static readonly AttachmentHashType Sha256 = new AttachmentHashType("Sha256");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AttachmentHashType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttachmentHashType FindValue(string value)
        {
            return FindValue<AttachmentHashType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AttachmentHashType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AttachmentsSourceKey.
    /// </summary>
    public class AttachmentsSourceKey : ConstantClass
    {

        /// <summary>
        /// Constant AttachmentReference for AttachmentsSourceKey
        /// </summary>
        public static readonly AttachmentsSourceKey AttachmentReference = new AttachmentsSourceKey("AttachmentReference");
        /// <summary>
        /// Constant S3FileUrl for AttachmentsSourceKey
        /// </summary>
        public static readonly AttachmentsSourceKey S3FileUrl = new AttachmentsSourceKey("S3FileUrl");
        /// <summary>
        /// Constant SourceUrl for AttachmentsSourceKey
        /// </summary>
        public static readonly AttachmentsSourceKey SourceUrl = new AttachmentsSourceKey("SourceUrl");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AttachmentsSourceKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttachmentsSourceKey FindValue(string value)
        {
            return FindValue<AttachmentsSourceKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AttachmentsSourceKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutomationExecutionFilterKey.
    /// </summary>
    public class AutomationExecutionFilterKey : ConstantClass
    {

        /// <summary>
        /// Constant AutomationSubtype for AutomationExecutionFilterKey
        /// </summary>
        public static readonly AutomationExecutionFilterKey AutomationSubtype = new AutomationExecutionFilterKey("AutomationSubtype");
        /// <summary>
        /// Constant AutomationType for AutomationExecutionFilterKey
        /// </summary>
        public static readonly AutomationExecutionFilterKey AutomationType = new AutomationExecutionFilterKey("AutomationType");
        /// <summary>
        /// Constant CurrentAction for AutomationExecutionFilterKey
        /// </summary>
        public static readonly AutomationExecutionFilterKey CurrentAction = new AutomationExecutionFilterKey("CurrentAction");
        /// <summary>
        /// Constant DocumentNamePrefix for AutomationExecutionFilterKey
        /// </summary>
        public static readonly AutomationExecutionFilterKey DocumentNamePrefix = new AutomationExecutionFilterKey("DocumentNamePrefix");
        /// <summary>
        /// Constant ExecutionId for AutomationExecutionFilterKey
        /// </summary>
        public static readonly AutomationExecutionFilterKey ExecutionId = new AutomationExecutionFilterKey("ExecutionId");
        /// <summary>
        /// Constant ExecutionStatus for AutomationExecutionFilterKey
        /// </summary>
        public static readonly AutomationExecutionFilterKey ExecutionStatus = new AutomationExecutionFilterKey("ExecutionStatus");
        /// <summary>
        /// Constant OpsItemId for AutomationExecutionFilterKey
        /// </summary>
        public static readonly AutomationExecutionFilterKey OpsItemId = new AutomationExecutionFilterKey("OpsItemId");
        /// <summary>
        /// Constant ParentExecutionId for AutomationExecutionFilterKey
        /// </summary>
        public static readonly AutomationExecutionFilterKey ParentExecutionId = new AutomationExecutionFilterKey("ParentExecutionId");
        /// <summary>
        /// Constant StartTimeAfter for AutomationExecutionFilterKey
        /// </summary>
        public static readonly AutomationExecutionFilterKey StartTimeAfter = new AutomationExecutionFilterKey("StartTimeAfter");
        /// <summary>
        /// Constant StartTimeBefore for AutomationExecutionFilterKey
        /// </summary>
        public static readonly AutomationExecutionFilterKey StartTimeBefore = new AutomationExecutionFilterKey("StartTimeBefore");
        /// <summary>
        /// Constant TagKey for AutomationExecutionFilterKey
        /// </summary>
        public static readonly AutomationExecutionFilterKey TagKey = new AutomationExecutionFilterKey("TagKey");
        /// <summary>
        /// Constant TargetResourceGroup for AutomationExecutionFilterKey
        /// </summary>
        public static readonly AutomationExecutionFilterKey TargetResourceGroup = new AutomationExecutionFilterKey("TargetResourceGroup");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutomationExecutionFilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutomationExecutionFilterKey FindValue(string value)
        {
            return FindValue<AutomationExecutionFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutomationExecutionFilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutomationExecutionStatus.
    /// </summary>
    public class AutomationExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Approved for AutomationExecutionStatus
        /// </summary>
        public static readonly AutomationExecutionStatus Approved = new AutomationExecutionStatus("Approved");
        /// <summary>
        /// Constant Cancelled for AutomationExecutionStatus
        /// </summary>
        public static readonly AutomationExecutionStatus Cancelled = new AutomationExecutionStatus("Cancelled");
        /// <summary>
        /// Constant Cancelling for AutomationExecutionStatus
        /// </summary>
        public static readonly AutomationExecutionStatus Cancelling = new AutomationExecutionStatus("Cancelling");
        /// <summary>
        /// Constant ChangeCalendarOverrideApproved for AutomationExecutionStatus
        /// </summary>
        public static readonly AutomationExecutionStatus ChangeCalendarOverrideApproved = new AutomationExecutionStatus("ChangeCalendarOverrideApproved");
        /// <summary>
        /// Constant ChangeCalendarOverrideRejected for AutomationExecutionStatus
        /// </summary>
        public static readonly AutomationExecutionStatus ChangeCalendarOverrideRejected = new AutomationExecutionStatus("ChangeCalendarOverrideRejected");
        /// <summary>
        /// Constant CompletedWithFailure for AutomationExecutionStatus
        /// </summary>
        public static readonly AutomationExecutionStatus CompletedWithFailure = new AutomationExecutionStatus("CompletedWithFailure");
        /// <summary>
        /// Constant CompletedWithSuccess for AutomationExecutionStatus
        /// </summary>
        public static readonly AutomationExecutionStatus CompletedWithSuccess = new AutomationExecutionStatus("CompletedWithSuccess");
        /// <summary>
        /// Constant Failed for AutomationExecutionStatus
        /// </summary>
        public static readonly AutomationExecutionStatus Failed = new AutomationExecutionStatus("Failed");
        /// <summary>
        /// Constant InProgress for AutomationExecutionStatus
        /// </summary>
        public static readonly AutomationExecutionStatus InProgress = new AutomationExecutionStatus("InProgress");
        /// <summary>
        /// Constant Pending for AutomationExecutionStatus
        /// </summary>
        public static readonly AutomationExecutionStatus Pending = new AutomationExecutionStatus("Pending");
        /// <summary>
        /// Constant PendingApproval for AutomationExecutionStatus
        /// </summary>
        public static readonly AutomationExecutionStatus PendingApproval = new AutomationExecutionStatus("PendingApproval");
        /// <summary>
        /// Constant PendingChangeCalendarOverride for AutomationExecutionStatus
        /// </summary>
        public static readonly AutomationExecutionStatus PendingChangeCalendarOverride = new AutomationExecutionStatus("PendingChangeCalendarOverride");
        /// <summary>
        /// Constant Rejected for AutomationExecutionStatus
        /// </summary>
        public static readonly AutomationExecutionStatus Rejected = new AutomationExecutionStatus("Rejected");
        /// <summary>
        /// Constant RunbookInProgress for AutomationExecutionStatus
        /// </summary>
        public static readonly AutomationExecutionStatus RunbookInProgress = new AutomationExecutionStatus("RunbookInProgress");
        /// <summary>
        /// Constant Scheduled for AutomationExecutionStatus
        /// </summary>
        public static readonly AutomationExecutionStatus Scheduled = new AutomationExecutionStatus("Scheduled");
        /// <summary>
        /// Constant Success for AutomationExecutionStatus
        /// </summary>
        public static readonly AutomationExecutionStatus Success = new AutomationExecutionStatus("Success");
        /// <summary>
        /// Constant TimedOut for AutomationExecutionStatus
        /// </summary>
        public static readonly AutomationExecutionStatus TimedOut = new AutomationExecutionStatus("TimedOut");
        /// <summary>
        /// Constant Waiting for AutomationExecutionStatus
        /// </summary>
        public static readonly AutomationExecutionStatus Waiting = new AutomationExecutionStatus("Waiting");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutomationExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutomationExecutionStatus FindValue(string value)
        {
            return FindValue<AutomationExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutomationExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutomationSubtype.
    /// </summary>
    public class AutomationSubtype : ConstantClass
    {

        /// <summary>
        /// Constant ChangeRequest for AutomationSubtype
        /// </summary>
        public static readonly AutomationSubtype ChangeRequest = new AutomationSubtype("ChangeRequest");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutomationSubtype(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutomationSubtype FindValue(string value)
        {
            return FindValue<AutomationSubtype>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutomationSubtype(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutomationType.
    /// </summary>
    public class AutomationType : ConstantClass
    {

        /// <summary>
        /// Constant CrossAccount for AutomationType
        /// </summary>
        public static readonly AutomationType CrossAccount = new AutomationType("CrossAccount");
        /// <summary>
        /// Constant Local for AutomationType
        /// </summary>
        public static readonly AutomationType Local = new AutomationType("Local");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutomationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutomationType FindValue(string value)
        {
            return FindValue<AutomationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutomationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CalendarState.
    /// </summary>
    public class CalendarState : ConstantClass
    {

        /// <summary>
        /// Constant CLOSED for CalendarState
        /// </summary>
        public static readonly CalendarState CLOSED = new CalendarState("CLOSED");
        /// <summary>
        /// Constant OPEN for CalendarState
        /// </summary>
        public static readonly CalendarState OPEN = new CalendarState("OPEN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CalendarState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CalendarState FindValue(string value)
        {
            return FindValue<CalendarState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CalendarState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CommandFilterKey.
    /// </summary>
    public class CommandFilterKey : ConstantClass
    {

        /// <summary>
        /// Constant DocumentName for CommandFilterKey
        /// </summary>
        public static readonly CommandFilterKey DocumentName = new CommandFilterKey("DocumentName");
        /// <summary>
        /// Constant ExecutionStage for CommandFilterKey
        /// </summary>
        public static readonly CommandFilterKey ExecutionStage = new CommandFilterKey("ExecutionStage");
        /// <summary>
        /// Constant InvokedAfter for CommandFilterKey
        /// </summary>
        public static readonly CommandFilterKey InvokedAfter = new CommandFilterKey("InvokedAfter");
        /// <summary>
        /// Constant InvokedBefore for CommandFilterKey
        /// </summary>
        public static readonly CommandFilterKey InvokedBefore = new CommandFilterKey("InvokedBefore");
        /// <summary>
        /// Constant Status for CommandFilterKey
        /// </summary>
        public static readonly CommandFilterKey Status = new CommandFilterKey("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CommandFilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CommandFilterKey FindValue(string value)
        {
            return FindValue<CommandFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CommandFilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CommandInvocationStatus.
    /// </summary>
    public class CommandInvocationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Cancelled for CommandInvocationStatus
        /// </summary>
        public static readonly CommandInvocationStatus Cancelled = new CommandInvocationStatus("Cancelled");
        /// <summary>
        /// Constant Cancelling for CommandInvocationStatus
        /// </summary>
        public static readonly CommandInvocationStatus Cancelling = new CommandInvocationStatus("Cancelling");
        /// <summary>
        /// Constant Delayed for CommandInvocationStatus
        /// </summary>
        public static readonly CommandInvocationStatus Delayed = new CommandInvocationStatus("Delayed");
        /// <summary>
        /// Constant Failed for CommandInvocationStatus
        /// </summary>
        public static readonly CommandInvocationStatus Failed = new CommandInvocationStatus("Failed");
        /// <summary>
        /// Constant InProgress for CommandInvocationStatus
        /// </summary>
        public static readonly CommandInvocationStatus InProgress = new CommandInvocationStatus("InProgress");
        /// <summary>
        /// Constant Pending for CommandInvocationStatus
        /// </summary>
        public static readonly CommandInvocationStatus Pending = new CommandInvocationStatus("Pending");
        /// <summary>
        /// Constant Success for CommandInvocationStatus
        /// </summary>
        public static readonly CommandInvocationStatus Success = new CommandInvocationStatus("Success");
        /// <summary>
        /// Constant TimedOut for CommandInvocationStatus
        /// </summary>
        public static readonly CommandInvocationStatus TimedOut = new CommandInvocationStatus("TimedOut");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CommandInvocationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CommandInvocationStatus FindValue(string value)
        {
            return FindValue<CommandInvocationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CommandInvocationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CommandPluginStatus.
    /// </summary>
    public class CommandPluginStatus : ConstantClass
    {

        /// <summary>
        /// Constant Cancelled for CommandPluginStatus
        /// </summary>
        public static readonly CommandPluginStatus Cancelled = new CommandPluginStatus("Cancelled");
        /// <summary>
        /// Constant Failed for CommandPluginStatus
        /// </summary>
        public static readonly CommandPluginStatus Failed = new CommandPluginStatus("Failed");
        /// <summary>
        /// Constant InProgress for CommandPluginStatus
        /// </summary>
        public static readonly CommandPluginStatus InProgress = new CommandPluginStatus("InProgress");
        /// <summary>
        /// Constant Pending for CommandPluginStatus
        /// </summary>
        public static readonly CommandPluginStatus Pending = new CommandPluginStatus("Pending");
        /// <summary>
        /// Constant Success for CommandPluginStatus
        /// </summary>
        public static readonly CommandPluginStatus Success = new CommandPluginStatus("Success");
        /// <summary>
        /// Constant TimedOut for CommandPluginStatus
        /// </summary>
        public static readonly CommandPluginStatus TimedOut = new CommandPluginStatus("TimedOut");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CommandPluginStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CommandPluginStatus FindValue(string value)
        {
            return FindValue<CommandPluginStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CommandPluginStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CommandStatus.
    /// </summary>
    public class CommandStatus : ConstantClass
    {

        /// <summary>
        /// Constant Cancelled for CommandStatus
        /// </summary>
        public static readonly CommandStatus Cancelled = new CommandStatus("Cancelled");
        /// <summary>
        /// Constant Cancelling for CommandStatus
        /// </summary>
        public static readonly CommandStatus Cancelling = new CommandStatus("Cancelling");
        /// <summary>
        /// Constant Failed for CommandStatus
        /// </summary>
        public static readonly CommandStatus Failed = new CommandStatus("Failed");
        /// <summary>
        /// Constant InProgress for CommandStatus
        /// </summary>
        public static readonly CommandStatus InProgress = new CommandStatus("InProgress");
        /// <summary>
        /// Constant Pending for CommandStatus
        /// </summary>
        public static readonly CommandStatus Pending = new CommandStatus("Pending");
        /// <summary>
        /// Constant Success for CommandStatus
        /// </summary>
        public static readonly CommandStatus Success = new CommandStatus("Success");
        /// <summary>
        /// Constant TimedOut for CommandStatus
        /// </summary>
        public static readonly CommandStatus TimedOut = new CommandStatus("TimedOut");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CommandStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CommandStatus FindValue(string value)
        {
            return FindValue<CommandStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CommandStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComplianceQueryOperatorType.
    /// </summary>
    public class ComplianceQueryOperatorType : ConstantClass
    {

        /// <summary>
        /// Constant BEGIN_WITH for ComplianceQueryOperatorType
        /// </summary>
        public static readonly ComplianceQueryOperatorType BEGIN_WITH = new ComplianceQueryOperatorType("BEGIN_WITH");
        /// <summary>
        /// Constant EQUAL for ComplianceQueryOperatorType
        /// </summary>
        public static readonly ComplianceQueryOperatorType EQUAL = new ComplianceQueryOperatorType("EQUAL");
        /// <summary>
        /// Constant GREATER_THAN for ComplianceQueryOperatorType
        /// </summary>
        public static readonly ComplianceQueryOperatorType GREATER_THAN = new ComplianceQueryOperatorType("GREATER_THAN");
        /// <summary>
        /// Constant LESS_THAN for ComplianceQueryOperatorType
        /// </summary>
        public static readonly ComplianceQueryOperatorType LESS_THAN = new ComplianceQueryOperatorType("LESS_THAN");
        /// <summary>
        /// Constant NOT_EQUAL for ComplianceQueryOperatorType
        /// </summary>
        public static readonly ComplianceQueryOperatorType NOT_EQUAL = new ComplianceQueryOperatorType("NOT_EQUAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComplianceQueryOperatorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComplianceQueryOperatorType FindValue(string value)
        {
            return FindValue<ComplianceQueryOperatorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComplianceQueryOperatorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComplianceSeverity.
    /// </summary>
    public class ComplianceSeverity : ConstantClass
    {

        /// <summary>
        /// Constant CRITICAL for ComplianceSeverity
        /// </summary>
        public static readonly ComplianceSeverity CRITICAL = new ComplianceSeverity("CRITICAL");
        /// <summary>
        /// Constant HIGH for ComplianceSeverity
        /// </summary>
        public static readonly ComplianceSeverity HIGH = new ComplianceSeverity("HIGH");
        /// <summary>
        /// Constant INFORMATIONAL for ComplianceSeverity
        /// </summary>
        public static readonly ComplianceSeverity INFORMATIONAL = new ComplianceSeverity("INFORMATIONAL");
        /// <summary>
        /// Constant LOW for ComplianceSeverity
        /// </summary>
        public static readonly ComplianceSeverity LOW = new ComplianceSeverity("LOW");
        /// <summary>
        /// Constant MEDIUM for ComplianceSeverity
        /// </summary>
        public static readonly ComplianceSeverity MEDIUM = new ComplianceSeverity("MEDIUM");
        /// <summary>
        /// Constant UNSPECIFIED for ComplianceSeverity
        /// </summary>
        public static readonly ComplianceSeverity UNSPECIFIED = new ComplianceSeverity("UNSPECIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComplianceSeverity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComplianceSeverity FindValue(string value)
        {
            return FindValue<ComplianceSeverity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComplianceSeverity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComplianceStatus.
    /// </summary>
    public class ComplianceStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLIANT for ComplianceStatus
        /// </summary>
        public static readonly ComplianceStatus COMPLIANT = new ComplianceStatus("COMPLIANT");
        /// <summary>
        /// Constant NON_COMPLIANT for ComplianceStatus
        /// </summary>
        public static readonly ComplianceStatus NON_COMPLIANT = new ComplianceStatus("NON_COMPLIANT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComplianceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComplianceStatus FindValue(string value)
        {
            return FindValue<ComplianceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComplianceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComplianceUploadType.
    /// </summary>
    public class ComplianceUploadType : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for ComplianceUploadType
        /// </summary>
        public static readonly ComplianceUploadType COMPLETE = new ComplianceUploadType("COMPLETE");
        /// <summary>
        /// Constant PARTIAL for ComplianceUploadType
        /// </summary>
        public static readonly ComplianceUploadType PARTIAL = new ComplianceUploadType("PARTIAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComplianceUploadType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComplianceUploadType FindValue(string value)
        {
            return FindValue<ComplianceUploadType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComplianceUploadType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectionStatus.
    /// </summary>
    public class ConnectionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Connected for ConnectionStatus
        /// </summary>
        public static readonly ConnectionStatus Connected = new ConnectionStatus("Connected");
        /// <summary>
        /// Constant NotConnected for ConnectionStatus
        /// </summary>
        public static readonly ConnectionStatus NotConnected = new ConnectionStatus("NotConnected");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionStatus FindValue(string value)
        {
            return FindValue<ConnectionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DescribeActivationsFilterKeys.
    /// </summary>
    public class DescribeActivationsFilterKeys : ConstantClass
    {

        /// <summary>
        /// Constant ActivationIds for DescribeActivationsFilterKeys
        /// </summary>
        public static readonly DescribeActivationsFilterKeys ActivationIds = new DescribeActivationsFilterKeys("ActivationIds");
        /// <summary>
        /// Constant DefaultInstanceName for DescribeActivationsFilterKeys
        /// </summary>
        public static readonly DescribeActivationsFilterKeys DefaultInstanceName = new DescribeActivationsFilterKeys("DefaultInstanceName");
        /// <summary>
        /// Constant IamRole for DescribeActivationsFilterKeys
        /// </summary>
        public static readonly DescribeActivationsFilterKeys IamRole = new DescribeActivationsFilterKeys("IamRole");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DescribeActivationsFilterKeys(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DescribeActivationsFilterKeys FindValue(string value)
        {
            return FindValue<DescribeActivationsFilterKeys>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DescribeActivationsFilterKeys(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentFilterKey.
    /// </summary>
    public class DocumentFilterKey : ConstantClass
    {

        /// <summary>
        /// Constant DocumentType for DocumentFilterKey
        /// </summary>
        public static readonly DocumentFilterKey DocumentType = new DocumentFilterKey("DocumentType");
        /// <summary>
        /// Constant Name for DocumentFilterKey
        /// </summary>
        public static readonly DocumentFilterKey Name = new DocumentFilterKey("Name");
        /// <summary>
        /// Constant Owner for DocumentFilterKey
        /// </summary>
        public static readonly DocumentFilterKey Owner = new DocumentFilterKey("Owner");
        /// <summary>
        /// Constant PlatformTypes for DocumentFilterKey
        /// </summary>
        public static readonly DocumentFilterKey PlatformTypes = new DocumentFilterKey("PlatformTypes");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentFilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentFilterKey FindValue(string value)
        {
            return FindValue<DocumentFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentFilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentFormat.
    /// </summary>
    public class DocumentFormat : ConstantClass
    {

        /// <summary>
        /// Constant JSON for DocumentFormat
        /// </summary>
        public static readonly DocumentFormat JSON = new DocumentFormat("JSON");
        /// <summary>
        /// Constant TEXT for DocumentFormat
        /// </summary>
        public static readonly DocumentFormat TEXT = new DocumentFormat("TEXT");
        /// <summary>
        /// Constant YAML for DocumentFormat
        /// </summary>
        public static readonly DocumentFormat YAML = new DocumentFormat("YAML");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentFormat FindValue(string value)
        {
            return FindValue<DocumentFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentHashType.
    /// </summary>
    public class DocumentHashType : ConstantClass
    {

        /// <summary>
        /// Constant Sha1 for DocumentHashType
        /// </summary>
        public static readonly DocumentHashType Sha1 = new DocumentHashType("Sha1");
        /// <summary>
        /// Constant Sha256 for DocumentHashType
        /// </summary>
        public static readonly DocumentHashType Sha256 = new DocumentHashType("Sha256");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentHashType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentHashType FindValue(string value)
        {
            return FindValue<DocumentHashType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentHashType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentMetadataEnum.
    /// </summary>
    public class DocumentMetadataEnum : ConstantClass
    {

        /// <summary>
        /// Constant DocumentReviews for DocumentMetadataEnum
        /// </summary>
        public static readonly DocumentMetadataEnum DocumentReviews = new DocumentMetadataEnum("DocumentReviews");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentMetadataEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentMetadataEnum FindValue(string value)
        {
            return FindValue<DocumentMetadataEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentMetadataEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentParameterType.
    /// </summary>
    public class DocumentParameterType : ConstantClass
    {

        /// <summary>
        /// Constant String for DocumentParameterType
        /// </summary>
        public static readonly DocumentParameterType String = new DocumentParameterType("String");
        /// <summary>
        /// Constant StringList for DocumentParameterType
        /// </summary>
        public static readonly DocumentParameterType StringList = new DocumentParameterType("StringList");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentParameterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentParameterType FindValue(string value)
        {
            return FindValue<DocumentParameterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentParameterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentPermissionType.
    /// </summary>
    public class DocumentPermissionType : ConstantClass
    {

        /// <summary>
        /// Constant Share for DocumentPermissionType
        /// </summary>
        public static readonly DocumentPermissionType Share = new DocumentPermissionType("Share");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentPermissionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentPermissionType FindValue(string value)
        {
            return FindValue<DocumentPermissionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentPermissionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentReviewAction.
    /// </summary>
    public class DocumentReviewAction : ConstantClass
    {

        /// <summary>
        /// Constant Approve for DocumentReviewAction
        /// </summary>
        public static readonly DocumentReviewAction Approve = new DocumentReviewAction("Approve");
        /// <summary>
        /// Constant Reject for DocumentReviewAction
        /// </summary>
        public static readonly DocumentReviewAction Reject = new DocumentReviewAction("Reject");
        /// <summary>
        /// Constant SendForReview for DocumentReviewAction
        /// </summary>
        public static readonly DocumentReviewAction SendForReview = new DocumentReviewAction("SendForReview");
        /// <summary>
        /// Constant UpdateReview for DocumentReviewAction
        /// </summary>
        public static readonly DocumentReviewAction UpdateReview = new DocumentReviewAction("UpdateReview");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentReviewAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentReviewAction FindValue(string value)
        {
            return FindValue<DocumentReviewAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentReviewAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentReviewCommentType.
    /// </summary>
    public class DocumentReviewCommentType : ConstantClass
    {

        /// <summary>
        /// Constant Comment for DocumentReviewCommentType
        /// </summary>
        public static readonly DocumentReviewCommentType Comment = new DocumentReviewCommentType("Comment");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentReviewCommentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentReviewCommentType FindValue(string value)
        {
            return FindValue<DocumentReviewCommentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentReviewCommentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentStatus.
    /// </summary>
    public class DocumentStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus Active = new DocumentStatus("Active");
        /// <summary>
        /// Constant Creating for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus Creating = new DocumentStatus("Creating");
        /// <summary>
        /// Constant Deleting for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus Deleting = new DocumentStatus("Deleting");
        /// <summary>
        /// Constant Failed for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus Failed = new DocumentStatus("Failed");
        /// <summary>
        /// Constant Updating for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus Updating = new DocumentStatus("Updating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentStatus FindValue(string value)
        {
            return FindValue<DocumentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentType.
    /// </summary>
    public class DocumentType : ConstantClass
    {

        /// <summary>
        /// Constant ApplicationConfiguration for DocumentType
        /// </summary>
        public static readonly DocumentType ApplicationConfiguration = new DocumentType("ApplicationConfiguration");
        /// <summary>
        /// Constant ApplicationConfigurationSchema for DocumentType
        /// </summary>
        public static readonly DocumentType ApplicationConfigurationSchema = new DocumentType("ApplicationConfigurationSchema");
        /// <summary>
        /// Constant Automation for DocumentType
        /// </summary>
        public static readonly DocumentType Automation = new DocumentType("Automation");
        /// <summary>
        /// Constant AutomationChangeTemplate for DocumentType
        /// </summary>
        public static readonly DocumentType AutomationChangeTemplate = new DocumentType("Automation.ChangeTemplate");
        /// <summary>
        /// Constant ChangeCalendar for DocumentType
        /// </summary>
        public static readonly DocumentType ChangeCalendar = new DocumentType("ChangeCalendar");
        /// <summary>
        /// Constant CloudFormation for DocumentType
        /// </summary>
        public static readonly DocumentType CloudFormation = new DocumentType("CloudFormation");
        /// <summary>
        /// Constant Command for DocumentType
        /// </summary>
        public static readonly DocumentType Command = new DocumentType("Command");
        /// <summary>
        /// Constant ConformancePackTemplate for DocumentType
        /// </summary>
        public static readonly DocumentType ConformancePackTemplate = new DocumentType("ConformancePackTemplate");
        /// <summary>
        /// Constant DeploymentStrategy for DocumentType
        /// </summary>
        public static readonly DocumentType DeploymentStrategy = new DocumentType("DeploymentStrategy");
        /// <summary>
        /// Constant Package for DocumentType
        /// </summary>
        public static readonly DocumentType Package = new DocumentType("Package");
        /// <summary>
        /// Constant Policy for DocumentType
        /// </summary>
        public static readonly DocumentType Policy = new DocumentType("Policy");
        /// <summary>
        /// Constant ProblemAnalysis for DocumentType
        /// </summary>
        public static readonly DocumentType ProblemAnalysis = new DocumentType("ProblemAnalysis");
        /// <summary>
        /// Constant ProblemAnalysisTemplate for DocumentType
        /// </summary>
        public static readonly DocumentType ProblemAnalysisTemplate = new DocumentType("ProblemAnalysisTemplate");
        /// <summary>
        /// Constant QuickSetup for DocumentType
        /// </summary>
        public static readonly DocumentType QuickSetup = new DocumentType("QuickSetup");
        /// <summary>
        /// Constant Session for DocumentType
        /// </summary>
        public static readonly DocumentType Session = new DocumentType("Session");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentType FindValue(string value)
        {
            return FindValue<DocumentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionMode.
    /// </summary>
    public class ExecutionMode : ConstantClass
    {

        /// <summary>
        /// Constant Auto for ExecutionMode
        /// </summary>
        public static readonly ExecutionMode Auto = new ExecutionMode("Auto");
        /// <summary>
        /// Constant Interactive for ExecutionMode
        /// </summary>
        public static readonly ExecutionMode Interactive = new ExecutionMode("Interactive");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionMode FindValue(string value)
        {
            return FindValue<ExecutionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExternalAlarmState.
    /// </summary>
    public class ExternalAlarmState : ConstantClass
    {

        /// <summary>
        /// Constant ALARM for ExternalAlarmState
        /// </summary>
        public static readonly ExternalAlarmState ALARM = new ExternalAlarmState("ALARM");
        /// <summary>
        /// Constant UNKNOWN for ExternalAlarmState
        /// </summary>
        public static readonly ExternalAlarmState UNKNOWN = new ExternalAlarmState("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExternalAlarmState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExternalAlarmState FindValue(string value)
        {
            return FindValue<ExternalAlarmState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExternalAlarmState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Fault.
    /// </summary>
    public class Fault : ConstantClass
    {

        /// <summary>
        /// Constant Client for Fault
        /// </summary>
        public static readonly Fault Client = new Fault("Client");
        /// <summary>
        /// Constant Server for Fault
        /// </summary>
        public static readonly Fault Server = new Fault("Server");
        /// <summary>
        /// Constant Unknown for Fault
        /// </summary>
        public static readonly Fault Unknown = new Fault("Unknown");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Fault(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Fault FindValue(string value)
        {
            return FindValue<Fault>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Fault(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceInformationFilterKey.
    /// </summary>
    public class InstanceInformationFilterKey : ConstantClass
    {

        /// <summary>
        /// Constant ActivationIds for InstanceInformationFilterKey
        /// </summary>
        public static readonly InstanceInformationFilterKey ActivationIds = new InstanceInformationFilterKey("ActivationIds");
        /// <summary>
        /// Constant AgentVersion for InstanceInformationFilterKey
        /// </summary>
        public static readonly InstanceInformationFilterKey AgentVersion = new InstanceInformationFilterKey("AgentVersion");
        /// <summary>
        /// Constant AssociationStatus for InstanceInformationFilterKey
        /// </summary>
        public static readonly InstanceInformationFilterKey AssociationStatus = new InstanceInformationFilterKey("AssociationStatus");
        /// <summary>
        /// Constant IamRole for InstanceInformationFilterKey
        /// </summary>
        public static readonly InstanceInformationFilterKey IamRole = new InstanceInformationFilterKey("IamRole");
        /// <summary>
        /// Constant InstanceIds for InstanceInformationFilterKey
        /// </summary>
        public static readonly InstanceInformationFilterKey InstanceIds = new InstanceInformationFilterKey("InstanceIds");
        /// <summary>
        /// Constant PingStatus for InstanceInformationFilterKey
        /// </summary>
        public static readonly InstanceInformationFilterKey PingStatus = new InstanceInformationFilterKey("PingStatus");
        /// <summary>
        /// Constant PlatformTypes for InstanceInformationFilterKey
        /// </summary>
        public static readonly InstanceInformationFilterKey PlatformTypes = new InstanceInformationFilterKey("PlatformTypes");
        /// <summary>
        /// Constant ResourceType for InstanceInformationFilterKey
        /// </summary>
        public static readonly InstanceInformationFilterKey ResourceType = new InstanceInformationFilterKey("ResourceType");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceInformationFilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceInformationFilterKey FindValue(string value)
        {
            return FindValue<InstanceInformationFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceInformationFilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstancePatchStateOperatorType.
    /// </summary>
    public class InstancePatchStateOperatorType : ConstantClass
    {

        /// <summary>
        /// Constant Equal for InstancePatchStateOperatorType
        /// </summary>
        public static readonly InstancePatchStateOperatorType Equal = new InstancePatchStateOperatorType("Equal");
        /// <summary>
        /// Constant GreaterThan for InstancePatchStateOperatorType
        /// </summary>
        public static readonly InstancePatchStateOperatorType GreaterThan = new InstancePatchStateOperatorType("GreaterThan");
        /// <summary>
        /// Constant LessThan for InstancePatchStateOperatorType
        /// </summary>
        public static readonly InstancePatchStateOperatorType LessThan = new InstancePatchStateOperatorType("LessThan");
        /// <summary>
        /// Constant NotEqual for InstancePatchStateOperatorType
        /// </summary>
        public static readonly InstancePatchStateOperatorType NotEqual = new InstancePatchStateOperatorType("NotEqual");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstancePatchStateOperatorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstancePatchStateOperatorType FindValue(string value)
        {
            return FindValue<InstancePatchStateOperatorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstancePatchStateOperatorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InventoryAttributeDataType.
    /// </summary>
    public class InventoryAttributeDataType : ConstantClass
    {

        /// <summary>
        /// Constant Number for InventoryAttributeDataType
        /// </summary>
        public static readonly InventoryAttributeDataType Number = new InventoryAttributeDataType("number");
        /// <summary>
        /// Constant String for InventoryAttributeDataType
        /// </summary>
        public static readonly InventoryAttributeDataType String = new InventoryAttributeDataType("string");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InventoryAttributeDataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InventoryAttributeDataType FindValue(string value)
        {
            return FindValue<InventoryAttributeDataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InventoryAttributeDataType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InventoryDeletionStatus.
    /// </summary>
    public class InventoryDeletionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Complete for InventoryDeletionStatus
        /// </summary>
        public static readonly InventoryDeletionStatus Complete = new InventoryDeletionStatus("Complete");
        /// <summary>
        /// Constant InProgress for InventoryDeletionStatus
        /// </summary>
        public static readonly InventoryDeletionStatus InProgress = new InventoryDeletionStatus("InProgress");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InventoryDeletionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InventoryDeletionStatus FindValue(string value)
        {
            return FindValue<InventoryDeletionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InventoryDeletionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InventoryQueryOperatorType.
    /// </summary>
    public class InventoryQueryOperatorType : ConstantClass
    {

        /// <summary>
        /// Constant BeginWith for InventoryQueryOperatorType
        /// </summary>
        public static readonly InventoryQueryOperatorType BeginWith = new InventoryQueryOperatorType("BeginWith");
        /// <summary>
        /// Constant Equal for InventoryQueryOperatorType
        /// </summary>
        public static readonly InventoryQueryOperatorType Equal = new InventoryQueryOperatorType("Equal");
        /// <summary>
        /// Constant Exists for InventoryQueryOperatorType
        /// </summary>
        public static readonly InventoryQueryOperatorType Exists = new InventoryQueryOperatorType("Exists");
        /// <summary>
        /// Constant GreaterThan for InventoryQueryOperatorType
        /// </summary>
        public static readonly InventoryQueryOperatorType GreaterThan = new InventoryQueryOperatorType("GreaterThan");
        /// <summary>
        /// Constant LessThan for InventoryQueryOperatorType
        /// </summary>
        public static readonly InventoryQueryOperatorType LessThan = new InventoryQueryOperatorType("LessThan");
        /// <summary>
        /// Constant NotEqual for InventoryQueryOperatorType
        /// </summary>
        public static readonly InventoryQueryOperatorType NotEqual = new InventoryQueryOperatorType("NotEqual");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InventoryQueryOperatorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InventoryQueryOperatorType FindValue(string value)
        {
            return FindValue<InventoryQueryOperatorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InventoryQueryOperatorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InventorySchemaDeleteOption.
    /// </summary>
    public class InventorySchemaDeleteOption : ConstantClass
    {

        /// <summary>
        /// Constant DeleteSchema for InventorySchemaDeleteOption
        /// </summary>
        public static readonly InventorySchemaDeleteOption DeleteSchema = new InventorySchemaDeleteOption("DeleteSchema");
        /// <summary>
        /// Constant DisableSchema for InventorySchemaDeleteOption
        /// </summary>
        public static readonly InventorySchemaDeleteOption DisableSchema = new InventorySchemaDeleteOption("DisableSchema");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InventorySchemaDeleteOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InventorySchemaDeleteOption FindValue(string value)
        {
            return FindValue<InventorySchemaDeleteOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InventorySchemaDeleteOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LastResourceDataSyncStatus.
    /// </summary>
    public class LastResourceDataSyncStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for LastResourceDataSyncStatus
        /// </summary>
        public static readonly LastResourceDataSyncStatus Failed = new LastResourceDataSyncStatus("Failed");
        /// <summary>
        /// Constant InProgress for LastResourceDataSyncStatus
        /// </summary>
        public static readonly LastResourceDataSyncStatus InProgress = new LastResourceDataSyncStatus("InProgress");
        /// <summary>
        /// Constant Successful for LastResourceDataSyncStatus
        /// </summary>
        public static readonly LastResourceDataSyncStatus Successful = new LastResourceDataSyncStatus("Successful");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LastResourceDataSyncStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LastResourceDataSyncStatus FindValue(string value)
        {
            return FindValue<LastResourceDataSyncStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LastResourceDataSyncStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MaintenanceWindowExecutionStatus.
    /// </summary>
    public class MaintenanceWindowExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for MaintenanceWindowExecutionStatus
        /// </summary>
        public static readonly MaintenanceWindowExecutionStatus CANCELLED = new MaintenanceWindowExecutionStatus("CANCELLED");
        /// <summary>
        /// Constant CANCELLING for MaintenanceWindowExecutionStatus
        /// </summary>
        public static readonly MaintenanceWindowExecutionStatus CANCELLING = new MaintenanceWindowExecutionStatus("CANCELLING");
        /// <summary>
        /// Constant FAILED for MaintenanceWindowExecutionStatus
        /// </summary>
        public static readonly MaintenanceWindowExecutionStatus FAILED = new MaintenanceWindowExecutionStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for MaintenanceWindowExecutionStatus
        /// </summary>
        public static readonly MaintenanceWindowExecutionStatus IN_PROGRESS = new MaintenanceWindowExecutionStatus("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING for MaintenanceWindowExecutionStatus
        /// </summary>
        public static readonly MaintenanceWindowExecutionStatus PENDING = new MaintenanceWindowExecutionStatus("PENDING");
        /// <summary>
        /// Constant SKIPPED_OVERLAPPING for MaintenanceWindowExecutionStatus
        /// </summary>
        public static readonly MaintenanceWindowExecutionStatus SKIPPED_OVERLAPPING = new MaintenanceWindowExecutionStatus("SKIPPED_OVERLAPPING");
        /// <summary>
        /// Constant SUCCESS for MaintenanceWindowExecutionStatus
        /// </summary>
        public static readonly MaintenanceWindowExecutionStatus SUCCESS = new MaintenanceWindowExecutionStatus("SUCCESS");
        /// <summary>
        /// Constant TIMED_OUT for MaintenanceWindowExecutionStatus
        /// </summary>
        public static readonly MaintenanceWindowExecutionStatus TIMED_OUT = new MaintenanceWindowExecutionStatus("TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MaintenanceWindowExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MaintenanceWindowExecutionStatus FindValue(string value)
        {
            return FindValue<MaintenanceWindowExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MaintenanceWindowExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MaintenanceWindowResourceType.
    /// </summary>
    public class MaintenanceWindowResourceType : ConstantClass
    {

        /// <summary>
        /// Constant INSTANCE for MaintenanceWindowResourceType
        /// </summary>
        public static readonly MaintenanceWindowResourceType INSTANCE = new MaintenanceWindowResourceType("INSTANCE");
        /// <summary>
        /// Constant RESOURCE_GROUP for MaintenanceWindowResourceType
        /// </summary>
        public static readonly MaintenanceWindowResourceType RESOURCE_GROUP = new MaintenanceWindowResourceType("RESOURCE_GROUP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MaintenanceWindowResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MaintenanceWindowResourceType FindValue(string value)
        {
            return FindValue<MaintenanceWindowResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MaintenanceWindowResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MaintenanceWindowTaskCutoffBehavior.
    /// </summary>
    public class MaintenanceWindowTaskCutoffBehavior : ConstantClass
    {

        /// <summary>
        /// Constant CANCEL_TASK for MaintenanceWindowTaskCutoffBehavior
        /// </summary>
        public static readonly MaintenanceWindowTaskCutoffBehavior CANCEL_TASK = new MaintenanceWindowTaskCutoffBehavior("CANCEL_TASK");
        /// <summary>
        /// Constant CONTINUE_TASK for MaintenanceWindowTaskCutoffBehavior
        /// </summary>
        public static readonly MaintenanceWindowTaskCutoffBehavior CONTINUE_TASK = new MaintenanceWindowTaskCutoffBehavior("CONTINUE_TASK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MaintenanceWindowTaskCutoffBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MaintenanceWindowTaskCutoffBehavior FindValue(string value)
        {
            return FindValue<MaintenanceWindowTaskCutoffBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MaintenanceWindowTaskCutoffBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MaintenanceWindowTaskType.
    /// </summary>
    public class MaintenanceWindowTaskType : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATION for MaintenanceWindowTaskType
        /// </summary>
        public static readonly MaintenanceWindowTaskType AUTOMATION = new MaintenanceWindowTaskType("AUTOMATION");
        /// <summary>
        /// Constant LAMBDA for MaintenanceWindowTaskType
        /// </summary>
        public static readonly MaintenanceWindowTaskType LAMBDA = new MaintenanceWindowTaskType("LAMBDA");
        /// <summary>
        /// Constant RUN_COMMAND for MaintenanceWindowTaskType
        /// </summary>
        public static readonly MaintenanceWindowTaskType RUN_COMMAND = new MaintenanceWindowTaskType("RUN_COMMAND");
        /// <summary>
        /// Constant STEP_FUNCTIONS for MaintenanceWindowTaskType
        /// </summary>
        public static readonly MaintenanceWindowTaskType STEP_FUNCTIONS = new MaintenanceWindowTaskType("STEP_FUNCTIONS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MaintenanceWindowTaskType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MaintenanceWindowTaskType FindValue(string value)
        {
            return FindValue<MaintenanceWindowTaskType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MaintenanceWindowTaskType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotificationEvent.
    /// </summary>
    public class NotificationEvent : ConstantClass
    {

        /// <summary>
        /// Constant All for NotificationEvent
        /// </summary>
        public static readonly NotificationEvent All = new NotificationEvent("All");
        /// <summary>
        /// Constant Cancelled for NotificationEvent
        /// </summary>
        public static readonly NotificationEvent Cancelled = new NotificationEvent("Cancelled");
        /// <summary>
        /// Constant Failed for NotificationEvent
        /// </summary>
        public static readonly NotificationEvent Failed = new NotificationEvent("Failed");
        /// <summary>
        /// Constant InProgress for NotificationEvent
        /// </summary>
        public static readonly NotificationEvent InProgress = new NotificationEvent("InProgress");
        /// <summary>
        /// Constant Success for NotificationEvent
        /// </summary>
        public static readonly NotificationEvent Success = new NotificationEvent("Success");
        /// <summary>
        /// Constant TimedOut for NotificationEvent
        /// </summary>
        public static readonly NotificationEvent TimedOut = new NotificationEvent("TimedOut");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotificationEvent(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationEvent FindValue(string value)
        {
            return FindValue<NotificationEvent>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotificationEvent(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotificationType.
    /// </summary>
    public class NotificationType : ConstantClass
    {

        /// <summary>
        /// Constant Command for NotificationType
        /// </summary>
        public static readonly NotificationType Command = new NotificationType("Command");
        /// <summary>
        /// Constant Invocation for NotificationType
        /// </summary>
        public static readonly NotificationType Invocation = new NotificationType("Invocation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotificationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationType FindValue(string value)
        {
            return FindValue<NotificationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotificationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperatingSystem.
    /// </summary>
    public class OperatingSystem : ConstantClass
    {

        /// <summary>
        /// Constant ALMA_LINUX for OperatingSystem
        /// </summary>
        public static readonly OperatingSystem ALMA_LINUX = new OperatingSystem("ALMA_LINUX");
        /// <summary>
        /// Constant AMAZON_LINUX for OperatingSystem
        /// </summary>
        public static readonly OperatingSystem AMAZON_LINUX = new OperatingSystem("AMAZON_LINUX");
        /// <summary>
        /// Constant AMAZON_LINUX_2 for OperatingSystem
        /// </summary>
        public static readonly OperatingSystem AMAZON_LINUX_2 = new OperatingSystem("AMAZON_LINUX_2");
        /// <summary>
        /// Constant AMAZON_LINUX_2022 for OperatingSystem
        /// </summary>
        public static readonly OperatingSystem AMAZON_LINUX_2022 = new OperatingSystem("AMAZON_LINUX_2022");
        /// <summary>
        /// Constant AMAZON_LINUX_2023 for OperatingSystem
        /// </summary>
        public static readonly OperatingSystem AMAZON_LINUX_2023 = new OperatingSystem("AMAZON_LINUX_2023");
        /// <summary>
        /// Constant CENTOS for OperatingSystem
        /// </summary>
        public static readonly OperatingSystem CENTOS = new OperatingSystem("CENTOS");
        /// <summary>
        /// Constant DEBIAN for OperatingSystem
        /// </summary>
        public static readonly OperatingSystem DEBIAN = new OperatingSystem("DEBIAN");
        /// <summary>
        /// Constant MACOS for OperatingSystem
        /// </summary>
        public static readonly OperatingSystem MACOS = new OperatingSystem("MACOS");
        /// <summary>
        /// Constant ORACLE_LINUX for OperatingSystem
        /// </summary>
        public static readonly OperatingSystem ORACLE_LINUX = new OperatingSystem("ORACLE_LINUX");
        /// <summary>
        /// Constant RASPBIAN for OperatingSystem
        /// </summary>
        public static readonly OperatingSystem RASPBIAN = new OperatingSystem("RASPBIAN");
        /// <summary>
        /// Constant REDHAT_ENTERPRISE_LINUX for OperatingSystem
        /// </summary>
        public static readonly OperatingSystem REDHAT_ENTERPRISE_LINUX = new OperatingSystem("REDHAT_ENTERPRISE_LINUX");
        /// <summary>
        /// Constant ROCKY_LINUX for OperatingSystem
        /// </summary>
        public static readonly OperatingSystem ROCKY_LINUX = new OperatingSystem("ROCKY_LINUX");
        /// <summary>
        /// Constant SUSE for OperatingSystem
        /// </summary>
        public static readonly OperatingSystem SUSE = new OperatingSystem("SUSE");
        /// <summary>
        /// Constant UBUNTU for OperatingSystem
        /// </summary>
        public static readonly OperatingSystem UBUNTU = new OperatingSystem("UBUNTU");
        /// <summary>
        /// Constant WINDOWS for OperatingSystem
        /// </summary>
        public static readonly OperatingSystem WINDOWS = new OperatingSystem("WINDOWS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperatingSystem(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperatingSystem FindValue(string value)
        {
            return FindValue<OperatingSystem>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperatingSystem(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OpsFilterOperatorType.
    /// </summary>
    public class OpsFilterOperatorType : ConstantClass
    {

        /// <summary>
        /// Constant BeginWith for OpsFilterOperatorType
        /// </summary>
        public static readonly OpsFilterOperatorType BeginWith = new OpsFilterOperatorType("BeginWith");
        /// <summary>
        /// Constant Equal for OpsFilterOperatorType
        /// </summary>
        public static readonly OpsFilterOperatorType Equal = new OpsFilterOperatorType("Equal");
        /// <summary>
        /// Constant Exists for OpsFilterOperatorType
        /// </summary>
        public static readonly OpsFilterOperatorType Exists = new OpsFilterOperatorType("Exists");
        /// <summary>
        /// Constant GreaterThan for OpsFilterOperatorType
        /// </summary>
        public static readonly OpsFilterOperatorType GreaterThan = new OpsFilterOperatorType("GreaterThan");
        /// <summary>
        /// Constant LessThan for OpsFilterOperatorType
        /// </summary>
        public static readonly OpsFilterOperatorType LessThan = new OpsFilterOperatorType("LessThan");
        /// <summary>
        /// Constant NotEqual for OpsFilterOperatorType
        /// </summary>
        public static readonly OpsFilterOperatorType NotEqual = new OpsFilterOperatorType("NotEqual");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OpsFilterOperatorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OpsFilterOperatorType FindValue(string value)
        {
            return FindValue<OpsFilterOperatorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OpsFilterOperatorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OpsItemDataType.
    /// </summary>
    public class OpsItemDataType : ConstantClass
    {

        /// <summary>
        /// Constant SearchableString for OpsItemDataType
        /// </summary>
        public static readonly OpsItemDataType SearchableString = new OpsItemDataType("SearchableString");
        /// <summary>
        /// Constant String for OpsItemDataType
        /// </summary>
        public static readonly OpsItemDataType String = new OpsItemDataType("String");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OpsItemDataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OpsItemDataType FindValue(string value)
        {
            return FindValue<OpsItemDataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OpsItemDataType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OpsItemEventFilterKey.
    /// </summary>
    public class OpsItemEventFilterKey : ConstantClass
    {

        /// <summary>
        /// Constant OpsItemId for OpsItemEventFilterKey
        /// </summary>
        public static readonly OpsItemEventFilterKey OpsItemId = new OpsItemEventFilterKey("OpsItemId");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OpsItemEventFilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OpsItemEventFilterKey FindValue(string value)
        {
            return FindValue<OpsItemEventFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OpsItemEventFilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OpsItemEventFilterOperator.
    /// </summary>
    public class OpsItemEventFilterOperator : ConstantClass
    {

        /// <summary>
        /// Constant Equal for OpsItemEventFilterOperator
        /// </summary>
        public static readonly OpsItemEventFilterOperator Equal = new OpsItemEventFilterOperator("Equal");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OpsItemEventFilterOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OpsItemEventFilterOperator FindValue(string value)
        {
            return FindValue<OpsItemEventFilterOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OpsItemEventFilterOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OpsItemFilterKey.
    /// </summary>
    public class OpsItemFilterKey : ConstantClass
    {

        /// <summary>
        /// Constant AccountId for OpsItemFilterKey
        /// </summary>
        public static readonly OpsItemFilterKey AccountId = new OpsItemFilterKey("AccountId");
        /// <summary>
        /// Constant ActualEndTime for OpsItemFilterKey
        /// </summary>
        public static readonly OpsItemFilterKey ActualEndTime = new OpsItemFilterKey("ActualEndTime");
        /// <summary>
        /// Constant ActualStartTime for OpsItemFilterKey
        /// </summary>
        public static readonly OpsItemFilterKey ActualStartTime = new OpsItemFilterKey("ActualStartTime");
        /// <summary>
        /// Constant AutomationId for OpsItemFilterKey
        /// </summary>
        public static readonly OpsItemFilterKey AutomationId = new OpsItemFilterKey("AutomationId");
        /// <summary>
        /// Constant Category for OpsItemFilterKey
        /// </summary>
        public static readonly OpsItemFilterKey Category = new OpsItemFilterKey("Category");
        /// <summary>
        /// Constant ChangeRequestByApproverArn for OpsItemFilterKey
        /// </summary>
        public static readonly OpsItemFilterKey ChangeRequestByApproverArn = new OpsItemFilterKey("ChangeRequestByApproverArn");
        /// <summary>
        /// Constant ChangeRequestByApproverName for OpsItemFilterKey
        /// </summary>
        public static readonly OpsItemFilterKey ChangeRequestByApproverName = new OpsItemFilterKey("ChangeRequestByApproverName");
        /// <summary>
        /// Constant ChangeRequestByRequesterArn for OpsItemFilterKey
        /// </summary>
        public static readonly OpsItemFilterKey ChangeRequestByRequesterArn = new OpsItemFilterKey("ChangeRequestByRequesterArn");
        /// <summary>
        /// Constant ChangeRequestByRequesterName for OpsItemFilterKey
        /// </summary>
        public static readonly OpsItemFilterKey ChangeRequestByRequesterName = new OpsItemFilterKey("ChangeRequestByRequesterName");
        /// <summary>
        /// Constant ChangeRequestByTargetsResourceGroup for OpsItemFilterKey
        /// </summary>
        public static readonly OpsItemFilterKey ChangeRequestByTargetsResourceGroup = new OpsItemFilterKey("ChangeRequestByTargetsResourceGroup");
        /// <summary>
        /// Constant ChangeRequestByTemplate for OpsItemFilterKey
        /// </summary>
        public static readonly OpsItemFilterKey ChangeRequestByTemplate = new OpsItemFilterKey("ChangeRequestByTemplate");
        /// <summary>
        /// Constant CreatedBy for OpsItemFilterKey
        /// </summary>
        public static readonly OpsItemFilterKey CreatedBy = new OpsItemFilterKey("CreatedBy");
        /// <summary>
        /// Constant CreatedTime for OpsItemFilterKey
        /// </summary>
        public static readonly OpsItemFilterKey CreatedTime = new OpsItemFilterKey("CreatedTime");
        /// <summary>
        /// Constant InsightByType for OpsItemFilterKey
        /// </summary>
        public static readonly OpsItemFilterKey InsightByType = new OpsItemFilterKey("InsightByType");
        /// <summary>
        /// Constant LastModifiedTime for OpsItemFilterKey
        /// </summary>
        public static readonly OpsItemFilterKey LastModifiedTime = new OpsItemFilterKey("LastModifiedTime");
        /// <summary>
        /// Constant OperationalData for OpsItemFilterKey
        /// </summary>
        public static readonly OpsItemFilterKey OperationalData = new OpsItemFilterKey("OperationalData");
        /// <summary>
        /// Constant OperationalDataKey for OpsItemFilterKey
        /// </summary>
        public static readonly OpsItemFilterKey OperationalDataKey = new OpsItemFilterKey("OperationalDataKey");
        /// <summary>
        /// Constant OperationalDataValue for OpsItemFilterKey
        /// </summary>
        public static readonly OpsItemFilterKey OperationalDataValue = new OpsItemFilterKey("OperationalDataValue");
        /// <summary>
        /// Constant OpsItemId for OpsItemFilterKey
        /// </summary>
        public static readonly OpsItemFilterKey OpsItemId = new OpsItemFilterKey("OpsItemId");
        /// <summary>
        /// Constant OpsItemType for OpsItemFilterKey
        /// </summary>
        public static readonly OpsItemFilterKey OpsItemType = new OpsItemFilterKey("OpsItemType");
        /// <summary>
        /// Constant PlannedEndTime for OpsItemFilterKey
        /// </summary>
        public static readonly OpsItemFilterKey PlannedEndTime = new OpsItemFilterKey("PlannedEndTime");
        /// <summary>
        /// Constant PlannedStartTime for OpsItemFilterKey
        /// </summary>
        public static readonly OpsItemFilterKey PlannedStartTime = new OpsItemFilterKey("PlannedStartTime");
        /// <summary>
        /// Constant Priority for OpsItemFilterKey
        /// </summary>
        public static readonly OpsItemFilterKey Priority = new OpsItemFilterKey("Priority");
        /// <summary>
        /// Constant ResourceId for OpsItemFilterKey
        /// </summary>
        public static readonly OpsItemFilterKey ResourceId = new OpsItemFilterKey("ResourceId");
        /// <summary>
        /// Constant Severity for OpsItemFilterKey
        /// </summary>
        public static readonly OpsItemFilterKey Severity = new OpsItemFilterKey("Severity");
        /// <summary>
        /// Constant Source for OpsItemFilterKey
        /// </summary>
        public static readonly OpsItemFilterKey Source = new OpsItemFilterKey("Source");
        /// <summary>
        /// Constant Status for OpsItemFilterKey
        /// </summary>
        public static readonly OpsItemFilterKey Status = new OpsItemFilterKey("Status");
        /// <summary>
        /// Constant Title for OpsItemFilterKey
        /// </summary>
        public static readonly OpsItemFilterKey Title = new OpsItemFilterKey("Title");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OpsItemFilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OpsItemFilterKey FindValue(string value)
        {
            return FindValue<OpsItemFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OpsItemFilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OpsItemFilterOperator.
    /// </summary>
    public class OpsItemFilterOperator : ConstantClass
    {

        /// <summary>
        /// Constant Contains for OpsItemFilterOperator
        /// </summary>
        public static readonly OpsItemFilterOperator Contains = new OpsItemFilterOperator("Contains");
        /// <summary>
        /// Constant Equal for OpsItemFilterOperator
        /// </summary>
        public static readonly OpsItemFilterOperator Equal = new OpsItemFilterOperator("Equal");
        /// <summary>
        /// Constant GreaterThan for OpsItemFilterOperator
        /// </summary>
        public static readonly OpsItemFilterOperator GreaterThan = new OpsItemFilterOperator("GreaterThan");
        /// <summary>
        /// Constant LessThan for OpsItemFilterOperator
        /// </summary>
        public static readonly OpsItemFilterOperator LessThan = new OpsItemFilterOperator("LessThan");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OpsItemFilterOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OpsItemFilterOperator FindValue(string value)
        {
            return FindValue<OpsItemFilterOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OpsItemFilterOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OpsItemRelatedItemsFilterKey.
    /// </summary>
    public class OpsItemRelatedItemsFilterKey : ConstantClass
    {

        /// <summary>
        /// Constant AssociationId for OpsItemRelatedItemsFilterKey
        /// </summary>
        public static readonly OpsItemRelatedItemsFilterKey AssociationId = new OpsItemRelatedItemsFilterKey("AssociationId");
        /// <summary>
        /// Constant ResourceType for OpsItemRelatedItemsFilterKey
        /// </summary>
        public static readonly OpsItemRelatedItemsFilterKey ResourceType = new OpsItemRelatedItemsFilterKey("ResourceType");
        /// <summary>
        /// Constant ResourceUri for OpsItemRelatedItemsFilterKey
        /// </summary>
        public static readonly OpsItemRelatedItemsFilterKey ResourceUri = new OpsItemRelatedItemsFilterKey("ResourceUri");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OpsItemRelatedItemsFilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OpsItemRelatedItemsFilterKey FindValue(string value)
        {
            return FindValue<OpsItemRelatedItemsFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OpsItemRelatedItemsFilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OpsItemRelatedItemsFilterOperator.
    /// </summary>
    public class OpsItemRelatedItemsFilterOperator : ConstantClass
    {

        /// <summary>
        /// Constant Equal for OpsItemRelatedItemsFilterOperator
        /// </summary>
        public static readonly OpsItemRelatedItemsFilterOperator Equal = new OpsItemRelatedItemsFilterOperator("Equal");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OpsItemRelatedItemsFilterOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OpsItemRelatedItemsFilterOperator FindValue(string value)
        {
            return FindValue<OpsItemRelatedItemsFilterOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OpsItemRelatedItemsFilterOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OpsItemStatus.
    /// </summary>
    public class OpsItemStatus : ConstantClass
    {

        /// <summary>
        /// Constant Approved for OpsItemStatus
        /// </summary>
        public static readonly OpsItemStatus Approved = new OpsItemStatus("Approved");
        /// <summary>
        /// Constant Cancelled for OpsItemStatus
        /// </summary>
        public static readonly OpsItemStatus Cancelled = new OpsItemStatus("Cancelled");
        /// <summary>
        /// Constant Cancelling for OpsItemStatus
        /// </summary>
        public static readonly OpsItemStatus Cancelling = new OpsItemStatus("Cancelling");
        /// <summary>
        /// Constant ChangeCalendarOverrideApproved for OpsItemStatus
        /// </summary>
        public static readonly OpsItemStatus ChangeCalendarOverrideApproved = new OpsItemStatus("ChangeCalendarOverrideApproved");
        /// <summary>
        /// Constant ChangeCalendarOverrideRejected for OpsItemStatus
        /// </summary>
        public static readonly OpsItemStatus ChangeCalendarOverrideRejected = new OpsItemStatus("ChangeCalendarOverrideRejected");
        /// <summary>
        /// Constant Closed for OpsItemStatus
        /// </summary>
        public static readonly OpsItemStatus Closed = new OpsItemStatus("Closed");
        /// <summary>
        /// Constant CompletedWithFailure for OpsItemStatus
        /// </summary>
        public static readonly OpsItemStatus CompletedWithFailure = new OpsItemStatus("CompletedWithFailure");
        /// <summary>
        /// Constant CompletedWithSuccess for OpsItemStatus
        /// </summary>
        public static readonly OpsItemStatus CompletedWithSuccess = new OpsItemStatus("CompletedWithSuccess");
        /// <summary>
        /// Constant Failed for OpsItemStatus
        /// </summary>
        public static readonly OpsItemStatus Failed = new OpsItemStatus("Failed");
        /// <summary>
        /// Constant InProgress for OpsItemStatus
        /// </summary>
        public static readonly OpsItemStatus InProgress = new OpsItemStatus("InProgress");
        /// <summary>
        /// Constant Open for OpsItemStatus
        /// </summary>
        public static readonly OpsItemStatus Open = new OpsItemStatus("Open");
        /// <summary>
        /// Constant Pending for OpsItemStatus
        /// </summary>
        public static readonly OpsItemStatus Pending = new OpsItemStatus("Pending");
        /// <summary>
        /// Constant PendingApproval for OpsItemStatus
        /// </summary>
        public static readonly OpsItemStatus PendingApproval = new OpsItemStatus("PendingApproval");
        /// <summary>
        /// Constant PendingChangeCalendarOverride for OpsItemStatus
        /// </summary>
        public static readonly OpsItemStatus PendingChangeCalendarOverride = new OpsItemStatus("PendingChangeCalendarOverride");
        /// <summary>
        /// Constant Rejected for OpsItemStatus
        /// </summary>
        public static readonly OpsItemStatus Rejected = new OpsItemStatus("Rejected");
        /// <summary>
        /// Constant Resolved for OpsItemStatus
        /// </summary>
        public static readonly OpsItemStatus Resolved = new OpsItemStatus("Resolved");
        /// <summary>
        /// Constant RunbookInProgress for OpsItemStatus
        /// </summary>
        public static readonly OpsItemStatus RunbookInProgress = new OpsItemStatus("RunbookInProgress");
        /// <summary>
        /// Constant Scheduled for OpsItemStatus
        /// </summary>
        public static readonly OpsItemStatus Scheduled = new OpsItemStatus("Scheduled");
        /// <summary>
        /// Constant TimedOut for OpsItemStatus
        /// </summary>
        public static readonly OpsItemStatus TimedOut = new OpsItemStatus("TimedOut");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OpsItemStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OpsItemStatus FindValue(string value)
        {
            return FindValue<OpsItemStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OpsItemStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParametersFilterKey.
    /// </summary>
    public class ParametersFilterKey : ConstantClass
    {

        /// <summary>
        /// Constant KeyId for ParametersFilterKey
        /// </summary>
        public static readonly ParametersFilterKey KeyId = new ParametersFilterKey("KeyId");
        /// <summary>
        /// Constant Name for ParametersFilterKey
        /// </summary>
        public static readonly ParametersFilterKey Name = new ParametersFilterKey("Name");
        /// <summary>
        /// Constant Type for ParametersFilterKey
        /// </summary>
        public static readonly ParametersFilterKey Type = new ParametersFilterKey("Type");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParametersFilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParametersFilterKey FindValue(string value)
        {
            return FindValue<ParametersFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParametersFilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParameterTier.
    /// </summary>
    public class ParameterTier : ConstantClass
    {

        /// <summary>
        /// Constant Advanced for ParameterTier
        /// </summary>
        public static readonly ParameterTier Advanced = new ParameterTier("Advanced");
        /// <summary>
        /// Constant IntelligentTiering for ParameterTier
        /// </summary>
        public static readonly ParameterTier IntelligentTiering = new ParameterTier("Intelligent-Tiering");
        /// <summary>
        /// Constant Standard for ParameterTier
        /// </summary>
        public static readonly ParameterTier Standard = new ParameterTier("Standard");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParameterTier(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParameterTier FindValue(string value)
        {
            return FindValue<ParameterTier>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParameterTier(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParameterType.
    /// </summary>
    public class ParameterType : ConstantClass
    {

        /// <summary>
        /// Constant SecureString for ParameterType
        /// </summary>
        public static readonly ParameterType SecureString = new ParameterType("SecureString");
        /// <summary>
        /// Constant String for ParameterType
        /// </summary>
        public static readonly ParameterType String = new ParameterType("String");
        /// <summary>
        /// Constant StringList for ParameterType
        /// </summary>
        public static readonly ParameterType StringList = new ParameterType("StringList");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParameterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParameterType FindValue(string value)
        {
            return FindValue<ParameterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParameterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PatchAction.
    /// </summary>
    public class PatchAction : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW_AS_DEPENDENCY for PatchAction
        /// </summary>
        public static readonly PatchAction ALLOW_AS_DEPENDENCY = new PatchAction("ALLOW_AS_DEPENDENCY");
        /// <summary>
        /// Constant BLOCK for PatchAction
        /// </summary>
        public static readonly PatchAction BLOCK = new PatchAction("BLOCK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PatchAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PatchAction FindValue(string value)
        {
            return FindValue<PatchAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PatchAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PatchComplianceDataState.
    /// </summary>
    public class PatchComplianceDataState : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for PatchComplianceDataState
        /// </summary>
        public static readonly PatchComplianceDataState FAILED = new PatchComplianceDataState("FAILED");
        /// <summary>
        /// Constant INSTALLED for PatchComplianceDataState
        /// </summary>
        public static readonly PatchComplianceDataState INSTALLED = new PatchComplianceDataState("INSTALLED");
        /// <summary>
        /// Constant INSTALLED_OTHER for PatchComplianceDataState
        /// </summary>
        public static readonly PatchComplianceDataState INSTALLED_OTHER = new PatchComplianceDataState("INSTALLED_OTHER");
        /// <summary>
        /// Constant INSTALLED_PENDING_REBOOT for PatchComplianceDataState
        /// </summary>
        public static readonly PatchComplianceDataState INSTALLED_PENDING_REBOOT = new PatchComplianceDataState("INSTALLED_PENDING_REBOOT");
        /// <summary>
        /// Constant INSTALLED_REJECTED for PatchComplianceDataState
        /// </summary>
        public static readonly PatchComplianceDataState INSTALLED_REJECTED = new PatchComplianceDataState("INSTALLED_REJECTED");
        /// <summary>
        /// Constant MISSING for PatchComplianceDataState
        /// </summary>
        public static readonly PatchComplianceDataState MISSING = new PatchComplianceDataState("MISSING");
        /// <summary>
        /// Constant NOT_APPLICABLE for PatchComplianceDataState
        /// </summary>
        public static readonly PatchComplianceDataState NOT_APPLICABLE = new PatchComplianceDataState("NOT_APPLICABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PatchComplianceDataState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PatchComplianceDataState FindValue(string value)
        {
            return FindValue<PatchComplianceDataState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PatchComplianceDataState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PatchComplianceLevel.
    /// </summary>
    public class PatchComplianceLevel : ConstantClass
    {

        /// <summary>
        /// Constant CRITICAL for PatchComplianceLevel
        /// </summary>
        public static readonly PatchComplianceLevel CRITICAL = new PatchComplianceLevel("CRITICAL");
        /// <summary>
        /// Constant HIGH for PatchComplianceLevel
        /// </summary>
        public static readonly PatchComplianceLevel HIGH = new PatchComplianceLevel("HIGH");
        /// <summary>
        /// Constant INFORMATIONAL for PatchComplianceLevel
        /// </summary>
        public static readonly PatchComplianceLevel INFORMATIONAL = new PatchComplianceLevel("INFORMATIONAL");
        /// <summary>
        /// Constant LOW for PatchComplianceLevel
        /// </summary>
        public static readonly PatchComplianceLevel LOW = new PatchComplianceLevel("LOW");
        /// <summary>
        /// Constant MEDIUM for PatchComplianceLevel
        /// </summary>
        public static readonly PatchComplianceLevel MEDIUM = new PatchComplianceLevel("MEDIUM");
        /// <summary>
        /// Constant UNSPECIFIED for PatchComplianceLevel
        /// </summary>
        public static readonly PatchComplianceLevel UNSPECIFIED = new PatchComplianceLevel("UNSPECIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PatchComplianceLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PatchComplianceLevel FindValue(string value)
        {
            return FindValue<PatchComplianceLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PatchComplianceLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PatchDeploymentStatus.
    /// </summary>
    public class PatchDeploymentStatus : ConstantClass
    {

        /// <summary>
        /// Constant APPROVED for PatchDeploymentStatus
        /// </summary>
        public static readonly PatchDeploymentStatus APPROVED = new PatchDeploymentStatus("APPROVED");
        /// <summary>
        /// Constant EXPLICIT_APPROVED for PatchDeploymentStatus
        /// </summary>
        public static readonly PatchDeploymentStatus EXPLICIT_APPROVED = new PatchDeploymentStatus("EXPLICIT_APPROVED");
        /// <summary>
        /// Constant EXPLICIT_REJECTED for PatchDeploymentStatus
        /// </summary>
        public static readonly PatchDeploymentStatus EXPLICIT_REJECTED = new PatchDeploymentStatus("EXPLICIT_REJECTED");
        /// <summary>
        /// Constant PENDING_APPROVAL for PatchDeploymentStatus
        /// </summary>
        public static readonly PatchDeploymentStatus PENDING_APPROVAL = new PatchDeploymentStatus("PENDING_APPROVAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PatchDeploymentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PatchDeploymentStatus FindValue(string value)
        {
            return FindValue<PatchDeploymentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PatchDeploymentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PatchFilterKey.
    /// </summary>
    public class PatchFilterKey : ConstantClass
    {

        /// <summary>
        /// Constant ADVISORY_ID for PatchFilterKey
        /// </summary>
        public static readonly PatchFilterKey ADVISORY_ID = new PatchFilterKey("ADVISORY_ID");
        /// <summary>
        /// Constant ARCH for PatchFilterKey
        /// </summary>
        public static readonly PatchFilterKey ARCH = new PatchFilterKey("ARCH");
        /// <summary>
        /// Constant BUGZILLA_ID for PatchFilterKey
        /// </summary>
        public static readonly PatchFilterKey BUGZILLA_ID = new PatchFilterKey("BUGZILLA_ID");
        /// <summary>
        /// Constant CLASSIFICATION for PatchFilterKey
        /// </summary>
        public static readonly PatchFilterKey CLASSIFICATION = new PatchFilterKey("CLASSIFICATION");
        /// <summary>
        /// Constant CVE_ID for PatchFilterKey
        /// </summary>
        public static readonly PatchFilterKey CVE_ID = new PatchFilterKey("CVE_ID");
        /// <summary>
        /// Constant EPOCH for PatchFilterKey
        /// </summary>
        public static readonly PatchFilterKey EPOCH = new PatchFilterKey("EPOCH");
        /// <summary>
        /// Constant MSRC_SEVERITY for PatchFilterKey
        /// </summary>
        public static readonly PatchFilterKey MSRC_SEVERITY = new PatchFilterKey("MSRC_SEVERITY");
        /// <summary>
        /// Constant NAME for PatchFilterKey
        /// </summary>
        public static readonly PatchFilterKey NAME = new PatchFilterKey("NAME");
        /// <summary>
        /// Constant PATCH_ID for PatchFilterKey
        /// </summary>
        public static readonly PatchFilterKey PATCH_ID = new PatchFilterKey("PATCH_ID");
        /// <summary>
        /// Constant PATCH_SET for PatchFilterKey
        /// </summary>
        public static readonly PatchFilterKey PATCH_SET = new PatchFilterKey("PATCH_SET");
        /// <summary>
        /// Constant PRIORITY for PatchFilterKey
        /// </summary>
        public static readonly PatchFilterKey PRIORITY = new PatchFilterKey("PRIORITY");
        /// <summary>
        /// Constant PRODUCT for PatchFilterKey
        /// </summary>
        public static readonly PatchFilterKey PRODUCT = new PatchFilterKey("PRODUCT");
        /// <summary>
        /// Constant PRODUCT_FAMILY for PatchFilterKey
        /// </summary>
        public static readonly PatchFilterKey PRODUCT_FAMILY = new PatchFilterKey("PRODUCT_FAMILY");
        /// <summary>
        /// Constant RELEASE for PatchFilterKey
        /// </summary>
        public static readonly PatchFilterKey RELEASE = new PatchFilterKey("RELEASE");
        /// <summary>
        /// Constant REPOSITORY for PatchFilterKey
        /// </summary>
        public static readonly PatchFilterKey REPOSITORY = new PatchFilterKey("REPOSITORY");
        /// <summary>
        /// Constant SECTION for PatchFilterKey
        /// </summary>
        public static readonly PatchFilterKey SECTION = new PatchFilterKey("SECTION");
        /// <summary>
        /// Constant SECURITY for PatchFilterKey
        /// </summary>
        public static readonly PatchFilterKey SECURITY = new PatchFilterKey("SECURITY");
        /// <summary>
        /// Constant SEVERITY for PatchFilterKey
        /// </summary>
        public static readonly PatchFilterKey SEVERITY = new PatchFilterKey("SEVERITY");
        /// <summary>
        /// Constant VERSION for PatchFilterKey
        /// </summary>
        public static readonly PatchFilterKey VERSION = new PatchFilterKey("VERSION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PatchFilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PatchFilterKey FindValue(string value)
        {
            return FindValue<PatchFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PatchFilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PatchOperationType.
    /// </summary>
    public class PatchOperationType : ConstantClass
    {

        /// <summary>
        /// Constant Install for PatchOperationType
        /// </summary>
        public static readonly PatchOperationType Install = new PatchOperationType("Install");
        /// <summary>
        /// Constant Scan for PatchOperationType
        /// </summary>
        public static readonly PatchOperationType Scan = new PatchOperationType("Scan");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PatchOperationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PatchOperationType FindValue(string value)
        {
            return FindValue<PatchOperationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PatchOperationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PatchProperty.
    /// </summary>
    public class PatchProperty : ConstantClass
    {

        /// <summary>
        /// Constant CLASSIFICATION for PatchProperty
        /// </summary>
        public static readonly PatchProperty CLASSIFICATION = new PatchProperty("CLASSIFICATION");
        /// <summary>
        /// Constant MSRC_SEVERITY for PatchProperty
        /// </summary>
        public static readonly PatchProperty MSRC_SEVERITY = new PatchProperty("MSRC_SEVERITY");
        /// <summary>
        /// Constant PRIORITY for PatchProperty
        /// </summary>
        public static readonly PatchProperty PRIORITY = new PatchProperty("PRIORITY");
        /// <summary>
        /// Constant PRODUCT for PatchProperty
        /// </summary>
        public static readonly PatchProperty PRODUCT = new PatchProperty("PRODUCT");
        /// <summary>
        /// Constant PRODUCT_FAMILY for PatchProperty
        /// </summary>
        public static readonly PatchProperty PRODUCT_FAMILY = new PatchProperty("PRODUCT_FAMILY");
        /// <summary>
        /// Constant SEVERITY for PatchProperty
        /// </summary>
        public static readonly PatchProperty SEVERITY = new PatchProperty("SEVERITY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PatchProperty(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PatchProperty FindValue(string value)
        {
            return FindValue<PatchProperty>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PatchProperty(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PatchSet.
    /// </summary>
    public class PatchSet : ConstantClass
    {

        /// <summary>
        /// Constant APPLICATION for PatchSet
        /// </summary>
        public static readonly PatchSet APPLICATION = new PatchSet("APPLICATION");
        /// <summary>
        /// Constant OS for PatchSet
        /// </summary>
        public static readonly PatchSet OS = new PatchSet("OS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PatchSet(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PatchSet FindValue(string value)
        {
            return FindValue<PatchSet>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PatchSet(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PingStatus.
    /// </summary>
    public class PingStatus : ConstantClass
    {

        /// <summary>
        /// Constant ConnectionLost for PingStatus
        /// </summary>
        public static readonly PingStatus ConnectionLost = new PingStatus("ConnectionLost");
        /// <summary>
        /// Constant Inactive for PingStatus
        /// </summary>
        public static readonly PingStatus Inactive = new PingStatus("Inactive");
        /// <summary>
        /// Constant Online for PingStatus
        /// </summary>
        public static readonly PingStatus Online = new PingStatus("Online");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PingStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PingStatus FindValue(string value)
        {
            return FindValue<PingStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PingStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlatformType.
    /// </summary>
    public class PlatformType : ConstantClass
    {

        /// <summary>
        /// Constant Linux for PlatformType
        /// </summary>
        public static readonly PlatformType Linux = new PlatformType("Linux");
        /// <summary>
        /// Constant MacOS for PlatformType
        /// </summary>
        public static readonly PlatformType MacOS = new PlatformType("MacOS");
        /// <summary>
        /// Constant Windows for PlatformType
        /// </summary>
        public static readonly PlatformType Windows = new PlatformType("Windows");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlatformType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlatformType FindValue(string value)
        {
            return FindValue<PlatformType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlatformType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RebootOption.
    /// </summary>
    public class RebootOption : ConstantClass
    {

        /// <summary>
        /// Constant NoReboot for RebootOption
        /// </summary>
        public static readonly RebootOption NoReboot = new RebootOption("NoReboot");
        /// <summary>
        /// Constant RebootIfNeeded for RebootOption
        /// </summary>
        public static readonly RebootOption RebootIfNeeded = new RebootOption("RebootIfNeeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RebootOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RebootOption FindValue(string value)
        {
            return FindValue<RebootOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RebootOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceDataSyncS3Format.
    /// </summary>
    public class ResourceDataSyncS3Format : ConstantClass
    {

        /// <summary>
        /// Constant JsonSerDe for ResourceDataSyncS3Format
        /// </summary>
        public static readonly ResourceDataSyncS3Format JsonSerDe = new ResourceDataSyncS3Format("JsonSerDe");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceDataSyncS3Format(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceDataSyncS3Format FindValue(string value)
        {
            return FindValue<ResourceDataSyncS3Format>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceDataSyncS3Format(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceType.
    /// </summary>
    public class ResourceType : ConstantClass
    {

        /// <summary>
        /// Constant Document for ResourceType
        /// </summary>
        public static readonly ResourceType Document = new ResourceType("Document");
        /// <summary>
        /// Constant EC2Instance for ResourceType
        /// </summary>
        public static readonly ResourceType EC2Instance = new ResourceType("EC2Instance");
        /// <summary>
        /// Constant ManagedInstance for ResourceType
        /// </summary>
        public static readonly ResourceType ManagedInstance = new ResourceType("ManagedInstance");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceType FindValue(string value)
        {
            return FindValue<ResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceTypeForTagging.
    /// </summary>
    public class ResourceTypeForTagging : ConstantClass
    {

        /// <summary>
        /// Constant Association for ResourceTypeForTagging
        /// </summary>
        public static readonly ResourceTypeForTagging Association = new ResourceTypeForTagging("Association");
        /// <summary>
        /// Constant Automation for ResourceTypeForTagging
        /// </summary>
        public static readonly ResourceTypeForTagging Automation = new ResourceTypeForTagging("Automation");
        /// <summary>
        /// Constant Document for ResourceTypeForTagging
        /// </summary>
        public static readonly ResourceTypeForTagging Document = new ResourceTypeForTagging("Document");
        /// <summary>
        /// Constant MaintenanceWindow for ResourceTypeForTagging
        /// </summary>
        public static readonly ResourceTypeForTagging MaintenanceWindow = new ResourceTypeForTagging("MaintenanceWindow");
        /// <summary>
        /// Constant ManagedInstance for ResourceTypeForTagging
        /// </summary>
        public static readonly ResourceTypeForTagging ManagedInstance = new ResourceTypeForTagging("ManagedInstance");
        /// <summary>
        /// Constant OpsItem for ResourceTypeForTagging
        /// </summary>
        public static readonly ResourceTypeForTagging OpsItem = new ResourceTypeForTagging("OpsItem");
        /// <summary>
        /// Constant OpsMetadata for ResourceTypeForTagging
        /// </summary>
        public static readonly ResourceTypeForTagging OpsMetadata = new ResourceTypeForTagging("OpsMetadata");
        /// <summary>
        /// Constant Parameter for ResourceTypeForTagging
        /// </summary>
        public static readonly ResourceTypeForTagging Parameter = new ResourceTypeForTagging("Parameter");
        /// <summary>
        /// Constant PatchBaseline for ResourceTypeForTagging
        /// </summary>
        public static readonly ResourceTypeForTagging PatchBaseline = new ResourceTypeForTagging("PatchBaseline");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceTypeForTagging(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceTypeForTagging FindValue(string value)
        {
            return FindValue<ResourceTypeForTagging>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceTypeForTagging(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReviewStatus.
    /// </summary>
    public class ReviewStatus : ConstantClass
    {

        /// <summary>
        /// Constant APPROVED for ReviewStatus
        /// </summary>
        public static readonly ReviewStatus APPROVED = new ReviewStatus("APPROVED");
        /// <summary>
        /// Constant NOT_REVIEWED for ReviewStatus
        /// </summary>
        public static readonly ReviewStatus NOT_REVIEWED = new ReviewStatus("NOT_REVIEWED");
        /// <summary>
        /// Constant PENDING for ReviewStatus
        /// </summary>
        public static readonly ReviewStatus PENDING = new ReviewStatus("PENDING");
        /// <summary>
        /// Constant REJECTED for ReviewStatus
        /// </summary>
        public static readonly ReviewStatus REJECTED = new ReviewStatus("REJECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReviewStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReviewStatus FindValue(string value)
        {
            return FindValue<ReviewStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReviewStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SessionFilterKey.
    /// </summary>
    public class SessionFilterKey : ConstantClass
    {

        /// <summary>
        /// Constant InvokedAfter for SessionFilterKey
        /// </summary>
        public static readonly SessionFilterKey InvokedAfter = new SessionFilterKey("InvokedAfter");
        /// <summary>
        /// Constant InvokedBefore for SessionFilterKey
        /// </summary>
        public static readonly SessionFilterKey InvokedBefore = new SessionFilterKey("InvokedBefore");
        /// <summary>
        /// Constant Owner for SessionFilterKey
        /// </summary>
        public static readonly SessionFilterKey Owner = new SessionFilterKey("Owner");
        /// <summary>
        /// Constant SessionId for SessionFilterKey
        /// </summary>
        public static readonly SessionFilterKey SessionId = new SessionFilterKey("SessionId");
        /// <summary>
        /// Constant Status for SessionFilterKey
        /// </summary>
        public static readonly SessionFilterKey Status = new SessionFilterKey("Status");
        /// <summary>
        /// Constant Target for SessionFilterKey
        /// </summary>
        public static readonly SessionFilterKey Target = new SessionFilterKey("Target");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SessionFilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SessionFilterKey FindValue(string value)
        {
            return FindValue<SessionFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SessionFilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SessionState.
    /// </summary>
    public class SessionState : ConstantClass
    {

        /// <summary>
        /// Constant Active for SessionState
        /// </summary>
        public static readonly SessionState Active = new SessionState("Active");
        /// <summary>
        /// Constant History for SessionState
        /// </summary>
        public static readonly SessionState History = new SessionState("History");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SessionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SessionState FindValue(string value)
        {
            return FindValue<SessionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SessionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SessionStatus.
    /// </summary>
    public class SessionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Connected for SessionStatus
        /// </summary>
        public static readonly SessionStatus Connected = new SessionStatus("Connected");
        /// <summary>
        /// Constant Connecting for SessionStatus
        /// </summary>
        public static readonly SessionStatus Connecting = new SessionStatus("Connecting");
        /// <summary>
        /// Constant Disconnected for SessionStatus
        /// </summary>
        public static readonly SessionStatus Disconnected = new SessionStatus("Disconnected");
        /// <summary>
        /// Constant Failed for SessionStatus
        /// </summary>
        public static readonly SessionStatus Failed = new SessionStatus("Failed");
        /// <summary>
        /// Constant Terminated for SessionStatus
        /// </summary>
        public static readonly SessionStatus Terminated = new SessionStatus("Terminated");
        /// <summary>
        /// Constant Terminating for SessionStatus
        /// </summary>
        public static readonly SessionStatus Terminating = new SessionStatus("Terminating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SessionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SessionStatus FindValue(string value)
        {
            return FindValue<SessionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SessionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SignalType.
    /// </summary>
    public class SignalType : ConstantClass
    {

        /// <summary>
        /// Constant Approve for SignalType
        /// </summary>
        public static readonly SignalType Approve = new SignalType("Approve");
        /// <summary>
        /// Constant Reject for SignalType
        /// </summary>
        public static readonly SignalType Reject = new SignalType("Reject");
        /// <summary>
        /// Constant Resume for SignalType
        /// </summary>
        public static readonly SignalType Resume = new SignalType("Resume");
        /// <summary>
        /// Constant StartStep for SignalType
        /// </summary>
        public static readonly SignalType StartStep = new SignalType("StartStep");
        /// <summary>
        /// Constant StopStep for SignalType
        /// </summary>
        public static readonly SignalType StopStep = new SignalType("StopStep");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SignalType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SignalType FindValue(string value)
        {
            return FindValue<SignalType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SignalType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SourceType.
    /// </summary>
    public class SourceType : ConstantClass
    {

        /// <summary>
        /// Constant AWSEC2Instance for SourceType
        /// </summary>
        public static readonly SourceType AWSEC2Instance = new SourceType("AWS::EC2::Instance");
        /// <summary>
        /// Constant AWSIoTThing for SourceType
        /// </summary>
        public static readonly SourceType AWSIoTThing = new SourceType("AWS::IoT::Thing");
        /// <summary>
        /// Constant AWSSSMManagedInstance for SourceType
        /// </summary>
        public static readonly SourceType AWSSSMManagedInstance = new SourceType("AWS::SSM::ManagedInstance");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceType FindValue(string value)
        {
            return FindValue<SourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StepExecutionFilterKey.
    /// </summary>
    public class StepExecutionFilterKey : ConstantClass
    {

        /// <summary>
        /// Constant Action for StepExecutionFilterKey
        /// </summary>
        public static readonly StepExecutionFilterKey Action = new StepExecutionFilterKey("Action");
        /// <summary>
        /// Constant StartTimeAfter for StepExecutionFilterKey
        /// </summary>
        public static readonly StepExecutionFilterKey StartTimeAfter = new StepExecutionFilterKey("StartTimeAfter");
        /// <summary>
        /// Constant StartTimeBefore for StepExecutionFilterKey
        /// </summary>
        public static readonly StepExecutionFilterKey StartTimeBefore = new StepExecutionFilterKey("StartTimeBefore");
        /// <summary>
        /// Constant StepExecutionId for StepExecutionFilterKey
        /// </summary>
        public static readonly StepExecutionFilterKey StepExecutionId = new StepExecutionFilterKey("StepExecutionId");
        /// <summary>
        /// Constant StepExecutionStatus for StepExecutionFilterKey
        /// </summary>
        public static readonly StepExecutionFilterKey StepExecutionStatus = new StepExecutionFilterKey("StepExecutionStatus");
        /// <summary>
        /// Constant StepName for StepExecutionFilterKey
        /// </summary>
        public static readonly StepExecutionFilterKey StepName = new StepExecutionFilterKey("StepName");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StepExecutionFilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StepExecutionFilterKey FindValue(string value)
        {
            return FindValue<StepExecutionFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StepExecutionFilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StopType.
    /// </summary>
    public class StopType : ConstantClass
    {

        /// <summary>
        /// Constant Cancel for StopType
        /// </summary>
        public static readonly StopType Cancel = new StopType("Cancel");
        /// <summary>
        /// Constant Complete for StopType
        /// </summary>
        public static readonly StopType Complete = new StopType("Complete");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StopType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StopType FindValue(string value)
        {
            return FindValue<StopType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StopType(string value)
        {
            return FindValue(value);
        }
    }

}