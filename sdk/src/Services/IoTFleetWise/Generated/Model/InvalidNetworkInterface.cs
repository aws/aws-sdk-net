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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
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
namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// A reason a vehicle network interface isn't valid.
    /// </summary>
    public partial class InvalidNetworkInterface
    {
        private string _interfaceId;
        private NetworkInterfaceFailureReason _reason;

        /// <summary>
        /// Gets and sets the property InterfaceId. 
        /// <para>
        /// The ID of the interface that isn't valid.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string InterfaceId
        {
            get { return this._interfaceId; }
            set { this._interfaceId = value; }
        }

        // Check to see if InterfaceId property is set
        internal bool IsSetInterfaceId()
        {
            return this._interfaceId != null;
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// A message about why the interface isn't valid. 
        /// </para>
        /// </summary>
        public NetworkInterfaceFailureReason Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

    }
}