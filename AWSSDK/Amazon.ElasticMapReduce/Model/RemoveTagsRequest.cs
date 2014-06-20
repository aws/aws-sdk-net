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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the RemoveTags operation.
    /// Removes tags from an Amazon EMR resource. Tags make it easier to associate clusters
    /// in various ways, such as grouping clusters to track your Amazon EMR resource allocation
    /// costs.             For more information, see <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/emr-plan-tags.html">Tagging
    /// Amazon EMR Resources</a>.                                  
    /// 
    ///       
    /// <para>
    /// The following example removes the stack tag with value Prod from a cluster:
    /// </para>
    /// </summary>
    public partial class RemoveTagsRequest : AmazonWebServiceRequest
    {
        private string _resourceId;
        private List<string> _tagKeys = new List<string>();


        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The Amazon EMR resource identifier from which tags will be removed. This value must
        /// be a cluster identifier.
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }


        /// <summary>
        /// Sets the ResourceId property
        /// </summary>
        /// <param name="resourceId">The value to set for the ResourceId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RemoveTagsRequest WithResourceId(string resourceId)
        {
            this._resourceId = resourceId;
            return this;
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }


        /// <summary>
        /// Gets and sets the property TagKeys. 
        /// <para>
        /// A list of tag keys to remove from a resource.
        /// </para>
        /// </summary>
        public List<string> TagKeys
        {
            get { return this._tagKeys; }
            set { this._tagKeys = value; }
        }

        /// <summary>
        /// Sets the TagKeys property
        /// </summary>
        /// <param name="tagKeys">The values to add to the TagKeys collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RemoveTagsRequest WithTagKeys(params string[] tagKeys)
        {
            foreach (var element in tagKeys)
            {
                this._tagKeys.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the TagKeys property
        /// </summary>
        /// <param name="tagKeys">The values to add to the TagKeys collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RemoveTagsRequest WithTagKeys(IEnumerable<string> tagKeys)
        {
            foreach (var element in tagKeys)
            {
                this._tagKeys.Add(element);
            }
            return this;
        }
        // Check to see if TagKeys property is set
        internal bool IsSetTagKeys()
        {
            return this._tagKeys != null && this._tagKeys.Count > 0; 
        }

    }
}