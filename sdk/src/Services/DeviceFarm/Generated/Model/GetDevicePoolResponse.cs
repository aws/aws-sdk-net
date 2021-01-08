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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Represents the result of a get device pool request.
    /// </summary>
    public partial class GetDevicePoolResponse : AmazonWebServiceResponse
    {
        private DevicePool _devicePool;

        /// <summary>
        /// Gets and sets the property DevicePool. 
        /// <para>
        /// An object that contains information about the requested device pool.
        /// </para>
        /// </summary>
        public DevicePool DevicePool
        {
            get { return this._devicePool; }
            set { this._devicePool = value; }
        }

        // Check to see if DevicePool property is set
        internal bool IsSetDevicePool()
        {
            return this._devicePool != null;
        }

    }
}