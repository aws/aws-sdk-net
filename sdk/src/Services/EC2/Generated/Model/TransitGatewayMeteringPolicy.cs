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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
        private List<string> _middleboxAttachmentIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private TransitGatewayMeteringPolicyState _state;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _transitGatewayId;
        private string _transitGatewayMeteringPolicyId;
        private DateTime? _updateEffectiveAt;

        /// <summary>
        /// Gets and sets the property MiddleboxAttachmentIds. 
        /// <para>
        /// The IDs of the middlebox attachments associated with the metering policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MiddleboxAttachmentIds
        {
            get { return this._middleboxAttachmentIds; }
            set { this._middleboxAttachmentIds = value; }
        }

        // Check to see if MiddleboxAttachmentIds property is set
        internal bool IsSetMiddleboxAttachmentIds()
        {
            return this._middleboxAttachmentIds != null && (this._middleboxAttachmentIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the transit gateway metering policy.
        /// </para>
        /// </summary>
        public TransitGatewayMeteringPolicyState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the transit gateway metering policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayId. 
        /// <para>
        /// The ID of the transit gateway associated with the metering policy.
        /// </para>
        /// </summary>
        public string TransitGatewayId
        {
            get { return this._transitGatewayId; }
            set { this._transitGatewayId = value; }
        }

        // Check to see if TransitGatewayId property is set
        internal bool IsSetTransitGatewayId()
        {
            return this._transitGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayMeteringPolicyId. 
        /// <para>
        /// The ID of the transit gateway metering policy.
        /// </para>
        /// </summary>
        public string TransitGatewayMeteringPolicyId
        {
            get { return this._transitGatewayMeteringPolicyId; }
            set { this._transitGatewayMeteringPolicyId = value; }
        }

        // Check to see if TransitGatewayMeteringPolicyId property is set
        internal bool IsSetTransitGatewayMeteringPolicyId()
        {
            return this._transitGatewayMeteringPolicyId != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateEffectiveAt. 
        /// <para>
        /// The date and time when the metering policy update becomes effective.
        /// </para>
        /// </summary>
        public DateTime? UpdateEffectiveAt
        {
            get { return this._updateEffectiveAt; }
            set { this._updateEffectiveAt = value; }
        }

        // Check to see if UpdateEffectiveAt property is set
        internal bool IsSetUpdateEffectiveAt()
        {
            return this._updateEffectiveAt.HasValue; 
        }

    }
}