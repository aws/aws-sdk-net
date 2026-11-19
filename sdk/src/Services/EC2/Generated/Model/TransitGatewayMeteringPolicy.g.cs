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
    /// Describes a transit gateway metering policy.
    /// </summary>
    public partial class TransitGatewayMeteringPolicy
    {
        /// <summary>
        /// Gets and sets the property MiddleboxAttachmentIds. 
        /// <para>
        /// The IDs of the middlebox attachments associated with the metering policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MiddleboxAttachmentIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MiddleboxAttachmentIds property is set.
        /// </summary>
        internal bool IsSetMiddleboxAttachmentIds() => this.MiddleboxAttachmentIds != null && (this.MiddleboxAttachmentIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the transit gateway metering policy.
        /// </para>
        /// </summary>
        public TransitGatewayMeteringPolicyState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the transit gateway metering policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TransitGatewayId. 
        /// <para>
        /// The ID of the transit gateway associated with the metering policy.
        /// </para>
        /// </summary>
        public string TransitGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayId property is set.
        /// </summary>
        internal bool IsSetTransitGatewayId() => this.TransitGatewayId != null;

        /// <summary>
        /// Gets and sets the property TransitGatewayMeteringPolicyId. 
        /// <para>
        /// The ID of the transit gateway metering policy.
        /// </para>
        /// </summary>
        public string TransitGatewayMeteringPolicyId { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayMeteringPolicyId property is set.
        /// </summary>
        internal bool IsSetTransitGatewayMeteringPolicyId() => this.TransitGatewayMeteringPolicyId != null;

        /// <summary>
        /// Gets and sets the property UpdateEffectiveAt. 
        /// <para>
        /// The date and time when the metering policy update becomes effective.
        /// </para>
        /// </summary>
        public DateTime? UpdateEffectiveAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdateEffectiveAt property is set.
        /// </summary>
        internal bool IsSetUpdateEffectiveAt() => this.UpdateEffectiveAt.HasValue;
    }
}
