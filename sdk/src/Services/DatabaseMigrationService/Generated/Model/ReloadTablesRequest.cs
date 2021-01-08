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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the ReloadTables operation.
    /// Reloads the target database table with the source data.
    /// </summary>
    public partial class ReloadTablesRequest : AmazonDatabaseMigrationServiceRequest
    {
        private ReloadOptionValue _reloadOption;
        private string _replicationTaskArn;
        private List<TableToReload> _tablesToReload = new List<TableToReload>();

        /// <summary>
        /// Gets and sets the property ReloadOption. 
        /// <para>
        /// Options for reload. Specify <code>data-reload</code> to reload the data and re-validate
        /// it if validation is enabled. Specify <code>validate-only</code> to re-validate the
        /// table. This option applies only when validation is enabled for the task. 
        /// </para>
        ///  
        /// <para>
        /// Valid values: data-reload, validate-only
        /// </para>
        ///  
        /// <para>
        /// Default value is data-reload.
        /// </para>
        /// </summary>
        public ReloadOptionValue ReloadOption
        {
            get { return this._reloadOption; }
            set { this._reloadOption = value; }
        }

        // Check to see if ReloadOption property is set
        internal bool IsSetReloadOption()
        {
            return this._reloadOption != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationTaskArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the replication task. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReplicationTaskArn
        {
            get { return this._replicationTaskArn; }
            set { this._replicationTaskArn = value; }
        }

        // Check to see if ReplicationTaskArn property is set
        internal bool IsSetReplicationTaskArn()
        {
            return this._replicationTaskArn != null;
        }

        /// <summary>
        /// Gets and sets the property TablesToReload. 
        /// <para>
        /// The name and schema of the table to be reloaded. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<TableToReload> TablesToReload
        {
            get { return this._tablesToReload; }
            set { this._tablesToReload = value; }
        }

        // Check to see if TablesToReload property is set
        internal bool IsSetTablesToReload()
        {
            return this._tablesToReload != null && this._tablesToReload.Count > 0; 
        }

    }
}