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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the cache settings of an Amazon Lightsail content delivery network (CDN)
    /// distribution.
    /// 
    ///  
    /// <para>
    /// These settings apply only to your distribution's <c>cacheBehaviors</c> (including
    /// the <c>defaultCacheBehavior</c>) that have a <c>behavior</c> of <c>cache</c>.
    /// </para>
    /// </summary>
    public partial class CacheSettings
    {
        /// <summary>
        /// Gets and sets the property AllowedHTTPMethods. 
        /// <para>
        /// The HTTP methods that are processed and forwarded to the distribution's origin.
        /// </para>
        ///  
        /// <para>
        /// You can specify the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>GET,HEAD</c> - The distribution forwards the <c>GET</c> and <c>HEAD</c> methods.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GET,HEAD,OPTIONS</c> - The distribution forwards the <c>GET</c>, <c>HEAD</c>,
        /// and <c>OPTIONS</c> methods.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GET,HEAD,OPTIONS,PUT,PATCH,POST,DELETE</c> - The distribution forwards the <c>GET</c>,
        /// <c>HEAD</c>, <c>OPTIONS</c>, <c>PUT</c>, <c>PATCH</c>, <c>POST</c>, and <c>DELETE</c>
        /// methods.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify the third option, you might need to restrict access to your distribution's
        /// origin so users can't perform operations that you don't want them to. For example,
        /// you might not want users to have permission to delete objects from your origin.
        /// </para>
        /// </summary>
        public string AllowedHTTPMethods { get; set; }

        /// <summary>
        /// Checks to see if the AllowedHTTPMethods property is set.
        /// </summary>
        internal bool IsSetAllowedHTTPMethods() => this.AllowedHTTPMethods != null;

        /// <summary>
        /// Gets and sets the property CachedHTTPMethods. 
        /// <para>
        /// The HTTP method responses that are cached by your distribution.
        /// </para>
        ///  
        /// <para>
        /// You can specify the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>GET,HEAD</c> - The distribution caches responses to the <c>GET</c> and <c>HEAD</c>
        /// methods.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GET,HEAD,OPTIONS</c> - The distribution caches responses to the <c>GET</c>, <c>HEAD</c>,
        /// and <c>OPTIONS</c> methods.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string CachedHTTPMethods { get; set; }

        /// <summary>
        /// Checks to see if the CachedHTTPMethods property is set.
        /// </summary>
        internal bool IsSetCachedHTTPMethods() => this.CachedHTTPMethods != null;

        /// <summary>
        /// Gets and sets the property DefaultTTL. 
        /// <para>
        /// The default amount of time that objects stay in the distribution's cache before the
        /// distribution forwards another request to the origin to determine whether the content
        /// has been updated.
        /// </para>
        ///  <note> 
        /// <para>
        /// The value specified applies only when the origin does not add HTTP headers such as
        /// <c>Cache-Control max-age</c>, <c>Cache-Control s-maxage</c>, and <c>Expires</c> to
        /// objects.
        /// </para>
        ///  </note>
        /// </summary>
        public long? DefaultTTL { get; set; }

        /// <summary>
        /// Checks to see if the DefaultTTL property is set.
        /// </summary>
        internal bool IsSetDefaultTTL() => this.DefaultTTL.HasValue;

        /// <summary>
        /// Gets and sets the property ForwardedCookies. 
        /// <para>
        /// An object that describes the cookies that are forwarded to the origin. Your content
        /// is cached based on the cookies that are forwarded.
        /// </para>
        /// </summary>
        public CookieObject ForwardedCookies { get; set; }

        /// <summary>
        /// Checks to see if the ForwardedCookies property is set.
        /// </summary>
        internal bool IsSetForwardedCookies() => this.ForwardedCookies != null;

        /// <summary>
        /// Gets and sets the property ForwardedHeaders. 
        /// <para>
        /// An object that describes the headers that are forwarded to the origin. Your content
        /// is cached based on the headers that are forwarded.
        /// </para>
        /// </summary>
        public HeaderObject ForwardedHeaders { get; set; }

        /// <summary>
        /// Checks to see if the ForwardedHeaders property is set.
        /// </summary>
        internal bool IsSetForwardedHeaders() => this.ForwardedHeaders != null;

        /// <summary>
        /// Gets and sets the property ForwardedQueryStrings. 
        /// <para>
        /// An object that describes the query strings that are forwarded to the origin. Your
        /// content is cached based on the query strings that are forwarded.
        /// </para>
        /// </summary>
        public QueryStringObject ForwardedQueryStrings { get; set; }

        /// <summary>
        /// Checks to see if the ForwardedQueryStrings property is set.
        /// </summary>
        internal bool IsSetForwardedQueryStrings() => this.ForwardedQueryStrings != null;

        /// <summary>
        /// Gets and sets the property MaximumTTL. 
        /// <para>
        /// The maximum amount of time that objects stay in the distribution's cache before the
        /// distribution forwards another request to the origin to determine whether the object
        /// has been updated.
        /// </para>
        ///  
        /// <para>
        /// The value specified applies only when the origin adds HTTP headers such as <c>Cache-Control
        /// max-age</c>, <c>Cache-Control s-maxage</c>, and <c>Expires</c> to objects.
        /// </para>
        /// </summary>
        public long? MaximumTTL { get; set; }

        /// <summary>
        /// Checks to see if the MaximumTTL property is set.
        /// </summary>
        internal bool IsSetMaximumTTL() => this.MaximumTTL.HasValue;

        /// <summary>
        /// Gets and sets the property MinimumTTL. 
        /// <para>
        /// The minimum amount of time that objects stay in the distribution's cache before the
        /// distribution forwards another request to the origin to determine whether the object
        /// has been updated.
        /// </para>
        ///  
        /// <para>
        /// A value of <c>0</c> must be specified for <c>minimumTTL</c> if the distribution is
        /// configured to forward all headers to the origin.
        /// </para>
        /// </summary>
        public long? MinimumTTL { get; set; }

        /// <summary>
        /// Checks to see if the MinimumTTL property is set.
        /// </summary>
        internal bool IsSetMinimumTTL() => this.MinimumTTL.HasValue;
    }
}
