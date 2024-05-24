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
    /// A summary report of actual Amazon Web Services charges and calculated Amazon Web Services
    /// charges, based on the associated pricing plan of a billing group.
    /// </summary>
    public partial class BillingGroupCostReportElement
    {
        private string _arn;
        private string _awsCost;
        private string _currency;
        private string _margin;
        private string _marginPercentage;
        private string _proformaCost;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a billing group.
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
        /// The percentage of billing group margin.
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