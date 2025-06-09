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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
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
namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// This object is a container for common summary information about the entity. The summary
    /// doesn't contain the whole entity structure, but it does contain information common
    /// across all entities.
    /// </summary>
    public partial class EntitySummary
    {
        private AmiProductSummary _amiProductSummary;
        private ContainerProductSummary _containerProductSummary;
        private DataProductSummary _dataProductSummary;
        private string _entityArn;
        private string _entityId;
        private string _entityType;
        private string _lastModifiedDate;
        private MachineLearningProductSummary _machineLearningProductSummary;
        private string _name;
        private OfferSummary _offerSummary;
        private ResaleAuthorizationSummary _resaleAuthorizationSummary;
        private SaaSProductSummary _saaSProductSummary;
        private string _visibility;

        /// <summary>
        /// Gets and sets the property AmiProductSummary. 
        /// <para>
        /// An object that contains summary information about the AMI product.
        /// </para>
        /// </summary>
        public AmiProductSummary AmiProductSummary
        {
            get { return this._amiProductSummary; }
            set { this._amiProductSummary = value; }
        }

        // Check to see if AmiProductSummary property is set
        internal bool IsSetAmiProductSummary()
        {
            return this._amiProductSummary != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerProductSummary. 
        /// <para>
        /// An object that contains summary information about the container product.
        /// </para>
        /// </summary>
        public ContainerProductSummary ContainerProductSummary
        {
            get { return this._containerProductSummary; }
            set { this._containerProductSummary = value; }
        }

        // Check to see if ContainerProductSummary property is set
        internal bool IsSetContainerProductSummary()
        {
            return this._containerProductSummary != null;
        }

        /// <summary>
        /// Gets and sets the property DataProductSummary. 
        /// <para>
        /// An object that contains summary information about the data product.
        /// </para>
        /// </summary>
        public DataProductSummary DataProductSummary
        {
            get { return this._dataProductSummary; }
            set { this._dataProductSummary = value; }
        }

        // Check to see if DataProductSummary property is set
        internal bool IsSetDataProductSummary()
        {
            return this._dataProductSummary != null;
        }

        /// <summary>
        /// Gets and sets the property EntityArn. 
        /// <para>
        /// The ARN associated with the unique identifier for the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string EntityArn
        {
            get { return this._entityArn; }
            set { this._entityArn = value; }
        }

        // Check to see if EntityArn property is set
        internal bool IsSetEntityArn()
        {
            return this._entityArn != null;
        }

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The unique identifier for the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string EntityId
        {
            get { return this._entityId; }
            set { this._entityId = value; }
        }

        // Check to see if EntityId property is set
        internal bool IsSetEntityId()
        {
            return this._entityId != null;
        }

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        /// The type of the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string EntityType
        {
            get { return this._entityType; }
            set { this._entityType = value; }
        }

        // Check to see if EntityType property is set
        internal bool IsSetEntityType()
        {
            return this._entityType != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The last time the entity was published, using ISO 8601 format (2018-02-27T13:45:22Z).
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=20)]
        public string LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate != null;
        }

        /// <summary>
        /// Gets and sets the property MachineLearningProductSummary.
        /// </summary>
        public MachineLearningProductSummary MachineLearningProductSummary
        {
            get { return this._machineLearningProductSummary; }
            set { this._machineLearningProductSummary = value; }
        }

        // Check to see if MachineLearningProductSummary property is set
        internal bool IsSetMachineLearningProductSummary()
        {
            return this._machineLearningProductSummary != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the entity. This value is not unique. It is defined by the seller.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OfferSummary. 
        /// <para>
        /// An object that contains summary information about the offer.
        /// </para>
        /// </summary>
        public OfferSummary OfferSummary
        {
            get { return this._offerSummary; }
            set { this._offerSummary = value; }
        }

        // Check to see if OfferSummary property is set
        internal bool IsSetOfferSummary()
        {
            return this._offerSummary != null;
        }

        /// <summary>
        /// Gets and sets the property ResaleAuthorizationSummary. 
        /// <para>
        /// An object that contains summary information about the Resale Authorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationSummary ResaleAuthorizationSummary
        {
            get { return this._resaleAuthorizationSummary; }
            set { this._resaleAuthorizationSummary = value; }
        }

        // Check to see if ResaleAuthorizationSummary property is set
        internal bool IsSetResaleAuthorizationSummary()
        {
            return this._resaleAuthorizationSummary != null;
        }

        /// <summary>
        /// Gets and sets the property SaaSProductSummary. 
        /// <para>
        /// An object that contains summary information about the SaaS product.
        /// </para>
        /// </summary>
        public SaaSProductSummary SaaSProductSummary
        {
            get { return this._saaSProductSummary; }
            set { this._saaSProductSummary = value; }
        }

        // Check to see if SaaSProductSummary property is set
        internal bool IsSetSaaSProductSummary()
        {
            return this._saaSProductSummary != null;
        }

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// The visibility status of the entity to buyers. This value can be <c>Public</c> (everyone
        /// can view the entity), <c>Limited</c> (the entity is visible to limited accounts only),
        /// or <c>Restricted</c> (the entity was published and then unpublished and only existing
        /// buyers can view it). 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Visibility
        {
            get { return this._visibility; }
            set { this._visibility = value; }
        }

        // Check to see if Visibility property is set
        internal bool IsSetVisibility()
        {
            return this._visibility != null;
        }

    }
}