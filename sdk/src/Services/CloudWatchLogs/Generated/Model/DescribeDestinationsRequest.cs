/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDestinations operation.
    /// Returns all the destinations that are associated with the AWS account making the request.
    /// The list returned in the response is ASCII-sorted by destination name.
    /// 
    ///  
    /// <para>
    /// By default, this operation returns up to 50 destinations. If there are more destinations
    /// to list, the response would contain a <code>nextToken</code> value in the response
    /// body. You can also limit the number of destinations returned in the response by specifying
    /// the <code>limit</code> parameter in the request.
    /// </para>
    /// </summary>
    public partial class DescribeDestinationsRequest : AmazonCloudWatchLogsRequest
    {
        private string _destinationNamePrefix;
        private int? _limit;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DestinationNamePrefix. 
        /// <para>
        /// Will only return destinations that match the provided destinationNamePrefix. If you
        /// don't specify a value, no prefix is applied.
        /// </para>
        /// </summary>
        public string DestinationNamePrefix
        {
            get { return this._destinationNamePrefix; }
            set { this._destinationNamePrefix = value; }
        }

        // Check to see if DestinationNamePrefix property is set
        internal bool IsSetDestinationNamePrefix()
        {
            return this._destinationNamePrefix != null;
        }

        /// <summary>
        /// Gets and sets the property Limit.
        /// </summary>
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
        /// Gets and sets the property NextToken.
        /// </summary>
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