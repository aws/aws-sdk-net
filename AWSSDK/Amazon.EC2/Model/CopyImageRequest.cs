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
    /// Copies a image from a source region to the current region.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class CopyImageRequest : EC2Request
    {
        private string sourceRegionField;
        private string sourceImageIdField;
        private string nameField;
        private string descriptionField;
        private string clientTokenField;

        /// <summary>
        /// Source region to copy the image from.
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceRegion")]
        public string SourceRegion
        {
            get { return this.sourceRegionField; }
            set { this.sourceRegionField = value; }
        }

        /// <summary>
        /// Sets the source region to copy the image from.
        /// </summary>
        /// <param name="sourceRegion">Source region.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyImageRequest WithSourceRegion(string sourceRegion)
        {
            this.sourceRegionField = sourceRegion;
            return this;
        }

        /// <summary>
        /// Checks if SourceRegion property is set
        /// </summary>
        /// <returns>true if SourceRegion property is set</returns>
        public bool IsSetSourceRegion()
        {
            return this.sourceRegionField != null;
        }


        /// <summary>
        /// Id of the source image to copy.
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceRegion")]
        public string SourceImageId
        {
            get { return this.sourceImageIdField; }
            set { this.sourceImageIdField = value; }
        }

        /// <summary>
        /// Sets the id of the source image to copy.
        /// </summary>
        /// <param name="sourceImageId">Image id.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyImageRequest WithSourceImageId(string sourceImageId)
        {
            this.sourceImageIdField = sourceImageId;
            return this;
        }

        /// <summary>
        /// Checks if SourceImageId property is set
        /// </summary>
        /// <returns>true if SourceImageId property is set</returns>
        public bool IsSetSourceImageId()
        {
            return this.sourceImageIdField != null;
        }


        /// <summary>
        /// Description of the image copy.
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceRegion")]
        public string Description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <summary>
        /// Sets the description of the image copy.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyImageRequest WithDescription(string description)
        {
            this.descriptionField = description;
            return this;
        }

        /// <summary>
        /// Checks if Description property is set
        /// </summary>
        /// <returns>true if Description property is set</returns>
        public bool IsSetDescription()
        {
            return this.descriptionField != null;
        }

        /// <summary>
        /// Name of the image copy.
        /// </summary>
        [XmlElementAttribute(ElementName = "Name")]
        public string Name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <summary>
        /// Sets the name of the image copy.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyImageRequest WithName(string name)
        {
            this.nameField = name;
            return this;
        }

        /// <summary>
        /// Checks if Name property is set
        /// </summary>
        /// <returns>true if Name property is set</returns>
        public bool IsSetName()
        {
            return this.nameField != null;
        }

        /// <summary>
        /// A unique, case-sensitive identifier you provide to ensure
        /// idempotency of the copy.
        /// </summary>
        [XmlElementAttribute(ElementName = "ClientToken")]
        public string ClientToken
        {
            get { return this.clientTokenField; }
            set { this.clientTokenField = value; }
        }

        /// <summary>
        /// Sets the ClientToken property.
        /// </summary>
        /// <param name="clientToken">ClientToken.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopyImageRequest WithClientToken(string clientToken)
        {
            this.clientTokenField = clientToken;
            return this;
        }

        /// <summary>
        /// Checks if ClientToken property is set
        /// </summary>
        /// <returns>true if ClientToken property is set</returns>
        public bool IsSetClientToken()
        {
            return this.clientTokenField != null;
        }
    }
}
