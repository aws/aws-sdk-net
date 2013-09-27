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
        /// A list of filters used to match system-defined properties and user-defined tags associated 
        /// with the specified Images.
        /// For a complete reference to the available filter keys for this operation, see the
        /// Amazon EC2 API reference.
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
