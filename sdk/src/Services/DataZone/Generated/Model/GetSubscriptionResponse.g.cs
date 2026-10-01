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
    /// This is the response object from the GetSubscription operation.
    /// </summary>
    public partial class GetSubscriptionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the subscription was created.
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
        /// The Amazon DataZone user who created the subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The ID of the Amazon DataZone domain in which the subscription exists.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property RetainPermissions. 
        /// <para>
        /// The retain permissions of the subscription.
        /// </para>
        /// </summary>
        public bool? RetainPermissions { get; set; }

        /// <summary>
        /// Checks to see if the RetainPermissions property is set.
        /// </summary>
        internal bool IsSetRetainPermissions() => this.RetainPermissions.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SubscriptionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SubscribedListing. 
        /// <para>
        /// The details of the published asset for which the subscription grant is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SubscribedListing SubscribedListing { get; set; }

        /// <summary>
        /// Checks to see if the SubscribedListing property is set.
        /// </summary>
        internal bool IsSetSubscribedListing() => this.SubscribedListing != null;

        /// <summary>
        /// Gets and sets the property SubscribedPrincipal. 
        /// <para>
        /// The principal that owns the subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SubscribedPrincipal SubscribedPrincipal { get; set; }

        /// <summary>
        /// Checks to see if the SubscribedPrincipal property is set.
        /// </summary>
        internal bool IsSetSubscribedPrincipal() => this.SubscribedPrincipal != null;

        /// <summary>
        /// Gets and sets the property SubscriptionRequestId. 
        /// <para>
        /// The ID of the subscription request.
        /// </para>
        /// </summary>
        public string SubscriptionRequestId { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionRequestId property is set.
        /// </summary>
        internal bool IsSetSubscriptionRequestId() => this.SubscriptionRequestId != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the subscription was updated.
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
        /// The Amazon DataZone user who updated the subscription.
        /// </para>
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedBy property is set.
        /// </summary>
        internal bool IsSetUpdatedBy() => this.UpdatedBy != null;
    }
}
