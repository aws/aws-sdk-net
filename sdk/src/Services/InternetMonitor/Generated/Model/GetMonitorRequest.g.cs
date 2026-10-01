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

namespace Amazon.InternetMonitor.Model
{
    /// <summary>
    /// Container for the parameters to the GetMonitor operation. Gets information about a
    /// monitor in Amazon CloudWatch Internet Monitor based on a monitor name. The information
    /// returned includes the Amazon Resource Name (ARN), create time, modified time, resources
    /// included in the monitor, and status information.
    /// </summary>
    public partial class GetMonitorRequest : AmazonInternetMonitorRequest
    {
        /// <summary>
        /// Gets and sets the property LinkedAccountId. 
        /// <para>
        /// The account ID for an account that you've set up cross-account sharing for in Amazon
        /// CloudWatch Internet Monitor. You configure cross-account sharing by using Amazon CloudWatch
        /// Observability Access Manager. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/cwim-cross-account.html">Internet
        /// Monitor cross-account observability</a> in the Amazon CloudWatch Internet Monitor
        /// User Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string LinkedAccountId { get; set; }

        /// <summary>
        /// Checks to see if the LinkedAccountId property is set.
        /// </summary>
        internal bool IsSetLinkedAccountId() => this.LinkedAccountId != null;

        /// <summary>
        /// Gets and sets the property MonitorName. 
        /// <para>
        /// The name of the monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string MonitorName { get; set; }

        /// <summary>
        /// Checks to see if the MonitorName property is set.
        /// </summary>
        internal bool IsSetMonitorName() => this.MonitorName != null;
    }
}
