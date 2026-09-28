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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Information about an Amazon Web Services account or service that has access to an
    /// Amazon OpenSearch Service domain through the use of an interface VPC endpoint.
    /// </summary>
    public partial class AuthorizedPrincipal
    {
        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_principal.html">IAM
        /// principal</a> that is allowed access to the domain.
        /// </para>
        /// </summary>
        public string Principal { get; set; }

        /// <summary>
        /// Checks to see if the Principal property is set.
        /// </summary>
        internal bool IsSetPrincipal() => this.Principal != null;

        /// <summary>
        /// Gets and sets the property PrincipalType. 
        /// <para>
        /// The type of principal.
        /// </para>
        /// </summary>
        public PrincipalType PrincipalType { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalType property is set.
        /// </summary>
        internal bool IsSetPrincipalType() => this.PrincipalType != null;

        /// <summary>
        /// Gets and sets the property ServiceOptions. 
        /// <para>
        /// The options for the service, including the supported Regions for the endpoint access.
        /// </para>
        /// </summary>
        public ServiceOptions ServiceOptions { get; set; }

        /// <summary>
        /// Checks to see if the ServiceOptions property is set.
        /// </summary>
        internal bool IsSetServiceOptions() => this.ServiceOptions != null;
    }
}
