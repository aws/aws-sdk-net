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

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// Each <c>LongTermPricingListEntry</c> object contains information about a long-term
    /// pricing type.
    /// </summary>
    public partial class LongTermPricingListEntry
    {
        /// <summary>
        /// Gets and sets the property CurrentActiveJob. 
        /// <para>
        /// The current active jobs on the device the long-term pricing type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 39, Max = 39)]
        public string CurrentActiveJob { get; set; }

        /// <summary>
        /// Checks to see if the CurrentActiveJob property is set.
        /// </summary>
        internal bool IsSetCurrentActiveJob() => this.CurrentActiveJob != null;

        /// <summary>
        /// Gets and sets the property IsLongTermPricingAutoRenew. 
        /// <para>
        /// If set to <c>true</c>, specifies that the current long-term pricing type for the device
        /// should be automatically renewed before the long-term pricing contract expires.
        /// </para>
        /// </summary>
        public bool? IsLongTermPricingAutoRenew { get; set; }

        /// <summary>
        /// Checks to see if the IsLongTermPricingAutoRenew property is set.
        /// </summary>
        internal bool IsSetIsLongTermPricingAutoRenew() => this.IsLongTermPricingAutoRenew.HasValue;

        /// <summary>
        /// Gets and sets the property JobIds. 
        /// <para>
        /// The IDs of the jobs that are associated with a long-term pricing type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> JobIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the JobIds property is set.
        /// </summary>
        internal bool IsSetJobIds() => this.JobIds != null && (this.JobIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LongTermPricingEndDate. 
        /// <para>
        /// The end date the long-term pricing contract.
        /// </para>
        /// </summary>
        public DateTime? LongTermPricingEndDate { get; set; }

        /// <summary>
        /// Checks to see if the LongTermPricingEndDate property is set.
        /// </summary>
        internal bool IsSetLongTermPricingEndDate() => this.LongTermPricingEndDate.HasValue;

        /// <summary>
        /// Gets and sets the property LongTermPricingId. 
        /// <para>
        /// The ID of the long-term pricing type for the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 41, Max = 41)]
        public string LongTermPricingId { get; set; }

        /// <summary>
        /// Checks to see if the LongTermPricingId property is set.
        /// </summary>
        internal bool IsSetLongTermPricingId() => this.LongTermPricingId != null;

        /// <summary>
        /// Gets and sets the property LongTermPricingStartDate. 
        /// <para>
        /// The start date of the long-term pricing contract.
        /// </para>
        /// </summary>
        public DateTime? LongTermPricingStartDate { get; set; }

        /// <summary>
        /// Checks to see if the LongTermPricingStartDate property is set.
        /// </summary>
        internal bool IsSetLongTermPricingStartDate() => this.LongTermPricingStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property LongTermPricingStatus. 
        /// <para>
        /// The status of the long-term pricing type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string LongTermPricingStatus { get; set; }

        /// <summary>
        /// Checks to see if the LongTermPricingStatus property is set.
        /// </summary>
        internal bool IsSetLongTermPricingStatus() => this.LongTermPricingStatus != null;

        /// <summary>
        /// Gets and sets the property LongTermPricingType. 
        /// <para>
        /// The type of long-term pricing that was selected for the device.
        /// </para>
        /// </summary>
        public LongTermPricingType LongTermPricingType { get; set; }

        /// <summary>
        /// Checks to see if the LongTermPricingType property is set.
        /// </summary>
        internal bool IsSetLongTermPricingType() => this.LongTermPricingType != null;

        /// <summary>
        /// Gets and sets the property ReplacementJob. 
        /// <para>
        /// A new device that replaces a device that is ordered with long-term pricing.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 39, Max = 39)]
        public string ReplacementJob { get; set; }

        /// <summary>
        /// Checks to see if the ReplacementJob property is set.
        /// </summary>
        internal bool IsSetReplacementJob() => this.ReplacementJob != null;

        /// <summary>
        /// Gets and sets the property SnowballType. 
        /// <para>
        /// The type of Snow Family devices associated with this long-term pricing job.
        /// </para>
        /// </summary>
        public SnowballType SnowballType { get; set; }

        /// <summary>
        /// Checks to see if the SnowballType property is set.
        /// </summary>
        internal bool IsSetSnowballType() => this.SnowballType != null;
    }
}
