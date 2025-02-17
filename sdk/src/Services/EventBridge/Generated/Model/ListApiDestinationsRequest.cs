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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
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
namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// Container for the parameters to the ListApiDestinations operation.
    /// Retrieves a list of API destination in the account in the current Region.
    /// </summary>
    public partial class ListApiDestinationsRequest : AmazonEventBridgeRequest
    {
        private string _connectionArn;
        private int? _limit;
        private string _namePrefix;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ConnectionArn. 
        /// <para>
        /// The ARN of the connection specified for the API destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string ConnectionArn
        {
            get { return this._connectionArn; }
            set { this._connectionArn = value; }
        }

        // Check to see if ConnectionArn property is set
        internal bool IsSetConnectionArn()
        {
            return this._connectionArn != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of API destinations to include in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NamePrefix. 
        /// <para>
        /// A name prefix to filter results returned. Only API destinations with a name that starts
        /// with the prefix are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string NamePrefix
        {
            get { return this._namePrefix; }
            set { this._namePrefix = value; }
        }

        // Check to see if NamePrefix property is set
        internal bool IsSetNamePrefix()
        {
            return this._namePrefix != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned by a previous call, which you can use to retrieve the next set
        /// of results.
        /// </para>
        ///  
        /// <para>
        /// The value of <c>nextToken</c> is a unique pagination token for each page. To retrieve
        /// the next page of results, make the call again using the returned token. Keep all other
        /// arguments unchanged.
        /// </para>
        ///  
        /// <para>
        ///  Using an expired pagination token results in an <c>HTTP 400 InvalidToken</c> error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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

    }
}