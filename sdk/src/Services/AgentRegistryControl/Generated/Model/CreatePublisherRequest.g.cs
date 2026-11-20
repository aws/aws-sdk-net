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

namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePublisher operation. Create a publisher
    /// for a domain you control. The publisher starts in ACTION_REQUIRED, and the response
    /// includes a domainChallenge. To verify the domain, create a DNS TXT record with the
    /// challenge's recordName and recordValue. When the registry finds the record, the publisher
    /// becomes ACTIVE and you can associate registry records with it. Your account can have
    /// one publisher per domain. Creating a second publisher for the same domain fails with
    /// ConflictException unless the request repeats the original clientToken, which returns
    /// the existing publisher. The request also fails with ConflictException when another
    /// account has already verified the domain. If your account has reached its Publisher
    /// quota, the request fails with ServiceQuotaExceededException (HTTP 402). Delete an
    /// unused Publisher or request a quota increase.
    /// </summary>
    public partial class CreatePublisherRequest : AmazonAgentRegistryControlRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. Optional client-provided idempotency token.
        /// Retries of the same Create request carrying the same token return the originally-created
        /// resource instead of creating a duplicate. Forwarded to BelfryGlobalCP. Optional and
        /// backward-compatible.
        /// </summary>
        [AWSProperty(Min = 33, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Tags. The tags to attach to the publisher. Each tag is
        /// a key-value pair. You can attach up to 50 tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Value.
        /// </summary>
        [AWSProperty(Required = true)]
        public Identifier Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
