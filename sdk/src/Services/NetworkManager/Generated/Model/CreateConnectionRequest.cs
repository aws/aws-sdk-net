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
    /// Container for the parameters to the CreateConnection operation.
    /// Creates a connection between two devices. The devices can be a physical or virtual
    /// appliance that connects to a third-party appliance in a VPC, or a physical appliance
    /// that connects to another physical appliance in an on-premises network.
    /// </summary>
    public partial class CreateConnectionRequest : AmazonNetworkManagerRequest
    {
        private string _connectedDeviceId;
        private string _connectedLinkId;
        private string _description;
        private string _deviceId;
        private string _globalNetworkId;
        private string _linkId;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ConnectedDeviceId. 
        /// <para>
        /// The ID of the second device in the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public string ConnectedDeviceId
        {
            get { return this._connectedDeviceId; }
            set { this._connectedDeviceId = value; }
        }

        // Check to see if ConnectedDeviceId property is set
        internal bool IsSetConnectedDeviceId()
        {
            return this._connectedDeviceId != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectedLinkId. 
        /// <para>
        /// The ID of the link for the second device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public string ConnectedLinkId
        {
            get { return this._connectedLinkId; }
            set { this._connectedLinkId = value; }
        }

        // Check to see if ConnectedLinkId property is set
        internal bool IsSetConnectedLinkId()
        {
            return this._connectedLinkId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the connection.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Maximum length of 256 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceId. 
        /// <para>
        /// The ID of the first device in the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public string DeviceId
        {
            get { return this._deviceId; }
            set { this._deviceId = value; }
        }

        // Check to see if DeviceId property is set
        internal bool IsSetDeviceId()
        {
            return this._deviceId != null;
        }

        /// <summary>
        /// Gets and sets the property GlobalNetworkId. 
        /// <para>
        /// The ID of the global network.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public string GlobalNetworkId
        {
            get { return this._globalNetworkId; }
            set { this._globalNetworkId = value; }
        }

        // Check to see if GlobalNetworkId property is set
        internal bool IsSetGlobalNetworkId()
        {
            return this._globalNetworkId != null;
        }

        /// <summary>
        /// Gets and sets the property LinkId. 
        /// <para>
        /// The ID of the link for the first device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public string LinkId
        {
            get { return this._linkId; }
            set { this._linkId = value; }
        }

        // Check to see if LinkId property is set
        internal bool IsSetLinkId()
        {
            return this._linkId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to apply to the resource during creation.
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

    }
}