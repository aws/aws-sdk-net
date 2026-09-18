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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Represents a single metric data query to include in a batch.
    /// </summary>
    public partial class BatchGetMetricDataQuery
    {
        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// An object that contains mapping between <c>MetricDimensionName</c> and <c>MetricDimensionValue</c>
        /// to filter metrics by.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 3)]
        public Dictionary<string, string> Dimensions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Dimensions property is set.
        /// </summary>
        internal bool IsSetDimensions() => this.Dimensions != null && (this.Dimensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// Represents the end date for the query interval.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Checks to see if the EndDate property is set.
        /// </summary>
        internal bool IsSetEndDate() => this.EndDate.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The query identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Metric. 
        /// <para>
        /// The queried metric. This can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SEND</c> – Emails sent eligible for tracking in the VDM dashboard. This excludes
        /// emails sent to the mailbox simulator and emails addressed to more than one recipient.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLAINT</c> – Complaints received for your account. This excludes complaints
        /// from the mailbox simulator, those originating from your account-level suppression
        /// list (if enabled), and those for emails addressed to more than one recipient
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PERMANENT_BOUNCE</c> – Permanent bounces - i.e. feedback received for emails sent
        /// to non-existent mailboxes. Excludes bounces from the mailbox simulator, those originating
        /// from your account-level suppression list (if enabled), and those for emails addressed
        /// to more than one recipient.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TRANSIENT_BOUNCE</c> – Transient bounces - i.e. feedback received for delivery
        /// failures excluding issues with non-existent mailboxes. Excludes bounces from the mailbox
        /// simulator, and those for emails addressed to more than one recipient.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OPEN</c> – Unique open events for emails including open trackers. Excludes opens
        /// for emails addressed to more than one recipient.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CLICK</c> – Unique click events for emails including wrapped links. Excludes clicks
        /// for emails addressed to more than one recipient.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELIVERY</c> – Successful deliveries for email sending attempts. Excludes deliveries
        /// to the mailbox simulator and for emails addressed to more than one recipient.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELIVERY_OPEN</c> – Successful deliveries for email sending attempts. Excludes
        /// deliveries to the mailbox simulator, for emails addressed to more than one recipient,
        /// and emails without open trackers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELIVERY_CLICK</c> – Successful deliveries for email sending attempts. Excludes
        /// deliveries to the mailbox simulator, for emails addressed to more than one recipient,
        /// and emails without click trackers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELIVERY_COMPLAINT</c> – Successful deliveries for email sending attempts. Excludes
        /// deliveries to the mailbox simulator, for emails addressed to more than one recipient,
        /// and emails addressed to recipients hosted by ISPs with which Amazon SES does not have
        /// a feedback loop agreement.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public Metric Metric { get; set; }

        /// <summary>
        /// Checks to see if the Metric property is set.
        /// </summary>
        internal bool IsSetMetric() => this.Metric != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The query namespace - e.g. <c>VDM</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MetricNamespace Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// Represents the start date for the query interval.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate.HasValue;
    }
}
