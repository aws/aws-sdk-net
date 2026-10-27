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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Information about CloudWatch Logs for a build project.
    /// </summary>
    public partial class CloudWatchLogsConfig
    {
        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        ///  The group name of the logs in CloudWatch Logs. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/Working-with-log-groups-and-streams.html">Working
        /// with Log Groups and Log Streams</a>. 
        /// </para>
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// Checks to see if the GroupName property is set.
        /// </summary>
        internal bool IsSetGroupName() => this.GroupName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the logs in CloudWatch Logs for a build project. Valid values
        /// are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLED</c>: CloudWatch Logs are enabled for this build project.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c>: CloudWatch Logs are not enabled for this build project.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public LogsConfigStatusType Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        ///  The prefix of the stream name of the CloudWatch Logs. For more information, see <a
        /// href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/Working-with-log-groups-and-streams.html">Working
        /// with Log Groups and Log Streams</a>. 
        /// </para>
        /// </summary>
        public string StreamName { get; set; }

        /// <summary>
        /// Checks to see if the StreamName property is set.
        /// </summary>
        internal bool IsSetStreamName() => this.StreamName != null;
    }
}
