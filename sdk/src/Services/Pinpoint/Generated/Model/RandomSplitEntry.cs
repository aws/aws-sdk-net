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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the settings for a path in a random split activity in a journey.
    /// </summary>
    public partial class RandomSplitEntry
    {
        private string _nextActivity;
        private int? _percentage;

        /// <summary>
        /// Gets and sets the property NextActivity. 
        /// <para>
        /// The unique identifier for the next activity to perform, after completing the activity
        /// for the path.
        /// </para>
        /// </summary>
        public string NextActivity
        {
            get { return this._nextActivity; }
            set { this._nextActivity = value; }
        }

        // Check to see if NextActivity property is set
        internal bool IsSetNextActivity()
        {
            return this._nextActivity != null;
        }

        /// <summary>
        /// Gets and sets the property Percentage. 
        /// <para>
        /// The percentage of participants to send down the activity path.
        /// </para>
        /// </summary>
        public int Percentage
        {
            get { return this._percentage.GetValueOrDefault(); }
            set { this._percentage = value; }
        }

        // Check to see if Percentage property is set
        internal bool IsSetPercentage()
        {
            return this._percentage.HasValue; 
        }

    }
}