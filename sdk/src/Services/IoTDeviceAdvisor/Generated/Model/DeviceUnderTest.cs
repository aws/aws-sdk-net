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
 * Do not modify this file. This file is generated from the iotdeviceadvisor-2020-09-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTDeviceAdvisor.Model
{
    /// <summary>
    /// Lists all the devices under test
    /// </summary>
    public partial class DeviceUnderTest
    {
        private string _certificateArn;
        private string _thingArn;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// Lists devices certificate arn
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string CertificateArn
        {
            get { return this._certificateArn; }
            set { this._certificateArn = value; }
        }

        // Check to see if CertificateArn property is set
        internal bool IsSetCertificateArn()
        {
            return this._certificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property ThingArn. 
        /// <para>
        /// Lists devices thing arn
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ThingArn
        {
            get { return this._thingArn; }
            set { this._thingArn = value; }
        }

        // Check to see if ThingArn property is set
        internal bool IsSetThingArn()
        {
            return this._thingArn != null;
        }

    }
}