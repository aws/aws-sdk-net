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
    /// This is the response object from the GetSubscriptionGrant operation.
    /// </summary>
    public partial class GetSubscriptionGrantResponse : AmazonWebServiceResponse
    {
        private List<SubscribedAsset> _assets = AWSConfigs.InitializeCollections ? new List<SubscribedAsset>() : null;
        private DateTime? _createdAt;
        private string _createdBy;
        private string _domainId;
        private GrantedEntity _grantedEntity;
        private string _id;
        private SubscriptionGrantOverallStatus _status;
        private string _subscriptionId;
        private string _subscriptionTargetId;
        private DateTime? _updatedAt;
        private string _updatedBy;

        /// <summary>
        /// Gets and sets the property Assets. 
        /// <para>
        /// The assets for which the subscription grant is created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SubscribedAsset> Assets
        {
            get { return this._assets; }
            set { this._assets = value; }
        }

        // Check to see if Assets property is set
        internal bool IsSetAssets()
        {
            return this._assets != null && (this._assets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the subscription grant is created.
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
        /// The Amazon DataZone user who created the subscription grant.
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
        /// The ID of the Amazon DataZone domain in which the subscription grant exists.
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
        /// Gets and sets the property GrantedEntity. 
        /// <para>
        /// The entity to which the subscription is granted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GrantedEntity GrantedEntity
        {
            get { return this._grantedEntity; }
            set { this._grantedEntity = value; }
        }

        // Check to see if GrantedEntity property is set
        internal bool IsSetGrantedEntity()
        {
            return this._grantedEntity != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the subscription grant.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the subscription grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SubscriptionGrantOverallStatus Status
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
        /// Gets and sets the property SubscriptionId. 
        /// <para>
        /// The identifier of the subscription.
        /// </para>
        /// </summary>
        [Obsolete("Multiple subscriptions can exist for a single grant")]
        public string SubscriptionId
        {
            get { return this._subscriptionId; }
            set { this._subscriptionId = value; }
        }

        // Check to see if SubscriptionId property is set
        internal bool IsSetSubscriptionId()
        {
            return this._subscriptionId != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionTargetId. 
        /// <para>
        /// The subscription target ID associated with the subscription grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SubscriptionTargetId
        {
            get { return this._subscriptionTargetId; }
            set { this._subscriptionTargetId = value; }
        }

        // Check to see if SubscriptionTargetId property is set
        internal bool IsSetSubscriptionTargetId()
        {
            return this._subscriptionTargetId != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the subscription grant was upated.
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
        /// The Amazon DataZone user who updated the subscription grant.
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