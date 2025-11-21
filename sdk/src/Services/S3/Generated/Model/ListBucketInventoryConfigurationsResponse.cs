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
    /// This is the response object from the ListBucketInventoryConfigurations operation.
    /// </summary>
    public partial class ListBucketInventoryConfigurationsResponse : AmazonWebServiceResponse
    {
        private List<InventoryConfiguration> _inventoryConfigurationList = AWSConfigs.InitializeCollections ? new List<InventoryConfiguration>() : null;
        private bool? _isTruncated;
        private string _nextToken;
        private string _token;

        /// <summary>
        /// Gets and sets the property InventoryConfigurationList. 
        /// <para>
        /// The list of inventory configurations for a bucket.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InventoryConfiguration> InventoryConfigurationList
        {
            get { return this._inventoryConfigurationList; }
            set { this._inventoryConfigurationList = value; }
        }

        // Check to see if InventoryConfigurationList property is set
        internal bool IsSetInventoryConfigurationList()
        {
            return this._inventoryConfigurationList != null && (this._inventoryConfigurationList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// Tells whether the returned list of inventory configurations is complete. A value of
        /// true indicates that the list is not complete and the NextContinuationToken is provided
        /// for a subsequent request.
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The marker used to continue this inventory configuration listing. Use the <c>NextContinuationToken</c>
        /// from this response to continue the listing in a subsequent request. The continuation
        /// token is an opaque value that Amazon S3 understands.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return !String.IsNullOrEmpty(this._nextToken);
        }

        /// <summary>
        /// Gets and sets the property Token. 
        /// <para>
        /// If sent in the request, the marker that is used as a starting point for this inventory
        /// configuration list response.
        /// </para>
        /// </summary>
        public string Token
        {
            get { return this._token; }
            set { this._token = value; }
        }

        // Check to see if Token property is set
        internal bool IsSetToken()
        {
            return !String.IsNullOrEmpty(this._token);
        }

    }
}