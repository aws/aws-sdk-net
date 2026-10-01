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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Typed content structure for a context. Contains application-specific fields that describe
    /// the environment used during recommendation generation.
    /// </summary>
    public partial class ContextContent
    {
        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// The Amazon Web Services account IDs associated with this application context.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 1000)]
        public List<string> AccountIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AccountIds property is set.
        /// </summary>
        internal bool IsSetAccountIds() => this.AccountIds != null && (this.AccountIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AdditionalContext. 
        /// <para>
        /// Additional context not captured by other fields.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 10000)]
        public string AdditionalContext { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalContext property is set.
        /// </summary>
        internal bool IsSetAdditionalContext() => this.AdditionalContext != null;

        /// <summary>
        /// Gets and sets the property ApplicationOverview. 
        /// <para>
        /// A free-form overview of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 10000)]
        public string ApplicationOverview { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationOverview property is set.
        /// </summary>
        internal bool IsSetApplicationOverview() => this.ApplicationOverview != null;

        /// <summary>
        /// Gets and sets the property ApplicationType. 
        /// <para>
        /// The type of the application.
        /// </para>
        /// </summary>
        public ApplicationType ApplicationType { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationType property is set.
        /// </summary>
        internal bool IsSetApplicationType() => this.ApplicationType != null;

        /// <summary>
        /// Gets and sets the property ArchitectureOverview. 
        /// <para>
        /// A free-form description of the application architecture.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 10000)]
        public string ArchitectureOverview { get; set; }

        /// <summary>
        /// Checks to see if the ArchitectureOverview property is set.
        /// </summary>
        internal bool IsSetArchitectureOverview() => this.ArchitectureOverview != null;

        /// <summary>
        /// Gets and sets the property AwsServices. 
        /// <para>
        /// The Amazon Web Services services used by this application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 300)]
        public List<string> AwsServices { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AwsServices property is set.
        /// </summary>
        internal bool IsSetAwsServices() => this.AwsServices != null && (this.AwsServices.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Criticality. 
        /// <para>
        /// The business criticality of the application.
        /// </para>
        /// </summary>
        public Criticality Criticality { get; set; }

        /// <summary>
        /// Checks to see if the Criticality property is set.
        /// </summary>
        internal bool IsSetCriticality() => this.Criticality != null;

        /// <summary>
        /// Gets and sets the property Industry. 
        /// <para>
        /// The industry vertical for this application.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 1000)]
        public string Industry { get; set; }

        /// <summary>
        /// Checks to see if the Industry property is set.
        /// </summary>
        internal bool IsSetIndustry() => this.Industry != null;

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// The Amazon Web Services Regions where this application operates.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public List<string> Regions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Regions property is set.
        /// </summary>
        internal bool IsSetRegions() => this.Regions != null && (this.Regions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// Resource tags used to scope this application context.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<ContextResourceTag> ResourceTags { get; set; } = AWSConfigs.InitializeCollections ? new List<ContextResourceTag>() : null;

        /// <summary>
        /// Checks to see if the ResourceTags property is set.
        /// </summary>
        internal bool IsSetResourceTags() => this.ResourceTags != null && (this.ResourceTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// The Amazon Web Services resource types relevant to this application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 1500)]
        public List<string> ResourceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourceTypes property is set.
        /// </summary>
        internal bool IsSetResourceTypes() => this.ResourceTypes != null && (this.ResourceTypes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
