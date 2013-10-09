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
    /// <para>Describes an instance's Amazon EBS volumes.</para> <para><b>NOTE:</b>You must specify at least one of the parameters.</para>
    /// </summary>
    /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeVolumes"/>
    public class DescribeVolumesRequest : AmazonWebServiceRequest
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

        /// <summary>
        /// Sets the InstanceId property
        /// </summary>
        /// <param name="instanceId">The value to set for the InstanceId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeVolumesRequest WithInstanceId(string instanceId)
        {
            this.instanceId = instanceId;
            return this;
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

        /// <summary>
        /// Sets the StackId property
        /// </summary>
        /// <param name="stackId">The value to set for the StackId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeVolumesRequest WithStackId(string stackId)
        {
            this.stackId = stackId;
            return this;
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

        /// <summary>
        /// Sets the RaidArrayId property
        /// </summary>
        /// <param name="raidArrayId">The value to set for the RaidArrayId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeVolumesRequest WithRaidArrayId(string raidArrayId)
        {
            this.raidArrayId = raidArrayId;
            return this;
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
        /// <summary>
        /// Adds elements to the VolumeIds collection
        /// </summary>
        /// <param name="volumeIds">The values to add to the VolumeIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeVolumesRequest WithVolumeIds(params string[] volumeIds)
        {
            foreach (string element in volumeIds)
            {
                this.volumeIds.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the VolumeIds collection
        /// </summary>
        /// <param name="volumeIds">The values to add to the VolumeIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeVolumesRequest WithVolumeIds(IEnumerable<string> volumeIds)
        {
            foreach (string element in volumeIds)
            {
                this.volumeIds.Add(element);
            }

            return this;
        }

        // Check to see if VolumeIds property is set
        internal bool IsSetVolumeIds()
        {
            return this.volumeIds.Count > 0;
        }
    }
}
    
