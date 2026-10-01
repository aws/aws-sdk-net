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

namespace Amazon.SnowDeviceManagement.Model
{
    /// <summary>
    /// Describes a parameter used to set up an Amazon Elastic Block Store (Amazon EBS) volume
    /// in a block device mapping.
    /// </summary>
    public partial class EbsInstanceBlockDevice
    {
        /// <summary>
        /// Gets and sets the property AttachTime. 
        /// <para>
        /// When the attachment was initiated.
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
        /// A value that indicates whether the volume is deleted on instance termination.
        /// </para>
        /// </summary>
        public bool? DeleteOnTermination { get; set; }

        /// <summary>
        /// Checks to see if the DeleteOnTermination property is set.
        /// </summary>
        internal bool IsSetDeleteOnTermination() => this.DeleteOnTermination.HasValue;

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
        /// The ID of the Amazon EBS volume.
        /// </para>
        /// </summary>
        public string VolumeId { get; set; }

        /// <summary>
        /// Checks to see if the VolumeId property is set.
        /// </summary>
        internal bool IsSetVolumeId() => this.VolumeId != null;
    }
}
