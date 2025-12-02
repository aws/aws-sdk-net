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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
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
namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Specifies a field in the request to redact from WAF logs, such as headers, query
    /// parameters, or body content.
    /// </summary>
    public partial class FieldToMatch
    {
        private string _method;
        private string _queryString;
        private SingleHeader _singleHeader;
        private string _uriPath;

        /// <summary>
        /// Gets and sets the property Method. 
        /// <para>
        ///  Redacts the HTTP method from WAF logs. 
        /// </para>
        /// </summary>
        public string Method
        {
            get { return this._method; }
            set { this._method = value; }
        }

        // Check to see if Method property is set
        internal bool IsSetMethod()
        {
            return this._method != null;
        }

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        ///  Redacts the entire query string from WAF logs. 
        /// </para>
        /// </summary>
        public string QueryString
        {
            get { return this._queryString; }
            set { this._queryString = value; }
        }

        // Check to see if QueryString property is set
        internal bool IsSetQueryString()
        {
            return this._queryString != null;
        }

        /// <summary>
        /// Gets and sets the property SingleHeader. 
        /// <para>
        ///  Redacts a specific header field by name from WAF logs. 
        /// </para>
        /// </summary>
        public SingleHeader SingleHeader
        {
            get { return this._singleHeader; }
            set { this._singleHeader = value; }
        }

        // Check to see if SingleHeader property is set
        internal bool IsSetSingleHeader()
        {
            return this._singleHeader != null;
        }

        /// <summary>
        /// Gets and sets the property UriPath. 
        /// <para>
        ///  Redacts the URI path from WAF logs. 
        /// </para>
        /// </summary>
        public string UriPath
        {
            get { return this._uriPath; }
            set { this._uriPath = value; }
        }

        // Check to see if UriPath property is set
        internal bool IsSetUriPath()
        {
            return this._uriPath != null;
        }

    }
}