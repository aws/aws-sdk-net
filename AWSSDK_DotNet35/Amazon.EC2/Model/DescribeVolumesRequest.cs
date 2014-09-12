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
 * Do not modify this file. This file is generated from the ec2-2014-06-15.normal.json service model.
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
    /// Describes the specified Amazon EBS volumes.
    /// 
    ///  
    /// <para>
    /// For more information about Amazon EBS volumes, see <a href='http://docs.&awsdomain;/AWSEC2/latest/UserGuide/EBSVolumes.html'>Amazon
    /// EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeVolumesRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private List<string> _volumeIds = new List<string>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeVolumesRequest() { }

        /// <summary>
        /// Instantiates DescribeVolumesRequest with the parameterized properties
        /// </summary>
        /// <param name="volumeIds">One or more volume IDs.</param>
        public DescribeVolumesRequest(List<string> volumeIds)
        {
            _volumeIds = volumeIds;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <code>attachment.attach-time</code> - The time stamp when the attachment initiated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>attachment.delete-on-termination</code> - Whether the volume is deleted on instance
        /// termination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>attachment.device</code> - The device name that is exposed to the instance (for
        /// example, <code>/dev/sda1</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>attachment.instance-id</code> - The ID of the instance the volume is attached
        /// to.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>attachment.status</code> - The attachment state (<code>attaching</code> | <code>attached</code>
        /// | <code>detaching</code> | <code>detached</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>availability-zone</code> - The Availability Zone in which the volume was created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>create-time</code> - The time stamp when the volume was created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>encrypted</code> - The encryption status of the volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>size</code> - The size of the volume, in GiB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>snapshot-id</code> - The snapshot from which the volume was created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>status</code> - The status of the volume (<code>creating</code> | <code>available</code>
        /// | <code>in-use</code> | <code>deleting</code> | <code>deleted</code> | <code>error</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>tag</code>:<i>key</i>=<i>value</i> - The key/value combination of a tag assigned
        /// to the resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>tag-key</code> - The key of a tag assigned to the resource. This filter is independent
        /// of the <code>tag-value</code> filter. For example, if you use both the filter "tag-key=Purpose"
        /// and the filter "tag-value=X", you get any resources assigned both the tag key Purpose
        /// (regardless of what the tag's value is), and the tag value X (regardless of what the
        /// tag's key is). If you want to list only resources where Purpose is X, see the <code>tag</code>:<i>key</i>=<i>value</i>
        /// filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>tag-value</code> - The value of a tag assigned to the resource. This filter
        /// is independent of the <code>tag-key</code> filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>volume-id</code> - The volume ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>volume-type</code> - The Amazon EBS volume type. This can be <code>gp2</code>
        /// for General Purpose (SSD) volumes, <code>io1</code> for Provisioned IOPS (SSD) volumes,
        /// or <code>standard</code> for Magnetic volumes.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VolumeIds. 
        /// <para>
        /// One or more volume IDs.
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