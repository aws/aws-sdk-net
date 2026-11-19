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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the GetCapacityManagerAttributes operation.
    /// </summary>
    public partial class GetCapacityManagerAttributesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CapacityManagerStatus. 
        /// <para>
        ///  The current status of Capacity Manager. 
        /// </para>
        /// </summary>
        public CapacityManagerStatus CapacityManagerStatus { get; set; }

        /// <summary>
        /// Checks to see if the CapacityManagerStatus property is set.
        /// </summary>
        internal bool IsSetCapacityManagerStatus() => this.CapacityManagerStatus != null;

        /// <summary>
        /// Gets and sets the property DataExportCount. 
        /// <para>
        ///  The number of active data export configurations for this account. This count includes
        /// all data exports regardless of their current delivery status. 
        /// </para>
        /// </summary>
        public int? DataExportCount { get; set; }

        /// <summary>
        /// Checks to see if the DataExportCount property is set.
        /// </summary>
        internal bool IsSetDataExportCount() => this.DataExportCount.HasValue;

        /// <summary>
        /// Gets and sets the property EarliestDatapointTimestamp. 
        /// <para>
        ///  The timestamp of the earliest data point available in Capacity Manager, in milliseconds
        /// since epoch. This indicates how far back historical data is available for queries.
        /// 
        /// </para>
        /// </summary>
        public DateTime? EarliestDatapointTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the EarliestDatapointTimestamp property is set.
        /// </summary>
        internal bool IsSetEarliestDatapointTimestamp() => this.EarliestDatapointTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property IngestionStatus. 
        /// <para>
        ///  The current data ingestion status. Initial ingestion may take several hours after
        /// enabling Capacity Manager. 
        /// </para>
        /// </summary>
        public IngestionStatus IngestionStatus { get; set; }

        /// <summary>
        /// Checks to see if the IngestionStatus property is set.
        /// </summary>
        internal bool IsSetIngestionStatus() => this.IngestionStatus != null;

        /// <summary>
        /// Gets and sets the property IngestionStatusMessage. 
        /// <para>
        ///  A descriptive message providing additional details about the current ingestion status.
        /// This may include error information if ingestion has failed or progress details during
        /// initial setup. 
        /// </para>
        /// </summary>
        public string IngestionStatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the IngestionStatusMessage property is set.
        /// </summary>
        internal bool IsSetIngestionStatusMessage() => this.IngestionStatusMessage != null;

        /// <summary>
        /// Gets and sets the property LatestDatapointTimestamp. 
        /// <para>
        ///  The timestamp of the most recent data point ingested by Capacity Manager, in milliseconds
        /// since epoch. This indicates how current your capacity data is. 
        /// </para>
        /// </summary>
        public DateTime? LatestDatapointTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LatestDatapointTimestamp property is set.
        /// </summary>
        internal bool IsSetLatestDatapointTimestamp() => this.LatestDatapointTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property OrganizationsAccess. 
        /// <para>
        ///  Indicates whether Organizations access is enabled for cross-account data aggregation.
        /// 
        /// </para>
        /// </summary>
        public bool? OrganizationsAccess { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationsAccess property is set.
        /// </summary>
        internal bool IsSetOrganizationsAccess() => this.OrganizationsAccess.HasValue;
    }
}
