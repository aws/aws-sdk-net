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
    /// Application aggregated status.
    /// </summary>
    public partial class ApplicationAggregatedStatus
    {
        private ApplicationHealthStatus _healthStatus;
        private string _lastUpdateDateTime;
        private ApplicationProgressStatus _progressStatus;
        private long? _totalSourceServers;

        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// Application aggregated status health status.
        /// </para>
        /// </summary>
        public ApplicationHealthStatus HealthStatus
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
        /// Application aggregated status last update dateTime.
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
        /// Application aggregated status progress status.
        /// </para>
        /// </summary>
        public ApplicationProgressStatus ProgressStatus
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
        /// Gets and sets the property TotalSourceServers. 
        /// <para>
        /// Application aggregated status total source servers amount.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long TotalSourceServers
        {
            get { return this._totalSourceServers.GetValueOrDefault(); }
            set { this._totalSourceServers = value; }
        }

        // Check to see if TotalSourceServers property is set
        internal bool IsSetTotalSourceServers()
        {
            return this._totalSourceServers.HasValue; 
        }

    }
}