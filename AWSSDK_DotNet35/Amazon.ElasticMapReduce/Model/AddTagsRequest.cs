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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
    /// Container for the parameters to the AddTags operation.
    /// Adds tags to an Amazon EMR resource. Tags make it easier to associate clusters in
    /// various ways, such as grouping clusters to track your Amazon EMR resource allocation
    /// costs. For more information, see <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/emr-plan-tags.html">Tagging
    /// Amazon EMR Resources</a>.
    /// </summary>
    public partial class AddTagsRequest : AmazonElasticMapReduceRequest
    {
        private string _resourceId;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public AddTagsRequest() { }

        /// <summary>
        /// Instantiates AddTagsRequest with the parameterized properties
        /// </summary>
        /// <param name="resourceId">The Amazon EMR resource identifier to which tags will be added. This value must be a cluster identifier.</param>
        public AddTagsRequest(string resourceId)
        {
            _resourceId = resourceId;
        }

        /// <summary>
        /// Instantiates AddTagsRequest with the parameterized properties
        /// </summary>
        /// <param name="resourceId">The Amazon EMR resource identifier to which tags will be added. This value must be a cluster identifier.</param>
        /// <param name="tags">A list of tags to associate with a cluster and propagate to Amazon EC2 instances. Tags are user-defined key/value pairs that consist of a required key string with a maximum of 128 characters, and an optional value string with a maximum of 256 characters.</param>
        public AddTagsRequest(string resourceId, List<Tag> tags)
        {
            _resourceId = resourceId;
            _tags = tags;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The Amazon EMR resource identifier to which tags will be added. This value must be
        /// a cluster identifier.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to associate with a cluster and propagate to Amazon EC2 instances.
        /// Tags are user-defined key/value pairs that consist of a required key string with a
        /// maximum of 128 characters, and an optional value string with a maximum of 256 characters.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}