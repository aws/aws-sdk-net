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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Contains information about CloudTrail access.
    /// </summary>
    public partial class CloudTrailProperties
    {
        private DateTime? _endTime;
        private DateTime? _startTime;
        private List<TrailProperties> _trailProperties = AWSConfigs.InitializeCollections ? new List<TrailProperties>() : null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time range for which IAM Access Analyzer reviews your CloudTrail events.
        /// Events with a timestamp after this time are not considered to generate a policy. If
        /// this is not included in the request, the default value is the current time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The start of the time range for which IAM Access Analyzer reviews your CloudTrail
        /// events. Events with a timestamp before this time are not considered to generate a
        /// policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property TrailProperties. 
        /// <para>
        /// A <c>TrailProperties</c> object that contains settings for trail properties.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<TrailProperties> TrailProperties
        {
            get { return this._trailProperties; }
            set { this._trailProperties = value; }
        }

        // Check to see if TrailProperties property is set
        internal bool IsSetTrailProperties()
        {
            return this._trailProperties != null && (this._trailProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}