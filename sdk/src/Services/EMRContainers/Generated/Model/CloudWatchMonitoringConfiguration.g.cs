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

namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// A configuration for CloudWatch monitoring. You can configure your jobs to send log
    /// information to CloudWatch Logs.
    /// </summary>
    public partial class CloudWatchMonitoringConfiguration
    {
        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the log group for log publishing.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string LogGroupName { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupName property is set.
        /// </summary>
        internal bool IsSetLogGroupName() => this.LogGroupName != null;

        /// <summary>
        /// Gets and sets the property LogStreamNamePrefix. 
        /// <para>
        /// The specified name prefix for log streams.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string LogStreamNamePrefix { get; set; }

        /// <summary>
        /// Checks to see if the LogStreamNamePrefix property is set.
        /// </summary>
        internal bool IsSetLogStreamNamePrefix() => this.LogStreamNamePrefix != null;
    }
}
