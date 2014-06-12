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
    /// Container for the parameters to the CreateClusterSnapshot operation.
    /// Creates a manual snapshot of the specified cluster.         The cluster must
    /// be in the <code>available</code> state.        
    /// 
    ///         
    /// <para>
    /// For more information about working with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
    /// Redshift Snapshots</a> in the <i>Amazon Redshift Management Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateClusterSnapshotRequest : AmazonRedshiftRequest
    {
        private string _clusterIdentifier;
        private string _snapshotIdentifier;


        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        ///         The cluster identifier for which you want a snapshot.         
        /// </para>
        /// </summary>
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }


        /// <summary>
        /// Gets and sets the property SnapshotIdentifier. 
        /// <para>
        ///         A unique identifier for the snapshot that you are requesting. This identifier
        /// must be unique for         all snapshots within         the AWS account.        
        /// </para>
        ///         
        /// <para>
        /// Constraints:
        /// </para>
        ///         <ul>            <li>Cannot be null, empty, or blank</li>            <li>Must
        /// contain from 1 to 255 alphanumeric characters or hyphens</li>            <li>First
        /// character must be a letter</li>            <li>Cannot end with a hyphen or contain
        /// two consecutive hyphens</li>        </ul>        
        /// <para>
        /// Example: <code>my-snapshot-id</code>
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