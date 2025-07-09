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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
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
namespace Amazon.OpsWorksCM.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeServers operation.
    /// Lists all configuration management servers that are identified with your account.
    /// Only the stored results from Amazon DynamoDB are returned. OpsWorks CM does not query
    /// other services. 
    /// 
    ///  
    /// <para>
    ///  This operation is synchronous. 
    /// </para>
    ///  
    /// <para>
    ///  A <c>ResourceNotFoundException</c> is thrown when the server does not exist. A <c>ValidationException</c>
    /// is raised when parameters of the request are not valid. 
    /// </para>
    /// </summary>
    public partial class DescribeServersRequest : AmazonOpsWorksCMRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _serverName;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// This is not currently implemented for <c>DescribeServers</c> requests. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// This is not currently implemented for <c>DescribeServers</c> requests. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=10000)]
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
        /// Gets and sets the property ServerName. 
        /// <para>
        /// Describes the server with the specified ServerName.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
        public string ServerName
        {
            get { return this._serverName; }
            set { this._serverName = value; }
        }

        // Check to see if ServerName property is set
        internal bool IsSetServerName()
        {
            return this._serverName != null;
        }

    }
}