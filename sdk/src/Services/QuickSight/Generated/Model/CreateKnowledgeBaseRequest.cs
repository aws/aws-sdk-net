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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the CreateKnowledgeBase operation.
    /// Creates a knowledge base from a specified data source. Supported data source connector
    /// types include:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>S3_KNOWLEDGE_BASE</c> – Uses an Amazon S3 bucket as the data source.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>WEB_CRAWLER</c> – Uses web pages indexed by the built-in web crawler as the data
    /// source.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>GOOGLE_DRIVE</c> – Uses Google Drive as the data source. Supports service account
    /// authentication only.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>SHAREPOINT</c> – Uses SharePoint as the data source. Supports two-legged OAuth
    /// only.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ONE_DRIVE</c> – Uses OneDrive as the data source. Supports two-legged OAuth only.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateKnowledgeBaseRequest : AmazonQuickSightRequest
    {
        private AccessControlConfiguration _accessControlConfiguration;
        private string _awsAccountId;
        private string _dataSourceArn;
        private string _description;
        private KnowledgeBaseConfiguration _knowledgeBaseConfiguration;
        private string _knowledgeBaseId;
        private MediaExtractionConfiguration _mediaExtractionConfiguration;
        private string _name;
        private List<ResourcePermission> _permissions = AWSConfigs.InitializeCollections ? new List<ResourcePermission>() : null;
        private string _primaryOwnerArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AccessControlConfiguration. 
        /// <para>
        /// The access control configuration for the knowledge base. If you don't specify this
        /// parameter, document-level ACLs are disabled.
        /// </para>
        /// </summary>
        public AccessControlConfiguration AccessControlConfiguration
        {
            get { return this._accessControlConfiguration; }
            set { this._accessControlConfiguration = value; }
        }

        // Check to see if AccessControlConfiguration property is set
        internal bool IsSetAccessControlConfiguration()
        {
            return this._accessControlConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property DataSourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the data source for the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1284)]
        public string DataSourceArn
        {
            get { return this._dataSourceArn; }
            set { this._dataSourceArn = value; }
        }

        // Check to see if DataSourceArn property is set
        internal bool IsSetDataSourceArn()
        {
            return this._dataSourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the knowledge base. If you don't specify a description, the knowledge
        /// base is created without one.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
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
        /// Gets and sets the property KnowledgeBaseConfiguration.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public KnowledgeBaseConfiguration KnowledgeBaseConfiguration
        {
            get { return this._knowledgeBaseConfiguration; }
            set { this._knowledgeBaseConfiguration = value; }
        }

        // Check to see if KnowledgeBaseConfiguration property is set
        internal bool IsSetKnowledgeBaseConfiguration()
        {
            return this._knowledgeBaseConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The unique identifier for the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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
        /// Gets and sets the property MediaExtractionConfiguration.
        /// </summary>
        public MediaExtractionConfiguration MediaExtractionConfiguration
        {
            get { return this._mediaExtractionConfiguration; }
            set { this._mediaExtractionConfiguration = value; }
        }

        // Check to see if MediaExtractionConfiguration property is set
        internal bool IsSetMediaExtractionConfiguration()
        {
            return this._mediaExtractionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=128)]
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
        /// Gets and sets the property Permissions. 
        /// <para>
        /// A list of resource permissions on the knowledge base. Each entry grants a specified
        /// Amazon QuickSight principal either owner or viewer access. If you don't specify permissions,
        /// only the primary owner (if provided) receives owner access.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public List<ResourcePermission> Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null && (this._permissions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PrimaryOwnerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the primary owner for the knowledge base. The specified
        /// user is always granted owner access, regardless of what is specified in the <c>Permissions</c>
        /// field. If you don't specify a primary owner, the knowledge base is created without
        /// one.
        /// </para>
        /// </summary>
        public string PrimaryOwnerArn
        {
            get { return this._primaryOwnerArn; }
            set { this._primaryOwnerArn = value; }
        }

        // Check to see if PrimaryOwnerArn property is set
        internal bool IsSetPrimaryOwnerArn()
        {
            return this._primaryOwnerArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to assign to the knowledge base. If you don't specify tags, the knowledge
        /// base is created without tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<Tag> Tags
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