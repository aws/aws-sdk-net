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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// The configuration settings for a router input using the RTMP (Real-Time Messaging
    /// Protocol) protocol.
    /// </summary>
    public partial class RtmpPushRouterInputConfiguration
    {
        /// <summary>
        /// Gets and sets the property NamingConfiguration. 
        /// <para>
        /// The configuration settings for the application and stream names.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RtmpPushNamingConfiguration NamingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NamingConfiguration property is set.
        /// </summary>
        internal bool IsSetNamingConfiguration() => this.NamingConfiguration != null;

        /// <summary>
        /// Gets and sets the property NamingType. 
        /// <para>
        /// The naming type. If you specify it, it must match the naming configuration.
        /// </para>
        /// </summary>
        public RtmpPushNamingType NamingType { get; set; }

        /// <summary>
        /// Checks to see if the NamingType property is set.
        /// </summary>
        internal bool IsSetNamingType() => this.NamingType != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number for the RTMP protocol. The only valid value is <c>1935</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1935, Max = 1935)]
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;
    }
}
