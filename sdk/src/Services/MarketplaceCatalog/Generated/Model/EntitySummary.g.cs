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

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// This object is a container for common summary information about the entity. The summary
    /// doesn't contain the whole entity structure, but it does contain information common
    /// across all entities.
    /// </summary>
    public partial class EntitySummary
    {
        /// <summary>
        /// Gets and sets the property AmiProductSummary. 
        /// <para>
        /// An object that contains summary information about the AMI product.
        /// </para>
        /// </summary>
        public AmiProductSummary AmiProductSummary { get; set; }

        /// <summary>
        /// Checks to see if the AmiProductSummary property is set.
        /// </summary>
        internal bool IsSetAmiProductSummary() => this.AmiProductSummary != null;

        /// <summary>
        /// Gets and sets the property ContainerProductSummary. 
        /// <para>
        /// An object that contains summary information about the container product.
        /// </para>
        /// </summary>
        public ContainerProductSummary ContainerProductSummary { get; set; }

        /// <summary>
        /// Checks to see if the ContainerProductSummary property is set.
        /// </summary>
        internal bool IsSetContainerProductSummary() => this.ContainerProductSummary != null;

        /// <summary>
        /// Gets and sets the property DataProductSummary. 
        /// <para>
        /// An object that contains summary information about the data product.
        /// </para>
        /// </summary>
        public DataProductSummary DataProductSummary { get; set; }

        /// <summary>
        /// Checks to see if the DataProductSummary property is set.
        /// </summary>
        internal bool IsSetDataProductSummary() => this.DataProductSummary != null;

        /// <summary>
        /// Gets and sets the property EntityArn. 
        /// <para>
        /// The ARN associated with the unique identifier for the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string EntityArn { get; set; }

        /// <summary>
        /// Checks to see if the EntityArn property is set.
        /// </summary>
        internal bool IsSetEntityArn() => this.EntityArn != null;

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The unique identifier for the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string EntityId { get; set; }

        /// <summary>
        /// Checks to see if the EntityId property is set.
        /// </summary>
        internal bool IsSetEntityId() => this.EntityId != null;

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        /// The type of the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string EntityType { get; set; }

        /// <summary>
        /// Checks to see if the EntityType property is set.
        /// </summary>
        internal bool IsSetEntityType() => this.EntityType != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The last time the entity was published, using ISO 8601 format (2018-02-27T13:45:22Z).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 20)]
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate != null;

        /// <summary>
        /// Gets and sets the property MachineLearningProductSummary.
        /// </summary>
        public MachineLearningProductSummary MachineLearningProductSummary { get; set; }

        /// <summary>
        /// Checks to see if the MachineLearningProductSummary property is set.
        /// </summary>
        internal bool IsSetMachineLearningProductSummary() => this.MachineLearningProductSummary != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the entity. This value is not unique. It is defined by the seller.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OfferSetSummary. 
        /// <para>
        /// An object that contains summary information about the offer set.
        /// </para>
        /// </summary>
        public OfferSetSummary OfferSetSummary { get; set; }

        /// <summary>
        /// Checks to see if the OfferSetSummary property is set.
        /// </summary>
        internal bool IsSetOfferSetSummary() => this.OfferSetSummary != null;

        /// <summary>
        /// Gets and sets the property OfferSummary. 
        /// <para>
        /// An object that contains summary information about the offer.
        /// </para>
        /// </summary>
        public OfferSummary OfferSummary { get; set; }

        /// <summary>
        /// Checks to see if the OfferSummary property is set.
        /// </summary>
        internal bool IsSetOfferSummary() => this.OfferSummary != null;

        /// <summary>
        /// Gets and sets the property ResaleAuthorizationSummary. 
        /// <para>
        /// An object that contains summary information about the Resale Authorization.
        /// </para>
        /// </summary>
        public ResaleAuthorizationSummary ResaleAuthorizationSummary { get; set; }

        /// <summary>
        /// Checks to see if the ResaleAuthorizationSummary property is set.
        /// </summary>
        internal bool IsSetResaleAuthorizationSummary() => this.ResaleAuthorizationSummary != null;

        /// <summary>
        /// Gets and sets the property SaaSProductSummary. 
        /// <para>
        /// An object that contains summary information about the SaaS product.
        /// </para>
        /// </summary>
        public SaaSProductSummary SaaSProductSummary { get; set; }

        /// <summary>
        /// Checks to see if the SaaSProductSummary property is set.
        /// </summary>
        internal bool IsSetSaaSProductSummary() => this.SaaSProductSummary != null;

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// The visibility status of the entity to buyers. This value can be <c>Public</c> (everyone
        /// can view the entity), <c>Limited</c> (the entity is visible to limited accounts only),
        /// or <c>Restricted</c> (the entity was published and then unpublished and only existing
        /// buyers can view it). 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Visibility { get; set; }

        /// <summary>
        /// Checks to see if the Visibility property is set.
        /// </summary>
        internal bool IsSetVisibility() => this.Visibility != null;
    }
}
