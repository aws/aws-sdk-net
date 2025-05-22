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
    /// Container for the parameters to the FailoverGlobalCluster operation.
    /// Initiates the failover process for a Neptune global database.
    /// 
    ///  
    /// <para>
    /// A failover for a Neptune global database promotes one of secondary read-only DB clusters
    /// to be the primary DB cluster and demotes the primary DB cluster to being a secondary
    /// (read-only) DB cluster. In other words, the role of the current primary DB cluster
    /// and the selected target secondary DB cluster are switched. The selected secondary
    /// DB cluster assumes full read/write capabilities for the Neptune global database.
    /// </para>
    ///  <note> 
    /// <para>
    /// This action applies <b>only</b> to Neptune global databases. This action is only intended
    /// for use on healthy Neptune global databases with healthy Neptune DB clusters and no
    /// region-wide outages, to test disaster recovery scenarios or to reconfigure the global
    /// database topology.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class FailoverGlobalClusterRequest : AmazonNeptuneRequest
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
        /// Constraints:Can't be specified together with the <c>Switchover</c> parameter.
        /// </para>
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
        /// Identifier of the Neptune global database that should be failed over. The identifier
        /// is the unique key assigned by the user when the Neptune global database was created.
        /// In other words, it's the name of the global database that you want to fail over.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must match the identifier of an existing Neptune global database.
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
        /// Constraints:Can't be specified together with the <c>AllowDataLoss</c> parameter.
        /// </para>
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