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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
        private DateTime? _createdAt;
        private string _createdBy;
        private string _decisionComment;
        private string _domainId;
        private string _existingSubscriptionId;
        private string _id;
        private List<FormOutput> _metadataForms = AWSConfigs.InitializeCollections ? new List<FormOutput>() : null;
        private string _requestReason;
        private string _reviewerId;
        private SubscriptionRequestStatus _status;
        private List<SubscribedListing> _subscribedListings = AWSConfigs.InitializeCollections ? new List<SubscribedListing>() : null;
        private List<SubscribedPrincipal> _subscribedPrincipals = AWSConfigs.InitializeCollections ? new List<SubscribedPrincipal>() : null;
        private DateTime? _updatedAt;
        private string _updatedBy;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the subscription request was rejected.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The timestamp of when the subscription request was rejected.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property DecisionComment. 
        /// <para>
        /// The decision comment of the rejected subscription request.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4096)]
        public string DecisionComment
        {
            get { return this._decisionComment; }
            set { this._decisionComment = value; }
        }

        // Check to see if DecisionComment property is set
        internal bool IsSetDecisionComment()
        {
            return this._decisionComment != null;
        }

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the Amazon DataZone domain in which the subscription request was
        /// rejected.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property ExistingSubscriptionId. 
        /// <para>
        /// The ID of the existing subscription.
        /// </para>
        /// </summary>
        public string ExistingSubscriptionId
        {
            get { return this._existingSubscriptionId; }
            set { this._existingSubscriptionId = value; }
        }

        // Check to see if ExistingSubscriptionId property is set
        internal bool IsSetExistingSubscriptionId()
        {
            return this._existingSubscriptionId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the subscription request that was rejected.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property MetadataForms. 
        /// <para>
        /// Metadata forms included in the subscription request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FormOutput> MetadataForms
        {
            get { return this._metadataForms; }
            set { this._metadataForms = value; }
        }

        // Check to see if MetadataForms property is set
        internal bool IsSetMetadataForms()
        {
            return this._metadataForms != null && (this._metadataForms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RequestReason. 
        /// <para>
        /// The reason for the subscription request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=4096)]
        public string RequestReason
        {
            get { return this._requestReason; }
            set { this._requestReason = value; }
        }

        // Check to see if RequestReason property is set
        internal bool IsSetRequestReason()
        {
            return this._requestReason != null;
        }

        /// <summary>
        /// Gets and sets the property ReviewerId. 
        /// <para>
        /// The identifier of the subscription request reviewer.
        /// </para>
        /// </summary>
        public string ReviewerId
        {
            get { return this._reviewerId; }
            set { this._reviewerId = value; }
        }

        // Check to see if ReviewerId property is set
        internal bool IsSetReviewerId()
        {
            return this._reviewerId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the subscription request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SubscriptionRequestStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SubscribedListings. 
        /// <para>
        /// The subscribed listings of the subscription request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<SubscribedListing> SubscribedListings
        {
            get { return this._subscribedListings; }
            set { this._subscribedListings = value; }
        }

        // Check to see if SubscribedListings property is set
        internal bool IsSetSubscribedListings()
        {
            return this._subscribedListings != null && (this._subscribedListings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubscribedPrincipals. 
        /// <para>
        /// The subscribed principals of the subscription request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<SubscribedPrincipal> SubscribedPrincipals
        {
            get { return this._subscribedPrincipals; }
            set { this._subscribedPrincipals = value; }
        }

        // Check to see if SubscribedPrincipals property is set
        internal bool IsSetSubscribedPrincipals()
        {
            return this._subscribedPrincipals != null && (this._subscribedPrincipals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the subscription request was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// The Amazon DataZone user who updated the subscription request.
        /// </para>
        /// </summary>
        public string UpdatedBy
        {
            get { return this._updatedBy; }
            set { this._updatedBy = value; }
        }

        // Check to see if UpdatedBy property is set
        internal bool IsSetUpdatedBy()
        {
            return this._updatedBy != null;
        }

    }
}