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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
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
namespace Amazon.Billing.Model
{
    /// <summary>
    /// Service-level usage details by account.
    /// </summary>
    public partial class ServiceLevelAccountUsage
    {
        private string _serviceCode;
        private string _totalSupportEligibleSpend;

        /// <summary>
        /// Gets and sets the property ServiceCode. 
        /// <para>
        /// The service code for which to return Support-eligible spend data.
        /// </para>
        /// </summary>
        public string ServiceCode
        {
            get { return this._serviceCode; }
            set { this._serviceCode = value; }
        }

        // Check to see if ServiceCode property is set
        internal bool IsSetServiceCode()
        {
            return this._serviceCode != null;
        }

        /// <summary>
        /// Gets and sets the property TotalSupportEligibleSpend. 
        /// <para>
        /// The total support-eligible spend for the service.
        /// </para>
        /// </summary>
        public string TotalSupportEligibleSpend
        {
            get { return this._totalSupportEligibleSpend; }
            set { this._totalSupportEligibleSpend = value; }
        }

        // Check to see if TotalSupportEligibleSpend property is set
        internal bool IsSetTotalSupportEligibleSpend()
        {
            return this._totalSupportEligibleSpend != null;
        }

    }
}