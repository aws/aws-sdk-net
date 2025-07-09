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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
    /// Container for the parameters to the CreateHubContentPresignedUrls operation.
    /// Creates presigned URLs for accessing hub content artifacts. This operation generates
    /// time-limited, secure URLs that allow direct download of model artifacts and associated
    /// files from Amazon SageMaker hub content, including gated models that require end-user
    /// license agreement acceptance.
    /// </summary>
    public partial class CreateHubContentPresignedUrlsRequest : AmazonSageMakerRequest
    {
        private PresignedUrlAccessConfig _accessConfig;
        private string _hubContentName;
        private HubContentType _hubContentType;
        private string _hubContentVersion;
        private string _hubName;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AccessConfig. 
        /// <para>
        /// Configuration settings for accessing the hub content, including end-user license agreement
        /// acceptance for gated models and expected S3 URL validation.
        /// </para>
        /// </summary>
        public PresignedUrlAccessConfig AccessConfig
        {
            get { return this._accessConfig; }
            set { this._accessConfig = value; }
        }

        // Check to see if AccessConfig property is set
        internal bool IsSetAccessConfig()
        {
            return this._accessConfig != null;
        }

        /// <summary>
        /// Gets and sets the property HubContentName. 
        /// <para>
        /// The name of the hub content for which to generate presigned URLs. This identifies
        /// the specific model or content within the hub.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string HubContentName
        {
            get { return this._hubContentName; }
            set { this._hubContentName = value; }
        }

        // Check to see if HubContentName property is set
        internal bool IsSetHubContentName()
        {
            return this._hubContentName != null;
        }

        /// <summary>
        /// Gets and sets the property HubContentType. 
        /// <para>
        /// The type of hub content to access. Valid values include <c>Model</c>, <c>Notebook</c>,
        /// and <c>ModelReference</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HubContentType HubContentType
        {
            get { return this._hubContentType; }
            set { this._hubContentType = value; }
        }

        // Check to see if HubContentType property is set
        internal bool IsSetHubContentType()
        {
            return this._hubContentType != null;
        }

        /// <summary>
        /// Gets and sets the property HubContentVersion. 
        /// <para>
        /// The version of the hub content. If not specified, the latest version is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=14)]
        public string HubContentVersion
        {
            get { return this._hubContentVersion; }
            set { this._hubContentVersion = value; }
        }

        // Check to see if HubContentVersion property is set
        internal bool IsSetHubContentVersion()
        {
            return this._hubContentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property HubName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the hub that contains the content. For public
        /// content, use <c>SageMakerPublicHub</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string HubName
        {
            get { return this._hubName; }
            set { this._hubName = value; }
        }

        // Check to see if HubName property is set
        internal bool IsSetHubName()
        {
            return this._hubName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of presigned URLs to return in the response. Default value is 100.
        /// Large models may contain hundreds of files, requiring pagination to retrieve all URLs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  A token for pagination. Use this token to retrieve the next set of presigned URLs
        /// when the response is truncated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}