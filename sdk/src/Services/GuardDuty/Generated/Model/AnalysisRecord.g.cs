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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains an assessment that GuardDuty derived from the data during an investigation,
    /// such as a threat assessment, a comparison against normal behavior, or a process lineage.
    /// The record contains at most one of the payload members, the one that corresponds to
    /// <c>AnalysisType</c>. <c>Indicators</c> can accompany any analysis type.
    /// </summary>
    public partial class AnalysisRecord
    {
        /// <summary>
        /// Gets and sets the property AccountAnalysis. 
        /// <para>
        /// An analysis of the findings in an account over time. Set when <c>AnalysisType</c>
        /// is <c>TREND</c> or <c>BASELINE</c>.
        /// </para>
        /// </summary>
        public InvestigationAccountAnalysis AccountAnalysis { get; set; }

        /// <summary>
        /// Checks to see if the AccountAnalysis property is set.
        /// </summary>
        internal bool IsSetAccountAnalysis() => this.AccountAnalysis != null;

        /// <summary>
        /// Gets and sets the property AnalysisType. 
        /// <para>
        /// The kind of analysis. The value identifies the payload member that can be set: <c>REPUTATION</c>,
        /// <c>THREAT_ASSESSMENT</c>, and <c>RDS_THREAT_ASSESSMENT</c> (<c>ThreatAssessment</c>);
        /// <c>KUBERNETES_POLICY_VIOLATION</c> (<c>KubernetesPolicyViolation</c>); <c>S3_EXPOSURE</c>,
        /// <c>S3_ACTOR_CONTEXT</c>, and <c>S3_PEN_TEST</c> (<c>S3Analysis</c>); <c>PROCESS_LINEAGE</c>
        /// (<c>Processes</c>); and <c>TREND</c> and <c>BASELINE</c> (<c>AccountAnalysis</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AnalysisType AnalysisType { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisType property is set.
        /// </summary>
        internal bool IsSetAnalysisType() => this.AnalysisType != null;

        /// <summary>
        /// Gets and sets the property Indicators. 
        /// <para>
        /// The threat indicators associated with the analysis, such as an IP address, a domain,
        /// or a file hash.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<InvestigationIndicator> Indicators { get; set; } = AWSConfigs.InitializeCollections ? new List<InvestigationIndicator>() : null;

        /// <summary>
        /// Checks to see if the Indicators property is set.
        /// </summary>
        internal bool IsSetIndicators() => this.Indicators != null && (this.Indicators.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KubernetesPolicyViolation. 
        /// <para>
        /// An assessment of a Kubernetes policy violation. Set when <c>AnalysisType</c> is <c>KUBERNETES_POLICY_VIOLATION</c>.
        /// </para>
        /// </summary>
        public KubernetesPolicyViolation KubernetesPolicyViolation { get; set; }

        /// <summary>
        /// Checks to see if the KubernetesPolicyViolation property is set.
        /// </summary>
        internal bool IsSetKubernetesPolicyViolation() => this.KubernetesPolicyViolation != null;

        /// <summary>
        /// Gets and sets the property Processes. 
        /// <para>
        /// The processes in a process lineage. Set when <c>AnalysisType</c> is <c>PROCESS_LINEAGE</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<Process> Processes { get; set; } = AWSConfigs.InitializeCollections ? new List<Process>() : null;

        /// <summary>
        /// Checks to see if the Processes property is set.
        /// </summary>
        internal bool IsSetProcesses() => this.Processes != null && (this.Processes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property S3Analysis. 
        /// <para>
        /// An analysis of Amazon S3 activity or exposure. Set when <c>AnalysisType</c> is <c>S3_EXPOSURE</c>,
        /// <c>S3_ACTOR_CONTEXT</c>, or <c>S3_PEN_TEST</c>.
        /// </para>
        /// </summary>
        public S3Analysis S3Analysis { get; set; }

        /// <summary>
        /// Checks to see if the S3Analysis property is set.
        /// </summary>
        internal bool IsSetS3Analysis() => this.S3Analysis != null;

        /// <summary>
        /// Gets and sets the property ThreatAssessment. 
        /// <para>
        /// A threat assessment. Set when <c>AnalysisType</c> is <c>REPUTATION</c>, <c>THREAT_ASSESSMENT</c>,
        /// or <c>RDS_THREAT_ASSESSMENT</c>.
        /// </para>
        /// </summary>
        public InvestigationThreatAssessment ThreatAssessment { get; set; }

        /// <summary>
        /// Checks to see if the ThreatAssessment property is set.
        /// </summary>
        internal bool IsSetThreatAssessment() => this.ThreatAssessment != null;
    }
}
