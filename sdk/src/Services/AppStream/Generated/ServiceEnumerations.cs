/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.AppStream
{

    /// <summary>
    /// Constants used for properties of type FleetErrorCode.
    /// </summary>
    public class FleetErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant INSUFFICIENT_AVAILABLE_IP_ADDRESSES for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode INSUFFICIENT_AVAILABLE_IP_ADDRESSES = new FleetErrorCode("INSUFFICIENT_AVAILABLE_IP_ADDRESSES");
        /// <summary>
        /// Constant INTERNAL_SERVICE_ERROR for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode INTERNAL_SERVICE_ERROR = new FleetErrorCode("INTERNAL_SERVICE_ERROR");
        /// <summary>
        /// Constant INVALID_PHOTON_ROLE_MISSING_ENI_CREATE_ACTION for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode INVALID_PHOTON_ROLE_MISSING_ENI_CREATE_ACTION = new FleetErrorCode("INVALID_PHOTON_ROLE_MISSING_ENI_CREATE_ACTION");
        /// <summary>
        /// Constant INVALID_PHOTON_ROLE_MISSING_ENI_DELETE_ACTION for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode INVALID_PHOTON_ROLE_MISSING_ENI_DELETE_ACTION = new FleetErrorCode("INVALID_PHOTON_ROLE_MISSING_ENI_DELETE_ACTION");
        /// <summary>
        /// Constant INVALID_PHOTON_ROLE_MISSING_ENI_DESCRIBE_ACTION for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode INVALID_PHOTON_ROLE_MISSING_ENI_DESCRIBE_ACTION = new FleetErrorCode("INVALID_PHOTON_ROLE_MISSING_ENI_DESCRIBE_ACTION");
        /// <summary>
        /// Constant INVALID_PHOTON_ROLE_MISSING_SUBNET_DESCRIBE_ACTION for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode INVALID_PHOTON_ROLE_MISSING_SUBNET_DESCRIBE_ACTION = new FleetErrorCode("INVALID_PHOTON_ROLE_MISSING_SUBNET_DESCRIBE_ACTION");
        /// <summary>
        /// Constant INVALID_SUBNET_CONFIGURATION for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode INVALID_SUBNET_CONFIGURATION = new FleetErrorCode("INVALID_SUBNET_CONFIGURATION");
        /// <summary>
        /// Constant MISSING_IMAGE for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode MISSING_IMAGE = new FleetErrorCode("MISSING_IMAGE");
        /// <summary>
        /// Constant MISSING_ROLE for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode MISSING_ROLE = new FleetErrorCode("MISSING_ROLE");
        /// <summary>
        /// Constant MISSING_SUBNET for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode MISSING_SUBNET = new FleetErrorCode("MISSING_SUBNET");
        /// <summary>
        /// Constant NETWORK_INTERFACE_LIMIT_EXCEEDED for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode NETWORK_INTERFACE_LIMIT_EXCEEDED = new FleetErrorCode("NETWORK_INTERFACE_LIMIT_EXCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetErrorCode FindValue(string value)
        {
            return FindValue<FleetErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetState.
    /// </summary>
    public class FleetState : ConstantClass
    {

        /// <summary>
        /// Constant RUNNING for FleetState
        /// </summary>
        public static readonly FleetState RUNNING = new FleetState("RUNNING");
        /// <summary>
        /// Constant STARTING for FleetState
        /// </summary>
        public static readonly FleetState STARTING = new FleetState("STARTING");
        /// <summary>
        /// Constant STOPPED for FleetState
        /// </summary>
        public static readonly FleetState STOPPED = new FleetState("STOPPED");
        /// <summary>
        /// Constant STOPPING for FleetState
        /// </summary>
        public static readonly FleetState STOPPING = new FleetState("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetState FindValue(string value)
        {
            return FindValue<FleetState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageState.
    /// </summary>
    public class ImageState : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for ImageState
        /// </summary>
        public static readonly ImageState AVAILABLE = new ImageState("AVAILABLE");
        /// <summary>
        /// Constant DELETING for ImageState
        /// </summary>
        public static readonly ImageState DELETING = new ImageState("DELETING");
        /// <summary>
        /// Constant FAILED for ImageState
        /// </summary>
        public static readonly ImageState FAILED = new ImageState("FAILED");
        /// <summary>
        /// Constant PENDING for ImageState
        /// </summary>
        public static readonly ImageState PENDING = new ImageState("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageState FindValue(string value)
        {
            return FindValue<ImageState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageStateChangeReasonCode.
    /// </summary>
    public class ImageStateChangeReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant IMAGE_BUILDER_NOT_AVAILABLE for ImageStateChangeReasonCode
        /// </summary>
        public static readonly ImageStateChangeReasonCode IMAGE_BUILDER_NOT_AVAILABLE = new ImageStateChangeReasonCode("IMAGE_BUILDER_NOT_AVAILABLE");
        /// <summary>
        /// Constant INTERNAL_ERROR for ImageStateChangeReasonCode
        /// </summary>
        public static readonly ImageStateChangeReasonCode INTERNAL_ERROR = new ImageStateChangeReasonCode("INTERNAL_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageStateChangeReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageStateChangeReasonCode FindValue(string value)
        {
            return FindValue<ImageStateChangeReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageStateChangeReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlatformType.
    /// </summary>
    public class PlatformType : ConstantClass
    {

        /// <summary>
        /// Constant WINDOWS for PlatformType
        /// </summary>
        public static readonly PlatformType WINDOWS = new PlatformType("WINDOWS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlatformType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlatformType FindValue(string value)
        {
            return FindValue<PlatformType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlatformType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamSessionState.
    /// </summary>
    public class StreamSessionState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for StreamSessionState
        /// </summary>
        public static readonly StreamSessionState ACTIVE = new StreamSessionState("ACTIVE");
        /// <summary>
        /// Constant EXPIRED for StreamSessionState
        /// </summary>
        public static readonly StreamSessionState EXPIRED = new StreamSessionState("EXPIRED");
        /// <summary>
        /// Constant PENDING for StreamSessionState
        /// </summary>
        public static readonly StreamSessionState PENDING = new StreamSessionState("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamSessionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamSessionState FindValue(string value)
        {
            return FindValue<StreamSessionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamSessionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VisibilityType.
    /// </summary>
    public class VisibilityType : ConstantClass
    {

        /// <summary>
        /// Constant PRIVATE for VisibilityType
        /// </summary>
        public static readonly VisibilityType PRIVATE = new VisibilityType("PRIVATE");
        /// <summary>
        /// Constant PUBLIC for VisibilityType
        /// </summary>
        public static readonly VisibilityType PUBLIC = new VisibilityType("PUBLIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VisibilityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VisibilityType FindValue(string value)
        {
            return FindValue<VisibilityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VisibilityType(string value)
        {
            return FindValue(value);
        }
    }

}