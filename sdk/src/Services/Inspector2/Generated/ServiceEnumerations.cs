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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Inspector2
{

    /// <summary>
    /// Constants used for properties of type AccountSortBy.
    /// </summary>
    public class AccountSortBy : ConstantClass
    {

        /// <summary>
        /// Constant ALL for AccountSortBy
        /// </summary>
        public static readonly AccountSortBy ALL = new AccountSortBy("ALL");
        /// <summary>
        /// Constant CRITICAL for AccountSortBy
        /// </summary>
        public static readonly AccountSortBy CRITICAL = new AccountSortBy("CRITICAL");
        /// <summary>
        /// Constant HIGH for AccountSortBy
        /// </summary>
        public static readonly AccountSortBy HIGH = new AccountSortBy("HIGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccountSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccountSortBy FindValue(string value)
        {
            return FindValue<AccountSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccountSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AggregationFindingType.
    /// </summary>
    public class AggregationFindingType : ConstantClass
    {

        /// <summary>
        /// Constant CODE_VULNERABILITY for AggregationFindingType
        /// </summary>
        public static readonly AggregationFindingType CODE_VULNERABILITY = new AggregationFindingType("CODE_VULNERABILITY");
        /// <summary>
        /// Constant NETWORK_REACHABILITY for AggregationFindingType
        /// </summary>
        public static readonly AggregationFindingType NETWORK_REACHABILITY = new AggregationFindingType("NETWORK_REACHABILITY");
        /// <summary>
        /// Constant PACKAGE_VULNERABILITY for AggregationFindingType
        /// </summary>
        public static readonly AggregationFindingType PACKAGE_VULNERABILITY = new AggregationFindingType("PACKAGE_VULNERABILITY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AggregationFindingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AggregationFindingType FindValue(string value)
        {
            return FindValue<AggregationFindingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AggregationFindingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AggregationResourceType.
    /// </summary>
    public class AggregationResourceType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_EC2_INSTANCE for AggregationResourceType
        /// </summary>
        public static readonly AggregationResourceType AWS_EC2_INSTANCE = new AggregationResourceType("AWS_EC2_INSTANCE");
        /// <summary>
        /// Constant AWS_ECR_CONTAINER_IMAGE for AggregationResourceType
        /// </summary>
        public static readonly AggregationResourceType AWS_ECR_CONTAINER_IMAGE = new AggregationResourceType("AWS_ECR_CONTAINER_IMAGE");
        /// <summary>
        /// Constant AWS_LAMBDA_FUNCTION for AggregationResourceType
        /// </summary>
        public static readonly AggregationResourceType AWS_LAMBDA_FUNCTION = new AggregationResourceType("AWS_LAMBDA_FUNCTION");
        /// <summary>
        /// Constant CODE_REPOSITORY for AggregationResourceType
        /// </summary>
        public static readonly AggregationResourceType CODE_REPOSITORY = new AggregationResourceType("CODE_REPOSITORY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AggregationResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AggregationResourceType FindValue(string value)
        {
            return FindValue<AggregationResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AggregationResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AggregationType.
    /// </summary>
    public class AggregationType : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT for AggregationType
        /// </summary>
        public static readonly AggregationType ACCOUNT = new AggregationType("ACCOUNT");
        /// <summary>
        /// Constant AMI for AggregationType
        /// </summary>
        public static readonly AggregationType AMI = new AggregationType("AMI");
        /// <summary>
        /// Constant AWS_EC2_INSTANCE for AggregationType
        /// </summary>
        public static readonly AggregationType AWS_EC2_INSTANCE = new AggregationType("AWS_EC2_INSTANCE");
        /// <summary>
        /// Constant AWS_ECR_CONTAINER for AggregationType
        /// </summary>
        public static readonly AggregationType AWS_ECR_CONTAINER = new AggregationType("AWS_ECR_CONTAINER");
        /// <summary>
        /// Constant AWS_LAMBDA_FUNCTION for AggregationType
        /// </summary>
        public static readonly AggregationType AWS_LAMBDA_FUNCTION = new AggregationType("AWS_LAMBDA_FUNCTION");
        /// <summary>
        /// Constant CODE_REPOSITORY for AggregationType
        /// </summary>
        public static readonly AggregationType CODE_REPOSITORY = new AggregationType("CODE_REPOSITORY");
        /// <summary>
        /// Constant FINDING_TYPE for AggregationType
        /// </summary>
        public static readonly AggregationType FINDING_TYPE = new AggregationType("FINDING_TYPE");
        /// <summary>
        /// Constant IMAGE_LAYER for AggregationType
        /// </summary>
        public static readonly AggregationType IMAGE_LAYER = new AggregationType("IMAGE_LAYER");
        /// <summary>
        /// Constant LAMBDA_LAYER for AggregationType
        /// </summary>
        public static readonly AggregationType LAMBDA_LAYER = new AggregationType("LAMBDA_LAYER");
        /// <summary>
        /// Constant PACKAGE for AggregationType
        /// </summary>
        public static readonly AggregationType PACKAGE = new AggregationType("PACKAGE");
        /// <summary>
        /// Constant REPOSITORY for AggregationType
        /// </summary>
        public static readonly AggregationType REPOSITORY = new AggregationType("REPOSITORY");
        /// <summary>
        /// Constant TITLE for AggregationType
        /// </summary>
        public static readonly AggregationType TITLE = new AggregationType("TITLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AggregationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AggregationType FindValue(string value)
        {
            return FindValue<AggregationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AggregationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AmiSortBy.
    /// </summary>
    public class AmiSortBy : ConstantClass
    {

        /// <summary>
        /// Constant AFFECTED_INSTANCES for AmiSortBy
        /// </summary>
        public static readonly AmiSortBy AFFECTED_INSTANCES = new AmiSortBy("AFFECTED_INSTANCES");
        /// <summary>
        /// Constant ALL for AmiSortBy
        /// </summary>
        public static readonly AmiSortBy ALL = new AmiSortBy("ALL");
        /// <summary>
        /// Constant CRITICAL for AmiSortBy
        /// </summary>
        public static readonly AmiSortBy CRITICAL = new AmiSortBy("CRITICAL");
        /// <summary>
        /// Constant HIGH for AmiSortBy
        /// </summary>
        public static readonly AmiSortBy HIGH = new AmiSortBy("HIGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AmiSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AmiSortBy FindValue(string value)
        {
            return FindValue<AmiSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AmiSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Architecture.
    /// </summary>
    public class Architecture : ConstantClass
    {

        /// <summary>
        /// Constant ARM64 for Architecture
        /// </summary>
        public static readonly Architecture ARM64 = new Architecture("ARM64");
        /// <summary>
        /// Constant X86_64 for Architecture
        /// </summary>
        public static readonly Architecture X86_64 = new Architecture("X86_64");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Architecture(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Architecture FindValue(string value)
        {
            return FindValue<Architecture>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Architecture(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssociationResultStatusCode.
    /// </summary>
    public class AssociationResultStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for AssociationResultStatusCode
        /// </summary>
        public static readonly AssociationResultStatusCode ACCESS_DENIED = new AssociationResultStatusCode("ACCESS_DENIED");
        /// <summary>
        /// Constant INTERNAL_ERROR for AssociationResultStatusCode
        /// </summary>
        public static readonly AssociationResultStatusCode INTERNAL_ERROR = new AssociationResultStatusCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant INVALID_INPUT for AssociationResultStatusCode
        /// </summary>
        public static readonly AssociationResultStatusCode INVALID_INPUT = new AssociationResultStatusCode("INVALID_INPUT");
        /// <summary>
        /// Constant QUOTA_EXCEEDED for AssociationResultStatusCode
        /// </summary>
        public static readonly AssociationResultStatusCode QUOTA_EXCEEDED = new AssociationResultStatusCode("QUOTA_EXCEEDED");
        /// <summary>
        /// Constant RESOURCE_NOT_FOUND for AssociationResultStatusCode
        /// </summary>
        public static readonly AssociationResultStatusCode RESOURCE_NOT_FOUND = new AssociationResultStatusCode("RESOURCE_NOT_FOUND");
        /// <summary>
        /// Constant SCAN_CONFIGURATION_NOT_FOUND for AssociationResultStatusCode
        /// </summary>
        public static readonly AssociationResultStatusCode SCAN_CONFIGURATION_NOT_FOUND = new AssociationResultStatusCode("SCAN_CONFIGURATION_NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssociationResultStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssociationResultStatusCode FindValue(string value)
        {
            return FindValue<AssociationResultStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssociationResultStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AwsEcrContainerSortBy.
    /// </summary>
    public class AwsEcrContainerSortBy : ConstantClass
    {

        /// <summary>
        /// Constant ALL for AwsEcrContainerSortBy
        /// </summary>
        public static readonly AwsEcrContainerSortBy ALL = new AwsEcrContainerSortBy("ALL");
        /// <summary>
        /// Constant CRITICAL for AwsEcrContainerSortBy
        /// </summary>
        public static readonly AwsEcrContainerSortBy CRITICAL = new AwsEcrContainerSortBy("CRITICAL");
        /// <summary>
        /// Constant HIGH for AwsEcrContainerSortBy
        /// </summary>
        public static readonly AwsEcrContainerSortBy HIGH = new AwsEcrContainerSortBy("HIGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AwsEcrContainerSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AwsEcrContainerSortBy FindValue(string value)
        {
            return FindValue<AwsEcrContainerSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AwsEcrContainerSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CisFindingStatus.
    /// </summary>
    public class CisFindingStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for CisFindingStatus
        /// </summary>
        public static readonly CisFindingStatus FAILED = new CisFindingStatus("FAILED");
        /// <summary>
        /// Constant PASSED for CisFindingStatus
        /// </summary>
        public static readonly CisFindingStatus PASSED = new CisFindingStatus("PASSED");
        /// <summary>
        /// Constant SKIPPED for CisFindingStatus
        /// </summary>
        public static readonly CisFindingStatus SKIPPED = new CisFindingStatus("SKIPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CisFindingStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CisFindingStatus FindValue(string value)
        {
            return FindValue<CisFindingStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CisFindingStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CisFindingStatusComparison.
    /// </summary>
    public class CisFindingStatusComparison : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS for CisFindingStatusComparison
        /// </summary>
        public static readonly CisFindingStatusComparison EQUALS = new CisFindingStatusComparison("EQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CisFindingStatusComparison(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CisFindingStatusComparison FindValue(string value)
        {
            return FindValue<CisFindingStatusComparison>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CisFindingStatusComparison(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CisReportFormat.
    /// </summary>
    public class CisReportFormat : ConstantClass
    {

        /// <summary>
        /// Constant CSV for CisReportFormat
        /// </summary>
        public static readonly CisReportFormat CSV = new CisReportFormat("CSV");
        /// <summary>
        /// Constant PDF for CisReportFormat
        /// </summary>
        public static readonly CisReportFormat PDF = new CisReportFormat("PDF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CisReportFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CisReportFormat FindValue(string value)
        {
            return FindValue<CisReportFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CisReportFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CisReportStatus.
    /// </summary>
    public class CisReportStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for CisReportStatus
        /// </summary>
        public static readonly CisReportStatus FAILED = new CisReportStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for CisReportStatus
        /// </summary>
        public static readonly CisReportStatus IN_PROGRESS = new CisReportStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCEEDED for CisReportStatus
        /// </summary>
        public static readonly CisReportStatus SUCCEEDED = new CisReportStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CisReportStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CisReportStatus FindValue(string value)
        {
            return FindValue<CisReportStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CisReportStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CisResultStatus.
    /// </summary>
    public class CisResultStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for CisResultStatus
        /// </summary>
        public static readonly CisResultStatus FAILED = new CisResultStatus("FAILED");
        /// <summary>
        /// Constant PASSED for CisResultStatus
        /// </summary>
        public static readonly CisResultStatus PASSED = new CisResultStatus("PASSED");
        /// <summary>
        /// Constant SKIPPED for CisResultStatus
        /// </summary>
        public static readonly CisResultStatus SKIPPED = new CisResultStatus("SKIPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CisResultStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CisResultStatus FindValue(string value)
        {
            return FindValue<CisResultStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CisResultStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CisResultStatusComparison.
    /// </summary>
    public class CisResultStatusComparison : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS for CisResultStatusComparison
        /// </summary>
        public static readonly CisResultStatusComparison EQUALS = new CisResultStatusComparison("EQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CisResultStatusComparison(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CisResultStatusComparison FindValue(string value)
        {
            return FindValue<CisResultStatusComparison>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CisResultStatusComparison(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CisRuleStatus.
    /// </summary>
    public class CisRuleStatus : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for CisRuleStatus
        /// </summary>
        public static readonly CisRuleStatus ERROR = new CisRuleStatus("ERROR");
        /// <summary>
        /// Constant FAILED for CisRuleStatus
        /// </summary>
        public static readonly CisRuleStatus FAILED = new CisRuleStatus("FAILED");
        /// <summary>
        /// Constant INFORMATIONAL for CisRuleStatus
        /// </summary>
        public static readonly CisRuleStatus INFORMATIONAL = new CisRuleStatus("INFORMATIONAL");
        /// <summary>
        /// Constant NOT_APPLICABLE for CisRuleStatus
        /// </summary>
        public static readonly CisRuleStatus NOT_APPLICABLE = new CisRuleStatus("NOT_APPLICABLE");
        /// <summary>
        /// Constant NOT_EVALUATED for CisRuleStatus
        /// </summary>
        public static readonly CisRuleStatus NOT_EVALUATED = new CisRuleStatus("NOT_EVALUATED");
        /// <summary>
        /// Constant PASSED for CisRuleStatus
        /// </summary>
        public static readonly CisRuleStatus PASSED = new CisRuleStatus("PASSED");
        /// <summary>
        /// Constant UNKNOWN for CisRuleStatus
        /// </summary>
        public static readonly CisRuleStatus UNKNOWN = new CisRuleStatus("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CisRuleStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CisRuleStatus FindValue(string value)
        {
            return FindValue<CisRuleStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CisRuleStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CisScanConfigurationsSortBy.
    /// </summary>
    public class CisScanConfigurationsSortBy : ConstantClass
    {

        /// <summary>
        /// Constant SCAN_CONFIGURATION_ARN for CisScanConfigurationsSortBy
        /// </summary>
        public static readonly CisScanConfigurationsSortBy SCAN_CONFIGURATION_ARN = new CisScanConfigurationsSortBy("SCAN_CONFIGURATION_ARN");
        /// <summary>
        /// Constant SCAN_NAME for CisScanConfigurationsSortBy
        /// </summary>
        public static readonly CisScanConfigurationsSortBy SCAN_NAME = new CisScanConfigurationsSortBy("SCAN_NAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CisScanConfigurationsSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CisScanConfigurationsSortBy FindValue(string value)
        {
            return FindValue<CisScanConfigurationsSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CisScanConfigurationsSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CisScanResultDetailsSortBy.
    /// </summary>
    public class CisScanResultDetailsSortBy : ConstantClass
    {

        /// <summary>
        /// Constant CHECK_ID for CisScanResultDetailsSortBy
        /// </summary>
        public static readonly CisScanResultDetailsSortBy CHECK_ID = new CisScanResultDetailsSortBy("CHECK_ID");
        /// <summary>
        /// Constant STATUS for CisScanResultDetailsSortBy
        /// </summary>
        public static readonly CisScanResultDetailsSortBy STATUS = new CisScanResultDetailsSortBy("STATUS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CisScanResultDetailsSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CisScanResultDetailsSortBy FindValue(string value)
        {
            return FindValue<CisScanResultDetailsSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CisScanResultDetailsSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CisScanResultsAggregatedByChecksSortBy.
    /// </summary>
    public class CisScanResultsAggregatedByChecksSortBy : ConstantClass
    {

        /// <summary>
        /// Constant CHECK_ID for CisScanResultsAggregatedByChecksSortBy
        /// </summary>
        public static readonly CisScanResultsAggregatedByChecksSortBy CHECK_ID = new CisScanResultsAggregatedByChecksSortBy("CHECK_ID");
        /// <summary>
        /// Constant FAILED_COUNTS for CisScanResultsAggregatedByChecksSortBy
        /// </summary>
        public static readonly CisScanResultsAggregatedByChecksSortBy FAILED_COUNTS = new CisScanResultsAggregatedByChecksSortBy("FAILED_COUNTS");
        /// <summary>
        /// Constant PLATFORM for CisScanResultsAggregatedByChecksSortBy
        /// </summary>
        public static readonly CisScanResultsAggregatedByChecksSortBy PLATFORM = new CisScanResultsAggregatedByChecksSortBy("PLATFORM");
        /// <summary>
        /// Constant SECURITY_LEVEL for CisScanResultsAggregatedByChecksSortBy
        /// </summary>
        public static readonly CisScanResultsAggregatedByChecksSortBy SECURITY_LEVEL = new CisScanResultsAggregatedByChecksSortBy("SECURITY_LEVEL");
        /// <summary>
        /// Constant TITLE for CisScanResultsAggregatedByChecksSortBy
        /// </summary>
        public static readonly CisScanResultsAggregatedByChecksSortBy TITLE = new CisScanResultsAggregatedByChecksSortBy("TITLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CisScanResultsAggregatedByChecksSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CisScanResultsAggregatedByChecksSortBy FindValue(string value)
        {
            return FindValue<CisScanResultsAggregatedByChecksSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CisScanResultsAggregatedByChecksSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CisScanResultsAggregatedByTargetResourceSortBy.
    /// </summary>
    public class CisScanResultsAggregatedByTargetResourceSortBy : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_ID for CisScanResultsAggregatedByTargetResourceSortBy
        /// </summary>
        public static readonly CisScanResultsAggregatedByTargetResourceSortBy ACCOUNT_ID = new CisScanResultsAggregatedByTargetResourceSortBy("ACCOUNT_ID");
        /// <summary>
        /// Constant FAILED_COUNTS for CisScanResultsAggregatedByTargetResourceSortBy
        /// </summary>
        public static readonly CisScanResultsAggregatedByTargetResourceSortBy FAILED_COUNTS = new CisScanResultsAggregatedByTargetResourceSortBy("FAILED_COUNTS");
        /// <summary>
        /// Constant PLATFORM for CisScanResultsAggregatedByTargetResourceSortBy
        /// </summary>
        public static readonly CisScanResultsAggregatedByTargetResourceSortBy PLATFORM = new CisScanResultsAggregatedByTargetResourceSortBy("PLATFORM");
        /// <summary>
        /// Constant RESOURCE_ID for CisScanResultsAggregatedByTargetResourceSortBy
        /// </summary>
        public static readonly CisScanResultsAggregatedByTargetResourceSortBy RESOURCE_ID = new CisScanResultsAggregatedByTargetResourceSortBy("RESOURCE_ID");
        /// <summary>
        /// Constant TARGET_STATUS for CisScanResultsAggregatedByTargetResourceSortBy
        /// </summary>
        public static readonly CisScanResultsAggregatedByTargetResourceSortBy TARGET_STATUS = new CisScanResultsAggregatedByTargetResourceSortBy("TARGET_STATUS");
        /// <summary>
        /// Constant TARGET_STATUS_REASON for CisScanResultsAggregatedByTargetResourceSortBy
        /// </summary>
        public static readonly CisScanResultsAggregatedByTargetResourceSortBy TARGET_STATUS_REASON = new CisScanResultsAggregatedByTargetResourceSortBy("TARGET_STATUS_REASON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CisScanResultsAggregatedByTargetResourceSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CisScanResultsAggregatedByTargetResourceSortBy FindValue(string value)
        {
            return FindValue<CisScanResultsAggregatedByTargetResourceSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CisScanResultsAggregatedByTargetResourceSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CisScanStatus.
    /// </summary>
    public class CisScanStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for CisScanStatus
        /// </summary>
        public static readonly CisScanStatus CANCELLED = new CisScanStatus("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for CisScanStatus
        /// </summary>
        public static readonly CisScanStatus COMPLETED = new CisScanStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for CisScanStatus
        /// </summary>
        public static readonly CisScanStatus FAILED = new CisScanStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for CisScanStatus
        /// </summary>
        public static readonly CisScanStatus IN_PROGRESS = new CisScanStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CisScanStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CisScanStatus FindValue(string value)
        {
            return FindValue<CisScanStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CisScanStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CisScanStatusComparison.
    /// </summary>
    public class CisScanStatusComparison : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS for CisScanStatusComparison
        /// </summary>
        public static readonly CisScanStatusComparison EQUALS = new CisScanStatusComparison("EQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CisScanStatusComparison(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CisScanStatusComparison FindValue(string value)
        {
            return FindValue<CisScanStatusComparison>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CisScanStatusComparison(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CisSecurityLevel.
    /// </summary>
    public class CisSecurityLevel : ConstantClass
    {

        /// <summary>
        /// Constant LEVEL_1 for CisSecurityLevel
        /// </summary>
        public static readonly CisSecurityLevel LEVEL_1 = new CisSecurityLevel("LEVEL_1");
        /// <summary>
        /// Constant LEVEL_2 for CisSecurityLevel
        /// </summary>
        public static readonly CisSecurityLevel LEVEL_2 = new CisSecurityLevel("LEVEL_2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CisSecurityLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CisSecurityLevel FindValue(string value)
        {
            return FindValue<CisSecurityLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CisSecurityLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CisSecurityLevelComparison.
    /// </summary>
    public class CisSecurityLevelComparison : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS for CisSecurityLevelComparison
        /// </summary>
        public static readonly CisSecurityLevelComparison EQUALS = new CisSecurityLevelComparison("EQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CisSecurityLevelComparison(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CisSecurityLevelComparison FindValue(string value)
        {
            return FindValue<CisSecurityLevelComparison>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CisSecurityLevelComparison(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CisSortOrder.
    /// </summary>
    public class CisSortOrder : ConstantClass
    {

        /// <summary>
        /// Constant ASC for CisSortOrder
        /// </summary>
        public static readonly CisSortOrder ASC = new CisSortOrder("ASC");
        /// <summary>
        /// Constant DESC for CisSortOrder
        /// </summary>
        public static readonly CisSortOrder DESC = new CisSortOrder("DESC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CisSortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CisSortOrder FindValue(string value)
        {
            return FindValue<CisSortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CisSortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CisStringComparison.
    /// </summary>
    public class CisStringComparison : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS for CisStringComparison
        /// </summary>
        public static readonly CisStringComparison EQUALS = new CisStringComparison("EQUALS");
        /// <summary>
        /// Constant NOT_EQUALS for CisStringComparison
        /// </summary>
        public static readonly CisStringComparison NOT_EQUALS = new CisStringComparison("NOT_EQUALS");
        /// <summary>
        /// Constant PREFIX for CisStringComparison
        /// </summary>
        public static readonly CisStringComparison PREFIX = new CisStringComparison("PREFIX");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CisStringComparison(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CisStringComparison FindValue(string value)
        {
            return FindValue<CisStringComparison>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CisStringComparison(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CisTargetStatus.
    /// </summary>
    public class CisTargetStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for CisTargetStatus
        /// </summary>
        public static readonly CisTargetStatus CANCELLED = new CisTargetStatus("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for CisTargetStatus
        /// </summary>
        public static readonly CisTargetStatus COMPLETED = new CisTargetStatus("COMPLETED");
        /// <summary>
        /// Constant TIMED_OUT for CisTargetStatus
        /// </summary>
        public static readonly CisTargetStatus TIMED_OUT = new CisTargetStatus("TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CisTargetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CisTargetStatus FindValue(string value)
        {
            return FindValue<CisTargetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CisTargetStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CisTargetStatusComparison.
    /// </summary>
    public class CisTargetStatusComparison : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS for CisTargetStatusComparison
        /// </summary>
        public static readonly CisTargetStatusComparison EQUALS = new CisTargetStatusComparison("EQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CisTargetStatusComparison(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CisTargetStatusComparison FindValue(string value)
        {
            return FindValue<CisTargetStatusComparison>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CisTargetStatusComparison(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CisTargetStatusReason.
    /// </summary>
    public class CisTargetStatusReason : ConstantClass
    {

        /// <summary>
        /// Constant SCAN_IN_PROGRESS for CisTargetStatusReason
        /// </summary>
        public static readonly CisTargetStatusReason SCAN_IN_PROGRESS = new CisTargetStatusReason("SCAN_IN_PROGRESS");
        /// <summary>
        /// Constant SSM_UNMANAGED for CisTargetStatusReason
        /// </summary>
        public static readonly CisTargetStatusReason SSM_UNMANAGED = new CisTargetStatusReason("SSM_UNMANAGED");
        /// <summary>
        /// Constant UNSUPPORTED_OS for CisTargetStatusReason
        /// </summary>
        public static readonly CisTargetStatusReason UNSUPPORTED_OS = new CisTargetStatusReason("UNSUPPORTED_OS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CisTargetStatusReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CisTargetStatusReason FindValue(string value)
        {
            return FindValue<CisTargetStatusReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CisTargetStatusReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CodeRepositoryProviderType.
    /// </summary>
    public class CodeRepositoryProviderType : ConstantClass
    {

        /// <summary>
        /// Constant GITHUB for CodeRepositoryProviderType
        /// </summary>
        public static readonly CodeRepositoryProviderType GITHUB = new CodeRepositoryProviderType("GITHUB");
        /// <summary>
        /// Constant GITLAB_SELF_MANAGED for CodeRepositoryProviderType
        /// </summary>
        public static readonly CodeRepositoryProviderType GITLAB_SELF_MANAGED = new CodeRepositoryProviderType("GITLAB_SELF_MANAGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CodeRepositoryProviderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CodeRepositoryProviderType FindValue(string value)
        {
            return FindValue<CodeRepositoryProviderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CodeRepositoryProviderType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CodeRepositorySortBy.
    /// </summary>
    public class CodeRepositorySortBy : ConstantClass
    {

        /// <summary>
        /// Constant ALL for CodeRepositorySortBy
        /// </summary>
        public static readonly CodeRepositorySortBy ALL = new CodeRepositorySortBy("ALL");
        /// <summary>
        /// Constant CRITICAL for CodeRepositorySortBy
        /// </summary>
        public static readonly CodeRepositorySortBy CRITICAL = new CodeRepositorySortBy("CRITICAL");
        /// <summary>
        /// Constant HIGH for CodeRepositorySortBy
        /// </summary>
        public static readonly CodeRepositorySortBy HIGH = new CodeRepositorySortBy("HIGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CodeRepositorySortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CodeRepositorySortBy FindValue(string value)
        {
            return FindValue<CodeRepositorySortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CodeRepositorySortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CodeScanStatus.
    /// </summary>
    public class CodeScanStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for CodeScanStatus
        /// </summary>
        public static readonly CodeScanStatus FAILED = new CodeScanStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for CodeScanStatus
        /// </summary>
        public static readonly CodeScanStatus IN_PROGRESS = new CodeScanStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SKIPPED for CodeScanStatus
        /// </summary>
        public static readonly CodeScanStatus SKIPPED = new CodeScanStatus("SKIPPED");
        /// <summary>
        /// Constant SUCCESSFUL for CodeScanStatus
        /// </summary>
        public static readonly CodeScanStatus SUCCESSFUL = new CodeScanStatus("SUCCESSFUL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CodeScanStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CodeScanStatus FindValue(string value)
        {
            return FindValue<CodeScanStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CodeScanStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CodeSnippetErrorCode.
    /// </summary>
    public class CodeSnippetErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for CodeSnippetErrorCode
        /// </summary>
        public static readonly CodeSnippetErrorCode ACCESS_DENIED = new CodeSnippetErrorCode("ACCESS_DENIED");
        /// <summary>
        /// Constant CODE_SNIPPET_NOT_FOUND for CodeSnippetErrorCode
        /// </summary>
        public static readonly CodeSnippetErrorCode CODE_SNIPPET_NOT_FOUND = new CodeSnippetErrorCode("CODE_SNIPPET_NOT_FOUND");
        /// <summary>
        /// Constant INTERNAL_ERROR for CodeSnippetErrorCode
        /// </summary>
        public static readonly CodeSnippetErrorCode INTERNAL_ERROR = new CodeSnippetErrorCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant INVALID_INPUT for CodeSnippetErrorCode
        /// </summary>
        public static readonly CodeSnippetErrorCode INVALID_INPUT = new CodeSnippetErrorCode("INVALID_INPUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CodeSnippetErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CodeSnippetErrorCode FindValue(string value)
        {
            return FindValue<CodeSnippetErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CodeSnippetErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfigurationLevel.
    /// </summary>
    public class ConfigurationLevel : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT for ConfigurationLevel
        /// </summary>
        public static readonly ConfigurationLevel ACCOUNT = new ConfigurationLevel("ACCOUNT");
        /// <summary>
        /// Constant ORGANIZATION for ConfigurationLevel
        /// </summary>
        public static readonly ConfigurationLevel ORGANIZATION = new ConfigurationLevel("ORGANIZATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfigurationLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigurationLevel FindValue(string value)
        {
            return FindValue<ConfigurationLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfigurationLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContinuousIntegrationScanEvent.
    /// </summary>
    public class ContinuousIntegrationScanEvent : ConstantClass
    {

        /// <summary>
        /// Constant PULL_REQUEST for ContinuousIntegrationScanEvent
        /// </summary>
        public static readonly ContinuousIntegrationScanEvent PULL_REQUEST = new ContinuousIntegrationScanEvent("PULL_REQUEST");
        /// <summary>
        /// Constant PUSH for ContinuousIntegrationScanEvent
        /// </summary>
        public static readonly ContinuousIntegrationScanEvent PUSH = new ContinuousIntegrationScanEvent("PUSH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContinuousIntegrationScanEvent(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContinuousIntegrationScanEvent FindValue(string value)
        {
            return FindValue<ContinuousIntegrationScanEvent>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContinuousIntegrationScanEvent(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CoverageMapComparison.
    /// </summary>
    public class CoverageMapComparison : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS for CoverageMapComparison
        /// </summary>
        public static readonly CoverageMapComparison EQUALS = new CoverageMapComparison("EQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CoverageMapComparison(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CoverageMapComparison FindValue(string value)
        {
            return FindValue<CoverageMapComparison>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CoverageMapComparison(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CoverageResourceType.
    /// </summary>
    public class CoverageResourceType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_EC2_INSTANCE for CoverageResourceType
        /// </summary>
        public static readonly CoverageResourceType AWS_EC2_INSTANCE = new CoverageResourceType("AWS_EC2_INSTANCE");
        /// <summary>
        /// Constant AWS_ECR_CONTAINER_IMAGE for CoverageResourceType
        /// </summary>
        public static readonly CoverageResourceType AWS_ECR_CONTAINER_IMAGE = new CoverageResourceType("AWS_ECR_CONTAINER_IMAGE");
        /// <summary>
        /// Constant AWS_ECR_REPOSITORY for CoverageResourceType
        /// </summary>
        public static readonly CoverageResourceType AWS_ECR_REPOSITORY = new CoverageResourceType("AWS_ECR_REPOSITORY");
        /// <summary>
        /// Constant AWS_LAMBDA_FUNCTION for CoverageResourceType
        /// </summary>
        public static readonly CoverageResourceType AWS_LAMBDA_FUNCTION = new CoverageResourceType("AWS_LAMBDA_FUNCTION");
        /// <summary>
        /// Constant CODE_REPOSITORY for CoverageResourceType
        /// </summary>
        public static readonly CoverageResourceType CODE_REPOSITORY = new CoverageResourceType("CODE_REPOSITORY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CoverageResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CoverageResourceType FindValue(string value)
        {
            return FindValue<CoverageResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CoverageResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CoverageStringComparison.
    /// </summary>
    public class CoverageStringComparison : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS for CoverageStringComparison
        /// </summary>
        public static readonly CoverageStringComparison EQUALS = new CoverageStringComparison("EQUALS");
        /// <summary>
        /// Constant NOT_EQUALS for CoverageStringComparison
        /// </summary>
        public static readonly CoverageStringComparison NOT_EQUALS = new CoverageStringComparison("NOT_EQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CoverageStringComparison(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CoverageStringComparison FindValue(string value)
        {
            return FindValue<CoverageStringComparison>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CoverageStringComparison(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Currency.
    /// </summary>
    public class Currency : ConstantClass
    {

        /// <summary>
        /// Constant USD for Currency
        /// </summary>
        public static readonly Currency USD = new Currency("USD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Currency(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Currency FindValue(string value)
        {
            return FindValue<Currency>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Currency(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Day.
    /// </summary>
    public class Day : ConstantClass
    {

        /// <summary>
        /// Constant FRI for Day
        /// </summary>
        public static readonly Day FRI = new Day("FRI");
        /// <summary>
        /// Constant MON for Day
        /// </summary>
        public static readonly Day MON = new Day("MON");
        /// <summary>
        /// Constant SAT for Day
        /// </summary>
        public static readonly Day SAT = new Day("SAT");
        /// <summary>
        /// Constant SUN for Day
        /// </summary>
        public static readonly Day SUN = new Day("SUN");
        /// <summary>
        /// Constant THU for Day
        /// </summary>
        public static readonly Day THU = new Day("THU");
        /// <summary>
        /// Constant TUE for Day
        /// </summary>
        public static readonly Day TUE = new Day("TUE");
        /// <summary>
        /// Constant WED for Day
        /// </summary>
        public static readonly Day WED = new Day("WED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Day(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Day FindValue(string value)
        {
            return FindValue<Day>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Day(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DelegatedAdminStatus.
    /// </summary>
    public class DelegatedAdminStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLE_IN_PROGRESS for DelegatedAdminStatus
        /// </summary>
        public static readonly DelegatedAdminStatus DISABLE_IN_PROGRESS = new DelegatedAdminStatus("DISABLE_IN_PROGRESS");
        /// <summary>
        /// Constant ENABLED for DelegatedAdminStatus
        /// </summary>
        public static readonly DelegatedAdminStatus ENABLED = new DelegatedAdminStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DelegatedAdminStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DelegatedAdminStatus FindValue(string value)
        {
            return FindValue<DelegatedAdminStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DelegatedAdminStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Ec2DeepInspectionStatus.
    /// </summary>
    public class Ec2DeepInspectionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATED for Ec2DeepInspectionStatus
        /// </summary>
        public static readonly Ec2DeepInspectionStatus ACTIVATED = new Ec2DeepInspectionStatus("ACTIVATED");
        /// <summary>
        /// Constant DEACTIVATED for Ec2DeepInspectionStatus
        /// </summary>
        public static readonly Ec2DeepInspectionStatus DEACTIVATED = new Ec2DeepInspectionStatus("DEACTIVATED");
        /// <summary>
        /// Constant FAILED for Ec2DeepInspectionStatus
        /// </summary>
        public static readonly Ec2DeepInspectionStatus FAILED = new Ec2DeepInspectionStatus("FAILED");
        /// <summary>
        /// Constant PENDING for Ec2DeepInspectionStatus
        /// </summary>
        public static readonly Ec2DeepInspectionStatus PENDING = new Ec2DeepInspectionStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Ec2DeepInspectionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Ec2DeepInspectionStatus FindValue(string value)
        {
            return FindValue<Ec2DeepInspectionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Ec2DeepInspectionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Ec2InstanceSortBy.
    /// </summary>
    public class Ec2InstanceSortBy : ConstantClass
    {

        /// <summary>
        /// Constant ALL for Ec2InstanceSortBy
        /// </summary>
        public static readonly Ec2InstanceSortBy ALL = new Ec2InstanceSortBy("ALL");
        /// <summary>
        /// Constant CRITICAL for Ec2InstanceSortBy
        /// </summary>
        public static readonly Ec2InstanceSortBy CRITICAL = new Ec2InstanceSortBy("CRITICAL");
        /// <summary>
        /// Constant HIGH for Ec2InstanceSortBy
        /// </summary>
        public static readonly Ec2InstanceSortBy HIGH = new Ec2InstanceSortBy("HIGH");
        /// <summary>
        /// Constant NETWORK_FINDINGS for Ec2InstanceSortBy
        /// </summary>
        public static readonly Ec2InstanceSortBy NETWORK_FINDINGS = new Ec2InstanceSortBy("NETWORK_FINDINGS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Ec2InstanceSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Ec2InstanceSortBy FindValue(string value)
        {
            return FindValue<Ec2InstanceSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Ec2InstanceSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Ec2Platform.
    /// </summary>
    public class Ec2Platform : ConstantClass
    {

        /// <summary>
        /// Constant LINUX for Ec2Platform
        /// </summary>
        public static readonly Ec2Platform LINUX = new Ec2Platform("LINUX");
        /// <summary>
        /// Constant MACOS for Ec2Platform
        /// </summary>
        public static readonly Ec2Platform MACOS = new Ec2Platform("MACOS");
        /// <summary>
        /// Constant UNKNOWN for Ec2Platform
        /// </summary>
        public static readonly Ec2Platform UNKNOWN = new Ec2Platform("UNKNOWN");
        /// <summary>
        /// Constant WINDOWS for Ec2Platform
        /// </summary>
        public static readonly Ec2Platform WINDOWS = new Ec2Platform("WINDOWS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Ec2Platform(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Ec2Platform FindValue(string value)
        {
            return FindValue<Ec2Platform>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Ec2Platform(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Ec2ScanMode.
    /// </summary>
    public class Ec2ScanMode : ConstantClass
    {

        /// <summary>
        /// Constant EC2_HYBRID for Ec2ScanMode
        /// </summary>
        public static readonly Ec2ScanMode EC2_HYBRID = new Ec2ScanMode("EC2_HYBRID");
        /// <summary>
        /// Constant EC2_SSM_AGENT_BASED for Ec2ScanMode
        /// </summary>
        public static readonly Ec2ScanMode EC2_SSM_AGENT_BASED = new Ec2ScanMode("EC2_SSM_AGENT_BASED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Ec2ScanMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Ec2ScanMode FindValue(string value)
        {
            return FindValue<Ec2ScanMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Ec2ScanMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Ec2ScanModeStatus.
    /// </summary>
    public class Ec2ScanModeStatus : ConstantClass
    {

        /// <summary>
        /// Constant PENDING for Ec2ScanModeStatus
        /// </summary>
        public static readonly Ec2ScanModeStatus PENDING = new Ec2ScanModeStatus("PENDING");
        /// <summary>
        /// Constant SUCCESS for Ec2ScanModeStatus
        /// </summary>
        public static readonly Ec2ScanModeStatus SUCCESS = new Ec2ScanModeStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Ec2ScanModeStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Ec2ScanModeStatus FindValue(string value)
        {
            return FindValue<Ec2ScanModeStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Ec2ScanModeStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EcrPullDateRescanDuration.
    /// </summary>
    public class EcrPullDateRescanDuration : ConstantClass
    {

        /// <summary>
        /// Constant DAYS_14 for EcrPullDateRescanDuration
        /// </summary>
        public static readonly EcrPullDateRescanDuration DAYS_14 = new EcrPullDateRescanDuration("DAYS_14");
        /// <summary>
        /// Constant DAYS_180 for EcrPullDateRescanDuration
        /// </summary>
        public static readonly EcrPullDateRescanDuration DAYS_180 = new EcrPullDateRescanDuration("DAYS_180");
        /// <summary>
        /// Constant DAYS_30 for EcrPullDateRescanDuration
        /// </summary>
        public static readonly EcrPullDateRescanDuration DAYS_30 = new EcrPullDateRescanDuration("DAYS_30");
        /// <summary>
        /// Constant DAYS_60 for EcrPullDateRescanDuration
        /// </summary>
        public static readonly EcrPullDateRescanDuration DAYS_60 = new EcrPullDateRescanDuration("DAYS_60");
        /// <summary>
        /// Constant DAYS_90 for EcrPullDateRescanDuration
        /// </summary>
        public static readonly EcrPullDateRescanDuration DAYS_90 = new EcrPullDateRescanDuration("DAYS_90");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EcrPullDateRescanDuration(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EcrPullDateRescanDuration FindValue(string value)
        {
            return FindValue<EcrPullDateRescanDuration>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EcrPullDateRescanDuration(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EcrPullDateRescanMode.
    /// </summary>
    public class EcrPullDateRescanMode : ConstantClass
    {

        /// <summary>
        /// Constant LAST_IN_USE_AT for EcrPullDateRescanMode
        /// </summary>
        public static readonly EcrPullDateRescanMode LAST_IN_USE_AT = new EcrPullDateRescanMode("LAST_IN_USE_AT");
        /// <summary>
        /// Constant LAST_PULL_DATE for EcrPullDateRescanMode
        /// </summary>
        public static readonly EcrPullDateRescanMode LAST_PULL_DATE = new EcrPullDateRescanMode("LAST_PULL_DATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EcrPullDateRescanMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EcrPullDateRescanMode FindValue(string value)
        {
            return FindValue<EcrPullDateRescanMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EcrPullDateRescanMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EcrRescanDuration.
    /// </summary>
    public class EcrRescanDuration : ConstantClass
    {

        /// <summary>
        /// Constant DAYS_14 for EcrRescanDuration
        /// </summary>
        public static readonly EcrRescanDuration DAYS_14 = new EcrRescanDuration("DAYS_14");
        /// <summary>
        /// Constant DAYS_180 for EcrRescanDuration
        /// </summary>
        public static readonly EcrRescanDuration DAYS_180 = new EcrRescanDuration("DAYS_180");
        /// <summary>
        /// Constant DAYS_30 for EcrRescanDuration
        /// </summary>
        public static readonly EcrRescanDuration DAYS_30 = new EcrRescanDuration("DAYS_30");
        /// <summary>
        /// Constant DAYS_60 for EcrRescanDuration
        /// </summary>
        public static readonly EcrRescanDuration DAYS_60 = new EcrRescanDuration("DAYS_60");
        /// <summary>
        /// Constant DAYS_90 for EcrRescanDuration
        /// </summary>
        public static readonly EcrRescanDuration DAYS_90 = new EcrRescanDuration("DAYS_90");
        /// <summary>
        /// Constant LIFETIME for EcrRescanDuration
        /// </summary>
        public static readonly EcrRescanDuration LIFETIME = new EcrRescanDuration("LIFETIME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EcrRescanDuration(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EcrRescanDuration FindValue(string value)
        {
            return FindValue<EcrRescanDuration>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EcrRescanDuration(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EcrRescanDurationStatus.
    /// </summary>
    public class EcrRescanDurationStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for EcrRescanDurationStatus
        /// </summary>
        public static readonly EcrRescanDurationStatus FAILED = new EcrRescanDurationStatus("FAILED");
        /// <summary>
        /// Constant PENDING for EcrRescanDurationStatus
        /// </summary>
        public static readonly EcrRescanDurationStatus PENDING = new EcrRescanDurationStatus("PENDING");
        /// <summary>
        /// Constant SUCCESS for EcrRescanDurationStatus
        /// </summary>
        public static readonly EcrRescanDurationStatus SUCCESS = new EcrRescanDurationStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EcrRescanDurationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EcrRescanDurationStatus FindValue(string value)
        {
            return FindValue<EcrRescanDurationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EcrRescanDurationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EcrScanFrequency.
    /// </summary>
    public class EcrScanFrequency : ConstantClass
    {

        /// <summary>
        /// Constant CONTINUOUS_SCAN for EcrScanFrequency
        /// </summary>
        public static readonly EcrScanFrequency CONTINUOUS_SCAN = new EcrScanFrequency("CONTINUOUS_SCAN");
        /// <summary>
        /// Constant MANUAL for EcrScanFrequency
        /// </summary>
        public static readonly EcrScanFrequency MANUAL = new EcrScanFrequency("MANUAL");
        /// <summary>
        /// Constant SCAN_ON_PUSH for EcrScanFrequency
        /// </summary>
        public static readonly EcrScanFrequency SCAN_ON_PUSH = new EcrScanFrequency("SCAN_ON_PUSH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EcrScanFrequency(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EcrScanFrequency FindValue(string value)
        {
            return FindValue<EcrScanFrequency>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EcrScanFrequency(string value)
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
        /// Constant ACCESS_DENIED for ErrorCode
        /// </summary>
        public static readonly ErrorCode ACCESS_DENIED = new ErrorCode("ACCESS_DENIED");
        /// <summary>
        /// Constant ACCOUNT_IS_ISOLATED for ErrorCode
        /// </summary>
        public static readonly ErrorCode ACCOUNT_IS_ISOLATED = new ErrorCode("ACCOUNT_IS_ISOLATED");
        /// <summary>
        /// Constant ALREADY_ENABLED for ErrorCode
        /// </summary>
        public static readonly ErrorCode ALREADY_ENABLED = new ErrorCode("ALREADY_ENABLED");
        /// <summary>
        /// Constant DISABLE_IN_PROGRESS for ErrorCode
        /// </summary>
        public static readonly ErrorCode DISABLE_IN_PROGRESS = new ErrorCode("DISABLE_IN_PROGRESS");
        /// <summary>
        /// Constant DISASSOCIATE_ALL_MEMBERS for ErrorCode
        /// </summary>
        public static readonly ErrorCode DISASSOCIATE_ALL_MEMBERS = new ErrorCode("DISASSOCIATE_ALL_MEMBERS");
        /// <summary>
        /// Constant EC2_SSM_ASSOCIATION_VERSION_LIMIT_EXCEEDED for ErrorCode
        /// </summary>
        public static readonly ErrorCode EC2_SSM_ASSOCIATION_VERSION_LIMIT_EXCEEDED = new ErrorCode("EC2_SSM_ASSOCIATION_VERSION_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant EC2_SSM_RESOURCE_DATA_SYNC_LIMIT_EXCEEDED for ErrorCode
        /// </summary>
        public static readonly ErrorCode EC2_SSM_RESOURCE_DATA_SYNC_LIMIT_EXCEEDED = new ErrorCode("EC2_SSM_RESOURCE_DATA_SYNC_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant ENABLE_IN_PROGRESS for ErrorCode
        /// </summary>
        public static readonly ErrorCode ENABLE_IN_PROGRESS = new ErrorCode("ENABLE_IN_PROGRESS");
        /// <summary>
        /// Constant EVENTBRIDGE_THROTTLED for ErrorCode
        /// </summary>
        public static readonly ErrorCode EVENTBRIDGE_THROTTLED = new ErrorCode("EVENTBRIDGE_THROTTLED");
        /// <summary>
        /// Constant EVENTBRIDGE_UNAVAILABLE for ErrorCode
        /// </summary>
        public static readonly ErrorCode EVENTBRIDGE_UNAVAILABLE = new ErrorCode("EVENTBRIDGE_UNAVAILABLE");
        /// <summary>
        /// Constant INTERNAL_ERROR for ErrorCode
        /// </summary>
        public static readonly ErrorCode INTERNAL_ERROR = new ErrorCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant RESOURCE_NOT_FOUND for ErrorCode
        /// </summary>
        public static readonly ErrorCode RESOURCE_NOT_FOUND = new ErrorCode("RESOURCE_NOT_FOUND");
        /// <summary>
        /// Constant RESOURCE_SCAN_NOT_DISABLED for ErrorCode
        /// </summary>
        public static readonly ErrorCode RESOURCE_SCAN_NOT_DISABLED = new ErrorCode("RESOURCE_SCAN_NOT_DISABLED");
        /// <summary>
        /// Constant SSM_THROTTLED for ErrorCode
        /// </summary>
        public static readonly ErrorCode SSM_THROTTLED = new ErrorCode("SSM_THROTTLED");
        /// <summary>
        /// Constant SSM_UNAVAILABLE for ErrorCode
        /// </summary>
        public static readonly ErrorCode SSM_UNAVAILABLE = new ErrorCode("SSM_UNAVAILABLE");
        /// <summary>
        /// Constant SUSPEND_IN_PROGRESS for ErrorCode
        /// </summary>
        public static readonly ErrorCode SUSPEND_IN_PROGRESS = new ErrorCode("SUSPEND_IN_PROGRESS");

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
    /// Constants used for properties of type ExploitAvailable.
    /// </summary>
    public class ExploitAvailable : ConstantClass
    {

        /// <summary>
        /// Constant NO for ExploitAvailable
        /// </summary>
        public static readonly ExploitAvailable NO = new ExploitAvailable("NO");
        /// <summary>
        /// Constant YES for ExploitAvailable
        /// </summary>
        public static readonly ExploitAvailable YES = new ExploitAvailable("YES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExploitAvailable(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExploitAvailable FindValue(string value)
        {
            return FindValue<ExploitAvailable>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExploitAvailable(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExternalReportStatus.
    /// </summary>
    public class ExternalReportStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for ExternalReportStatus
        /// </summary>
        public static readonly ExternalReportStatus CANCELLED = new ExternalReportStatus("CANCELLED");
        /// <summary>
        /// Constant FAILED for ExternalReportStatus
        /// </summary>
        public static readonly ExternalReportStatus FAILED = new ExternalReportStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ExternalReportStatus
        /// </summary>
        public static readonly ExternalReportStatus IN_PROGRESS = new ExternalReportStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCEEDED for ExternalReportStatus
        /// </summary>
        public static readonly ExternalReportStatus SUCCEEDED = new ExternalReportStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExternalReportStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExternalReportStatus FindValue(string value)
        {
            return FindValue<ExternalReportStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExternalReportStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FilterAction.
    /// </summary>
    public class FilterAction : ConstantClass
    {

        /// <summary>
        /// Constant NONE for FilterAction
        /// </summary>
        public static readonly FilterAction NONE = new FilterAction("NONE");
        /// <summary>
        /// Constant SUPPRESS for FilterAction
        /// </summary>
        public static readonly FilterAction SUPPRESS = new FilterAction("SUPPRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterAction FindValue(string value)
        {
            return FindValue<FilterAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FindingDetailsErrorCode.
    /// </summary>
    public class FindingDetailsErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for FindingDetailsErrorCode
        /// </summary>
        public static readonly FindingDetailsErrorCode ACCESS_DENIED = new FindingDetailsErrorCode("ACCESS_DENIED");
        /// <summary>
        /// Constant FINDING_DETAILS_NOT_FOUND for FindingDetailsErrorCode
        /// </summary>
        public static readonly FindingDetailsErrorCode FINDING_DETAILS_NOT_FOUND = new FindingDetailsErrorCode("FINDING_DETAILS_NOT_FOUND");
        /// <summary>
        /// Constant INTERNAL_ERROR for FindingDetailsErrorCode
        /// </summary>
        public static readonly FindingDetailsErrorCode INTERNAL_ERROR = new FindingDetailsErrorCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant INVALID_INPUT for FindingDetailsErrorCode
        /// </summary>
        public static readonly FindingDetailsErrorCode INVALID_INPUT = new FindingDetailsErrorCode("INVALID_INPUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FindingDetailsErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingDetailsErrorCode FindValue(string value)
        {
            return FindValue<FindingDetailsErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingDetailsErrorCode(string value)
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
        /// Constant ACTIVE for FindingStatus
        /// </summary>
        public static readonly FindingStatus ACTIVE = new FindingStatus("ACTIVE");
        /// <summary>
        /// Constant CLOSED for FindingStatus
        /// </summary>
        public static readonly FindingStatus CLOSED = new FindingStatus("CLOSED");
        /// <summary>
        /// Constant SUPPRESSED for FindingStatus
        /// </summary>
        public static readonly FindingStatus SUPPRESSED = new FindingStatus("SUPPRESSED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FindingStatus(string value)
            : base(value)
        {
        }

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
        /// Constant CODE_VULNERABILITY for FindingType
        /// </summary>
        public static readonly FindingType CODE_VULNERABILITY = new FindingType("CODE_VULNERABILITY");
        /// <summary>
        /// Constant NETWORK_REACHABILITY for FindingType
        /// </summary>
        public static readonly FindingType NETWORK_REACHABILITY = new FindingType("NETWORK_REACHABILITY");
        /// <summary>
        /// Constant PACKAGE_VULNERABILITY for FindingType
        /// </summary>
        public static readonly FindingType PACKAGE_VULNERABILITY = new FindingType("PACKAGE_VULNERABILITY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FindingType(string value)
            : base(value)
        {
        }

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
    /// Constants used for properties of type FindingTypeSortBy.
    /// </summary>
    public class FindingTypeSortBy : ConstantClass
    {

        /// <summary>
        /// Constant ALL for FindingTypeSortBy
        /// </summary>
        public static readonly FindingTypeSortBy ALL = new FindingTypeSortBy("ALL");
        /// <summary>
        /// Constant CRITICAL for FindingTypeSortBy
        /// </summary>
        public static readonly FindingTypeSortBy CRITICAL = new FindingTypeSortBy("CRITICAL");
        /// <summary>
        /// Constant HIGH for FindingTypeSortBy
        /// </summary>
        public static readonly FindingTypeSortBy HIGH = new FindingTypeSortBy("HIGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FindingTypeSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingTypeSortBy FindValue(string value)
        {
            return FindValue<FindingTypeSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingTypeSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FixAvailable.
    /// </summary>
    public class FixAvailable : ConstantClass
    {

        /// <summary>
        /// Constant NO for FixAvailable
        /// </summary>
        public static readonly FixAvailable NO = new FixAvailable("NO");
        /// <summary>
        /// Constant PARTIAL for FixAvailable
        /// </summary>
        public static readonly FixAvailable PARTIAL = new FixAvailable("PARTIAL");
        /// <summary>
        /// Constant YES for FixAvailable
        /// </summary>
        public static readonly FixAvailable YES = new FixAvailable("YES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FixAvailable(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FixAvailable FindValue(string value)
        {
            return FindValue<FixAvailable>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FixAvailable(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FreeTrialInfoErrorCode.
    /// </summary>
    public class FreeTrialInfoErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for FreeTrialInfoErrorCode
        /// </summary>
        public static readonly FreeTrialInfoErrorCode ACCESS_DENIED = new FreeTrialInfoErrorCode("ACCESS_DENIED");
        /// <summary>
        /// Constant INTERNAL_ERROR for FreeTrialInfoErrorCode
        /// </summary>
        public static readonly FreeTrialInfoErrorCode INTERNAL_ERROR = new FreeTrialInfoErrorCode("INTERNAL_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FreeTrialInfoErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FreeTrialInfoErrorCode FindValue(string value)
        {
            return FindValue<FreeTrialInfoErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FreeTrialInfoErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FreeTrialStatus.
    /// </summary>
    public class FreeTrialStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for FreeTrialStatus
        /// </summary>
        public static readonly FreeTrialStatus ACTIVE = new FreeTrialStatus("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for FreeTrialStatus
        /// </summary>
        public static readonly FreeTrialStatus INACTIVE = new FreeTrialStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FreeTrialStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FreeTrialStatus FindValue(string value)
        {
            return FindValue<FreeTrialStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FreeTrialStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FreeTrialType.
    /// </summary>
    public class FreeTrialType : ConstantClass
    {

        /// <summary>
        /// Constant CODE_REPOSITORY for FreeTrialType
        /// </summary>
        public static readonly FreeTrialType CODE_REPOSITORY = new FreeTrialType("CODE_REPOSITORY");
        /// <summary>
        /// Constant EC2 for FreeTrialType
        /// </summary>
        public static readonly FreeTrialType EC2 = new FreeTrialType("EC2");
        /// <summary>
        /// Constant ECR for FreeTrialType
        /// </summary>
        public static readonly FreeTrialType ECR = new FreeTrialType("ECR");
        /// <summary>
        /// Constant LAMBDA for FreeTrialType
        /// </summary>
        public static readonly FreeTrialType LAMBDA = new FreeTrialType("LAMBDA");
        /// <summary>
        /// Constant LAMBDA_CODE for FreeTrialType
        /// </summary>
        public static readonly FreeTrialType LAMBDA_CODE = new FreeTrialType("LAMBDA_CODE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FreeTrialType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FreeTrialType FindValue(string value)
        {
            return FindValue<FreeTrialType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FreeTrialType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GroupKey.
    /// </summary>
    public class GroupKey : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_ID for GroupKey
        /// </summary>
        public static readonly GroupKey ACCOUNT_ID = new GroupKey("ACCOUNT_ID");
        /// <summary>
        /// Constant ECR_REPOSITORY_NAME for GroupKey
        /// </summary>
        public static readonly GroupKey ECR_REPOSITORY_NAME = new GroupKey("ECR_REPOSITORY_NAME");
        /// <summary>
        /// Constant RESOURCE_TYPE for GroupKey
        /// </summary>
        public static readonly GroupKey RESOURCE_TYPE = new GroupKey("RESOURCE_TYPE");
        /// <summary>
        /// Constant SCAN_STATUS_CODE for GroupKey
        /// </summary>
        public static readonly GroupKey SCAN_STATUS_CODE = new GroupKey("SCAN_STATUS_CODE");
        /// <summary>
        /// Constant SCAN_STATUS_REASON for GroupKey
        /// </summary>
        public static readonly GroupKey SCAN_STATUS_REASON = new GroupKey("SCAN_STATUS_REASON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GroupKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GroupKey FindValue(string value)
        {
            return FindValue<GroupKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GroupKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageLayerSortBy.
    /// </summary>
    public class ImageLayerSortBy : ConstantClass
    {

        /// <summary>
        /// Constant ALL for ImageLayerSortBy
        /// </summary>
        public static readonly ImageLayerSortBy ALL = new ImageLayerSortBy("ALL");
        /// <summary>
        /// Constant CRITICAL for ImageLayerSortBy
        /// </summary>
        public static readonly ImageLayerSortBy CRITICAL = new ImageLayerSortBy("CRITICAL");
        /// <summary>
        /// Constant HIGH for ImageLayerSortBy
        /// </summary>
        public static readonly ImageLayerSortBy HIGH = new ImageLayerSortBy("HIGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageLayerSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageLayerSortBy FindValue(string value)
        {
            return FindValue<ImageLayerSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageLayerSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IntegrationStatus.
    /// </summary>
    public class IntegrationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for IntegrationStatus
        /// </summary>
        public static readonly IntegrationStatus ACTIVE = new IntegrationStatus("ACTIVE");
        /// <summary>
        /// Constant DISABLING for IntegrationStatus
        /// </summary>
        public static readonly IntegrationStatus DISABLING = new IntegrationStatus("DISABLING");
        /// <summary>
        /// Constant IN_PROGRESS for IntegrationStatus
        /// </summary>
        public static readonly IntegrationStatus IN_PROGRESS = new IntegrationStatus("IN_PROGRESS");
        /// <summary>
        /// Constant INACTIVE for IntegrationStatus
        /// </summary>
        public static readonly IntegrationStatus INACTIVE = new IntegrationStatus("INACTIVE");
        /// <summary>
        /// Constant PENDING for IntegrationStatus
        /// </summary>
        public static readonly IntegrationStatus PENDING = new IntegrationStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IntegrationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IntegrationStatus FindValue(string value)
        {
            return FindValue<IntegrationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IntegrationStatus(string value)
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
        /// Constant GITLAB_SELF_MANAGED for IntegrationType
        /// </summary>
        public static readonly IntegrationType GITLAB_SELF_MANAGED = new IntegrationType("GITLAB_SELF_MANAGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IntegrationType(string value)
            : base(value)
        {
        }

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
    /// Constants used for properties of type LambdaFunctionSortBy.
    /// </summary>
    public class LambdaFunctionSortBy : ConstantClass
    {

        /// <summary>
        /// Constant ALL for LambdaFunctionSortBy
        /// </summary>
        public static readonly LambdaFunctionSortBy ALL = new LambdaFunctionSortBy("ALL");
        /// <summary>
        /// Constant CRITICAL for LambdaFunctionSortBy
        /// </summary>
        public static readonly LambdaFunctionSortBy CRITICAL = new LambdaFunctionSortBy("CRITICAL");
        /// <summary>
        /// Constant HIGH for LambdaFunctionSortBy
        /// </summary>
        public static readonly LambdaFunctionSortBy HIGH = new LambdaFunctionSortBy("HIGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LambdaFunctionSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LambdaFunctionSortBy FindValue(string value)
        {
            return FindValue<LambdaFunctionSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LambdaFunctionSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LambdaLayerSortBy.
    /// </summary>
    public class LambdaLayerSortBy : ConstantClass
    {

        /// <summary>
        /// Constant ALL for LambdaLayerSortBy
        /// </summary>
        public static readonly LambdaLayerSortBy ALL = new LambdaLayerSortBy("ALL");
        /// <summary>
        /// Constant CRITICAL for LambdaLayerSortBy
        /// </summary>
        public static readonly LambdaLayerSortBy CRITICAL = new LambdaLayerSortBy("CRITICAL");
        /// <summary>
        /// Constant HIGH for LambdaLayerSortBy
        /// </summary>
        public static readonly LambdaLayerSortBy HIGH = new LambdaLayerSortBy("HIGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LambdaLayerSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LambdaLayerSortBy FindValue(string value)
        {
            return FindValue<LambdaLayerSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LambdaLayerSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListCisScansDetailLevel.
    /// </summary>
    public class ListCisScansDetailLevel : ConstantClass
    {

        /// <summary>
        /// Constant MEMBER for ListCisScansDetailLevel
        /// </summary>
        public static readonly ListCisScansDetailLevel MEMBER = new ListCisScansDetailLevel("MEMBER");
        /// <summary>
        /// Constant ORGANIZATION for ListCisScansDetailLevel
        /// </summary>
        public static readonly ListCisScansDetailLevel ORGANIZATION = new ListCisScansDetailLevel("ORGANIZATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListCisScansDetailLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListCisScansDetailLevel FindValue(string value)
        {
            return FindValue<ListCisScansDetailLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListCisScansDetailLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListCisScansSortBy.
    /// </summary>
    public class ListCisScansSortBy : ConstantClass
    {

        /// <summary>
        /// Constant FAILED_CHECKS for ListCisScansSortBy
        /// </summary>
        public static readonly ListCisScansSortBy FAILED_CHECKS = new ListCisScansSortBy("FAILED_CHECKS");
        /// <summary>
        /// Constant SCAN_START_DATE for ListCisScansSortBy
        /// </summary>
        public static readonly ListCisScansSortBy SCAN_START_DATE = new ListCisScansSortBy("SCAN_START_DATE");
        /// <summary>
        /// Constant SCHEDULED_BY for ListCisScansSortBy
        /// </summary>
        public static readonly ListCisScansSortBy SCHEDULED_BY = new ListCisScansSortBy("SCHEDULED_BY");
        /// <summary>
        /// Constant STATUS for ListCisScansSortBy
        /// </summary>
        public static readonly ListCisScansSortBy STATUS = new ListCisScansSortBy("STATUS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListCisScansSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListCisScansSortBy FindValue(string value)
        {
            return FindValue<ListCisScansSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListCisScansSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MapComparison.
    /// </summary>
    public class MapComparison : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS for MapComparison
        /// </summary>
        public static readonly MapComparison EQUALS = new MapComparison("EQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MapComparison(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MapComparison FindValue(string value)
        {
            return FindValue<MapComparison>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MapComparison(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkProtocol.
    /// </summary>
    public class NetworkProtocol : ConstantClass
    {

        /// <summary>
        /// Constant TCP for NetworkProtocol
        /// </summary>
        public static readonly NetworkProtocol TCP = new NetworkProtocol("TCP");
        /// <summary>
        /// Constant UDP for NetworkProtocol
        /// </summary>
        public static readonly NetworkProtocol UDP = new NetworkProtocol("UDP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkProtocol FindValue(string value)
        {
            return FindValue<NetworkProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Operation.
    /// </summary>
    public class Operation : ConstantClass
    {

        /// <summary>
        /// Constant DISABLE_REPOSITORY for Operation
        /// </summary>
        public static readonly Operation DISABLE_REPOSITORY = new Operation("DISABLE_REPOSITORY");
        /// <summary>
        /// Constant DISABLE_SCANNING for Operation
        /// </summary>
        public static readonly Operation DISABLE_SCANNING = new Operation("DISABLE_SCANNING");
        /// <summary>
        /// Constant ENABLE_REPOSITORY for Operation
        /// </summary>
        public static readonly Operation ENABLE_REPOSITORY = new Operation("ENABLE_REPOSITORY");
        /// <summary>
        /// Constant ENABLE_SCANNING for Operation
        /// </summary>
        public static readonly Operation ENABLE_SCANNING = new Operation("ENABLE_SCANNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Operation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Operation FindValue(string value)
        {
            return FindValue<Operation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Operation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PackageManager.
    /// </summary>
    public class PackageManager : ConstantClass
    {

        /// <summary>
        /// Constant BUNDLER for PackageManager
        /// </summary>
        public static readonly PackageManager BUNDLER = new PackageManager("BUNDLER");
        /// <summary>
        /// Constant CARGO for PackageManager
        /// </summary>
        public static readonly PackageManager CARGO = new PackageManager("CARGO");
        /// <summary>
        /// Constant COMPOSER for PackageManager
        /// </summary>
        public static readonly PackageManager COMPOSER = new PackageManager("COMPOSER");
        /// <summary>
        /// Constant DOTNET_CORE for PackageManager
        /// </summary>
        public static readonly PackageManager DOTNET_CORE = new PackageManager("DOTNET_CORE");
        /// <summary>
        /// Constant GEMSPEC for PackageManager
        /// </summary>
        public static readonly PackageManager GEMSPEC = new PackageManager("GEMSPEC");
        /// <summary>
        /// Constant GOBINARY for PackageManager
        /// </summary>
        public static readonly PackageManager GOBINARY = new PackageManager("GOBINARY");
        /// <summary>
        /// Constant GOMOD for PackageManager
        /// </summary>
        public static readonly PackageManager GOMOD = new PackageManager("GOMOD");
        /// <summary>
        /// Constant JAR for PackageManager
        /// </summary>
        public static readonly PackageManager JAR = new PackageManager("JAR");
        /// <summary>
        /// Constant NODEPKG for PackageManager
        /// </summary>
        public static readonly PackageManager NODEPKG = new PackageManager("NODEPKG");
        /// <summary>
        /// Constant NPM for PackageManager
        /// </summary>
        public static readonly PackageManager NPM = new PackageManager("NPM");
        /// <summary>
        /// Constant NUGET for PackageManager
        /// </summary>
        public static readonly PackageManager NUGET = new PackageManager("NUGET");
        /// <summary>
        /// Constant OS for PackageManager
        /// </summary>
        public static readonly PackageManager OS = new PackageManager("OS");
        /// <summary>
        /// Constant PIP for PackageManager
        /// </summary>
        public static readonly PackageManager PIP = new PackageManager("PIP");
        /// <summary>
        /// Constant PIPENV for PackageManager
        /// </summary>
        public static readonly PackageManager PIPENV = new PackageManager("PIPENV");
        /// <summary>
        /// Constant POETRY for PackageManager
        /// </summary>
        public static readonly PackageManager POETRY = new PackageManager("POETRY");
        /// <summary>
        /// Constant POM for PackageManager
        /// </summary>
        public static readonly PackageManager POM = new PackageManager("POM");
        /// <summary>
        /// Constant PYTHONPKG for PackageManager
        /// </summary>
        public static readonly PackageManager PYTHONPKG = new PackageManager("PYTHONPKG");
        /// <summary>
        /// Constant YARN for PackageManager
        /// </summary>
        public static readonly PackageManager YARN = new PackageManager("YARN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PackageManager(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PackageManager FindValue(string value)
        {
            return FindValue<PackageManager>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PackageManager(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PackageSortBy.
    /// </summary>
    public class PackageSortBy : ConstantClass
    {

        /// <summary>
        /// Constant ALL for PackageSortBy
        /// </summary>
        public static readonly PackageSortBy ALL = new PackageSortBy("ALL");
        /// <summary>
        /// Constant CRITICAL for PackageSortBy
        /// </summary>
        public static readonly PackageSortBy CRITICAL = new PackageSortBy("CRITICAL");
        /// <summary>
        /// Constant HIGH for PackageSortBy
        /// </summary>
        public static readonly PackageSortBy HIGH = new PackageSortBy("HIGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PackageSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PackageSortBy FindValue(string value)
        {
            return FindValue<PackageSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PackageSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PackageType.
    /// </summary>
    public class PackageType : ConstantClass
    {

        /// <summary>
        /// Constant IMAGE for PackageType
        /// </summary>
        public static readonly PackageType IMAGE = new PackageType("IMAGE");
        /// <summary>
        /// Constant ZIP for PackageType
        /// </summary>
        public static readonly PackageType ZIP = new PackageType("ZIP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PackageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PackageType FindValue(string value)
        {
            return FindValue<PackageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PackageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PeriodicScanFrequency.
    /// </summary>
    public class PeriodicScanFrequency : ConstantClass
    {

        /// <summary>
        /// Constant MONTHLY for PeriodicScanFrequency
        /// </summary>
        public static readonly PeriodicScanFrequency MONTHLY = new PeriodicScanFrequency("MONTHLY");
        /// <summary>
        /// Constant NEVER for PeriodicScanFrequency
        /// </summary>
        public static readonly PeriodicScanFrequency NEVER = new PeriodicScanFrequency("NEVER");
        /// <summary>
        /// Constant WEEKLY for PeriodicScanFrequency
        /// </summary>
        public static readonly PeriodicScanFrequency WEEKLY = new PeriodicScanFrequency("WEEKLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PeriodicScanFrequency(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PeriodicScanFrequency FindValue(string value)
        {
            return FindValue<PeriodicScanFrequency>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PeriodicScanFrequency(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProjectSelectionScope.
    /// </summary>
    public class ProjectSelectionScope : ConstantClass
    {

        /// <summary>
        /// Constant ALL for ProjectSelectionScope
        /// </summary>
        public static readonly ProjectSelectionScope ALL = new ProjectSelectionScope("ALL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProjectSelectionScope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProjectSelectionScope FindValue(string value)
        {
            return FindValue<ProjectSelectionScope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProjectSelectionScope(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RelationshipStatus.
    /// </summary>
    public class RelationshipStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_SUSPENDED for RelationshipStatus
        /// </summary>
        public static readonly RelationshipStatus ACCOUNT_SUSPENDED = new RelationshipStatus("ACCOUNT_SUSPENDED");
        /// <summary>
        /// Constant CANNOT_CREATE_DETECTOR_IN_ORG_MASTER for RelationshipStatus
        /// </summary>
        public static readonly RelationshipStatus CANNOT_CREATE_DETECTOR_IN_ORG_MASTER = new RelationshipStatus("CANNOT_CREATE_DETECTOR_IN_ORG_MASTER");
        /// <summary>
        /// Constant CREATED for RelationshipStatus
        /// </summary>
        public static readonly RelationshipStatus CREATED = new RelationshipStatus("CREATED");
        /// <summary>
        /// Constant DELETED for RelationshipStatus
        /// </summary>
        public static readonly RelationshipStatus DELETED = new RelationshipStatus("DELETED");
        /// <summary>
        /// Constant DISABLED for RelationshipStatus
        /// </summary>
        public static readonly RelationshipStatus DISABLED = new RelationshipStatus("DISABLED");
        /// <summary>
        /// Constant EMAIL_VERIFICATION_FAILED for RelationshipStatus
        /// </summary>
        public static readonly RelationshipStatus EMAIL_VERIFICATION_FAILED = new RelationshipStatus("EMAIL_VERIFICATION_FAILED");
        /// <summary>
        /// Constant EMAIL_VERIFICATION_IN_PROGRESS for RelationshipStatus
        /// </summary>
        public static readonly RelationshipStatus EMAIL_VERIFICATION_IN_PROGRESS = new RelationshipStatus("EMAIL_VERIFICATION_IN_PROGRESS");
        /// <summary>
        /// Constant ENABLED for RelationshipStatus
        /// </summary>
        public static readonly RelationshipStatus ENABLED = new RelationshipStatus("ENABLED");
        /// <summary>
        /// Constant INVITED for RelationshipStatus
        /// </summary>
        public static readonly RelationshipStatus INVITED = new RelationshipStatus("INVITED");
        /// <summary>
        /// Constant REGION_DISABLED for RelationshipStatus
        /// </summary>
        public static readonly RelationshipStatus REGION_DISABLED = new RelationshipStatus("REGION_DISABLED");
        /// <summary>
        /// Constant REMOVED for RelationshipStatus
        /// </summary>
        public static readonly RelationshipStatus REMOVED = new RelationshipStatus("REMOVED");
        /// <summary>
        /// Constant RESIGNED for RelationshipStatus
        /// </summary>
        public static readonly RelationshipStatus RESIGNED = new RelationshipStatus("RESIGNED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RelationshipStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RelationshipStatus FindValue(string value)
        {
            return FindValue<RelationshipStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RelationshipStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportFormat.
    /// </summary>
    public class ReportFormat : ConstantClass
    {

        /// <summary>
        /// Constant CSV for ReportFormat
        /// </summary>
        public static readonly ReportFormat CSV = new ReportFormat("CSV");
        /// <summary>
        /// Constant JSON for ReportFormat
        /// </summary>
        public static readonly ReportFormat JSON = new ReportFormat("JSON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReportFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportFormat FindValue(string value)
        {
            return FindValue<ReportFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportingErrorCode.
    /// </summary>
    public class ReportingErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant BUCKET_NOT_FOUND for ReportingErrorCode
        /// </summary>
        public static readonly ReportingErrorCode BUCKET_NOT_FOUND = new ReportingErrorCode("BUCKET_NOT_FOUND");
        /// <summary>
        /// Constant INCOMPATIBLE_BUCKET_REGION for ReportingErrorCode
        /// </summary>
        public static readonly ReportingErrorCode INCOMPATIBLE_BUCKET_REGION = new ReportingErrorCode("INCOMPATIBLE_BUCKET_REGION");
        /// <summary>
        /// Constant INTERNAL_ERROR for ReportingErrorCode
        /// </summary>
        public static readonly ReportingErrorCode INTERNAL_ERROR = new ReportingErrorCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant INVALID_PERMISSIONS for ReportingErrorCode
        /// </summary>
        public static readonly ReportingErrorCode INVALID_PERMISSIONS = new ReportingErrorCode("INVALID_PERMISSIONS");
        /// <summary>
        /// Constant MALFORMED_KMS_KEY for ReportingErrorCode
        /// </summary>
        public static readonly ReportingErrorCode MALFORMED_KMS_KEY = new ReportingErrorCode("MALFORMED_KMS_KEY");
        /// <summary>
        /// Constant NO_FINDINGS_FOUND for ReportingErrorCode
        /// </summary>
        public static readonly ReportingErrorCode NO_FINDINGS_FOUND = new ReportingErrorCode("NO_FINDINGS_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReportingErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportingErrorCode FindValue(string value)
        {
            return FindValue<ReportingErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportingErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RepositorySortBy.
    /// </summary>
    public class RepositorySortBy : ConstantClass
    {

        /// <summary>
        /// Constant AFFECTED_IMAGES for RepositorySortBy
        /// </summary>
        public static readonly RepositorySortBy AFFECTED_IMAGES = new RepositorySortBy("AFFECTED_IMAGES");
        /// <summary>
        /// Constant ALL for RepositorySortBy
        /// </summary>
        public static readonly RepositorySortBy ALL = new RepositorySortBy("ALL");
        /// <summary>
        /// Constant CRITICAL for RepositorySortBy
        /// </summary>
        public static readonly RepositorySortBy CRITICAL = new RepositorySortBy("CRITICAL");
        /// <summary>
        /// Constant HIGH for RepositorySortBy
        /// </summary>
        public static readonly RepositorySortBy HIGH = new RepositorySortBy("HIGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RepositorySortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RepositorySortBy FindValue(string value)
        {
            return FindValue<RepositorySortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RepositorySortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceMapComparison.
    /// </summary>
    public class ResourceMapComparison : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS for ResourceMapComparison
        /// </summary>
        public static readonly ResourceMapComparison EQUALS = new ResourceMapComparison("EQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceMapComparison(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceMapComparison FindValue(string value)
        {
            return FindValue<ResourceMapComparison>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceMapComparison(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceScanType.
    /// </summary>
    public class ResourceScanType : ConstantClass
    {

        /// <summary>
        /// Constant CODE_REPOSITORY for ResourceScanType
        /// </summary>
        public static readonly ResourceScanType CODE_REPOSITORY = new ResourceScanType("CODE_REPOSITORY");
        /// <summary>
        /// Constant EC2 for ResourceScanType
        /// </summary>
        public static readonly ResourceScanType EC2 = new ResourceScanType("EC2");
        /// <summary>
        /// Constant ECR for ResourceScanType
        /// </summary>
        public static readonly ResourceScanType ECR = new ResourceScanType("ECR");
        /// <summary>
        /// Constant LAMBDA for ResourceScanType
        /// </summary>
        public static readonly ResourceScanType LAMBDA = new ResourceScanType("LAMBDA");
        /// <summary>
        /// Constant LAMBDA_CODE for ResourceScanType
        /// </summary>
        public static readonly ResourceScanType LAMBDA_CODE = new ResourceScanType("LAMBDA_CODE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceScanType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceScanType FindValue(string value)
        {
            return FindValue<ResourceScanType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceScanType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceStringComparison.
    /// </summary>
    public class ResourceStringComparison : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS for ResourceStringComparison
        /// </summary>
        public static readonly ResourceStringComparison EQUALS = new ResourceStringComparison("EQUALS");
        /// <summary>
        /// Constant NOT_EQUALS for ResourceStringComparison
        /// </summary>
        public static readonly ResourceStringComparison NOT_EQUALS = new ResourceStringComparison("NOT_EQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceStringComparison(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceStringComparison FindValue(string value)
        {
            return FindValue<ResourceStringComparison>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceStringComparison(string value)
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
        /// Constant AWS_EC2_INSTANCE for ResourceType
        /// </summary>
        public static readonly ResourceType AWS_EC2_INSTANCE = new ResourceType("AWS_EC2_INSTANCE");
        /// <summary>
        /// Constant AWS_ECR_CONTAINER_IMAGE for ResourceType
        /// </summary>
        public static readonly ResourceType AWS_ECR_CONTAINER_IMAGE = new ResourceType("AWS_ECR_CONTAINER_IMAGE");
        /// <summary>
        /// Constant AWS_ECR_REPOSITORY for ResourceType
        /// </summary>
        public static readonly ResourceType AWS_ECR_REPOSITORY = new ResourceType("AWS_ECR_REPOSITORY");
        /// <summary>
        /// Constant AWS_LAMBDA_FUNCTION for ResourceType
        /// </summary>
        public static readonly ResourceType AWS_LAMBDA_FUNCTION = new ResourceType("AWS_LAMBDA_FUNCTION");
        /// <summary>
        /// Constant CODE_REPOSITORY for ResourceType
        /// </summary>
        public static readonly ResourceType CODE_REPOSITORY = new ResourceType("CODE_REPOSITORY");

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
    /// Constants used for properties of type RuleSetCategory.
    /// </summary>
    public class RuleSetCategory : ConstantClass
    {

        /// <summary>
        /// Constant IAC for RuleSetCategory
        /// </summary>
        public static readonly RuleSetCategory IAC = new RuleSetCategory("IAC");
        /// <summary>
        /// Constant SAST for RuleSetCategory
        /// </summary>
        public static readonly RuleSetCategory SAST = new RuleSetCategory("SAST");
        /// <summary>
        /// Constant SCA for RuleSetCategory
        /// </summary>
        public static readonly RuleSetCategory SCA = new RuleSetCategory("SCA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleSetCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleSetCategory FindValue(string value)
        {
            return FindValue<RuleSetCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleSetCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Runtime.
    /// </summary>
    public class Runtime : ConstantClass
    {

        /// <summary>
        /// Constant DOTNET_6 for Runtime
        /// </summary>
        public static readonly Runtime DOTNET_6 = new Runtime("DOTNET_6");
        /// <summary>
        /// Constant DOTNET_7 for Runtime
        /// </summary>
        public static readonly Runtime DOTNET_7 = new Runtime("DOTNET_7");
        /// <summary>
        /// Constant DOTNETCORE_3_1 for Runtime
        /// </summary>
        public static readonly Runtime DOTNETCORE_3_1 = new Runtime("DOTNETCORE_3_1");
        /// <summary>
        /// Constant GO_1_X for Runtime
        /// </summary>
        public static readonly Runtime GO_1_X = new Runtime("GO_1_X");
        /// <summary>
        /// Constant JAVA_11 for Runtime
        /// </summary>
        public static readonly Runtime JAVA_11 = new Runtime("JAVA_11");
        /// <summary>
        /// Constant JAVA_17 for Runtime
        /// </summary>
        public static readonly Runtime JAVA_17 = new Runtime("JAVA_17");
        /// <summary>
        /// Constant JAVA_8 for Runtime
        /// </summary>
        public static readonly Runtime JAVA_8 = new Runtime("JAVA_8");
        /// <summary>
        /// Constant JAVA_8_AL2 for Runtime
        /// </summary>
        public static readonly Runtime JAVA_8_AL2 = new Runtime("JAVA_8_AL2");
        /// <summary>
        /// Constant NODEJS for Runtime
        /// </summary>
        public static readonly Runtime NODEJS = new Runtime("NODEJS");
        /// <summary>
        /// Constant NODEJS_12_X for Runtime
        /// </summary>
        public static readonly Runtime NODEJS_12_X = new Runtime("NODEJS_12_X");
        /// <summary>
        /// Constant NODEJS_14_X for Runtime
        /// </summary>
        public static readonly Runtime NODEJS_14_X = new Runtime("NODEJS_14_X");
        /// <summary>
        /// Constant NODEJS_16_X for Runtime
        /// </summary>
        public static readonly Runtime NODEJS_16_X = new Runtime("NODEJS_16_X");
        /// <summary>
        /// Constant NODEJS_18_X for Runtime
        /// </summary>
        public static readonly Runtime NODEJS_18_X = new Runtime("NODEJS_18_X");
        /// <summary>
        /// Constant PYTHON_3_10 for Runtime
        /// </summary>
        public static readonly Runtime PYTHON_3_10 = new Runtime("PYTHON_3_10");
        /// <summary>
        /// Constant PYTHON_3_11 for Runtime
        /// </summary>
        public static readonly Runtime PYTHON_3_11 = new Runtime("PYTHON_3_11");
        /// <summary>
        /// Constant PYTHON_3_7 for Runtime
        /// </summary>
        public static readonly Runtime PYTHON_3_7 = new Runtime("PYTHON_3_7");
        /// <summary>
        /// Constant PYTHON_3_8 for Runtime
        /// </summary>
        public static readonly Runtime PYTHON_3_8 = new Runtime("PYTHON_3_8");
        /// <summary>
        /// Constant PYTHON_3_9 for Runtime
        /// </summary>
        public static readonly Runtime PYTHON_3_9 = new Runtime("PYTHON_3_9");
        /// <summary>
        /// Constant RUBY_2_7 for Runtime
        /// </summary>
        public static readonly Runtime RUBY_2_7 = new Runtime("RUBY_2_7");
        /// <summary>
        /// Constant RUBY_3_2 for Runtime
        /// </summary>
        public static readonly Runtime RUBY_3_2 = new Runtime("RUBY_3_2");
        /// <summary>
        /// Constant UNSUPPORTED for Runtime
        /// </summary>
        public static readonly Runtime UNSUPPORTED = new Runtime("UNSUPPORTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Runtime(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Runtime FindValue(string value)
        {
            return FindValue<Runtime>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Runtime(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SbomReportFormat.
    /// </summary>
    public class SbomReportFormat : ConstantClass
    {

        /// <summary>
        /// Constant CYCLONEDX_1_4 for SbomReportFormat
        /// </summary>
        public static readonly SbomReportFormat CYCLONEDX_1_4 = new SbomReportFormat("CYCLONEDX_1_4");
        /// <summary>
        /// Constant SPDX_2_3 for SbomReportFormat
        /// </summary>
        public static readonly SbomReportFormat SPDX_2_3 = new SbomReportFormat("SPDX_2_3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SbomReportFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SbomReportFormat FindValue(string value)
        {
            return FindValue<SbomReportFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SbomReportFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScanMode.
    /// </summary>
    public class ScanMode : ConstantClass
    {

        /// <summary>
        /// Constant EC2_AGENTLESS for ScanMode
        /// </summary>
        public static readonly ScanMode EC2_AGENTLESS = new ScanMode("EC2_AGENTLESS");
        /// <summary>
        /// Constant EC2_SSM_AGENT_BASED for ScanMode
        /// </summary>
        public static readonly ScanMode EC2_SSM_AGENT_BASED = new ScanMode("EC2_SSM_AGENT_BASED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScanMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScanMode FindValue(string value)
        {
            return FindValue<ScanMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScanMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScanStatusCode.
    /// </summary>
    public class ScanStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ScanStatusCode
        /// </summary>
        public static readonly ScanStatusCode ACTIVE = new ScanStatusCode("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for ScanStatusCode
        /// </summary>
        public static readonly ScanStatusCode INACTIVE = new ScanStatusCode("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScanStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScanStatusCode FindValue(string value)
        {
            return FindValue<ScanStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScanStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScanStatusReason.
    /// </summary>
    public class ScanStatusReason : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason ACCESS_DENIED = new ScanStatusReason("ACCESS_DENIED");
        /// <summary>
        /// Constant ACCESS_DENIED_TO_ENCRYPTION_KEY for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason ACCESS_DENIED_TO_ENCRYPTION_KEY = new ScanStatusReason("ACCESS_DENIED_TO_ENCRYPTION_KEY");
        /// <summary>
        /// Constant AGENTLESS_INSTANCE_COLLECTION_TIME_LIMIT_EXCEEDED for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason AGENTLESS_INSTANCE_COLLECTION_TIME_LIMIT_EXCEEDED = new ScanStatusReason("AGENTLESS_INSTANCE_COLLECTION_TIME_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant AGENTLESS_INSTANCE_STORAGE_LIMIT_EXCEEDED for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason AGENTLESS_INSTANCE_STORAGE_LIMIT_EXCEEDED = new ScanStatusReason("AGENTLESS_INSTANCE_STORAGE_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant DEEP_INSPECTION_COLLECTION_TIME_LIMIT_EXCEEDED for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason DEEP_INSPECTION_COLLECTION_TIME_LIMIT_EXCEEDED = new ScanStatusReason("DEEP_INSPECTION_COLLECTION_TIME_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant DEEP_INSPECTION_DAILY_SSM_INVENTORY_LIMIT_EXCEEDED for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason DEEP_INSPECTION_DAILY_SSM_INVENTORY_LIMIT_EXCEEDED = new ScanStatusReason("DEEP_INSPECTION_DAILY_SSM_INVENTORY_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant DEEP_INSPECTION_NO_INVENTORY for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason DEEP_INSPECTION_NO_INVENTORY = new ScanStatusReason("DEEP_INSPECTION_NO_INVENTORY");
        /// <summary>
        /// Constant DEEP_INSPECTION_PACKAGE_COLLECTION_LIMIT_EXCEEDED for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason DEEP_INSPECTION_PACKAGE_COLLECTION_LIMIT_EXCEEDED = new ScanStatusReason("DEEP_INSPECTION_PACKAGE_COLLECTION_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant EC2_INSTANCE_STOPPED for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason EC2_INSTANCE_STOPPED = new ScanStatusReason("EC2_INSTANCE_STOPPED");
        /// <summary>
        /// Constant EXCLUDED_BY_TAG for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason EXCLUDED_BY_TAG = new ScanStatusReason("EXCLUDED_BY_TAG");
        /// <summary>
        /// Constant IMAGE_SIZE_EXCEEDED for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason IMAGE_SIZE_EXCEEDED = new ScanStatusReason("IMAGE_SIZE_EXCEEDED");
        /// <summary>
        /// Constant INTEGRATION_CONNECTION_LOST for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason INTEGRATION_CONNECTION_LOST = new ScanStatusReason("INTEGRATION_CONNECTION_LOST");
        /// <summary>
        /// Constant INTERNAL_ERROR for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason INTERNAL_ERROR = new ScanStatusReason("INTERNAL_ERROR");
        /// <summary>
        /// Constant NO_INVENTORY for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason NO_INVENTORY = new ScanStatusReason("NO_INVENTORY");
        /// <summary>
        /// Constant NO_RESOURCES_FOUND for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason NO_RESOURCES_FOUND = new ScanStatusReason("NO_RESOURCES_FOUND");
        /// <summary>
        /// Constant NO_SCAN_CONFIGURATION_ASSOCIATED for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason NO_SCAN_CONFIGURATION_ASSOCIATED = new ScanStatusReason("NO_SCAN_CONFIGURATION_ASSOCIATED");
        /// <summary>
        /// Constant PENDING_DISABLE for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason PENDING_DISABLE = new ScanStatusReason("PENDING_DISABLE");
        /// <summary>
        /// Constant PENDING_INITIAL_SCAN for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason PENDING_INITIAL_SCAN = new ScanStatusReason("PENDING_INITIAL_SCAN");
        /// <summary>
        /// Constant PENDING_REVIVAL_SCAN for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason PENDING_REVIVAL_SCAN = new ScanStatusReason("PENDING_REVIVAL_SCAN");
        /// <summary>
        /// Constant RESOURCE_TERMINATED for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason RESOURCE_TERMINATED = new ScanStatusReason("RESOURCE_TERMINATED");
        /// <summary>
        /// Constant SCAN_ELIGIBILITY_EXPIRED for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason SCAN_ELIGIBILITY_EXPIRED = new ScanStatusReason("SCAN_ELIGIBILITY_EXPIRED");
        /// <summary>
        /// Constant SCAN_FREQUENCY_MANUAL for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason SCAN_FREQUENCY_MANUAL = new ScanStatusReason("SCAN_FREQUENCY_MANUAL");
        /// <summary>
        /// Constant SCAN_FREQUENCY_SCAN_ON_PUSH for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason SCAN_FREQUENCY_SCAN_ON_PUSH = new ScanStatusReason("SCAN_FREQUENCY_SCAN_ON_PUSH");
        /// <summary>
        /// Constant SCAN_IN_PROGRESS for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason SCAN_IN_PROGRESS = new ScanStatusReason("SCAN_IN_PROGRESS");
        /// <summary>
        /// Constant STALE_INVENTORY for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason STALE_INVENTORY = new ScanStatusReason("STALE_INVENTORY");
        /// <summary>
        /// Constant SUCCESSFUL for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason SUCCESSFUL = new ScanStatusReason("SUCCESSFUL");
        /// <summary>
        /// Constant UNMANAGED_EC2_INSTANCE for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason UNMANAGED_EC2_INSTANCE = new ScanStatusReason("UNMANAGED_EC2_INSTANCE");
        /// <summary>
        /// Constant UNSUPPORTED_CONFIG_FILE for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason UNSUPPORTED_CONFIG_FILE = new ScanStatusReason("UNSUPPORTED_CONFIG_FILE");
        /// <summary>
        /// Constant UNSUPPORTED_LANGUAGE for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason UNSUPPORTED_LANGUAGE = new ScanStatusReason("UNSUPPORTED_LANGUAGE");
        /// <summary>
        /// Constant UNSUPPORTED_MEDIA_TYPE for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason UNSUPPORTED_MEDIA_TYPE = new ScanStatusReason("UNSUPPORTED_MEDIA_TYPE");
        /// <summary>
        /// Constant UNSUPPORTED_OS for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason UNSUPPORTED_OS = new ScanStatusReason("UNSUPPORTED_OS");
        /// <summary>
        /// Constant UNSUPPORTED_RUNTIME for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason UNSUPPORTED_RUNTIME = new ScanStatusReason("UNSUPPORTED_RUNTIME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScanStatusReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScanStatusReason FindValue(string value)
        {
            return FindValue<ScanStatusReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScanStatusReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScanType.
    /// </summary>
    public class ScanType : ConstantClass
    {

        /// <summary>
        /// Constant CODE for ScanType
        /// </summary>
        public static readonly ScanType CODE = new ScanType("CODE");
        /// <summary>
        /// Constant NETWORK for ScanType
        /// </summary>
        public static readonly ScanType NETWORK = new ScanType("NETWORK");
        /// <summary>
        /// Constant PACKAGE for ScanType
        /// </summary>
        public static readonly ScanType PACKAGE = new ScanType("PACKAGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScanType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScanType FindValue(string value)
        {
            return FindValue<ScanType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScanType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Service.
    /// </summary>
    public class Service : ConstantClass
    {

        /// <summary>
        /// Constant EC2 for Service
        /// </summary>
        public static readonly Service EC2 = new Service("EC2");
        /// <summary>
        /// Constant ECR for Service
        /// </summary>
        public static readonly Service ECR = new Service("ECR");
        /// <summary>
        /// Constant LAMBDA for Service
        /// </summary>
        public static readonly Service LAMBDA = new Service("LAMBDA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Service(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Service FindValue(string value)
        {
            return FindValue<Service>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Service(string value)
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
        /// Constant UNTRIAGED for Severity
        /// </summary>
        public static readonly Severity UNTRIAGED = new Severity("UNTRIAGED");

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
    /// Constants used for properties of type SortField.
    /// </summary>
    public class SortField : ConstantClass
    {

        /// <summary>
        /// Constant AWS_ACCOUNT_ID for SortField
        /// </summary>
        public static readonly SortField AWS_ACCOUNT_ID = new SortField("AWS_ACCOUNT_ID");
        /// <summary>
        /// Constant COMPONENT_TYPE for SortField
        /// </summary>
        public static readonly SortField COMPONENT_TYPE = new SortField("COMPONENT_TYPE");
        /// <summary>
        /// Constant ECR_IMAGE_PUSHED_AT for SortField
        /// </summary>
        public static readonly SortField ECR_IMAGE_PUSHED_AT = new SortField("ECR_IMAGE_PUSHED_AT");
        /// <summary>
        /// Constant ECR_IMAGE_REGISTRY for SortField
        /// </summary>
        public static readonly SortField ECR_IMAGE_REGISTRY = new SortField("ECR_IMAGE_REGISTRY");
        /// <summary>
        /// Constant ECR_IMAGE_REPOSITORY_NAME for SortField
        /// </summary>
        public static readonly SortField ECR_IMAGE_REPOSITORY_NAME = new SortField("ECR_IMAGE_REPOSITORY_NAME");
        /// <summary>
        /// Constant EPSS_SCORE for SortField
        /// </summary>
        public static readonly SortField EPSS_SCORE = new SortField("EPSS_SCORE");
        /// <summary>
        /// Constant FINDING_STATUS for SortField
        /// </summary>
        public static readonly SortField FINDING_STATUS = new SortField("FINDING_STATUS");
        /// <summary>
        /// Constant FINDING_TYPE for SortField
        /// </summary>
        public static readonly SortField FINDING_TYPE = new SortField("FINDING_TYPE");
        /// <summary>
        /// Constant FIRST_OBSERVED_AT for SortField
        /// </summary>
        public static readonly SortField FIRST_OBSERVED_AT = new SortField("FIRST_OBSERVED_AT");
        /// <summary>
        /// Constant INSPECTOR_SCORE for SortField
        /// </summary>
        public static readonly SortField INSPECTOR_SCORE = new SortField("INSPECTOR_SCORE");
        /// <summary>
        /// Constant LAST_OBSERVED_AT for SortField
        /// </summary>
        public static readonly SortField LAST_OBSERVED_AT = new SortField("LAST_OBSERVED_AT");
        /// <summary>
        /// Constant NETWORK_PROTOCOL for SortField
        /// </summary>
        public static readonly SortField NETWORK_PROTOCOL = new SortField("NETWORK_PROTOCOL");
        /// <summary>
        /// Constant RESOURCE_TYPE for SortField
        /// </summary>
        public static readonly SortField RESOURCE_TYPE = new SortField("RESOURCE_TYPE");
        /// <summary>
        /// Constant SEVERITY for SortField
        /// </summary>
        public static readonly SortField SEVERITY = new SortField("SEVERITY");
        /// <summary>
        /// Constant VENDOR_SEVERITY for SortField
        /// </summary>
        public static readonly SortField VENDOR_SEVERITY = new SortField("VENDOR_SEVERITY");
        /// <summary>
        /// Constant VULNERABILITY_ID for SortField
        /// </summary>
        public static readonly SortField VULNERABILITY_ID = new SortField("VULNERABILITY_ID");
        /// <summary>
        /// Constant VULNERABILITY_SOURCE for SortField
        /// </summary>
        public static readonly SortField VULNERABILITY_SOURCE = new SortField("VULNERABILITY_SOURCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortField FindValue(string value)
        {
            return FindValue<SortField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortField(string value)
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
    /// Constants used for properties of type Status.
    /// </summary>
    public class Status : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for Status
        /// </summary>
        public static readonly Status DISABLED = new Status("DISABLED");
        /// <summary>
        /// Constant DISABLING for Status
        /// </summary>
        public static readonly Status DISABLING = new Status("DISABLING");
        /// <summary>
        /// Constant ENABLED for Status
        /// </summary>
        public static readonly Status ENABLED = new Status("ENABLED");
        /// <summary>
        /// Constant ENABLING for Status
        /// </summary>
        public static readonly Status ENABLING = new Status("ENABLING");
        /// <summary>
        /// Constant SUSPENDED for Status
        /// </summary>
        public static readonly Status SUSPENDED = new Status("SUSPENDED");
        /// <summary>
        /// Constant SUSPENDING for Status
        /// </summary>
        public static readonly Status SUSPENDING = new Status("SUSPENDING");

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


    /// <summary>
    /// Constants used for properties of type StopCisSessionStatus.
    /// </summary>
    public class StopCisSessionStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for StopCisSessionStatus
        /// </summary>
        public static readonly StopCisSessionStatus FAILED = new StopCisSessionStatus("FAILED");
        /// <summary>
        /// Constant INTERRUPTED for StopCisSessionStatus
        /// </summary>
        public static readonly StopCisSessionStatus INTERRUPTED = new StopCisSessionStatus("INTERRUPTED");
        /// <summary>
        /// Constant SUCCESS for StopCisSessionStatus
        /// </summary>
        public static readonly StopCisSessionStatus SUCCESS = new StopCisSessionStatus("SUCCESS");
        /// <summary>
        /// Constant UNSUPPORTED_OS for StopCisSessionStatus
        /// </summary>
        public static readonly StopCisSessionStatus UNSUPPORTED_OS = new StopCisSessionStatus("UNSUPPORTED_OS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StopCisSessionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StopCisSessionStatus FindValue(string value)
        {
            return FindValue<StopCisSessionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StopCisSessionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StringComparison.
    /// </summary>
    public class StringComparison : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS for StringComparison
        /// </summary>
        public static readonly StringComparison EQUALS = new StringComparison("EQUALS");
        /// <summary>
        /// Constant NOT_EQUALS for StringComparison
        /// </summary>
        public static readonly StringComparison NOT_EQUALS = new StringComparison("NOT_EQUALS");
        /// <summary>
        /// Constant PREFIX for StringComparison
        /// </summary>
        public static readonly StringComparison PREFIX = new StringComparison("PREFIX");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StringComparison(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StringComparison FindValue(string value)
        {
            return FindValue<StringComparison>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StringComparison(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TagComparison.
    /// </summary>
    public class TagComparison : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS for TagComparison
        /// </summary>
        public static readonly TagComparison EQUALS = new TagComparison("EQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TagComparison(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TagComparison FindValue(string value)
        {
            return FindValue<TagComparison>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TagComparison(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TitleSortBy.
    /// </summary>
    public class TitleSortBy : ConstantClass
    {

        /// <summary>
        /// Constant ALL for TitleSortBy
        /// </summary>
        public static readonly TitleSortBy ALL = new TitleSortBy("ALL");
        /// <summary>
        /// Constant CRITICAL for TitleSortBy
        /// </summary>
        public static readonly TitleSortBy CRITICAL = new TitleSortBy("CRITICAL");
        /// <summary>
        /// Constant HIGH for TitleSortBy
        /// </summary>
        public static readonly TitleSortBy HIGH = new TitleSortBy("HIGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TitleSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TitleSortBy FindValue(string value)
        {
            return FindValue<TitleSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TitleSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UsageType.
    /// </summary>
    public class UsageType : ConstantClass
    {

        /// <summary>
        /// Constant CODE_REPOSITORY_IAC for UsageType
        /// </summary>
        public static readonly UsageType CODE_REPOSITORY_IAC = new UsageType("CODE_REPOSITORY_IAC");
        /// <summary>
        /// Constant CODE_REPOSITORY_SAST for UsageType
        /// </summary>
        public static readonly UsageType CODE_REPOSITORY_SAST = new UsageType("CODE_REPOSITORY_SAST");
        /// <summary>
        /// Constant CODE_REPOSITORY_SCA for UsageType
        /// </summary>
        public static readonly UsageType CODE_REPOSITORY_SCA = new UsageType("CODE_REPOSITORY_SCA");
        /// <summary>
        /// Constant EC2_AGENTLESS_INSTANCE_HOURS for UsageType
        /// </summary>
        public static readonly UsageType EC2_AGENTLESS_INSTANCE_HOURS = new UsageType("EC2_AGENTLESS_INSTANCE_HOURS");
        /// <summary>
        /// Constant EC2_INSTANCE_HOURS for UsageType
        /// </summary>
        public static readonly UsageType EC2_INSTANCE_HOURS = new UsageType("EC2_INSTANCE_HOURS");
        /// <summary>
        /// Constant ECR_INITIAL_SCAN for UsageType
        /// </summary>
        public static readonly UsageType ECR_INITIAL_SCAN = new UsageType("ECR_INITIAL_SCAN");
        /// <summary>
        /// Constant ECR_RESCAN for UsageType
        /// </summary>
        public static readonly UsageType ECR_RESCAN = new UsageType("ECR_RESCAN");
        /// <summary>
        /// Constant LAMBDA_FUNCTION_CODE_HOURS for UsageType
        /// </summary>
        public static readonly UsageType LAMBDA_FUNCTION_CODE_HOURS = new UsageType("LAMBDA_FUNCTION_CODE_HOURS");
        /// <summary>
        /// Constant LAMBDA_FUNCTION_HOURS for UsageType
        /// </summary>
        public static readonly UsageType LAMBDA_FUNCTION_HOURS = new UsageType("LAMBDA_FUNCTION_HOURS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UsageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UsageType FindValue(string value)
        {
            return FindValue<UsageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UsageType(string value)
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


    /// <summary>
    /// Constants used for properties of type VulnerabilitySource.
    /// </summary>
    public class VulnerabilitySource : ConstantClass
    {

        /// <summary>
        /// Constant NVD for VulnerabilitySource
        /// </summary>
        public static readonly VulnerabilitySource NVD = new VulnerabilitySource("NVD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VulnerabilitySource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VulnerabilitySource FindValue(string value)
        {
            return FindValue<VulnerabilitySource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VulnerabilitySource(string value)
        {
            return FindValue(value);
        }
    }

}