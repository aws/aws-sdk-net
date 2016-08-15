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
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// Container for the parameters to the ListApplications operation.
    /// Returns a list of Amazon Kinesis Analytics applications in your account. For each
    /// application, the response includes the application name, Amazon Resource Name (ARN),
    /// and status. If the response returns the <code>HasMoreApplications</code> value as
    /// true, you can send another request by adding the <code>ExclusiveStartApplicationName</code>
    /// in the request body, and set the value of this to the last application name from the
    /// previous response. 
    /// 
    ///  
    /// <para>
    /// If you want detailed information about a specific application, use <a>DescribeApplication</a>.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <code>kinesisanalytics:ListApplications</code>
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

    }
}