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
    /// Container for the parameters to the BatchDescribeEntities operation.
    /// Returns metadata and content for multiple entities. This is the Batch version of the
    /// <c>DescribeEntity</c> API and uses the same IAM permission action as <c>DescribeEntity</c>
    /// API.
    /// </summary>
    public partial class BatchDescribeEntitiesRequest : AmazonMarketplaceCatalogRequest
    {
        private List<EntityRequest> _entityRequestList = AWSConfigs.InitializeCollections ? new List<EntityRequest>() : null;

        /// <summary>
        /// Gets and sets the property EntityRequestList. 
        /// <para>
        /// List of entity IDs and the catalogs the entities are present in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<EntityRequest> EntityRequestList
        {
            get { return this._entityRequestList; }
            set { this._entityRequestList = value; }
        }

        // Check to see if EntityRequestList property is set
        internal bool IsSetEntityRequestList()
        {
            return this._entityRequestList != null && (this._entityRequestList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}