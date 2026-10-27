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
    /// Container for the parameters to the UpdateTrafficPolicy operation. Update attributes
    /// of an already provisioned traffic policy resource.
    /// </summary>
    public partial class UpdateTrafficPolicyRequest : AmazonMailManagerRequest
    {
        /// <summary>
        /// Gets and sets the property DefaultAction. 
        /// <para>
        /// Default action instructs the traﬃc policy to either Allow or Deny (block) messages
        /// that fall outside of (or not addressed by) the conditions of your policy statements
        /// </para>
        /// </summary>
        public AcceptAction DefaultAction { get; set; }

        /// <summary>
        /// Checks to see if the DefaultAction property is set.
        /// </summary>
        internal bool IsSetDefaultAction() => this.DefaultAction != null;

        /// <summary>
        /// Gets and sets the property MaxMessageSizeBytes. 
        /// <para>
        /// The maximum message size in bytes of email which is allowed in by this traffic policy—anything
        /// larger will be blocked.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxMessageSizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the MaxMessageSizeBytes property is set.
        /// </summary>
        internal bool IsSetMaxMessageSizeBytes() => this.MaxMessageSizeBytes.HasValue;

        /// <summary>
        /// Gets and sets the property PolicyStatements. 
        /// <para>
        /// The list of conditions to be updated for filtering email traffic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PolicyStatement> PolicyStatements { get; set; } = AWSConfigs.InitializeCollections ? new List<PolicyStatement>() : null;

        /// <summary>
        /// Checks to see if the PolicyStatements property is set.
        /// </summary>
        internal bool IsSetPolicyStatements() => this.PolicyStatements != null && (this.PolicyStatements.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrafficPolicyId. 
        /// <para>
        /// The identifier of the traffic policy that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string TrafficPolicyId { get; set; }

        /// <summary>
        /// Checks to see if the TrafficPolicyId property is set.
        /// </summary>
        internal bool IsSetTrafficPolicyId() => this.TrafficPolicyId != null;

        /// <summary>
        /// Gets and sets the property TrafficPolicyName. 
        /// <para>
        /// A user-friendly name for the traffic policy resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 63)]
        public string TrafficPolicyName { get; set; }

        /// <summary>
        /// Checks to see if the TrafficPolicyName property is set.
        /// </summary>
        internal bool IsSetTrafficPolicyName() => this.TrafficPolicyName != null;
    }
}
