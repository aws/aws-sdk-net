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
    /// Container for the parameters to the CreateTransitGatewayConnect operation.
    /// Creates a Connect attachment from a specified transit gateway attachment. A Connect
    /// attachment is a GRE-based tunnel attachment that you can use to establish a connection
    /// between a transit gateway and an appliance.
    /// 
    ///  
    /// <para>
    /// A Connect attachment uses an existing VPC or Amazon Web Services Direct Connect attachment
    /// as the underlying transport mechanism.
    /// </para>
    /// </summary>
    public partial class CreateTransitGatewayConnectRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private CreateTransitGatewayConnectRequestOptions _options;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;
        private string _transportTransitGatewayAttachmentId;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The Connect attachment options.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CreateTransitGatewayConnectRequestOptions Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the Connect attachment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Gets and sets the property TransportTransitGatewayAttachmentId. 
        /// <para>
        /// The ID of the transit gateway attachment. You can specify a VPC attachment or Amazon
        /// Web Services Direct Connect attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TransportTransitGatewayAttachmentId
        {
            get { return this._transportTransitGatewayAttachmentId; }
            set { this._transportTransitGatewayAttachmentId = value; }
        }

        // Check to see if TransportTransitGatewayAttachmentId property is set
        internal bool IsSetTransportTransitGatewayAttachmentId()
        {
            return this._transportTransitGatewayAttachmentId != null;
        }

    }
}