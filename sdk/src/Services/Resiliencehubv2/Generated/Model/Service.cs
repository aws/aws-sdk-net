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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
        private string _accountId;
        private Achievability _achievability;
        private AssessmentStatus _assessmentStatus;
        private List<AssociatedSystem> _associatedSystems = AWSConfigs.InitializeCollections ? new List<AssociatedSystem>() : null;
        private DateTime? _createdAt;
        private DependencyDiscoveryConfig _dependencyDiscovery;
        private string _description;
        private EffectivePolicyValues _effectivePolicyValues;
        private AssessmentCost _estimatedAssessmentCost;
        private string _kmsKeyId;
        private string _name;
        private int? _openFindingsCount;
        private string _organizationId;
        private string _ouId;
        private PermissionModel _permissionModel;
        private string _policyArn;
        private List<string> _regions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ServiceReportConfiguration _reportConfiguration;
        private bool? _rerunAssessment;
        private int? _resolvedFindingsCount;
        private ResourceDiscoveryStatus _resourceDiscovery;
        private string _serviceArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The AWS account ID that owns the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Achievability. 
        /// <para>
        /// The achievability status of the service's resilience targets.
        /// </para>
        /// </summary>
        public Achievability Achievability
        {
            get { return this._achievability; }
            set { this._achievability = value; }
        }

        // Check to see if Achievability property is set
        internal bool IsSetAchievability()
        {
            return this._achievability != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentStatus. 
        /// <para>
        /// The current assessment status of the service.
        /// </para>
        /// </summary>
        public AssessmentStatus AssessmentStatus
        {
            get { return this._assessmentStatus; }
            set { this._assessmentStatus = value; }
        }

        // Check to see if AssessmentStatus property is set
        internal bool IsSetAssessmentStatus()
        {
            return this._assessmentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property AssociatedSystems. 
        /// <para>
        /// The systems associated with the service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<AssociatedSystem> AssociatedSystems
        {
            get { return this._associatedSystems; }
            set { this._associatedSystems = value; }
        }

        // Check to see if AssociatedSystems property is set
        internal bool IsSetAssociatedSystems()
        {
            return this._associatedSystems != null && (this._associatedSystems.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the service was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DependencyDiscovery. 
        /// <para>
        /// The dependency discovery configuration for the service.
        /// </para>
        /// </summary>
        public DependencyDiscoveryConfig DependencyDiscovery
        {
            get { return this._dependencyDiscovery; }
            set { this._dependencyDiscovery = value; }
        }

        // Check to see if DependencyDiscovery property is set
        internal bool IsSetDependencyDiscovery()
        {
            return this._dependencyDiscovery != null;
        }

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Min=0, Max=615)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EffectivePolicyValues. 
        /// <para>
        /// The effective policy values for the service.
        /// </para>
        /// </summary>
        public EffectivePolicyValues EffectivePolicyValues
        {
            get { return this._effectivePolicyValues; }
            set { this._effectivePolicyValues = value; }
        }

        // Check to see if EffectivePolicyValues property is set
        internal bool IsSetEffectivePolicyValues()
        {
            return this._effectivePolicyValues != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedAssessmentCost. 
        /// <para>
        /// The estimated cost of running an assessment on the service.
        /// </para>
        /// </summary>
        public AssessmentCost EstimatedAssessmentCost
        {
            get { return this._estimatedAssessmentCost; }
            set { this._estimatedAssessmentCost = value; }
        }

        // Check to see if EstimatedAssessmentCost property is set
        internal bool IsSetEstimatedAssessmentCost()
        {
            return this._estimatedAssessmentCost != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId.
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=60)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OpenFindingsCount. 
        /// <para>
        /// The number of open findings for the service.
        /// </para>
        /// </summary>
        public int? OpenFindingsCount
        {
            get { return this._openFindingsCount; }
            set { this._openFindingsCount = value; }
        }

        // Check to see if OpenFindingsCount property is set
        internal bool IsSetOpenFindingsCount()
        {
            return this._openFindingsCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The AWS Organizations identifier for the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=34)]
        public string OrganizationId
        {
            get { return this._organizationId; }
            set { this._organizationId = value; }
        }

        // Check to see if OrganizationId property is set
        internal bool IsSetOrganizationId()
        {
            return this._organizationId != null;
        }

        /// <summary>
        /// Gets and sets the property OuId. 
        /// <para>
        /// The organizational unit (OU) identifier for the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=16, Max=68)]
        public string OuId
        {
            get { return this._ouId; }
            set { this._ouId = value; }
        }

        // Check to see if OuId property is set
        internal bool IsSetOuId()
        {
            return this._ouId != null;
        }

        /// <summary>
        /// Gets and sets the property PermissionModel. 
        /// <para>
        /// The permission model for the service.
        /// </para>
        /// </summary>
        public PermissionModel PermissionModel
        {
            get { return this._permissionModel; }
            set { this._permissionModel = value; }
        }

        // Check to see if PermissionModel property is set
        internal bool IsSetPermissionModel()
        {
            return this._permissionModel != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyArn.
        /// </summary>
        [AWSProperty(Min=31)]
        public string PolicyArn
        {
            get { return this._policyArn; }
            set { this._policyArn = value; }
        }

        // Check to see if PolicyArn property is set
        internal bool IsSetPolicyArn()
        {
            return this._policyArn != null;
        }

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// The AWS Regions where the service operates.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }

        // Check to see if Regions property is set
        internal bool IsSetRegions()
        {
            return this._regions != null && (this._regions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReportConfiguration.
        /// </summary>
        public ServiceReportConfiguration ReportConfiguration
        {
            get { return this._reportConfiguration; }
            set { this._reportConfiguration = value; }
        }

        // Check to see if ReportConfiguration property is set
        internal bool IsSetReportConfiguration()
        {
            return this._reportConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RerunAssessment. 
        /// <para>
        /// Indicates whether the assessment should be rerun.
        /// </para>
        /// </summary>
        public bool? RerunAssessment
        {
            get { return this._rerunAssessment; }
            set { this._rerunAssessment = value; }
        }

        // Check to see if RerunAssessment property is set
        internal bool IsSetRerunAssessment()
        {
            return this._rerunAssessment.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResolvedFindingsCount. 
        /// <para>
        /// The number of resolved findings for the service.
        /// </para>
        /// </summary>
        public int? ResolvedFindingsCount
        {
            get { return this._resolvedFindingsCount; }
            set { this._resolvedFindingsCount = value; }
        }

        // Check to see if ResolvedFindingsCount property is set
        internal bool IsSetResolvedFindingsCount()
        {
            return this._resolvedFindingsCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceDiscovery. 
        /// <para>
        /// The resource discovery status for the service.
        /// </para>
        /// </summary>
        public ResourceDiscoveryStatus ResourceDiscovery
        {
            get { return this._resourceDiscovery; }
            set { this._resourceDiscovery = value; }
        }

        // Check to see if ResourceDiscovery property is set
        internal bool IsSetResourceDiscovery()
        {
            return this._resourceDiscovery != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceArn.
        /// </summary>
        [AWSProperty(Required=true, Min=31)]
        public string ServiceArn
        {
            get { return this._serviceArn; }
            set { this._serviceArn = value; }
        }

        // Check to see if ServiceArn property is set
        internal bool IsSetServiceArn()
        {
            return this._serviceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the service was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}