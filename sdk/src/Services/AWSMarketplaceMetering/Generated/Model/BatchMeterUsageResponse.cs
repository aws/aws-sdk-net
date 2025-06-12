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
 * Do not modify this file. This file is generated from the meteringmarketplace-2016-01-14.normal.json service model.
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
namespace Amazon.AWSMarketplaceMetering.Model
{
    /// <summary>
    /// Contains the <c>UsageRecords</c> processed by <c>BatchMeterUsage</c> and any records
    /// that have failed due to transient error.
    /// </summary>
    public partial class BatchMeterUsageResponse : AmazonWebServiceResponse
    {
        private List<UsageRecordResult> _results = AWSConfigs.InitializeCollections ? new List<UsageRecordResult>() : null;
        private List<UsageRecord> _unprocessedRecords = AWSConfigs.InitializeCollections ? new List<UsageRecord>() : null;

        /// <summary>
        /// Gets and sets the property Results. 
        /// <para>
        /// Contains all <c>UsageRecords</c> processed by <c>BatchMeterUsage</c>. These records
        /// were either honored by Amazon Web Services Marketplace Metering Service or were invalid.
        /// Invalid records should be fixed before being resubmitted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UsageRecordResult> Results
        {
            get { return this._results; }
            set { this._results = value; }
        }

        // Check to see if Results property is set
        internal bool IsSetResults()
        {
            return this._results != null && (this._results.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UnprocessedRecords. 
        /// <para>
        /// Contains all <c>UsageRecords</c> that were not processed by <c>BatchMeterUsage</c>.
        /// This is a list of <c>UsageRecords</c>. You can retry the failed request by making
        /// another <c>BatchMeterUsage</c> call with this list as input in the <c>BatchMeterUsageRequest</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
        public List<UsageRecord> UnprocessedRecords
        {
            get { return this._unprocessedRecords; }
            set { this._unprocessedRecords = value; }
        }

        // Check to see if UnprocessedRecords property is set
        internal bool IsSetUnprocessedRecords()
        {
            return this._unprocessedRecords != null && (this._unprocessedRecords.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}