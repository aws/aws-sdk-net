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
    /// This is the response object from the GetCommitmentPurchaseAnalysis operation.
    /// </summary>
    public partial class GetCommitmentPurchaseAnalysisResponse : AmazonWebServiceResponse
    {
        private string _analysisCompletionTime;
        private AnalysisDetails _analysisDetails;
        private string _analysisId;
        private string _analysisStartedTime;
        private AnalysisStatus _analysisStatus;
        private CommitmentPurchaseAnalysisConfiguration _commitmentPurchaseAnalysisConfiguration;
        private ErrorCode _errorCode;
        private string _estimatedCompletionTime;

        /// <summary>
        /// Gets and sets the property AnalysisCompletionTime. 
        /// <para>
        /// The completion time of the analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=25)]
        public string AnalysisCompletionTime
        {
            get { return this._analysisCompletionTime; }
            set { this._analysisCompletionTime = value; }
        }

        // Check to see if AnalysisCompletionTime property is set
        internal bool IsSetAnalysisCompletionTime()
        {
            return this._analysisCompletionTime != null;
        }

        /// <summary>
        /// Gets and sets the property AnalysisDetails. 
        /// <para>
        /// Details about the analysis.
        /// </para>
        /// </summary>
        public AnalysisDetails AnalysisDetails
        {
            get { return this._analysisDetails; }
            set { this._analysisDetails = value; }
        }

        // Check to see if AnalysisDetails property is set
        internal bool IsSetAnalysisDetails()
        {
            return this._analysisDetails != null;
        }

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
        /// Gets and sets the property AnalysisStatus. 
        /// <para>
        /// The status of the analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property CommitmentPurchaseAnalysisConfiguration. 
        /// <para>
        /// The configuration for the commitment purchase analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CommitmentPurchaseAnalysisConfiguration CommitmentPurchaseAnalysisConfiguration
        {
            get { return this._commitmentPurchaseAnalysisConfiguration; }
            set { this._commitmentPurchaseAnalysisConfiguration = value; }
        }

        // Check to see if CommitmentPurchaseAnalysisConfiguration property is set
        internal bool IsSetCommitmentPurchaseAnalysisConfiguration()
        {
            return this._commitmentPurchaseAnalysisConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code used for the analysis.
        /// </para>
        /// </summary>
        public ErrorCode ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
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