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
    /// Container for the parameters to the FailoverGlobalCluster operation.
    /// Promotes the specified secondary DB cluster to be the primary DB cluster in the global
    /// database cluster to fail over or switch over a global database. Switchover operations
    /// were previously called "managed planned failovers."
    /// 
    ///  <note> 
    /// <para>
    /// Although this operation can be used either to fail over or to switch over a global
    /// database cluster, its intended use is for global database failover. To switch over
    /// a global database cluster, we recommend that you use the <a>SwitchoverGlobalCluster</a>
    /// operation instead.
    /// </para>
    ///  </note> 
    /// <para>
    /// How you use this operation depends on whether you are failing over or switching over
    /// your global database cluster:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Failing over - Specify the <c>AllowDataLoss</c> parameter and don't specify the <c>Switchover</c>
    /// parameter.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Switching over - Specify the <c>Switchover</c> parameter or omit it, but don't specify
    /// the <c>AllowDataLoss</c> parameter.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>About failing over and switching over</b> 
    /// </para>
    ///  
    /// <para>
    /// While failing over and switching over a global database cluster both change the primary
    /// DB cluster, you use these operations for different reasons:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>Failing over</i> - Use this operation to respond to an unplanned event, such as
    /// a Regional disaster in the primary Region. Failing over can result in a loss of write
    /// transaction data that wasn't replicated to the chosen secondary before the failover
    /// event occurred. However, the recovery process that promotes a DB instance on the chosen
    /// seconday DB cluster to be the primary writer DB instance guarantees that the data
    /// is in a transactionally consistent state.
    /// </para>
    ///  
    /// <para>
    /// For more information about failing over an Amazon Aurora global database, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-global-database-disaster-recovery.html#aurora-global-database-failover.managed-unplanned">Performing
    /// managed failovers for Aurora global databases</a> in the <i>Amazon Aurora User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Switching over</i> - Use this operation on a healthy global database cluster for
    /// planned events, such as Regional rotation or to fail back to the original primary
    /// DB cluster after a failover operation. With this operation, there is no data loss.
    /// </para>
    ///  
    /// <para>
    /// For more information about switching over an Amazon Aurora global database, see <a
    /// href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-global-database-disaster-recovery.html#aurora-global-database-disaster-recovery.managed-failover">Performing
    /// switchovers for Aurora global databases</a> in the <i>Amazon Aurora User Guide</i>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class FailoverGlobalClusterRequest : AmazonRDSRequest
    {
        private bool? _allowDataLoss;
        private string _globalClusterIdentifier;
        private bool? _switchover;
        private string _targetDbClusterIdentifier;

        /// <summary>
        /// Gets and sets the property AllowDataLoss. 
        /// <para>
        /// Specifies whether to allow data loss for this global database cluster operation. Allowing
        /// data loss triggers a global failover operation.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify <c>AllowDataLoss</c>, the global database cluster operation defaults
        /// to a switchover.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can't be specified together with the <c>Switchover</c> parameter.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? AllowDataLoss
        {
            get { return this._allowDataLoss; }
            set { this._allowDataLoss = value; }
        }

        // Check to see if AllowDataLoss property is set
        internal bool IsSetAllowDataLoss()
        {
            return this._allowDataLoss.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GlobalClusterIdentifier. 
        /// <para>
        /// The identifier of the global database cluster (Aurora global database) this operation
        /// should apply to. The identifier is the unique key assigned by the user when the Aurora
        /// global database is created. In other words, it's the name of the Aurora global database.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing global database cluster.
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
        /// Gets and sets the property Switchover. 
        /// <para>
        /// Specifies whether to switch over this global database cluster.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can't be specified together with the <c>AllowDataLoss</c> parameter.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? Switchover
        {
            get { return this._switchover; }
            set { this._switchover = value; }
        }

        // Check to see if Switchover property is set
        internal bool IsSetSwitchover()
        {
            return this._switchover.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetDbClusterIdentifier. 
        /// <para>
        /// The identifier of the secondary Aurora DB cluster that you want to promote to the
        /// primary for the global database cluster. Use the Amazon Resource Name (ARN) for the
        /// identifier so that Aurora can locate the cluster in its Amazon Web Services Region.
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