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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// This is the response object from the GetHostReservationPurchasePreview operation.
    /// </summary>
    public partial class GetHostReservationPurchasePreviewResponse : AmazonWebServiceResponse
    {
        private CurrencyCodeValues _currencyCode;
        private List<Purchase> _purchase = AWSConfigs.InitializeCollections ? new List<Purchase>() : null;
        private string _totalHourlyPrice;
        private string _totalUpfrontPrice;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency in which the <c>totalUpfrontPrice</c> and <c>totalHourlyPrice</c> amounts
        /// are specified. At this time, the only supported currency is <c>USD</c>.
        /// </para>
        /// </summary>
        public CurrencyCodeValues CurrencyCode
        {
            get { return this._currencyCode; }
            set { this._currencyCode = value; }
        }

        // Check to see if CurrencyCode property is set
        internal bool IsSetCurrencyCode()
        {
            return this._currencyCode != null;
        }

        /// <summary>
        /// Gets and sets the property Purchase. 
        /// <para>
        /// The purchase information of the Dedicated Host reservation and the Dedicated Hosts
        /// associated with it.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Purchase> Purchase
        {
            get { return this._purchase; }
            set { this._purchase = value; }
        }

        // Check to see if Purchase property is set
        internal bool IsSetPurchase()
        {
            return this._purchase != null && (this._purchase.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalHourlyPrice. 
        /// <para>
        /// The potential total hourly price of the reservation per hour.
        /// </para>
        /// </summary>
        public string TotalHourlyPrice
        {
            get { return this._totalHourlyPrice; }
            set { this._totalHourlyPrice = value; }
        }

        // Check to see if TotalHourlyPrice property is set
        internal bool IsSetTotalHourlyPrice()
        {
            return this._totalHourlyPrice != null;
        }

        /// <summary>
        /// Gets and sets the property TotalUpfrontPrice. 
        /// <para>
        /// The potential total upfront price. This is billed immediately.
        /// </para>
        /// </summary>
        public string TotalUpfrontPrice
        {
            get { return this._totalUpfrontPrice; }
            set { this._totalUpfrontPrice = value; }
        }

        // Check to see if TotalUpfrontPrice property is set
        internal bool IsSetTotalUpfrontPrice()
        {
            return this._totalUpfrontPrice != null;
        }

    }
}