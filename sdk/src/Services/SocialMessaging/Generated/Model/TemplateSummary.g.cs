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
    /// Provides a summary of a WhatsApp message template's key attributes.
    /// </summary>
    public partial class TemplateSummary
    {
        /// <summary>
        /// Gets and sets the property CorrectCategory. 
        /// <para>
        /// The category that the template content actually belongs to, when it differs from the
        /// template's current category. This field is present only when the template has been
        /// flagged as miscategorized.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string CorrectCategory { get; set; }

        /// <summary>
        /// Checks to see if the CorrectCategory property is set.
        /// </summary>
        internal bool IsSetCorrectCategory() => this.CorrectCategory != null;

        /// <summary>
        /// Gets and sets the property MetaTemplateId. 
        /// <para>
        /// The numeric ID assigned to the template by Meta.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string MetaTemplateId { get; set; }

        /// <summary>
        /// Checks to see if the MetaTemplateId property is set.
        /// </summary>
        internal bool IsSetMetaTemplateId() => this.MetaTemplateId != null;

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
        /// Gets and sets the property TemplateLanguage. 
        /// <para>
        /// The language code of the template (for example, en_US).
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
        /// Gets and sets the property TemplateQualityScore. 
        /// <para>
        /// The quality score assigned to the template by Meta.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string TemplateQualityScore { get; set; }

        /// <summary>
        /// Checks to see if the TemplateQualityScore property is set.
        /// </summary>
        internal bool IsSetTemplateQualityScore() => this.TemplateQualityScore != null;

        /// <summary>
        /// Gets and sets the property TemplateSource. 
        /// <para>
        /// The source of the template. A value of AUTO_GENERATED indicates that the template
        /// was created automatically from a message that you sent. This field is not present
        /// for templates that you created manually.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string TemplateSource { get; set; }

        /// <summary>
        /// Checks to see if the TemplateSource property is set.
        /// </summary>
        internal bool IsSetTemplateSource() => this.TemplateSource != null;

        /// <summary>
        /// Gets and sets the property TemplateStatus. 
        /// <para>
        /// The current status of the template (for example, APPROVED, PENDING, or REJECTED).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string TemplateStatus { get; set; }

        /// <summary>
        /// Checks to see if the TemplateStatus property is set.
        /// </summary>
        internal bool IsSetTemplateStatus() => this.TemplateStatus != null;
    }
}
