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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// A message in an Amazon Q Business web experience.
    /// </summary>
    public partial class Message
    {
        /// <summary>
        /// Gets and sets the property ActionExecution.
        /// </summary>
        public ActionExecution ActionExecution { get; set; }

        /// <summary>
        /// Checks to see if the ActionExecution property is set.
        /// </summary>
        internal bool IsSetActionExecution() => this.ActionExecution != null;

        /// <summary>
        /// Gets and sets the property ActionReview.
        /// </summary>
        public ActionReview ActionReview { get; set; }

        /// <summary>
        /// Checks to see if the ActionReview property is set.
        /// </summary>
        internal bool IsSetActionReview() => this.ActionReview != null;

        /// <summary>
        /// Gets and sets the property Attachments. 
        /// <para>
        /// A file directly uploaded into an Amazon Q Business web experience chat.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttachmentOutput> Attachments { get; set; } = AWSConfigs.InitializeCollections ? new List<AttachmentOutput>() : null;

        /// <summary>
        /// Checks to see if the Attachments property is set.
        /// </summary>
        internal bool IsSetAttachments() => this.Attachments != null && (this.Attachments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The content of the Amazon Q Business web experience message.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// The identifier of the Amazon Q Business web experience message.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string MessageId { get; set; }

        /// <summary>
        /// Checks to see if the MessageId property is set.
        /// </summary>
        internal bool IsSetMessageId() => this.MessageId != null;

        /// <summary>
        /// Gets and sets the property SourceAttribution. 
        /// <para>
        /// The source documents used to generate Amazon Q Business web experience message.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SourceAttribution> SourceAttribution { get; set; } = AWSConfigs.InitializeCollections ? new List<SourceAttribution>() : null;

        /// <summary>
        /// Checks to see if the SourceAttribution property is set.
        /// </summary>
        internal bool IsSetSourceAttribution() => this.SourceAttribution != null && (this.SourceAttribution.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        /// The timestamp of the first Amazon Q Business web experience message.
        /// </para>
        /// </summary>
        public DateTime? Time { get; set; }

        /// <summary>
        /// Checks to see if the Time property is set.
        /// </summary>
        internal bool IsSetTime() => this.Time.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of Amazon Q Business message, whether <c>HUMAN</c> or <c>AI</c> generated.
        /// </para>
        /// </summary>
        public MessageType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
