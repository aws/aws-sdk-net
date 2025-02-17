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
 * Do not modify this file. This file is generated from the bcm-pricing-calculator-2024-06-19.normal.json service model.
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
namespace Amazon.BCMPricingCalculator.Model
{
    /// <summary>
    /// This is the response object from the BatchUpdateBillScenarioUsageModification operation.
    /// </summary>
    public partial class BatchUpdateBillScenarioUsageModificationResponse : AmazonWebServiceResponse
    {
        private List<BatchUpdateBillScenarioUsageModificationError> _errors = AWSConfigs.InitializeCollections ? new List<BatchUpdateBillScenarioUsageModificationError>() : null;
        private List<BillScenarioUsageModificationItem> _items = AWSConfigs.InitializeCollections ? new List<BillScenarioUsageModificationItem>() : null;

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        ///  Returns the list of error reasons and usage line item IDs that could not be updated
        /// for the Bill Scenario. 
        /// </para>
        /// </summary>
        public List<BatchUpdateBillScenarioUsageModificationError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        ///  Returns the list of successful usage line items that were updated for a Bill Scenario.
        /// 
        /// </para>
        /// </summary>
        public List<BillScenarioUsageModificationItem> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && (this._items.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}