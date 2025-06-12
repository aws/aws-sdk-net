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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about a Docker volume.
    /// </summary>
    public partial class AwsEcsTaskDefinitionVolumesDockerVolumeConfigurationDetails
    {
        private bool? _autoprovision;
        private string _driver;
        private Dictionary<string, string> _driverOpts = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _labels = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _scope;

        /// <summary>
        /// Gets and sets the property Autoprovision. 
        /// <para>
        /// Whether to create the Docker volume automatically if it does not already exist.
        /// </para>
        /// </summary>
        public bool? Autoprovision
        {
            get { return this._autoprovision; }
            set { this._autoprovision = value; }
        }

        // Check to see if Autoprovision property is set
        internal bool IsSetAutoprovision()
        {
            return this._autoprovision.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Driver. 
        /// <para>
        /// The Docker volume driver to use.
        /// </para>
        /// </summary>
        public string Driver
        {
            get { return this._driver; }
            set { this._driver = value; }
        }

        // Check to see if Driver property is set
        internal bool IsSetDriver()
        {
            return this._driver != null;
        }

        /// <summary>
        /// Gets and sets the property DriverOpts. 
        /// <para>
        /// A map of Docker driver-specific options that are passed through.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> DriverOpts
        {
            get { return this._driverOpts; }
            set { this._driverOpts = value; }
        }

        // Check to see if DriverOpts property is set
        internal bool IsSetDriverOpts()
        {
            return this._driverOpts != null && (this._driverOpts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        /// Custom metadata to add to the Docker volume.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Labels
        {
            get { return this._labels; }
            set { this._labels = value; }
        }

        // Check to see if Labels property is set
        internal bool IsSetLabels()
        {
            return this._labels != null && (this._labels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The scope for the Docker volume that determines its lifecycle. Docker volumes that
        /// are scoped to a task are provisioned automatically when the task starts and destroyed
        /// when the task stops. Docker volumes that are shared persist after the task stops.
        /// Valid values are <c>shared</c> or <c>task</c>.
        /// </para>
        /// </summary>
        public string Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

    }
}