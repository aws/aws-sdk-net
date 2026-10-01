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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
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
namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Evaluation cadence. {@code intervalSeconds} must be one of {30, 60, 120, 300, 600,
    /// 900, 1800, 3600}; {@code pendingDurationSeconds} and {@code recoveryDurationSeconds}
    /// must be multiples of {@code intervalSeconds}. A duration of 0 means fire/clear immediately
    /// with no delay.
    /// 
    ///  
    /// <para>
    /// On UpdateAlert a supplied evaluation block is replaced whole, not merged: an omitted
    /// {@code pendingDurationSeconds} or {@code recoveryDurationSeconds} is cleared to unset
    /// (no such duration), not preserved and not defaulted to 0. {@code intervalSeconds}
    /// is required whenever the block is present. All enforced server-side / by the front-door
    /// validator.
    /// </para>
    /// </summary>
    public partial class AlertEvaluation
    {
        private int? _intervalSeconds;
        private int? _pendingDurationSeconds;
        private int? _recoveryDurationSeconds;

        /// <summary>
        /// Gets and sets the property IntervalSeconds. 
        /// <para>
        /// The interval between evaluations, in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? IntervalSeconds
        {
            get { return this._intervalSeconds; }
            set { this._intervalSeconds = value; }
        }

        // Check to see if IntervalSeconds property is set
        internal bool IsSetIntervalSeconds()
        {
            return this._intervalSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PendingDurationSeconds. 
        /// <para>
        /// The duration a breach must persist before the alert fires, in seconds.
        /// </para>
        /// </summary>
        public int? PendingDurationSeconds
        {
            get { return this._pendingDurationSeconds; }
            set { this._pendingDurationSeconds = value; }
        }

        // Check to see if PendingDurationSeconds property is set
        internal bool IsSetPendingDurationSeconds()
        {
            return this._pendingDurationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecoveryDurationSeconds. 
        /// <para>
        /// The duration a recovery must persist before the alert clears, in seconds.
        /// </para>
        /// </summary>
        public int? RecoveryDurationSeconds
        {
            get { return this._recoveryDurationSeconds; }
            set { this._recoveryDurationSeconds = value; }
        }

        // Check to see if RecoveryDurationSeconds property is set
        internal bool IsSetRecoveryDurationSeconds()
        {
            return this._recoveryDurationSeconds.HasValue; 
        }

    }
}