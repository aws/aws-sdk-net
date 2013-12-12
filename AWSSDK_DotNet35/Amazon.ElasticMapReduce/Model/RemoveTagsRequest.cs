/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>Removes tags from an Amazon EMR resource. Tags make it easier to associate clusters in various ways, such as grouping clusters to
    /// track your Amazon EMR resource allocation costs. For more information, see <a
    /// href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/emr-plan-tags.html" >Tagging Amazon EMR Resources</a> .
    /// </para>
    /// </summary>
    public partial class RemoveTagsRequest : AmazonElasticMapReduceRequest
    {
        private string resourceId;
        private List<string> tagKeys = new List<string>();


        /// <summary>
        /// The Amazon EMR resource identifier from which tags will be removed. This value must be a cluster identifier.
        ///  
        /// </summary>
        public string ResourceId
        {
            get { return this.resourceId; }
            set { this.resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this.resourceId != null;
        }

        /// <summary>
        /// A list of tag keys to remove from a resource.
        ///  
        /// </summary>
        public List<string> TagKeys
        {
            get { return this.tagKeys; }
            set { this.tagKeys = value; }
        }

        // Check to see if TagKeys property is set
        internal bool IsSetTagKeys()
        {
            return this.tagKeys.Count > 0;
        }

    }
}
    
