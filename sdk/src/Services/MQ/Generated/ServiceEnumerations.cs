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
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.MQ
{

    /// <summary>
    /// Constants used for properties of type AuthenticationStrategy.
    /// </summary>
    public class AuthenticationStrategy : ConstantClass
    {

        /// <summary>
        /// Constant CONFIG_MANAGED for AuthenticationStrategy
        /// </summary>
        public static readonly AuthenticationStrategy CONFIG_MANAGED = new AuthenticationStrategy("CONFIG_MANAGED");
        /// <summary>
        /// Constant LDAP for AuthenticationStrategy
        /// </summary>
        public static readonly AuthenticationStrategy LDAP = new AuthenticationStrategy("LDAP");
        /// <summary>
        /// Constant SIMPLE for AuthenticationStrategy
        /// </summary>
        public static readonly AuthenticationStrategy SIMPLE = new AuthenticationStrategy("SIMPLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthenticationStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthenticationStrategy FindValue(string value)
        {
            return FindValue<AuthenticationStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthenticationStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BrokerState.
    /// </summary>
    public class BrokerState : ConstantClass
    {

        /// <summary>
        /// Constant CREATION_FAILED for BrokerState
        /// </summary>
        public static readonly BrokerState CREATION_FAILED = new BrokerState("CREATION_FAILED");
        /// <summary>
        /// Constant CREATION_IN_PROGRESS for BrokerState
        /// </summary>
        public static readonly BrokerState CREATION_IN_PROGRESS = new BrokerState("CREATION_IN_PROGRESS");
        /// <summary>
        /// Constant CRITICAL_ACTION_REQUIRED for BrokerState
        /// </summary>
        public static readonly BrokerState CRITICAL_ACTION_REQUIRED = new BrokerState("CRITICAL_ACTION_REQUIRED");
        /// <summary>
        /// Constant DELETION_IN_PROGRESS for BrokerState
        /// </summary>
        public static readonly BrokerState DELETION_IN_PROGRESS = new BrokerState("DELETION_IN_PROGRESS");
        /// <summary>
        /// Constant REBOOT_IN_PROGRESS for BrokerState
        /// </summary>
        public static readonly BrokerState REBOOT_IN_PROGRESS = new BrokerState("REBOOT_IN_PROGRESS");
        /// <summary>
        /// Constant REPLICA for BrokerState
        /// </summary>
        public static readonly BrokerState REPLICA = new BrokerState("REPLICA");
        /// <summary>
        /// Constant RUNNING for BrokerState
        /// </summary>
        public static readonly BrokerState RUNNING = new BrokerState("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BrokerState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BrokerState FindValue(string value)
        {
            return FindValue<BrokerState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BrokerState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BrokerStorageType.
    /// </summary>
    public class BrokerStorageType : ConstantClass
    {

        /// <summary>
        /// Constant EBS for BrokerStorageType
        /// </summary>
        public static readonly BrokerStorageType EBS = new BrokerStorageType("EBS");
        /// <summary>
        /// Constant EFS for BrokerStorageType
        /// </summary>
        public static readonly BrokerStorageType EFS = new BrokerStorageType("EFS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BrokerStorageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BrokerStorageType FindValue(string value)
        {
            return FindValue<BrokerStorageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BrokerStorageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChangeType.
    /// </summary>
    public class ChangeType : ConstantClass
    {

        /// <summary>
        /// Constant CREATE for ChangeType
        /// </summary>
        public static readonly ChangeType CREATE = new ChangeType("CREATE");
        /// <summary>
        /// Constant DELETE for ChangeType
        /// </summary>
        public static readonly ChangeType DELETE = new ChangeType("DELETE");
        /// <summary>
        /// Constant UPDATE for ChangeType
        /// </summary>
        public static readonly ChangeType UPDATE = new ChangeType("UPDATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeType FindValue(string value)
        {
            return FindValue<ChangeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataReplicationMode.
    /// </summary>
    public class DataReplicationMode : ConstantClass
    {

        /// <summary>
        /// Constant CRDR for DataReplicationMode
        /// </summary>
        public static readonly DataReplicationMode CRDR = new DataReplicationMode("CRDR");
        /// <summary>
        /// Constant NONE for DataReplicationMode
        /// </summary>
        public static readonly DataReplicationMode NONE = new DataReplicationMode("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataReplicationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataReplicationMode FindValue(string value)
        {
            return FindValue<DataReplicationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataReplicationMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DayOfWeek.
    /// </summary>
    public class DayOfWeek : ConstantClass
    {

        /// <summary>
        /// Constant FRIDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek FRIDAY = new DayOfWeek("FRIDAY");
        /// <summary>
        /// Constant MONDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek MONDAY = new DayOfWeek("MONDAY");
        /// <summary>
        /// Constant SATURDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek SATURDAY = new DayOfWeek("SATURDAY");
        /// <summary>
        /// Constant SUNDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek SUNDAY = new DayOfWeek("SUNDAY");
        /// <summary>
        /// Constant THURSDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek THURSDAY = new DayOfWeek("THURSDAY");
        /// <summary>
        /// Constant TUESDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek TUESDAY = new DayOfWeek("TUESDAY");
        /// <summary>
        /// Constant WEDNESDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek WEDNESDAY = new DayOfWeek("WEDNESDAY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DayOfWeek(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DayOfWeek FindValue(string value)
        {
            return FindValue<DayOfWeek>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DayOfWeek(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentMode.
    /// </summary>
    public class DeploymentMode : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE_STANDBY_MULTI_AZ for DeploymentMode
        /// </summary>
        public static readonly DeploymentMode ACTIVE_STANDBY_MULTI_AZ = new DeploymentMode("ACTIVE_STANDBY_MULTI_AZ");
        /// <summary>
        /// Constant CLUSTER_MULTI_AZ for DeploymentMode
        /// </summary>
        public static readonly DeploymentMode CLUSTER_MULTI_AZ = new DeploymentMode("CLUSTER_MULTI_AZ");
        /// <summary>
        /// Constant SINGLE_INSTANCE for DeploymentMode
        /// </summary>
        public static readonly DeploymentMode SINGLE_INSTANCE = new DeploymentMode("SINGLE_INSTANCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentMode FindValue(string value)
        {
            return FindValue<DeploymentMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EngineType.
    /// </summary>
    public class EngineType : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVEMQ for EngineType
        /// </summary>
        public static readonly EngineType ACTIVEMQ = new EngineType("ACTIVEMQ");
        /// <summary>
        /// Constant RABBITMQ for EngineType
        /// </summary>
        public static readonly EngineType RABBITMQ = new EngineType("RABBITMQ");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EngineType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EngineType FindValue(string value)
        {
            return FindValue<EngineType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EngineType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PromoteMode.
    /// </summary>
    public class PromoteMode : ConstantClass
    {

        /// <summary>
        /// Constant FAILOVER for PromoteMode
        /// </summary>
        public static readonly PromoteMode FAILOVER = new PromoteMode("FAILOVER");
        /// <summary>
        /// Constant SWITCHOVER for PromoteMode
        /// </summary>
        public static readonly PromoteMode SWITCHOVER = new PromoteMode("SWITCHOVER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PromoteMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PromoteMode FindValue(string value)
        {
            return FindValue<PromoteMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PromoteMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SanitizationWarningReason.
    /// </summary>
    public class SanitizationWarningReason : ConstantClass
    {

        /// <summary>
        /// Constant DISALLOWED_ATTRIBUTE_REMOVED for SanitizationWarningReason
        /// </summary>
        public static readonly SanitizationWarningReason DISALLOWED_ATTRIBUTE_REMOVED = new SanitizationWarningReason("DISALLOWED_ATTRIBUTE_REMOVED");
        /// <summary>
        /// Constant DISALLOWED_ELEMENT_REMOVED for SanitizationWarningReason
        /// </summary>
        public static readonly SanitizationWarningReason DISALLOWED_ELEMENT_REMOVED = new SanitizationWarningReason("DISALLOWED_ELEMENT_REMOVED");
        /// <summary>
        /// Constant INVALID_ATTRIBUTE_VALUE_REMOVED for SanitizationWarningReason
        /// </summary>
        public static readonly SanitizationWarningReason INVALID_ATTRIBUTE_VALUE_REMOVED = new SanitizationWarningReason("INVALID_ATTRIBUTE_VALUE_REMOVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SanitizationWarningReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SanitizationWarningReason FindValue(string value)
        {
            return FindValue<SanitizationWarningReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SanitizationWarningReason(string value)
        {
            return FindValue(value);
        }
    }

}