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
 * Do not modify this file. This file is generated from the simspaceweaver-2022-10-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimSpaceWeaver.Model
{
    /// <summary>
    /// The location where SimSpace Weaver sends simulation log data.
    /// </summary>
    public partial class LogDestination
    {
        private CloudWatchLogsLogGroup _cloudWatchLogsLogGroup;

        /// <summary>
        /// Gets and sets the property CloudWatchLogsLogGroup. 
        /// <para>
        /// An Amazon CloudWatch Logs log group that stores simulation log data. For more information
        /// about log groups, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/Working-with-log-groups-and-streams.html">Working
        /// with log groups and log streams</a> in the <i>Amazon CloudWatch Logs User Guide</i>.
        /// </para>
        /// </summary>
        public CloudWatchLogsLogGroup CloudWatchLogsLogGroup
        {
            get { return this._cloudWatchLogsLogGroup; }
            set { this._cloudWatchLogsLogGroup = value; }
        }

        // Check to see if CloudWatchLogsLogGroup property is set
        internal bool IsSetCloudWatchLogsLogGroup()
        {
            return this._cloudWatchLogsLogGroup != null;
        }

    }
}