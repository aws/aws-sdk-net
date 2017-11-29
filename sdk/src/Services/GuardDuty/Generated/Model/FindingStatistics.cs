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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Finding statistics object.
    /// </summary>
    public partial class FindingStatistics
    {
        private Dictionary<string, int> _countBySeverity = new Dictionary<string, int>();

        /// <summary>
        /// Gets and sets the property CountBySeverity. Represents a map of severity to count
        /// statistic for a set of findings
        /// </summary>
        public Dictionary<string, int> CountBySeverity
        {
            get { return this._countBySeverity; }
            set { this._countBySeverity = value; }
        }

        // Check to see if CountBySeverity property is set
        internal bool IsSetCountBySeverity()
        {
            return this._countBySeverity != null && this._countBySeverity.Count > 0; 
        }

    }
}