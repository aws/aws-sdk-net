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

namespace Amazon.Interconnect.Model
{
    /// <summary>
    /// Container for the parameters to the AcceptConnectionProposal operation. Accepts a
    /// connection proposal which was generated at a supported partner's portal. <para> The
    /// proposal contains the Environment and bandwidth that were chosen on the partner's
    /// portal and cannot be modified. </para> <para> Upon accepting the proposal a connection
    /// will be made between the AWS network as accessed via the selected Attach Point and
    /// the network previously selected network on the partner's portal. </para>
    /// </summary>
    public partial class AcceptConnectionProposalRequest : AmazonInterconnectRequest
    {
        /// <summary>
        /// Gets and sets the property ActivationKey. 
        /// <para>
        /// An Activation Key that was generated on a supported partner's portal. This key captures
        /// the desired parameters from the initial creation request.
        /// </para>
        ///  
        /// <para>
        /// The details of this request can be described using with <a>DescribeConnectionProposal</a>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 2048)]
        public string ActivationKey { get; set; }

        /// <summary>
        /// Checks to see if the ActivationKey property is set.
        /// </summary>
        internal bool IsSetActivationKey() => this.ActivationKey != null;

        /// <summary>
        /// Gets and sets the property AttachPoint. 
        /// <para>
        /// The Attach Point to which the connection should be associated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AttachPoint AttachPoint { get; set; }

        /// <summary>
        /// Checks to see if the AttachPoint property is set.
        /// </summary>
        internal bool IsSetAttachPoint() => this.AttachPoint != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Idempotency token used for the request.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description to distinguish this <a>Connection</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to associate with the resulting <a>Connection</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
