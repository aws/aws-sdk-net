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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// A savings plan that reserves a certain amount of outbound bandwidth usage at a discounted
    /// rate each month over a period of time.
    /// </summary>
    public partial class Offering
    {
        private string _currencyCode;
        private int? _duration;
        private DurationUnits _durationUnits;
        private string _offeringArn;
        private string _offeringDescription;
        private string _pricePerUnit;
        private PriceUnits _priceUnits;
        private ResourceSpecification _resourceSpecification;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        ///  The type of currency that is used for billing. The currencyCode used for all reservations
        /// is US dollars.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CurrencyCode
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
        /// Gets and sets the property Duration. 
        /// <para>
        ///  The length of time that your reservation would be active.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DurationUnits. 
        /// <para>
        ///  The unit of measurement for the duration of the offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DurationUnits DurationUnits
        {
            get { return this._durationUnits; }
            set { this._durationUnits = value; }
        }

        // Check to see if DurationUnits property is set
        internal bool IsSetDurationUnits()
        {
            return this._durationUnits != null;
        }

        /// <summary>
        /// Gets and sets the property OfferingArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) that MediaConnect assigns to the offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OfferingArn
        {
            get { return this._offeringArn; }
            set { this._offeringArn = value; }
        }

        // Check to see if OfferingArn property is set
        internal bool IsSetOfferingArn()
        {
            return this._offeringArn != null;
        }

        /// <summary>
        /// Gets and sets the property OfferingDescription. 
        /// <para>
        ///  A description of the offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OfferingDescription
        {
            get { return this._offeringDescription; }
            set { this._offeringDescription = value; }
        }

        // Check to see if OfferingDescription property is set
        internal bool IsSetOfferingDescription()
        {
            return this._offeringDescription != null;
        }

        /// <summary>
        /// Gets and sets the property PricePerUnit. 
        /// <para>
        ///  The cost of a single unit. This value, in combination with priceUnits, makes up the
        /// rate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PricePerUnit
        {
            get { return this._pricePerUnit; }
            set { this._pricePerUnit = value; }
        }

        // Check to see if PricePerUnit property is set
        internal bool IsSetPricePerUnit()
        {
            return this._pricePerUnit != null;
        }

        /// <summary>
        /// Gets and sets the property PriceUnits. 
        /// <para>
        ///  The unit of measurement that is used for billing. This value, in combination with
        /// pricePerUnit, makes up the rate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PriceUnits PriceUnits
        {
            get { return this._priceUnits; }
            set { this._priceUnits = value; }
        }

        // Check to see if PriceUnits property is set
        internal bool IsSetPriceUnits()
        {
            return this._priceUnits != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceSpecification. 
        /// <para>
        ///  A definition of the amount of outbound bandwidth that you would be reserving if you
        /// purchase the offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceSpecification ResourceSpecification
        {
            get { return this._resourceSpecification; }
            set { this._resourceSpecification = value; }
        }

        // Check to see if ResourceSpecification property is set
        internal bool IsSetResourceSpecification()
        {
            return this._resourceSpecification != null;
        }

    }
}