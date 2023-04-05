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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.NetworkFirewall
{

    /// <summary>
    /// Constants used for properties of type AttachmentStatus.
    /// </summary>
    public class AttachmentStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATING for AttachmentStatus
        /// </summary>
        public static readonly AttachmentStatus CREATING = new AttachmentStatus("CREATING");
        /// <summary>
        /// Constant DELETING for AttachmentStatus
        /// </summary>
        public static readonly AttachmentStatus DELETING = new AttachmentStatus("DELETING");
        /// <summary>
        /// Constant READY for AttachmentStatus
        /// </summary>
        public static readonly AttachmentStatus READY = new AttachmentStatus("READY");
        /// <summary>
        /// Constant SCALING for AttachmentStatus
        /// </summary>
        public static readonly AttachmentStatus SCALING = new AttachmentStatus("SCALING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AttachmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttachmentStatus FindValue(string value)
        {
            return FindValue<AttachmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AttachmentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfigurationSyncState.
    /// </summary>
    public class ConfigurationSyncState : ConstantClass
    {

        /// <summary>
        /// Constant CAPACITY_CONSTRAINED for ConfigurationSyncState
        /// </summary>
        public static readonly ConfigurationSyncState CAPACITY_CONSTRAINED = new ConfigurationSyncState("CAPACITY_CONSTRAINED");
        /// <summary>
        /// Constant IN_SYNC for ConfigurationSyncState
        /// </summary>
        public static readonly ConfigurationSyncState IN_SYNC = new ConfigurationSyncState("IN_SYNC");
        /// <summary>
        /// Constant PENDING for ConfigurationSyncState
        /// </summary>
        public static readonly ConfigurationSyncState PENDING = new ConfigurationSyncState("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfigurationSyncState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigurationSyncState FindValue(string value)
        {
            return FindValue<ConfigurationSyncState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfigurationSyncState(string value)
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
        /// Constant AWS_OWNED_KMS_KEY for EncryptionType
        /// </summary>
        public static readonly EncryptionType AWS_OWNED_KMS_KEY = new EncryptionType("AWS_OWNED_KMS_KEY");
        /// <summary>
        /// Constant CUSTOMER_KMS for EncryptionType
        /// </summary>
        public static readonly EncryptionType CUSTOMER_KMS = new EncryptionType("CUSTOMER_KMS");

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
    /// Constants used for properties of type FirewallStatusValue.
    /// </summary>
    public class FirewallStatusValue : ConstantClass
    {

        /// <summary>
        /// Constant DELETING for FirewallStatusValue
        /// </summary>
        public static readonly FirewallStatusValue DELETING = new FirewallStatusValue("DELETING");
        /// <summary>
        /// Constant PROVISIONING for FirewallStatusValue
        /// </summary>
        public static readonly FirewallStatusValue PROVISIONING = new FirewallStatusValue("PROVISIONING");
        /// <summary>
        /// Constant READY for FirewallStatusValue
        /// </summary>
        public static readonly FirewallStatusValue READY = new FirewallStatusValue("READY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FirewallStatusValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FirewallStatusValue FindValue(string value)
        {
            return FindValue<FirewallStatusValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FirewallStatusValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GeneratedRulesType.
    /// </summary>
    public class GeneratedRulesType : ConstantClass
    {

        /// <summary>
        /// Constant ALLOWLIST for GeneratedRulesType
        /// </summary>
        public static readonly GeneratedRulesType ALLOWLIST = new GeneratedRulesType("ALLOWLIST");
        /// <summary>
        /// Constant DENYLIST for GeneratedRulesType
        /// </summary>
        public static readonly GeneratedRulesType DENYLIST = new GeneratedRulesType("DENYLIST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GeneratedRulesType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GeneratedRulesType FindValue(string value)
        {
            return FindValue<GeneratedRulesType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GeneratedRulesType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IPAddressType.
    /// </summary>
    public class IPAddressType : ConstantClass
    {

        /// <summary>
        /// Constant DUALSTACK for IPAddressType
        /// </summary>
        public static readonly IPAddressType DUALSTACK = new IPAddressType("DUALSTACK");
        /// <summary>
        /// Constant IPV4 for IPAddressType
        /// </summary>
        public static readonly IPAddressType IPV4 = new IPAddressType("IPV4");
        /// <summary>
        /// Constant IPV6 for IPAddressType
        /// </summary>
        public static readonly IPAddressType IPV6 = new IPAddressType("IPV6");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IPAddressType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IPAddressType FindValue(string value)
        {
            return FindValue<IPAddressType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IPAddressType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogDestinationType.
    /// </summary>
    public class LogDestinationType : ConstantClass
    {

        /// <summary>
        /// Constant CloudWatchLogs for LogDestinationType
        /// </summary>
        public static readonly LogDestinationType CloudWatchLogs = new LogDestinationType("CloudWatchLogs");
        /// <summary>
        /// Constant KinesisDataFirehose for LogDestinationType
        /// </summary>
        public static readonly LogDestinationType KinesisDataFirehose = new LogDestinationType("KinesisDataFirehose");
        /// <summary>
        /// Constant S3 for LogDestinationType
        /// </summary>
        public static readonly LogDestinationType S3 = new LogDestinationType("S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogDestinationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogDestinationType FindValue(string value)
        {
            return FindValue<LogDestinationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogDestinationType(string value)
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
        /// Constant ALERT for LogType
        /// </summary>
        public static readonly LogType ALERT = new LogType("ALERT");
        /// <summary>
        /// Constant FLOW for LogType
        /// </summary>
        public static readonly LogType FLOW = new LogType("FLOW");

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
    /// Constants used for properties of type OverrideAction.
    /// </summary>
    public class OverrideAction : ConstantClass
    {

        /// <summary>
        /// Constant DROP_TO_ALERT for OverrideAction
        /// </summary>
        public static readonly OverrideAction DROP_TO_ALERT = new OverrideAction("DROP_TO_ALERT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OverrideAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OverrideAction FindValue(string value)
        {
            return FindValue<OverrideAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OverrideAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PerObjectSyncStatus.
    /// </summary>
    public class PerObjectSyncStatus : ConstantClass
    {

        /// <summary>
        /// Constant CAPACITY_CONSTRAINED for PerObjectSyncStatus
        /// </summary>
        public static readonly PerObjectSyncStatus CAPACITY_CONSTRAINED = new PerObjectSyncStatus("CAPACITY_CONSTRAINED");
        /// <summary>
        /// Constant IN_SYNC for PerObjectSyncStatus
        /// </summary>
        public static readonly PerObjectSyncStatus IN_SYNC = new PerObjectSyncStatus("IN_SYNC");
        /// <summary>
        /// Constant PENDING for PerObjectSyncStatus
        /// </summary>
        public static readonly PerObjectSyncStatus PENDING = new PerObjectSyncStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PerObjectSyncStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PerObjectSyncStatus FindValue(string value)
        {
            return FindValue<PerObjectSyncStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PerObjectSyncStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceManagedStatus.
    /// </summary>
    public class ResourceManagedStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT for ResourceManagedStatus
        /// </summary>
        public static readonly ResourceManagedStatus ACCOUNT = new ResourceManagedStatus("ACCOUNT");
        /// <summary>
        /// Constant MANAGED for ResourceManagedStatus
        /// </summary>
        public static readonly ResourceManagedStatus MANAGED = new ResourceManagedStatus("MANAGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceManagedStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceManagedStatus FindValue(string value)
        {
            return FindValue<ResourceManagedStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceManagedStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceManagedType.
    /// </summary>
    public class ResourceManagedType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_MANAGED_DOMAIN_LISTS for ResourceManagedType
        /// </summary>
        public static readonly ResourceManagedType AWS_MANAGED_DOMAIN_LISTS = new ResourceManagedType("AWS_MANAGED_DOMAIN_LISTS");
        /// <summary>
        /// Constant AWS_MANAGED_THREAT_SIGNATURES for ResourceManagedType
        /// </summary>
        public static readonly ResourceManagedType AWS_MANAGED_THREAT_SIGNATURES = new ResourceManagedType("AWS_MANAGED_THREAT_SIGNATURES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceManagedType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceManagedType FindValue(string value)
        {
            return FindValue<ResourceManagedType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceManagedType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceStatus.
    /// </summary>
    public class ResourceStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus ACTIVE = new ResourceStatus("ACTIVE");
        /// <summary>
        /// Constant DELETING for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus DELETING = new ResourceStatus("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceStatus FindValue(string value)
        {
            return FindValue<ResourceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleGroupType.
    /// </summary>
    public class RuleGroupType : ConstantClass
    {

        /// <summary>
        /// Constant STATEFUL for RuleGroupType
        /// </summary>
        public static readonly RuleGroupType STATEFUL = new RuleGroupType("STATEFUL");
        /// <summary>
        /// Constant STATELESS for RuleGroupType
        /// </summary>
        public static readonly RuleGroupType STATELESS = new RuleGroupType("STATELESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleGroupType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleGroupType FindValue(string value)
        {
            return FindValue<RuleGroupType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleGroupType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleOrder.
    /// </summary>
    public class RuleOrder : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT_ACTION_ORDER for RuleOrder
        /// </summary>
        public static readonly RuleOrder DEFAULT_ACTION_ORDER = new RuleOrder("DEFAULT_ACTION_ORDER");
        /// <summary>
        /// Constant STRICT_ORDER for RuleOrder
        /// </summary>
        public static readonly RuleOrder STRICT_ORDER = new RuleOrder("STRICT_ORDER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleOrder FindValue(string value)
        {
            return FindValue<RuleOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StatefulAction.
    /// </summary>
    public class StatefulAction : ConstantClass
    {

        /// <summary>
        /// Constant ALERT for StatefulAction
        /// </summary>
        public static readonly StatefulAction ALERT = new StatefulAction("ALERT");
        /// <summary>
        /// Constant DROP for StatefulAction
        /// </summary>
        public static readonly StatefulAction DROP = new StatefulAction("DROP");
        /// <summary>
        /// Constant PASS for StatefulAction
        /// </summary>
        public static readonly StatefulAction PASS = new StatefulAction("PASS");
        /// <summary>
        /// Constant REJECT for StatefulAction
        /// </summary>
        public static readonly StatefulAction REJECT = new StatefulAction("REJECT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StatefulAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatefulAction FindValue(string value)
        {
            return FindValue<StatefulAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StatefulAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StatefulRuleDirection.
    /// </summary>
    public class StatefulRuleDirection : ConstantClass
    {

        /// <summary>
        /// Constant ANY for StatefulRuleDirection
        /// </summary>
        public static readonly StatefulRuleDirection ANY = new StatefulRuleDirection("ANY");
        /// <summary>
        /// Constant FORWARD for StatefulRuleDirection
        /// </summary>
        public static readonly StatefulRuleDirection FORWARD = new StatefulRuleDirection("FORWARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StatefulRuleDirection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatefulRuleDirection FindValue(string value)
        {
            return FindValue<StatefulRuleDirection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StatefulRuleDirection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StatefulRuleProtocol.
    /// </summary>
    public class StatefulRuleProtocol : ConstantClass
    {

        /// <summary>
        /// Constant DCERPC for StatefulRuleProtocol
        /// </summary>
        public static readonly StatefulRuleProtocol DCERPC = new StatefulRuleProtocol("DCERPC");
        /// <summary>
        /// Constant DHCP for StatefulRuleProtocol
        /// </summary>
        public static readonly StatefulRuleProtocol DHCP = new StatefulRuleProtocol("DHCP");
        /// <summary>
        /// Constant DNS for StatefulRuleProtocol
        /// </summary>
        public static readonly StatefulRuleProtocol DNS = new StatefulRuleProtocol("DNS");
        /// <summary>
        /// Constant FTP for StatefulRuleProtocol
        /// </summary>
        public static readonly StatefulRuleProtocol FTP = new StatefulRuleProtocol("FTP");
        /// <summary>
        /// Constant HTTP for StatefulRuleProtocol
        /// </summary>
        public static readonly StatefulRuleProtocol HTTP = new StatefulRuleProtocol("HTTP");
        /// <summary>
        /// Constant ICMP for StatefulRuleProtocol
        /// </summary>
        public static readonly StatefulRuleProtocol ICMP = new StatefulRuleProtocol("ICMP");
        /// <summary>
        /// Constant IKEV2 for StatefulRuleProtocol
        /// </summary>
        public static readonly StatefulRuleProtocol IKEV2 = new StatefulRuleProtocol("IKEV2");
        /// <summary>
        /// Constant IMAP for StatefulRuleProtocol
        /// </summary>
        public static readonly StatefulRuleProtocol IMAP = new StatefulRuleProtocol("IMAP");
        /// <summary>
        /// Constant IP for StatefulRuleProtocol
        /// </summary>
        public static readonly StatefulRuleProtocol IP = new StatefulRuleProtocol("IP");
        /// <summary>
        /// Constant KRB5 for StatefulRuleProtocol
        /// </summary>
        public static readonly StatefulRuleProtocol KRB5 = new StatefulRuleProtocol("KRB5");
        /// <summary>
        /// Constant MSN for StatefulRuleProtocol
        /// </summary>
        public static readonly StatefulRuleProtocol MSN = new StatefulRuleProtocol("MSN");
        /// <summary>
        /// Constant NTP for StatefulRuleProtocol
        /// </summary>
        public static readonly StatefulRuleProtocol NTP = new StatefulRuleProtocol("NTP");
        /// <summary>
        /// Constant SMB for StatefulRuleProtocol
        /// </summary>
        public static readonly StatefulRuleProtocol SMB = new StatefulRuleProtocol("SMB");
        /// <summary>
        /// Constant SMTP for StatefulRuleProtocol
        /// </summary>
        public static readonly StatefulRuleProtocol SMTP = new StatefulRuleProtocol("SMTP");
        /// <summary>
        /// Constant SSH for StatefulRuleProtocol
        /// </summary>
        public static readonly StatefulRuleProtocol SSH = new StatefulRuleProtocol("SSH");
        /// <summary>
        /// Constant TCP for StatefulRuleProtocol
        /// </summary>
        public static readonly StatefulRuleProtocol TCP = new StatefulRuleProtocol("TCP");
        /// <summary>
        /// Constant TFTP for StatefulRuleProtocol
        /// </summary>
        public static readonly StatefulRuleProtocol TFTP = new StatefulRuleProtocol("TFTP");
        /// <summary>
        /// Constant TLS for StatefulRuleProtocol
        /// </summary>
        public static readonly StatefulRuleProtocol TLS = new StatefulRuleProtocol("TLS");
        /// <summary>
        /// Constant UDP for StatefulRuleProtocol
        /// </summary>
        public static readonly StatefulRuleProtocol UDP = new StatefulRuleProtocol("UDP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StatefulRuleProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatefulRuleProtocol FindValue(string value)
        {
            return FindValue<StatefulRuleProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StatefulRuleProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamExceptionPolicy.
    /// </summary>
    public class StreamExceptionPolicy : ConstantClass
    {

        /// <summary>
        /// Constant CONTINUE for StreamExceptionPolicy
        /// </summary>
        public static readonly StreamExceptionPolicy CONTINUE = new StreamExceptionPolicy("CONTINUE");
        /// <summary>
        /// Constant DROP for StreamExceptionPolicy
        /// </summary>
        public static readonly StreamExceptionPolicy DROP = new StreamExceptionPolicy("DROP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamExceptionPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamExceptionPolicy FindValue(string value)
        {
            return FindValue<StreamExceptionPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamExceptionPolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetType.
    /// </summary>
    public class TargetType : ConstantClass
    {

        /// <summary>
        /// Constant HTTP_HOST for TargetType
        /// </summary>
        public static readonly TargetType HTTP_HOST = new TargetType("HTTP_HOST");
        /// <summary>
        /// Constant TLS_SNI for TargetType
        /// </summary>
        public static readonly TargetType TLS_SNI = new TargetType("TLS_SNI");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetType FindValue(string value)
        {
            return FindValue<TargetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TCPFlag.
    /// </summary>
    public class TCPFlag : ConstantClass
    {

        /// <summary>
        /// Constant ACK for TCPFlag
        /// </summary>
        public static readonly TCPFlag ACK = new TCPFlag("ACK");
        /// <summary>
        /// Constant CWR for TCPFlag
        /// </summary>
        public static readonly TCPFlag CWR = new TCPFlag("CWR");
        /// <summary>
        /// Constant ECE for TCPFlag
        /// </summary>
        public static readonly TCPFlag ECE = new TCPFlag("ECE");
        /// <summary>
        /// Constant FIN for TCPFlag
        /// </summary>
        public static readonly TCPFlag FIN = new TCPFlag("FIN");
        /// <summary>
        /// Constant PSH for TCPFlag
        /// </summary>
        public static readonly TCPFlag PSH = new TCPFlag("PSH");
        /// <summary>
        /// Constant RST for TCPFlag
        /// </summary>
        public static readonly TCPFlag RST = new TCPFlag("RST");
        /// <summary>
        /// Constant SYN for TCPFlag
        /// </summary>
        public static readonly TCPFlag SYN = new TCPFlag("SYN");
        /// <summary>
        /// Constant URG for TCPFlag
        /// </summary>
        public static readonly TCPFlag URG = new TCPFlag("URG");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TCPFlag(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TCPFlag FindValue(string value)
        {
            return FindValue<TCPFlag>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TCPFlag(string value)
        {
            return FindValue(value);
        }
    }

}