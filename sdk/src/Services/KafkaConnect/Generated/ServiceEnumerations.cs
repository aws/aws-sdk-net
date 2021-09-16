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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.KafkaConnect
{

    /// <summary>
    /// Constants used for properties of type ConnectorState.
    /// </summary>
    public class ConnectorState : ConstantClass
    {

        /// <summary>
        /// Constant CREATING for ConnectorState
        /// </summary>
        public static readonly ConnectorState CREATING = new ConnectorState("CREATING");
        /// <summary>
        /// Constant DELETING for ConnectorState
        /// </summary>
        public static readonly ConnectorState DELETING = new ConnectorState("DELETING");
        /// <summary>
        /// Constant FAILED for ConnectorState
        /// </summary>
        public static readonly ConnectorState FAILED = new ConnectorState("FAILED");
        /// <summary>
        /// Constant RUNNING for ConnectorState
        /// </summary>
        public static readonly ConnectorState RUNNING = new ConnectorState("RUNNING");
        /// <summary>
        /// Constant UPDATING for ConnectorState
        /// </summary>
        public static readonly ConnectorState UPDATING = new ConnectorState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectorState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectorState FindValue(string value)
        {
            return FindValue<ConnectorState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectorState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CustomPluginContentType.
    /// </summary>
    public class CustomPluginContentType : ConstantClass
    {

        /// <summary>
        /// Constant JAR for CustomPluginContentType
        /// </summary>
        public static readonly CustomPluginContentType JAR = new CustomPluginContentType("JAR");
        /// <summary>
        /// Constant ZIP for CustomPluginContentType
        /// </summary>
        public static readonly CustomPluginContentType ZIP = new CustomPluginContentType("ZIP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomPluginContentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomPluginContentType FindValue(string value)
        {
            return FindValue<CustomPluginContentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomPluginContentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CustomPluginState.
    /// </summary>
    public class CustomPluginState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for CustomPluginState
        /// </summary>
        public static readonly CustomPluginState ACTIVE = new CustomPluginState("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for CustomPluginState
        /// </summary>
        public static readonly CustomPluginState CREATE_FAILED = new CustomPluginState("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for CustomPluginState
        /// </summary>
        public static readonly CustomPluginState CREATING = new CustomPluginState("CREATING");
        /// <summary>
        /// Constant DELETING for CustomPluginState
        /// </summary>
        public static readonly CustomPluginState DELETING = new CustomPluginState("DELETING");
        /// <summary>
        /// Constant UPDATE_FAILED for CustomPluginState
        /// </summary>
        public static readonly CustomPluginState UPDATE_FAILED = new CustomPluginState("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for CustomPluginState
        /// </summary>
        public static readonly CustomPluginState UPDATING = new CustomPluginState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomPluginState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomPluginState FindValue(string value)
        {
            return FindValue<CustomPluginState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomPluginState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KafkaClusterClientAuthenticationType.
    /// </summary>
    public class KafkaClusterClientAuthenticationType : ConstantClass
    {

        /// <summary>
        /// Constant IAM for KafkaClusterClientAuthenticationType
        /// </summary>
        public static readonly KafkaClusterClientAuthenticationType IAM = new KafkaClusterClientAuthenticationType("IAM");
        /// <summary>
        /// Constant NONE for KafkaClusterClientAuthenticationType
        /// </summary>
        public static readonly KafkaClusterClientAuthenticationType NONE = new KafkaClusterClientAuthenticationType("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KafkaClusterClientAuthenticationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KafkaClusterClientAuthenticationType FindValue(string value)
        {
            return FindValue<KafkaClusterClientAuthenticationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KafkaClusterClientAuthenticationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KafkaClusterEncryptionInTransitType.
    /// </summary>
    public class KafkaClusterEncryptionInTransitType : ConstantClass
    {

        /// <summary>
        /// Constant PLAINTEXT for KafkaClusterEncryptionInTransitType
        /// </summary>
        public static readonly KafkaClusterEncryptionInTransitType PLAINTEXT = new KafkaClusterEncryptionInTransitType("PLAINTEXT");
        /// <summary>
        /// Constant TLS for KafkaClusterEncryptionInTransitType
        /// </summary>
        public static readonly KafkaClusterEncryptionInTransitType TLS = new KafkaClusterEncryptionInTransitType("TLS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KafkaClusterEncryptionInTransitType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KafkaClusterEncryptionInTransitType FindValue(string value)
        {
            return FindValue<KafkaClusterEncryptionInTransitType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KafkaClusterEncryptionInTransitType(string value)
        {
            return FindValue(value);
        }
    }

}