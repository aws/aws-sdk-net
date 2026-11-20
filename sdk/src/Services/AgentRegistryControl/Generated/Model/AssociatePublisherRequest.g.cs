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
    /// Container for the parameters to the AssociatePublisher operation. Associate a registry
    /// record with a publisher and assign the record a public identifier under the publisher's
    /// domain. The registry record must be APPROVED and the publisher must be ACTIVE. A registry
    /// record can have only one publisher association. The new association starts in PENDING_APPROVAL
    /// until a curator approves or rejects it. A ConflictException (HTTP 409) means the publisher
    /// is not ACTIVE yet, the registry record already has an association, or another registry
    /// record already holds the public identifier. To retry safely, repeat the request with
    /// the same clientToken; a retry returns the original association. If the publisher has
    /// reached its association quota, the request fails with ServiceQuotaExceededException
    /// (HTTP 402). Remove an unused association or request a quota increase.
    /// </summary>
    public partial class AssociatePublisherRequest : AmazonAgentRegistryControlRequest
    {
        /// <summary>
        /// Gets and sets the property Categories. Optional categorization/hierarchy applied to
        /// the public identifier.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 8)]
        public List<string> Categories { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Categories property is set.
        /// </summary>
        internal bool IsSetCategories() => this.Categories != null && (this.Categories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientToken. Optional client-provided idempotency token.
        /// Retries carrying the same token return the originally-created association instead
        /// of creating a duplicate.
        /// </summary>
        [AWSProperty(Min = 33, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property PublisherArn. The Publisher to associate the Record with.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string PublisherArn { get; set; }

        /// <summary>
        /// Checks to see if the PublisherArn property is set.
        /// </summary>
        internal bool IsSetPublisherArn() => this.PublisherArn != null;

        /// <summary>
        /// Gets and sets the property RecordArn. The Record being associated.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string RecordArn { get; set; }

        /// <summary>
        /// Checks to see if the RecordArn property is set.
        /// </summary>
        internal bool IsSetRecordArn() => this.RecordArn != null;

        /// <summary>
        /// Gets and sets the property Subdomain. Optional single DNS label placed in front of
        /// the publisher domain (e.g. "agents" -> agents.acme.com). Absent means the Record sits
        /// directly on the publisher domain.
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string Subdomain { get; set; }

        /// <summary>
        /// Checks to see if the Subdomain property is set.
        /// </summary>
        internal bool IsSetSubdomain() => this.Subdomain != null;
    }
}
