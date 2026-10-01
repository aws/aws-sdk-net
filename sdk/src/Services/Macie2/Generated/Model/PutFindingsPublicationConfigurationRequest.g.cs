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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Container for the parameters to the PutFindingsPublicationConfiguration operation.
    /// Updates the configuration settings for publishing findings to Security Hub.
    /// </summary>
    public partial class PutFindingsPublicationConfigurationRequest : AmazonMacie2Request
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive token that you provide to ensure the idempotency of the request.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property SecurityHubConfiguration. 
        /// <para>
        /// The configuration settings that determine which findings to publish to Security Hub.
        /// </para>
        /// </summary>
        public SecurityHubConfiguration SecurityHubConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SecurityHubConfiguration property is set.
        /// </summary>
        internal bool IsSetSecurityHubConfiguration() => this.SecurityHubConfiguration != null;
    }
}
