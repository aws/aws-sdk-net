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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCustomMetric operation.
    /// Use this API to define a Custom Metric published by your devices to Device Defender.
    /// </summary>
    public partial class CreateCustomMetricRequest : AmazonIoTRequest
    {
        private string _clientRequestToken;
        private string _displayName;
        private string _metricName;
        private CustomMetricType _metricType;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Each custom metric must have a unique client request token. If you try to create a
        /// new custom metric that already exists with a different token, an exception occurs.
        /// If you omit this value, AWS SDKs will automatically generate a unique client request.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        ///  Field represents a friendly name in the console for the custom metric; it doesn't
        /// have to be unique. Don't use this name as the metric identifier in the device metric
        /// report. Can be updated once defined.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        ///  The name of the custom metric. This will be used in the metric report submitted from
        /// the device/thing. Shouldn't begin with <code>aws:</code>. Cannot be updated once defined.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property MetricType. 
        /// <para>
        ///  The type of the custom metric. Types include <code>string-list</code>, <code>ip-address-list</code>,
        /// <code>number-list</code>, and <code>number</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CustomMetricType MetricType
        {
            get { return this._metricType; }
            set { this._metricType = value; }
        }

        // Check to see if MetricType property is set
        internal bool IsSetMetricType()
        {
            return this._metricType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  Metadata that can be used to manage the custom metric. 
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}