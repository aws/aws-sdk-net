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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// This is the response object from the DescribeReplicationInstanceTaskLogs operation.
    /// </summary>
    public partial class DescribeReplicationInstanceTaskLogsResponse : AmazonWebServiceResponse
    {
        private string _marker;
        private string _replicationInstanceArn;
        private List<ReplicationInstanceTaskLog> _replicationInstanceTaskLogs = new List<ReplicationInstanceTaskLog>();

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        ///  An optional pagination token provided by a previous request. If this parameter is
        /// specified, the response includes only records beyond the marker, up to the value specified
        /// by <code>MaxRecords</code>.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the replication instance.
        /// </para>
        /// </summary>
        public string ReplicationInstanceArn
        {
            get { return this._replicationInstanceArn; }
            set { this._replicationInstanceArn = value; }
        }

        // Check to see if ReplicationInstanceArn property is set
        internal bool IsSetReplicationInstanceArn()
        {
            return this._replicationInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationInstanceTaskLogs. 
        /// <para>
        /// An array of replication task log metadata. Each member of the array contains the replication
        /// task name, ARN, and task log size (in bytes). 
        /// </para>
        /// </summary>
        public List<ReplicationInstanceTaskLog> ReplicationInstanceTaskLogs
        {
            get { return this._replicationInstanceTaskLogs; }
            set { this._replicationInstanceTaskLogs = value; }
        }

        // Check to see if ReplicationInstanceTaskLogs property is set
        internal bool IsSetReplicationInstanceTaskLogs()
        {
            return this._replicationInstanceTaskLogs != null && this._replicationInstanceTaskLogs.Count > 0; 
        }

    }
}