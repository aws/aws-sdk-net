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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Captures details about the project associated with the opportunity, including objectives,
    /// scope, and customer requirements.
    /// </summary>
    public partial class AwsOpportunityProject
    {
        private List<ExpectedCustomerSpend> _expectedCustomerSpend = AWSConfigs.InitializeCollections ? new List<ExpectedCustomerSpend>() : null;

        /// <summary>
        /// Gets and sets the property ExpectedCustomerSpend. 
        /// <para>
        /// Indicates the expected spending by the customer over the course of the project. This
        /// value helps partners and AWS estimate the financial impact of the opportunity. Use
        /// the <a href="https://calculator.aws/#/">AWS Pricing Calculator</a> to create an estimate
        /// of the customer’s total spend. If only annual recurring revenue (ARR) is available,
        /// distribute it across 12 months to provide an average monthly value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<ExpectedCustomerSpend> ExpectedCustomerSpend
        {
            get { return this._expectedCustomerSpend; }
            set { this._expectedCustomerSpend = value; }
        }

        // Check to see if ExpectedCustomerSpend property is set
        internal bool IsSetExpectedCustomerSpend()
        {
            return this._expectedCustomerSpend != null && (this._expectedCustomerSpend.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}