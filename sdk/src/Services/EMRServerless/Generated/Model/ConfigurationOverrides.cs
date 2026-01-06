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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
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
namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// A configuration specification to be used to override existing configurations.
    /// </summary>
    public partial class ConfigurationOverrides
    {
        private List<Configuration> _applicationConfiguration = AWSConfigs.InitializeCollections ? new List<Configuration>() : null;
        private DiskEncryptionConfiguration _diskEncryptionConfiguration;
        private MonitoringConfiguration _monitoringConfiguration;

        /// <summary>
        /// Gets and sets the property ApplicationConfiguration. 
        /// <para>
        /// The override configurations for the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<Configuration> ApplicationConfiguration
        {
            get { return this._applicationConfiguration; }
            set { this._applicationConfiguration = value; }
        }

        // Check to see if ApplicationConfiguration property is set
        internal bool IsSetApplicationConfiguration()
        {
            return this._applicationConfiguration != null && (this._applicationConfiguration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DiskEncryptionConfiguration. 
        /// <para>
        /// The override configuration to encrypt local disks.
        /// </para>
        /// </summary>
        public DiskEncryptionConfiguration DiskEncryptionConfiguration
        {
            get { return this._diskEncryptionConfiguration; }
            set { this._diskEncryptionConfiguration = value; }
        }

        // Check to see if DiskEncryptionConfiguration property is set
        internal bool IsSetDiskEncryptionConfiguration()
        {
            return this._diskEncryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MonitoringConfiguration. 
        /// <para>
        /// The override configurations for monitoring.
        /// </para>
        /// </summary>
        public MonitoringConfiguration MonitoringConfiguration
        {
            get { return this._monitoringConfiguration; }
            set { this._monitoringConfiguration = value; }
        }

        // Check to see if MonitoringConfiguration property is set
        internal bool IsSetMonitoringConfiguration()
        {
            return this._monitoringConfiguration != null;
        }

    }
}