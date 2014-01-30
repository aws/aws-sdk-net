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
    /// Container for the parameters to the DescribeImages operation.
    /// <para>Describes one or more of the images (AMIs, AKIs, and ARIs) available to you. Images available to you include public images, private
    /// images that you own, and private images owned by other AWS accounts but for which you have explicit launch permissions.</para>
    /// <para><b>NOTE:</b> Deregistered images are included in the returned results for an unspecified interval after deregistration. </para>
    /// </summary>
    public partial class DescribeImagesRequest : AmazonEC2Request
    {
        private List<string> imageIds = new List<string>();
        private List<string> owners = new List<string>();
        private List<string> executableUsers = new List<string>();
        private List<Filter> filters = new List<Filter>();


        /// <summary>
        /// One or more image IDs. Default: Describes all images available to you.
        ///  
        /// </summary>
        public List<string> ImageIds
        {
            get { return this.imageIds; }
            set { this.imageIds = value; }
        }

        // Check to see if ImageIds property is set
        internal bool IsSetImageIds()
        {
            return this.imageIds.Count > 0;
        }

        /// <summary>
        /// Filters the images by the owner. Specify an AWS account ID, <c>amazon</c> (owner is Amazon), <c>aws-marketplace</c> (owner is AWS
        /// Marketplace), <c>self</c> (owner is the sender of the request), or <c>all</c> (all owners).
        ///  
        /// </summary>
        public List<string> Owners
        {
            get { return this.owners; }
            set { this.owners = value; }
        }

        // Check to see if Owners property is set
        internal bool IsSetOwners()
        {
            return this.owners.Count > 0;
        }

        /// <summary>
        /// Scopes the images by users with explicit launch permissions. Specify an AWS account ID, <c>self</c> (the sender of the request), or
        /// <c>all</c> (public AMIs).
        ///  
        /// </summary>
        public List<string> ExecutableUsers
        {
            get { return this.executableUsers; }
            set { this.executableUsers = value; }
        }

        // Check to see if ExecutableUsers property is set
        internal bool IsSetExecutableUsers()
        {
            return this.executableUsers.Count > 0;
        }

        /// <summary>
        /// One or more filters. <ul> <li> <c>architecture</c> - The image architecture (<c>i386</c> | <c>x86_64</c>). </li> <li>
        /// <c>block-device-mapping.delete-on-termination</c> - A Boolean value that indicates whether the Amazon EBS volume is deleted on instance
        /// termination. </li> <li> <c>block-device-mapping.device-name</c> - The device name for the Amazon EBS volume (for example, <c>/dev/sdh</c>).
        /// </li> <li> <c>block-device-mapping.snapshot-id</c> - The ID of the snapshot used for the Amazon EBS volume. </li> <li>
        /// <c>block-device-mapping.volume-size</c> - The volume size of the Amazon EBS volume, in GiB. </li> <li>
        /// <c>block-device-mapping.volume-type</c> - The volume type of the Amazon EBS volume (<c>standard</c> | <c>io1</c>). </li> <li>
        /// <c>description</c> - The description of the image (provided during image creation). </li> <li> <c>hypervisor</c> - The hypervisor type
        /// (<c>ovm</c> | <c>xen</c>). </li> <li> <c>image-id</c> - The ID of the image. </li> <li> <c>image-type</c> - The image type (<c>machine</c> |
        /// <c>kernel</c> | <c>ramdisk</c>). </li> <li> <c>is-public</c> - A Boolean that indicates whether the image is public. </li> <li>
        /// <c>kernel-id</c> - The kernel ID. </li> <li> <c>manifest-location</c> - The location of the image manifest. </li> <li> <c>name</c> - The
        /// name of the AMI (provided during image creation). </li> <li> <c>owner-alias</c> - The AWS account alias (for example, <c>amazon</c>). </li>
        /// <li> <c>owner-id</c> - The AWS account ID of the image owner. </li> <li> <c>platform</c> - The platform. To only list Windows-based AMIs,
        /// use <c>windows</c>. </li> <li> <c>product-code</c> - The product code. </li> <li> <c>product-code.type</c> - The type of the product code
        /// (<c>devpay</c> | <c>marketplace</c>). </li> <li> <c>ramdisk-id</c> - The RAM disk ID. </li> <li> <c>root-device-name</c> - The name of the
        /// root device volume (for example, <c>/dev/sda1</c>). </li> <li> <c>root-device-type</c> - The type of the root device volume (<c>ebs</c> |
        /// <c>instance-store</c>). </li> <li> <c>state</c> - The state of the image (<c>available</c> | <c>pending</c> | <c>failed</c>). </li> <li>
        /// <c>state-reason-code</c> - The reason code for the state change. </li> <li> <c>state-reason-message</c> - The message for the state change.
        /// </li> <li> <c>tag</c>:<i>key</i>=<i>value</i> - The key/value combination of a tag assigned to the resource. </li> <li> <c>tag-key</c> - The
        /// key of a tag assigned to the resource. This filter is independent of the tag-value filter. For example, if you use both the filter
        /// "tag-key=Purpose" and the filter "tag-value=X", you get any resources assigned both the tag key Purpose (regardless of what the tag's value
        /// is), and the tag value X (regardless of what the tag's key is). If you want to list only resources where Purpose is X, see the
        /// <c>tag</c>:<i>key</i>=<i>value</i> filter. </li> <li> <c>tag-value</c> - The value of a tag assigned to the resource. This filter is
        /// independent of the <c>tag-key</c> filter. </li> <li> <c>virtualization-type</c> - The virtualization type (<c>paravirtual</c> | <c>hvm</c>).
        /// </li> </ul>
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
    
