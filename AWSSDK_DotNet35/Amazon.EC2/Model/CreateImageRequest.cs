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
    /// Container for the parameters to the CreateImage operation.
    /// <para>Creates an Amazon EBS-backed AMI from an Amazon EBS-backed instance that is either running or stopped.</para> <para>If you customized
    /// your instance with instance store volumes or EBS volumes in addition to the root device volume, the new AMI contains block device mapping
    /// information for those volumes. When you launch an instance from this new AMI, the instance automatically launches with those additional
    /// volumes.</para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami-ebs.html"
    /// >Creating Amazon EBS-Backed Linux AMIs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
    /// </summary>
    public partial class CreateImageRequest : AmazonEC2Request
    {
        private string instanceId;
        private string name;
        private string description;
        private bool? noReboot;
        private List<BlockDeviceMapping> blockDeviceMappings = new List<BlockDeviceMapping>();


        /// <summary>
        /// The ID of the instance.
        ///  
        /// </summary>
        public string InstanceId
        {
            get { return this.instanceId; }
            set { this.instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this.instanceId != null;
        }

        /// <summary>
        /// A name for the new image. Constraints: 3-128 alphanumeric characters, parenthesis (()), periods (.), slashes (/), dashes (-), or
        /// underscores(_)
        ///  
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// A description for the new image.
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
        /// By default, this parameter is set to <c>false</c>, which means Amazon EC2 attempts to shut down the instance cleanly before image creation
        /// and then reboots the instance. When the parameter is set to <c>true</c>, Amazon EC2 doesn't shut down the instance before creating the
        /// image. When this option is used, file system integrity on the created image can't be guaranteed.
        ///  
        /// </summary>
        public bool NoReboot
        {
            get { return this.noReboot ?? default(bool); }
            set { this.noReboot = value; }
        }

        // Check to see if NoReboot property is set
        internal bool IsSetNoReboot()
        {
            return this.noReboot.HasValue;
        }

        /// <summary>
        /// Information about one or more block device mappings.
        ///  
        /// </summary>
        public List<BlockDeviceMapping> BlockDeviceMappings
        {
            get { return this.blockDeviceMappings; }
            set { this.blockDeviceMappings = value; }
        }

        // Check to see if BlockDeviceMappings property is set
        internal bool IsSetBlockDeviceMappings()
        {
            return this.blockDeviceMappings.Count > 0;
        }

    }
}
    
