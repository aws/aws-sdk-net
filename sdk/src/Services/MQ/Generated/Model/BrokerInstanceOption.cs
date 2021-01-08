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
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MQ.Model
{
    /// <summary>
    /// Option for host instance type.
    /// </summary>
    public partial class BrokerInstanceOption
    {
        private List<AvailabilityZone> _availabilityZones = new List<AvailabilityZone>();
        private EngineType _engineType;
        private string _hostInstanceType;
        private BrokerStorageType _storageType;
        private List<string> _supportedDeploymentModes = new List<string>();
        private List<string> _supportedEngineVersions = new List<string>();

        /// <summary>
        /// Gets and sets the property AvailabilityZones. The list of available az.
        /// </summary>
        public List<AvailabilityZone> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && this._availabilityZones.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EngineType. The type of broker engine.
        /// </summary>
        public EngineType EngineType
        {
            get { return this._engineType; }
            set { this._engineType = value; }
        }

        // Check to see if EngineType property is set
        internal bool IsSetEngineType()
        {
            return this._engineType != null;
        }

        /// <summary>
        /// Gets and sets the property HostInstanceType. The type of broker instance.
        /// </summary>
        public string HostInstanceType
        {
            get { return this._hostInstanceType; }
            set { this._hostInstanceType = value; }
        }

        // Check to see if HostInstanceType property is set
        internal bool IsSetHostInstanceType()
        {
            return this._hostInstanceType != null;
        }

        /// <summary>
        /// Gets and sets the property StorageType. The broker's storage type.
        /// </summary>
        public BrokerStorageType StorageType
        {
            get { return this._storageType; }
            set { this._storageType = value; }
        }

        // Check to see if StorageType property is set
        internal bool IsSetStorageType()
        {
            return this._storageType != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedDeploymentModes. The list of supported deployment
        /// modes.
        /// </summary>
        public List<string> SupportedDeploymentModes
        {
            get { return this._supportedDeploymentModes; }
            set { this._supportedDeploymentModes = value; }
        }

        // Check to see if SupportedDeploymentModes property is set
        internal bool IsSetSupportedDeploymentModes()
        {
            return this._supportedDeploymentModes != null && this._supportedDeploymentModes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SupportedEngineVersions. The list of supported engine versions.
        /// </summary>
        public List<string> SupportedEngineVersions
        {
            get { return this._supportedEngineVersions; }
            set { this._supportedEngineVersions = value; }
        }

        // Check to see if SupportedEngineVersions property is set
        internal bool IsSetSupportedEngineVersions()
        {
            return this._supportedEngineVersions != null && this._supportedEngineVersions.Count > 0; 
        }

    }
}