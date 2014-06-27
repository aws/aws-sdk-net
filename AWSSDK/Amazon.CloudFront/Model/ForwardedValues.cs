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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A complex type that specifies how CloudFront handles query strings, cookies and headers.
    /// </summary>
    public partial class ForwardedValues
    {
        private CookiePreference _cookies;
        private Headers _headers;
        private bool? _queryString;


        /// <summary>
        /// Gets and sets the property Cookies. A complex type that specifies how CloudFront handles
        /// cookies.
        /// </summary>
        public CookiePreference Cookies
        {
            get { return this._cookies; }
            set { this._cookies = value; }
        }


        /// <summary>
        /// Sets the Cookies property
        /// </summary>
        /// <param name="cookies">The value to set for the Cookies property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ForwardedValues WithCookies(CookiePreference cookies)
        {
            this._cookies = cookies;
            return this;
        }

        // Check to see if Cookies property is set
        internal bool IsSetCookies()
        {
            return this._cookies != null;
        }


        /// <summary>
        /// Gets and sets the property Headers. A complex type that specifies the Headers, if
        /// any, that you want CloudFront to vary upon    for this cache behavior.
        /// </summary>
        public Headers Headers
        {
            get { return this._headers; }
            set { this._headers = value; }
        }


        /// <summary>
        /// Sets the Headers property
        /// </summary>
        /// <param name="headers">The value to set for the Headers property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ForwardedValues WithHeaders(Headers headers)
        {
            this._headers = headers;
            return this;
        }

        // Check to see if Headers property is set
        internal bool IsSetHeaders()
        {
            return this._headers != null;
        }


        /// <summary>
        /// Gets and sets the property QueryString. Indicates whether you want CloudFront to forward
        /// query strings to the    origin that is associated with this cache behavior. If so,
        /// specify true; if    not, specify false.
        /// </summary>
        public bool QueryString
        {
            get { return this._queryString.GetValueOrDefault(); }
            set { this._queryString = value; }
        }


        /// <summary>
        /// Sets the QueryString property
        /// </summary>
        /// <param name="queryString">The value to set for the QueryString property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ForwardedValues WithQueryString(bool queryString)
        {
            this._queryString = queryString;
            return this;
        }

        // Check to see if QueryString property is set
        internal bool IsSetQueryString()
        {
            return this._queryString.HasValue; 
        }

    }
}