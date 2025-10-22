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
 * Do not modify this file. This file is generated from the rtbfabric-2023-05-15.normal.json service model.
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
namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLink operation.
    /// Creates a new link between RTB applications.
    /// 
    ///  
    /// <para>
    /// Establishes a connection that allows RTB applications to communicate and exchange
    /// bid requests and responses.
    /// </para>
    /// </summary>
    public partial class CreateLinkRequest : AmazonRTBFabricRequest
    {
        private LinkAttributes _attributes;
        private string _gatewayId;
        private bool? _httpResponderAllowed;
        private LinkLogSettings _logSettings;
        private string _peerGatewayId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Attributes of the link.
        /// </para>
        /// </summary>
        public LinkAttributes Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayId. 
        /// <para>
        /// The unique identifier of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GatewayId
        {
            get { return this._gatewayId; }
            set { this._gatewayId = value; }
        }

        // Check to see if GatewayId property is set
        internal bool IsSetGatewayId()
        {
            return this._gatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property HttpResponderAllowed. 
        /// <para>
        /// Boolean to specify if an HTTP responder is allowed.
        /// </para>
        /// </summary>
        public bool? HttpResponderAllowed
        {
            get { return this._httpResponderAllowed; }
            set { this._httpResponderAllowed = value; }
        }

        // Check to see if HttpResponderAllowed property is set
        internal bool IsSetHttpResponderAllowed()
        {
            return this._httpResponderAllowed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogSettings. 
        /// <para>
        /// Settings for the application logs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LinkLogSettings LogSettings
        {
            get { return this._logSettings; }
            set { this._logSettings = value; }
        }

        // Check to see if LogSettings property is set
        internal bool IsSetLogSettings()
        {
            return this._logSettings != null;
        }

        /// <summary>
        /// Gets and sets the property PeerGatewayId. 
        /// <para>
        /// The unique identifier of the peer gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PeerGatewayId
        {
            get { return this._peerGatewayId; }
            set { this._peerGatewayId = value; }
        }

        // Check to see if PeerGatewayId property is set
        internal bool IsSetPeerGatewayId()
        {
            return this._peerGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of the key-value pairs of the tag or tags to assign to the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
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