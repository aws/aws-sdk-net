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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// This is the response object from the GetConfigurationBundle operation.
    /// </summary>
    public partial class GetConfigurationBundleResponse : AmazonWebServiceResponse
    {
        private string _bundleArn;
        private string _bundleId;
        private string _bundleName;
        private Dictionary<string, ComponentConfiguration> _components = AWSConfigs.InitializeCollections ? new Dictionary<string, ComponentConfiguration>() : null;
        private DateTime? _createdAt;
        private string _description;
        private VersionLineageMetadata _lineageMetadata;
        private DateTime? _updatedAt;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property BundleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the configuration bundle.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BundleArn
        {
            get { return this._bundleArn; }
            set { this._bundleArn = value; }
        }

        // Check to see if BundleArn property is set
        internal bool IsSetBundleArn()
        {
            return this._bundleArn != null;
        }

        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The unique identifier of the configuration bundle.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BundleId
        {
            get { return this._bundleId; }
            set { this._bundleId = value; }
        }

        // Check to see if BundleId property is set
        internal bool IsSetBundleId()
        {
            return this._bundleId != null;
        }

        /// <summary>
        /// Gets and sets the property BundleName. 
        /// <para>
        /// The name of the configuration bundle.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BundleName
        {
            get { return this._bundleName; }
            set { this._bundleName = value; }
        }

        // Check to see if BundleName property is set
        internal bool IsSetBundleName()
        {
            return this._bundleName != null;
        }

        /// <summary>
        /// Gets and sets the property Components. 
        /// <para>
        /// A map of component identifiers to their configurations for this version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, ComponentConfiguration> Components
        {
            get { return this._components; }
            set { this._components = value; }
        }

        // Check to see if Components property is set
        internal bool IsSetComponents()
        {
            return this._components != null && (this._components.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the configuration bundle was created.
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
        /// The description of the configuration bundle.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=500)]
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
        /// Gets and sets the property LineageMetadata. 
        /// <para>
        /// The version lineage metadata, including parent versions, branch name, and creation
        /// source.
        /// </para>
        /// </summary>
        public VersionLineageMetadata LineageMetadata
        {
            get { return this._lineageMetadata; }
            set { this._lineageMetadata = value; }
        }

        // Check to see if LineageMetadata property is set
        internal bool IsSetLineageMetadata()
        {
            return this._lineageMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the configuration bundle was last updated.
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

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The version identifier of this configuration bundle.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}