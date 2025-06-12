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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
    /// Container for the parameters to the CreateContentAssociation operation.
    /// Creates an association between a content resource in a knowledge base and <a href="https://docs.aws.amazon.com/connect/latest/adminguide/step-by-step-guided-experiences.html">step-by-step
    /// guides</a>. Step-by-step guides offer instructions to agents for resolving common
    /// customer issues. You create a content association to integrate Amazon Q in Connect
    /// and step-by-step guides. 
    /// 
    ///  
    /// <para>
    /// After you integrate Amazon Q and step-by-step guides, when Amazon Q provides a recommendation
    /// to an agent based on the intent that it's detected, it also provides them with the
    /// option to start the step-by-step guide that you have associated with the content.
    /// </para>
    ///  
    /// <para>
    /// Note the following limitations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You can create only one content association for each content resource in a knowledge
    /// base.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can associate a step-by-step guide with multiple content resources.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/integrate-q-with-guides.html">Integrate
    /// Amazon Q in Connect with step-by-step guides</a> in the <i>Amazon Connect Administrator
    /// Guide</i>. 
    /// </para>
    /// </summary>
    public partial class CreateContentAssociationRequest : AmazonQConnectRequest
    {
        private ContentAssociationContents _association;
        private ContentAssociationType _associationType;
        private string _clientToken;
        private string _contentId;
        private string _knowledgeBaseId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Association. 
        /// <para>
        /// The identifier of the associated resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContentAssociationContents Association
        {
            get { return this._association; }
            set { this._association = value; }
        }

        // Check to see if Association property is set
        internal bool IsSetAssociation()
        {
            return this._association != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationType. 
        /// <para>
        /// The type of association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContentAssociationType AssociationType
        {
            get { return this._associationType; }
            set { this._associationType = value; }
        }

        // Check to see if AssociationType property is set
        internal bool IsSetAssociationType()
        {
            return this._associationType != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="http://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
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
        /// Gets and sets the property ContentId. 
        /// <para>
        /// The identifier of the content.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ContentId
        {
            get { return this._contentId; }
            set { this._contentId = value; }
        }

        // Check to see if ContentId property is set
        internal bool IsSetContentId()
        {
            return this._contentId != null;
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The identifier of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string KnowledgeBaseId
        {
            get { return this._knowledgeBaseId; }
            set { this._knowledgeBaseId = value; }
        }

        // Check to see if KnowledgeBaseId property is set
        internal bool IsSetKnowledgeBaseId()
        {
            return this._knowledgeBaseId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}