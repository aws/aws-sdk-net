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
    /// Container for the parameters to the UpdateDirectConnectGatewayAttachment operation.
    /// Updates the edge locations associated with an Amazon Web Services Direct Connect gateway
    /// attachment.
    /// </summary>
    public partial class UpdateDirectConnectGatewayAttachmentRequest : AmazonNetworkManagerRequest
    {
        private string _attachmentId;
        private List<string> _edgeLocations = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AttachmentId. 
        /// <para>
        /// The ID of the Direct Connect gateway attachment for the updated edge locations. 
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
        /// Gets and sets the property EdgeLocations. 
        /// <para>
        /// One or more edge locations to update for the Direct Connect gateway attachment. The
        /// updated array of edge locations overwrites the previous array of locations. <c>EdgeLocations</c>
        /// is only used for Direct Connect gateway attachments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EdgeLocations
        {
            get { return this._edgeLocations; }
            set { this._edgeLocations = value; }
        }

        // Check to see if EdgeLocations property is set
        internal bool IsSetEdgeLocations()
        {
            return this._edgeLocations != null && (this._edgeLocations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}