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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateVolume operation.
    /// <para>Updates an Amazon EBS volume's name or mount point. For more information, see <a
    /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html"
    /// >http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html</a> .</para>
    /// </summary>
    /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.UpdateVolume"/>
    public class UpdateVolumeRequest : AmazonWebServiceRequest
    {
        private string volumeId;
        private string name;
        private string mountPoint;

        /// <summary>
        /// The volume ID.
        ///  
        /// </summary>
        public string VolumeId
        {
            get { return this.volumeId; }
            set { this.volumeId = value; }
        }

        /// <summary>
        /// Sets the VolumeId property
        /// </summary>
        /// <param name="volumeId">The value to set for the VolumeId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateVolumeRequest WithVolumeId(string volumeId)
        {
            this.volumeId = volumeId;
            return this;
        }
            

        // Check to see if VolumeId property is set
        internal bool IsSetVolumeId()
        {
            return this.volumeId != null;
        }

        /// <summary>
        /// The new name.
        ///  
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateVolumeRequest WithName(string name)
        {
            this.name = name;
            return this;
        }
            

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// The new mount point.
        ///  
        /// </summary>
        public string MountPoint
        {
            get { return this.mountPoint; }
            set { this.mountPoint = value; }
        }

        /// <summary>
        /// Sets the MountPoint property
        /// </summary>
        /// <param name="mountPoint">The value to set for the MountPoint property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateVolumeRequest WithMountPoint(string mountPoint)
        {
            this.mountPoint = mountPoint;
            return this;
        }
            

        // Check to see if MountPoint property is set
        internal bool IsSetMountPoint()
        {
            return this.mountPoint != null;
        }
    }
}
    
