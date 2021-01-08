/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the RemoveTags operation.
    /// Removes tags from an Amazon EMR resource. Tags make it easier to associate clusters
    /// in various ways, such as grouping clusters to track your Amazon EMR resource allocation
    /// costs. For more information, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-plan-tags.html">Tag
    /// Clusters</a>. 
    /// 
    ///  
    /// <para>
    /// The following example removes the stack tag with value Prod from a cluster:
    /// </para>
    /// </summary>
    public partial class RemoveTagsRequest : AmazonElasticMapReduceRequest
    {
        private string _resourceId;
        private List<string> _tagKeys = new List<string>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public RemoveTagsRequest() { }

        /// <summary>
        /// Instantiates RemoveTagsRequest with the parameterized properties
        /// </summary>
        /// <param name="resourceId">The Amazon EMR resource identifier from which tags will be removed. This value must be a cluster identifier.</param>
        public RemoveTagsRequest(string resourceId)
        {
            _resourceId = resourceId;
        }

        /// <summary>
        /// Instantiates RemoveTagsRequest with the parameterized properties
        /// </summary>
        /// <param name="resourceId">The Amazon EMR resource identifier from which tags will be removed. This value must be a cluster identifier.</param>
        /// <param name="tagKeys">A list of tag keys to remove from a resource.</param>
        public RemoveTagsRequest(string resourceId, List<string> tagKeys)
        {
            _resourceId = resourceId;
            _tagKeys = tagKeys;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The Amazon EMR resource identifier from which tags will be removed. This value must
        /// be a cluster identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
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
        [AWSProperty(Required=true)]
        public List<string> TagKeys
        {
            get { return this._tagKeys; }
            set { this._tagKeys = value; }
        }

        // Check to see if TagKeys property is set
        internal bool IsSetTagKeys()
        {
            return this._tagKeys != null && this._tagKeys.Count > 0; 
        }

    }
}