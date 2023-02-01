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

namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// A representation of a custom line item.
    /// </summary>
    public partial class CustomLineItemListElement
    {
        private string _arn;
        private long? _associationSize;
        private string _billingGroupArn;
        private ListCustomLineItemChargeDetails _chargeDetails;
        private long? _creationTime;
        private CurrencyCode _currencyCode;
        private string _description;
        private long? _lastModifiedTime;
        private string _name;
        private string _productCode;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The Amazon Resource Names (ARNs) for custom line items. 
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
        /// Gets and sets the property AssociationSize. 
        /// <para>
        ///  The number of resources that are associated to the custom line item. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long AssociationSize
        {
            get { return this._associationSize.GetValueOrDefault(); }
            set { this._associationSize = value; }
        }

        // Check to see if AssociationSize property is set
        internal bool IsSetAssociationSize()
        {
            return this._associationSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BillingGroupArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) that references the billing group where the custom
        /// line item applies to. 
        /// </para>
        /// </summary>
        public string BillingGroupArn
        {
            get { return this._billingGroupArn; }
            set { this._billingGroupArn = value; }
        }

        // Check to see if BillingGroupArn property is set
        internal bool IsSetBillingGroupArn()
        {
            return this._billingGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property ChargeDetails. 
        /// <para>
        ///  A <code>ListCustomLineItemChargeDetails</code> that describes the charge details
        /// of a custom line item. 
        /// </para>
        /// </summary>
        public ListCustomLineItemChargeDetails ChargeDetails
        {
            get { return this._chargeDetails; }
            set { this._chargeDetails = value; }
        }

        // Check to see if ChargeDetails property is set
        internal bool IsSetChargeDetails()
        {
            return this._chargeDetails != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        ///  The time created. 
        /// </para>
        /// </summary>
        public long CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        ///  The custom line item's charge value currency. Only one of the valid values can be
        /// used. 
        /// </para>
        /// </summary>
        public CurrencyCode CurrencyCode
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
        /// Gets and sets the property Description. 
        /// <para>
        ///  The custom line item's description. This is shown on the Bills page in association
        /// with the charge value. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=255)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        ///  The most recent time when the custom line item was modified. 
        /// </para>
        /// </summary>
        public long LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The custom line item's name. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ProductCode. 
        /// <para>
        ///  The product code that's associated with the custom line item. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=29)]
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

    }
}