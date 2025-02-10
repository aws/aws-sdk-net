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
    /// Container for the parameters to the BacktrackDBCluster operation.
    /// Backtracks a DB cluster to a specific time, without creating a new DB cluster.
    /// 
    ///  
    /// <para>
    /// For more information on backtracking, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/AuroraMySQL.Managing.Backtrack.html">
    /// Backtracking an Aurora DB Cluster</a> in the <i>Amazon Aurora User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// This action applies only to Aurora MySQL DB clusters.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class BacktrackDBClusterRequest : AmazonRDSRequest
    {
        private DateTime? _backtrackTo;
        private string _dbClusterIdentifier;
        private bool? _force;
        private bool? _useEarliestTimeOnPointInTimeUnavailable;

        /// <summary>
        /// Gets and sets the property BacktrackTo. 
        /// <para>
        /// The timestamp of the time to backtrack the DB cluster to, specified in ISO 8601 format.
        /// For more information about ISO 8601, see the <a href="http://en.wikipedia.org/wiki/ISO_8601">ISO8601
        /// Wikipedia page.</a> 
        /// </para>
        ///  <note> 
        /// <para>
        /// If the specified time isn't a consistent time for the DB cluster, Aurora automatically
        /// chooses the nearest possible consistent time for the DB cluster.
        /// </para>
        ///  </note> 
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain a valid ISO 8601 timestamp.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't contain a timestamp set in the future.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>2017-07-08T18:00Z</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? BacktrackTo
        {
            get { return this._backtrackTo; }
            set { this._backtrackTo = value; }
        }

        // Check to see if BacktrackTo property is set
        internal bool IsSetBacktrackTo()
        {
            return this._backtrackTo.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// The DB cluster identifier of the DB cluster to be backtracked. This parameter is stored
        /// as a lowercase string.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain from 1 to 63 alphanumeric characters or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>my-cluster1</c> 
        /// </para>
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
        /// Gets and sets the property Force. 
        /// <para>
        /// Specifies whether to force the DB cluster to backtrack when binary logging is enabled.
        /// Otherwise, an error occurs when binary logging is enabled.
        /// </para>
        /// </summary>
        public bool? Force
        {
            get { return this._force; }
            set { this._force = value; }
        }

        // Check to see if Force property is set
        internal bool IsSetForce()
        {
            return this._force.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UseEarliestTimeOnPointInTimeUnavailable. 
        /// <para>
        /// Specifies whether to backtrack the DB cluster to the earliest possible backtrack time
        /// when <i>BacktrackTo</i> is set to a timestamp earlier than the earliest backtrack
        /// time. When this parameter is disabled and <i>BacktrackTo</i> is set to a timestamp
        /// earlier than the earliest backtrack time, an error occurs.
        /// </para>
        /// </summary>
        public bool? UseEarliestTimeOnPointInTimeUnavailable
        {
            get { return this._useEarliestTimeOnPointInTimeUnavailable; }
            set { this._useEarliestTimeOnPointInTimeUnavailable = value; }
        }

        // Check to see if UseEarliestTimeOnPointInTimeUnavailable property is set
        internal bool IsSetUseEarliestTimeOnPointInTimeUnavailable()
        {
            return this._useEarliestTimeOnPointInTimeUnavailable.HasValue; 
        }

    }
}