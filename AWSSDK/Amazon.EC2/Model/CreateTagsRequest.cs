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
    /// Adds or overwrites tags for the specified resources. 
    /// Each resource can have a maximum of 10 tags. 
    /// Each tag consists of a key-value pair.
    /// Tag keys must be unique per resource.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class CreateTagsRequest : EC2Request
    {    
        private List<string> resourceIdField;
        private List<Tag> tagField;

        /// <summary>
        /// One or more IDs of resources to tag.
        /// </summary>
        [XmlElementAttribute(ElementName = "ResourceId")]
        public List<string> ResourceId
        {
            get
            {
                if (this.resourceIdField == null)
                {
                    this.resourceIdField = new List<string>();
                }
                return this.resourceIdField;
            }
            set { this.resourceIdField = value; }
        }

        /// <summary>
        /// Sets the IDs of resources to tag.
        /// </summary>
        /// <param name="list">One or more IDs of resources to tag.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateTagsRequest WithResourceId(params string[] list)
        {
            foreach (string item in list)
            {
                ResourceId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if ResourceId property is set
        /// </summary>
        /// <returns>true if ResourceId property is set</returns>
        public bool IsSetResourceId()
        {
            return (ResourceId.Count > 0);
        }

        /// <summary>
        /// The tags to add or overwrite for the specified resources. 
        /// Each tag item consists of a key-value pair.
        /// </summary>
        [XmlElementAttribute(ElementName = "Tag")]
        public List<Tag> Tag
        {
            get
            {
                if (this.tagField == null)
                {
                    this.tagField = new List<Tag>();
                }
                return this.tagField;
            }
            set { this.tagField = value; }
        }

        /// <summary>
        /// Sets the tags to add or overwrite for the specified resources. 
        /// </summary>
        /// <param name="list">The tags to add or overwrite for the specified resources. 
        /// Each tag item consists of a 
        /// key-value pair.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateTagsRequest WithTag(params Tag[] list)
        {
            foreach (Tag item in list)
            {
                Tag.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Tag property is set
        /// </summary>
        /// <returns>true if Tag property is set</returns>
        public bool IsSetTag()
        {
            return (Tag.Count > 0);
        }

    }
}
