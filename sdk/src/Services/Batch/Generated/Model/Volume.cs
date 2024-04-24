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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// A data volume that's used in a job's container properties.
    /// </summary>
    public partial class Volume
    {
        private EFSVolumeConfiguration _efsVolumeConfiguration;
        private Host _host;
        private string _name;

        /// <summary>
        /// Gets and sets the property EfsVolumeConfiguration. 
        /// <para>
        /// This parameter is specified when you're using an Amazon Elastic File System file system
        /// for job storage. Jobs that are running on Fargate resources must specify a <c>platformVersion</c>
        /// of at least <c>1.4.0</c>.
        /// </para>
        /// </summary>
        public EFSVolumeConfiguration EfsVolumeConfiguration
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
        /// The contents of the <c>host</c> parameter determine whether your data volume persists
        /// on the host container instance and where it's stored. If the host parameter is empty,
        /// then the Docker daemon assigns a host path for your data volume. However, the data
        /// isn't guaranteed to persist after the containers that are associated with it stop
        /// running.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that are running on Fargate resources and
        /// shouldn't be provided.
        /// </para>
        ///  </note>
        /// </summary>
        public Host Host
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
        /// The name of the volume. It can be up to 255 characters long. It can contain uppercase
        /// and lowercase letters, numbers, hyphens (-), and underscores (_). This name is referenced
        /// in the <c>sourceVolume</c> parameter of container definition <c>mountPoints</c>.
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