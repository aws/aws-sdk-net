/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes a parameter used to set up an Amazon EBS volume in a block device mapping.</para>
    /// </summary>
    public class EbsInstanceBlockDevice
    {
        
        private string volumeId;
        private AttachmentStatus status;
        private DateTime? attachTime;
        private bool? deleteOnTermination;


        /// <summary>
        /// The ID of the Amazon EBS volume.
        ///  
        /// </summary>
        public string VolumeId
        {
            get { return this.volumeId; }
            set { this.volumeId = value; }
        }

        // Check to see if VolumeId property is set
        internal bool IsSetVolumeId()
        {
            return this.volumeId != null;
        }

        /// <summary>
        /// The attachment state.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>attaching, attached, detaching, detached</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public AttachmentStatus Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// The time stamp when the attachment initiated.
        ///  
        /// </summary>
        public DateTime AttachTime
        {
            get { return this.attachTime ?? default(DateTime); }
            set { this.attachTime = value; }
        }

        // Check to see if AttachTime property is set
        internal bool IsSetAttachTime()
        {
            return this.attachTime.HasValue;
        }

        /// <summary>
        /// Indicates whether the volume is deleted on instance termination.
        ///  
        /// </summary>
        public bool DeleteOnTermination
        {
            get { return this.deleteOnTermination ?? default(bool); }
            set { this.deleteOnTermination = value; }
        }

        // Check to see if DeleteOnTermination property is set
        internal bool IsSetDeleteOnTermination()
        {
            return this.deleteOnTermination.HasValue;
        }
    }
}
