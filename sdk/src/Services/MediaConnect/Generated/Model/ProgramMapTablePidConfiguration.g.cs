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
    /// The configuration settings for the Program Map Table (PMT) Packet ID (PID).
    /// </summary>
    public partial class ProgramMapTablePidConfiguration
    {
        /// <summary>
        /// Gets and sets the property Passthrough. 
        /// <para>
        /// The PMT PID configuration that passes through the PMT PID from the source.
        /// </para>
        /// </summary>
        public Passthrough Passthrough { get; set; }

        /// <summary>
        /// Checks to see if the Passthrough property is set.
        /// </summary>
        internal bool IsSetPassthrough() => this.Passthrough != null;

        /// <summary>
        /// Gets and sets the property Set. 
        /// <para>
        /// The PMT PID to use for the router output. If you also set the PCR PID, the two values
        /// must be different.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 8190)]
        public int? Set { get; set; }

        /// <summary>
        /// Checks to see if the Set property is set.
        /// </summary>
        internal bool IsSetSet() => this.Set.HasValue;
    }
}
