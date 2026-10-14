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
        /// <summary>
        /// Gets and sets the property ConfigurationSet. 
        /// <para>
        /// The name of the configuration set used when sent through a configuration set with
        /// archiving enabled.
        /// </para>
        /// </summary>
        public string ConfigurationSet { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationSet property is set.
        /// </summary>
        internal bool IsSetConfigurationSet() => this.ConfigurationSet != null;

        /// <summary>
        /// Gets and sets the property IngressPointId. 
        /// <para>
        /// The ID of the ingress endpoint through which the email was received.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string IngressPointId { get; set; }

        /// <summary>
        /// Checks to see if the IngressPointId property is set.
        /// </summary>
        internal bool IsSetIngressPointId() => this.IngressPointId != null;

        /// <summary>
        /// Gets and sets the property RuleSetId. 
        /// <para>
        /// The ID of the rule set that processed the email.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string RuleSetId { get; set; }

        /// <summary>
        /// Checks to see if the RuleSetId property is set.
        /// </summary>
        internal bool IsSetRuleSetId() => this.RuleSetId != null;

        /// <summary>
        /// Gets and sets the property SenderHostname. 
        /// <para>
        /// The name of the host from which the email was received.
        /// </para>
        /// </summary>
        public string SenderHostname { get; set; }

        /// <summary>
        /// Checks to see if the SenderHostname property is set.
        /// </summary>
        internal bool IsSetSenderHostname() => this.SenderHostname != null;

        /// <summary>
        /// Gets and sets the property SenderIpAddress. 
        /// <para>
        /// The IP address of the host from which the email was received.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string SenderIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the SenderIpAddress property is set.
        /// </summary>
        internal bool IsSetSenderIpAddress() => this.SenderIpAddress != null;

        /// <summary>
        /// Gets and sets the property SendingMethod. 
        /// <para>
        /// The name of the API call used when sent through a configuration set with archiving
        /// enabled.
        /// </para>
        /// </summary>
        public string SendingMethod { get; set; }

        /// <summary>
        /// Checks to see if the SendingMethod property is set.
        /// </summary>
        internal bool IsSetSendingMethod() => this.SendingMethod != null;

        /// <summary>
        /// Gets and sets the property SendingPool. 
        /// <para>
        /// The name of the dedicated IP pool used when sent through a configuration set with
        /// archiving enabled.
        /// </para>
        /// </summary>
        public string SendingPool { get; set; }

        /// <summary>
        /// Checks to see if the SendingPool property is set.
        /// </summary>
        internal bool IsSetSendingPool() => this.SendingPool != null;

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// Specifies the archived email source, identified by either a Rule Set's ARN with an
        /// Archive action, or a Configuration Set's Archive ARN.
        /// </para>
        /// </summary>
        public string SourceArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceArn property is set.
        /// </summary>
        internal bool IsSetSourceArn() => this.SourceArn != null;

        /// <summary>
        /// Gets and sets the property SourceIdentity. 
        /// <para>
        /// The identity name used to authorize the sending action when sent through a configuration
        /// set with archiving enabled.
        /// </para>
        /// </summary>
        public string SourceIdentity { get; set; }

        /// <summary>
        /// Checks to see if the SourceIdentity property is set.
        /// </summary>
        internal bool IsSetSourceIdentity() => this.SourceIdentity != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp of when the email was received.
        /// </para>
        /// </summary>
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;

        /// <summary>
        /// Gets and sets the property TlsCipherSuite. 
        /// <para>
        /// The TLS cipher suite used to communicate with the host from which the email was received.
        /// </para>
        /// </summary>
        public string TlsCipherSuite { get; set; }

        /// <summary>
        /// Checks to see if the TlsCipherSuite property is set.
        /// </summary>
        internal bool IsSetTlsCipherSuite() => this.TlsCipherSuite != null;

        /// <summary>
        /// Gets and sets the property TlsProtocol. 
        /// <para>
        /// The TLS protocol used to communicate with the host from which the email was received.
        /// </para>
        /// </summary>
        public string TlsProtocol { get; set; }

        /// <summary>
        /// Checks to see if the TlsProtocol property is set.
        /// </summary>
        internal bool IsSetTlsProtocol() => this.TlsProtocol != null;

        /// <summary>
        /// Gets and sets the property TrafficPolicyId. 
        /// <para>
        /// The ID of the traffic policy that was in effect when the email was received.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string TrafficPolicyId { get; set; }

        /// <summary>
        /// Checks to see if the TrafficPolicyId property is set.
        /// </summary>
        internal bool IsSetTrafficPolicyId() => this.TrafficPolicyId != null;
    }
}
