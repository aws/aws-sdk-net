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
 * Do not modify this file. This file is generated from the billingconductor-2021-07-30.normal.json service model.
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
namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// A paginated call to retrieve a list of summary reports of actual Amazon Web Services
    /// charges and the calculated Amazon Web Services charges, broken down by attributes.
    /// </summary>
    public partial class BillingGroupCostReportResultElement
    {
        private string _arn;
        private List<Attribute> _attributes = AWSConfigs.InitializeCollections ? new List<Attribute>() : null;
        private string _awsCost;
        private string _currency;
        private string _margin;
        private string _marginPercentage;
        private string _proformaCost;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Number (ARN) that uniquely identifies the billing group.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The list of key-value pairs that represent the attributes by which the <c>BillingGroupCostReportResults</c>
        /// are grouped. For example, if you want the Amazon S3 service-level breakdown of a billing
        /// group for November 2023, the attributes list will contain a key-value pair of <c>"PRODUCT_NAME"</c>
        /// and <c>"S3"</c> and a key-value pair of <c>"BILLING_PERIOD"</c> and <c>"Nov 2023"</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Attribute> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AWSCost. 
        /// <para>
        /// The actual Amazon Web Services charges for the billing group.
        /// </para>
        /// </summary>
        public string AWSCost
        {
            get { return this._awsCost; }
            set { this._awsCost = value; }
        }

        // Check to see if AWSCost property is set
        internal bool IsSetAWSCost()
        {
            return this._awsCost != null;
        }

        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        /// The displayed currency.
        /// </para>
        /// </summary>
        public string Currency
        {
            get { return this._currency; }
            set { this._currency = value; }
        }

        // Check to see if Currency property is set
        internal bool IsSetCurrency()
        {
            return this._currency != null;
        }

        /// <summary>
        /// Gets and sets the property Margin. 
        /// <para>
        /// The billing group margin.
        /// </para>
        /// </summary>
        public string Margin
        {
            get { return this._margin; }
            set { this._margin = value; }
        }

        // Check to see if Margin property is set
        internal bool IsSetMargin()
        {
            return this._margin != null;
        }

        /// <summary>
        /// Gets and sets the property MarginPercentage. 
        /// <para>
        /// The percentage of the billing group margin.
        /// </para>
        /// </summary>
        public string MarginPercentage
        {
            get { return this._marginPercentage; }
            set { this._marginPercentage = value; }
        }

        // Check to see if MarginPercentage property is set
        internal bool IsSetMarginPercentage()
        {
            return this._marginPercentage != null;
        }

        /// <summary>
        /// Gets and sets the property ProformaCost. 
        /// <para>
        /// The hypothetical Amazon Web Services charges based on the associated pricing plan
        /// of a billing group.
        /// </para>
        /// </summary>
        public string ProformaCost
        {
            get { return this._proformaCost; }
            set { this._proformaCost = value; }
        }

        // Check to see if ProformaCost property is set
        internal bool IsSetProformaCost()
        {
            return this._proformaCost != null;
        }

    }
}