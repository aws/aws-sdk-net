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
    /// A resource that a context store records, which <c>ListResourcesInContextStore</c>
    /// returns.
    /// </summary>
    public partial class ResourceContext
    {
        /// <summary>
        /// Gets and sets the property AttachmentType. 
        /// <para>
        /// The type of the transit gateway attachment. Present for attachments.
        /// </para>
        /// </summary>
        public string AttachmentType { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentType property is set.
        /// </summary>
        internal bool IsSetAttachmentType() => this.AttachmentType != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone of the resource. Present for subnets.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property ContextType. 
        /// <para>
        /// The kind of context that the context store records for the resource. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ResourceId</c> - A VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SegmentId</c> - A security group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Subnet</c> - A subnet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Attachment</c> - A transit gateway attachment.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ContextType ContextType { get; set; }

        /// <summary>
        /// Checks to see if the ContextType property is set.
        /// </summary>
        internal bool IsSetContextType() => this.ContextType != null;

        /// <summary>
        /// Gets and sets the property PublicId. 
        /// <para>
        /// The identifier of the resource, for example <c>vpc-1234567890abcdef0</c>, <c>subnet-1234567890abcdef0</c>,
        /// <c>sg-1234567890abcdef0</c>, or <c>tgw-attach-1234567890abcdef0</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PublicId { get; set; }

        /// <summary>
        /// Checks to see if the PublicId property is set.
        /// </summary>
        internal bool IsSetPublicId() => this.PublicId != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region of the resource.
        /// </para>
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;
    }
}
