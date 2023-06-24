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

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes a network resource.
    /// </summary>
    public partial class NetworkResource
    {
        private string _accountId;
        private string _awsRegion;
        private string _coreNetworkId;
        private string _definition;
        private DateTime? _definitionTimestamp;
        private Dictionary<string, string> _metadata = new Dictionary<string, string>();
        private string _registeredGatewayArn;
        private string _resourceArn;
        private string _resourceId;
        private string _resourceType;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// The Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string AwsRegion
        {
            get { return this._awsRegion; }
            set { this._awsRegion = value; }
        }

        // Check to see if AwsRegion property is set
        internal bool IsSetAwsRegion()
        {
            return this._awsRegion != null;
        }

        /// <summary>
        /// Gets and sets the property CoreNetworkId. 
        /// <para>
        /// The ID of a core network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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
        /// Gets and sets the property Definition. 
        /// <para>
        /// Information about the resource, in JSON format. Network Manager gets this information
        /// by describing the resource using its Describe API call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null;
        }

        /// <summary>
        /// Gets and sets the property DefinitionTimestamp. 
        /// <para>
        /// The time that the resource definition was retrieved.
        /// </para>
        /// </summary>
        public DateTime DefinitionTimestamp
        {
            get { return this._definitionTimestamp.GetValueOrDefault(); }
            set { this._definitionTimestamp = value; }
        }

        // Check to see if DefinitionTimestamp property is set
        internal bool IsSetDefinitionTimestamp()
        {
            return this._definitionTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The resource metadata.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null && this._metadata.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RegisteredGatewayArn. 
        /// <para>
        /// The ARN of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1500)]
        public string RegisteredGatewayArn
        {
            get { return this._registeredGatewayArn; }
            set { this._registeredGatewayArn = value; }
        }

        // Check to see if RegisteredGatewayArn property is set
        internal bool IsSetRegisteredGatewayArn()
        {
            return this._registeredGatewayArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1500)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type.
        /// </para>
        ///  
        /// <para>
        /// The following are the supported resource types for Direct Connect:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>dxcon</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>dx-gateway</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>dx-vif</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following are the supported resource types for Network Manager:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>connection</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>device</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>link</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>site</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following are the supported resource types for Amazon VPC:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>customer-gateway</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>transit-gateway</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>transit-gateway-attachment</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>transit-gateway-connect-peer</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>transit-gateway-route-table</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpn-connection</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}