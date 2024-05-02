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
    /// Returns information about the  ListBucketAnalyticsConfigurationsResponse response and response metadata.
    /// </summary>
    public partial class ListBucketAnalyticsConfigurationsResponse : AmazonWebServiceResponse
    {
        private string token;
        private List<AnalyticsConfiguration> analyticsConfigurationList = AWSConfigs.InitializeCollections ? new List<AnalyticsConfiguration>() : null;
        private bool? isTruncated;
        private string nextToken;

        /// <summary>
        /// The ContinuationToken that represents where this request began.
        /// </summary>
        public string ContinuationToken
        {
            get { return this.token; }
            set { this.token = value; }
        }

        // Check to see if ContinuationToken property is set
        internal bool IsSetToken()
        {
            return !(string.IsNullOrEmpty(this.token));
        }

        /// <summary>
        /// The list of analytics configurations for a bucket.
        /// </summary>
        public List<AnalyticsConfiguration> AnalyticsConfigurationList
        {
            get { return this.analyticsConfigurationList; }
            set { this.analyticsConfigurationList = value; }
        }

        /// <summary>
        /// Check to see if AnalyticsConfigurationList property is set
        /// </summary>
        /// <returns></returns>
        public bool IsSetAnalyticsConfigurationList()
        {
            return this.analyticsConfigurationList != null && (this.analyticsConfigurationList.Count > 0 || !AWSConfigs.InitializeCollections);
        }

        /// <summary>
        /// Indicates whether the returned list of analytics configurations is complete. 
        /// A value of true indicates that the list is not complete and the NextContinuationToken will be provided for a subsequent request.
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
        /// NextContinuationToken is sent when isTruncated is true, which indicates that there are more analytics configurations to list. 
        /// The next request must include this NextContinuationToken. The token is obfuscated and is not a usable value.
        /// </summary>
        public string NextContinuationToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        // Check to see if NextContinuationToken property is set
        internal bool IsSetNextToken()
        {
            return !(string.IsNullOrEmpty(this.nextToken));
        }
    }
}
