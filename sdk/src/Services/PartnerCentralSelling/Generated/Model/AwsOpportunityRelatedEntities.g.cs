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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Represents other entities related to the AWS opportunity, such as AWS products, partner
    /// solutions, and marketplace offers. These associations help build a complete picture
    /// of the solution being sold.
    /// </summary>
    public partial class AwsOpportunityRelatedEntities
    {
        /// <summary>
        /// Gets and sets the property AwsMarketplaceProducts. 
        /// <para>
        /// The AWS Marketplace product ARNs associated with this opportunity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AwsMarketplaceProducts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AwsMarketplaceProducts property is set.
        /// </summary>
        internal bool IsSetAwsMarketplaceProducts() => this.AwsMarketplaceProducts != null && (this.AwsMarketplaceProducts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AwsMarketplaceSolutions. 
        /// <para>
        /// The AWS Marketplace solution ARNs associated with this opportunity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AwsMarketplaceSolutions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AwsMarketplaceSolutions property is set.
        /// </summary>
        internal bool IsSetAwsMarketplaceSolutions() => this.AwsMarketplaceSolutions != null && (this.AwsMarketplaceSolutions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AwsProducts. 
        /// <para>
        /// Specifies the AWS products associated with the opportunity. This field helps track
        /// the specific products that are part of the proposed solution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AwsProducts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AwsProducts property is set.
        /// </summary>
        internal bool IsSetAwsProducts() => this.AwsProducts != null && (this.AwsProducts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Solutions. 
        /// <para>
        /// Specifies the partner solutions related to the opportunity. These solutions represent
        /// the partner's offerings that are being positioned as part of the overall AWS opportunity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Solutions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Solutions property is set.
        /// </summary>
        internal bool IsSetSolutions() => this.Solutions != null && (this.Solutions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
