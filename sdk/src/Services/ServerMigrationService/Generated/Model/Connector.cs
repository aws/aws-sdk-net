/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// Object representing a Connector
    /// </summary>
    public partial class Connector
    {
        private DateTime? _associatedOn;
        private List<string> _capabilityList = new List<string>();
        private string _connectorId;
        private string _ipAddress;
        private string _macAddress;
        private ConnectorStatus _status;
        private string _version;
        private string _vmManagerId;
        private string _vmManagerName;
        private VmManagerType _vmManagerType;

        /// <summary>
        /// Gets and sets the property AssociatedOn.
        /// </summary>
        public DateTime AssociatedOn
        {
            get { return this._associatedOn.GetValueOrDefault(); }
            set { this._associatedOn = value; }
        }

        // Check to see if AssociatedOn property is set
        internal bool IsSetAssociatedOn()
        {
            return this._associatedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CapabilityList.
        /// </summary>
        public List<string> CapabilityList
        {
            get { return this._capabilityList; }
            set { this._capabilityList = value; }
        }

        // Check to see if CapabilityList property is set
        internal bool IsSetCapabilityList()
        {
            return this._capabilityList != null && this._capabilityList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ConnectorId.
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
        /// Gets and sets the property IpAddress.
        /// </summary>
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IpAddress property is set
        internal bool IsSetIpAddress()
        {
            return this._ipAddress != null;
        }

        /// <summary>
        /// Gets and sets the property MacAddress.
        /// </summary>
        public string MacAddress
        {
            get { return this._macAddress; }
            set { this._macAddress = value; }
        }

        // Check to see if MacAddress property is set
        internal bool IsSetMacAddress()
        {
            return this._macAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Status.
        /// </summary>
        public ConnectorStatus Status
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
        /// Gets and sets the property Version.
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

        /// <summary>
        /// Gets and sets the property VmManagerId.
        /// </summary>
        public string VmManagerId
        {
            get { return this._vmManagerId; }
            set { this._vmManagerId = value; }
        }

        // Check to see if VmManagerId property is set
        internal bool IsSetVmManagerId()
        {
            return this._vmManagerId != null;
        }

        /// <summary>
        /// Gets and sets the property VmManagerName.
        /// </summary>
        public string VmManagerName
        {
            get { return this._vmManagerName; }
            set { this._vmManagerName = value; }
        }

        // Check to see if VmManagerName property is set
        internal bool IsSetVmManagerName()
        {
            return this._vmManagerName != null;
        }

        /// <summary>
        /// Gets and sets the property VmManagerType.
        /// </summary>
        public VmManagerType VmManagerType
        {
            get { return this._vmManagerType; }
            set { this._vmManagerType = value; }
        }

        // Check to see if VmManagerType property is set
        internal bool IsSetVmManagerType()
        {
            return this._vmManagerType != null;
        }

    }
}