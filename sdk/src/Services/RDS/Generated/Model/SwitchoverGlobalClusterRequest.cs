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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the SwitchoverGlobalCluster operation.
    /// Switches over the specified secondary DB cluster to be the new primary DB cluster
    /// in the global database cluster. Switchover operations were previously called "managed
    /// planned failovers."
    /// 
    ///  
    /// <para>
    /// Aurora promotes the specified secondary cluster to assume full read/write capabilities
    /// and demotes the current primary cluster to a secondary (read-only) cluster, maintaining
    /// the orginal replication topology. All secondary clusters are synchronized with the
    /// primary at the beginning of the process so the new primary continues operations for
    /// the Aurora global database without losing any data. Your database is unavailable for
    /// a short time while the primary and selected secondary clusters are assuming their
    /// new roles. For more information about switching over an Aurora global database, see
    /// <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-global-database-disaster-recovery.html#aurora-global-database-disaster-recovery.managed-failover">Performing
    /// switchovers for Amazon Aurora global databases</a> in the <i>Amazon Aurora User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// This operation is intended for controlled environments, for operations such as "regional
    /// rotation" or to fall back to the original primary after a global database failover.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class SwitchoverGlobalClusterRequest : AmazonRDSRequest
    {
        private string _globalClusterIdentifier;
        private string _targetDbClusterIdentifier;

        /// <summary>
        /// Gets and sets the property GlobalClusterIdentifier. 
        /// <para>
        /// The identifier of the global database cluster to switch over. This parameter isn't
        /// case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing global database cluster (Aurora global database).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string GlobalClusterIdentifier
        {
            get { return this._globalClusterIdentifier; }
            set { this._globalClusterIdentifier = value; }
        }

        // Check to see if GlobalClusterIdentifier property is set
        internal bool IsSetGlobalClusterIdentifier()
        {
            return this._globalClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property TargetDbClusterIdentifier. 
        /// <para>
        /// The identifier of the secondary Aurora DB cluster to promote to the new primary for
        /// the global database cluster. Use the Amazon Resource Name (ARN) for the identifier
        /// so that Aurora can locate the cluster in its Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string TargetDbClusterIdentifier
        {
            get { return this._targetDbClusterIdentifier; }
            set { this._targetDbClusterIdentifier = value; }
        }

        // Check to see if TargetDbClusterIdentifier property is set
        internal bool IsSetTargetDbClusterIdentifier()
        {
            return this._targetDbClusterIdentifier != null;
        }

    }
}