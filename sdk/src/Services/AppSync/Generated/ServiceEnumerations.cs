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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.AppSync
{

    /// <summary>
    /// Constants used for properties of type AuthenticationType.
    /// </summary>
    public class AuthenticationType : ConstantClass
    {

        /// <summary>
        /// Constant AMAZON_COGNITO_USER_POOLS for AuthenticationType
        /// </summary>
        public static readonly AuthenticationType AMAZON_COGNITO_USER_POOLS = new AuthenticationType("AMAZON_COGNITO_USER_POOLS");
        /// <summary>
        /// Constant API_KEY for AuthenticationType
        /// </summary>
        public static readonly AuthenticationType API_KEY = new AuthenticationType("API_KEY");
        /// <summary>
        /// Constant AWS_IAM for AuthenticationType
        /// </summary>
        public static readonly AuthenticationType AWS_IAM = new AuthenticationType("AWS_IAM");
        /// <summary>
        /// Constant OPENID_CONNECT for AuthenticationType
        /// </summary>
        public static readonly AuthenticationType OPENID_CONNECT = new AuthenticationType("OPENID_CONNECT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthenticationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthenticationType FindValue(string value)
        {
            return FindValue<AuthenticationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthenticationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSourceType.
    /// </summary>
    public class DataSourceType : ConstantClass
    {

        /// <summary>
        /// Constant AMAZON_DYNAMODB for DataSourceType
        /// </summary>
        public static readonly DataSourceType AMAZON_DYNAMODB = new DataSourceType("AMAZON_DYNAMODB");
        /// <summary>
        /// Constant AMAZON_ELASTICSEARCH for DataSourceType
        /// </summary>
        public static readonly DataSourceType AMAZON_ELASTICSEARCH = new DataSourceType("AMAZON_ELASTICSEARCH");
        /// <summary>
        /// Constant AWS_LAMBDA for DataSourceType
        /// </summary>
        public static readonly DataSourceType AWS_LAMBDA = new DataSourceType("AWS_LAMBDA");
        /// <summary>
        /// Constant NONE for DataSourceType
        /// </summary>
        public static readonly DataSourceType NONE = new DataSourceType("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSourceType FindValue(string value)
        {
            return FindValue<DataSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DefaultAction.
    /// </summary>
    public class DefaultAction : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW for DefaultAction
        /// </summary>
        public static readonly DefaultAction ALLOW = new DefaultAction("ALLOW");
        /// <summary>
        /// Constant DENY for DefaultAction
        /// </summary>
        public static readonly DefaultAction DENY = new DefaultAction("DENY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DefaultAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DefaultAction FindValue(string value)
        {
            return FindValue<DefaultAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DefaultAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FieldLogLevel.
    /// </summary>
    public class FieldLogLevel : ConstantClass
    {

        /// <summary>
        /// Constant ALL for FieldLogLevel
        /// </summary>
        public static readonly FieldLogLevel ALL = new FieldLogLevel("ALL");
        /// <summary>
        /// Constant ERROR for FieldLogLevel
        /// </summary>
        public static readonly FieldLogLevel ERROR = new FieldLogLevel("ERROR");
        /// <summary>
        /// Constant NONE for FieldLogLevel
        /// </summary>
        public static readonly FieldLogLevel NONE = new FieldLogLevel("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FieldLogLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FieldLogLevel FindValue(string value)
        {
            return FindValue<FieldLogLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FieldLogLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OutputType.
    /// </summary>
    public class OutputType : ConstantClass
    {

        /// <summary>
        /// Constant JSON for OutputType
        /// </summary>
        public static readonly OutputType JSON = new OutputType("JSON");
        /// <summary>
        /// Constant SDL for OutputType
        /// </summary>
        public static readonly OutputType SDL = new OutputType("SDL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OutputType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OutputType FindValue(string value)
        {
            return FindValue<OutputType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OutputType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SchemaStatus.
    /// </summary>
    public class SchemaStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for SchemaStatus
        /// </summary>
        public static readonly SchemaStatus ACTIVE = new SchemaStatus("ACTIVE");
        /// <summary>
        /// Constant DELETING for SchemaStatus
        /// </summary>
        public static readonly SchemaStatus DELETING = new SchemaStatus("DELETING");
        /// <summary>
        /// Constant PROCESSING for SchemaStatus
        /// </summary>
        public static readonly SchemaStatus PROCESSING = new SchemaStatus("PROCESSING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SchemaStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SchemaStatus FindValue(string value)
        {
            return FindValue<SchemaStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SchemaStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TypeDefinitionFormat.
    /// </summary>
    public class TypeDefinitionFormat : ConstantClass
    {

        /// <summary>
        /// Constant JSON for TypeDefinitionFormat
        /// </summary>
        public static readonly TypeDefinitionFormat JSON = new TypeDefinitionFormat("JSON");
        /// <summary>
        /// Constant SDL for TypeDefinitionFormat
        /// </summary>
        public static readonly TypeDefinitionFormat SDL = new TypeDefinitionFormat("SDL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TypeDefinitionFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TypeDefinitionFormat FindValue(string value)
        {
            return FindValue<TypeDefinitionFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TypeDefinitionFormat(string value)
        {
            return FindValue(value);
        }
    }

}