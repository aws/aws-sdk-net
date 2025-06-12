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
    /// Represents a REST API.
    /// </summary>
    public partial class ImportRestApiResponse : AmazonWebServiceResponse
    {
        private ApiKeySourceType _apiKeySource;
        private List<string> _binaryMediaTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _createdDate;
        private string _description;
        private bool? _disableExecuteApiEndpoint;
        private EndpointConfiguration _endpointConfiguration;
        private string _id;
        private int? _minimumCompressionSize;
        private string _name;
        private string _policy;
        private string _rootResourceId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _version;
        private List<string> _warnings = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ApiKeySource. 
        /// <para>
        /// The source of the API key for metering requests according to a usage plan. Valid values
        /// are: &gt;<c>HEADER</c> to read the API key from the <c>X-API-Key</c> header of a request.
        /// <c>AUTHORIZER</c> to read the API key from the <c>UsageIdentifierKey</c> from a custom
        /// authorizer.
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
        /// The list of binary media types supported by the RestApi. By default, the RestApi supports
        /// only UTF-8-encoded text payloads.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> BinaryMediaTypes
        {
            get { return this._binaryMediaTypes; }
            set { this._binaryMediaTypes = value; }
        }

        // Check to see if BinaryMediaTypes property is set
        internal bool IsSetBinaryMediaTypes()
        {
            return this._binaryMediaTypes != null && (this._binaryMediaTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The timestamp when the API was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate
        {
            get { return this._createdDate; }
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
        /// Gets and sets the property DisableExecuteApiEndpoint. 
        /// <para>
        /// Specifies whether clients can invoke your API by using the default <c>execute-api</c>
        /// endpoint. By default, clients can invoke your API with the default <c>https://{api_id}.execute-api.{region}.amazonaws.com</c>
        /// endpoint. To require that clients use a custom domain name to invoke your API, disable
        /// the default endpoint.
        /// </para>
        /// </summary>
        public bool? DisableExecuteApiEndpoint
        {
            get { return this._disableExecuteApiEndpoint; }
            set { this._disableExecuteApiEndpoint = value; }
        }

        // Check to see if DisableExecuteApiEndpoint property is set
        internal bool IsSetDisableExecuteApiEndpoint()
        {
            return this._disableExecuteApiEndpoint.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndpointConfiguration. 
        /// <para>
        /// The endpoint configuration of this RestApi showing the endpoint types and IP address
        /// types of the API. 
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
        public int? MinimumCompressionSize
        {
            get { return this._minimumCompressionSize; }
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
        /// Gets and sets the property Policy. 
        /// <para>
        /// A stringified JSON policy document that applies to this RestApi regardless of the
        /// caller and Method configuration.
        /// </para>
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
        /// Gets and sets the property RootResourceId. 
        /// <para>
        /// The API's root resource ID.
        /// </para>
        /// </summary>
        public string RootResourceId
        {
            get { return this._rootResourceId; }
            set { this._rootResourceId = value; }
        }

        // Check to see if RootResourceId property is set
        internal bool IsSetRootResourceId()
        {
            return this._rootResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The collection of tags. Each tag element is associated with a given resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// The warning messages reported when <c>failonwarnings</c> is turned on during API import.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Warnings
        {
            get { return this._warnings; }
            set { this._warnings = value; }
        }

        // Check to see if Warnings property is set
        internal bool IsSetWarnings()
        {
            return this._warnings != null && (this._warnings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}