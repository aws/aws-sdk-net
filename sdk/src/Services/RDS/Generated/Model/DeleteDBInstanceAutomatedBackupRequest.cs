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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDBInstanceAutomatedBackup operation.
    /// Deletes automated backups using the <c>DbiResourceId</c> value of the source DB instance
    /// or the Amazon Resource Name (ARN) of the automated backups.
    /// </summary>
    public partial class DeleteDBInstanceAutomatedBackupRequest : AmazonRDSRequest
    {
        private string _dbInstanceAutomatedBackupsArn;
        private string _dbiResourceId;

        /// <summary>
        /// Gets and sets the property DBInstanceAutomatedBackupsArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the automated backups to delete, for example, <c>arn:aws:rds:us-east-1:123456789012:auto-backup:ab-L2IJCEXJP7XQ7HOJ4SIEXAMPLE</c>.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to RDS Custom.
        /// </para>
        /// </summary>
        public string DBInstanceAutomatedBackupsArn
        {
            get { return this._dbInstanceAutomatedBackupsArn; }
            set { this._dbInstanceAutomatedBackupsArn = value; }
        }

        // Check to see if DBInstanceAutomatedBackupsArn property is set
        internal bool IsSetDBInstanceAutomatedBackupsArn()
        {
            return this._dbInstanceAutomatedBackupsArn != null;
        }

        /// <summary>
        /// Gets and sets the property DbiResourceId. 
        /// <para>
        /// The identifier for the source DB instance, which can't be changed and which is unique
        /// to an Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string DbiResourceId
        {
            get { return this._dbiResourceId; }
            set { this._dbiResourceId = value; }
        }

        // Check to see if DbiResourceId property is set
        internal bool IsSetDbiResourceId()
        {
            return this._dbiResourceId != null;
        }

    }
}