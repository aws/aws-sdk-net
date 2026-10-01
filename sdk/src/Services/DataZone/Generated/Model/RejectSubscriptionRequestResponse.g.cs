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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// This is the response object from the RejectSubscriptionRequest operation.
    /// </summary>
    public partial class RejectSubscriptionRequestResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the subscription request was rejected.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The timestamp of when the subscription request was rejected.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property DecisionComment. 
        /// <para>
        /// The decision comment of the rejected subscription request.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4096)]
        public string DecisionComment { get; set; }

        /// <summary>
        /// Checks to see if the DecisionComment property is set.
        /// </summary>
        internal bool IsSetDecisionComment() => this.DecisionComment != null;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the Amazon DataZone domain in which the subscription request was
        /// rejected.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property ExistingSubscriptionId. 
        /// <para>
        /// The ID of the existing subscription.
        /// </para>
        /// </summary>
        public string ExistingSubscriptionId { get; set; }

        /// <summary>
        /// Checks to see if the ExistingSubscriptionId property is set.
        /// </summary>
        internal bool IsSetExistingSubscriptionId() => this.ExistingSubscriptionId != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the subscription request that was rejected.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property MetadataForms. 
        /// <para>
        /// Metadata forms included in the subscription request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FormOutput> MetadataForms { get; set; } = AWSConfigs.InitializeCollections ? new List<FormOutput>() : null;

        /// <summary>
        /// Checks to see if the MetadataForms property is set.
        /// </summary>
        internal bool IsSetMetadataForms() => this.MetadataForms != null && (this.MetadataForms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RequestReason. 
        /// <para>
        /// The reason for the subscription request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 4096)]
        public string RequestReason { get; set; }

        /// <summary>
        /// Checks to see if the RequestReason property is set.
        /// </summary>
        internal bool IsSetRequestReason() => this.RequestReason != null;

        /// <summary>
        /// Gets and sets the property ReviewerId. 
        /// <para>
        /// The identifier of the subscription request reviewer.
        /// </para>
        /// </summary>
        public string ReviewerId { get; set; }

        /// <summary>
        /// Checks to see if the ReviewerId property is set.
        /// </summary>
        internal bool IsSetReviewerId() => this.ReviewerId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the subscription request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SubscriptionRequestStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SubscribedListings. 
        /// <para>
        /// The subscribed listings of the subscription request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<SubscribedListing> SubscribedListings { get; set; } = AWSConfigs.InitializeCollections ? new List<SubscribedListing>() : null;

        /// <summary>
        /// Checks to see if the SubscribedListings property is set.
        /// </summary>
        internal bool IsSetSubscribedListings() => this.SubscribedListings != null && (this.SubscribedListings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubscribedPrincipals. 
        /// <para>
        /// The subscribed principals of the subscription request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<SubscribedPrincipal> SubscribedPrincipals { get; set; } = AWSConfigs.InitializeCollections ? new List<SubscribedPrincipal>() : null;

        /// <summary>
        /// Checks to see if the SubscribedPrincipals property is set.
        /// </summary>
        internal bool IsSetSubscribedPrincipals() => this.SubscribedPrincipals != null && (this.SubscribedPrincipals.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the subscription request was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// The Amazon DataZone user who updated the subscription request.
        /// </para>
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedBy property is set.
        /// </summary>
        internal bool IsSetUpdatedBy() => this.UpdatedBy != null;
    }
}
