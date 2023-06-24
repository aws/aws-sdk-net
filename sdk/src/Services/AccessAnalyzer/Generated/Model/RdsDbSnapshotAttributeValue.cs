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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// The name and values of a manual Amazon RDS DB snapshot attribute. Manual DB snapshot
    /// attributes are used to authorize other Amazon Web Services accounts to restore a manual
    /// DB snapshot.
    /// </summary>
    public partial class RdsDbSnapshotAttributeValue
    {
        private List<string> _accountIds = new List<string>();

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// The Amazon Web Services account IDs that have access to the manual Amazon RDS DB snapshot.
        /// If the value <code>all</code> is specified, then the Amazon RDS DB snapshot is public
        /// and can be copied or restored by all Amazon Web Services accounts.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the configuration is for an existing Amazon RDS DB snapshot and you do not specify
        /// the <code>accountIds</code> in <code>RdsDbSnapshotAttributeValue</code>, then the
        /// access preview uses the existing shared <code>accountIds</code> for the snapshot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the access preview is for a new resource and you do not specify the specify the
        /// <code>accountIds</code> in <code>RdsDbSnapshotAttributeValue</code>, then the access
        /// preview considers the snapshot without any attributes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To propose deletion of an existing shared <code>accountIds</code>, you can specify
        /// an empty list for <code>accountIds</code> in the <code>RdsDbSnapshotAttributeValue</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> AccountIds
        {
            get { return this._accountIds; }
            set { this._accountIds = value; }
        }

        // Check to see if AccountIds property is set
        internal bool IsSetAccountIds()
        {
            return this._accountIds != null && this._accountIds.Count > 0; 
        }

    }
}