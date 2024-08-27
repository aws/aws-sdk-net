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
    /// Container for the parameters to the FailoverGlobalCluster operation.
    /// Promotes the specified secondary DB cluster to be the primary DB cluster in the global
    /// cluster when failing over a global cluster occurs.
    /// 
    ///  
    /// <para>
    /// Use this operation to respond to an unplanned event, such as a regional disaster in
    /// the primary region. Failing over can result in a loss of write transaction data that
    /// wasn't replicated to the chosen secondary before the failover event occurred. However,
    /// the recovery process that promotes a DB instance on the chosen seconday DB cluster
    /// to be the primary writer DB instance guarantees that the data is in a transactionally
    /// consistent state.
    /// </para>
    /// </summary>
    public partial class FailoverGlobalClusterRequest : AmazonDocDBRequest
    {
        private bool? _allowDataLoss;
        private string _globalClusterIdentifier;
        private bool? _switchover;
        private string _targetDbClusterIdentifier;

        /// <summary>
        /// Gets and sets the property AllowDataLoss. 
        /// <para>
        /// Specifies whether to allow data loss for this global cluster operation. Allowing data
        /// loss triggers a global failover operation.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify <c>AllowDataLoss</c>, the global cluster operation defaults to
        /// a switchover.
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
        /// The identifier of the Amazon DocumentDB global cluster to apply this operation. The
        /// identifier is the unique key assigned by the user when the cluster is created. In
        /// other words, it's the name of the global cluster.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing global cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Minimum length of 1. Maximum length of 255.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Pattern: <c>[A-Za-z][0-9A-Za-z-:._]*</c> 
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
        /// The identifier of the secondary Amazon DocumentDB cluster that you want to promote
        /// to the primary for the global cluster. Use the Amazon Resource Name (ARN) for the
        /// identifier so that Amazon DocumentDB can locate the cluster in its Amazon Web Services
        /// region.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing secondary cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Minimum length of 1. Maximum length of 255.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Pattern: <c>[A-Za-z][0-9A-Za-z-:._]*</c> 
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