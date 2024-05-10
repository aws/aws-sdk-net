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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The CIS date filter.
    /// </summary>
    public partial class CisDateFilter
    {
        private DateTime? _earliestScanStartTime;
        private DateTime? _latestScanStartTime;

        /// <summary>
        /// Gets and sets the property EarliestScanStartTime. 
        /// <para>
        /// The CIS date filter's earliest scan start time.
        /// </para>
        /// </summary>
        public DateTime? EarliestScanStartTime
        {
            get { return this._earliestScanStartTime; }
            set { this._earliestScanStartTime = value; }
        }

        // Check to see if EarliestScanStartTime property is set
        internal bool IsSetEarliestScanStartTime()
        {
            return this._earliestScanStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestScanStartTime. 
        /// <para>
        /// The CIS date filter's latest scan start time.
        /// </para>
        /// </summary>
        public DateTime? LatestScanStartTime
        {
            get { return this._latestScanStartTime; }
            set { this._latestScanStartTime = value; }
        }

        // Check to see if LatestScanStartTime property is set
        internal bool IsSetLatestScanStartTime()
        {
            return this._latestScanStartTime.HasValue; 
        }

    }
}