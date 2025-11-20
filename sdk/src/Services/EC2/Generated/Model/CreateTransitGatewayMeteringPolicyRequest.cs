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
    /// Container for the parameters to the CreateTransitGatewayMeteringPolicy operation.
    /// Creates a metering policy for a transit gateway to track and measure network traffic.
    /// </summary>
    public partial class CreateTransitGatewayMeteringPolicyRequest : AmazonEC2Request
    {
        private List<string> _middleboxAttachmentIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;
        private string _transitGatewayId;

        /// <summary>
        /// Gets and sets the property MiddleboxAttachmentIds. 
        /// <para>
        /// The IDs of the middlebox attachments to include in the metering policy.
        /// </para>
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
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to assign to the metering policy.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayId. 
        /// <para>
        /// The ID of the transit gateway for which to create the metering policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}