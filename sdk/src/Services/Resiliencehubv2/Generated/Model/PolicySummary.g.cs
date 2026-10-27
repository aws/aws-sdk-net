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
    /// Contains summary information about a resilience policy.
    /// </summary>
    public partial class PolicySummary
    {
        /// <summary>
        /// Gets and sets the property AssociatedServiceCount. 
        /// <para>
        /// The number of services associated with this policy.
        /// </para>
        /// </summary>
        public int? AssociatedServiceCount { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedServiceCount property is set.
        /// </summary>
        internal bool IsSetAssociatedServiceCount() => this.AssociatedServiceCount.HasValue;

        /// <summary>
        /// Gets and sets the property AvailabilitySlo. 
        /// <para>
        /// The availability SLO defined in the policy.
        /// </para>
        /// </summary>
        public AvailabilitySlo AvailabilitySlo { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilitySlo property is set.
        /// </summary>
        internal bool IsSetAvailabilitySlo() => this.AvailabilitySlo != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the policy was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DataRecovery. 
        /// <para>
        /// The data recovery targets defined in the policy.
        /// </para>
        /// </summary>
        public DataRecoveryTargets DataRecovery { get; set; }

        /// <summary>
        /// Checks to see if the DataRecovery property is set.
        /// </summary>
        internal bool IsSetDataRecovery() => this.DataRecovery != null;

        /// <summary>
        /// Gets and sets the property MultiAz. 
        /// <para>
        /// The multi-AZ disaster recovery targets defined in the policy.
        /// </para>
        /// </summary>
        public MultiAzTargets MultiAz { get; set; }

        /// <summary>
        /// Checks to see if the MultiAz property is set.
        /// </summary>
        internal bool IsSetMultiAz() => this.MultiAz != null;

        /// <summary>
        /// Gets and sets the property MultiRegion. 
        /// <para>
        /// The multi-Region disaster recovery targets defined in the policy.
        /// </para>
        /// </summary>
        public MultiRegionTargets MultiRegion { get; set; }

        /// <summary>
        /// Checks to see if the MultiRegion property is set.
        /// </summary>
        internal bool IsSetMultiRegion() => this.MultiRegion != null;

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
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The identifier of the organization this policy is shared with.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 34)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationId property is set.
        /// </summary>
        internal bool IsSetOrganizationId() => this.OrganizationId != null;

        /// <summary>
        /// Gets and sets the property PolicyArn.
        /// </summary>
        [AWSProperty(Required = true, Min = 31)]
        public string PolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the PolicyArn property is set.
        /// </summary>
        internal bool IsSetPolicyArn() => this.PolicyArn != null;

        /// <summary>
        /// Gets and sets the property SharingEnabled. 
        /// <para>
        /// Specifies whether cross-account sharing is enabled.
        /// </para>
        /// </summary>
        public bool? SharingEnabled { get; set; }

        /// <summary>
        /// Checks to see if the SharingEnabled property is set.
        /// </summary>
        internal bool IsSetSharingEnabled() => this.SharingEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the policy was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
