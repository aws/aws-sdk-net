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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
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
namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// A configuration specification to be used to override existing configurations. This
    /// data type allows job template parameters to be specified within.
    /// </summary>
    public partial class ParametricConfigurationOverrides
    {
        private List<Configuration> _applicationConfiguration = AWSConfigs.InitializeCollections ? new List<Configuration>() : null;
        private ParametricMonitoringConfiguration _monitoringConfiguration;

        /// <summary>
        /// Gets and sets the property ApplicationConfiguration. 
        /// <para>
        ///  The configurations for the application running by the job run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
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
        /// Gets and sets the property MonitoringConfiguration. 
        /// <para>
        ///  The configurations for monitoring. 
        /// </para>
        /// </summary>
        public ParametricMonitoringConfiguration MonitoringConfiguration
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