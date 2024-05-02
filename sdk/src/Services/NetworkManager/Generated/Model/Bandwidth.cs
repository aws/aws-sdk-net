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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
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
namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes bandwidth information.
    /// </summary>
    public partial class Bandwidth
    {
        private int? _downloadSpeed;
        private int? _uploadSpeed;

        /// <summary>
        /// Gets and sets the property DownloadSpeed. 
        /// <para>
        /// Download speed in Mbps.
        /// </para>
        /// </summary>
        public int? DownloadSpeed
        {
            get { return this._downloadSpeed; }
            set { this._downloadSpeed = value; }
        }

        // Check to see if DownloadSpeed property is set
        internal bool IsSetDownloadSpeed()
        {
            return this._downloadSpeed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UploadSpeed. 
        /// <para>
        /// Upload speed in Mbps.
        /// </para>
        /// </summary>
        public int? UploadSpeed
        {
            get { return this._uploadSpeed; }
            set { this._uploadSpeed = value; }
        }

        // Check to see if UploadSpeed property is set
        internal bool IsSetUploadSpeed()
        {
            return this._uploadSpeed.HasValue; 
        }

    }
}