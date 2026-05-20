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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
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
namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Specifies the automated snapshot pause request options for the domain.
    /// 
    ///  <important> 
    /// <para>
    /// Suspending snapshots reduces data protection. You cannot restore your domain to points
    /// in time when snapshots are suspended. Use this feature only for short-term operational
    /// needs such as migrations or maintenance windows.
    /// </para>
    ///  </important> 
    /// <para>
    /// Maximum suspension duration: 3 days.
    /// </para>
    /// </summary>
    public partial class AutomatedSnapshotPauseRequestOptions
    {
        private bool? _enabled;
        private DateTime? _endTime;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether to enable or disable automated snapshot pause for the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp at which the automated snapshot pause should end. The maximum allowed
        /// duration between <c>StartTime</c> and <c>EndTime</c> is 3 days.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp at which the automated snapshot pause should begin.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}