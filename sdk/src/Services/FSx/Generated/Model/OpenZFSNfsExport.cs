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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// The Network File System (NFS) configurations for mounting an Amazon FSx for OpenZFS
    /// file system.
    /// </summary>
    public partial class OpenZFSNfsExport
    {
        private List<OpenZFSClientConfiguration> _clientConfigurations = new List<OpenZFSClientConfiguration>();

        /// <summary>
        /// Gets and sets the property ClientConfigurations. 
        /// <para>
        /// A list of configuration objects that contain the client and options for mounting the
        /// OpenZFS file system. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=25)]
        public List<OpenZFSClientConfiguration> ClientConfigurations
        {
            get { return this._clientConfigurations; }
            set { this._clientConfigurations = value; }
        }

        // Check to see if ClientConfigurations property is set
        internal bool IsSetClientConfigurations()
        {
            return this._clientConfigurations != null && this._clientConfigurations.Count > 0; 
        }

    }
}