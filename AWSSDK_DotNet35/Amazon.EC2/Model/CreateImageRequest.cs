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
    /// <para> Creates an Amazon EBS-backed AMI from a "running" or "stopped" instance. AMIs that use an Amazon EBS root device boot faster than
    /// AMIs that use instance stores. They can be up to 1 TiB in size, use storage that persists on instance failure, and can be stopped and
    /// started. </para>
    /// </summary>
    public partial class CreateImageRequest : AmazonEC2Request
    {
        private string instanceId;
        private string name;
        private string description;
        private bool? noReboot;
        private List<BlockDeviceMapping> blockDeviceMappings = new List<BlockDeviceMapping>();


        /// <summary>
        /// The ID of the instance from which to create the new image.
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
        /// The name for the new AMI being created.
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
        /// The description for the new AMI being created.
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
        /// By default this property is set to <c>false</c>, which means Amazon EC2 attempts to cleanly shut down the instance before image creation and
        /// reboots the instance afterwards. When set to true, Amazon EC2 will not shut down the instance before creating the image. When this option is
        /// used, file system integrity on the created image cannot be guaranteed.
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
    
