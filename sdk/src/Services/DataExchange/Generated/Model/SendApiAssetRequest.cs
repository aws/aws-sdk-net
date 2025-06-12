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
    /// Container for the parameters to the SendApiAsset operation.
    /// This operation invokes an API Gateway API asset. The request is proxied to the provider’s
    /// API Gateway API.
    /// </summary>
    public partial class SendApiAssetRequest : AmazonDataExchangeRequest
    {
        private string _assetId;
        private string _body;
        private string _dataSetId;
        private string _method;
        private string _path;
        private Dictionary<string, string> _queryStringParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _requestHeaders = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _revisionId;

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// Asset ID value for the API request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AssetId
        {
            get { return this._assetId; }
            set { this._assetId = value; }
        }

        // Check to see if AssetId property is set
        internal bool IsSetAssetId()
        {
            return this._assetId != null;
        }

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The request body.
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
        /// Gets and sets the property DataSetId. 
        /// <para>
        /// Data set ID value for the API request.
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
        /// Gets and sets the property Method. 
        /// <para>
        /// HTTP method value for the API request. Alternatively, you can use the appropriate
        /// verb in your request.
        /// </para>
        /// </summary>
        public string Method
        {
            get { return this._method; }
            set { this._method = value; }
        }

        // Check to see if Method property is set
        internal bool IsSetMethod()
        {
            return this._method != null;
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// URI path value for the API request. Alternatively, you can set the URI path directly
        /// by invoking /v1/{pathValue}.
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property QueryStringParameters. 
        /// <para>
        /// Attach query string parameters to the end of the URI (for example, /v1/examplePath?exampleParam=exampleValue).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> QueryStringParameters
        {
            get { return this._queryStringParameters; }
            set { this._queryStringParameters = value; }
        }

        // Check to see if QueryStringParameters property is set
        internal bool IsSetQueryStringParameters()
        {
            return this._queryStringParameters != null && (this._queryStringParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RequestHeaders. 
        /// <para>
        /// Any header value prefixed with x-amzn-dataexchange-header- will have that stripped
        /// before sending the Asset API request. Use this when you want to override a header
        /// that AWS Data Exchange uses. Alternatively, you can use the header without a prefix
        /// to the HTTP request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> RequestHeaders
        {
            get { return this._requestHeaders; }
            set { this._requestHeaders = value; }
        }

        // Check to see if RequestHeaders property is set
        internal bool IsSetRequestHeaders()
        {
            return this._requestHeaders != null && (this._requestHeaders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// Revision ID value for the API request.
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

    }
}