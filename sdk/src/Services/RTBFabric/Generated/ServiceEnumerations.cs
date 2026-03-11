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
 * Do not modify this file. This file is generated from the rtbfabric-2023-05-15.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.RTBFabric
{

    /// <summary>
    /// Constants used for properties of type FilterType.
    /// </summary>
    public class FilterType : ConstantClass
    {

        /// <summary>
        /// Constant EXCLUDE for FilterType
        /// </summary>
        public static readonly FilterType EXCLUDE = new FilterType("EXCLUDE");
        /// <summary>
        /// Constant INCLUDE for FilterType
        /// </summary>
        public static readonly FilterType INCLUDE = new FilterType("INCLUDE");

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
    /// Constants used for properties of type LinkDirection.
    /// </summary>
    public class LinkDirection : ConstantClass
    {

        /// <summary>
        /// Constant REQUEST for LinkDirection
        /// </summary>
        public static readonly LinkDirection REQUEST = new LinkDirection("REQUEST");
        /// <summary>
        /// Constant RESPONSE for LinkDirection
        /// </summary>
        public static readonly LinkDirection RESPONSE = new LinkDirection("RESPONSE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LinkDirection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LinkDirection FindValue(string value)
        {
            return FindValue<LinkDirection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LinkDirection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LinkStatus.
    /// </summary>
    public class LinkStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACCEPTED for LinkStatus
        /// </summary>
        public static readonly LinkStatus ACCEPTED = new LinkStatus("ACCEPTED");
        /// <summary>
        /// Constant ACTIVE for LinkStatus
        /// </summary>
        public static readonly LinkStatus ACTIVE = new LinkStatus("ACTIVE");
        /// <summary>
        /// Constant DELETED for LinkStatus
        /// </summary>
        public static readonly LinkStatus DELETED = new LinkStatus("DELETED");
        /// <summary>
        /// Constant FAILED for LinkStatus
        /// </summary>
        public static readonly LinkStatus FAILED = new LinkStatus("FAILED");
        /// <summary>
        /// Constant ISOLATED for LinkStatus
        /// </summary>
        public static readonly LinkStatus ISOLATED = new LinkStatus("ISOLATED");
        /// <summary>
        /// Constant PENDING_CREATION for LinkStatus
        /// </summary>
        public static readonly LinkStatus PENDING_CREATION = new LinkStatus("PENDING_CREATION");
        /// <summary>
        /// Constant PENDING_DELETION for LinkStatus
        /// </summary>
        public static readonly LinkStatus PENDING_DELETION = new LinkStatus("PENDING_DELETION");
        /// <summary>
        /// Constant PENDING_ISOLATION for LinkStatus
        /// </summary>
        public static readonly LinkStatus PENDING_ISOLATION = new LinkStatus("PENDING_ISOLATION");
        /// <summary>
        /// Constant PENDING_REQUEST for LinkStatus
        /// </summary>
        public static readonly LinkStatus PENDING_REQUEST = new LinkStatus("PENDING_REQUEST");
        /// <summary>
        /// Constant PENDING_RESTORATION for LinkStatus
        /// </summary>
        public static readonly LinkStatus PENDING_RESTORATION = new LinkStatus("PENDING_RESTORATION");
        /// <summary>
        /// Constant PENDING_UPDATE for LinkStatus
        /// </summary>
        public static readonly LinkStatus PENDING_UPDATE = new LinkStatus("PENDING_UPDATE");
        /// <summary>
        /// Constant REJECTED for LinkStatus
        /// </summary>
        public static readonly LinkStatus REJECTED = new LinkStatus("REJECTED");
        /// <summary>
        /// Constant REQUESTED for LinkStatus
        /// </summary>
        public static readonly LinkStatus REQUESTED = new LinkStatus("REQUESTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LinkStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LinkStatus FindValue(string value)
        {
            return FindValue<LinkStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LinkStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Protocol.
    /// </summary>
    public class Protocol : ConstantClass
    {

        /// <summary>
        /// Constant HTTP for Protocol
        /// </summary>
        public static readonly Protocol HTTP = new Protocol("HTTP");
        /// <summary>
        /// Constant HTTPS for Protocol
        /// </summary>
        public static readonly Protocol HTTPS = new Protocol("HTTPS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Protocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Protocol FindValue(string value)
        {
            return FindValue<Protocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Protocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RequesterGatewayStatus.
    /// </summary>
    public class RequesterGatewayStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for RequesterGatewayStatus
        /// </summary>
        public static readonly RequesterGatewayStatus ACTIVE = new RequesterGatewayStatus("ACTIVE");
        /// <summary>
        /// Constant DELETED for RequesterGatewayStatus
        /// </summary>
        public static readonly RequesterGatewayStatus DELETED = new RequesterGatewayStatus("DELETED");
        /// <summary>
        /// Constant ERROR for RequesterGatewayStatus
        /// </summary>
        public static readonly RequesterGatewayStatus ERROR = new RequesterGatewayStatus("ERROR");
        /// <summary>
        /// Constant ISOLATED for RequesterGatewayStatus
        /// </summary>
        public static readonly RequesterGatewayStatus ISOLATED = new RequesterGatewayStatus("ISOLATED");
        /// <summary>
        /// Constant PENDING_CREATION for RequesterGatewayStatus
        /// </summary>
        public static readonly RequesterGatewayStatus PENDING_CREATION = new RequesterGatewayStatus("PENDING_CREATION");
        /// <summary>
        /// Constant PENDING_DELETION for RequesterGatewayStatus
        /// </summary>
        public static readonly RequesterGatewayStatus PENDING_DELETION = new RequesterGatewayStatus("PENDING_DELETION");
        /// <summary>
        /// Constant PENDING_ISOLATION for RequesterGatewayStatus
        /// </summary>
        public static readonly RequesterGatewayStatus PENDING_ISOLATION = new RequesterGatewayStatus("PENDING_ISOLATION");
        /// <summary>
        /// Constant PENDING_RESTORATION for RequesterGatewayStatus
        /// </summary>
        public static readonly RequesterGatewayStatus PENDING_RESTORATION = new RequesterGatewayStatus("PENDING_RESTORATION");
        /// <summary>
        /// Constant PENDING_UPDATE for RequesterGatewayStatus
        /// </summary>
        public static readonly RequesterGatewayStatus PENDING_UPDATE = new RequesterGatewayStatus("PENDING_UPDATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RequesterGatewayStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RequesterGatewayStatus FindValue(string value)
        {
            return FindValue<RequesterGatewayStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RequesterGatewayStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResponderErrorMaskingAction.
    /// </summary>
    public class ResponderErrorMaskingAction : ConstantClass
    {

        /// <summary>
        /// Constant NO_BID for ResponderErrorMaskingAction
        /// </summary>
        public static readonly ResponderErrorMaskingAction NO_BID = new ResponderErrorMaskingAction("NO_BID");
        /// <summary>
        /// Constant PASSTHROUGH for ResponderErrorMaskingAction
        /// </summary>
        public static readonly ResponderErrorMaskingAction PASSTHROUGH = new ResponderErrorMaskingAction("PASSTHROUGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResponderErrorMaskingAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResponderErrorMaskingAction FindValue(string value)
        {
            return FindValue<ResponderErrorMaskingAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResponderErrorMaskingAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResponderErrorMaskingLoggingType.
    /// </summary>
    public class ResponderErrorMaskingLoggingType : ConstantClass
    {

        /// <summary>
        /// Constant METRIC for ResponderErrorMaskingLoggingType
        /// </summary>
        public static readonly ResponderErrorMaskingLoggingType METRIC = new ResponderErrorMaskingLoggingType("METRIC");
        /// <summary>
        /// Constant NONE for ResponderErrorMaskingLoggingType
        /// </summary>
        public static readonly ResponderErrorMaskingLoggingType NONE = new ResponderErrorMaskingLoggingType("NONE");
        /// <summary>
        /// Constant RESPONSE for ResponderErrorMaskingLoggingType
        /// </summary>
        public static readonly ResponderErrorMaskingLoggingType RESPONSE = new ResponderErrorMaskingLoggingType("RESPONSE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResponderErrorMaskingLoggingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResponderErrorMaskingLoggingType FindValue(string value)
        {
            return FindValue<ResponderErrorMaskingLoggingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResponderErrorMaskingLoggingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResponderGatewayStatus.
    /// </summary>
    public class ResponderGatewayStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ResponderGatewayStatus
        /// </summary>
        public static readonly ResponderGatewayStatus ACTIVE = new ResponderGatewayStatus("ACTIVE");
        /// <summary>
        /// Constant DELETED for ResponderGatewayStatus
        /// </summary>
        public static readonly ResponderGatewayStatus DELETED = new ResponderGatewayStatus("DELETED");
        /// <summary>
        /// Constant ERROR for ResponderGatewayStatus
        /// </summary>
        public static readonly ResponderGatewayStatus ERROR = new ResponderGatewayStatus("ERROR");
        /// <summary>
        /// Constant ISOLATED for ResponderGatewayStatus
        /// </summary>
        public static readonly ResponderGatewayStatus ISOLATED = new ResponderGatewayStatus("ISOLATED");
        /// <summary>
        /// Constant PENDING_CREATION for ResponderGatewayStatus
        /// </summary>
        public static readonly ResponderGatewayStatus PENDING_CREATION = new ResponderGatewayStatus("PENDING_CREATION");
        /// <summary>
        /// Constant PENDING_DELETION for ResponderGatewayStatus
        /// </summary>
        public static readonly ResponderGatewayStatus PENDING_DELETION = new ResponderGatewayStatus("PENDING_DELETION");
        /// <summary>
        /// Constant PENDING_ISOLATION for ResponderGatewayStatus
        /// </summary>
        public static readonly ResponderGatewayStatus PENDING_ISOLATION = new ResponderGatewayStatus("PENDING_ISOLATION");
        /// <summary>
        /// Constant PENDING_RESTORATION for ResponderGatewayStatus
        /// </summary>
        public static readonly ResponderGatewayStatus PENDING_RESTORATION = new ResponderGatewayStatus("PENDING_RESTORATION");
        /// <summary>
        /// Constant PENDING_UPDATE for ResponderGatewayStatus
        /// </summary>
        public static readonly ResponderGatewayStatus PENDING_UPDATE = new ResponderGatewayStatus("PENDING_UPDATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResponderGatewayStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResponderGatewayStatus FindValue(string value)
        {
            return FindValue<ResponderGatewayStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResponderGatewayStatus(string value)
        {
            return FindValue(value);
        }
    }

}