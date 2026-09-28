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

namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// Defines the complete structure and content of a template in Meta's library.
    /// </summary>
    public partial class MetaLibraryTemplateDefinition
    {
        /// <summary>
        /// Gets and sets the property TemplateBody. 
        /// <para>
        /// The body text of the template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// Checks to see if the TemplateBody property is set.
        /// </summary>
        internal bool IsSetTemplateBody() => this.TemplateBody != null;

        /// <summary>
        /// Gets and sets the property TemplateBodyExampleParams. 
        /// <para>
        /// Example parameter values for the template body, used to demonstrate how dynamic content
        /// appears in the template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TemplateBodyExampleParams { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TemplateBodyExampleParams property is set.
        /// </summary>
        internal bool IsSetTemplateBodyExampleParams() => this.TemplateBodyExampleParams != null && (this.TemplateBodyExampleParams.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TemplateButtons. 
        /// <para>
        /// The buttons included in the template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LibraryTemplateButtonList> TemplateButtons { get; set; } = AWSConfigs.InitializeCollections ? new List<LibraryTemplateButtonList>() : null;

        /// <summary>
        /// Checks to see if the TemplateButtons property is set.
        /// </summary>
        internal bool IsSetTemplateButtons() => this.TemplateButtons != null && (this.TemplateButtons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TemplateCategory. 
        /// <para>
        /// The category of the template (for example, UTILITY or MARKETING).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string TemplateCategory { get; set; }

        /// <summary>
        /// Checks to see if the TemplateCategory property is set.
        /// </summary>
        internal bool IsSetTemplateCategory() => this.TemplateCategory != null;

        /// <summary>
        /// Gets and sets the property TemplateHeader. 
        /// <para>
        /// The header text of the template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string TemplateHeader { get; set; }

        /// <summary>
        /// Checks to see if the TemplateHeader property is set.
        /// </summary>
        internal bool IsSetTemplateHeader() => this.TemplateHeader != null;

        /// <summary>
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// The ID of the template in Meta's library.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string TemplateId { get; set; }

        /// <summary>
        /// Checks to see if the TemplateId property is set.
        /// </summary>
        internal bool IsSetTemplateId() => this.TemplateId != null;

        /// <summary>
        /// Gets and sets the property TemplateIndustry. 
        /// <para>
        /// The industries the template is designed for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TemplateIndustry { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TemplateIndustry property is set.
        /// </summary>
        internal bool IsSetTemplateIndustry() => this.TemplateIndustry != null && (this.TemplateIndustry.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TemplateLanguage. 
        /// <para>
        /// The language code for the template (for example, en_US).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 6)]
        public string TemplateLanguage { get; set; }

        /// <summary>
        /// Checks to see if the TemplateLanguage property is set.
        /// </summary>
        internal bool IsSetTemplateLanguage() => this.TemplateLanguage != null;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;

        /// <summary>
        /// Gets and sets the property TemplateTopic. 
        /// <para>
        /// The topic or subject matter of the template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string TemplateTopic { get; set; }

        /// <summary>
        /// Checks to see if the TemplateTopic property is set.
        /// </summary>
        internal bool IsSetTemplateTopic() => this.TemplateTopic != null;

        /// <summary>
        /// Gets and sets the property TemplateUseCase. 
        /// <para>
        /// The intended use case for the template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 30)]
        public string TemplateUseCase { get; set; }

        /// <summary>
        /// Checks to see if the TemplateUseCase property is set.
        /// </summary>
        internal bool IsSetTemplateUseCase() => this.TemplateUseCase != null;
    }
}
