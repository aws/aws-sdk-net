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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the FailoverDBCluster operation.
    /// Forces a failover for a DB cluster.
    /// 
    ///  
    /// <para>
    /// For an Aurora DB cluster, failover for a DB cluster promotes one of the Aurora Replicas
    /// (read-only instances) in the DB cluster to be the primary DB instance (the cluster
    /// writer).
    /// </para>
    ///  
    /// <para>
    /// For a Multi-AZ DB cluster, failover for a DB cluster promotes one of the readable
    /// standby DB instances (read-only instances) in the DB cluster to be the primary DB
    /// instance (the cluster writer).
    /// </para>
    ///  
    /// <para>
    /// An Amazon Aurora DB cluster automatically fails over to an Aurora Replica, if one
    /// exists, when the primary DB instance fails. A Multi-AZ DB cluster automatically fails
    /// over to a readable standby DB instance when the primary DB instance fails.
    /// </para>
    ///  
    /// <para>
    /// To simulate a failure of a primary instance for testing, you can force a failover.
    /// Because each instance in a DB cluster has its own endpoint address, make sure to clean
    /// up and re-establish any existing connections that use those endpoint addresses when
    /// the failover is complete.
    /// </para>
    ///  
    /// <para>
    /// For more information on Amazon Aurora DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
    /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
    /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class FailoverDBClusterRequest : AmazonRDSRequest
    {
        private string _dbClusterIdentifier;
        private string _targetDBInstanceIdentifier;

        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// A DB cluster identifier to force a failover for. This parameter isn't case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing DBCluster.
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
        /// Gets and sets the property TargetDBInstanceIdentifier. 
        /// <para>
        /// The name of the DB instance to promote to the primary DB instance.
        /// </para>
        ///  
        /// <para>
        /// Specify the DB instance identifier for an Aurora Replica or a Multi-AZ readable standby
        /// in the DB cluster, for example <code>mydbcluster-replica1</code>.
        /// </para>
        ///  
        /// <para>
        /// This setting isn't supported for RDS for MySQL Multi-AZ DB clusters.
        /// </para>
        /// </summary>
        public string TargetDBInstanceIdentifier
        {
            get { return this._targetDBInstanceIdentifier; }
            set { this._targetDBInstanceIdentifier = value; }
        }

        // Check to see if TargetDBInstanceIdentifier property is set
        internal bool IsSetTargetDBInstanceIdentifier()
        {
            return this._targetDBInstanceIdentifier != null;
        }

    }
}