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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AnalysisCompletionTime. 
        /// <para>
        /// The completion time of the analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 25)]
        public string AnalysisCompletionTime { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisCompletionTime property is set.
        /// </summary>
        internal bool IsSetAnalysisCompletionTime() => this.AnalysisCompletionTime != null;

        /// <summary>
        /// Gets and sets the property AnalysisDetails. 
        /// <para>
        /// Details about the analysis.
        /// </para>
        /// </summary>
        public AnalysisDetails AnalysisDetails { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisDetails property is set.
        /// </summary>
        internal bool IsSetAnalysisDetails() => this.AnalysisDetails != null;

        /// <summary>
        /// Gets and sets the property AnalysisId. 
        /// <para>
        /// The analysis ID that's associated with the commitment purchase analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string AnalysisId { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisId property is set.
        /// </summary>
        internal bool IsSetAnalysisId() => this.AnalysisId != null;

        /// <summary>
        /// Gets and sets the property AnalysisStartedTime. 
        /// <para>
        /// The start time of the analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 25)]
        public string AnalysisStartedTime { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisStartedTime property is set.
        /// </summary>
        internal bool IsSetAnalysisStartedTime() => this.AnalysisStartedTime != null;

        /// <summary>
        /// Gets and sets the property AnalysisStatus. 
        /// <para>
        /// The status of the analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AnalysisStatus AnalysisStatus { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisStatus property is set.
        /// </summary>
        internal bool IsSetAnalysisStatus() => this.AnalysisStatus != null;

        /// <summary>
        /// Gets and sets the property CommitmentPurchaseAnalysisConfiguration. 
        /// <para>
        /// The configuration for the commitment purchase analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CommitmentPurchaseAnalysisConfiguration CommitmentPurchaseAnalysisConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CommitmentPurchaseAnalysisConfiguration property is set.
        /// </summary>
        internal bool IsSetCommitmentPurchaseAnalysisConfiguration() => this.CommitmentPurchaseAnalysisConfiguration != null;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code used for the analysis.
        /// </para>
        /// </summary>
        public ErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property EstimatedCompletionTime. 
        /// <para>
        /// The estimated time for when the analysis will complete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 25)]
        public string EstimatedCompletionTime { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedCompletionTime property is set.
        /// </summary>
        internal bool IsSetEstimatedCompletionTime() => this.EstimatedCompletionTime != null;
    }
}
