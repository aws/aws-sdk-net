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
    /// Describes the achievability status of a service's resilience targets based on the
    /// most recent assessment.
    /// </summary>
    public partial class Achievability
    {
        /// <summary>
        /// Gets and sets the property AvailabilitySlo. 
        /// <para>
        /// The achievability status of the availability SLO target for the service.
        /// </para>
        /// </summary>
        public AchievabilityStatus AvailabilitySlo { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilitySlo property is set.
        /// </summary>
        internal bool IsSetAvailabilitySlo() => this.AvailabilitySlo != null;

        /// <summary>
        /// Gets and sets the property DataRecoveryTimeBetweenBackups. 
        /// <para>
        /// The achievability status of the data recovery time between backups for the service.
        /// </para>
        /// </summary>
        public AchievabilityStatus DataRecoveryTimeBetweenBackups { get; set; }

        /// <summary>
        /// Checks to see if the DataRecoveryTimeBetweenBackups property is set.
        /// </summary>
        internal bool IsSetDataRecoveryTimeBetweenBackups() => this.DataRecoveryTimeBetweenBackups != null;

        /// <summary>
        /// Gets and sets the property MultiAzRtoRpo. 
        /// <para>
        /// The achievability status of the multi-AZ RTO and RPO targets for the service.
        /// </para>
        /// </summary>
        public AchievabilityStatus MultiAzRtoRpo { get; set; }

        /// <summary>
        /// Checks to see if the MultiAzRtoRpo property is set.
        /// </summary>
        internal bool IsSetMultiAzRtoRpo() => this.MultiAzRtoRpo != null;

        /// <summary>
        /// Gets and sets the property MultiRegionRtoRpo. 
        /// <para>
        /// The achievability status of the multi-Region RTO and RPO targets for the service.
        /// </para>
        /// </summary>
        public AchievabilityStatus MultiRegionRtoRpo { get; set; }

        /// <summary>
        /// Checks to see if the MultiRegionRtoRpo property is set.
        /// </summary>
        internal bool IsSetMultiRegionRtoRpo() => this.MultiRegionRtoRpo != null;
    }
}
