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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDBCluster operation. The DeleteDBCluster
    /// action deletes a previously provisioned DB cluster. When you delete a DB cluster,
    /// all automated backups for that DB cluster are deleted and can't be recovered. Manual
    /// DB cluster snapshots of the specified DB cluster are not deleted. <para> Note that
    /// the DB Cluster cannot be deleted if deletion protection is enabled. To delete it,
    /// you must first set its <c>DeletionProtection</c> field to <c>False</c>. </para>
    /// </summary>
    public partial class DeleteDBClusterRequest : AmazonNeptuneRequest
    {
        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// The DB cluster identifier for the DB cluster to be deleted. This parameter isn't case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match an existing DBClusterIdentifier.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DBClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetDBClusterIdentifier() => this.DBClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property FinalDBSnapshotIdentifier. 
        /// <para>
        ///  The DB cluster snapshot identifier of the new DB cluster snapshot created when <c>SkipFinalSnapshot</c>
        /// is set to <c>false</c>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  Specifying this parameter and also setting the <c>SkipFinalSnapshot</c> parameter
        /// to true results in an error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be 1 to 255 letters, numbers, or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot end with a hyphen or contain two consecutive hyphens
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string FinalDBSnapshotIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the FinalDBSnapshotIdentifier property is set.
        /// </summary>
        internal bool IsSetFinalDBSnapshotIdentifier() => this.FinalDBSnapshotIdentifier != null;

        /// <summary>
        /// Gets and sets the property SkipFinalSnapshot. 
        /// <para>
        ///  Determines whether a final DB cluster snapshot is created before the DB cluster is
        /// deleted. If <c>true</c> is specified, no DB cluster snapshot is created. If <c>false</c>
        /// is specified, a DB cluster snapshot is created before the DB cluster is deleted.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must specify a <c>FinalDBSnapshotIdentifier</c> parameter if <c>SkipFinalSnapshot</c>
        /// is <c>false</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? SkipFinalSnapshot { get; set; }

        /// <summary>
        /// Checks to see if the SkipFinalSnapshot property is set.
        /// </summary>
        internal bool IsSetSkipFinalSnapshot() => this.SkipFinalSnapshot.HasValue;
    }
}
