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
    /// The details of the subscription.
    /// </summary>
    public partial class SubscriptionSummary
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
        /// The timestamp of when the subscription was created.
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
        /// The Amazon DataZone user who created the subscription.
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
        /// The identifier of the Amazon DataZone domain in which a subscription exists.
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
        /// The retain permissions included in the subscription.
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
        /// The status of the subscription.
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
        /// The listing included in the subscription.
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
        /// The principal included in the subscription.
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
        /// The identifier of the subscription request for the subscription.
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
        /// The timestamp of when the subscription was updated.
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
        /// The Amazon DataZone user who updated the subscription.
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