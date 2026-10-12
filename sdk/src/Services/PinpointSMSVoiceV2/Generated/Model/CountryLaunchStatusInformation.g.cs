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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Contains per-country launch status details for an RCS agent.
    /// </summary>
    public partial class CountryLaunchStatusInformation
    {
        /// <summary>
        /// Gets and sets the property CarrierStatus. 
        /// <para>
        /// An array of CarrierStatusInformation objects containing carrier-level launch status
        /// details.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<CarrierStatusInformation> CarrierStatus { get; set; } = AWSConfigs.InitializeCollections ? new List<CarrierStatusInformation>() : null;

        /// <summary>
        /// Checks to see if the CarrierStatus property is set.
        /// </summary>
        internal bool IsSetCarrierStatus() => this.CarrierStatus != null && (this.CarrierStatus.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IsoCountryCode. 
        /// <para>
        /// The two-character code, in ISO 3166-1 alpha-2 format, for the country or region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 2)]
        public string IsoCountryCode { get; set; }

        /// <summary>
        /// Checks to see if the IsoCountryCode property is set.
        /// </summary>
        internal bool IsSetIsoCountryCode() => this.IsoCountryCode != null;

        /// <summary>
        /// Gets and sets the property RcsPlatformId. 
        /// <para>
        /// The RCS platform identifier for this country.
        /// </para>
        /// </summary>
        public string RcsPlatformId { get; set; }

        /// <summary>
        /// Checks to see if the RcsPlatformId property is set.
        /// </summary>
        internal bool IsSetRcsPlatformId() => this.RcsPlatformId != null;

        /// <summary>
        /// Gets and sets the property RegistrationId. 
        /// <para>
        /// The unique identifier of the registration associated with this country launch.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RegistrationId { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationId property is set.
        /// </summary>
        internal bool IsSetRegistrationId() => this.RegistrationId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The launch status for this country.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CountryLaunchStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
