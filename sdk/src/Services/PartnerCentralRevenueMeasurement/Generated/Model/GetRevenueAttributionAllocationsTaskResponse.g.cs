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
    /// This is the response object from the GetRevenueAttributionAllocationsTask operation.
    /// </summary>
    public partial class GetRevenueAttributionAllocationsTaskResponse : AmazonWebServiceResponse
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
        /// Gets and sets the property Description. 
        /// <para>
        /// Human-readable description, if provided at creation.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// When processing ended. Only present when COMPLETE or FAILED.
        /// </para>
        /// </summary>
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Checks to see if the EndedAt property is set.
        /// </summary>
        internal bool IsSetEndedAt() => this.EndedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorDetailList. 
        /// <para>
        /// All errors discovered during async processing. Only present when FAILED.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RevenueAttributionAllocationErrorDetail> ErrorDetailList { get; set; } = AWSConfigs.InitializeCollections ? new List<RevenueAttributionAllocationErrorDetail>() : null;

        /// <summary>
        /// Checks to see if the ErrorDetailList property is set.
        /// </summary>
        internal bool IsSetErrorDetailList() => this.ErrorDetailList != null && (this.ErrorDetailList.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property RevenueAttributionLatestRevision. 
        /// <para>
        /// The revision number assigned to this batch. Only present when COMPLETE.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 19)]
        public string RevenueAttributionLatestRevision { get; set; }

        /// <summary>
        /// Checks to see if the RevenueAttributionLatestRevision property is set.
        /// </summary>
        internal bool IsSetRevenueAttributionLatestRevision() => this.RevenueAttributionLatestRevision != null;

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
        /// Current task status.
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
        /// The unique identifier for the asynchronous task.
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
