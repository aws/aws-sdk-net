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

namespace Amazon.ConnectWisdomService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateKnowledgeBase operation. Creates a knowledge
    /// base. <note> <para> When using this API, you cannot reuse <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/Welcome.html">Amazon
    /// AppIntegrations</a> DataIntegrations with external knowledge bases such as Salesforce
    /// and ServiceNow. If you do, you'll get an <c>InvalidRequestException</c> error. </para>
    /// <para> For example, you're programmatically managing your external knowledge base,
    /// and you want to add or remove one of the fields that is being ingested from Salesforce.
    /// Do the following: </para> <ol> <li> <para> Call <a href="https://docs.aws.amazon.com/wisdom/latest/APIReference/API_DeleteKnowledgeBase.html">DeleteKnowledgeBase</a>.
    /// </para> </li> <li> <para> Call <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_DeleteDataIntegration.html">DeleteDataIntegration</a>.
    /// </para> </li> <li> <para> Call <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
    /// to recreate the DataIntegration or a create different one. </para> </li> <li> <para>
    /// Call CreateKnowledgeBase. </para> </li> </ol> </note>
    /// </summary>
    public partial class CreateKnowledgeBaseRequest : AmazonConnectWisdomServiceRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseType. 
        /// <para>
        /// The type of knowledge base. Only CUSTOM knowledge bases allow you to upload your own
        /// content. EXTERNAL knowledge bases support integrations with third-party systems whose
        /// content is synchronized automatically. 
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
        /// and <c>kms:Decrypt/kms:GenerateDataKey</c> permissions to the IAM identity using the
        /// key to invoke Wisdom.
        /// </para>
        ///  
        /// <para>
        /// For more information about setting up a customer managed key for Wisdom, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/enable-wisdom.html">Enable
        /// Amazon Connect Wisdom for your instance</a>.
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
        /// The source of the knowledge base content. Only set this argument for EXTERNAL knowledge
        /// bases.
        /// </para>
        /// </summary>
        public SourceConfiguration SourceConfiguration { get; set; }

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
