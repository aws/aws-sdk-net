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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeFieldIndexes operation.
    /// Returns a list of field indexes discovered in log data. By default, the response includes
    /// the <c>DEFAULT</c>, <c>CUSTOM</c>, and <c>INACTIVE</c> index categories. To return
    /// indexes from other categories, use the <c>indexCategories</c> parameter.
    /// 
    ///  
    /// <para>
    /// For more information about field index policies, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutIndexPolicy.html">PutIndexPolicy</a>.
    /// </para>
    /// </summary>
    public partial class DescribeFieldIndexesRequest : AmazonCloudWatchLogsRequest
    {
        private List<string> _indexCategories = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _logGroupIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property IndexCategories. 
        /// <para>
        /// The index categories to return. The following values are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DEFAULT</c>: Fields that CloudWatch Logs indexes by default. Examples include
        /// <c>@logStream</c> and <c>@data_format</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CUSTOM</c>: Fields that you added manually to the field index policy. CloudWatch
        /// Logs always indexes these fields. These fields count toward the quota of 20 fields
        /// for each log group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AUTO</c>: Fields that CloudWatch Logs indexes automatically based on your query
        /// patterns and usage. These fields do not count toward the field index quota. CloudWatch
        /// Logs might update these fields based on changes in your query patterns. To keep a
        /// field indexed permanently, add it to an account-level or log-group level field index
        /// policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INACTIVE</c>: Fields that CloudWatch Logs indexed before but does not index now.
        /// This happens if you remove a field from the field index policy or if CloudWatch Logs
        /// automatically selects a different field based on your queries.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you omit this parameter, the response includes the <c>DEFAULT</c>, <c>CUSTOM</c>,
        /// and <c>INACTIVE</c> categories.
        /// </para>
        ///  
        /// <para>
        /// For more information about automatically indexed fields and using the <c>AUTO</c>
        /// category, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatchLogs-Field-Indexing-Automatic.html">Automatically
        /// indexed fields</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=4)]
        public List<string> IndexCategories
        {
            get { return this._indexCategories; }
            set { this._indexCategories = value; }
        }

        // Check to see if IndexCategories property is set
        internal bool IsSetIndexCategories()
        {
            return this._indexCategories != null && (this._indexCategories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LogGroupIdentifiers. 
        /// <para>
        /// An array containing the names or ARNs of the log groups that you want to retrieve
        /// field indexes for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> LogGroupIdentifiers
        {
            get { return this._logGroupIdentifiers; }
            set { this._logGroupIdentifiers = value; }
        }

        // Check to see if LogGroupIdentifiers property is set
        internal bool IsSetLogGroupIdentifiers()
        {
            return this._logGroupIdentifiers != null && (this._logGroupIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min=1)]
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