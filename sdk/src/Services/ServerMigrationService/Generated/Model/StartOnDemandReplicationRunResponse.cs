/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// This is the response object from the StartOnDemandReplicationRun operation.
    /// </summary>
    public partial class StartOnDemandReplicationRunResponse : AmazonWebServiceResponse
    {
        private string _replicationRunId;

        /// <summary>
        /// Gets and sets the property ReplicationRunId. 
        /// <para>
        /// The identifier of the replication run.
        /// </para>
        /// </summary>
        public string ReplicationRunId
        {
            get { return this._replicationRunId; }
            set { this._replicationRunId = value; }
        }

        // Check to see if ReplicationRunId property is set
        internal bool IsSetReplicationRunId()
        {
            return this._replicationRunId != null;
        }

    }
}