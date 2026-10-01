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
    /// Object containing all the sort fields per entity type.
    /// </summary>
    public partial class EntityTypeSort
    {
        /// <summary>
        /// Gets and sets the property AmiProductSort. 
        /// <para>
        /// A sort for AMI products.
        /// </para>
        /// </summary>
        public AmiProductSort AmiProductSort { get; set; }

        /// <summary>
        /// Checks to see if the AmiProductSort property is set.
        /// </summary>
        internal bool IsSetAmiProductSort() => this.AmiProductSort != null;

        /// <summary>
        /// Gets and sets the property ContainerProductSort. 
        /// <para>
        /// A sort for container products.
        /// </para>
        /// </summary>
        public ContainerProductSort ContainerProductSort { get; set; }

        /// <summary>
        /// Checks to see if the ContainerProductSort property is set.
        /// </summary>
        internal bool IsSetContainerProductSort() => this.ContainerProductSort != null;

        /// <summary>
        /// Gets and sets the property DataProductSort. 
        /// <para>
        /// A sort for data products.
        /// </para>
        /// </summary>
        public DataProductSort DataProductSort { get; set; }

        /// <summary>
        /// Checks to see if the DataProductSort property is set.
        /// </summary>
        internal bool IsSetDataProductSort() => this.DataProductSort != null;

        /// <summary>
        /// Gets and sets the property MachineLearningProductSort.
        /// </summary>
        public MachineLearningProductSort MachineLearningProductSort { get; set; }

        /// <summary>
        /// Checks to see if the MachineLearningProductSort property is set.
        /// </summary>
        internal bool IsSetMachineLearningProductSort() => this.MachineLearningProductSort != null;

        /// <summary>
        /// Gets and sets the property OfferSetSort. 
        /// <para>
        /// A sort for offer sets.
        /// </para>
        /// </summary>
        public OfferSetSort OfferSetSort { get; set; }

        /// <summary>
        /// Checks to see if the OfferSetSort property is set.
        /// </summary>
        internal bool IsSetOfferSetSort() => this.OfferSetSort != null;

        /// <summary>
        /// Gets and sets the property OfferSort. 
        /// <para>
        /// A sort for offers.
        /// </para>
        /// </summary>
        public OfferSort OfferSort { get; set; }

        /// <summary>
        /// Checks to see if the OfferSort property is set.
        /// </summary>
        internal bool IsSetOfferSort() => this.OfferSort != null;

        /// <summary>
        /// Gets and sets the property ResaleAuthorizationSort. 
        /// <para>
        /// A sort for Resale Authorizations.
        /// </para>
        /// </summary>
        public ResaleAuthorizationSort ResaleAuthorizationSort { get; set; }

        /// <summary>
        /// Checks to see if the ResaleAuthorizationSort property is set.
        /// </summary>
        internal bool IsSetResaleAuthorizationSort() => this.ResaleAuthorizationSort != null;

        /// <summary>
        /// Gets and sets the property SaaSProductSort. 
        /// <para>
        /// A sort for SaaS products.
        /// </para>
        /// </summary>
        public SaaSProductSort SaaSProductSort { get; set; }

        /// <summary>
        /// Checks to see if the SaaSProductSort property is set.
        /// </summary>
        internal bool IsSetSaaSProductSort() => this.SaaSProductSort != null;
    }
}
