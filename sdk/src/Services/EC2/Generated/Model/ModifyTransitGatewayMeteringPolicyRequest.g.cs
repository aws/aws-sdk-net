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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyTransitGatewayMeteringPolicy operation.
    /// Modifies a transit gateway metering policy.
    /// </summary>
    public partial class ModifyTransitGatewayMeteringPolicyRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property AddMiddleboxAttachmentIds. 
        /// <para>
        /// The IDs of middlebox attachments to add to the metering policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AddMiddleboxAttachmentIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AddMiddleboxAttachmentIds property is set.
        /// </summary>
        internal bool IsSetAddMiddleboxAttachmentIds() => this.AddMiddleboxAttachmentIds != null && (this.AddMiddleboxAttachmentIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property RemoveMiddleboxAttachmentIds. 
        /// <para>
        /// The IDs of middlebox attachments to remove from the metering policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RemoveMiddleboxAttachmentIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RemoveMiddleboxAttachmentIds property is set.
        /// </summary>
        internal bool IsSetRemoveMiddleboxAttachmentIds() => this.RemoveMiddleboxAttachmentIds != null && (this.RemoveMiddleboxAttachmentIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TransitGatewayMeteringPolicyId. 
        /// <para>
        /// The ID of the transit gateway metering policy to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TransitGatewayMeteringPolicyId { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayMeteringPolicyId property is set.
        /// </summary>
        internal bool IsSetTransitGatewayMeteringPolicyId() => this.TransitGatewayMeteringPolicyId != null;
    }
}
