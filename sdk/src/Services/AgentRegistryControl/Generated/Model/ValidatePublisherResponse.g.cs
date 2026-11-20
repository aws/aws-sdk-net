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
    /// This is the response object from the ValidatePublisher operation.
    /// </summary>
    public partial class ValidatePublisherResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. The date and time that the publisher was created.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DomainChallenge.
        /// </summary>
        public DomainChallenge DomainChallenge { get; set; }

        /// <summary>
        /// Checks to see if the DomainChallenge property is set.
        /// </summary>
        internal bool IsSetDomainChallenge() => this.DomainChallenge != null;

        /// <summary>
        /// Gets and sets the property IdentifierType. The identifier type. `DOMAIN` is the only
        /// supported value.
        /// </summary>
        public IdentifierType IdentifierType { get; set; }

        /// <summary>
        /// Checks to see if the IdentifierType property is set.
        /// </summary>
        internal bool IsSetIdentifierType() => this.IdentifierType != null;

        /// <summary>
        /// Gets and sets the property PublisherArn.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string PublisherArn { get; set; }

        /// <summary>
        /// Checks to see if the PublisherArn property is set.
        /// </summary>
        internal bool IsSetPublisherArn() => this.PublisherArn != null;

        /// <summary>
        /// Gets and sets the property Status. The domain verification status of the publisher:
        /// - `ACTION_REQUIRED`: The registry is waiting to find the DNS TXT record described
        /// by `domainChallenge`. - `ACTIVE`: The domain is verified. You can associate registry
        /// records with the publisher. - `SUSPENDED`: The domain was verified, but a later check
        /// found the TXT record missing or changed. The publisher returns to `ACTIVE` when the
        /// record is found again, and becomes `FAILED` if the record stays missing. - `FAILED`:
        /// Verification didn't succeed, for example because the TXT record wasn't found in time
        /// or another account verified the domain first. Call `ValidatePublisher` to try again.
        /// - `DELETING`: A delete is in progress.
        /// </summary>
        [AWSProperty(Required = true)]
        public VerificationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. The reason for the publisher's current status,
        /// such as why verification failed. Present only when a reason is available.
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property Tags. The tags attached to the publisher.
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
        /// Gets and sets the property UpdatedAt. The date and time that the publisher was last
        /// updated.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

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
