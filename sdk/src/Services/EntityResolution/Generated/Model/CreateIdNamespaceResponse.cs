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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
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
namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// This is the response object from the CreateIdNamespace operation.
    /// </summary>
    public partial class CreateIdNamespaceResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private string _description;
        private List<IdNamespaceIdMappingWorkflowProperties> _idMappingWorkflowProperties = AWSConfigs.InitializeCollections ? new List<IdNamespaceIdMappingWorkflowProperties>() : null;
        private string _idNamespaceArn;
        private string _idNamespaceName;
        private List<IdNamespaceInputSource> _inputSourceConfig = AWSConfigs.InitializeCollections ? new List<IdNamespaceInputSource>() : null;
        private string _roleArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private IdNamespaceType _type;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the ID namespace was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the ID namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
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
        /// Gets and sets the property IdMappingWorkflowProperties. 
        /// <para>
        /// Determines the properties of <c>IdMappingWorkflow</c> where this <c>IdNamespace</c>
        /// can be used as a <c>Source</c> or a <c>Target</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<IdNamespaceIdMappingWorkflowProperties> IdMappingWorkflowProperties
        {
            get { return this._idMappingWorkflowProperties; }
            set { this._idMappingWorkflowProperties = value; }
        }

        // Check to see if IdMappingWorkflowProperties property is set
        internal bool IsSetIdMappingWorkflowProperties()
        {
            return this._idMappingWorkflowProperties != null && (this._idMappingWorkflowProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IdNamespaceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ID namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IdNamespaceArn
        {
            get { return this._idNamespaceArn; }
            set { this._idNamespaceArn = value; }
        }

        // Check to see if IdNamespaceArn property is set
        internal bool IsSetIdNamespaceArn()
        {
            return this._idNamespaceArn != null;
        }

        /// <summary>
        /// Gets and sets the property IdNamespaceName. 
        /// <para>
        /// The name of the ID namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string IdNamespaceName
        {
            get { return this._idNamespaceName; }
            set { this._idNamespaceName = value; }
        }

        // Check to see if IdNamespaceName property is set
        internal bool IsSetIdNamespaceName()
        {
            return this._idNamespaceName != null;
        }

        /// <summary>
        /// Gets and sets the property InputSourceConfig. 
        /// <para>
        /// A list of <c>InputSource</c> objects, which have the fields <c>InputSourceARN</c>
        /// and <c>SchemaName</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<IdNamespaceInputSource> InputSourceConfig
        {
            get { return this._inputSourceConfig; }
            set { this._inputSourceConfig = value; }
        }

        // Check to see if InputSourceConfig property is set
        internal bool IsSetInputSourceConfig()
        {
            return this._inputSourceConfig != null && (this._inputSourceConfig.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role. Entity Resolution assumes this role
        /// to access the resources defined in <c>inputSourceConfig</c> on your behalf as part
        /// of the workflow run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=512)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
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
        [AWSProperty(Min=0, Max=200)]
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

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of ID namespace. There are two types: <c>SOURCE</c> and <c>TARGET</c>.
        /// </para>
        ///  
        /// <para>
        /// The <c>SOURCE</c> contains configurations for <c>sourceId</c> data that will be processed
        /// in an ID mapping workflow. 
        /// </para>
        ///  
        /// <para>
        /// The <c>TARGET</c> contains a configuration of <c>targetId</c> to which all <c>sourceIds</c>
        /// will resolve to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IdNamespaceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the ID namespace was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}