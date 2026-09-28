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
    /// Container for the parameters to the GetMessageTemplate operation. Retrieves the Amazon
    /// Q in Connect message template. The message template identifier can contain an optional
    /// qualifier, for example, <c>&lt;message-template-id&gt;:&lt;qualifier&gt;</c>, which
    /// is either an actual version number or an Amazon Q Connect managed qualifier <c>$ACTIVE_VERSION</c>
    /// | <c>$LATEST</c>. If it is not supplied, then <c>$LATEST</c> is assumed implicitly.
    /// </summary>
    public partial class GetMessageTemplateRequest : AmazonQConnectRequest
    {
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
        /// Gets and sets the property MessageTemplateId. 
        /// <para>
        /// The identifier of the message template. Can be either the ID or the ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MessageTemplateId { get; set; }

        /// <summary>
        /// Checks to see if the MessageTemplateId property is set.
        /// </summary>
        internal bool IsSetMessageTemplateId() => this.MessageTemplateId != null;
    }
}
