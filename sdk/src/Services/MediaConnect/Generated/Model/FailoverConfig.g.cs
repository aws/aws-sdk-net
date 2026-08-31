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
    /// The settings for source failover.
    /// </summary>
    public partial class FailoverConfig
    {
        /// <summary>
        /// Gets and sets the property FailoverMode. 
        /// <para>
        ///  The type of failover you choose for this flow. MERGE combines the source streams
        /// into a single stream, allowing graceful recovery from any single-source loss. FAILOVER
        /// allows switching between different streams.
        /// </para>
        /// </summary>
        public FailoverMode FailoverMode { get; set; }

        /// <summary>
        /// Checks to see if the FailoverMode property is set.
        /// </summary>
        internal bool IsSetFailoverMode() => this.FailoverMode != null;

        /// <summary>
        /// Gets and sets the property RecoveryWindow. 
        /// <para>
        ///  Search window time to look for dash-7 packets.
        /// </para>
        /// </summary>
        public int? RecoveryWindow { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryWindow property is set.
        /// </summary>
        internal bool IsSetRecoveryWindow() => this.RecoveryWindow.HasValue;

        /// <summary>
        /// Gets and sets the property SourcePriority. 
        /// <para>
        ///  The priority you want to assign to a source. You can have a primary stream and a
        /// backup stream or two equally prioritized streams.
        /// </para>
        /// </summary>
        public SourcePriority SourcePriority { get; set; }

        /// <summary>
        /// Checks to see if the SourcePriority property is set.
        /// </summary>
        internal bool IsSetSourcePriority() => this.SourcePriority != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of source failover on the flow. If the state is inactive, the flow can have
        /// only one source. If the state is active, the flow can have one or two sources. 
        /// </para>
        /// </summary>
        public State State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
