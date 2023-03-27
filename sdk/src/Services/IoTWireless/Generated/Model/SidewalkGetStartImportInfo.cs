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

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Sidewalk-related information for devices in an import task that are being onboarded.
    /// </summary>
    public partial class SidewalkGetStartImportInfo
    {
        private List<string> _deviceCreationFileList = new List<string>();
        private string _role;

        /// <summary>
        /// Gets and sets the property DeviceCreationFileList. 
        /// <para>
        /// List of Sidewalk devices that are added to the import task.
        /// </para>
        /// </summary>
        public List<string> DeviceCreationFileList
        {
            get { return this._deviceCreationFileList; }
            set { this._deviceCreationFileList = value; }
        }

        // Check to see if DeviceCreationFileList property is set
        internal bool IsSetDeviceCreationFileList()
        {
            return this._deviceCreationFileList != null && this._deviceCreationFileList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The IAM role that allows AWS IoT Wireless to access the CSV file in the S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

    }
}