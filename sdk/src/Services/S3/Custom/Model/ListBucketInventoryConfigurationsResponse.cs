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
    /// Returns information about the  ListInventoryConfigurationsResponse response and response metadata.
    /// </summary>
    public partial class ListBucketInventoryConfigurationsResponse : AmazonWebServiceResponse
    {
        private string token;
        private List<InventoryConfiguration> inventoryConfigurationList = AWSConfigs.InitializeCollections ? new List<InventoryConfiguration>() : null;
        private bool? isTruncated;
        private string nextToken;

        /// <summary>
        /// If sent in the request, the marker that is used as a starting point for this inventory configuration list response.
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
        /// The list of inventory configurations for a bucket.
        /// </summary>
        public List<InventoryConfiguration> InventoryConfigurationList
        {
            get { return this.inventoryConfigurationList; }
            set { this.inventoryConfigurationList = value; }
        }

        /// <summary>
        /// Check to see if InventoryConfigurationList property is set
        /// </summary>
        /// <returns></returns>
        public bool IsSetInventoryConfigurationList()
        {
            return this.inventoryConfigurationList != null && (this.inventoryConfigurationList.Count > 0 || !AWSConfigs.InitializeCollections);
        }

        /// <summary>
        /// Indicates whether the returned list of inventory configurations is truncated in this response. A value of true indicates that the list is truncated.
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
        /// The marker used to continue this inventory configuration listing. Use the NextContinuationToken from this response to continue the listing in a subsequent request. 
        /// The continuation token is an opaque value that Amazon S3 understands.
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
