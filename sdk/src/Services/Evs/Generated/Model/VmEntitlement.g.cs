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

namespace Amazon.Evs.Model
{
    /// <summary>
    /// An object that represents a Windows Server License entitlement for a virtual machine
    /// in an Amazon EVS environment.
    /// </summary>
    public partial class VmEntitlement
    {
        /// <summary>
        /// Gets and sets the property ConnectorId. 
        /// <para>
        /// The unique ID of the connector associated with the entitlement.
        /// </para>
        /// </summary>
        public string ConnectorId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorId property is set.
        /// </summary>
        internal bool IsSetConnectorId() => this.ConnectorId != null;

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The unique ID of the environment.
        /// </para>
        /// </summary>
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property ErrorDetail. 
        /// <para>
        /// The error details associated with the entitlement, if applicable.
        /// </para>
        /// </summary>
        public ErrorDetail ErrorDetail { get; set; }

        /// <summary>
        /// Checks to see if the ErrorDetail property is set.
        /// </summary>
        internal bool IsSetErrorDetail() => this.ErrorDetail != null;

        /// <summary>
        /// Gets and sets the property LastSyncedAt. 
        /// <para>
        /// The date and time that the entitlement was last synced.
        /// </para>
        /// </summary>
        public DateTime? LastSyncedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastSyncedAt property is set.
        /// </summary>
        internal bool IsSetLastSyncedAt() => this.LastSyncedAt.HasValue;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The date and time that the entitlement started.
        /// </para>
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the entitlement.
        /// </para>
        /// </summary>
        public EntitlementStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StoppedAt. 
        /// <para>
        /// The date and time that the entitlement stopped.
        /// </para>
        /// </summary>
        public DateTime? StoppedAt { get; set; }

        /// <summary>
        /// Checks to see if the StoppedAt property is set.
        /// </summary>
        internal bool IsSetStoppedAt() => this.StoppedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of entitlement.
        /// </para>
        /// </summary>
        public EntitlementType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property VmId. 
        /// <para>
        /// The unique ID of the virtual machine.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 1024)]
        public string VmId { get; set; }

        /// <summary>
        /// Checks to see if the VmId property is set.
        /// </summary>
        internal bool IsSetVmId() => this.VmId != null;

        /// <summary>
        /// Gets and sets the property VmName. 
        /// <para>
        /// The name of the virtual machine.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string VmName { get; set; }

        /// <summary>
        /// Checks to see if the VmName property is set.
        /// </summary>
        internal bool IsSetVmName() => this.VmName != null;
    }
}
