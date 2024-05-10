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
    /// Container for the parameters to the UpdateIdNamespace operation.
    /// Updates an existing ID namespace.
    /// </summary>
    public partial class UpdateIdNamespaceRequest : AmazonEntityResolutionRequest
    {
        private string _description;
        private List<IdNamespaceIdMappingWorkflowProperties> _idMappingWorkflowProperties = AWSConfigs.InitializeCollections ? new List<IdNamespaceIdMappingWorkflowProperties>() : null;
        private string _idNamespaceName;
        private List<IdNamespaceInputSource> _inputSourceConfig = AWSConfigs.InitializeCollections ? new List<IdNamespaceInputSource>() : null;
        private string _roleArn;

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
        /// to access the resources defined in this <c>IdNamespace</c> on your behalf as part
        /// of a workflow run.
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

    }
}