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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about a Docker volume.
    /// </summary>
    public partial class AwsEcsTaskDefinitionVolumesDockerVolumeConfigurationDetails
    {
        /// <summary>
        /// Gets and sets the property Autoprovision. 
        /// <para>
        /// Whether to create the Docker volume automatically if it does not already exist.
        /// </para>
        /// </summary>
        public bool? Autoprovision { get; set; }

        /// <summary>
        /// Checks to see if the Autoprovision property is set.
        /// </summary>
        internal bool IsSetAutoprovision() => this.Autoprovision.HasValue;

        /// <summary>
        /// Gets and sets the property Driver. 
        /// <para>
        /// The Docker volume driver to use.
        /// </para>
        /// </summary>
        public string Driver { get; set; }

        /// <summary>
        /// Checks to see if the Driver property is set.
        /// </summary>
        internal bool IsSetDriver() => this.Driver != null;

        /// <summary>
        /// Gets and sets the property DriverOpts. 
        /// <para>
        /// A map of Docker driver-specific options that are passed through.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> DriverOpts { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the DriverOpts property is set.
        /// </summary>
        internal bool IsSetDriverOpts() => this.DriverOpts != null && (this.DriverOpts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        /// Custom metadata to add to the Docker volume.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Labels { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Labels property is set.
        /// </summary>
        internal bool IsSetLabels() => this.Labels != null && (this.Labels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The scope for the Docker volume that determines its lifecycle. Docker volumes that
        /// are scoped to a task are provisioned automatically when the task starts and destroyed
        /// when the task stops. Docker volumes that are shared persist after the task stops.
        /// Valid values are <c>shared</c> or <c>task</c>.
        /// </para>
        /// </summary>
        public string Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;
    }
}
