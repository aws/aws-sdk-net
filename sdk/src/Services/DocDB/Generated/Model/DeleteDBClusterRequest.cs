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
 * Do not modify this file. This file is generated from the docdb-2014-10-31.normal.json service model.
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
namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDBCluster operation.
    /// Deletes a previously provisioned cluster. When you delete a cluster, all automated
    /// backups for that cluster are deleted and can't be recovered. Manual DB cluster snapshots
    /// of the specified cluster are not deleted.
    /// </summary>
    public partial class DeleteDBClusterRequest : AmazonDocDBRequest
    {
        private string _dbClusterIdentifier;
        private string _finalDBSnapshotIdentifier;
        private bool? _skipFinalSnapshot;

        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// The cluster identifier for the cluster to be deleted. This parameter isn't case sensitive.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match an existing <c>DBClusterIdentifier</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBClusterIdentifier
        {
            get { return this._dbClusterIdentifier; }
            set { this._dbClusterIdentifier = value; }
        }

        // Check to see if DBClusterIdentifier property is set
        internal bool IsSetDBClusterIdentifier()
        {
            return this._dbClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property FinalDBSnapshotIdentifier. 
        /// <para>
        ///  The cluster snapshot identifier of the new cluster snapshot created when <c>SkipFinalSnapshot</c>
        /// is set to <c>false</c>. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  Specifying this parameter and also setting the <c>SkipFinalShapshot</c> parameter
        /// to <c>true</c> results in an error. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be from 1 to 255 letters, numbers, or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The first character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string FinalDBSnapshotIdentifier
        {
            get { return this._finalDBSnapshotIdentifier; }
            set { this._finalDBSnapshotIdentifier = value; }
        }

        // Check to see if FinalDBSnapshotIdentifier property is set
        internal bool IsSetFinalDBSnapshotIdentifier()
        {
            return this._finalDBSnapshotIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SkipFinalSnapshot. 
        /// <para>
        ///  Determines whether a final cluster snapshot is created before the cluster is deleted.
        /// If <c>true</c> is specified, no cluster snapshot is created. If <c>false</c> is specified,
        /// a cluster snapshot is created before the DB cluster is deleted. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If <c>SkipFinalSnapshot</c> is <c>false</c>, you must specify a <c>FinalDBSnapshotIdentifier</c>
        /// parameter.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? SkipFinalSnapshot
        {
            get { return this._skipFinalSnapshot; }
            set { this._skipFinalSnapshot = value; }
        }

        // Check to see if SkipFinalSnapshot property is set
        internal bool IsSetSkipFinalSnapshot()
        {
            return this._skipFinalSnapshot.HasValue; 
        }

    }
}