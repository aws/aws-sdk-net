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
    /// Container for the parameters to the FailoverGlobalCluster operation.
    /// Initiates the failover process for an Aurora global database (<a>GlobalCluster</a>).
    /// 
    ///  
    /// <para>
    /// A failover for an Aurora global database promotes one of secondary read-only DB clusters
    /// to be the primary DB cluster and demotes the primary DB cluster to being a secondary
    /// (read-only) DB cluster. In other words, the role of the current primary DB cluster
    /// and the selected (target) DB cluster are switched. The selected secondary DB cluster
    /// assumes full read/write capabilities for the Aurora global database.
    /// </para>
    ///  
    /// <para>
    /// For more information about failing over an Amazon Aurora global database, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-global-database-disaster-recovery.html#aurora-global-database-disaster-recovery.managed-failover">Managed
    /// planned failover for Amazon Aurora global databases</a> in the <i>Amazon Aurora User
    /// Guide.</i> 
    /// </para>
    ///  <note> 
    /// <para>
    /// This action applies to <a>GlobalCluster</a> (Aurora global databases) only. Use this
    /// action only on healthy Aurora global databases with running Aurora DB clusters and
    /// no Region-wide outages, to test disaster recovery scenarios or to reconfigure your
    /// Aurora global database topology. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class FailoverGlobalClusterRequest : AmazonRDSRequest
    {
        private string _globalClusterIdentifier;
        private string _targetDbClusterIdentifier;

        /// <summary>
        /// Gets and sets the property GlobalClusterIdentifier. 
        /// <para>
        /// Identifier of the Aurora global database (<a>GlobalCluster</a>) that should be failed
        /// over. The identifier is the unique key assigned by the user when the Aurora global
        /// database was created. In other words, it's the name of the Aurora global database
        /// that you want to fail over. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing <a>GlobalCluster</a> (Aurora global database).
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
        /// Identifier of the secondary Aurora DB cluster that you want to promote to primary
        /// for the Aurora global database (<a>GlobalCluster</a>.) Use the Amazon Resource Name
        /// (ARN) for the identifier so that Aurora can locate the cluster in its Amazon Web Services
        /// Region. 
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