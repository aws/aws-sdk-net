/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */

using System.Text;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Amazon.S3.Model
{
    /// <summary>
    /// A collection of tags
    /// </summary>
    public class TagSet
    {
        private List<Tag> tags;

        /// <summary>
        /// The collection of tags.
        /// </summary>
        [XmlElementAttribute(ElementName = "TagSet")]
        public List<Tag> Tags
        {
            get
            {
                if (this.tags == null)
                {
                    this.tags = new List<Tag>();
                }
                return this.tags;
            }
            set
            {
                this.tags = value;
            }
        }

        /// <summary>
        /// Sets the collection of tags.
        /// </summary>
        /// <param name="args">Tags collection</param>
        /// <returns>this instance</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TagSet WithTags(params Tag[] args)
        {
            foreach (Tag arg in args)
            {
                Tags.Add(arg);
            }
            return this;
        }

        /// <summary>
        /// Checks if Tags property is set.
        /// </summary>
        /// <returns>true if Tags property is set.</returns>
        internal bool IsSetTags()
        {
            return (this.Tags.Count > 0);
        }

        internal string ToXML()
        {
            StringBuilder sb = new StringBuilder(1024);
            sb.Append("<TagSet>");
            foreach (Tag tag in Tags)
            {
                sb.Append(tag.ToXML());
            }
            sb.Append("</TagSet>");

            return sb.ToString();
        }
    }
}
