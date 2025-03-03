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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The HTTP header in the <c>ContextData</c> parameter.
    /// </summary>
    public partial class HttpHeader
    {
        private string _headerName;
        private string _headerValue;

        /// <summary>
        /// Gets and sets the property HeaderName. 
        /// <para>
        /// The header name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=131072)]
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
        /// The header value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=131072)]
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