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

namespace Amazon.AWSMarketplaceMetering.Model
{
    /// <summary>
    /// Contains the <code>UsageRecords</code> processed by <code>BatchMeterUsage</code> and
    /// any records that have failed due to transient error.
    /// </summary>
    public partial class BatchMeterUsageResponse : AmazonWebServiceResponse
    {
        private List<UsageRecordResult> _results = new List<UsageRecordResult>();
        private List<UsageRecord> _unprocessedRecords = new List<UsageRecord>();

        /// <summary>
        /// Gets and sets the property Results. 
        /// <para>
        /// Contains all <code>UsageRecords</code> processed by <code>BatchMeterUsage</code>.
        /// These records were either honored by AWS Marketplace Metering Service or were invalid.
        /// Invalid records should be fixed before being resubmitted.
        /// </para>
        /// </summary>
        public List<UsageRecordResult> Results
        {
            get { return this._results; }
            set { this._results = value; }
        }

        // Check to see if Results property is set
        internal bool IsSetResults()
        {
            return this._results != null && this._results.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UnprocessedRecords. 
        /// <para>
        /// Contains all <code>UsageRecords</code> that were not processed by <code>BatchMeterUsage</code>.
        /// This is a list of <code>UsageRecords</code>. You can retry the failed request by making
        /// another <code>BatchMeterUsage</code> call with this list as input in the <code>BatchMeterUsageRequest</code>.
        /// </para>
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
            return this._unprocessedRecords != null && this._unprocessedRecords.Count > 0; 
        }

    }
}