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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
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
namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Describes a filter for choosing a subset of objects. Each filter consists of a condition
    /// and a match statement. The condition is either <c>IS</c> or <c>IS_NOT</c>, which specifies
    /// whether to include or exclude the objects that match the statement, respectively.
    /// The match statement consists of a key and a value.
    /// </summary>
    public partial class Filter
    {
        private FilterConditionString _condition;
        private string _key;
        private string _value;

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// The condition to apply. To include the objects that match the statement, specify <c>IS</c>.
        /// To exclude matching objects, specify <c>IS_NOT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FilterConditionString Condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        // Check to see if Condition property is set
        internal bool IsSetCondition()
        {
            return this._condition != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The name of the parameter to filter on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value to match.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}