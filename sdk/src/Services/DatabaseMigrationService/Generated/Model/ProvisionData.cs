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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Information about provisioning resources for an DMS serverless replication.
    /// </summary>
    public partial class ProvisionData
    {
        private DateTime? _dateNewProvisioningDataAvailable;
        private DateTime? _dateProvisioned;
        private bool? _isNewProvisioningAvailable;
        private int? _provisionedCapacityUnits;
        private string _provisionState;
        private string _reasonForNewProvisioningData;

        /// <summary>
        /// Gets and sets the property DateNewProvisioningDataAvailable. 
        /// <para>
        /// The timestamp when provisioning became available.
        /// </para>
        /// </summary>
        public DateTime? DateNewProvisioningDataAvailable
        {
            get { return this._dateNewProvisioningDataAvailable; }
            set { this._dateNewProvisioningDataAvailable = value; }
        }

        // Check to see if DateNewProvisioningDataAvailable property is set
        internal bool IsSetDateNewProvisioningDataAvailable()
        {
            return this._dateNewProvisioningDataAvailable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DateProvisioned. 
        /// <para>
        /// The timestamp when DMS provisioned replication resources.
        /// </para>
        /// </summary>
        public DateTime? DateProvisioned
        {
            get { return this._dateProvisioned; }
            set { this._dateProvisioned = value; }
        }

        // Check to see if DateProvisioned property is set
        internal bool IsSetDateProvisioned()
        {
            return this._dateProvisioned.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsNewProvisioningAvailable. 
        /// <para>
        /// Whether the new provisioning is available to the replication.
        /// </para>
        /// </summary>
        public bool? IsNewProvisioningAvailable
        {
            get { return this._isNewProvisioningAvailable; }
            set { this._isNewProvisioningAvailable = value; }
        }

        // Check to see if IsNewProvisioningAvailable property is set
        internal bool IsSetIsNewProvisioningAvailable()
        {
            return this._isNewProvisioningAvailable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProvisionedCapacityUnits. 
        /// <para>
        /// The number of capacity units the replication is using.
        /// </para>
        /// </summary>
        public int? ProvisionedCapacityUnits
        {
            get { return this._provisionedCapacityUnits; }
            set { this._provisionedCapacityUnits = value; }
        }

        // Check to see if ProvisionedCapacityUnits property is set
        internal bool IsSetProvisionedCapacityUnits()
        {
            return this._provisionedCapacityUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProvisionState. 
        /// <para>
        /// The current provisioning state 
        /// </para>
        /// </summary>
        public string ProvisionState
        {
            get { return this._provisionState; }
            set { this._provisionState = value; }
        }

        // Check to see if ProvisionState property is set
        internal bool IsSetProvisionState()
        {
            return this._provisionState != null;
        }

        /// <summary>
        /// Gets and sets the property ReasonForNewProvisioningData. 
        /// <para>
        /// A message describing the reason that DMS provisioned new resources for the serverless
        /// replication.
        /// </para>
        /// </summary>
        public string ReasonForNewProvisioningData
        {
            get { return this._reasonForNewProvisioningData; }
            set { this._reasonForNewProvisioningData = value; }
        }

        // Check to see if ReasonForNewProvisioningData property is set
        internal bool IsSetReasonForNewProvisioningData()
        {
            return this._reasonForNewProvisioningData != null;
        }

    }
}