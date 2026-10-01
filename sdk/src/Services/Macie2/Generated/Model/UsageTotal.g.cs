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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides aggregated data for an Amazon Macie usage metric. The value for the metric
    /// reports estimated usage data for an account for the preceding 30 days or the current
    /// calendar month to date, depending on the time period (timeRange) specified in the
    /// request.
    /// </summary>
    public partial class UsageTotal
    {
        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        /// The type of currency that the value for the metric (estimatedCost) is reported in.
        /// </para>
        /// </summary>
        public Currency Currency { get; set; }

        /// <summary>
        /// Checks to see if the Currency property is set.
        /// </summary>
        internal bool IsSetCurrency() => this.Currency != null;

        /// <summary>
        /// Gets and sets the property EstimatedCost. 
        /// <para>
        /// The estimated value for the metric.
        /// </para>
        /// </summary>
        public string EstimatedCost { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedCost property is set.
        /// </summary>
        internal bool IsSetEstimatedCost() => this.EstimatedCost != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The name of the metric. Possible values are: AUTOMATED_OBJECT_MONITORING, to monitor
        /// S3 objects for automated sensitive data discovery; AUTOMATED_SENSITIVE_DATA_DISCOVERY,
        /// to analyze S3 objects for automated sensitive data discovery; DATA_INVENTORY_EVALUATION,
        /// to monitor S3 buckets; and, SENSITIVE_DATA_DISCOVERY, to run classification jobs.
        /// </para>
        /// </summary>
        public UsageType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
