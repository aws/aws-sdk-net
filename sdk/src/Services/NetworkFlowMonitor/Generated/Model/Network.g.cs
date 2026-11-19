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

namespace Amazon.NetworkFlowMonitor.Model
{
    /// <summary>
    /// The network that an address in a network flow belongs to.
    /// </summary>
    public partial class Network
    {
        /// <summary>
        /// Gets and sets the property AsName. 
        /// <para>
        /// The name of the autonomous system that the network belongs to.
        /// </para>
        /// </summary>
        public string AsName { get; set; }

        /// <summary>
        /// Checks to see if the AsName property is set.
        /// </summary>
        internal bool IsSetAsName() => this.AsName != null;

        /// <summary>
        /// Gets and sets the property AsNumber. 
        /// <para>
        /// The autonomous system number (ASN) of the autonomous system that the network belongs
        /// to.
        /// </para>
        /// </summary>
        public long? AsNumber { get; set; }

        /// <summary>
        /// Checks to see if the AsNumber property is set.
        /// </summary>
        internal bool IsSetAsNumber() => this.AsNumber.HasValue;
    }
}
