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
    /// Container for the parameters to the UpdateVpcAttachment operation.
    /// Updates a VPC attachment.
    /// </summary>
    public partial class UpdateVpcAttachmentRequest : AmazonNetworkManagerRequest
    {
        private List<string> _addSubnetArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _attachmentId;
        private VpcOptions _options;
        private List<string> _removeSubnetArns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AddSubnetArns. 
        /// <para>
        /// Adds a subnet ARN to the VPC attachment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AddSubnetArns
        {
            get { return this._addSubnetArns; }
            set { this._addSubnetArns = value; }
        }

        // Check to see if AddSubnetArns property is set
        internal bool IsSetAddSubnetArns()
        {
            return this._addSubnetArns != null && (this._addSubnetArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AttachmentId. 
        /// <para>
        /// The ID of the attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public string AttachmentId
        {
            get { return this._attachmentId; }
            set { this._attachmentId = value; }
        }

        // Check to see if AttachmentId property is set
        internal bool IsSetAttachmentId()
        {
            return this._attachmentId != null;
        }

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// Additional options for updating the VPC attachment. 
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
        /// Gets and sets the property RemoveSubnetArns. 
        /// <para>
        /// Removes a subnet ARN from the attachment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RemoveSubnetArns
        {
            get { return this._removeSubnetArns; }
            set { this._removeSubnetArns = value; }
        }

        // Check to see if RemoveSubnetArns property is set
        internal bool IsSetRemoveSubnetArns()
        {
            return this._removeSubnetArns != null && (this._removeSubnetArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}