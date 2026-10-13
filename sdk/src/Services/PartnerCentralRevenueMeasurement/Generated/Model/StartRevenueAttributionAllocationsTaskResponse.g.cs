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

namespace Amazon.PartnerCentralRevenueMeasurement.Model
{
    /// <summary>
    /// This is the response object from the StartRevenueAttributionAllocationsTask operation.
    /// </summary>
    public partial class StartRevenueAttributionAllocationsTaskResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog used for this task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CatalogName Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property RevenueAttributionArn. 
        /// <para>
        /// ARN of the revenue attribution resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RevenueAttributionArn { get; set; }

        /// <summary>
        /// Checks to see if the RevenueAttributionArn property is set.
        /// </summary>
        internal bool IsSetRevenueAttributionArn() => this.RevenueAttributionArn != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// When processing started.
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
        /// Initial task status. Always IN_PROGRESS on successful submission.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RevenueAttributionAllocationTaskStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// Unique identifier for the submitted task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 21, Max = 21)]
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;

        /// <summary>
        /// Gets and sets the property TotalRevenueAttributionAllocationRecords. 
        /// <para>
        /// Total revenue attribution allocation records in the batch.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? TotalRevenueAttributionAllocationRecords { get; set; }

        /// <summary>
        /// Checks to see if the TotalRevenueAttributionAllocationRecords property is set.
        /// </summary>
        internal bool IsSetTotalRevenueAttributionAllocationRecords() => this.TotalRevenueAttributionAllocationRecords.HasValue;
    }
}
