/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// How long, in days, message data is kept.
    /// </summary>
    public partial class RetentionPeriod
    {
        private int? _numberOfDays;
        private bool? _unlimited;

        /// <summary>
        /// Gets and sets the property NumberOfDays. 
        /// <para>
        /// The number of days that message data is kept. The "unlimited" parameter must be false.
        /// </para>
        /// </summary>
        public int NumberOfDays
        {
            get { return this._numberOfDays.GetValueOrDefault(); }
            set { this._numberOfDays = value; }
        }

        // Check to see if NumberOfDays property is set
        internal bool IsSetNumberOfDays()
        {
            return this._numberOfDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unlimited. 
        /// <para>
        /// If true, message data is kept indefinitely.
        /// </para>
        /// </summary>
        public bool Unlimited
        {
            get { return this._unlimited.GetValueOrDefault(); }
            set { this._unlimited = value; }
        }

        // Check to see if Unlimited property is set
        internal bool IsSetUnlimited()
        {
            return this._unlimited.HasValue; 
        }

    }
}