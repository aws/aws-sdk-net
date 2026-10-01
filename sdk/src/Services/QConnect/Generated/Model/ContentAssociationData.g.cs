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
    /// Information about the content association.
    /// </summary>
    public partial class ContentAssociationData
    {
        /// <summary>
        /// Gets and sets the property AssociationData. 
        /// <para>
        /// The content association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ContentAssociationContents AssociationData { get; set; }

        /// <summary>
        /// Checks to see if the AssociationData property is set.
        /// </summary>
        internal bool IsSetAssociationData() => this.AssociationData != null;

        /// <summary>
        /// Gets and sets the property AssociationType. 
        /// <para>
        /// The type of association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ContentAssociationType AssociationType { get; set; }

        /// <summary>
        /// Checks to see if the AssociationType property is set.
        /// </summary>
        internal bool IsSetAssociationType() => this.AssociationType != null;

        /// <summary>
        /// Gets and sets the property ContentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the content.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ContentArn { get; set; }

        /// <summary>
        /// Checks to see if the ContentArn property is set.
        /// </summary>
        internal bool IsSetContentArn() => this.ContentArn != null;

        /// <summary>
        /// Gets and sets the property ContentAssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the content association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ContentAssociationArn { get; set; }

        /// <summary>
        /// Checks to see if the ContentAssociationArn property is set.
        /// </summary>
        internal bool IsSetContentAssociationArn() => this.ContentAssociationArn != null;

        /// <summary>
        /// Gets and sets the property ContentAssociationId. 
        /// <para>
        /// The identifier of the content association. Can be either the ID or the ARN. URLs cannot
        /// contain the ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ContentAssociationId { get; set; }

        /// <summary>
        /// Checks to see if the ContentAssociationId property is set.
        /// </summary>
        internal bool IsSetContentAssociationId() => this.ContentAssociationId != null;

        /// <summary>
        /// Gets and sets the property ContentId. 
        /// <para>
        /// The identifier of the content.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ContentId { get; set; }

        /// <summary>
        /// Checks to see if the ContentId property is set.
        /// </summary>
        internal bool IsSetContentId() => this.ContentId != null;

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
