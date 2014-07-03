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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the AuthorizeSnapshotAccess operation.
    /// Authorizes the specified AWS customer account to restore the specified
    /// snapshot.        
    /// 
    ///         
    /// <para>
    /// For more information about working with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
    /// Redshift Snapshots</a> in the <i>Amazon Redshift Management Guide</i>.
    /// </para>
    /// </summary>
    public partial class AuthorizeSnapshotAccessRequest : AmazonRedshiftRequest
    {
        private string _accountWithRestoreAccess;
        private string _snapshotClusterIdentifier;
        private string _snapshotIdentifier;


        /// <summary>
        /// Gets and sets the property AccountWithRestoreAccess. 
        /// <para>
        ///             The identifier of the AWS customer account authorized to restore the specified
        /// snapshot.        
        /// </para>
        /// </summary>
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
        /// Gets and sets the property SnapshotClusterIdentifier. 
        /// <para>
        ///             The identifier of the cluster the snapshot was created from. This parameter
        /// is required if your IAM user has a policy containing a snapshot resource element that
        /// specifies anything other than * for the cluster name.        
        /// </para>
        /// </summary>
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
        ///             The identifier of the snapshot the account is authorized to restore. 
        ///       
        /// </para>
        /// </summary>
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