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
 * Do not modify this file. This file is generated from the partnercentral-revenue-measurement-2022-07-26.normal.json service model.
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
        private CatalogName _catalog;
        private string _revenueAttributionArn;
        private DateTime? _startedAt;
        private RevenueAttributionAllocationTaskStatus _status;
        private string _taskId;
        private int? _totalRevenueAttributionAllocationRecords;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog used for this task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CatalogName Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property RevenueAttributionArn. 
        /// <para>
        /// ARN of the revenue attribution resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RevenueAttributionArn
        {
            get { return this._revenueAttributionArn; }
            set { this._revenueAttributionArn = value; }
        }

        // Check to see if RevenueAttributionArn property is set
        internal bool IsSetRevenueAttributionArn()
        {
            return this._revenueAttributionArn != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// When processing started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Initial task status. Always IN_PROGRESS on successful submission.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RevenueAttributionAllocationTaskStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// Unique identifier for the submitted task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=21, Max=21)]
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

        /// <summary>
        /// Gets and sets the property TotalRevenueAttributionAllocationRecords. 
        /// <para>
        /// Total revenue attribution allocation records in the batch.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? TotalRevenueAttributionAllocationRecords
        {
            get { return this._totalRevenueAttributionAllocationRecords; }
            set { this._totalRevenueAttributionAllocationRecords = value; }
        }

        // Check to see if TotalRevenueAttributionAllocationRecords property is set
        internal bool IsSetTotalRevenueAttributionAllocationRecords()
        {
            return this._totalRevenueAttributionAllocationRecords.HasValue; 
        }

    }
}