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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the StopDBInstanceAutomatedBackupsReplication operation.
    /// Stops automated backup replication for a DB instance.
    /// 
    ///  
    /// <para>
    /// This command doesn't apply to RDS Custom, Aurora MySQL, and Aurora PostgreSQL.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_ReplicateBackups.html">
    /// Replicating Automated Backups to Another Amazon Web Services Region</a> in the <i>Amazon
    /// RDS User Guide.</i> 
    /// </para>
    /// </summary>
    public partial class StopDBInstanceAutomatedBackupsReplicationRequest : AmazonRDSRequest
    {
        private string _sourceDBInstanceArn;

        /// <summary>
        /// Gets and sets the property SourceDBInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source DB instance for which to stop replicating
        /// automate backups, for example, <code>arn:aws:rds:us-west-2:123456789012:db:mydatabase</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceDBInstanceArn
        {
            get { return this._sourceDBInstanceArn; }
            set { this._sourceDBInstanceArn = value; }
        }

        // Check to see if SourceDBInstanceArn property is set
        internal bool IsSetSourceDBInstanceArn()
        {
            return this._sourceDBInstanceArn != null;
        }

    }
}