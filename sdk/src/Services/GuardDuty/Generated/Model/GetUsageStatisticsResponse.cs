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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// This is the response object from the GetUsageStatistics operation.
    /// </summary>
    public partial class GetUsageStatisticsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private UsageStatistics _usageStatistics;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination parameter to be used on the next list operation to retrieve more items.
        /// </para>
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

        /// <summary>
        /// Gets and sets the property UsageStatistics. 
        /// <para>
        /// The usage statistics object. If a UsageStatisticType was provided, the objects representing
        /// other types will be null.
        /// </para>
        /// </summary>
        public UsageStatistics UsageStatistics
        {
            get { return this._usageStatistics; }
            set { this._usageStatistics = value; }
        }

        // Check to see if UsageStatistics property is set
        internal bool IsSetUsageStatistics()
        {
            return this._usageStatistics != null;
        }

    }
}