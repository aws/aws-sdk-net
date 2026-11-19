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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a parameter used to set up an EBS volume in a block device mapping.
    /// </summary>
    public partial class EbsInstanceBlockDevice
    {
        /// <summary>
        /// Gets and sets the property AssociatedResource. 
        /// <para>
        /// The ARN of the Amazon Web Services-managed resource to which the volume is attached.
        /// </para>
        /// </summary>
        public string AssociatedResource { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedResource property is set.
        /// </summary>
        internal bool IsSetAssociatedResource() => this.AssociatedResource != null;

        /// <summary>
        /// Gets and sets the property AttachTime. 
        /// <para>
        /// The time stamp when the attachment initiated.
        /// </para>
        /// </summary>
        public DateTime? AttachTime { get; set; }

        /// <summary>
        /// Checks to see if the AttachTime property is set.
        /// </summary>
        internal bool IsSetAttachTime() => this.AttachTime.HasValue;

        /// <summary>
        /// Gets and sets the property DeleteOnTermination. 
        /// <para>
        /// Indicates whether the volume is deleted on instance termination.
        /// </para>
        /// </summary>
        public bool? DeleteOnTermination { get; set; }

        /// <summary>
        /// Checks to see if the DeleteOnTermination property is set.
        /// </summary>
        internal bool IsSetDeleteOnTermination() => this.DeleteOnTermination.HasValue;

        /// <summary>
        /// Gets and sets the property EbsCardIndex. 
        /// <para>
        /// The index of the EBS card. Some instance types support multiple EBS cards. The default
        /// EBS card index is 0.
        /// </para>
        /// </summary>
        public int? EbsCardIndex { get; set; }

        /// <summary>
        /// Checks to see if the EbsCardIndex property is set.
        /// </summary>
        internal bool IsSetEbsCardIndex() => this.EbsCardIndex.HasValue;

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The service provider that manages the EBS volume.
        /// </para>
        /// </summary>
        public OperatorResponse Operator { get; set; }

        /// <summary>
        /// Checks to see if the Operator property is set.
        /// </summary>
        internal bool IsSetOperator() => this.Operator != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The attachment state.
        /// </para>
        /// </summary>
        public AttachmentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The ID of the EBS volume.
        /// </para>
        /// </summary>
        public string VolumeId { get; set; }

        /// <summary>
        /// Checks to see if the VolumeId property is set.
        /// </summary>
        internal bool IsSetVolumeId() => this.VolumeId != null;

        /// <summary>
        /// Gets and sets the property VolumeOwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the volume.
        /// </para>
        ///  
        /// <para>
        /// This parameter is returned only for volumes that are attached to Amazon Web Services-managed
        /// resources.
        /// </para>
        /// </summary>
        public string VolumeOwnerId { get; set; }

        /// <summary>
        /// Checks to see if the VolumeOwnerId property is set.
        /// </summary>
        internal bool IsSetVolumeOwnerId() => this.VolumeOwnerId != null;
    }
}
