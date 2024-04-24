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
 * Do not modify this file. This file is generated from the iotevents-data-2018-10-23.normal.json service model.
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
namespace Amazon.IoTEventsData.Model
{
    /// <summary>
    /// This is the response object from the DescribeAlarm operation.
    /// </summary>
    public partial class DescribeAlarmResponse : AmazonWebServiceResponse
    {
        private Alarm _alarm;

        /// <summary>
        /// Gets and sets the property Alarm. 
        /// <para>
        /// Contains information about an alarm.
        /// </para>
        /// </summary>
        public Alarm Alarm
        {
            get { return this._alarm; }
            set { this._alarm = value; }
        }

        // Check to see if Alarm property is set
        internal bool IsSetAlarm()
        {
            return this._alarm != null;
        }

    }
}