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

namespace Amazon.KeyspacesStreams.Model
{
    /// <summary>
    /// Container for the parameters to the ListStreams operation. Returns a list of all data
    /// capture streams associated with your Amazon Keyspaces account or for a specific keyspace
    /// or table. The response includes information such as stream ARNs, table associations,
    /// creation timestamps, and current status. This operation helps you discover and manage
    /// all active data streams in your Amazon Keyspaces environment.
    /// </summary>
    public partial class ListStreamsRequest : AmazonKeyspacesStreamsRequest
    {
        /// <summary>
        /// Gets and sets the property KeyspaceName. 
        /// <para>
        ///  The name of the keyspace for which to list streams. If specified, only streams associated
        /// with tables in this keyspace are returned. If omitted, streams from all keyspaces
        /// are included in the results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 48)]
        public string KeyspaceName { get; set; }

        /// <summary>
        /// Checks to see if the KeyspaceName property is set.
        /// </summary>
        internal bool IsSetKeyspaceName() => this.KeyspaceName != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of streams to return in a single <c>ListStreams</c> request. The
        /// default value is 100. The minimum value is 1 and the maximum value is 100. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  An optional pagination token provided by a previous <c>ListStreams</c> operation.
        /// If this parameter is specified, the response includes only records beyond the token,
        /// up to the value specified by <c>maxResults</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 80, Max = 3000)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        ///  The name of the table for which to list streams. Must be used together with <c>keyspaceName</c>.
        /// If specified, only streams associated with this specific table are returned. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 48)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;
    }
}
