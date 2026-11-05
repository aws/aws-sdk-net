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

namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Represents a resilience finding from a failure mode assessment.
    /// </summary>
    public partial class Finding
    {
        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// A user-provided comment about the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FailureCategory. 
        /// <para>
        /// The failure category of the finding.
        /// </para>
        /// </summary>
        public FailureCategory FailureCategory { get; set; }

        /// <summary>
        /// Checks to see if the FailureCategory property is set.
        /// </summary>
        internal bool IsSetFailureCategory() => this.FailureCategory != null;

        /// <summary>
        /// Gets and sets the property FindingId. 
        /// <para>
        /// The unique identifier of the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string FindingId { get; set; }

        /// <summary>
        /// Checks to see if the FindingId property is set.
        /// </summary>
        internal bool IsSetFindingId() => this.FindingId != null;

        /// <summary>
        /// Gets and sets the property InfrastructureAndCodeRecommendations. 
        /// <para>
        /// Infrastructure and code recommendations to address the finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 5)]
        public List<InfrastructureAndCodeRecommendation> InfrastructureAndCodeRecommendations { get; set; } = AWSConfigs.InitializeCollections ? new List<InfrastructureAndCodeRecommendation>() : null;

        /// <summary>
        /// Checks to see if the InfrastructureAndCodeRecommendations property is set.
        /// </summary>
        internal bool IsSetInfrastructureAndCodeRecommendations() => this.InfrastructureAndCodeRecommendations != null && (this.InfrastructureAndCodeRecommendations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InvestigationDeepLink. 
        /// <para>
        /// A deep link to an interactive DevOps Agent investigation seeded with this finding.
        /// This value is null until DevOps Agent creates an investigation.
        /// </para>
        /// </summary>
        public string InvestigationDeepLink { get; set; }

        /// <summary>
        /// Checks to see if the InvestigationDeepLink property is set.
        /// </summary>
        internal bool IsSetInvestigationDeepLink() => this.InvestigationDeepLink != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the finding.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ObservabilityRecommendations. 
        /// <para>
        /// Observability recommendations to address the finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 5)]
        public List<ObservabilityRecommendation> ObservabilityRecommendations { get; set; } = AWSConfigs.InitializeCollections ? new List<ObservabilityRecommendation>() : null;

        /// <summary>
        /// Checks to see if the ObservabilityRecommendations property is set.
        /// </summary>
        internal bool IsSetObservabilityRecommendations() => this.ObservabilityRecommendations != null && (this.ObservabilityRecommendations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PolicyComponent. 
        /// <para>
        /// The policy component associated with the finding.
        /// </para>
        /// </summary>
        public PolicyComponent PolicyComponent { get; set; }

        /// <summary>
        /// Checks to see if the PolicyComponent property is set.
        /// </summary>
        internal bool IsSetPolicyComponent() => this.PolicyComponent != null;

        /// <summary>
        /// Gets and sets the property Reasoning. 
        /// <para>
        /// The reasoning behind the finding.
        /// </para>
        /// </summary>
        public string Reasoning { get; set; }

        /// <summary>
        /// Checks to see if the Reasoning property is set.
        /// </summary>
        internal bool IsSetReasoning() => this.Reasoning != null;

        /// <summary>
        /// Gets and sets the property ServiceFunctions. 
        /// <para>
        /// The service functions associated with the finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<string> ServiceFunctions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ServiceFunctions property is set.
        /// </summary>
        internal bool IsSetServiceFunctions() => this.ServiceFunctions != null && (this.ServiceFunctions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the finding.
        /// </para>
        /// </summary>
        public FindingSeverity Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the finding.
        /// </para>
        /// </summary>
        public FindingStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TestingRecommendations. 
        /// <para>
        /// Testing recommendations to address the finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 5)]
        public List<TestingRecommendation> TestingRecommendations { get; set; } = AWSConfigs.InitializeCollections ? new List<TestingRecommendation>() : null;

        /// <summary>
        /// Checks to see if the TestingRecommendations property is set.
        /// </summary>
        internal bool IsSetTestingRecommendations() => this.TestingRecommendations != null && (this.TestingRecommendations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the finding was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
