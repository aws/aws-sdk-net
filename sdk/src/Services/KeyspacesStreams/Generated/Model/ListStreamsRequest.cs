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
 * Do not modify this file. This file is generated from the keyspacesstreams-2024-09-09.normal.json service model.
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
namespace Amazon.KeyspacesStreams.Model
{
    /// <summary>
    /// Container for the parameters to the ListStreams operation.
    /// Returns a list of all data capture streams associated with your Amazon Keyspaces account
    /// or for a specific keyspace or table. The response includes information such as stream
    /// ARNs, table associations, creation timestamps, and current status. This operation
    /// helps you discover and manage all active data streams in your Amazon Keyspaces environment.
    /// </summary>
    public partial class ListStreamsRequest : AmazonKeyspacesStreamsRequest
    {
        private string _keyspaceName;
        private int? _maxResults;
        private string _nextToken;
        private string _tableName;

        /// <summary>
        /// Gets and sets the property KeyspaceName. 
        /// <para>
        ///  The name of the keyspace for which to list streams. If specified, only streams associated
        /// with tables in this keyspace are returned. If omitted, streams from all keyspaces
        /// are included in the results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=48)]
        public string KeyspaceName
        {
            get { return this._keyspaceName; }
            set { this._keyspaceName = value; }
        }

        // Check to see if KeyspaceName property is set
        internal bool IsSetKeyspaceName()
        {
            return this._keyspaceName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of streams to return in a single <c>ListStreams</c> request. Default
        /// value is 100. The minimum value is 1 and the maximum value is 100. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  An optional pagination token provided by a previous <c>ListStreams</c> operation.
        /// If this parameter is specified, the response includes only records beyond the token,
        /// up to the value specified by <c>maxResults</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=80, Max=3000)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        ///  The name of the table for which to list streams. Must be used together with <c>keyspaceName</c>.
        /// If specified, only streams associated with this specific table are returned. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=48)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

    }
}