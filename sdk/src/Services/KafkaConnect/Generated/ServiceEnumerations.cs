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
    /// Constants used for properties of type ConnectorOperationState.
    /// </summary>
    public class ConnectorOperationState : ConstantClass
    {

        /// <summary>
        /// Constant PENDING for ConnectorOperationState
        /// </summary>
        public static readonly ConnectorOperationState PENDING = new ConnectorOperationState("PENDING");
        /// <summary>
        /// Constant ROLLBACK_COMPLETE for ConnectorOperationState
        /// </summary>
        public static readonly ConnectorOperationState ROLLBACK_COMPLETE = new ConnectorOperationState("ROLLBACK_COMPLETE");
        /// <summary>
        /// Constant ROLLBACK_FAILED for ConnectorOperationState
        /// </summary>
        public static readonly ConnectorOperationState ROLLBACK_FAILED = new ConnectorOperationState("ROLLBACK_FAILED");
        /// <summary>
        /// Constant ROLLBACK_IN_PROGRESS for ConnectorOperationState
        /// </summary>
        public static readonly ConnectorOperationState ROLLBACK_IN_PROGRESS = new ConnectorOperationState("ROLLBACK_IN_PROGRESS");
        /// <summary>
        /// Constant UPDATE_COMPLETE for ConnectorOperationState
        /// </summary>
        public static readonly ConnectorOperationState UPDATE_COMPLETE = new ConnectorOperationState("UPDATE_COMPLETE");
        /// <summary>
        /// Constant UPDATE_FAILED for ConnectorOperationState
        /// </summary>
        public static readonly ConnectorOperationState UPDATE_FAILED = new ConnectorOperationState("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for ConnectorOperationState
        /// </summary>
        public static readonly ConnectorOperationState UPDATE_IN_PROGRESS = new ConnectorOperationState("UPDATE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectorOperationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectorOperationState FindValue(string value)
        {
            return FindValue<ConnectorOperationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectorOperationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectorOperationStepState.
    /// </summary>
    public class ConnectorOperationStepState : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for ConnectorOperationStepState
        /// </summary>
        public static readonly ConnectorOperationStepState CANCELLED = new ConnectorOperationStepState("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for ConnectorOperationStepState
        /// </summary>
        public static readonly ConnectorOperationStepState COMPLETED = new ConnectorOperationStepState("COMPLETED");
        /// <summary>
        /// Constant FAILED for ConnectorOperationStepState
        /// </summary>
        public static readonly ConnectorOperationStepState FAILED = new ConnectorOperationStepState("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ConnectorOperationStepState
        /// </summary>
        public static readonly ConnectorOperationStepState IN_PROGRESS = new ConnectorOperationStepState("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING for ConnectorOperationStepState
        /// </summary>
        public static readonly ConnectorOperationStepState PENDING = new ConnectorOperationStepState("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectorOperationStepState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectorOperationStepState FindValue(string value)
        {
            return FindValue<ConnectorOperationStepState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectorOperationStepState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectorOperationStepType.
    /// </summary>
    public class ConnectorOperationStepType : ConstantClass
    {

        /// <summary>
        /// Constant FINALIZE_UPDATE for ConnectorOperationStepType
        /// </summary>
        public static readonly ConnectorOperationStepType FINALIZE_UPDATE = new ConnectorOperationStepType("FINALIZE_UPDATE");
        /// <summary>
        /// Constant INITIALIZE_UPDATE for ConnectorOperationStepType
        /// </summary>
        public static readonly ConnectorOperationStepType INITIALIZE_UPDATE = new ConnectorOperationStepType("INITIALIZE_UPDATE");
        /// <summary>
        /// Constant UPDATE_CONNECTOR_CONFIGURATION for ConnectorOperationStepType
        /// </summary>
        public static readonly ConnectorOperationStepType UPDATE_CONNECTOR_CONFIGURATION = new ConnectorOperationStepType("UPDATE_CONNECTOR_CONFIGURATION");
        /// <summary>
        /// Constant UPDATE_WORKER_SETTING for ConnectorOperationStepType
        /// </summary>
        public static readonly ConnectorOperationStepType UPDATE_WORKER_SETTING = new ConnectorOperationStepType("UPDATE_WORKER_SETTING");
        /// <summary>
        /// Constant VALIDATE_UPDATE for ConnectorOperationStepType
        /// </summary>
        public static readonly ConnectorOperationStepType VALIDATE_UPDATE = new ConnectorOperationStepType("VALIDATE_UPDATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectorOperationStepType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectorOperationStepType FindValue(string value)
        {
            return FindValue<ConnectorOperationStepType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectorOperationStepType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectorOperationType.
    /// </summary>
    public class ConnectorOperationType : ConstantClass
    {

        /// <summary>
        /// Constant ISOLATE_CONNECTOR for ConnectorOperationType
        /// </summary>
        public static readonly ConnectorOperationType ISOLATE_CONNECTOR = new ConnectorOperationType("ISOLATE_CONNECTOR");
        /// <summary>
        /// Constant RESTORE_CONNECTOR for ConnectorOperationType
        /// </summary>
        public static readonly ConnectorOperationType RESTORE_CONNECTOR = new ConnectorOperationType("RESTORE_CONNECTOR");
        /// <summary>
        /// Constant UPDATE_CONNECTOR_CONFIGURATION for ConnectorOperationType
        /// </summary>
        public static readonly ConnectorOperationType UPDATE_CONNECTOR_CONFIGURATION = new ConnectorOperationType("UPDATE_CONNECTOR_CONFIGURATION");
        /// <summary>
        /// Constant UPDATE_WORKER_SETTING for ConnectorOperationType
        /// </summary>
        public static readonly ConnectorOperationType UPDATE_WORKER_SETTING = new ConnectorOperationType("UPDATE_WORKER_SETTING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectorOperationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectorOperationType FindValue(string value)
        {
            return FindValue<ConnectorOperationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectorOperationType(string value)
        {
            return FindValue(value);
        }
    }


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


    /// <summary>
    /// Constants used for properties of type WorkerConfigurationState.
    /// </summary>
    public class WorkerConfigurationState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for WorkerConfigurationState
        /// </summary>
        public static readonly WorkerConfigurationState ACTIVE = new WorkerConfigurationState("ACTIVE");
        /// <summary>
        /// Constant DELETING for WorkerConfigurationState
        /// </summary>
        public static readonly WorkerConfigurationState DELETING = new WorkerConfigurationState("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkerConfigurationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkerConfigurationState FindValue(string value)
        {
            return FindValue<WorkerConfigurationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkerConfigurationState(string value)
        {
            return FindValue(value);
        }
    }

}