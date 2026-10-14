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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Describes a work team of a vendor that does the labelling job.
    /// </summary>
    public partial class SubscribedWorkteam
    {
        /// <summary>
        /// Gets and sets the property ListingId. 
        /// <para>
        /// Marketplace product listing ID.
        /// </para>
        /// </summary>
        public string ListingId { get; set; }

        /// <summary>
        /// Checks to see if the ListingId property is set.
        /// </summary>
        internal bool IsSetListingId() => this.ListingId != null;

        /// <summary>
        /// Gets and sets the property MarketplaceDescription. 
        /// <para>
        /// The description of the vendor from the Amazon Marketplace.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string MarketplaceDescription { get; set; }

        /// <summary>
        /// Checks to see if the MarketplaceDescription property is set.
        /// </summary>
        internal bool IsSetMarketplaceDescription() => this.MarketplaceDescription != null;

        /// <summary>
        /// Gets and sets the property MarketplaceTitle. 
        /// <para>
        /// The title of the service provided by the vendor in the Amazon Marketplace.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string MarketplaceTitle { get; set; }

        /// <summary>
        /// Checks to see if the MarketplaceTitle property is set.
        /// </summary>
        internal bool IsSetMarketplaceTitle() => this.MarketplaceTitle != null;

        /// <summary>
        /// Gets and sets the property SellerName. 
        /// <para>
        /// The name of the vendor in the Amazon Marketplace.
        /// </para>
        /// </summary>
        public string SellerName { get; set; }

        /// <summary>
        /// Checks to see if the SellerName property is set.
        /// </summary>
        internal bool IsSetSellerName() => this.SellerName != null;

        /// <summary>
        /// Gets and sets the property WorkteamArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the vendor that you have subscribed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string WorkteamArn { get; set; }

        /// <summary>
        /// Checks to see if the WorkteamArn property is set.
        /// </summary>
        internal bool IsSetWorkteamArn() => this.WorkteamArn != null;
    }
}
