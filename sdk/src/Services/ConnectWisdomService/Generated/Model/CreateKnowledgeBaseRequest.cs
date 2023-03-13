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
 * Do not modify this file. This file is generated from the wisdom-2020-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConnectWisdomService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateKnowledgeBase operation.
    /// Creates a knowledge base.
    /// 
    ///  <note> 
    /// <para>
    /// When using this API, you cannot reuse <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/Welcome.html">Amazon
    /// AppIntegrations</a> DataIntegrations with external knowledge bases such as Salesforce
    /// and ServiceNow. If you do, you'll get an <code>InvalidRequestException</code> error.
    /// 
    /// </para>
    ///  
    /// <para>
    /// For example, you're programmatically managing your external knowledge base, and you
    /// want to add or remove one of the fields that is being ingested from Salesforce. Do
    /// the following:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Call <a href="https://docs.aws.amazon.com/wisdom/latest/APIReference/API_DeleteKnowledgeBase.html">DeleteKnowledgeBase</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Call <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_DeleteDataIntegration.html">DeleteDataIntegration</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Call <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
    /// to recreate the DataIntegration or a create different one.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Call CreateKnowledgeBase.
    /// </para>
    ///  </li> </ol> </note>
    /// </summary>
    public partial class CreateKnowledgeBaseRequest : AmazonConnectWisdomServiceRequest
    {
        private string _clientToken;
        private string _description;
        private KnowledgeBaseType _knowledgeBaseType;
        private string _name;
        private RenderingConfiguration _renderingConfiguration;
        private ServerSideEncryptionConfiguration _serverSideEncryptionConfiguration;
        private SourceConfiguration _sourceConfiguration;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBaseType. 
        /// <para>
        /// The type of knowledge base. Only CUSTOM knowledge bases allow you to upload your own
        /// content. EXTERNAL knowledge bases support integrations with third-party systems whose
        /// content is synchronized automatically. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KnowledgeBaseType KnowledgeBaseType
        {
            get { return this._knowledgeBaseType; }
            set { this._knowledgeBaseType = value; }
        }

        // Check to see if KnowledgeBaseType property is set
        internal bool IsSetKnowledgeBaseType()
        {
            return this._knowledgeBaseType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RenderingConfiguration. 
        /// <para>
        /// Information about how to render the content.
        /// </para>
        /// </summary>
        public RenderingConfiguration RenderingConfiguration
        {
            get { return this._renderingConfiguration; }
            set { this._renderingConfiguration = value; }
        }

        // Check to see if RenderingConfiguration property is set
        internal bool IsSetRenderingConfiguration()
        {
            return this._renderingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionConfiguration. 
        /// <para>
        /// The KMS key used for encryption.
        /// </para>
        /// </summary>
        public ServerSideEncryptionConfiguration ServerSideEncryptionConfiguration
        {
            get { return this._serverSideEncryptionConfiguration; }
            set { this._serverSideEncryptionConfiguration = value; }
        }

        // Check to see if ServerSideEncryptionConfiguration property is set
        internal bool IsSetServerSideEncryptionConfiguration()
        {
            return this._serverSideEncryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SourceConfiguration. 
        /// <para>
        /// The source of the knowledge base content. Only set this argument for EXTERNAL knowledge
        /// bases.
        /// </para>
        /// </summary>
        public SourceConfiguration SourceConfiguration
        {
            get { return this._sourceConfiguration; }
            set { this._sourceConfiguration = value; }
        }

        // Check to see if SourceConfiguration property is set
        internal bool IsSetSourceConfiguration()
        {
            return this._sourceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}