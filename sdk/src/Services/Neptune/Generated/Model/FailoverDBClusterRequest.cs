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
 * Do not modify this file. This file is generated from the neptune-2018-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Container for the parameters to the FailoverDBCluster operation.
    /// Forces a failover for a DB cluster.
    /// 
    ///  
    /// <para>
    /// A failover for a DB cluster promotes one of the Aurora Replicas (read-only instances)
    /// in the DB cluster to be the primary instance (the cluster writer).
    /// </para>
    ///  
    /// <para>
    /// Amazon Aurora will automatically fail over to an Aurora Replica, if one exists, when
    /// the primary instance fails. You can force a failover when you want to simulate a failure
    /// of a primary instance for testing. Because each instance in a DB cluster has its own
    /// endpoint address, you will need to clean up and re-establish any existing connections
    /// that use those endpoint addresses when the failover is complete.
    /// </para>
    ///  
    /// <para>
    /// For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
    /// on Amazon Neptune</a> in the <i>Amazon Neptune User Guide.</i> 
    /// </para>
    /// </summary>
    public partial class FailoverDBClusterRequest : AmazonNeptuneRequest
    {
        private string _dbClusterIdentifier;
        private string _targetDBInstanceIdentifier;

        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// A DB cluster identifier to force a failover for. This parameter is not case-sensitive.
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
        /// The name of the instance to promote to the primary instance.
        /// </para>
        ///  
        /// <para>
        /// You must specify the instance identifier for an Aurora Replica in the DB cluster.
        /// For example, <code>mydbcluster-replica1</code>.
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