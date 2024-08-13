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
using Amazon.Runtime;
using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Response for the ListBucketIntelligentTieringConfigurations operation.
    /// </summary>
    public partial class ListBucketIntelligentTieringConfigurationsResponse : AmazonWebServiceResponse
	{
		private string continuationToken;
		private List<IntelligentTieringConfiguration> intelligentTieringConfigurationList = AWSConfigs.InitializeCollections ? new List<IntelligentTieringConfiguration>() : null;
        private bool? isTruncated;
		private string nextContinuationToken;

        /// <summary>
        /// <para>The ContinuationToken that represents a placeholder from where this request should begin.</para>
        /// </summary>
        public string ContinuationToken
        {
            get { return this.continuationToken; }
            set { this.continuationToken = value; }
        }

        // Check to see if Token property is set
        internal bool IsSetToken()
        {
            return !(string.IsNullOrEmpty(this.continuationToken));
        }

        /// <summary>
        /// <para>The list of S3 Intelligent-Tiering configurations for a bucket.</para>
        /// </summary>
        public List<IntelligentTieringConfiguration> IntelligentTieringConfigurationList
        {
            get { return this.intelligentTieringConfigurationList; }
            set { this.intelligentTieringConfigurationList = value; }
        }

        /// <summary>
        /// Check to see if IntelligentTieringConfiguration property is set
        /// </summary>
        public bool IsSetIntelligentTieringConfigurationList()
        {
            return this.intelligentTieringConfigurationList != null && (this.intelligentTieringConfigurationList.Count > 0 || !AWSConfigs.InitializeCollections);
        }

        /// <summary>
        /// <para>Indicates whether the returned list of analytics configurations is complete. 
        /// A value of true indicates that the list is not complete and the 
        /// NextContinuationToken will be provided for a subsequent request.</para>
        /// </summary>
        public bool? IsTruncated
        {
            get { return this.isTruncated; }
            set { this.isTruncated = value; }
        }

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this.isTruncated.HasValue;
        }

        /// <summary>
        /// <para>The marker used to continue this inventory configuration listing. 
        /// Use the <code>NextContinuationToken</code> from this response to 
        /// continue the listing in a subsequent request. 
        /// The continuation token is an opaque value that Amazon S3 understands.</para>
        /// </summary>
        public string NextContinuationToken
        {
            get { return this.nextContinuationToken; }
            set { this.nextContinuationToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return !(string.IsNullOrEmpty(this.nextContinuationToken));
        }
    }
}
