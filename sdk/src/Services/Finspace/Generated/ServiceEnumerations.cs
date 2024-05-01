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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Finspace
{

    /// <summary>
    /// Constants used for properties of type AutoScalingMetric.
    /// </summary>
    public class AutoScalingMetric : ConstantClass
    {

        /// <summary>
        /// Constant CPU_UTILIZATION_PERCENTAGE for AutoScalingMetric
        /// </summary>
        public static readonly AutoScalingMetric CPU_UTILIZATION_PERCENTAGE = new AutoScalingMetric("CPU_UTILIZATION_PERCENTAGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoScalingMetric(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoScalingMetric FindValue(string value)
        {
            return FindValue<AutoScalingMetric>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoScalingMetric(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChangesetStatus.
    /// </summary>
    public class ChangesetStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for ChangesetStatus
        /// </summary>
        public static readonly ChangesetStatus COMPLETED = new ChangesetStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for ChangesetStatus
        /// </summary>
        public static readonly ChangesetStatus FAILED = new ChangesetStatus("FAILED");
        /// <summary>
        /// Constant PENDING for ChangesetStatus
        /// </summary>
        public static readonly ChangesetStatus PENDING = new ChangesetStatus("PENDING");
        /// <summary>
        /// Constant PROCESSING for ChangesetStatus
        /// </summary>
        public static readonly ChangesetStatus PROCESSING = new ChangesetStatus("PROCESSING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangesetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangesetStatus FindValue(string value)
        {
            return FindValue<ChangesetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangesetStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChangeType.
    /// </summary>
    public class ChangeType : ConstantClass
    {

        /// <summary>
        /// Constant DELETE for ChangeType
        /// </summary>
        public static readonly ChangeType DELETE = new ChangeType("DELETE");
        /// <summary>
        /// Constant PUT for ChangeType
        /// </summary>
        public static readonly ChangeType PUT = new ChangeType("PUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeType FindValue(string value)
        {
            return FindValue<ChangeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DnsStatus.
    /// </summary>
    public class DnsStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED_UPDATE for DnsStatus
        /// </summary>
        public static readonly DnsStatus FAILED_UPDATE = new DnsStatus("FAILED_UPDATE");
        /// <summary>
        /// Constant NONE for DnsStatus
        /// </summary>
        public static readonly DnsStatus NONE = new DnsStatus("NONE");
        /// <summary>
        /// Constant SUCCESSFULLY_UPDATED for DnsStatus
        /// </summary>
        public static readonly DnsStatus SUCCESSFULLY_UPDATED = new DnsStatus("SUCCESSFULLY_UPDATED");
        /// <summary>
        /// Constant UPDATE_REQUESTED for DnsStatus
        /// </summary>
        public static readonly DnsStatus UPDATE_REQUESTED = new DnsStatus("UPDATE_REQUESTED");
        /// <summary>
        /// Constant UPDATING for DnsStatus
        /// </summary>
        public static readonly DnsStatus UPDATING = new DnsStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DnsStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DnsStatus FindValue(string value)
        {
            return FindValue<DnsStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DnsStatus(string value)
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
        /// Constant CREATE_REQUESTED for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus CREATE_REQUESTED = new EnvironmentStatus("CREATE_REQUESTED");
        /// <summary>
        /// Constant CREATED for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus CREATED = new EnvironmentStatus("CREATED");
        /// <summary>
        /// Constant CREATING for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus CREATING = new EnvironmentStatus("CREATING");
        /// <summary>
        /// Constant DELETE_REQUESTED for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus DELETE_REQUESTED = new EnvironmentStatus("DELETE_REQUESTED");
        /// <summary>
        /// Constant DELETED for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus DELETED = new EnvironmentStatus("DELETED");
        /// <summary>
        /// Constant DELETING for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus DELETING = new EnvironmentStatus("DELETING");
        /// <summary>
        /// Constant FAILED_CREATION for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus FAILED_CREATION = new EnvironmentStatus("FAILED_CREATION");
        /// <summary>
        /// Constant FAILED_DELETION for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus FAILED_DELETION = new EnvironmentStatus("FAILED_DELETION");
        /// <summary>
        /// Constant FAILED_UPDATING_NETWORK for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus FAILED_UPDATING_NETWORK = new EnvironmentStatus("FAILED_UPDATING_NETWORK");
        /// <summary>
        /// Constant RETRY_DELETION for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus RETRY_DELETION = new EnvironmentStatus("RETRY_DELETION");
        /// <summary>
        /// Constant SUSPENDED for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus SUSPENDED = new EnvironmentStatus("SUSPENDED");
        /// <summary>
        /// Constant UPDATE_NETWORK_REQUESTED for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus UPDATE_NETWORK_REQUESTED = new EnvironmentStatus("UPDATE_NETWORK_REQUESTED");
        /// <summary>
        /// Constant UPDATING_NETWORK for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus UPDATING_NETWORK = new EnvironmentStatus("UPDATING_NETWORK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnvironmentStatus(string value)
            : base(value)
        {
        }

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
    /// Constants used for properties of type ErrorDetails.
    /// </summary>
    public class ErrorDetails : ConstantClass
    {

        /// <summary>
        /// Constant AnInternalErrorHasOccurred for ErrorDetails
        /// </summary>
        public static readonly ErrorDetails AnInternalErrorHasOccurred = new ErrorDetails("An internal error has occurred.");
        /// <summary>
        /// Constant AUserRecoverableErrorHasOccurred for ErrorDetails
        /// </summary>
        public static readonly ErrorDetails AUserRecoverableErrorHasOccurred = new ErrorDetails("A user recoverable error has occurred");
        /// <summary>
        /// Constant Cancelled for ErrorDetails
        /// </summary>
        public static readonly ErrorDetails Cancelled = new ErrorDetails("Cancelled");
        /// <summary>
        /// Constant MissingRequiredPermissionToPerformThisRequest for ErrorDetails
        /// </summary>
        public static readonly ErrorDetails MissingRequiredPermissionToPerformThisRequest = new ErrorDetails("Missing required permission to perform this request.");
        /// <summary>
        /// Constant OneOrMoreInputsToThisRequestWereNotFound for ErrorDetails
        /// </summary>
        public static readonly ErrorDetails OneOrMoreInputsToThisRequestWereNotFound = new ErrorDetails("One or more inputs to this request were not found.");
        /// <summary>
        /// Constant ServiceLimitsHaveBeenExceeded for ErrorDetails
        /// </summary>
        public static readonly ErrorDetails ServiceLimitsHaveBeenExceeded = new ErrorDetails("Service limits have been exceeded.");
        /// <summary>
        /// Constant TheInputsToThisRequestAreInvalid for ErrorDetails
        /// </summary>
        public static readonly ErrorDetails TheInputsToThisRequestAreInvalid = new ErrorDetails("The inputs to this request are invalid.");
        /// <summary>
        /// Constant TheSystemTemporarilyLacksSufficientResourcesToProcessTheRequest for ErrorDetails
        /// </summary>
        public static readonly ErrorDetails TheSystemTemporarilyLacksSufficientResourcesToProcessTheRequest = new ErrorDetails("The system temporarily lacks sufficient resources to process the request.");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ErrorDetails(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ErrorDetails FindValue(string value)
        {
            return FindValue<ErrorDetails>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ErrorDetails(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FederationMode.
    /// </summary>
    public class FederationMode : ConstantClass
    {

        /// <summary>
        /// Constant FEDERATED for FederationMode
        /// </summary>
        public static readonly FederationMode FEDERATED = new FederationMode("FEDERATED");
        /// <summary>
        /// Constant LOCAL for FederationMode
        /// </summary>
        public static readonly FederationMode LOCAL = new FederationMode("LOCAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FederationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FederationMode FindValue(string value)
        {
            return FindValue<FederationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FederationMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IPAddressType.
    /// </summary>
    public class IPAddressType : ConstantClass
    {

        /// <summary>
        /// Constant IP_V4 for IPAddressType
        /// </summary>
        public static readonly IPAddressType IP_V4 = new IPAddressType("IP_V4");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IPAddressType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IPAddressType FindValue(string value)
        {
            return FindValue<IPAddressType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IPAddressType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KxAzMode.
    /// </summary>
    public class KxAzMode : ConstantClass
    {

        /// <summary>
        /// Constant MULTI for KxAzMode
        /// </summary>
        public static readonly KxAzMode MULTI = new KxAzMode("MULTI");
        /// <summary>
        /// Constant SINGLE for KxAzMode
        /// </summary>
        public static readonly KxAzMode SINGLE = new KxAzMode("SINGLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KxAzMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KxAzMode FindValue(string value)
        {
            return FindValue<KxAzMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KxAzMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KxClusterCodeDeploymentStrategy.
    /// </summary>
    public class KxClusterCodeDeploymentStrategy : ConstantClass
    {

        /// <summary>
        /// Constant FORCE for KxClusterCodeDeploymentStrategy
        /// </summary>
        public static readonly KxClusterCodeDeploymentStrategy FORCE = new KxClusterCodeDeploymentStrategy("FORCE");
        /// <summary>
        /// Constant NO_RESTART for KxClusterCodeDeploymentStrategy
        /// </summary>
        public static readonly KxClusterCodeDeploymentStrategy NO_RESTART = new KxClusterCodeDeploymentStrategy("NO_RESTART");
        /// <summary>
        /// Constant ROLLING for KxClusterCodeDeploymentStrategy
        /// </summary>
        public static readonly KxClusterCodeDeploymentStrategy ROLLING = new KxClusterCodeDeploymentStrategy("ROLLING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KxClusterCodeDeploymentStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KxClusterCodeDeploymentStrategy FindValue(string value)
        {
            return FindValue<KxClusterCodeDeploymentStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KxClusterCodeDeploymentStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KxClusterStatus.
    /// </summary>
    public class KxClusterStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_FAILED for KxClusterStatus
        /// </summary>
        public static readonly KxClusterStatus CREATE_FAILED = new KxClusterStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for KxClusterStatus
        /// </summary>
        public static readonly KxClusterStatus CREATING = new KxClusterStatus("CREATING");
        /// <summary>
        /// Constant DELETE_FAILED for KxClusterStatus
        /// </summary>
        public static readonly KxClusterStatus DELETE_FAILED = new KxClusterStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETED for KxClusterStatus
        /// </summary>
        public static readonly KxClusterStatus DELETED = new KxClusterStatus("DELETED");
        /// <summary>
        /// Constant DELETING for KxClusterStatus
        /// </summary>
        public static readonly KxClusterStatus DELETING = new KxClusterStatus("DELETING");
        /// <summary>
        /// Constant PENDING for KxClusterStatus
        /// </summary>
        public static readonly KxClusterStatus PENDING = new KxClusterStatus("PENDING");
        /// <summary>
        /// Constant RUNNING for KxClusterStatus
        /// </summary>
        public static readonly KxClusterStatus RUNNING = new KxClusterStatus("RUNNING");
        /// <summary>
        /// Constant UPDATING for KxClusterStatus
        /// </summary>
        public static readonly KxClusterStatus UPDATING = new KxClusterStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KxClusterStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KxClusterStatus FindValue(string value)
        {
            return FindValue<KxClusterStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KxClusterStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KxClusterType.
    /// </summary>
    public class KxClusterType : ConstantClass
    {

        /// <summary>
        /// Constant GATEWAY for KxClusterType
        /// </summary>
        public static readonly KxClusterType GATEWAY = new KxClusterType("GATEWAY");
        /// <summary>
        /// Constant GP for KxClusterType
        /// </summary>
        public static readonly KxClusterType GP = new KxClusterType("GP");
        /// <summary>
        /// Constant HDB for KxClusterType
        /// </summary>
        public static readonly KxClusterType HDB = new KxClusterType("HDB");
        /// <summary>
        /// Constant RDB for KxClusterType
        /// </summary>
        public static readonly KxClusterType RDB = new KxClusterType("RDB");
        /// <summary>
        /// Constant TICKERPLANT for KxClusterType
        /// </summary>
        public static readonly KxClusterType TICKERPLANT = new KxClusterType("TICKERPLANT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KxClusterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KxClusterType FindValue(string value)
        {
            return FindValue<KxClusterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KxClusterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KxDataviewStatus.
    /// </summary>
    public class KxDataviewStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for KxDataviewStatus
        /// </summary>
        public static readonly KxDataviewStatus ACTIVE = new KxDataviewStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for KxDataviewStatus
        /// </summary>
        public static readonly KxDataviewStatus CREATING = new KxDataviewStatus("CREATING");
        /// <summary>
        /// Constant DELETING for KxDataviewStatus
        /// </summary>
        public static readonly KxDataviewStatus DELETING = new KxDataviewStatus("DELETING");
        /// <summary>
        /// Constant FAILED for KxDataviewStatus
        /// </summary>
        public static readonly KxDataviewStatus FAILED = new KxDataviewStatus("FAILED");
        /// <summary>
        /// Constant UPDATING for KxDataviewStatus
        /// </summary>
        public static readonly KxDataviewStatus UPDATING = new KxDataviewStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KxDataviewStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KxDataviewStatus FindValue(string value)
        {
            return FindValue<KxDataviewStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KxDataviewStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KxDeploymentStrategy.
    /// </summary>
    public class KxDeploymentStrategy : ConstantClass
    {

        /// <summary>
        /// Constant NO_RESTART for KxDeploymentStrategy
        /// </summary>
        public static readonly KxDeploymentStrategy NO_RESTART = new KxDeploymentStrategy("NO_RESTART");
        /// <summary>
        /// Constant ROLLING for KxDeploymentStrategy
        /// </summary>
        public static readonly KxDeploymentStrategy ROLLING = new KxDeploymentStrategy("ROLLING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KxDeploymentStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KxDeploymentStrategy FindValue(string value)
        {
            return FindValue<KxDeploymentStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KxDeploymentStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KxNAS1Type.
    /// </summary>
    public class KxNAS1Type : ConstantClass
    {

        /// <summary>
        /// Constant HDD_12 for KxNAS1Type
        /// </summary>
        public static readonly KxNAS1Type HDD_12 = new KxNAS1Type("HDD_12");
        /// <summary>
        /// Constant SSD_1000 for KxNAS1Type
        /// </summary>
        public static readonly KxNAS1Type SSD_1000 = new KxNAS1Type("SSD_1000");
        /// <summary>
        /// Constant SSD_250 for KxNAS1Type
        /// </summary>
        public static readonly KxNAS1Type SSD_250 = new KxNAS1Type("SSD_250");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KxNAS1Type(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KxNAS1Type FindValue(string value)
        {
            return FindValue<KxNAS1Type>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KxNAS1Type(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KxNodeStatus.
    /// </summary>
    public class KxNodeStatus : ConstantClass
    {

        /// <summary>
        /// Constant PROVISIONING for KxNodeStatus
        /// </summary>
        public static readonly KxNodeStatus PROVISIONING = new KxNodeStatus("PROVISIONING");
        /// <summary>
        /// Constant RUNNING for KxNodeStatus
        /// </summary>
        public static readonly KxNodeStatus RUNNING = new KxNodeStatus("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KxNodeStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KxNodeStatus FindValue(string value)
        {
            return FindValue<KxNodeStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KxNodeStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KxSavedownStorageType.
    /// </summary>
    public class KxSavedownStorageType : ConstantClass
    {

        /// <summary>
        /// Constant SDS01 for KxSavedownStorageType
        /// </summary>
        public static readonly KxSavedownStorageType SDS01 = new KxSavedownStorageType("SDS01");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KxSavedownStorageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KxSavedownStorageType FindValue(string value)
        {
            return FindValue<KxSavedownStorageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KxSavedownStorageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KxScalingGroupStatus.
    /// </summary>
    public class KxScalingGroupStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for KxScalingGroupStatus
        /// </summary>
        public static readonly KxScalingGroupStatus ACTIVE = new KxScalingGroupStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for KxScalingGroupStatus
        /// </summary>
        public static readonly KxScalingGroupStatus CREATE_FAILED = new KxScalingGroupStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for KxScalingGroupStatus
        /// </summary>
        public static readonly KxScalingGroupStatus CREATING = new KxScalingGroupStatus("CREATING");
        /// <summary>
        /// Constant DELETE_FAILED for KxScalingGroupStatus
        /// </summary>
        public static readonly KxScalingGroupStatus DELETE_FAILED = new KxScalingGroupStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETED for KxScalingGroupStatus
        /// </summary>
        public static readonly KxScalingGroupStatus DELETED = new KxScalingGroupStatus("DELETED");
        /// <summary>
        /// Constant DELETING for KxScalingGroupStatus
        /// </summary>
        public static readonly KxScalingGroupStatus DELETING = new KxScalingGroupStatus("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KxScalingGroupStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KxScalingGroupStatus FindValue(string value)
        {
            return FindValue<KxScalingGroupStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KxScalingGroupStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KxVolumeStatus.
    /// </summary>
    public class KxVolumeStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for KxVolumeStatus
        /// </summary>
        public static readonly KxVolumeStatus ACTIVE = new KxVolumeStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for KxVolumeStatus
        /// </summary>
        public static readonly KxVolumeStatus CREATE_FAILED = new KxVolumeStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for KxVolumeStatus
        /// </summary>
        public static readonly KxVolumeStatus CREATING = new KxVolumeStatus("CREATING");
        /// <summary>
        /// Constant DELETE_FAILED for KxVolumeStatus
        /// </summary>
        public static readonly KxVolumeStatus DELETE_FAILED = new KxVolumeStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETED for KxVolumeStatus
        /// </summary>
        public static readonly KxVolumeStatus DELETED = new KxVolumeStatus("DELETED");
        /// <summary>
        /// Constant DELETING for KxVolumeStatus
        /// </summary>
        public static readonly KxVolumeStatus DELETING = new KxVolumeStatus("DELETING");
        /// <summary>
        /// Constant UPDATE_FAILED for KxVolumeStatus
        /// </summary>
        public static readonly KxVolumeStatus UPDATE_FAILED = new KxVolumeStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATED for KxVolumeStatus
        /// </summary>
        public static readonly KxVolumeStatus UPDATED = new KxVolumeStatus("UPDATED");
        /// <summary>
        /// Constant UPDATING for KxVolumeStatus
        /// </summary>
        public static readonly KxVolumeStatus UPDATING = new KxVolumeStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KxVolumeStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KxVolumeStatus FindValue(string value)
        {
            return FindValue<KxVolumeStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KxVolumeStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KxVolumeType.
    /// </summary>
    public class KxVolumeType : ConstantClass
    {

        /// <summary>
        /// Constant NAS_1 for KxVolumeType
        /// </summary>
        public static readonly KxVolumeType NAS_1 = new KxVolumeType("NAS_1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KxVolumeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KxVolumeType FindValue(string value)
        {
            return FindValue<KxVolumeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KxVolumeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleAction.
    /// </summary>
    public class RuleAction : ConstantClass
    {

        /// <summary>
        /// Constant Allow for RuleAction
        /// </summary>
        public static readonly RuleAction Allow = new RuleAction("allow");
        /// <summary>
        /// Constant Deny for RuleAction
        /// </summary>
        public static readonly RuleAction Deny = new RuleAction("deny");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleAction FindValue(string value)
        {
            return FindValue<RuleAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TgwStatus.
    /// </summary>
    public class TgwStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED_UPDATE for TgwStatus
        /// </summary>
        public static readonly TgwStatus FAILED_UPDATE = new TgwStatus("FAILED_UPDATE");
        /// <summary>
        /// Constant NONE for TgwStatus
        /// </summary>
        public static readonly TgwStatus NONE = new TgwStatus("NONE");
        /// <summary>
        /// Constant SUCCESSFULLY_UPDATED for TgwStatus
        /// </summary>
        public static readonly TgwStatus SUCCESSFULLY_UPDATED = new TgwStatus("SUCCESSFULLY_UPDATED");
        /// <summary>
        /// Constant UPDATE_REQUESTED for TgwStatus
        /// </summary>
        public static readonly TgwStatus UPDATE_REQUESTED = new TgwStatus("UPDATE_REQUESTED");
        /// <summary>
        /// Constant UPDATING for TgwStatus
        /// </summary>
        public static readonly TgwStatus UPDATING = new TgwStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TgwStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TgwStatus FindValue(string value)
        {
            return FindValue<TgwStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TgwStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VolumeType.
    /// </summary>
    public class VolumeType : ConstantClass
    {

        /// <summary>
        /// Constant NAS_1 for VolumeType
        /// </summary>
        public static readonly VolumeType NAS_1 = new VolumeType("NAS_1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VolumeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VolumeType FindValue(string value)
        {
            return FindValue<VolumeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VolumeType(string value)
        {
            return FindValue(value);
        }
    }

}