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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTargetDomain operation. Creates a new target
    /// domain for penetration testing. A target domain is a web domain that must be registered
    /// and verified before it can be tested.
    /// </summary>
    public partial class CreateTargetDomainRequest : AmazonSecurityAgentRequest
    {
        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to associate with the target domain.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetDomainName. 
        /// <para>
        /// The domain name to register as a target domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetDomainName { get; set; }

        /// <summary>
        /// Checks to see if the TargetDomainName property is set.
        /// </summary>
        internal bool IsSetTargetDomainName() => this.TargetDomainName != null;

        /// <summary>
        /// Gets and sets the property VerificationMethod. 
        /// <para>
        /// The method to use for verifying domain ownership. Valid values are DNS_TXT, HTTP_ROUTE,
        /// and PRIVATE_VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DomainVerificationMethod VerificationMethod { get; set; }

        /// <summary>
        /// Checks to see if the VerificationMethod property is set.
        /// </summary>
        internal bool IsSetVerificationMethod() => this.VerificationMethod != null;
    }
}
