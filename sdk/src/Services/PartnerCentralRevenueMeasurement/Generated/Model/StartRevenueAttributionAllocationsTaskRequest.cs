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
 * Do not modify this file. This file is generated from the partnercentral-revenue-measurement-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralRevenueMeasurement.Model
{
    /// <summary>
    /// Container for the parameters to the StartRevenueAttributionAllocationsTask operation.
    /// Submits a batch of up to 250 allocation changes (CREATE and/or UPDATE) for asynchronous
    /// processing. Returns a TaskId for tracking.
    /// </summary>
    public partial class StartRevenueAttributionAllocationsTaskRequest : AmazonPartnerCentralRevenueMeasurementRequest
    {
        private CatalogName _catalog;
        private string _clientToken;
        private string _description;
        private string _revenueAttributionIdentifier;
        private string _revenueAttributionRevision;
        private List<RevenueShareAllocation> _revenueShareAllocations = AWSConfigs.InitializeCollections ? new List<RevenueShareAllocation>() : null;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog context for this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CatalogName Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Idempotency token for deduplication and retry.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Human-readable description of the batch.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property RevenueAttributionIdentifier. 
        /// <para>
        /// The revenue attribution identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=16, Max=1011)]
        public string RevenueAttributionIdentifier
        {
            get { return this._revenueAttributionIdentifier; }
            set { this._revenueAttributionIdentifier = value; }
        }

        // Check to see if RevenueAttributionIdentifier property is set
        internal bool IsSetRevenueAttributionIdentifier()
        {
            return this._revenueAttributionIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property RevenueAttributionRevision. 
        /// <para>
        /// Current revision of the revenue attribution for optimistic locking.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=19)]
        public string RevenueAttributionRevision
        {
            get { return this._revenueAttributionRevision; }
            set { this._revenueAttributionRevision = value; }
        }

        // Check to see if RevenueAttributionRevision property is set
        internal bool IsSetRevenueAttributionRevision()
        {
            return this._revenueAttributionRevision != null;
        }

        /// <summary>
        /// Gets and sets the property RevenueShareAllocations. 
        /// <para>
        /// The list of allocation changes to process in this batch.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=250)]
        public List<RevenueShareAllocation> RevenueShareAllocations
        {
            get { return this._revenueShareAllocations; }
            set { this._revenueShareAllocations = value; }
        }

        // Check to see if RevenueShareAllocations property is set
        internal bool IsSetRevenueShareAllocations()
        {
            return this._revenueShareAllocations != null && (this._revenueShareAllocations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}