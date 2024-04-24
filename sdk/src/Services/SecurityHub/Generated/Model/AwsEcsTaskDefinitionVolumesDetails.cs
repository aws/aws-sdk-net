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
    /// A data volume to mount from another container.
    /// </summary>
    public partial class AwsEcsTaskDefinitionVolumesDetails
    {
        private AwsEcsTaskDefinitionVolumesDockerVolumeConfigurationDetails _dockerVolumeConfiguration;
        private AwsEcsTaskDefinitionVolumesEfsVolumeConfigurationDetails _efsVolumeConfiguration;
        private AwsEcsTaskDefinitionVolumesHostDetails _host;
        private string _name;

        /// <summary>
        /// Gets and sets the property DockerVolumeConfiguration. 
        /// <para>
        /// Information about a Docker volume.
        /// </para>
        /// </summary>
        public AwsEcsTaskDefinitionVolumesDockerVolumeConfigurationDetails DockerVolumeConfiguration
        {
            get { return this._dockerVolumeConfiguration; }
            set { this._dockerVolumeConfiguration = value; }
        }

        // Check to see if DockerVolumeConfiguration property is set
        internal bool IsSetDockerVolumeConfiguration()
        {
            return this._dockerVolumeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property EfsVolumeConfiguration. 
        /// <para>
        /// Information about the Amazon Elastic File System file system that is used for task
        /// storage.
        /// </para>
        /// </summary>
        public AwsEcsTaskDefinitionVolumesEfsVolumeConfigurationDetails EfsVolumeConfiguration
        {
            get { return this._efsVolumeConfiguration; }
            set { this._efsVolumeConfiguration = value; }
        }

        // Check to see if EfsVolumeConfiguration property is set
        internal bool IsSetEfsVolumeConfiguration()
        {
            return this._efsVolumeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Host. 
        /// <para>
        /// Information about a bind mount host volume.
        /// </para>
        /// </summary>
        public AwsEcsTaskDefinitionVolumesHostDetails Host
        {
            get { return this._host; }
            set { this._host = value; }
        }

        // Check to see if Host property is set
        internal bool IsSetHost()
        {
            return this._host != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data volume.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}