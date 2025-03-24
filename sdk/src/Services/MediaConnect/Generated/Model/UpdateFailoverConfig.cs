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
    /// The settings for source failover.
    /// </summary>
    public partial class UpdateFailoverConfig
    {
        private FailoverMode _failoverMode;
        private int? _recoveryWindow;
        private SourcePriority _sourcePriority;
        private State _state;

        /// <summary>
        /// Gets and sets the property FailoverMode. 
        /// <para>
        ///  The type of failover you choose for this flow. MERGE combines the source streams
        /// into a single stream, allowing graceful recovery from any single-source loss. FAILOVER
        /// allows switching between different streams.
        /// </para>
        /// </summary>
        public FailoverMode FailoverMode
        {
            get { return this._failoverMode; }
            set { this._failoverMode = value; }
        }

        // Check to see if FailoverMode property is set
        internal bool IsSetFailoverMode()
        {
            return this._failoverMode != null;
        }

        /// <summary>
        /// Gets and sets the property RecoveryWindow. 
        /// <para>
        ///  Recovery window time to look for dash-7 packets.
        /// </para>
        /// </summary>
        public int? RecoveryWindow
        {
            get { return this._recoveryWindow; }
            set { this._recoveryWindow = value; }
        }

        // Check to see if RecoveryWindow property is set
        internal bool IsSetRecoveryWindow()
        {
            return this._recoveryWindow.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourcePriority. 
        /// <para>
        ///  The priority you want to assign to a source. You can have a primary stream and a
        /// backup stream or two equally prioritized streams.
        /// </para>
        /// </summary>
        public SourcePriority SourcePriority
        {
            get { return this._sourcePriority; }
            set { this._sourcePriority = value; }
        }

        // Check to see if SourcePriority property is set
        internal bool IsSetSourcePriority()
        {
            return this._sourcePriority != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of source failover on the flow. If the state is inactive, the flow can have
        /// only one source. If the state is active, the flow can have one or two sources. 
        /// </para>
        /// </summary>
        public State State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}