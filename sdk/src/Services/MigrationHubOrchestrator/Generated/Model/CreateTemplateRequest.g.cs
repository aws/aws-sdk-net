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

namespace Amazon.MigrationHubOrchestrator.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTemplate operation. Creates a migration
    /// workflow template.
    /// </summary>
    public partial class CreateTemplateRequest : AmazonMigrationHubOrchestratorRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. For more information, see <a href="https://smithy.io/2.0/spec/behavior-traits.html#idempotencytoken-trait">Idempotency</a>
        /// in the Smithy documentation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to add to the migration workflow template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TemplateDescription. 
        /// <para>
        /// A description of the migration workflow template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 250)]
        public string TemplateDescription { get; set; }

        /// <summary>
        /// Checks to see if the TemplateDescription property is set.
        /// </summary>
        internal bool IsSetTemplateDescription() => this.TemplateDescription != null;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the migration workflow template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;

        /// <summary>
        /// Gets and sets the property TemplateSource. 
        /// <para>
        /// The source of the migration workflow template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TemplateSource TemplateSource { get; set; }

        /// <summary>
        /// Checks to see if the TemplateSource property is set.
        /// </summary>
        internal bool IsSetTemplateSource() => this.TemplateSource != null;
    }
}
