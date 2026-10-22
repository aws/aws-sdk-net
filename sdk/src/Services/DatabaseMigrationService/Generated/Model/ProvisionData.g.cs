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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Information about provisioning resources for an DMS serverless replication.
    /// </summary>
    public partial class ProvisionData
    {
        /// <summary>
        /// Gets and sets the property DateNewProvisioningDataAvailable. 
        /// <para>
        /// The timestamp when provisioning became available.
        /// </para>
        /// </summary>
        public DateTime? DateNewProvisioningDataAvailable { get; set; }

        /// <summary>
        /// Checks to see if the DateNewProvisioningDataAvailable property is set.
        /// </summary>
        internal bool IsSetDateNewProvisioningDataAvailable() => this.DateNewProvisioningDataAvailable.HasValue;

        /// <summary>
        /// Gets and sets the property DateProvisioned. 
        /// <para>
        /// The timestamp when DMS provisioned replication resources.
        /// </para>
        /// </summary>
        public DateTime? DateProvisioned { get; set; }

        /// <summary>
        /// Checks to see if the DateProvisioned property is set.
        /// </summary>
        internal bool IsSetDateProvisioned() => this.DateProvisioned.HasValue;

        /// <summary>
        /// Gets and sets the property IsNewProvisioningAvailable. 
        /// <para>
        /// Whether the new provisioning is available to the replication.
        /// </para>
        /// </summary>
        public bool? IsNewProvisioningAvailable { get; set; }

        /// <summary>
        /// Checks to see if the IsNewProvisioningAvailable property is set.
        /// </summary>
        internal bool IsSetIsNewProvisioningAvailable() => this.IsNewProvisioningAvailable.HasValue;

        /// <summary>
        /// Gets and sets the property ProvisionState. 
        /// <para>
        /// The current provisioning state 
        /// </para>
        /// </summary>
        public string ProvisionState { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionState property is set.
        /// </summary>
        internal bool IsSetProvisionState() => this.ProvisionState != null;

        /// <summary>
        /// Gets and sets the property ProvisionedCapacityUnits. 
        /// <para>
        /// The number of capacity units the replication is using.
        /// </para>
        /// </summary>
        public int? ProvisionedCapacityUnits { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedCapacityUnits property is set.
        /// </summary>
        internal bool IsSetProvisionedCapacityUnits() => this.ProvisionedCapacityUnits.HasValue;

        /// <summary>
        /// Gets and sets the property ReasonForNewProvisioningData. 
        /// <para>
        /// A message describing the reason that DMS provisioned new resources for the serverless
        /// replication.
        /// </para>
        /// </summary>
        public string ReasonForNewProvisioningData { get; set; }

        /// <summary>
        /// Checks to see if the ReasonForNewProvisioningData property is set.
        /// </summary>
        internal bool IsSetReasonForNewProvisioningData() => this.ReasonForNewProvisioningData != null;
    }
}
