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
    /// An HTTP response header name and its value. CloudFront includes this header in HTTP
    /// responses that it sends for requests that match a cache behavior that's associated
    /// with this response headers policy.
    /// </summary>
    public partial class ResponseHeadersPolicyCustomHeader
    {
        private string _header;
        private bool? _override;
        private string _value;

        /// <summary>
        /// Gets and sets the property Header. 
        /// <para>
        /// The HTTP response header name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Header
        {
            get { return this._header; }
            set { this._header = value; }
        }

        // Check to see if Header property is set
        internal bool IsSetHeader()
        {
            return this._header != null;
        }

        /// <summary>
        /// Gets and sets the property Override. 
        /// <para>
        /// A Boolean that determines whether CloudFront overrides a response header with the
        /// same name received from the origin with the header specified here.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool Override
        {
            get { return this._override.GetValueOrDefault(); }
            set { this._override = value; }
        }

        // Check to see if Override property is set
        internal bool IsSetOverride()
        {
            return this._override.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value for the HTTP response header.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}