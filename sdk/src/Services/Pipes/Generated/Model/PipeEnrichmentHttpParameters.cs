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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// These are custom parameter to be used when the target is an API Gateway REST APIs
    /// or EventBridge ApiDestinations. In the latter case, these are merged with any InvocationParameters
    /// specified on the Connection, with any values from the Connection taking precedence.
    /// </summary>
    public partial class PipeEnrichmentHttpParameters
    {
        private Dictionary<string, string> _headerParameters = new Dictionary<string, string>();
        private List<string> _pathParameterValues = new List<string>();
        private Dictionary<string, string> _queryStringParameters = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property HeaderParameters. 
        /// <para>
        /// The headers that need to be sent as part of request invoking the API Gateway REST
        /// API or EventBridge ApiDestination.
        /// </para>
        /// </summary>
        public Dictionary<string, string> HeaderParameters
        {
            get { return this._headerParameters; }
            set { this._headerParameters = value; }
        }

        // Check to see if HeaderParameters property is set
        internal bool IsSetHeaderParameters()
        {
            return this._headerParameters != null && this._headerParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PathParameterValues. 
        /// <para>
        /// The path parameter values to be used to populate API Gateway REST API or EventBridge
        /// ApiDestination path wildcards ("*").
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<string> PathParameterValues
        {
            get { return this._pathParameterValues; }
            set { this._pathParameterValues = value; }
        }

        // Check to see if PathParameterValues property is set
        internal bool IsSetPathParameterValues()
        {
            return this._pathParameterValues != null && this._pathParameterValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property QueryStringParameters. 
        /// <para>
        /// The query string keys/values that need to be sent as part of request invoking the
        /// API Gateway REST API or EventBridge ApiDestination.
        /// </para>
        /// </summary>
        public Dictionary<string, string> QueryStringParameters
        {
            get { return this._queryStringParameters; }
            set { this._queryStringParameters = value; }
        }

        // Check to see if QueryStringParameters property is set
        internal bool IsSetQueryStringParameters()
        {
            return this._queryStringParameters != null && this._queryStringParameters.Count > 0; 
        }

    }
}