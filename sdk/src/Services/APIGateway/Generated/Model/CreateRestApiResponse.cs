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
    /// Represents a REST API.
    /// 
    ///  <div class="seeAlso"> <a href="http://docs.aws.amazon.com/apigateway/latest/developerguide/how-to-create-api.html">Create
    /// an API</a> </div>
    /// </summary>
    public partial class CreateRestApiResponse : AmazonWebServiceResponse
    {
        private ApiKeySourceType _apiKeySource;
        private List<string> _binaryMediaTypes = new List<string>();
        private DateTime? _createdDate;
        private string _description;
        private EndpointConfiguration _endpointConfiguration;
        private string _id;
        private int? _minimumCompressionSize;
        private string _name;
        private string _policy;
        private string _version;
        private List<string> _warnings = new List<string>();

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
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The timestamp when the API was created.
        /// </para>
        /// </summary>
        public DateTime CreatedDate
        {
            get { return this._createdDate.GetValueOrDefault(); }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The API's description.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The API's identifier. This identifier is unique across all of your APIs in API Gateway.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
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
        /// The API's name.
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

        /// <summary>
        /// Gets and sets the property Warnings. 
        /// <para>
        /// The warning messages reported when <code>failonwarnings</code> is turned on during
        /// API import.
        /// </para>
        /// </summary>
        public List<string> Warnings
        {
            get { return this._warnings; }
            set { this._warnings = value; }
        }

        // Check to see if Warnings property is set
        internal bool IsSetWarnings()
        {
            return this._warnings != null && this._warnings.Count > 0; 
        }

    }
}