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
    /// Lightweight projection for list results.
    /// </summary>
    public partial class PublisherSummary
    {
        /// <summary>
        /// Gets and sets the property AssociationCount. The number of registry records associated
        /// with the publisher, in any association status. Omitted when the count isn't available.
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? AssociationCount { get; set; }

        /// <summary>
        /// Checks to see if the AssociationCount property is set.
        /// </summary>
        internal bool IsSetAssociationCount() => this.AssociationCount.HasValue;

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
        /// Gets and sets the property IdentifierType. The identifier type. `DOMAIN` is the only
        /// supported value.
        /// </summary>
        public IdentifierType IdentifierType { get; set; }

        /// <summary>
        /// Checks to see if the IdentifierType property is set.
        /// </summary>
        internal bool IsSetIdentifierType() => this.IdentifierType != null;

        /// <summary>
        /// Gets and sets the property PendingAssociationApprovalCount. The number of the publisher's
        /// associations that are in PENDING_APPROVAL. Omitted when the count isn't available.
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? PendingAssociationApprovalCount { get; set; }

        /// <summary>
        /// Checks to see if the PendingAssociationApprovalCount property is set.
        /// </summary>
        internal bool IsSetPendingAssociationApprovalCount() => this.PendingAssociationApprovalCount.HasValue;

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
        /// `ACTION_REQUIRED`, `ACTIVE`, `SUSPENDED`, `FAILED`, or `DELETING`. Only an `ACTIVE`
        /// publisher accepts new registry record associations.
        /// </summary>
        [AWSProperty(Required = true)]
        public VerificationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

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
