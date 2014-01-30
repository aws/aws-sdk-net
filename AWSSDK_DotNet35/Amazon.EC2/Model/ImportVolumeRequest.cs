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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ImportVolume operation.
    /// <para>Creates an import volume task using metadata from the specified disk image. After importing the image, you then upload it using the
    /// ec2-upload-disk-image command in the Amazon EC2 command-line interface (CLI) tools. For more information, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html" >Using the Command Line Tools to Import Your
    /// Virtual Machine to Amazon EC2</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
    /// </summary>
    public partial class ImportVolumeRequest : AmazonEC2Request
    {
        private string availabilityZone;
        private DiskImageDetail image;
        private string description;
        private VolumeDetail volume;


        /// <summary>
        /// The Availability Zone for the resulting Amazon EBS volume.
        ///  
        /// </summary>
        public string AvailabilityZone
        {
            get { return this.availabilityZone; }
            set { this.availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this.availabilityZone != null;
        }

        /// <summary>
        /// 
        ///  
        /// </summary>
        public DiskImageDetail Image
        {
            get { return this.image; }
            set { this.image = value; }
        }

        // Check to see if Image property is set
        internal bool IsSetImage()
        {
            return this.image != null;
        }

        /// <summary>
        /// An optional description for the volume being imported.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// 
        ///  
        /// </summary>
        public VolumeDetail Volume
        {
            get { return this.volume; }
            set { this.volume = value; }
        }

        // Check to see if Volume property is set
        internal bool IsSetVolume()
        {
            return this.volume != null;
        }

    }
}
    
