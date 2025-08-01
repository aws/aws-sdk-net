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
    /// Defines the complete structure and content of a template in Meta's library.
    /// </summary>
    public partial class MetaLibraryTemplateDefinition
    {
        private string _templateBody;
        private List<LibraryTemplateButtonList> _templateButtons = AWSConfigs.InitializeCollections ? new List<LibraryTemplateButtonList>() : null;
        private string _templateCategory;
        private string _templateHeader;
        private string _templateId;
        private List<string> _templateIndustry = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _templateLanguage;
        private string _templateName;
        private string _templateTopic;
        private string _templateUseCase;

        /// <summary>
        /// Gets and sets the property TemplateBody. 
        /// <para>
        /// The body text of the template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string TemplateBody
        {
            get { return this._templateBody; }
            set { this._templateBody = value; }
        }

        // Check to see if TemplateBody property is set
        internal bool IsSetTemplateBody()
        {
            return this._templateBody != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateButtons. 
        /// <para>
        /// The buttons included in the template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LibraryTemplateButtonList> TemplateButtons
        {
            get { return this._templateButtons; }
            set { this._templateButtons = value; }
        }

        // Check to see if TemplateButtons property is set
        internal bool IsSetTemplateButtons()
        {
            return this._templateButtons != null && (this._templateButtons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TemplateCategory. 
        /// <para>
        /// The category of the template (for example, UTILITY or MARKETING).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property TemplateHeader. 
        /// <para>
        /// The header text of the template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string TemplateHeader
        {
            get { return this._templateHeader; }
            set { this._templateHeader = value; }
        }

        // Check to see if TemplateHeader property is set
        internal bool IsSetTemplateHeader()
        {
            return this._templateHeader != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// The ID of the template in Meta's library.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string TemplateId
        {
            get { return this._templateId; }
            set { this._templateId = value; }
        }

        // Check to see if TemplateId property is set
        internal bool IsSetTemplateId()
        {
            return this._templateId != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateIndustry. 
        /// <para>
        /// The industries the template is designed for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TemplateIndustry
        {
            get { return this._templateIndustry; }
            set { this._templateIndustry = value; }
        }

        // Check to see if TemplateIndustry property is set
        internal bool IsSetTemplateIndustry()
        {
            return this._templateIndustry != null && (this._templateIndustry.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TemplateLanguage. 
        /// <para>
        /// The language code for the template (for example, en_US).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=6)]
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
        /// The name of the template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
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

        /// <summary>
        /// Gets and sets the property TemplateTopic. 
        /// <para>
        /// The topic or subject matter of the template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string TemplateTopic
        {
            get { return this._templateTopic; }
            set { this._templateTopic = value; }
        }

        // Check to see if TemplateTopic property is set
        internal bool IsSetTemplateTopic()
        {
            return this._templateTopic != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateUseCase. 
        /// <para>
        /// The intended use case for the template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=30)]
        public string TemplateUseCase
        {
            get { return this._templateUseCase; }
            set { this._templateUseCase = value; }
        }

        // Check to see if TemplateUseCase property is set
        internal bool IsSetTemplateUseCase()
        {
            return this._templateUseCase != null;
        }

    }
}