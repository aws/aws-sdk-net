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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Contains a cache policy.
    /// </summary>
    public partial class CachePolicySummary
    {
        private CachePolicy _cachePolicy;
        private CachePolicyType _type;

        /// <summary>
        /// Gets and sets the property CachePolicy. 
        /// <para>
        /// The cache policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CachePolicy CachePolicy
        {
            get { return this._cachePolicy; }
            set { this._cachePolicy = value; }
        }

        // Check to see if CachePolicy property is set
        internal bool IsSetCachePolicy()
        {
            return this._cachePolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of cache policy, either <code>managed</code> (created by AWS) or <code>custom</code>
        /// (created in this AWS account).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CachePolicyType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}