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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Container for the parameters to the ListApplications operation.
    /// Returns a list of Amazon Kinesis Data Analytics applications in your account. For
    /// each application, the response includes the application name, Amazon Resource Name
    /// (ARN), and status. 
    /// 
    ///  
    /// <para>
    /// If you want detailed information about a specific application, use <a>DescribeApplication</a>.
    /// </para>
    /// </summary>
    public partial class ListApplicationsRequest : AmazonKinesisAnalyticsV2Request
    {
        private int? _limit;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of applications to list.
        /// </para>
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
        /// <para>
        /// If a previous command returned a pagination token, pass it into this value to retrieve
        /// the next set of results. For more information about pagination, see <a href="https://docs.aws.amazon.com/cli/latest/userguide/pagination.html">Using
        /// the AWS Command Line Interface's Pagination Options</a>.
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

    }
}