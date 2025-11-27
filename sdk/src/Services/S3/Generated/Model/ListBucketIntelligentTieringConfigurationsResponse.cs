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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// This is the response object from the ListBucketIntelligentTieringConfigurations operation.
    /// </summary>
    public partial class ListBucketIntelligentTieringConfigurationsResponse : AmazonWebServiceResponse
    {
        private string _continuationToken;
        private List<IntelligentTieringConfiguration> _intelligentTieringConfigurationList = AWSConfigs.InitializeCollections ? new List<IntelligentTieringConfiguration>() : null;
        private bool? _isTruncated;
        private string _nextContinuationToken;

        /// <summary>
        /// Gets and sets the property ContinuationToken. 
        /// <para>
        /// The <c>ContinuationToken</c> that represents a placeholder from where this request
        /// should begin.
        /// </para>
        /// </summary>
        public string ContinuationToken
        {
            get { return this._continuationToken; }
            set { this._continuationToken = value; }
        }

        // Check to see if ContinuationToken property is set
        internal bool IsSetContinuationToken()
        {
            return !string.IsNullOrEmpty(this._continuationToken);
        }

        /// <summary>
        /// Gets and sets the property IntelligentTieringConfigurationList. 
        /// <para>
        /// The list of S3 Intelligent-Tiering configurations for a bucket.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IntelligentTieringConfiguration> IntelligentTieringConfigurationList
        {
            get { return this._intelligentTieringConfigurationList; }
            set { this._intelligentTieringConfigurationList = value; }
        }

        // Check to see if IntelligentTieringConfigurationList property is set
        internal bool IsSetIntelligentTieringConfigurationList()
        {
            return this._intelligentTieringConfigurationList != null && (this._intelligentTieringConfigurationList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// Indicates whether the returned list of analytics configurations is complete. A value
        /// of <c>true</c> indicates that the list is not complete and the <c>NextContinuationToken</c>
        /// will be provided for a subsequent request.
        /// </para>
        /// </summary>
        public bool? IsTruncated
        {
            get { return this._isTruncated; }
            set { this._isTruncated = value; }
        }

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this._isTruncated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextContinuationToken. 
        /// <para>
        /// The marker used to continue this inventory configuration listing. Use the <c>NextContinuationToken</c>
        /// from this response to continue the listing in a subsequent request. The continuation
        /// token is an opaque value that Amazon S3 understands.
        /// </para>
        /// </summary>
        public string NextContinuationToken
        {
            get { return this._nextContinuationToken; }
            set { this._nextContinuationToken = value; }
        }

        // Check to see if NextContinuationToken property is set
        internal bool IsSetNextContinuationToken()
        {
            return !string.IsNullOrEmpty(this._nextContinuationToken);
        }

    }
}