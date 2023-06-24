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
    /// This configuration determines which HTTP requests are sent to the staging distribution.
    /// If the HTTP request contains a header and value that matches what you specify here,
    /// the request is sent to the staging distribution. Otherwise the request is sent to
    /// the primary distribution.
    /// </summary>
    public partial class ContinuousDeploymentSingleHeaderConfig
    {
        private string _header;
        private string _value;

        /// <summary>
        /// Gets and sets the property Header. 
        /// <para>
        /// The request header name that you want CloudFront to send to your staging distribution.
        /// The header must contain the prefix <code>aws-cf-cd-</code>.
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
        /// Gets and sets the property Value. 
        /// <para>
        /// The request header value.
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