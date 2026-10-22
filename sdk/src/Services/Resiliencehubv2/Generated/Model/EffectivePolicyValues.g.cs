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
    /// Contains the effective resilience policy values for a service.
    /// </summary>
    public partial class EffectivePolicyValues
    {
        /// <summary>
        /// Gets and sets the property AvailabilitySlo. 
        /// <para>
        /// The effective availability SLO value for the service.
        /// </para>
        /// </summary>
        public SloSource AvailabilitySlo { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilitySlo property is set.
        /// </summary>
        internal bool IsSetAvailabilitySlo() => this.AvailabilitySlo != null;

        /// <summary>
        /// Gets and sets the property DataRecoveryTimeBetweenBackups. 
        /// <para>
        /// The effective data recovery time between backups value for the service.
        /// </para>
        /// </summary>
        public TargetSource DataRecoveryTimeBetweenBackups { get; set; }

        /// <summary>
        /// Checks to see if the DataRecoveryTimeBetweenBackups property is set.
        /// </summary>
        internal bool IsSetDataRecoveryTimeBetweenBackups() => this.DataRecoveryTimeBetweenBackups != null;

        /// <summary>
        /// Gets and sets the property MultiAzDrApproach. 
        /// <para>
        /// The effective multi-AZ disaster recovery approach for the service.
        /// </para>
        /// </summary>
        public DisasterRecoverySource MultiAzDrApproach { get; set; }

        /// <summary>
        /// Checks to see if the MultiAzDrApproach property is set.
        /// </summary>
        internal bool IsSetMultiAzDrApproach() => this.MultiAzDrApproach != null;

        /// <summary>
        /// Gets and sets the property MultiAzRpo. 
        /// <para>
        /// The effective multi-AZ RPO value for the service, in minutes.
        /// </para>
        /// </summary>
        public TargetSource MultiAzRpo { get; set; }

        /// <summary>
        /// Checks to see if the MultiAzRpo property is set.
        /// </summary>
        internal bool IsSetMultiAzRpo() => this.MultiAzRpo != null;

        /// <summary>
        /// Gets and sets the property MultiAzRto. 
        /// <para>
        /// The effective multi-AZ RTO value for the service, in minutes.
        /// </para>
        /// </summary>
        public TargetSource MultiAzRto { get; set; }

        /// <summary>
        /// Checks to see if the MultiAzRto property is set.
        /// </summary>
        internal bool IsSetMultiAzRto() => this.MultiAzRto != null;

        /// <summary>
        /// Gets and sets the property MultiRegionDrApproach. 
        /// <para>
        /// The effective multi-Region disaster recovery approach for the service.
        /// </para>
        /// </summary>
        public DisasterRecoverySource MultiRegionDrApproach { get; set; }

        /// <summary>
        /// Checks to see if the MultiRegionDrApproach property is set.
        /// </summary>
        internal bool IsSetMultiRegionDrApproach() => this.MultiRegionDrApproach != null;

        /// <summary>
        /// Gets and sets the property MultiRegionRpo. 
        /// <para>
        /// The effective multi-Region RPO value for the service, in minutes.
        /// </para>
        /// </summary>
        public TargetSource MultiRegionRpo { get; set; }

        /// <summary>
        /// Checks to see if the MultiRegionRpo property is set.
        /// </summary>
        internal bool IsSetMultiRegionRpo() => this.MultiRegionRpo != null;

        /// <summary>
        /// Gets and sets the property MultiRegionRto. 
        /// <para>
        /// The effective multi-Region RTO value for the service, in minutes.
        /// </para>
        /// </summary>
        public TargetSource MultiRegionRto { get; set; }

        /// <summary>
        /// Checks to see if the MultiRegionRto property is set.
        /// </summary>
        internal bool IsSetMultiRegionRto() => this.MultiRegionRto != null;
    }
}
