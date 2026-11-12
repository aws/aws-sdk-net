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
    /// The fabric configuration settings for the router output.
    /// </summary>
    public partial class FabricConfiguration
    {
        /// <summary>
        /// Gets and sets the property RecoveryLatencyMode. 
        /// <para>
        /// The recovery latency mode for the router fabric connection. Valid values include the
        /// following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BALANCED</c> (default) – Optimizes for stream quality.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LOW_LATENCY</c> – Reduces latency at the potential cost of stream quality under
        /// adverse network conditions.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public FabricLatencyMode RecoveryLatencyMode { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryLatencyMode property is set.
        /// </summary>
        internal bool IsSetRecoveryLatencyMode() => this.RecoveryLatencyMode != null;

        /// <summary>
        /// Gets and sets the property SwitchingConfiguration. 
        /// <para>
        /// The configuration settings for the switching mode.
        /// </para>
        /// </summary>
        public FabricSwitchingConfiguration SwitchingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SwitchingConfiguration property is set.
        /// </summary>
        internal bool IsSetSwitchingConfiguration() => this.SwitchingConfiguration != null;

        /// <summary>
        /// Gets and sets the property SwitchingMode. 
        /// <para>
        /// The switching mode that the router output uses when it switches to a new router input.
        /// Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IMMEDIATE</c> (default) – Switches to the new router input immediately.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KEY_FRAME</c> – Waits for a key frame on the new router input before it switches.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify it, it must match the switching configuration.
        /// </para>
        /// </summary>
        public FabricSwitchingMode SwitchingMode { get; set; }

        /// <summary>
        /// Checks to see if the SwitchingMode property is set.
        /// </summary>
        internal bool IsSetSwitchingMode() => this.SwitchingMode != null;
    }
}
