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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Configuration that defines how to make requests to endpoints, including request methods,
    /// paths, parameters, and response handling.
    /// </summary>
    public partial class SourceConfiguration
    {
        private PaginationConfiguration _paginationConfiguration;
        private HTTPMethod _requestMethod;
        private List<ConnectorProperty> _requestParameters = AWSConfigs.InitializeCollections ? new List<ConnectorProperty>() : null;
        private string _requestPath;
        private ResponseConfiguration _responseConfiguration;

        /// <summary>
        /// Gets and sets the property PaginationConfiguration. 
        /// <para>
        /// Configuration for handling paginated responses from the REST API, supporting both
        /// cursor-based and offset-based pagination strategies.
        /// </para>
        /// </summary>
        public PaginationConfiguration PaginationConfiguration
        {
            get { return this._paginationConfiguration; }
            set { this._paginationConfiguration = value; }
        }

        // Check to see if PaginationConfiguration property is set
        internal bool IsSetPaginationConfiguration()
        {
            return this._paginationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RequestMethod. 
        /// <para>
        /// The HTTP method to use for requests to this endpoint, such as GET, POST.
        /// </para>
        /// </summary>
        public HTTPMethod RequestMethod
        {
            get { return this._requestMethod; }
            set { this._requestMethod = value; }
        }

        // Check to see if RequestMethod property is set
        internal bool IsSetRequestMethod()
        {
            return this._requestMethod != null;
        }

        /// <summary>
        /// Gets and sets the property RequestParameters. 
        /// <para>
        /// Configuration for request parameters that should be included in API calls, such as
        /// query parameters, headers, or body content.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConnectorProperty> RequestParameters
        {
            get { return this._requestParameters; }
            set { this._requestParameters = value; }
        }

        // Check to see if RequestParameters property is set
        internal bool IsSetRequestParameters()
        {
            return this._requestParameters != null && (this._requestParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RequestPath. 
        /// <para>
        /// The URL path for the REST endpoint, which may include parameter placeholders that
        /// will be replaced with actual values during requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string RequestPath
        {
            get { return this._requestPath; }
            set { this._requestPath = value; }
        }

        // Check to see if RequestPath property is set
        internal bool IsSetRequestPath()
        {
            return this._requestPath != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseConfiguration. 
        /// <para>
        /// Configuration that defines how to parse and extract data from API responses, including
        /// success and error handling.
        /// </para>
        /// </summary>
        public ResponseConfiguration ResponseConfiguration
        {
            get { return this._responseConfiguration; }
            set { this._responseConfiguration = value; }
        }

        // Check to see if ResponseConfiguration property is set
        internal bool IsSetResponseConfiguration()
        {
            return this._responseConfiguration != null;
        }

    }
}