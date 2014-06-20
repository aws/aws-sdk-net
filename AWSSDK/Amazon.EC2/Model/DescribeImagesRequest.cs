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
    /// Returns information about AMIs, AKIs, and ARIs.
    /// This includes image type, product codes, architecture, and kernel
    /// and RAM disk IDs. Images available to you include public images,
    /// private images that you own, and private images owned by other
    /// users for which you have explicit launch permissions.
    /// </summary>
    /// <remarks>
    /// Launch permissions fall into three categories:
    ///
    /// 1. public:
    /// The owner of the AMI granted launch permissions for the AMI to the
    /// all group. All users have launch permissions for these AMIs.
    ///
    /// 2. explicit:
    /// The owner of the AMI granted launch permissions to a specific user.
    ///
    /// 3. implicit:
    /// A user has implicit launch permissions for all AMIs he or she
    /// owns.
    ///
    /// The list of AMIs returned can be modified by specifying AMI IDs,
    /// AMI owners, or users with launch permissions. If no options are
    /// specified, Amazon EC2 returns all AMIs for
    /// which the user has launch permissions.
    ///
    /// If you specify one or more AMI IDs, only AMIs that have the
    /// specified IDs are returned. If you specify an invalid AMI
    /// ID, a fault is returned. If you specify an AMI ID for which
    /// you do not have access, it will not be included in the returned
    /// results.
    ///
    /// If you specify one or more AMI owners, only AMIs from the
    /// specified owners and for which you have access are returned. The
    /// results can include the account IDs of the
    /// specified owners, amazon for AMIs owned by Amazon or self for AMIs that you
    /// own.
    ///
    /// If you specify a list of executable users, only users that have
    /// launch permissions for the AMIs are returned. You can specify account IDs
    /// (if you own the AMI(s)), self for AMIs for which you own or have
    /// explicit permissions, or all for public AMIs.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeImagesRequest : EC2Request
    {    
        private List<string> imageIdField;
        private List<string> ownerField;
        private List<string> executableByField;
        private List<Filter> filterField;

        /// <summary>
        /// AMI IDs to describe.
        /// </summary>
        [XmlElementAttribute(ElementName = "ImageId")]
        public List<string> ImageId
        {
            get
            {
                if (this.imageIdField == null)
                {
                    this.imageIdField = new List<string>();
                }
                return this.imageIdField;
            }
            set { this.imageIdField = value; }
        }

        /// <summary>
        /// Sets AMI IDs to describe.
        /// </summary>
        /// <param name="list">AMI IDs to describe.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeImagesRequest WithImageId(params string[] list)
        {
            foreach (string item in list)
            {
                ImageId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if ImageId property is set
        /// </summary>
        /// <returns>true if ImageId property is set</returns>
        public bool IsSetImageId()
        {
            return (ImageId.Count > 0);
        }

        /// <summary>
        /// Owner(s) for the AMIs to return.
        /// Multiple owners can be specified.
        /// </summary>
        [XmlElementAttribute(ElementName = "Owner")]
        public List<string> Owner
        {
            get
            {
                if (this.ownerField == null)
                {
                    this.ownerField = new List<string>();
                }
                return this.ownerField;
            }
            set { this.ownerField = value; }
        }

        /// <summary>
        /// Sets owner(s) for the AMIs to return.
        /// </summary>
        /// <param name="list">Returns AMIs owned by the specified owner.
        /// Multiple owners can be specified.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeImagesRequest WithOwner(params string[] list)
        {
            foreach (string item in list)
            {
                Owner.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Owner property is set
        /// </summary>
        /// <returns>true if Owner property is set</returns>
        public bool IsSetOwner()
        {
            return (Owner.Count > 0);
        }

        /// <summary>
        /// List of executor user IDs.
        /// AMIs will be returned
        /// for which the specified user(s) have
        /// explicit launch permissions.
        /// </summary>
        [XmlElementAttribute(ElementName = "ExecutableBy")]
        public List<string> ExecutableBy
        {
            get
            {
                if (this.executableByField == null)
                {
                    this.executableByField = new List<string>();
                }
                return this.executableByField;
            }
            set { this.executableByField = value; }
        }

        /// <summary>
        /// Sets executor user IDs.
        /// </summary>
        /// <param name="list">Returns AMIs for which the specified user has
        /// explicit launch permissions.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeImagesRequest WithExecutableBy(params string[] list)
        {
            foreach (string item in list)
            {
                ExecutableBy.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if ExecutableBy property is set
        /// </summary>
        /// <returns>true if ExecutableBy property is set</returns>
        public bool IsSetExecutableBy()
        {
            return (ExecutableBy.Count > 0);
        }

        /// <summary>
        /// One or more filters. <ul> <li> <c>architecture</c> - The image architecture (<c>i386</c> | <c>x86_64</c>). </li> <li>
        /// <c>block-device-mapping.delete-on-termination</c> - A Boolean value that indicates whether the Amazon EBS volume is deleted on instance
        /// termination. </li> <li> <c>block-device-mapping.device-name</c> - The device name for the Amazon EBS volume (for example, <c>/dev/sdh</c>).
        /// </li> <li> <c>block-device-mapping.snapshot-id</c> - The ID of the snapshot used for the Amazon EBS volume. </li> <li>
        /// <c>block-device-mapping.volume-size</c> - The volume size of the Amazon EBS volume, in GiB. </li> <li>
        /// <c>block-device-mapping.volume-type</c> - The volume type of the Amazon EBS volume (<c>gp2</c> | <c>standard</c> | <c>io1</c>). </li> <li>
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
        [XmlElementAttribute(ElementName = "Filter")]
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
        /// with the specified Images.
        /// </summary>
        /// <param name="list">A list of filters used to match system-defined properties and user-defined tags associated 
        /// with the specified Images.
        /// For a complete reference to the available filter keys for this operation, see the
        /// Amazon EC2 API reference.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeImagesRequest WithFilter(params Filter[] list)
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
