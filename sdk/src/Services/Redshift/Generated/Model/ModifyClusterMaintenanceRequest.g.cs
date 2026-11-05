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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyClusterMaintenance operation. Modifies the
    /// maintenance settings of a cluster.
    /// </summary>
    public partial class ModifyClusterMaintenanceRequest : AmazonRedshiftRequest
    {
        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// A unique identifier for the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public string ClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetClusterIdentifier() => this.ClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property DeferMaintenance. 
        /// <para>
        /// A boolean indicating whether to enable the deferred maintenance window. 
        /// </para>
        /// </summary>
        public bool? DeferMaintenance { get; set; }

        /// <summary>
        /// Checks to see if the DeferMaintenance property is set.
        /// </summary>
        internal bool IsSetDeferMaintenance() => this.DeferMaintenance.HasValue;

        /// <summary>
        /// Gets and sets the property DeferMaintenanceDuration. 
        /// <para>
        /// An integer indicating the duration of the maintenance window in days. If you specify
        /// a duration, you can't specify an end time. The duration must be 60 days or less.
        /// </para>
        /// </summary>
        public int? DeferMaintenanceDuration { get; set; }

        /// <summary>
        /// Checks to see if the DeferMaintenanceDuration property is set.
        /// </summary>
        internal bool IsSetDeferMaintenanceDuration() => this.DeferMaintenanceDuration.HasValue;

        /// <summary>
        /// Gets and sets the property DeferMaintenanceEndTime. 
        /// <para>
        /// A timestamp indicating end time for the deferred maintenance window. If you specify
        /// an end time, you can't specify a duration.
        /// </para>
        /// </summary>
        public DateTime? DeferMaintenanceEndTime { get; set; }

        /// <summary>
        /// Checks to see if the DeferMaintenanceEndTime property is set.
        /// </summary>
        internal bool IsSetDeferMaintenanceEndTime() => this.DeferMaintenanceEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property DeferMaintenanceIdentifier. 
        /// <para>
        /// A unique identifier for the deferred maintenance window.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string DeferMaintenanceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DeferMaintenanceIdentifier property is set.
        /// </summary>
        internal bool IsSetDeferMaintenanceIdentifier() => this.DeferMaintenanceIdentifier != null;

        /// <summary>
        /// Gets and sets the property DeferMaintenanceStartTime. 
        /// <para>
        /// A timestamp indicating the start time for the deferred maintenance window.
        /// </para>
        /// </summary>
        public DateTime? DeferMaintenanceStartTime { get; set; }

        /// <summary>
        /// Checks to see if the DeferMaintenanceStartTime property is set.
        /// </summary>
        internal bool IsSetDeferMaintenanceStartTime() => this.DeferMaintenanceStartTime.HasValue;
    }
}
