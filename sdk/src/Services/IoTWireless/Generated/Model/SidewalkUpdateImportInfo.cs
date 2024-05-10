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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
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
namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Sidewalk object information for updating an import task.
    /// </summary>
    public partial class SidewalkUpdateImportInfo
    {
        private string _deviceCreationFile;

        /// <summary>
        /// Gets and sets the property DeviceCreationFile. 
        /// <para>
        /// The CSV file contained in an S3 bucket that's used for appending devices to an existing
        /// import task.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string DeviceCreationFile
        {
            get { return this._deviceCreationFile; }
            set { this._deviceCreationFile = value; }
        }

        // Check to see if DeviceCreationFile property is set
        internal bool IsSetDeviceCreationFile()
        {
            return this._deviceCreationFile != null;
        }

    }
}