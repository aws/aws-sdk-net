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
    /// Container for the parameters to the UpdateMonitoringAlert operation.
    /// Update the parameters of a model monitor alert.
    /// </summary>
    public partial class UpdateMonitoringAlertRequest : AmazonSageMakerRequest
    {
        private int? _datapointsToAlert;
        private int? _evaluationPeriod;
        private string _monitoringAlertName;
        private string _monitoringScheduleName;

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