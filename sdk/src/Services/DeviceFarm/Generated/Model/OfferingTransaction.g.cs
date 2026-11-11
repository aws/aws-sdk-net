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

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Represents the metadata of an offering transaction.
    /// </summary>
    public partial class OfferingTransaction
    {
        /// <summary>
        /// Gets and sets the property Cost. 
        /// <para>
        /// The cost of an offering transaction.
        /// </para>
        /// </summary>
        public MonetaryAmount Cost { get; set; }

        /// <summary>
        /// Checks to see if the Cost property is set.
        /// </summary>
        internal bool IsSetCost() => this.Cost != null;

        /// <summary>
        /// Gets and sets the property CreatedOn. 
        /// <para>
        /// The date on which an offering transaction was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Checks to see if the CreatedOn property is set.
        /// </summary>
        internal bool IsSetCreatedOn() => this.CreatedOn.HasValue;

        /// <summary>
        /// Gets and sets the property OfferingPromotionId. 
        /// <para>
        /// The ID that corresponds to a device offering promotion.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4)]
        public string OfferingPromotionId { get; set; }

        /// <summary>
        /// Checks to see if the OfferingPromotionId property is set.
        /// </summary>
        internal bool IsSetOfferingPromotionId() => this.OfferingPromotionId != null;

        /// <summary>
        /// Gets and sets the property OfferingStatus. 
        /// <para>
        /// The status of an offering transaction.
        /// </para>
        /// </summary>
        public OfferingStatus OfferingStatus { get; set; }

        /// <summary>
        /// Checks to see if the OfferingStatus property is set.
        /// </summary>
        internal bool IsSetOfferingStatus() => this.OfferingStatus != null;

        /// <summary>
        /// Gets and sets the property TransactionId. 
        /// <para>
        /// The transaction ID of the offering transaction.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Checks to see if the TransactionId property is set.
        /// </summary>
        internal bool IsSetTransactionId() => this.TransactionId != null;
    }
}
