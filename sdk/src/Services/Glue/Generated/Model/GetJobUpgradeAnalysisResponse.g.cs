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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the GetJobUpgradeAnalysis operation.
    /// </summary>
    public partial class GetJobUpgradeAnalysisResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AnalysisId. 
        /// <para>
        /// The unique identifier of the upgrade analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 39, Max = 39)]
        public string AnalysisId { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisId property is set.
        /// </summary>
        internal bool IsSetAnalysisId() => this.AnalysisId != null;

        /// <summary>
        /// Gets and sets the property AnalysisType. 
        /// <para>
        /// The type of upgrade analysis. For auto-upgrade jobs, this value is <c>AUTO_UPGRADE</c>.
        /// </para>
        /// </summary>
        public AnalysisType AnalysisType { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisType property is set.
        /// </summary>
        internal bool IsSetAnalysisType() => this.AnalysisType != null;

        /// <summary>
        /// Gets and sets the property AutoUpgradeEligibilitySummary. 
        /// <para>
        /// The Amazon S3 URI of the consent report summarizing upgrade assessment findings. Populated
        /// when the analysis reaches <c>WAITING_FOR_CONSENT</c> and remains available in all
        /// subsequent states.
        /// </para>
        /// </summary>
        public string AutoUpgradeEligibilitySummary { get; set; }

        /// <summary>
        /// Checks to see if the AutoUpgradeEligibilitySummary property is set.
        /// </summary>
        internal bool IsSetAutoUpgradeEligibilitySummary() => this.AutoUpgradeEligibilitySummary != null;

        /// <summary>
        /// Gets and sets the property AutoUpgradeEvaluationSummary. 
        /// <para>
        /// The Amazon S3 URI of the terminal-state evaluation summary, available once the analysis
        /// reaches a terminal status (<c>SUCCEEDED</c> or <c>FAILED</c>).
        /// </para>
        /// </summary>
        public string AutoUpgradeEvaluationSummary { get; set; }

        /// <summary>
        /// Checks to see if the AutoUpgradeEvaluationSummary property is set.
        /// </summary>
        internal bool IsSetAutoUpgradeEvaluationSummary() => this.AutoUpgradeEvaluationSummary != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The reason the analysis did not complete.
        /// </para>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the job associated with this analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property SourceVersion. 
        /// <para>
        /// The Glue version the job was running before the upgrade, for example <c>4.0</c>.
        /// </para>
        /// </summary>
        public string SourceVersion { get; set; }

        /// <summary>
        /// Checks to see if the SourceVersion property is set.
        /// </summary>
        internal bool IsSetSourceVersion() => this.SourceVersion != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetVersion. 
        /// <para>
        /// The Glue version the job will be upgraded to, for example <c>6.0</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetVersion { get; set; }

        /// <summary>
        /// Checks to see if the TargetVersion property is set.
        /// </summary>
        internal bool IsSetTargetVersion() => this.TargetVersion != null;
    }
}
