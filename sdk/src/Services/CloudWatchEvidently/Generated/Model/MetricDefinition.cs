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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
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
namespace Amazon.CloudWatchEvidently.Model
{
    /// <summary>
    /// This structure defines a metric that is being used to evaluate the variations during
    /// a launch or experiment.
    /// </summary>
    public partial class MetricDefinition
    {
        private string _entityIdKey;
        private string _eventPattern;
        private string _name;
        private string _unitLabel;
        private string _valueKey;

        /// <summary>
        /// Gets and sets the property EntityIdKey. 
        /// <para>
        /// The entity, such as a user or session, that does an action that causes a metric value
        /// to be recorded.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string EntityIdKey
        {
            get { return this._entityIdKey; }
            set { this._entityIdKey = value; }
        }

        // Check to see if EntityIdKey property is set
        internal bool IsSetEntityIdKey()
        {
            return this._entityIdKey != null;
        }

        /// <summary>
        /// Gets and sets the property EventPattern. 
        /// <para>
        /// The EventBridge event pattern that defines how the metric is recorded.
        /// </para>
        ///  
        /// <para>
        /// For more information about EventBridge event patterns, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-event-patterns.html">Amazon
        /// EventBridge event patterns</a>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the metric.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property UnitLabel. 
        /// <para>
        /// The label for the units that the metric is measuring.
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
        /// The value that is tracked to produce the metric.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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