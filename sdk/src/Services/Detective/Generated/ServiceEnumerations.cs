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
 * Do not modify this file. This file is generated from the detective-2018-10-26.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Detective
{

    /// <summary>
    /// Constants used for properties of type DatasourcePackage.
    /// </summary>
    public class DatasourcePackage : ConstantClass
    {

        /// <summary>
        /// Constant ASFF_SECURITYHUB_FINDING for DatasourcePackage
        /// </summary>
        public static readonly DatasourcePackage ASFF_SECURITYHUB_FINDING = new DatasourcePackage("ASFF_SECURITYHUB_FINDING");
        /// <summary>
        /// Constant DETECTIVE_CORE for DatasourcePackage
        /// </summary>
        public static readonly DatasourcePackage DETECTIVE_CORE = new DatasourcePackage("DETECTIVE_CORE");
        /// <summary>
        /// Constant EKS_AUDIT for DatasourcePackage
        /// </summary>
        public static readonly DatasourcePackage EKS_AUDIT = new DatasourcePackage("EKS_AUDIT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatasourcePackage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatasourcePackage FindValue(string value)
        {
            return FindValue<DatasourcePackage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatasourcePackage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DatasourcePackageIngestState.
    /// </summary>
    public class DatasourcePackageIngestState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for DatasourcePackageIngestState
        /// </summary>
        public static readonly DatasourcePackageIngestState DISABLED = new DatasourcePackageIngestState("DISABLED");
        /// <summary>
        /// Constant STARTED for DatasourcePackageIngestState
        /// </summary>
        public static readonly DatasourcePackageIngestState STARTED = new DatasourcePackageIngestState("STARTED");
        /// <summary>
        /// Constant STOPPED for DatasourcePackageIngestState
        /// </summary>
        public static readonly DatasourcePackageIngestState STOPPED = new DatasourcePackageIngestState("STOPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatasourcePackageIngestState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatasourcePackageIngestState FindValue(string value)
        {
            return FindValue<DatasourcePackageIngestState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatasourcePackageIngestState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EntityType.
    /// </summary>
    public class EntityType : ConstantClass
    {

        /// <summary>
        /// Constant IAM_ROLE for EntityType
        /// </summary>
        public static readonly EntityType IAM_ROLE = new EntityType("IAM_ROLE");
        /// <summary>
        /// Constant IAM_USER for EntityType
        /// </summary>
        public static readonly EntityType IAM_USER = new EntityType("IAM_USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EntityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EntityType FindValue(string value)
        {
            return FindValue<EntityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EntityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ErrorCode.
    /// </summary>
    public class ErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant INTERNAL_ERROR for ErrorCode
        /// </summary>
        public static readonly ErrorCode INTERNAL_ERROR = new ErrorCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant INVALID_GRAPH_ARN for ErrorCode
        /// </summary>
        public static readonly ErrorCode INVALID_GRAPH_ARN = new ErrorCode("INVALID_GRAPH_ARN");
        /// <summary>
        /// Constant INVALID_REQUEST_BODY for ErrorCode
        /// </summary>
        public static readonly ErrorCode INVALID_REQUEST_BODY = new ErrorCode("INVALID_REQUEST_BODY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ErrorCode FindValue(string value)
        {
            return FindValue<ErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Field.
    /// </summary>
    public class Field : ConstantClass
    {

        /// <summary>
        /// Constant CREATED_TIME for Field
        /// </summary>
        public static readonly Field CREATED_TIME = new Field("CREATED_TIME");
        /// <summary>
        /// Constant SEVERITY for Field
        /// </summary>
        public static readonly Field SEVERITY = new Field("SEVERITY");
        /// <summary>
        /// Constant STATUS for Field
        /// </summary>
        public static readonly Field STATUS = new Field("STATUS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Field(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Field FindValue(string value)
        {
            return FindValue<Field>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Field(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IndicatorType.
    /// </summary>
    public class IndicatorType : ConstantClass
    {

        /// <summary>
        /// Constant FLAGGED_IP_ADDRESS for IndicatorType
        /// </summary>
        public static readonly IndicatorType FLAGGED_IP_ADDRESS = new IndicatorType("FLAGGED_IP_ADDRESS");
        /// <summary>
        /// Constant IMPOSSIBLE_TRAVEL for IndicatorType
        /// </summary>
        public static readonly IndicatorType IMPOSSIBLE_TRAVEL = new IndicatorType("IMPOSSIBLE_TRAVEL");
        /// <summary>
        /// Constant NEW_ASO for IndicatorType
        /// </summary>
        public static readonly IndicatorType NEW_ASO = new IndicatorType("NEW_ASO");
        /// <summary>
        /// Constant NEW_GEOLOCATION for IndicatorType
        /// </summary>
        public static readonly IndicatorType NEW_GEOLOCATION = new IndicatorType("NEW_GEOLOCATION");
        /// <summary>
        /// Constant NEW_USER_AGENT for IndicatorType
        /// </summary>
        public static readonly IndicatorType NEW_USER_AGENT = new IndicatorType("NEW_USER_AGENT");
        /// <summary>
        /// Constant RELATED_FINDING for IndicatorType
        /// </summary>
        public static readonly IndicatorType RELATED_FINDING = new IndicatorType("RELATED_FINDING");
        /// <summary>
        /// Constant RELATED_FINDING_GROUP for IndicatorType
        /// </summary>
        public static readonly IndicatorType RELATED_FINDING_GROUP = new IndicatorType("RELATED_FINDING_GROUP");
        /// <summary>
        /// Constant TTP_OBSERVED for IndicatorType
        /// </summary>
        public static readonly IndicatorType TTP_OBSERVED = new IndicatorType("TTP_OBSERVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IndicatorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IndicatorType FindValue(string value)
        {
            return FindValue<IndicatorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IndicatorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InvitationType.
    /// </summary>
    public class InvitationType : ConstantClass
    {

        /// <summary>
        /// Constant INVITATION for InvitationType
        /// </summary>
        public static readonly InvitationType INVITATION = new InvitationType("INVITATION");
        /// <summary>
        /// Constant ORGANIZATION for InvitationType
        /// </summary>
        public static readonly InvitationType ORGANIZATION = new InvitationType("ORGANIZATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InvitationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InvitationType FindValue(string value)
        {
            return FindValue<InvitationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InvitationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MemberDisabledReason.
    /// </summary>
    public class MemberDisabledReason : ConstantClass
    {

        /// <summary>
        /// Constant VOLUME_TOO_HIGH for MemberDisabledReason
        /// </summary>
        public static readonly MemberDisabledReason VOLUME_TOO_HIGH = new MemberDisabledReason("VOLUME_TOO_HIGH");
        /// <summary>
        /// Constant VOLUME_UNKNOWN for MemberDisabledReason
        /// </summary>
        public static readonly MemberDisabledReason VOLUME_UNKNOWN = new MemberDisabledReason("VOLUME_UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MemberDisabledReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MemberDisabledReason FindValue(string value)
        {
            return FindValue<MemberDisabledReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MemberDisabledReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MemberStatus.
    /// </summary>
    public class MemberStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACCEPTED_BUT_DISABLED for MemberStatus
        /// </summary>
        public static readonly MemberStatus ACCEPTED_BUT_DISABLED = new MemberStatus("ACCEPTED_BUT_DISABLED");
        /// <summary>
        /// Constant ENABLED for MemberStatus
        /// </summary>
        public static readonly MemberStatus ENABLED = new MemberStatus("ENABLED");
        /// <summary>
        /// Constant INVITED for MemberStatus
        /// </summary>
        public static readonly MemberStatus INVITED = new MemberStatus("INVITED");
        /// <summary>
        /// Constant VERIFICATION_FAILED for MemberStatus
        /// </summary>
        public static readonly MemberStatus VERIFICATION_FAILED = new MemberStatus("VERIFICATION_FAILED");
        /// <summary>
        /// Constant VERIFICATION_IN_PROGRESS for MemberStatus
        /// </summary>
        public static readonly MemberStatus VERIFICATION_IN_PROGRESS = new MemberStatus("VERIFICATION_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MemberStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MemberStatus FindValue(string value)
        {
            return FindValue<MemberStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MemberStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Reason.
    /// </summary>
    public class Reason : ConstantClass
    {

        /// <summary>
        /// Constant AWS_THREAT_INTELLIGENCE for Reason
        /// </summary>
        public static readonly Reason AWS_THREAT_INTELLIGENCE = new Reason("AWS_THREAT_INTELLIGENCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Reason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Reason FindValue(string value)
        {
            return FindValue<Reason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Reason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Severity.
    /// </summary>
    public class Severity : ConstantClass
    {

        /// <summary>
        /// Constant CRITICAL for Severity
        /// </summary>
        public static readonly Severity CRITICAL = new Severity("CRITICAL");
        /// <summary>
        /// Constant HIGH for Severity
        /// </summary>
        public static readonly Severity HIGH = new Severity("HIGH");
        /// <summary>
        /// Constant INFORMATIONAL for Severity
        /// </summary>
        public static readonly Severity INFORMATIONAL = new Severity("INFORMATIONAL");
        /// <summary>
        /// Constant LOW for Severity
        /// </summary>
        public static readonly Severity LOW = new Severity("LOW");
        /// <summary>
        /// Constant MEDIUM for Severity
        /// </summary>
        public static readonly Severity MEDIUM = new Severity("MEDIUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Severity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Severity FindValue(string value)
        {
            return FindValue<Severity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Severity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortOrder.
    /// </summary>
    public class SortOrder : ConstantClass
    {

        /// <summary>
        /// Constant ASC for SortOrder
        /// </summary>
        public static readonly SortOrder ASC = new SortOrder("ASC");
        /// <summary>
        /// Constant DESC for SortOrder
        /// </summary>
        public static readonly SortOrder DESC = new SortOrder("DESC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortOrder FindValue(string value)
        {
            return FindValue<SortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type State.
    /// </summary>
    public class State : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for State
        /// </summary>
        public static readonly State ACTIVE = new State("ACTIVE");
        /// <summary>
        /// Constant ARCHIVED for State
        /// </summary>
        public static readonly State ARCHIVED = new State("ARCHIVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public State(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static State FindValue(string value)
        {
            return FindValue<State>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator State(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Status.
    /// </summary>
    public class Status : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for Status
        /// </summary>
        public static readonly Status FAILED = new Status("FAILED");
        /// <summary>
        /// Constant RUNNING for Status
        /// </summary>
        public static readonly Status RUNNING = new Status("RUNNING");
        /// <summary>
        /// Constant SUCCESSFUL for Status
        /// </summary>
        public static readonly Status SUCCESSFUL = new Status("SUCCESSFUL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Status(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Status FindValue(string value)
        {
            return FindValue<Status>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Status(string value)
        {
            return FindValue(value);
        }
    }

}