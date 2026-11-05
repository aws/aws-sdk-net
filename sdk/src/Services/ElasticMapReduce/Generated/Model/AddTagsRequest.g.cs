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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the AddTags operation. Adds tags to an Amazon EMR
    /// resource, such as a cluster or an Amazon EMR Studio. Tags make it easier to associate
    /// resources in various ways, such as grouping clusters to track your Amazon EMR resource
    /// allocation costs. For more information, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-plan-tags.html">Tag
    /// Clusters</a>.
    /// </summary>
    public partial class AddTagsRequest : AmazonElasticMapReduceRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public AddTagsRequest() { }

        /// <summary>
        /// Instantiates AddTagsRequest with the parameterized properties
        /// </summary>
        /// <param name="resourceId">The Amazon EMR resource identifier to which tags will be added. For example, a   cluster identifier or an Amazon EMR Studio ID.</param>
        public AddTagsRequest(string resourceId)
        {
            this.ResourceId = resourceId;
        }

        /// <summary>
        /// Instantiates AddTagsRequest with the parameterized properties
        /// </summary>
        /// <param name="resourceId">The Amazon EMR resource identifier to which tags will be added. For example, a   cluster identifier or an Amazon EMR Studio ID.</param>
        /// <param name="tags">A list of tags to associate with a resource. Tags are user-defined key-value pairs that   consist of a required key string with a maximum of 128 characters, and an optional value   string with a maximum of 256 characters.</param>
        public AddTagsRequest(string resourceId, List<Tag> tags)
        {
            this.ResourceId = resourceId;
            this.Tags = tags;
        }

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The ID of the cluster that scopes the tag operation. Required when the resource being
        /// tagged is a session-scoped resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Checks to see if the ClusterId property is set.
        /// </summary>
        internal bool IsSetClusterId() => this.ClusterId != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The Amazon EMR resource identifier to which tags will be added. For example, a cluster
        /// identifier or an Amazon EMR Studio ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to associate with a resource. Tags are user-defined key-value pairs
        /// that consist of a required key string with a maximum of 128 characters, and an optional
        /// value string with a maximum of 256 characters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
