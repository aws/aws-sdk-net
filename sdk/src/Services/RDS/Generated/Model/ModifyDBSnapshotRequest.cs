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
    /// Container for the parameters to the ModifyDBSnapshot operation.
    /// Updates a manual DB snapshot with a new engine version. The snapshot can be encrypted
    /// or unencrypted, but not shared or public. 
    /// 
    ///  
    /// <para>
    /// Amazon RDS supports upgrading DB snapshots for MariaDB, MySQL, PostgreSQL, and Oracle.
    /// This operation doesn't apply to RDS Custom or RDS for Db2.
    /// </para>
    /// </summary>
    public partial class ModifyDBSnapshotRequest : AmazonRDSRequest
    {
        private string _dbSnapshotIdentifier;
        private string _engineVersion;
        private string _optionGroupName;

        /// <summary>
        /// Gets and sets the property DBSnapshotIdentifier. 
        /// <para>
        /// The identifier of the DB snapshot to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBSnapshotIdentifier
        {
            get { return this._dbSnapshotIdentifier; }
            set { this._dbSnapshotIdentifier = value; }
        }

        // Check to see if DBSnapshotIdentifier property is set
        internal bool IsSetDBSnapshotIdentifier()
        {
            return this._dbSnapshotIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The engine version to upgrade the DB snapshot to.
        /// </para>
        ///  
        /// <para>
        /// The following are the database engines and engine versions that are available when
        /// you upgrade a DB snapshot.
        /// </para>
        ///  
        /// <para>
        ///  <b>MariaDB</b> 
        /// </para>
        ///  
        /// <para>
        /// For the list of engine versions that are available for upgrading a DB snapshot, see
        /// <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/mariadb-upgrade-snapshot.html">
        /// Upgrading a MariaDB DB snapshot engine version</a> in the <i>Amazon RDS User Guide.</i>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>MySQL</b> 
        /// </para>
        ///  
        /// <para>
        /// For the list of engine versions that are available for upgrading a DB snapshot, see
        /// <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/mysql-upgrade-snapshot.html">
        /// Upgrading a MySQL DB snapshot engine version</a> in the <i>Amazon RDS User Guide.</i>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>Oracle</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>21.0.0.0.ru-2025-04.rur-2025-04.r1</c> (supported for 21.0.0.0.ru-2022-01.rur-2022-01.r1,
        /// 21.0.0.0.ru-2022-04.rur-2022-04.r1, 21.0.0.0.ru-2022-07.rur-2022-07.r1, 21.0.0.0.ru-2022-10.rur-2022-10.r1,
        /// 21.0.0.0.ru-2023-01.rur-2023-01.r1 and 21.0.0.0.ru-2023-01.rur-2023-01.r2 DB snapshots)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>19.0.0.0.ru-2025-04.rur-2025-04.r1</c> (supported for 19.0.0.0.ru-2019-07.rur-2019-07.r1,
        /// 19.0.0.0.ru-2019-10.rur-2019-10.r1 and 0.0.0.ru-2020-01.rur-2020-01.r1 DB snapshots)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>19.0.0.0.ru-2022-01.rur-2022-01.r1</c> (supported for 12.2.0.1 DB snapshots)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>19.0.0.0.ru-2022-07.rur-2022-07.r1</c> (supported for 12.1.0.2 DB snapshots)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>12.1.0.2.v8</c> (supported for 12.1.0.1 DB snapshots)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>11.2.0.4.v12</c> (supported for 11.2.0.2 DB snapshots)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>11.2.0.4.v11</c> (supported for 11.2.0.3 DB snapshots)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>PostgreSQL</b> 
        /// </para>
        ///  
        /// <para>
        /// For the list of engine versions that are available for upgrading a DB snapshot, see
        /// <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_UpgradeDBSnapshot.PostgreSQL.html">
        /// Upgrading a PostgreSQL DB snapshot engine version</a> in the <i>Amazon RDS User Guide.</i>
        /// 
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property OptionGroupName. 
        /// <para>
        /// The option group to identify with the upgraded DB snapshot.
        /// </para>
        ///  
        /// <para>
        /// You can specify this parameter when you upgrade an Oracle DB snapshot. The same option
        /// group considerations apply when upgrading a DB snapshot as when upgrading a DB instance.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_UpgradeDBInstance.Oracle.html#USER_UpgradeDBInstance.Oracle.OGPG.OG">Option
        /// group considerations</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        public string OptionGroupName
        {
            get { return this._optionGroupName; }
            set { this._optionGroupName = value; }
        }

        // Check to see if OptionGroupName property is set
        internal bool IsSetOptionGroupName()
        {
            return this._optionGroupName != null;
        }

    }
}