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
 * Do not modify this file. This file is generated from the security-ir-2018-05-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SecurityIR
{

    /// <summary>
    /// Constants used for properties of type ActionType.
    /// </summary>
    public class ActionType : ConstantClass
    {

        /// <summary>
        /// Constant Evidence for ActionType
        /// </summary>
        public static readonly ActionType Evidence = new ActionType("Evidence");
        /// <summary>
        /// Constant Investigation for ActionType
        /// </summary>
        public static readonly ActionType Investigation = new ActionType("Investigation");
        /// <summary>
        /// Constant Summarization for ActionType
        /// </summary>
        public static readonly ActionType Summarization = new ActionType("Summarization");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionType FindValue(string value)
        {
            return FindValue<ActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AwsRegion.
    /// </summary>
    public class AwsRegion : ConstantClass
    {

        /// <summary>
        /// Constant AfSouth1 for AwsRegion
        /// </summary>
        public static readonly AwsRegion AfSouth1 = new AwsRegion("af-south-1");
        /// <summary>
        /// Constant ApEast1 for AwsRegion
        /// </summary>
        public static readonly AwsRegion ApEast1 = new AwsRegion("ap-east-1");
        /// <summary>
        /// Constant ApEast2 for AwsRegion
        /// </summary>
        public static readonly AwsRegion ApEast2 = new AwsRegion("ap-east-2");
        /// <summary>
        /// Constant ApNortheast1 for AwsRegion
        /// </summary>
        public static readonly AwsRegion ApNortheast1 = new AwsRegion("ap-northeast-1");
        /// <summary>
        /// Constant ApNortheast2 for AwsRegion
        /// </summary>
        public static readonly AwsRegion ApNortheast2 = new AwsRegion("ap-northeast-2");
        /// <summary>
        /// Constant ApNortheast3 for AwsRegion
        /// </summary>
        public static readonly AwsRegion ApNortheast3 = new AwsRegion("ap-northeast-3");
        /// <summary>
        /// Constant ApSouth1 for AwsRegion
        /// </summary>
        public static readonly AwsRegion ApSouth1 = new AwsRegion("ap-south-1");
        /// <summary>
        /// Constant ApSouth2 for AwsRegion
        /// </summary>
        public static readonly AwsRegion ApSouth2 = new AwsRegion("ap-south-2");
        /// <summary>
        /// Constant ApSoutheast1 for AwsRegion
        /// </summary>
        public static readonly AwsRegion ApSoutheast1 = new AwsRegion("ap-southeast-1");
        /// <summary>
        /// Constant ApSoutheast2 for AwsRegion
        /// </summary>
        public static readonly AwsRegion ApSoutheast2 = new AwsRegion("ap-southeast-2");
        /// <summary>
        /// Constant ApSoutheast3 for AwsRegion
        /// </summary>
        public static readonly AwsRegion ApSoutheast3 = new AwsRegion("ap-southeast-3");
        /// <summary>
        /// Constant ApSoutheast4 for AwsRegion
        /// </summary>
        public static readonly AwsRegion ApSoutheast4 = new AwsRegion("ap-southeast-4");
        /// <summary>
        /// Constant ApSoutheast5 for AwsRegion
        /// </summary>
        public static readonly AwsRegion ApSoutheast5 = new AwsRegion("ap-southeast-5");
        /// <summary>
        /// Constant ApSoutheast6 for AwsRegion
        /// </summary>
        public static readonly AwsRegion ApSoutheast6 = new AwsRegion("ap-southeast-6");
        /// <summary>
        /// Constant ApSoutheast7 for AwsRegion
        /// </summary>
        public static readonly AwsRegion ApSoutheast7 = new AwsRegion("ap-southeast-7");
        /// <summary>
        /// Constant CaCentral1 for AwsRegion
        /// </summary>
        public static readonly AwsRegion CaCentral1 = new AwsRegion("ca-central-1");
        /// <summary>
        /// Constant CaWest1 for AwsRegion
        /// </summary>
        public static readonly AwsRegion CaWest1 = new AwsRegion("ca-west-1");
        /// <summary>
        /// Constant CnNorth1 for AwsRegion
        /// </summary>
        public static readonly AwsRegion CnNorth1 = new AwsRegion("cn-north-1");
        /// <summary>
        /// Constant CnNorthwest1 for AwsRegion
        /// </summary>
        public static readonly AwsRegion CnNorthwest1 = new AwsRegion("cn-northwest-1");
        /// <summary>
        /// Constant EuCentral1 for AwsRegion
        /// </summary>
        public static readonly AwsRegion EuCentral1 = new AwsRegion("eu-central-1");
        /// <summary>
        /// Constant EuCentral2 for AwsRegion
        /// </summary>
        public static readonly AwsRegion EuCentral2 = new AwsRegion("eu-central-2");
        /// <summary>
        /// Constant EuNorth1 for AwsRegion
        /// </summary>
        public static readonly AwsRegion EuNorth1 = new AwsRegion("eu-north-1");
        /// <summary>
        /// Constant EuSouth1 for AwsRegion
        /// </summary>
        public static readonly AwsRegion EuSouth1 = new AwsRegion("eu-south-1");
        /// <summary>
        /// Constant EuSouth2 for AwsRegion
        /// </summary>
        public static readonly AwsRegion EuSouth2 = new AwsRegion("eu-south-2");
        /// <summary>
        /// Constant EuWest1 for AwsRegion
        /// </summary>
        public static readonly AwsRegion EuWest1 = new AwsRegion("eu-west-1");
        /// <summary>
        /// Constant EuWest2 for AwsRegion
        /// </summary>
        public static readonly AwsRegion EuWest2 = new AwsRegion("eu-west-2");
        /// <summary>
        /// Constant EuWest3 for AwsRegion
        /// </summary>
        public static readonly AwsRegion EuWest3 = new AwsRegion("eu-west-3");
        /// <summary>
        /// Constant IlCentral1 for AwsRegion
        /// </summary>
        public static readonly AwsRegion IlCentral1 = new AwsRegion("il-central-1");
        /// <summary>
        /// Constant MeCentral1 for AwsRegion
        /// </summary>
        public static readonly AwsRegion MeCentral1 = new AwsRegion("me-central-1");
        /// <summary>
        /// Constant MeSouth1 for AwsRegion
        /// </summary>
        public static readonly AwsRegion MeSouth1 = new AwsRegion("me-south-1");
        /// <summary>
        /// Constant MxCentral1 for AwsRegion
        /// </summary>
        public static readonly AwsRegion MxCentral1 = new AwsRegion("mx-central-1");
        /// <summary>
        /// Constant SaEast1 for AwsRegion
        /// </summary>
        public static readonly AwsRegion SaEast1 = new AwsRegion("sa-east-1");
        /// <summary>
        /// Constant UsEast1 for AwsRegion
        /// </summary>
        public static readonly AwsRegion UsEast1 = new AwsRegion("us-east-1");
        /// <summary>
        /// Constant UsEast2 for AwsRegion
        /// </summary>
        public static readonly AwsRegion UsEast2 = new AwsRegion("us-east-2");
        /// <summary>
        /// Constant UsWest1 for AwsRegion
        /// </summary>
        public static readonly AwsRegion UsWest1 = new AwsRegion("us-west-1");
        /// <summary>
        /// Constant UsWest2 for AwsRegion
        /// </summary>
        public static readonly AwsRegion UsWest2 = new AwsRegion("us-west-2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AwsRegion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AwsRegion FindValue(string value)
        {
            return FindValue<AwsRegion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AwsRegion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CaseAttachmentStatus.
    /// </summary>
    public class CaseAttachmentStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for CaseAttachmentStatus
        /// </summary>
        public static readonly CaseAttachmentStatus Failed = new CaseAttachmentStatus("Failed");
        /// <summary>
        /// Constant Pending for CaseAttachmentStatus
        /// </summary>
        public static readonly CaseAttachmentStatus Pending = new CaseAttachmentStatus("Pending");
        /// <summary>
        /// Constant Verified for CaseAttachmentStatus
        /// </summary>
        public static readonly CaseAttachmentStatus Verified = new CaseAttachmentStatus("Verified");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CaseAttachmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CaseAttachmentStatus FindValue(string value)
        {
            return FindValue<CaseAttachmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CaseAttachmentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CaseStatus.
    /// </summary>
    public class CaseStatus : ConstantClass
    {

        /// <summary>
        /// Constant Acknowledged for CaseStatus
        /// </summary>
        public static readonly CaseStatus Acknowledged = new CaseStatus("Acknowledged");
        /// <summary>
        /// Constant Closed for CaseStatus
        /// </summary>
        public static readonly CaseStatus Closed = new CaseStatus("Closed");
        /// <summary>
        /// Constant ContainmentEradicationAndRecovery for CaseStatus
        /// </summary>
        public static readonly CaseStatus ContainmentEradicationAndRecovery = new CaseStatus("Containment, Eradication and Recovery");
        /// <summary>
        /// Constant DetectionAndAnalysis for CaseStatus
        /// </summary>
        public static readonly CaseStatus DetectionAndAnalysis = new CaseStatus("Detection and Analysis");
        /// <summary>
        /// Constant PostIncidentActivities for CaseStatus
        /// </summary>
        public static readonly CaseStatus PostIncidentActivities = new CaseStatus("Post-incident Activities");
        /// <summary>
        /// Constant ReadyToClose for CaseStatus
        /// </summary>
        public static readonly CaseStatus ReadyToClose = new CaseStatus("Ready to Close");
        /// <summary>
        /// Constant Submitted for CaseStatus
        /// </summary>
        public static readonly CaseStatus Submitted = new CaseStatus("Submitted");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CaseStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CaseStatus FindValue(string value)
        {
            return FindValue<CaseStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CaseStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClosureCode.
    /// </summary>
    public class ClosureCode : ConstantClass
    {

        /// <summary>
        /// Constant Duplicate for ClosureCode
        /// </summary>
        public static readonly ClosureCode Duplicate = new ClosureCode("Duplicate");
        /// <summary>
        /// Constant FalsePositive for ClosureCode
        /// </summary>
        public static readonly ClosureCode FalsePositive = new ClosureCode("False Positive");
        /// <summary>
        /// Constant InvestigationCompleted for ClosureCode
        /// </summary>
        public static readonly ClosureCode InvestigationCompleted = new ClosureCode("Investigation Completed");
        /// <summary>
        /// Constant NotResolved for ClosureCode
        /// </summary>
        public static readonly ClosureCode NotResolved = new ClosureCode("Not Resolved");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClosureCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClosureCode FindValue(string value)
        {
            return FindValue<ClosureCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClosureCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CommunicationType.
    /// </summary>
    public class CommunicationType : ConstantClass
    {

        /// <summary>
        /// Constant CaseAcknowledged for CommunicationType
        /// </summary>
        public static readonly CommunicationType CaseAcknowledged = new CommunicationType("Case Acknowledged");
        /// <summary>
        /// Constant CaseAttachmentUrlUploaded for CommunicationType
        /// </summary>
        public static readonly CommunicationType CaseAttachmentUrlUploaded = new CommunicationType("Case Attachment Url Uploaded");
        /// <summary>
        /// Constant CaseClosed for CommunicationType
        /// </summary>
        public static readonly CommunicationType CaseClosed = new CommunicationType("Case Closed");
        /// <summary>
        /// Constant CaseCommentAdded for CommunicationType
        /// </summary>
        public static readonly CommunicationType CaseCommentAdded = new CommunicationType("Case Comment Added");
        /// <summary>
        /// Constant CaseCommentUpdated for CommunicationType
        /// </summary>
        public static readonly CommunicationType CaseCommentUpdated = new CommunicationType("Case Comment Updated");
        /// <summary>
        /// Constant CaseCreated for CommunicationType
        /// </summary>
        public static readonly CommunicationType CaseCreated = new CommunicationType("Case Created");
        /// <summary>
        /// Constant CasePendingCustomerActionReminder for CommunicationType
        /// </summary>
        public static readonly CommunicationType CasePendingCustomerActionReminder = new CommunicationType("Case Pending Customer Action Reminder");
        /// <summary>
        /// Constant CaseStatusUpdated for CommunicationType
        /// </summary>
        public static readonly CommunicationType CaseStatusUpdated = new CommunicationType("Case Status Updated");
        /// <summary>
        /// Constant CaseUpdated for CommunicationType
        /// </summary>
        public static readonly CommunicationType CaseUpdated = new CommunicationType("Case Updated");
        /// <summary>
        /// Constant CaseUpdatedToServiceManaged for CommunicationType
        /// </summary>
        public static readonly CommunicationType CaseUpdatedToServiceManaged = new CommunicationType("Case Updated To Service Managed");
        /// <summary>
        /// Constant DeregisterDelegatedAdministrator for CommunicationType
        /// </summary>
        public static readonly CommunicationType DeregisterDelegatedAdministrator = new CommunicationType("Deregister Delegated Administrator");
        /// <summary>
        /// Constant DisableAWSServiceAccess for CommunicationType
        /// </summary>
        public static readonly CommunicationType DisableAWSServiceAccess = new CommunicationType("Disable AWS Service Access");
        /// <summary>
        /// Constant MembershipCancelled for CommunicationType
        /// </summary>
        public static readonly CommunicationType MembershipCancelled = new CommunicationType("Membership Cancelled");
        /// <summary>
        /// Constant MembershipCreated for CommunicationType
        /// </summary>
        public static readonly CommunicationType MembershipCreated = new CommunicationType("Membership Created");
        /// <summary>
        /// Constant MembershipUpdated for CommunicationType
        /// </summary>
        public static readonly CommunicationType MembershipUpdated = new CommunicationType("Membership Updated");
        /// <summary>
        /// Constant RegisterDelegatedAdministrator for CommunicationType
        /// </summary>
        public static readonly CommunicationType RegisterDelegatedAdministrator = new CommunicationType("Register Delegated Administrator");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CommunicationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CommunicationType FindValue(string value)
        {
            return FindValue<CommunicationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CommunicationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CustomerType.
    /// </summary>
    public class CustomerType : ConstantClass
    {

        /// <summary>
        /// Constant Organization for CustomerType
        /// </summary>
        public static readonly CustomerType Organization = new CustomerType("Organization");
        /// <summary>
        /// Constant Standalone for CustomerType
        /// </summary>
        public static readonly CustomerType Standalone = new CustomerType("Standalone");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomerType FindValue(string value)
        {
            return FindValue<CustomerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EngagementType.
    /// </summary>
    public class EngagementType : ConstantClass
    {

        /// <summary>
        /// Constant Investigation for EngagementType
        /// </summary>
        public static readonly EngagementType Investigation = new EngagementType("Investigation");
        /// <summary>
        /// Constant SecurityIncident for EngagementType
        /// </summary>
        public static readonly EngagementType SecurityIncident = new EngagementType("Security Incident");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EngagementType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EngagementType FindValue(string value)
        {
            return FindValue<EngagementType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EngagementType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionStatus.
    /// </summary>
    public class ExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Cancelled for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus Cancelled = new ExecutionStatus("Cancelled");
        /// <summary>
        /// Constant Completed for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus Completed = new ExecutionStatus("Completed");
        /// <summary>
        /// Constant Failed for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus Failed = new ExecutionStatus("Failed");
        /// <summary>
        /// Constant InProgress for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus InProgress = new ExecutionStatus("InProgress");
        /// <summary>
        /// Constant Pending for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus Pending = new ExecutionStatus("Pending");
        /// <summary>
        /// Constant Waiting for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus Waiting = new ExecutionStatus("Waiting");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionStatus FindValue(string value)
        {
            return FindValue<ExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MembershipAccountRelationshipStatus.
    /// </summary>
    public class MembershipAccountRelationshipStatus : ConstantClass
    {

        /// <summary>
        /// Constant Associated for MembershipAccountRelationshipStatus
        /// </summary>
        public static readonly MembershipAccountRelationshipStatus Associated = new MembershipAccountRelationshipStatus("Associated");
        /// <summary>
        /// Constant Disassociated for MembershipAccountRelationshipStatus
        /// </summary>
        public static readonly MembershipAccountRelationshipStatus Disassociated = new MembershipAccountRelationshipStatus("Disassociated");
        /// <summary>
        /// Constant Unassociated for MembershipAccountRelationshipStatus
        /// </summary>
        public static readonly MembershipAccountRelationshipStatus Unassociated = new MembershipAccountRelationshipStatus("Unassociated");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MembershipAccountRelationshipStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MembershipAccountRelationshipStatus FindValue(string value)
        {
            return FindValue<MembershipAccountRelationshipStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MembershipAccountRelationshipStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MembershipAccountRelationshipType.
    /// </summary>
    public class MembershipAccountRelationshipType : ConstantClass
    {

        /// <summary>
        /// Constant Organization for MembershipAccountRelationshipType
        /// </summary>
        public static readonly MembershipAccountRelationshipType Organization = new MembershipAccountRelationshipType("Organization");
        /// <summary>
        /// Constant Unrelated for MembershipAccountRelationshipType
        /// </summary>
        public static readonly MembershipAccountRelationshipType Unrelated = new MembershipAccountRelationshipType("Unrelated");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MembershipAccountRelationshipType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MembershipAccountRelationshipType FindValue(string value)
        {
            return FindValue<MembershipAccountRelationshipType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MembershipAccountRelationshipType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MembershipStatus.
    /// </summary>
    public class MembershipStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for MembershipStatus
        /// </summary>
        public static readonly MembershipStatus Active = new MembershipStatus("Active");
        /// <summary>
        /// Constant Cancelled for MembershipStatus
        /// </summary>
        public static readonly MembershipStatus Cancelled = new MembershipStatus("Cancelled");
        /// <summary>
        /// Constant Terminated for MembershipStatus
        /// </summary>
        public static readonly MembershipStatus Terminated = new MembershipStatus("Terminated");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MembershipStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MembershipStatus FindValue(string value)
        {
            return FindValue<MembershipStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MembershipStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OptInFeatureName.
    /// </summary>
    public class OptInFeatureName : ConstantClass
    {

        /// <summary>
        /// Constant Triage for OptInFeatureName
        /// </summary>
        public static readonly OptInFeatureName Triage = new OptInFeatureName("Triage");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OptInFeatureName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OptInFeatureName FindValue(string value)
        {
            return FindValue<OptInFeatureName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OptInFeatureName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PendingAction.
    /// </summary>
    public class PendingAction : ConstantClass
    {

        /// <summary>
        /// Constant Customer for PendingAction
        /// </summary>
        public static readonly PendingAction Customer = new PendingAction("Customer");
        /// <summary>
        /// Constant None for PendingAction
        /// </summary>
        public static readonly PendingAction None = new PendingAction("None");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PendingAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PendingAction FindValue(string value)
        {
            return FindValue<PendingAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PendingAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResolverType.
    /// </summary>
    public class ResolverType : ConstantClass
    {

        /// <summary>
        /// Constant AWS for ResolverType
        /// </summary>
        public static readonly ResolverType AWS = new ResolverType("AWS");
        /// <summary>
        /// Constant Self for ResolverType
        /// </summary>
        public static readonly ResolverType Self = new ResolverType("Self");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResolverType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResolverType FindValue(string value)
        {
            return FindValue<ResolverType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResolverType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SelfManagedCaseStatus.
    /// </summary>
    public class SelfManagedCaseStatus : ConstantClass
    {

        /// <summary>
        /// Constant ContainmentEradicationAndRecovery for SelfManagedCaseStatus
        /// </summary>
        public static readonly SelfManagedCaseStatus ContainmentEradicationAndRecovery = new SelfManagedCaseStatus("Containment, Eradication and Recovery");
        /// <summary>
        /// Constant DetectionAndAnalysis for SelfManagedCaseStatus
        /// </summary>
        public static readonly SelfManagedCaseStatus DetectionAndAnalysis = new SelfManagedCaseStatus("Detection and Analysis");
        /// <summary>
        /// Constant PostIncidentActivities for SelfManagedCaseStatus
        /// </summary>
        public static readonly SelfManagedCaseStatus PostIncidentActivities = new SelfManagedCaseStatus("Post-incident Activities");
        /// <summary>
        /// Constant Submitted for SelfManagedCaseStatus
        /// </summary>
        public static readonly SelfManagedCaseStatus Submitted = new SelfManagedCaseStatus("Submitted");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SelfManagedCaseStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SelfManagedCaseStatus FindValue(string value)
        {
            return FindValue<SelfManagedCaseStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SelfManagedCaseStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UsefulnessRating.
    /// </summary>
    public class UsefulnessRating : ConstantClass
    {

        /// <summary>
        /// Constant NOT_USEFUL for UsefulnessRating
        /// </summary>
        public static readonly UsefulnessRating NOT_USEFUL = new UsefulnessRating("NOT_USEFUL");
        /// <summary>
        /// Constant USEFUL for UsefulnessRating
        /// </summary>
        public static readonly UsefulnessRating USEFUL = new UsefulnessRating("USEFUL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UsefulnessRating(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UsefulnessRating FindValue(string value)
        {
            return FindValue<UsefulnessRating>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UsefulnessRating(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationExceptionReason.
    /// </summary>
    public class ValidationExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant CANNOT_PARSE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CANNOT_PARSE = new ValidationExceptionReason("CANNOT_PARSE");
        /// <summary>
        /// Constant FIELD_VALIDATION_FAILED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FIELD_VALIDATION_FAILED = new ValidationExceptionReason("FIELD_VALIDATION_FAILED");
        /// <summary>
        /// Constant OTHER for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason OTHER = new ValidationExceptionReason("OTHER");
        /// <summary>
        /// Constant UNKNOWN_OPERATION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UNKNOWN_OPERATION = new ValidationExceptionReason("UNKNOWN_OPERATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionReason FindValue(string value)
        {
            return FindValue<ValidationExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionReason(string value)
        {
            return FindValue(value);
        }
    }

}