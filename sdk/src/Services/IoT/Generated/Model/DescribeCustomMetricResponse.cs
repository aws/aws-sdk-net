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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the DescribeCustomMetric operation.
    /// </summary>
    public partial class DescribeCustomMetricResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationDate;
        private string _displayName;
        private DateTime? _lastModifiedDate;
        private string _metricArn;
        private string _metricName;
        private CustomMetricType _metricType;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        ///  The creation date of the custom metric in milliseconds since epoch. 
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        ///  Field represents a friendly name in the console for the custom metric; doesn't have
        /// to be unique. Don't use this name as the metric identifier in the device metric report.
        /// Can be updated. 
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
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        ///  The time the custom metric was last modified in milliseconds since epoch. 
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricArn. 
        /// <para>
        ///  The Amazon Resource Number (ARN) of the custom metric. 
        /// </para>
        /// </summary>
        public string MetricArn
        {
            get { return this._metricArn; }
            set { this._metricArn = value; }
        }

        // Check to see if MetricArn property is set
        internal bool IsSetMetricArn()
        {
            return this._metricArn != null;
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        ///  The name of the custom metric. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        ///  The type of the custom metric. 
        /// </para>
        ///  <important> 
        /// <para>
        /// The type <c>number</c> only takes a single metric value as an input, but while submitting
        /// the metrics value in the DeviceMetrics report, it must be passed as an array with
        /// a single value.
        /// </para>
        ///  </important>
        /// </summary>
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

    }
}