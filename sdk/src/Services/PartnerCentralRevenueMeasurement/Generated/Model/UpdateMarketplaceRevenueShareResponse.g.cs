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

namespace Amazon.PartnerCentralRevenueMeasurement.Model
{
    /// <summary>
    /// This is the response object from the UpdateMarketplaceRevenueShare operation.
    /// </summary>
    public partial class UpdateMarketplaceRevenueShareResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the updated marketplace revenue share.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the updated marketplace revenue share, short ID form (mrs-...).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 17, Max = 17)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date when the marketplace revenue share was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property LatestRevision. 
        /// <para>
        /// The latest revision of the marketplace revenue share after the update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 19)]
        public string LatestRevision { get; set; }

        /// <summary>
        /// Checks to see if the LatestRevision property is set.
        /// </summary>
        internal bool IsSetLatestRevision() => this.LatestRevision != null;

        /// <summary>
        /// Gets and sets the property Products. 
        /// <para>
        /// The products in the marketplace revenue share after the update, each with per-type
        /// account counts. Empty when the marketplace revenue share is closed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 25)]
        public List<MarketplaceRevenueShareProductSummary> Products { get; set; } = AWSConfigs.InitializeCollections ? new List<MarketplaceRevenueShareProductSummary>() : null;

        /// <summary>
        /// Checks to see if the Products property is set.
        /// </summary>
        internal bool IsSetProducts() => this.Products != null && (this.Products.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
