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
    /// A parameter declaration for the <code>DateTime</code> data type.
    /// </summary>
    public partial class DateTimeParameterDeclaration
    {
        private DateTimeDefaultValues _defaultValues;
        private string _name;
        private TimeGranularity _timeGranularity;
        private DateTimeValueWhenUnsetConfiguration _valueWhenUnset;

        /// <summary>
        /// Gets and sets the property DefaultValues. 
        /// <para>
        /// The default values of a parameter. If the parameter is a single-value parameter, a
        /// maximum of one default value can be provided.
        /// </para>
        /// </summary>
        public DateTimeDefaultValues DefaultValues
        {
            get { return this._defaultValues; }
            set { this._defaultValues = value; }
        }

        // Check to see if DefaultValues property is set
        internal bool IsSetDefaultValues()
        {
            return this._defaultValues != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the parameter that is being declared.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        /// Gets and sets the property TimeGranularity. 
        /// <para>
        /// The level of time precision that is used to aggregate <code>DateTime</code> values.
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
        /// Gets and sets the property ValueWhenUnset. 
        /// <para>
        /// The configuration that defines the default value of a <code>DateTime</code> parameter
        /// when a value has not been set.
        /// </para>
        /// </summary>
        public DateTimeValueWhenUnsetConfiguration ValueWhenUnset
        {
            get { return this._valueWhenUnset; }
            set { this._valueWhenUnset = value; }
        }

        // Check to see if ValueWhenUnset property is set
        internal bool IsSetValueWhenUnset()
        {
            return this._valueWhenUnset != null;
        }

    }
}