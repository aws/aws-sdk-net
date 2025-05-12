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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.GameLift
{

    /// <summary>
    /// Constants used for properties of type AcceptanceType.
    /// </summary>
    public class AcceptanceType : ConstantClass
    {

        /// <summary>
        /// Constant ACCEPT for AcceptanceType
        /// </summary>
        public static readonly AcceptanceType ACCEPT = new AcceptanceType("ACCEPT");
        /// <summary>
        /// Constant REJECT for AcceptanceType
        /// </summary>
        public static readonly AcceptanceType REJECT = new AcceptanceType("REJECT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AcceptanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AcceptanceType FindValue(string value)
        {
            return FindValue<AcceptanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AcceptanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BackfillMode.
    /// </summary>
    public class BackfillMode : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATIC for BackfillMode
        /// </summary>
        public static readonly BackfillMode AUTOMATIC = new BackfillMode("AUTOMATIC");
        /// <summary>
        /// Constant MANUAL for BackfillMode
        /// </summary>
        public static readonly BackfillMode MANUAL = new BackfillMode("MANUAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BackfillMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BackfillMode FindValue(string value)
        {
            return FindValue<BackfillMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BackfillMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BalancingStrategy.
    /// </summary>
    public class BalancingStrategy : ConstantClass
    {

        /// <summary>
        /// Constant ON_DEMAND_ONLY for BalancingStrategy
        /// </summary>
        public static readonly BalancingStrategy ON_DEMAND_ONLY = new BalancingStrategy("ON_DEMAND_ONLY");
        /// <summary>
        /// Constant SPOT_ONLY for BalancingStrategy
        /// </summary>
        public static readonly BalancingStrategy SPOT_ONLY = new BalancingStrategy("SPOT_ONLY");
        /// <summary>
        /// Constant SPOT_PREFERRED for BalancingStrategy
        /// </summary>
        public static readonly BalancingStrategy SPOT_PREFERRED = new BalancingStrategy("SPOT_PREFERRED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BalancingStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BalancingStrategy FindValue(string value)
        {
            return FindValue<BalancingStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BalancingStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BuildStatus.
    /// </summary>
    public class BuildStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for BuildStatus
        /// </summary>
        public static readonly BuildStatus FAILED = new BuildStatus("FAILED");
        /// <summary>
        /// Constant INITIALIZED for BuildStatus
        /// </summary>
        public static readonly BuildStatus INITIALIZED = new BuildStatus("INITIALIZED");
        /// <summary>
        /// Constant READY for BuildStatus
        /// </summary>
        public static readonly BuildStatus READY = new BuildStatus("READY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BuildStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BuildStatus FindValue(string value)
        {
            return FindValue<BuildStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BuildStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CertificateType.
    /// </summary>
    public class CertificateType : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for CertificateType
        /// </summary>
        public static readonly CertificateType DISABLED = new CertificateType("DISABLED");
        /// <summary>
        /// Constant GENERATED for CertificateType
        /// </summary>
        public static readonly CertificateType GENERATED = new CertificateType("GENERATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CertificateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CertificateType FindValue(string value)
        {
            return FindValue<CertificateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CertificateType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComparisonOperatorType.
    /// </summary>
    public class ComparisonOperatorType : ConstantClass
    {

        /// <summary>
        /// Constant GreaterThanOrEqualToThreshold for ComparisonOperatorType
        /// </summary>
        public static readonly ComparisonOperatorType GreaterThanOrEqualToThreshold = new ComparisonOperatorType("GreaterThanOrEqualToThreshold");
        /// <summary>
        /// Constant GreaterThanThreshold for ComparisonOperatorType
        /// </summary>
        public static readonly ComparisonOperatorType GreaterThanThreshold = new ComparisonOperatorType("GreaterThanThreshold");
        /// <summary>
        /// Constant LessThanOrEqualToThreshold for ComparisonOperatorType
        /// </summary>
        public static readonly ComparisonOperatorType LessThanOrEqualToThreshold = new ComparisonOperatorType("LessThanOrEqualToThreshold");
        /// <summary>
        /// Constant LessThanThreshold for ComparisonOperatorType
        /// </summary>
        public static readonly ComparisonOperatorType LessThanThreshold = new ComparisonOperatorType("LessThanThreshold");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComparisonOperatorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComparisonOperatorType FindValue(string value)
        {
            return FindValue<ComparisonOperatorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComparisonOperatorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComputeStatus.
    /// </summary>
    public class ComputeStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ComputeStatus
        /// </summary>
        public static readonly ComputeStatus ACTIVE = new ComputeStatus("ACTIVE");
        /// <summary>
        /// Constant IMPAIRED for ComputeStatus
        /// </summary>
        public static readonly ComputeStatus IMPAIRED = new ComputeStatus("IMPAIRED");
        /// <summary>
        /// Constant PENDING for ComputeStatus
        /// </summary>
        public static readonly ComputeStatus PENDING = new ComputeStatus("PENDING");
        /// <summary>
        /// Constant TERMINATING for ComputeStatus
        /// </summary>
        public static readonly ComputeStatus TERMINATING = new ComputeStatus("TERMINATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComputeStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComputeStatus FindValue(string value)
        {
            return FindValue<ComputeStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComputeStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComputeType.
    /// </summary>
    public class ComputeType : ConstantClass
    {

        /// <summary>
        /// Constant ANYWHERE for ComputeType
        /// </summary>
        public static readonly ComputeType ANYWHERE = new ComputeType("ANYWHERE");
        /// <summary>
        /// Constant EC2 for ComputeType
        /// </summary>
        public static readonly ComputeType EC2 = new ComputeType("EC2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComputeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComputeType FindValue(string value)
        {
            return FindValue<ComputeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComputeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContainerDependencyCondition.
    /// </summary>
    public class ContainerDependencyCondition : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for ContainerDependencyCondition
        /// </summary>
        public static readonly ContainerDependencyCondition COMPLETE = new ContainerDependencyCondition("COMPLETE");
        /// <summary>
        /// Constant HEALTHY for ContainerDependencyCondition
        /// </summary>
        public static readonly ContainerDependencyCondition HEALTHY = new ContainerDependencyCondition("HEALTHY");
        /// <summary>
        /// Constant START for ContainerDependencyCondition
        /// </summary>
        public static readonly ContainerDependencyCondition START = new ContainerDependencyCondition("START");
        /// <summary>
        /// Constant SUCCESS for ContainerDependencyCondition
        /// </summary>
        public static readonly ContainerDependencyCondition SUCCESS = new ContainerDependencyCondition("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContainerDependencyCondition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerDependencyCondition FindValue(string value)
        {
            return FindValue<ContainerDependencyCondition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContainerDependencyCondition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContainerFleetBillingType.
    /// </summary>
    public class ContainerFleetBillingType : ConstantClass
    {

        /// <summary>
        /// Constant ON_DEMAND for ContainerFleetBillingType
        /// </summary>
        public static readonly ContainerFleetBillingType ON_DEMAND = new ContainerFleetBillingType("ON_DEMAND");
        /// <summary>
        /// Constant SPOT for ContainerFleetBillingType
        /// </summary>
        public static readonly ContainerFleetBillingType SPOT = new ContainerFleetBillingType("SPOT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContainerFleetBillingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerFleetBillingType FindValue(string value)
        {
            return FindValue<ContainerFleetBillingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContainerFleetBillingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContainerFleetLocationStatus.
    /// </summary>
    public class ContainerFleetLocationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATING for ContainerFleetLocationStatus
        /// </summary>
        public static readonly ContainerFleetLocationStatus ACTIVATING = new ContainerFleetLocationStatus("ACTIVATING");
        /// <summary>
        /// Constant ACTIVE for ContainerFleetLocationStatus
        /// </summary>
        public static readonly ContainerFleetLocationStatus ACTIVE = new ContainerFleetLocationStatus("ACTIVE");
        /// <summary>
        /// Constant CREATED for ContainerFleetLocationStatus
        /// </summary>
        public static readonly ContainerFleetLocationStatus CREATED = new ContainerFleetLocationStatus("CREATED");
        /// <summary>
        /// Constant CREATING for ContainerFleetLocationStatus
        /// </summary>
        public static readonly ContainerFleetLocationStatus CREATING = new ContainerFleetLocationStatus("CREATING");
        /// <summary>
        /// Constant DELETING for ContainerFleetLocationStatus
        /// </summary>
        public static readonly ContainerFleetLocationStatus DELETING = new ContainerFleetLocationStatus("DELETING");
        /// <summary>
        /// Constant PENDING for ContainerFleetLocationStatus
        /// </summary>
        public static readonly ContainerFleetLocationStatus PENDING = new ContainerFleetLocationStatus("PENDING");
        /// <summary>
        /// Constant UPDATING for ContainerFleetLocationStatus
        /// </summary>
        public static readonly ContainerFleetLocationStatus UPDATING = new ContainerFleetLocationStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContainerFleetLocationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerFleetLocationStatus FindValue(string value)
        {
            return FindValue<ContainerFleetLocationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContainerFleetLocationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContainerFleetRemoveAttribute.
    /// </summary>
    public class ContainerFleetRemoveAttribute : ConstantClass
    {

        /// <summary>
        /// Constant PER_INSTANCE_CONTAINER_GROUP_DEFINITION for ContainerFleetRemoveAttribute
        /// </summary>
        public static readonly ContainerFleetRemoveAttribute PER_INSTANCE_CONTAINER_GROUP_DEFINITION = new ContainerFleetRemoveAttribute("PER_INSTANCE_CONTAINER_GROUP_DEFINITION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContainerFleetRemoveAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerFleetRemoveAttribute FindValue(string value)
        {
            return FindValue<ContainerFleetRemoveAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContainerFleetRemoveAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContainerFleetStatus.
    /// </summary>
    public class ContainerFleetStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATING for ContainerFleetStatus
        /// </summary>
        public static readonly ContainerFleetStatus ACTIVATING = new ContainerFleetStatus("ACTIVATING");
        /// <summary>
        /// Constant ACTIVE for ContainerFleetStatus
        /// </summary>
        public static readonly ContainerFleetStatus ACTIVE = new ContainerFleetStatus("ACTIVE");
        /// <summary>
        /// Constant CREATED for ContainerFleetStatus
        /// </summary>
        public static readonly ContainerFleetStatus CREATED = new ContainerFleetStatus("CREATED");
        /// <summary>
        /// Constant CREATING for ContainerFleetStatus
        /// </summary>
        public static readonly ContainerFleetStatus CREATING = new ContainerFleetStatus("CREATING");
        /// <summary>
        /// Constant DELETING for ContainerFleetStatus
        /// </summary>
        public static readonly ContainerFleetStatus DELETING = new ContainerFleetStatus("DELETING");
        /// <summary>
        /// Constant PENDING for ContainerFleetStatus
        /// </summary>
        public static readonly ContainerFleetStatus PENDING = new ContainerFleetStatus("PENDING");
        /// <summary>
        /// Constant UPDATING for ContainerFleetStatus
        /// </summary>
        public static readonly ContainerFleetStatus UPDATING = new ContainerFleetStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContainerFleetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerFleetStatus FindValue(string value)
        {
            return FindValue<ContainerFleetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContainerFleetStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContainerGroupDefinitionStatus.
    /// </summary>
    public class ContainerGroupDefinitionStatus : ConstantClass
    {

        /// <summary>
        /// Constant COPYING for ContainerGroupDefinitionStatus
        /// </summary>
        public static readonly ContainerGroupDefinitionStatus COPYING = new ContainerGroupDefinitionStatus("COPYING");
        /// <summary>
        /// Constant FAILED for ContainerGroupDefinitionStatus
        /// </summary>
        public static readonly ContainerGroupDefinitionStatus FAILED = new ContainerGroupDefinitionStatus("FAILED");
        /// <summary>
        /// Constant READY for ContainerGroupDefinitionStatus
        /// </summary>
        public static readonly ContainerGroupDefinitionStatus READY = new ContainerGroupDefinitionStatus("READY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContainerGroupDefinitionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerGroupDefinitionStatus FindValue(string value)
        {
            return FindValue<ContainerGroupDefinitionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContainerGroupDefinitionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContainerGroupType.
    /// </summary>
    public class ContainerGroupType : ConstantClass
    {

        /// <summary>
        /// Constant GAME_SERVER for ContainerGroupType
        /// </summary>
        public static readonly ContainerGroupType GAME_SERVER = new ContainerGroupType("GAME_SERVER");
        /// <summary>
        /// Constant PER_INSTANCE for ContainerGroupType
        /// </summary>
        public static readonly ContainerGroupType PER_INSTANCE = new ContainerGroupType("PER_INSTANCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContainerGroupType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerGroupType FindValue(string value)
        {
            return FindValue<ContainerGroupType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContainerGroupType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContainerMountPointAccessLevel.
    /// </summary>
    public class ContainerMountPointAccessLevel : ConstantClass
    {

        /// <summary>
        /// Constant READ_AND_WRITE for ContainerMountPointAccessLevel
        /// </summary>
        public static readonly ContainerMountPointAccessLevel READ_AND_WRITE = new ContainerMountPointAccessLevel("READ_AND_WRITE");
        /// <summary>
        /// Constant READ_ONLY for ContainerMountPointAccessLevel
        /// </summary>
        public static readonly ContainerMountPointAccessLevel READ_ONLY = new ContainerMountPointAccessLevel("READ_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContainerMountPointAccessLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerMountPointAccessLevel FindValue(string value)
        {
            return FindValue<ContainerMountPointAccessLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContainerMountPointAccessLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContainerOperatingSystem.
    /// </summary>
    public class ContainerOperatingSystem : ConstantClass
    {

        /// <summary>
        /// Constant AMAZON_LINUX_2023 for ContainerOperatingSystem
        /// </summary>
        public static readonly ContainerOperatingSystem AMAZON_LINUX_2023 = new ContainerOperatingSystem("AMAZON_LINUX_2023");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContainerOperatingSystem(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerOperatingSystem FindValue(string value)
        {
            return FindValue<ContainerOperatingSystem>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContainerOperatingSystem(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentImpairmentStrategy.
    /// </summary>
    public class DeploymentImpairmentStrategy : ConstantClass
    {

        /// <summary>
        /// Constant MAINTAIN for DeploymentImpairmentStrategy
        /// </summary>
        public static readonly DeploymentImpairmentStrategy MAINTAIN = new DeploymentImpairmentStrategy("MAINTAIN");
        /// <summary>
        /// Constant ROLLBACK for DeploymentImpairmentStrategy
        /// </summary>
        public static readonly DeploymentImpairmentStrategy ROLLBACK = new DeploymentImpairmentStrategy("ROLLBACK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentImpairmentStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentImpairmentStrategy FindValue(string value)
        {
            return FindValue<DeploymentImpairmentStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentImpairmentStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentProtectionStrategy.
    /// </summary>
    public class DeploymentProtectionStrategy : ConstantClass
    {

        /// <summary>
        /// Constant IGNORE_PROTECTION for DeploymentProtectionStrategy
        /// </summary>
        public static readonly DeploymentProtectionStrategy IGNORE_PROTECTION = new DeploymentProtectionStrategy("IGNORE_PROTECTION");
        /// <summary>
        /// Constant WITH_PROTECTION for DeploymentProtectionStrategy
        /// </summary>
        public static readonly DeploymentProtectionStrategy WITH_PROTECTION = new DeploymentProtectionStrategy("WITH_PROTECTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentProtectionStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentProtectionStrategy FindValue(string value)
        {
            return FindValue<DeploymentProtectionStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentProtectionStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentStatus.
    /// </summary>
    public class DeploymentStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus CANCELLED = new DeploymentStatus("CANCELLED");
        /// <summary>
        /// Constant COMPLETE for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus COMPLETE = new DeploymentStatus("COMPLETE");
        /// <summary>
        /// Constant IMPAIRED for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus IMPAIRED = new DeploymentStatus("IMPAIRED");
        /// <summary>
        /// Constant IN_PROGRESS for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus IN_PROGRESS = new DeploymentStatus("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus PENDING = new DeploymentStatus("PENDING");
        /// <summary>
        /// Constant ROLLBACK_COMPLETE for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus ROLLBACK_COMPLETE = new DeploymentStatus("ROLLBACK_COMPLETE");
        /// <summary>
        /// Constant ROLLBACK_IN_PROGRESS for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus ROLLBACK_IN_PROGRESS = new DeploymentStatus("ROLLBACK_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentStatus FindValue(string value)
        {
            return FindValue<DeploymentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EC2InstanceType.
    /// </summary>
    public class EC2InstanceType : ConstantClass
    {

        /// <summary>
        /// Constant C32xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C32xlarge = new EC2InstanceType("c3.2xlarge");
        /// <summary>
        /// Constant C34xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C34xlarge = new EC2InstanceType("c3.4xlarge");
        /// <summary>
        /// Constant C38xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C38xlarge = new EC2InstanceType("c3.8xlarge");
        /// <summary>
        /// Constant C3Large for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C3Large = new EC2InstanceType("c3.large");
        /// <summary>
        /// Constant C3Xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C3Xlarge = new EC2InstanceType("c3.xlarge");
        /// <summary>
        /// Constant C42xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C42xlarge = new EC2InstanceType("c4.2xlarge");
        /// <summary>
        /// Constant C44xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C44xlarge = new EC2InstanceType("c4.4xlarge");
        /// <summary>
        /// Constant C48xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C48xlarge = new EC2InstanceType("c4.8xlarge");
        /// <summary>
        /// Constant C4Large for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C4Large = new EC2InstanceType("c4.large");
        /// <summary>
        /// Constant C4Xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C4Xlarge = new EC2InstanceType("c4.xlarge");
        /// <summary>
        /// Constant C512xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C512xlarge = new EC2InstanceType("c5.12xlarge");
        /// <summary>
        /// Constant C518xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C518xlarge = new EC2InstanceType("c5.18xlarge");
        /// <summary>
        /// Constant C524xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C524xlarge = new EC2InstanceType("c5.24xlarge");
        /// <summary>
        /// Constant C52xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C52xlarge = new EC2InstanceType("c5.2xlarge");
        /// <summary>
        /// Constant C54xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C54xlarge = new EC2InstanceType("c5.4xlarge");
        /// <summary>
        /// Constant C59xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C59xlarge = new EC2InstanceType("c5.9xlarge");
        /// <summary>
        /// Constant C5a12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5a12xlarge = new EC2InstanceType("c5a.12xlarge");
        /// <summary>
        /// Constant C5a16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5a16xlarge = new EC2InstanceType("c5a.16xlarge");
        /// <summary>
        /// Constant C5a24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5a24xlarge = new EC2InstanceType("c5a.24xlarge");
        /// <summary>
        /// Constant C5a2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5a2xlarge = new EC2InstanceType("c5a.2xlarge");
        /// <summary>
        /// Constant C5a4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5a4xlarge = new EC2InstanceType("c5a.4xlarge");
        /// <summary>
        /// Constant C5a8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5a8xlarge = new EC2InstanceType("c5a.8xlarge");
        /// <summary>
        /// Constant C5ad12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5ad12xlarge = new EC2InstanceType("c5ad.12xlarge");
        /// <summary>
        /// Constant C5ad16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5ad16xlarge = new EC2InstanceType("c5ad.16xlarge");
        /// <summary>
        /// Constant C5ad24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5ad24xlarge = new EC2InstanceType("c5ad.24xlarge");
        /// <summary>
        /// Constant C5ad2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5ad2xlarge = new EC2InstanceType("c5ad.2xlarge");
        /// <summary>
        /// Constant C5ad4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5ad4xlarge = new EC2InstanceType("c5ad.4xlarge");
        /// <summary>
        /// Constant C5ad8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5ad8xlarge = new EC2InstanceType("c5ad.8xlarge");
        /// <summary>
        /// Constant C5adLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5adLarge = new EC2InstanceType("c5ad.large");
        /// <summary>
        /// Constant C5adXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5adXlarge = new EC2InstanceType("c5ad.xlarge");
        /// <summary>
        /// Constant C5aLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5aLarge = new EC2InstanceType("c5a.large");
        /// <summary>
        /// Constant C5aXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5aXlarge = new EC2InstanceType("c5a.xlarge");
        /// <summary>
        /// Constant C5d12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5d12xlarge = new EC2InstanceType("c5d.12xlarge");
        /// <summary>
        /// Constant C5d18xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5d18xlarge = new EC2InstanceType("c5d.18xlarge");
        /// <summary>
        /// Constant C5d24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5d24xlarge = new EC2InstanceType("c5d.24xlarge");
        /// <summary>
        /// Constant C5d2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5d2xlarge = new EC2InstanceType("c5d.2xlarge");
        /// <summary>
        /// Constant C5d4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5d4xlarge = new EC2InstanceType("c5d.4xlarge");
        /// <summary>
        /// Constant C5d9xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5d9xlarge = new EC2InstanceType("c5d.9xlarge");
        /// <summary>
        /// Constant C5dLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5dLarge = new EC2InstanceType("c5d.large");
        /// <summary>
        /// Constant C5dXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5dXlarge = new EC2InstanceType("c5d.xlarge");
        /// <summary>
        /// Constant C5Large for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5Large = new EC2InstanceType("c5.large");
        /// <summary>
        /// Constant C5n18xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5n18xlarge = new EC2InstanceType("c5n.18xlarge");
        /// <summary>
        /// Constant C5n2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5n2xlarge = new EC2InstanceType("c5n.2xlarge");
        /// <summary>
        /// Constant C5n4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5n4xlarge = new EC2InstanceType("c5n.4xlarge");
        /// <summary>
        /// Constant C5n9xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5n9xlarge = new EC2InstanceType("c5n.9xlarge");
        /// <summary>
        /// Constant C5nLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5nLarge = new EC2InstanceType("c5n.large");
        /// <summary>
        /// Constant C5nXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5nXlarge = new EC2InstanceType("c5n.xlarge");
        /// <summary>
        /// Constant C5Xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C5Xlarge = new EC2InstanceType("c5.xlarge");
        /// <summary>
        /// Constant C6a12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6a12xlarge = new EC2InstanceType("c6a.12xlarge");
        /// <summary>
        /// Constant C6a16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6a16xlarge = new EC2InstanceType("c6a.16xlarge");
        /// <summary>
        /// Constant C6a24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6a24xlarge = new EC2InstanceType("c6a.24xlarge");
        /// <summary>
        /// Constant C6a2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6a2xlarge = new EC2InstanceType("c6a.2xlarge");
        /// <summary>
        /// Constant C6a32xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6a32xlarge = new EC2InstanceType("c6a.32xlarge");
        /// <summary>
        /// Constant C6a48xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6a48xlarge = new EC2InstanceType("c6a.48xlarge");
        /// <summary>
        /// Constant C6a4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6a4xlarge = new EC2InstanceType("c6a.4xlarge");
        /// <summary>
        /// Constant C6a8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6a8xlarge = new EC2InstanceType("c6a.8xlarge");
        /// <summary>
        /// Constant C6aLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6aLarge = new EC2InstanceType("c6a.large");
        /// <summary>
        /// Constant C6aXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6aXlarge = new EC2InstanceType("c6a.xlarge");
        /// <summary>
        /// Constant C6g12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6g12xlarge = new EC2InstanceType("c6g.12xlarge");
        /// <summary>
        /// Constant C6g16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6g16xlarge = new EC2InstanceType("c6g.16xlarge");
        /// <summary>
        /// Constant C6g2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6g2xlarge = new EC2InstanceType("c6g.2xlarge");
        /// <summary>
        /// Constant C6g4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6g4xlarge = new EC2InstanceType("c6g.4xlarge");
        /// <summary>
        /// Constant C6g8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6g8xlarge = new EC2InstanceType("c6g.8xlarge");
        /// <summary>
        /// Constant C6gd12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6gd12xlarge = new EC2InstanceType("c6gd.12xlarge");
        /// <summary>
        /// Constant C6gd16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6gd16xlarge = new EC2InstanceType("c6gd.16xlarge");
        /// <summary>
        /// Constant C6gd2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6gd2xlarge = new EC2InstanceType("c6gd.2xlarge");
        /// <summary>
        /// Constant C6gd4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6gd4xlarge = new EC2InstanceType("c6gd.4xlarge");
        /// <summary>
        /// Constant C6gd8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6gd8xlarge = new EC2InstanceType("c6gd.8xlarge");
        /// <summary>
        /// Constant C6gdLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6gdLarge = new EC2InstanceType("c6gd.large");
        /// <summary>
        /// Constant C6gdMedium for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6gdMedium = new EC2InstanceType("c6gd.medium");
        /// <summary>
        /// Constant C6gdXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6gdXlarge = new EC2InstanceType("c6gd.xlarge");
        /// <summary>
        /// Constant C6gLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6gLarge = new EC2InstanceType("c6g.large");
        /// <summary>
        /// Constant C6gMedium for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6gMedium = new EC2InstanceType("c6g.medium");
        /// <summary>
        /// Constant C6gn12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6gn12xlarge = new EC2InstanceType("c6gn.12xlarge");
        /// <summary>
        /// Constant C6gn16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6gn16xlarge = new EC2InstanceType("c6gn.16xlarge");
        /// <summary>
        /// Constant C6gn2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6gn2xlarge = new EC2InstanceType("c6gn.2xlarge");
        /// <summary>
        /// Constant C6gn4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6gn4xlarge = new EC2InstanceType("c6gn.4xlarge");
        /// <summary>
        /// Constant C6gn8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6gn8xlarge = new EC2InstanceType("c6gn.8xlarge");
        /// <summary>
        /// Constant C6gnLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6gnLarge = new EC2InstanceType("c6gn.large");
        /// <summary>
        /// Constant C6gnMedium for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6gnMedium = new EC2InstanceType("c6gn.medium");
        /// <summary>
        /// Constant C6gnXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6gnXlarge = new EC2InstanceType("c6gn.xlarge");
        /// <summary>
        /// Constant C6gXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6gXlarge = new EC2InstanceType("c6g.xlarge");
        /// <summary>
        /// Constant C6i12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6i12xlarge = new EC2InstanceType("c6i.12xlarge");
        /// <summary>
        /// Constant C6i16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6i16xlarge = new EC2InstanceType("c6i.16xlarge");
        /// <summary>
        /// Constant C6i24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6i24xlarge = new EC2InstanceType("c6i.24xlarge");
        /// <summary>
        /// Constant C6i2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6i2xlarge = new EC2InstanceType("c6i.2xlarge");
        /// <summary>
        /// Constant C6i32xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6i32xlarge = new EC2InstanceType("c6i.32xlarge");
        /// <summary>
        /// Constant C6i4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6i4xlarge = new EC2InstanceType("c6i.4xlarge");
        /// <summary>
        /// Constant C6i8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6i8xlarge = new EC2InstanceType("c6i.8xlarge");
        /// <summary>
        /// Constant C6id12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6id12xlarge = new EC2InstanceType("c6id.12xlarge");
        /// <summary>
        /// Constant C6id16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6id16xlarge = new EC2InstanceType("c6id.16xlarge");
        /// <summary>
        /// Constant C6id24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6id24xlarge = new EC2InstanceType("c6id.24xlarge");
        /// <summary>
        /// Constant C6id2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6id2xlarge = new EC2InstanceType("c6id.2xlarge");
        /// <summary>
        /// Constant C6id32xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6id32xlarge = new EC2InstanceType("c6id.32xlarge");
        /// <summary>
        /// Constant C6id4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6id4xlarge = new EC2InstanceType("c6id.4xlarge");
        /// <summary>
        /// Constant C6id8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6id8xlarge = new EC2InstanceType("c6id.8xlarge");
        /// <summary>
        /// Constant C6idLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6idLarge = new EC2InstanceType("c6id.large");
        /// <summary>
        /// Constant C6idXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6idXlarge = new EC2InstanceType("c6id.xlarge");
        /// <summary>
        /// Constant C6iLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6iLarge = new EC2InstanceType("c6i.large");
        /// <summary>
        /// Constant C6in12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6in12xlarge = new EC2InstanceType("c6in.12xlarge");
        /// <summary>
        /// Constant C6in16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6in16xlarge = new EC2InstanceType("c6in.16xlarge");
        /// <summary>
        /// Constant C6in24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6in24xlarge = new EC2InstanceType("c6in.24xlarge");
        /// <summary>
        /// Constant C6in2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6in2xlarge = new EC2InstanceType("c6in.2xlarge");
        /// <summary>
        /// Constant C6in32xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6in32xlarge = new EC2InstanceType("c6in.32xlarge");
        /// <summary>
        /// Constant C6in4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6in4xlarge = new EC2InstanceType("c6in.4xlarge");
        /// <summary>
        /// Constant C6in8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6in8xlarge = new EC2InstanceType("c6in.8xlarge");
        /// <summary>
        /// Constant C6inLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6inLarge = new EC2InstanceType("c6in.large");
        /// <summary>
        /// Constant C6inXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6inXlarge = new EC2InstanceType("c6in.xlarge");
        /// <summary>
        /// Constant C6iXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C6iXlarge = new EC2InstanceType("c6i.xlarge");
        /// <summary>
        /// Constant C7a12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7a12xlarge = new EC2InstanceType("c7a.12xlarge");
        /// <summary>
        /// Constant C7a16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7a16xlarge = new EC2InstanceType("c7a.16xlarge");
        /// <summary>
        /// Constant C7a24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7a24xlarge = new EC2InstanceType("c7a.24xlarge");
        /// <summary>
        /// Constant C7a2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7a2xlarge = new EC2InstanceType("c7a.2xlarge");
        /// <summary>
        /// Constant C7a32xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7a32xlarge = new EC2InstanceType("c7a.32xlarge");
        /// <summary>
        /// Constant C7a48xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7a48xlarge = new EC2InstanceType("c7a.48xlarge");
        /// <summary>
        /// Constant C7a4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7a4xlarge = new EC2InstanceType("c7a.4xlarge");
        /// <summary>
        /// Constant C7a8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7a8xlarge = new EC2InstanceType("c7a.8xlarge");
        /// <summary>
        /// Constant C7aLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7aLarge = new EC2InstanceType("c7a.large");
        /// <summary>
        /// Constant C7aMedium for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7aMedium = new EC2InstanceType("c7a.medium");
        /// <summary>
        /// Constant C7aXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7aXlarge = new EC2InstanceType("c7a.xlarge");
        /// <summary>
        /// Constant C7g12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7g12xlarge = new EC2InstanceType("c7g.12xlarge");
        /// <summary>
        /// Constant C7g16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7g16xlarge = new EC2InstanceType("c7g.16xlarge");
        /// <summary>
        /// Constant C7g2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7g2xlarge = new EC2InstanceType("c7g.2xlarge");
        /// <summary>
        /// Constant C7g4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7g4xlarge = new EC2InstanceType("c7g.4xlarge");
        /// <summary>
        /// Constant C7g8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7g8xlarge = new EC2InstanceType("c7g.8xlarge");
        /// <summary>
        /// Constant C7gd12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7gd12xlarge = new EC2InstanceType("c7gd.12xlarge");
        /// <summary>
        /// Constant C7gd16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7gd16xlarge = new EC2InstanceType("c7gd.16xlarge");
        /// <summary>
        /// Constant C7gd2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7gd2xlarge = new EC2InstanceType("c7gd.2xlarge");
        /// <summary>
        /// Constant C7gd4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7gd4xlarge = new EC2InstanceType("c7gd.4xlarge");
        /// <summary>
        /// Constant C7gd8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7gd8xlarge = new EC2InstanceType("c7gd.8xlarge");
        /// <summary>
        /// Constant C7gdLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7gdLarge = new EC2InstanceType("c7gd.large");
        /// <summary>
        /// Constant C7gdMedium for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7gdMedium = new EC2InstanceType("c7gd.medium");
        /// <summary>
        /// Constant C7gdXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7gdXlarge = new EC2InstanceType("c7gd.xlarge");
        /// <summary>
        /// Constant C7gLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7gLarge = new EC2InstanceType("c7g.large");
        /// <summary>
        /// Constant C7gMedium for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7gMedium = new EC2InstanceType("c7g.medium");
        /// <summary>
        /// Constant C7gn12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7gn12xlarge = new EC2InstanceType("c7gn.12xlarge");
        /// <summary>
        /// Constant C7gn16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7gn16xlarge = new EC2InstanceType("c7gn.16xlarge");
        /// <summary>
        /// Constant C7gn2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7gn2xlarge = new EC2InstanceType("c7gn.2xlarge");
        /// <summary>
        /// Constant C7gn4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7gn4xlarge = new EC2InstanceType("c7gn.4xlarge");
        /// <summary>
        /// Constant C7gn8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7gn8xlarge = new EC2InstanceType("c7gn.8xlarge");
        /// <summary>
        /// Constant C7gnLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7gnLarge = new EC2InstanceType("c7gn.large");
        /// <summary>
        /// Constant C7gnMedium for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7gnMedium = new EC2InstanceType("c7gn.medium");
        /// <summary>
        /// Constant C7gnXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7gnXlarge = new EC2InstanceType("c7gn.xlarge");
        /// <summary>
        /// Constant C7gXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7gXlarge = new EC2InstanceType("c7g.xlarge");
        /// <summary>
        /// Constant C7i12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7i12xlarge = new EC2InstanceType("c7i.12xlarge");
        /// <summary>
        /// Constant C7i16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7i16xlarge = new EC2InstanceType("c7i.16xlarge");
        /// <summary>
        /// Constant C7i24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7i24xlarge = new EC2InstanceType("c7i.24xlarge");
        /// <summary>
        /// Constant C7i2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7i2xlarge = new EC2InstanceType("c7i.2xlarge");
        /// <summary>
        /// Constant C7i48xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7i48xlarge = new EC2InstanceType("c7i.48xlarge");
        /// <summary>
        /// Constant C7i4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7i4xlarge = new EC2InstanceType("c7i.4xlarge");
        /// <summary>
        /// Constant C7i8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7i8xlarge = new EC2InstanceType("c7i.8xlarge");
        /// <summary>
        /// Constant C7iLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7iLarge = new EC2InstanceType("c7i.large");
        /// <summary>
        /// Constant C7iXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C7iXlarge = new EC2InstanceType("c7i.xlarge");
        /// <summary>
        /// Constant C8g12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C8g12xlarge = new EC2InstanceType("c8g.12xlarge");
        /// <summary>
        /// Constant C8g16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C8g16xlarge = new EC2InstanceType("c8g.16xlarge");
        /// <summary>
        /// Constant C8g24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C8g24xlarge = new EC2InstanceType("c8g.24xlarge");
        /// <summary>
        /// Constant C8g2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C8g2xlarge = new EC2InstanceType("c8g.2xlarge");
        /// <summary>
        /// Constant C8g48xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C8g48xlarge = new EC2InstanceType("c8g.48xlarge");
        /// <summary>
        /// Constant C8g4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C8g4xlarge = new EC2InstanceType("c8g.4xlarge");
        /// <summary>
        /// Constant C8g8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C8g8xlarge = new EC2InstanceType("c8g.8xlarge");
        /// <summary>
        /// Constant C8gLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C8gLarge = new EC2InstanceType("c8g.large");
        /// <summary>
        /// Constant C8gMedium for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C8gMedium = new EC2InstanceType("c8g.medium");
        /// <summary>
        /// Constant C8gXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType C8gXlarge = new EC2InstanceType("c8g.xlarge");
        /// <summary>
        /// Constant G5g16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType G5g16xlarge = new EC2InstanceType("g5g.16xlarge");
        /// <summary>
        /// Constant G5g2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType G5g2xlarge = new EC2InstanceType("g5g.2xlarge");
        /// <summary>
        /// Constant G5g4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType G5g4xlarge = new EC2InstanceType("g5g.4xlarge");
        /// <summary>
        /// Constant G5g8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType G5g8xlarge = new EC2InstanceType("g5g.8xlarge");
        /// <summary>
        /// Constant G5gXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType G5gXlarge = new EC2InstanceType("g5g.xlarge");
        /// <summary>
        /// Constant M32xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M32xlarge = new EC2InstanceType("m3.2xlarge");
        /// <summary>
        /// Constant M3Large for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M3Large = new EC2InstanceType("m3.large");
        /// <summary>
        /// Constant M3Medium for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M3Medium = new EC2InstanceType("m3.medium");
        /// <summary>
        /// Constant M3Xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M3Xlarge = new EC2InstanceType("m3.xlarge");
        /// <summary>
        /// Constant M410xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M410xlarge = new EC2InstanceType("m4.10xlarge");
        /// <summary>
        /// Constant M416xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M416xlarge = new EC2InstanceType("m4.16xlarge");
        /// <summary>
        /// Constant M42xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M42xlarge = new EC2InstanceType("m4.2xlarge");
        /// <summary>
        /// Constant M44xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M44xlarge = new EC2InstanceType("m4.4xlarge");
        /// <summary>
        /// Constant M4Large for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M4Large = new EC2InstanceType("m4.large");
        /// <summary>
        /// Constant M4Xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M4Xlarge = new EC2InstanceType("m4.xlarge");
        /// <summary>
        /// Constant M512xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M512xlarge = new EC2InstanceType("m5.12xlarge");
        /// <summary>
        /// Constant M516xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M516xlarge = new EC2InstanceType("m5.16xlarge");
        /// <summary>
        /// Constant M524xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M524xlarge = new EC2InstanceType("m5.24xlarge");
        /// <summary>
        /// Constant M52xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M52xlarge = new EC2InstanceType("m5.2xlarge");
        /// <summary>
        /// Constant M54xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M54xlarge = new EC2InstanceType("m5.4xlarge");
        /// <summary>
        /// Constant M58xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M58xlarge = new EC2InstanceType("m5.8xlarge");
        /// <summary>
        /// Constant M5a12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5a12xlarge = new EC2InstanceType("m5a.12xlarge");
        /// <summary>
        /// Constant M5a16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5a16xlarge = new EC2InstanceType("m5a.16xlarge");
        /// <summary>
        /// Constant M5a24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5a24xlarge = new EC2InstanceType("m5a.24xlarge");
        /// <summary>
        /// Constant M5a2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5a2xlarge = new EC2InstanceType("m5a.2xlarge");
        /// <summary>
        /// Constant M5a4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5a4xlarge = new EC2InstanceType("m5a.4xlarge");
        /// <summary>
        /// Constant M5a8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5a8xlarge = new EC2InstanceType("m5a.8xlarge");
        /// <summary>
        /// Constant M5ad12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5ad12xlarge = new EC2InstanceType("m5ad.12xlarge");
        /// <summary>
        /// Constant M5ad16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5ad16xlarge = new EC2InstanceType("m5ad.16xlarge");
        /// <summary>
        /// Constant M5ad24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5ad24xlarge = new EC2InstanceType("m5ad.24xlarge");
        /// <summary>
        /// Constant M5ad2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5ad2xlarge = new EC2InstanceType("m5ad.2xlarge");
        /// <summary>
        /// Constant M5ad4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5ad4xlarge = new EC2InstanceType("m5ad.4xlarge");
        /// <summary>
        /// Constant M5ad8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5ad8xlarge = new EC2InstanceType("m5ad.8xlarge");
        /// <summary>
        /// Constant M5adLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5adLarge = new EC2InstanceType("m5ad.large");
        /// <summary>
        /// Constant M5adXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5adXlarge = new EC2InstanceType("m5ad.xlarge");
        /// <summary>
        /// Constant M5aLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5aLarge = new EC2InstanceType("m5a.large");
        /// <summary>
        /// Constant M5aXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5aXlarge = new EC2InstanceType("m5a.xlarge");
        /// <summary>
        /// Constant M5d12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5d12xlarge = new EC2InstanceType("m5d.12xlarge");
        /// <summary>
        /// Constant M5d16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5d16xlarge = new EC2InstanceType("m5d.16xlarge");
        /// <summary>
        /// Constant M5d24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5d24xlarge = new EC2InstanceType("m5d.24xlarge");
        /// <summary>
        /// Constant M5d2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5d2xlarge = new EC2InstanceType("m5d.2xlarge");
        /// <summary>
        /// Constant M5d4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5d4xlarge = new EC2InstanceType("m5d.4xlarge");
        /// <summary>
        /// Constant M5d8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5d8xlarge = new EC2InstanceType("m5d.8xlarge");
        /// <summary>
        /// Constant M5dLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5dLarge = new EC2InstanceType("m5d.large");
        /// <summary>
        /// Constant M5dn12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5dn12xlarge = new EC2InstanceType("m5dn.12xlarge");
        /// <summary>
        /// Constant M5dn16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5dn16xlarge = new EC2InstanceType("m5dn.16xlarge");
        /// <summary>
        /// Constant M5dn24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5dn24xlarge = new EC2InstanceType("m5dn.24xlarge");
        /// <summary>
        /// Constant M5dn2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5dn2xlarge = new EC2InstanceType("m5dn.2xlarge");
        /// <summary>
        /// Constant M5dn4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5dn4xlarge = new EC2InstanceType("m5dn.4xlarge");
        /// <summary>
        /// Constant M5dn8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5dn8xlarge = new EC2InstanceType("m5dn.8xlarge");
        /// <summary>
        /// Constant M5dnLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5dnLarge = new EC2InstanceType("m5dn.large");
        /// <summary>
        /// Constant M5dnXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5dnXlarge = new EC2InstanceType("m5dn.xlarge");
        /// <summary>
        /// Constant M5dXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5dXlarge = new EC2InstanceType("m5d.xlarge");
        /// <summary>
        /// Constant M5Large for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5Large = new EC2InstanceType("m5.large");
        /// <summary>
        /// Constant M5n12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5n12xlarge = new EC2InstanceType("m5n.12xlarge");
        /// <summary>
        /// Constant M5n16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5n16xlarge = new EC2InstanceType("m5n.16xlarge");
        /// <summary>
        /// Constant M5n24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5n24xlarge = new EC2InstanceType("m5n.24xlarge");
        /// <summary>
        /// Constant M5n2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5n2xlarge = new EC2InstanceType("m5n.2xlarge");
        /// <summary>
        /// Constant M5n4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5n4xlarge = new EC2InstanceType("m5n.4xlarge");
        /// <summary>
        /// Constant M5n8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5n8xlarge = new EC2InstanceType("m5n.8xlarge");
        /// <summary>
        /// Constant M5nLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5nLarge = new EC2InstanceType("m5n.large");
        /// <summary>
        /// Constant M5nXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5nXlarge = new EC2InstanceType("m5n.xlarge");
        /// <summary>
        /// Constant M5Xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M5Xlarge = new EC2InstanceType("m5.xlarge");
        /// <summary>
        /// Constant M6a12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6a12xlarge = new EC2InstanceType("m6a.12xlarge");
        /// <summary>
        /// Constant M6a16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6a16xlarge = new EC2InstanceType("m6a.16xlarge");
        /// <summary>
        /// Constant M6a24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6a24xlarge = new EC2InstanceType("m6a.24xlarge");
        /// <summary>
        /// Constant M6a2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6a2xlarge = new EC2InstanceType("m6a.2xlarge");
        /// <summary>
        /// Constant M6a32xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6a32xlarge = new EC2InstanceType("m6a.32xlarge");
        /// <summary>
        /// Constant M6a48xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6a48xlarge = new EC2InstanceType("m6a.48xlarge");
        /// <summary>
        /// Constant M6a4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6a4xlarge = new EC2InstanceType("m6a.4xlarge");
        /// <summary>
        /// Constant M6a8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6a8xlarge = new EC2InstanceType("m6a.8xlarge");
        /// <summary>
        /// Constant M6aLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6aLarge = new EC2InstanceType("m6a.large");
        /// <summary>
        /// Constant M6aXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6aXlarge = new EC2InstanceType("m6a.xlarge");
        /// <summary>
        /// Constant M6g12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6g12xlarge = new EC2InstanceType("m6g.12xlarge");
        /// <summary>
        /// Constant M6g16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6g16xlarge = new EC2InstanceType("m6g.16xlarge");
        /// <summary>
        /// Constant M6g2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6g2xlarge = new EC2InstanceType("m6g.2xlarge");
        /// <summary>
        /// Constant M6g4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6g4xlarge = new EC2InstanceType("m6g.4xlarge");
        /// <summary>
        /// Constant M6g8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6g8xlarge = new EC2InstanceType("m6g.8xlarge");
        /// <summary>
        /// Constant M6gd12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6gd12xlarge = new EC2InstanceType("m6gd.12xlarge");
        /// <summary>
        /// Constant M6gd16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6gd16xlarge = new EC2InstanceType("m6gd.16xlarge");
        /// <summary>
        /// Constant M6gd2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6gd2xlarge = new EC2InstanceType("m6gd.2xlarge");
        /// <summary>
        /// Constant M6gd4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6gd4xlarge = new EC2InstanceType("m6gd.4xlarge");
        /// <summary>
        /// Constant M6gd8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6gd8xlarge = new EC2InstanceType("m6gd.8xlarge");
        /// <summary>
        /// Constant M6gdLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6gdLarge = new EC2InstanceType("m6gd.large");
        /// <summary>
        /// Constant M6gdMedium for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6gdMedium = new EC2InstanceType("m6gd.medium");
        /// <summary>
        /// Constant M6gdXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6gdXlarge = new EC2InstanceType("m6gd.xlarge");
        /// <summary>
        /// Constant M6gLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6gLarge = new EC2InstanceType("m6g.large");
        /// <summary>
        /// Constant M6gMedium for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6gMedium = new EC2InstanceType("m6g.medium");
        /// <summary>
        /// Constant M6gXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6gXlarge = new EC2InstanceType("m6g.xlarge");
        /// <summary>
        /// Constant M6i12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6i12xlarge = new EC2InstanceType("m6i.12xlarge");
        /// <summary>
        /// Constant M6i16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6i16xlarge = new EC2InstanceType("m6i.16xlarge");
        /// <summary>
        /// Constant M6i24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6i24xlarge = new EC2InstanceType("m6i.24xlarge");
        /// <summary>
        /// Constant M6i2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6i2xlarge = new EC2InstanceType("m6i.2xlarge");
        /// <summary>
        /// Constant M6i32xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6i32xlarge = new EC2InstanceType("m6i.32xlarge");
        /// <summary>
        /// Constant M6i4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6i4xlarge = new EC2InstanceType("m6i.4xlarge");
        /// <summary>
        /// Constant M6i8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6i8xlarge = new EC2InstanceType("m6i.8xlarge");
        /// <summary>
        /// Constant M6id12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6id12xlarge = new EC2InstanceType("m6id.12xlarge");
        /// <summary>
        /// Constant M6id16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6id16xlarge = new EC2InstanceType("m6id.16xlarge");
        /// <summary>
        /// Constant M6id24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6id24xlarge = new EC2InstanceType("m6id.24xlarge");
        /// <summary>
        /// Constant M6id2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6id2xlarge = new EC2InstanceType("m6id.2xlarge");
        /// <summary>
        /// Constant M6id32xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6id32xlarge = new EC2InstanceType("m6id.32xlarge");
        /// <summary>
        /// Constant M6id4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6id4xlarge = new EC2InstanceType("m6id.4xlarge");
        /// <summary>
        /// Constant M6id8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6id8xlarge = new EC2InstanceType("m6id.8xlarge");
        /// <summary>
        /// Constant M6idLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6idLarge = new EC2InstanceType("m6id.large");
        /// <summary>
        /// Constant M6idn12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6idn12xlarge = new EC2InstanceType("m6idn.12xlarge");
        /// <summary>
        /// Constant M6idn16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6idn16xlarge = new EC2InstanceType("m6idn.16xlarge");
        /// <summary>
        /// Constant M6idn24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6idn24xlarge = new EC2InstanceType("m6idn.24xlarge");
        /// <summary>
        /// Constant M6idn2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6idn2xlarge = new EC2InstanceType("m6idn.2xlarge");
        /// <summary>
        /// Constant M6idn32xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6idn32xlarge = new EC2InstanceType("m6idn.32xlarge");
        /// <summary>
        /// Constant M6idn4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6idn4xlarge = new EC2InstanceType("m6idn.4xlarge");
        /// <summary>
        /// Constant M6idn8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6idn8xlarge = new EC2InstanceType("m6idn.8xlarge");
        /// <summary>
        /// Constant M6idnLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6idnLarge = new EC2InstanceType("m6idn.large");
        /// <summary>
        /// Constant M6idnXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6idnXlarge = new EC2InstanceType("m6idn.xlarge");
        /// <summary>
        /// Constant M6idXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6idXlarge = new EC2InstanceType("m6id.xlarge");
        /// <summary>
        /// Constant M6iLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6iLarge = new EC2InstanceType("m6i.large");
        /// <summary>
        /// Constant M6in12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6in12xlarge = new EC2InstanceType("m6in.12xlarge");
        /// <summary>
        /// Constant M6in16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6in16xlarge = new EC2InstanceType("m6in.16xlarge");
        /// <summary>
        /// Constant M6in24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6in24xlarge = new EC2InstanceType("m6in.24xlarge");
        /// <summary>
        /// Constant M6in2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6in2xlarge = new EC2InstanceType("m6in.2xlarge");
        /// <summary>
        /// Constant M6in32xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6in32xlarge = new EC2InstanceType("m6in.32xlarge");
        /// <summary>
        /// Constant M6in4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6in4xlarge = new EC2InstanceType("m6in.4xlarge");
        /// <summary>
        /// Constant M6in8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6in8xlarge = new EC2InstanceType("m6in.8xlarge");
        /// <summary>
        /// Constant M6inLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6inLarge = new EC2InstanceType("m6in.large");
        /// <summary>
        /// Constant M6inXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6inXlarge = new EC2InstanceType("m6in.xlarge");
        /// <summary>
        /// Constant M6iXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M6iXlarge = new EC2InstanceType("m6i.xlarge");
        /// <summary>
        /// Constant M7a12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7a12xlarge = new EC2InstanceType("m7a.12xlarge");
        /// <summary>
        /// Constant M7a16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7a16xlarge = new EC2InstanceType("m7a.16xlarge");
        /// <summary>
        /// Constant M7a24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7a24xlarge = new EC2InstanceType("m7a.24xlarge");
        /// <summary>
        /// Constant M7a2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7a2xlarge = new EC2InstanceType("m7a.2xlarge");
        /// <summary>
        /// Constant M7a32xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7a32xlarge = new EC2InstanceType("m7a.32xlarge");
        /// <summary>
        /// Constant M7a48xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7a48xlarge = new EC2InstanceType("m7a.48xlarge");
        /// <summary>
        /// Constant M7a4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7a4xlarge = new EC2InstanceType("m7a.4xlarge");
        /// <summary>
        /// Constant M7a8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7a8xlarge = new EC2InstanceType("m7a.8xlarge");
        /// <summary>
        /// Constant M7aLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7aLarge = new EC2InstanceType("m7a.large");
        /// <summary>
        /// Constant M7aMedium for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7aMedium = new EC2InstanceType("m7a.medium");
        /// <summary>
        /// Constant M7aXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7aXlarge = new EC2InstanceType("m7a.xlarge");
        /// <summary>
        /// Constant M7g12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7g12xlarge = new EC2InstanceType("m7g.12xlarge");
        /// <summary>
        /// Constant M7g16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7g16xlarge = new EC2InstanceType("m7g.16xlarge");
        /// <summary>
        /// Constant M7g2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7g2xlarge = new EC2InstanceType("m7g.2xlarge");
        /// <summary>
        /// Constant M7g4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7g4xlarge = new EC2InstanceType("m7g.4xlarge");
        /// <summary>
        /// Constant M7g8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7g8xlarge = new EC2InstanceType("m7g.8xlarge");
        /// <summary>
        /// Constant M7gd12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7gd12xlarge = new EC2InstanceType("m7gd.12xlarge");
        /// <summary>
        /// Constant M7gd16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7gd16xlarge = new EC2InstanceType("m7gd.16xlarge");
        /// <summary>
        /// Constant M7gd2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7gd2xlarge = new EC2InstanceType("m7gd.2xlarge");
        /// <summary>
        /// Constant M7gd4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7gd4xlarge = new EC2InstanceType("m7gd.4xlarge");
        /// <summary>
        /// Constant M7gd8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7gd8xlarge = new EC2InstanceType("m7gd.8xlarge");
        /// <summary>
        /// Constant M7gdLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7gdLarge = new EC2InstanceType("m7gd.large");
        /// <summary>
        /// Constant M7gdMedium for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7gdMedium = new EC2InstanceType("m7gd.medium");
        /// <summary>
        /// Constant M7gdXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7gdXlarge = new EC2InstanceType("m7gd.xlarge");
        /// <summary>
        /// Constant M7gLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7gLarge = new EC2InstanceType("m7g.large");
        /// <summary>
        /// Constant M7gMedium for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7gMedium = new EC2InstanceType("m7g.medium");
        /// <summary>
        /// Constant M7gXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7gXlarge = new EC2InstanceType("m7g.xlarge");
        /// <summary>
        /// Constant M7i12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7i12xlarge = new EC2InstanceType("m7i.12xlarge");
        /// <summary>
        /// Constant M7i16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7i16xlarge = new EC2InstanceType("m7i.16xlarge");
        /// <summary>
        /// Constant M7i24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7i24xlarge = new EC2InstanceType("m7i.24xlarge");
        /// <summary>
        /// Constant M7i2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7i2xlarge = new EC2InstanceType("m7i.2xlarge");
        /// <summary>
        /// Constant M7i48xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7i48xlarge = new EC2InstanceType("m7i.48xlarge");
        /// <summary>
        /// Constant M7i4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7i4xlarge = new EC2InstanceType("m7i.4xlarge");
        /// <summary>
        /// Constant M7i8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7i8xlarge = new EC2InstanceType("m7i.8xlarge");
        /// <summary>
        /// Constant M7iLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7iLarge = new EC2InstanceType("m7i.large");
        /// <summary>
        /// Constant M7iXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M7iXlarge = new EC2InstanceType("m7i.xlarge");
        /// <summary>
        /// Constant M8g12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M8g12xlarge = new EC2InstanceType("m8g.12xlarge");
        /// <summary>
        /// Constant M8g16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M8g16xlarge = new EC2InstanceType("m8g.16xlarge");
        /// <summary>
        /// Constant M8g24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M8g24xlarge = new EC2InstanceType("m8g.24xlarge");
        /// <summary>
        /// Constant M8g2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M8g2xlarge = new EC2InstanceType("m8g.2xlarge");
        /// <summary>
        /// Constant M8g48xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M8g48xlarge = new EC2InstanceType("m8g.48xlarge");
        /// <summary>
        /// Constant M8g4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M8g4xlarge = new EC2InstanceType("m8g.4xlarge");
        /// <summary>
        /// Constant M8g8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M8g8xlarge = new EC2InstanceType("m8g.8xlarge");
        /// <summary>
        /// Constant M8gLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M8gLarge = new EC2InstanceType("m8g.large");
        /// <summary>
        /// Constant M8gMedium for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M8gMedium = new EC2InstanceType("m8g.medium");
        /// <summary>
        /// Constant M8gXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType M8gXlarge = new EC2InstanceType("m8g.xlarge");
        /// <summary>
        /// Constant R32xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R32xlarge = new EC2InstanceType("r3.2xlarge");
        /// <summary>
        /// Constant R34xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R34xlarge = new EC2InstanceType("r3.4xlarge");
        /// <summary>
        /// Constant R38xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R38xlarge = new EC2InstanceType("r3.8xlarge");
        /// <summary>
        /// Constant R3Large for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R3Large = new EC2InstanceType("r3.large");
        /// <summary>
        /// Constant R3Xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R3Xlarge = new EC2InstanceType("r3.xlarge");
        /// <summary>
        /// Constant R416xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R416xlarge = new EC2InstanceType("r4.16xlarge");
        /// <summary>
        /// Constant R42xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R42xlarge = new EC2InstanceType("r4.2xlarge");
        /// <summary>
        /// Constant R44xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R44xlarge = new EC2InstanceType("r4.4xlarge");
        /// <summary>
        /// Constant R48xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R48xlarge = new EC2InstanceType("r4.8xlarge");
        /// <summary>
        /// Constant R4Large for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R4Large = new EC2InstanceType("r4.large");
        /// <summary>
        /// Constant R4Xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R4Xlarge = new EC2InstanceType("r4.xlarge");
        /// <summary>
        /// Constant R512xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R512xlarge = new EC2InstanceType("r5.12xlarge");
        /// <summary>
        /// Constant R516xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R516xlarge = new EC2InstanceType("r5.16xlarge");
        /// <summary>
        /// Constant R524xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R524xlarge = new EC2InstanceType("r5.24xlarge");
        /// <summary>
        /// Constant R52xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R52xlarge = new EC2InstanceType("r5.2xlarge");
        /// <summary>
        /// Constant R54xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R54xlarge = new EC2InstanceType("r5.4xlarge");
        /// <summary>
        /// Constant R58xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R58xlarge = new EC2InstanceType("r5.8xlarge");
        /// <summary>
        /// Constant R5a12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5a12xlarge = new EC2InstanceType("r5a.12xlarge");
        /// <summary>
        /// Constant R5a16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5a16xlarge = new EC2InstanceType("r5a.16xlarge");
        /// <summary>
        /// Constant R5a24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5a24xlarge = new EC2InstanceType("r5a.24xlarge");
        /// <summary>
        /// Constant R5a2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5a2xlarge = new EC2InstanceType("r5a.2xlarge");
        /// <summary>
        /// Constant R5a4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5a4xlarge = new EC2InstanceType("r5a.4xlarge");
        /// <summary>
        /// Constant R5a8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5a8xlarge = new EC2InstanceType("r5a.8xlarge");
        /// <summary>
        /// Constant R5ad12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5ad12xlarge = new EC2InstanceType("r5ad.12xlarge");
        /// <summary>
        /// Constant R5ad16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5ad16xlarge = new EC2InstanceType("r5ad.16xlarge");
        /// <summary>
        /// Constant R5ad24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5ad24xlarge = new EC2InstanceType("r5ad.24xlarge");
        /// <summary>
        /// Constant R5ad2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5ad2xlarge = new EC2InstanceType("r5ad.2xlarge");
        /// <summary>
        /// Constant R5ad4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5ad4xlarge = new EC2InstanceType("r5ad.4xlarge");
        /// <summary>
        /// Constant R5ad8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5ad8xlarge = new EC2InstanceType("r5ad.8xlarge");
        /// <summary>
        /// Constant R5adLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5adLarge = new EC2InstanceType("r5ad.large");
        /// <summary>
        /// Constant R5adXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5adXlarge = new EC2InstanceType("r5ad.xlarge");
        /// <summary>
        /// Constant R5aLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5aLarge = new EC2InstanceType("r5a.large");
        /// <summary>
        /// Constant R5aXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5aXlarge = new EC2InstanceType("r5a.xlarge");
        /// <summary>
        /// Constant R5d12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5d12xlarge = new EC2InstanceType("r5d.12xlarge");
        /// <summary>
        /// Constant R5d16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5d16xlarge = new EC2InstanceType("r5d.16xlarge");
        /// <summary>
        /// Constant R5d24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5d24xlarge = new EC2InstanceType("r5d.24xlarge");
        /// <summary>
        /// Constant R5d2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5d2xlarge = new EC2InstanceType("r5d.2xlarge");
        /// <summary>
        /// Constant R5d4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5d4xlarge = new EC2InstanceType("r5d.4xlarge");
        /// <summary>
        /// Constant R5d8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5d8xlarge = new EC2InstanceType("r5d.8xlarge");
        /// <summary>
        /// Constant R5dLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5dLarge = new EC2InstanceType("r5d.large");
        /// <summary>
        /// Constant R5dn12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5dn12xlarge = new EC2InstanceType("r5dn.12xlarge");
        /// <summary>
        /// Constant R5dn16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5dn16xlarge = new EC2InstanceType("r5dn.16xlarge");
        /// <summary>
        /// Constant R5dn24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5dn24xlarge = new EC2InstanceType("r5dn.24xlarge");
        /// <summary>
        /// Constant R5dn2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5dn2xlarge = new EC2InstanceType("r5dn.2xlarge");
        /// <summary>
        /// Constant R5dn4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5dn4xlarge = new EC2InstanceType("r5dn.4xlarge");
        /// <summary>
        /// Constant R5dn8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5dn8xlarge = new EC2InstanceType("r5dn.8xlarge");
        /// <summary>
        /// Constant R5dnLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5dnLarge = new EC2InstanceType("r5dn.large");
        /// <summary>
        /// Constant R5dnXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5dnXlarge = new EC2InstanceType("r5dn.xlarge");
        /// <summary>
        /// Constant R5dXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5dXlarge = new EC2InstanceType("r5d.xlarge");
        /// <summary>
        /// Constant R5Large for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5Large = new EC2InstanceType("r5.large");
        /// <summary>
        /// Constant R5n12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5n12xlarge = new EC2InstanceType("r5n.12xlarge");
        /// <summary>
        /// Constant R5n16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5n16xlarge = new EC2InstanceType("r5n.16xlarge");
        /// <summary>
        /// Constant R5n24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5n24xlarge = new EC2InstanceType("r5n.24xlarge");
        /// <summary>
        /// Constant R5n2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5n2xlarge = new EC2InstanceType("r5n.2xlarge");
        /// <summary>
        /// Constant R5n4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5n4xlarge = new EC2InstanceType("r5n.4xlarge");
        /// <summary>
        /// Constant R5n8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5n8xlarge = new EC2InstanceType("r5n.8xlarge");
        /// <summary>
        /// Constant R5nLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5nLarge = new EC2InstanceType("r5n.large");
        /// <summary>
        /// Constant R5nXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5nXlarge = new EC2InstanceType("r5n.xlarge");
        /// <summary>
        /// Constant R5Xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R5Xlarge = new EC2InstanceType("r5.xlarge");
        /// <summary>
        /// Constant R6a12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6a12xlarge = new EC2InstanceType("r6a.12xlarge");
        /// <summary>
        /// Constant R6a16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6a16xlarge = new EC2InstanceType("r6a.16xlarge");
        /// <summary>
        /// Constant R6a24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6a24xlarge = new EC2InstanceType("r6a.24xlarge");
        /// <summary>
        /// Constant R6a2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6a2xlarge = new EC2InstanceType("r6a.2xlarge");
        /// <summary>
        /// Constant R6a32xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6a32xlarge = new EC2InstanceType("r6a.32xlarge");
        /// <summary>
        /// Constant R6a48xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6a48xlarge = new EC2InstanceType("r6a.48xlarge");
        /// <summary>
        /// Constant R6a4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6a4xlarge = new EC2InstanceType("r6a.4xlarge");
        /// <summary>
        /// Constant R6a8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6a8xlarge = new EC2InstanceType("r6a.8xlarge");
        /// <summary>
        /// Constant R6aLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6aLarge = new EC2InstanceType("r6a.large");
        /// <summary>
        /// Constant R6aXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6aXlarge = new EC2InstanceType("r6a.xlarge");
        /// <summary>
        /// Constant R6g12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6g12xlarge = new EC2InstanceType("r6g.12xlarge");
        /// <summary>
        /// Constant R6g16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6g16xlarge = new EC2InstanceType("r6g.16xlarge");
        /// <summary>
        /// Constant R6g2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6g2xlarge = new EC2InstanceType("r6g.2xlarge");
        /// <summary>
        /// Constant R6g4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6g4xlarge = new EC2InstanceType("r6g.4xlarge");
        /// <summary>
        /// Constant R6g8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6g8xlarge = new EC2InstanceType("r6g.8xlarge");
        /// <summary>
        /// Constant R6gd12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6gd12xlarge = new EC2InstanceType("r6gd.12xlarge");
        /// <summary>
        /// Constant R6gd16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6gd16xlarge = new EC2InstanceType("r6gd.16xlarge");
        /// <summary>
        /// Constant R6gd2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6gd2xlarge = new EC2InstanceType("r6gd.2xlarge");
        /// <summary>
        /// Constant R6gd4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6gd4xlarge = new EC2InstanceType("r6gd.4xlarge");
        /// <summary>
        /// Constant R6gd8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6gd8xlarge = new EC2InstanceType("r6gd.8xlarge");
        /// <summary>
        /// Constant R6gdLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6gdLarge = new EC2InstanceType("r6gd.large");
        /// <summary>
        /// Constant R6gdMedium for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6gdMedium = new EC2InstanceType("r6gd.medium");
        /// <summary>
        /// Constant R6gdXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6gdXlarge = new EC2InstanceType("r6gd.xlarge");
        /// <summary>
        /// Constant R6gLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6gLarge = new EC2InstanceType("r6g.large");
        /// <summary>
        /// Constant R6gMedium for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6gMedium = new EC2InstanceType("r6g.medium");
        /// <summary>
        /// Constant R6gXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6gXlarge = new EC2InstanceType("r6g.xlarge");
        /// <summary>
        /// Constant R6i12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6i12xlarge = new EC2InstanceType("r6i.12xlarge");
        /// <summary>
        /// Constant R6i16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6i16xlarge = new EC2InstanceType("r6i.16xlarge");
        /// <summary>
        /// Constant R6i24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6i24xlarge = new EC2InstanceType("r6i.24xlarge");
        /// <summary>
        /// Constant R6i2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6i2xlarge = new EC2InstanceType("r6i.2xlarge");
        /// <summary>
        /// Constant R6i32xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6i32xlarge = new EC2InstanceType("r6i.32xlarge");
        /// <summary>
        /// Constant R6i4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6i4xlarge = new EC2InstanceType("r6i.4xlarge");
        /// <summary>
        /// Constant R6i8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6i8xlarge = new EC2InstanceType("r6i.8xlarge");
        /// <summary>
        /// Constant R6id12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6id12xlarge = new EC2InstanceType("r6id.12xlarge");
        /// <summary>
        /// Constant R6id16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6id16xlarge = new EC2InstanceType("r6id.16xlarge");
        /// <summary>
        /// Constant R6id24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6id24xlarge = new EC2InstanceType("r6id.24xlarge");
        /// <summary>
        /// Constant R6id2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6id2xlarge = new EC2InstanceType("r6id.2xlarge");
        /// <summary>
        /// Constant R6id32xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6id32xlarge = new EC2InstanceType("r6id.32xlarge");
        /// <summary>
        /// Constant R6id4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6id4xlarge = new EC2InstanceType("r6id.4xlarge");
        /// <summary>
        /// Constant R6id8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6id8xlarge = new EC2InstanceType("r6id.8xlarge");
        /// <summary>
        /// Constant R6idLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6idLarge = new EC2InstanceType("r6id.large");
        /// <summary>
        /// Constant R6idn12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6idn12xlarge = new EC2InstanceType("r6idn.12xlarge");
        /// <summary>
        /// Constant R6idn16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6idn16xlarge = new EC2InstanceType("r6idn.16xlarge");
        /// <summary>
        /// Constant R6idn24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6idn24xlarge = new EC2InstanceType("r6idn.24xlarge");
        /// <summary>
        /// Constant R6idn2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6idn2xlarge = new EC2InstanceType("r6idn.2xlarge");
        /// <summary>
        /// Constant R6idn32xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6idn32xlarge = new EC2InstanceType("r6idn.32xlarge");
        /// <summary>
        /// Constant R6idn4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6idn4xlarge = new EC2InstanceType("r6idn.4xlarge");
        /// <summary>
        /// Constant R6idn8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6idn8xlarge = new EC2InstanceType("r6idn.8xlarge");
        /// <summary>
        /// Constant R6idnLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6idnLarge = new EC2InstanceType("r6idn.large");
        /// <summary>
        /// Constant R6idnXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6idnXlarge = new EC2InstanceType("r6idn.xlarge");
        /// <summary>
        /// Constant R6idXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6idXlarge = new EC2InstanceType("r6id.xlarge");
        /// <summary>
        /// Constant R6iLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6iLarge = new EC2InstanceType("r6i.large");
        /// <summary>
        /// Constant R6in12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6in12xlarge = new EC2InstanceType("r6in.12xlarge");
        /// <summary>
        /// Constant R6in16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6in16xlarge = new EC2InstanceType("r6in.16xlarge");
        /// <summary>
        /// Constant R6in24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6in24xlarge = new EC2InstanceType("r6in.24xlarge");
        /// <summary>
        /// Constant R6in2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6in2xlarge = new EC2InstanceType("r6in.2xlarge");
        /// <summary>
        /// Constant R6in32xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6in32xlarge = new EC2InstanceType("r6in.32xlarge");
        /// <summary>
        /// Constant R6in4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6in4xlarge = new EC2InstanceType("r6in.4xlarge");
        /// <summary>
        /// Constant R6in8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6in8xlarge = new EC2InstanceType("r6in.8xlarge");
        /// <summary>
        /// Constant R6inLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6inLarge = new EC2InstanceType("r6in.large");
        /// <summary>
        /// Constant R6inXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6inXlarge = new EC2InstanceType("r6in.xlarge");
        /// <summary>
        /// Constant R6iXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R6iXlarge = new EC2InstanceType("r6i.xlarge");
        /// <summary>
        /// Constant R7a12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7a12xlarge = new EC2InstanceType("r7a.12xlarge");
        /// <summary>
        /// Constant R7a16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7a16xlarge = new EC2InstanceType("r7a.16xlarge");
        /// <summary>
        /// Constant R7a24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7a24xlarge = new EC2InstanceType("r7a.24xlarge");
        /// <summary>
        /// Constant R7a2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7a2xlarge = new EC2InstanceType("r7a.2xlarge");
        /// <summary>
        /// Constant R7a32xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7a32xlarge = new EC2InstanceType("r7a.32xlarge");
        /// <summary>
        /// Constant R7a48xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7a48xlarge = new EC2InstanceType("r7a.48xlarge");
        /// <summary>
        /// Constant R7a4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7a4xlarge = new EC2InstanceType("r7a.4xlarge");
        /// <summary>
        /// Constant R7a8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7a8xlarge = new EC2InstanceType("r7a.8xlarge");
        /// <summary>
        /// Constant R7aLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7aLarge = new EC2InstanceType("r7a.large");
        /// <summary>
        /// Constant R7aMedium for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7aMedium = new EC2InstanceType("r7a.medium");
        /// <summary>
        /// Constant R7aXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7aXlarge = new EC2InstanceType("r7a.xlarge");
        /// <summary>
        /// Constant R7g12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7g12xlarge = new EC2InstanceType("r7g.12xlarge");
        /// <summary>
        /// Constant R7g16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7g16xlarge = new EC2InstanceType("r7g.16xlarge");
        /// <summary>
        /// Constant R7g2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7g2xlarge = new EC2InstanceType("r7g.2xlarge");
        /// <summary>
        /// Constant R7g4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7g4xlarge = new EC2InstanceType("r7g.4xlarge");
        /// <summary>
        /// Constant R7g8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7g8xlarge = new EC2InstanceType("r7g.8xlarge");
        /// <summary>
        /// Constant R7gd12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7gd12xlarge = new EC2InstanceType("r7gd.12xlarge");
        /// <summary>
        /// Constant R7gd16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7gd16xlarge = new EC2InstanceType("r7gd.16xlarge");
        /// <summary>
        /// Constant R7gd2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7gd2xlarge = new EC2InstanceType("r7gd.2xlarge");
        /// <summary>
        /// Constant R7gd4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7gd4xlarge = new EC2InstanceType("r7gd.4xlarge");
        /// <summary>
        /// Constant R7gd8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7gd8xlarge = new EC2InstanceType("r7gd.8xlarge");
        /// <summary>
        /// Constant R7gdLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7gdLarge = new EC2InstanceType("r7gd.large");
        /// <summary>
        /// Constant R7gdMedium for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7gdMedium = new EC2InstanceType("r7gd.medium");
        /// <summary>
        /// Constant R7gdXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7gdXlarge = new EC2InstanceType("r7gd.xlarge");
        /// <summary>
        /// Constant R7gLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7gLarge = new EC2InstanceType("r7g.large");
        /// <summary>
        /// Constant R7gMedium for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7gMedium = new EC2InstanceType("r7g.medium");
        /// <summary>
        /// Constant R7gXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7gXlarge = new EC2InstanceType("r7g.xlarge");
        /// <summary>
        /// Constant R7i12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7i12xlarge = new EC2InstanceType("r7i.12xlarge");
        /// <summary>
        /// Constant R7i16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7i16xlarge = new EC2InstanceType("r7i.16xlarge");
        /// <summary>
        /// Constant R7i24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7i24xlarge = new EC2InstanceType("r7i.24xlarge");
        /// <summary>
        /// Constant R7i2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7i2xlarge = new EC2InstanceType("r7i.2xlarge");
        /// <summary>
        /// Constant R7i48xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7i48xlarge = new EC2InstanceType("r7i.48xlarge");
        /// <summary>
        /// Constant R7i4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7i4xlarge = new EC2InstanceType("r7i.4xlarge");
        /// <summary>
        /// Constant R7i8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7i8xlarge = new EC2InstanceType("r7i.8xlarge");
        /// <summary>
        /// Constant R7iLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7iLarge = new EC2InstanceType("r7i.large");
        /// <summary>
        /// Constant R7iXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R7iXlarge = new EC2InstanceType("r7i.xlarge");
        /// <summary>
        /// Constant R8g12xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R8g12xlarge = new EC2InstanceType("r8g.12xlarge");
        /// <summary>
        /// Constant R8g16xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R8g16xlarge = new EC2InstanceType("r8g.16xlarge");
        /// <summary>
        /// Constant R8g24xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R8g24xlarge = new EC2InstanceType("r8g.24xlarge");
        /// <summary>
        /// Constant R8g2xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R8g2xlarge = new EC2InstanceType("r8g.2xlarge");
        /// <summary>
        /// Constant R8g48xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R8g48xlarge = new EC2InstanceType("r8g.48xlarge");
        /// <summary>
        /// Constant R8g4xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R8g4xlarge = new EC2InstanceType("r8g.4xlarge");
        /// <summary>
        /// Constant R8g8xlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R8g8xlarge = new EC2InstanceType("r8g.8xlarge");
        /// <summary>
        /// Constant R8gLarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R8gLarge = new EC2InstanceType("r8g.large");
        /// <summary>
        /// Constant R8gMedium for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R8gMedium = new EC2InstanceType("r8g.medium");
        /// <summary>
        /// Constant R8gXlarge for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType R8gXlarge = new EC2InstanceType("r8g.xlarge");
        /// <summary>
        /// Constant T2Large for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType T2Large = new EC2InstanceType("t2.large");
        /// <summary>
        /// Constant T2Medium for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType T2Medium = new EC2InstanceType("t2.medium");
        /// <summary>
        /// Constant T2Micro for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType T2Micro = new EC2InstanceType("t2.micro");
        /// <summary>
        /// Constant T2Small for EC2InstanceType
        /// </summary>
        public static readonly EC2InstanceType T2Small = new EC2InstanceType("t2.small");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EC2InstanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EC2InstanceType FindValue(string value)
        {
            return FindValue<EC2InstanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EC2InstanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventCode.
    /// </summary>
    public class EventCode : ConstantClass
    {

        /// <summary>
        /// Constant COMPUTE_LOG_UPLOAD_FAILED for EventCode
        /// </summary>
        public static readonly EventCode COMPUTE_LOG_UPLOAD_FAILED = new EventCode("COMPUTE_LOG_UPLOAD_FAILED");
        /// <summary>
        /// Constant FLEET_ACTIVATION_FAILED for EventCode
        /// </summary>
        public static readonly EventCode FLEET_ACTIVATION_FAILED = new EventCode("FLEET_ACTIVATION_FAILED");
        /// <summary>
        /// Constant FLEET_ACTIVATION_FAILED_NO_INSTANCES for EventCode
        /// </summary>
        public static readonly EventCode FLEET_ACTIVATION_FAILED_NO_INSTANCES = new EventCode("FLEET_ACTIVATION_FAILED_NO_INSTANCES");
        /// <summary>
        /// Constant FLEET_BINARY_DOWNLOAD_FAILED for EventCode
        /// </summary>
        public static readonly EventCode FLEET_BINARY_DOWNLOAD_FAILED = new EventCode("FLEET_BINARY_DOWNLOAD_FAILED");
        /// <summary>
        /// Constant FLEET_CREATED for EventCode
        /// </summary>
        public static readonly EventCode FLEET_CREATED = new EventCode("FLEET_CREATED");
        /// <summary>
        /// Constant FLEET_CREATION_COMPLETED_INSTALLER for EventCode
        /// </summary>
        public static readonly EventCode FLEET_CREATION_COMPLETED_INSTALLER = new EventCode("FLEET_CREATION_COMPLETED_INSTALLER");
        /// <summary>
        /// Constant FLEET_CREATION_EXTRACTING_BUILD for EventCode
        /// </summary>
        public static readonly EventCode FLEET_CREATION_EXTRACTING_BUILD = new EventCode("FLEET_CREATION_EXTRACTING_BUILD");
        /// <summary>
        /// Constant FLEET_CREATION_FAILED_INSTALLER for EventCode
        /// </summary>
        public static readonly EventCode FLEET_CREATION_FAILED_INSTALLER = new EventCode("FLEET_CREATION_FAILED_INSTALLER");
        /// <summary>
        /// Constant FLEET_CREATION_RUNNING_INSTALLER for EventCode
        /// </summary>
        public static readonly EventCode FLEET_CREATION_RUNNING_INSTALLER = new EventCode("FLEET_CREATION_RUNNING_INSTALLER");
        /// <summary>
        /// Constant FLEET_CREATION_VALIDATING_RUNTIME_CONFIG for EventCode
        /// </summary>
        public static readonly EventCode FLEET_CREATION_VALIDATING_RUNTIME_CONFIG = new EventCode("FLEET_CREATION_VALIDATING_RUNTIME_CONFIG");
        /// <summary>
        /// Constant FLEET_DELETED for EventCode
        /// </summary>
        public static readonly EventCode FLEET_DELETED = new EventCode("FLEET_DELETED");
        /// <summary>
        /// Constant FLEET_INITIALIZATION_FAILED for EventCode
        /// </summary>
        public static readonly EventCode FLEET_INITIALIZATION_FAILED = new EventCode("FLEET_INITIALIZATION_FAILED");
        /// <summary>
        /// Constant FLEET_NEW_GAME_SESSION_PROTECTION_POLICY_UPDATED for EventCode
        /// </summary>
        public static readonly EventCode FLEET_NEW_GAME_SESSION_PROTECTION_POLICY_UPDATED = new EventCode("FLEET_NEW_GAME_SESSION_PROTECTION_POLICY_UPDATED");
        /// <summary>
        /// Constant FLEET_SCALING_EVENT for EventCode
        /// </summary>
        public static readonly EventCode FLEET_SCALING_EVENT = new EventCode("FLEET_SCALING_EVENT");
        /// <summary>
        /// Constant FLEET_STATE_ACTIVATING for EventCode
        /// </summary>
        public static readonly EventCode FLEET_STATE_ACTIVATING = new EventCode("FLEET_STATE_ACTIVATING");
        /// <summary>
        /// Constant FLEET_STATE_ACTIVE for EventCode
        /// </summary>
        public static readonly EventCode FLEET_STATE_ACTIVE = new EventCode("FLEET_STATE_ACTIVE");
        /// <summary>
        /// Constant FLEET_STATE_BUILDING for EventCode
        /// </summary>
        public static readonly EventCode FLEET_STATE_BUILDING = new EventCode("FLEET_STATE_BUILDING");
        /// <summary>
        /// Constant FLEET_STATE_CREATED for EventCode
        /// </summary>
        public static readonly EventCode FLEET_STATE_CREATED = new EventCode("FLEET_STATE_CREATED");
        /// <summary>
        /// Constant FLEET_STATE_CREATING for EventCode
        /// </summary>
        public static readonly EventCode FLEET_STATE_CREATING = new EventCode("FLEET_STATE_CREATING");
        /// <summary>
        /// Constant FLEET_STATE_DOWNLOADING for EventCode
        /// </summary>
        public static readonly EventCode FLEET_STATE_DOWNLOADING = new EventCode("FLEET_STATE_DOWNLOADING");
        /// <summary>
        /// Constant FLEET_STATE_ERROR for EventCode
        /// </summary>
        public static readonly EventCode FLEET_STATE_ERROR = new EventCode("FLEET_STATE_ERROR");
        /// <summary>
        /// Constant FLEET_STATE_PENDING for EventCode
        /// </summary>
        public static readonly EventCode FLEET_STATE_PENDING = new EventCode("FLEET_STATE_PENDING");
        /// <summary>
        /// Constant FLEET_STATE_UPDATING for EventCode
        /// </summary>
        public static readonly EventCode FLEET_STATE_UPDATING = new EventCode("FLEET_STATE_UPDATING");
        /// <summary>
        /// Constant FLEET_STATE_VALIDATING for EventCode
        /// </summary>
        public static readonly EventCode FLEET_STATE_VALIDATING = new EventCode("FLEET_STATE_VALIDATING");
        /// <summary>
        /// Constant FLEET_VALIDATION_EXECUTABLE_RUNTIME_FAILURE for EventCode
        /// </summary>
        public static readonly EventCode FLEET_VALIDATION_EXECUTABLE_RUNTIME_FAILURE = new EventCode("FLEET_VALIDATION_EXECUTABLE_RUNTIME_FAILURE");
        /// <summary>
        /// Constant FLEET_VALIDATION_LAUNCH_PATH_NOT_FOUND for EventCode
        /// </summary>
        public static readonly EventCode FLEET_VALIDATION_LAUNCH_PATH_NOT_FOUND = new EventCode("FLEET_VALIDATION_LAUNCH_PATH_NOT_FOUND");
        /// <summary>
        /// Constant FLEET_VALIDATION_TIMED_OUT for EventCode
        /// </summary>
        public static readonly EventCode FLEET_VALIDATION_TIMED_OUT = new EventCode("FLEET_VALIDATION_TIMED_OUT");
        /// <summary>
        /// Constant FLEET_VPC_PEERING_DELETED for EventCode
        /// </summary>
        public static readonly EventCode FLEET_VPC_PEERING_DELETED = new EventCode("FLEET_VPC_PEERING_DELETED");
        /// <summary>
        /// Constant FLEET_VPC_PEERING_FAILED for EventCode
        /// </summary>
        public static readonly EventCode FLEET_VPC_PEERING_FAILED = new EventCode("FLEET_VPC_PEERING_FAILED");
        /// <summary>
        /// Constant FLEET_VPC_PEERING_SUCCEEDED for EventCode
        /// </summary>
        public static readonly EventCode FLEET_VPC_PEERING_SUCCEEDED = new EventCode("FLEET_VPC_PEERING_SUCCEEDED");
        /// <summary>
        /// Constant GAME_SERVER_CONTAINER_GROUP_CRASHED for EventCode
        /// </summary>
        public static readonly EventCode GAME_SERVER_CONTAINER_GROUP_CRASHED = new EventCode("GAME_SERVER_CONTAINER_GROUP_CRASHED");
        /// <summary>
        /// Constant GAME_SERVER_CONTAINER_GROUP_REPLACED_UNHEALTHY for EventCode
        /// </summary>
        public static readonly EventCode GAME_SERVER_CONTAINER_GROUP_REPLACED_UNHEALTHY = new EventCode("GAME_SERVER_CONTAINER_GROUP_REPLACED_UNHEALTHY");
        /// <summary>
        /// Constant GAME_SESSION_ACTIVATION_TIMEOUT for EventCode
        /// </summary>
        public static readonly EventCode GAME_SESSION_ACTIVATION_TIMEOUT = new EventCode("GAME_SESSION_ACTIVATION_TIMEOUT");
        /// <summary>
        /// Constant GENERIC_EVENT for EventCode
        /// </summary>
        public static readonly EventCode GENERIC_EVENT = new EventCode("GENERIC_EVENT");
        /// <summary>
        /// Constant INSTANCE_INTERRUPTED for EventCode
        /// </summary>
        public static readonly EventCode INSTANCE_INTERRUPTED = new EventCode("INSTANCE_INTERRUPTED");
        /// <summary>
        /// Constant INSTANCE_RECYCLED for EventCode
        /// </summary>
        public static readonly EventCode INSTANCE_RECYCLED = new EventCode("INSTANCE_RECYCLED");
        /// <summary>
        /// Constant INSTANCE_REPLACED_UNHEALTHY for EventCode
        /// </summary>
        public static readonly EventCode INSTANCE_REPLACED_UNHEALTHY = new EventCode("INSTANCE_REPLACED_UNHEALTHY");
        /// <summary>
        /// Constant LOCATION_STATE_ACTIVATING for EventCode
        /// </summary>
        public static readonly EventCode LOCATION_STATE_ACTIVATING = new EventCode("LOCATION_STATE_ACTIVATING");
        /// <summary>
        /// Constant LOCATION_STATE_ACTIVE for EventCode
        /// </summary>
        public static readonly EventCode LOCATION_STATE_ACTIVE = new EventCode("LOCATION_STATE_ACTIVE");
        /// <summary>
        /// Constant LOCATION_STATE_CREATED for EventCode
        /// </summary>
        public static readonly EventCode LOCATION_STATE_CREATED = new EventCode("LOCATION_STATE_CREATED");
        /// <summary>
        /// Constant LOCATION_STATE_CREATING for EventCode
        /// </summary>
        public static readonly EventCode LOCATION_STATE_CREATING = new EventCode("LOCATION_STATE_CREATING");
        /// <summary>
        /// Constant LOCATION_STATE_DELETED for EventCode
        /// </summary>
        public static readonly EventCode LOCATION_STATE_DELETED = new EventCode("LOCATION_STATE_DELETED");
        /// <summary>
        /// Constant LOCATION_STATE_DELETING for EventCode
        /// </summary>
        public static readonly EventCode LOCATION_STATE_DELETING = new EventCode("LOCATION_STATE_DELETING");
        /// <summary>
        /// Constant LOCATION_STATE_ERROR for EventCode
        /// </summary>
        public static readonly EventCode LOCATION_STATE_ERROR = new EventCode("LOCATION_STATE_ERROR");
        /// <summary>
        /// Constant LOCATION_STATE_PENDING for EventCode
        /// </summary>
        public static readonly EventCode LOCATION_STATE_PENDING = new EventCode("LOCATION_STATE_PENDING");
        /// <summary>
        /// Constant LOCATION_STATE_UPDATING for EventCode
        /// </summary>
        public static readonly EventCode LOCATION_STATE_UPDATING = new EventCode("LOCATION_STATE_UPDATING");
        /// <summary>
        /// Constant PER_INSTANCE_CONTAINER_GROUP_CRASHED for EventCode
        /// </summary>
        public static readonly EventCode PER_INSTANCE_CONTAINER_GROUP_CRASHED = new EventCode("PER_INSTANCE_CONTAINER_GROUP_CRASHED");
        /// <summary>
        /// Constant SERVER_PROCESS_CRASHED for EventCode
        /// </summary>
        public static readonly EventCode SERVER_PROCESS_CRASHED = new EventCode("SERVER_PROCESS_CRASHED");
        /// <summary>
        /// Constant SERVER_PROCESS_FORCE_TERMINATED for EventCode
        /// </summary>
        public static readonly EventCode SERVER_PROCESS_FORCE_TERMINATED = new EventCode("SERVER_PROCESS_FORCE_TERMINATED");
        /// <summary>
        /// Constant SERVER_PROCESS_INVALID_PATH for EventCode
        /// </summary>
        public static readonly EventCode SERVER_PROCESS_INVALID_PATH = new EventCode("SERVER_PROCESS_INVALID_PATH");
        /// <summary>
        /// Constant SERVER_PROCESS_MISCONFIGURED_CONTAINER_PORT for EventCode
        /// </summary>
        public static readonly EventCode SERVER_PROCESS_MISCONFIGURED_CONTAINER_PORT = new EventCode("SERVER_PROCESS_MISCONFIGURED_CONTAINER_PORT");
        /// <summary>
        /// Constant SERVER_PROCESS_PROCESS_EXIT_TIMEOUT for EventCode
        /// </summary>
        public static readonly EventCode SERVER_PROCESS_PROCESS_EXIT_TIMEOUT = new EventCode("SERVER_PROCESS_PROCESS_EXIT_TIMEOUT");
        /// <summary>
        /// Constant SERVER_PROCESS_PROCESS_READY_TIMEOUT for EventCode
        /// </summary>
        public static readonly EventCode SERVER_PROCESS_PROCESS_READY_TIMEOUT = new EventCode("SERVER_PROCESS_PROCESS_READY_TIMEOUT");
        /// <summary>
        /// Constant SERVER_PROCESS_SDK_INITIALIZATION_FAILED for EventCode
        /// </summary>
        public static readonly EventCode SERVER_PROCESS_SDK_INITIALIZATION_FAILED = new EventCode("SERVER_PROCESS_SDK_INITIALIZATION_FAILED");
        /// <summary>
        /// Constant SERVER_PROCESS_SDK_INITIALIZATION_TIMEOUT for EventCode
        /// </summary>
        public static readonly EventCode SERVER_PROCESS_SDK_INITIALIZATION_TIMEOUT = new EventCode("SERVER_PROCESS_SDK_INITIALIZATION_TIMEOUT");
        /// <summary>
        /// Constant SERVER_PROCESS_TERMINATED_UNHEALTHY for EventCode
        /// </summary>
        public static readonly EventCode SERVER_PROCESS_TERMINATED_UNHEALTHY = new EventCode("SERVER_PROCESS_TERMINATED_UNHEALTHY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventCode FindValue(string value)
        {
            return FindValue<EventCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FilterInstanceStatus.
    /// </summary>
    public class FilterInstanceStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for FilterInstanceStatus
        /// </summary>
        public static readonly FilterInstanceStatus ACTIVE = new FilterInstanceStatus("ACTIVE");
        /// <summary>
        /// Constant DRAINING for FilterInstanceStatus
        /// </summary>
        public static readonly FilterInstanceStatus DRAINING = new FilterInstanceStatus("DRAINING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterInstanceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterInstanceStatus FindValue(string value)
        {
            return FindValue<FilterInstanceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterInstanceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetAction.
    /// </summary>
    public class FleetAction : ConstantClass
    {

        /// <summary>
        /// Constant AUTO_SCALING for FleetAction
        /// </summary>
        public static readonly FleetAction AUTO_SCALING = new FleetAction("AUTO_SCALING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetAction FindValue(string value)
        {
            return FindValue<FleetAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetStatus.
    /// </summary>
    public class FleetStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATING for FleetStatus
        /// </summary>
        public static readonly FleetStatus ACTIVATING = new FleetStatus("ACTIVATING");
        /// <summary>
        /// Constant ACTIVE for FleetStatus
        /// </summary>
        public static readonly FleetStatus ACTIVE = new FleetStatus("ACTIVE");
        /// <summary>
        /// Constant BUILDING for FleetStatus
        /// </summary>
        public static readonly FleetStatus BUILDING = new FleetStatus("BUILDING");
        /// <summary>
        /// Constant DELETING for FleetStatus
        /// </summary>
        public static readonly FleetStatus DELETING = new FleetStatus("DELETING");
        /// <summary>
        /// Constant DOWNLOADING for FleetStatus
        /// </summary>
        public static readonly FleetStatus DOWNLOADING = new FleetStatus("DOWNLOADING");
        /// <summary>
        /// Constant ERROR for FleetStatus
        /// </summary>
        public static readonly FleetStatus ERROR = new FleetStatus("ERROR");
        /// <summary>
        /// Constant NEW for FleetStatus
        /// </summary>
        public static readonly FleetStatus NEW = new FleetStatus("NEW");
        /// <summary>
        /// Constant NOT_FOUND for FleetStatus
        /// </summary>
        public static readonly FleetStatus NOT_FOUND = new FleetStatus("NOT_FOUND");
        /// <summary>
        /// Constant TERMINATED for FleetStatus
        /// </summary>
        public static readonly FleetStatus TERMINATED = new FleetStatus("TERMINATED");
        /// <summary>
        /// Constant VALIDATING for FleetStatus
        /// </summary>
        public static readonly FleetStatus VALIDATING = new FleetStatus("VALIDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetStatus FindValue(string value)
        {
            return FindValue<FleetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetType.
    /// </summary>
    public class FleetType : ConstantClass
    {

        /// <summary>
        /// Constant ON_DEMAND for FleetType
        /// </summary>
        public static readonly FleetType ON_DEMAND = new FleetType("ON_DEMAND");
        /// <summary>
        /// Constant SPOT for FleetType
        /// </summary>
        public static readonly FleetType SPOT = new FleetType("SPOT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetType FindValue(string value)
        {
            return FindValue<FleetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FlexMatchMode.
    /// </summary>
    public class FlexMatchMode : ConstantClass
    {

        /// <summary>
        /// Constant STANDALONE for FlexMatchMode
        /// </summary>
        public static readonly FlexMatchMode STANDALONE = new FlexMatchMode("STANDALONE");
        /// <summary>
        /// Constant WITH_QUEUE for FlexMatchMode
        /// </summary>
        public static readonly FlexMatchMode WITH_QUEUE = new FlexMatchMode("WITH_QUEUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FlexMatchMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FlexMatchMode FindValue(string value)
        {
            return FindValue<FlexMatchMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FlexMatchMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GameServerClaimStatus.
    /// </summary>
    public class GameServerClaimStatus : ConstantClass
    {

        /// <summary>
        /// Constant CLAIMED for GameServerClaimStatus
        /// </summary>
        public static readonly GameServerClaimStatus CLAIMED = new GameServerClaimStatus("CLAIMED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GameServerClaimStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GameServerClaimStatus FindValue(string value)
        {
            return FindValue<GameServerClaimStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GameServerClaimStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GameServerGroupAction.
    /// </summary>
    public class GameServerGroupAction : ConstantClass
    {

        /// <summary>
        /// Constant REPLACE_INSTANCE_TYPES for GameServerGroupAction
        /// </summary>
        public static readonly GameServerGroupAction REPLACE_INSTANCE_TYPES = new GameServerGroupAction("REPLACE_INSTANCE_TYPES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GameServerGroupAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GameServerGroupAction FindValue(string value)
        {
            return FindValue<GameServerGroupAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GameServerGroupAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GameServerGroupDeleteOption.
    /// </summary>
    public class GameServerGroupDeleteOption : ConstantClass
    {

        /// <summary>
        /// Constant FORCE_DELETE for GameServerGroupDeleteOption
        /// </summary>
        public static readonly GameServerGroupDeleteOption FORCE_DELETE = new GameServerGroupDeleteOption("FORCE_DELETE");
        /// <summary>
        /// Constant RETAIN for GameServerGroupDeleteOption
        /// </summary>
        public static readonly GameServerGroupDeleteOption RETAIN = new GameServerGroupDeleteOption("RETAIN");
        /// <summary>
        /// Constant SAFE_DELETE for GameServerGroupDeleteOption
        /// </summary>
        public static readonly GameServerGroupDeleteOption SAFE_DELETE = new GameServerGroupDeleteOption("SAFE_DELETE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GameServerGroupDeleteOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GameServerGroupDeleteOption FindValue(string value)
        {
            return FindValue<GameServerGroupDeleteOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GameServerGroupDeleteOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GameServerGroupInstanceType.
    /// </summary>
    public class GameServerGroupInstanceType : ConstantClass
    {

        /// <summary>
        /// Constant C42xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType C42xlarge = new GameServerGroupInstanceType("c4.2xlarge");
        /// <summary>
        /// Constant C44xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType C44xlarge = new GameServerGroupInstanceType("c4.4xlarge");
        /// <summary>
        /// Constant C48xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType C48xlarge = new GameServerGroupInstanceType("c4.8xlarge");
        /// <summary>
        /// Constant C4Large for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType C4Large = new GameServerGroupInstanceType("c4.large");
        /// <summary>
        /// Constant C4Xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType C4Xlarge = new GameServerGroupInstanceType("c4.xlarge");
        /// <summary>
        /// Constant C512xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType C512xlarge = new GameServerGroupInstanceType("c5.12xlarge");
        /// <summary>
        /// Constant C518xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType C518xlarge = new GameServerGroupInstanceType("c5.18xlarge");
        /// <summary>
        /// Constant C524xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType C524xlarge = new GameServerGroupInstanceType("c5.24xlarge");
        /// <summary>
        /// Constant C52xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType C52xlarge = new GameServerGroupInstanceType("c5.2xlarge");
        /// <summary>
        /// Constant C54xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType C54xlarge = new GameServerGroupInstanceType("c5.4xlarge");
        /// <summary>
        /// Constant C59xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType C59xlarge = new GameServerGroupInstanceType("c5.9xlarge");
        /// <summary>
        /// Constant C5a12xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType C5a12xlarge = new GameServerGroupInstanceType("c5a.12xlarge");
        /// <summary>
        /// Constant C5a16xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType C5a16xlarge = new GameServerGroupInstanceType("c5a.16xlarge");
        /// <summary>
        /// Constant C5a24xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType C5a24xlarge = new GameServerGroupInstanceType("c5a.24xlarge");
        /// <summary>
        /// Constant C5a2xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType C5a2xlarge = new GameServerGroupInstanceType("c5a.2xlarge");
        /// <summary>
        /// Constant C5a4xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType C5a4xlarge = new GameServerGroupInstanceType("c5a.4xlarge");
        /// <summary>
        /// Constant C5a8xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType C5a8xlarge = new GameServerGroupInstanceType("c5a.8xlarge");
        /// <summary>
        /// Constant C5aLarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType C5aLarge = new GameServerGroupInstanceType("c5a.large");
        /// <summary>
        /// Constant C5aXlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType C5aXlarge = new GameServerGroupInstanceType("c5a.xlarge");
        /// <summary>
        /// Constant C5Large for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType C5Large = new GameServerGroupInstanceType("c5.large");
        /// <summary>
        /// Constant C5Xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType C5Xlarge = new GameServerGroupInstanceType("c5.xlarge");
        /// <summary>
        /// Constant C6g12xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType C6g12xlarge = new GameServerGroupInstanceType("c6g.12xlarge");
        /// <summary>
        /// Constant C6g16xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType C6g16xlarge = new GameServerGroupInstanceType("c6g.16xlarge");
        /// <summary>
        /// Constant C6g2xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType C6g2xlarge = new GameServerGroupInstanceType("c6g.2xlarge");
        /// <summary>
        /// Constant C6g4xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType C6g4xlarge = new GameServerGroupInstanceType("c6g.4xlarge");
        /// <summary>
        /// Constant C6g8xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType C6g8xlarge = new GameServerGroupInstanceType("c6g.8xlarge");
        /// <summary>
        /// Constant C6gLarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType C6gLarge = new GameServerGroupInstanceType("c6g.large");
        /// <summary>
        /// Constant C6gMedium for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType C6gMedium = new GameServerGroupInstanceType("c6g.medium");
        /// <summary>
        /// Constant C6gXlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType C6gXlarge = new GameServerGroupInstanceType("c6g.xlarge");
        /// <summary>
        /// Constant M410xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType M410xlarge = new GameServerGroupInstanceType("m4.10xlarge");
        /// <summary>
        /// Constant M42xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType M42xlarge = new GameServerGroupInstanceType("m4.2xlarge");
        /// <summary>
        /// Constant M44xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType M44xlarge = new GameServerGroupInstanceType("m4.4xlarge");
        /// <summary>
        /// Constant M4Large for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType M4Large = new GameServerGroupInstanceType("m4.large");
        /// <summary>
        /// Constant M4Xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType M4Xlarge = new GameServerGroupInstanceType("m4.xlarge");
        /// <summary>
        /// Constant M512xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType M512xlarge = new GameServerGroupInstanceType("m5.12xlarge");
        /// <summary>
        /// Constant M516xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType M516xlarge = new GameServerGroupInstanceType("m5.16xlarge");
        /// <summary>
        /// Constant M524xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType M524xlarge = new GameServerGroupInstanceType("m5.24xlarge");
        /// <summary>
        /// Constant M52xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType M52xlarge = new GameServerGroupInstanceType("m5.2xlarge");
        /// <summary>
        /// Constant M54xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType M54xlarge = new GameServerGroupInstanceType("m5.4xlarge");
        /// <summary>
        /// Constant M58xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType M58xlarge = new GameServerGroupInstanceType("m5.8xlarge");
        /// <summary>
        /// Constant M5a12xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType M5a12xlarge = new GameServerGroupInstanceType("m5a.12xlarge");
        /// <summary>
        /// Constant M5a16xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType M5a16xlarge = new GameServerGroupInstanceType("m5a.16xlarge");
        /// <summary>
        /// Constant M5a24xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType M5a24xlarge = new GameServerGroupInstanceType("m5a.24xlarge");
        /// <summary>
        /// Constant M5a2xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType M5a2xlarge = new GameServerGroupInstanceType("m5a.2xlarge");
        /// <summary>
        /// Constant M5a4xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType M5a4xlarge = new GameServerGroupInstanceType("m5a.4xlarge");
        /// <summary>
        /// Constant M5a8xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType M5a8xlarge = new GameServerGroupInstanceType("m5a.8xlarge");
        /// <summary>
        /// Constant M5aLarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType M5aLarge = new GameServerGroupInstanceType("m5a.large");
        /// <summary>
        /// Constant M5aXlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType M5aXlarge = new GameServerGroupInstanceType("m5a.xlarge");
        /// <summary>
        /// Constant M5Large for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType M5Large = new GameServerGroupInstanceType("m5.large");
        /// <summary>
        /// Constant M5Xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType M5Xlarge = new GameServerGroupInstanceType("m5.xlarge");
        /// <summary>
        /// Constant M6g12xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType M6g12xlarge = new GameServerGroupInstanceType("m6g.12xlarge");
        /// <summary>
        /// Constant M6g16xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType M6g16xlarge = new GameServerGroupInstanceType("m6g.16xlarge");
        /// <summary>
        /// Constant M6g2xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType M6g2xlarge = new GameServerGroupInstanceType("m6g.2xlarge");
        /// <summary>
        /// Constant M6g4xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType M6g4xlarge = new GameServerGroupInstanceType("m6g.4xlarge");
        /// <summary>
        /// Constant M6g8xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType M6g8xlarge = new GameServerGroupInstanceType("m6g.8xlarge");
        /// <summary>
        /// Constant M6gLarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType M6gLarge = new GameServerGroupInstanceType("m6g.large");
        /// <summary>
        /// Constant M6gMedium for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType M6gMedium = new GameServerGroupInstanceType("m6g.medium");
        /// <summary>
        /// Constant M6gXlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType M6gXlarge = new GameServerGroupInstanceType("m6g.xlarge");
        /// <summary>
        /// Constant R416xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType R416xlarge = new GameServerGroupInstanceType("r4.16xlarge");
        /// <summary>
        /// Constant R42xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType R42xlarge = new GameServerGroupInstanceType("r4.2xlarge");
        /// <summary>
        /// Constant R44xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType R44xlarge = new GameServerGroupInstanceType("r4.4xlarge");
        /// <summary>
        /// Constant R48xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType R48xlarge = new GameServerGroupInstanceType("r4.8xlarge");
        /// <summary>
        /// Constant R4Large for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType R4Large = new GameServerGroupInstanceType("r4.large");
        /// <summary>
        /// Constant R4Xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType R4Xlarge = new GameServerGroupInstanceType("r4.xlarge");
        /// <summary>
        /// Constant R512xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType R512xlarge = new GameServerGroupInstanceType("r5.12xlarge");
        /// <summary>
        /// Constant R516xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType R516xlarge = new GameServerGroupInstanceType("r5.16xlarge");
        /// <summary>
        /// Constant R524xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType R524xlarge = new GameServerGroupInstanceType("r5.24xlarge");
        /// <summary>
        /// Constant R52xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType R52xlarge = new GameServerGroupInstanceType("r5.2xlarge");
        /// <summary>
        /// Constant R54xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType R54xlarge = new GameServerGroupInstanceType("r5.4xlarge");
        /// <summary>
        /// Constant R58xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType R58xlarge = new GameServerGroupInstanceType("r5.8xlarge");
        /// <summary>
        /// Constant R5a12xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType R5a12xlarge = new GameServerGroupInstanceType("r5a.12xlarge");
        /// <summary>
        /// Constant R5a16xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType R5a16xlarge = new GameServerGroupInstanceType("r5a.16xlarge");
        /// <summary>
        /// Constant R5a24xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType R5a24xlarge = new GameServerGroupInstanceType("r5a.24xlarge");
        /// <summary>
        /// Constant R5a2xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType R5a2xlarge = new GameServerGroupInstanceType("r5a.2xlarge");
        /// <summary>
        /// Constant R5a4xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType R5a4xlarge = new GameServerGroupInstanceType("r5a.4xlarge");
        /// <summary>
        /// Constant R5a8xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType R5a8xlarge = new GameServerGroupInstanceType("r5a.8xlarge");
        /// <summary>
        /// Constant R5aLarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType R5aLarge = new GameServerGroupInstanceType("r5a.large");
        /// <summary>
        /// Constant R5aXlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType R5aXlarge = new GameServerGroupInstanceType("r5a.xlarge");
        /// <summary>
        /// Constant R5Large for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType R5Large = new GameServerGroupInstanceType("r5.large");
        /// <summary>
        /// Constant R5Xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType R5Xlarge = new GameServerGroupInstanceType("r5.xlarge");
        /// <summary>
        /// Constant R6g12xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType R6g12xlarge = new GameServerGroupInstanceType("r6g.12xlarge");
        /// <summary>
        /// Constant R6g16xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType R6g16xlarge = new GameServerGroupInstanceType("r6g.16xlarge");
        /// <summary>
        /// Constant R6g2xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType R6g2xlarge = new GameServerGroupInstanceType("r6g.2xlarge");
        /// <summary>
        /// Constant R6g4xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType R6g4xlarge = new GameServerGroupInstanceType("r6g.4xlarge");
        /// <summary>
        /// Constant R6g8xlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType R6g8xlarge = new GameServerGroupInstanceType("r6g.8xlarge");
        /// <summary>
        /// Constant R6gLarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType R6gLarge = new GameServerGroupInstanceType("r6g.large");
        /// <summary>
        /// Constant R6gMedium for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType R6gMedium = new GameServerGroupInstanceType("r6g.medium");
        /// <summary>
        /// Constant R6gXlarge for GameServerGroupInstanceType
        /// </summary>
        public static readonly GameServerGroupInstanceType R6gXlarge = new GameServerGroupInstanceType("r6g.xlarge");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GameServerGroupInstanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GameServerGroupInstanceType FindValue(string value)
        {
            return FindValue<GameServerGroupInstanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GameServerGroupInstanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GameServerGroupStatus.
    /// </summary>
    public class GameServerGroupStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATING for GameServerGroupStatus
        /// </summary>
        public static readonly GameServerGroupStatus ACTIVATING = new GameServerGroupStatus("ACTIVATING");
        /// <summary>
        /// Constant ACTIVE for GameServerGroupStatus
        /// </summary>
        public static readonly GameServerGroupStatus ACTIVE = new GameServerGroupStatus("ACTIVE");
        /// <summary>
        /// Constant DELETE_SCHEDULED for GameServerGroupStatus
        /// </summary>
        public static readonly GameServerGroupStatus DELETE_SCHEDULED = new GameServerGroupStatus("DELETE_SCHEDULED");
        /// <summary>
        /// Constant DELETED for GameServerGroupStatus
        /// </summary>
        public static readonly GameServerGroupStatus DELETED = new GameServerGroupStatus("DELETED");
        /// <summary>
        /// Constant DELETING for GameServerGroupStatus
        /// </summary>
        public static readonly GameServerGroupStatus DELETING = new GameServerGroupStatus("DELETING");
        /// <summary>
        /// Constant ERROR for GameServerGroupStatus
        /// </summary>
        public static readonly GameServerGroupStatus ERROR = new GameServerGroupStatus("ERROR");
        /// <summary>
        /// Constant NEW for GameServerGroupStatus
        /// </summary>
        public static readonly GameServerGroupStatus NEW = new GameServerGroupStatus("NEW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GameServerGroupStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GameServerGroupStatus FindValue(string value)
        {
            return FindValue<GameServerGroupStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GameServerGroupStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GameServerHealthCheck.
    /// </summary>
    public class GameServerHealthCheck : ConstantClass
    {

        /// <summary>
        /// Constant HEALTHY for GameServerHealthCheck
        /// </summary>
        public static readonly GameServerHealthCheck HEALTHY = new GameServerHealthCheck("HEALTHY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GameServerHealthCheck(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GameServerHealthCheck FindValue(string value)
        {
            return FindValue<GameServerHealthCheck>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GameServerHealthCheck(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GameServerInstanceStatus.
    /// </summary>
    public class GameServerInstanceStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for GameServerInstanceStatus
        /// </summary>
        public static readonly GameServerInstanceStatus ACTIVE = new GameServerInstanceStatus("ACTIVE");
        /// <summary>
        /// Constant DRAINING for GameServerInstanceStatus
        /// </summary>
        public static readonly GameServerInstanceStatus DRAINING = new GameServerInstanceStatus("DRAINING");
        /// <summary>
        /// Constant SPOT_TERMINATING for GameServerInstanceStatus
        /// </summary>
        public static readonly GameServerInstanceStatus SPOT_TERMINATING = new GameServerInstanceStatus("SPOT_TERMINATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GameServerInstanceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GameServerInstanceStatus FindValue(string value)
        {
            return FindValue<GameServerInstanceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GameServerInstanceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GameServerProtectionPolicy.
    /// </summary>
    public class GameServerProtectionPolicy : ConstantClass
    {

        /// <summary>
        /// Constant FULL_PROTECTION for GameServerProtectionPolicy
        /// </summary>
        public static readonly GameServerProtectionPolicy FULL_PROTECTION = new GameServerProtectionPolicy("FULL_PROTECTION");
        /// <summary>
        /// Constant NO_PROTECTION for GameServerProtectionPolicy
        /// </summary>
        public static readonly GameServerProtectionPolicy NO_PROTECTION = new GameServerProtectionPolicy("NO_PROTECTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GameServerProtectionPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GameServerProtectionPolicy FindValue(string value)
        {
            return FindValue<GameServerProtectionPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GameServerProtectionPolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GameServerUtilizationStatus.
    /// </summary>
    public class GameServerUtilizationStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for GameServerUtilizationStatus
        /// </summary>
        public static readonly GameServerUtilizationStatus AVAILABLE = new GameServerUtilizationStatus("AVAILABLE");
        /// <summary>
        /// Constant UTILIZED for GameServerUtilizationStatus
        /// </summary>
        public static readonly GameServerUtilizationStatus UTILIZED = new GameServerUtilizationStatus("UTILIZED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GameServerUtilizationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GameServerUtilizationStatus FindValue(string value)
        {
            return FindValue<GameServerUtilizationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GameServerUtilizationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GameSessionPlacementState.
    /// </summary>
    public class GameSessionPlacementState : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for GameSessionPlacementState
        /// </summary>
        public static readonly GameSessionPlacementState CANCELLED = new GameSessionPlacementState("CANCELLED");
        /// <summary>
        /// Constant FAILED for GameSessionPlacementState
        /// </summary>
        public static readonly GameSessionPlacementState FAILED = new GameSessionPlacementState("FAILED");
        /// <summary>
        /// Constant FULFILLED for GameSessionPlacementState
        /// </summary>
        public static readonly GameSessionPlacementState FULFILLED = new GameSessionPlacementState("FULFILLED");
        /// <summary>
        /// Constant PENDING for GameSessionPlacementState
        /// </summary>
        public static readonly GameSessionPlacementState PENDING = new GameSessionPlacementState("PENDING");
        /// <summary>
        /// Constant TIMED_OUT for GameSessionPlacementState
        /// </summary>
        public static readonly GameSessionPlacementState TIMED_OUT = new GameSessionPlacementState("TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GameSessionPlacementState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GameSessionPlacementState FindValue(string value)
        {
            return FindValue<GameSessionPlacementState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GameSessionPlacementState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GameSessionStatus.
    /// </summary>
    public class GameSessionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATING for GameSessionStatus
        /// </summary>
        public static readonly GameSessionStatus ACTIVATING = new GameSessionStatus("ACTIVATING");
        /// <summary>
        /// Constant ACTIVE for GameSessionStatus
        /// </summary>
        public static readonly GameSessionStatus ACTIVE = new GameSessionStatus("ACTIVE");
        /// <summary>
        /// Constant ERROR for GameSessionStatus
        /// </summary>
        public static readonly GameSessionStatus ERROR = new GameSessionStatus("ERROR");
        /// <summary>
        /// Constant TERMINATED for GameSessionStatus
        /// </summary>
        public static readonly GameSessionStatus TERMINATED = new GameSessionStatus("TERMINATED");
        /// <summary>
        /// Constant TERMINATING for GameSessionStatus
        /// </summary>
        public static readonly GameSessionStatus TERMINATING = new GameSessionStatus("TERMINATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GameSessionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GameSessionStatus FindValue(string value)
        {
            return FindValue<GameSessionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GameSessionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GameSessionStatusReason.
    /// </summary>
    public class GameSessionStatusReason : ConstantClass
    {

        /// <summary>
        /// Constant FORCE_TERMINATED for GameSessionStatusReason
        /// </summary>
        public static readonly GameSessionStatusReason FORCE_TERMINATED = new GameSessionStatusReason("FORCE_TERMINATED");
        /// <summary>
        /// Constant INTERRUPTED for GameSessionStatusReason
        /// </summary>
        public static readonly GameSessionStatusReason INTERRUPTED = new GameSessionStatusReason("INTERRUPTED");
        /// <summary>
        /// Constant TRIGGERED_ON_PROCESS_TERMINATE for GameSessionStatusReason
        /// </summary>
        public static readonly GameSessionStatusReason TRIGGERED_ON_PROCESS_TERMINATE = new GameSessionStatusReason("TRIGGERED_ON_PROCESS_TERMINATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GameSessionStatusReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GameSessionStatusReason FindValue(string value)
        {
            return FindValue<GameSessionStatusReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GameSessionStatusReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceRoleCredentialsProvider.
    /// </summary>
    public class InstanceRoleCredentialsProvider : ConstantClass
    {

        /// <summary>
        /// Constant SHARED_CREDENTIAL_FILE for InstanceRoleCredentialsProvider
        /// </summary>
        public static readonly InstanceRoleCredentialsProvider SHARED_CREDENTIAL_FILE = new InstanceRoleCredentialsProvider("SHARED_CREDENTIAL_FILE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceRoleCredentialsProvider(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceRoleCredentialsProvider FindValue(string value)
        {
            return FindValue<InstanceRoleCredentialsProvider>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceRoleCredentialsProvider(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceStatus.
    /// </summary>
    public class InstanceStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for InstanceStatus
        /// </summary>
        public static readonly InstanceStatus ACTIVE = new InstanceStatus("ACTIVE");
        /// <summary>
        /// Constant PENDING for InstanceStatus
        /// </summary>
        public static readonly InstanceStatus PENDING = new InstanceStatus("PENDING");
        /// <summary>
        /// Constant TERMINATING for InstanceStatus
        /// </summary>
        public static readonly InstanceStatus TERMINATING = new InstanceStatus("TERMINATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceStatus FindValue(string value)
        {
            return FindValue<InstanceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IpProtocol.
    /// </summary>
    public class IpProtocol : ConstantClass
    {

        /// <summary>
        /// Constant TCP for IpProtocol
        /// </summary>
        public static readonly IpProtocol TCP = new IpProtocol("TCP");
        /// <summary>
        /// Constant UDP for IpProtocol
        /// </summary>
        public static readonly IpProtocol UDP = new IpProtocol("UDP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IpProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IpProtocol FindValue(string value)
        {
            return FindValue<IpProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IpProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListComputeInputStatus.
    /// </summary>
    public class ListComputeInputStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ListComputeInputStatus
        /// </summary>
        public static readonly ListComputeInputStatus ACTIVE = new ListComputeInputStatus("ACTIVE");
        /// <summary>
        /// Constant IMPAIRED for ListComputeInputStatus
        /// </summary>
        public static readonly ListComputeInputStatus IMPAIRED = new ListComputeInputStatus("IMPAIRED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListComputeInputStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListComputeInputStatus FindValue(string value)
        {
            return FindValue<ListComputeInputStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListComputeInputStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LocationFilter.
    /// </summary>
    public class LocationFilter : ConstantClass
    {

        /// <summary>
        /// Constant AWS for LocationFilter
        /// </summary>
        public static readonly LocationFilter AWS = new LocationFilter("AWS");
        /// <summary>
        /// Constant CUSTOM for LocationFilter
        /// </summary>
        public static readonly LocationFilter CUSTOM = new LocationFilter("CUSTOM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LocationFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LocationFilter FindValue(string value)
        {
            return FindValue<LocationFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LocationFilter(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LocationUpdateStatus.
    /// </summary>
    public class LocationUpdateStatus : ConstantClass
    {

        /// <summary>
        /// Constant PENDING_UPDATE for LocationUpdateStatus
        /// </summary>
        public static readonly LocationUpdateStatus PENDING_UPDATE = new LocationUpdateStatus("PENDING_UPDATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LocationUpdateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LocationUpdateStatus FindValue(string value)
        {
            return FindValue<LocationUpdateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LocationUpdateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogDestination.
    /// </summary>
    public class LogDestination : ConstantClass
    {

        /// <summary>
        /// Constant CLOUDWATCH for LogDestination
        /// </summary>
        public static readonly LogDestination CLOUDWATCH = new LogDestination("CLOUDWATCH");
        /// <summary>
        /// Constant NONE for LogDestination
        /// </summary>
        public static readonly LogDestination NONE = new LogDestination("NONE");
        /// <summary>
        /// Constant S3 for LogDestination
        /// </summary>
        public static readonly LogDestination S3 = new LogDestination("S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogDestination(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogDestination FindValue(string value)
        {
            return FindValue<LogDestination>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogDestination(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MatchmakingConfigurationStatus.
    /// </summary>
    public class MatchmakingConfigurationStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for MatchmakingConfigurationStatus
        /// </summary>
        public static readonly MatchmakingConfigurationStatus CANCELLED = new MatchmakingConfigurationStatus("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for MatchmakingConfigurationStatus
        /// </summary>
        public static readonly MatchmakingConfigurationStatus COMPLETED = new MatchmakingConfigurationStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for MatchmakingConfigurationStatus
        /// </summary>
        public static readonly MatchmakingConfigurationStatus FAILED = new MatchmakingConfigurationStatus("FAILED");
        /// <summary>
        /// Constant PLACING for MatchmakingConfigurationStatus
        /// </summary>
        public static readonly MatchmakingConfigurationStatus PLACING = new MatchmakingConfigurationStatus("PLACING");
        /// <summary>
        /// Constant QUEUED for MatchmakingConfigurationStatus
        /// </summary>
        public static readonly MatchmakingConfigurationStatus QUEUED = new MatchmakingConfigurationStatus("QUEUED");
        /// <summary>
        /// Constant REQUIRES_ACCEPTANCE for MatchmakingConfigurationStatus
        /// </summary>
        public static readonly MatchmakingConfigurationStatus REQUIRES_ACCEPTANCE = new MatchmakingConfigurationStatus("REQUIRES_ACCEPTANCE");
        /// <summary>
        /// Constant SEARCHING for MatchmakingConfigurationStatus
        /// </summary>
        public static readonly MatchmakingConfigurationStatus SEARCHING = new MatchmakingConfigurationStatus("SEARCHING");
        /// <summary>
        /// Constant TIMED_OUT for MatchmakingConfigurationStatus
        /// </summary>
        public static readonly MatchmakingConfigurationStatus TIMED_OUT = new MatchmakingConfigurationStatus("TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MatchmakingConfigurationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MatchmakingConfigurationStatus FindValue(string value)
        {
            return FindValue<MatchmakingConfigurationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MatchmakingConfigurationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetricName.
    /// </summary>
    public class MetricName : ConstantClass
    {

        /// <summary>
        /// Constant ActivatingGameSessions for MetricName
        /// </summary>
        public static readonly MetricName ActivatingGameSessions = new MetricName("ActivatingGameSessions");
        /// <summary>
        /// Constant ActiveGameSessions for MetricName
        /// </summary>
        public static readonly MetricName ActiveGameSessions = new MetricName("ActiveGameSessions");
        /// <summary>
        /// Constant ActiveInstances for MetricName
        /// </summary>
        public static readonly MetricName ActiveInstances = new MetricName("ActiveInstances");
        /// <summary>
        /// Constant AvailableGameSessions for MetricName
        /// </summary>
        public static readonly MetricName AvailableGameSessions = new MetricName("AvailableGameSessions");
        /// <summary>
        /// Constant AvailablePlayerSessions for MetricName
        /// </summary>
        public static readonly MetricName AvailablePlayerSessions = new MetricName("AvailablePlayerSessions");
        /// <summary>
        /// Constant ConcurrentActivatableGameSessions for MetricName
        /// </summary>
        public static readonly MetricName ConcurrentActivatableGameSessions = new MetricName("ConcurrentActivatableGameSessions");
        /// <summary>
        /// Constant CurrentPlayerSessions for MetricName
        /// </summary>
        public static readonly MetricName CurrentPlayerSessions = new MetricName("CurrentPlayerSessions");
        /// <summary>
        /// Constant IdleInstances for MetricName
        /// </summary>
        public static readonly MetricName IdleInstances = new MetricName("IdleInstances");
        /// <summary>
        /// Constant PercentAvailableGameSessions for MetricName
        /// </summary>
        public static readonly MetricName PercentAvailableGameSessions = new MetricName("PercentAvailableGameSessions");
        /// <summary>
        /// Constant PercentIdleInstances for MetricName
        /// </summary>
        public static readonly MetricName PercentIdleInstances = new MetricName("PercentIdleInstances");
        /// <summary>
        /// Constant QueueDepth for MetricName
        /// </summary>
        public static readonly MetricName QueueDepth = new MetricName("QueueDepth");
        /// <summary>
        /// Constant WaitTime for MetricName
        /// </summary>
        public static readonly MetricName WaitTime = new MetricName("WaitTime");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetricName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetricName FindValue(string value)
        {
            return FindValue<MetricName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetricName(string value)
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
        /// Constant AMAZON_LINUX for OperatingSystem
        /// </summary>
        public static readonly OperatingSystem AMAZON_LINUX = new OperatingSystem("AMAZON_LINUX");
        /// <summary>
        /// Constant AMAZON_LINUX_2 for OperatingSystem
        /// </summary>
        public static readonly OperatingSystem AMAZON_LINUX_2 = new OperatingSystem("AMAZON_LINUX_2");
        /// <summary>
        /// Constant AMAZON_LINUX_2023 for OperatingSystem
        /// </summary>
        public static readonly OperatingSystem AMAZON_LINUX_2023 = new OperatingSystem("AMAZON_LINUX_2023");
        /// <summary>
        /// Constant WINDOWS_2012 for OperatingSystem
        /// </summary>
        public static readonly OperatingSystem WINDOWS_2012 = new OperatingSystem("WINDOWS_2012");
        /// <summary>
        /// Constant WINDOWS_2016 for OperatingSystem
        /// </summary>
        public static readonly OperatingSystem WINDOWS_2016 = new OperatingSystem("WINDOWS_2016");

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
    /// Constants used for properties of type PlacementFallbackStrategy.
    /// </summary>
    public class PlacementFallbackStrategy : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT_AFTER_SINGLE_PASS for PlacementFallbackStrategy
        /// </summary>
        public static readonly PlacementFallbackStrategy DEFAULT_AFTER_SINGLE_PASS = new PlacementFallbackStrategy("DEFAULT_AFTER_SINGLE_PASS");
        /// <summary>
        /// Constant NONE for PlacementFallbackStrategy
        /// </summary>
        public static readonly PlacementFallbackStrategy NONE = new PlacementFallbackStrategy("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlacementFallbackStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlacementFallbackStrategy FindValue(string value)
        {
            return FindValue<PlacementFallbackStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlacementFallbackStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlayerSessionCreationPolicy.
    /// </summary>
    public class PlayerSessionCreationPolicy : ConstantClass
    {

        /// <summary>
        /// Constant ACCEPT_ALL for PlayerSessionCreationPolicy
        /// </summary>
        public static readonly PlayerSessionCreationPolicy ACCEPT_ALL = new PlayerSessionCreationPolicy("ACCEPT_ALL");
        /// <summary>
        /// Constant DENY_ALL for PlayerSessionCreationPolicy
        /// </summary>
        public static readonly PlayerSessionCreationPolicy DENY_ALL = new PlayerSessionCreationPolicy("DENY_ALL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlayerSessionCreationPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlayerSessionCreationPolicy FindValue(string value)
        {
            return FindValue<PlayerSessionCreationPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlayerSessionCreationPolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlayerSessionStatus.
    /// </summary>
    public class PlayerSessionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for PlayerSessionStatus
        /// </summary>
        public static readonly PlayerSessionStatus ACTIVE = new PlayerSessionStatus("ACTIVE");
        /// <summary>
        /// Constant COMPLETED for PlayerSessionStatus
        /// </summary>
        public static readonly PlayerSessionStatus COMPLETED = new PlayerSessionStatus("COMPLETED");
        /// <summary>
        /// Constant RESERVED for PlayerSessionStatus
        /// </summary>
        public static readonly PlayerSessionStatus RESERVED = new PlayerSessionStatus("RESERVED");
        /// <summary>
        /// Constant TIMEDOUT for PlayerSessionStatus
        /// </summary>
        public static readonly PlayerSessionStatus TIMEDOUT = new PlayerSessionStatus("TIMEDOUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlayerSessionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlayerSessionStatus FindValue(string value)
        {
            return FindValue<PlayerSessionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlayerSessionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PolicyType.
    /// </summary>
    public class PolicyType : ConstantClass
    {

        /// <summary>
        /// Constant RuleBased for PolicyType
        /// </summary>
        public static readonly PolicyType RuleBased = new PolicyType("RuleBased");
        /// <summary>
        /// Constant TargetBased for PolicyType
        /// </summary>
        public static readonly PolicyType TargetBased = new PolicyType("TargetBased");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyType FindValue(string value)
        {
            return FindValue<PolicyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PriorityType.
    /// </summary>
    public class PriorityType : ConstantClass
    {

        /// <summary>
        /// Constant COST for PriorityType
        /// </summary>
        public static readonly PriorityType COST = new PriorityType("COST");
        /// <summary>
        /// Constant DESTINATION for PriorityType
        /// </summary>
        public static readonly PriorityType DESTINATION = new PriorityType("DESTINATION");
        /// <summary>
        /// Constant LATENCY for PriorityType
        /// </summary>
        public static readonly PriorityType LATENCY = new PriorityType("LATENCY");
        /// <summary>
        /// Constant LOCATION for PriorityType
        /// </summary>
        public static readonly PriorityType LOCATION = new PriorityType("LOCATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PriorityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PriorityType FindValue(string value)
        {
            return FindValue<PriorityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PriorityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProtectionPolicy.
    /// </summary>
    public class ProtectionPolicy : ConstantClass
    {

        /// <summary>
        /// Constant FullProtection for ProtectionPolicy
        /// </summary>
        public static readonly ProtectionPolicy FullProtection = new ProtectionPolicy("FullProtection");
        /// <summary>
        /// Constant NoProtection for ProtectionPolicy
        /// </summary>
        public static readonly ProtectionPolicy NoProtection = new ProtectionPolicy("NoProtection");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProtectionPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProtectionPolicy FindValue(string value)
        {
            return FindValue<ProtectionPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProtectionPolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RoutingStrategyType.
    /// </summary>
    public class RoutingStrategyType : ConstantClass
    {

        /// <summary>
        /// Constant SIMPLE for RoutingStrategyType
        /// </summary>
        public static readonly RoutingStrategyType SIMPLE = new RoutingStrategyType("SIMPLE");
        /// <summary>
        /// Constant TERMINAL for RoutingStrategyType
        /// </summary>
        public static readonly RoutingStrategyType TERMINAL = new RoutingStrategyType("TERMINAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RoutingStrategyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RoutingStrategyType FindValue(string value)
        {
            return FindValue<RoutingStrategyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RoutingStrategyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScalingAdjustmentType.
    /// </summary>
    public class ScalingAdjustmentType : ConstantClass
    {

        /// <summary>
        /// Constant ChangeInCapacity for ScalingAdjustmentType
        /// </summary>
        public static readonly ScalingAdjustmentType ChangeInCapacity = new ScalingAdjustmentType("ChangeInCapacity");
        /// <summary>
        /// Constant ExactCapacity for ScalingAdjustmentType
        /// </summary>
        public static readonly ScalingAdjustmentType ExactCapacity = new ScalingAdjustmentType("ExactCapacity");
        /// <summary>
        /// Constant PercentChangeInCapacity for ScalingAdjustmentType
        /// </summary>
        public static readonly ScalingAdjustmentType PercentChangeInCapacity = new ScalingAdjustmentType("PercentChangeInCapacity");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScalingAdjustmentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScalingAdjustmentType FindValue(string value)
        {
            return FindValue<ScalingAdjustmentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScalingAdjustmentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScalingStatusType.
    /// </summary>
    public class ScalingStatusType : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ScalingStatusType
        /// </summary>
        public static readonly ScalingStatusType ACTIVE = new ScalingStatusType("ACTIVE");
        /// <summary>
        /// Constant DELETE_REQUESTED for ScalingStatusType
        /// </summary>
        public static readonly ScalingStatusType DELETE_REQUESTED = new ScalingStatusType("DELETE_REQUESTED");
        /// <summary>
        /// Constant DELETED for ScalingStatusType
        /// </summary>
        public static readonly ScalingStatusType DELETED = new ScalingStatusType("DELETED");
        /// <summary>
        /// Constant DELETING for ScalingStatusType
        /// </summary>
        public static readonly ScalingStatusType DELETING = new ScalingStatusType("DELETING");
        /// <summary>
        /// Constant ERROR for ScalingStatusType
        /// </summary>
        public static readonly ScalingStatusType ERROR = new ScalingStatusType("ERROR");
        /// <summary>
        /// Constant UPDATE_REQUESTED for ScalingStatusType
        /// </summary>
        public static readonly ScalingStatusType UPDATE_REQUESTED = new ScalingStatusType("UPDATE_REQUESTED");
        /// <summary>
        /// Constant UPDATING for ScalingStatusType
        /// </summary>
        public static readonly ScalingStatusType UPDATING = new ScalingStatusType("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScalingStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScalingStatusType FindValue(string value)
        {
            return FindValue<ScalingStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScalingStatusType(string value)
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
        /// Constant ASCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder ASCENDING = new SortOrder("ASCENDING");
        /// <summary>
        /// Constant DESCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder DESCENDING = new SortOrder("DESCENDING");

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
    /// Constants used for properties of type TerminationMode.
    /// </summary>
    public class TerminationMode : ConstantClass
    {

        /// <summary>
        /// Constant FORCE_TERMINATE for TerminationMode
        /// </summary>
        public static readonly TerminationMode FORCE_TERMINATE = new TerminationMode("FORCE_TERMINATE");
        /// <summary>
        /// Constant TRIGGER_ON_PROCESS_TERMINATE for TerminationMode
        /// </summary>
        public static readonly TerminationMode TRIGGER_ON_PROCESS_TERMINATE = new TerminationMode("TRIGGER_ON_PROCESS_TERMINATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TerminationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TerminationMode FindValue(string value)
        {
            return FindValue<TerminationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TerminationMode(string value)
        {
            return FindValue(value);
        }
    }

}