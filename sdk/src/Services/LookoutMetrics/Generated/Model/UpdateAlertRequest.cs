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
    /// Container for the parameters to the UpdateAlert operation.
    /// Make changes to an existing alert.
    /// </summary>
    public partial class UpdateAlertRequest : AmazonLookoutMetricsRequest
    {
        private Action _action;
        private string _alertArn;
        private string _alertDescription;
        private AlertFilters _alertFilters;
        private int? _alertSensitivityThreshold;

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
        /// The ARN of the alert to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
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

    }
}