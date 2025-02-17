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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
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
namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Information about a redirect action.
    /// 
    ///  
    /// <para>
    /// A URI consists of the following components: protocol://hostname:port/path?query. You
    /// must modify at least one of the following components to avoid a redirect loop: protocol,
    /// hostname, port, or path. Any components that you do not modify retain their original
    /// values.
    /// </para>
    ///  
    /// <para>
    /// You can reuse URI components using the following reserved keywords:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// #{protocol}
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// #{host}
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// #{port}
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// #{path} (the leading "/" is removed)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// #{query}
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For example, you can change the path to "/new/#{path}", the hostname to "example.#{host}",
    /// or the query to "#{query}&amp;value=xyz".
    /// </para>
    /// </summary>
    public partial class RedirectActionConfig
    {
        private string _host;
        private string _path;
        private string _port;
        private string _protocol;
        private string _query;
        private RedirectActionStatusCodeEnum _statusCode;

        /// <summary>
        /// Gets and sets the property Host. 
        /// <para>
        /// The hostname. This component is not percent-encoded. The hostname can contain #{host}.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Host
        {
            get { return this._host; }
            set { this._host = value; }
        }

        // Check to see if Host property is set
        internal bool IsSetHost()
        {
            return this._host != null;
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The absolute path, starting with the leading "/". This component is not percent-encoded.
        /// The path can contain #{host}, #{path}, and #{port}.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port. You can specify a value from 1 to 65535 or #{port}.
        /// </para>
        /// </summary>
        public string Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol. You can specify HTTP, HTTPS, or #{protocol}. You can redirect HTTP to
        /// HTTP, HTTP to HTTPS, and HTTPS to HTTPS. You can't redirect HTTPS to HTTP.
        /// </para>
        /// </summary>
        public string Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property Query. 
        /// <para>
        /// The query parameters, URL-encoded when necessary, but not percent-encoded. Do not
        /// include the leading "?", as it is automatically added. You can specify any of the
        /// reserved keywords.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string Query
        {
            get { return this._query; }
            set { this._query = value; }
        }

        // Check to see if Query property is set
        internal bool IsSetQuery()
        {
            return this._query != null;
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The HTTP redirect code. The redirect is either permanent (HTTP 301) or temporary (HTTP
        /// 302).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RedirectActionStatusCodeEnum StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode != null;
        }

    }
}