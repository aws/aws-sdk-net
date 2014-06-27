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
    /// A complex type that specifies the cookie preferences associated with this cache behavior.
    /// </summary>
    public partial class CookiePreference
    {
        private string _forward;
        private CookieNames _whitelistedNames;


        /// <summary>
        /// Gets and sets the property Forward. Use this element to specify whether you want CloudFront
        /// to forward cookies to the origin that is    associated with this cache behavior. You
        /// can specify all, none or whitelist. If you choose All,    CloudFront forwards all
        /// cookies regardless of how many your application uses.
        /// </summary>
        public string Forward
        {
            get { return this._forward; }
            set { this._forward = value; }
        }


        /// <summary>
        /// Sets the Forward property
        /// </summary>
        /// <param name="forward">The value to set for the Forward property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CookiePreference WithForward(string forward)
        {
            this._forward = forward;
            return this;
        }

        // Check to see if Forward property is set
        internal bool IsSetForward()
        {
            return this._forward != null;
        }


        /// <summary>
        /// Gets and sets the property WhitelistedNames. A complex type that specifies the whitelisted
        /// cookies, if any, that you want CloudFront to forward to your    origin that is associated
        /// with this cache behavior.
        /// </summary>
        public CookieNames WhitelistedNames
        {
            get { return this._whitelistedNames; }
            set { this._whitelistedNames = value; }
        }


        /// <summary>
        /// Sets the WhitelistedNames property
        /// </summary>
        /// <param name="whitelistedNames">The value to set for the WhitelistedNames property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CookiePreference WithWhitelistedNames(CookieNames whitelistedNames)
        {
            this._whitelistedNames = whitelistedNames;
            return this;
        }

        // Check to see if WhitelistedNames property is set
        internal bool IsSetWhitelistedNames()
        {
            return this._whitelistedNames != null;
        }

    }
}