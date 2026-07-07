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
    /// This is the response object from the GetRevenueAttributionAllocationsTask operation.
    /// </summary>
    public partial class GetRevenueAttributionAllocationsTaskResponse : AmazonWebServiceResponse
    {
        private CatalogName _catalog;
        private string _description;
        private DateTime? _endedAt;
        private List<RevenueAttributionAllocationErrorDetail> _errorDetailList = AWSConfigs.InitializeCollections ? new List<RevenueAttributionAllocationErrorDetail>() : null;
        private string _revenueAttributionArn;
        private string _revenueAttributionLatestRevision;
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
        /// Gets and sets the property Description. 
        /// <para>
        /// Human-readable description, if provided at creation.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// When processing ended. Only present when COMPLETE or FAILED.
        /// </para>
        /// </summary>
        public DateTime? EndedAt
        {
            get { return this._endedAt; }
            set { this._endedAt = value; }
        }

        // Check to see if EndedAt property is set
        internal bool IsSetEndedAt()
        {
            return this._endedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorDetailList. 
        /// <para>
        /// All errors discovered during async processing. Only present when FAILED.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RevenueAttributionAllocationErrorDetail> ErrorDetailList
        {
            get { return this._errorDetailList; }
            set { this._errorDetailList = value; }
        }

        // Check to see if ErrorDetailList property is set
        internal bool IsSetErrorDetailList()
        {
            return this._errorDetailList != null && (this._errorDetailList.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property RevenueAttributionLatestRevision. 
        /// <para>
        /// The revision number assigned to this batch. Only present when COMPLETE.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=19)]
        public string RevenueAttributionLatestRevision
        {
            get { return this._revenueAttributionLatestRevision; }
            set { this._revenueAttributionLatestRevision = value; }
        }

        // Check to see if RevenueAttributionLatestRevision property is set
        internal bool IsSetRevenueAttributionLatestRevision()
        {
            return this._revenueAttributionLatestRevision != null;
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
        /// Current task status.
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
        /// The unique identifier for the asynchronous task.
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