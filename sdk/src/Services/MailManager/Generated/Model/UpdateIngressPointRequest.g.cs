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
    /// Container for the parameters to the UpdateIngressPoint operation. Update attributes
    /// of a provisioned ingress endpoint resource.
    /// </summary>
    public partial class UpdateIngressPointRequest : AmazonMailManagerRequest
    {
        /// <summary>
        /// Gets and sets the property IngressPointConfiguration. 
        /// <para>
        /// If you choose an Authenticated ingress endpoint, you must configure either an SMTP
        /// password or a secret ARN.
        /// </para>
        /// </summary>
        public IngressPointConfiguration IngressPointConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the IngressPointConfiguration property is set.
        /// </summary>
        internal bool IsSetIngressPointConfiguration() => this.IngressPointConfiguration != null;

        /// <summary>
        /// Gets and sets the property IngressPointId. 
        /// <para>
        /// The identifier for the ingress endpoint you want to update.
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
        /// A user friendly name for the ingress endpoint resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 63)]
        public string IngressPointName { get; set; }

        /// <summary>
        /// Checks to see if the IngressPointName property is set.
        /// </summary>
        internal bool IsSetIngressPointName() => this.IngressPointName != null;

        /// <summary>
        /// Gets and sets the property RuleSetId. 
        /// <para>
        /// The identifier of an existing rule set that you attach to an ingress endpoint resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string RuleSetId { get; set; }

        /// <summary>
        /// Checks to see if the RuleSetId property is set.
        /// </summary>
        internal bool IsSetRuleSetId() => this.RuleSetId != null;

        /// <summary>
        /// Gets and sets the property StatusToUpdate. 
        /// <para>
        /// The update status of an ingress endpoint.
        /// </para>
        /// </summary>
        public IngressPointStatusToUpdate StatusToUpdate { get; set; }

        /// <summary>
        /// Checks to see if the StatusToUpdate property is set.
        /// </summary>
        internal bool IsSetStatusToUpdate() => this.StatusToUpdate != null;

        /// <summary>
        /// Gets and sets the property TlsPolicy. 
        /// <para>
        /// The Transport Layer Security (TLS) policy for the ingress point. Valid values are
        /// REQUIRED, OPTIONAL. Only ingress endpoints using REQUIRED or OPTIONAL as TlsPolicy
        /// can be updated.
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
        /// The identifier of an existing traffic policy that you attach to an ingress endpoint
        /// resource.
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
