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
    /// Container for the parameters to the ListTagsForResource operation.
    /// Lists all cost allocation tags currently on the named resource. A <code>cost allocation
    /// tag</code> is a key-value pair where the key is case-sensitive and the value is optional.
    /// You can use cost allocation tags to categorize and track your AWS costs.
    /// 
    ///  
    /// <para>
    /// You can have a maximum of 10 cost allocation tags on an ElastiCache resource. For
    /// more information, see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/UserGuide/BestPractices.html">Using
    /// Cost Allocation Tags in Amazon ElastiCache</a>.
    /// </para>
    /// </summary>
    public partial class ListTagsForResourceRequest : AmazonElastiCacheRequest
    {
        private string _resourceName;

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource for which you want the list of tags,
        /// for example <code>arn:aws:elasticache:us-west-2:0123456789:cluster:myCluster</code>
        /// or <code>arn:aws:elasticache:us-west-2:0123456789:snapshot:mySnapshot</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
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

    }
}