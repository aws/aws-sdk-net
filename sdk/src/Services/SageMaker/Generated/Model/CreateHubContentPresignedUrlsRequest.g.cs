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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateHubContentPresignedUrls operation. Creates
    /// presigned URLs for accessing hub content artifacts. This operation generates time-limited,
    /// secure URLs that allow direct download of model artifacts and associated files from
    /// Amazon SageMaker hub content, including gated models that require end-user license
    /// agreement acceptance.
    /// </summary>
    public partial class CreateHubContentPresignedUrlsRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property AccessConfig. 
        /// <para>
        /// Configuration settings for accessing the hub content, including end-user license agreement
        /// acceptance for gated models and expected S3 URL validation.
        /// </para>
        /// </summary>
        public PresignedUrlAccessConfig AccessConfig { get; set; }

        /// <summary>
        /// Checks to see if the AccessConfig property is set.
        /// </summary>
        internal bool IsSetAccessConfig() => this.AccessConfig != null;

        /// <summary>
        /// Gets and sets the property HubContentName. 
        /// <para>
        /// The name of the hub content for which to generate presigned URLs. This identifies
        /// the specific model or content within the hub.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string HubContentName { get; set; }

        /// <summary>
        /// Checks to see if the HubContentName property is set.
        /// </summary>
        internal bool IsSetHubContentName() => this.HubContentName != null;

        /// <summary>
        /// Gets and sets the property HubContentType. 
        /// <para>
        /// The type of hub content to access. Valid values include <c>Model</c>, <c>Notebook</c>,
        /// and <c>ModelReference</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HubContentType HubContentType { get; set; }

        /// <summary>
        /// Checks to see if the HubContentType property is set.
        /// </summary>
        internal bool IsSetHubContentType() => this.HubContentType != null;

        /// <summary>
        /// Gets and sets the property HubContentVersion. 
        /// <para>
        /// The version of the hub content. If not specified, the latest version is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 14)]
        public string HubContentVersion { get; set; }

        /// <summary>
        /// Checks to see if the HubContentVersion property is set.
        /// </summary>
        internal bool IsSetHubContentVersion() => this.HubContentVersion != null;

        /// <summary>
        /// Gets and sets the property HubName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the hub that contains the content. For public
        /// content, use <c>SageMakerPublicHub</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string HubName { get; set; }

        /// <summary>
        /// Checks to see if the HubName property is set.
        /// </summary>
        internal bool IsSetHubName() => this.HubName != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of presigned URLs to return in the response. Default value is 100.
        /// Large models may contain hundreds of files, requiring pagination to retrieve all URLs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  A token for pagination. Use this token to retrieve the next set of presigned URLs
        /// when the response is truncated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
