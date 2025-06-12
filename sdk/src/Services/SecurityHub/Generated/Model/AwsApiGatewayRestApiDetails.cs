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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains information about a REST API in version 1 of Amazon API Gateway.
    /// </summary>
    public partial class AwsApiGatewayRestApiDetails
    {
        private string _apiKeySource;
        private List<string> _binaryMediaTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _createdDate;
        private string _description;
        private AwsApiGatewayEndpointConfiguration _endpointConfiguration;
        private string _id;
        private int? _minimumCompressionSize;
        private string _name;
        private string _version;

        /// <summary>
        /// Gets and sets the property ApiKeySource. 
        /// <para>
        /// The source of the API key for metering requests according to a usage plan.
        /// </para>
        ///  
        /// <para>
        ///  <c>HEADER</c> indicates whether to read the API key from the X-API-Key header of
        /// a request.
        /// </para>
        ///  
        /// <para>
        ///  <c>AUTHORIZER</c> indicates whether to read the API key from the <c>UsageIdentifierKey</c>
        /// from a custom authorizer.
        /// </para>
        /// </summary>
        public string ApiKeySource
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
        /// The list of binary media types supported by the REST API.
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
        /// Indicates when the API was created.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the REST API.
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
        /// The endpoint configuration of the REST API.
        /// </para>
        /// </summary>
        public AwsApiGatewayEndpointConfiguration EndpointConfiguration
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
        /// The identifier of the REST API.
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
        /// The minimum size in bytes of a payload before compression is enabled.
        /// </para>
        ///  
        /// <para>
        /// If <c>null</c>, then compression is disabled.
        /// </para>
        ///  
        /// <para>
        /// If 0, then all payloads are compressed.
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
        /// The name of the REST API.
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
        /// Gets and sets the property Version. 
        /// <para>
        /// The version identifier for the REST API.
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