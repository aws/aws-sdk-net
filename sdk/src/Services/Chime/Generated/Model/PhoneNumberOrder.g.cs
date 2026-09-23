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

namespace Amazon.Chime.Model
{
    /// <summary>
    /// The details of a phone number order created for Amazon Chime.
    /// </summary>
    public partial class PhoneNumberOrder
    {
        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The phone number order creation time stamp, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property OrderedPhoneNumbers. 
        /// <para>
        /// The ordered phone number details, such as the phone number in E.164 format and the
        /// phone number status.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OrderedPhoneNumber> OrderedPhoneNumbers { get; set; } = AWSConfigs.InitializeCollections ? new List<OrderedPhoneNumber>() : null;

        /// <summary>
        /// Checks to see if the OrderedPhoneNumbers property is set.
        /// </summary>
        internal bool IsSetOrderedPhoneNumbers() => this.OrderedPhoneNumbers != null && (this.OrderedPhoneNumbers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PhoneNumberOrderId. 
        /// <para>
        /// The phone number order ID.
        /// </para>
        /// </summary>
        public string PhoneNumberOrderId { get; set; }

        /// <summary>
        /// Checks to see if the PhoneNumberOrderId property is set.
        /// </summary>
        internal bool IsSetPhoneNumberOrderId() => this.PhoneNumberOrderId != null;

        /// <summary>
        /// Gets and sets the property ProductType. 
        /// <para>
        /// The phone number order product type.
        /// </para>
        /// </summary>
        public PhoneNumberProductType ProductType { get; set; }

        /// <summary>
        /// Checks to see if the ProductType property is set.
        /// </summary>
        internal bool IsSetProductType() => this.ProductType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the phone number order.
        /// </para>
        /// </summary>
        public PhoneNumberOrderStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        /// The updated phone number order time stamp, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? UpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetUpdatedTimestamp() => this.UpdatedTimestamp.HasValue;
    }
}
