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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// A filter condition applied to a metric component in a calculation. Filters restrict
    /// the data included in the metric computation.
    /// </summary>
    public partial class MetricFilter
    {
        private MetricFilterBooleanCondition _booleanCondition;
        private string _metricFilterKey;
        private bool? _negate;
        private MetricFilterNumberCondition _numberCondition;
        private MetricFilterStringCondition _stringCondition;

        /// <summary>
        /// Gets and sets the property BooleanCondition. 
        /// <para>
        /// A boolean comparison condition.
        /// </para>
        /// </summary>
        public MetricFilterBooleanCondition BooleanCondition
        {
            get { return this._booleanCondition; }
            set { this._booleanCondition = value; }
        }

        // Check to see if BooleanCondition property is set
        internal bool IsSetBooleanCondition()
        {
            return this._booleanCondition != null;
        }

        /// <summary>
        /// Gets and sets the property MetricFilterKey. 
        /// <para>
        /// The key identifying the field to filter on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string MetricFilterKey
        {
            get { return this._metricFilterKey; }
            set { this._metricFilterKey = value; }
        }

        // Check to see if MetricFilterKey property is set
        internal bool IsSetMetricFilterKey()
        {
            return this._metricFilterKey != null;
        }

        /// <summary>
        /// Gets and sets the property Negate. 
        /// <para>
        /// Specifies whether the filter condition is negated. When set to <c>true</c>, the filter
        /// excludes matching data instead of including it.
        /// </para>
        /// </summary>
        public bool? Negate
        {
            get { return this._negate; }
            set { this._negate = value; }
        }

        // Check to see if Negate property is set
        internal bool IsSetNegate()
        {
            return this._negate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberCondition. 
        /// <para>
        /// A numeric comparison condition.
        /// </para>
        /// </summary>
        public MetricFilterNumberCondition NumberCondition
        {
            get { return this._numberCondition; }
            set { this._numberCondition = value; }
        }

        // Check to see if NumberCondition property is set
        internal bool IsSetNumberCondition()
        {
            return this._numberCondition != null;
        }

        /// <summary>
        /// Gets and sets the property StringCondition. 
        /// <para>
        /// A string comparison condition.
        /// </para>
        /// </summary>
        public MetricFilterStringCondition StringCondition
        {
            get { return this._stringCondition; }
            set { this._stringCondition = value; }
        }

        // Check to see if StringCondition property is set
        internal bool IsSetStringCondition()
        {
            return this._stringCondition != null;
        }

    }
}