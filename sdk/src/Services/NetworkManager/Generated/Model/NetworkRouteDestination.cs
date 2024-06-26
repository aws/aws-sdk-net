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
    /// Describes the destination of a network route.
    /// </summary>
    public partial class NetworkRouteDestination
    {
        private string _coreNetworkAttachmentId;
        private string _edgeLocation;
        private string _networkFunctionGroupName;
        private string _resourceId;
        private string _resourceType;
        private string _segmentName;
        private string _transitGatewayAttachmentId;

        /// <summary>
        /// Gets and sets the property CoreNetworkAttachmentId. 
        /// <para>
        /// The ID of a core network attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public string CoreNetworkAttachmentId
        {
            get { return this._coreNetworkAttachmentId; }
            set { this._coreNetworkAttachmentId = value; }
        }

        // Check to see if CoreNetworkAttachmentId property is set
        internal bool IsSetCoreNetworkAttachmentId()
        {
            return this._coreNetworkAttachmentId != null;
        }

        /// <summary>
        /// Gets and sets the property EdgeLocation. 
        /// <para>
        /// The edge location for the network destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string EdgeLocation
        {
            get { return this._edgeLocation; }
            set { this._edgeLocation = value; }
        }

        // Check to see if EdgeLocation property is set
        internal bool IsSetEdgeLocation()
        {
            return this._edgeLocation != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkFunctionGroupName. 
        /// <para>
        /// The network function group name associated with the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string NetworkFunctionGroupName
        {
            get { return this._networkFunctionGroupName; }
            set { this._networkFunctionGroupName = value; }
        }

        // Check to see if NetworkFunctionGroupName property is set
        internal bool IsSetNetworkFunctionGroupName()
        {
            return this._networkFunctionGroupName != null;
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
        /// Gets and sets the property SegmentName. 
        /// <para>
        /// The name of the segment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string SegmentName
        {
            get { return this._segmentName; }
            set { this._segmentName = value; }
        }

        // Check to see if SegmentName property is set
        internal bool IsSetSegmentName()
        {
            return this._segmentName != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayAttachmentId. 
        /// <para>
        /// The ID of the transit gateway attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public string TransitGatewayAttachmentId
        {
            get { return this._transitGatewayAttachmentId; }
            set { this._transitGatewayAttachmentId = value; }
        }

        // Check to see if TransitGatewayAttachmentId property is set
        internal bool IsSetTransitGatewayAttachmentId()
        {
            return this._transitGatewayAttachmentId != null;
        }

    }
}