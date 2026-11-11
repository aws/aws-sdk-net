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
    /// Container for the parameters to the ListDistributionTenantsByCustomization operation.
    /// Lists distribution tenants by the customization that you specify. <para> You must
    /// specify either the <c>CertificateArn</c> parameter or <c>WebACLArn</c> parameter,
    /// but not both in the same request. </para>
    /// </summary>
    public partial class ListDistributionTenantsByCustomizationRequest : AmazonCloudFrontRequest
    {
        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// Filter by the ARN of the associated ACM certificate.
        /// </para>
        /// </summary>
        public string CertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateArn property is set.
        /// </summary>
        internal bool IsSetCertificateArn() => this.CertificateArn != null;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The marker for the next set of results.
        /// </para>
        /// </summary>
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The maximum number of distribution tenants to return by the specified customization.
        /// </para>
        /// </summary>
        public int? MaxItems { get; set; }

        /// <summary>
        /// Checks to see if the MaxItems property is set.
        /// </summary>
        internal bool IsSetMaxItems() => this.MaxItems.HasValue;

        /// <summary>
        /// Gets and sets the property WebACLArn. 
        /// <para>
        /// Filter by the ARN of the associated WAF web ACL.
        /// </para>
        /// </summary>
        public string WebACLArn { get; set; }

        /// <summary>
        /// Checks to see if the WebACLArn property is set.
        /// </summary>
        internal bool IsSetWebACLArn() => this.WebACLArn != null;
    }
}
