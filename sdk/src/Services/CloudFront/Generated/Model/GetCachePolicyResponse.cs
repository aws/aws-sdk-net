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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// This is the response object from the GetCachePolicy operation.
    /// </summary>
    public partial class GetCachePolicyResponse : AmazonWebServiceResponse
    {
        private CachePolicy _cachePolicy;
        private string _eTag;

        /// <summary>
        /// Gets and sets the property CachePolicy. 
        /// <para>
        /// The cache policy.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ETag. 
        /// <para>
        /// The current version of the cache policy.
        /// </para>
        /// </summary>
        public string ETag
        {
            get { return this._eTag; }
            set { this._eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this._eTag != null;
        }

    }
}