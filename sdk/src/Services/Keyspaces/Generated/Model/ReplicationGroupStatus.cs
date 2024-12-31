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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
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
namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// This shows the summary status of the keyspace after a new Amazon Web Services Region
    /// was added.
    /// </summary>
    public partial class ReplicationGroupStatus
    {
        private KeyspaceStatus _keyspaceStatus;
        private string _region;
        private string _tablesReplicationProgress;

        /// <summary>
        /// Gets and sets the property KeyspaceStatus. 
        /// <para>
        ///  The status of the keyspace. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KeyspaceStatus KeyspaceStatus
        {
            get { return this._keyspaceStatus; }
            set { this._keyspaceStatus = value; }
        }

        // Check to see if KeyspaceStatus property is set
        internal bool IsSetKeyspaceStatus()
        {
            return this._keyspaceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        ///  The name of the Region that was added to the keyspace. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=25)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property TablesReplicationProgress. 
        /// <para>
        ///  This shows the replication progress of tables in the keyspace. The value is expressed
        /// as a percentage of the newly replicated tables with status <c>Active</c> compared
        /// to the total number of tables in the keyspace. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=7)]
        public string TablesReplicationProgress
        {
            get { return this._tablesReplicationProgress; }
            set { this._tablesReplicationProgress = value; }
        }

        // Check to see if TablesReplicationProgress property is set
        internal bool IsSetTablesReplicationProgress()
        {
            return this._tablesReplicationProgress != null;
        }

    }
}