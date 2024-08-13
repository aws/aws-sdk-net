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
    /// Container for the parameters to the DeleteTenantDatabase operation.
    /// Deletes a tenant database from your DB instance. This command only applies to RDS
    /// for Oracle container database (CDB) instances.
    /// 
    ///  
    /// <para>
    /// You can't delete a tenant database when it is the only tenant in the DB instance.
    /// </para>
    /// </summary>
    public partial class DeleteTenantDatabaseRequest : AmazonRDSRequest
    {
        private string _dbInstanceIdentifier;
        private string _finalDBSnapshotIdentifier;
        private bool? _skipFinalSnapshot;
        private string _tenantDBName;

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        /// The user-supplied identifier for the DB instance that contains the tenant database
        /// that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBInstanceIdentifier
        {
            get { return this._dbInstanceIdentifier; }
            set { this._dbInstanceIdentifier = value; }
        }

        // Check to see if DBInstanceIdentifier property is set
        internal bool IsSetDBInstanceIdentifier()
        {
            return this._dbInstanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property FinalDBSnapshotIdentifier. 
        /// <para>
        /// The <c>DBSnapshotIdentifier</c> of the new <c>DBSnapshot</c> created when the <c>SkipFinalSnapshot</c>
        /// parameter is disabled.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you enable this parameter and also enable <c>SkipFinalShapshot</c>, the command
        /// results in an error.
        /// </para>
        ///  </note>
        /// </summary>
        public string FinalDBSnapshotIdentifier
        {
            get { return this._finalDBSnapshotIdentifier; }
            set { this._finalDBSnapshotIdentifier = value; }
        }

        // Check to see if FinalDBSnapshotIdentifier property is set
        internal bool IsSetFinalDBSnapshotIdentifier()
        {
            return this._finalDBSnapshotIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SkipFinalSnapshot. 
        /// <para>
        /// Specifies whether to skip the creation of a final DB snapshot before removing the
        /// tenant database from your DB instance. If you enable this parameter, RDS doesn't create
        /// a DB snapshot. If you don't enable this parameter, RDS creates a DB snapshot before
        /// it deletes the tenant database. By default, RDS doesn't skip the final snapshot. If
        /// you don't enable this parameter, you must specify the <c>FinalDBSnapshotIdentifier</c>
        /// parameter.
        /// </para>
        /// </summary>
        public bool? SkipFinalSnapshot
        {
            get { return this._skipFinalSnapshot; }
            set { this._skipFinalSnapshot = value; }
        }

        // Check to see if SkipFinalSnapshot property is set
        internal bool IsSetSkipFinalSnapshot()
        {
            return this._skipFinalSnapshot.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TenantDBName. 
        /// <para>
        /// The user-supplied name of the tenant database that you want to remove from your DB
        /// instance. Amazon RDS deletes the tenant database with this name. This parameter isn’t
        /// case-sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TenantDBName
        {
            get { return this._tenantDBName; }
            set { this._tenantDBName = value; }
        }

        // Check to see if TenantDBName property is set
        internal bool IsSetTenantDBName()
        {
            return this._tenantDBName != null;
        }

    }
}