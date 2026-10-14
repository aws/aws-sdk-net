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
    /// Container for the parameters to the UpdateBrandProfile operation. Updates the name
    /// or the deletion protection setting of a brand profile. To change the information that
    /// is stored in the profile, use the brand profile attribute operations.
    /// </summary>
    public partial class UpdateBrandProfileRequest : AmazonEndUserMessagingRequest
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
        /// Gets and sets the property BrandProfileName. 
        /// <para>
        /// The name of the brand profile. The name can contain alphanumeric characters, underscores,
        /// hyphens, and spaces.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string BrandProfileName { get; set; }

        /// <summary>
        /// Checks to see if the BrandProfileName property is set.
        /// </summary>
        internal bool IsSetBrandProfileName() => this.BrandProfileName != null;

        /// <summary>
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        /// Specifies whether deletion protection is enabled. When enabled, the resource cannot
        /// be deleted until deletion protection is turned off.
        /// </para>
        /// </summary>
        public bool? DeletionProtectionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtectionEnabled property is set.
        /// </summary>
        internal bool IsSetDeletionProtectionEnabled() => this.DeletionProtectionEnabled.HasValue;
    }
}
