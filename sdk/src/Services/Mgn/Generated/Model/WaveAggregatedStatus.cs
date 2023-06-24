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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Wave aggregated status.
    /// </summary>
    public partial class WaveAggregatedStatus
    {
        private WaveHealthStatus _healthStatus;
        private string _lastUpdateDateTime;
        private WaveProgressStatus _progressStatus;
        private string _replicationStartedDateTime;
        private long? _totalApplications;

        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// Wave aggregated status health status.
        /// </para>
        /// </summary>
        public WaveHealthStatus HealthStatus
        {
            get { return this._healthStatus; }
            set { this._healthStatus = value; }
        }

        // Check to see if HealthStatus property is set
        internal bool IsSetHealthStatus()
        {
            return this._healthStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateDateTime. 
        /// <para>
        /// Wave aggregated status last update dateTime.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string LastUpdateDateTime
        {
            get { return this._lastUpdateDateTime; }
            set { this._lastUpdateDateTime = value; }
        }

        // Check to see if LastUpdateDateTime property is set
        internal bool IsSetLastUpdateDateTime()
        {
            return this._lastUpdateDateTime != null;
        }

        /// <summary>
        /// Gets and sets the property ProgressStatus. 
        /// <para>
        /// Wave aggregated status progress status.
        /// </para>
        /// </summary>
        public WaveProgressStatus ProgressStatus
        {
            get { return this._progressStatus; }
            set { this._progressStatus = value; }
        }

        // Check to see if ProgressStatus property is set
        internal bool IsSetProgressStatus()
        {
            return this._progressStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationStartedDateTime. 
        /// <para>
        /// DateTime marking when the first source server in the wave started replication.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string ReplicationStartedDateTime
        {
            get { return this._replicationStartedDateTime; }
            set { this._replicationStartedDateTime = value; }
        }

        // Check to see if ReplicationStartedDateTime property is set
        internal bool IsSetReplicationStartedDateTime()
        {
            return this._replicationStartedDateTime != null;
        }

        /// <summary>
        /// Gets and sets the property TotalApplications. 
        /// <para>
        /// Wave aggregated status total applications amount.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long TotalApplications
        {
            get { return this._totalApplications.GetValueOrDefault(); }
            set { this._totalApplications = value; }
        }

        // Check to see if TotalApplications property is set
        internal bool IsSetTotalApplications()
        {
            return this._totalApplications.HasValue; 
        }

    }
}