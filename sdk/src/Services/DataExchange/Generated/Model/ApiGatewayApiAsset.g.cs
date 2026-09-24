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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ApiDescription. 
        /// <para>
        /// The API description of the API asset.
        /// </para>
        /// </summary>
        public string ApiDescription { get; set; }

        /// <summary>
        /// Checks to see if the ApiDescription property is set.
        /// </summary>
        internal bool IsSetApiDescription() => this.ApiDescription != null;

        /// <summary>
        /// Gets and sets the property ApiEndpoint. 
        /// <para>
        /// The API endpoint of the API asset.
        /// </para>
        /// </summary>
        public string ApiEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ApiEndpoint property is set.
        /// </summary>
        internal bool IsSetApiEndpoint() => this.ApiEndpoint != null;

        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The unique identifier of the API asset.
        /// </para>
        /// </summary>
        public string ApiId { get; set; }

        /// <summary>
        /// Checks to see if the ApiId property is set.
        /// </summary>
        internal bool IsSetApiId() => this.ApiId != null;

        /// <summary>
        /// Gets and sets the property ApiKey. 
        /// <para>
        /// The API key of the API asset.
        /// </para>
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Checks to see if the ApiKey property is set.
        /// </summary>
        internal bool IsSetApiKey() => this.ApiKey != null;

        /// <summary>
        /// Gets and sets the property ApiName. 
        /// <para>
        /// The API name of the API asset.
        /// </para>
        /// </summary>
        public string ApiName { get; set; }

        /// <summary>
        /// Checks to see if the ApiName property is set.
        /// </summary>
        internal bool IsSetApiName() => this.ApiName != null;

        /// <summary>
        /// Gets and sets the property ApiSpecificationDownloadUrl. 
        /// <para>
        /// The download URL of the API specification of the API asset.
        /// </para>
        /// </summary>
        public string ApiSpecificationDownloadUrl { get; set; }

        /// <summary>
        /// Checks to see if the ApiSpecificationDownloadUrl property is set.
        /// </summary>
        internal bool IsSetApiSpecificationDownloadUrl() => this.ApiSpecificationDownloadUrl != null;

        /// <summary>
        /// Gets and sets the property ApiSpecificationDownloadUrlExpiresAt. 
        /// <para>
        /// The date and time that the upload URL expires, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? ApiSpecificationDownloadUrlExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ApiSpecificationDownloadUrlExpiresAt property is set.
        /// </summary>
        internal bool IsSetApiSpecificationDownloadUrlExpiresAt() => this.ApiSpecificationDownloadUrlExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property ProtocolType. 
        /// <para>
        /// The protocol type of the API asset.
        /// </para>
        /// </summary>
        public ProtocolType ProtocolType { get; set; }

        /// <summary>
        /// Checks to see if the ProtocolType property is set.
        /// </summary>
        internal bool IsSetProtocolType() => this.ProtocolType != null;

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        /// The stage of the API asset.
        /// </para>
        /// </summary>
        public string Stage { get; set; }

        /// <summary>
        /// Checks to see if the Stage property is set.
        /// </summary>
        internal bool IsSetStage() => this.Stage != null;
    }
}
