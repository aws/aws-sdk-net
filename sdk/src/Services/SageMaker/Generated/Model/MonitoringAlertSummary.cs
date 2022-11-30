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
    /// Provides summary information about a monitor alert.
    /// </summary>
    public partial class MonitoringAlertSummary
    {
        private MonitoringAlertActions _actions;
        private MonitoringAlertStatus _alertStatus;
        private DateTime? _creationTime;
        private int? _datapointsToAlert;
        private int? _evaluationPeriod;
        private DateTime? _lastModifiedTime;
        private string _monitoringAlertName;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// A list of alert actions taken in response to an alert going into <code>InAlert</code>
        /// status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MonitoringAlertActions Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null;
        }

        /// <summary>
        /// Gets and sets the property AlertStatus. 
        /// <para>
        /// The current status of an alert.
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
        /// A timestamp that indicates when a monitor alert was created.
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
        /// Gets and sets the property DatapointsToAlert. 
        /// <para>
        /// Within <code>EvaluationPeriod</code>, how many execution failures will raise an alert.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public int DatapointsToAlert
        {
            get { return this._datapointsToAlert.GetValueOrDefault(); }
            set { this._datapointsToAlert = value; }
        }

        // Check to see if DatapointsToAlert property is set
        internal bool IsSetDatapointsToAlert()
        {
            return this._datapointsToAlert.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EvaluationPeriod. 
        /// <para>
        /// The number of most recent monitoring executions to consider when evaluating alert
        /// status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public int EvaluationPeriod
        {
            get { return this._evaluationPeriod.GetValueOrDefault(); }
            set { this._evaluationPeriod = value; }
        }

        // Check to see if EvaluationPeriod property is set
        internal bool IsSetEvaluationPeriod()
        {
            return this._evaluationPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// A timestamp that indicates when a monitor alert was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
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

    }
}