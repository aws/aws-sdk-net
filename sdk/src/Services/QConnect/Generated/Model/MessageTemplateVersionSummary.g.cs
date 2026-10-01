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
    /// The summary of the message template version.
    /// </summary>
    public partial class MessageTemplateVersionSummary
    {
        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// The channel of the message template.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 10)]
        public string Channel { get; set; }

        /// <summary>
        /// Checks to see if the Channel property is set.
        /// </summary>
        internal bool IsSetChannel() => this.Channel != null;

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
        /// Gets and sets the property IsActive. 
        /// <para>
        /// Whether the version of the message template is activated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Checks to see if the IsActive property is set.
        /// </summary>
        internal bool IsSetIsActive() => this.IsActive.HasValue;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string KnowledgeBaseArn { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseArn property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseArn() => this.KnowledgeBaseArn != null;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The identifier of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseId property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseId() => this.KnowledgeBaseId != null;

        /// <summary>
        /// Gets and sets the property MessageTemplateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the message template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MessageTemplateArn { get; set; }

        /// <summary>
        /// Checks to see if the MessageTemplateArn property is set.
        /// </summary>
        internal bool IsSetMessageTemplateArn() => this.MessageTemplateArn != null;

        /// <summary>
        /// Gets and sets the property MessageTemplateId. 
        /// <para>
        /// The identifier of the message template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MessageTemplateId { get; set; }

        /// <summary>
        /// Checks to see if the MessageTemplateId property is set.
        /// </summary>
        internal bool IsSetMessageTemplateId() => this.MessageTemplateId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the message template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// The version number of the message template version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public long? VersionNumber { get; set; }

        /// <summary>
        /// Checks to see if the VersionNumber property is set.
        /// </summary>
        internal bool IsSetVersionNumber() => this.VersionNumber.HasValue;
    }
}
