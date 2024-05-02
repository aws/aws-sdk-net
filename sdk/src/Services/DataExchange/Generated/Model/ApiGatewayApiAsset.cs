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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
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
namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// The API Gateway API that is the asset.
    /// </summary>
    public partial class ApiGatewayApiAsset
    {
        private string _apiDescription;
        private string _apiEndpoint;
        private string _apiId;
        private string _apiKey;
        private string _apiName;
        private string _apiSpecificationDownloadUrl;
        private DateTime? _apiSpecificationDownloadUrlExpiresAt;
        private ProtocolType _protocolType;
        private string _stage;

        /// <summary>
        /// Gets and sets the property ApiDescription. 
        /// <para>
        /// The API description of the API asset.
        /// </para>
        /// </summary>
        public string ApiDescription
        {
            get { return this._apiDescription; }
            set { this._apiDescription = value; }
        }

        // Check to see if ApiDescription property is set
        internal bool IsSetApiDescription()
        {
            return this._apiDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ApiEndpoint. 
        /// <para>
        /// The API endpoint of the API asset.
        /// </para>
        /// </summary>
        public string ApiEndpoint
        {
            get { return this._apiEndpoint; }
            set { this._apiEndpoint = value; }
        }

        // Check to see if ApiEndpoint property is set
        internal bool IsSetApiEndpoint()
        {
            return this._apiEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The unique identifier of the API asset.
        /// </para>
        /// </summary>
        public string ApiId
        {
            get { return this._apiId; }
            set { this._apiId = value; }
        }

        // Check to see if ApiId property is set
        internal bool IsSetApiId()
        {
            return this._apiId != null;
        }

        /// <summary>
        /// Gets and sets the property ApiKey. 
        /// <para>
        /// The API key of the API asset.
        /// </para>
        /// </summary>
        public string ApiKey
        {
            get { return this._apiKey; }
            set { this._apiKey = value; }
        }

        // Check to see if ApiKey property is set
        internal bool IsSetApiKey()
        {
            return this._apiKey != null;
        }

        /// <summary>
        /// Gets and sets the property ApiName. 
        /// <para>
        /// The API name of the API asset.
        /// </para>
        /// </summary>
        public string ApiName
        {
            get { return this._apiName; }
            set { this._apiName = value; }
        }

        // Check to see if ApiName property is set
        internal bool IsSetApiName()
        {
            return this._apiName != null;
        }

        /// <summary>
        /// Gets and sets the property ApiSpecificationDownloadUrl. 
        /// <para>
        /// The download URL of the API specification of the API asset.
        /// </para>
        /// </summary>
        public string ApiSpecificationDownloadUrl
        {
            get { return this._apiSpecificationDownloadUrl; }
            set { this._apiSpecificationDownloadUrl = value; }
        }

        // Check to see if ApiSpecificationDownloadUrl property is set
        internal bool IsSetApiSpecificationDownloadUrl()
        {
            return this._apiSpecificationDownloadUrl != null;
        }

        /// <summary>
        /// Gets and sets the property ApiSpecificationDownloadUrlExpiresAt. 
        /// <para>
        /// The date and time that the upload URL expires, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? ApiSpecificationDownloadUrlExpiresAt
        {
            get { return this._apiSpecificationDownloadUrlExpiresAt; }
            set { this._apiSpecificationDownloadUrlExpiresAt = value; }
        }

        // Check to see if ApiSpecificationDownloadUrlExpiresAt property is set
        internal bool IsSetApiSpecificationDownloadUrlExpiresAt()
        {
            return this._apiSpecificationDownloadUrlExpiresAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProtocolType. 
        /// <para>
        /// The protocol type of the API asset.
        /// </para>
        /// </summary>
        public ProtocolType ProtocolType
        {
            get { return this._protocolType; }
            set { this._protocolType = value; }
        }

        // Check to see if ProtocolType property is set
        internal bool IsSetProtocolType()
        {
            return this._protocolType != null;
        }

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        /// The stage of the API asset.
        /// </para>
        /// </summary>
        public string Stage
        {
            get { return this._stage; }
            set { this._stage = value; }
        }

        // Check to see if Stage property is set
        internal bool IsSetStage()
        {
            return this._stage != null;
        }

    }
}