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
    /// Container for the parameters to the ListTagsForResource operation.
    /// Lists all tags currently on a named resource.
    /// 
    ///  
    /// <para>
    ///  A tag is a key-value pair where the key and value are case-sensitive. You can use
    /// tags to categorize and track all your ElastiCache resources, with the exception of
    /// global replication group. When you add or remove tags on replication groups, those
    /// actions will be replicated to all nodes in the replication group. For more information,
    /// see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/dg/IAM.ResourceLevelPermissions.html">Resource-level
    /// permissions</a>.
    /// </para>
    ///  
    /// <para>
    /// If the cluster is not in the <i>available</i> state, <c>ListTagsForResource</c> returns
    /// an error.
    /// </para>
    /// </summary>
    public partial class ListTagsForResourceRequest : AmazonElastiCacheRequest
    {
        private string _resourceName;

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource for which you want the list of tags,
        /// for example <c>arn:aws:elasticache:us-west-2:0123456789:cluster:myCluster</c> or <c>arn:aws:elasticache:us-west-2:0123456789:snapshot:mySnapshot</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and Amazon Web Services Service Namespaces</a>.
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

    }
}