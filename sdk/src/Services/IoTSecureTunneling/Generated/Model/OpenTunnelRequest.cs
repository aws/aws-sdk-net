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
 * Do not modify this file. This file is generated from the iotsecuretunneling-2018-10-05.normal.json service model.
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
namespace Amazon.IoTSecureTunneling.Model
{
    /// <summary>
    /// Container for the parameters to the OpenTunnel operation.
    /// Creates a new tunnel, and returns two client access tokens for clients to use to connect
    /// to the IoT Secure Tunneling proxy server.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">OpenTunnel</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class OpenTunnelRequest : AmazonIoTSecureTunnelingRequest
    {
        private string _description;
        private DestinationConfig _destinationConfig;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private TimeoutConfig _timeoutConfig;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A short text description of the tunnel. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DestinationConfig. 
        /// <para>
        /// The destination configuration for the OpenTunnel request.
        /// </para>
        /// </summary>
        public DestinationConfig DestinationConfig
        {
            get { return this._destinationConfig; }
            set { this._destinationConfig = value; }
        }

        // Check to see if DestinationConfig property is set
        internal bool IsSetDestinationConfig()
        {
            return this._destinationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A collection of tag metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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
        /// Gets and sets the property TimeoutConfig. 
        /// <para>
        /// Timeout configuration for a tunnel.
        /// </para>
        /// </summary>
        public TimeoutConfig TimeoutConfig
        {
            get { return this._timeoutConfig; }
            set { this._timeoutConfig = value; }
        }

        // Check to see if TimeoutConfig property is set
        internal bool IsSetTimeoutConfig()
        {
            return this._timeoutConfig != null;
        }

    }
}