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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
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
namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Used to filter the workflow executions in visibility APIs by various time-based rules.
    /// Each parameter, if specified, defines a rule that must be satisfied by each returned
    /// query result. The parameter values are in the <a href="https://en.wikipedia.org/wiki/Unix_time">Unix
    /// Time format</a>. For example: <c>"oldestDate": 1325376070.</c>
    /// </summary>
    public partial class ExecutionTimeFilter
    {
        private DateTime? _latestDate;
        private DateTime? _oldestDate;

        /// <summary>
        /// Gets and sets the property LatestDate. 
        /// <para>
        /// Specifies the latest start or close date and time to return.
        /// </para>
        /// </summary>
        public DateTime? LatestDate
        {
            get { return this._latestDate; }
            set { this._latestDate = value; }
        }

        // Check to see if LatestDate property is set
        internal bool IsSetLatestDate()
        {
            return this._latestDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OldestDate. 
        /// <para>
        /// Specifies the oldest start or close date and time to return.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? OldestDate
        {
            get { return this._oldestDate; }
            set { this._oldestDate = value; }
        }

        // Check to see if OldestDate property is set
        internal bool IsSetOldestDate()
        {
            return this._oldestDate.HasValue; 
        }

    }
}