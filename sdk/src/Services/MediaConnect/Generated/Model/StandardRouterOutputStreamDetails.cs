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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Configuration details for a standard router output stream type. Contains information
    /// about the destination IP address and connection state for basic output routing.
    /// </summary>
    public partial class StandardRouterOutputStreamDetails
    {
        private string _destinationIpAddress;

        /// <summary>
        /// Gets and sets the property DestinationIpAddress. 
        /// <para>
        /// The IP address where the output stream will be sent. This is the destination address
        /// that will receive the routed media content.
        /// </para>
        /// </summary>
        public string DestinationIpAddress
        {
            get { return this._destinationIpAddress; }
            set { this._destinationIpAddress = value; }
        }

        // Check to see if DestinationIpAddress property is set
        internal bool IsSetDestinationIpAddress()
        {
            return this._destinationIpAddress != null;
        }

    }
}