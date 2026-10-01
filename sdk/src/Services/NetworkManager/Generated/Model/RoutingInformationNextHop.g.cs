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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Information about the next hop for a route in the core network.
    /// </summary>
    public partial class RoutingInformationNextHop
    {
        /// <summary>
        /// Gets and sets the property CoreNetworkAttachmentId. 
        /// <para>
        /// The ID of the core network attachment for the next hop.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string CoreNetworkAttachmentId { get; set; }

        /// <summary>
        /// Checks to see if the CoreNetworkAttachmentId property is set.
        /// </summary>
        internal bool IsSetCoreNetworkAttachmentId() => this.CoreNetworkAttachmentId != null;

        /// <summary>
        /// Gets and sets the property EdgeLocation. 
        /// <para>
        /// The edge location for the next hop.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string EdgeLocation { get; set; }

        /// <summary>
        /// Checks to see if the EdgeLocation property is set.
        /// </summary>
        internal bool IsSetEdgeLocation() => this.EdgeLocation != null;

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The IP address of the next hop.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Checks to see if the IpAddress property is set.
        /// </summary>
        internal bool IsSetIpAddress() => this.IpAddress != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource for the next hop.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource for the next hop.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property SegmentName. 
        /// <para>
        /// The name of the segment for the next hop.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string SegmentName { get; set; }

        /// <summary>
        /// Checks to see if the SegmentName property is set.
        /// </summary>
        internal bool IsSetSegmentName() => this.SegmentName != null;
    }
}
