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
    /// This is the response object from the GetReplicationRuns operation.
    /// </summary>
    public partial class GetReplicationRunsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private ReplicationJob _replicationJob;
        private List<ReplicationRun> _replicationRunList = new List<ReplicationRun>();

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationJob.
        /// </summary>
        public ReplicationJob ReplicationJob
        {
            get { return this._replicationJob; }
            set { this._replicationJob = value; }
        }

        // Check to see if ReplicationJob property is set
        internal bool IsSetReplicationJob()
        {
            return this._replicationJob != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationRunList.
        /// </summary>
        public List<ReplicationRun> ReplicationRunList
        {
            get { return this._replicationRunList; }
            set { this._replicationRunList = value; }
        }

        // Check to see if ReplicationRunList property is set
        internal bool IsSetReplicationRunList()
        {
            return this._replicationRunList != null && this._replicationRunList.Count > 0; 
        }

    }
}