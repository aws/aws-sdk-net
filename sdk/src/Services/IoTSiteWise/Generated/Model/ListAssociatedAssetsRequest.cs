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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the ListAssociatedAssets operation.
    /// Retrieves a paginated list of associated assets.
    /// 
    ///  
    /// <para>
    /// You can use this operation to do the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>CHILD</c> - List all child assets associated to the asset.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>PARENT</c> - List the asset's parent asset.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListAssociatedAssetsRequest : AmazonIoTSiteWiseRequest
    {
        private string _assetId;
        private string _hierarchyId;
        private int? _maxResults;
        private string _nextToken;
        private TraversalDirection _traversalDirection;

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The ID of the asset to query. This can be either the actual ID in UUID format, or
        /// else <c>externalId:</c> followed by the external ID, if it has one. For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-id-references">Referencing
        /// objects with external IDs</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=13, Max=139)]
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
        /// Gets and sets the property HierarchyId. 
        /// <para>
        /// (Optional) If you don't provide a <c>hierarchyId</c>, all the immediate assets in
        /// the <c>traversalDirection</c> will be returned. 
        /// </para>
        ///  
        /// <para>
        ///  The ID of the hierarchy by which child assets are associated to the asset. (This
        /// can be either the actual ID in UUID format, or else <c>externalId:</c> followed by
        /// the external ID, if it has one. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-id-references">Referencing
        /// objects with external IDs</a> in the <i>IoT SiteWise User Guide</i>.)
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/asset-hierarchies.html">Asset
        /// hierarchies</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=13, Max=139)]
        public string HierarchyId
        {
            get { return this._hierarchyId; }
            set { this._hierarchyId = value; }
        }

        // Check to see if HierarchyId property is set
        internal bool IsSetHierarchyId()
        {
            return this._hierarchyId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return for each paginated request.
        /// </para>
        ///  
        /// <para>
        /// Default: 50
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
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
        /// The token to be used for the next set of paginated results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
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
        /// Gets and sets the property TraversalDirection. 
        /// <para>
        /// The direction to list associated assets. Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CHILD</c> – The list includes all child assets associated to the asset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PARENT</c> – The list includes the asset's parent asset.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <c>CHILD</c> 
        /// </para>
        /// </summary>
        public TraversalDirection TraversalDirection
        {
            get { return this._traversalDirection; }
            set { this._traversalDirection = value; }
        }

        // Check to see if TraversalDirection property is set
        internal bool IsSetTraversalDirection()
        {
            return this._traversalDirection != null;
        }

    }
}