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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Information needed to continue an application with the provider.
    /// </summary>
    public partial class TrustedAccessProgramProviderHandoff
    {
        /// <summary>
        /// Gets and sets the property ApplicationToken. 
        /// <para>
        /// Opaque token binding the application to the authenticated customer, requested program,
        /// and scope.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1)]
        public string ApplicationToken { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationToken property is set.
        /// </summary>
        internal bool IsSetApplicationToken() => this.ApplicationToken != null;

        /// <summary>
        /// Gets and sets the property ApplicationTokenExpiresAt. 
        /// <para>
        /// Deadline for the provider to accept the application context. Start another application
        /// handoff if the token expires before acceptance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ApplicationTokenExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationTokenExpiresAt property is set.
        /// </summary>
        internal bool IsSetApplicationTokenExpiresAt() => this.ApplicationTokenExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property EnrollmentUrl. 
        /// <para>
        /// Provider intake URL. When present, open it and paste the complete application token
        /// into the provider's token field. Omitted when the provider receives the application
        /// token through a separate integration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string EnrollmentUrl { get; set; }

        /// <summary>
        /// Checks to see if the EnrollmentUrl property is set.
        /// </summary>
        internal bool IsSetEnrollmentUrl() => this.EnrollmentUrl != null;
    }
}
