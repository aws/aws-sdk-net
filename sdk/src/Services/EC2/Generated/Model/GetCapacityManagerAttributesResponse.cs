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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the GetCapacityManagerAttributes operation.
    /// </summary>
    public partial class GetCapacityManagerAttributesResponse : AmazonWebServiceResponse
    {
        private CapacityManagerStatus _capacityManagerStatus;
        private int? _dataExportCount;
        private DateTime? _earliestDatapointTimestamp;
        private IngestionStatus _ingestionStatus;
        private string _ingestionStatusMessage;
        private DateTime? _latestDatapointTimestamp;
        private bool? _organizationsAccess;

        /// <summary>
        /// Gets and sets the property CapacityManagerStatus. 
        /// <para>
        ///  The current status of Capacity Manager. 
        /// </para>
        /// </summary>
        public CapacityManagerStatus CapacityManagerStatus
        {
            get { return this._capacityManagerStatus; }
            set { this._capacityManagerStatus = value; }
        }

        // Check to see if CapacityManagerStatus property is set
        internal bool IsSetCapacityManagerStatus()
        {
            return this._capacityManagerStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DataExportCount. 
        /// <para>
        ///  The number of active data export configurations for this account. This count includes
        /// all data exports regardless of their current delivery status. 
        /// </para>
        /// </summary>
        public int DataExportCount
        {
            get { return this._dataExportCount.GetValueOrDefault(); }
            set { this._dataExportCount = value; }
        }

        // Check to see if DataExportCount property is set
        internal bool IsSetDataExportCount()
        {
            return this._dataExportCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EarliestDatapointTimestamp. 
        /// <para>
        ///  The timestamp of the earliest data point available in Capacity Manager, in milliseconds
        /// since epoch. This indicates how far back historical data is available for queries.
        /// 
        /// </para>
        /// </summary>
        public DateTime EarliestDatapointTimestamp
        {
            get { return this._earliestDatapointTimestamp.GetValueOrDefault(); }
            set { this._earliestDatapointTimestamp = value; }
        }

        // Check to see if EarliestDatapointTimestamp property is set
        internal bool IsSetEarliestDatapointTimestamp()
        {
            return this._earliestDatapointTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IngestionStatus. 
        /// <para>
        ///  The current data ingestion status. Initial ingestion may take several hours after
        /// enabling Capacity Manager. 
        /// </para>
        /// </summary>
        public IngestionStatus IngestionStatus
        {
            get { return this._ingestionStatus; }
            set { this._ingestionStatus = value; }
        }

        // Check to see if IngestionStatus property is set
        internal bool IsSetIngestionStatus()
        {
            return this._ingestionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property IngestionStatusMessage. 
        /// <para>
        ///  A descriptive message providing additional details about the current ingestion status.
        /// This may include error information if ingestion has failed or progress details during
        /// initial setup. 
        /// </para>
        /// </summary>
        public string IngestionStatusMessage
        {
            get { return this._ingestionStatusMessage; }
            set { this._ingestionStatusMessage = value; }
        }

        // Check to see if IngestionStatusMessage property is set
        internal bool IsSetIngestionStatusMessage()
        {
            return this._ingestionStatusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property LatestDatapointTimestamp. 
        /// <para>
        ///  The timestamp of the most recent data point ingested by Capacity Manager, in milliseconds
        /// since epoch. This indicates how current your capacity data is. 
        /// </para>
        /// </summary>
        public DateTime LatestDatapointTimestamp
        {
            get { return this._latestDatapointTimestamp.GetValueOrDefault(); }
            set { this._latestDatapointTimestamp = value; }
        }

        // Check to see if LatestDatapointTimestamp property is set
        internal bool IsSetLatestDatapointTimestamp()
        {
            return this._latestDatapointTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationsAccess. 
        /// <para>
        ///  Indicates whether Organizations access is enabled for cross-account data aggregation.
        /// 
        /// </para>
        /// </summary>
        public bool OrganizationsAccess
        {
            get { return this._organizationsAccess.GetValueOrDefault(); }
            set { this._organizationsAccess = value; }
        }

        // Check to see if OrganizationsAccess property is set
        internal bool IsSetOrganizationsAccess()
        {
            return this._organizationsAccess.HasValue; 
        }

    }
}