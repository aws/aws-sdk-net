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
    /// Information about the content association.
    /// </summary>
    public partial class ContentAssociationData
    {
        private ContentAssociationContents _associationData;
        private ContentAssociationType _associationType;
        private string _contentArn;
        private string _contentAssociationArn;
        private string _contentAssociationId;
        private string _contentId;
        private string _knowledgeBaseArn;
        private string _knowledgeBaseId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AssociationData. 
        /// <para>
        /// The content association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContentAssociationContents AssociationData
        {
            get { return this._associationData; }
            set { this._associationData = value; }
        }

        // Check to see if AssociationData property is set
        internal bool IsSetAssociationData()
        {
            return this._associationData != null;
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
        /// Gets and sets the property ContentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the content.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ContentArn
        {
            get { return this._contentArn; }
            set { this._contentArn = value; }
        }

        // Check to see if ContentArn property is set
        internal bool IsSetContentArn()
        {
            return this._contentArn != null;
        }

        /// <summary>
        /// Gets and sets the property ContentAssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the content association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ContentAssociationArn
        {
            get { return this._contentAssociationArn; }
            set { this._contentAssociationArn = value; }
        }

        // Check to see if ContentAssociationArn property is set
        internal bool IsSetContentAssociationArn()
        {
            return this._contentAssociationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ContentAssociationId. 
        /// <para>
        /// The identifier of the content association. Can be either the ID or the ARN. URLs cannot
        /// contain the ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ContentAssociationId
        {
            get { return this._contentAssociationId; }
            set { this._contentAssociationId = value; }
        }

        // Check to see if ContentAssociationId property is set
        internal bool IsSetContentAssociationId()
        {
            return this._contentAssociationId != null;
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
        /// Gets and sets the property KnowledgeBaseArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string KnowledgeBaseArn
        {
            get { return this._knowledgeBaseArn; }
            set { this._knowledgeBaseArn = value; }
        }

        // Check to see if KnowledgeBaseArn property is set
        internal bool IsSetKnowledgeBaseArn()
        {
            return this._knowledgeBaseArn != null;
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