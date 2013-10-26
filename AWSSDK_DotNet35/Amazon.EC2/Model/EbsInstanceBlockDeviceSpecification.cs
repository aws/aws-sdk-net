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
    /// <para> Specifies how an EBS volume should be mapped as part of a block device mapping specification when launching a new instance. </para>
    /// </summary>
    public class EbsInstanceBlockDeviceSpecification
    {
        
        private string volumeId;
        private bool? deleteOnTermination;


        /// <summary>
        /// The ID of the EBS volume that should be mounted as a block device on an Amazon EC2 instance.
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
        /// Specifies whether the Amazon EBS volume is deleted on instance termination.
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
