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

namespace Amazon.Braket.Model
{
    /// <summary>
    /// Contains summary information about a spending limit, including current spending status
    /// and configuration details.
    /// </summary>
    public partial class SpendingLimitSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the spending limit was created, in epoch seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DeviceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the quantum device associated with this spending
        /// limit.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string DeviceArn { get; set; }

        /// <summary>
        /// Checks to see if the DeviceArn property is set.
        /// </summary>
        internal bool IsSetDeviceArn() => this.DeviceArn != null;

        /// <summary>
        /// Gets and sets the property QueuedSpend. 
        /// <para>
        /// The amount currently queued for spending on the device, in USD.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string QueuedSpend { get; set; }

        /// <summary>
        /// Checks to see if the QueuedSpend property is set.
        /// </summary>
        internal bool IsSetQueuedSpend() => this.QueuedSpend != null;

        /// <summary>
        /// Gets and sets the property SpendingLimit. 
        /// <para>
        /// The maximum spending amount allowed for the device during the specified time period,
        /// in USD.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SpendingLimit { get; set; }

        /// <summary>
        /// Checks to see if the SpendingLimit property is set.
        /// </summary>
        internal bool IsSetSpendingLimit() => this.SpendingLimit != null;

        /// <summary>
        /// Gets and sets the property SpendingLimitArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the spending limit.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string SpendingLimitArn { get; set; }

        /// <summary>
        /// Checks to see if the SpendingLimitArn property is set.
        /// </summary>
        internal bool IsSetSpendingLimitArn() => this.SpendingLimitArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the spending limit. Each tag consists of a key and an optional
        /// value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// The time period during which the spending limit is active.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TimePeriod TimePeriod { get; set; }

        /// <summary>
        /// Checks to see if the TimePeriod property is set.
        /// </summary>
        internal bool IsSetTimePeriod() => this.TimePeriod != null;

        /// <summary>
        /// Gets and sets the property TotalSpend. 
        /// <para>
        /// The total amount spent on the device so far during the current time period, in USD.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TotalSpend { get; set; }

        /// <summary>
        /// Checks to see if the TotalSpend property is set.
        /// </summary>
        internal bool IsSetTotalSpend() => this.TotalSpend != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the spending limit was last modified, in epoch seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
