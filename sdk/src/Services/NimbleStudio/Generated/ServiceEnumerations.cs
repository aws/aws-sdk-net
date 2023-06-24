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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.NimbleStudio
{

    /// <summary>
    /// Constants used for properties of type AutomaticTerminationMode.
    /// </summary>
    public class AutomaticTerminationMode : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATED for AutomaticTerminationMode
        /// </summary>
        public static readonly AutomaticTerminationMode ACTIVATED = new AutomaticTerminationMode("ACTIVATED");
        /// <summary>
        /// Constant DEACTIVATED for AutomaticTerminationMode
        /// </summary>
        public static readonly AutomaticTerminationMode DEACTIVATED = new AutomaticTerminationMode("DEACTIVATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutomaticTerminationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutomaticTerminationMode FindValue(string value)
        {
            return FindValue<AutomaticTerminationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutomaticTerminationMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LaunchProfilePersona.
    /// </summary>
    public class LaunchProfilePersona : ConstantClass
    {

        /// <summary>
        /// Constant USER for LaunchProfilePersona
        /// </summary>
        public static readonly LaunchProfilePersona USER = new LaunchProfilePersona("USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LaunchProfilePersona(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LaunchProfilePersona FindValue(string value)
        {
            return FindValue<LaunchProfilePersona>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LaunchProfilePersona(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LaunchProfilePlatform.
    /// </summary>
    public class LaunchProfilePlatform : ConstantClass
    {

        /// <summary>
        /// Constant LINUX for LaunchProfilePlatform
        /// </summary>
        public static readonly LaunchProfilePlatform LINUX = new LaunchProfilePlatform("LINUX");
        /// <summary>
        /// Constant WINDOWS for LaunchProfilePlatform
        /// </summary>
        public static readonly LaunchProfilePlatform WINDOWS = new LaunchProfilePlatform("WINDOWS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LaunchProfilePlatform(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LaunchProfilePlatform FindValue(string value)
        {
            return FindValue<LaunchProfilePlatform>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LaunchProfilePlatform(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LaunchProfileState.
    /// </summary>
    public class LaunchProfileState : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_FAILED for LaunchProfileState
        /// </summary>
        public static readonly LaunchProfileState CREATE_FAILED = new LaunchProfileState("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for LaunchProfileState
        /// </summary>
        public static readonly LaunchProfileState CREATE_IN_PROGRESS = new LaunchProfileState("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_FAILED for LaunchProfileState
        /// </summary>
        public static readonly LaunchProfileState DELETE_FAILED = new LaunchProfileState("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for LaunchProfileState
        /// </summary>
        public static readonly LaunchProfileState DELETE_IN_PROGRESS = new LaunchProfileState("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETED for LaunchProfileState
        /// </summary>
        public static readonly LaunchProfileState DELETED = new LaunchProfileState("DELETED");
        /// <summary>
        /// Constant READY for LaunchProfileState
        /// </summary>
        public static readonly LaunchProfileState READY = new LaunchProfileState("READY");
        /// <summary>
        /// Constant UPDATE_FAILED for LaunchProfileState
        /// </summary>
        public static readonly LaunchProfileState UPDATE_FAILED = new LaunchProfileState("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for LaunchProfileState
        /// </summary>
        public static readonly LaunchProfileState UPDATE_IN_PROGRESS = new LaunchProfileState("UPDATE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LaunchProfileState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LaunchProfileState FindValue(string value)
        {
            return FindValue<LaunchProfileState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LaunchProfileState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LaunchProfileStatusCode.
    /// </summary>
    public class LaunchProfileStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant ENCRYPTION_KEY_ACCESS_DENIED for LaunchProfileStatusCode
        /// </summary>
        public static readonly LaunchProfileStatusCode ENCRYPTION_KEY_ACCESS_DENIED = new LaunchProfileStatusCode("ENCRYPTION_KEY_ACCESS_DENIED");
        /// <summary>
        /// Constant ENCRYPTION_KEY_NOT_FOUND for LaunchProfileStatusCode
        /// </summary>
        public static readonly LaunchProfileStatusCode ENCRYPTION_KEY_NOT_FOUND = new LaunchProfileStatusCode("ENCRYPTION_KEY_NOT_FOUND");
        /// <summary>
        /// Constant INTERNAL_ERROR for LaunchProfileStatusCode
        /// </summary>
        public static readonly LaunchProfileStatusCode INTERNAL_ERROR = new LaunchProfileStatusCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant INVALID_INSTANCE_TYPES_PROVIDED for LaunchProfileStatusCode
        /// </summary>
        public static readonly LaunchProfileStatusCode INVALID_INSTANCE_TYPES_PROVIDED = new LaunchProfileStatusCode("INVALID_INSTANCE_TYPES_PROVIDED");
        /// <summary>
        /// Constant INVALID_SUBNETS_COMBINATION for LaunchProfileStatusCode
        /// </summary>
        public static readonly LaunchProfileStatusCode INVALID_SUBNETS_COMBINATION = new LaunchProfileStatusCode("INVALID_SUBNETS_COMBINATION");
        /// <summary>
        /// Constant INVALID_SUBNETS_PROVIDED for LaunchProfileStatusCode
        /// </summary>
        public static readonly LaunchProfileStatusCode INVALID_SUBNETS_PROVIDED = new LaunchProfileStatusCode("INVALID_SUBNETS_PROVIDED");
        /// <summary>
        /// Constant LAUNCH_PROFILE_CREATE_IN_PROGRESS for LaunchProfileStatusCode
        /// </summary>
        public static readonly LaunchProfileStatusCode LAUNCH_PROFILE_CREATE_IN_PROGRESS = new LaunchProfileStatusCode("LAUNCH_PROFILE_CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant LAUNCH_PROFILE_CREATED for LaunchProfileStatusCode
        /// </summary>
        public static readonly LaunchProfileStatusCode LAUNCH_PROFILE_CREATED = new LaunchProfileStatusCode("LAUNCH_PROFILE_CREATED");
        /// <summary>
        /// Constant LAUNCH_PROFILE_DELETE_IN_PROGRESS for LaunchProfileStatusCode
        /// </summary>
        public static readonly LaunchProfileStatusCode LAUNCH_PROFILE_DELETE_IN_PROGRESS = new LaunchProfileStatusCode("LAUNCH_PROFILE_DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant LAUNCH_PROFILE_DELETED for LaunchProfileStatusCode
        /// </summary>
        public static readonly LaunchProfileStatusCode LAUNCH_PROFILE_DELETED = new LaunchProfileStatusCode("LAUNCH_PROFILE_DELETED");
        /// <summary>
        /// Constant LAUNCH_PROFILE_UPDATE_IN_PROGRESS for LaunchProfileStatusCode
        /// </summary>
        public static readonly LaunchProfileStatusCode LAUNCH_PROFILE_UPDATE_IN_PROGRESS = new LaunchProfileStatusCode("LAUNCH_PROFILE_UPDATE_IN_PROGRESS");
        /// <summary>
        /// Constant LAUNCH_PROFILE_UPDATED for LaunchProfileStatusCode
        /// </summary>
        public static readonly LaunchProfileStatusCode LAUNCH_PROFILE_UPDATED = new LaunchProfileStatusCode("LAUNCH_PROFILE_UPDATED");
        /// <summary>
        /// Constant LAUNCH_PROFILE_WITH_STREAM_SESSIONS_NOT_DELETED for LaunchProfileStatusCode
        /// </summary>
        public static readonly LaunchProfileStatusCode LAUNCH_PROFILE_WITH_STREAM_SESSIONS_NOT_DELETED = new LaunchProfileStatusCode("LAUNCH_PROFILE_WITH_STREAM_SESSIONS_NOT_DELETED");
        /// <summary>
        /// Constant STREAMING_IMAGE_NOT_FOUND for LaunchProfileStatusCode
        /// </summary>
        public static readonly LaunchProfileStatusCode STREAMING_IMAGE_NOT_FOUND = new LaunchProfileStatusCode("STREAMING_IMAGE_NOT_FOUND");
        /// <summary>
        /// Constant STREAMING_IMAGE_NOT_READY for LaunchProfileStatusCode
        /// </summary>
        public static readonly LaunchProfileStatusCode STREAMING_IMAGE_NOT_READY = new LaunchProfileStatusCode("STREAMING_IMAGE_NOT_READY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LaunchProfileStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LaunchProfileStatusCode FindValue(string value)
        {
            return FindValue<LaunchProfileStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LaunchProfileStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LaunchProfileValidationState.
    /// </summary>
    public class LaunchProfileValidationState : ConstantClass
    {

        /// <summary>
        /// Constant VALIDATION_FAILED for LaunchProfileValidationState
        /// </summary>
        public static readonly LaunchProfileValidationState VALIDATION_FAILED = new LaunchProfileValidationState("VALIDATION_FAILED");
        /// <summary>
        /// Constant VALIDATION_FAILED_INTERNAL_SERVER_ERROR for LaunchProfileValidationState
        /// </summary>
        public static readonly LaunchProfileValidationState VALIDATION_FAILED_INTERNAL_SERVER_ERROR = new LaunchProfileValidationState("VALIDATION_FAILED_INTERNAL_SERVER_ERROR");
        /// <summary>
        /// Constant VALIDATION_IN_PROGRESS for LaunchProfileValidationState
        /// </summary>
        public static readonly LaunchProfileValidationState VALIDATION_IN_PROGRESS = new LaunchProfileValidationState("VALIDATION_IN_PROGRESS");
        /// <summary>
        /// Constant VALIDATION_NOT_STARTED for LaunchProfileValidationState
        /// </summary>
        public static readonly LaunchProfileValidationState VALIDATION_NOT_STARTED = new LaunchProfileValidationState("VALIDATION_NOT_STARTED");
        /// <summary>
        /// Constant VALIDATION_SUCCESS for LaunchProfileValidationState
        /// </summary>
        public static readonly LaunchProfileValidationState VALIDATION_SUCCESS = new LaunchProfileValidationState("VALIDATION_SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LaunchProfileValidationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LaunchProfileValidationState FindValue(string value)
        {
            return FindValue<LaunchProfileValidationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LaunchProfileValidationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LaunchProfileValidationStatusCode.
    /// </summary>
    public class LaunchProfileValidationStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant VALIDATION_FAILED_INTERNAL_SERVER_ERROR for LaunchProfileValidationStatusCode
        /// </summary>
        public static readonly LaunchProfileValidationStatusCode VALIDATION_FAILED_INTERNAL_SERVER_ERROR = new LaunchProfileValidationStatusCode("VALIDATION_FAILED_INTERNAL_SERVER_ERROR");
        /// <summary>
        /// Constant VALIDATION_FAILED_INVALID_ACTIVE_DIRECTORY for LaunchProfileValidationStatusCode
        /// </summary>
        public static readonly LaunchProfileValidationStatusCode VALIDATION_FAILED_INVALID_ACTIVE_DIRECTORY = new LaunchProfileValidationStatusCode("VALIDATION_FAILED_INVALID_ACTIVE_DIRECTORY");
        /// <summary>
        /// Constant VALIDATION_FAILED_INVALID_SECURITY_GROUP_ASSOCIATION for LaunchProfileValidationStatusCode
        /// </summary>
        public static readonly LaunchProfileValidationStatusCode VALIDATION_FAILED_INVALID_SECURITY_GROUP_ASSOCIATION = new LaunchProfileValidationStatusCode("VALIDATION_FAILED_INVALID_SECURITY_GROUP_ASSOCIATION");
        /// <summary>
        /// Constant VALIDATION_FAILED_INVALID_SUBNET_ROUTE_TABLE_ASSOCIATION for LaunchProfileValidationStatusCode
        /// </summary>
        public static readonly LaunchProfileValidationStatusCode VALIDATION_FAILED_INVALID_SUBNET_ROUTE_TABLE_ASSOCIATION = new LaunchProfileValidationStatusCode("VALIDATION_FAILED_INVALID_SUBNET_ROUTE_TABLE_ASSOCIATION");
        /// <summary>
        /// Constant VALIDATION_FAILED_SUBNET_NOT_FOUND for LaunchProfileValidationStatusCode
        /// </summary>
        public static readonly LaunchProfileValidationStatusCode VALIDATION_FAILED_SUBNET_NOT_FOUND = new LaunchProfileValidationStatusCode("VALIDATION_FAILED_SUBNET_NOT_FOUND");
        /// <summary>
        /// Constant VALIDATION_FAILED_UNAUTHORIZED for LaunchProfileValidationStatusCode
        /// </summary>
        public static readonly LaunchProfileValidationStatusCode VALIDATION_FAILED_UNAUTHORIZED = new LaunchProfileValidationStatusCode("VALIDATION_FAILED_UNAUTHORIZED");
        /// <summary>
        /// Constant VALIDATION_IN_PROGRESS for LaunchProfileValidationStatusCode
        /// </summary>
        public static readonly LaunchProfileValidationStatusCode VALIDATION_IN_PROGRESS = new LaunchProfileValidationStatusCode("VALIDATION_IN_PROGRESS");
        /// <summary>
        /// Constant VALIDATION_NOT_STARTED for LaunchProfileValidationStatusCode
        /// </summary>
        public static readonly LaunchProfileValidationStatusCode VALIDATION_NOT_STARTED = new LaunchProfileValidationStatusCode("VALIDATION_NOT_STARTED");
        /// <summary>
        /// Constant VALIDATION_SUCCESS for LaunchProfileValidationStatusCode
        /// </summary>
        public static readonly LaunchProfileValidationStatusCode VALIDATION_SUCCESS = new LaunchProfileValidationStatusCode("VALIDATION_SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LaunchProfileValidationStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LaunchProfileValidationStatusCode FindValue(string value)
        {
            return FindValue<LaunchProfileValidationStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LaunchProfileValidationStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LaunchProfileValidationType.
    /// </summary>
    public class LaunchProfileValidationType : ConstantClass
    {

        /// <summary>
        /// Constant VALIDATE_ACTIVE_DIRECTORY_STUDIO_COMPONENT for LaunchProfileValidationType
        /// </summary>
        public static readonly LaunchProfileValidationType VALIDATE_ACTIVE_DIRECTORY_STUDIO_COMPONENT = new LaunchProfileValidationType("VALIDATE_ACTIVE_DIRECTORY_STUDIO_COMPONENT");
        /// <summary>
        /// Constant VALIDATE_NETWORK_ACL_ASSOCIATION for LaunchProfileValidationType
        /// </summary>
        public static readonly LaunchProfileValidationType VALIDATE_NETWORK_ACL_ASSOCIATION = new LaunchProfileValidationType("VALIDATE_NETWORK_ACL_ASSOCIATION");
        /// <summary>
        /// Constant VALIDATE_SECURITY_GROUP_ASSOCIATION for LaunchProfileValidationType
        /// </summary>
        public static readonly LaunchProfileValidationType VALIDATE_SECURITY_GROUP_ASSOCIATION = new LaunchProfileValidationType("VALIDATE_SECURITY_GROUP_ASSOCIATION");
        /// <summary>
        /// Constant VALIDATE_SUBNET_ASSOCIATION for LaunchProfileValidationType
        /// </summary>
        public static readonly LaunchProfileValidationType VALIDATE_SUBNET_ASSOCIATION = new LaunchProfileValidationType("VALIDATE_SUBNET_ASSOCIATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LaunchProfileValidationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LaunchProfileValidationType FindValue(string value)
        {
            return FindValue<LaunchProfileValidationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LaunchProfileValidationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SessionBackupMode.
    /// </summary>
    public class SessionBackupMode : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATIC for SessionBackupMode
        /// </summary>
        public static readonly SessionBackupMode AUTOMATIC = new SessionBackupMode("AUTOMATIC");
        /// <summary>
        /// Constant DEACTIVATED for SessionBackupMode
        /// </summary>
        public static readonly SessionBackupMode DEACTIVATED = new SessionBackupMode("DEACTIVATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SessionBackupMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SessionBackupMode FindValue(string value)
        {
            return FindValue<SessionBackupMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SessionBackupMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SessionPersistenceMode.
    /// </summary>
    public class SessionPersistenceMode : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATED for SessionPersistenceMode
        /// </summary>
        public static readonly SessionPersistenceMode ACTIVATED = new SessionPersistenceMode("ACTIVATED");
        /// <summary>
        /// Constant DEACTIVATED for SessionPersistenceMode
        /// </summary>
        public static readonly SessionPersistenceMode DEACTIVATED = new SessionPersistenceMode("DEACTIVATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SessionPersistenceMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SessionPersistenceMode FindValue(string value)
        {
            return FindValue<SessionPersistenceMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SessionPersistenceMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamingClipboardMode.
    /// </summary>
    public class StreamingClipboardMode : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for StreamingClipboardMode
        /// </summary>
        public static readonly StreamingClipboardMode DISABLED = new StreamingClipboardMode("DISABLED");
        /// <summary>
        /// Constant ENABLED for StreamingClipboardMode
        /// </summary>
        public static readonly StreamingClipboardMode ENABLED = new StreamingClipboardMode("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamingClipboardMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamingClipboardMode FindValue(string value)
        {
            return FindValue<StreamingClipboardMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamingClipboardMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamingImageEncryptionConfigurationKeyType.
    /// </summary>
    public class StreamingImageEncryptionConfigurationKeyType : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOMER_MANAGED_KEY for StreamingImageEncryptionConfigurationKeyType
        /// </summary>
        public static readonly StreamingImageEncryptionConfigurationKeyType CUSTOMER_MANAGED_KEY = new StreamingImageEncryptionConfigurationKeyType("CUSTOMER_MANAGED_KEY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamingImageEncryptionConfigurationKeyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamingImageEncryptionConfigurationKeyType FindValue(string value)
        {
            return FindValue<StreamingImageEncryptionConfigurationKeyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamingImageEncryptionConfigurationKeyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamingImageState.
    /// </summary>
    public class StreamingImageState : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_FAILED for StreamingImageState
        /// </summary>
        public static readonly StreamingImageState CREATE_FAILED = new StreamingImageState("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for StreamingImageState
        /// </summary>
        public static readonly StreamingImageState CREATE_IN_PROGRESS = new StreamingImageState("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_FAILED for StreamingImageState
        /// </summary>
        public static readonly StreamingImageState DELETE_FAILED = new StreamingImageState("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for StreamingImageState
        /// </summary>
        public static readonly StreamingImageState DELETE_IN_PROGRESS = new StreamingImageState("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETED for StreamingImageState
        /// </summary>
        public static readonly StreamingImageState DELETED = new StreamingImageState("DELETED");
        /// <summary>
        /// Constant READY for StreamingImageState
        /// </summary>
        public static readonly StreamingImageState READY = new StreamingImageState("READY");
        /// <summary>
        /// Constant UPDATE_FAILED for StreamingImageState
        /// </summary>
        public static readonly StreamingImageState UPDATE_FAILED = new StreamingImageState("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for StreamingImageState
        /// </summary>
        public static readonly StreamingImageState UPDATE_IN_PROGRESS = new StreamingImageState("UPDATE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamingImageState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamingImageState FindValue(string value)
        {
            return FindValue<StreamingImageState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamingImageState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamingImageStatusCode.
    /// </summary>
    public class StreamingImageStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for StreamingImageStatusCode
        /// </summary>
        public static readonly StreamingImageStatusCode ACCESS_DENIED = new StreamingImageStatusCode("ACCESS_DENIED");
        /// <summary>
        /// Constant INTERNAL_ERROR for StreamingImageStatusCode
        /// </summary>
        public static readonly StreamingImageStatusCode INTERNAL_ERROR = new StreamingImageStatusCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant STREAMING_IMAGE_CREATE_IN_PROGRESS for StreamingImageStatusCode
        /// </summary>
        public static readonly StreamingImageStatusCode STREAMING_IMAGE_CREATE_IN_PROGRESS = new StreamingImageStatusCode("STREAMING_IMAGE_CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant STREAMING_IMAGE_DELETE_IN_PROGRESS for StreamingImageStatusCode
        /// </summary>
        public static readonly StreamingImageStatusCode STREAMING_IMAGE_DELETE_IN_PROGRESS = new StreamingImageStatusCode("STREAMING_IMAGE_DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant STREAMING_IMAGE_DELETED for StreamingImageStatusCode
        /// </summary>
        public static readonly StreamingImageStatusCode STREAMING_IMAGE_DELETED = new StreamingImageStatusCode("STREAMING_IMAGE_DELETED");
        /// <summary>
        /// Constant STREAMING_IMAGE_READY for StreamingImageStatusCode
        /// </summary>
        public static readonly StreamingImageStatusCode STREAMING_IMAGE_READY = new StreamingImageStatusCode("STREAMING_IMAGE_READY");
        /// <summary>
        /// Constant STREAMING_IMAGE_UPDATE_IN_PROGRESS for StreamingImageStatusCode
        /// </summary>
        public static readonly StreamingImageStatusCode STREAMING_IMAGE_UPDATE_IN_PROGRESS = new StreamingImageStatusCode("STREAMING_IMAGE_UPDATE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamingImageStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamingImageStatusCode FindValue(string value)
        {
            return FindValue<StreamingImageStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamingImageStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamingInstanceType.
    /// </summary>
    public class StreamingInstanceType : ConstantClass
    {

        /// <summary>
        /// Constant G34xlarge for StreamingInstanceType
        /// </summary>
        public static readonly StreamingInstanceType G34xlarge = new StreamingInstanceType("g3.4xlarge");
        /// <summary>
        /// Constant G3sXlarge for StreamingInstanceType
        /// </summary>
        public static readonly StreamingInstanceType G3sXlarge = new StreamingInstanceType("g3s.xlarge");
        /// <summary>
        /// Constant G4dn12xlarge for StreamingInstanceType
        /// </summary>
        public static readonly StreamingInstanceType G4dn12xlarge = new StreamingInstanceType("g4dn.12xlarge");
        /// <summary>
        /// Constant G4dn16xlarge for StreamingInstanceType
        /// </summary>
        public static readonly StreamingInstanceType G4dn16xlarge = new StreamingInstanceType("g4dn.16xlarge");
        /// <summary>
        /// Constant G4dn2xlarge for StreamingInstanceType
        /// </summary>
        public static readonly StreamingInstanceType G4dn2xlarge = new StreamingInstanceType("g4dn.2xlarge");
        /// <summary>
        /// Constant G4dn4xlarge for StreamingInstanceType
        /// </summary>
        public static readonly StreamingInstanceType G4dn4xlarge = new StreamingInstanceType("g4dn.4xlarge");
        /// <summary>
        /// Constant G4dn8xlarge for StreamingInstanceType
        /// </summary>
        public static readonly StreamingInstanceType G4dn8xlarge = new StreamingInstanceType("g4dn.8xlarge");
        /// <summary>
        /// Constant G4dnXlarge for StreamingInstanceType
        /// </summary>
        public static readonly StreamingInstanceType G4dnXlarge = new StreamingInstanceType("g4dn.xlarge");
        /// <summary>
        /// Constant G516xlarge for StreamingInstanceType
        /// </summary>
        public static readonly StreamingInstanceType G516xlarge = new StreamingInstanceType("g5.16xlarge");
        /// <summary>
        /// Constant G52xlarge for StreamingInstanceType
        /// </summary>
        public static readonly StreamingInstanceType G52xlarge = new StreamingInstanceType("g5.2xlarge");
        /// <summary>
        /// Constant G54xlarge for StreamingInstanceType
        /// </summary>
        public static readonly StreamingInstanceType G54xlarge = new StreamingInstanceType("g5.4xlarge");
        /// <summary>
        /// Constant G58xlarge for StreamingInstanceType
        /// </summary>
        public static readonly StreamingInstanceType G58xlarge = new StreamingInstanceType("g5.8xlarge");
        /// <summary>
        /// Constant G5Xlarge for StreamingInstanceType
        /// </summary>
        public static readonly StreamingInstanceType G5Xlarge = new StreamingInstanceType("g5.xlarge");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamingInstanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamingInstanceType FindValue(string value)
        {
            return FindValue<StreamingInstanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamingInstanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamingSessionState.
    /// </summary>
    public class StreamingSessionState : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_FAILED for StreamingSessionState
        /// </summary>
        public static readonly StreamingSessionState CREATE_FAILED = new StreamingSessionState("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for StreamingSessionState
        /// </summary>
        public static readonly StreamingSessionState CREATE_IN_PROGRESS = new StreamingSessionState("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_FAILED for StreamingSessionState
        /// </summary>
        public static readonly StreamingSessionState DELETE_FAILED = new StreamingSessionState("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for StreamingSessionState
        /// </summary>
        public static readonly StreamingSessionState DELETE_IN_PROGRESS = new StreamingSessionState("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETED for StreamingSessionState
        /// </summary>
        public static readonly StreamingSessionState DELETED = new StreamingSessionState("DELETED");
        /// <summary>
        /// Constant READY for StreamingSessionState
        /// </summary>
        public static readonly StreamingSessionState READY = new StreamingSessionState("READY");
        /// <summary>
        /// Constant START_FAILED for StreamingSessionState
        /// </summary>
        public static readonly StreamingSessionState START_FAILED = new StreamingSessionState("START_FAILED");
        /// <summary>
        /// Constant START_IN_PROGRESS for StreamingSessionState
        /// </summary>
        public static readonly StreamingSessionState START_IN_PROGRESS = new StreamingSessionState("START_IN_PROGRESS");
        /// <summary>
        /// Constant STOP_FAILED for StreamingSessionState
        /// </summary>
        public static readonly StreamingSessionState STOP_FAILED = new StreamingSessionState("STOP_FAILED");
        /// <summary>
        /// Constant STOP_IN_PROGRESS for StreamingSessionState
        /// </summary>
        public static readonly StreamingSessionState STOP_IN_PROGRESS = new StreamingSessionState("STOP_IN_PROGRESS");
        /// <summary>
        /// Constant STOPPED for StreamingSessionState
        /// </summary>
        public static readonly StreamingSessionState STOPPED = new StreamingSessionState("STOPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamingSessionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamingSessionState FindValue(string value)
        {
            return FindValue<StreamingSessionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamingSessionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamingSessionStatusCode.
    /// </summary>
    public class StreamingSessionStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE_DIRECTORY_DOMAIN_JOIN_ERROR for StreamingSessionStatusCode
        /// </summary>
        public static readonly StreamingSessionStatusCode ACTIVE_DIRECTORY_DOMAIN_JOIN_ERROR = new StreamingSessionStatusCode("ACTIVE_DIRECTORY_DOMAIN_JOIN_ERROR");
        /// <summary>
        /// Constant AMI_VALIDATION_ERROR for StreamingSessionStatusCode
        /// </summary>
        public static readonly StreamingSessionStatusCode AMI_VALIDATION_ERROR = new StreamingSessionStatusCode("AMI_VALIDATION_ERROR");
        /// <summary>
        /// Constant DECRYPT_STREAMING_IMAGE_ERROR for StreamingSessionStatusCode
        /// </summary>
        public static readonly StreamingSessionStatusCode DECRYPT_STREAMING_IMAGE_ERROR = new StreamingSessionStatusCode("DECRYPT_STREAMING_IMAGE_ERROR");
        /// <summary>
        /// Constant INITIALIZATION_SCRIPT_ERROR for StreamingSessionStatusCode
        /// </summary>
        public static readonly StreamingSessionStatusCode INITIALIZATION_SCRIPT_ERROR = new StreamingSessionStatusCode("INITIALIZATION_SCRIPT_ERROR");
        /// <summary>
        /// Constant INSUFFICIENT_CAPACITY for StreamingSessionStatusCode
        /// </summary>
        public static readonly StreamingSessionStatusCode INSUFFICIENT_CAPACITY = new StreamingSessionStatusCode("INSUFFICIENT_CAPACITY");
        /// <summary>
        /// Constant INTERNAL_ERROR for StreamingSessionStatusCode
        /// </summary>
        public static readonly StreamingSessionStatusCode INTERNAL_ERROR = new StreamingSessionStatusCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant NETWORK_CONNECTION_ERROR for StreamingSessionStatusCode
        /// </summary>
        public static readonly StreamingSessionStatusCode NETWORK_CONNECTION_ERROR = new StreamingSessionStatusCode("NETWORK_CONNECTION_ERROR");
        /// <summary>
        /// Constant NETWORK_INTERFACE_ERROR for StreamingSessionStatusCode
        /// </summary>
        public static readonly StreamingSessionStatusCode NETWORK_INTERFACE_ERROR = new StreamingSessionStatusCode("NETWORK_INTERFACE_ERROR");
        /// <summary>
        /// Constant STREAMING_SESSION_CREATE_IN_PROGRESS for StreamingSessionStatusCode
        /// </summary>
        public static readonly StreamingSessionStatusCode STREAMING_SESSION_CREATE_IN_PROGRESS = new StreamingSessionStatusCode("STREAMING_SESSION_CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant STREAMING_SESSION_DELETE_IN_PROGRESS for StreamingSessionStatusCode
        /// </summary>
        public static readonly StreamingSessionStatusCode STREAMING_SESSION_DELETE_IN_PROGRESS = new StreamingSessionStatusCode("STREAMING_SESSION_DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant STREAMING_SESSION_DELETED for StreamingSessionStatusCode
        /// </summary>
        public static readonly StreamingSessionStatusCode STREAMING_SESSION_DELETED = new StreamingSessionStatusCode("STREAMING_SESSION_DELETED");
        /// <summary>
        /// Constant STREAMING_SESSION_READY for StreamingSessionStatusCode
        /// </summary>
        public static readonly StreamingSessionStatusCode STREAMING_SESSION_READY = new StreamingSessionStatusCode("STREAMING_SESSION_READY");
        /// <summary>
        /// Constant STREAMING_SESSION_START_IN_PROGRESS for StreamingSessionStatusCode
        /// </summary>
        public static readonly StreamingSessionStatusCode STREAMING_SESSION_START_IN_PROGRESS = new StreamingSessionStatusCode("STREAMING_SESSION_START_IN_PROGRESS");
        /// <summary>
        /// Constant STREAMING_SESSION_STARTED for StreamingSessionStatusCode
        /// </summary>
        public static readonly StreamingSessionStatusCode STREAMING_SESSION_STARTED = new StreamingSessionStatusCode("STREAMING_SESSION_STARTED");
        /// <summary>
        /// Constant STREAMING_SESSION_STOP_IN_PROGRESS for StreamingSessionStatusCode
        /// </summary>
        public static readonly StreamingSessionStatusCode STREAMING_SESSION_STOP_IN_PROGRESS = new StreamingSessionStatusCode("STREAMING_SESSION_STOP_IN_PROGRESS");
        /// <summary>
        /// Constant STREAMING_SESSION_STOPPED for StreamingSessionStatusCode
        /// </summary>
        public static readonly StreamingSessionStatusCode STREAMING_SESSION_STOPPED = new StreamingSessionStatusCode("STREAMING_SESSION_STOPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamingSessionStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamingSessionStatusCode FindValue(string value)
        {
            return FindValue<StreamingSessionStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamingSessionStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamingSessionStorageMode.
    /// </summary>
    public class StreamingSessionStorageMode : ConstantClass
    {

        /// <summary>
        /// Constant UPLOAD for StreamingSessionStorageMode
        /// </summary>
        public static readonly StreamingSessionStorageMode UPLOAD = new StreamingSessionStorageMode("UPLOAD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamingSessionStorageMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamingSessionStorageMode FindValue(string value)
        {
            return FindValue<StreamingSessionStorageMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamingSessionStorageMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamingSessionStreamState.
    /// </summary>
    public class StreamingSessionStreamState : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_FAILED for StreamingSessionStreamState
        /// </summary>
        public static readonly StreamingSessionStreamState CREATE_FAILED = new StreamingSessionStreamState("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for StreamingSessionStreamState
        /// </summary>
        public static readonly StreamingSessionStreamState CREATE_IN_PROGRESS = new StreamingSessionStreamState("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_FAILED for StreamingSessionStreamState
        /// </summary>
        public static readonly StreamingSessionStreamState DELETE_FAILED = new StreamingSessionStreamState("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for StreamingSessionStreamState
        /// </summary>
        public static readonly StreamingSessionStreamState DELETE_IN_PROGRESS = new StreamingSessionStreamState("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETED for StreamingSessionStreamState
        /// </summary>
        public static readonly StreamingSessionStreamState DELETED = new StreamingSessionStreamState("DELETED");
        /// <summary>
        /// Constant READY for StreamingSessionStreamState
        /// </summary>
        public static readonly StreamingSessionStreamState READY = new StreamingSessionStreamState("READY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamingSessionStreamState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamingSessionStreamState FindValue(string value)
        {
            return FindValue<StreamingSessionStreamState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamingSessionStreamState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamingSessionStreamStatusCode.
    /// </summary>
    public class StreamingSessionStreamStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant INTERNAL_ERROR for StreamingSessionStreamStatusCode
        /// </summary>
        public static readonly StreamingSessionStreamStatusCode INTERNAL_ERROR = new StreamingSessionStreamStatusCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant NETWORK_CONNECTION_ERROR for StreamingSessionStreamStatusCode
        /// </summary>
        public static readonly StreamingSessionStreamStatusCode NETWORK_CONNECTION_ERROR = new StreamingSessionStreamStatusCode("NETWORK_CONNECTION_ERROR");
        /// <summary>
        /// Constant STREAM_CREATE_IN_PROGRESS for StreamingSessionStreamStatusCode
        /// </summary>
        public static readonly StreamingSessionStreamStatusCode STREAM_CREATE_IN_PROGRESS = new StreamingSessionStreamStatusCode("STREAM_CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant STREAM_DELETE_IN_PROGRESS for StreamingSessionStreamStatusCode
        /// </summary>
        public static readonly StreamingSessionStreamStatusCode STREAM_DELETE_IN_PROGRESS = new StreamingSessionStreamStatusCode("STREAM_DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant STREAM_DELETED for StreamingSessionStreamStatusCode
        /// </summary>
        public static readonly StreamingSessionStreamStatusCode STREAM_DELETED = new StreamingSessionStreamStatusCode("STREAM_DELETED");
        /// <summary>
        /// Constant STREAM_READY for StreamingSessionStreamStatusCode
        /// </summary>
        public static readonly StreamingSessionStreamStatusCode STREAM_READY = new StreamingSessionStreamStatusCode("STREAM_READY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamingSessionStreamStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamingSessionStreamStatusCode FindValue(string value)
        {
            return FindValue<StreamingSessionStreamStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamingSessionStreamStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StudioComponentInitializationScriptRunContext.
    /// </summary>
    public class StudioComponentInitializationScriptRunContext : ConstantClass
    {

        /// <summary>
        /// Constant SYSTEM_INITIALIZATION for StudioComponentInitializationScriptRunContext
        /// </summary>
        public static readonly StudioComponentInitializationScriptRunContext SYSTEM_INITIALIZATION = new StudioComponentInitializationScriptRunContext("SYSTEM_INITIALIZATION");
        /// <summary>
        /// Constant USER_INITIALIZATION for StudioComponentInitializationScriptRunContext
        /// </summary>
        public static readonly StudioComponentInitializationScriptRunContext USER_INITIALIZATION = new StudioComponentInitializationScriptRunContext("USER_INITIALIZATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StudioComponentInitializationScriptRunContext(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StudioComponentInitializationScriptRunContext FindValue(string value)
        {
            return FindValue<StudioComponentInitializationScriptRunContext>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StudioComponentInitializationScriptRunContext(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StudioComponentState.
    /// </summary>
    public class StudioComponentState : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_FAILED for StudioComponentState
        /// </summary>
        public static readonly StudioComponentState CREATE_FAILED = new StudioComponentState("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for StudioComponentState
        /// </summary>
        public static readonly StudioComponentState CREATE_IN_PROGRESS = new StudioComponentState("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_FAILED for StudioComponentState
        /// </summary>
        public static readonly StudioComponentState DELETE_FAILED = new StudioComponentState("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for StudioComponentState
        /// </summary>
        public static readonly StudioComponentState DELETE_IN_PROGRESS = new StudioComponentState("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETED for StudioComponentState
        /// </summary>
        public static readonly StudioComponentState DELETED = new StudioComponentState("DELETED");
        /// <summary>
        /// Constant READY for StudioComponentState
        /// </summary>
        public static readonly StudioComponentState READY = new StudioComponentState("READY");
        /// <summary>
        /// Constant UPDATE_FAILED for StudioComponentState
        /// </summary>
        public static readonly StudioComponentState UPDATE_FAILED = new StudioComponentState("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for StudioComponentState
        /// </summary>
        public static readonly StudioComponentState UPDATE_IN_PROGRESS = new StudioComponentState("UPDATE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StudioComponentState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StudioComponentState FindValue(string value)
        {
            return FindValue<StudioComponentState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StudioComponentState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StudioComponentStatusCode.
    /// </summary>
    public class StudioComponentStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE_DIRECTORY_ALREADY_EXISTS for StudioComponentStatusCode
        /// </summary>
        public static readonly StudioComponentStatusCode ACTIVE_DIRECTORY_ALREADY_EXISTS = new StudioComponentStatusCode("ACTIVE_DIRECTORY_ALREADY_EXISTS");
        /// <summary>
        /// Constant ENCRYPTION_KEY_ACCESS_DENIED for StudioComponentStatusCode
        /// </summary>
        public static readonly StudioComponentStatusCode ENCRYPTION_KEY_ACCESS_DENIED = new StudioComponentStatusCode("ENCRYPTION_KEY_ACCESS_DENIED");
        /// <summary>
        /// Constant ENCRYPTION_KEY_NOT_FOUND for StudioComponentStatusCode
        /// </summary>
        public static readonly StudioComponentStatusCode ENCRYPTION_KEY_NOT_FOUND = new StudioComponentStatusCode("ENCRYPTION_KEY_NOT_FOUND");
        /// <summary>
        /// Constant INTERNAL_ERROR for StudioComponentStatusCode
        /// </summary>
        public static readonly StudioComponentStatusCode INTERNAL_ERROR = new StudioComponentStatusCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant STUDIO_COMPONENT_CREATE_IN_PROGRESS for StudioComponentStatusCode
        /// </summary>
        public static readonly StudioComponentStatusCode STUDIO_COMPONENT_CREATE_IN_PROGRESS = new StudioComponentStatusCode("STUDIO_COMPONENT_CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant STUDIO_COMPONENT_CREATED for StudioComponentStatusCode
        /// </summary>
        public static readonly StudioComponentStatusCode STUDIO_COMPONENT_CREATED = new StudioComponentStatusCode("STUDIO_COMPONENT_CREATED");
        /// <summary>
        /// Constant STUDIO_COMPONENT_DELETE_IN_PROGRESS for StudioComponentStatusCode
        /// </summary>
        public static readonly StudioComponentStatusCode STUDIO_COMPONENT_DELETE_IN_PROGRESS = new StudioComponentStatusCode("STUDIO_COMPONENT_DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant STUDIO_COMPONENT_DELETED for StudioComponentStatusCode
        /// </summary>
        public static readonly StudioComponentStatusCode STUDIO_COMPONENT_DELETED = new StudioComponentStatusCode("STUDIO_COMPONENT_DELETED");
        /// <summary>
        /// Constant STUDIO_COMPONENT_UPDATE_IN_PROGRESS for StudioComponentStatusCode
        /// </summary>
        public static readonly StudioComponentStatusCode STUDIO_COMPONENT_UPDATE_IN_PROGRESS = new StudioComponentStatusCode("STUDIO_COMPONENT_UPDATE_IN_PROGRESS");
        /// <summary>
        /// Constant STUDIO_COMPONENT_UPDATED for StudioComponentStatusCode
        /// </summary>
        public static readonly StudioComponentStatusCode STUDIO_COMPONENT_UPDATED = new StudioComponentStatusCode("STUDIO_COMPONENT_UPDATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StudioComponentStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StudioComponentStatusCode FindValue(string value)
        {
            return FindValue<StudioComponentStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StudioComponentStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StudioComponentSubtype.
    /// </summary>
    public class StudioComponentSubtype : ConstantClass
    {

        /// <summary>
        /// Constant AMAZON_FSX_FOR_LUSTRE for StudioComponentSubtype
        /// </summary>
        public static readonly StudioComponentSubtype AMAZON_FSX_FOR_LUSTRE = new StudioComponentSubtype("AMAZON_FSX_FOR_LUSTRE");
        /// <summary>
        /// Constant AMAZON_FSX_FOR_WINDOWS for StudioComponentSubtype
        /// </summary>
        public static readonly StudioComponentSubtype AMAZON_FSX_FOR_WINDOWS = new StudioComponentSubtype("AMAZON_FSX_FOR_WINDOWS");
        /// <summary>
        /// Constant AWS_MANAGED_MICROSOFT_AD for StudioComponentSubtype
        /// </summary>
        public static readonly StudioComponentSubtype AWS_MANAGED_MICROSOFT_AD = new StudioComponentSubtype("AWS_MANAGED_MICROSOFT_AD");
        /// <summary>
        /// Constant CUSTOM for StudioComponentSubtype
        /// </summary>
        public static readonly StudioComponentSubtype CUSTOM = new StudioComponentSubtype("CUSTOM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StudioComponentSubtype(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StudioComponentSubtype FindValue(string value)
        {
            return FindValue<StudioComponentSubtype>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StudioComponentSubtype(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StudioComponentType.
    /// </summary>
    public class StudioComponentType : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE_DIRECTORY for StudioComponentType
        /// </summary>
        public static readonly StudioComponentType ACTIVE_DIRECTORY = new StudioComponentType("ACTIVE_DIRECTORY");
        /// <summary>
        /// Constant COMPUTE_FARM for StudioComponentType
        /// </summary>
        public static readonly StudioComponentType COMPUTE_FARM = new StudioComponentType("COMPUTE_FARM");
        /// <summary>
        /// Constant CUSTOM for StudioComponentType
        /// </summary>
        public static readonly StudioComponentType CUSTOM = new StudioComponentType("CUSTOM");
        /// <summary>
        /// Constant LICENSE_SERVICE for StudioComponentType
        /// </summary>
        public static readonly StudioComponentType LICENSE_SERVICE = new StudioComponentType("LICENSE_SERVICE");
        /// <summary>
        /// Constant SHARED_FILE_SYSTEM for StudioComponentType
        /// </summary>
        public static readonly StudioComponentType SHARED_FILE_SYSTEM = new StudioComponentType("SHARED_FILE_SYSTEM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StudioComponentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StudioComponentType FindValue(string value)
        {
            return FindValue<StudioComponentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StudioComponentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StudioEncryptionConfigurationKeyType.
    /// </summary>
    public class StudioEncryptionConfigurationKeyType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_OWNED_KEY for StudioEncryptionConfigurationKeyType
        /// </summary>
        public static readonly StudioEncryptionConfigurationKeyType AWS_OWNED_KEY = new StudioEncryptionConfigurationKeyType("AWS_OWNED_KEY");
        /// <summary>
        /// Constant CUSTOMER_MANAGED_KEY for StudioEncryptionConfigurationKeyType
        /// </summary>
        public static readonly StudioEncryptionConfigurationKeyType CUSTOMER_MANAGED_KEY = new StudioEncryptionConfigurationKeyType("CUSTOMER_MANAGED_KEY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StudioEncryptionConfigurationKeyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StudioEncryptionConfigurationKeyType FindValue(string value)
        {
            return FindValue<StudioEncryptionConfigurationKeyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StudioEncryptionConfigurationKeyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StudioPersona.
    /// </summary>
    public class StudioPersona : ConstantClass
    {

        /// <summary>
        /// Constant ADMINISTRATOR for StudioPersona
        /// </summary>
        public static readonly StudioPersona ADMINISTRATOR = new StudioPersona("ADMINISTRATOR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StudioPersona(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StudioPersona FindValue(string value)
        {
            return FindValue<StudioPersona>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StudioPersona(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StudioState.
    /// </summary>
    public class StudioState : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_FAILED for StudioState
        /// </summary>
        public static readonly StudioState CREATE_FAILED = new StudioState("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for StudioState
        /// </summary>
        public static readonly StudioState CREATE_IN_PROGRESS = new StudioState("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_FAILED for StudioState
        /// </summary>
        public static readonly StudioState DELETE_FAILED = new StudioState("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for StudioState
        /// </summary>
        public static readonly StudioState DELETE_IN_PROGRESS = new StudioState("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETED for StudioState
        /// </summary>
        public static readonly StudioState DELETED = new StudioState("DELETED");
        /// <summary>
        /// Constant READY for StudioState
        /// </summary>
        public static readonly StudioState READY = new StudioState("READY");
        /// <summary>
        /// Constant UPDATE_FAILED for StudioState
        /// </summary>
        public static readonly StudioState UPDATE_FAILED = new StudioState("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for StudioState
        /// </summary>
        public static readonly StudioState UPDATE_IN_PROGRESS = new StudioState("UPDATE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StudioState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StudioState FindValue(string value)
        {
            return FindValue<StudioState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StudioState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StudioStatusCode.
    /// </summary>
    public class StudioStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant AWS_SSO_ACCESS_DENIED for StudioStatusCode
        /// </summary>
        public static readonly StudioStatusCode AWS_SSO_ACCESS_DENIED = new StudioStatusCode("AWS_SSO_ACCESS_DENIED");
        /// <summary>
        /// Constant AWS_SSO_CONFIGURATION_REPAIR_IN_PROGRESS for StudioStatusCode
        /// </summary>
        public static readonly StudioStatusCode AWS_SSO_CONFIGURATION_REPAIR_IN_PROGRESS = new StudioStatusCode("AWS_SSO_CONFIGURATION_REPAIR_IN_PROGRESS");
        /// <summary>
        /// Constant AWS_SSO_CONFIGURATION_REPAIRED for StudioStatusCode
        /// </summary>
        public static readonly StudioStatusCode AWS_SSO_CONFIGURATION_REPAIRED = new StudioStatusCode("AWS_SSO_CONFIGURATION_REPAIRED");
        /// <summary>
        /// Constant AWS_SSO_NOT_ENABLED for StudioStatusCode
        /// </summary>
        public static readonly StudioStatusCode AWS_SSO_NOT_ENABLED = new StudioStatusCode("AWS_SSO_NOT_ENABLED");
        /// <summary>
        /// Constant AWS_STS_REGION_DISABLED for StudioStatusCode
        /// </summary>
        public static readonly StudioStatusCode AWS_STS_REGION_DISABLED = new StudioStatusCode("AWS_STS_REGION_DISABLED");
        /// <summary>
        /// Constant ENCRYPTION_KEY_ACCESS_DENIED for StudioStatusCode
        /// </summary>
        public static readonly StudioStatusCode ENCRYPTION_KEY_ACCESS_DENIED = new StudioStatusCode("ENCRYPTION_KEY_ACCESS_DENIED");
        /// <summary>
        /// Constant ENCRYPTION_KEY_NOT_FOUND for StudioStatusCode
        /// </summary>
        public static readonly StudioStatusCode ENCRYPTION_KEY_NOT_FOUND = new StudioStatusCode("ENCRYPTION_KEY_NOT_FOUND");
        /// <summary>
        /// Constant INTERNAL_ERROR for StudioStatusCode
        /// </summary>
        public static readonly StudioStatusCode INTERNAL_ERROR = new StudioStatusCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant ROLE_COULD_NOT_BE_ASSUMED for StudioStatusCode
        /// </summary>
        public static readonly StudioStatusCode ROLE_COULD_NOT_BE_ASSUMED = new StudioStatusCode("ROLE_COULD_NOT_BE_ASSUMED");
        /// <summary>
        /// Constant ROLE_NOT_OWNED_BY_STUDIO_OWNER for StudioStatusCode
        /// </summary>
        public static readonly StudioStatusCode ROLE_NOT_OWNED_BY_STUDIO_OWNER = new StudioStatusCode("ROLE_NOT_OWNED_BY_STUDIO_OWNER");
        /// <summary>
        /// Constant STUDIO_CREATE_IN_PROGRESS for StudioStatusCode
        /// </summary>
        public static readonly StudioStatusCode STUDIO_CREATE_IN_PROGRESS = new StudioStatusCode("STUDIO_CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant STUDIO_CREATED for StudioStatusCode
        /// </summary>
        public static readonly StudioStatusCode STUDIO_CREATED = new StudioStatusCode("STUDIO_CREATED");
        /// <summary>
        /// Constant STUDIO_DELETE_IN_PROGRESS for StudioStatusCode
        /// </summary>
        public static readonly StudioStatusCode STUDIO_DELETE_IN_PROGRESS = new StudioStatusCode("STUDIO_DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant STUDIO_DELETED for StudioStatusCode
        /// </summary>
        public static readonly StudioStatusCode STUDIO_DELETED = new StudioStatusCode("STUDIO_DELETED");
        /// <summary>
        /// Constant STUDIO_UPDATE_IN_PROGRESS for StudioStatusCode
        /// </summary>
        public static readonly StudioStatusCode STUDIO_UPDATE_IN_PROGRESS = new StudioStatusCode("STUDIO_UPDATE_IN_PROGRESS");
        /// <summary>
        /// Constant STUDIO_UPDATED for StudioStatusCode
        /// </summary>
        public static readonly StudioStatusCode STUDIO_UPDATED = new StudioStatusCode("STUDIO_UPDATED");
        /// <summary>
        /// Constant STUDIO_WITH_LAUNCH_PROFILES_NOT_DELETED for StudioStatusCode
        /// </summary>
        public static readonly StudioStatusCode STUDIO_WITH_LAUNCH_PROFILES_NOT_DELETED = new StudioStatusCode("STUDIO_WITH_LAUNCH_PROFILES_NOT_DELETED");
        /// <summary>
        /// Constant STUDIO_WITH_STREAMING_IMAGES_NOT_DELETED for StudioStatusCode
        /// </summary>
        public static readonly StudioStatusCode STUDIO_WITH_STREAMING_IMAGES_NOT_DELETED = new StudioStatusCode("STUDIO_WITH_STREAMING_IMAGES_NOT_DELETED");
        /// <summary>
        /// Constant STUDIO_WITH_STUDIO_COMPONENTS_NOT_DELETED for StudioStatusCode
        /// </summary>
        public static readonly StudioStatusCode STUDIO_WITH_STUDIO_COMPONENTS_NOT_DELETED = new StudioStatusCode("STUDIO_WITH_STUDIO_COMPONENTS_NOT_DELETED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StudioStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StudioStatusCode FindValue(string value)
        {
            return FindValue<StudioStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StudioStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VolumeRetentionMode.
    /// </summary>
    public class VolumeRetentionMode : ConstantClass
    {

        /// <summary>
        /// Constant DELETE for VolumeRetentionMode
        /// </summary>
        public static readonly VolumeRetentionMode DELETE = new VolumeRetentionMode("DELETE");
        /// <summary>
        /// Constant RETAIN for VolumeRetentionMode
        /// </summary>
        public static readonly VolumeRetentionMode RETAIN = new VolumeRetentionMode("RETAIN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VolumeRetentionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VolumeRetentionMode FindValue(string value)
        {
            return FindValue<VolumeRetentionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VolumeRetentionMode(string value)
        {
            return FindValue(value);
        }
    }

}