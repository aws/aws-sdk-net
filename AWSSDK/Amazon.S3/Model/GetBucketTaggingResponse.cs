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
    /// The DeleteBucketTaggingResponse contains the TagSets and any headers returned by S3.
    /// </summary>
    [XmlTypeAttribute(Namespace = "http://s3.amazonaws.com/doc/2006-03-01/")]
    [XmlRootAttribute(Namespace = "http://s3.amazonaws.com/doc/2006-03-01/", IsNullable = false)]
    public class GetBucketTaggingResponse : S3Response
    {
        private List<TagSet> tagSets;

        /// <summary>
        /// Gets and sets the TagSets property.
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
        /// Sets the TagSets property.
        /// </summary>
        /// <param name="args">TagSets property</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetBucketTaggingResponse WithTagSets(params TagSet[] args)
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
    }
}
