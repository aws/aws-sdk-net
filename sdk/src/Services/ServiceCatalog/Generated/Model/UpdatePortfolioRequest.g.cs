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

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePortfolio operation. Updates the specified
    /// portfolio. <para> You cannot update a product that was shared with you. </para>
    /// </summary>
    public partial class UpdatePortfolioRequest : AmazonServiceCatalogRequest
    {
        /// <summary>
        /// Gets and sets the property AcceptLanguage. 
        /// <para>
        /// The language code.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>jp</c> - Japanese
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>zh</c> - Chinese
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// Checks to see if the AcceptLanguage property is set.
        /// </summary>
        internal bool IsSetAcceptLanguage() => this.AcceptLanguage != null;

        /// <summary>
        /// Gets and sets the property AddTags. 
        /// <para>
        /// The tags to add.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<Tag> AddTags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the AddTags property is set.
        /// </summary>
        internal bool IsSetAddTags() => this.AddTags != null && (this.AddTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description of the portfolio.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name to use for display purposes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The portfolio identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ProviderName. 
        /// <para>
        /// The updated name of the portfolio provider.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string ProviderName { get; set; }

        /// <summary>
        /// Checks to see if the ProviderName property is set.
        /// </summary>
        internal bool IsSetProviderName() => this.ProviderName != null;

        /// <summary>
        /// Gets and sets the property RemoveTags. 
        /// <para>
        /// The tags to remove.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RemoveTags { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RemoveTags property is set.
        /// </summary>
        internal bool IsSetRemoveTags() => this.RemoveTags != null && (this.RemoveTags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
