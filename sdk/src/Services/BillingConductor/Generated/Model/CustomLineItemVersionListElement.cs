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
    /// A representation of a custom line item version.
    /// </summary>
    public partial class CustomLineItemVersionListElement
    {
        private string _arn;
        private long? _associationSize;
        private string _billingGroupArn;
        private ListCustomLineItemChargeDetails _chargeDetails;
        private long? _creationTime;
        private CurrencyCode _currencyCode;
        private string _description;
        private string _endBillingPeriod;
        private long? _lastModifiedTime;
        private string _name;
        private string _productCode;
        private string _startBillingPeriod;
        private long? _startTime;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  A list of custom line item Amazon Resource Names (ARNs) to retrieve information.
        /// 
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
        /// The number of resources that are associated with the custom line item.
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
        /// The Amazon Resource Name (ARN) of the billing group that the custom line item applies
        /// to.
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
        /// The time when the custom line item version was created.
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
        /// The charge value currency of the custom line item.
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
        /// The description of the custom line item.
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
        /// Gets and sets the property EndBillingPeriod. 
        /// <para>
        /// The end billing period of the custom line item version.
        /// </para>
        /// </summary>
        public string EndBillingPeriod
        {
            get { return this._endBillingPeriod; }
            set { this._endBillingPeriod = value; }
        }

        // Check to see if EndBillingPeriod property is set
        internal bool IsSetEndBillingPeriod()
        {
            return this._endBillingPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The most recent time that the custom line item version was modified.
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
        /// The name of the custom line item.
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
        /// The product code that’s associated with the custom line item.
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

        /// <summary>
        /// Gets and sets the property StartBillingPeriod. 
        /// <para>
        /// The start billing period of the custom line item version.
        /// </para>
        /// </summary>
        public string StartBillingPeriod
        {
            get { return this._startBillingPeriod; }
            set { this._startBillingPeriod = value; }
        }

        // Check to see if StartBillingPeriod property is set
        internal bool IsSetStartBillingPeriod()
        {
            return this._startBillingPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  The inclusive start time. 
        /// </para>
        /// </summary>
        public long StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}