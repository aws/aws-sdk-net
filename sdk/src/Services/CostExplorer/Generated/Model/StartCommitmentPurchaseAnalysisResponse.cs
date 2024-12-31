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
    /// This is the response object from the StartCommitmentPurchaseAnalysis operation.
    /// </summary>
    public partial class StartCommitmentPurchaseAnalysisResponse : AmazonWebServiceResponse
    {
        private string _analysisId;
        private string _analysisStartedTime;
        private string _estimatedCompletionTime;

        /// <summary>
        /// Gets and sets the property AnalysisId. 
        /// <para>
        /// The analysis ID that's associated with the commitment purchase analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string AnalysisId
        {
            get { return this._analysisId; }
            set { this._analysisId = value; }
        }

        // Check to see if AnalysisId property is set
        internal bool IsSetAnalysisId()
        {
            return this._analysisId != null;
        }

        /// <summary>
        /// Gets and sets the property AnalysisStartedTime. 
        /// <para>
        /// The start time of the analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=25)]
        public string AnalysisStartedTime
        {
            get { return this._analysisStartedTime; }
            set { this._analysisStartedTime = value; }
        }

        // Check to see if AnalysisStartedTime property is set
        internal bool IsSetAnalysisStartedTime()
        {
            return this._analysisStartedTime != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedCompletionTime. 
        /// <para>
        /// The estimated time for when the analysis will complete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=25)]
        public string EstimatedCompletionTime
        {
            get { return this._estimatedCompletionTime; }
            set { this._estimatedCompletionTime = value; }
        }

        // Check to see if EstimatedCompletionTime property is set
        internal bool IsSetEstimatedCompletionTime()
        {
            return this._estimatedCompletionTime != null;
        }

    }
}