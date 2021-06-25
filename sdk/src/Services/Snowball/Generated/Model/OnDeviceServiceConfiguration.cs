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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// An object that represents metadata and configuration settings for services on an AWS
    /// Snow Family device.
    /// </summary>
    public partial class OnDeviceServiceConfiguration
    {
        private NFSOnDeviceServiceConfiguration _nfsOnDeviceService;

        /// <summary>
        /// Gets and sets the property NFSOnDeviceService. 
        /// <para>
        /// Represents the NFS service on a Snow Family device.
        /// </para>
        /// </summary>
        public NFSOnDeviceServiceConfiguration NFSOnDeviceService
        {
            get { return this._nfsOnDeviceService; }
            set { this._nfsOnDeviceService = value; }
        }

        // Check to see if NFSOnDeviceService property is set
        internal bool IsSetNFSOnDeviceService()
        {
            return this._nfsOnDeviceService != null;
        }

    }
}