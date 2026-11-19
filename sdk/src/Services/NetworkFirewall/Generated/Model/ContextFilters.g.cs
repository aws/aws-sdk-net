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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Filters for <c>ListResourcesInContextStore</c>. Both filters are optional. If you
    /// specify both, Network Firewall returns only the resources that match both.
    /// </summary>
    public partial class ContextFilters
    {
        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region of the resources to return, for example <c>us-east-1</c>.
        /// </para>
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource to return. Each resource type corresponds to the <c>ContextType</c>
        /// that Network Firewall reports for the resource:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SecurityGroup</c> - Security groups. Reported with the <c>SegmentId</c> context
        /// type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VPC</c> - VPCs. Reported with the <c>ResourceId</c> context type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Subnet</c> - Subnets. Reported with the <c>Subnet</c> context type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TGWAttachment</c> - Transit gateway attachments. Reported with the <c>Attachment</c>
        /// context type.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}
