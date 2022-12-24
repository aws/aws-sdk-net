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
    /// Constants used for properties of type EcrRescanDuration.
    /// </summary>
    public class EcrRescanDuration : ConstantClass
    {

        /// <summary>
        /// Constant DAYS_180 for EcrRescanDuration
        /// </summary>
        public static readonly EcrRescanDuration DAYS_180 = new EcrRescanDuration("DAYS_180");
        /// <summary>
        /// Constant DAYS_30 for EcrRescanDuration
        /// </summary>
        public static readonly EcrRescanDuration DAYS_30 = new EcrRescanDuration("DAYS_30");
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
    /// Constants used for properties of type ResourceScanType.
    /// </summary>
    public class ResourceScanType : ConstantClass
    {

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
    /// Constants used for properties of type Runtime.
    /// </summary>
    public class Runtime : ConstantClass
    {

        /// <summary>
        /// Constant GO_1_X for Runtime
        /// </summary>
        public static readonly Runtime GO_1_X = new Runtime("GO_1_X");
        /// <summary>
        /// Constant JAVA_11 for Runtime
        /// </summary>
        public static readonly Runtime JAVA_11 = new Runtime("JAVA_11");
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
        /// Constant PENDING_DISABLE for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason PENDING_DISABLE = new ScanStatusReason("PENDING_DISABLE");
        /// <summary>
        /// Constant PENDING_INITIAL_SCAN for ScanStatusReason
        /// </summary>
        public static readonly ScanStatusReason PENDING_INITIAL_SCAN = new ScanStatusReason("PENDING_INITIAL_SCAN");
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

}