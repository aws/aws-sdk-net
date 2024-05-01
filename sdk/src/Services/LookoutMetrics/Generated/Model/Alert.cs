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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
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
namespace Amazon.LookoutMetrics.Model
{
    /// <summary>
    /// A configuration for Amazon SNS-integrated notifications.
    /// </summary>
    public partial class Alert
    {
        private Action _action;
        private string _alertArn;
        private string _alertDescription;
        private AlertFilters _alertFilters;
        private string _alertName;
        private int? _alertSensitivityThreshold;
        private AlertStatus _alertStatus;
        private AlertType _alertType;
        private string _anomalyDetectorArn;
        private DateTime? _creationTime;
        private DateTime? _lastModificationTime;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Action that will be triggered when there is an alert.
        /// </para>
        /// </summary>
        public Action Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property AlertArn. 
        /// <para>
        /// The ARN of the alert.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string AlertArn
        {
            get { return this._alertArn; }
            set { this._alertArn = value; }
        }

        // Check to see if AlertArn property is set
        internal bool IsSetAlertArn()
        {
            return this._alertArn != null;
        }

        /// <summary>
        /// Gets and sets the property AlertDescription. 
        /// <para>
        /// A description of the alert.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string AlertDescription
        {
            get { return this._alertDescription; }
            set { this._alertDescription = value; }
        }

        // Check to see if AlertDescription property is set
        internal bool IsSetAlertDescription()
        {
            return this._alertDescription != null;
        }

        /// <summary>
        /// Gets and sets the property AlertFilters. 
        /// <para>
        /// The configuration of the alert filters, containing MetricList and DimensionFilter.
        /// </para>
        /// </summary>
        public AlertFilters AlertFilters
        {
            get { return this._alertFilters; }
            set { this._alertFilters = value; }
        }

        // Check to see if AlertFilters property is set
        internal bool IsSetAlertFilters()
        {
            return this._alertFilters != null;
        }

        /// <summary>
        /// Gets and sets the property AlertName. 
        /// <para>
        /// The name of the alert.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string AlertName
        {
            get { return this._alertName; }
            set { this._alertName = value; }
        }

        // Check to see if AlertName property is set
        internal bool IsSetAlertName()
        {
            return this._alertName != null;
        }

        /// <summary>
        /// Gets and sets the property AlertSensitivityThreshold. 
        /// <para>
        /// The minimum severity for an anomaly to trigger the alert.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? AlertSensitivityThreshold
        {
            get { return this._alertSensitivityThreshold; }
            set { this._alertSensitivityThreshold = value; }
        }

        // Check to see if AlertSensitivityThreshold property is set
        internal bool IsSetAlertSensitivityThreshold()
        {
            return this._alertSensitivityThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AlertStatus. 
        /// <para>
        /// The status of the alert.
        /// </para>
        /// </summary>
        public AlertStatus AlertStatus
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
        /// Gets and sets the property AlertType. 
        /// <para>
        /// The type of the alert.
        /// </para>
        /// </summary>
        public AlertType AlertType
        {
            get { return this._alertType; }
            set { this._alertType = value; }
        }

        // Check to see if AlertType property is set
        internal bool IsSetAlertType()
        {
            return this._alertType != null;
        }

        /// <summary>
        /// Gets and sets the property AnomalyDetectorArn. 
        /// <para>
        /// The ARN of the detector to which the alert is attached.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string AnomalyDetectorArn
        {
            get { return this._anomalyDetectorArn; }
            set { this._anomalyDetectorArn = value; }
        }

        // Check to see if AnomalyDetectorArn property is set
        internal bool IsSetAnomalyDetectorArn()
        {
            return this._anomalyDetectorArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the alert was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModificationTime. 
        /// <para>
        /// The time at which the alert was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModificationTime
        {
            get { return this._lastModificationTime; }
            set { this._lastModificationTime = value; }
        }

        // Check to see if LastModificationTime property is set
        internal bool IsSetLastModificationTime()
        {
            return this._lastModificationTime.HasValue; 
        }

    }
}