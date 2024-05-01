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
    /// This field is deprecated. We recommend that you use a cache policy or an origin request
    /// policy instead of this field.
    /// 
    ///  
    /// <para>
    /// If you want to include cookies in the cache key, use <c>CookiesConfig</c> in a cache
    /// policy. See <c>CachePolicy</c>.
    /// </para>
    ///  
    /// <para>
    /// If you want to send cookies to the origin but not include them in the cache key, use
    /// <c>CookiesConfig</c> in an origin request policy. See <c>OriginRequestPolicy</c>.
    /// </para>
    ///  
    /// <para>
    /// A complex type that specifies whether you want CloudFront to forward cookies to the
    /// origin and, if so, which ones. For more information about forwarding cookies to the
    /// origin, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/Cookies.html">Caching
    /// Content Based on Cookies</a> in the <i>Amazon CloudFront Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CookiePreference
    {
        private ItemSelection _forward;
        private CookieNames _whitelistedNames;

        /// <summary>
        /// Gets and sets the property Forward. 
        /// <para>
        /// This field is deprecated. We recommend that you use a cache policy or an origin request
        /// policy instead of this field.
        /// </para>
        ///  
        /// <para>
        /// If you want to include cookies in the cache key, use a cache policy. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/controlling-the-cache-key.html#cache-key-create-cache-policy">Creating
        /// cache policies</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you want to send cookies to the origin but not include them in the cache key, use
        /// origin request policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/controlling-origin-requests.html#origin-request-create-origin-request-policy">Creating
        /// origin request policies</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Specifies which cookies to forward to the origin for this cache behavior: all, none,
        /// or the list of cookies specified in the <c>WhitelistedNames</c> complex type.
        /// </para>
        ///  
        /// <para>
        /// Amazon S3 doesn't process cookies. When the cache behavior is forwarding requests
        /// to an Amazon S3 origin, specify none for the <c>Forward</c> element.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// This field is deprecated. We recommend that you use a cache policy or an origin request
        /// policy instead of this field.
        /// </para>
        ///  
        /// <para>
        /// If you want to include cookies in the cache key, use a cache policy. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/controlling-the-cache-key.html#cache-key-create-cache-policy">Creating
        /// cache policies</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you want to send cookies to the origin but not include them in the cache key, use
        /// an origin request policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/controlling-origin-requests.html#origin-request-create-origin-request-policy">Creating
        /// origin request policies</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Required if you specify <c>whitelist</c> for the value of <c>Forward</c>. A complex
        /// type that specifies how many different cookies you want CloudFront to forward to the
        /// origin for this cache behavior and, if you want to forward selected cookies, the names
        /// of those cookies.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>all</c> or <c>none</c> for the value of <c>Forward</c>, omit <c>WhitelistedNames</c>.
        /// If you change the value of <c>Forward</c> from <c>whitelist</c> to <c>all</c> or <c>none</c>
        /// and you don't delete the <c>WhitelistedNames</c> element and its child elements, CloudFront
        /// deletes them automatically.
        /// </para>
        ///  
        /// <para>
        /// For the current limit on the number of cookie names that you can whitelist for each
        /// cache behavior, see <a href="https://docs.aws.amazon.com/general/latest/gr/xrefaws_service_limits.html#limits_cloudfront">
        /// CloudFront Limits</a> in the <i>Amazon Web Services General Reference</i>.
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