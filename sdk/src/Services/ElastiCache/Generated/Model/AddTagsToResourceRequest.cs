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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
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
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the AddTagsToResource operation.
    /// A tag is a key-value pair where the key and value are case-sensitive. You can use
    /// tags to categorize and track all your ElastiCache resources, with the exception of
    /// global replication group. When you add or remove tags on replication groups, those
    /// actions will be replicated to all nodes in the replication group. For more information,
    /// see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/dg/IAM.ResourceLevelPermissions.html">Resource-level
    /// permissions</a>.
    /// 
    ///  
    /// <para>
    ///  For example, you can use cost-allocation tags to your ElastiCache resources, Amazon
    /// generates a cost allocation report as a comma-separated value (CSV) file with your
    /// usage and costs aggregated by your tags. You can apply tags that represent business
    /// categories (such as cost centers, application names, or owners) to organize your costs
    /// across multiple services.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/Tagging.html">Using
    /// Cost Allocation Tags in Amazon ElastiCache</a> in the <i>ElastiCache User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AddTagsToResourceRequest : AmazonElastiCacheRequest
    {
        private string _resourceName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource to which the tags are to be added,
        /// for example <c>arn:aws:elasticache:us-west-2:0123456789:cluster:myCluster</c> or <c>arn:aws:elasticache:us-west-2:0123456789:snapshot:mySnapshot</c>.
        /// ElastiCache resources are <i>cluster</i> and <i>snapshot</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and Amazon Service Namespaces</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }

        // Check to see if ResourceName property is set
        internal bool IsSetResourceName()
        {
            return this._resourceName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to be added to this resource. A tag is a key-value pair. A tag key
        /// must be accompanied by a tag value, although null is accepted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}