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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the GetOTAUpdate operation.
    /// Gets an OTA update.
    /// </summary>
    public partial class GetOTAUpdateRequest : AmazonIoTRequest
    {
        private string _otaUpdateId;

        /// <summary>
        /// Gets and sets the property OtaUpdateId. 
        /// <para>
        /// The OTA update ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string OtaUpdateId
        {
            get { return this._otaUpdateId; }
            set { this._otaUpdateId = value; }
        }

        // Check to see if OtaUpdateId property is set
        internal bool IsSetOtaUpdateId()
        {
            return this._otaUpdateId != null;
        }

    }
}