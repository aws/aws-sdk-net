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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the GetLogAnomalyDetector operation. Retrieves information
    /// about the log anomaly detector that you specify. The KMS key ARN detected is valid.
    /// </summary>
    public partial class GetLogAnomalyDetectorRequest : AmazonCloudWatchLogsRequest
    {
        /// <summary>
        /// Gets and sets the property AnomalyDetectorArn. 
        /// <para>
        /// The ARN of the anomaly detector to retrieve information about. You can find the ARNs
        /// of log anomaly detectors in your account by using the <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_ListLogAnomalyDetectors.html">ListLogAnomalyDetectors</a>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string AnomalyDetectorArn { get; set; }

        /// <summary>
        /// Checks to see if the AnomalyDetectorArn property is set.
        /// </summary>
        internal bool IsSetAnomalyDetectorArn() => this.AnomalyDetectorArn != null;
    }
}
