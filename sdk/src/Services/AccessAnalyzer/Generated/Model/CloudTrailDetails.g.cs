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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    public partial class CloudTrailDetails
    {
        /// <summary>
        /// Gets and sets the property AccessRole. 
        /// <para>
        /// The ARN of the service role that IAM Access Analyzer uses to access your CloudTrail
        /// trail and service last accessed information.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AccessRole { get; set; }

        /// <summary>
        /// Checks to see if the AccessRole property is set.
        /// </summary>
        internal bool IsSetAccessRole() => this.AccessRole != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time range for which IAM Access Analyzer reviews your CloudTrail events.
        /// Events with a timestamp after this time are not considered to generate a policy. If
        /// this is not included in the request, the default value is the current time.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start of the time range for which IAM Access Analyzer reviews your CloudTrail
        /// events. Events with a timestamp before this time are not considered to generate a
        /// policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Trails. 
        /// <para>
        /// A <c>Trail</c> object that contains settings for a trail.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Trail> Trails { get; set; } = AWSConfigs.InitializeCollections ? new List<Trail>() : null;

        /// <summary>
        /// Checks to see if the Trails property is set.
        /// </summary>
        internal bool IsSetTrails() => this.Trails != null && (this.Trails.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
