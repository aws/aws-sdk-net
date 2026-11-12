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
    /// Contains the structured summary of a GuardDuty investigation. The fields that are
    /// present depend on the investigation type.
    /// </summary>
    public partial class InvestigationSummaryData
    {
        /// <summary>
        /// Gets and sets the property AccountAnalysis. 
        /// <para>
        /// For an <c>ACCOUNT</c> investigation, an analysis of the findings in the investigated
        /// account.
        /// </para>
        /// </summary>
        public AccountAnalysis AccountAnalysis { get; set; }

        /// <summary>
        /// Checks to see if the AccountAnalysis property is set.
        /// </summary>
        internal bool IsSetAccountAnalysis() => this.AccountAnalysis != null;

        /// <summary>
        /// Gets and sets the property Countermeasures. 
        /// <para>
        /// For a <c>FINDING</c> investigation, actions that you can take to respond to the threat,
        /// grouped by defensive tactic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<Countermeasure> Countermeasures { get; set; } = AWSConfigs.InitializeCollections ? new List<Countermeasure>() : null;

        /// <summary>
        /// Checks to see if the Countermeasures property is set.
        /// </summary>
        internal bool IsSetCountermeasures() => this.Countermeasures != null && (this.Countermeasures.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FindingType. 
        /// <para>
        /// For a <c>FINDING</c> investigation, the type of the finding that the investigation
        /// analyzed.
        /// </para>
        /// </summary>
        public string FindingType { get; set; }

        /// <summary>
        /// Checks to see if the FindingType property is set.
        /// </summary>
        internal bool IsSetFindingType() => this.FindingType != null;

        /// <summary>
        /// Gets and sets the property KeyObservations. 
        /// <para>
        /// The key observations of the investigation.
        /// </para>
        /// </summary>
        public KeyObservations KeyObservations { get; set; }

        /// <summary>
        /// Checks to see if the KeyObservations property is set.
        /// </summary>
        internal bool IsSetKeyObservations() => this.KeyObservations != null;

        /// <summary>
        /// Gets and sets the property OrganizationAnalysis. 
        /// <para>
        /// For an <c>ORGANIZATION</c> investigation, an analysis of the findings across the organization.
        /// </para>
        /// </summary>
        public OrganizationAnalysis OrganizationAnalysis { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationAnalysis property is set.
        /// </summary>
        internal bool IsSetOrganizationAnalysis() => this.OrganizationAnalysis != null;

        /// <summary>
        /// Gets and sets the property Recommendations. 
        /// <para>
        /// For an <c>ACCOUNT</c> or <c>ORGANIZATION</c> investigation, the recommended actions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 25)]
        public List<Recommendation> Recommendations { get; set; } = AWSConfigs.InitializeCollections ? new List<Recommendation>() : null;

        /// <summary>
        /// Checks to see if the Recommendations property is set.
        /// </summary>
        internal bool IsSetRecommendations() => this.Recommendations != null && (this.Recommendations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ThreatAssessment. 
        /// <para>
        /// For a <c>FINDING</c> investigation, an assessment of the threat, including how the
        /// attack progressed.
        /// </para>
        /// </summary>
        public ThreatAssessment ThreatAssessment { get; set; }

        /// <summary>
        /// Checks to see if the ThreatAssessment property is set.
        /// </summary>
        internal bool IsSetThreatAssessment() => this.ThreatAssessment != null;
    }
}
