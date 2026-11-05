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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Provides information about a message template that's associated with your Amazon Pinpoint
    /// account.
    /// </summary>
    public partial class TemplateResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the message template. This value isn't included
        /// in a TemplateResponse object. To retrieve the ARN of a template, use the GetEmailTemplate,
        /// GetPushTemplate, GetSmsTemplate, or GetVoiceTemplate operation, depending on the type
        /// of template that you want to retrieve the ARN for.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date, in ISO 8601 format, when the message template was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate != null;

        /// <summary>
        /// Gets and sets the property DefaultSubstitutions. 
        /// <para>
        /// The JSON object that specifies the default values that are used for message variables
        /// in the message template. This object isn't included in a TemplateResponse object.
        /// To retrieve this object for a template, use the GetEmailTemplate, GetPushTemplate,
        /// GetSmsTemplate, or GetVoiceTemplate operation, depending on the type of template that
        /// you want to retrieve the object for.
        /// </para>
        /// </summary>
        public string DefaultSubstitutions { get; set; }

        /// <summary>
        /// Checks to see if the DefaultSubstitutions property is set.
        /// </summary>
        internal bool IsSetDefaultSubstitutions() => this.DefaultSubstitutions != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date, in ISO 8601 format, when the message template was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of key-value pairs that identifies the tags that are associated with the message
        /// template. This object isn't included in a TemplateResponse object. To retrieve this
        /// object for a template, use the GetEmailTemplate, GetPushTemplate, GetSmsTemplate,
        /// or GetVoiceTemplate operation, depending on the type of template that you want to
        /// retrieve the object for.
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
        /// The custom description of the message template. This value isn't included in a TemplateResponse
        /// object. To retrieve the description of a template, use the GetEmailTemplate, GetPushTemplate,
        /// GetSmsTemplate, or GetVoiceTemplate operation, depending on the type of template that
        /// you want to retrieve the description for.
        /// </para>
        /// </summary>
        public string TemplateDescription { get; set; }

        /// <summary>
        /// Checks to see if the TemplateDescription property is set.
        /// </summary>
        internal bool IsSetTemplateDescription() => this.TemplateDescription != null;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the message template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;

        /// <summary>
        /// Gets and sets the property TemplateType. 
        /// <para>
        /// The type of channel that the message template is designed for. Possible values are:
        /// EMAIL, PUSH, SMS, INAPP, and VOICE.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TemplateType TemplateType { get; set; }

        /// <summary>
        /// Checks to see if the TemplateType property is set.
        /// </summary>
        internal bool IsSetTemplateType() => this.TemplateType != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The unique identifier, as an integer, for the active version of the message template.
        /// </para>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
