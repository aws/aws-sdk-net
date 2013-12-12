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
    /// Container for the parameters to the DescribeVolumes operation.
    /// <para>Describes an instance's Amazon EBS volumes.</para> <para><b>NOTE:</b>You must specify at least one of the parameters.</para> <para>
    /// <b>Required Permissions</b> : To use this action, an IAM user must have a Show, Deploy, or Manage permissions level for the stack, or an
    /// attached policy that explicitly grants permissions. For more information on user permissions, see <a
    /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
    /// </summary>
    public partial class DescribeVolumesRequest : AmazonOpsWorksRequest
    {
        private string instanceId;
        private string stackId;
        private string raidArrayId;
        private List<string> volumeIds = new List<string>();


        /// <summary>
        /// The instance ID. If you use this parameter, <c>DescribeVolumes</c> returns descriptions of the volumes associated with the specified
        /// instance.
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
        /// A stack ID. The action describes the stack's registered Amazon EBS volumes.
        ///  
        /// </summary>
        public string StackId
        {
            get { return this.stackId; }
            set { this.stackId = value; }
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this.stackId != null;
        }

        /// <summary>
        /// The RAID array ID. If you use this parameter, <c>DescribeVolumes</c> returns descriptions of the volumes associated with the specified RAID
        /// array.
        ///  
        /// </summary>
        public string RaidArrayId
        {
            get { return this.raidArrayId; }
            set { this.raidArrayId = value; }
        }

        // Check to see if RaidArrayId property is set
        internal bool IsSetRaidArrayId()
        {
            return this.raidArrayId != null;
        }

        /// <summary>
        /// Am array of volume IDs. If you use this parameter, <c>DescribeVolumes</c> returns descriptions of the specified volumes. Otherwise, it
        /// returns a description of every volume.
        ///  
        /// </summary>
        public List<string> VolumeIds
        {
            get { return this.volumeIds; }
            set { this.volumeIds = value; }
        }

        // Check to see if VolumeIds property is set
        internal bool IsSetVolumeIds()
        {
            return this.volumeIds.Count > 0;
        }

    }
}
    
