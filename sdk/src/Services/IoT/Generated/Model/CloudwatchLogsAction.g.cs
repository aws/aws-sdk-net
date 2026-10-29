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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Describes an action that sends data to CloudWatch Logs.
    /// </summary>
    public partial class CloudwatchLogsAction
    {
        /// <summary>
        /// Gets and sets the property BatchMode. 
        /// <para>
        /// Indicates whether batches of log records will be extracted and uploaded into CloudWatch.
        /// Values include <c>true</c> or <c>false</c> <i>(default)</i>.
        /// </para>
        /// </summary>
        public bool? BatchMode { get; set; }

        /// <summary>
        /// Checks to see if the BatchMode property is set.
        /// </summary>
        internal bool IsSetBatchMode() => this.BatchMode.HasValue;

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The CloudWatch log group to which the action sends data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LogGroupName { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupName property is set.
        /// </summary>
        internal bool IsSetLogGroupName() => this.LogGroupName != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role that allows access to the CloudWatch log.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
