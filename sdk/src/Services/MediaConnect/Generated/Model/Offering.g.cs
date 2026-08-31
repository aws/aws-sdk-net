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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        ///  The type of currency that is used for billing. The currencyCode used for all reservations
        /// is US dollars.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Checks to see if the CurrencyCode property is set.
        /// </summary>
        internal bool IsSetCurrencyCode() => this.CurrencyCode != null;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        ///  The length of time that your reservation would be active.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property DurationUnits. 
        /// <para>
        ///  The unit of measurement for the duration of the offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DurationUnits DurationUnits { get; set; }

        /// <summary>
        /// Checks to see if the DurationUnits property is set.
        /// </summary>
        internal bool IsSetDurationUnits() => this.DurationUnits != null;

        /// <summary>
        /// Gets and sets the property OfferingArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) that MediaConnect assigns to the offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OfferingArn { get; set; }

        /// <summary>
        /// Checks to see if the OfferingArn property is set.
        /// </summary>
        internal bool IsSetOfferingArn() => this.OfferingArn != null;

        /// <summary>
        /// Gets and sets the property OfferingDescription. 
        /// <para>
        ///  A description of the offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OfferingDescription { get; set; }

        /// <summary>
        /// Checks to see if the OfferingDescription property is set.
        /// </summary>
        internal bool IsSetOfferingDescription() => this.OfferingDescription != null;

        /// <summary>
        /// Gets and sets the property PricePerUnit. 
        /// <para>
        ///  The cost of a single unit. This value, in combination with priceUnits, makes up the
        /// rate.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PricePerUnit { get; set; }

        /// <summary>
        /// Checks to see if the PricePerUnit property is set.
        /// </summary>
        internal bool IsSetPricePerUnit() => this.PricePerUnit != null;

        /// <summary>
        /// Gets and sets the property PriceUnits. 
        /// <para>
        ///  The unit of measurement that is used for billing. This value, in combination with
        /// pricePerUnit, makes up the rate.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PriceUnits PriceUnits { get; set; }

        /// <summary>
        /// Checks to see if the PriceUnits property is set.
        /// </summary>
        internal bool IsSetPriceUnits() => this.PriceUnits != null;

        /// <summary>
        /// Gets and sets the property ResourceSpecification. 
        /// <para>
        ///  A definition of the amount of outbound bandwidth that you would be reserving if you
        /// purchase the offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceSpecification ResourceSpecification { get; set; }

        /// <summary>
        /// Checks to see if the ResourceSpecification property is set.
        /// </summary>
        internal bool IsSetResourceSpecification() => this.ResourceSpecification != null;
    }
}
