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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the AuthorizeSnapshotAccess operation.
    /// Authorizes the specified Amazon Web Services account to restore the specified snapshot.
    /// 
    ///  
    /// <para>
    ///  For more information about working with snapshots, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
    /// Redshift Snapshots</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
    /// </para>
    /// </summary>
    public partial class AuthorizeSnapshotAccessRequest : AmazonRedshiftRequest
    {
        private string _accountWithRestoreAccess;
        private string _snapshotArn;
        private string _snapshotClusterIdentifier;
        private string _snapshotIdentifier;

        /// <summary>
        /// Gets and sets the property AccountWithRestoreAccess. 
        /// <para>
        /// The identifier of the Amazon Web Services account authorized to restore the specified
        /// snapshot.
        /// </para>
        ///  
        /// <para>
        /// To share a snapshot with Amazon Web Services Support, specify amazon-redshift-support.
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
        /// The Amazon Resource Name (ARN) of the snapshot to authorize access to.
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
        /// The identifier of the cluster the snapshot was created from.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>If the snapshot to access doesn't exist and the associated IAM policy doesn't
        /// allow access to all (*) snapshots</i> - This parameter is required. Otherwise, permissions
        /// aren't available to check if the snapshot exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>If the snapshot to access exists</i> - This parameter isn't required. Redshift
        /// can retrieve the cluster identifier and use it to validate snapshot authorization.
        /// </para>
        ///  </li> </ul>
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
        /// The identifier of the snapshot the account is authorized to restore.
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