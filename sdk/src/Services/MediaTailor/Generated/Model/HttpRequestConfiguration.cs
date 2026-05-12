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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
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
namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// -- Function Configuration DataStructure
    /// </summary>
    public partial class HttpRequestConfiguration
    {
        private string _body;
        private Dictionary<string, string> _headers = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private MethodType _methodType;
        private Dictionary<string, string> _output = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private int? _requestTimeoutMilliseconds;
        private RuntimeType _runtime;
        private string _url;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// An expression that evaluates to the request body. Used with <c>POST</c> requests.
        /// The maximum size after evaluation is 64 KB.
        /// </para>
        /// </summary>
        public string Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property Headers. 
        /// <para>
        /// A map of HTTP header names to expression values. MediaTailor evaluates each header
        /// value expression at runtime and includes the result in the outbound HTTP request.
        /// Maximum 50 headers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Headers
        {
            get { return this._headers; }
            set { this._headers = value; }
        }

        // Check to see if Headers property is set
        internal bool IsSetHeaders()
        {
            return this._headers != null && (this._headers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MethodType. 
        /// <para>
        /// The HTTP method for the request. Valid values: <c>GET</c> and <c>POST</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MethodType MethodType
        {
            get { return this._methodType; }
            set { this._methodType = value; }
        }

        // Check to see if MethodType property is set
        internal bool IsSetMethodType()
        {
            return this._methodType != null;
        }

        /// <summary>
        /// Gets and sets the property Output. 
        /// <para>
        /// A map of output bindings. Each key is a namespaced output path (such as <c>player_params.device_type</c>
        /// or <c>temp.identity</c>), and each value is an expression that MediaTailor evaluates
        /// at runtime. Output expressions in an <c>HTTP_REQUEST</c> function can reference the
        /// <c>response</c> object returned by the HTTP call. For more information about expression
        /// syntax, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/monetization-functions-jsonata.html">JSONata
        /// expression reference</a> in the <i>MediaTailor User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Output
        {
            get { return this._output; }
            set { this._output = value; }
        }

        // Check to see if Output property is set
        internal bool IsSetOutput()
        {
            return this._output != null && (this._output.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RequestTimeoutMilliseconds. 
        /// <para>
        /// The maximum time, in milliseconds, that MediaTailor waits for a response from the
        /// external service. If the call exceeds this timeout, MediaTailor sets the response
        /// status code to <c>null</c> and proceeds with output expression evaluation. Valid values:
        /// <c>100</c> to <c>2000</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? RequestTimeoutMilliseconds
        {
            get { return this._requestTimeoutMilliseconds; }
            set { this._requestTimeoutMilliseconds = value; }
        }

        // Check to see if RequestTimeoutMilliseconds property is set
        internal bool IsSetRequestTimeoutMilliseconds()
        {
            return this._requestTimeoutMilliseconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Runtime. 
        /// <para>
        /// The expression language used to evaluate expressions in the function configuration.
        /// Set this to <c>JSONata</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RuntimeType Runtime
        {
            get { return this._runtime; }
            set { this._runtime = value; }
        }

        // Check to see if Runtime property is set
        internal bool IsSetRuntime()
        {
            return this._runtime != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// An expression that evaluates to the request URL. Use <c>{%...%}</c> delimiters for
        /// dynamic expressions. The maximum length after evaluation is 2,048 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}