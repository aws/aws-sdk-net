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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains a gateway's platform information.
    /// </summary>
    public partial class GatewayPlatform
    {
        private Greengrass _greengrass;
        private GreengrassV2 _greengrassv2;

        /// <summary>
        /// Gets and sets the property Greengrass. 
        /// <para>
        /// A gateway that runs on IoT Greengrass.
        /// </para>
        /// </summary>
        public Greengrass Greengrass
        {
            get { return this._greengrass; }
            set { this._greengrass = value; }
        }

        // Check to see if Greengrass property is set
        internal bool IsSetGreengrass()
        {
            return this._greengrass != null;
        }

        /// <summary>
        /// Gets and sets the property GreengrassV2. 
        /// <para>
        /// A gateway that runs on IoT Greengrass V2.
        /// </para>
        /// </summary>
        public GreengrassV2 GreengrassV2
        {
            get { return this._greengrassv2; }
            set { this._greengrassv2 = value; }
        }

        // Check to see if GreengrassV2 property is set
        internal bool IsSetGreengrassV2()
        {
            return this._greengrassv2 != null;
        }

    }
}