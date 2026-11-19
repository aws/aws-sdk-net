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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Customizations for the distribution tenant. For each distribution tenant, you can
    /// specify the geographic restrictions, and the Amazon Resource Names (ARNs) for the
    /// ACM certificate and WAF web ACL. These are specific values that you can override or
    /// disable from the multi-tenant distribution that was used to create the distribution
    /// tenant.
    /// </summary>
    public partial class Customizations
    {
        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// The Certificate Manager (ACM) certificate.
        /// </para>
        /// </summary>
        public Certificate Certificate { get; set; }

        /// <summary>
        /// Checks to see if the Certificate property is set.
        /// </summary>
        internal bool IsSetCertificate() => this.Certificate != null;

        /// <summary>
        /// Gets and sets the property GeoRestrictions. 
        /// <para>
        /// The geographic restrictions.
        /// </para>
        /// </summary>
        public GeoRestrictionCustomization GeoRestrictions { get; set; }

        /// <summary>
        /// Checks to see if the GeoRestrictions property is set.
        /// </summary>
        internal bool IsSetGeoRestrictions() => this.GeoRestrictions != null;

        /// <summary>
        /// Gets and sets the property WebAcl. 
        /// <para>
        /// The WAF web ACL.
        /// </para>
        /// </summary>
        public WebAclCustomization WebAcl { get; set; }

        /// <summary>
        /// Checks to see if the WebAcl property is set.
        /// </summary>
        internal bool IsSetWebAcl() => this.WebAcl != null;
    }
}
