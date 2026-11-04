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

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// A list of phone numbers and their metadata.
    /// </summary>
    public partial class PhoneNumberInformation
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the phone number was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Iso2CountryCode. 
        /// <para>
        /// The two-character code for the country or region, in ISO 3166-1 alpha-2 format.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public string Iso2CountryCode { get; set; }

        /// <summary>
        /// Checks to see if the Iso2CountryCode property is set.
        /// </summary>
        internal bool IsSetIso2CountryCode() => this.Iso2CountryCode != null;

        /// <summary>
        /// Gets and sets the property NumberCapabilities. 
        /// <para>
        /// The capabilities of each phone number.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NumberCapabilities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NumberCapabilities property is set.
        /// </summary>
        internal bool IsSetNumberCapabilities() => this.NumberCapabilities != null && (this.NumberCapabilities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the PhoneNumber property is set.
        /// </summary>
        internal bool IsSetPhoneNumber() => this.PhoneNumber != null;

        /// <summary>
        /// Gets and sets the property RouteType. 
        /// <para>
        /// The list of supported routes.
        /// </para>
        /// </summary>
        public RouteType RouteType { get; set; }

        /// <summary>
        /// Checks to see if the RouteType property is set.
        /// </summary>
        internal bool IsSetRouteType() => this.RouteType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the phone number.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
