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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
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
        private LibraryTemplateBodyInputs _libraryTemplateBodyInputs;
        private List<LibraryTemplateButtonInput> _libraryTemplateButtonInputs = AWSConfigs.InitializeCollections ? new List<LibraryTemplateButtonInput>() : null;
        private string _libraryTemplateName;
        private string _templateCategory;
        private string _templateLanguage;
        private string _templateName;

        /// <summary>
        /// Gets and sets the property LibraryTemplateBodyInputs. 
        /// <para>
        /// Body text customizations for the template.
        /// </para>
        /// </summary>
        public LibraryTemplateBodyInputs LibraryTemplateBodyInputs
        {
            get { return this._libraryTemplateBodyInputs; }
            set { this._libraryTemplateBodyInputs = value; }
        }

        // Check to see if LibraryTemplateBodyInputs property is set
        internal bool IsSetLibraryTemplateBodyInputs()
        {
            return this._libraryTemplateBodyInputs != null;
        }

        /// <summary>
        /// Gets and sets the property LibraryTemplateButtonInputs. 
        /// <para>
        /// Button customizations for the template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LibraryTemplateButtonInput> LibraryTemplateButtonInputs
        {
            get { return this._libraryTemplateButtonInputs; }
            set { this._libraryTemplateButtonInputs = value; }
        }

        // Check to see if LibraryTemplateButtonInputs property is set
        internal bool IsSetLibraryTemplateButtonInputs()
        {
            return this._libraryTemplateButtonInputs != null && (this._libraryTemplateButtonInputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LibraryTemplateName. 
        /// <para>
        /// The name of the template in Meta's library.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string LibraryTemplateName
        {
            get { return this._libraryTemplateName; }
            set { this._libraryTemplateName = value; }
        }

        // Check to see if LibraryTemplateName property is set
        internal bool IsSetLibraryTemplateName()
        {
            return this._libraryTemplateName != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateCategory. 
        /// <para>
        /// The category of the template (for example, UTILITY or MARKETING).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string TemplateCategory
        {
            get { return this._templateCategory; }
            set { this._templateCategory = value; }
        }

        // Check to see if TemplateCategory property is set
        internal bool IsSetTemplateCategory()
        {
            return this._templateCategory != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateLanguage. 
        /// <para>
        /// The language code for the template (for example, en_US).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=6)]
        public string TemplateLanguage
        {
            get { return this._templateLanguage; }
            set { this._templateLanguage = value; }
        }

        // Check to see if TemplateLanguage property is set
        internal bool IsSetTemplateLanguage()
        {
            return this._templateLanguage != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name to assign to the template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string TemplateName
        {
            get { return this._templateName; }
            set { this._templateName = value; }
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this._templateName != null;
        }

    }
}