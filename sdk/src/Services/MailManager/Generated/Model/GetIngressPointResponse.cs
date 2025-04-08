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
    /// This is the response object from the GetIngressPoint operation.
    /// </summary>
    public partial class GetIngressPointResponse : AmazonWebServiceResponse
    {
        private string _aRecord;
        private DateTime? _createdTimestamp;
        private string _ingressPointArn;
        private IngressPointAuthConfiguration _ingressPointAuthConfiguration;
        private string _ingressPointId;
        private string _ingressPointName;
        private DateTime? _lastUpdatedTimestamp;
        private NetworkConfiguration _networkConfiguration;
        private string _ruleSetId;
        private IngressPointStatus _status;
        private string _trafficPolicyId;
        private IngressPointType _type;

        /// <summary>
        /// Gets and sets the property ARecord. 
        /// <para>
        ///  The DNS A Record that identifies your ingress endpoint. Configure your DNS Mail Exchange
        /// (MX) record with this value to route emails to Mail Manager. 
        /// </para>
        /// </summary>
        public string ARecord
        {
            get { return this._aRecord; }
            set { this._aRecord = value; }
        }

        // Check to see if ARecord property is set
        internal bool IsSetARecord()
        {
            return this._aRecord != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The timestamp of when the ingress endpoint was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp
        {
            get { return this._createdTimestamp; }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IngressPointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ingress endpoint resource.
        /// </para>
        /// </summary>
        public string IngressPointArn
        {
            get { return this._ingressPointArn; }
            set { this._ingressPointArn = value; }
        }

        // Check to see if IngressPointArn property is set
        internal bool IsSetIngressPointArn()
        {
            return this._ingressPointArn != null;
        }

        /// <summary>
        /// Gets and sets the property IngressPointAuthConfiguration. 
        /// <para>
        /// The authentication configuration of the ingress endpoint resource.
        /// </para>
        /// </summary>
        public IngressPointAuthConfiguration IngressPointAuthConfiguration
        {
            get { return this._ingressPointAuthConfiguration; }
            set { this._ingressPointAuthConfiguration = value; }
        }

        // Check to see if IngressPointAuthConfiguration property is set
        internal bool IsSetIngressPointAuthConfiguration()
        {
            return this._ingressPointAuthConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property IngressPointId. 
        /// <para>
        /// The identifier of an ingress endpoint resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property IngressPointName. 
        /// <para>
        /// A user friendly name for the ingress endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string IngressPointName
        {
            get { return this._ingressPointName; }
            set { this._ingressPointName = value; }
        }

        // Check to see if IngressPointName property is set
        internal bool IsSetIngressPointName()
        {
            return this._ingressPointName != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// The timestamp of when the ingress endpoint was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTimestamp
        {
            get { return this._lastUpdatedTimestamp; }
            set { this._lastUpdatedTimestamp = value; }
        }

        // Check to see if LastUpdatedTimestamp property is set
        internal bool IsSetLastUpdatedTimestamp()
        {
            return this._lastUpdatedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The network configuration for the ingress point.
        /// </para>
        /// </summary>
        public NetworkConfiguration NetworkConfiguration
        {
            get { return this._networkConfiguration; }
            set { this._networkConfiguration = value; }
        }

        // Check to see if NetworkConfiguration property is set
        internal bool IsSetNetworkConfiguration()
        {
            return this._networkConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RuleSetId. 
        /// <para>
        /// The identifier of a rule set resource associated with the ingress endpoint.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the ingress endpoint resource.
        /// </para>
        /// </summary>
        public IngressPointStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficPolicyId. 
        /// <para>
        /// The identifier of the traffic policy resource associated with the ingress endpoint.
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

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of ingress endpoint.
        /// </para>
        /// </summary>
        public IngressPointType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}