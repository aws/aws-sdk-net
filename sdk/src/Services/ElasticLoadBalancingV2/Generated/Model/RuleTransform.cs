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
    /// Information about a transform to apply to requests that match a rule. Transforms are
    /// applied to requests before they are sent to targets.
    /// </summary>
    public partial class RuleTransform
    {
        private HostHeaderRewriteConfig _hostHeaderRewriteConfig;
        private TransformTypeEnum _type;
        private UrlRewriteConfig _urlRewriteConfig;

        /// <summary>
        /// Gets and sets the property HostHeaderRewriteConfig. 
        /// <para>
        /// Information about a host header rewrite transform. This transform modifies the host
        /// header in an HTTP request. Specify only when <c>Type</c> is <c>host-header-rewrite</c>.
        /// </para>
        /// </summary>
        public HostHeaderRewriteConfig HostHeaderRewriteConfig
        {
            get { return this._hostHeaderRewriteConfig; }
            set { this._hostHeaderRewriteConfig = value; }
        }

        // Check to see if HostHeaderRewriteConfig property is set
        internal bool IsSetHostHeaderRewriteConfig()
        {
            return this._hostHeaderRewriteConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of transform. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>host-header-rewrite</c> - Rewrite the host header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>url-rewrite</c> - Rewrite the request URL.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public TransformTypeEnum Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UrlRewriteConfig. 
        /// <para>
        /// Information about a URL rewrite transform. This transform modifies the request URL.
        /// Specify only when <c>Type</c> is <c>url-rewrite</c>.
        /// </para>
        /// </summary>
        public UrlRewriteConfig UrlRewriteConfig
        {
            get { return this._urlRewriteConfig; }
            set { this._urlRewriteConfig = value; }
        }

        // Check to see if UrlRewriteConfig property is set
        internal bool IsSetUrlRewriteConfig()
        {
            return this._urlRewriteConfig != null;
        }

    }
}