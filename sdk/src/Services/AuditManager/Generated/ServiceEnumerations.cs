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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.AuditManager
{

    /// <summary>
    /// Constants used for properties of type AccountStatus.
    /// </summary>
    public class AccountStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for AccountStatus
        /// </summary>
        public static readonly AccountStatus ACTIVE = new AccountStatus("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for AccountStatus
        /// </summary>
        public static readonly AccountStatus INACTIVE = new AccountStatus("INACTIVE");
        /// <summary>
        /// Constant PENDING_ACTIVATION for AccountStatus
        /// </summary>
        public static readonly AccountStatus PENDING_ACTIVATION = new AccountStatus("PENDING_ACTIVATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccountStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccountStatus FindValue(string value)
        {
            return FindValue<AccountStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccountStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ActionEnum.
    /// </summary>
    public class ActionEnum : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ActionEnum
        /// </summary>
        public static readonly ActionEnum ACTIVE = new ActionEnum("ACTIVE");
        /// <summary>
        /// Constant CREATE for ActionEnum
        /// </summary>
        public static readonly ActionEnum CREATE = new ActionEnum("CREATE");
        /// <summary>
        /// Constant DELETE for ActionEnum
        /// </summary>
        public static readonly ActionEnum DELETE = new ActionEnum("DELETE");
        /// <summary>
        /// Constant IMPORT_EVIDENCE for ActionEnum
        /// </summary>
        public static readonly ActionEnum IMPORT_EVIDENCE = new ActionEnum("IMPORT_EVIDENCE");
        /// <summary>
        /// Constant INACTIVE for ActionEnum
        /// </summary>
        public static readonly ActionEnum INACTIVE = new ActionEnum("INACTIVE");
        /// <summary>
        /// Constant REVIEWED for ActionEnum
        /// </summary>
        public static readonly ActionEnum REVIEWED = new ActionEnum("REVIEWED");
        /// <summary>
        /// Constant UNDER_REVIEW for ActionEnum
        /// </summary>
        public static readonly ActionEnum UNDER_REVIEW = new ActionEnum("UNDER_REVIEW");
        /// <summary>
        /// Constant UPDATE_METADATA for ActionEnum
        /// </summary>
        public static readonly ActionEnum UPDATE_METADATA = new ActionEnum("UPDATE_METADATA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionEnum FindValue(string value)
        {
            return FindValue<ActionEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssessmentReportDestinationType.
    /// </summary>
    public class AssessmentReportDestinationType : ConstantClass
    {

        /// <summary>
        /// Constant S3 for AssessmentReportDestinationType
        /// </summary>
        public static readonly AssessmentReportDestinationType S3 = new AssessmentReportDestinationType("S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssessmentReportDestinationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssessmentReportDestinationType FindValue(string value)
        {
            return FindValue<AssessmentReportDestinationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssessmentReportDestinationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssessmentReportStatus.
    /// </summary>
    public class AssessmentReportStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for AssessmentReportStatus
        /// </summary>
        public static readonly AssessmentReportStatus COMPLETE = new AssessmentReportStatus("COMPLETE");
        /// <summary>
        /// Constant FAILED for AssessmentReportStatus
        /// </summary>
        public static readonly AssessmentReportStatus FAILED = new AssessmentReportStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for AssessmentReportStatus
        /// </summary>
        public static readonly AssessmentReportStatus IN_PROGRESS = new AssessmentReportStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssessmentReportStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssessmentReportStatus FindValue(string value)
        {
            return FindValue<AssessmentReportStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssessmentReportStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssessmentStatus.
    /// </summary>
    public class AssessmentStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for AssessmentStatus
        /// </summary>
        public static readonly AssessmentStatus ACTIVE = new AssessmentStatus("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for AssessmentStatus
        /// </summary>
        public static readonly AssessmentStatus INACTIVE = new AssessmentStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssessmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssessmentStatus FindValue(string value)
        {
            return FindValue<AssessmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssessmentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ControlResponse.
    /// </summary>
    public class ControlResponse : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATE for ControlResponse
        /// </summary>
        public static readonly ControlResponse AUTOMATE = new ControlResponse("AUTOMATE");
        /// <summary>
        /// Constant DEFER for ControlResponse
        /// </summary>
        public static readonly ControlResponse DEFER = new ControlResponse("DEFER");
        /// <summary>
        /// Constant IGNORE for ControlResponse
        /// </summary>
        public static readonly ControlResponse IGNORE = new ControlResponse("IGNORE");
        /// <summary>
        /// Constant MANUAL for ControlResponse
        /// </summary>
        public static readonly ControlResponse MANUAL = new ControlResponse("MANUAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ControlResponse(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ControlResponse FindValue(string value)
        {
            return FindValue<ControlResponse>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ControlResponse(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ControlSetStatus.
    /// </summary>
    public class ControlSetStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ControlSetStatus
        /// </summary>
        public static readonly ControlSetStatus ACTIVE = new ControlSetStatus("ACTIVE");
        /// <summary>
        /// Constant REVIEWED for ControlSetStatus
        /// </summary>
        public static readonly ControlSetStatus REVIEWED = new ControlSetStatus("REVIEWED");
        /// <summary>
        /// Constant UNDER_REVIEW for ControlSetStatus
        /// </summary>
        public static readonly ControlSetStatus UNDER_REVIEW = new ControlSetStatus("UNDER_REVIEW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ControlSetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ControlSetStatus FindValue(string value)
        {
            return FindValue<ControlSetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ControlSetStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ControlStatus.
    /// </summary>
    public class ControlStatus : ConstantClass
    {

        /// <summary>
        /// Constant INACTIVE for ControlStatus
        /// </summary>
        public static readonly ControlStatus INACTIVE = new ControlStatus("INACTIVE");
        /// <summary>
        /// Constant REVIEWED for ControlStatus
        /// </summary>
        public static readonly ControlStatus REVIEWED = new ControlStatus("REVIEWED");
        /// <summary>
        /// Constant UNDER_REVIEW for ControlStatus
        /// </summary>
        public static readonly ControlStatus UNDER_REVIEW = new ControlStatus("UNDER_REVIEW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ControlStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ControlStatus FindValue(string value)
        {
            return FindValue<ControlStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ControlStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ControlType.
    /// </summary>
    public class ControlType : ConstantClass
    {

        /// <summary>
        /// Constant Custom for ControlType
        /// </summary>
        public static readonly ControlType Custom = new ControlType("Custom");
        /// <summary>
        /// Constant Standard for ControlType
        /// </summary>
        public static readonly ControlType Standard = new ControlType("Standard");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ControlType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ControlType FindValue(string value)
        {
            return FindValue<ControlType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ControlType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DelegationStatus.
    /// </summary>
    public class DelegationStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for DelegationStatus
        /// </summary>
        public static readonly DelegationStatus COMPLETE = new DelegationStatus("COMPLETE");
        /// <summary>
        /// Constant IN_PROGRESS for DelegationStatus
        /// </summary>
        public static readonly DelegationStatus IN_PROGRESS = new DelegationStatus("IN_PROGRESS");
        /// <summary>
        /// Constant UNDER_REVIEW for DelegationStatus
        /// </summary>
        public static readonly DelegationStatus UNDER_REVIEW = new DelegationStatus("UNDER_REVIEW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DelegationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DelegationStatus FindValue(string value)
        {
            return FindValue<DelegationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DelegationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeleteResources.
    /// </summary>
    public class DeleteResources : ConstantClass
    {

        /// <summary>
        /// Constant ALL for DeleteResources
        /// </summary>
        public static readonly DeleteResources ALL = new DeleteResources("ALL");
        /// <summary>
        /// Constant DEFAULT for DeleteResources
        /// </summary>
        public static readonly DeleteResources DEFAULT = new DeleteResources("DEFAULT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeleteResources(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeleteResources FindValue(string value)
        {
            return FindValue<DeleteResources>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeleteResources(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EvidenceFinderBackfillStatus.
    /// </summary>
    public class EvidenceFinderBackfillStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for EvidenceFinderBackfillStatus
        /// </summary>
        public static readonly EvidenceFinderBackfillStatus COMPLETED = new EvidenceFinderBackfillStatus("COMPLETED");
        /// <summary>
        /// Constant IN_PROGRESS for EvidenceFinderBackfillStatus
        /// </summary>
        public static readonly EvidenceFinderBackfillStatus IN_PROGRESS = new EvidenceFinderBackfillStatus("IN_PROGRESS");
        /// <summary>
        /// Constant NOT_STARTED for EvidenceFinderBackfillStatus
        /// </summary>
        public static readonly EvidenceFinderBackfillStatus NOT_STARTED = new EvidenceFinderBackfillStatus("NOT_STARTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EvidenceFinderBackfillStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EvidenceFinderBackfillStatus FindValue(string value)
        {
            return FindValue<EvidenceFinderBackfillStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EvidenceFinderBackfillStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EvidenceFinderEnablementStatus.
    /// </summary>
    public class EvidenceFinderEnablementStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLE_IN_PROGRESS for EvidenceFinderEnablementStatus
        /// </summary>
        public static readonly EvidenceFinderEnablementStatus DISABLE_IN_PROGRESS = new EvidenceFinderEnablementStatus("DISABLE_IN_PROGRESS");
        /// <summary>
        /// Constant DISABLED for EvidenceFinderEnablementStatus
        /// </summary>
        public static readonly EvidenceFinderEnablementStatus DISABLED = new EvidenceFinderEnablementStatus("DISABLED");
        /// <summary>
        /// Constant ENABLE_IN_PROGRESS for EvidenceFinderEnablementStatus
        /// </summary>
        public static readonly EvidenceFinderEnablementStatus ENABLE_IN_PROGRESS = new EvidenceFinderEnablementStatus("ENABLE_IN_PROGRESS");
        /// <summary>
        /// Constant ENABLED for EvidenceFinderEnablementStatus
        /// </summary>
        public static readonly EvidenceFinderEnablementStatus ENABLED = new EvidenceFinderEnablementStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EvidenceFinderEnablementStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EvidenceFinderEnablementStatus FindValue(string value)
        {
            return FindValue<EvidenceFinderEnablementStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EvidenceFinderEnablementStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FrameworkType.
    /// </summary>
    public class FrameworkType : ConstantClass
    {

        /// <summary>
        /// Constant Custom for FrameworkType
        /// </summary>
        public static readonly FrameworkType Custom = new FrameworkType("Custom");
        /// <summary>
        /// Constant Standard for FrameworkType
        /// </summary>
        public static readonly FrameworkType Standard = new FrameworkType("Standard");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FrameworkType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FrameworkType FindValue(string value)
        {
            return FindValue<FrameworkType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FrameworkType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KeywordInputType.
    /// </summary>
    public class KeywordInputType : ConstantClass
    {

        /// <summary>
        /// Constant SELECT_FROM_LIST for KeywordInputType
        /// </summary>
        public static readonly KeywordInputType SELECT_FROM_LIST = new KeywordInputType("SELECT_FROM_LIST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KeywordInputType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KeywordInputType FindValue(string value)
        {
            return FindValue<KeywordInputType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KeywordInputType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ObjectTypeEnum.
    /// </summary>
    public class ObjectTypeEnum : ConstantClass
    {

        /// <summary>
        /// Constant ASSESSMENT for ObjectTypeEnum
        /// </summary>
        public static readonly ObjectTypeEnum ASSESSMENT = new ObjectTypeEnum("ASSESSMENT");
        /// <summary>
        /// Constant ASSESSMENT_REPORT for ObjectTypeEnum
        /// </summary>
        public static readonly ObjectTypeEnum ASSESSMENT_REPORT = new ObjectTypeEnum("ASSESSMENT_REPORT");
        /// <summary>
        /// Constant CONTROL for ObjectTypeEnum
        /// </summary>
        public static readonly ObjectTypeEnum CONTROL = new ObjectTypeEnum("CONTROL");
        /// <summary>
        /// Constant CONTROL_SET for ObjectTypeEnum
        /// </summary>
        public static readonly ObjectTypeEnum CONTROL_SET = new ObjectTypeEnum("CONTROL_SET");
        /// <summary>
        /// Constant DELEGATION for ObjectTypeEnum
        /// </summary>
        public static readonly ObjectTypeEnum DELEGATION = new ObjectTypeEnum("DELEGATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ObjectTypeEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ObjectTypeEnum FindValue(string value)
        {
            return FindValue<ObjectTypeEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ObjectTypeEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RoleType.
    /// </summary>
    public class RoleType : ConstantClass
    {

        /// <summary>
        /// Constant PROCESS_OWNER for RoleType
        /// </summary>
        public static readonly RoleType PROCESS_OWNER = new RoleType("PROCESS_OWNER");
        /// <summary>
        /// Constant RESOURCE_OWNER for RoleType
        /// </summary>
        public static readonly RoleType RESOURCE_OWNER = new RoleType("RESOURCE_OWNER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RoleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RoleType FindValue(string value)
        {
            return FindValue<RoleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RoleType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SettingAttribute.
    /// </summary>
    public class SettingAttribute : ConstantClass
    {

        /// <summary>
        /// Constant ALL for SettingAttribute
        /// </summary>
        public static readonly SettingAttribute ALL = new SettingAttribute("ALL");
        /// <summary>
        /// Constant DEFAULT_ASSESSMENT_REPORTS_DESTINATION for SettingAttribute
        /// </summary>
        public static readonly SettingAttribute DEFAULT_ASSESSMENT_REPORTS_DESTINATION = new SettingAttribute("DEFAULT_ASSESSMENT_REPORTS_DESTINATION");
        /// <summary>
        /// Constant DEFAULT_PROCESS_OWNERS for SettingAttribute
        /// </summary>
        public static readonly SettingAttribute DEFAULT_PROCESS_OWNERS = new SettingAttribute("DEFAULT_PROCESS_OWNERS");
        /// <summary>
        /// Constant DEREGISTRATION_POLICY for SettingAttribute
        /// </summary>
        public static readonly SettingAttribute DEREGISTRATION_POLICY = new SettingAttribute("DEREGISTRATION_POLICY");
        /// <summary>
        /// Constant EVIDENCE_FINDER_ENABLEMENT for SettingAttribute
        /// </summary>
        public static readonly SettingAttribute EVIDENCE_FINDER_ENABLEMENT = new SettingAttribute("EVIDENCE_FINDER_ENABLEMENT");
        /// <summary>
        /// Constant IS_AWS_ORG_ENABLED for SettingAttribute
        /// </summary>
        public static readonly SettingAttribute IS_AWS_ORG_ENABLED = new SettingAttribute("IS_AWS_ORG_ENABLED");
        /// <summary>
        /// Constant SNS_TOPIC for SettingAttribute
        /// </summary>
        public static readonly SettingAttribute SNS_TOPIC = new SettingAttribute("SNS_TOPIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SettingAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SettingAttribute FindValue(string value)
        {
            return FindValue<SettingAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SettingAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ShareRequestAction.
    /// </summary>
    public class ShareRequestAction : ConstantClass
    {

        /// <summary>
        /// Constant ACCEPT for ShareRequestAction
        /// </summary>
        public static readonly ShareRequestAction ACCEPT = new ShareRequestAction("ACCEPT");
        /// <summary>
        /// Constant DECLINE for ShareRequestAction
        /// </summary>
        public static readonly ShareRequestAction DECLINE = new ShareRequestAction("DECLINE");
        /// <summary>
        /// Constant REVOKE for ShareRequestAction
        /// </summary>
        public static readonly ShareRequestAction REVOKE = new ShareRequestAction("REVOKE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ShareRequestAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ShareRequestAction FindValue(string value)
        {
            return FindValue<ShareRequestAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ShareRequestAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ShareRequestStatus.
    /// </summary>
    public class ShareRequestStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ShareRequestStatus
        /// </summary>
        public static readonly ShareRequestStatus ACTIVE = new ShareRequestStatus("ACTIVE");
        /// <summary>
        /// Constant DECLINED for ShareRequestStatus
        /// </summary>
        public static readonly ShareRequestStatus DECLINED = new ShareRequestStatus("DECLINED");
        /// <summary>
        /// Constant EXPIRED for ShareRequestStatus
        /// </summary>
        public static readonly ShareRequestStatus EXPIRED = new ShareRequestStatus("EXPIRED");
        /// <summary>
        /// Constant EXPIRING for ShareRequestStatus
        /// </summary>
        public static readonly ShareRequestStatus EXPIRING = new ShareRequestStatus("EXPIRING");
        /// <summary>
        /// Constant FAILED for ShareRequestStatus
        /// </summary>
        public static readonly ShareRequestStatus FAILED = new ShareRequestStatus("FAILED");
        /// <summary>
        /// Constant REPLICATING for ShareRequestStatus
        /// </summary>
        public static readonly ShareRequestStatus REPLICATING = new ShareRequestStatus("REPLICATING");
        /// <summary>
        /// Constant REVOKED for ShareRequestStatus
        /// </summary>
        public static readonly ShareRequestStatus REVOKED = new ShareRequestStatus("REVOKED");
        /// <summary>
        /// Constant SHARED for ShareRequestStatus
        /// </summary>
        public static readonly ShareRequestStatus SHARED = new ShareRequestStatus("SHARED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ShareRequestStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ShareRequestStatus FindValue(string value)
        {
            return FindValue<ShareRequestStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ShareRequestStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ShareRequestType.
    /// </summary>
    public class ShareRequestType : ConstantClass
    {

        /// <summary>
        /// Constant RECEIVED for ShareRequestType
        /// </summary>
        public static readonly ShareRequestType RECEIVED = new ShareRequestType("RECEIVED");
        /// <summary>
        /// Constant SENT for ShareRequestType
        /// </summary>
        public static readonly ShareRequestType SENT = new ShareRequestType("SENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ShareRequestType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ShareRequestType FindValue(string value)
        {
            return FindValue<ShareRequestType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ShareRequestType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SourceFrequency.
    /// </summary>
    public class SourceFrequency : ConstantClass
    {

        /// <summary>
        /// Constant DAILY for SourceFrequency
        /// </summary>
        public static readonly SourceFrequency DAILY = new SourceFrequency("DAILY");
        /// <summary>
        /// Constant MONTHLY for SourceFrequency
        /// </summary>
        public static readonly SourceFrequency MONTHLY = new SourceFrequency("MONTHLY");
        /// <summary>
        /// Constant WEEKLY for SourceFrequency
        /// </summary>
        public static readonly SourceFrequency WEEKLY = new SourceFrequency("WEEKLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceFrequency(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceFrequency FindValue(string value)
        {
            return FindValue<SourceFrequency>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceFrequency(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SourceSetUpOption.
    /// </summary>
    public class SourceSetUpOption : ConstantClass
    {

        /// <summary>
        /// Constant Procedural_Controls_Mapping for SourceSetUpOption
        /// </summary>
        public static readonly SourceSetUpOption Procedural_Controls_Mapping = new SourceSetUpOption("Procedural_Controls_Mapping");
        /// <summary>
        /// Constant System_Controls_Mapping for SourceSetUpOption
        /// </summary>
        public static readonly SourceSetUpOption System_Controls_Mapping = new SourceSetUpOption("System_Controls_Mapping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceSetUpOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceSetUpOption FindValue(string value)
        {
            return FindValue<SourceSetUpOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceSetUpOption(string value)
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
        /// Constant AWS_API_Call for SourceType
        /// </summary>
        public static readonly SourceType AWS_API_Call = new SourceType("AWS_API_Call");
        /// <summary>
        /// Constant AWS_Cloudtrail for SourceType
        /// </summary>
        public static readonly SourceType AWS_Cloudtrail = new SourceType("AWS_Cloudtrail");
        /// <summary>
        /// Constant AWS_Config for SourceType
        /// </summary>
        public static readonly SourceType AWS_Config = new SourceType("AWS_Config");
        /// <summary>
        /// Constant AWS_Security_Hub for SourceType
        /// </summary>
        public static readonly SourceType AWS_Security_Hub = new SourceType("AWS_Security_Hub");
        /// <summary>
        /// Constant MANUAL for SourceType
        /// </summary>
        public static readonly SourceType MANUAL = new SourceType("MANUAL");

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
    /// Constants used for properties of type ValidationExceptionReason.
    /// </summary>
    public class ValidationExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant CannotParse for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CannotParse = new ValidationExceptionReason("cannotParse");
        /// <summary>
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("fieldValidationFailed");
        /// <summary>
        /// Constant Other for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason Other = new ValidationExceptionReason("other");
        /// <summary>
        /// Constant UnknownOperation for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnknownOperation = new ValidationExceptionReason("unknownOperation");

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