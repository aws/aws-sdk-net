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
    /// Summary information about the knowledge base.
    /// </summary>
    public partial class KnowledgeBaseSummary
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        /// Gets and sets the property KnowledgeBaseType. 
        /// <para>
        /// The type of knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public KnowledgeBaseType KnowledgeBaseType { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseType property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseType() => this.KnowledgeBaseType != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RenderingConfiguration. 
        /// <para>
        /// Information about how to render the content.
        /// </para>
        /// </summary>
        public RenderingConfiguration RenderingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RenderingConfiguration property is set.
        /// </summary>
        internal bool IsSetRenderingConfiguration() => this.RenderingConfiguration != null;

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionConfiguration. 
        /// <para>
        /// The configuration information for the customer managed key used for encryption. 
        /// </para>
        ///  
        /// <para>
        /// This KMS key must have a policy that allows <c>kms:CreateGrant</c>, <c>kms:DescribeKey</c>,
        /// <c>kms:Decrypt</c>, and <c>kms:GenerateDataKey*</c> permissions to the IAM identity
        /// using the key to invoke Amazon Q in Connect. 
        /// </para>
        ///  
        /// <para>
        /// For more information about setting up a customer managed key for Amazon Q in Connect,
        /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/enable-q.html">Enable
        /// Amazon Q in Connect for your instance</a>.
        /// </para>
        /// </summary>
        public ServerSideEncryptionConfiguration ServerSideEncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ServerSideEncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetServerSideEncryptionConfiguration() => this.ServerSideEncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property SourceConfiguration. 
        /// <para>
        /// Configuration information about the external data source.
        /// </para>
        /// </summary>
        public SourceConfiguration SourceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SourceConfiguration property is set.
        /// </summary>
        internal bool IsSetSourceConfiguration() => this.SourceConfiguration != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the knowledge base summary.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public KnowledgeBaseStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

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

        /// <summary>
        /// Gets and sets the property VectorIngestionConfiguration. 
        /// <para>
        /// Contains details about how to ingest the documents in a data source.
        /// </para>
        /// </summary>
        public VectorIngestionConfiguration VectorIngestionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VectorIngestionConfiguration property is set.
        /// </summary>
        internal bool IsSetVectorIngestionConfiguration() => this.VectorIngestionConfiguration != null;
    }
}
