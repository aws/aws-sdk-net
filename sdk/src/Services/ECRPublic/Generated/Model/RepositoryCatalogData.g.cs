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

namespace Amazon.ECRPublic.Model
{
    /// <summary>
    /// The catalog data for a repository. This data is publicly visible in the Amazon ECR
    /// Public Gallery.
    /// </summary>
    public partial class RepositoryCatalogData
    {
        /// <summary>
        /// Gets and sets the property AboutText. 
        /// <para>
        /// The longform description of the contents of the repository. This text appears in the
        /// repository details on the Amazon ECR Public Gallery.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 25600)]
        public string AboutText { get; set; }

        /// <summary>
        /// Checks to see if the AboutText property is set.
        /// </summary>
        internal bool IsSetAboutText() => this.AboutText != null;

        /// <summary>
        /// Gets and sets the property Architectures. 
        /// <para>
        /// The architecture tags that are associated with the repository.
        /// </para>
        ///  <note> 
        /// <para>
        /// Only supported operating system tags appear publicly in the Amazon ECR Public Gallery.
        /// For more information, see <a>RepositoryCatalogDataInput</a>.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> Architectures { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Architectures property is set.
        /// </summary>
        internal bool IsSetArchitectures() => this.Architectures != null && (this.Architectures.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The short description of the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LogoUrl. 
        /// <para>
        /// The URL that contains the logo that's associated with the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// Checks to see if the LogoUrl property is set.
        /// </summary>
        internal bool IsSetLogoUrl() => this.LogoUrl != null;

        /// <summary>
        /// Gets and sets the property MarketplaceCertified. 
        /// <para>
        /// Indicates whether the repository is certified by Amazon Web Services Marketplace.
        /// </para>
        /// </summary>
        public bool? MarketplaceCertified { get; set; }

        /// <summary>
        /// Checks to see if the MarketplaceCertified property is set.
        /// </summary>
        internal bool IsSetMarketplaceCertified() => this.MarketplaceCertified.HasValue;

        /// <summary>
        /// Gets and sets the property OperatingSystems. 
        /// <para>
        /// The operating system tags that are associated with the repository.
        /// </para>
        ///  <note> 
        /// <para>
        /// Only supported operating system tags appear publicly in the Amazon ECR Public Gallery.
        /// For more information, see <a>RepositoryCatalogDataInput</a>.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> OperatingSystems { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OperatingSystems property is set.
        /// </summary>
        internal bool IsSetOperatingSystems() => this.OperatingSystems != null && (this.OperatingSystems.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UsageText. 
        /// <para>
        /// The longform usage details of the contents of the repository. The usage text provides
        /// context for users of the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 25600)]
        public string UsageText { get; set; }

        /// <summary>
        /// Checks to see if the UsageText property is set.
        /// </summary>
        internal bool IsSetUsageText() => this.UsageText != null;
    }
}
