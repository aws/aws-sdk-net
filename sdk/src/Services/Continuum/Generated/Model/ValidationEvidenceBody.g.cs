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

namespace Amazon.Continuum.Model
{
    /// <summary>
    /// Projected content for a VALIDATION_EVIDENCE artifact: the validation agent's durable
    /// proof of exploitability.
    /// </summary>
    public partial class ValidationEvidenceBody
    {
        /// <summary>
        /// Gets and sets the property AttackFlowsConfirmed. Identifiers of attack flows upgraded
        /// to Confirmed provenance.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<string> AttackFlowsConfirmed { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AttackFlowsConfirmed property is set.
        /// </summary>
        internal bool IsSetAttackFlowsConfirmed() => this.AttackFlowsConfirmed != null && (this.AttackFlowsConfirmed.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExecutedProof. Proof the agent produced by executing code
        /// against the repository under test, with the output that execution produced.
        /// </summary>
        public ValidationExecutedProof ExecutedProof { get; set; }

        /// <summary>
        /// Checks to see if the ExecutedProof property is set.
        /// </summary>
        internal bool IsSetExecutedProof() => this.ExecutedProof != null;

        /// <summary>
        /// Gets and sets the property ExploitArtifact. Concrete payload and its observed effect,
        /// when validation produced one by sending an HTTP request. Only an HTTP proof projects
        /// here. A validation agent that proves exploitability by RUNNING code against the repository
        /// projects `executedProof`, and one that proves it by reading the source projects `sourceAnalysis`.
        /// All three are mutually exclusive: at most one is present.
        /// </summary>
        public ValidationExploitArtifact ExploitArtifact { get; set; }

        /// <summary>
        /// Checks to see if the ExploitArtifact property is set.
        /// </summary>
        internal bool IsSetExploitArtifact() => this.ExploitArtifact != null;

        /// <summary>
        /// Gets and sets the property Exploitable. Exploitability verdict. Explicit UNCERTAIN
        /// replaces the producer's tri-state `exploitable: true | false | null`, so an absent
        /// verdict is never confused with a negative one.
        /// </summary>
        [AWSProperty(Required = true)]
        public ExploitabilityVerdict Exploitable { get; set; }

        /// <summary>
        /// Checks to see if the Exploitable property is set.
        /// </summary>
        internal bool IsSetExploitable() => this.Exploitable != null;

        /// <summary>
        /// Gets and sets the property FlowVerdicts. One verdict per attack flow assessed in the
        /// bundle.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<FlowVerdict> FlowVerdicts { get; set; } = AWSConfigs.InitializeCollections ? new List<FlowVerdict>() : null;

        /// <summary>
        /// Checks to see if the FlowVerdicts property is set.
        /// </summary>
        internal bool IsSetFlowVerdicts() => this.FlowVerdicts != null && (this.FlowVerdicts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PerFindingResults. Per-finding breakdown for a multi-finding
        /// bundle. Absent for a single-finding bundle.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<PerFindingResult> PerFindingResults { get; set; } = AWSConfigs.InitializeCollections ? new List<PerFindingResult>() : null;

        /// <summary>
        /// Checks to see if the PerFindingResults property is set.
        /// </summary>
        internal bool IsSetPerFindingResults() => this.PerFindingResults != null && (this.PerFindingResults.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceAnalysis. Proof the agent produced by reading the
        /// repository's source, with nothing built or run.
        /// </summary>
        public ValidationSourceAnalysis SourceAnalysis { get; set; }

        /// <summary>
        /// Checks to see if the SourceAnalysis property is set.
        /// </summary>
        internal bool IsSetSourceAnalysis() => this.SourceAnalysis != null;

        /// <summary>
        /// Gets and sets the property TerminalStatus. How the validation run ended. Absent when
        /// the producer reported a status with no mapping yet: the rest of the body still projects,
        /// so one unmapped enum never costs a customer the whole artifact.
        /// </summary>
        public ValidationTerminalStatus TerminalStatus { get; set; }

        /// <summary>
        /// Checks to see if the TerminalStatus property is set.
        /// </summary>
        internal bool IsSetTerminalStatus() => this.TerminalStatus != null;
    }
}
