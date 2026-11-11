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
    /// Describes volume attachment details.
    /// </summary>
    public partial class VolumeAttachment
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
        /// Indicates whether the EBS volume is deleted on instance termination.
        /// </para>
        /// </summary>
        public bool? DeleteOnTermination { get; set; }

        /// <summary>
        /// Checks to see if the DeleteOnTermination property is set.
        /// </summary>
        internal bool IsSetDeleteOnTermination() => this.DeleteOnTermination.HasValue;

        /// <summary>
        /// Gets and sets the property Device. 
        /// <para>
        /// The device name.
        /// </para>
        ///  
        /// <para>
        /// If the volume is attached to an Amazon Web Services-managed resource, this parameter
        /// returns <c>null</c>.
        /// </para>
        /// </summary>
        public string Device { get; set; }

        /// <summary>
        /// Checks to see if the Device property is set.
        /// </summary>
        internal bool IsSetDevice() => this.Device != null;

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
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        ///  
        /// <para>
        /// If the volume is attached to an Amazon Web Services-managed resource, this parameter
        /// returns <c>null</c>.
        /// </para>
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property InstanceOwningService. 
        /// <para>
        /// The service principal of the Amazon Web Services service that owns the underlying
        /// resource to which the volume is attached.
        /// </para>
        ///  
        /// <para>
        /// This parameter is returned only for volumes that are attached to Amazon Web Services-managed
        /// resources.
        /// </para>
        /// </summary>
        public string InstanceOwningService { get; set; }

        /// <summary>
        /// Checks to see if the InstanceOwningService property is set.
        /// </summary>
        internal bool IsSetInstanceOwningService() => this.InstanceOwningService != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The attachment state of the volume.
        /// </para>
        /// </summary>
        public VolumeAttachmentState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The ID of the volume.
        /// </para>
        /// </summary>
        public string VolumeId { get; set; }

        /// <summary>
        /// Checks to see if the VolumeId property is set.
        /// </summary>
        internal bool IsSetVolumeId() => this.VolumeId != null;
    }
}
