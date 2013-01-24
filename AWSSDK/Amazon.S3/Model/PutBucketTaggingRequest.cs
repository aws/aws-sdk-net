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

using System;
using System.Security;
using System.Text;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The parameters to apply one or more tag sets to a bucket.
    /// </summary>
    public class PutBucketTaggingRequest : S3Request
    {
        private List<TagSet> tagSets;
        private string bucketName;

        /// <summary>
        /// The name of the bucket to apply the tag sets to.
        /// </summary>
        [XmlElementAttribute(ElementName = "BucketName")]
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Sets the name of the bucket to apply the tag sets to.
        /// </summary>
        /// <param name="bucketName">The bucket name</param>
        /// <returns>the request with the BucketName set</returns>
        public PutBucketTaggingRequest WithBucketName(string bucketName)
        {
            this.bucketName = bucketName;
            return this;
        }

        /// <summary>
        /// Checks if BucketName property is set.
        /// </summary>
        /// <returns>true if BucketName property is set.</returns>
        internal bool IsSetBucketName()
        {
            return !System.String.IsNullOrEmpty(this.bucketName);
        }


        /// <summary>
        /// The tag sets to apply to the bucket.
        /// </summary>
        [XmlElementAttribute(ElementName = "TagSets")]
        public List<TagSet> TagSets
        {
            get
            {
                if (this.tagSets == null)
                {
                    this.tagSets = new List<TagSet>();
                }
                return this.tagSets;
            }
            set
            {
                this.tagSets = value;
            }
        }

        /// <summary>
        /// Sets the tag sets to apply to the bucket.
        /// </summary>
        /// <param name="args">TagSets property</param>
        /// <returns>this instance</returns>
        public PutBucketTaggingRequest WithTagSets(params TagSet[] args)
        {
            foreach (TagSet arg in args)
            {
                TagSets.Add(arg);
            }
            return this;
        }

        /// <summary>
        /// Checks if TagSets property is set.
        /// </summary>
        /// <returns>true if TagSets property is set.</returns>
        internal bool IsSetTagSets()
        {
            return (this.TagSets.Count > 0);
        }

        internal string ContentXML
        {
            get
            {
                if (tagSets == null)
                    throw new InvalidOperationException("TagSets cannot be null");

                using (StringWriter sw = new StringWriter())
                {
                    using (XmlTextWriter writer = new XmlTextWriter(sw))
                    {
                        writer.WriteStartElement("Tagging");
                        foreach (var tagSet in TagSets)
                        {
                            writer.WriteRaw(tagSet.ToXML());
                        }
                        writer.WriteEndElement();
                    }
                    string xml = sw.ToString();
                    return xml;
                }
            }
        }
    }
}
