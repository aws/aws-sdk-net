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
    /// A <c>UsageRecordResult</c> indicates the status of a given <c>UsageRecord</c> processed
    /// by <c>BatchMeterUsage</c>.
    /// </summary>
    public partial class UsageRecordResult
    {
        private string _meteringRecordId;
        private UsageRecordResultStatus _status;
        private UsageRecord _usageRecord;

        /// <summary>
        /// Gets and sets the property MeteringRecordId. 
        /// <para>
        /// The <c>MeteringRecordId</c> is a unique identifier for this metering event.
        /// </para>
        /// </summary>
        public string MeteringRecordId
        {
            get { return this._meteringRecordId; }
            set { this._meteringRecordId = value; }
        }

        // Check to see if MeteringRecordId property is set
        internal bool IsSetMeteringRecordId()
        {
            return this._meteringRecordId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The <c>UsageRecordResult</c> <c>Status</c> indicates the status of an individual <c>UsageRecord</c>
        /// processed by <c>BatchMeterUsage</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Success</i>- The <c>UsageRecord</c> was accepted and honored by <c>BatchMeterUsage</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>CustomerNotSubscribed</i>- The <c>CustomerIdentifier</c> specified is not able
        /// to use your product. The <c>UsageRecord</c> was not honored. There are three causes
        /// for this result:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The customer identifier is invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The customer identifier provided in the metering record does not have an active agreement
        /// or subscription with this product. Future <c>UsageRecords</c> for this customer will
        /// fail until the customer subscribes to your product.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The customer's Amazon Web Services account was suspended.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <i>DuplicateRecord</i>- Indicates that the <c>UsageRecord</c> was invalid and not
        /// honored. A previously metered <c>UsageRecord</c> had the same customer, dimension,
        /// and time, but a different quantity.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public UsageRecordResultStatus Status
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
        /// Gets and sets the property UsageRecord. 
        /// <para>
        /// The <c>UsageRecord</c> that was part of the <c>BatchMeterUsage</c> request.
        /// </para>
        /// </summary>
        public UsageRecord UsageRecord
        {
            get { return this._usageRecord; }
            set { this._usageRecord = value; }
        }

        // Check to see if UsageRecord property is set
        internal bool IsSetUsageRecord()
        {
            return this._usageRecord != null;
        }

    }
}