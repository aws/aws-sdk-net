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
    /// Describes a context entry in a context store. A context entry describes a resource,
    /// such as a security group, subnet, or attachment.
    /// </summary>
    public partial class ContextEntry
    {
        /// <summary>
        /// Gets and sets the property AttachmentType. 
        /// <para>
        /// The type of the attachment, for example <c>VPC</c>. Network Manager returns this value
        /// only when the context type is <c>Attachment</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string AttachmentType { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentType property is set.
        /// </summary>
        internal bool IsSetAttachmentType() => this.AttachmentType != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The ID of the Availability Zone of the resource, for example <c>use1-az2</c>. Network
        /// Manager returns this value only when the context type is <c>Subnet</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property ContextId. 
        /// <para>
        /// The ID of the context entry.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ContextId { get; set; }

        /// <summary>
        /// Checks to see if the ContextId property is set.
        /// </summary>
        internal bool IsSetContextId() => this.ContextId != null;

        /// <summary>
        /// Gets and sets the property ContextType. 
        /// <para>
        /// The type of the context entry, for example <c>SegmentId</c>, <c>Subnet</c>, or <c>Attachment</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ContextType { get; set; }

        /// <summary>
        /// Checks to see if the ContextType property is set.
        /// </summary>
        internal bool IsSetContextType() => this.ContextType != null;

        /// <summary>
        /// Gets and sets the property PublicId. 
        /// <para>
        /// The ID of the resource, for example a security group ID, subnet ID, or transit gateway
        /// attachment ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
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
        [AWSProperty(Min = 1, Max = 63)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property SegmentType. 
        /// <para>
        /// The type of the segment, for example <c>SecurityGroup</c>. Network Manager returns
        /// this value only when the context type is <c>SegmentId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string SegmentType { get; set; }

        /// <summary>
        /// Checks to see if the SegmentType property is set.
        /// </summary>
        internal bool IsSetSegmentType() => this.SegmentType != null;
    }
}
