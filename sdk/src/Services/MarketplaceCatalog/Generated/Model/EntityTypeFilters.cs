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
    /// Object containing all the filter fields per entity type.
    /// </summary>
    public partial class EntityTypeFilters
    {
        private AmiProductFilters _amiProductFilters;
        private ContainerProductFilters _containerProductFilters;
        private DataProductFilters _dataProductFilters;
        private MachineLearningProductFilters _machineLearningProductFilters;
        private OfferFilters _offerFilters;
        private ResaleAuthorizationFilters _resaleAuthorizationFilters;
        private SaaSProductFilters _saaSProductFilters;

        /// <summary>
        /// Gets and sets the property AmiProductFilters. 
        /// <para>
        /// A filter for AMI products.
        /// </para>
        /// </summary>
        public AmiProductFilters AmiProductFilters
        {
            get { return this._amiProductFilters; }
            set { this._amiProductFilters = value; }
        }

        // Check to see if AmiProductFilters property is set
        internal bool IsSetAmiProductFilters()
        {
            return this._amiProductFilters != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerProductFilters. 
        /// <para>
        /// A filter for container products.
        /// </para>
        /// </summary>
        public ContainerProductFilters ContainerProductFilters
        {
            get { return this._containerProductFilters; }
            set { this._containerProductFilters = value; }
        }

        // Check to see if ContainerProductFilters property is set
        internal bool IsSetContainerProductFilters()
        {
            return this._containerProductFilters != null;
        }

        /// <summary>
        /// Gets and sets the property DataProductFilters. 
        /// <para>
        /// A filter for data products.
        /// </para>
        /// </summary>
        public DataProductFilters DataProductFilters
        {
            get { return this._dataProductFilters; }
            set { this._dataProductFilters = value; }
        }

        // Check to see if DataProductFilters property is set
        internal bool IsSetDataProductFilters()
        {
            return this._dataProductFilters != null;
        }

        /// <summary>
        /// Gets and sets the property MachineLearningProductFilters.
        /// </summary>
        public MachineLearningProductFilters MachineLearningProductFilters
        {
            get { return this._machineLearningProductFilters; }
            set { this._machineLearningProductFilters = value; }
        }

        // Check to see if MachineLearningProductFilters property is set
        internal bool IsSetMachineLearningProductFilters()
        {
            return this._machineLearningProductFilters != null;
        }

        /// <summary>
        /// Gets and sets the property OfferFilters. 
        /// <para>
        /// A filter for offers.
        /// </para>
        /// </summary>
        public OfferFilters OfferFilters
        {
            get { return this._offerFilters; }
            set { this._offerFilters = value; }
        }

        // Check to see if OfferFilters property is set
        internal bool IsSetOfferFilters()
        {
            return this._offerFilters != null;
        }

        /// <summary>
        /// Gets and sets the property ResaleAuthorizationFilters. 
        /// <para>
        /// A filter for Resale Authorizations.
        /// </para>
        /// </summary>
        public ResaleAuthorizationFilters ResaleAuthorizationFilters
        {
            get { return this._resaleAuthorizationFilters; }
            set { this._resaleAuthorizationFilters = value; }
        }

        // Check to see if ResaleAuthorizationFilters property is set
        internal bool IsSetResaleAuthorizationFilters()
        {
            return this._resaleAuthorizationFilters != null;
        }

        /// <summary>
        /// Gets and sets the property SaaSProductFilters. 
        /// <para>
        /// A filter for SaaS products.
        /// </para>
        /// </summary>
        public SaaSProductFilters SaaSProductFilters
        {
            get { return this._saaSProductFilters; }
            set { this._saaSProductFilters = value; }
        }

        // Check to see if SaaSProductFilters property is set
        internal bool IsSetSaaSProductFilters()
        {
            return this._saaSProductFilters != null;
        }

    }
}