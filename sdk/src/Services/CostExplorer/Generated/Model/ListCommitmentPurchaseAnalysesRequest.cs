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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the ListCommitmentPurchaseAnalyses operation.
    /// Lists the commitment purchase analyses for your account.
    /// </summary>
    public partial class ListCommitmentPurchaseAnalysesRequest : AmazonCostExplorerRequest
    {
        private List<string> _analysisIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AnalysisStatus _analysisStatus;
        private string _nextPageToken;
        private int? _pageSize;

        /// <summary>
        /// Gets and sets the property AnalysisIds. 
        /// <para>
        /// The analysis IDs associated with the commitment purchase analyses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=600)]
        public List<string> AnalysisIds
        {
            get { return this._analysisIds; }
            set { this._analysisIds = value; }
        }

        // Check to see if AnalysisIds property is set
        internal bool IsSetAnalysisIds()
        {
            return this._analysisIds != null && (this._analysisIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AnalysisStatus. 
        /// <para>
        /// The status of the analysis.
        /// </para>
        /// </summary>
        public AnalysisStatus AnalysisStatus
        {
            get { return this._analysisStatus; }
            set { this._analysisStatus = value; }
        }

        // Check to see if AnalysisStatus property is set
        internal bool IsSetAnalysisStatus()
        {
            return this._analysisStatus != null;
        }

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token to retrieve the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The number of analyses that you want returned in a single response object.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? PageSize
        {
            get { return this._pageSize; }
            set { this._pageSize = value; }
        }

        // Check to see if PageSize property is set
        internal bool IsSetPageSize()
        {
            return this._pageSize.HasValue; 
        }

    }
}