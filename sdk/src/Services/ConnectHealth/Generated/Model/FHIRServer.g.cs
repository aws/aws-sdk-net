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

namespace Amazon.ConnectHealth.Model
{
    /// <summary>
    /// FHIR server configuration for input data source
    /// </summary>
    public partial class FHIRServer
    {
        /// <summary>
        /// Gets and sets the property FhirEndpoint. 
        /// <para>
        /// FHIR server endpoint URL for accessing patient data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FhirEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the FhirEndpoint property is set.
        /// </summary>
        internal bool IsSetFhirEndpoint() => this.FhirEndpoint != null;

        /// <summary>
        /// Gets and sets the property OauthToken. 
        /// <para>
        /// OAuth token for authenticating with the FHIR server.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string OauthToken { get; set; }

        /// <summary>
        /// Checks to see if the OauthToken property is set.
        /// </summary>
        internal bool IsSetOauthToken() => this.OauthToken != null;
    }
}
