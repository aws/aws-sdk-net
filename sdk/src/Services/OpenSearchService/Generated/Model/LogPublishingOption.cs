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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Specifies whether the Amazon OpenSearch Service domain publishes the OpenSearch application
    /// and slow logs to Amazon CloudWatch. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/createdomain-configure-slow-logs.html">Monitoring
    /// OpenSearch logs with Amazon CloudWatch Logs</a>.
    /// 
    ///  <note> 
    /// <para>
    /// After you enable log publishing, you still have to enable the collection of slow logs
    /// using the OpenSearch REST API.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class LogPublishingOption
    {
        private string _cloudWatchLogsLogGroupArn;
        private bool? _enabled;

        /// <summary>
        /// Gets and sets the property CloudWatchLogsLogGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the CloudWatch Logs group to publish logs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string CloudWatchLogsLogGroupArn
        {
            get { return this._cloudWatchLogsLogGroupArn; }
            set { this._cloudWatchLogsLogGroupArn = value; }
        }

        // Check to see if CloudWatchLogsLogGroupArn property is set
        internal bool IsSetCloudWatchLogsLogGroupArn()
        {
            return this._cloudWatchLogsLogGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether the log should be published.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

    }
}