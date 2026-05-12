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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// The capacity utilization for a specific quota share, including the quota share name
    /// and its current usage.
    /// </summary>
    public partial class QuotaShareCapacityUtilization
    {
        private List<QuotaShareCapacityUsage> _capacityUsage = AWSConfigs.InitializeCollections ? new List<QuotaShareCapacityUsage>() : null;
        private string _quotaShareName;

        /// <summary>
        /// Gets and sets the property CapacityUsage. 
        /// <para>
        /// The capacity usage information for this quota share, including the units of compute
        /// capacity and quantity being used.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<QuotaShareCapacityUsage> CapacityUsage
        {
            get { return this._capacityUsage; }
            set { this._capacityUsage = value; }
        }

        // Check to see if CapacityUsage property is set
        internal bool IsSetCapacityUsage()
        {
            return this._capacityUsage != null && (this._capacityUsage.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QuotaShareName. 
        /// <para>
        /// The name of the quota share.
        /// </para>
        /// </summary>
        public string QuotaShareName
        {
            get { return this._quotaShareName; }
            set { this._quotaShareName = value; }
        }

        // Check to see if QuotaShareName property is set
        internal bool IsSetQuotaShareName()
        {
            return this._quotaShareName != null;
        }

    }
}