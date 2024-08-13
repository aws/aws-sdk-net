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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Returns information about the  ListBucketMetricsConfiguration response and response metadata.
    /// </summary>
    public partial class ListBucketMetricsConfigurationsResponse : AmazonWebServiceResponse
    {
        private string token;
        private List<MetricsConfiguration> metricsConfigurationList = AWSConfigs.InitializeCollections ? new List<MetricsConfiguration>() : null;
        private bool? isTruncated;
        private string nextToken;

        /// <summary>
        /// <para>
        /// The marker that is used to continue a metrics configuration listing that has been truncated. 
        /// Use the NextContinuationToken from a previously truncated list response to continue the listing. 
        /// The continuation token is an opaque value that Amazon S3 understands.
        /// </para>
        /// </summary>
        public string Token
        {
            get { return this.token; }
            set { this.token = value; }
        }

        // Check to see if Token property is set
        internal bool IsSetToken()
        {
            return !(string.IsNullOrEmpty(this.token));
        }

        /// <summary>
        /// The list of metrics configurations for a bucket.
        /// </summary>
        public List<MetricsConfiguration> MetricsConfigurationList
        {
            get { return this.metricsConfigurationList; }
            set { this.metricsConfigurationList = value; }
        }

        /// <summary>
        /// Check to see if MetricsConfigurationList property is set
        /// </summary>
        /// <returns></returns>
        public bool IsSetMetricsConfigurationList()
        {
            return this.metricsConfigurationList != null && (this.metricsConfigurationList.Count > 0 || !AWSConfigs.InitializeCollections);
        }

        /// <summary>
        /// <para>
        /// Indicates whether the returned list of metrics configurations is complete. 
        /// A value of true indicates that the list is not complete and the NextContinuationToken will be provided for 
        /// a subsequent request.
        /// </para>
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
        /// <para>
        /// The marker used to continue a metrics configuration listing that has been truncated. 
        /// Use the NextContinuationToken from a previously truncated list response to continue the listing. 
        /// The continuation token is an opaque value that Amazon S3 understands.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return !(string.IsNullOrEmpty(this.nextToken));
        }

    }
}
