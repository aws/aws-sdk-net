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
    /// Represents the current status of minimum throughput billing commitment for an account.
    /// </summary>
    public partial class MinimumThroughputBillingCommitmentOutput
    {
        private DateTime? _earliestAllowedEndAt;
        private DateTime? _endedAt;
        private DateTime? _startedAt;
        private MinimumThroughputBillingCommitmentOutputStatus _status;

        /// <summary>
        /// Gets and sets the property EarliestAllowedEndAt. 
        /// <para>
        /// The earliest timestamp when the commitment can be ended.
        /// </para>
        /// </summary>
        public DateTime EarliestAllowedEndAt
        {
            get { return this._earliestAllowedEndAt.GetValueOrDefault(); }
            set { this._earliestAllowedEndAt = value; }
        }

        // Check to see if EarliestAllowedEndAt property is set
        internal bool IsSetEarliestAllowedEndAt()
        {
            return this._earliestAllowedEndAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The timestamp when the commitment was ended.
        /// </para>
        /// </summary>
        public DateTime EndedAt
        {
            get { return this._endedAt.GetValueOrDefault(); }
            set { this._endedAt = value; }
        }

        // Check to see if EndedAt property is set
        internal bool IsSetEndedAt()
        {
            return this._endedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp when the commitment was started.
        /// </para>
        /// </summary>
        public DateTime StartedAt
        {
            get { return this._startedAt.GetValueOrDefault(); }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the minimum throughput billing commitment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MinimumThroughputBillingCommitmentOutputStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}