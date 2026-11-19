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

namespace Amazon.PartnerCentralMarketing.Model
{
    /// <summary>
    /// Container for the parameters to the SearchCampaignTemplates operation. Searches and
    /// browses the AWS-authored campaign template catalog. With no SearchText it returns
    /// the whole catalog in the default order, so browse and keyword search share one shape;
    /// GetCampaignTemplate reads one template.
    /// </summary>
    public partial class SearchCampaignTemplatesRequest : AmazonPartnerCentralMarketingRequest
    {
        /// <summary>
        /// Gets and sets the property AwsServices. Restrict to templates promoting these AWS
        /// services. Values within this member are OR-ed; distinct facet members are AND-ed.
        /// Exact, case-sensitive match.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<string> AwsServices { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AwsServices property is set.
        /// </summary>
        internal bool IsSetAwsServices() => this.AwsServices != null && (this.AwsServices.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Catalog. The catalog (AWS or Sandbox). AWS and Sandbox
        /// templates may differ.
        /// </summary>
        [AWSProperty(Required = true)]
        public Catalog Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property Collection. Restrict to templates in these collections.
        /// Values within this member are OR-ed; distinct facet members are AND-ed. Omit for no
        /// restriction; there is no default.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<string> Collection { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Collection property is set.
        /// </summary>
        internal bool IsSetCollection() => this.Collection != null && (this.Collection.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CustomerSegments. Restrict to templates for these customer
        /// segments. Values within this member are OR-ed; distinct facet members are AND-ed.
        /// A template that names no customer segment matches every value.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<string> CustomerSegments { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CustomerSegments property is set.
        /// </summary>
        internal bool IsSetCustomerSegments() => this.CustomerSegments != null && (this.CustomerSegments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Industry. Restrict to templates in these industries. Values
        /// within this member are OR-ed; distinct facet members are AND-ed. Exact, case-sensitive
        /// match.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<string> Industry { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Industry property is set.
        /// </summary>
        internal bool IsSetIndustry() => this.Industry != null && (this.Industry.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Language. Restrict to templates in these language(s), matched
        /// by each template's `LanguageCode`. Values within this member are OR-ed; distinct facet
        /// members are AND-ed. Narrows results; it does not reinterpret SearchText.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<string> Language { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Language property is set.
        /// </summary>
        internal bool IsSetLanguage() => this.Language != null && (this.Language.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. Maximum results per page.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. Pagination token.
        /// </summary>
        [AWSProperty(Min = 1, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SearchText. Free-text query matched against the template's
        /// name and description. Any word may match, and the last word matches as a prefix when
        /// it has 3 or more characters, so `nov` finds Amazon Nova. A template whose name holds
        /// the query as a phrase ranks first, then whole-word matches, then prefix-only ones.
        /// Omit to browse the whole catalog. Text analysis is derived from each template's own
        /// LanguageCode, never from the language filter.
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string SearchText { get; set; }

        /// <summary>
        /// Checks to see if the SearchText property is set.
        /// </summary>
        internal bool IsSetSearchText() => this.SearchText != null;

        /// <summary>
        /// Gets and sets the property Themes. Restrict to templates with these themes. Values
        /// within this member are OR-ed; distinct facet members are AND-ed. A template that names
        /// no theme matches every value.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<string> Themes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Themes property is set.
        /// </summary>
        internal bool IsSetThemes() => this.Themes != null && (this.Themes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UseCase. Restrict to templates with these campaign use
        /// cases. Values within this member are OR-ed; distinct facet members are AND-ed. Exact,
        /// case-sensitive match.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<string> UseCase { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the UseCase property is set.
        /// </summary>
        internal bool IsSetUseCase() => this.UseCase != null && (this.UseCase.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
