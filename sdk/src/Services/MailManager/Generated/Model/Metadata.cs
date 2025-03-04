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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// The metadata about the email.
    /// </summary>
    public partial class Metadata
    {
        private string _configurationSet;
        private string _ingressPointId;
        private string _ruleSetId;
        private string _senderHostname;
        private string _senderIpAddress;
        private string _sendingMethod;
        private string _sendingPool;
        private string _sourceArn;
        private string _sourceIdentity;
        private DateTime? _timestamp;
        private string _tlsCipherSuite;
        private string _tlsProtocol;
        private string _trafficPolicyId;

        /// <summary>
        /// Gets and sets the property ConfigurationSet. 
        /// <para>
        /// The name of the configuration set used when sent through a configuration set with
        /// archiving enabled.
        /// </para>
        /// </summary>
        public string ConfigurationSet
        {
            get { return this._configurationSet; }
            set { this._configurationSet = value; }
        }

        // Check to see if ConfigurationSet property is set
        internal bool IsSetConfigurationSet()
        {
            return this._configurationSet != null;
        }

        /// <summary>
        /// Gets and sets the property IngressPointId. 
        /// <para>
        /// The ID of the ingress endpoint through which the email was received.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string IngressPointId
        {
            get { return this._ingressPointId; }
            set { this._ingressPointId = value; }
        }

        // Check to see if IngressPointId property is set
        internal bool IsSetIngressPointId()
        {
            return this._ingressPointId != null;
        }

        /// <summary>
        /// Gets and sets the property RuleSetId. 
        /// <para>
        /// The ID of the rule set that processed the email.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string RuleSetId
        {
            get { return this._ruleSetId; }
            set { this._ruleSetId = value; }
        }

        // Check to see if RuleSetId property is set
        internal bool IsSetRuleSetId()
        {
            return this._ruleSetId != null;
        }

        /// <summary>
        /// Gets and sets the property SenderHostname. 
        /// <para>
        /// The name of the host from which the email was received.
        /// </para>
        /// </summary>
        public string SenderHostname
        {
            get { return this._senderHostname; }
            set { this._senderHostname = value; }
        }

        // Check to see if SenderHostname property is set
        internal bool IsSetSenderHostname()
        {
            return this._senderHostname != null;
        }

        /// <summary>
        /// Gets and sets the property SenderIpAddress. 
        /// <para>
        /// The IP address of the host from which the email was received.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string SenderIpAddress
        {
            get { return this._senderIpAddress; }
            set { this._senderIpAddress = value; }
        }

        // Check to see if SenderIpAddress property is set
        internal bool IsSetSenderIpAddress()
        {
            return this._senderIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property SendingMethod. 
        /// <para>
        /// The name of the API call used when sent through a configuration set with archiving
        /// enabled.
        /// </para>
        /// </summary>
        public string SendingMethod
        {
            get { return this._sendingMethod; }
            set { this._sendingMethod = value; }
        }

        // Check to see if SendingMethod property is set
        internal bool IsSetSendingMethod()
        {
            return this._sendingMethod != null;
        }

        /// <summary>
        /// Gets and sets the property SendingPool. 
        /// <para>
        /// The name of the dedicated IP pool used when sent through a configuration set with
        /// archiving enabled.
        /// </para>
        /// </summary>
        public string SendingPool
        {
            get { return this._sendingPool; }
            set { this._sendingPool = value; }
        }

        // Check to see if SendingPool property is set
        internal bool IsSetSendingPool()
        {
            return this._sendingPool != null;
        }

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// Specifies the archived email source, identified by either a Rule Set's ARN with an
        /// Archive action, or a Configuration Set's Archive ARN.
        /// </para>
        /// </summary>
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceIdentity. 
        /// <para>
        /// The identity name used to authorize the sending action when sent through a configuration
        /// set with archiving enabled.
        /// </para>
        /// </summary>
        public string SourceIdentity
        {
            get { return this._sourceIdentity; }
            set { this._sourceIdentity = value; }
        }

        // Check to see if SourceIdentity property is set
        internal bool IsSetSourceIdentity()
        {
            return this._sourceIdentity != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp of when the email was received.
        /// </para>
        /// </summary>
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TlsCipherSuite. 
        /// <para>
        /// The TLS cipher suite used to communicate with the host from which the email was received.
        /// </para>
        /// </summary>
        public string TlsCipherSuite
        {
            get { return this._tlsCipherSuite; }
            set { this._tlsCipherSuite = value; }
        }

        // Check to see if TlsCipherSuite property is set
        internal bool IsSetTlsCipherSuite()
        {
            return this._tlsCipherSuite != null;
        }

        /// <summary>
        /// Gets and sets the property TlsProtocol. 
        /// <para>
        /// The TLS protocol used to communicate with the host from which the email was received.
        /// </para>
        /// </summary>
        public string TlsProtocol
        {
            get { return this._tlsProtocol; }
            set { this._tlsProtocol = value; }
        }

        // Check to see if TlsProtocol property is set
        internal bool IsSetTlsProtocol()
        {
            return this._tlsProtocol != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficPolicyId. 
        /// <para>
        /// The ID of the traffic policy that was in effect when the email was received.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string TrafficPolicyId
        {
            get { return this._trafficPolicyId; }
            set { this._trafficPolicyId = value; }
        }

        // Check to see if TrafficPolicyId property is set
        internal bool IsSetTrafficPolicyId()
        {
            return this._trafficPolicyId != null;
        }

    }
}