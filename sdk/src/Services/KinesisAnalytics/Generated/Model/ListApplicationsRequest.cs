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
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
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
namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// Container for the parameters to the ListApplications operation.
    /// <note> 
    /// <para>
    /// This documentation is for version 1 of the Amazon Kinesis Data Analytics API, which
    /// only supports SQL applications. Version 2 of the API supports SQL and Java applications.
    /// For more information about version 2, see <a href="/kinesisanalytics/latest/apiv2/Welcome.html">Amazon
    /// Kinesis Data Analytics API V2 Documentation</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Returns a list of Amazon Kinesis Analytics applications in your account. For each
    /// application, the response includes the application name, Amazon Resource Name (ARN),
    /// and status. If the response returns the <c>HasMoreApplications</c> value as true,
    /// you can send another request by adding the <c>ExclusiveStartApplicationName</c> in
    /// the request body, and set the value of this to the last application name from the
    /// previous response. 
    /// </para>
    ///  
    /// <para>
    /// If you want detailed information about a specific application, use <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/API_DescribeApplication.html">DescribeApplication</a>.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <c>kinesisanalytics:ListApplications</c>
    /// action.
    /// </para>
    /// </summary>
    public partial class ListApplicationsRequest : AmazonKinesisAnalyticsRequest
    {
        private string _exclusiveStartApplicationName;
        private int? _limit;

        /// <summary>
        /// Gets and sets the property ExclusiveStartApplicationName. 
        /// <para>
        /// Name of the application to start the list with. When using pagination to retrieve
        /// the list, you don't need to specify this parameter in the first request. However,
        /// in subsequent requests, you add the last application name from the previous response
        /// to get the next page of applications.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ExclusiveStartApplicationName
        {
            get { return this._exclusiveStartApplicationName; }
            set { this._exclusiveStartApplicationName = value; }
        }

        // Check to see if ExclusiveStartApplicationName property is set
        internal bool IsSetExclusiveStartApplicationName()
        {
            return this._exclusiveStartApplicationName != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Maximum number of applications to list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

    }
}