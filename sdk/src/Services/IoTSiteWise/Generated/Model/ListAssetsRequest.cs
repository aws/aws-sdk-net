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
    /// Container for the parameters to the ListAssets operation.
    /// Retrieves a paginated list of asset summaries.
    /// 
    ///  
    /// <para>
    /// You can use this operation to do the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// List assets based on a specific asset model.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// List top-level assets.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can't use this operation to list all assets. To retrieve summaries for all of
    /// your assets, use <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_ListAssetModels.html">ListAssetModels</a>
    /// to get all of your asset model IDs. Then, use ListAssets to get all assets for each
    /// asset model.
    /// </para>
    /// </summary>
    public partial class ListAssetsRequest : AmazonIoTSiteWiseRequest
    {
        private string _assetModelId;
        private ListAssetsFilter _filter;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AssetModelId. 
        /// <para>
        /// The ID of the asset model by which to filter the list of assets. This parameter is
        /// required if you choose <code>ALL</code> for <code>filter</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string AssetModelId
        {
            get { return this._assetModelId; }
            set { this._assetModelId = value; }
        }

        // Check to see if AssetModelId property is set
        internal bool IsSetAssetModelId()
        {
            return this._assetModelId != null;
        }

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// The filter for the requested list of assets. Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ALL</code> – The list includes all assets for a given asset model ID. The <code>assetModelId</code>
        /// parameter is required if you filter by <code>ALL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TOP_LEVEL</code> – The list includes only top-level assets in the asset hierarchy
        /// tree.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <code>ALL</code> 
        /// </para>
        /// </summary>
        public ListAssetsFilter Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to be returned per paginated request.
        /// </para>
        ///  
        /// <para>
        /// Default: 50
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

    }
}