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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// This is the response object from the RenderMessageTemplate operation.
    /// </summary>
    public partial class RenderMessageTemplateResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Attachments. 
        /// <para>
        /// The message template attachments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MessageTemplateAttachment> Attachments { get; set; } = AWSConfigs.InitializeCollections ? new List<MessageTemplateAttachment>() : null;

        /// <summary>
        /// Checks to see if the Attachments property is set.
        /// </summary>
        internal bool IsSetAttachments() => this.Attachments != null && (this.Attachments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AttributesNotInterpolated. 
        /// <para>
        /// The attribute keys that are not resolved.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public List<string> AttributesNotInterpolated { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AttributesNotInterpolated property is set.
        /// </summary>
        internal bool IsSetAttributesNotInterpolated() => this.AttributesNotInterpolated != null && (this.AttributesNotInterpolated.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the message template.
        /// </para>
        /// </summary>
        public MessageTemplateContentProvider Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property SourceConfigurationSummary. 
        /// <para>
        /// The source configuration of the message template.
        /// </para>
        /// </summary>
        public MessageTemplateSourceConfigurationSummary SourceConfigurationSummary { get; set; }

        /// <summary>
        /// Checks to see if the SourceConfigurationSummary property is set.
        /// </summary>
        internal bool IsSetSourceConfigurationSummary() => this.SourceConfigurationSummary != null;
    }
}
