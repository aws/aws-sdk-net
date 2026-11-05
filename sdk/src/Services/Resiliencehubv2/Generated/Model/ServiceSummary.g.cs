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
    /// Contains summary information about a service.
    /// </summary>
    public partial class ServiceSummary
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// Displayed only if caller has access.
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
        /// The dependency discovery configuration.
        /// </para>
        /// </summary>
        public DependencyDiscoveryConfig DependencyDiscovery { get; set; }

        /// <summary>
        /// Checks to see if the DependencyDiscovery property is set.
        /// </summary>
        internal bool IsSetDependencyDiscovery() => this.DependencyDiscovery != null;

        /// <summary>
        /// Gets and sets the property DevOpsAgentSpaceArn. 
        /// <para>
        /// The ARN of the DevOps Agent Agent Space linked to the service, when the service is
        /// linked to one.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string DevOpsAgentSpaceArn { get; set; }

        /// <summary>
        /// Checks to see if the DevOpsAgentSpaceArn property is set.
        /// </summary>
        internal bool IsSetDevOpsAgentSpaceArn() => this.DevOpsAgentSpaceArn != null;

        /// <summary>
        /// Gets and sets the property DevOpsAgentStatus. 
        /// <para>
        /// The DevOps Agent connection status for the service. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CONNECTING - The service is being connected to the Agent Space.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CONNECTED - The service is connected to the Agent Space.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DISCONNECTED - The service is not connected to an Agent Space.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FAILED - The connection attempt failed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DevOpsAgentConnectionStatus DevOpsAgentStatus { get; set; }

        /// <summary>
        /// Checks to see if the DevOpsAgentStatus property is set.
        /// </summary>
        internal bool IsSetDevOpsAgentStatus() => this.DevOpsAgentStatus != null;

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
        /// The number of open findings.
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
        /// Displayed only if caller has access.
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
        /// Displayed only if caller has access.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 16, Max = 68)]
        public string OuId { get; set; }

        /// <summary>
        /// Checks to see if the OuId property is set.
        /// </summary>
        internal bool IsSetOuId() => this.OuId != null;

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
        /// Gets and sets the property ResolvedFindingsCount. 
        /// <para>
        /// The number of resolved findings.
        /// </para>
        /// </summary>
        public int? ResolvedFindingsCount { get; set; }

        /// <summary>
        /// Checks to see if the ResolvedFindingsCount property is set.
        /// </summary>
        internal bool IsSetResolvedFindingsCount() => this.ResolvedFindingsCount.HasValue;

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
