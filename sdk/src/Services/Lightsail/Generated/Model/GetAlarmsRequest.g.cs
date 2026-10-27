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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the GetAlarms operation. Returns information about
    /// the configured alarms. Specify an alarm name in your request to return information
    /// about a specific alarm, or specify a monitored resource name to return information
    /// about all alarms for a specific resource. <para> An alarm is used to monitor a single
    /// metric for one of your resources. When a metric condition is met, the alarm can notify
    /// you by email, SMS text message, and a banner displayed on the Amazon Lightsail console.
    /// For more information, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-alarms">Alarms
    /// in Amazon Lightsail</a>. </para>
    /// </summary>
    public partial class GetAlarmsRequest : AmazonLightsailRequest
    {
        /// <summary>
        /// Gets and sets the property AlarmName. 
        /// <para>
        /// The name of the alarm.
        /// </para>
        ///  
        /// <para>
        /// Specify an alarm name to return information about a specific alarm.
        /// </para>
        /// </summary>
        public string AlarmName { get; set; }

        /// <summary>
        /// Checks to see if the AlarmName property is set.
        /// </summary>
        internal bool IsSetAlarmName() => this.AlarmName != null;

        /// <summary>
        /// Gets and sets the property MonitoredResourceName. 
        /// <para>
        /// The name of the Lightsail resource being monitored by the alarm.
        /// </para>
        ///  
        /// <para>
        /// Specify a monitored resource name to return information about all alarms for a specific
        /// resource.
        /// </para>
        /// </summary>
        public string MonitoredResourceName { get; set; }

        /// <summary>
        /// Checks to see if the MonitoredResourceName property is set.
        /// </summary>
        internal bool IsSetMonitoredResourceName() => this.MonitoredResourceName != null;

        /// <summary>
        /// Gets and sets the property PageToken. 
        /// <para>
        /// The token to advance to the next page of results from your request.
        /// </para>
        ///  
        /// <para>
        /// To get a page token, perform an initial <c>GetAlarms</c> request. If your results
        /// are paginated, the response will return a next page token that you can specify as
        /// the page token in a subsequent request.
        /// </para>
        /// </summary>
        public string PageToken { get; set; }

        /// <summary>
        /// Checks to see if the PageToken property is set.
        /// </summary>
        internal bool IsSetPageToken() => this.PageToken != null;
    }
}
