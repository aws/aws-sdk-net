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
    /// A complex type that specifies the HTTP header name from which CloudFront extracts
    /// cache tags from origin responses. When you add <c>CacheTagConfig</c> to a distribution,
    /// CloudFront reads the specified header from origin responses, parses the comma-separated
    /// tag values, and stores them with the cached object. You can then invalidate cached
    /// objects by tag using the <c>CreateInvalidation</c> API.
    /// </summary>
    public partial class CacheTagConfig
    {
        private string _headerName;

        /// <summary>
        /// Gets and sets the property HeaderName. 
        /// <para>
        /// The name of the HTTP header that your origin includes in responses. CloudFront uses
        /// this header to extract cache tags. The header value must contain comma-separated tag
        /// values (for example, <c>product:electronics, category:tv, brand:example</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string HeaderName
        {
            get { return this._headerName; }
            set { this._headerName = value; }
        }

        // Check to see if HeaderName property is set
        internal bool IsSetHeaderName()
        {
            return this._headerName != null;
        }

    }
}