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
    /// Object containing all the filter fields per entity type.
    /// </summary>
    public partial class EntityTypeFilters
    {
        /// <summary>
        /// Gets and sets the property AmiProductFilters. 
        /// <para>
        /// A filter for AMI products.
        /// </para>
        /// </summary>
        public AmiProductFilters AmiProductFilters { get; set; }

        /// <summary>
        /// Checks to see if the AmiProductFilters property is set.
        /// </summary>
        internal bool IsSetAmiProductFilters() => this.AmiProductFilters != null;

        /// <summary>
        /// Gets and sets the property ContainerProductFilters. 
        /// <para>
        /// A filter for container products.
        /// </para>
        /// </summary>
        public ContainerProductFilters ContainerProductFilters { get; set; }

        /// <summary>
        /// Checks to see if the ContainerProductFilters property is set.
        /// </summary>
        internal bool IsSetContainerProductFilters() => this.ContainerProductFilters != null;

        /// <summary>
        /// Gets and sets the property DataProductFilters. 
        /// <para>
        /// A filter for data products.
        /// </para>
        /// </summary>
        public DataProductFilters DataProductFilters { get; set; }

        /// <summary>
        /// Checks to see if the DataProductFilters property is set.
        /// </summary>
        internal bool IsSetDataProductFilters() => this.DataProductFilters != null;

        /// <summary>
        /// Gets and sets the property MachineLearningProductFilters.
        /// </summary>
        public MachineLearningProductFilters MachineLearningProductFilters { get; set; }

        /// <summary>
        /// Checks to see if the MachineLearningProductFilters property is set.
        /// </summary>
        internal bool IsSetMachineLearningProductFilters() => this.MachineLearningProductFilters != null;

        /// <summary>
        /// Gets and sets the property OfferFilters. 
        /// <para>
        /// A filter for offers.
        /// </para>
        /// </summary>
        public OfferFilters OfferFilters { get; set; }

        /// <summary>
        /// Checks to see if the OfferFilters property is set.
        /// </summary>
        internal bool IsSetOfferFilters() => this.OfferFilters != null;

        /// <summary>
        /// Gets and sets the property OfferSetFilters. 
        /// <para>
        /// A filter for offer sets.
        /// </para>
        /// </summary>
        public OfferSetFilters OfferSetFilters { get; set; }

        /// <summary>
        /// Checks to see if the OfferSetFilters property is set.
        /// </summary>
        internal bool IsSetOfferSetFilters() => this.OfferSetFilters != null;

        /// <summary>
        /// Gets and sets the property ResaleAuthorizationFilters. 
        /// <para>
        /// A filter for Resale Authorizations.
        /// </para>
        /// </summary>
        public ResaleAuthorizationFilters ResaleAuthorizationFilters { get; set; }

        /// <summary>
        /// Checks to see if the ResaleAuthorizationFilters property is set.
        /// </summary>
        internal bool IsSetResaleAuthorizationFilters() => this.ResaleAuthorizationFilters != null;

        /// <summary>
        /// Gets and sets the property SaaSProductFilters. 
        /// <para>
        /// A filter for SaaS products.
        /// </para>
        /// </summary>
        public SaaSProductFilters SaaSProductFilters { get; set; }

        /// <summary>
        /// Checks to see if the SaaSProductFilters property is set.
        /// </summary>
        internal bool IsSetSaaSProductFilters() => this.SaaSProductFilters != null;
    }
}
