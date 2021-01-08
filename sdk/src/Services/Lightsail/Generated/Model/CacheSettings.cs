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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the cache settings of an Amazon Lightsail content delivery network (CDN)
    /// distribution.
    /// 
    ///  
    /// <para>
    /// These settings apply only to your distribution's <code>cacheBehaviors</code> (including
    /// the <code>defaultCacheBehavior</code>) that have a <code>behavior</code> of <code>cache</code>.
    /// </para>
    /// </summary>
    public partial class CacheSettings
    {
        private string _allowedhttpMethods;
        private string _cachedhttpMethods;
        private long? _defaultttl;
        private CookieObject _forwardedCookies;
        private HeaderObject _forwardedHeaders;
        private QueryStringObject _forwardedQueryStrings;
        private long? _maximumttl;
        private long? _minimumttl;

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
        ///  <code>GET,HEAD</code> - The distribution forwards the <code>GET</code> and <code>HEAD</code>
        /// methods.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GET,HEAD,OPTIONS</code> - The distribution forwards the <code>GET</code>, <code>HEAD</code>,
        /// and <code>OPTIONS</code> methods.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GET,HEAD,OPTIONS,PUT,PATCH,POST,DELETE</code> - The distribution forwards the
        /// <code>GET</code>, <code>HEAD</code>, <code>OPTIONS</code>, <code>PUT</code>, <code>PATCH</code>,
        /// <code>POST</code>, and <code>DELETE</code> methods.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify the third option, you might need to restrict access to your distribution's
        /// origin so users can't perform operations that you don't want them to. For example,
        /// you might not want users to have permission to delete objects from your origin.
        /// </para>
        /// </summary>
        public string AllowedHTTPMethods
        {
            get { return this._allowedhttpMethods; }
            set { this._allowedhttpMethods = value; }
        }

        // Check to see if AllowedHTTPMethods property is set
        internal bool IsSetAllowedHTTPMethods()
        {
            return this._allowedhttpMethods != null;
        }

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
        ///  <code>GET,HEAD</code> - The distribution caches responses to the <code>GET</code>
        /// and <code>HEAD</code> methods.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GET,HEAD,OPTIONS</code> - The distribution caches responses to the <code>GET</code>,
        /// <code>HEAD</code>, and <code>OPTIONS</code> methods.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string CachedHTTPMethods
        {
            get { return this._cachedhttpMethods; }
            set { this._cachedhttpMethods = value; }
        }

        // Check to see if CachedHTTPMethods property is set
        internal bool IsSetCachedHTTPMethods()
        {
            return this._cachedhttpMethods != null;
        }

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
        /// <code>Cache-Control max-age</code>, <code>Cache-Control s-maxage</code>, and <code>Expires</code>
        /// to objects.
        /// </para>
        ///  </note>
        /// </summary>
        public long DefaultTTL
        {
            get { return this._defaultttl.GetValueOrDefault(); }
            set { this._defaultttl = value; }
        }

        // Check to see if DefaultTTL property is set
        internal bool IsSetDefaultTTL()
        {
            return this._defaultttl.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ForwardedCookies. 
        /// <para>
        /// An object that describes the cookies that are forwarded to the origin. Your content
        /// is cached based on the cookies that are forwarded.
        /// </para>
        /// </summary>
        public CookieObject ForwardedCookies
        {
            get { return this._forwardedCookies; }
            set { this._forwardedCookies = value; }
        }

        // Check to see if ForwardedCookies property is set
        internal bool IsSetForwardedCookies()
        {
            return this._forwardedCookies != null;
        }

        /// <summary>
        /// Gets and sets the property ForwardedHeaders. 
        /// <para>
        /// An object that describes the headers that are forwarded to the origin. Your content
        /// is cached based on the headers that are forwarded.
        /// </para>
        /// </summary>
        public HeaderObject ForwardedHeaders
        {
            get { return this._forwardedHeaders; }
            set { this._forwardedHeaders = value; }
        }

        // Check to see if ForwardedHeaders property is set
        internal bool IsSetForwardedHeaders()
        {
            return this._forwardedHeaders != null;
        }

        /// <summary>
        /// Gets and sets the property ForwardedQueryStrings. 
        /// <para>
        /// An object that describes the query strings that are forwarded to the origin. Your
        /// content is cached based on the query strings that are forwarded.
        /// </para>
        /// </summary>
        public QueryStringObject ForwardedQueryStrings
        {
            get { return this._forwardedQueryStrings; }
            set { this._forwardedQueryStrings = value; }
        }

        // Check to see if ForwardedQueryStrings property is set
        internal bool IsSetForwardedQueryStrings()
        {
            return this._forwardedQueryStrings != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumTTL. 
        /// <para>
        /// The maximum amount of time that objects stay in the distribution's cache before the
        /// distribution forwards another request to the origin to determine whether the object
        /// has been updated.
        /// </para>
        ///  
        /// <para>
        /// The value specified applies only when the origin adds HTTP headers such as <code>Cache-Control
        /// max-age</code>, <code>Cache-Control s-maxage</code>, and <code>Expires</code> to objects.
        /// </para>
        /// </summary>
        public long MaximumTTL
        {
            get { return this._maximumttl.GetValueOrDefault(); }
            set { this._maximumttl = value; }
        }

        // Check to see if MaximumTTL property is set
        internal bool IsSetMaximumTTL()
        {
            return this._maximumttl.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinimumTTL. 
        /// <para>
        /// The minimum amount of time that objects stay in the distribution's cache before the
        /// distribution forwards another request to the origin to determine whether the object
        /// has been updated.
        /// </para>
        ///  
        /// <para>
        /// A value of <code>0</code> must be specified for <code>minimumTTL</code> if the distribution
        /// is configured to forward all headers to the origin.
        /// </para>
        /// </summary>
        public long MinimumTTL
        {
            get { return this._minimumttl.GetValueOrDefault(); }
            set { this._minimumttl = value; }
        }

        // Check to see if MinimumTTL property is set
        internal bool IsSetMinimumTTL()
        {
            return this._minimumttl.HasValue; 
        }

    }
}