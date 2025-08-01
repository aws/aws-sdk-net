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
    /// Provides a summary of a WhatsApp message template's key attributes.
    /// </summary>
    public partial class TemplateSummary
    {
        private string _metaTemplateId;
        private string _templateCategory;
        private string _templateLanguage;
        private string _templateName;
        private string _templateQualityScore;
        private string _templateStatus;

        /// <summary>
        /// Gets and sets the property MetaTemplateId. 
        /// <para>
        /// The numeric ID assigned to the template by Meta.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string MetaTemplateId
        {
            get { return this._metaTemplateId; }
            set { this._metaTemplateId = value; }
        }

        // Check to see if MetaTemplateId property is set
        internal bool IsSetMetaTemplateId()
        {
            return this._metaTemplateId != null;
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
        /// Gets and sets the property TemplateLanguage. 
        /// <para>
        /// The language code of the template (for example, en_US).
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
        /// Gets and sets the property TemplateQualityScore. 
        /// <para>
        /// The quality score assigned to the template by Meta.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string TemplateQualityScore
        {
            get { return this._templateQualityScore; }
            set { this._templateQualityScore = value; }
        }

        // Check to see if TemplateQualityScore property is set
        internal bool IsSetTemplateQualityScore()
        {
            return this._templateQualityScore != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateStatus. 
        /// <para>
        /// The current status of the template (for example, APPROVED, PENDING, or REJECTED).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string TemplateStatus
        {
            get { return this._templateStatus; }
            set { this._templateStatus = value; }
        }

        // Check to see if TemplateStatus property is set
        internal bool IsSetTemplateStatus()
        {
            return this._templateStatus != null;
        }

    }
}