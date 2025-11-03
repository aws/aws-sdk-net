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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
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
namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Represents the warm throughput configuration on the stream. This is only present for
    /// On-Demand Kinesis Data Streams in accounts that have <c>MinimumThroughputBillingCommitment</c>
    /// enabled.
    /// </summary>
    public partial class WarmThroughputObject
    {
        private int? _currentMiBps;
        private int? _targetMiBps;

        /// <summary>
        /// Gets and sets the property CurrentMiBps. 
        /// <para>
        /// The current warm throughput value on the stream. This is the write throughput in MiBps
        /// that the stream is currently scaled to handle.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int CurrentMiBps
        {
            get { return this._currentMiBps.GetValueOrDefault(); }
            set { this._currentMiBps = value; }
        }

        // Check to see if CurrentMiBps property is set
        internal bool IsSetCurrentMiBps()
        {
            return this._currentMiBps.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetMiBps. 
        /// <para>
        /// The target warm throughput value on the stream. This indicates that the stream is
        /// currently scaling towards this target value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int TargetMiBps
        {
            get { return this._targetMiBps.GetValueOrDefault(); }
            set { this._targetMiBps = value; }
        }

        // Check to see if TargetMiBps property is set
        internal bool IsSetTargetMiBps()
        {
            return this._targetMiBps.HasValue; 
        }

    }
}