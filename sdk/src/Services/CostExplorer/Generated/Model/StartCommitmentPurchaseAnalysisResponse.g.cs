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
    /// This is the response object from the StartCommitmentPurchaseAnalysis operation.
    /// </summary>
    public partial class StartCommitmentPurchaseAnalysisResponse : AmazonWebServiceResponse
    {
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
