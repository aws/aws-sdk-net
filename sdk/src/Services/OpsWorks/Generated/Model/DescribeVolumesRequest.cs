/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
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
    /// Describes an instance's Amazon EBS volumes.
    /// 
    ///  <note> 
    /// <para>
    /// This call accepts only one resource-identifying parameter.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
    /// or Manage permissions level for the stack, or an attached policy that explicitly grants
    /// permissions. For more information about user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
    /// User Permissions</a>.
    /// </para>
    /// </summary>
    public partial class DescribeVolumesRequest : AmazonOpsWorksRequest
    {
        private string _instanceId;
        private string _raidArrayId;
        private string _stackId;
        private List<string> _volumeIds = new List<string>();

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The instance ID. If you use this parameter, <code>DescribeVolumes</code> returns descriptions
        /// of the volumes associated with the specified instance.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property RaidArrayId. 
        /// <para>
        /// The RAID array ID. If you use this parameter, <code>DescribeVolumes</code> returns
        /// descriptions of the volumes associated with the specified RAID array.
        /// </para>
        /// </summary>
        public string RaidArrayId
        {
            get { return this._raidArrayId; }
            set { this._raidArrayId = value; }
        }

        // Check to see if RaidArrayId property is set
        internal bool IsSetRaidArrayId()
        {
            return this._raidArrayId != null;
        }

        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// A stack ID. The action describes the stack's registered Amazon EBS volumes.
        /// </para>
        /// </summary>
        public string StackId
        {
            get { return this._stackId; }
            set { this._stackId = value; }
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeIds. 
        /// <para>
        /// Am array of volume IDs. If you use this parameter, <code>DescribeVolumes</code> returns
        /// descriptions of the specified volumes. Otherwise, it returns a description of every
        /// volume.
        /// </para>
        /// </summary>
        public List<string> VolumeIds
        {
            get { return this._volumeIds; }
            set { this._volumeIds = value; }
        }

        // Check to see if VolumeIds property is set
        internal bool IsSetVolumeIds()
        {
            return this._volumeIds != null && this._volumeIds.Count > 0; 
        }

    }
}