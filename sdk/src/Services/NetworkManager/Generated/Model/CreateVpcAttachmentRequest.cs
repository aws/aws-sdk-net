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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
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
namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVpcAttachment operation.
    /// Creates a VPC attachment on an edge location of a core network.
    /// </summary>
    public partial class CreateVpcAttachmentRequest : AmazonNetworkManagerRequest
    {
        private string _clientToken;
        private string _coreNetworkId;
        private VpcOptions _options;
        private List<string> _subnetArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _vpcArn;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client token associated with the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property CoreNetworkId. 
        /// <para>
        /// The ID of a core network for the VPC attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public string CoreNetworkId
        {
            get { return this._coreNetworkId; }
            set { this._coreNetworkId = value; }
        }

        // Check to see if CoreNetworkId property is set
        internal bool IsSetCoreNetworkId()
        {
            return this._coreNetworkId != null;
        }

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// Options for the VPC attachment.
        /// </para>
        /// </summary>
        public VpcOptions Options
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
        /// Gets and sets the property SubnetArns. 
        /// <para>
        /// The subnet ARN of the VPC attachment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SubnetArns
        {
            get { return this._subnetArns; }
            set { this._subnetArns = value; }
        }

        // Check to see if SubnetArns property is set
        internal bool IsSetSubnetArns()
        {
            return this._subnetArns != null && (this._subnetArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key-value tags associated with the request.
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
        /// Gets and sets the property VpcArn. 
        /// <para>
        /// The ARN of the VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=500)]
        public string VpcArn
        {
            get { return this._vpcArn; }
            set { this._vpcArn = value; }
        }

        // Check to see if VpcArn property is set
        internal bool IsSetVpcArn()
        {
            return this._vpcArn != null;
        }

    }
}