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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the ListAssetRelationships operation.
    /// Retrieves a paginated list of asset relationships for an asset. You can use this operation
    /// to identify an asset's root asset and all associated assets between that asset and
    /// its root.
    /// </summary>
    public partial class ListAssetRelationshipsRequest : AmazonIoTSiteWiseRequest
    {
        private string _assetId;
        private int? _maxResults;
        private string _nextToken;
        private TraversalType _traversalType;

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The ID of the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string AssetId
        {
            get { return this._assetId; }
            set { this._assetId = value; }
        }

        // Check to see if AssetId property is set
        internal bool IsSetAssetId()
        {
            return this._assetId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to be returned per paginated request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// The token to be used for the next set of paginated results.
        /// </para>
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
        /// Gets and sets the property TraversalType. 
        /// <para>
        /// The type of traversal to use to identify asset relationships. Choose the following
        /// option:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>PATH_TO_ROOT</code> – Identify the asset's parent assets up to the root asset.
        /// The asset that you specify in <code>assetId</code> is the first result in the list
        /// of <code>assetRelationshipSummaries</code>, and the root asset is the last result.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public TraversalType TraversalType
        {
            get { return this._traversalType; }
            set { this._traversalType = value; }
        }

        // Check to see if TraversalType property is set
        internal bool IsSetTraversalType()
        {
            return this._traversalType != null;
        }

    }
}