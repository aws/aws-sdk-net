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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Container for the parameters to the RemoveTags operation.
    /// Removes the specified tags from the specified Elastic Load Balancing resources. You
    /// can remove the tags for one or more Application Load Balancers, Network Load Balancers,
    /// Gateway Load Balancers, target groups, listeners, or rules.
    /// </summary>
    public partial class RemoveTagsRequest : AmazonElasticLoadBalancingV2Request
    {
        private List<string> _resourceArns = new List<string>();
        private List<string> _tagKeys = new List<string>();

        /// <summary>
        /// Gets and sets the property ResourceArns. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ResourceArns
        {
            get { return this._resourceArns; }
            set { this._resourceArns = value; }
        }

        // Check to see if ResourceArns property is set
        internal bool IsSetResourceArns()
        {
            return this._resourceArns != null && this._resourceArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TagKeys. 
        /// <para>
        /// The tag keys for the tags to remove.
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