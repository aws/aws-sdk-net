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
    /// A complex type that contains <code>HeaderName</code> and <code>HeaderValue</code>
    /// elements, if any, for this distribution.
    /// </summary>
    public partial class OriginCustomHeader
    {
        private string _headerName;
        private string _headerValue;

        /// <summary>
        /// Gets and sets the property HeaderName. 
        /// <para>
        /// The name of a header that you want CloudFront to send to your origin. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/forward-custom-headers.html">Adding
        /// Custom Headers to Origin Requests</a> in the <i> Amazon CloudFront Developer Guide</i>.
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

        /// <summary>
        /// Gets and sets the property HeaderValue. 
        /// <para>
        /// The value for the header that you specified in the <code>HeaderName</code> field.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string HeaderValue
        {
            get { return this._headerValue; }
            set { this._headerValue = value; }
        }

        // Check to see if HeaderValue property is set
        internal bool IsSetHeaderValue()
        {
            return this._headerValue != null;
        }

    }
}