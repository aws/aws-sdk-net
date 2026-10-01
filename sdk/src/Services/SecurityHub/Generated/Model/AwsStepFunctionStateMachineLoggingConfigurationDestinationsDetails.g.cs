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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// An array of objects that describes where your execution history events will be logged.
    /// </summary>
    public partial class AwsStepFunctionStateMachineLoggingConfigurationDestinationsDetails
    {
        /// <summary>
        /// Gets and sets the property CloudWatchLogsLogGroup. 
        /// <para>
        ///  An object describing a CloudWatch Logs log group. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-loggroup.html">
        /// Amazon Web Services::Logs::LogGroup</a> in the <i>CloudFormation User Guide</i>. 
        /// </para>
        /// </summary>
        public AwsStepFunctionStateMachineLoggingConfigurationDestinationsCloudWatchLogsLogGroupDetails CloudWatchLogsLogGroup { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLogsLogGroup property is set.
        /// </summary>
        internal bool IsSetCloudWatchLogsLogGroup() => this.CloudWatchLogsLogGroup != null;
    }
}
