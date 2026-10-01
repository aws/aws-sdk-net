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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Application aggregated status.
    /// </summary>
    public partial class ApplicationAggregatedStatus
    {
        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// Application aggregated status health status.
        /// </para>
        /// </summary>
        public ApplicationHealthStatus HealthStatus { get; set; }

        /// <summary>
        /// Checks to see if the HealthStatus property is set.
        /// </summary>
        internal bool IsSetHealthStatus() => this.HealthStatus != null;

        /// <summary>
        /// Gets and sets the property LastUpdateDateTime. 
        /// <para>
        /// Application aggregated status last update dateTime.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 32)]
        public string LastUpdateDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdateDateTime() => this.LastUpdateDateTime != null;

        /// <summary>
        /// Gets and sets the property ProgressStatus. 
        /// <para>
        /// Application aggregated status progress status.
        /// </para>
        /// </summary>
        public ApplicationProgressStatus ProgressStatus { get; set; }

        /// <summary>
        /// Checks to see if the ProgressStatus property is set.
        /// </summary>
        internal bool IsSetProgressStatus() => this.ProgressStatus != null;

        /// <summary>
        /// Gets and sets the property TotalSourceServers. 
        /// <para>
        /// Application aggregated status total source servers amount.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? TotalSourceServers { get; set; }

        /// <summary>
        /// Checks to see if the TotalSourceServers property is set.
        /// </summary>
        internal bool IsSetTotalSourceServers() => this.TotalSourceServers.HasValue;
    }
}
