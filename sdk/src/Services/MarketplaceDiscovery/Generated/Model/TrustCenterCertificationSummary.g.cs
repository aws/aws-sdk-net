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

namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// Summary information for a certification associated with a listing.
    /// </summary>
    public partial class TrustCenterCertificationSummary
    {
        /// <summary>
        /// Gets and sets the property CertificationType. 
        /// <para>
        /// The certification type. The set of values is open and can include provider-defined
        /// certifications.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string CertificationType { get; set; }

        /// <summary>
        /// Checks to see if the CertificationType property is set.
        /// </summary>
        internal bool IsSetCertificationType() => this.CertificationType != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The certification name displayed to you.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property LogoUrl. 
        /// <para>
        /// The URL of the certification logo.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// Checks to see if the LogoUrl property is set.
        /// </summary>
        internal bool IsSetLogoUrl() => this.LogoUrl != null;
    }
}
