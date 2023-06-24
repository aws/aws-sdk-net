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
    /// Provides summary information of an alert's history.
    /// </summary>
    public partial class MonitoringAlertHistorySummary
    {
        private MonitoringAlertStatus _alertStatus;
        private DateTime? _creationTime;
        private string _monitoringAlertName;
        private string _monitoringScheduleName;

        /// <summary>
        /// Gets and sets the property AlertStatus. 
        /// <para>
        /// The current alert status of an alert.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MonitoringAlertStatus AlertStatus
        {
            get { return this._alertStatus; }
            set { this._alertStatus = value; }
        }

        // Check to see if AlertStatus property is set
        internal bool IsSetAlertStatus()
        {
            return this._alertStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that indicates when the first alert transition occurred in an alert history.
        /// An alert transition can be from status <code>InAlert</code> to <code>OK</code>, or
        /// from <code>OK</code> to <code>InAlert</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MonitoringAlertName. 
        /// <para>
        /// The name of a monitoring alert.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        /// Gets and sets the property MonitoringScheduleName. 
        /// <para>
        /// The name of a monitoring schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string MonitoringScheduleName
        {
            get { return this._monitoringScheduleName; }
            set { this._monitoringScheduleName = value; }
        }

        // Check to see if MonitoringScheduleName property is set
        internal bool IsSetMonitoringScheduleName()
        {
            return this._monitoringScheduleName != null;
        }

    }
}