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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
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
    /// Container for the parameters to the SwitchoverGlobalCluster operation.
    /// Switches over the specified secondary DB cluster to be the new primary DB cluster
    /// in the global database cluster. Switchover operations were previously called "managed
    /// planned failovers."
    /// 
    ///  
    /// <para>
    /// Promotes the specified secondary cluster to assume full read/write capabilities and
    /// demotes the current primary cluster to a secondary (read-only) cluster, maintaining
    /// the original replication topology. All secondary clusters are synchronized with the
    /// primary at the beginning of the process so the new primary continues operations for
    /// the global database without losing any data. Your database is unavailable for a short
    /// time while the primary and selected secondary clusters are assuming their new roles.
    /// </para>
    ///  <note> 
    /// <para>
    /// This operation is intended for controlled environments, for operations such as "regional
    /// rotation" or to fall back to the original primary after a global database failover.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class SwitchoverGlobalClusterRequest : AmazonNeptuneRequest
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
        /// Constraints: Must match the identifier of an existing global database cluster.
        /// </para>
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
        /// The Amazon Resource Name (ARN) of the secondary Neptune DB cluster that you want to
        /// promote to primary for the global database.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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