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

namespace Amazon.EndUserMessaging.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRegistrationsFromBrandProfile operation.
    /// Repushes the attributes of a brand profile into existing DRAFT registrations. This
    /// operation runs asynchronously. Use the GetJob operation to track its progress.
    /// </summary>
    public partial class UpdateRegistrationsFromBrandProfileRequest : AmazonEndUserMessagingRequest
    {
        /// <summary>
        /// Gets and sets the property BrandProfileId. 
        /// <para>
        /// The unique identifier of the brand profile. You can specify either the bare ID or
        /// the full Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string BrandProfileId { get; set; }

        /// <summary>
        /// Checks to see if the BrandProfileId property is set.
        /// </summary>
        internal bool IsSetBrandProfileId() => this.BrandProfileId != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If you do not specify a client token, the AWS SDK automatically generates
        /// one.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property OnAttributeConflict. 
        /// <para>
        /// Specifies how the service resolves an attribute that already exists. REPLACE overwrites
        /// the existing value with the incoming value. PRESERVE keeps the existing value.
        /// </para>
        /// </summary>
        public OnAttributeConflict OnAttributeConflict { get; set; }

        /// <summary>
        /// Checks to see if the OnAttributeConflict property is set.
        /// </summary>
        internal bool IsSetOnAttributeConflict() => this.OnAttributeConflict != null;

        /// <summary>
        /// Gets and sets the property RegistrationIds. 
        /// <para>
        /// The identifiers of the registrations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<string> RegistrationIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RegistrationIds property is set.
        /// </summary>
        internal bool IsSetRegistrationIds() => this.RegistrationIds != null && (this.RegistrationIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SmartMatch. 
        /// <para>
        /// Specifies whether to use semantic field mapping between brand profile attributes and
        /// registration fields. The default is true. When false, the service maps fields using
        /// a fixed set of standard field types.
        /// </para>
        /// </summary>
        public bool? SmartMatch { get; set; }

        /// <summary>
        /// Checks to see if the SmartMatch property is set.
        /// </summary>
        internal bool IsSetSmartMatch() => this.SmartMatch.HasValue;
    }
}
