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

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Describes the CloudWatch Logs configuration for the Event API.
    /// </summary>
    public partial class EventLogConfig
    {
        /// <summary>
        /// Gets and sets the property CloudWatchLogsRoleArn. 
        /// <para>
        /// The IAM service role that AppSync assumes to publish CloudWatch Logs in your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CloudWatchLogsRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLogsRoleArn property is set.
        /// </summary>
        internal bool IsSetCloudWatchLogsRoleArn() => this.CloudWatchLogsRoleArn != null;

        /// <summary>
        /// Gets and sets the property LogLevel. 
        /// <para>
        /// The type of information to log for the Event API. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EventLogLevel LogLevel { get; set; }

        /// <summary>
        /// Checks to see if the LogLevel property is set.
        /// </summary>
        internal bool IsSetLogLevel() => this.LogLevel != null;
    }
}
