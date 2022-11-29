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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The data field series item configuration of a line chart.
    /// </summary>
    public partial class DataFieldSeriesItem
    {
        private AxisBinding _axisBinding;
        private string _fieldId;
        private string _fieldValue;
        private LineChartSeriesSettings _settings;

        /// <summary>
        /// Gets and sets the property AxisBinding. 
        /// <para>
        /// The axis that you are binding the field to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AxisBinding AxisBinding
        {
            get { return this._axisBinding; }
            set { this._axisBinding = value; }
        }

        // Check to see if AxisBinding property is set
        internal bool IsSetAxisBinding()
        {
            return this._axisBinding != null;
        }

        /// <summary>
        /// Gets and sets the property FieldId. 
        /// <para>
        /// The field ID of the field that you are setting the axis binding to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string FieldId
        {
            get { return this._fieldId; }
            set { this._fieldId = value; }
        }

        // Check to see if FieldId property is set
        internal bool IsSetFieldId()
        {
            return this._fieldId != null;
        }

        /// <summary>
        /// Gets and sets the property FieldValue. 
        /// <para>
        /// The field value of the field that you are setting the axis binding to.
        /// </para>
        /// </summary>
        public string FieldValue
        {
            get { return this._fieldValue; }
            set { this._fieldValue = value; }
        }

        // Check to see if FieldValue property is set
        internal bool IsSetFieldValue()
        {
            return this._fieldValue != null;
        }

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// The options that determine the presentation of line series associated to the field.
        /// </para>
        /// </summary>
        public LineChartSeriesSettings Settings
        {
            get { return this._settings; }
            set { this._settings = value; }
        }

        // Check to see if Settings property is set
        internal bool IsSetSettings()
        {
            return this._settings != null;
        }

    }
}