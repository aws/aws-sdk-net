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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateThreat operation. Updates a threat.
    /// </summary>
    public partial class UpdateThreatRequest : AmazonSecurityAgentRequest
    {
        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier of the agent space.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentSpaceId { get; set; }

        /// <summary>
        /// Checks to see if the AgentSpaceId property is set.
        /// </summary>
        internal bool IsSetAgentSpaceId() => this.AgentSpaceId != null;

        /// <summary>
        /// Gets and sets the property Anchor. 
        /// <para>
        /// The updated DFD element this threat is anchored to.
        /// </para>
        /// </summary>
        public ThreatAnchorShape Anchor { get; set; }

        /// <summary>
        /// Checks to see if the Anchor property is set.
        /// </summary>
        internal bool IsSetAnchor() => this.Anchor != null;

        /// <summary>
        /// Gets and sets the property Comments. 
        /// <para>
        /// Optional customer comment.
        /// </para>
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// Checks to see if the Comments property is set.
        /// </summary>
        internal bool IsSetComments() => this.Comments != null;

        /// <summary>
        /// Gets and sets the property Evidence. 
        /// <para>
        /// The updated source code files supporting the threat.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ThreatEvidenceShape> Evidence { get; set; } = AWSConfigs.InitializeCollections ? new List<ThreatEvidenceShape>() : null;

        /// <summary>
        /// Checks to see if the Evidence property is set.
        /// </summary>
        internal bool IsSetEvidence() => this.Evidence != null && (this.Evidence.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ImpactedAssets. 
        /// <para>
        /// The updated list of specific assets affected by the threat.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ImpactedAssets { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ImpactedAssets property is set.
        /// </summary>
        internal bool IsSetImpactedAssets() => this.ImpactedAssets != null && (this.ImpactedAssets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ImpactedGoal. 
        /// <para>
        /// The updated security goals affected by the threat.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ImpactedGoal { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ImpactedGoal property is set.
        /// </summary>
        internal bool IsSetImpactedGoal() => this.ImpactedGoal != null && (this.ImpactedGoal.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Prerequisites. 
        /// <para>
        /// The updated conditions required for the threat to be exploitable.
        /// </para>
        /// </summary>
        public string Prerequisites { get; set; }

        /// <summary>
        /// Checks to see if the Prerequisites property is set.
        /// </summary>
        internal bool IsSetPrerequisites() => this.Prerequisites != null;

        /// <summary>
        /// Gets and sets the property Recommendation. 
        /// <para>
        /// The updated recommended mitigation guidance for this threat.
        /// </para>
        /// </summary>
        public string Recommendation { get; set; }

        /// <summary>
        /// Checks to see if the Recommendation property is set.
        /// </summary>
        internal bool IsSetRecommendation() => this.Recommendation != null;

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The updated severity level of the threat.
        /// </para>
        /// </summary>
        public ThreatSeverity Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;

        /// <summary>
        /// Gets and sets the property Statement. 
        /// <para>
        /// The updated natural-language threat statement.
        /// </para>
        /// </summary>
        public string Statement { get; set; }

        /// <summary>
        /// Checks to see if the Statement property is set.
        /// </summary>
        internal bool IsSetStatement() => this.Statement != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The updated status of the threat.
        /// </para>
        /// </summary>
        public ThreatStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property ThreatAction. 
        /// <para>
        /// The updated description of what the threat source can do.
        /// </para>
        /// </summary>
        public string ThreatAction { get; set; }

        /// <summary>
        /// Checks to see if the ThreatAction property is set.
        /// </summary>
        internal bool IsSetThreatAction() => this.ThreatAction != null;

        /// <summary>
        /// Gets and sets the property ThreatId. 
        /// <para>
        /// The unique identifier of the threat to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ThreatId { get; set; }

        /// <summary>
        /// Checks to see if the ThreatId property is set.
        /// </summary>
        internal bool IsSetThreatId() => this.ThreatId != null;

        /// <summary>
        /// Gets and sets the property ThreatImpact. 
        /// <para>
        /// The updated direct consequence of the threat action.
        /// </para>
        /// </summary>
        public string ThreatImpact { get; set; }

        /// <summary>
        /// Checks to see if the ThreatImpact property is set.
        /// </summary>
        internal bool IsSetThreatImpact() => this.ThreatImpact != null;

        /// <summary>
        /// Gets and sets the property ThreatSource. 
        /// <para>
        /// The updated actor or origin of the threat.
        /// </para>
        /// </summary>
        public string ThreatSource { get; set; }

        /// <summary>
        /// Checks to see if the ThreatSource property is set.
        /// </summary>
        internal bool IsSetThreatSource() => this.ThreatSource != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A short title summarizing the threat.
        /// </para>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
