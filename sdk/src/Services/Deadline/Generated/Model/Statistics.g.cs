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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// A list of statistics for a session.
    /// </summary>
    public partial class Statistics
    {
        /// <summary>
        /// Gets and sets the property AggregationEndTime. 
        /// <para>
        /// The end time for the aggregation.
        /// </para>
        /// </summary>
        public DateTime? AggregationEndTime { get; set; }

        /// <summary>
        /// Checks to see if the AggregationEndTime property is set.
        /// </summary>
        internal bool IsSetAggregationEndTime() => this.AggregationEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property AggregationStartTime. 
        /// <para>
        /// The start time for the aggregation.
        /// </para>
        /// </summary>
        public DateTime? AggregationStartTime { get; set; }

        /// <summary>
        /// Checks to see if the AggregationStartTime property is set.
        /// </summary>
        internal bool IsSetAggregationStartTime() => this.AggregationStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property CostInUsd. 
        /// <para>
        /// How the statistics should appear in USD. Options include: minimum, maximum, average
        /// or sum.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Stats CostInUsd { get; set; }

        /// <summary>
        /// Checks to see if the CostInUsd property is set.
        /// </summary>
        internal bool IsSetCostInUsd() => this.CostInUsd != null;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of instances in a list of statistics.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// The fleet ID.
        /// </para>
        /// </summary>
        public string FleetId { get; set; }

        /// <summary>
        /// Checks to see if the FleetId property is set.
        /// </summary>
        internal bool IsSetFleetId() => this.FleetId != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The type of instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The job ID.
        /// </para>
        /// </summary>
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The job name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property LicenseProduct. 
        /// <para>
        /// The licensed product.
        /// </para>
        /// </summary>
        public string LicenseProduct { get; set; }

        /// <summary>
        /// Checks to see if the LicenseProduct property is set.
        /// </summary>
        internal bool IsSetLicenseProduct() => this.LicenseProduct != null;

        /// <summary>
        /// Gets and sets the property QueueId. 
        /// <para>
        /// The queue ID.
        /// </para>
        /// </summary>
        public string QueueId { get; set; }

        /// <summary>
        /// Checks to see if the QueueId property is set.
        /// </summary>
        internal bool IsSetQueueId() => this.QueueId != null;

        /// <summary>
        /// Gets and sets the property RuntimeInSeconds. 
        /// <para>
        /// The total aggregated runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Stats RuntimeInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeInSeconds property is set.
        /// </summary>
        internal bool IsSetRuntimeInSeconds() => this.RuntimeInSeconds != null;

        /// <summary>
        /// Gets and sets the property UsageType. 
        /// <para>
        /// The type of usage for the statistics.
        /// </para>
        /// </summary>
        public UsageType UsageType { get; set; }

        /// <summary>
        /// Checks to see if the UsageType property is set.
        /// </summary>
        internal bool IsSetUsageType() => this.UsageType != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The user ID.
        /// </para>
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
