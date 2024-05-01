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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
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
namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// The schedule's ad break properties.
    /// </summary>
    public partial class ScheduleAdBreak
    {
        private long? _approximateDurationSeconds;
        private DateTime? _approximateStartTime;
        private string _sourceLocationName;
        private string _vodSourceName;

        /// <summary>
        /// Gets and sets the property ApproximateDurationSeconds. 
        /// <para>
        /// The approximate duration of the ad break, in seconds.
        /// </para>
        /// </summary>
        public long? ApproximateDurationSeconds
        {
            get { return this._approximateDurationSeconds; }
            set { this._approximateDurationSeconds = value; }
        }

        // Check to see if ApproximateDurationSeconds property is set
        internal bool IsSetApproximateDurationSeconds()
        {
            return this._approximateDurationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ApproximateStartTime. 
        /// <para>
        /// The approximate time that the ad will start playing.
        /// </para>
        /// </summary>
        public DateTime? ApproximateStartTime
        {
            get { return this._approximateStartTime; }
            set { this._approximateStartTime = value; }
        }

        // Check to see if ApproximateStartTime property is set
        internal bool IsSetApproximateStartTime()
        {
            return this._approximateStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceLocationName. 
        /// <para>
        /// The name of the source location containing the VOD source used for the ad break.
        /// </para>
        /// </summary>
        public string SourceLocationName
        {
            get { return this._sourceLocationName; }
            set { this._sourceLocationName = value; }
        }

        // Check to see if SourceLocationName property is set
        internal bool IsSetSourceLocationName()
        {
            return this._sourceLocationName != null;
        }

        /// <summary>
        /// Gets and sets the property VodSourceName. 
        /// <para>
        /// The name of the VOD source used for the ad break.
        /// </para>
        /// </summary>
        public string VodSourceName
        {
            get { return this._vodSourceName; }
            set { this._vodSourceName = value; }
        }

        // Check to see if VodSourceName property is set
        internal bool IsSetVodSourceName()
        {
            return this._vodSourceName != null;
        }

    }
}