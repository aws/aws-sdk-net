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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
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
namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Represents the response of the test invoke request in the HTTP method.
    /// </summary>
    public partial class TestInvokeMethodResponse : AmazonWebServiceResponse
    {
        private string _body;
        private Dictionary<string, string> _headers = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private long? _latency;
        private string _log;
        private Dictionary<string, List<string>> _multiValueHeaders = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private int? _status;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The body of the HTTP response.
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
        /// The headers of the HTTP response.
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
        /// Gets and sets the property Latency. 
        /// <para>
        /// The execution latency, in ms, of the test invoke request.
        /// </para>
        /// </summary>
        public long? Latency
        {
            get { return this._latency; }
            set { this._latency = value; }
        }

        // Check to see if Latency property is set
        internal bool IsSetLatency()
        {
            return this._latency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Log. 
        /// <para>
        /// The API Gateway execution log for the test invoke request.
        /// </para>
        /// </summary>
        public string Log
        {
            get { return this._log; }
            set { this._log = value; }
        }

        // Check to see if Log property is set
        internal bool IsSetLog()
        {
            return this._log != null;
        }

        /// <summary>
        /// Gets and sets the property MultiValueHeaders. 
        /// <para>
        /// The headers of the HTTP response as a map from string to list of values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> MultiValueHeaders
        {
            get { return this._multiValueHeaders; }
            set { this._multiValueHeaders = value; }
        }

        // Check to see if MultiValueHeaders property is set
        internal bool IsSetMultiValueHeaders()
        {
            return this._multiValueHeaders != null && (this._multiValueHeaders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status code.
        /// </para>
        /// </summary>
        public int? Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status.HasValue; 
        }

    }
}