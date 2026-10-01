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
    /// Container for the parameters to the CreateMessageTemplate operation. Creates an Amazon
    /// Q in Connect message template. The name of the message template has to be unique for
    /// each knowledge base. The channel subtype of the message template is immutable and
    /// cannot be modified after creation. After the message template is created, you can
    /// use the <c>$LATEST</c> qualifier to reference the created message template.
    /// </summary>
    public partial class CreateMessageTemplateRequest : AmazonQConnectRequest
    {
        /// <summary>
        /// Gets and sets the property ChannelSubtype. 
        /// <para>
        /// The channel subtype this message template applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ChannelSubtype ChannelSubtype { get; set; }

        /// <summary>
        /// Checks to see if the ChannelSubtype property is set.
        /// </summary>
        internal bool IsSetChannelSubtype() => this.ChannelSubtype != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="http://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

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
        /// Gets and sets the property DefaultAttributes. 
        /// <para>
        /// An object that specifies the default values to use for variables in the message template.
        /// This object contains different categories of key-value pairs. Each key defines a variable
        /// or placeholder in the message template. The corresponding value defines the default
        /// value for that variable.
        /// </para>
        /// </summary>
        public MessageTemplateAttributes DefaultAttributes { get; set; }

        /// <summary>
        /// Checks to see if the DefaultAttributes property is set.
        /// </summary>
        internal bool IsSetDefaultAttributes() => this.DefaultAttributes != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the message template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property GroupingConfiguration.
        /// </summary>
        public GroupingConfiguration GroupingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the GroupingConfiguration property is set.
        /// </summary>
        internal bool IsSetGroupingConfiguration() => this.GroupingConfiguration != null;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The identifier of the knowledge base. Can be either the ID or the ARN. URLs cannot
        /// contain the ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseId property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseId() => this.KnowledgeBaseId != null;

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The language code value for the language in which the quick response is written. The
        /// supported language codes include <c>de_DE</c>, <c>en_US</c>, <c>es_ES</c>, <c>fr_FR</c>,
        /// <c>id_ID</c>, <c>it_IT</c>, <c>ja_JP</c>, <c>ko_KR</c>, <c>pt_BR</c>, <c>zh_CN</c>,
        /// <c>zh_TW</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 5)]
        public string Language { get; set; }

        /// <summary>
        /// Checks to see if the Language property is set.
        /// </summary>
        internal bool IsSetLanguage() => this.Language != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the message template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SourceConfiguration. 
        /// <para>
        /// The source configuration of the message template. Only set this argument for WHATSAPP
        /// channel subtype.
        /// </para>
        /// </summary>
        public MessageTemplateSourceConfiguration SourceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SourceConfiguration property is set.
        /// </summary>
        internal bool IsSetSourceConfiguration() => this.SourceConfiguration != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource.
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
    }
}
