/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDBSnapshotAttributes operation.
    /// Returns a list of DB snapshot attribute names and values for a manual DB snapshot.
    /// 
    ///  
    /// <para>
    /// When sharing snapshots with other AWS accounts, <code>DescribeDBSnapshotAttributes</code>
    /// returns the <code>restore</code> attribute and a list of IDs for the AWS accounts
    /// that are authorized to copy or restore the manual DB snapshot. If <code>all</code>
    /// is included in the list of values for the <code>restore</code> attribute, then the
    /// manual DB snapshot is public and can be copied or restored by all AWS accounts.
    /// </para>
    ///  
    /// <para>
    /// To add or remove access for an AWS account to copy or restore a manual DB snapshot,
    /// or to make the manual DB snapshot public or private, use the <a>ModifyDBSnapshotAttribute</a>
    /// API action.
    /// </para>
    /// </summary>
    public partial class DescribeDBSnapshotAttributesRequest : AmazonRDSRequest
    {
        private string _dbSnapshotIdentifier;

        /// <summary>
        /// Gets and sets the property DBSnapshotIdentifier. 
        /// <para>
        /// The identifier for the DB snapshot to describe the attributes for.
        /// </para>
        /// </summary>
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

    }
}