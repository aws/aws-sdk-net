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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the BacktrackDBCluster operation.
    /// </summary>
    public partial class BacktrackDBClusterResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BacktrackIdentifier. 
        /// <para>
        /// Contains the backtrack identifier.
        /// </para>
        /// </summary>
        public string BacktrackIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the BacktrackIdentifier property is set.
        /// </summary>
        internal bool IsSetBacktrackIdentifier() => this.BacktrackIdentifier != null;

        /// <summary>
        /// Gets and sets the property BacktrackRequestCreationTime. 
        /// <para>
        /// The timestamp of the time at which the backtrack was requested.
        /// </para>
        /// </summary>
        public DateTime? BacktrackRequestCreationTime { get; set; }

        /// <summary>
        /// Checks to see if the BacktrackRequestCreationTime property is set.
        /// </summary>
        internal bool IsSetBacktrackRequestCreationTime() => this.BacktrackRequestCreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property BacktrackTo. 
        /// <para>
        /// The timestamp of the time to which the DB cluster was backtracked.
        /// </para>
        /// </summary>
        public DateTime? BacktrackTo { get; set; }

        /// <summary>
        /// Checks to see if the BacktrackTo property is set.
        /// </summary>
        internal bool IsSetBacktrackTo() => this.BacktrackTo.HasValue;

        /// <summary>
        /// Gets and sets the property BacktrackedFrom. 
        /// <para>
        /// The timestamp of the time from which the DB cluster was backtracked.
        /// </para>
        /// </summary>
        public DateTime? BacktrackedFrom { get; set; }

        /// <summary>
        /// Checks to see if the BacktrackedFrom property is set.
        /// </summary>
        internal bool IsSetBacktrackedFrom() => this.BacktrackedFrom.HasValue;

        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// Contains a user-supplied DB cluster identifier. This identifier is the unique key
        /// that identifies a DB cluster.
        /// </para>
        /// </summary>
        public string DBClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetDBClusterIdentifier() => this.DBClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the backtrack. This property returns one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>applying</c> - The backtrack is currently being applied to or rolled back from
        /// the DB cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>completed</c> - The backtrack has successfully been applied to or rolled back
        /// from the DB cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>failed</c> - An error occurred while the backtrack was applied to or rolled back
        /// from the DB cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending</c> - The backtrack is currently pending application to or rollback from
        /// the DB cluster.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
