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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Information about a URL rewrite transform. This transform matches a pattern in the
    /// request URL and replaces it with the specified string.
    /// </summary>
    public partial class UrlRewriteConfig
    {
        private List<RewriteConfig> _rewrites = AWSConfigs.InitializeCollections ? new List<RewriteConfig>() : null;

        /// <summary>
        /// Gets and sets the property Rewrites. 
        /// <para>
        /// The URL rewrite transform to apply to the request. The transform consists of a regular
        /// expression to match and a replacement string.
        /// </para>
        /// </summary>
        public List<RewriteConfig> Rewrites
        {
            get { return this._rewrites; }
            set { this._rewrites = value; }
        }

        // Check to see if Rewrites property is set
        internal bool IsSetRewrites()
        {
            return this._rewrites != null && (this._rewrites.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}