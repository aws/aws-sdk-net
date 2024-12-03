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

namespace Amazon.S3.Model
{
    /// <summary>
    /// GetBucketMetadataTableConfiguration Response
    /// </summary>
    public partial class GetBucketMetadataTableConfigurationResponse : AmazonWebServiceResponse
    {
        private GetBucketMetadataTableConfigurationResult getBucketMetadataTableConfigurationResult;

        /// <summary>
        /// <para>
        /// The metadata table configuration for the general purpose bucket.
        /// </para>
        /// </summary>
        public GetBucketMetadataTableConfigurationResult GetBucketMetadataTableConfigurationResult
        {
            get { return this.getBucketMetadataTableConfigurationResult; }
            set { this.getBucketMetadataTableConfigurationResult = value; }
        }

    }
}

