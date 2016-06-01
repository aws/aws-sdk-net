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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the AddTagsToResource operation.
    /// The <i>AddTagsToResource</i> action adds up to 10 cost allocation tags to the named
    /// resource. A <i>cost allocation tag</i> is a key-value pair where the key and value
    /// are case-sensitive. Cost allocation tags can be used to categorize and track your
    /// AWS costs.
    /// 
    ///  
    /// <para>
    ///  When you apply tags to your ElastiCache resources, AWS generates a cost allocation
    /// report as a comma-separated value (CSV) file with your usage and costs aggregated
    /// by your tags. You can apply tags that represent business categories (such as cost
    /// centers, application names, or owners) to organize your costs across multiple services.
    /// For more information, see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/UserGuide/Tagging.html">Using
    /// Cost Allocation Tags in Amazon ElastiCache</a> in the <i>ElastiCache User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AddTagsToResourceRequest : AmazonElastiCacheRequest
    {
        private string _resourceName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource to which the tags are to be added,
        /// for example <code>arn:aws:elasticache:us-west-2:0123456789:cluster:myCluster</code>
        /// or <code>arn:aws:elasticache:us-west-2:0123456789:snapshot:mySnapshot</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information on ARNs, go to <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and AWS Service Namespaces</a>.
        /// </para>
        /// </summary>
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
        /// A list of cost allocation tags to be added to this resource. A tag is a key-value
        /// pair. A tag key must be accompanied by a tag value.
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