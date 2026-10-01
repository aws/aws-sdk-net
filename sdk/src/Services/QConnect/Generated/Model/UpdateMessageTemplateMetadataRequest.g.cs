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
    /// Container for the parameters to the UpdateMessageTemplateMetadata operation. Updates
    /// the Amazon Q in Connect message template metadata. Note that any modification to the
    /// message template’s name, description and grouping configuration will applied to the
    /// message template pointed by the <c>$LATEST</c> qualifier and all available versions.
    /// Partial update is supported. If any field is not supplied, it will remain unchanged
    /// for the message template.
    /// </summary>
    public partial class UpdateMessageTemplateMetadataRequest : AmazonQConnectRequest
    {
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
        /// Gets and sets the property MessageTemplateId. 
        /// <para>
        /// The identifier of the message template. Can be either the ID or the ARN. It cannot
        /// contain any qualifier.
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
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
