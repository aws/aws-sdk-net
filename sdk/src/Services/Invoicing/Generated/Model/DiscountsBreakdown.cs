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
 * Do not modify this file. This file is generated from the invoicing-2024-12-01.normal.json service model.
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
namespace Amazon.Invoicing.Model
{
    /// <summary>
    /// The discounts details.
    /// </summary>
    public partial class DiscountsBreakdown
    {
        private List<DiscountsBreakdownAmount> _breakdown = AWSConfigs.InitializeCollections ? new List<DiscountsBreakdownAmount>() : null;
        private string _totalAmount;

        /// <summary>
        /// Gets and sets the property Breakdown. 
        /// <para>
        /// The list of discounts information. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DiscountsBreakdownAmount> Breakdown
        {
            get { return this._breakdown; }
            set { this._breakdown = value; }
        }

        // Check to see if Breakdown property is set
        internal bool IsSetBreakdown()
        {
            return this._breakdown != null && (this._breakdown.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalAmount. 
        /// <para>
        ///  The discount's total amount. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string TotalAmount
        {
            get { return this._totalAmount; }
            set { this._totalAmount = value; }
        }

        // Check to see if TotalAmount property is set
        internal bool IsSetTotalAmount()
        {
            return this._totalAmount != null;
        }

    }
}