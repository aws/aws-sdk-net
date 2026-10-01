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
    /// A phone number used for Amazon Chime Business Calling or an Amazon Chime Voice Connector.
    /// </summary>
    public partial class PhoneNumber
    {
        /// <summary>
        /// Gets and sets the property Associations. 
        /// <para>
        /// The phone number associations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PhoneNumberAssociation> Associations { get; set; } = AWSConfigs.InitializeCollections ? new List<PhoneNumberAssociation>() : null;

        /// <summary>
        /// Checks to see if the Associations property is set.
        /// </summary>
        internal bool IsSetAssociations() => this.Associations != null && (this.Associations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CallingName. 
        /// <para>
        /// The outbound calling name associated with the phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string CallingName { get; set; }

        /// <summary>
        /// Checks to see if the CallingName property is set.
        /// </summary>
        internal bool IsSetCallingName() => this.CallingName != null;

        /// <summary>
        /// Gets and sets the property CallingNameStatus. 
        /// <para>
        /// The outbound calling name status.
        /// </para>
        /// </summary>
        public CallingNameStatus CallingNameStatus { get; set; }

        /// <summary>
        /// Checks to see if the CallingNameStatus property is set.
        /// </summary>
        internal bool IsSetCallingNameStatus() => this.CallingNameStatus != null;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The phone number capabilities.
        /// </para>
        /// </summary>
        public PhoneNumberCapabilities Capabilities { get; set; }

        /// <summary>
        /// Checks to see if the Capabilities property is set.
        /// </summary>
        internal bool IsSetCapabilities() => this.Capabilities != null;

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The phone number country. Format: ISO 3166-1 alpha-2.
        /// </para>
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The phone number creation timestamp, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property DeletionTimestamp. 
        /// <para>
        /// The deleted phone number timestamp, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? DeletionTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the DeletionTimestamp property is set.
        /// </summary>
        internal bool IsSetDeletionTimestamp() => this.DeletionTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property E164PhoneNumber. 
        /// <para>
        /// The phone number, in E.164 format.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string E164PhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the E164PhoneNumber property is set.
        /// </summary>
        internal bool IsSetE164PhoneNumber() => this.E164PhoneNumber != null;

        /// <summary>
        /// Gets and sets the property PhoneNumberId. 
        /// <para>
        /// The phone number ID.
        /// </para>
        /// </summary>
        public string PhoneNumberId { get; set; }

        /// <summary>
        /// Checks to see if the PhoneNumberId property is set.
        /// </summary>
        internal bool IsSetPhoneNumberId() => this.PhoneNumberId != null;

        /// <summary>
        /// Gets and sets the property ProductType. 
        /// <para>
        /// The phone number product type.
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
        /// The phone number status.
        /// </para>
        /// </summary>
        public PhoneNumberStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The phone number type.
        /// </para>
        /// </summary>
        public PhoneNumberType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        /// The updated phone number timestamp, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? UpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetUpdatedTimestamp() => this.UpdatedTimestamp.HasValue;
    }
}
