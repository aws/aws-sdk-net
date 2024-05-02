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
 * Do not modify this file. This file is generated from the qldb-2019-01-02.normal.json service model.
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
namespace Amazon.QLDB.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLedgerPermissionsMode operation.
    /// Updates the permissions mode of a ledger.
    /// 
    ///  <important> 
    /// <para>
    /// Before you switch to the <c>STANDARD</c> permissions mode, you must first create all
    /// required IAM policies and table tags to avoid disruption to your users. To learn more,
    /// see <a href="https://docs.aws.amazon.com/qldb/latest/developerguide/ledger-management.basics.html#ledger-mgmt.basics.update-permissions.migrating">Migrating
    /// to the standard permissions mode</a> in the <i>Amazon QLDB Developer Guide</i>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UpdateLedgerPermissionsModeRequest : AmazonQLDBRequest
    {
        private string _name;
        private PermissionsMode _permissionsMode;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the ledger.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PermissionsMode. 
        /// <para>
        /// The permissions mode to assign to the ledger. This parameter can have one of the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALLOW_ALL</c>: A legacy permissions mode that enables access control with API-level
        /// granularity for ledgers.
        /// </para>
        ///  
        /// <para>
        /// This mode allows users who have the <c>SendCommand</c> API permission for this ledger
        /// to run all PartiQL commands (hence, <c>ALLOW_ALL</c>) on any tables in the specified
        /// ledger. This mode disregards any table-level or command-level IAM permissions policies
        /// that you create for the ledger.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STANDARD</c>: (<i>Recommended</i>) A permissions mode that enables access control
        /// with finer granularity for ledgers, tables, and PartiQL commands.
        /// </para>
        ///  
        /// <para>
        /// By default, this mode denies all user requests to run any PartiQL commands on any
        /// tables in this ledger. To allow PartiQL commands to run, you must create IAM permissions
        /// policies for specific table resources and PartiQL actions, in addition to the <c>SendCommand</c>
        /// API permission for the ledger. For information, see <a href="https://docs.aws.amazon.com/qldb/latest/developerguide/getting-started-standard-mode.html">Getting
        /// started with the standard permissions mode</a> in the <i>Amazon QLDB Developer Guide</i>.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// We strongly recommend using the <c>STANDARD</c> permissions mode to maximize the security
        /// of your ledger data.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public PermissionsMode PermissionsMode
        {
            get { return this._permissionsMode; }
            set { this._permissionsMode = value; }
        }

        // Check to see if PermissionsMode property is set
        internal bool IsSetPermissionsMode()
        {
            return this._permissionsMode != null;
        }

    }
}