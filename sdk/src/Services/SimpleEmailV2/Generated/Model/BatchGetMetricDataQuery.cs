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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Represents a single metric data query to include in a batch.
    /// </summary>
    public partial class BatchGetMetricDataQuery
    {
        private Dictionary<string, string> _dimensions = new Dictionary<string, string>();
        private DateTime? _endDate;
        private string _id;
        private Metric _metric;
        private MetricNamespace _awsNamespace;
        private DateTime? _startDate;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// An object that contains mapping between <code>MetricDimensionName</code> and <code>MetricDimensionValue</code>
        /// to filter metrics by.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public Dictionary<string, string> Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null && this._dimensions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// Represents the end date for the query interval.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime EndDate
        {
            get { return this._endDate.GetValueOrDefault(); }
            set { this._endDate = value; }
        }

        // Check to see if EndDate property is set
        internal bool IsSetEndDate()
        {
            return this._endDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The query identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Metric. 
        /// <para>
        /// The queried metric. This can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>SEND</code> – Emails sent eligible for tracking in the VDM dashboard. This
        /// excludes emails sent to the mailbox simulator and emails addressed to more than one
        /// recipient.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>COMPLAINT</code> – Complaints received for your account. This excludes complaints
        /// from the mailbox simulator, those originating from your account-level suppression
        /// list (if enabled), and those for emails addressed to more than one recipient
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PERMANENT_BOUNCE</code> – Permanent bounces - i.e. feedback received for emails
        /// sent to non-existent mailboxes. Excludes bounces from the mailbox simulator, those
        /// originating from your account-level suppression list (if enabled), and those for emails
        /// addressed to more than one recipient.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TRANSIENT_BOUNCE</code> – Transient bounces - i.e. feedback received for delivery
        /// failures excluding issues with non-existent mailboxes. Excludes bounces from the mailbox
        /// simulator, and those for emails addressed to more than one recipient.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OPEN</code> – Unique open events for emails including open trackers. Excludes
        /// opens for emails addressed to more than one recipient.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CLICK</code> – Unique click events for emails including wrapped links. Excludes
        /// clicks for emails addressed to more than one recipient.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELIVERY</code> – Successful deliveries for email sending attempts. Excludes
        /// deliveries to the mailbox simulator and for emails addressed to more than one recipient.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELIVERY_OPEN</code> – Successful deliveries for email sending attempts. Excludes
        /// deliveries to the mailbox simulator, for emails addressed to more than one recipient,
        /// and emails without open trackers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELIVERY_CLICK</code> – Successful deliveries for email sending attempts. Excludes
        /// deliveries to the mailbox simulator, for emails addressed to more than one recipient,
        /// and emails without click trackers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELIVERY_COMPLAINT</code> – Successful deliveries for email sending attempts.
        /// Excludes deliveries to the mailbox simulator, for emails addressed to more than one
        /// recipient, and emails addressed to recipients hosted by ISPs with which Amazon SES
        /// does not have a feedback loop agreement.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public Metric Metric
        {
            get { return this._metric; }
            set { this._metric = value; }
        }

        // Check to see if Metric property is set
        internal bool IsSetMetric()
        {
            return this._metric != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The query namespace - e.g. <code>VDM</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetricNamespace Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// Represents the start date for the query interval.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime StartDate
        {
            get { return this._startDate.GetValueOrDefault(); }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate.HasValue; 
        }

    }
}