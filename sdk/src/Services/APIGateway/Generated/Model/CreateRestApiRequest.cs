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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRestApi operation.
    /// Creates a new <a>RestApi</a> resource.
    /// </summary>
    public partial class CreateRestApiRequest : AmazonAPIGatewayRequest
    {
        private ApiKeySourceType _apiKeySource;
        private List<string> _binaryMediaTypes = new List<string>();
        private string _cloneFrom;
        private string _description;
        private EndpointConfiguration _endpointConfiguration;
        private int? _minimumCompressionSize;
        private string _name;
        private string _policy;
        private string _version;

        /// <summary>
        /// Gets and sets the property ApiKeySource. 
        /// <para>
        /// The source of the API key for metering requests according to a usage plan. Valid values
        /// are: <ul><li><code>HEADER</code> to read the API key from the <code>X-API-Key</code>
        /// header of a request. </li><li><code>AUTHORIZER</code> to read the API key from the
        /// <code>UsageIdentifierKey</code> from a custom authorizer.</li></ul> 
        /// </para>
        /// </summary>
        public ApiKeySourceType ApiKeySource
        {
            get { return this._apiKeySource; }
            set { this._apiKeySource = value; }
        }

        // Check to see if ApiKeySource property is set
        internal bool IsSetApiKeySource()
        {
            return this._apiKeySource != null;
        }

        /// <summary>
        /// Gets and sets the property BinaryMediaTypes. 
        /// <para>
        /// The list of binary media types supported by the <a>RestApi</a>. By default, the <a>RestApi</a>
        /// supports only UTF-8-encoded text payloads.
        /// </para>
        /// </summary>
        public List<string> BinaryMediaTypes
        {
            get { return this._binaryMediaTypes; }
            set { this._binaryMediaTypes = value; }
        }

        // Check to see if BinaryMediaTypes property is set
        internal bool IsSetBinaryMediaTypes()
        {
            return this._binaryMediaTypes != null && this._binaryMediaTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CloneFrom. 
        /// <para>
        /// The ID of the <a>RestApi</a> that you want to clone from.
        /// </para>
        /// </summary>
        public string CloneFrom
        {
            get { return this._cloneFrom; }
            set { this._cloneFrom = value; }
        }

        // Check to see if CloneFrom property is set
        internal bool IsSetCloneFrom()
        {
            return this._cloneFrom != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the <a>RestApi</a>.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointConfiguration. 
        /// <para>
        /// The endpoint configuration of this <a>RestApi</a> showing the endpoint types of the
        /// API. 
        /// </para>
        /// </summary>
        public EndpointConfiguration EndpointConfiguration
        {
            get { return this._endpointConfiguration; }
            set { this._endpointConfiguration = value; }
        }

        // Check to see if EndpointConfiguration property is set
        internal bool IsSetEndpointConfiguration()
        {
            return this._endpointConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MinimumCompressionSize. 
        /// <para>
        /// A nullable integer that is used to enable compression (with non-negative between 0
        /// and 10485760 (10M) bytes, inclusive) or disable compression (with a null value) on
        /// an API. When compression is enabled, compression or decompression is not applied on
        /// the payload if the payload size is smaller than this value. Setting it to zero allows
        /// compression for any payload size.
        /// </para>
        /// </summary>
        public int MinimumCompressionSize
        {
            get { return this._minimumCompressionSize.GetValueOrDefault(); }
            set { this._minimumCompressionSize = value; }
        }

        // Check to see if MinimumCompressionSize property is set
        internal bool IsSetMinimumCompressionSize()
        {
            return this._minimumCompressionSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// [Required] The name of the <a>RestApi</a>.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. A stringified JSON policy document that applies
        /// to this RestApi regardless of the caller and <a>Method</a> configuration.
        /// </summary>
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// A version identifier for the API.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}