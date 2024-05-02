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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
    /// Container for the parameters to the ModifyClusterMaintenance operation.
    /// Modifies the maintenance settings of a cluster.
    /// </summary>
    public partial class ModifyClusterMaintenanceRequest : AmazonRedshiftRequest
    {
        private string _clusterIdentifier;
        private bool? _deferMaintenance;
        private int? _deferMaintenanceDuration;
        private DateTime? _deferMaintenanceEndTime;
        private string _deferMaintenanceIdentifier;
        private DateTime? _deferMaintenanceStartTime;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// A unique identifier for the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DeferMaintenance. 
        /// <para>
        /// A boolean indicating whether to enable the deferred maintenance window. 
        /// </para>
        /// </summary>
        public bool? DeferMaintenance
        {
            get { return this._deferMaintenance; }
            set { this._deferMaintenance = value; }
        }

        // Check to see if DeferMaintenance property is set
        internal bool IsSetDeferMaintenance()
        {
            return this._deferMaintenance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeferMaintenanceDuration. 
        /// <para>
        /// An integer indicating the duration of the maintenance window in days. If you specify
        /// a duration, you can't specify an end time. The duration must be 45 days or less.
        /// </para>
        /// </summary>
        public int? DeferMaintenanceDuration
        {
            get { return this._deferMaintenanceDuration; }
            set { this._deferMaintenanceDuration = value; }
        }

        // Check to see if DeferMaintenanceDuration property is set
        internal bool IsSetDeferMaintenanceDuration()
        {
            return this._deferMaintenanceDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeferMaintenanceEndTime. 
        /// <para>
        /// A timestamp indicating end time for the deferred maintenance window. If you specify
        /// an end time, you can't specify a duration.
        /// </para>
        /// </summary>
        public DateTime? DeferMaintenanceEndTime
        {
            get { return this._deferMaintenanceEndTime; }
            set { this._deferMaintenanceEndTime = value; }
        }

        // Check to see if DeferMaintenanceEndTime property is set
        internal bool IsSetDeferMaintenanceEndTime()
        {
            return this._deferMaintenanceEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeferMaintenanceIdentifier. 
        /// <para>
        /// A unique identifier for the deferred maintenance window.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string DeferMaintenanceIdentifier
        {
            get { return this._deferMaintenanceIdentifier; }
            set { this._deferMaintenanceIdentifier = value; }
        }

        // Check to see if DeferMaintenanceIdentifier property is set
        internal bool IsSetDeferMaintenanceIdentifier()
        {
            return this._deferMaintenanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DeferMaintenanceStartTime. 
        /// <para>
        /// A timestamp indicating the start time for the deferred maintenance window.
        /// </para>
        /// </summary>
        public DateTime? DeferMaintenanceStartTime
        {
            get { return this._deferMaintenanceStartTime; }
            set { this._deferMaintenanceStartTime = value; }
        }

        // Check to see if DeferMaintenanceStartTime property is set
        internal bool IsSetDeferMaintenanceStartTime()
        {
            return this._deferMaintenanceStartTime.HasValue; 
        }

    }
}