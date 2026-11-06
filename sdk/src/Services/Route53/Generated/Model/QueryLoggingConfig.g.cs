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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that contains information about a configuration for DNS query logging.
    /// </summary>
    public partial class QueryLoggingConfig
    {
        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID for a configuration for DNS query logging.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The ID of the hosted zone that CloudWatch Logs is logging queries for. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 32)]
        public string HostedZoneId { get; set; }

        /// <summary>
        /// Checks to see if the HostedZoneId property is set.
        /// </summary>
        internal bool IsSetHostedZoneId() => this.HostedZoneId != null;

        /// <summary>
        /// Gets and sets the property CloudWatchLogsLogGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the CloudWatch Logs log group that Amazon Route
        /// 53 is publishing logs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CloudWatchLogsLogGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLogsLogGroupArn property is set.
        /// </summary>
        internal bool IsSetCloudWatchLogsLogGroupArn() => this.CloudWatchLogsLogGroupArn != null;
    }
}
