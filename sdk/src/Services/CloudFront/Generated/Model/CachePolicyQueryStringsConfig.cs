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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// An object that determines whether any URL query strings in viewer requests (and if
    /// so, which query strings) are included in the cache key and in requests that CloudFront
    /// sends to the origin.
    /// </summary>
    public partial class CachePolicyQueryStringsConfig
    {
        private CachePolicyQueryStringBehavior _queryStringBehavior;
        private QueryStringNames _queryStrings;

        /// <summary>
        /// Gets and sets the property QueryStringBehavior. 
        /// <para>
        /// Determines whether any URL query strings in viewer requests are included in the cache
        /// key and in requests that CloudFront sends to the origin. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>none</code> – No query strings in viewer requests are included in the cache
        /// key or in requests that CloudFront sends to the origin. Even when this field is set
        /// to <code>none</code>, any query strings that are listed in an <code>OriginRequestPolicy</code>
        /// <i>are</i> included in origin requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>whitelist</code> – Only the query strings in viewer requests that are listed
        /// in the <code>QueryStringNames</code> type are included in the cache key and in requests
        /// that CloudFront sends to the origin.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>allExcept</code> – All query strings in viewer requests are included in the
        /// cache key and in requests that CloudFront sends to the origin, <i> <b>except</b> </i>
        /// those that are listed in the <code>QueryStringNames</code> type, which are not included.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>all</code> – All query strings in viewer requests are included in the cache
        /// key and in requests that CloudFront sends to the origin.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public CachePolicyQueryStringBehavior QueryStringBehavior
        {
            get { return this._queryStringBehavior; }
            set { this._queryStringBehavior = value; }
        }

        // Check to see if QueryStringBehavior property is set
        internal bool IsSetQueryStringBehavior()
        {
            return this._queryStringBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property QueryStrings. 
        /// <para>
        /// Contains the specific query strings in viewer requests that either <i> <b>are</b>
        /// </i> or <i> <b>are not</b> </i> included in the cache key and in requests that CloudFront
        /// sends to the origin. The behavior depends on whether the <code>QueryStringBehavior</code>
        /// field in the <code>CachePolicyQueryStringsConfig</code> type is set to <code>whitelist</code>
        /// (the listed query strings <i> <b>are</b> </i> included) or <code>allExcept</code>
        /// (the listed query strings <i> <b>are not</b> </i> included, but all other query strings
        /// are).
        /// </para>
        /// </summary>
        public QueryStringNames QueryStrings
        {
            get { return this._queryStrings; }
            set { this._queryStrings = value; }
        }

        // Check to see if QueryStrings property is set
        internal bool IsSetQueryStrings()
        {
            return this._queryStrings != null;
        }

    }
}