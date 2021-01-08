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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// Information about a dedicated IP address.
    /// </summary>
    public partial class GetDedicatedIpResponse : AmazonWebServiceResponse
    {
        private DedicatedIp _dedicatedIp;

        /// <summary>
        /// Gets and sets the property DedicatedIp. 
        /// <para>
        /// An object that contains information about a dedicated IP address.
        /// </para>
        /// </summary>
        public DedicatedIp DedicatedIp
        {
            get { return this._dedicatedIp; }
            set { this._dedicatedIp = value; }
        }

        // Check to see if DedicatedIp property is set
        internal bool IsSetDedicatedIp()
        {
            return this._dedicatedIp != null;
        }

    }
}