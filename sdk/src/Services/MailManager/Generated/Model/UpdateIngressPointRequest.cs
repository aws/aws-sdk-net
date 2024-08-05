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
    /// Container for the parameters to the UpdateIngressPoint operation.
    /// Update attributes of a provisioned ingress endpoint resource.
    /// </summary>
    public partial class UpdateIngressPointRequest : AmazonMailManagerRequest
    {
        private IngressPointConfiguration _ingressPointConfiguration;
        private string _ingressPointId;
        private string _ingressPointName;
        private string _ruleSetId;
        private IngressPointStatusToUpdate _statusToUpdate;
        private string _trafficPolicyId;

        /// <summary>
        /// Gets and sets the property IngressPointConfiguration. 
        /// <para>
        /// If you choose an Authenticated ingress endpoint, you must configure either an SMTP
        /// password or a secret ARN.
        /// </para>
        /// </summary>
        public IngressPointConfiguration IngressPointConfiguration
        {
            get { return this._ingressPointConfiguration; }
            set { this._ingressPointConfiguration = value; }
        }

        // Check to see if IngressPointConfiguration property is set
        internal bool IsSetIngressPointConfiguration()
        {
            return this._ingressPointConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property IngressPointId. 
        /// <para>
        /// The identifier for the ingress endpoint you want to update.
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
        /// A user friendly name for the ingress endpoint resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
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
        /// Gets and sets the property RuleSetId. 
        /// <para>
        /// The identifier of an existing rule set that you attach to an ingress endpoint resource.
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
        /// Gets and sets the property StatusToUpdate. 
        /// <para>
        /// The update status of an ingress endpoint.
        /// </para>
        /// </summary>
        public IngressPointStatusToUpdate StatusToUpdate
        {
            get { return this._statusToUpdate; }
            set { this._statusToUpdate = value; }
        }

        // Check to see if StatusToUpdate property is set
        internal bool IsSetStatusToUpdate()
        {
            return this._statusToUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficPolicyId. 
        /// <para>
        /// The identifier of an existing traffic policy that you attach to an ingress endpoint
        /// resource.
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