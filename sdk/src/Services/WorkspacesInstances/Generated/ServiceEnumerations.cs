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
 * Do not modify this file. This file is generated from the workspaces-instances-2022-07-26.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.WorkspacesInstances
{

    /// <summary>
    /// Constants used for properties of type AmdSevSnpEnum.
    /// </summary>
    public class AmdSevSnpEnum : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for AmdSevSnpEnum
        /// </summary>
        public static readonly AmdSevSnpEnum Disabled = new AmdSevSnpEnum("disabled");
        /// <summary>
        /// Constant Enabled for AmdSevSnpEnum
        /// </summary>
        public static readonly AmdSevSnpEnum Enabled = new AmdSevSnpEnum("enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AmdSevSnpEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AmdSevSnpEnum FindValue(string value)
        {
            return FindValue<AmdSevSnpEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AmdSevSnpEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoRecoveryEnum.
    /// </summary>
    public class AutoRecoveryEnum : ConstantClass
    {

        /// <summary>
        /// Constant Default for AutoRecoveryEnum
        /// </summary>
        public static readonly AutoRecoveryEnum Default = new AutoRecoveryEnum("default");
        /// <summary>
        /// Constant Disabled for AutoRecoveryEnum
        /// </summary>
        public static readonly AutoRecoveryEnum Disabled = new AutoRecoveryEnum("disabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoRecoveryEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoRecoveryEnum FindValue(string value)
        {
            return FindValue<AutoRecoveryEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoRecoveryEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BandwidthWeightingEnum.
    /// </summary>
    public class BandwidthWeightingEnum : ConstantClass
    {

        /// <summary>
        /// Constant Default for BandwidthWeightingEnum
        /// </summary>
        public static readonly BandwidthWeightingEnum Default = new BandwidthWeightingEnum("default");
        /// <summary>
        /// Constant Ebs1 for BandwidthWeightingEnum
        /// </summary>
        public static readonly BandwidthWeightingEnum Ebs1 = new BandwidthWeightingEnum("ebs-1");
        /// <summary>
        /// Constant Vpc1 for BandwidthWeightingEnum
        /// </summary>
        public static readonly BandwidthWeightingEnum Vpc1 = new BandwidthWeightingEnum("vpc-1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BandwidthWeightingEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BandwidthWeightingEnum FindValue(string value)
        {
            return FindValue<BandwidthWeightingEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BandwidthWeightingEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CapacityReservationPreferenceEnum.
    /// </summary>
    public class CapacityReservationPreferenceEnum : ConstantClass
    {

        /// <summary>
        /// Constant CapacityReservationsOnly for CapacityReservationPreferenceEnum
        /// </summary>
        public static readonly CapacityReservationPreferenceEnum CapacityReservationsOnly = new CapacityReservationPreferenceEnum("capacity-reservations-only");
        /// <summary>
        /// Constant None for CapacityReservationPreferenceEnum
        /// </summary>
        public static readonly CapacityReservationPreferenceEnum None = new CapacityReservationPreferenceEnum("none");
        /// <summary>
        /// Constant Open for CapacityReservationPreferenceEnum
        /// </summary>
        public static readonly CapacityReservationPreferenceEnum Open = new CapacityReservationPreferenceEnum("open");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CapacityReservationPreferenceEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CapacityReservationPreferenceEnum FindValue(string value)
        {
            return FindValue<CapacityReservationPreferenceEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CapacityReservationPreferenceEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CpuCreditsEnum.
    /// </summary>
    public class CpuCreditsEnum : ConstantClass
    {

        /// <summary>
        /// Constant Standard for CpuCreditsEnum
        /// </summary>
        public static readonly CpuCreditsEnum Standard = new CpuCreditsEnum("standard");
        /// <summary>
        /// Constant Unlimited for CpuCreditsEnum
        /// </summary>
        public static readonly CpuCreditsEnum Unlimited = new CpuCreditsEnum("unlimited");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CpuCreditsEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CpuCreditsEnum FindValue(string value)
        {
            return FindValue<CpuCreditsEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CpuCreditsEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DisassociateModeEnum.
    /// </summary>
    public class DisassociateModeEnum : ConstantClass
    {

        /// <summary>
        /// Constant FORCE for DisassociateModeEnum
        /// </summary>
        public static readonly DisassociateModeEnum FORCE = new DisassociateModeEnum("FORCE");
        /// <summary>
        /// Constant NO_FORCE for DisassociateModeEnum
        /// </summary>
        public static readonly DisassociateModeEnum NO_FORCE = new DisassociateModeEnum("NO_FORCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DisassociateModeEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DisassociateModeEnum FindValue(string value)
        {
            return FindValue<DisassociateModeEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DisassociateModeEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HostnameTypeEnum.
    /// </summary>
    public class HostnameTypeEnum : ConstantClass
    {

        /// <summary>
        /// Constant IpName for HostnameTypeEnum
        /// </summary>
        public static readonly HostnameTypeEnum IpName = new HostnameTypeEnum("ip-name");
        /// <summary>
        /// Constant ResourceName for HostnameTypeEnum
        /// </summary>
        public static readonly HostnameTypeEnum ResourceName = new HostnameTypeEnum("resource-name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HostnameTypeEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HostnameTypeEnum FindValue(string value)
        {
            return FindValue<HostnameTypeEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HostnameTypeEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HttpEndpointEnum.
    /// </summary>
    public class HttpEndpointEnum : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for HttpEndpointEnum
        /// </summary>
        public static readonly HttpEndpointEnum Disabled = new HttpEndpointEnum("disabled");
        /// <summary>
        /// Constant Enabled for HttpEndpointEnum
        /// </summary>
        public static readonly HttpEndpointEnum Enabled = new HttpEndpointEnum("enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HttpEndpointEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HttpEndpointEnum FindValue(string value)
        {
            return FindValue<HttpEndpointEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HttpEndpointEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HttpProtocolIpv6Enum.
    /// </summary>
    public class HttpProtocolIpv6Enum : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for HttpProtocolIpv6Enum
        /// </summary>
        public static readonly HttpProtocolIpv6Enum Disabled = new HttpProtocolIpv6Enum("disabled");
        /// <summary>
        /// Constant Enabled for HttpProtocolIpv6Enum
        /// </summary>
        public static readonly HttpProtocolIpv6Enum Enabled = new HttpProtocolIpv6Enum("enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HttpProtocolIpv6Enum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HttpProtocolIpv6Enum FindValue(string value)
        {
            return FindValue<HttpProtocolIpv6Enum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HttpProtocolIpv6Enum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HttpTokensEnum.
    /// </summary>
    public class HttpTokensEnum : ConstantClass
    {

        /// <summary>
        /// Constant Optional for HttpTokensEnum
        /// </summary>
        public static readonly HttpTokensEnum Optional = new HttpTokensEnum("optional");
        /// <summary>
        /// Constant Required for HttpTokensEnum
        /// </summary>
        public static readonly HttpTokensEnum Required = new HttpTokensEnum("required");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HttpTokensEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HttpTokensEnum FindValue(string value)
        {
            return FindValue<HttpTokensEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HttpTokensEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceInterruptionBehaviorEnum.
    /// </summary>
    public class InstanceInterruptionBehaviorEnum : ConstantClass
    {

        /// <summary>
        /// Constant Hibernate for InstanceInterruptionBehaviorEnum
        /// </summary>
        public static readonly InstanceInterruptionBehaviorEnum Hibernate = new InstanceInterruptionBehaviorEnum("hibernate");
        /// <summary>
        /// Constant Stop for InstanceInterruptionBehaviorEnum
        /// </summary>
        public static readonly InstanceInterruptionBehaviorEnum Stop = new InstanceInterruptionBehaviorEnum("stop");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceInterruptionBehaviorEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceInterruptionBehaviorEnum FindValue(string value)
        {
            return FindValue<InstanceInterruptionBehaviorEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceInterruptionBehaviorEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceMetadataTagsEnum.
    /// </summary>
    public class InstanceMetadataTagsEnum : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for InstanceMetadataTagsEnum
        /// </summary>
        public static readonly InstanceMetadataTagsEnum Disabled = new InstanceMetadataTagsEnum("disabled");
        /// <summary>
        /// Constant Enabled for InstanceMetadataTagsEnum
        /// </summary>
        public static readonly InstanceMetadataTagsEnum Enabled = new InstanceMetadataTagsEnum("enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceMetadataTagsEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceMetadataTagsEnum FindValue(string value)
        {
            return FindValue<InstanceMetadataTagsEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceMetadataTagsEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InterfaceTypeEnum.
    /// </summary>
    public class InterfaceTypeEnum : ConstantClass
    {

        /// <summary>
        /// Constant Efa for InterfaceTypeEnum
        /// </summary>
        public static readonly InterfaceTypeEnum Efa = new InterfaceTypeEnum("efa");
        /// <summary>
        /// Constant EfaOnly for InterfaceTypeEnum
        /// </summary>
        public static readonly InterfaceTypeEnum EfaOnly = new InterfaceTypeEnum("efa-only");
        /// <summary>
        /// Constant Interface for InterfaceTypeEnum
        /// </summary>
        public static readonly InterfaceTypeEnum Interface = new InterfaceTypeEnum("interface");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InterfaceTypeEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InterfaceTypeEnum FindValue(string value)
        {
            return FindValue<InterfaceTypeEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InterfaceTypeEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MarketTypeEnum.
    /// </summary>
    public class MarketTypeEnum : ConstantClass
    {

        /// <summary>
        /// Constant CapacityBlock for MarketTypeEnum
        /// </summary>
        public static readonly MarketTypeEnum CapacityBlock = new MarketTypeEnum("capacity-block");
        /// <summary>
        /// Constant Spot for MarketTypeEnum
        /// </summary>
        public static readonly MarketTypeEnum Spot = new MarketTypeEnum("spot");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MarketTypeEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MarketTypeEnum FindValue(string value)
        {
            return FindValue<MarketTypeEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MarketTypeEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProvisionStateEnum.
    /// </summary>
    public class ProvisionStateEnum : ConstantClass
    {

        /// <summary>
        /// Constant ALLOCATED for ProvisionStateEnum
        /// </summary>
        public static readonly ProvisionStateEnum ALLOCATED = new ProvisionStateEnum("ALLOCATED");
        /// <summary>
        /// Constant ALLOCATING for ProvisionStateEnum
        /// </summary>
        public static readonly ProvisionStateEnum ALLOCATING = new ProvisionStateEnum("ALLOCATING");
        /// <summary>
        /// Constant DEALLOCATED for ProvisionStateEnum
        /// </summary>
        public static readonly ProvisionStateEnum DEALLOCATED = new ProvisionStateEnum("DEALLOCATED");
        /// <summary>
        /// Constant DEALLOCATING for ProvisionStateEnum
        /// </summary>
        public static readonly ProvisionStateEnum DEALLOCATING = new ProvisionStateEnum("DEALLOCATING");
        /// <summary>
        /// Constant ERROR_ALLOCATING for ProvisionStateEnum
        /// </summary>
        public static readonly ProvisionStateEnum ERROR_ALLOCATING = new ProvisionStateEnum("ERROR_ALLOCATING");
        /// <summary>
        /// Constant ERROR_DEALLOCATING for ProvisionStateEnum
        /// </summary>
        public static readonly ProvisionStateEnum ERROR_DEALLOCATING = new ProvisionStateEnum("ERROR_DEALLOCATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProvisionStateEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProvisionStateEnum FindValue(string value)
        {
            return FindValue<ProvisionStateEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProvisionStateEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceTypeEnum.
    /// </summary>
    public class ResourceTypeEnum : ConstantClass
    {

        /// <summary>
        /// Constant Instance for ResourceTypeEnum
        /// </summary>
        public static readonly ResourceTypeEnum Instance = new ResourceTypeEnum("instance");
        /// <summary>
        /// Constant NetworkInterface for ResourceTypeEnum
        /// </summary>
        public static readonly ResourceTypeEnum NetworkInterface = new ResourceTypeEnum("network-interface");
        /// <summary>
        /// Constant SpotInstancesRequest for ResourceTypeEnum
        /// </summary>
        public static readonly ResourceTypeEnum SpotInstancesRequest = new ResourceTypeEnum("spot-instances-request");
        /// <summary>
        /// Constant Volume for ResourceTypeEnum
        /// </summary>
        public static readonly ResourceTypeEnum Volume = new ResourceTypeEnum("volume");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceTypeEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceTypeEnum FindValue(string value)
        {
            return FindValue<ResourceTypeEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceTypeEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SpotInstanceTypeEnum.
    /// </summary>
    public class SpotInstanceTypeEnum : ConstantClass
    {

        /// <summary>
        /// Constant OneTime for SpotInstanceTypeEnum
        /// </summary>
        public static readonly SpotInstanceTypeEnum OneTime = new SpotInstanceTypeEnum("one-time");
        /// <summary>
        /// Constant Persistent for SpotInstanceTypeEnum
        /// </summary>
        public static readonly SpotInstanceTypeEnum Persistent = new SpotInstanceTypeEnum("persistent");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SpotInstanceTypeEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SpotInstanceTypeEnum FindValue(string value)
        {
            return FindValue<SpotInstanceTypeEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SpotInstanceTypeEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TenancyEnum.
    /// </summary>
    public class TenancyEnum : ConstantClass
    {

        /// <summary>
        /// Constant Dedicated for TenancyEnum
        /// </summary>
        public static readonly TenancyEnum Dedicated = new TenancyEnum("dedicated");
        /// <summary>
        /// Constant Default for TenancyEnum
        /// </summary>
        public static readonly TenancyEnum Default = new TenancyEnum("default");
        /// <summary>
        /// Constant Host for TenancyEnum
        /// </summary>
        public static readonly TenancyEnum Host = new TenancyEnum("host");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TenancyEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TenancyEnum FindValue(string value)
        {
            return FindValue<TenancyEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TenancyEnum(string value)
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
        /// Constant DEPENDENCY_FAILURE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason DEPENDENCY_FAILURE = new ValidationExceptionReason("DEPENDENCY_FAILURE");
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
        /// Constant UNSUPPORTED_OPERATION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UNSUPPORTED_OPERATION = new ValidationExceptionReason("UNSUPPORTED_OPERATION");

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
    /// Constants used for properties of type VolumeTypeEnum.
    /// </summary>
    public class VolumeTypeEnum : ConstantClass
    {

        /// <summary>
        /// Constant Gp2 for VolumeTypeEnum
        /// </summary>
        public static readonly VolumeTypeEnum Gp2 = new VolumeTypeEnum("gp2");
        /// <summary>
        /// Constant Gp3 for VolumeTypeEnum
        /// </summary>
        public static readonly VolumeTypeEnum Gp3 = new VolumeTypeEnum("gp3");
        /// <summary>
        /// Constant Io1 for VolumeTypeEnum
        /// </summary>
        public static readonly VolumeTypeEnum Io1 = new VolumeTypeEnum("io1");
        /// <summary>
        /// Constant Io2 for VolumeTypeEnum
        /// </summary>
        public static readonly VolumeTypeEnum Io2 = new VolumeTypeEnum("io2");
        /// <summary>
        /// Constant Sc1 for VolumeTypeEnum
        /// </summary>
        public static readonly VolumeTypeEnum Sc1 = new VolumeTypeEnum("sc1");
        /// <summary>
        /// Constant St1 for VolumeTypeEnum
        /// </summary>
        public static readonly VolumeTypeEnum St1 = new VolumeTypeEnum("st1");
        /// <summary>
        /// Constant Standard for VolumeTypeEnum
        /// </summary>
        public static readonly VolumeTypeEnum Standard = new VolumeTypeEnum("standard");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VolumeTypeEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VolumeTypeEnum FindValue(string value)
        {
            return FindValue<VolumeTypeEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VolumeTypeEnum(string value)
        {
            return FindValue(value);
        }
    }

}