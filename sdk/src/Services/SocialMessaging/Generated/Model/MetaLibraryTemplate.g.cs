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
    /// Represents a template from Meta's library with customization options.
    /// </summary>
    public partial class MetaLibraryTemplate
    {
        /// <summary>
        /// Gets and sets the property LibraryTemplateBodyInputs. 
        /// <para>
        /// Body text customizations for the template.
        /// </para>
        /// </summary>
        public LibraryTemplateBodyInputs LibraryTemplateBodyInputs { get; set; }

        /// <summary>
        /// Checks to see if the LibraryTemplateBodyInputs property is set.
        /// </summary>
        internal bool IsSetLibraryTemplateBodyInputs() => this.LibraryTemplateBodyInputs != null;

        /// <summary>
        /// Gets and sets the property LibraryTemplateButtonInputs. 
        /// <para>
        /// Button customizations for the template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LibraryTemplateButtonInput> LibraryTemplateButtonInputs { get; set; } = AWSConfigs.InitializeCollections ? new List<LibraryTemplateButtonInput>() : null;

        /// <summary>
        /// Checks to see if the LibraryTemplateButtonInputs property is set.
        /// </summary>
        internal bool IsSetLibraryTemplateButtonInputs() => this.LibraryTemplateButtonInputs != null && (this.LibraryTemplateButtonInputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LibraryTemplateName. 
        /// <para>
        /// The name of the template in Meta's library.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string LibraryTemplateName { get; set; }

        /// <summary>
        /// Checks to see if the LibraryTemplateName property is set.
        /// </summary>
        internal bool IsSetLibraryTemplateName() => this.LibraryTemplateName != null;

        /// <summary>
        /// Gets and sets the property TemplateCategory. 
        /// <para>
        /// The category of the template (for example, UTILITY or MARKETING).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string TemplateCategory { get; set; }

        /// <summary>
        /// Checks to see if the TemplateCategory property is set.
        /// </summary>
        internal bool IsSetTemplateCategory() => this.TemplateCategory != null;

        /// <summary>
        /// Gets and sets the property TemplateLanguage. 
        /// <para>
        /// The language code for the template (for example, en_US).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 6)]
        public string TemplateLanguage { get; set; }

        /// <summary>
        /// Checks to see if the TemplateLanguage property is set.
        /// </summary>
        internal bool IsSetTemplateLanguage() => this.TemplateLanguage != null;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name to assign to the template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;
    }
}
