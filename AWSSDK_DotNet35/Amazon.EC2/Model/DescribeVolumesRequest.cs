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
    /// Container for the parameters to the DescribeVolumes operation.
    /// <para>Describes the specified Amazon EBS volumes.</para> <para>For more information about Amazon EBS volumes, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html" >Amazon EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud
    /// User Guide</i> .</para>
    /// </summary>
    public partial class DescribeVolumesRequest : AmazonEC2Request
    {
        private List<string> volumeIds = new List<string>();
        private List<Filter> filters = new List<Filter>();


        /// <summary>
        /// One or more volume IDs.
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

        /// <summary>
        /// One or more filters. <ul> <li> <c>attachment.attach-time</c> - The time stamp when the attachment initiated. </li> <li>
        /// <c>attachment.delete-on-termination</c> - Whether the volume is deleted on instance termination. </li> <li> <c>attachment.device</c> - The
        /// device name that is exposed to the instance (for example, <c>/dev/sda1</c>). </li> <li> <c>attachment.instance-id</c> - The ID of the
        /// instance the volume is attached to. </li> <li> <c>attachment.status</c> - The attachment state (<c>attaching</c> | <c>attached</c> |
        /// <c>detaching</c> | <c>detached</c>). </li> <li> <c>availability-zone</c> - The Availability Zone in which the volume was created. </li> <li>
        /// <c>create-time</c> - The time stamp when the volume was created. </li> <li> <c>size</c> - The size of the volume, in GiB. </li> <li>
        /// <c>snapshot-id</c> - The snapshot from which the volume was created. </li> <li> <c>status</c> - The status of the volume (<c>creating</c> |
        /// <c>available</c> | <c>in-use</c> | <c>deleting</c> | <c>deleted</c> | <c>error</c>). </li> <li> <c>tag</c>:<i>key</i>=<i>value</i> - The
        /// key/value combination of a tag assigned to the resource. </li> <li> <c>tag-key</c> - The key of a tag assigned to the resource. This filter
        /// is independent of the <c>tag-value</c> filter. For example, if you use both the filter "tag-key=Purpose" and the filter "tag-value=X", you
        /// get any resources assigned both the tag key Purpose (regardless of what the tag's value is), and the tag value X (regardless of what the
        /// tag's key is). If you want to list only resources where Purpose is X, see the <c>tag</c>:<i>key</i>=<i>value</i> filter. </li> <li>
        /// <c>tag-value</c> - The value of a tag assigned to the resource. This filter is independent of the <c>tag-key</c> filter. </li> <li>
        /// <c>volume-id</c> - The volume ID. </li> <li> <c>volume-type</c> - The Amazon EBS volume type (<c>standard</c> | <c>io1</c>). </li> </ul>
        ///  
        /// </summary>
        public List<Filter> Filters
        {
            get { return this.filters; }
            set { this.filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this.filters.Count > 0;
        }

    }
}
    
