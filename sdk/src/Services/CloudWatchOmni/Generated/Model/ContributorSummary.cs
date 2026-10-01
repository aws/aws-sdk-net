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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
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
namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Counts of contributors currently breaching each severity threshold.
    /// </summary>
    public partial class ContributorSummary
    {
        private int? _criticalCount;
        private int? _warningCount;

        /// <summary>
        /// Gets and sets the property CriticalCount. 
        /// <para>
        /// Number of contributors currently breaching the critical threshold.
        /// </para>
        /// </summary>
        public int? CriticalCount
        {
            get { return this._criticalCount; }
            set { this._criticalCount = value; }
        }

        // Check to see if CriticalCount property is set
        internal bool IsSetCriticalCount()
        {
            return this._criticalCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WarningCount. 
        /// <para>
        /// Number of contributors currently breaching the warning threshold.
        /// </para>
        /// </summary>
        public int? WarningCount
        {
            get { return this._warningCount; }
            set { this._warningCount = value; }
        }

        // Check to see if WarningCount property is set
        internal bool IsSetWarningCount()
        {
            return this._warningCount.HasValue; 
        }

    }
}