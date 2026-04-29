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
 * Do not modify this file. This file is generated from the evs-2023-07-27.normal.json service model.
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
        private string _connectorId;
        private string _environmentId;
        private ErrorDetail _errorDetail;
        private DateTime? _lastSyncedAt;
        private DateTime? _startedAt;
        private EntitlementStatus _status;
        private DateTime? _stoppedAt;
        private EntitlementType _type;
        private string _vmId;
        private string _vmName;

        /// <summary>
        /// Gets and sets the property ConnectorId. 
        /// <para>
        /// The unique ID of the connector associated with the entitlement.
        /// </para>
        /// </summary>
        public string ConnectorId
        {
            get { return this._connectorId; }
            set { this._connectorId = value; }
        }

        // Check to see if ConnectorId property is set
        internal bool IsSetConnectorId()
        {
            return this._connectorId != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The unique ID of the environment.
        /// </para>
        /// </summary>
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorDetail. 
        /// <para>
        /// The error details associated with the entitlement, if applicable.
        /// </para>
        /// </summary>
        public ErrorDetail ErrorDetail
        {
            get { return this._errorDetail; }
            set { this._errorDetail = value; }
        }

        // Check to see if ErrorDetail property is set
        internal bool IsSetErrorDetail()
        {
            return this._errorDetail != null;
        }

        /// <summary>
        /// Gets and sets the property LastSyncedAt. 
        /// <para>
        /// The date and time that the entitlement was last synced.
        /// </para>
        /// </summary>
        public DateTime? LastSyncedAt
        {
            get { return this._lastSyncedAt; }
            set { this._lastSyncedAt = value; }
        }

        // Check to see if LastSyncedAt property is set
        internal bool IsSetLastSyncedAt()
        {
            return this._lastSyncedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The date and time that the entitlement started.
        /// </para>
        /// </summary>
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the entitlement.
        /// </para>
        /// </summary>
        public EntitlementStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StoppedAt. 
        /// <para>
        /// The date and time that the entitlement stopped.
        /// </para>
        /// </summary>
        public DateTime? StoppedAt
        {
            get { return this._stoppedAt; }
            set { this._stoppedAt = value; }
        }

        // Check to see if StoppedAt property is set
        internal bool IsSetStoppedAt()
        {
            return this._stoppedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of entitlement.
        /// </para>
        /// </summary>
        public EntitlementType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property VmId. 
        /// <para>
        /// The unique ID of the virtual machine.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=1024)]
        public string VmId
        {
            get { return this._vmId; }
            set { this._vmId = value; }
        }

        // Check to see if VmId property is set
        internal bool IsSetVmId()
        {
            return this._vmId != null;
        }

        /// <summary>
        /// Gets and sets the property VmName. 
        /// <para>
        /// The name of the virtual machine.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string VmName
        {
            get { return this._vmName; }
            set { this._vmName = value; }
        }

        // Check to see if VmName property is set
        internal bool IsSetVmName()
        {
            return this._vmName != null;
        }

    }
}