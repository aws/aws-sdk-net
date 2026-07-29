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
    /// Describes the achievability status of a service's resilience targets based on the
    /// most recent assessment.
    /// </summary>
    public partial class Achievability
    {
        private AchievabilityStatus _availabilitySlo;
        private AchievabilityStatus _dataRecoveryTimeBetweenBackups;
        private AchievabilityStatus _multiAzRtoRpo;
        private AchievabilityStatus _multiRegionRtoRpo;

        /// <summary>
        /// Gets and sets the property AvailabilitySlo. 
        /// <para>
        /// The achievability status of the availability SLO target for the service.
        /// </para>
        /// </summary>
        public AchievabilityStatus AvailabilitySlo
        {
            get { return this._availabilitySlo; }
            set { this._availabilitySlo = value; }
        }

        // Check to see if AvailabilitySlo property is set
        internal bool IsSetAvailabilitySlo()
        {
            return this._availabilitySlo != null;
        }

        /// <summary>
        /// Gets and sets the property DataRecoveryTimeBetweenBackups. 
        /// <para>
        /// The achievability status of the data recovery time between backups for the service.
        /// </para>
        /// </summary>
        public AchievabilityStatus DataRecoveryTimeBetweenBackups
        {
            get { return this._dataRecoveryTimeBetweenBackups; }
            set { this._dataRecoveryTimeBetweenBackups = value; }
        }

        // Check to see if DataRecoveryTimeBetweenBackups property is set
        internal bool IsSetDataRecoveryTimeBetweenBackups()
        {
            return this._dataRecoveryTimeBetweenBackups != null;
        }

        /// <summary>
        /// Gets and sets the property MultiAzRtoRpo. 
        /// <para>
        /// The achievability status of the multi-AZ RTO and RPO targets for the service.
        /// </para>
        /// </summary>
        public AchievabilityStatus MultiAzRtoRpo
        {
            get { return this._multiAzRtoRpo; }
            set { this._multiAzRtoRpo = value; }
        }

        // Check to see if MultiAzRtoRpo property is set
        internal bool IsSetMultiAzRtoRpo()
        {
            return this._multiAzRtoRpo != null;
        }

        /// <summary>
        /// Gets and sets the property MultiRegionRtoRpo. 
        /// <para>
        /// The achievability status of the multi-Region RTO and RPO targets for the service.
        /// </para>
        /// </summary>
        public AchievabilityStatus MultiRegionRtoRpo
        {
            get { return this._multiRegionRtoRpo; }
            set { this._multiRegionRtoRpo = value; }
        }

        // Check to see if MultiRegionRtoRpo property is set
        internal bool IsSetMultiRegionRtoRpo()
        {
            return this._multiRegionRtoRpo != null;
        }

    }
}