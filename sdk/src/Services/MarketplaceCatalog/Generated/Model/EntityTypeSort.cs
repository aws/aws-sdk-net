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
    /// Object containing all the sort fields per entity type.
    /// </summary>
    public partial class EntityTypeSort
    {
        private AmiProductSort _amiProductSort;
        private ContainerProductSort _containerProductSort;
        private DataProductSort _dataProductSort;
        private MachineLearningProductSort _machineLearningProductSort;
        private OfferSort _offerSort;
        private ResaleAuthorizationSort _resaleAuthorizationSort;
        private SaaSProductSort _saaSProductSort;

        /// <summary>
        /// Gets and sets the property AmiProductSort. 
        /// <para>
        /// A sort for AMI products.
        /// </para>
        /// </summary>
        public AmiProductSort AmiProductSort
        {
            get { return this._amiProductSort; }
            set { this._amiProductSort = value; }
        }

        // Check to see if AmiProductSort property is set
        internal bool IsSetAmiProductSort()
        {
            return this._amiProductSort != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerProductSort. 
        /// <para>
        /// A sort for container products.
        /// </para>
        /// </summary>
        public ContainerProductSort ContainerProductSort
        {
            get { return this._containerProductSort; }
            set { this._containerProductSort = value; }
        }

        // Check to see if ContainerProductSort property is set
        internal bool IsSetContainerProductSort()
        {
            return this._containerProductSort != null;
        }

        /// <summary>
        /// Gets and sets the property DataProductSort. 
        /// <para>
        /// A sort for data products.
        /// </para>
        /// </summary>
        public DataProductSort DataProductSort
        {
            get { return this._dataProductSort; }
            set { this._dataProductSort = value; }
        }

        // Check to see if DataProductSort property is set
        internal bool IsSetDataProductSort()
        {
            return this._dataProductSort != null;
        }

        /// <summary>
        /// Gets and sets the property MachineLearningProductSort.
        /// </summary>
        public MachineLearningProductSort MachineLearningProductSort
        {
            get { return this._machineLearningProductSort; }
            set { this._machineLearningProductSort = value; }
        }

        // Check to see if MachineLearningProductSort property is set
        internal bool IsSetMachineLearningProductSort()
        {
            return this._machineLearningProductSort != null;
        }

        /// <summary>
        /// Gets and sets the property OfferSort. 
        /// <para>
        /// A sort for offers.
        /// </para>
        /// </summary>
        public OfferSort OfferSort
        {
            get { return this._offerSort; }
            set { this._offerSort = value; }
        }

        // Check to see if OfferSort property is set
        internal bool IsSetOfferSort()
        {
            return this._offerSort != null;
        }

        /// <summary>
        /// Gets and sets the property ResaleAuthorizationSort. 
        /// <para>
        /// A sort for Resale Authorizations.
        /// </para>
        /// </summary>
        public ResaleAuthorizationSort ResaleAuthorizationSort
        {
            get { return this._resaleAuthorizationSort; }
            set { this._resaleAuthorizationSort = value; }
        }

        // Check to see if ResaleAuthorizationSort property is set
        internal bool IsSetResaleAuthorizationSort()
        {
            return this._resaleAuthorizationSort != null;
        }

        /// <summary>
        /// Gets and sets the property SaaSProductSort. 
        /// <para>
        /// A sort for SaaS products.
        /// </para>
        /// </summary>
        public SaaSProductSort SaaSProductSort
        {
            get { return this._saaSProductSort; }
            set { this._saaSProductSort = value; }
        }

        // Check to see if SaaSProductSort property is set
        internal bool IsSetSaaSProductSort()
        {
            return this._saaSProductSort != null;
        }

    }
}