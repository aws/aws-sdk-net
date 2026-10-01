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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateReputationEntityPolicy operation. Update
    /// the reputation management policy for a reputation entity. The policy determines how
    /// the entity responds to reputation findings, such as automatically pausing sending
    /// when certain thresholds are exceeded. <para> Reputation management policies are Amazon
    /// Web Services Amazon SES-managed (predefined policies). You can select from none, standard,
    /// and strict policies. </para>
    /// </summary>
    public partial class UpdateReputationEntityPolicyRequest : AmazonSimpleEmailServiceV2Request
    {
        /// <summary>
        /// Gets and sets the property ReputationEntityPolicy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the reputation management policy to apply to this
        /// entity. This is an Amazon Web Services Amazon SES-managed policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string ReputationEntityPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ReputationEntityPolicy property is set.
        /// </summary>
        internal bool IsSetReputationEntityPolicy() => this.ReputationEntityPolicy != null;

        /// <summary>
        /// Gets and sets the property ReputationEntityReference. 
        /// <para>
        /// The unique identifier for the reputation entity. For resource-type entities, this
        /// is the Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string ReputationEntityReference { get; set; }

        /// <summary>
        /// Checks to see if the ReputationEntityReference property is set.
        /// </summary>
        internal bool IsSetReputationEntityReference() => this.ReputationEntityReference != null;

        /// <summary>
        /// Gets and sets the property ReputationEntityType. 
        /// <para>
        /// The type of reputation entity. Currently, only <c>RESOURCE</c> type entities are supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReputationEntityType ReputationEntityType { get; set; }

        /// <summary>
        /// Checks to see if the ReputationEntityType property is set.
        /// </summary>
        internal bool IsSetReputationEntityType() => this.ReputationEntityType != null;
    }
}
