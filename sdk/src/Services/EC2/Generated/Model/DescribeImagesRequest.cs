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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
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
    /// Describes one or more of the images (AMIs, AKIs, and ARIs) available to you. Images
    /// available to you include public images, private images that you own, and private images
    /// owned by other AWS accounts but for which you have explicit launch permissions.
    /// 
    ///  <note>
    /// <para>
    /// Deregistered images are included in the returned results for an unspecified interval
    /// after deregistration.
    /// </para>
    /// </note>
    /// </summary>
    public partial class DescribeImagesRequest : AmazonEC2Request
    {
        private List<string> _executableUsers = new List<string>();
        private List<Filter> _filters = new List<Filter>();
        private List<string> _imageIds = new List<string>();
        private List<string> _owners = new List<string>();

        /// <summary>
        /// Gets and sets the property ExecutableUsers. 
        /// <para>
        /// Scopes the images by users with explicit launch permissions. Specify an AWS account
        /// ID, <code>self</code> (the sender of the request), or <code>all</code> (public AMIs).
        /// </para>
        /// </summary>
        public List<string> ExecutableUsers
        {
            get { return this._executableUsers; }
            set { this._executableUsers = value; }
        }

        // Check to see if ExecutableUsers property is set
        internal bool IsSetExecutableUsers()
        {
            return this._executableUsers != null && this._executableUsers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <code>architecture</code> - The image architecture (<code>i386</code> | <code>x86_64</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>block-device-mapping.delete-on-termination</code> - A Boolean value that indicates
        /// whether the Amazon EBS volume is deleted on instance termination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>block-device-mapping.device-name</code> - The device name for the Amazon EBS
        /// volume (for example, <code>/dev/sdh</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>block-device-mapping.snapshot-id</code> - The ID of the snapshot used for the
        /// Amazon EBS volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>block-device-mapping.volume-size</code> - The volume size of the Amazon EBS
        /// volume, in GiB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>block-device-mapping.volume-type</code> - The volume type of the Amazon EBS
        /// volume (<code>gp2</code> | <code>standard</code> | <code>io1</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>description</code> - The description of the image (provided during image creation).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>hypervisor</code> - The hypervisor type (<code>ovm</code> | <code>xen</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>image-id</code> - The ID of the image.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>image-type</code> - The image type (<code>machine</code> | <code>kernel</code>
        /// | <code>ramdisk</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>is-public</code> - A Boolean that indicates whether the image is public.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>kernel-id</code> - The kernel ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>manifest-location</code> - The location of the image manifest.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>name</code> - The name of the AMI (provided during image creation).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>owner-alias</code> - The AWS account alias (for example, <code>amazon</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>owner-id</code> - The AWS account ID of the image owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>platform</code> - The platform. To only list Windows-based AMIs, use <code>windows</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>product-code</code> - The product code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>product-code.type</code> - The type of the product code (<code>devpay</code>
        /// | <code>marketplace</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>ramdisk-id</code> - The RAM disk ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>root-device-name</code> - The name of the root device volume (for example, <code>/dev/sda1</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>root-device-type</code> - The type of the root device volume (<code>ebs</code>
        /// | <code>instance-store</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>state</code> - The state of the image (<code>available</code> | <code>pending</code>
        /// | <code>failed</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>state-reason-code</code> - The reason code for the state change.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>state-reason-message</code> - The message for the state change.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>tag</code>:<i>key</i>=<i>value</i> - The key/value combination of a tag assigned
        /// to the resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>tag-key</code> - The key of a tag assigned to the resource. This filter is independent
        /// of the tag-value filter. For example, if you use both the filter "tag-key=Purpose"
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
        /// <code>virtualization-type</code> - The virtualization type (<code>paravirtual</code>
        /// | <code>hvm</code>).
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
        /// Gets and sets the property ImageIds. 
        /// <para>
        /// One or more image IDs.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all images available to you.
        /// </para>
        /// </summary>
        public List<string> ImageIds
        {
            get { return this._imageIds; }
            set { this._imageIds = value; }
        }

        // Check to see if ImageIds property is set
        internal bool IsSetImageIds()
        {
            return this._imageIds != null && this._imageIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Owners. 
        /// <para>
        /// Filters the images by the owner. Specify an AWS account ID, <code>amazon</code> (owner
        /// is Amazon), <code>aws-marketplace</code> (owner is AWS Marketplace), <code>self</code>
        /// (owner is the sender of the request). Omitting this option returns all images for
        /// which you have launch permissions, regardless of ownership.
        /// </para>
        /// </summary>
        public List<string> Owners
        {
            get { return this._owners; }
            set { this._owners = value; }
        }

        // Check to see if Owners property is set
        internal bool IsSetOwners()
        {
            return this._owners != null && this._owners.Count > 0; 
        }

    }
}