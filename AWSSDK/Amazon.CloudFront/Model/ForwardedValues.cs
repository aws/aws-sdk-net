/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// <para> A complex type that specifies how CloudFront handles query strings. </para>
    /// </summary>
    public class ForwardedValues
    {
        
        private bool? queryString;
        private CookiePreference cookies;

        /// <summary>
        /// Indicates whether you want CloudFront to forward query strings to the origin that is associated with this cache behavior. If so, specify
        /// true; if not, specify false.
        ///  
        /// </summary>
        public bool QueryString
        {
            get { return this.queryString ?? default(bool); }
            set { this.queryString = value; }
        }

        /// <summary>
        /// Sets the QueryString property
        /// </summary>
        /// <param name="queryString">The value to set for the QueryString property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ForwardedValues WithQueryString(bool queryString)
        {
            this.queryString = queryString;
            return this;
        }
            

        // Check to see if QueryString property is set
        internal bool IsSetQueryString()
        {
            return this.queryString.HasValue;
        }

        /// <summary>
        /// A complex type that specifies how CloudFront handles cookies.
        ///  
        /// </summary>
        public CookiePreference Cookies
        {
            get { return this.cookies; }
            set { this.cookies = value; }
        }

        /// <summary>
        /// Sets the Cookies property
        /// </summary>
        /// <param name="cookies">The value to set for the Cookies property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ForwardedValues WithCookies(CookiePreference cookies)
        {
            this.cookies = cookies;
            return this;
        }
            

        // Check to see if Cookies property is set
        internal bool IsSetCookies()
        {
            return this.cookies != null;
        }
    }
}
