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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// A data volume used in a job's container properties.
    /// </summary>
    public partial class Volume
    {
        private Host _host;
        private string _name;

        /// <summary>
        /// Gets and sets the property Host. 
        /// <para>
        /// The contents of the <code>host</code> parameter determine whether your data volume
        /// persists on the host container instance and where it is stored. If the host parameter
        /// is empty, then the Docker daemon assigns a host path for your data volume. However,
        /// the data isn't guaranteed to persist after the containers associated with it stop
        /// running.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs running on Fargate resources and shouldn't
        /// be provided.
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
        /// The name of the volume. Up to 255 letters (uppercase and lowercase), numbers, hyphens,
        /// and underscores are allowed. This name is referenced in the <code>sourceVolume</code>
        /// parameter of container definition <code>mountPoints</code>.
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