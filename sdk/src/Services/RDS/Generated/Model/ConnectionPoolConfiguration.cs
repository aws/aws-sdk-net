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
    /// Specifies the settings that control the size and behavior of the connection pool associated
    /// with a <code>DBProxyTargetGroup</code>.
    /// </summary>
    public partial class ConnectionPoolConfiguration
    {
        private int? _connectionBorrowTimeout;
        private string _initQuery;
        private int? _maxConnectionsPercent;
        private int? _maxIdleConnectionsPercent;
        private List<string> _sessionPinningFilters = new List<string>();

        /// <summary>
        /// Gets and sets the property ConnectionBorrowTimeout. 
        /// <para>
        /// The number of seconds for a proxy to wait for a connection to become available in
        /// the connection pool. Only applies when the proxy has opened its maximum number of
        /// connections and all connections are busy with client sessions.
        /// </para>
        ///  
        /// <para>
        /// Default: 120
        /// </para>
        ///  
        /// <para>
        /// Constraints: between 1 and 3600, or 0 representing unlimited
        /// </para>
        /// </summary>
        public int ConnectionBorrowTimeout
        {
            get { return this._connectionBorrowTimeout.GetValueOrDefault(); }
            set { this._connectionBorrowTimeout = value; }
        }

        // Check to see if ConnectionBorrowTimeout property is set
        internal bool IsSetConnectionBorrowTimeout()
        {
            return this._connectionBorrowTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InitQuery. 
        /// <para>
        /// One or more SQL statements for the proxy to run when opening each new database connection.
        /// Typically used with <code>SET</code> statements to make sure that each connection
        /// has identical settings such as time zone and character set. For multiple statements,
        /// use semicolons as the separator. You can also include multiple variables in a single
        /// <code>SET</code> statement, such as <code>SET x=1, y=2</code>.
        /// </para>
        ///  
        /// <para>
        /// Default: no initialization query
        /// </para>
        /// </summary>
        public string InitQuery
        {
            get { return this._initQuery; }
            set { this._initQuery = value; }
        }

        // Check to see if InitQuery property is set
        internal bool IsSetInitQuery()
        {
            return this._initQuery != null;
        }

        /// <summary>
        /// Gets and sets the property MaxConnectionsPercent. 
        /// <para>
        /// The maximum size of the connection pool for each target in a target group. The value
        /// is expressed as a percentage of the <code>max_connections</code> setting for the RDS
        /// DB instance or Aurora DB cluster used by the target group.
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>MaxIdleConnectionsPercent</code>, then you must also include
        /// a value for this parameter.
        /// </para>
        ///  
        /// <para>
        /// Default: 10 for RDS for Microsoft SQL Server, and 100 for all other engines
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must be between 1 and 100.
        /// </para>
        /// </summary>
        public int MaxConnectionsPercent
        {
            get { return this._maxConnectionsPercent.GetValueOrDefault(); }
            set { this._maxConnectionsPercent = value; }
        }

        // Check to see if MaxConnectionsPercent property is set
        internal bool IsSetMaxConnectionsPercent()
        {
            return this._maxConnectionsPercent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxIdleConnectionsPercent. 
        /// <para>
        /// Controls how actively the proxy closes idle database connections in the connection
        /// pool. The value is expressed as a percentage of the <code>max_connections</code> setting
        /// for the RDS DB instance or Aurora DB cluster used by the target group. With a high
        /// value, the proxy leaves a high percentage of idle database connections open. A low
        /// value causes the proxy to close more idle connections and return them to the database.
        /// </para>
        ///  
        /// <para>
        /// If you specify this parameter, then you must also include a value for <code>MaxConnectionsPercent</code>.
        /// </para>
        ///  
        /// <para>
        /// Default: The default value is half of the value of <code>MaxConnectionsPercent</code>.
        /// For example, if <code>MaxConnectionsPercent</code> is 80, then the default value of
        /// <code>MaxIdleConnectionsPercent</code> is 40. If the value of <code>MaxConnectionsPercent</code>
        /// isn't specified, then for SQL Server, <code>MaxIdleConnectionsPercent</code> is 5,
        /// and for all other engines, the default is 50.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must be between 0 and the value of <code>MaxConnectionsPercent</code>.
        /// </para>
        /// </summary>
        public int MaxIdleConnectionsPercent
        {
            get { return this._maxIdleConnectionsPercent.GetValueOrDefault(); }
            set { this._maxIdleConnectionsPercent = value; }
        }

        // Check to see if MaxIdleConnectionsPercent property is set
        internal bool IsSetMaxIdleConnectionsPercent()
        {
            return this._maxIdleConnectionsPercent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SessionPinningFilters. 
        /// <para>
        /// Each item in the list represents a class of SQL operations that normally cause all
        /// later statements in a session using a proxy to be pinned to the same underlying database
        /// connection. Including an item in the list exempts that class of SQL operations from
        /// the pinning behavior.
        /// </para>
        ///  
        /// <para>
        /// Default: no session pinning filters
        /// </para>
        /// </summary>
        public List<string> SessionPinningFilters
        {
            get { return this._sessionPinningFilters; }
            set { this._sessionPinningFilters = value; }
        }

        // Check to see if SessionPinningFilters property is set
        internal bool IsSetSessionPinningFilters()
        {
            return this._sessionPinningFilters != null && this._sessionPinningFilters.Count > 0; 
        }

    }
}