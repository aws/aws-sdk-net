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
    /// This data type is used as a response element in the <c>DescribeDBClusterBacktracks</c>
    /// action.
    /// </summary>
    public partial class DBClusterBacktrack
    {
        private DateTime? _backtrackedFrom;
        private string _backtrackIdentifier;
        private DateTime? _backtrackRequestCreationTime;
        private DateTime? _backtrackTo;
        private string _dbClusterIdentifier;
        private string _status;

        /// <summary>
        /// Gets and sets the property BacktrackedFrom. 
        /// <para>
        /// The timestamp of the time from which the DB cluster was backtracked.
        /// </para>
        /// </summary>
        public DateTime? BacktrackedFrom
        {
            get { return this._backtrackedFrom; }
            set { this._backtrackedFrom = value; }
        }

        // Check to see if BacktrackedFrom property is set
        internal bool IsSetBacktrackedFrom()
        {
            return this._backtrackedFrom.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BacktrackIdentifier. 
        /// <para>
        /// Contains the backtrack identifier.
        /// </para>
        /// </summary>
        public string BacktrackIdentifier
        {
            get { return this._backtrackIdentifier; }
            set { this._backtrackIdentifier = value; }
        }

        // Check to see if BacktrackIdentifier property is set
        internal bool IsSetBacktrackIdentifier()
        {
            return this._backtrackIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property BacktrackRequestCreationTime. 
        /// <para>
        /// The timestamp of the time at which the backtrack was requested.
        /// </para>
        /// </summary>
        public DateTime? BacktrackRequestCreationTime
        {
            get { return this._backtrackRequestCreationTime; }
            set { this._backtrackRequestCreationTime = value; }
        }

        // Check to see if BacktrackRequestCreationTime property is set
        internal bool IsSetBacktrackRequestCreationTime()
        {
            return this._backtrackRequestCreationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BacktrackTo. 
        /// <para>
        /// The timestamp of the time to which the DB cluster was backtracked.
        /// </para>
        /// </summary>
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
        /// Contains a user-supplied DB cluster identifier. This identifier is the unique key
        /// that identifies a DB cluster.
        /// </para>
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
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}