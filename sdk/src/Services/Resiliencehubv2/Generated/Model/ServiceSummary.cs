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
    /// Contains summary information about a service.
    /// </summary>
    public partial class ServiceSummary
    {
        private string _accountId;
        private Achievability _achievability;
        private AssessmentStatus _assessmentStatus;
        private List<AssociatedSystem> _associatedSystems = AWSConfigs.InitializeCollections ? new List<AssociatedSystem>() : null;
        private DateTime? _createdAt;
        private DependencyDiscoveryConfig _dependencyDiscovery;
        private string _name;
        private int? _openFindingsCount;
        private string _organizationId;
        private string _ouId;
        private string _policyArn;
        private List<string> _regions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _resolvedFindingsCount;
        private string _serviceArn;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// Displayed only if caller has access.
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
        /// The dependency discovery configuration.
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
        /// The number of open findings.
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
        /// Displayed only if caller has access.
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
        /// Displayed only if caller has access.
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
        /// Gets and sets the property ResolvedFindingsCount. 
        /// <para>
        /// The number of resolved findings.
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