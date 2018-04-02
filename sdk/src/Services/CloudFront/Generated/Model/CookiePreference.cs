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

/*
 * Do not modify this file. This file is generated from the cloudfront-2017-10-30.normal.json service model.
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
    /// A complex type that specifies whether you want CloudFront to forward cookies to the
    /// origin and, if so, which ones. For more information about forwarding cookies to the
    /// origin, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/Cookies.html">How
    /// CloudFront Forwards, Caches, and Logs Cookies</a> in the <i>Amazon CloudFront Developer
    /// Guide</i>.
    /// </summary>
    public partial class CookiePreference
    {
        private ItemSelection _forward;
        private CookieNames _whitelistedNames;

        /// <summary>
        /// Gets and sets the property Forward. 
        /// <para>
        /// Specifies which cookies to forward to the origin for this cache behavior: all, none,
        /// or the list of cookies specified in the <code>WhitelistedNames</code> complex type.
        /// </para>
        ///  
        /// <para>
        /// Amazon S3 doesn't process cookies. When the cache behavior is forwarding requests
        /// to an Amazon S3 origin, specify none for the <code>Forward</code> element. 
        /// </para>
        /// </summary>
        public ItemSelection Forward
        {
            get { return this._forward; }
            set { this._forward = value; }
        }

        // Check to see if Forward property is set
        internal bool IsSetForward()
        {
            return this._forward != null;
        }

        /// <summary>
        /// Gets and sets the property WhitelistedNames. 
        /// <para>
        /// Required if you specify <code>whitelist</code> for the value of <code>Forward:</code>.
        /// A complex type that specifies how many different cookies you want CloudFront to forward
        /// to the origin for this cache behavior and, if you want to forward selected cookies,
        /// the names of those cookies.
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>all</code> or none for the value of <code>Forward</code>, omit
        /// <code>WhitelistedNames</code>. If you change the value of <code>Forward</code> from
        /// <code>whitelist</code> to all or none and you don't delete the <code>WhitelistedNames</code>
        /// element and its child elements, CloudFront deletes them automatically.
        /// </para>
        ///  
        /// <para>
        /// For the current limit on the number of cookie names that you can whitelist for each
        /// cache behavior, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html#limits_cloudfront">Amazon
        /// CloudFront Limits</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </summary>
        public CookieNames WhitelistedNames
        {
            get { return this._whitelistedNames; }
            set { this._whitelistedNames = value; }
        }

        // Check to see if WhitelistedNames property is set
        internal bool IsSetWhitelistedNames()
        {
            return this._whitelistedNames != null;
        }

    }
}