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

namespace Amazon.InternetMonitor.Model
{
    /// <summary>
    /// Information about a health event created in a monitor in Amazon CloudWatch Internet
    /// Monitor.
    /// </summary>
    public partial class HealthEvent
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// When the health event was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The time when a health event ended. If the health event is still active, then the
        /// end time is not set.
        /// </para>
        /// </summary>
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Checks to see if the EndedAt property is set.
        /// </summary>
        internal bool IsSetEndedAt() => this.EndedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EventArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string EventArn { get; set; }

        /// <summary>
        /// Checks to see if the EventArn property is set.
        /// </summary>
        internal bool IsSetEventArn() => this.EventArn != null;

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The internally-generated identifier of a specific network traffic impairment health
        /// event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string EventId { get; set; }

        /// <summary>
        /// Checks to see if the EventId property is set.
        /// </summary>
        internal bool IsSetEventId() => this.EventId != null;

        /// <summary>
        /// Gets and sets the property HealthScoreThreshold. 
        /// <para>
        /// The value of the threshold percentage for performance or availability that was configured
        /// when Amazon CloudWatch Internet Monitor created the health event.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public double? HealthScoreThreshold { get; set; }

        /// <summary>
        /// Checks to see if the HealthScoreThreshold property is set.
        /// </summary>
        internal bool IsSetHealthScoreThreshold() => this.HealthScoreThreshold.HasValue;

        /// <summary>
        /// Gets and sets the property ImpactType. 
        /// <para>
        /// The type of impairment for a health event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HealthEventImpactType ImpactType { get; set; }

        /// <summary>
        /// Checks to see if the ImpactType property is set.
        /// </summary>
        internal bool IsSetImpactType() => this.ImpactType != null;

        /// <summary>
        /// Gets and sets the property ImpactedLocations. 
        /// <para>
        /// The locations impacted by the health event.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<ImpactedLocation> ImpactedLocations { get; set; } = AWSConfigs.InitializeCollections ? new List<ImpactedLocation>() : null;

        /// <summary>
        /// Checks to see if the ImpactedLocations property is set.
        /// </summary>
        internal bool IsSetImpactedLocations() => this.ImpactedLocations != null && (this.ImpactedLocations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// When the health event was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property PercentOfTotalTrafficImpacted. 
        /// <para>
        /// The impact on total traffic that a health event has, in increased latency or reduced
        /// availability. This is the percentage of how much latency has increased or availability
        /// has decreased during the event, compared to what is typical for traffic from this
        /// client location to the Amazon Web Services location using this client network.
        /// </para>
        /// </summary>
        public double? PercentOfTotalTrafficImpacted { get; set; }

        /// <summary>
        /// Checks to see if the PercentOfTotalTrafficImpacted property is set.
        /// </summary>
        internal bool IsSetPercentOfTotalTrafficImpacted() => this.PercentOfTotalTrafficImpacted.HasValue;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// When a health event started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a health event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HealthEventStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
