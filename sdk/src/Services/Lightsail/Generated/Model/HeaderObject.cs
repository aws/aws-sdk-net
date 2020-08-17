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
    /// Describes the request headers that a Lightsail distribution bases caching on.
    /// 
    ///  
    /// <para>
    /// For the headers that you specify, your distribution caches separate versions of the
    /// specified content based on the header values in viewer requests. For example, suppose
    /// viewer requests for <code>logo.jpg</code> contain a custom <code>product</code> header
    /// that has a value of either <code>acme</code> or <code>apex</code>, and you configure
    /// your distribution to cache your content based on values in the <code>product</code>
    /// header. Your distribution forwards the <code>product</code> header to the origin and
    /// caches the response from the origin once for each header value. 
    /// </para>
    /// </summary>
    public partial class HeaderObject
    {
        private List<string> _headersAllowList = new List<string>();
        private ForwardValues _option;

        /// <summary>
        /// Gets and sets the property HeadersAllowList. 
        /// <para>
        /// The specific headers to forward to your distribution's origin.
        /// </para>
        /// </summary>
        public List<string> HeadersAllowList
        {
            get { return this._headersAllowList; }
            set { this._headersAllowList = value; }
        }

        // Check to see if HeadersAllowList property is set
        internal bool IsSetHeadersAllowList()
        {
            return this._headersAllowList != null && this._headersAllowList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Option. 
        /// <para>
        /// The headers that you want your distribution to forward to your origin and base caching
        /// on.
        /// </para>
        ///  
        /// <para>
        /// You can configure your distribution to do one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>all</code> </b> - Forward all headers to your origin.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>none</code> </b> - Forward only the default headers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>allow-list</code> </b> - Forward only the headers you specify using the
        /// <code>headersAllowList</code> parameter.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ForwardValues Option
        {
            get { return this._option; }
            set { this._option = value; }
        }

        // Check to see if Option property is set
        internal bool IsSetOption()
        {
            return this._option != null;
        }

    }
}