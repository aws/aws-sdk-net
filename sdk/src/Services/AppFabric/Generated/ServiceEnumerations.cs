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
 * Do not modify this file. This file is generated from the appfabric-2023-05-19.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.AppFabric
{

    /// <summary>
    /// Constants used for properties of type AppAuthorizationStatus.
    /// </summary>
    public class AppAuthorizationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Connected for AppAuthorizationStatus
        /// </summary>
        public static readonly AppAuthorizationStatus Connected = new AppAuthorizationStatus("Connected");
        /// <summary>
        /// Constant ConnectionValidationFailed for AppAuthorizationStatus
        /// </summary>
        public static readonly AppAuthorizationStatus ConnectionValidationFailed = new AppAuthorizationStatus("ConnectionValidationFailed");
        /// <summary>
        /// Constant PendingConnect for AppAuthorizationStatus
        /// </summary>
        public static readonly AppAuthorizationStatus PendingConnect = new AppAuthorizationStatus("PendingConnect");
        /// <summary>
        /// Constant TokenAutoRotationFailed for AppAuthorizationStatus
        /// </summary>
        public static readonly AppAuthorizationStatus TokenAutoRotationFailed = new AppAuthorizationStatus("TokenAutoRotationFailed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppAuthorizationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppAuthorizationStatus FindValue(string value)
        {
            return FindValue<AppAuthorizationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppAuthorizationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthType.
    /// </summary>
    public class AuthType : ConstantClass
    {

        /// <summary>
        /// Constant ApiKey for AuthType
        /// </summary>
        public static readonly AuthType ApiKey = new AuthType("apiKey");
        /// <summary>
        /// Constant Oauth2 for AuthType
        /// </summary>
        public static readonly AuthType Oauth2 = new AuthType("oauth2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthType FindValue(string value)
        {
            return FindValue<AuthType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Format.
    /// </summary>
    public class Format : ConstantClass
    {

        /// <summary>
        /// Constant Json for Format
        /// </summary>
        public static readonly Format Json = new Format("json");
        /// <summary>
        /// Constant Parquet for Format
        /// </summary>
        public static readonly Format Parquet = new Format("parquet");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Format(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Format FindValue(string value)
        {
            return FindValue<Format>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Format(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IngestionDestinationStatus.
    /// </summary>
    public class IngestionDestinationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for IngestionDestinationStatus
        /// </summary>
        public static readonly IngestionDestinationStatus Active = new IngestionDestinationStatus("Active");
        /// <summary>
        /// Constant Failed for IngestionDestinationStatus
        /// </summary>
        public static readonly IngestionDestinationStatus Failed = new IngestionDestinationStatus("Failed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngestionDestinationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngestionDestinationStatus FindValue(string value)
        {
            return FindValue<IngestionDestinationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngestionDestinationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IngestionState.
    /// </summary>
    public class IngestionState : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for IngestionState
        /// </summary>
        public static readonly IngestionState Disabled = new IngestionState("disabled");
        /// <summary>
        /// Constant Enabled for IngestionState
        /// </summary>
        public static readonly IngestionState Enabled = new IngestionState("enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngestionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngestionState FindValue(string value)
        {
            return FindValue<IngestionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngestionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IngestionType.
    /// </summary>
    public class IngestionType : ConstantClass
    {

        /// <summary>
        /// Constant AuditLog for IngestionType
        /// </summary>
        public static readonly IngestionType AuditLog = new IngestionType("auditLog");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngestionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngestionType FindValue(string value)
        {
            return FindValue<IngestionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngestionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Persona.
    /// </summary>
    public class Persona : ConstantClass
    {

        /// <summary>
        /// Constant Admin for Persona
        /// </summary>
        public static readonly Persona Admin = new Persona("admin");
        /// <summary>
        /// Constant EndUser for Persona
        /// </summary>
        public static readonly Persona EndUser = new Persona("endUser");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Persona(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Persona FindValue(string value)
        {
            return FindValue<Persona>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Persona(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResultStatus.
    /// </summary>
    public class ResultStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for ResultStatus
        /// </summary>
        public static readonly ResultStatus COMPLETED = new ResultStatus("COMPLETED");
        /// <summary>
        /// Constant EXPIRED for ResultStatus
        /// </summary>
        public static readonly ResultStatus EXPIRED = new ResultStatus("EXPIRED");
        /// <summary>
        /// Constant FAILED for ResultStatus
        /// </summary>
        public static readonly ResultStatus FAILED = new ResultStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ResultStatus
        /// </summary>
        public static readonly ResultStatus IN_PROGRESS = new ResultStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResultStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResultStatus FindValue(string value)
        {
            return FindValue<ResultStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResultStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Schema.
    /// </summary>
    public class Schema : ConstantClass
    {

        /// <summary>
        /// Constant Ocsf for Schema
        /// </summary>
        public static readonly Schema Ocsf = new Schema("ocsf");
        /// <summary>
        /// Constant Raw for Schema
        /// </summary>
        public static readonly Schema Raw = new Schema("raw");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Schema(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Schema FindValue(string value)
        {
            return FindValue<Schema>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Schema(string value)
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

}