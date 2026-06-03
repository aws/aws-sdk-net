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
    /// Contains the effective resilience policy values for a service.
    /// </summary>
    public partial class EffectivePolicyValues
    {
        private SloSource _availabilitySlo;
        private TargetSource _dataRecoveryTimeBetweenBackups;
        private DisasterRecoverySource _multiAzDrApproach;
        private TargetSource _multiAzRpo;
        private TargetSource _multiAzRto;
        private DisasterRecoverySource _multiRegionDrApproach;
        private TargetSource _multiRegionRpo;
        private TargetSource _multiRegionRto;

        /// <summary>
        /// Gets and sets the property AvailabilitySlo. 
        /// <para>
        /// The effective availability SLO value for the service.
        /// </para>
        /// </summary>
        public SloSource AvailabilitySlo
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
        /// The effective data recovery time between backups value for the service.
        /// </para>
        /// </summary>
        public TargetSource DataRecoveryTimeBetweenBackups
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
        /// Gets and sets the property MultiAzDrApproach. 
        /// <para>
        /// The effective multi-AZ disaster recovery approach for the service.
        /// </para>
        /// </summary>
        public DisasterRecoverySource MultiAzDrApproach
        {
            get { return this._multiAzDrApproach; }
            set { this._multiAzDrApproach = value; }
        }

        // Check to see if MultiAzDrApproach property is set
        internal bool IsSetMultiAzDrApproach()
        {
            return this._multiAzDrApproach != null;
        }

        /// <summary>
        /// Gets and sets the property MultiAzRpo. 
        /// <para>
        /// The effective multi-AZ RPO value for the service, in minutes.
        /// </para>
        /// </summary>
        public TargetSource MultiAzRpo
        {
            get { return this._multiAzRpo; }
            set { this._multiAzRpo = value; }
        }

        // Check to see if MultiAzRpo property is set
        internal bool IsSetMultiAzRpo()
        {
            return this._multiAzRpo != null;
        }

        /// <summary>
        /// Gets and sets the property MultiAzRto. 
        /// <para>
        /// The effective multi-AZ RTO value for the service, in minutes.
        /// </para>
        /// </summary>
        public TargetSource MultiAzRto
        {
            get { return this._multiAzRto; }
            set { this._multiAzRto = value; }
        }

        // Check to see if MultiAzRto property is set
        internal bool IsSetMultiAzRto()
        {
            return this._multiAzRto != null;
        }

        /// <summary>
        /// Gets and sets the property MultiRegionDrApproach. 
        /// <para>
        /// The effective multi-Region disaster recovery approach for the service.
        /// </para>
        /// </summary>
        public DisasterRecoverySource MultiRegionDrApproach
        {
            get { return this._multiRegionDrApproach; }
            set { this._multiRegionDrApproach = value; }
        }

        // Check to see if MultiRegionDrApproach property is set
        internal bool IsSetMultiRegionDrApproach()
        {
            return this._multiRegionDrApproach != null;
        }

        /// <summary>
        /// Gets and sets the property MultiRegionRpo. 
        /// <para>
        /// The effective multi-Region RPO value for the service, in minutes.
        /// </para>
        /// </summary>
        public TargetSource MultiRegionRpo
        {
            get { return this._multiRegionRpo; }
            set { this._multiRegionRpo = value; }
        }

        // Check to see if MultiRegionRpo property is set
        internal bool IsSetMultiRegionRpo()
        {
            return this._multiRegionRpo != null;
        }

        /// <summary>
        /// Gets and sets the property MultiRegionRto. 
        /// <para>
        /// The effective multi-Region RTO value for the service, in minutes.
        /// </para>
        /// </summary>
        public TargetSource MultiRegionRto
        {
            get { return this._multiRegionRto; }
            set { this._multiRegionRto = value; }
        }

        // Check to see if MultiRegionRto property is set
        internal bool IsSetMultiRegionRto()
        {
            return this._multiRegionRto != null;
        }

    }
}