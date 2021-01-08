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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Attributes that define a local device resource.
    /// </summary>
    public partial class LocalDeviceResourceData
    {
        private GroupOwnerSetting _groupOwnerSetting;
        private string _sourcePath;

        /// <summary>
        /// Gets and sets the property GroupOwnerSetting. Group/owner related settings for local
        /// resources.
        /// </summary>
        public GroupOwnerSetting GroupOwnerSetting
        {
            get { return this._groupOwnerSetting; }
            set { this._groupOwnerSetting = value; }
        }

        // Check to see if GroupOwnerSetting property is set
        internal bool IsSetGroupOwnerSetting()
        {
            return this._groupOwnerSetting != null;
        }

        /// <summary>
        /// Gets and sets the property SourcePath. The local absolute path of the device resource.
        /// The source path for a device resource can refer only to a character device or block
        /// device under ''/dev''.
        /// </summary>
        public string SourcePath
        {
            get { return this._sourcePath; }
            set { this._sourcePath = value; }
        }

        // Check to see if SourcePath property is set
        internal bool IsSetSourcePath()
        {
            return this._sourcePath != null;
        }

    }
}