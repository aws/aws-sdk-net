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

namespace Amazon.B2bi.Model
{
    /// <summary>
    /// This is the response object from the UpdatePartnership operation.
    /// </summary>
    public partial class UpdatePartnershipResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// Returns one or more capabilities associated with this partnership.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Capabilities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Capabilities property is set.
        /// </summary>
        internal bool IsSetCapabilities() => this.Capabilities != null && (this.Capabilities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CapabilityOptions. 
        /// <para>
        /// Returns the structure that contains the details for the associated capabilities.
        /// </para>
        /// </summary>
        public CapabilityOptions CapabilityOptions { get; set; }

        /// <summary>
        /// Checks to see if the CapabilityOptions property is set.
        /// </summary>
        internal bool IsSetCapabilityOptions() => this.CapabilityOptions != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Returns a timestamp that identifies the most recent date and time that the partnership
        /// was modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// Returns the email address associated with this trading partner.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 5, Max = 254)]
        public string Email { get; set; }

        /// <summary>
        /// Checks to see if the Email property is set.
        /// </summary>
        internal bool IsSetEmail() => this.Email != null;

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// Returns a timestamp that identifies the most recent date and time that the partnership
        /// was modified.
        /// </para>
        /// </summary>
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedAt property is set.
        /// </summary>
        internal bool IsSetModifiedAt() => this.ModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the partnership, used to identify it.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 254)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PartnershipArn. 
        /// <para>
        /// Returns an Amazon Resource Name (ARN) for a specific Amazon Web Services resource,
        /// such as a capability, partnership, profile, or transformer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string PartnershipArn { get; set; }

        /// <summary>
        /// Checks to see if the PartnershipArn property is set.
        /// </summary>
        internal bool IsSetPartnershipArn() => this.PartnershipArn != null;

        /// <summary>
        /// Gets and sets the property PartnershipId. 
        /// <para>
        /// Returns the unique, system-generated identifier for a partnership.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string PartnershipId { get; set; }

        /// <summary>
        /// Checks to see if the PartnershipId property is set.
        /// </summary>
        internal bool IsSetPartnershipId() => this.PartnershipId != null;

        /// <summary>
        /// Gets and sets the property Phone. 
        /// <para>
        /// Returns the phone number associated with the partnership.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 7, Max = 22)]
        public string Phone { get; set; }

        /// <summary>
        /// Checks to see if the Phone property is set.
        /// </summary>
        internal bool IsSetPhone() => this.Phone != null;

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// Returns the unique, system-generated identifier for the profile connected to this
        /// partnership.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Checks to see if the ProfileId property is set.
        /// </summary>
        internal bool IsSetProfileId() => this.ProfileId != null;

        /// <summary>
        /// Gets and sets the property TradingPartnerId. 
        /// <para>
        /// Returns the unique, system-generated identifier for a trading partner.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string TradingPartnerId { get; set; }

        /// <summary>
        /// Checks to see if the TradingPartnerId property is set.
        /// </summary>
        internal bool IsSetTradingPartnerId() => this.TradingPartnerId != null;
    }
}
