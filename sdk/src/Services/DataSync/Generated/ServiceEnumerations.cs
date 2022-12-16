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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.DataSync
{

    /// <summary>
    /// Constants used for properties of type AgentStatus.
    /// </summary>
    public class AgentStatus : ConstantClass
    {

        /// <summary>
        /// Constant OFFLINE for AgentStatus
        /// </summary>
        public static readonly AgentStatus OFFLINE = new AgentStatus("OFFLINE");
        /// <summary>
        /// Constant ONLINE for AgentStatus
        /// </summary>
        public static readonly AgentStatus ONLINE = new AgentStatus("ONLINE");

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
    /// Constants used for properties of type Atime.
    /// </summary>
    public class Atime : ConstantClass
    {

        /// <summary>
        /// Constant BEST_EFFORT for Atime
        /// </summary>
        public static readonly Atime BEST_EFFORT = new Atime("BEST_EFFORT");
        /// <summary>
        /// Constant NONE for Atime
        /// </summary>
        public static readonly Atime NONE = new Atime("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Atime(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Atime FindValue(string value)
        {
            return FindValue<Atime>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Atime(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EfsInTransitEncryption.
    /// </summary>
    public class EfsInTransitEncryption : ConstantClass
    {

        /// <summary>
        /// Constant NONE for EfsInTransitEncryption
        /// </summary>
        public static readonly EfsInTransitEncryption NONE = new EfsInTransitEncryption("NONE");
        /// <summary>
        /// Constant TLS1_2 for EfsInTransitEncryption
        /// </summary>
        public static readonly EfsInTransitEncryption TLS1_2 = new EfsInTransitEncryption("TLS1_2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EfsInTransitEncryption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EfsInTransitEncryption FindValue(string value)
        {
            return FindValue<EfsInTransitEncryption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EfsInTransitEncryption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EndpointType.
    /// </summary>
    public class EndpointType : ConstantClass
    {

        /// <summary>
        /// Constant FIPS for EndpointType
        /// </summary>
        public static readonly EndpointType FIPS = new EndpointType("FIPS");
        /// <summary>
        /// Constant PRIVATE_LINK for EndpointType
        /// </summary>
        public static readonly EndpointType PRIVATE_LINK = new EndpointType("PRIVATE_LINK");
        /// <summary>
        /// Constant PUBLIC for EndpointType
        /// </summary>
        public static readonly EndpointType PUBLIC = new EndpointType("PUBLIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EndpointType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndpointType FindValue(string value)
        {
            return FindValue<EndpointType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndpointType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FilterType.
    /// </summary>
    public class FilterType : ConstantClass
    {

        /// <summary>
        /// Constant SIMPLE_PATTERN for FilterType
        /// </summary>
        public static readonly FilterType SIMPLE_PATTERN = new FilterType("SIMPLE_PATTERN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterType FindValue(string value)
        {
            return FindValue<FilterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Gid.
    /// </summary>
    public class Gid : ConstantClass
    {

        /// <summary>
        /// Constant BOTH for Gid
        /// </summary>
        public static readonly Gid BOTH = new Gid("BOTH");
        /// <summary>
        /// Constant INT_VALUE for Gid
        /// </summary>
        public static readonly Gid INT_VALUE = new Gid("INT_VALUE");
        /// <summary>
        /// Constant NAME for Gid
        /// </summary>
        public static readonly Gid NAME = new Gid("NAME");
        /// <summary>
        /// Constant NONE for Gid
        /// </summary>
        public static readonly Gid NONE = new Gid("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Gid(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Gid FindValue(string value)
        {
            return FindValue<Gid>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Gid(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HdfsAuthenticationType.
    /// </summary>
    public class HdfsAuthenticationType : ConstantClass
    {

        /// <summary>
        /// Constant KERBEROS for HdfsAuthenticationType
        /// </summary>
        public static readonly HdfsAuthenticationType KERBEROS = new HdfsAuthenticationType("KERBEROS");
        /// <summary>
        /// Constant SIMPLE for HdfsAuthenticationType
        /// </summary>
        public static readonly HdfsAuthenticationType SIMPLE = new HdfsAuthenticationType("SIMPLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HdfsAuthenticationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HdfsAuthenticationType FindValue(string value)
        {
            return FindValue<HdfsAuthenticationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HdfsAuthenticationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HdfsDataTransferProtection.
    /// </summary>
    public class HdfsDataTransferProtection : ConstantClass
    {

        /// <summary>
        /// Constant AUTHENTICATION for HdfsDataTransferProtection
        /// </summary>
        public static readonly HdfsDataTransferProtection AUTHENTICATION = new HdfsDataTransferProtection("AUTHENTICATION");
        /// <summary>
        /// Constant DISABLED for HdfsDataTransferProtection
        /// </summary>
        public static readonly HdfsDataTransferProtection DISABLED = new HdfsDataTransferProtection("DISABLED");
        /// <summary>
        /// Constant INTEGRITY for HdfsDataTransferProtection
        /// </summary>
        public static readonly HdfsDataTransferProtection INTEGRITY = new HdfsDataTransferProtection("INTEGRITY");
        /// <summary>
        /// Constant PRIVACY for HdfsDataTransferProtection
        /// </summary>
        public static readonly HdfsDataTransferProtection PRIVACY = new HdfsDataTransferProtection("PRIVACY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HdfsDataTransferProtection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HdfsDataTransferProtection FindValue(string value)
        {
            return FindValue<HdfsDataTransferProtection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HdfsDataTransferProtection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HdfsRpcProtection.
    /// </summary>
    public class HdfsRpcProtection : ConstantClass
    {

        /// <summary>
        /// Constant AUTHENTICATION for HdfsRpcProtection
        /// </summary>
        public static readonly HdfsRpcProtection AUTHENTICATION = new HdfsRpcProtection("AUTHENTICATION");
        /// <summary>
        /// Constant DISABLED for HdfsRpcProtection
        /// </summary>
        public static readonly HdfsRpcProtection DISABLED = new HdfsRpcProtection("DISABLED");
        /// <summary>
        /// Constant INTEGRITY for HdfsRpcProtection
        /// </summary>
        public static readonly HdfsRpcProtection INTEGRITY = new HdfsRpcProtection("INTEGRITY");
        /// <summary>
        /// Constant PRIVACY for HdfsRpcProtection
        /// </summary>
        public static readonly HdfsRpcProtection PRIVACY = new HdfsRpcProtection("PRIVACY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HdfsRpcProtection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HdfsRpcProtection FindValue(string value)
        {
            return FindValue<HdfsRpcProtection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HdfsRpcProtection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LocationFilterName.
    /// </summary>
    public class LocationFilterName : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for LocationFilterName
        /// </summary>
        public static readonly LocationFilterName CreationTime = new LocationFilterName("CreationTime");
        /// <summary>
        /// Constant LocationType for LocationFilterName
        /// </summary>
        public static readonly LocationFilterName LocationType = new LocationFilterName("LocationType");
        /// <summary>
        /// Constant LocationUri for LocationFilterName
        /// </summary>
        public static readonly LocationFilterName LocationUri = new LocationFilterName("LocationUri");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LocationFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LocationFilterName FindValue(string value)
        {
            return FindValue<LocationFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LocationFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogLevel.
    /// </summary>
    public class LogLevel : ConstantClass
    {

        /// <summary>
        /// Constant BASIC for LogLevel
        /// </summary>
        public static readonly LogLevel BASIC = new LogLevel("BASIC");
        /// <summary>
        /// Constant OFF for LogLevel
        /// </summary>
        public static readonly LogLevel OFF = new LogLevel("OFF");
        /// <summary>
        /// Constant TRANSFER for LogLevel
        /// </summary>
        public static readonly LogLevel TRANSFER = new LogLevel("TRANSFER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogLevel FindValue(string value)
        {
            return FindValue<LogLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mtime.
    /// </summary>
    public class Mtime : ConstantClass
    {

        /// <summary>
        /// Constant NONE for Mtime
        /// </summary>
        public static readonly Mtime NONE = new Mtime("NONE");
        /// <summary>
        /// Constant PRESERVE for Mtime
        /// </summary>
        public static readonly Mtime PRESERVE = new Mtime("PRESERVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mtime(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mtime FindValue(string value)
        {
            return FindValue<Mtime>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mtime(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NfsVersion.
    /// </summary>
    public class NfsVersion : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATIC for NfsVersion
        /// </summary>
        public static readonly NfsVersion AUTOMATIC = new NfsVersion("AUTOMATIC");
        /// <summary>
        /// Constant NFS3 for NfsVersion
        /// </summary>
        public static readonly NfsVersion NFS3 = new NfsVersion("NFS3");
        /// <summary>
        /// Constant NFS4_0 for NfsVersion
        /// </summary>
        public static readonly NfsVersion NFS4_0 = new NfsVersion("NFS4_0");
        /// <summary>
        /// Constant NFS4_1 for NfsVersion
        /// </summary>
        public static readonly NfsVersion NFS4_1 = new NfsVersion("NFS4_1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NfsVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NfsVersion FindValue(string value)
        {
            return FindValue<NfsVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NfsVersion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ObjectStorageServerProtocol.
    /// </summary>
    public class ObjectStorageServerProtocol : ConstantClass
    {

        /// <summary>
        /// Constant HTTP for ObjectStorageServerProtocol
        /// </summary>
        public static readonly ObjectStorageServerProtocol HTTP = new ObjectStorageServerProtocol("HTTP");
        /// <summary>
        /// Constant HTTPS for ObjectStorageServerProtocol
        /// </summary>
        public static readonly ObjectStorageServerProtocol HTTPS = new ObjectStorageServerProtocol("HTTPS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ObjectStorageServerProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ObjectStorageServerProtocol FindValue(string value)
        {
            return FindValue<ObjectStorageServerProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ObjectStorageServerProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ObjectTags.
    /// </summary>
    public class ObjectTags : ConstantClass
    {

        /// <summary>
        /// Constant NONE for ObjectTags
        /// </summary>
        public static readonly ObjectTags NONE = new ObjectTags("NONE");
        /// <summary>
        /// Constant PRESERVE for ObjectTags
        /// </summary>
        public static readonly ObjectTags PRESERVE = new ObjectTags("PRESERVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ObjectTags(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ObjectTags FindValue(string value)
        {
            return FindValue<ObjectTags>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ObjectTags(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Operator.
    /// </summary>
    public class Operator : ConstantClass
    {

        /// <summary>
        /// Constant BeginsWith for Operator
        /// </summary>
        public static readonly Operator BeginsWith = new Operator("BeginsWith");
        /// <summary>
        /// Constant Contains for Operator
        /// </summary>
        public static readonly Operator Contains = new Operator("Contains");
        /// <summary>
        /// Constant Equals for Operator
        /// </summary>
        public static readonly Operator Equals = new Operator("Equals");
        /// <summary>
        /// Constant GreaterThan for Operator
        /// </summary>
        public static readonly Operator GreaterThan = new Operator("GreaterThan");
        /// <summary>
        /// Constant GreaterThanOrEqual for Operator
        /// </summary>
        public static readonly Operator GreaterThanOrEqual = new Operator("GreaterThanOrEqual");
        /// <summary>
        /// Constant In for Operator
        /// </summary>
        public static readonly Operator In = new Operator("In");
        /// <summary>
        /// Constant LessThan for Operator
        /// </summary>
        public static readonly Operator LessThan = new Operator("LessThan");
        /// <summary>
        /// Constant LessThanOrEqual for Operator
        /// </summary>
        public static readonly Operator LessThanOrEqual = new Operator("LessThanOrEqual");
        /// <summary>
        /// Constant NotContains for Operator
        /// </summary>
        public static readonly Operator NotContains = new Operator("NotContains");
        /// <summary>
        /// Constant NotEquals for Operator
        /// </summary>
        public static readonly Operator NotEquals = new Operator("NotEquals");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Operator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Operator FindValue(string value)
        {
            return FindValue<Operator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Operator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OverwriteMode.
    /// </summary>
    public class OverwriteMode : ConstantClass
    {

        /// <summary>
        /// Constant ALWAYS for OverwriteMode
        /// </summary>
        public static readonly OverwriteMode ALWAYS = new OverwriteMode("ALWAYS");
        /// <summary>
        /// Constant NEVER for OverwriteMode
        /// </summary>
        public static readonly OverwriteMode NEVER = new OverwriteMode("NEVER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OverwriteMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OverwriteMode FindValue(string value)
        {
            return FindValue<OverwriteMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OverwriteMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PhaseStatus.
    /// </summary>
    public class PhaseStatus : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for PhaseStatus
        /// </summary>
        public static readonly PhaseStatus ERROR = new PhaseStatus("ERROR");
        /// <summary>
        /// Constant PENDING for PhaseStatus
        /// </summary>
        public static readonly PhaseStatus PENDING = new PhaseStatus("PENDING");
        /// <summary>
        /// Constant SUCCESS for PhaseStatus
        /// </summary>
        public static readonly PhaseStatus SUCCESS = new PhaseStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PhaseStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PhaseStatus FindValue(string value)
        {
            return FindValue<PhaseStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PhaseStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PosixPermissions.
    /// </summary>
    public class PosixPermissions : ConstantClass
    {

        /// <summary>
        /// Constant NONE for PosixPermissions
        /// </summary>
        public static readonly PosixPermissions NONE = new PosixPermissions("NONE");
        /// <summary>
        /// Constant PRESERVE for PosixPermissions
        /// </summary>
        public static readonly PosixPermissions PRESERVE = new PosixPermissions("PRESERVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PosixPermissions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PosixPermissions FindValue(string value)
        {
            return FindValue<PosixPermissions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PosixPermissions(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PreserveDeletedFiles.
    /// </summary>
    public class PreserveDeletedFiles : ConstantClass
    {

        /// <summary>
        /// Constant PRESERVE for PreserveDeletedFiles
        /// </summary>
        public static readonly PreserveDeletedFiles PRESERVE = new PreserveDeletedFiles("PRESERVE");
        /// <summary>
        /// Constant REMOVE for PreserveDeletedFiles
        /// </summary>
        public static readonly PreserveDeletedFiles REMOVE = new PreserveDeletedFiles("REMOVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PreserveDeletedFiles(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PreserveDeletedFiles FindValue(string value)
        {
            return FindValue<PreserveDeletedFiles>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PreserveDeletedFiles(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PreserveDevices.
    /// </summary>
    public class PreserveDevices : ConstantClass
    {

        /// <summary>
        /// Constant NONE for PreserveDevices
        /// </summary>
        public static readonly PreserveDevices NONE = new PreserveDevices("NONE");
        /// <summary>
        /// Constant PRESERVE for PreserveDevices
        /// </summary>
        public static readonly PreserveDevices PRESERVE = new PreserveDevices("PRESERVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PreserveDevices(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PreserveDevices FindValue(string value)
        {
            return FindValue<PreserveDevices>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PreserveDevices(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3StorageClass.
    /// </summary>
    public class S3StorageClass : ConstantClass
    {

        /// <summary>
        /// Constant DEEP_ARCHIVE for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass DEEP_ARCHIVE = new S3StorageClass("DEEP_ARCHIVE");
        /// <summary>
        /// Constant GLACIER for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass GLACIER = new S3StorageClass("GLACIER");
        /// <summary>
        /// Constant GLACIER_INSTANT_RETRIEVAL for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass GLACIER_INSTANT_RETRIEVAL = new S3StorageClass("GLACIER_INSTANT_RETRIEVAL");
        /// <summary>
        /// Constant INTELLIGENT_TIERING for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass INTELLIGENT_TIERING = new S3StorageClass("INTELLIGENT_TIERING");
        /// <summary>
        /// Constant ONEZONE_IA for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass ONEZONE_IA = new S3StorageClass("ONEZONE_IA");
        /// <summary>
        /// Constant OUTPOSTS for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass OUTPOSTS = new S3StorageClass("OUTPOSTS");
        /// <summary>
        /// Constant STANDARD for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass STANDARD = new S3StorageClass("STANDARD");
        /// <summary>
        /// Constant STANDARD_IA for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass STANDARD_IA = new S3StorageClass("STANDARD_IA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3StorageClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3StorageClass FindValue(string value)
        {
            return FindValue<S3StorageClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3StorageClass(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SmbSecurityDescriptorCopyFlags.
    /// </summary>
    public class SmbSecurityDescriptorCopyFlags : ConstantClass
    {

        /// <summary>
        /// Constant NONE for SmbSecurityDescriptorCopyFlags
        /// </summary>
        public static readonly SmbSecurityDescriptorCopyFlags NONE = new SmbSecurityDescriptorCopyFlags("NONE");
        /// <summary>
        /// Constant OWNER_DACL for SmbSecurityDescriptorCopyFlags
        /// </summary>
        public static readonly SmbSecurityDescriptorCopyFlags OWNER_DACL = new SmbSecurityDescriptorCopyFlags("OWNER_DACL");
        /// <summary>
        /// Constant OWNER_DACL_SACL for SmbSecurityDescriptorCopyFlags
        /// </summary>
        public static readonly SmbSecurityDescriptorCopyFlags OWNER_DACL_SACL = new SmbSecurityDescriptorCopyFlags("OWNER_DACL_SACL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SmbSecurityDescriptorCopyFlags(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SmbSecurityDescriptorCopyFlags FindValue(string value)
        {
            return FindValue<SmbSecurityDescriptorCopyFlags>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SmbSecurityDescriptorCopyFlags(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SmbVersion.
    /// </summary>
    public class SmbVersion : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATIC for SmbVersion
        /// </summary>
        public static readonly SmbVersion AUTOMATIC = new SmbVersion("AUTOMATIC");
        /// <summary>
        /// Constant SMB2 for SmbVersion
        /// </summary>
        public static readonly SmbVersion SMB2 = new SmbVersion("SMB2");
        /// <summary>
        /// Constant SMB3 for SmbVersion
        /// </summary>
        public static readonly SmbVersion SMB3 = new SmbVersion("SMB3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SmbVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SmbVersion FindValue(string value)
        {
            return FindValue<SmbVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SmbVersion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskExecutionStatus.
    /// </summary>
    public class TaskExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for TaskExecutionStatus
        /// </summary>
        public static readonly TaskExecutionStatus ERROR = new TaskExecutionStatus("ERROR");
        /// <summary>
        /// Constant LAUNCHING for TaskExecutionStatus
        /// </summary>
        public static readonly TaskExecutionStatus LAUNCHING = new TaskExecutionStatus("LAUNCHING");
        /// <summary>
        /// Constant PREPARING for TaskExecutionStatus
        /// </summary>
        public static readonly TaskExecutionStatus PREPARING = new TaskExecutionStatus("PREPARING");
        /// <summary>
        /// Constant QUEUED for TaskExecutionStatus
        /// </summary>
        public static readonly TaskExecutionStatus QUEUED = new TaskExecutionStatus("QUEUED");
        /// <summary>
        /// Constant SUCCESS for TaskExecutionStatus
        /// </summary>
        public static readonly TaskExecutionStatus SUCCESS = new TaskExecutionStatus("SUCCESS");
        /// <summary>
        /// Constant TRANSFERRING for TaskExecutionStatus
        /// </summary>
        public static readonly TaskExecutionStatus TRANSFERRING = new TaskExecutionStatus("TRANSFERRING");
        /// <summary>
        /// Constant VERIFYING for TaskExecutionStatus
        /// </summary>
        public static readonly TaskExecutionStatus VERIFYING = new TaskExecutionStatus("VERIFYING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskExecutionStatus FindValue(string value)
        {
            return FindValue<TaskExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskFilterName.
    /// </summary>
    public class TaskFilterName : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for TaskFilterName
        /// </summary>
        public static readonly TaskFilterName CreationTime = new TaskFilterName("CreationTime");
        /// <summary>
        /// Constant LocationId for TaskFilterName
        /// </summary>
        public static readonly TaskFilterName LocationId = new TaskFilterName("LocationId");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskFilterName FindValue(string value)
        {
            return FindValue<TaskFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskQueueing.
    /// </summary>
    public class TaskQueueing : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for TaskQueueing
        /// </summary>
        public static readonly TaskQueueing DISABLED = new TaskQueueing("DISABLED");
        /// <summary>
        /// Constant ENABLED for TaskQueueing
        /// </summary>
        public static readonly TaskQueueing ENABLED = new TaskQueueing("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskQueueing(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskQueueing FindValue(string value)
        {
            return FindValue<TaskQueueing>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskQueueing(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskStatus.
    /// </summary>
    public class TaskStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for TaskStatus
        /// </summary>
        public static readonly TaskStatus AVAILABLE = new TaskStatus("AVAILABLE");
        /// <summary>
        /// Constant CREATING for TaskStatus
        /// </summary>
        public static readonly TaskStatus CREATING = new TaskStatus("CREATING");
        /// <summary>
        /// Constant QUEUED for TaskStatus
        /// </summary>
        public static readonly TaskStatus QUEUED = new TaskStatus("QUEUED");
        /// <summary>
        /// Constant RUNNING for TaskStatus
        /// </summary>
        public static readonly TaskStatus RUNNING = new TaskStatus("RUNNING");
        /// <summary>
        /// Constant UNAVAILABLE for TaskStatus
        /// </summary>
        public static readonly TaskStatus UNAVAILABLE = new TaskStatus("UNAVAILABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskStatus FindValue(string value)
        {
            return FindValue<TaskStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransferMode.
    /// </summary>
    public class TransferMode : ConstantClass
    {

        /// <summary>
        /// Constant ALL for TransferMode
        /// </summary>
        public static readonly TransferMode ALL = new TransferMode("ALL");
        /// <summary>
        /// Constant CHANGED for TransferMode
        /// </summary>
        public static readonly TransferMode CHANGED = new TransferMode("CHANGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransferMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransferMode FindValue(string value)
        {
            return FindValue<TransferMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransferMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Uid.
    /// </summary>
    public class Uid : ConstantClass
    {

        /// <summary>
        /// Constant BOTH for Uid
        /// </summary>
        public static readonly Uid BOTH = new Uid("BOTH");
        /// <summary>
        /// Constant INT_VALUE for Uid
        /// </summary>
        public static readonly Uid INT_VALUE = new Uid("INT_VALUE");
        /// <summary>
        /// Constant NAME for Uid
        /// </summary>
        public static readonly Uid NAME = new Uid("NAME");
        /// <summary>
        /// Constant NONE for Uid
        /// </summary>
        public static readonly Uid NONE = new Uid("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Uid(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Uid FindValue(string value)
        {
            return FindValue<Uid>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Uid(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VerifyMode.
    /// </summary>
    public class VerifyMode : ConstantClass
    {

        /// <summary>
        /// Constant NONE for VerifyMode
        /// </summary>
        public static readonly VerifyMode NONE = new VerifyMode("NONE");
        /// <summary>
        /// Constant ONLY_FILES_TRANSFERRED for VerifyMode
        /// </summary>
        public static readonly VerifyMode ONLY_FILES_TRANSFERRED = new VerifyMode("ONLY_FILES_TRANSFERRED");
        /// <summary>
        /// Constant POINT_IN_TIME_CONSISTENT for VerifyMode
        /// </summary>
        public static readonly VerifyMode POINT_IN_TIME_CONSISTENT = new VerifyMode("POINT_IN_TIME_CONSISTENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VerifyMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VerifyMode FindValue(string value)
        {
            return FindValue<VerifyMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VerifyMode(string value)
        {
            return FindValue(value);
        }
    }

}