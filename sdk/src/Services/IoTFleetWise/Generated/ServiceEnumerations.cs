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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.IoTFleetWise
{

    /// <summary>
    /// Constants used for properties of type CampaignStatus.
    /// </summary>
    public class CampaignStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATING for CampaignStatus
        /// </summary>
        public static readonly CampaignStatus CREATING = new CampaignStatus("CREATING");
        /// <summary>
        /// Constant RUNNING for CampaignStatus
        /// </summary>
        public static readonly CampaignStatus RUNNING = new CampaignStatus("RUNNING");
        /// <summary>
        /// Constant SUSPENDED for CampaignStatus
        /// </summary>
        public static readonly CampaignStatus SUSPENDED = new CampaignStatus("SUSPENDED");
        /// <summary>
        /// Constant WAITING_FOR_APPROVAL for CampaignStatus
        /// </summary>
        public static readonly CampaignStatus WAITING_FOR_APPROVAL = new CampaignStatus("WAITING_FOR_APPROVAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CampaignStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CampaignStatus FindValue(string value)
        {
            return FindValue<CampaignStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CampaignStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Compression.
    /// </summary>
    public class Compression : ConstantClass
    {

        /// <summary>
        /// Constant OFF for Compression
        /// </summary>
        public static readonly Compression OFF = new Compression("OFF");
        /// <summary>
        /// Constant SNAPPY for Compression
        /// </summary>
        public static readonly Compression SNAPPY = new Compression("SNAPPY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Compression(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Compression FindValue(string value)
        {
            return FindValue<Compression>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Compression(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataFormat.
    /// </summary>
    public class DataFormat : ConstantClass
    {

        /// <summary>
        /// Constant JSON for DataFormat
        /// </summary>
        public static readonly DataFormat JSON = new DataFormat("JSON");
        /// <summary>
        /// Constant PARQUET for DataFormat
        /// </summary>
        public static readonly DataFormat PARQUET = new DataFormat("PARQUET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataFormat FindValue(string value)
        {
            return FindValue<DataFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DefaultForUnmappedSignalsType.
    /// </summary>
    public class DefaultForUnmappedSignalsType : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOM_DECODING for DefaultForUnmappedSignalsType
        /// </summary>
        public static readonly DefaultForUnmappedSignalsType CUSTOM_DECODING = new DefaultForUnmappedSignalsType("CUSTOM_DECODING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DefaultForUnmappedSignalsType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DefaultForUnmappedSignalsType FindValue(string value)
        {
            return FindValue<DefaultForUnmappedSignalsType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DefaultForUnmappedSignalsType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DiagnosticsMode.
    /// </summary>
    public class DiagnosticsMode : ConstantClass
    {

        /// <summary>
        /// Constant OFF for DiagnosticsMode
        /// </summary>
        public static readonly DiagnosticsMode OFF = new DiagnosticsMode("OFF");
        /// <summary>
        /// Constant SEND_ACTIVE_DTCS for DiagnosticsMode
        /// </summary>
        public static readonly DiagnosticsMode SEND_ACTIVE_DTCS = new DiagnosticsMode("SEND_ACTIVE_DTCS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DiagnosticsMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DiagnosticsMode FindValue(string value)
        {
            return FindValue<DiagnosticsMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DiagnosticsMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncryptionStatus.
    /// </summary>
    public class EncryptionStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILURE for EncryptionStatus
        /// </summary>
        public static readonly EncryptionStatus FAILURE = new EncryptionStatus("FAILURE");
        /// <summary>
        /// Constant PENDING for EncryptionStatus
        /// </summary>
        public static readonly EncryptionStatus PENDING = new EncryptionStatus("PENDING");
        /// <summary>
        /// Constant SUCCESS for EncryptionStatus
        /// </summary>
        public static readonly EncryptionStatus SUCCESS = new EncryptionStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionStatus FindValue(string value)
        {
            return FindValue<EncryptionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncryptionType.
    /// </summary>
    public class EncryptionType : ConstantClass
    {

        /// <summary>
        /// Constant FLEETWISE_DEFAULT_ENCRYPTION for EncryptionType
        /// </summary>
        public static readonly EncryptionType FLEETWISE_DEFAULT_ENCRYPTION = new EncryptionType("FLEETWISE_DEFAULT_ENCRYPTION");
        /// <summary>
        /// Constant KMS_BASED_ENCRYPTION for EncryptionType
        /// </summary>
        public static readonly EncryptionType KMS_BASED_ENCRYPTION = new EncryptionType("KMS_BASED_ENCRYPTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionType FindValue(string value)
        {
            return FindValue<EncryptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListResponseScope.
    /// </summary>
    public class ListResponseScope : ConstantClass
    {

        /// <summary>
        /// Constant METADATA_ONLY for ListResponseScope
        /// </summary>
        public static readonly ListResponseScope METADATA_ONLY = new ListResponseScope("METADATA_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListResponseScope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListResponseScope FindValue(string value)
        {
            return FindValue<ListResponseScope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListResponseScope(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogType.
    /// </summary>
    public class LogType : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for LogType
        /// </summary>
        public static readonly LogType ERROR = new LogType("ERROR");
        /// <summary>
        /// Constant OFF for LogType
        /// </summary>
        public static readonly LogType OFF = new LogType("OFF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogType FindValue(string value)
        {
            return FindValue<LogType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ManifestStatus.
    /// </summary>
    public class ManifestStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ManifestStatus
        /// </summary>
        public static readonly ManifestStatus ACTIVE = new ManifestStatus("ACTIVE");
        /// <summary>
        /// Constant DRAFT for ManifestStatus
        /// </summary>
        public static readonly ManifestStatus DRAFT = new ManifestStatus("DRAFT");
        /// <summary>
        /// Constant INVALID for ManifestStatus
        /// </summary>
        public static readonly ManifestStatus INVALID = new ManifestStatus("INVALID");
        /// <summary>
        /// Constant VALIDATING for ManifestStatus
        /// </summary>
        public static readonly ManifestStatus VALIDATING = new ManifestStatus("VALIDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ManifestStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ManifestStatus FindValue(string value)
        {
            return FindValue<ManifestStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ManifestStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkInterfaceFailureReason.
    /// </summary>
    public class NetworkInterfaceFailureReason : ConstantClass
    {

        /// <summary>
        /// Constant CAN_NETWORK_INTERFACE_INFO_IS_NULL for NetworkInterfaceFailureReason
        /// </summary>
        public static readonly NetworkInterfaceFailureReason CAN_NETWORK_INTERFACE_INFO_IS_NULL = new NetworkInterfaceFailureReason("CAN_NETWORK_INTERFACE_INFO_IS_NULL");
        /// <summary>
        /// Constant CONFLICTING_NETWORK_INTERFACE for NetworkInterfaceFailureReason
        /// </summary>
        public static readonly NetworkInterfaceFailureReason CONFLICTING_NETWORK_INTERFACE = new NetworkInterfaceFailureReason("CONFLICTING_NETWORK_INTERFACE");
        /// <summary>
        /// Constant CUSTOM_DECODING_SIGNAL_NETWORK_INTERFACE_INFO_IS_NULL for NetworkInterfaceFailureReason
        /// </summary>
        public static readonly NetworkInterfaceFailureReason CUSTOM_DECODING_SIGNAL_NETWORK_INTERFACE_INFO_IS_NULL = new NetworkInterfaceFailureReason("CUSTOM_DECODING_SIGNAL_NETWORK_INTERFACE_INFO_IS_NULL");
        /// <summary>
        /// Constant DUPLICATE_NETWORK_INTERFACE for NetworkInterfaceFailureReason
        /// </summary>
        public static readonly NetworkInterfaceFailureReason DUPLICATE_NETWORK_INTERFACE = new NetworkInterfaceFailureReason("DUPLICATE_NETWORK_INTERFACE");
        /// <summary>
        /// Constant NETWORK_INTERFACE_TO_ADD_ALREADY_EXISTS for NetworkInterfaceFailureReason
        /// </summary>
        public static readonly NetworkInterfaceFailureReason NETWORK_INTERFACE_TO_ADD_ALREADY_EXISTS = new NetworkInterfaceFailureReason("NETWORK_INTERFACE_TO_ADD_ALREADY_EXISTS");
        /// <summary>
        /// Constant NETWORK_INTERFACE_TO_REMOVE_ASSOCIATED_WITH_SIGNALS for NetworkInterfaceFailureReason
        /// </summary>
        public static readonly NetworkInterfaceFailureReason NETWORK_INTERFACE_TO_REMOVE_ASSOCIATED_WITH_SIGNALS = new NetworkInterfaceFailureReason("NETWORK_INTERFACE_TO_REMOVE_ASSOCIATED_WITH_SIGNALS");
        /// <summary>
        /// Constant OBD_NETWORK_INTERFACE_INFO_IS_NULL for NetworkInterfaceFailureReason
        /// </summary>
        public static readonly NetworkInterfaceFailureReason OBD_NETWORK_INTERFACE_INFO_IS_NULL = new NetworkInterfaceFailureReason("OBD_NETWORK_INTERFACE_INFO_IS_NULL");
        /// <summary>
        /// Constant VEHICLE_MIDDLEWARE_NETWORK_INTERFACE_INFO_IS_NULL for NetworkInterfaceFailureReason
        /// </summary>
        public static readonly NetworkInterfaceFailureReason VEHICLE_MIDDLEWARE_NETWORK_INTERFACE_INFO_IS_NULL = new NetworkInterfaceFailureReason("VEHICLE_MIDDLEWARE_NETWORK_INTERFACE_INFO_IS_NULL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkInterfaceFailureReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkInterfaceFailureReason FindValue(string value)
        {
            return FindValue<NetworkInterfaceFailureReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkInterfaceFailureReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkInterfaceType.
    /// </summary>
    public class NetworkInterfaceType : ConstantClass
    {

        /// <summary>
        /// Constant CAN_INTERFACE for NetworkInterfaceType
        /// </summary>
        public static readonly NetworkInterfaceType CAN_INTERFACE = new NetworkInterfaceType("CAN_INTERFACE");
        /// <summary>
        /// Constant CUSTOM_DECODING_INTERFACE for NetworkInterfaceType
        /// </summary>
        public static readonly NetworkInterfaceType CUSTOM_DECODING_INTERFACE = new NetworkInterfaceType("CUSTOM_DECODING_INTERFACE");
        /// <summary>
        /// Constant OBD_INTERFACE for NetworkInterfaceType
        /// </summary>
        public static readonly NetworkInterfaceType OBD_INTERFACE = new NetworkInterfaceType("OBD_INTERFACE");
        /// <summary>
        /// Constant VEHICLE_MIDDLEWARE for NetworkInterfaceType
        /// </summary>
        public static readonly NetworkInterfaceType VEHICLE_MIDDLEWARE = new NetworkInterfaceType("VEHICLE_MIDDLEWARE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkInterfaceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkInterfaceType FindValue(string value)
        {
            return FindValue<NetworkInterfaceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkInterfaceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NodeDataEncoding.
    /// </summary>
    public class NodeDataEncoding : ConstantClass
    {

        /// <summary>
        /// Constant BINARY for NodeDataEncoding
        /// </summary>
        public static readonly NodeDataEncoding BINARY = new NodeDataEncoding("BINARY");
        /// <summary>
        /// Constant TYPED for NodeDataEncoding
        /// </summary>
        public static readonly NodeDataEncoding TYPED = new NodeDataEncoding("TYPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NodeDataEncoding(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NodeDataEncoding FindValue(string value)
        {
            return FindValue<NodeDataEncoding>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NodeDataEncoding(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NodeDataType.
    /// </summary>
    public class NodeDataType : ConstantClass
    {

        /// <summary>
        /// Constant BOOLEAN for NodeDataType
        /// </summary>
        public static readonly NodeDataType BOOLEAN = new NodeDataType("BOOLEAN");
        /// <summary>
        /// Constant BOOLEAN_ARRAY for NodeDataType
        /// </summary>
        public static readonly NodeDataType BOOLEAN_ARRAY = new NodeDataType("BOOLEAN_ARRAY");
        /// <summary>
        /// Constant DOUBLE for NodeDataType
        /// </summary>
        public static readonly NodeDataType DOUBLE = new NodeDataType("DOUBLE");
        /// <summary>
        /// Constant DOUBLE_ARRAY for NodeDataType
        /// </summary>
        public static readonly NodeDataType DOUBLE_ARRAY = new NodeDataType("DOUBLE_ARRAY");
        /// <summary>
        /// Constant FLOAT for NodeDataType
        /// </summary>
        public static readonly NodeDataType FLOAT = new NodeDataType("FLOAT");
        /// <summary>
        /// Constant FLOAT_ARRAY for NodeDataType
        /// </summary>
        public static readonly NodeDataType FLOAT_ARRAY = new NodeDataType("FLOAT_ARRAY");
        /// <summary>
        /// Constant INT16 for NodeDataType
        /// </summary>
        public static readonly NodeDataType INT16 = new NodeDataType("INT16");
        /// <summary>
        /// Constant INT16_ARRAY for NodeDataType
        /// </summary>
        public static readonly NodeDataType INT16_ARRAY = new NodeDataType("INT16_ARRAY");
        /// <summary>
        /// Constant INT32 for NodeDataType
        /// </summary>
        public static readonly NodeDataType INT32 = new NodeDataType("INT32");
        /// <summary>
        /// Constant INT32_ARRAY for NodeDataType
        /// </summary>
        public static readonly NodeDataType INT32_ARRAY = new NodeDataType("INT32_ARRAY");
        /// <summary>
        /// Constant INT64 for NodeDataType
        /// </summary>
        public static readonly NodeDataType INT64 = new NodeDataType("INT64");
        /// <summary>
        /// Constant INT64_ARRAY for NodeDataType
        /// </summary>
        public static readonly NodeDataType INT64_ARRAY = new NodeDataType("INT64_ARRAY");
        /// <summary>
        /// Constant INT8 for NodeDataType
        /// </summary>
        public static readonly NodeDataType INT8 = new NodeDataType("INT8");
        /// <summary>
        /// Constant INT8_ARRAY for NodeDataType
        /// </summary>
        public static readonly NodeDataType INT8_ARRAY = new NodeDataType("INT8_ARRAY");
        /// <summary>
        /// Constant STRING for NodeDataType
        /// </summary>
        public static readonly NodeDataType STRING = new NodeDataType("STRING");
        /// <summary>
        /// Constant STRING_ARRAY for NodeDataType
        /// </summary>
        public static readonly NodeDataType STRING_ARRAY = new NodeDataType("STRING_ARRAY");
        /// <summary>
        /// Constant STRUCT for NodeDataType
        /// </summary>
        public static readonly NodeDataType STRUCT = new NodeDataType("STRUCT");
        /// <summary>
        /// Constant STRUCT_ARRAY for NodeDataType
        /// </summary>
        public static readonly NodeDataType STRUCT_ARRAY = new NodeDataType("STRUCT_ARRAY");
        /// <summary>
        /// Constant UINT16 for NodeDataType
        /// </summary>
        public static readonly NodeDataType UINT16 = new NodeDataType("UINT16");
        /// <summary>
        /// Constant UINT16_ARRAY for NodeDataType
        /// </summary>
        public static readonly NodeDataType UINT16_ARRAY = new NodeDataType("UINT16_ARRAY");
        /// <summary>
        /// Constant UINT32 for NodeDataType
        /// </summary>
        public static readonly NodeDataType UINT32 = new NodeDataType("UINT32");
        /// <summary>
        /// Constant UINT32_ARRAY for NodeDataType
        /// </summary>
        public static readonly NodeDataType UINT32_ARRAY = new NodeDataType("UINT32_ARRAY");
        /// <summary>
        /// Constant UINT64 for NodeDataType
        /// </summary>
        public static readonly NodeDataType UINT64 = new NodeDataType("UINT64");
        /// <summary>
        /// Constant UINT64_ARRAY for NodeDataType
        /// </summary>
        public static readonly NodeDataType UINT64_ARRAY = new NodeDataType("UINT64_ARRAY");
        /// <summary>
        /// Constant UINT8 for NodeDataType
        /// </summary>
        public static readonly NodeDataType UINT8 = new NodeDataType("UINT8");
        /// <summary>
        /// Constant UINT8_ARRAY for NodeDataType
        /// </summary>
        public static readonly NodeDataType UINT8_ARRAY = new NodeDataType("UINT8_ARRAY");
        /// <summary>
        /// Constant UNIX_TIMESTAMP for NodeDataType
        /// </summary>
        public static readonly NodeDataType UNIX_TIMESTAMP = new NodeDataType("UNIX_TIMESTAMP");
        /// <summary>
        /// Constant UNIX_TIMESTAMP_ARRAY for NodeDataType
        /// </summary>
        public static readonly NodeDataType UNIX_TIMESTAMP_ARRAY = new NodeDataType("UNIX_TIMESTAMP_ARRAY");
        /// <summary>
        /// Constant UNKNOWN for NodeDataType
        /// </summary>
        public static readonly NodeDataType UNKNOWN = new NodeDataType("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NodeDataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NodeDataType FindValue(string value)
        {
            return FindValue<NodeDataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NodeDataType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegistrationStatus.
    /// </summary>
    public class RegistrationStatus : ConstantClass
    {

        /// <summary>
        /// Constant REGISTRATION_FAILURE for RegistrationStatus
        /// </summary>
        public static readonly RegistrationStatus REGISTRATION_FAILURE = new RegistrationStatus("REGISTRATION_FAILURE");
        /// <summary>
        /// Constant REGISTRATION_PENDING for RegistrationStatus
        /// </summary>
        public static readonly RegistrationStatus REGISTRATION_PENDING = new RegistrationStatus("REGISTRATION_PENDING");
        /// <summary>
        /// Constant REGISTRATION_SUCCESS for RegistrationStatus
        /// </summary>
        public static readonly RegistrationStatus REGISTRATION_SUCCESS = new RegistrationStatus("REGISTRATION_SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegistrationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegistrationStatus FindValue(string value)
        {
            return FindValue<RegistrationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegistrationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ROS2PrimitiveType.
    /// </summary>
    public class ROS2PrimitiveType : ConstantClass
    {

        /// <summary>
        /// Constant BOOL for ROS2PrimitiveType
        /// </summary>
        public static readonly ROS2PrimitiveType BOOL = new ROS2PrimitiveType("BOOL");
        /// <summary>
        /// Constant BYTE for ROS2PrimitiveType
        /// </summary>
        public static readonly ROS2PrimitiveType BYTE = new ROS2PrimitiveType("BYTE");
        /// <summary>
        /// Constant CHAR for ROS2PrimitiveType
        /// </summary>
        public static readonly ROS2PrimitiveType CHAR = new ROS2PrimitiveType("CHAR");
        /// <summary>
        /// Constant FLOAT32 for ROS2PrimitiveType
        /// </summary>
        public static readonly ROS2PrimitiveType FLOAT32 = new ROS2PrimitiveType("FLOAT32");
        /// <summary>
        /// Constant FLOAT64 for ROS2PrimitiveType
        /// </summary>
        public static readonly ROS2PrimitiveType FLOAT64 = new ROS2PrimitiveType("FLOAT64");
        /// <summary>
        /// Constant INT16 for ROS2PrimitiveType
        /// </summary>
        public static readonly ROS2PrimitiveType INT16 = new ROS2PrimitiveType("INT16");
        /// <summary>
        /// Constant INT32 for ROS2PrimitiveType
        /// </summary>
        public static readonly ROS2PrimitiveType INT32 = new ROS2PrimitiveType("INT32");
        /// <summary>
        /// Constant INT64 for ROS2PrimitiveType
        /// </summary>
        public static readonly ROS2PrimitiveType INT64 = new ROS2PrimitiveType("INT64");
        /// <summary>
        /// Constant INT8 for ROS2PrimitiveType
        /// </summary>
        public static readonly ROS2PrimitiveType INT8 = new ROS2PrimitiveType("INT8");
        /// <summary>
        /// Constant STRING for ROS2PrimitiveType
        /// </summary>
        public static readonly ROS2PrimitiveType STRING = new ROS2PrimitiveType("STRING");
        /// <summary>
        /// Constant UINT16 for ROS2PrimitiveType
        /// </summary>
        public static readonly ROS2PrimitiveType UINT16 = new ROS2PrimitiveType("UINT16");
        /// <summary>
        /// Constant UINT32 for ROS2PrimitiveType
        /// </summary>
        public static readonly ROS2PrimitiveType UINT32 = new ROS2PrimitiveType("UINT32");
        /// <summary>
        /// Constant UINT64 for ROS2PrimitiveType
        /// </summary>
        public static readonly ROS2PrimitiveType UINT64 = new ROS2PrimitiveType("UINT64");
        /// <summary>
        /// Constant UINT8 for ROS2PrimitiveType
        /// </summary>
        public static readonly ROS2PrimitiveType UINT8 = new ROS2PrimitiveType("UINT8");
        /// <summary>
        /// Constant WSTRING for ROS2PrimitiveType
        /// </summary>
        public static readonly ROS2PrimitiveType WSTRING = new ROS2PrimitiveType("WSTRING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ROS2PrimitiveType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ROS2PrimitiveType FindValue(string value)
        {
            return FindValue<ROS2PrimitiveType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ROS2PrimitiveType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SignalDecoderFailureReason.
    /// </summary>
    public class SignalDecoderFailureReason : ConstantClass
    {

        /// <summary>
        /// Constant CAN_SIGNAL_INFO_IS_NULL for SignalDecoderFailureReason
        /// </summary>
        public static readonly SignalDecoderFailureReason CAN_SIGNAL_INFO_IS_NULL = new SignalDecoderFailureReason("CAN_SIGNAL_INFO_IS_NULL");
        /// <summary>
        /// Constant CONFLICTING_SIGNAL for SignalDecoderFailureReason
        /// </summary>
        public static readonly SignalDecoderFailureReason CONFLICTING_SIGNAL = new SignalDecoderFailureReason("CONFLICTING_SIGNAL");
        /// <summary>
        /// Constant CUSTOM_DECODING_SIGNAL_INFO_IS_NULL for SignalDecoderFailureReason
        /// </summary>
        public static readonly SignalDecoderFailureReason CUSTOM_DECODING_SIGNAL_INFO_IS_NULL = new SignalDecoderFailureReason("CUSTOM_DECODING_SIGNAL_INFO_IS_NULL");
        /// <summary>
        /// Constant DUPLICATE_SIGNAL for SignalDecoderFailureReason
        /// </summary>
        public static readonly SignalDecoderFailureReason DUPLICATE_SIGNAL = new SignalDecoderFailureReason("DUPLICATE_SIGNAL");
        /// <summary>
        /// Constant EMPTY_MESSAGE_SIGNAL for SignalDecoderFailureReason
        /// </summary>
        public static readonly SignalDecoderFailureReason EMPTY_MESSAGE_SIGNAL = new SignalDecoderFailureReason("EMPTY_MESSAGE_SIGNAL");
        /// <summary>
        /// Constant MESSAGE_SIGNAL_INFO_IS_NULL for SignalDecoderFailureReason
        /// </summary>
        public static readonly SignalDecoderFailureReason MESSAGE_SIGNAL_INFO_IS_NULL = new SignalDecoderFailureReason("MESSAGE_SIGNAL_INFO_IS_NULL");
        /// <summary>
        /// Constant NETWORK_INTERFACE_TYPE_INCOMPATIBLE_WITH_SIGNAL_DECODER_TYPE for SignalDecoderFailureReason
        /// </summary>
        public static readonly SignalDecoderFailureReason NETWORK_INTERFACE_TYPE_INCOMPATIBLE_WITH_SIGNAL_DECODER_TYPE = new SignalDecoderFailureReason("NETWORK_INTERFACE_TYPE_INCOMPATIBLE_WITH_SIGNAL_DECODER_TYPE");
        /// <summary>
        /// Constant NO_DECODER_INFO_FOR_SIGNAL_IN_MODEL for SignalDecoderFailureReason
        /// </summary>
        public static readonly SignalDecoderFailureReason NO_DECODER_INFO_FOR_SIGNAL_IN_MODEL = new SignalDecoderFailureReason("NO_DECODER_INFO_FOR_SIGNAL_IN_MODEL");
        /// <summary>
        /// Constant NO_SIGNAL_IN_CATALOG_FOR_DECODER_SIGNAL for SignalDecoderFailureReason
        /// </summary>
        public static readonly SignalDecoderFailureReason NO_SIGNAL_IN_CATALOG_FOR_DECODER_SIGNAL = new SignalDecoderFailureReason("NO_SIGNAL_IN_CATALOG_FOR_DECODER_SIGNAL");
        /// <summary>
        /// Constant OBD_SIGNAL_INFO_IS_NULL for SignalDecoderFailureReason
        /// </summary>
        public static readonly SignalDecoderFailureReason OBD_SIGNAL_INFO_IS_NULL = new SignalDecoderFailureReason("OBD_SIGNAL_INFO_IS_NULL");
        /// <summary>
        /// Constant SIGNAL_DECODER_INCOMPATIBLE_WITH_SIGNAL_CATALOG for SignalDecoderFailureReason
        /// </summary>
        public static readonly SignalDecoderFailureReason SIGNAL_DECODER_INCOMPATIBLE_WITH_SIGNAL_CATALOG = new SignalDecoderFailureReason("SIGNAL_DECODER_INCOMPATIBLE_WITH_SIGNAL_CATALOG");
        /// <summary>
        /// Constant SIGNAL_DECODER_TYPE_INCOMPATIBLE_WITH_MESSAGE_SIGNAL_TYPE for SignalDecoderFailureReason
        /// </summary>
        public static readonly SignalDecoderFailureReason SIGNAL_DECODER_TYPE_INCOMPATIBLE_WITH_MESSAGE_SIGNAL_TYPE = new SignalDecoderFailureReason("SIGNAL_DECODER_TYPE_INCOMPATIBLE_WITH_MESSAGE_SIGNAL_TYPE");
        /// <summary>
        /// Constant SIGNAL_NOT_ASSOCIATED_WITH_NETWORK_INTERFACE for SignalDecoderFailureReason
        /// </summary>
        public static readonly SignalDecoderFailureReason SIGNAL_NOT_ASSOCIATED_WITH_NETWORK_INTERFACE = new SignalDecoderFailureReason("SIGNAL_NOT_ASSOCIATED_WITH_NETWORK_INTERFACE");
        /// <summary>
        /// Constant SIGNAL_NOT_IN_MODEL for SignalDecoderFailureReason
        /// </summary>
        public static readonly SignalDecoderFailureReason SIGNAL_NOT_IN_MODEL = new SignalDecoderFailureReason("SIGNAL_NOT_IN_MODEL");
        /// <summary>
        /// Constant SIGNAL_TO_ADD_ALREADY_EXISTS for SignalDecoderFailureReason
        /// </summary>
        public static readonly SignalDecoderFailureReason SIGNAL_TO_ADD_ALREADY_EXISTS = new SignalDecoderFailureReason("SIGNAL_TO_ADD_ALREADY_EXISTS");
        /// <summary>
        /// Constant STRUCT_SIZE_MISMATCH for SignalDecoderFailureReason
        /// </summary>
        public static readonly SignalDecoderFailureReason STRUCT_SIZE_MISMATCH = new SignalDecoderFailureReason("STRUCT_SIZE_MISMATCH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SignalDecoderFailureReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SignalDecoderFailureReason FindValue(string value)
        {
            return FindValue<SignalDecoderFailureReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SignalDecoderFailureReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SignalDecoderType.
    /// </summary>
    public class SignalDecoderType : ConstantClass
    {

        /// <summary>
        /// Constant CAN_SIGNAL for SignalDecoderType
        /// </summary>
        public static readonly SignalDecoderType CAN_SIGNAL = new SignalDecoderType("CAN_SIGNAL");
        /// <summary>
        /// Constant CUSTOM_DECODING_SIGNAL for SignalDecoderType
        /// </summary>
        public static readonly SignalDecoderType CUSTOM_DECODING_SIGNAL = new SignalDecoderType("CUSTOM_DECODING_SIGNAL");
        /// <summary>
        /// Constant MESSAGE_SIGNAL for SignalDecoderType
        /// </summary>
        public static readonly SignalDecoderType MESSAGE_SIGNAL = new SignalDecoderType("MESSAGE_SIGNAL");
        /// <summary>
        /// Constant OBD_SIGNAL for SignalDecoderType
        /// </summary>
        public static readonly SignalDecoderType OBD_SIGNAL = new SignalDecoderType("OBD_SIGNAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SignalDecoderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SignalDecoderType FindValue(string value)
        {
            return FindValue<SignalDecoderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SignalDecoderType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SignalNodeType.
    /// </summary>
    public class SignalNodeType : ConstantClass
    {

        /// <summary>
        /// Constant ACTUATOR for SignalNodeType
        /// </summary>
        public static readonly SignalNodeType ACTUATOR = new SignalNodeType("ACTUATOR");
        /// <summary>
        /// Constant ATTRIBUTE for SignalNodeType
        /// </summary>
        public static readonly SignalNodeType ATTRIBUTE = new SignalNodeType("ATTRIBUTE");
        /// <summary>
        /// Constant BRANCH for SignalNodeType
        /// </summary>
        public static readonly SignalNodeType BRANCH = new SignalNodeType("BRANCH");
        /// <summary>
        /// Constant CUSTOM_PROPERTY for SignalNodeType
        /// </summary>
        public static readonly SignalNodeType CUSTOM_PROPERTY = new SignalNodeType("CUSTOM_PROPERTY");
        /// <summary>
        /// Constant CUSTOM_STRUCT for SignalNodeType
        /// </summary>
        public static readonly SignalNodeType CUSTOM_STRUCT = new SignalNodeType("CUSTOM_STRUCT");
        /// <summary>
        /// Constant SENSOR for SignalNodeType
        /// </summary>
        public static readonly SignalNodeType SENSOR = new SignalNodeType("SENSOR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SignalNodeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SignalNodeType FindValue(string value)
        {
            return FindValue<SignalNodeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SignalNodeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SignalValueType.
    /// </summary>
    public class SignalValueType : ConstantClass
    {

        /// <summary>
        /// Constant FLOATING_POINT for SignalValueType
        /// </summary>
        public static readonly SignalValueType FLOATING_POINT = new SignalValueType("FLOATING_POINT");
        /// <summary>
        /// Constant INTEGER for SignalValueType
        /// </summary>
        public static readonly SignalValueType INTEGER = new SignalValueType("INTEGER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SignalValueType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SignalValueType FindValue(string value)
        {
            return FindValue<SignalValueType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SignalValueType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SpoolingMode.
    /// </summary>
    public class SpoolingMode : ConstantClass
    {

        /// <summary>
        /// Constant OFF for SpoolingMode
        /// </summary>
        public static readonly SpoolingMode OFF = new SpoolingMode("OFF");
        /// <summary>
        /// Constant TO_DISK for SpoolingMode
        /// </summary>
        public static readonly SpoolingMode TO_DISK = new SpoolingMode("TO_DISK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SpoolingMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SpoolingMode FindValue(string value)
        {
            return FindValue<SpoolingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SpoolingMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StorageCompressionFormat.
    /// </summary>
    public class StorageCompressionFormat : ConstantClass
    {

        /// <summary>
        /// Constant GZIP for StorageCompressionFormat
        /// </summary>
        public static readonly StorageCompressionFormat GZIP = new StorageCompressionFormat("GZIP");
        /// <summary>
        /// Constant NONE for StorageCompressionFormat
        /// </summary>
        public static readonly StorageCompressionFormat NONE = new StorageCompressionFormat("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StorageCompressionFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageCompressionFormat FindValue(string value)
        {
            return FindValue<StorageCompressionFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageCompressionFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StorageMaximumSizeUnit.
    /// </summary>
    public class StorageMaximumSizeUnit : ConstantClass
    {

        /// <summary>
        /// Constant GB for StorageMaximumSizeUnit
        /// </summary>
        public static readonly StorageMaximumSizeUnit GB = new StorageMaximumSizeUnit("GB");
        /// <summary>
        /// Constant MB for StorageMaximumSizeUnit
        /// </summary>
        public static readonly StorageMaximumSizeUnit MB = new StorageMaximumSizeUnit("MB");
        /// <summary>
        /// Constant TB for StorageMaximumSizeUnit
        /// </summary>
        public static readonly StorageMaximumSizeUnit TB = new StorageMaximumSizeUnit("TB");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StorageMaximumSizeUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageMaximumSizeUnit FindValue(string value)
        {
            return FindValue<StorageMaximumSizeUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageMaximumSizeUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StorageMinimumTimeToLiveUnit.
    /// </summary>
    public class StorageMinimumTimeToLiveUnit : ConstantClass
    {

        /// <summary>
        /// Constant DAYS for StorageMinimumTimeToLiveUnit
        /// </summary>
        public static readonly StorageMinimumTimeToLiveUnit DAYS = new StorageMinimumTimeToLiveUnit("DAYS");
        /// <summary>
        /// Constant HOURS for StorageMinimumTimeToLiveUnit
        /// </summary>
        public static readonly StorageMinimumTimeToLiveUnit HOURS = new StorageMinimumTimeToLiveUnit("HOURS");
        /// <summary>
        /// Constant WEEKS for StorageMinimumTimeToLiveUnit
        /// </summary>
        public static readonly StorageMinimumTimeToLiveUnit WEEKS = new StorageMinimumTimeToLiveUnit("WEEKS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StorageMinimumTimeToLiveUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageMinimumTimeToLiveUnit FindValue(string value)
        {
            return FindValue<StorageMinimumTimeToLiveUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageMinimumTimeToLiveUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StructuredMessageListType.
    /// </summary>
    public class StructuredMessageListType : ConstantClass
    {

        /// <summary>
        /// Constant DYNAMIC_BOUNDED_CAPACITY for StructuredMessageListType
        /// </summary>
        public static readonly StructuredMessageListType DYNAMIC_BOUNDED_CAPACITY = new StructuredMessageListType("DYNAMIC_BOUNDED_CAPACITY");
        /// <summary>
        /// Constant DYNAMIC_UNBOUNDED_CAPACITY for StructuredMessageListType
        /// </summary>
        public static readonly StructuredMessageListType DYNAMIC_UNBOUNDED_CAPACITY = new StructuredMessageListType("DYNAMIC_UNBOUNDED_CAPACITY");
        /// <summary>
        /// Constant FIXED_CAPACITY for StructuredMessageListType
        /// </summary>
        public static readonly StructuredMessageListType FIXED_CAPACITY = new StructuredMessageListType("FIXED_CAPACITY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StructuredMessageListType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StructuredMessageListType FindValue(string value)
        {
            return FindValue<StructuredMessageListType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StructuredMessageListType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TimeUnit.
    /// </summary>
    public class TimeUnit : ConstantClass
    {

        /// <summary>
        /// Constant HOUR for TimeUnit
        /// </summary>
        public static readonly TimeUnit HOUR = new TimeUnit("HOUR");
        /// <summary>
        /// Constant MILLISECOND for TimeUnit
        /// </summary>
        public static readonly TimeUnit MILLISECOND = new TimeUnit("MILLISECOND");
        /// <summary>
        /// Constant MINUTE for TimeUnit
        /// </summary>
        public static readonly TimeUnit MINUTE = new TimeUnit("MINUTE");
        /// <summary>
        /// Constant SECOND for TimeUnit
        /// </summary>
        public static readonly TimeUnit SECOND = new TimeUnit("SECOND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TimeUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TimeUnit FindValue(string value)
        {
            return FindValue<TimeUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TimeUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TriggerMode.
    /// </summary>
    public class TriggerMode : ConstantClass
    {

        /// <summary>
        /// Constant ALWAYS for TriggerMode
        /// </summary>
        public static readonly TriggerMode ALWAYS = new TriggerMode("ALWAYS");
        /// <summary>
        /// Constant RISING_EDGE for TriggerMode
        /// </summary>
        public static readonly TriggerMode RISING_EDGE = new TriggerMode("RISING_EDGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TriggerMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TriggerMode FindValue(string value)
        {
            return FindValue<TriggerMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TriggerMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdateCampaignAction.
    /// </summary>
    public class UpdateCampaignAction : ConstantClass
    {

        /// <summary>
        /// Constant APPROVE for UpdateCampaignAction
        /// </summary>
        public static readonly UpdateCampaignAction APPROVE = new UpdateCampaignAction("APPROVE");
        /// <summary>
        /// Constant RESUME for UpdateCampaignAction
        /// </summary>
        public static readonly UpdateCampaignAction RESUME = new UpdateCampaignAction("RESUME");
        /// <summary>
        /// Constant SUSPEND for UpdateCampaignAction
        /// </summary>
        public static readonly UpdateCampaignAction SUSPEND = new UpdateCampaignAction("SUSPEND");
        /// <summary>
        /// Constant UPDATE for UpdateCampaignAction
        /// </summary>
        public static readonly UpdateCampaignAction UPDATE = new UpdateCampaignAction("UPDATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateCampaignAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateCampaignAction FindValue(string value)
        {
            return FindValue<UpdateCampaignAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateCampaignAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdateMode.
    /// </summary>
    public class UpdateMode : ConstantClass
    {

        /// <summary>
        /// Constant Merge for UpdateMode
        /// </summary>
        public static readonly UpdateMode Merge = new UpdateMode("Merge");
        /// <summary>
        /// Constant Overwrite for UpdateMode
        /// </summary>
        public static readonly UpdateMode Overwrite = new UpdateMode("Overwrite");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateMode FindValue(string value)
        {
            return FindValue<UpdateMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateMode(string value)
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


    /// <summary>
    /// Constants used for properties of type VehicleAssociationBehavior.
    /// </summary>
    public class VehicleAssociationBehavior : ConstantClass
    {

        /// <summary>
        /// Constant CreateIotThing for VehicleAssociationBehavior
        /// </summary>
        public static readonly VehicleAssociationBehavior CreateIotThing = new VehicleAssociationBehavior("CreateIotThing");
        /// <summary>
        /// Constant ValidateIotThingExists for VehicleAssociationBehavior
        /// </summary>
        public static readonly VehicleAssociationBehavior ValidateIotThingExists = new VehicleAssociationBehavior("ValidateIotThingExists");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VehicleAssociationBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VehicleAssociationBehavior FindValue(string value)
        {
            return FindValue<VehicleAssociationBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VehicleAssociationBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VehicleMiddlewareProtocol.
    /// </summary>
    public class VehicleMiddlewareProtocol : ConstantClass
    {

        /// <summary>
        /// Constant ROS_2 for VehicleMiddlewareProtocol
        /// </summary>
        public static readonly VehicleMiddlewareProtocol ROS_2 = new VehicleMiddlewareProtocol("ROS_2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VehicleMiddlewareProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VehicleMiddlewareProtocol FindValue(string value)
        {
            return FindValue<VehicleMiddlewareProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VehicleMiddlewareProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VehicleState.
    /// </summary>
    public class VehicleState : ConstantClass
    {

        /// <summary>
        /// Constant CREATED for VehicleState
        /// </summary>
        public static readonly VehicleState CREATED = new VehicleState("CREATED");
        /// <summary>
        /// Constant DELETING for VehicleState
        /// </summary>
        public static readonly VehicleState DELETING = new VehicleState("DELETING");
        /// <summary>
        /// Constant HEALTHY for VehicleState
        /// </summary>
        public static readonly VehicleState HEALTHY = new VehicleState("HEALTHY");
        /// <summary>
        /// Constant READY for VehicleState
        /// </summary>
        public static readonly VehicleState READY = new VehicleState("READY");
        /// <summary>
        /// Constant READY_FOR_CHECKIN for VehicleState
        /// </summary>
        public static readonly VehicleState READY_FOR_CHECKIN = new VehicleState("READY_FOR_CHECKIN");
        /// <summary>
        /// Constant SUSPENDED for VehicleState
        /// </summary>
        public static readonly VehicleState SUSPENDED = new VehicleState("SUSPENDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VehicleState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VehicleState FindValue(string value)
        {
            return FindValue<VehicleState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VehicleState(string value)
        {
            return FindValue(value);
        }
    }

}