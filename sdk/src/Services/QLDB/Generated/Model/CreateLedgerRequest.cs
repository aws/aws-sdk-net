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

namespace Amazon.QLDB.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLedger operation.
    /// Creates a new ledger in your AWS account in the current Region.
    /// </summary>
    public partial class CreateLedgerRequest : AmazonQLDBRequest
    {
        private bool? _deletionProtection;
        private string _name;
        private PermissionsMode _permissionsMode;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// The flag that prevents a ledger from being deleted by any user. If not provided on
        /// ledger creation, this feature is enabled (<code>true</code>) by default.
        /// </para>
        ///  
        /// <para>
        /// If deletion protection is enabled, you must first disable it before you can delete
        /// the ledger. You can disable it by calling the <code>UpdateLedger</code> operation
        /// to set the flag to <code>false</code>.
        /// </para>
        /// </summary>
        public bool DeletionProtection
        {
            get { return this._deletionProtection.GetValueOrDefault(); }
            set { this._deletionProtection = value; }
        }

        // Check to see if DeletionProtection property is set
        internal bool IsSetDeletionProtection()
        {
            return this._deletionProtection.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the ledger that you want to create. The name must be unique among all
        /// of your ledgers in the current AWS Region.
        /// </para>
        ///  
        /// <para>
        /// Naming constraints for ledger names are defined in <a href="https://docs.aws.amazon.com/qldb/latest/developerguide/limits.html#limits.naming">Quotas
        /// in Amazon QLDB</a> in the <i>Amazon QLDB Developer Guide</i>.
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
        /// The permissions mode to assign to the ledger that you want to create. This parameter
        /// can have one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ALLOW_ALL</code>: A legacy permissions mode that enables access control with
        /// API-level granularity for ledgers.
        /// </para>
        ///  
        /// <para>
        /// This mode allows users who have the <code>SendCommand</code> API permission for this
        /// ledger to run all PartiQL commands (hence, <code>ALLOW_ALL</code>) on any tables in
        /// the specified ledger. This mode disregards any table-level or command-level IAM permissions
        /// policies that you create for the ledger.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>STANDARD</code>: (<i>Recommended</i>) A permissions mode that enables access
        /// control with finer granularity for ledgers, tables, and PartiQL commands.
        /// </para>
        ///  
        /// <para>
        /// By default, this mode denies all user requests to run any PartiQL commands on any
        /// tables in this ledger. To allow PartiQL commands to run, you must create IAM permissions
        /// policies for specific table resources and PartiQL actions, in addition to the <code>SendCommand</code>
        /// API permission for the ledger. For information, see <a href="https://docs.aws.amazon.com/qldb/latest/developerguide/getting-started-standard-mode.html">Getting
        /// started with the standard permissions mode</a> in the <i>Amazon QLDB Developer Guide</i>.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// We strongly recommend using the <code>STANDARD</code> permissions mode to maximize
        /// the security of your ledger data.
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key-value pairs to add as tags to the ledger that you want to create. Tag keys
        /// are case sensitive. Tag values are case sensitive and can be null.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}