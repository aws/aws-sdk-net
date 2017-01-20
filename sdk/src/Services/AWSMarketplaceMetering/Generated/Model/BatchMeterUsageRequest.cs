/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSMarketplaceMetering.Model
{
    /// <summary>
    /// Container for the parameters to the BatchMeterUsage operation.
    /// 
    /// </summary>
    public partial class BatchMeterUsageRequest : AmazonAWSMarketplaceMeteringRequest
    {
        private string _productCode;
        private List<UsageRecord> _usageRecords = new List<UsageRecord>();

        /// <summary>
        /// Gets and sets the property ProductCode.
        /// </summary>
        public string ProductCode
        {
            get { return this._productCode; }
            set { this._productCode = value; }
        }

        // Check to see if ProductCode property is set
        internal bool IsSetProductCode()
        {
            return this._productCode != null;
        }

        /// <summary>
        /// Gets and sets the property UsageRecords.
        /// </summary>
        public List<UsageRecord> UsageRecords
        {
            get { return this._usageRecords; }
            set { this._usageRecords = value; }
        }

        // Check to see if UsageRecords property is set
        internal bool IsSetUsageRecords()
        {
            return this._usageRecords != null && this._usageRecords.Count > 0; 
        }

    }
}