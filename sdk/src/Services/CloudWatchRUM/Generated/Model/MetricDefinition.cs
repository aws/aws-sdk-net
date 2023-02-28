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
 * Do not modify this file. This file is generated from the rum-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchRUM.Model
{
    /// <summary>
    /// A structure that displays the definition of one extended metric that RUM sends to
    /// CloudWatch or CloudWatch Evidently. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-RUM-vended-metrics.html">
    /// Additional metrics that you can send to CloudWatch and CloudWatch Evidently</a>.
    /// </summary>
    public partial class MetricDefinition
    {
        private Dictionary<string, string> _dimensionKeys = new Dictionary<string, string>();
        private string _eventPattern;
        private string _metricDefinitionId;
        private string _name;
        private string _awsNamespace;
        private string _unitLabel;
        private string _valueKey;

        /// <summary>
        /// Gets and sets the property DimensionKeys. 
        /// <para>
        /// This field is a map of field paths to dimension names. It defines the dimensions to
        /// associate with this metric in CloudWatch The value of this field is used only if the
        /// metric destination is <code>CloudWatch</code>. If the metric destination is <code>Evidently</code>,
        /// the value of <code>DimensionKeys</code> is ignored.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=29)]
        public Dictionary<string, string> DimensionKeys
        {
            get { return this._dimensionKeys; }
            set { this._dimensionKeys = value; }
        }

        // Check to see if DimensionKeys property is set
        internal bool IsSetDimensionKeys()
        {
            return this._dimensionKeys != null && this._dimensionKeys.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EventPattern. 
        /// <para>
        /// The pattern that defines the metric. RUM checks events that happen in a user's session
        /// against the pattern, and events that match the pattern are sent to the metric destination.
        /// </para>
        ///  
        /// <para>
        /// If the metrics destination is <code>CloudWatch</code> and the event also matches a
        /// value in <code>DimensionKeys</code>, then the metric is published with the specified
        /// dimensions. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=4000)]
        public string EventPattern
        {
            get { return this._eventPattern; }
            set { this._eventPattern = value; }
        }

        // Check to see if EventPattern property is set
        internal bool IsSetEventPattern()
        {
            return this._eventPattern != null;
        }

        /// <summary>
        /// Gets and sets the property MetricDefinitionId. 
        /// <para>
        /// The ID of this metric definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string MetricDefinitionId
        {
            get { return this._metricDefinitionId; }
            set { this._metricDefinitionId = value; }
        }

        // Check to see if MetricDefinitionId property is set
        internal bool IsSetMetricDefinitionId()
        {
            return this._metricDefinitionId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the metric that is defined in this structure.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// If this metric definition is for a custom metric instead of an extended metric, this
        /// field displays the metric namespace that the custom metric is published to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=237)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property UnitLabel. 
        /// <para>
        /// Use this field only if you are sending this metric to CloudWatch. It defines the CloudWatch
        /// metric unit that this metric is measured in. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string UnitLabel
        {
            get { return this._unitLabel; }
            set { this._unitLabel = value; }
        }

        // Check to see if UnitLabel property is set
        internal bool IsSetUnitLabel()
        {
            return this._unitLabel != null;
        }

        /// <summary>
        /// Gets and sets the property ValueKey. 
        /// <para>
        /// The field within the event object that the metric value is sourced from.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=280)]
        public string ValueKey
        {
            get { return this._valueKey; }
            set { this._valueKey = value; }
        }

        // Check to see if ValueKey property is set
        internal bool IsSetValueKey()
        {
            return this._valueKey != null;
        }

    }
}