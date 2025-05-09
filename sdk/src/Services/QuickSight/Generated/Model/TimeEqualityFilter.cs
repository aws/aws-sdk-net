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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A <c>TimeEqualityFilter</c> filters values that are equal to a given value.
    /// </summary>
    public partial class TimeEqualityFilter
    {
        private ColumnIdentifier _column;
        private DefaultFilterControlConfiguration _defaultFilterControlConfiguration;
        private string _filterId;
        private string _parameterName;
        private RollingDateConfiguration _rollingDate;
        private TimeGranularity _timeGranularity;
        private DateTime? _value;

        /// <summary>
        /// Gets and sets the property Column. 
        /// <para>
        /// The column that the filter is applied to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ColumnIdentifier Column
        {
            get { return this._column; }
            set { this._column = value; }
        }

        // Check to see if Column property is set
        internal bool IsSetColumn()
        {
            return this._column != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultFilterControlConfiguration. 
        /// <para>
        /// The default configurations for the associated controls. This applies only for filters
        /// that are scoped to multiple sheets.
        /// </para>
        /// </summary>
        public DefaultFilterControlConfiguration DefaultFilterControlConfiguration
        {
            get { return this._defaultFilterControlConfiguration; }
            set { this._defaultFilterControlConfiguration = value; }
        }

        // Check to see if DefaultFilterControlConfiguration property is set
        internal bool IsSetDefaultFilterControlConfiguration()
        {
            return this._defaultFilterControlConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property FilterId. 
        /// <para>
        /// An identifier that uniquely identifies a filter within a dashboard, analysis, or template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string FilterId
        {
            get { return this._filterId; }
            set { this._filterId = value; }
        }

        // Check to see if FilterId property is set
        internal bool IsSetFilterId()
        {
            return this._filterId != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterName. 
        /// <para>
        /// The parameter whose value should be used for the filter value.
        /// </para>
        ///  
        /// <para>
        /// This field is mutually exclusive to <c>Value</c> and <c>RollingDate</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ParameterName
        {
            get { return this._parameterName; }
            set { this._parameterName = value; }
        }

        // Check to see if ParameterName property is set
        internal bool IsSetParameterName()
        {
            return this._parameterName != null;
        }

        /// <summary>
        /// Gets and sets the property RollingDate. 
        /// <para>
        /// The rolling date input for the <c>TimeEquality</c> filter.
        /// </para>
        ///  
        /// <para>
        /// This field is mutually exclusive to <c>Value</c> and <c>ParameterName</c>.
        /// </para>
        /// </summary>
        public RollingDateConfiguration RollingDate
        {
            get { return this._rollingDate; }
            set { this._rollingDate = value; }
        }

        // Check to see if RollingDate property is set
        internal bool IsSetRollingDate()
        {
            return this._rollingDate != null;
        }

        /// <summary>
        /// Gets and sets the property TimeGranularity. 
        /// <para>
        /// The level of time precision that is used to aggregate <c>DateTime</c> values.
        /// </para>
        /// </summary>
        public TimeGranularity TimeGranularity
        {
            get { return this._timeGranularity; }
            set { this._timeGranularity = value; }
        }

        // Check to see if TimeGranularity property is set
        internal bool IsSetTimeGranularity()
        {
            return this._timeGranularity != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of a <c>TimeEquality</c> filter.
        /// </para>
        ///  
        /// <para>
        /// This field is mutually exclusive to <c>RollingDate</c> and <c>ParameterName</c>.
        /// </para>
        /// </summary>
        public DateTime? Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}