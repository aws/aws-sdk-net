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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the GetNetworkInsightsAccessScopeAnalysisFindings operation.
    /// </summary>
    public partial class GetNetworkInsightsAccessScopeAnalysisFindingsResponse : AmazonWebServiceResponse
    {
        private List<AccessScopeAnalysisFinding> _analysisFindings = AWSConfigs.InitializeCollections ? new List<AccessScopeAnalysisFinding>() : null;
        private AnalysisStatus _analysisStatus;
        private string _networkInsightsAccessScopeAnalysisId;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AnalysisFindings. 
        /// <para>
        /// The findings associated with Network Access Scope Analysis.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AccessScopeAnalysisFinding> AnalysisFindings
        {
            get { return this._analysisFindings; }
            set { this._analysisFindings = value; }
        }

        // Check to see if AnalysisFindings property is set
        internal bool IsSetAnalysisFindings()
        {
            return this._analysisFindings != null && (this._analysisFindings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AnalysisStatus. 
        /// <para>
        /// The status of Network Access Scope Analysis.
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
        /// Gets and sets the property NetworkInsightsAccessScopeAnalysisId. 
        /// <para>
        /// The ID of the Network Access Scope analysis.
        /// </para>
        /// </summary>
        public string NetworkInsightsAccessScopeAnalysisId
        {
            get { return this._networkInsightsAccessScopeAnalysisId; }
            set { this._networkInsightsAccessScopeAnalysisId = value; }
        }

        // Check to see if NetworkInsightsAccessScopeAnalysisId property is set
        internal bool IsSetNetworkInsightsAccessScopeAnalysisId()
        {
            return this._networkInsightsAccessScopeAnalysisId != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to retrieve the next page of results. This value is <c>null</c> when
        /// there are no more results to return.
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
            return this._nextToken != null;
        }

    }
}