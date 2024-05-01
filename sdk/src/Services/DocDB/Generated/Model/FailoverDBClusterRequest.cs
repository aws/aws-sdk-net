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
    /// Container for the parameters to the FailoverDBCluster operation.
    /// Forces a failover for a cluster.
    /// 
    ///  
    /// <para>
    /// A failover for a cluster promotes one of the Amazon DocumentDB replicas (read-only
    /// instances) in the cluster to be the primary instance (the cluster writer).
    /// </para>
    ///  
    /// <para>
    /// If the primary instance fails, Amazon DocumentDB automatically fails over to an Amazon
    /// DocumentDB replica, if one exists. You can force a failover when you want to simulate
    /// a failure of a primary instance for testing.
    /// </para>
    /// </summary>
    public partial class FailoverDBClusterRequest : AmazonDocDBRequest
    {
        private string _dbClusterIdentifier;
        private string _targetDBInstanceIdentifier;

        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// A cluster identifier to force a failover for. This parameter is not case sensitive.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing <c>DBCluster</c>.
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
        /// You must specify the instance identifier for an Amazon DocumentDB replica in the cluster.
        /// For example, <c>mydbcluster-replica1</c>.
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