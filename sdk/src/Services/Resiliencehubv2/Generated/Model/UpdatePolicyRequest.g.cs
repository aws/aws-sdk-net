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
    /// Container for the parameters to the UpdatePolicy operation. Updates an existing resilience
    /// policy.
    /// </summary>
    public partial class UpdatePolicyRequest : AmazonResiliencehubv2Request
    {
        /// <summary>
        /// Gets and sets the property AvailabilitySlo. 
        /// <para>
        /// The updated availability SLO for the policy.
        /// </para>
        /// </summary>
        public AvailabilitySlo AvailabilitySlo { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilitySlo property is set.
        /// </summary>
        internal bool IsSetAvailabilitySlo() => this.AvailabilitySlo != null;

        /// <summary>
        /// Gets and sets the property DataRecovery. 
        /// <para>
        /// The updated data recovery targets for the policy.
        /// </para>
        /// </summary>
        public DataRecoveryTargets DataRecovery { get; set; }

        /// <summary>
        /// Checks to see if the DataRecovery property is set.
        /// </summary>
        internal bool IsSetDataRecovery() => this.DataRecovery != null;

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
        /// Gets and sets the property MultiAz. 
        /// <para>
        /// The updated multi-AZ disaster recovery targets for the policy.
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
        /// The updated multi-Region disaster recovery targets for the policy.
        /// </para>
        /// </summary>
        public MultiRegionTargets MultiRegion { get; set; }

        /// <summary>
        /// Checks to see if the MultiRegion property is set.
        /// </summary>
        internal bool IsSetMultiRegion() => this.MultiRegion != null;

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
        /// Specifies whether cross-account sharing is enabled for the policy. Disabling sharing
        /// stops member services from using the policy.
        /// </para>
        /// </summary>
        public bool? SharingEnabled { get; set; }

        /// <summary>
        /// Checks to see if the SharingEnabled property is set.
        /// </summary>
        internal bool IsSetSharingEnabled() => this.SharingEnabled.HasValue;
    }
}
