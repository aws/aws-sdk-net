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
    /// Provides the forecast to meet the target for a particular date.
    /// </summary>
    public partial class WhatIfPointScenario
    {
        private DateTime? _date;
        private double? _value;

        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// The date that you need the forecast results for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime Date
        {
            get { return this._date.GetValueOrDefault(); }
            set { this._date = value; }
        }

        // Check to see if Date property is set
        internal bool IsSetDate()
        {
            return this._date.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The target value that you want to meet for the provided date.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double Value
        {
            get { return this._value.GetValueOrDefault(); }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}