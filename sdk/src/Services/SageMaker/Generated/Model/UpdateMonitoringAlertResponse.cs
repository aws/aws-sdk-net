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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the UpdateMonitoringAlert operation.
    /// </summary>
    public partial class UpdateMonitoringAlertResponse : AmazonWebServiceResponse
    {
        private string _monitoringAlertName;
        private string _monitoringScheduleArn;

        /// <summary>
        /// Gets and sets the property MonitoringAlertName. 
        /// <para>
        /// The name of a monitoring alert.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string MonitoringAlertName
        {
            get { return this._monitoringAlertName; }
            set { this._monitoringAlertName = value; }
        }

        // Check to see if MonitoringAlertName property is set
        internal bool IsSetMonitoringAlertName()
        {
            return this._monitoringAlertName != null;
        }

        /// <summary>
        /// Gets and sets the property MonitoringScheduleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the monitoring schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string MonitoringScheduleArn
        {
            get { return this._monitoringScheduleArn; }
            set { this._monitoringScheduleArn = value; }
        }

        // Check to see if MonitoringScheduleArn property is set
        internal bool IsSetMonitoringScheduleArn()
        {
            return this._monitoringScheduleArn != null;
        }

    }
}