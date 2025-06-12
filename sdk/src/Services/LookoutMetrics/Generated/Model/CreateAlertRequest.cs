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
    /// Container for the parameters to the CreateAlert operation.
    /// Creates an alert for an anomaly detector.
    /// </summary>
    public partial class CreateAlertRequest : AmazonLookoutMetricsRequest
    {
        private Action _action;
        private string _alertDescription;
        private AlertFilters _alertFilters;
        private string _alertName;
        private int? _alertSensitivityThreshold;
        private string _anomalyDetectorArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Action that will be triggered when there is an alert.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The configuration of the alert filters, containing MetricList and DimensionFilterList.
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
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        /// An integer from 0 to 100 specifying the alert sensitivity threshold.
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
        /// Gets and sets the property AnomalyDetectorArn. 
        /// <para>
        /// The ARN of the detector to which the alert is attached.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of <a href="https://docs.aws.amazon.com/lookoutmetrics/latest/dev/detectors-tags.html">tags</a>
        /// to apply to the alert.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}