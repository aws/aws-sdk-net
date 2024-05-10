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
    /// This is the response object from the CancelSubscription operation.
    /// </summary>
    public partial class CancelSubscriptionResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private string _createdBy;
        private string _domainId;
        private string _id;
        private bool? _retainPermissions;
        private SubscriptionStatus _status;
        private SubscribedListing _subscribedListing;
        private SubscribedPrincipal _subscribedPrincipal;
        private string _subscriptionRequestId;
        private DateTime? _updatedAt;
        private string _updatedBy;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp that specifies when the request to cancel the subscription was created.
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
        /// Specifies the Amazon DataZone user who is cancelling the subscription.
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
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The unique identifier of the Amazon DataZone domain where the subscription is being
        /// cancelled.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the subscription.
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
        /// Gets and sets the property RetainPermissions. 
        /// <para>
        /// Specifies whether the permissions to the asset are retained after the subscription
        /// is cancelled.
        /// </para>
        /// </summary>
        public bool? RetainPermissions
        {
            get { return this._retainPermissions; }
            set { this._retainPermissions = value; }
        }

        // Check to see if RetainPermissions property is set
        internal bool IsSetRetainPermissions()
        {
            return this._retainPermissions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the request to cancel the subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SubscriptionStatus Status
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
        /// Gets and sets the property SubscribedListing. 
        /// <para>
        /// The asset to which a subscription is being cancelled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SubscribedListing SubscribedListing
        {
            get { return this._subscribedListing; }
            set { this._subscribedListing = value; }
        }

        // Check to see if SubscribedListing property is set
        internal bool IsSetSubscribedListing()
        {
            return this._subscribedListing != null;
        }

        /// <summary>
        /// Gets and sets the property SubscribedPrincipal. 
        /// <para>
        /// The Amazon DataZone user who is made a subscriber to the specified asset by the subscription
        /// that is being cancelled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SubscribedPrincipal SubscribedPrincipal
        {
            get { return this._subscribedPrincipal; }
            set { this._subscribedPrincipal = value; }
        }

        // Check to see if SubscribedPrincipal property is set
        internal bool IsSetSubscribedPrincipal()
        {
            return this._subscribedPrincipal != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionRequestId. 
        /// <para>
        /// The unique ID of the subscripton request for the subscription that is being cancelled.
        /// </para>
        /// </summary>
        public string SubscriptionRequestId
        {
            get { return this._subscriptionRequestId; }
            set { this._subscriptionRequestId = value; }
        }

        // Check to see if SubscriptionRequestId property is set
        internal bool IsSetSubscriptionRequestId()
        {
            return this._subscriptionRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp that specifies when the subscription was cancelled.
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
        /// The Amazon DataZone user that cancelled the subscription.
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