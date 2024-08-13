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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
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
namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Represents the metadata of an offering transaction.
    /// </summary>
    public partial class OfferingTransaction
    {
        private MonetaryAmount _cost;
        private DateTime? _createdOn;
        private string _offeringPromotionId;
        private OfferingStatus _offeringStatus;
        private string _transactionId;

        /// <summary>
        /// Gets and sets the property Cost. 
        /// <para>
        /// The cost of an offering transaction.
        /// </para>
        /// </summary>
        public MonetaryAmount Cost
        {
            get { return this._cost; }
            set { this._cost = value; }
        }

        // Check to see if Cost property is set
        internal bool IsSetCost()
        {
            return this._cost != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedOn. 
        /// <para>
        /// The date on which an offering transaction was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedOn
        {
            get { return this._createdOn; }
            set { this._createdOn = value; }
        }

        // Check to see if CreatedOn property is set
        internal bool IsSetCreatedOn()
        {
            return this._createdOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OfferingPromotionId. 
        /// <para>
        /// The ID that corresponds to a device offering promotion.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4)]
        public string OfferingPromotionId
        {
            get { return this._offeringPromotionId; }
            set { this._offeringPromotionId = value; }
        }

        // Check to see if OfferingPromotionId property is set
        internal bool IsSetOfferingPromotionId()
        {
            return this._offeringPromotionId != null;
        }

        /// <summary>
        /// Gets and sets the property OfferingStatus. 
        /// <para>
        /// The status of an offering transaction.
        /// </para>
        /// </summary>
        public OfferingStatus OfferingStatus
        {
            get { return this._offeringStatus; }
            set { this._offeringStatus = value; }
        }

        // Check to see if OfferingStatus property is set
        internal bool IsSetOfferingStatus()
        {
            return this._offeringStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TransactionId. 
        /// <para>
        /// The transaction ID of the offering transaction.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32)]
        public string TransactionId
        {
            get { return this._transactionId; }
            set { this._transactionId = value; }
        }

        // Check to see if TransactionId property is set
        internal bool IsSetTransactionId()
        {
            return this._transactionId != null;
        }

    }
}