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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.GroundStation
{

    /// <summary>
    /// Constants used for properties of type AgentStatus.
    /// </summary>
    public class AgentStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for AgentStatus
        /// </summary>
        public static readonly AgentStatus ACTIVE = new AgentStatus("ACTIVE");
        /// <summary>
        /// Constant FAILED for AgentStatus
        /// </summary>
        public static readonly AgentStatus FAILED = new AgentStatus("FAILED");
        /// <summary>
        /// Constant INACTIVE for AgentStatus
        /// </summary>
        public static readonly AgentStatus INACTIVE = new AgentStatus("INACTIVE");
        /// <summary>
        /// Constant SUCCESS for AgentStatus
        /// </summary>
        public static readonly AgentStatus SUCCESS = new AgentStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AgentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AgentStatus FindValue(string value)
        {
            return FindValue<AgentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AgentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AngleUnits.
    /// </summary>
    public class AngleUnits : ConstantClass
    {

        /// <summary>
        /// Constant DEGREE_ANGLE for AngleUnits
        /// </summary>
        public static readonly AngleUnits DEGREE_ANGLE = new AngleUnits("DEGREE_ANGLE");
        /// <summary>
        /// Constant RADIAN for AngleUnits
        /// </summary>
        public static readonly AngleUnits RADIAN = new AngleUnits("RADIAN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AngleUnits(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AngleUnits FindValue(string value)
        {
            return FindValue<AngleUnits>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AngleUnits(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuditResults.
    /// </summary>
    public class AuditResults : ConstantClass
    {

        /// <summary>
        /// Constant HEALTHY for AuditResults
        /// </summary>
        public static readonly AuditResults HEALTHY = new AuditResults("HEALTHY");
        /// <summary>
        /// Constant UNHEALTHY for AuditResults
        /// </summary>
        public static readonly AuditResults UNHEALTHY = new AuditResults("UNHEALTHY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuditResults(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuditResults FindValue(string value)
        {
            return FindValue<AuditResults>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuditResults(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BandwidthUnits.
    /// </summary>
    public class BandwidthUnits : ConstantClass
    {

        /// <summary>
        /// Constant GHz for BandwidthUnits
        /// </summary>
        public static readonly BandwidthUnits GHz = new BandwidthUnits("GHz");
        /// <summary>
        /// Constant KHz for BandwidthUnits
        /// </summary>
        public static readonly BandwidthUnits KHz = new BandwidthUnits("kHz");
        /// <summary>
        /// Constant MHz for BandwidthUnits
        /// </summary>
        public static readonly BandwidthUnits MHz = new BandwidthUnits("MHz");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BandwidthUnits(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BandwidthUnits FindValue(string value)
        {
            return FindValue<BandwidthUnits>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BandwidthUnits(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComponentType.
    /// </summary>
    public class ComponentType : ConstantClass
    {

        /// <summary>
        /// Constant DIGITIZER for ComponentType
        /// </summary>
        public static readonly ComponentType DIGITIZER = new ComponentType("DIGITIZER");
        /// <summary>
        /// Constant LAMINAR_FLOW for ComponentType
        /// </summary>
        public static readonly ComponentType LAMINAR_FLOW = new ComponentType("LAMINAR_FLOW");
        /// <summary>
        /// Constant PRISM for ComponentType
        /// </summary>
        public static readonly ComponentType PRISM = new ComponentType("PRISM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComponentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComponentType FindValue(string value)
        {
            return FindValue<ComponentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComponentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfigCapabilityType.
    /// </summary>
    public class ConfigCapabilityType : ConstantClass
    {

        /// <summary>
        /// Constant AntennaDownlink for ConfigCapabilityType
        /// </summary>
        public static readonly ConfigCapabilityType AntennaDownlink = new ConfigCapabilityType("antenna-downlink");
        /// <summary>
        /// Constant AntennaDownlinkDemodDecode for ConfigCapabilityType
        /// </summary>
        public static readonly ConfigCapabilityType AntennaDownlinkDemodDecode = new ConfigCapabilityType("antenna-downlink-demod-decode");
        /// <summary>
        /// Constant AntennaUplink for ConfigCapabilityType
        /// </summary>
        public static readonly ConfigCapabilityType AntennaUplink = new ConfigCapabilityType("antenna-uplink");
        /// <summary>
        /// Constant DataflowEndpoint for ConfigCapabilityType
        /// </summary>
        public static readonly ConfigCapabilityType DataflowEndpoint = new ConfigCapabilityType("dataflow-endpoint");
        /// <summary>
        /// Constant S3Recording for ConfigCapabilityType
        /// </summary>
        public static readonly ConfigCapabilityType S3Recording = new ConfigCapabilityType("s3-recording");
        /// <summary>
        /// Constant Tracking for ConfigCapabilityType
        /// </summary>
        public static readonly ConfigCapabilityType Tracking = new ConfigCapabilityType("tracking");
        /// <summary>
        /// Constant UplinkEcho for ConfigCapabilityType
        /// </summary>
        public static readonly ConfigCapabilityType UplinkEcho = new ConfigCapabilityType("uplink-echo");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfigCapabilityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigCapabilityType FindValue(string value)
        {
            return FindValue<ConfigCapabilityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfigCapabilityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContactStatus.
    /// </summary>
    public class ContactStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for ContactStatus
        /// </summary>
        public static readonly ContactStatus AVAILABLE = new ContactStatus("AVAILABLE");
        /// <summary>
        /// Constant AWS_CANCELLED for ContactStatus
        /// </summary>
        public static readonly ContactStatus AWS_CANCELLED = new ContactStatus("AWS_CANCELLED");
        /// <summary>
        /// Constant AWS_FAILED for ContactStatus
        /// </summary>
        public static readonly ContactStatus AWS_FAILED = new ContactStatus("AWS_FAILED");
        /// <summary>
        /// Constant CANCELLED for ContactStatus
        /// </summary>
        public static readonly ContactStatus CANCELLED = new ContactStatus("CANCELLED");
        /// <summary>
        /// Constant CANCELLING for ContactStatus
        /// </summary>
        public static readonly ContactStatus CANCELLING = new ContactStatus("CANCELLING");
        /// <summary>
        /// Constant COMPLETED for ContactStatus
        /// </summary>
        public static readonly ContactStatus COMPLETED = new ContactStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for ContactStatus
        /// </summary>
        public static readonly ContactStatus FAILED = new ContactStatus("FAILED");
        /// <summary>
        /// Constant FAILED_TO_SCHEDULE for ContactStatus
        /// </summary>
        public static readonly ContactStatus FAILED_TO_SCHEDULE = new ContactStatus("FAILED_TO_SCHEDULE");
        /// <summary>
        /// Constant PASS for ContactStatus
        /// </summary>
        public static readonly ContactStatus PASS = new ContactStatus("PASS");
        /// <summary>
        /// Constant POSTPASS for ContactStatus
        /// </summary>
        public static readonly ContactStatus POSTPASS = new ContactStatus("POSTPASS");
        /// <summary>
        /// Constant PREPASS for ContactStatus
        /// </summary>
        public static readonly ContactStatus PREPASS = new ContactStatus("PREPASS");
        /// <summary>
        /// Constant SCHEDULED for ContactStatus
        /// </summary>
        public static readonly ContactStatus SCHEDULED = new ContactStatus("SCHEDULED");
        /// <summary>
        /// Constant SCHEDULING for ContactStatus
        /// </summary>
        public static readonly ContactStatus SCHEDULING = new ContactStatus("SCHEDULING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContactStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContactStatus FindValue(string value)
        {
            return FindValue<ContactStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContactStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Criticality.
    /// </summary>
    public class Criticality : ConstantClass
    {

        /// <summary>
        /// Constant PREFERRED for Criticality
        /// </summary>
        public static readonly Criticality PREFERRED = new Criticality("PREFERRED");
        /// <summary>
        /// Constant REMOVED for Criticality
        /// </summary>
        public static readonly Criticality REMOVED = new Criticality("REMOVED");
        /// <summary>
        /// Constant REQUIRED for Criticality
        /// </summary>
        public static readonly Criticality REQUIRED = new Criticality("REQUIRED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Criticality(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Criticality FindValue(string value)
        {
            return FindValue<Criticality>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Criticality(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EirpUnits.
    /// </summary>
    public class EirpUnits : ConstantClass
    {

        /// <summary>
        /// Constant DBW for EirpUnits
        /// </summary>
        public static readonly EirpUnits DBW = new EirpUnits("dBW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EirpUnits(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EirpUnits FindValue(string value)
        {
            return FindValue<EirpUnits>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EirpUnits(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EndpointStatus.
    /// </summary>
    public class EndpointStatus : ConstantClass
    {

        /// <summary>
        /// Constant Created for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus Created = new EndpointStatus("created");
        /// <summary>
        /// Constant Creating for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus Creating = new EndpointStatus("creating");
        /// <summary>
        /// Constant Deleted for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus Deleted = new EndpointStatus("deleted");
        /// <summary>
        /// Constant Deleting for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus Deleting = new EndpointStatus("deleting");
        /// <summary>
        /// Constant Failed for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus Failed = new EndpointStatus("failed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EndpointStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndpointStatus FindValue(string value)
        {
            return FindValue<EndpointStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndpointStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EphemerisInvalidReason.
    /// </summary>
    public class EphemerisInvalidReason : ConstantClass
    {

        /// <summary>
        /// Constant KMS_KEY_INVALID for EphemerisInvalidReason
        /// </summary>
        public static readonly EphemerisInvalidReason KMS_KEY_INVALID = new EphemerisInvalidReason("KMS_KEY_INVALID");
        /// <summary>
        /// Constant METADATA_INVALID for EphemerisInvalidReason
        /// </summary>
        public static readonly EphemerisInvalidReason METADATA_INVALID = new EphemerisInvalidReason("METADATA_INVALID");
        /// <summary>
        /// Constant TIME_RANGE_INVALID for EphemerisInvalidReason
        /// </summary>
        public static readonly EphemerisInvalidReason TIME_RANGE_INVALID = new EphemerisInvalidReason("TIME_RANGE_INVALID");
        /// <summary>
        /// Constant TRAJECTORY_INVALID for EphemerisInvalidReason
        /// </summary>
        public static readonly EphemerisInvalidReason TRAJECTORY_INVALID = new EphemerisInvalidReason("TRAJECTORY_INVALID");
        /// <summary>
        /// Constant VALIDATION_ERROR for EphemerisInvalidReason
        /// </summary>
        public static readonly EphemerisInvalidReason VALIDATION_ERROR = new EphemerisInvalidReason("VALIDATION_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EphemerisInvalidReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EphemerisInvalidReason FindValue(string value)
        {
            return FindValue<EphemerisInvalidReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EphemerisInvalidReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EphemerisSource.
    /// </summary>
    public class EphemerisSource : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOMER_PROVIDED for EphemerisSource
        /// </summary>
        public static readonly EphemerisSource CUSTOMER_PROVIDED = new EphemerisSource("CUSTOMER_PROVIDED");
        /// <summary>
        /// Constant SPACE_TRACK for EphemerisSource
        /// </summary>
        public static readonly EphemerisSource SPACE_TRACK = new EphemerisSource("SPACE_TRACK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EphemerisSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EphemerisSource FindValue(string value)
        {
            return FindValue<EphemerisSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EphemerisSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EphemerisStatus.
    /// </summary>
    public class EphemerisStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for EphemerisStatus
        /// </summary>
        public static readonly EphemerisStatus DISABLED = new EphemerisStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for EphemerisStatus
        /// </summary>
        public static readonly EphemerisStatus ENABLED = new EphemerisStatus("ENABLED");
        /// <summary>
        /// Constant ERROR for EphemerisStatus
        /// </summary>
        public static readonly EphemerisStatus ERROR = new EphemerisStatus("ERROR");
        /// <summary>
        /// Constant EXPIRED for EphemerisStatus
        /// </summary>
        public static readonly EphemerisStatus EXPIRED = new EphemerisStatus("EXPIRED");
        /// <summary>
        /// Constant INVALID for EphemerisStatus
        /// </summary>
        public static readonly EphemerisStatus INVALID = new EphemerisStatus("INVALID");
        /// <summary>
        /// Constant VALIDATING for EphemerisStatus
        /// </summary>
        public static readonly EphemerisStatus VALIDATING = new EphemerisStatus("VALIDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EphemerisStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EphemerisStatus FindValue(string value)
        {
            return FindValue<EphemerisStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EphemerisStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FrequencyUnits.
    /// </summary>
    public class FrequencyUnits : ConstantClass
    {

        /// <summary>
        /// Constant GHz for FrequencyUnits
        /// </summary>
        public static readonly FrequencyUnits GHz = new FrequencyUnits("GHz");
        /// <summary>
        /// Constant KHz for FrequencyUnits
        /// </summary>
        public static readonly FrequencyUnits KHz = new FrequencyUnits("kHz");
        /// <summary>
        /// Constant MHz for FrequencyUnits
        /// </summary>
        public static readonly FrequencyUnits MHz = new FrequencyUnits("MHz");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FrequencyUnits(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FrequencyUnits FindValue(string value)
        {
            return FindValue<FrequencyUnits>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FrequencyUnits(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Polarization.
    /// </summary>
    public class Polarization : ConstantClass
    {

        /// <summary>
        /// Constant LEFT_HAND for Polarization
        /// </summary>
        public static readonly Polarization LEFT_HAND = new Polarization("LEFT_HAND");
        /// <summary>
        /// Constant NONE for Polarization
        /// </summary>
        public static readonly Polarization NONE = new Polarization("NONE");
        /// <summary>
        /// Constant RIGHT_HAND for Polarization
        /// </summary>
        public static readonly Polarization RIGHT_HAND = new Polarization("RIGHT_HAND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Polarization(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Polarization FindValue(string value)
        {
            return FindValue<Polarization>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Polarization(string value)
        {
            return FindValue(value);
        }
    }

}