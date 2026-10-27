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
    /// This is the response object from the GetIngressPoint operation.
    /// </summary>
    public partial class GetIngressPointResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ARecord. 
        /// <para>
        ///  The DNS A Record that identifies your ingress endpoint. Configure your DNS Mail Exchange
        /// (MX) record with this value to route emails to Mail Manager. 
        /// </para>
        /// </summary>
        public string ARecord { get; set; }

        /// <summary>
        /// Checks to see if the ARecord property is set.
        /// </summary>
        internal bool IsSetARecord() => this.ARecord != null;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The timestamp of when the ingress endpoint was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property IngressPointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ingress endpoint resource.
        /// </para>
        /// </summary>
        public string IngressPointArn { get; set; }

        /// <summary>
        /// Checks to see if the IngressPointArn property is set.
        /// </summary>
        internal bool IsSetIngressPointArn() => this.IngressPointArn != null;

        /// <summary>
        /// Gets and sets the property IngressPointAuthConfiguration. 
        /// <para>
        /// The authentication configuration of the ingress endpoint resource.
        /// </para>
        /// </summary>
        public IngressPointAuthConfiguration IngressPointAuthConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the IngressPointAuthConfiguration property is set.
        /// </summary>
        internal bool IsSetIngressPointAuthConfiguration() => this.IngressPointAuthConfiguration != null;

        /// <summary>
        /// Gets and sets the property IngressPointId. 
        /// <para>
        /// The identifier of an ingress endpoint resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string IngressPointId { get; set; }

        /// <summary>
        /// Checks to see if the IngressPointId property is set.
        /// </summary>
        internal bool IsSetIngressPointId() => this.IngressPointId != null;

        /// <summary>
        /// Gets and sets the property IngressPointName. 
        /// <para>
        /// A user friendly name for the ingress endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 63)]
        public string IngressPointName { get; set; }

        /// <summary>
        /// Checks to see if the IngressPointName property is set.
        /// </summary>
        internal bool IsSetIngressPointName() => this.IngressPointName != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// The timestamp of when the ingress endpoint was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTimestamp() => this.LastUpdatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The network configuration for the ingress point.
        /// </para>
        /// </summary>
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConfiguration property is set.
        /// </summary>
        internal bool IsSetNetworkConfiguration() => this.NetworkConfiguration != null;

        /// <summary>
        /// Gets and sets the property RuleSetId. 
        /// <para>
        /// The identifier of a rule set resource associated with the ingress endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string RuleSetId { get; set; }

        /// <summary>
        /// Checks to see if the RuleSetId property is set.
        /// </summary>
        internal bool IsSetRuleSetId() => this.RuleSetId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the ingress endpoint resource.
        /// </para>
        /// </summary>
        public IngressPointStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TlsPolicy. 
        /// <para>
        /// The selected Transport Layer Security (TLS) policy of the ingress point.
        /// </para>
        /// </summary>
        public TlsPolicy TlsPolicy { get; set; }

        /// <summary>
        /// Checks to see if the TlsPolicy property is set.
        /// </summary>
        internal bool IsSetTlsPolicy() => this.TlsPolicy != null;

        /// <summary>
        /// Gets and sets the property TrafficPolicyId. 
        /// <para>
        /// The identifier of the traffic policy resource associated with the ingress endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string TrafficPolicyId { get; set; }

        /// <summary>
        /// Checks to see if the TrafficPolicyId property is set.
        /// </summary>
        internal bool IsSetTrafficPolicyId() => this.TrafficPolicyId != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of ingress endpoint.
        /// </para>
        /// </summary>
        public IngressPointType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
