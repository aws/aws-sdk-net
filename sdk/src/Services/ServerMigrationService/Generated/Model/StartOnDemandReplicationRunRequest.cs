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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the StartOnDemandReplicationRun operation.
    /// Starts an on-demand replication run for the specified replication job. This replication
    /// run starts immediately. This replication run is in addition to the ones already scheduled.
    /// 
    ///  
    /// <para>
    /// There is a limit on the number of on-demand replications runs that you can request
    /// in a 24-hour period.
    /// </para>
    /// </summary>
    public partial class StartOnDemandReplicationRunRequest : AmazonServerMigrationServiceRequest
    {
        private string _description;
        private string _replicationJobId;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the replication run.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationJobId. 
        /// <para>
        /// The ID of the replication job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReplicationJobId
        {
            get { return this._replicationJobId; }
            set { this._replicationJobId = value; }
        }

        // Check to see if ReplicationJobId property is set
        internal bool IsSetReplicationJobId()
        {
            return this._replicationJobId != null;
        }

    }
}