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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using Amazon.Runtime;

namespace Amazon.NetworkFirewall
{
    /// <summary>
    /// Constants used for properties of type ActionScope.
    /// </summary>
    public class ActionScope : ConstantClass
    {
        /// <summary>
        /// Constant FLOW for ActionScope
        /// </summary>
        public static readonly ActionScope FLOW = new ActionScope("FLOW");

        /// <summary>
        /// Constant HOOK for ActionScope
        /// </summary>
        public static readonly ActionScope HOOK = new ActionScope("HOOK");

        /// <summary>
        /// Constant PACKET for ActionScope
        /// </summary>
        public static readonly ActionScope PACKET = new ActionScope("PACKET");

        /// <summary>
        /// Constant TX for ActionScope
        /// </summary>
        public static readonly ActionScope TX = new ActionScope("TX");

        /// <summary>
        /// Constructs a custom ActionScope for a value not among the defined constants.
        /// </summary>
        public ActionScope(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionScope FindValue(string value)
        {
            return FindValue<ActionScope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionScope(string value)
        {
            return FindValue(value);
        }
    }

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
        /// Constant ERROR for AttachmentStatus
        /// </summary>
        public static readonly AttachmentStatus ERROR = new AttachmentStatus("ERROR");

        /// <summary>
        /// Constant FAILED for AttachmentStatus
        /// </summary>
        public static readonly AttachmentStatus FAILED = new AttachmentStatus("FAILED");

        /// <summary>
        /// Constant READY for AttachmentStatus
        /// </summary>
        public static readonly AttachmentStatus READY = new AttachmentStatus("READY");

        /// <summary>
        /// Constant SCALING for AttachmentStatus
        /// </summary>
        public static readonly AttachmentStatus SCALING = new AttachmentStatus("SCALING");

        /// <summary>
        /// Constructs a custom AttachmentStatus for a value not among the defined constants.
        /// </summary>
        public AttachmentStatus(string value) : base(value) { }

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
        /// Constructs a custom ConfigurationSyncState for a value not among the defined constants.
        /// </summary>
        public ConfigurationSyncState(string value) : base(value) { }

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
    /// Constants used for properties of type ContainerAssociationStatus.
    /// </summary>
    public class ContainerAssociationStatus : ConstantClass
    {
        /// <summary>
        /// Constant ACTIVE for ContainerAssociationStatus
        /// </summary>
        public static readonly ContainerAssociationStatus ACTIVE = new ContainerAssociationStatus("ACTIVE");

        /// <summary>
        /// Constant CREATING for ContainerAssociationStatus
        /// </summary>
        public static readonly ContainerAssociationStatus CREATING = new ContainerAssociationStatus("CREATING");

        /// <summary>
        /// Constant DELETING for ContainerAssociationStatus
        /// </summary>
        public static readonly ContainerAssociationStatus DELETING = new ContainerAssociationStatus("DELETING");

        /// <summary>
        /// Constant UPDATING for ContainerAssociationStatus
        /// </summary>
        public static readonly ContainerAssociationStatus UPDATING = new ContainerAssociationStatus("UPDATING");

        /// <summary>
        /// Constructs a custom ContainerAssociationStatus for a value not among the defined constants.
        /// </summary>
        public ContainerAssociationStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerAssociationStatus FindValue(string value)
        {
            return FindValue<ContainerAssociationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContainerAssociationStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ContainerMonitoringType.
    /// </summary>
    public class ContainerMonitoringType : ConstantClass
    {
        /// <summary>
        /// Constant ECS for ContainerMonitoringType
        /// </summary>
        public static readonly ContainerMonitoringType ECS = new ContainerMonitoringType("ECS");

        /// <summary>
        /// Constant EKS for ContainerMonitoringType
        /// </summary>
        public static readonly ContainerMonitoringType EKS = new ContainerMonitoringType("EKS");

        /// <summary>
        /// Constructs a custom ContainerMonitoringType for a value not among the defined constants.
        /// </summary>
        public ContainerMonitoringType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerMonitoringType FindValue(string value)
        {
            return FindValue<ContainerMonitoringType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContainerMonitoringType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DNSExpiryExceptionPolicy.
    /// </summary>
    public class DNSExpiryExceptionPolicy : ConstantClass
    {
        /// <summary>
        /// Constant CONTINUE for DNSExpiryExceptionPolicy
        /// </summary>
        public static readonly DNSExpiryExceptionPolicy CONTINUE = new DNSExpiryExceptionPolicy("CONTINUE");

        /// <summary>
        /// Constant DROP for DNSExpiryExceptionPolicy
        /// </summary>
        public static readonly DNSExpiryExceptionPolicy DROP = new DNSExpiryExceptionPolicy("DROP");

        /// <summary>
        /// Constant REJECT for DNSExpiryExceptionPolicy
        /// </summary>
        public static readonly DNSExpiryExceptionPolicy REJECT = new DNSExpiryExceptionPolicy("REJECT");

        /// <summary>
        /// Constructs a custom DNSExpiryExceptionPolicy for a value not among the defined constants.
        /// </summary>
        public DNSExpiryExceptionPolicy(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DNSExpiryExceptionPolicy FindValue(string value)
        {
            return FindValue<DNSExpiryExceptionPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DNSExpiryExceptionPolicy(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type EnabledAnalysisType.
    /// </summary>
    public class EnabledAnalysisType : ConstantClass
    {
        /// <summary>
        /// Constant HTTP_HOST for EnabledAnalysisType
        /// </summary>
        public static readonly EnabledAnalysisType HTTP_HOST = new EnabledAnalysisType("HTTP_HOST");

        /// <summary>
        /// Constant TLS_SNI for EnabledAnalysisType
        /// </summary>
        public static readonly EnabledAnalysisType TLS_SNI = new EnabledAnalysisType("TLS_SNI");

        /// <summary>
        /// Constructs a custom EnabledAnalysisType for a value not among the defined constants.
        /// </summary>
        public EnabledAnalysisType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnabledAnalysisType FindValue(string value)
        {
            return FindValue<EnabledAnalysisType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnabledAnalysisType(string value)
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
        /// Constructs a custom EncryptionType for a value not among the defined constants.
        /// </summary>
        public EncryptionType(string value) : base(value) { }

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
    /// Constants used for properties of type FirewallPolicyErrorCode.
    /// </summary>
    public class FirewallPolicyErrorCode : ConstantClass
    {
        /// <summary>
        /// Constant DNS_FIREWALL_RULE_GROUP_UNAVAILABLE for FirewallPolicyErrorCode
        /// </summary>
        public static readonly FirewallPolicyErrorCode DNS_FIREWALL_RULE_GROUP_UNAVAILABLE = new FirewallPolicyErrorCode("DNS_FIREWALL_RULE_GROUP_UNAVAILABLE");

        /// <summary>
        /// Constant ROUTE53_RESOLVED_IP_VALIDATION_MISSING for FirewallPolicyErrorCode
        /// </summary>
        public static readonly FirewallPolicyErrorCode ROUTE53_RESOLVED_IP_VALIDATION_MISSING = new FirewallPolicyErrorCode("ROUTE53_RESOLVED_IP_VALIDATION_MISSING");

        /// <summary>
        /// Constructs a custom FirewallPolicyErrorCode for a value not among the defined constants.
        /// </summary>
        public FirewallPolicyErrorCode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FirewallPolicyErrorCode FindValue(string value)
        {
            return FindValue<FirewallPolicyErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FirewallPolicyErrorCode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type FirewallRuleAction.
    /// </summary>
    public class FirewallRuleAction : ConstantClass
    {
        /// <summary>
        /// Constant ACCEPT for FirewallRuleAction
        /// </summary>
        public static readonly FirewallRuleAction ACCEPT = new FirewallRuleAction("ACCEPT");

        /// <summary>
        /// Constant DROP for FirewallRuleAction
        /// </summary>
        public static readonly FirewallRuleAction DROP = new FirewallRuleAction("DROP");

        /// <summary>
        /// Constant REJECT for FirewallRuleAction
        /// </summary>
        public static readonly FirewallRuleAction REJECT = new FirewallRuleAction("REJECT");

        /// <summary>
        /// Constant REJECT_BOTH for FirewallRuleAction
        /// </summary>
        public static readonly FirewallRuleAction REJECT_BOTH = new FirewallRuleAction("REJECT_BOTH");

        /// <summary>
        /// Constant REJECT_DST for FirewallRuleAction
        /// </summary>
        public static readonly FirewallRuleAction REJECT_DST = new FirewallRuleAction("REJECT_DST");

        /// <summary>
        /// Constructs a custom FirewallRuleAction for a value not among the defined constants.
        /// </summary>
        public FirewallRuleAction(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FirewallRuleAction FindValue(string value)
        {
            return FindValue<FirewallRuleAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FirewallRuleAction(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type FirewallRuleProtocol.
    /// </summary>
    public class FirewallRuleProtocol : ConstantClass
    {
        /// <summary>
        /// Constant BITTORRENT_DHT for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol BITTORRENT_DHT = new FirewallRuleProtocol("BITTORRENT_DHT");

        /// <summary>
        /// Constant DCERPC for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol DCERPC = new FirewallRuleProtocol("DCERPC");

        /// <summary>
        /// Constant DHCP for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol DHCP = new FirewallRuleProtocol("DHCP");

        /// <summary>
        /// Constant DNP3 for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol DNP3 = new FirewallRuleProtocol("DNP3");

        /// <summary>
        /// Constant DNS for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol DNS = new FirewallRuleProtocol("DNS");

        /// <summary>
        /// Constant DOH2 for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol DOH2 = new FirewallRuleProtocol("DOH2");

        /// <summary>
        /// Constant FTP for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol FTP = new FirewallRuleProtocol("FTP");

        /// <summary>
        /// Constant FTP_DATA for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol FTP_DATA = new FirewallRuleProtocol("FTP_DATA");

        /// <summary>
        /// Constant HTTP for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol HTTP = new FirewallRuleProtocol("HTTP");

        /// <summary>
        /// Constant HTTP2 for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol HTTP2 = new FirewallRuleProtocol("HTTP2");

        /// <summary>
        /// Constant ICMP for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol ICMP = new FirewallRuleProtocol("ICMP");

        /// <summary>
        /// Constant ICMPV4 for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol ICMPV4 = new FirewallRuleProtocol("ICMPV4");

        /// <summary>
        /// Constant ICMPV6 for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol ICMPV6 = new FirewallRuleProtocol("ICMPV6");

        /// <summary>
        /// Constant IKEV2 for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol IKEV2 = new FirewallRuleProtocol("IKEV2");

        /// <summary>
        /// Constant IP for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol IP = new FirewallRuleProtocol("IP");

        /// <summary>
        /// Constant IPV4 for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol IPV4 = new FirewallRuleProtocol("IPV4");

        /// <summary>
        /// Constant IPV6 for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol IPV6 = new FirewallRuleProtocol("IPV6");

        /// <summary>
        /// Constant KRB5 for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol KRB5 = new FirewallRuleProtocol("KRB5");

        /// <summary>
        /// Constant LDAP for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol LDAP = new FirewallRuleProtocol("LDAP");

        /// <summary>
        /// Constant MDNS for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol MDNS = new FirewallRuleProtocol("MDNS");

        /// <summary>
        /// Constant MQTT for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol MQTT = new FirewallRuleProtocol("MQTT");

        /// <summary>
        /// Constant MSN for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol MSN = new FirewallRuleProtocol("MSN");

        /// <summary>
        /// Constant NFS for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol NFS = new FirewallRuleProtocol("NFS");

        /// <summary>
        /// Constant NTP for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol NTP = new FirewallRuleProtocol("NTP");

        /// <summary>
        /// Constant PGSQL for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol PGSQL = new FirewallRuleProtocol("PGSQL");

        /// <summary>
        /// Constant POP3 for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol POP3 = new FirewallRuleProtocol("POP3");

        /// <summary>
        /// Constant QUIC for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol QUIC = new FirewallRuleProtocol("QUIC");

        /// <summary>
        /// Constant RDP for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol RDP = new FirewallRuleProtocol("RDP");

        /// <summary>
        /// Constant RFB for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol RFB = new FirewallRuleProtocol("RFB");

        /// <summary>
        /// Constant SCTP for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol SCTP = new FirewallRuleProtocol("SCTP");

        /// <summary>
        /// Constant SMB for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol SMB = new FirewallRuleProtocol("SMB");

        /// <summary>
        /// Constant SMTP for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol SMTP = new FirewallRuleProtocol("SMTP");

        /// <summary>
        /// Constant SNMP for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol SNMP = new FirewallRuleProtocol("SNMP");

        /// <summary>
        /// Constant SSH for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol SSH = new FirewallRuleProtocol("SSH");

        /// <summary>
        /// Constant TCP for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol TCP = new FirewallRuleProtocol("TCP");

        /// <summary>
        /// Constant TELNET for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol TELNET = new FirewallRuleProtocol("TELNET");

        /// <summary>
        /// Constant TFTP for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol TFTP = new FirewallRuleProtocol("TFTP");

        /// <summary>
        /// Constant TLS for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol TLS = new FirewallRuleProtocol("TLS");

        /// <summary>
        /// Constant UDP for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol UDP = new FirewallRuleProtocol("UDP");

        /// <summary>
        /// Constant WEBSOCKET for FirewallRuleProtocol
        /// </summary>
        public static readonly FirewallRuleProtocol WEBSOCKET = new FirewallRuleProtocol("WEBSOCKET");

        /// <summary>
        /// Constructs a custom FirewallRuleProtocol for a value not among the defined constants.
        /// </summary>
        public FirewallRuleProtocol(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FirewallRuleProtocol FindValue(string value)
        {
            return FindValue<FirewallRuleProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FirewallRuleProtocol(string value)
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
        /// Constant FAILED for FirewallStatusValue
        /// </summary>
        public static readonly FirewallStatusValue FAILED = new FirewallStatusValue("FAILED");

        /// <summary>
        /// Constant PROVISIONING for FirewallStatusValue
        /// </summary>
        public static readonly FirewallStatusValue PROVISIONING = new FirewallStatusValue("PROVISIONING");

        /// <summary>
        /// Constant READY for FirewallStatusValue
        /// </summary>
        public static readonly FirewallStatusValue READY = new FirewallStatusValue("READY");

        /// <summary>
        /// Constructs a custom FirewallStatusValue for a value not among the defined constants.
        /// </summary>
        public FirewallStatusValue(string value) : base(value) { }

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
    /// Constants used for properties of type FlowOperationStatus.
    /// </summary>
    public class FlowOperationStatus : ConstantClass
    {
        /// <summary>
        /// Constant COMPLETED for FlowOperationStatus
        /// </summary>
        public static readonly FlowOperationStatus COMPLETED = new FlowOperationStatus("COMPLETED");

        /// <summary>
        /// Constant COMPLETED_WITH_ERRORS for FlowOperationStatus
        /// </summary>
        public static readonly FlowOperationStatus COMPLETED_WITH_ERRORS = new FlowOperationStatus("COMPLETED_WITH_ERRORS");

        /// <summary>
        /// Constant FAILED for FlowOperationStatus
        /// </summary>
        public static readonly FlowOperationStatus FAILED = new FlowOperationStatus("FAILED");

        /// <summary>
        /// Constant IN_PROGRESS for FlowOperationStatus
        /// </summary>
        public static readonly FlowOperationStatus IN_PROGRESS = new FlowOperationStatus("IN_PROGRESS");

        /// <summary>
        /// Constructs a custom FlowOperationStatus for a value not among the defined constants.
        /// </summary>
        public FlowOperationStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FlowOperationStatus FindValue(string value)
        {
            return FindValue<FlowOperationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FlowOperationStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type FlowOperationType.
    /// </summary>
    public class FlowOperationType : ConstantClass
    {
        /// <summary>
        /// Constant FLOW_CAPTURE for FlowOperationType
        /// </summary>
        public static readonly FlowOperationType FLOW_CAPTURE = new FlowOperationType("FLOW_CAPTURE");

        /// <summary>
        /// Constant FLOW_FLUSH for FlowOperationType
        /// </summary>
        public static readonly FlowOperationType FLOW_FLUSH = new FlowOperationType("FLOW_FLUSH");

        /// <summary>
        /// Constructs a custom FlowOperationType for a value not among the defined constants.
        /// </summary>
        public FlowOperationType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FlowOperationType FindValue(string value)
        {
            return FindValue<FlowOperationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FlowOperationType(string value)
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
        /// Constant ALERTLIST for GeneratedRulesType
        /// </summary>
        public static readonly GeneratedRulesType ALERTLIST = new GeneratedRulesType("ALERTLIST");

        /// <summary>
        /// Constant ALLOWLIST for GeneratedRulesType
        /// </summary>
        public static readonly GeneratedRulesType ALLOWLIST = new GeneratedRulesType("ALLOWLIST");

        /// <summary>
        /// Constant DENYLIST for GeneratedRulesType
        /// </summary>
        public static readonly GeneratedRulesType DENYLIST = new GeneratedRulesType("DENYLIST");

        /// <summary>
        /// Constant REJECTLIST for GeneratedRulesType
        /// </summary>
        public static readonly GeneratedRulesType REJECTLIST = new GeneratedRulesType("REJECTLIST");

        /// <summary>
        /// Constructs a custom GeneratedRulesType for a value not among the defined constants.
        /// </summary>
        public GeneratedRulesType(string value) : base(value) { }

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
    /// Constants used for properties of type HookKey.
    /// </summary>
    public class HookKey : ConstantClass
    {
        /// <summary>
        /// Constant BITTORRENT_DHT_REQUEST_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey BITTORRENT_DHT_REQUEST_COMPLETE = new HookKey("BITTORRENT_DHT_REQUEST_COMPLETE");

        /// <summary>
        /// Constant BITTORRENT_DHT_REQUEST_STARTED for HookKey
        /// </summary>
        public static readonly HookKey BITTORRENT_DHT_REQUEST_STARTED = new HookKey("BITTORRENT_DHT_REQUEST_STARTED");

        /// <summary>
        /// Constant BITTORRENT_DHT_RESPONSE_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey BITTORRENT_DHT_RESPONSE_COMPLETE = new HookKey("BITTORRENT_DHT_RESPONSE_COMPLETE");

        /// <summary>
        /// Constant BITTORRENT_DHT_RESPONSE_STARTED for HookKey
        /// </summary>
        public static readonly HookKey BITTORRENT_DHT_RESPONSE_STARTED = new HookKey("BITTORRENT_DHT_RESPONSE_STARTED");

        /// <summary>
        /// Constant DCERPC_REQUEST_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey DCERPC_REQUEST_COMPLETE = new HookKey("DCERPC_REQUEST_COMPLETE");

        /// <summary>
        /// Constant DCERPC_REQUEST_STARTED for HookKey
        /// </summary>
        public static readonly HookKey DCERPC_REQUEST_STARTED = new HookKey("DCERPC_REQUEST_STARTED");

        /// <summary>
        /// Constant DCERPC_RESPONSE_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey DCERPC_RESPONSE_COMPLETE = new HookKey("DCERPC_RESPONSE_COMPLETE");

        /// <summary>
        /// Constant DCERPC_RESPONSE_STARTED for HookKey
        /// </summary>
        public static readonly HookKey DCERPC_RESPONSE_STARTED = new HookKey("DCERPC_RESPONSE_STARTED");

        /// <summary>
        /// Constant DHCP_REQUEST_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey DHCP_REQUEST_COMPLETE = new HookKey("DHCP_REQUEST_COMPLETE");

        /// <summary>
        /// Constant DHCP_REQUEST_STARTED for HookKey
        /// </summary>
        public static readonly HookKey DHCP_REQUEST_STARTED = new HookKey("DHCP_REQUEST_STARTED");

        /// <summary>
        /// Constant DHCP_RESPONSE_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey DHCP_RESPONSE_COMPLETE = new HookKey("DHCP_RESPONSE_COMPLETE");

        /// <summary>
        /// Constant DHCP_RESPONSE_STARTED for HookKey
        /// </summary>
        public static readonly HookKey DHCP_RESPONSE_STARTED = new HookKey("DHCP_RESPONSE_STARTED");

        /// <summary>
        /// Constant DNP3_REQUEST_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey DNP3_REQUEST_COMPLETE = new HookKey("DNP3_REQUEST_COMPLETE");

        /// <summary>
        /// Constant DNP3_REQUEST_STARTED for HookKey
        /// </summary>
        public static readonly HookKey DNP3_REQUEST_STARTED = new HookKey("DNP3_REQUEST_STARTED");

        /// <summary>
        /// Constant DNP3_RESPONSE_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey DNP3_RESPONSE_COMPLETE = new HookKey("DNP3_RESPONSE_COMPLETE");

        /// <summary>
        /// Constant DNP3_RESPONSE_STARTED for HookKey
        /// </summary>
        public static readonly HookKey DNP3_RESPONSE_STARTED = new HookKey("DNP3_RESPONSE_STARTED");

        /// <summary>
        /// Constant DNS_REQUEST_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey DNS_REQUEST_COMPLETE = new HookKey("DNS_REQUEST_COMPLETE");

        /// <summary>
        /// Constant DNS_REQUEST_STARTED for HookKey
        /// </summary>
        public static readonly HookKey DNS_REQUEST_STARTED = new HookKey("DNS_REQUEST_STARTED");

        /// <summary>
        /// Constant DNS_RESPONSE_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey DNS_RESPONSE_COMPLETE = new HookKey("DNS_RESPONSE_COMPLETE");

        /// <summary>
        /// Constant DNS_RESPONSE_STARTED for HookKey
        /// </summary>
        public static readonly HookKey DNS_RESPONSE_STARTED = new HookKey("DNS_RESPONSE_STARTED");

        /// <summary>
        /// Constant DOH2_GLOBAL_REQUEST_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey DOH2_GLOBAL_REQUEST_COMPLETE = new HookKey("DOH2_GLOBAL_REQUEST_COMPLETE");

        /// <summary>
        /// Constant DOH2_GLOBAL_REQUEST_STARTED for HookKey
        /// </summary>
        public static readonly HookKey DOH2_GLOBAL_REQUEST_STARTED = new HookKey("DOH2_GLOBAL_REQUEST_STARTED");

        /// <summary>
        /// Constant DOH2_GLOBAL_RESPONSE_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey DOH2_GLOBAL_RESPONSE_COMPLETE = new HookKey("DOH2_GLOBAL_RESPONSE_COMPLETE");

        /// <summary>
        /// Constant DOH2_GLOBAL_RESPONSE_STARTED for HookKey
        /// </summary>
        public static readonly HookKey DOH2_GLOBAL_RESPONSE_STARTED = new HookKey("DOH2_GLOBAL_RESPONSE_STARTED");

        /// <summary>
        /// Constant DOH2_STREAM_REQUEST_CLOSED for HookKey
        /// </summary>
        public static readonly HookKey DOH2_STREAM_REQUEST_CLOSED = new HookKey("DOH2_STREAM_REQUEST_CLOSED");

        /// <summary>
        /// Constant DOH2_STREAM_REQUEST_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey DOH2_STREAM_REQUEST_COMPLETE = new HookKey("DOH2_STREAM_REQUEST_COMPLETE");

        /// <summary>
        /// Constant DOH2_STREAM_REQUEST_DATA for HookKey
        /// </summary>
        public static readonly HookKey DOH2_STREAM_REQUEST_DATA = new HookKey("DOH2_STREAM_REQUEST_DATA");

        /// <summary>
        /// Constant DOH2_STREAM_REQUEST_HEADERS for HookKey
        /// </summary>
        public static readonly HookKey DOH2_STREAM_REQUEST_HEADERS = new HookKey("DOH2_STREAM_REQUEST_HEADERS");

        /// <summary>
        /// Constant DOH2_STREAM_REQUEST_STARTED for HookKey
        /// </summary>
        public static readonly HookKey DOH2_STREAM_REQUEST_STARTED = new HookKey("DOH2_STREAM_REQUEST_STARTED");

        /// <summary>
        /// Constant DOH2_STREAM_RESPONSE_CLOSED for HookKey
        /// </summary>
        public static readonly HookKey DOH2_STREAM_RESPONSE_CLOSED = new HookKey("DOH2_STREAM_RESPONSE_CLOSED");

        /// <summary>
        /// Constant DOH2_STREAM_RESPONSE_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey DOH2_STREAM_RESPONSE_COMPLETE = new HookKey("DOH2_STREAM_RESPONSE_COMPLETE");

        /// <summary>
        /// Constant DOH2_STREAM_RESPONSE_DATA for HookKey
        /// </summary>
        public static readonly HookKey DOH2_STREAM_RESPONSE_DATA = new HookKey("DOH2_STREAM_RESPONSE_DATA");

        /// <summary>
        /// Constant DOH2_STREAM_RESPONSE_HEADERS for HookKey
        /// </summary>
        public static readonly HookKey DOH2_STREAM_RESPONSE_HEADERS = new HookKey("DOH2_STREAM_RESPONSE_HEADERS");

        /// <summary>
        /// Constant DOH2_STREAM_RESPONSE_STARTED for HookKey
        /// </summary>
        public static readonly HookKey DOH2_STREAM_RESPONSE_STARTED = new HookKey("DOH2_STREAM_RESPONSE_STARTED");

        /// <summary>
        /// Constant FTP_DATA_REQUEST_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey FTP_DATA_REQUEST_COMPLETE = new HookKey("FTP_DATA_REQUEST_COMPLETE");

        /// <summary>
        /// Constant FTP_DATA_REQUEST_STARTED for HookKey
        /// </summary>
        public static readonly HookKey FTP_DATA_REQUEST_STARTED = new HookKey("FTP_DATA_REQUEST_STARTED");

        /// <summary>
        /// Constant FTP_DATA_RESPONSE_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey FTP_DATA_RESPONSE_COMPLETE = new HookKey("FTP_DATA_RESPONSE_COMPLETE");

        /// <summary>
        /// Constant FTP_DATA_RESPONSE_STARTED for HookKey
        /// </summary>
        public static readonly HookKey FTP_DATA_RESPONSE_STARTED = new HookKey("FTP_DATA_RESPONSE_STARTED");

        /// <summary>
        /// Constant FTP_REQUEST_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey FTP_REQUEST_COMPLETE = new HookKey("FTP_REQUEST_COMPLETE");

        /// <summary>
        /// Constant FTP_REQUEST_STARTED for HookKey
        /// </summary>
        public static readonly HookKey FTP_REQUEST_STARTED = new HookKey("FTP_REQUEST_STARTED");

        /// <summary>
        /// Constant FTP_RESPONSE_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey FTP_RESPONSE_COMPLETE = new HookKey("FTP_RESPONSE_COMPLETE");

        /// <summary>
        /// Constant FTP_RESPONSE_STARTED for HookKey
        /// </summary>
        public static readonly HookKey FTP_RESPONSE_STARTED = new HookKey("FTP_RESPONSE_STARTED");

        /// <summary>
        /// Constant HTTP1_REQUEST_BODY for HookKey
        /// </summary>
        public static readonly HookKey HTTP1_REQUEST_BODY = new HookKey("HTTP1_REQUEST_BODY");

        /// <summary>
        /// Constant HTTP1_REQUEST_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey HTTP1_REQUEST_COMPLETE = new HookKey("HTTP1_REQUEST_COMPLETE");

        /// <summary>
        /// Constant HTTP1_REQUEST_HEADERS for HookKey
        /// </summary>
        public static readonly HookKey HTTP1_REQUEST_HEADERS = new HookKey("HTTP1_REQUEST_HEADERS");

        /// <summary>
        /// Constant HTTP1_REQUEST_LINE for HookKey
        /// </summary>
        public static readonly HookKey HTTP1_REQUEST_LINE = new HookKey("HTTP1_REQUEST_LINE");

        /// <summary>
        /// Constant HTTP1_REQUEST_STARTED for HookKey
        /// </summary>
        public static readonly HookKey HTTP1_REQUEST_STARTED = new HookKey("HTTP1_REQUEST_STARTED");

        /// <summary>
        /// Constant HTTP1_REQUEST_TRAILER for HookKey
        /// </summary>
        public static readonly HookKey HTTP1_REQUEST_TRAILER = new HookKey("HTTP1_REQUEST_TRAILER");

        /// <summary>
        /// Constant HTTP1_RESPONSE_BODY for HookKey
        /// </summary>
        public static readonly HookKey HTTP1_RESPONSE_BODY = new HookKey("HTTP1_RESPONSE_BODY");

        /// <summary>
        /// Constant HTTP1_RESPONSE_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey HTTP1_RESPONSE_COMPLETE = new HookKey("HTTP1_RESPONSE_COMPLETE");

        /// <summary>
        /// Constant HTTP1_RESPONSE_HEADERS for HookKey
        /// </summary>
        public static readonly HookKey HTTP1_RESPONSE_HEADERS = new HookKey("HTTP1_RESPONSE_HEADERS");

        /// <summary>
        /// Constant HTTP1_RESPONSE_LINE for HookKey
        /// </summary>
        public static readonly HookKey HTTP1_RESPONSE_LINE = new HookKey("HTTP1_RESPONSE_LINE");

        /// <summary>
        /// Constant HTTP1_RESPONSE_STARTED for HookKey
        /// </summary>
        public static readonly HookKey HTTP1_RESPONSE_STARTED = new HookKey("HTTP1_RESPONSE_STARTED");

        /// <summary>
        /// Constant HTTP1_RESPONSE_TRAILER for HookKey
        /// </summary>
        public static readonly HookKey HTTP1_RESPONSE_TRAILER = new HookKey("HTTP1_RESPONSE_TRAILER");

        /// <summary>
        /// Constant HTTP2_GLOBAL_REQUEST_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey HTTP2_GLOBAL_REQUEST_COMPLETE = new HookKey("HTTP2_GLOBAL_REQUEST_COMPLETE");

        /// <summary>
        /// Constant HTTP2_GLOBAL_REQUEST_STARTED for HookKey
        /// </summary>
        public static readonly HookKey HTTP2_GLOBAL_REQUEST_STARTED = new HookKey("HTTP2_GLOBAL_REQUEST_STARTED");

        /// <summary>
        /// Constant HTTP2_GLOBAL_RESPONSE_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey HTTP2_GLOBAL_RESPONSE_COMPLETE = new HookKey("HTTP2_GLOBAL_RESPONSE_COMPLETE");

        /// <summary>
        /// Constant HTTP2_GLOBAL_RESPONSE_STARTED for HookKey
        /// </summary>
        public static readonly HookKey HTTP2_GLOBAL_RESPONSE_STARTED = new HookKey("HTTP2_GLOBAL_RESPONSE_STARTED");

        /// <summary>
        /// Constant HTTP2_STREAM_REQUEST_CLOSED for HookKey
        /// </summary>
        public static readonly HookKey HTTP2_STREAM_REQUEST_CLOSED = new HookKey("HTTP2_STREAM_REQUEST_CLOSED");

        /// <summary>
        /// Constant HTTP2_STREAM_REQUEST_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey HTTP2_STREAM_REQUEST_COMPLETE = new HookKey("HTTP2_STREAM_REQUEST_COMPLETE");

        /// <summary>
        /// Constant HTTP2_STREAM_REQUEST_DATA for HookKey
        /// </summary>
        public static readonly HookKey HTTP2_STREAM_REQUEST_DATA = new HookKey("HTTP2_STREAM_REQUEST_DATA");

        /// <summary>
        /// Constant HTTP2_STREAM_REQUEST_HEADERS for HookKey
        /// </summary>
        public static readonly HookKey HTTP2_STREAM_REQUEST_HEADERS = new HookKey("HTTP2_STREAM_REQUEST_HEADERS");

        /// <summary>
        /// Constant HTTP2_STREAM_REQUEST_STARTED for HookKey
        /// </summary>
        public static readonly HookKey HTTP2_STREAM_REQUEST_STARTED = new HookKey("HTTP2_STREAM_REQUEST_STARTED");

        /// <summary>
        /// Constant HTTP2_STREAM_RESPONSE_CLOSED for HookKey
        /// </summary>
        public static readonly HookKey HTTP2_STREAM_RESPONSE_CLOSED = new HookKey("HTTP2_STREAM_RESPONSE_CLOSED");

        /// <summary>
        /// Constant HTTP2_STREAM_RESPONSE_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey HTTP2_STREAM_RESPONSE_COMPLETE = new HookKey("HTTP2_STREAM_RESPONSE_COMPLETE");

        /// <summary>
        /// Constant HTTP2_STREAM_RESPONSE_DATA for HookKey
        /// </summary>
        public static readonly HookKey HTTP2_STREAM_RESPONSE_DATA = new HookKey("HTTP2_STREAM_RESPONSE_DATA");

        /// <summary>
        /// Constant HTTP2_STREAM_RESPONSE_HEADERS for HookKey
        /// </summary>
        public static readonly HookKey HTTP2_STREAM_RESPONSE_HEADERS = new HookKey("HTTP2_STREAM_RESPONSE_HEADERS");

        /// <summary>
        /// Constant HTTP2_STREAM_RESPONSE_STARTED for HookKey
        /// </summary>
        public static readonly HookKey HTTP2_STREAM_RESPONSE_STARTED = new HookKey("HTTP2_STREAM_RESPONSE_STARTED");

        /// <summary>
        /// Constant ICMPV4_ALL for HookKey
        /// </summary>
        public static readonly HookKey ICMPV4_ALL = new HookKey("ICMPV4_ALL");

        /// <summary>
        /// Constant ICMPV4_FLOW_START for HookKey
        /// </summary>
        public static readonly HookKey ICMPV4_FLOW_START = new HookKey("ICMPV4_FLOW_START");

        /// <summary>
        /// Constant ICMPV4_PRE_FLOW for HookKey
        /// </summary>
        public static readonly HookKey ICMPV4_PRE_FLOW = new HookKey("ICMPV4_PRE_FLOW");

        /// <summary>
        /// Constant ICMPV4_PRE_STREAM for HookKey
        /// </summary>
        public static readonly HookKey ICMPV4_PRE_STREAM = new HookKey("ICMPV4_PRE_STREAM");

        /// <summary>
        /// Constant ICMPV6_ALL for HookKey
        /// </summary>
        public static readonly HookKey ICMPV6_ALL = new HookKey("ICMPV6_ALL");

        /// <summary>
        /// Constant ICMPV6_FLOW_START for HookKey
        /// </summary>
        public static readonly HookKey ICMPV6_FLOW_START = new HookKey("ICMPV6_FLOW_START");

        /// <summary>
        /// Constant ICMPV6_PRE_FLOW for HookKey
        /// </summary>
        public static readonly HookKey ICMPV6_PRE_FLOW = new HookKey("ICMPV6_PRE_FLOW");

        /// <summary>
        /// Constant ICMPV6_PRE_STREAM for HookKey
        /// </summary>
        public static readonly HookKey ICMPV6_PRE_STREAM = new HookKey("ICMPV6_PRE_STREAM");

        /// <summary>
        /// Constant ICMP_ALL for HookKey
        /// </summary>
        public static readonly HookKey ICMP_ALL = new HookKey("ICMP_ALL");

        /// <summary>
        /// Constant ICMP_FLOW_START for HookKey
        /// </summary>
        public static readonly HookKey ICMP_FLOW_START = new HookKey("ICMP_FLOW_START");

        /// <summary>
        /// Constant ICMP_PRE_FLOW for HookKey
        /// </summary>
        public static readonly HookKey ICMP_PRE_FLOW = new HookKey("ICMP_PRE_FLOW");

        /// <summary>
        /// Constant ICMP_PRE_STREAM for HookKey
        /// </summary>
        public static readonly HookKey ICMP_PRE_STREAM = new HookKey("ICMP_PRE_STREAM");

        /// <summary>
        /// Constant IKE_REQUEST_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey IKE_REQUEST_COMPLETE = new HookKey("IKE_REQUEST_COMPLETE");

        /// <summary>
        /// Constant IKE_REQUEST_STARTED for HookKey
        /// </summary>
        public static readonly HookKey IKE_REQUEST_STARTED = new HookKey("IKE_REQUEST_STARTED");

        /// <summary>
        /// Constant IKE_RESPONSE_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey IKE_RESPONSE_COMPLETE = new HookKey("IKE_RESPONSE_COMPLETE");

        /// <summary>
        /// Constant IKE_RESPONSE_STARTED for HookKey
        /// </summary>
        public static readonly HookKey IKE_RESPONSE_STARTED = new HookKey("IKE_RESPONSE_STARTED");

        /// <summary>
        /// Constant IPV4_ALL for HookKey
        /// </summary>
        public static readonly HookKey IPV4_ALL = new HookKey("IPV4_ALL");

        /// <summary>
        /// Constant IPV4_FLOW_START for HookKey
        /// </summary>
        public static readonly HookKey IPV4_FLOW_START = new HookKey("IPV4_FLOW_START");

        /// <summary>
        /// Constant IPV4_PRE_FLOW for HookKey
        /// </summary>
        public static readonly HookKey IPV4_PRE_FLOW = new HookKey("IPV4_PRE_FLOW");

        /// <summary>
        /// Constant IPV4_PRE_STREAM for HookKey
        /// </summary>
        public static readonly HookKey IPV4_PRE_STREAM = new HookKey("IPV4_PRE_STREAM");

        /// <summary>
        /// Constant IPV6_ALL for HookKey
        /// </summary>
        public static readonly HookKey IPV6_ALL = new HookKey("IPV6_ALL");

        /// <summary>
        /// Constant IPV6_FLOW_START for HookKey
        /// </summary>
        public static readonly HookKey IPV6_FLOW_START = new HookKey("IPV6_FLOW_START");

        /// <summary>
        /// Constant IPV6_PRE_FLOW for HookKey
        /// </summary>
        public static readonly HookKey IPV6_PRE_FLOW = new HookKey("IPV6_PRE_FLOW");

        /// <summary>
        /// Constant IPV6_PRE_STREAM for HookKey
        /// </summary>
        public static readonly HookKey IPV6_PRE_STREAM = new HookKey("IPV6_PRE_STREAM");

        /// <summary>
        /// Constant IP_ALL for HookKey
        /// </summary>
        public static readonly HookKey IP_ALL = new HookKey("IP_ALL");

        /// <summary>
        /// Constant IP_FLOW_START for HookKey
        /// </summary>
        public static readonly HookKey IP_FLOW_START = new HookKey("IP_FLOW_START");

        /// <summary>
        /// Constant IP_PRE_FLOW for HookKey
        /// </summary>
        public static readonly HookKey IP_PRE_FLOW = new HookKey("IP_PRE_FLOW");

        /// <summary>
        /// Constant IP_PRE_STREAM for HookKey
        /// </summary>
        public static readonly HookKey IP_PRE_STREAM = new HookKey("IP_PRE_STREAM");

        /// <summary>
        /// Constant KRB5_REQUEST_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey KRB5_REQUEST_COMPLETE = new HookKey("KRB5_REQUEST_COMPLETE");

        /// <summary>
        /// Constant KRB5_REQUEST_STARTED for HookKey
        /// </summary>
        public static readonly HookKey KRB5_REQUEST_STARTED = new HookKey("KRB5_REQUEST_STARTED");

        /// <summary>
        /// Constant KRB5_RESPONSE_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey KRB5_RESPONSE_COMPLETE = new HookKey("KRB5_RESPONSE_COMPLETE");

        /// <summary>
        /// Constant KRB5_RESPONSE_STARTED for HookKey
        /// </summary>
        public static readonly HookKey KRB5_RESPONSE_STARTED = new HookKey("KRB5_RESPONSE_STARTED");

        /// <summary>
        /// Constant LDAP_REQUEST_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey LDAP_REQUEST_COMPLETE = new HookKey("LDAP_REQUEST_COMPLETE");

        /// <summary>
        /// Constant LDAP_REQUEST_STARTED for HookKey
        /// </summary>
        public static readonly HookKey LDAP_REQUEST_STARTED = new HookKey("LDAP_REQUEST_STARTED");

        /// <summary>
        /// Constant LDAP_RESPONSE_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey LDAP_RESPONSE_COMPLETE = new HookKey("LDAP_RESPONSE_COMPLETE");

        /// <summary>
        /// Constant LDAP_RESPONSE_STARTED for HookKey
        /// </summary>
        public static readonly HookKey LDAP_RESPONSE_STARTED = new HookKey("LDAP_RESPONSE_STARTED");

        /// <summary>
        /// Constant MDNS_REQUEST_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey MDNS_REQUEST_COMPLETE = new HookKey("MDNS_REQUEST_COMPLETE");

        /// <summary>
        /// Constant MDNS_REQUEST_STARTED for HookKey
        /// </summary>
        public static readonly HookKey MDNS_REQUEST_STARTED = new HookKey("MDNS_REQUEST_STARTED");

        /// <summary>
        /// Constant MDNS_RESPONSE_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey MDNS_RESPONSE_COMPLETE = new HookKey("MDNS_RESPONSE_COMPLETE");

        /// <summary>
        /// Constant MDNS_RESPONSE_STARTED for HookKey
        /// </summary>
        public static readonly HookKey MDNS_RESPONSE_STARTED = new HookKey("MDNS_RESPONSE_STARTED");

        /// <summary>
        /// Constant MQTT_REQUEST_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey MQTT_REQUEST_COMPLETE = new HookKey("MQTT_REQUEST_COMPLETE");

        /// <summary>
        /// Constant MQTT_REQUEST_STARTED for HookKey
        /// </summary>
        public static readonly HookKey MQTT_REQUEST_STARTED = new HookKey("MQTT_REQUEST_STARTED");

        /// <summary>
        /// Constant MQTT_RESPONSE_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey MQTT_RESPONSE_COMPLETE = new HookKey("MQTT_RESPONSE_COMPLETE");

        /// <summary>
        /// Constant MQTT_RESPONSE_STARTED for HookKey
        /// </summary>
        public static readonly HookKey MQTT_RESPONSE_STARTED = new HookKey("MQTT_RESPONSE_STARTED");

        /// <summary>
        /// Constant NFS_REQUEST_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey NFS_REQUEST_COMPLETE = new HookKey("NFS_REQUEST_COMPLETE");

        /// <summary>
        /// Constant NFS_REQUEST_STARTED for HookKey
        /// </summary>
        public static readonly HookKey NFS_REQUEST_STARTED = new HookKey("NFS_REQUEST_STARTED");

        /// <summary>
        /// Constant NFS_RESPONSE_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey NFS_RESPONSE_COMPLETE = new HookKey("NFS_RESPONSE_COMPLETE");

        /// <summary>
        /// Constant NFS_RESPONSE_STARTED for HookKey
        /// </summary>
        public static readonly HookKey NFS_RESPONSE_STARTED = new HookKey("NFS_RESPONSE_STARTED");

        /// <summary>
        /// Constant NTP_REQUEST_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey NTP_REQUEST_COMPLETE = new HookKey("NTP_REQUEST_COMPLETE");

        /// <summary>
        /// Constant NTP_REQUEST_STARTED for HookKey
        /// </summary>
        public static readonly HookKey NTP_REQUEST_STARTED = new HookKey("NTP_REQUEST_STARTED");

        /// <summary>
        /// Constant NTP_RESPONSE_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey NTP_RESPONSE_COMPLETE = new HookKey("NTP_RESPONSE_COMPLETE");

        /// <summary>
        /// Constant NTP_RESPONSE_STARTED for HookKey
        /// </summary>
        public static readonly HookKey NTP_RESPONSE_STARTED = new HookKey("NTP_RESPONSE_STARTED");

        /// <summary>
        /// Constant PGSQL_REQUEST_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey PGSQL_REQUEST_COMPLETE = new HookKey("PGSQL_REQUEST_COMPLETE");

        /// <summary>
        /// Constant PGSQL_REQUEST_STARTED for HookKey
        /// </summary>
        public static readonly HookKey PGSQL_REQUEST_STARTED = new HookKey("PGSQL_REQUEST_STARTED");

        /// <summary>
        /// Constant PGSQL_RESPONSE_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey PGSQL_RESPONSE_COMPLETE = new HookKey("PGSQL_RESPONSE_COMPLETE");

        /// <summary>
        /// Constant PGSQL_RESPONSE_STARTED for HookKey
        /// </summary>
        public static readonly HookKey PGSQL_RESPONSE_STARTED = new HookKey("PGSQL_RESPONSE_STARTED");

        /// <summary>
        /// Constant POP3_REQUEST_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey POP3_REQUEST_COMPLETE = new HookKey("POP3_REQUEST_COMPLETE");

        /// <summary>
        /// Constant POP3_REQUEST_STARTED for HookKey
        /// </summary>
        public static readonly HookKey POP3_REQUEST_STARTED = new HookKey("POP3_REQUEST_STARTED");

        /// <summary>
        /// Constant POP3_RESPONSE_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey POP3_RESPONSE_COMPLETE = new HookKey("POP3_RESPONSE_COMPLETE");

        /// <summary>
        /// Constant POP3_RESPONSE_STARTED for HookKey
        /// </summary>
        public static readonly HookKey POP3_RESPONSE_STARTED = new HookKey("POP3_RESPONSE_STARTED");

        /// <summary>
        /// Constant QUIC_REQUEST_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey QUIC_REQUEST_COMPLETE = new HookKey("QUIC_REQUEST_COMPLETE");

        /// <summary>
        /// Constant QUIC_REQUEST_STARTED for HookKey
        /// </summary>
        public static readonly HookKey QUIC_REQUEST_STARTED = new HookKey("QUIC_REQUEST_STARTED");

        /// <summary>
        /// Constant QUIC_RESPONSE_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey QUIC_RESPONSE_COMPLETE = new HookKey("QUIC_RESPONSE_COMPLETE");

        /// <summary>
        /// Constant QUIC_RESPONSE_STARTED for HookKey
        /// </summary>
        public static readonly HookKey QUIC_RESPONSE_STARTED = new HookKey("QUIC_RESPONSE_STARTED");

        /// <summary>
        /// Constant RDP_REQUEST_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey RDP_REQUEST_COMPLETE = new HookKey("RDP_REQUEST_COMPLETE");

        /// <summary>
        /// Constant RDP_REQUEST_STARTED for HookKey
        /// </summary>
        public static readonly HookKey RDP_REQUEST_STARTED = new HookKey("RDP_REQUEST_STARTED");

        /// <summary>
        /// Constant RDP_RESPONSE_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey RDP_RESPONSE_COMPLETE = new HookKey("RDP_RESPONSE_COMPLETE");

        /// <summary>
        /// Constant RDP_RESPONSE_STARTED for HookKey
        /// </summary>
        public static readonly HookKey RDP_RESPONSE_STARTED = new HookKey("RDP_RESPONSE_STARTED");

        /// <summary>
        /// Constant RFB_REQUEST_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey RFB_REQUEST_COMPLETE = new HookKey("RFB_REQUEST_COMPLETE");

        /// <summary>
        /// Constant RFB_REQUEST_STARTED for HookKey
        /// </summary>
        public static readonly HookKey RFB_REQUEST_STARTED = new HookKey("RFB_REQUEST_STARTED");

        /// <summary>
        /// Constant RFB_RESPONSE_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey RFB_RESPONSE_COMPLETE = new HookKey("RFB_RESPONSE_COMPLETE");

        /// <summary>
        /// Constant RFB_RESPONSE_STARTED for HookKey
        /// </summary>
        public static readonly HookKey RFB_RESPONSE_STARTED = new HookKey("RFB_RESPONSE_STARTED");

        /// <summary>
        /// Constant SCTP_ALL for HookKey
        /// </summary>
        public static readonly HookKey SCTP_ALL = new HookKey("SCTP_ALL");

        /// <summary>
        /// Constant SCTP_FLOW_START for HookKey
        /// </summary>
        public static readonly HookKey SCTP_FLOW_START = new HookKey("SCTP_FLOW_START");

        /// <summary>
        /// Constant SCTP_PRE_FLOW for HookKey
        /// </summary>
        public static readonly HookKey SCTP_PRE_FLOW = new HookKey("SCTP_PRE_FLOW");

        /// <summary>
        /// Constant SCTP_PRE_STREAM for HookKey
        /// </summary>
        public static readonly HookKey SCTP_PRE_STREAM = new HookKey("SCTP_PRE_STREAM");

        /// <summary>
        /// Constant SMB_REQUEST_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey SMB_REQUEST_COMPLETE = new HookKey("SMB_REQUEST_COMPLETE");

        /// <summary>
        /// Constant SMB_REQUEST_STARTED for HookKey
        /// </summary>
        public static readonly HookKey SMB_REQUEST_STARTED = new HookKey("SMB_REQUEST_STARTED");

        /// <summary>
        /// Constant SMB_RESPONSE_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey SMB_RESPONSE_COMPLETE = new HookKey("SMB_RESPONSE_COMPLETE");

        /// <summary>
        /// Constant SMB_RESPONSE_STARTED for HookKey
        /// </summary>
        public static readonly HookKey SMB_RESPONSE_STARTED = new HookKey("SMB_RESPONSE_STARTED");

        /// <summary>
        /// Constant SMTP_REQUEST_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey SMTP_REQUEST_COMPLETE = new HookKey("SMTP_REQUEST_COMPLETE");

        /// <summary>
        /// Constant SMTP_REQUEST_DATA for HookKey
        /// </summary>
        public static readonly HookKey SMTP_REQUEST_DATA = new HookKey("SMTP_REQUEST_DATA");

        /// <summary>
        /// Constant SMTP_REQUEST_STARTED for HookKey
        /// </summary>
        public static readonly HookKey SMTP_REQUEST_STARTED = new HookKey("SMTP_REQUEST_STARTED");

        /// <summary>
        /// Constant SMTP_RESPONSE_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey SMTP_RESPONSE_COMPLETE = new HookKey("SMTP_RESPONSE_COMPLETE");

        /// <summary>
        /// Constant SMTP_RESPONSE_DATA for HookKey
        /// </summary>
        public static readonly HookKey SMTP_RESPONSE_DATA = new HookKey("SMTP_RESPONSE_DATA");

        /// <summary>
        /// Constant SMTP_RESPONSE_STARTED for HookKey
        /// </summary>
        public static readonly HookKey SMTP_RESPONSE_STARTED = new HookKey("SMTP_RESPONSE_STARTED");

        /// <summary>
        /// Constant SNMP_REQUEST_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey SNMP_REQUEST_COMPLETE = new HookKey("SNMP_REQUEST_COMPLETE");

        /// <summary>
        /// Constant SNMP_REQUEST_STARTED for HookKey
        /// </summary>
        public static readonly HookKey SNMP_REQUEST_STARTED = new HookKey("SNMP_REQUEST_STARTED");

        /// <summary>
        /// Constant SNMP_RESPONSE_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey SNMP_RESPONSE_COMPLETE = new HookKey("SNMP_RESPONSE_COMPLETE");

        /// <summary>
        /// Constant SNMP_RESPONSE_STARTED for HookKey
        /// </summary>
        public static readonly HookKey SNMP_RESPONSE_STARTED = new HookKey("SNMP_RESPONSE_STARTED");

        /// <summary>
        /// Constant SSH_REQUEST_BANNER_DONE for HookKey
        /// </summary>
        public static readonly HookKey SSH_REQUEST_BANNER_DONE = new HookKey("SSH_REQUEST_BANNER_DONE");

        /// <summary>
        /// Constant SSH_REQUEST_BANNER_WAIT_EOL for HookKey
        /// </summary>
        public static readonly HookKey SSH_REQUEST_BANNER_WAIT_EOL = new HookKey("SSH_REQUEST_BANNER_WAIT_EOL");

        /// <summary>
        /// Constant SSH_REQUEST_FINISHED for HookKey
        /// </summary>
        public static readonly HookKey SSH_REQUEST_FINISHED = new HookKey("SSH_REQUEST_FINISHED");

        /// <summary>
        /// Constant SSH_REQUEST_IN_PROGRESS for HookKey
        /// </summary>
        public static readonly HookKey SSH_REQUEST_IN_PROGRESS = new HookKey("SSH_REQUEST_IN_PROGRESS");

        /// <summary>
        /// Constant SSH_RESPONSE_BANNER_DONE for HookKey
        /// </summary>
        public static readonly HookKey SSH_RESPONSE_BANNER_DONE = new HookKey("SSH_RESPONSE_BANNER_DONE");

        /// <summary>
        /// Constant SSH_RESPONSE_BANNER_WAIT_EOL for HookKey
        /// </summary>
        public static readonly HookKey SSH_RESPONSE_BANNER_WAIT_EOL = new HookKey("SSH_RESPONSE_BANNER_WAIT_EOL");

        /// <summary>
        /// Constant SSH_RESPONSE_FINISHED for HookKey
        /// </summary>
        public static readonly HookKey SSH_RESPONSE_FINISHED = new HookKey("SSH_RESPONSE_FINISHED");

        /// <summary>
        /// Constant SSH_RESPONSE_IN_PROGRESS for HookKey
        /// </summary>
        public static readonly HookKey SSH_RESPONSE_IN_PROGRESS = new HookKey("SSH_RESPONSE_IN_PROGRESS");

        /// <summary>
        /// Constant TCP_ALL for HookKey
        /// </summary>
        public static readonly HookKey TCP_ALL = new HookKey("TCP_ALL");

        /// <summary>
        /// Constant TCP_FLOW_START for HookKey
        /// </summary>
        public static readonly HookKey TCP_FLOW_START = new HookKey("TCP_FLOW_START");

        /// <summary>
        /// Constant TCP_PRE_FLOW for HookKey
        /// </summary>
        public static readonly HookKey TCP_PRE_FLOW = new HookKey("TCP_PRE_FLOW");

        /// <summary>
        /// Constant TCP_PRE_STREAM for HookKey
        /// </summary>
        public static readonly HookKey TCP_PRE_STREAM = new HookKey("TCP_PRE_STREAM");

        /// <summary>
        /// Constant TELNET_REQUEST_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey TELNET_REQUEST_COMPLETE = new HookKey("TELNET_REQUEST_COMPLETE");

        /// <summary>
        /// Constant TELNET_REQUEST_STARTED for HookKey
        /// </summary>
        public static readonly HookKey TELNET_REQUEST_STARTED = new HookKey("TELNET_REQUEST_STARTED");

        /// <summary>
        /// Constant TELNET_RESPONSE_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey TELNET_RESPONSE_COMPLETE = new HookKey("TELNET_RESPONSE_COMPLETE");

        /// <summary>
        /// Constant TELNET_RESPONSE_STARTED for HookKey
        /// </summary>
        public static readonly HookKey TELNET_RESPONSE_STARTED = new HookKey("TELNET_RESPONSE_STARTED");

        /// <summary>
        /// Constant TFTP_REQUEST_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey TFTP_REQUEST_COMPLETE = new HookKey("TFTP_REQUEST_COMPLETE");

        /// <summary>
        /// Constant TFTP_REQUEST_STARTED for HookKey
        /// </summary>
        public static readonly HookKey TFTP_REQUEST_STARTED = new HookKey("TFTP_REQUEST_STARTED");

        /// <summary>
        /// Constant TFTP_RESPONSE_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey TFTP_RESPONSE_COMPLETE = new HookKey("TFTP_RESPONSE_COMPLETE");

        /// <summary>
        /// Constant TFTP_RESPONSE_STARTED for HookKey
        /// </summary>
        public static readonly HookKey TFTP_RESPONSE_STARTED = new HookKey("TFTP_RESPONSE_STARTED");

        /// <summary>
        /// Constant TLS_CLIENT_CERT for HookKey
        /// </summary>
        public static readonly HookKey TLS_CLIENT_CERT = new HookKey("TLS_CLIENT_CERT");

        /// <summary>
        /// Constant TLS_CLIENT_DATA for HookKey
        /// </summary>
        public static readonly HookKey TLS_CLIENT_DATA = new HookKey("TLS_CLIENT_DATA");

        /// <summary>
        /// Constant TLS_CLIENT_FINISHED for HookKey
        /// </summary>
        public static readonly HookKey TLS_CLIENT_FINISHED = new HookKey("TLS_CLIENT_FINISHED");

        /// <summary>
        /// Constant TLS_CLIENT_HELLO for HookKey
        /// </summary>
        public static readonly HookKey TLS_CLIENT_HELLO = new HookKey("TLS_CLIENT_HELLO");

        /// <summary>
        /// Constant TLS_CLIENT_STARTED for HookKey
        /// </summary>
        public static readonly HookKey TLS_CLIENT_STARTED = new HookKey("TLS_CLIENT_STARTED");

        /// <summary>
        /// Constant TLS_SERVER_CERT for HookKey
        /// </summary>
        public static readonly HookKey TLS_SERVER_CERT = new HookKey("TLS_SERVER_CERT");

        /// <summary>
        /// Constant TLS_SERVER_DATA for HookKey
        /// </summary>
        public static readonly HookKey TLS_SERVER_DATA = new HookKey("TLS_SERVER_DATA");

        /// <summary>
        /// Constant TLS_SERVER_FINISHED for HookKey
        /// </summary>
        public static readonly HookKey TLS_SERVER_FINISHED = new HookKey("TLS_SERVER_FINISHED");

        /// <summary>
        /// Constant TLS_SERVER_HELLO for HookKey
        /// </summary>
        public static readonly HookKey TLS_SERVER_HELLO = new HookKey("TLS_SERVER_HELLO");

        /// <summary>
        /// Constant TLS_SERVER_STARTED for HookKey
        /// </summary>
        public static readonly HookKey TLS_SERVER_STARTED = new HookKey("TLS_SERVER_STARTED");

        /// <summary>
        /// Constant UDP_ALL for HookKey
        /// </summary>
        public static readonly HookKey UDP_ALL = new HookKey("UDP_ALL");

        /// <summary>
        /// Constant UDP_FLOW_START for HookKey
        /// </summary>
        public static readonly HookKey UDP_FLOW_START = new HookKey("UDP_FLOW_START");

        /// <summary>
        /// Constant UDP_PRE_FLOW for HookKey
        /// </summary>
        public static readonly HookKey UDP_PRE_FLOW = new HookKey("UDP_PRE_FLOW");

        /// <summary>
        /// Constant UDP_PRE_STREAM for HookKey
        /// </summary>
        public static readonly HookKey UDP_PRE_STREAM = new HookKey("UDP_PRE_STREAM");

        /// <summary>
        /// Constant WEBSOCKET_REQUEST_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey WEBSOCKET_REQUEST_COMPLETE = new HookKey("WEBSOCKET_REQUEST_COMPLETE");

        /// <summary>
        /// Constant WEBSOCKET_REQUEST_STARTED for HookKey
        /// </summary>
        public static readonly HookKey WEBSOCKET_REQUEST_STARTED = new HookKey("WEBSOCKET_REQUEST_STARTED");

        /// <summary>
        /// Constant WEBSOCKET_RESPONSE_COMPLETE for HookKey
        /// </summary>
        public static readonly HookKey WEBSOCKET_RESPONSE_COMPLETE = new HookKey("WEBSOCKET_RESPONSE_COMPLETE");

        /// <summary>
        /// Constant WEBSOCKET_RESPONSE_STARTED for HookKey
        /// </summary>
        public static readonly HookKey WEBSOCKET_RESPONSE_STARTED = new HookKey("WEBSOCKET_RESPONSE_STARTED");

        /// <summary>
        /// Constructs a custom HookKey for a value not among the defined constants.
        /// </summary>
        public HookKey(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HookKey FindValue(string value)
        {
            return FindValue<HookKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HookKey(string value)
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
        /// Constructs a custom IPAddressType for a value not among the defined constants.
        /// </summary>
        public IPAddressType(string value) : base(value) { }

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
    /// Constants used for properties of type IdentifiedType.
    /// </summary>
    public class IdentifiedType : ConstantClass
    {
        /// <summary>
        /// Constant STATELESS_RULE_CONTAINS_TCP_FLAGS for IdentifiedType
        /// </summary>
        public static readonly IdentifiedType STATELESS_RULE_CONTAINS_TCP_FLAGS = new IdentifiedType("STATELESS_RULE_CONTAINS_TCP_FLAGS");

        /// <summary>
        /// Constant STATELESS_RULE_FORWARDING_ASYMMETRICALLY for IdentifiedType
        /// </summary>
        public static readonly IdentifiedType STATELESS_RULE_FORWARDING_ASYMMETRICALLY = new IdentifiedType("STATELESS_RULE_FORWARDING_ASYMMETRICALLY");

        /// <summary>
        /// Constructs a custom IdentifiedType for a value not among the defined constants.
        /// </summary>
        public IdentifiedType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdentifiedType FindValue(string value)
        {
            return FindValue<IdentifiedType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdentifiedType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ListenerPropertyType.
    /// </summary>
    public class ListenerPropertyType : ConstantClass
    {
        /// <summary>
        /// Constant HTTP for ListenerPropertyType
        /// </summary>
        public static readonly ListenerPropertyType HTTP = new ListenerPropertyType("HTTP");

        /// <summary>
        /// Constant HTTPS for ListenerPropertyType
        /// </summary>
        public static readonly ListenerPropertyType HTTPS = new ListenerPropertyType("HTTPS");

        /// <summary>
        /// Constructs a custom ListenerPropertyType for a value not among the defined constants.
        /// </summary>
        public ListenerPropertyType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListenerPropertyType FindValue(string value)
        {
            return FindValue<ListenerPropertyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListenerPropertyType(string value)
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
        /// Constructs a custom LogDestinationType for a value not among the defined constants.
        /// </summary>
        public LogDestinationType(string value) : base(value) { }

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
        /// Constant TLS for LogType
        /// </summary>
        public static readonly LogType TLS = new LogType("TLS");

        /// <summary>
        /// Constructs a custom LogType for a value not among the defined constants.
        /// </summary>
        public LogType(string value) : base(value) { }

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
    /// Constants used for properties of type NatGatewayAttachmentStatus.
    /// </summary>
    public class NatGatewayAttachmentStatus : ConstantClass
    {
        /// <summary>
        /// Constant CREATING for NatGatewayAttachmentStatus
        /// </summary>
        public static readonly NatGatewayAttachmentStatus CREATING = new NatGatewayAttachmentStatus("CREATING");

        /// <summary>
        /// Constant DELETING for NatGatewayAttachmentStatus
        /// </summary>
        public static readonly NatGatewayAttachmentStatus DELETING = new NatGatewayAttachmentStatus("DELETING");

        /// <summary>
        /// Constant FAILED for NatGatewayAttachmentStatus
        /// </summary>
        public static readonly NatGatewayAttachmentStatus FAILED = new NatGatewayAttachmentStatus("FAILED");

        /// <summary>
        /// Constant READY for NatGatewayAttachmentStatus
        /// </summary>
        public static readonly NatGatewayAttachmentStatus READY = new NatGatewayAttachmentStatus("READY");

        /// <summary>
        /// Constant UPDATING for NatGatewayAttachmentStatus
        /// </summary>
        public static readonly NatGatewayAttachmentStatus UPDATING = new NatGatewayAttachmentStatus("UPDATING");

        /// <summary>
        /// Constructs a custom NatGatewayAttachmentStatus for a value not among the defined constants.
        /// </summary>
        public NatGatewayAttachmentStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NatGatewayAttachmentStatus FindValue(string value)
        {
            return FindValue<NatGatewayAttachmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NatGatewayAttachmentStatus(string value)
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
        /// Constructs a custom OverrideAction for a value not among the defined constants.
        /// </summary>
        public OverrideAction(string value) : base(value) { }

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
        /// Constant DEPRECATED for PerObjectSyncStatus
        /// </summary>
        public static readonly PerObjectSyncStatus DEPRECATED = new PerObjectSyncStatus("DEPRECATED");

        /// <summary>
        /// Constant IN_SYNC for PerObjectSyncStatus
        /// </summary>
        public static readonly PerObjectSyncStatus IN_SYNC = new PerObjectSyncStatus("IN_SYNC");

        /// <summary>
        /// Constant NOT_SUBSCRIBED for PerObjectSyncStatus
        /// </summary>
        public static readonly PerObjectSyncStatus NOT_SUBSCRIBED = new PerObjectSyncStatus("NOT_SUBSCRIBED");

        /// <summary>
        /// Constant PENDING for PerObjectSyncStatus
        /// </summary>
        public static readonly PerObjectSyncStatus PENDING = new PerObjectSyncStatus("PENDING");

        /// <summary>
        /// Constructs a custom PerObjectSyncStatus for a value not among the defined constants.
        /// </summary>
        public PerObjectSyncStatus(string value) : base(value) { }

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
    /// Constants used for properties of type PolicyDefaultAction.
    /// </summary>
    public class PolicyDefaultAction : ConstantClass
    {
        /// <summary>
        /// Constant ACCEPT for PolicyDefaultAction
        /// </summary>
        public static readonly PolicyDefaultAction ACCEPT = new PolicyDefaultAction("ACCEPT");

        /// <summary>
        /// Constant ALERT for PolicyDefaultAction
        /// </summary>
        public static readonly PolicyDefaultAction ALERT = new PolicyDefaultAction("ALERT");

        /// <summary>
        /// Constant DROP for PolicyDefaultAction
        /// </summary>
        public static readonly PolicyDefaultAction DROP = new PolicyDefaultAction("DROP");

        /// <summary>
        /// Constant REJECT for PolicyDefaultAction
        /// </summary>
        public static readonly PolicyDefaultAction REJECT = new PolicyDefaultAction("REJECT");

        /// <summary>
        /// Constructs a custom PolicyDefaultAction for a value not among the defined constants.
        /// </summary>
        public PolicyDefaultAction(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyDefaultAction FindValue(string value)
        {
            return FindValue<PolicyDefaultAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyDefaultAction(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type PolicyMode.
    /// </summary>
    public class PolicyMode : ConstantClass
    {
        /// <summary>
        /// Constant ENFORCE for PolicyMode
        /// </summary>
        public static readonly PolicyMode ENFORCE = new PolicyMode("ENFORCE");

        /// <summary>
        /// Constant MONITOR for PolicyMode
        /// </summary>
        public static readonly PolicyMode MONITOR = new PolicyMode("MONITOR");

        /// <summary>
        /// Constructs a custom PolicyMode for a value not among the defined constants.
        /// </summary>
        public PolicyMode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyMode FindValue(string value)
        {
            return FindValue<PolicyMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyMode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ProxyModifyState.
    /// </summary>
    public class ProxyModifyState : ConstantClass
    {
        /// <summary>
        /// Constant COMPLETED for ProxyModifyState
        /// </summary>
        public static readonly ProxyModifyState COMPLETED = new ProxyModifyState("COMPLETED");

        /// <summary>
        /// Constant FAILED for ProxyModifyState
        /// </summary>
        public static readonly ProxyModifyState FAILED = new ProxyModifyState("FAILED");

        /// <summary>
        /// Constant MODIFYING for ProxyModifyState
        /// </summary>
        public static readonly ProxyModifyState MODIFYING = new ProxyModifyState("MODIFYING");

        /// <summary>
        /// Constructs a custom ProxyModifyState for a value not among the defined constants.
        /// </summary>
        public ProxyModifyState(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProxyModifyState FindValue(string value)
        {
            return FindValue<ProxyModifyState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProxyModifyState(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ProxyRulePhaseAction.
    /// </summary>
    public class ProxyRulePhaseAction : ConstantClass
    {
        /// <summary>
        /// Constant ALERT for ProxyRulePhaseAction
        /// </summary>
        public static readonly ProxyRulePhaseAction ALERT = new ProxyRulePhaseAction("ALERT");

        /// <summary>
        /// Constant ALLOW for ProxyRulePhaseAction
        /// </summary>
        public static readonly ProxyRulePhaseAction ALLOW = new ProxyRulePhaseAction("ALLOW");

        /// <summary>
        /// Constant DENY for ProxyRulePhaseAction
        /// </summary>
        public static readonly ProxyRulePhaseAction DENY = new ProxyRulePhaseAction("DENY");

        /// <summary>
        /// Constructs a custom ProxyRulePhaseAction for a value not among the defined constants.
        /// </summary>
        public ProxyRulePhaseAction(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProxyRulePhaseAction FindValue(string value)
        {
            return FindValue<ProxyRulePhaseAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProxyRulePhaseAction(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ProxyState.
    /// </summary>
    public class ProxyState : ConstantClass
    {
        /// <summary>
        /// Constant ATTACHED for ProxyState
        /// </summary>
        public static readonly ProxyState ATTACHED = new ProxyState("ATTACHED");

        /// <summary>
        /// Constant ATTACHING for ProxyState
        /// </summary>
        public static readonly ProxyState ATTACHING = new ProxyState("ATTACHING");

        /// <summary>
        /// Constant ATTACH_FAILED for ProxyState
        /// </summary>
        public static readonly ProxyState ATTACH_FAILED = new ProxyState("ATTACH_FAILED");

        /// <summary>
        /// Constant DETACHED for ProxyState
        /// </summary>
        public static readonly ProxyState DETACHED = new ProxyState("DETACHED");

        /// <summary>
        /// Constant DETACHING for ProxyState
        /// </summary>
        public static readonly ProxyState DETACHING = new ProxyState("DETACHING");

        /// <summary>
        /// Constant DETACH_FAILED for ProxyState
        /// </summary>
        public static readonly ProxyState DETACH_FAILED = new ProxyState("DETACH_FAILED");

        /// <summary>
        /// Constructs a custom ProxyState for a value not among the defined constants.
        /// </summary>
        public ProxyState(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProxyState FindValue(string value)
        {
            return FindValue<ProxyState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProxyState(string value)
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
        /// Constructs a custom ResourceManagedStatus for a value not among the defined constants.
        /// </summary>
        public ResourceManagedStatus(string value) : base(value) { }

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
        /// Constant ACTIVE_THREAT_DEFENSE for ResourceManagedType
        /// </summary>
        public static readonly ResourceManagedType ACTIVE_THREAT_DEFENSE = new ResourceManagedType("ACTIVE_THREAT_DEFENSE");

        /// <summary>
        /// Constant AWS_MANAGED_DOMAIN_LISTS for ResourceManagedType
        /// </summary>
        public static readonly ResourceManagedType AWS_MANAGED_DOMAIN_LISTS = new ResourceManagedType("AWS_MANAGED_DOMAIN_LISTS");

        /// <summary>
        /// Constant AWS_MANAGED_THREAT_SIGNATURES for ResourceManagedType
        /// </summary>
        public static readonly ResourceManagedType AWS_MANAGED_THREAT_SIGNATURES = new ResourceManagedType("AWS_MANAGED_THREAT_SIGNATURES");

        /// <summary>
        /// Constant PARTNER_MANAGED for ResourceManagedType
        /// </summary>
        public static readonly ResourceManagedType PARTNER_MANAGED = new ResourceManagedType("PARTNER_MANAGED");

        /// <summary>
        /// Constructs a custom ResourceManagedType for a value not among the defined constants.
        /// </summary>
        public ResourceManagedType(string value) : base(value) { }

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
        /// Constant ERROR for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus ERROR = new ResourceStatus("ERROR");

        /// <summary>
        /// Constant UPDATING for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus UPDATING = new ResourceStatus("UPDATING");

        /// <summary>
        /// Constructs a custom ResourceStatus for a value not among the defined constants.
        /// </summary>
        public ResourceStatus(string value) : base(value) { }

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
    /// Constants used for properties of type RevocationCheckAction.
    /// </summary>
    public class RevocationCheckAction : ConstantClass
    {
        /// <summary>
        /// Constant DROP for RevocationCheckAction
        /// </summary>
        public static readonly RevocationCheckAction DROP = new RevocationCheckAction("DROP");

        /// <summary>
        /// Constant PASS for RevocationCheckAction
        /// </summary>
        public static readonly RevocationCheckAction PASS = new RevocationCheckAction("PASS");

        /// <summary>
        /// Constant REJECT for RevocationCheckAction
        /// </summary>
        public static readonly RevocationCheckAction REJECT = new RevocationCheckAction("REJECT");

        /// <summary>
        /// Constructs a custom RevocationCheckAction for a value not among the defined constants.
        /// </summary>
        public RevocationCheckAction(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RevocationCheckAction FindValue(string value)
        {
            return FindValue<RevocationCheckAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RevocationCheckAction(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type Route53ResolvedIPValidationAction.
    /// </summary>
    public class Route53ResolvedIPValidationAction : ConstantClass
    {
        /// <summary>
        /// Constant ALERT for Route53ResolvedIPValidationAction
        /// </summary>
        public static readonly Route53ResolvedIPValidationAction ALERT = new Route53ResolvedIPValidationAction("ALERT");

        /// <summary>
        /// Constant DROP for Route53ResolvedIPValidationAction
        /// </summary>
        public static readonly Route53ResolvedIPValidationAction DROP = new Route53ResolvedIPValidationAction("DROP");

        /// <summary>
        /// Constant REJECT for Route53ResolvedIPValidationAction
        /// </summary>
        public static readonly Route53ResolvedIPValidationAction REJECT = new Route53ResolvedIPValidationAction("REJECT");

        /// <summary>
        /// Constructs a custom Route53ResolvedIPValidationAction for a value not among the defined constants.
        /// </summary>
        public Route53ResolvedIPValidationAction(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Route53ResolvedIPValidationAction FindValue(string value)
        {
            return FindValue<Route53ResolvedIPValidationAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Route53ResolvedIPValidationAction(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type RuleGroupRequestPhase.
    /// </summary>
    public class RuleGroupRequestPhase : ConstantClass
    {
        /// <summary>
        /// Constant POST_RES for RuleGroupRequestPhase
        /// </summary>
        public static readonly RuleGroupRequestPhase POST_RES = new RuleGroupRequestPhase("POST_RES");

        /// <summary>
        /// Constant PRE_DNS for RuleGroupRequestPhase
        /// </summary>
        public static readonly RuleGroupRequestPhase PRE_DNS = new RuleGroupRequestPhase("PRE_DNS");

        /// <summary>
        /// Constant PRE_REQ for RuleGroupRequestPhase
        /// </summary>
        public static readonly RuleGroupRequestPhase PRE_REQ = new RuleGroupRequestPhase("PRE_REQ");

        /// <summary>
        /// Constructs a custom RuleGroupRequestPhase for a value not among the defined constants.
        /// </summary>
        public RuleGroupRequestPhase(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleGroupRequestPhase FindValue(string value)
        {
            return FindValue<RuleGroupRequestPhase>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleGroupRequestPhase(string value)
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
        /// Constant FIREWALL for RuleGroupType
        /// </summary>
        public static readonly RuleGroupType FIREWALL = new RuleGroupType("FIREWALL");

        /// <summary>
        /// Constant IPS for RuleGroupType
        /// </summary>
        public static readonly RuleGroupType IPS = new RuleGroupType("IPS");

        /// <summary>
        /// Constant STATEFUL for RuleGroupType
        /// </summary>
        public static readonly RuleGroupType STATEFUL = new RuleGroupType("STATEFUL");

        /// <summary>
        /// Constant STATEFUL_DOMAIN for RuleGroupType
        /// </summary>
        public static readonly RuleGroupType STATEFUL_DOMAIN = new RuleGroupType("STATEFUL_DOMAIN");

        /// <summary>
        /// Constant STATELESS for RuleGroupType
        /// </summary>
        public static readonly RuleGroupType STATELESS = new RuleGroupType("STATELESS");

        /// <summary>
        /// Constructs a custom RuleGroupType for a value not among the defined constants.
        /// </summary>
        public RuleGroupType(string value) : base(value) { }

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
        /// Constructs a custom RuleOrder for a value not among the defined constants.
        /// </summary>
        public RuleOrder(string value) : base(value) { }

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
    /// Constants used for properties of type RuleOutputFormat.
    /// </summary>
    public class RuleOutputFormat : ConstantClass
    {
        /// <summary>
        /// Constant FIREWALL_RULES for RuleOutputFormat
        /// </summary>
        public static readonly RuleOutputFormat FIREWALL_RULES = new RuleOutputFormat("FIREWALL_RULES");

        /// <summary>
        /// Constant RULES_STRING for RuleOutputFormat
        /// </summary>
        public static readonly RuleOutputFormat RULES_STRING = new RuleOutputFormat("RULES_STRING");

        /// <summary>
        /// Constructs a custom RuleOutputFormat for a value not among the defined constants.
        /// </summary>
        public RuleOutputFormat(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleOutputFormat FindValue(string value)
        {
            return FindValue<RuleOutputFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleOutputFormat(string value)
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
        /// Constructs a custom StatefulAction for a value not among the defined constants.
        /// </summary>
        public StatefulAction(string value) : base(value) { }

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
        /// Constructs a custom StatefulRuleDirection for a value not among the defined constants.
        /// </summary>
        public StatefulRuleDirection(string value) : base(value) { }

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
        /// Constant HTTP2 for StatefulRuleProtocol
        /// </summary>
        public static readonly StatefulRuleProtocol HTTP2 = new StatefulRuleProtocol("HTTP2");

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
        /// Constant QUIC for StatefulRuleProtocol
        /// </summary>
        public static readonly StatefulRuleProtocol QUIC = new StatefulRuleProtocol("QUIC");

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
        /// Constructs a custom StatefulRuleProtocol for a value not among the defined constants.
        /// </summary>
        public StatefulRuleProtocol(string value) : base(value) { }

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
        /// Constant REJECT for StreamExceptionPolicy
        /// </summary>
        public static readonly StreamExceptionPolicy REJECT = new StreamExceptionPolicy("REJECT");

        /// <summary>
        /// Constructs a custom StreamExceptionPolicy for a value not among the defined constants.
        /// </summary>
        public StreamExceptionPolicy(string value) : base(value) { }

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
    /// Constants used for properties of type StreamExceptionPolicyV2.
    /// </summary>
    public class StreamExceptionPolicyV2 : ConstantClass
    {
        /// <summary>
        /// Constant DROP for StreamExceptionPolicyV2
        /// </summary>
        public static readonly StreamExceptionPolicyV2 DROP = new StreamExceptionPolicyV2("DROP");

        /// <summary>
        /// Constant REJECT for StreamExceptionPolicyV2
        /// </summary>
        public static readonly StreamExceptionPolicyV2 REJECT = new StreamExceptionPolicyV2("REJECT");

        /// <summary>
        /// Constructs a custom StreamExceptionPolicyV2 for a value not among the defined constants.
        /// </summary>
        public StreamExceptionPolicyV2(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamExceptionPolicyV2 FindValue(string value)
        {
            return FindValue<StreamExceptionPolicyV2>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamExceptionPolicyV2(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SubscriptionStatus.
    /// </summary>
    public class SubscriptionStatus : ConstantClass
    {
        /// <summary>
        /// Constant NOT_SUBSCRIBED for SubscriptionStatus
        /// </summary>
        public static readonly SubscriptionStatus NOT_SUBSCRIBED = new SubscriptionStatus("NOT_SUBSCRIBED");

        /// <summary>
        /// Constant SUBSCRIBED for SubscriptionStatus
        /// </summary>
        public static readonly SubscriptionStatus SUBSCRIBED = new SubscriptionStatus("SUBSCRIBED");

        /// <summary>
        /// Constructs a custom SubscriptionStatus for a value not among the defined constants.
        /// </summary>
        public SubscriptionStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubscriptionStatus FindValue(string value)
        {
            return FindValue<SubscriptionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubscriptionStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SummaryRuleOption.
    /// </summary>
    public class SummaryRuleOption : ConstantClass
    {
        /// <summary>
        /// Constant METADATA for SummaryRuleOption
        /// </summary>
        public static readonly SummaryRuleOption METADATA = new SummaryRuleOption("METADATA");

        /// <summary>
        /// Constant MSG for SummaryRuleOption
        /// </summary>
        public static readonly SummaryRuleOption MSG = new SummaryRuleOption("MSG");

        /// <summary>
        /// Constant SID for SummaryRuleOption
        /// </summary>
        public static readonly SummaryRuleOption SID = new SummaryRuleOption("SID");

        /// <summary>
        /// Constructs a custom SummaryRuleOption for a value not among the defined constants.
        /// </summary>
        public SummaryRuleOption(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SummaryRuleOption FindValue(string value)
        {
            return FindValue<SummaryRuleOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SummaryRuleOption(string value)
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
        /// Constructs a custom TCPFlag for a value not among the defined constants.
        /// </summary>
        public TCPFlag(string value) : base(value) { }

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

    /// <summary>
    /// Constants used for properties of type TargetType.
    /// </summary>
    public class TargetType : ConstantClass
    {
        /// <summary>
        /// Constant AWS_ROUTE_53_RESOLVED_DOMAIN for TargetType
        /// </summary>
        public static readonly TargetType AWS_ROUTE_53_RESOLVED_DOMAIN = new TargetType("AWS_ROUTE_53_RESOLVED_DOMAIN");

        /// <summary>
        /// Constant HTTP_HOST for TargetType
        /// </summary>
        public static readonly TargetType HTTP_HOST = new TargetType("HTTP_HOST");

        /// <summary>
        /// Constant TLS_SNI for TargetType
        /// </summary>
        public static readonly TargetType TLS_SNI = new TargetType("TLS_SNI");

        /// <summary>
        /// Constructs a custom TargetType for a value not among the defined constants.
        /// </summary>
        public TargetType(string value) : base(value) { }

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
    /// Constants used for properties of type TlsInterceptMode.
    /// </summary>
    public class TlsInterceptMode : ConstantClass
    {
        /// <summary>
        /// Constant DISABLED for TlsInterceptMode
        /// </summary>
        public static readonly TlsInterceptMode DISABLED = new TlsInterceptMode("DISABLED");

        /// <summary>
        /// Constant ENABLED for TlsInterceptMode
        /// </summary>
        public static readonly TlsInterceptMode ENABLED = new TlsInterceptMode("ENABLED");

        /// <summary>
        /// Constructs a custom TlsInterceptMode for a value not among the defined constants.
        /// </summary>
        public TlsInterceptMode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TlsInterceptMode FindValue(string value)
        {
            return FindValue<TlsInterceptMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TlsInterceptMode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type TransitGatewayAttachmentStatus.
    /// </summary>
    public class TransitGatewayAttachmentStatus : ConstantClass
    {
        /// <summary>
        /// Constant CREATING for TransitGatewayAttachmentStatus
        /// </summary>
        public static readonly TransitGatewayAttachmentStatus CREATING = new TransitGatewayAttachmentStatus("CREATING");

        /// <summary>
        /// Constant DELETED for TransitGatewayAttachmentStatus
        /// </summary>
        public static readonly TransitGatewayAttachmentStatus DELETED = new TransitGatewayAttachmentStatus("DELETED");

        /// <summary>
        /// Constant DELETING for TransitGatewayAttachmentStatus
        /// </summary>
        public static readonly TransitGatewayAttachmentStatus DELETING = new TransitGatewayAttachmentStatus("DELETING");

        /// <summary>
        /// Constant ERROR for TransitGatewayAttachmentStatus
        /// </summary>
        public static readonly TransitGatewayAttachmentStatus ERROR = new TransitGatewayAttachmentStatus("ERROR");

        /// <summary>
        /// Constant FAILED for TransitGatewayAttachmentStatus
        /// </summary>
        public static readonly TransitGatewayAttachmentStatus FAILED = new TransitGatewayAttachmentStatus("FAILED");

        /// <summary>
        /// Constant PENDING_ACCEPTANCE for TransitGatewayAttachmentStatus
        /// </summary>
        public static readonly TransitGatewayAttachmentStatus PENDING_ACCEPTANCE = new TransitGatewayAttachmentStatus("PENDING_ACCEPTANCE");

        /// <summary>
        /// Constant READY for TransitGatewayAttachmentStatus
        /// </summary>
        public static readonly TransitGatewayAttachmentStatus READY = new TransitGatewayAttachmentStatus("READY");

        /// <summary>
        /// Constant REJECTED for TransitGatewayAttachmentStatus
        /// </summary>
        public static readonly TransitGatewayAttachmentStatus REJECTED = new TransitGatewayAttachmentStatus("REJECTED");

        /// <summary>
        /// Constant REJECTING for TransitGatewayAttachmentStatus
        /// </summary>
        public static readonly TransitGatewayAttachmentStatus REJECTING = new TransitGatewayAttachmentStatus("REJECTING");

        /// <summary>
        /// Constructs a custom TransitGatewayAttachmentStatus for a value not among the defined constants.
        /// </summary>
        public TransitGatewayAttachmentStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransitGatewayAttachmentStatus FindValue(string value)
        {
            return FindValue<TransitGatewayAttachmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransitGatewayAttachmentStatus(string value)
        {
            return FindValue(value);
        }
    }
}
