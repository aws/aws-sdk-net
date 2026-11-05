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
    /// Represents a service in Resilience Hub. A service is the primary unit of resilience
    /// assessment.
    /// </summary>
    public partial class Service
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The AWS account ID that owns the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property Achievability. 
        /// <para>
        /// The achievability status of the service's resilience targets.
        /// </para>
        /// </summary>
        public Achievability Achievability { get; set; }

        /// <summary>
        /// Checks to see if the Achievability property is set.
        /// </summary>
        internal bool IsSetAchievability() => this.Achievability != null;

        /// <summary>
        /// Gets and sets the property AssessmentStatus. 
        /// <para>
        /// The current assessment status of the service.
        /// </para>
        /// </summary>
        public AssessmentStatus AssessmentStatus { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentStatus property is set.
        /// </summary>
        internal bool IsSetAssessmentStatus() => this.AssessmentStatus != null;

        /// <summary>
        /// Gets and sets the property AssociatedSystems. 
        /// <para>
        /// The systems associated with the service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<AssociatedSystem> AssociatedSystems { get; set; } = AWSConfigs.InitializeCollections ? new List<AssociatedSystem>() : null;

        /// <summary>
        /// Checks to see if the AssociatedSystems property is set.
        /// </summary>
        internal bool IsSetAssociatedSystems() => this.AssociatedSystems != null && (this.AssociatedSystems.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the service was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DependencyDiscovery. 
        /// <para>
        /// The dependency discovery configuration for the service.
        /// </para>
        /// </summary>
        public DependencyDiscoveryConfig DependencyDiscovery { get; set; }

        /// <summary>
        /// Checks to see if the DependencyDiscovery property is set.
        /// </summary>
        internal bool IsSetDependencyDiscovery() => this.DependencyDiscovery != null;

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Max = 615)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DevOpsAgentConfiguration. 
        /// <para>
        /// The current DevOps Agent integration state for the service.
        /// </para>
        /// </summary>
        public DevOpsAgentConfigurationView DevOpsAgentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DevOpsAgentConfiguration property is set.
        /// </summary>
        internal bool IsSetDevOpsAgentConfiguration() => this.DevOpsAgentConfiguration != null;

        /// <summary>
        /// Gets and sets the property EffectivePolicyValues. 
        /// <para>
        /// The effective policy values for the service.
        /// </para>
        /// </summary>
        public EffectivePolicyValues EffectivePolicyValues { get; set; }

        /// <summary>
        /// Checks to see if the EffectivePolicyValues property is set.
        /// </summary>
        internal bool IsSetEffectivePolicyValues() => this.EffectivePolicyValues != null;

        /// <summary>
        /// Gets and sets the property EstimatedAssessmentCost. 
        /// <para>
        /// The estimated cost of running an assessment on the service.
        /// </para>
        /// </summary>
        public AssessmentCost EstimatedAssessmentCost { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedAssessmentCost property is set.
        /// </summary>
        internal bool IsSetEstimatedAssessmentCost() => this.EstimatedAssessmentCost != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 60)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OpenFindingsCount. 
        /// <para>
        /// The number of open findings for the service.
        /// </para>
        /// </summary>
        public int? OpenFindingsCount { get; set; }

        /// <summary>
        /// Checks to see if the OpenFindingsCount property is set.
        /// </summary>
        internal bool IsSetOpenFindingsCount() => this.OpenFindingsCount.HasValue;

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The AWS Organizations identifier for the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 34)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationId property is set.
        /// </summary>
        internal bool IsSetOrganizationId() => this.OrganizationId != null;

        /// <summary>
        /// Gets and sets the property OuId. 
        /// <para>
        /// The organizational unit (OU) identifier for the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 16, Max = 68)]
        public string OuId { get; set; }

        /// <summary>
        /// Checks to see if the OuId property is set.
        /// </summary>
        internal bool IsSetOuId() => this.OuId != null;

        /// <summary>
        /// Gets and sets the property PermissionModel. 
        /// <para>
        /// The permission model for the service.
        /// </para>
        /// </summary>
        public PermissionModel PermissionModel { get; set; }

        /// <summary>
        /// Checks to see if the PermissionModel property is set.
        /// </summary>
        internal bool IsSetPermissionModel() => this.PermissionModel != null;

        /// <summary>
        /// Gets and sets the property PolicyArn.
        /// </summary>
        [AWSProperty(Min = 31)]
        public string PolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the PolicyArn property is set.
        /// </summary>
        internal bool IsSetPolicyArn() => this.PolicyArn != null;

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// The Regions where the service operates.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<string> Regions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Regions property is set.
        /// </summary>
        internal bool IsSetRegions() => this.Regions != null && (this.Regions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReportConfiguration.
        /// </summary>
        public ServiceReportConfiguration ReportConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ReportConfiguration property is set.
        /// </summary>
        internal bool IsSetReportConfiguration() => this.ReportConfiguration != null;

        /// <summary>
        /// Gets and sets the property RerunAssessment. 
        /// <para>
        /// Indicates whether the assessment should be rerun.
        /// </para>
        /// </summary>
        public bool? RerunAssessment { get; set; }

        /// <summary>
        /// Checks to see if the RerunAssessment property is set.
        /// </summary>
        internal bool IsSetRerunAssessment() => this.RerunAssessment.HasValue;

        /// <summary>
        /// Gets and sets the property ResolvedFindingsCount. 
        /// <para>
        /// The number of resolved findings for the service.
        /// </para>
        /// </summary>
        public int? ResolvedFindingsCount { get; set; }

        /// <summary>
        /// Checks to see if the ResolvedFindingsCount property is set.
        /// </summary>
        internal bool IsSetResolvedFindingsCount() => this.ResolvedFindingsCount.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceDiscovery. 
        /// <para>
        /// The resource discovery status for the service.
        /// </para>
        /// </summary>
        public ResourceDiscoveryStatus ResourceDiscovery { get; set; }

        /// <summary>
        /// Checks to see if the ResourceDiscovery property is set.
        /// </summary>
        internal bool IsSetResourceDiscovery() => this.ResourceDiscovery != null;

        /// <summary>
        /// Gets and sets the property ServiceArn.
        /// </summary>
        [AWSProperty(Required = true, Min = 31)]
        public string ServiceArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceArn property is set.
        /// </summary>
        internal bool IsSetServiceArn() => this.ServiceArn != null;

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the service was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
