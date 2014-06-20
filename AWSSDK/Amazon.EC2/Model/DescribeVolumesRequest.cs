/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the specified Amazon EBS volumes that you own.
    /// </summary>
    /// <remarks>
    /// If you do not specify one or more volume IDs, Amazon EBS
    /// describes all volumes that you own.
    /// For more information about Amazon EBS, go to the Amazon
    /// Elastic Compute Cloud Developer Guide.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeVolumesRequest : EC2Request
    {    
        private List<string> volumeIdField;
        private List<Filter> filterField;

        /// <summary>
        /// One or more volume IDs.
        /// </summary>
        [XmlElementAttribute(ElementName = "VolumeId")]
        public List<string> VolumeId
        {
            get
            {
                if (this.volumeIdField == null)
                {
                    this.volumeIdField = new List<string>();
                }
                return this.volumeIdField;
            }
            set { this.volumeIdField = value; }
        }

        /// <summary>
        /// Sets volume IDs.
        /// </summary>
        /// <param name="list">The ID of the volume to list.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeVolumesRequest WithVolumeId(params string[] list)
        {
            foreach (string item in list)
            {
                VolumeId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if VolumeId property is set
        /// </summary>
        /// <returns>true if VolumeId property is set</returns>
        public bool IsSetVolumeId()
        {
            return (VolumeId.Count > 0);
        }

        /// <summary>
        /// One or more filters. <ul> <li> <c>attachment.attach-time</c> - The time stamp when the attachment initiated. </li> <li>
        /// <c>attachment.delete-on-termination</c> - Whether the volume is deleted on instance termination. </li> <li> <c>attachment.device</c> - The
        /// device name that is exposed to the instance (for example, <c>/dev/sda1</c>). </li> <li> <c>attachment.instance-id</c> - The ID of the
        /// instance the volume is attached to. </li> <li> <c>attachment.status</c> - The attachment state (<c>attaching</c> | <c>attached</c> |
        /// <c>detaching</c> | <c>detached</c>). </li> <li> <c>availability-zone</c> - The Availability Zone in which the volume was created. </li> <li>
        /// <c>create-time</c> - The time stamp when the volume was created. </li> <li> <c>encrypted</c> - The encryption status of the volume. </li>
        /// <li> <c>size</c> - The size of the volume, in GiB. </li> <li> <c>snapshot-id</c> - The snapshot from which the volume was created. </li>
        /// <li> <c>status</c> - The status of the volume (<c>creating</c> | <c>available</c> | <c>in-use</c> | <c>deleting</c> | <c>deleted</c> |
        /// <c>error</c>). </li> <li> <c>tag</c>:<i>key</i>=<i>value</i> - The key/value combination of a tag assigned to the resource. </li> <li>
        /// <c>tag-key</c> - The key of a tag assigned to the resource. This filter is independent of the <c>tag-value</c> filter. For example, if you
        /// use both the filter "tag-key=Purpose" and the filter "tag-value=X", you get any resources assigned both the tag key Purpose (regardless of
        /// what the tag's value is), and the tag value X (regardless of what the tag's key is). If you want to list only resources where Purpose is X,
        /// see the <c>tag</c>:<i>key</i>=<i>value</i> filter. </li> <li> <c>tag-value</c> - The value of a tag assigned to the resource. This filter is
        /// independent of the <c>tag-key</c> filter. </li> <li> <c>volume-id</c> - The volume ID. </li> <li> <c>volume-type</c> - The Amazon EBS volume
        /// type. This can be <c>gp2</c> for General Purpose (SSD) volumes, <c>io1</c> for Provisioned IOPS (SSD) volumes, or <c>standard</c> for
        /// Magnetic volumes. </li> </ul>
        ///  
        /// </summary>        [XmlElementAttribute(ElementName = "Filter")]
        public List<Filter> Filter
        {
            get
            {
                if (this.filterField == null)
                {
                    this.filterField = new List<Filter>();
                }
                return this.filterField;
            }
            set { this.filterField = value; }
        }

        /// <summary>
        /// Sets filters used to match system-defined properties and user-defined tags associated 
        /// with the specified Volumes.
        /// </summary>
        /// <param name="list">A list of filters used to match system-defined properties and user-defined tags associated 
        /// with the specified Volumes.
        /// For a complete reference to the available filter keys for this operation, see the
        /// Amazon EC2 API reference.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeVolumesRequest WithFilter(params Filter[] list)
        {
            foreach (Filter item in list)
            {
                Filter.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Filter property is set
        /// </summary>
        /// <returns>true if Filter property is set</returns>
        public bool IsSetFilter()
        {
            return (Filter.Count > 0);
        }

    }
}
