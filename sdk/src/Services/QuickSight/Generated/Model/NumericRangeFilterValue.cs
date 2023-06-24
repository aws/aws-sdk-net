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
    /// The value input pf the numeric range filter.
    /// </summary>
    public partial class NumericRangeFilterValue
    {
        private string _parameter;
        private double? _staticValue;

        /// <summary>
        /// Gets and sets the property Parameter. 
        /// <para>
        /// The parameter that is used in the numeric range.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Parameter
        {
            get { return this._parameter; }
            set { this._parameter = value; }
        }

        // Check to see if Parameter property is set
        internal bool IsSetParameter()
        {
            return this._parameter != null;
        }

        /// <summary>
        /// Gets and sets the property StaticValue. 
        /// <para>
        /// The static value of the numeric range filter.
        /// </para>
        /// </summary>
        public double StaticValue
        {
            get { return this._staticValue.GetValueOrDefault(); }
            set { this._staticValue = value; }
        }

        // Check to see if StaticValue property is set
        internal bool IsSetStaticValue()
        {
            return this._staticValue.HasValue; 
        }

    }
}