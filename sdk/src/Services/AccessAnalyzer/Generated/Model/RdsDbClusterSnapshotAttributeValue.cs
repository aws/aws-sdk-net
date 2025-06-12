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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// The values for a manual Amazon RDS DB cluster snapshot attribute.
    /// </summary>
    public partial class RdsDbClusterSnapshotAttributeValue
    {
        private List<string> _accountIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// The Amazon Web Services account IDs that have access to the manual Amazon RDS DB cluster
        /// snapshot. If the value <c>all</c> is specified, then the Amazon RDS DB cluster snapshot
        /// is public and can be copied or restored by all Amazon Web Services accounts.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the configuration is for an existing Amazon RDS DB cluster snapshot and you do
        /// not specify the <c>accountIds</c> in <c>RdsDbClusterSnapshotAttributeValue</c>, then
        /// the access preview uses the existing shared <c>accountIds</c> for the snapshot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the access preview is for a new resource and you do not specify the specify the
        /// <c>accountIds</c> in <c>RdsDbClusterSnapshotAttributeValue</c>, then the access preview
        /// considers the snapshot without any attributes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To propose deletion of existing shared <c>accountIds</c>, you can specify an empty
        /// list for <c>accountIds</c> in the <c>RdsDbClusterSnapshotAttributeValue</c>.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AccountIds
        {
            get { return this._accountIds; }
            set { this._accountIds = value; }
        }

        // Check to see if AccountIds property is set
        internal bool IsSetAccountIds()
        {
            return this._accountIds != null && (this._accountIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}