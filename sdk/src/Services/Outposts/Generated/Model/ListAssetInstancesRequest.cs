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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Container for the parameters to the ListAssetInstances operation.
    /// A list of Amazon EC2 instances, belonging to all accounts, running on the specified
    /// Outpost. Does not include Amazon EBS or Amazon S3 instances.
    /// </summary>
    public partial class ListAssetInstancesRequest : AmazonOutpostsRequest
    {
        private List<string> _accountIdFilter = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _assetIdFilter = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _awsServiceFilter = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _instanceTypeFilter = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;
        private string _outpostIdentifier;

        /// <summary>
        /// Gets and sets the property AccountIdFilter. 
        /// <para>
        /// Filters the results by account ID.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AccountIdFilter
        {
            get { return this._accountIdFilter; }
            set { this._accountIdFilter = value; }
        }

        // Check to see if AccountIdFilter property is set
        internal bool IsSetAccountIdFilter()
        {
            return this._accountIdFilter != null && (this._accountIdFilter.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssetIdFilter. 
        /// <para>
        /// Filters the results by asset ID.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssetIdFilter
        {
            get { return this._assetIdFilter; }
            set { this._assetIdFilter = value; }
        }

        // Check to see if AssetIdFilter property is set
        internal bool IsSetAssetIdFilter()
        {
            return this._assetIdFilter != null && (this._assetIdFilter.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AwsServiceFilter. 
        /// <para>
        /// Filters the results by Amazon Web Services service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AwsServiceFilter
        {
            get { return this._awsServiceFilter; }
            set { this._awsServiceFilter = value; }
        }

        // Check to see if AwsServiceFilter property is set
        internal bool IsSetAwsServiceFilter()
        {
            return this._awsServiceFilter != null && (this._awsServiceFilter.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstanceTypeFilter. 
        /// <para>
        /// Filters the results by instance ID.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstanceTypeFilter
        {
            get { return this._instanceTypeFilter; }
            set { this._instanceTypeFilter = value; }
        }

        // Check to see if InstanceTypeFilter property is set
        internal bool IsSetInstanceTypeFilter()
        {
            return this._instanceTypeFilter != null && (this._instanceTypeFilter.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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

        /// <summary>
        /// Gets and sets the property OutpostIdentifier. 
        /// <para>
        /// The ID of the Outpost.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=180)]
        public string OutpostIdentifier
        {
            get { return this._outpostIdentifier; }
            set { this._outpostIdentifier = value; }
        }

        // Check to see if OutpostIdentifier property is set
        internal bool IsSetOutpostIdentifier()
        {
            return this._outpostIdentifier != null;
        }

    }
}