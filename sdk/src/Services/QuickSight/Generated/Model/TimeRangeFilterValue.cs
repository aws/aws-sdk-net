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
    /// The value of a time range filter.
    /// 
    ///  
    /// <para>
    /// This is a union type structure. For this structure to be valid, only one of the attributes
    /// can be defined.
    /// </para>
    /// </summary>
    public partial class TimeRangeFilterValue
    {
        private string _parameter;
        private RollingDateConfiguration _rollingDate;
        private DateTime? _staticValue;

        /// <summary>
        /// Gets and sets the property Parameter. 
        /// <para>
        /// The parameter type input value.
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
        /// Gets and sets the property RollingDate. 
        /// <para>
        /// The rolling date input value.
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
        /// Gets and sets the property StaticValue. 
        /// <para>
        /// The static input value.
        /// </para>
        /// </summary>
        public DateTime StaticValue
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