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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyClusterSnapshotSchedule operation.
    /// Modifies a snapshot schedule for a cluster.
    /// </summary>
    public partial class ModifyClusterSnapshotScheduleRequest : AmazonRedshiftRequest
    {
        private string _clusterIdentifier;
        private bool? _disassociateSchedule;
        private string _scheduleIdentifier;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// A unique identifier for the cluster whose snapshot schedule you want to modify. 
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
        /// Gets and sets the property DisassociateSchedule. 
        /// <para>
        /// A boolean to indicate whether to remove the assoiciation between the cluster and the
        /// schedule.
        /// </para>
        /// </summary>
        public bool DisassociateSchedule
        {
            get { return this._disassociateSchedule.GetValueOrDefault(); }
            set { this._disassociateSchedule = value; }
        }

        // Check to see if DisassociateSchedule property is set
        internal bool IsSetDisassociateSchedule()
        {
            return this._disassociateSchedule.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScheduleIdentifier. 
        /// <para>
        /// A unique alphanumeric identifier for the schedule that you want to associate with
        /// the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ScheduleIdentifier
        {
            get { return this._scheduleIdentifier; }
            set { this._scheduleIdentifier = value; }
        }

        // Check to see if ScheduleIdentifier property is set
        internal bool IsSetScheduleIdentifier()
        {
            return this._scheduleIdentifier != null;
        }

    }
}