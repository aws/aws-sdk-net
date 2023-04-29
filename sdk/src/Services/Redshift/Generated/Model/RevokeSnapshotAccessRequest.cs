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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the RevokeSnapshotAccess operation.
    /// Removes the ability of the specified Amazon Web Services account to restore the specified
    /// snapshot. If the account is currently restoring the snapshot, the restore will run
    /// to completion.
    /// 
    ///  
    /// <para>
    ///  For more information about working with snapshots, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
    /// Redshift Snapshots</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
    /// </para>
    /// </summary>
    public partial class RevokeSnapshotAccessRequest : AmazonRedshiftRequest
    {
        private string _accountWithRestoreAccess;
        private string _snapshotArn;
        private string _snapshotClusterIdentifier;
        private string _snapshotIdentifier;

        /// <summary>
        /// Gets and sets the property AccountWithRestoreAccess. 
        /// <para>
        /// The identifier of the Amazon Web Services account that can no longer restore the specified
        /// snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
        public string AccountWithRestoreAccess
        {
            get { return this._accountWithRestoreAccess; }
            set { this._accountWithRestoreAccess = value; }
        }

        // Check to see if AccountWithRestoreAccess property is set
        internal bool IsSetAccountWithRestoreAccess()
        {
            return this._accountWithRestoreAccess != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the snapshot associated with the message to revoke
        /// access.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string SnapshotArn
        {
            get { return this._snapshotArn; }
            set { this._snapshotArn = value; }
        }

        // Check to see if SnapshotArn property is set
        internal bool IsSetSnapshotArn()
        {
            return this._snapshotArn != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotClusterIdentifier. 
        /// <para>
        /// The identifier of the cluster the snapshot was created from. This parameter is required
        /// if your IAM user or role has a policy containing a snapshot resource element that
        /// specifies anything other than * for the cluster name.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string SnapshotClusterIdentifier
        {
            get { return this._snapshotClusterIdentifier; }
            set { this._snapshotClusterIdentifier = value; }
        }

        // Check to see if SnapshotClusterIdentifier property is set
        internal bool IsSetSnapshotClusterIdentifier()
        {
            return this._snapshotClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotIdentifier. 
        /// <para>
        /// The identifier of the snapshot that the account can no longer access.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string SnapshotIdentifier
        {
            get { return this._snapshotIdentifier; }
            set { this._snapshotIdentifier = value; }
        }

        // Check to see if SnapshotIdentifier property is set
        internal bool IsSetSnapshotIdentifier()
        {
            return this._snapshotIdentifier != null;
        }

    }
}