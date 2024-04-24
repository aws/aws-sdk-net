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
    /// The request details.
    /// </summary>
    public partial class ImportAssetFromApiGatewayApiRequestDetails
    {
        private string _apiDescription;
        private string _apiId;
        private string _apiKey;
        private string _apiName;
        private string _apiSpecificationMd5Hash;
        private string _dataSetId;
        private ProtocolType _protocolType;
        private string _revisionId;
        private string _stage;

        /// <summary>
        /// Gets and sets the property ApiDescription. 
        /// <para>
        /// The API description. Markdown supported.
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
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The API Gateway API ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The API Gateway API key.
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
        /// The API name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ApiSpecificationMd5Hash. 
        /// <para>
        /// The Base64-encoded MD5 hash of the OpenAPI 3.0 JSON API specification file. It is
        /// used to ensure the integrity of the file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=24, Max=24)]
        public string ApiSpecificationMd5Hash
        {
            get { return this._apiSpecificationMd5Hash; }
            set { this._apiSpecificationMd5Hash = value; }
        }

        // Check to see if ApiSpecificationMd5Hash property is set
        internal bool IsSetApiSpecificationMd5Hash()
        {
            return this._apiSpecificationMd5Hash != null;
        }

        /// <summary>
        /// Gets and sets the property DataSetId. 
        /// <para>
        /// The data set ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataSetId
        {
            get { return this._dataSetId; }
            set { this._dataSetId = value; }
        }

        // Check to see if DataSetId property is set
        internal bool IsSetDataSetId()
        {
            return this._dataSetId != null;
        }

        /// <summary>
        /// Gets and sets the property ProtocolType. 
        /// <para>
        /// The protocol type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// The revision ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RevisionId
        {
            get { return this._revisionId; }
            set { this._revisionId = value; }
        }

        // Check to see if RevisionId property is set
        internal bool IsSetRevisionId()
        {
            return this._revisionId != null;
        }

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        /// The API stage.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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