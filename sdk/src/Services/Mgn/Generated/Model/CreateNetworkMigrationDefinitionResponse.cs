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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
namespace Amazon.Mgn.Model
{
    /// <summary>
    /// This is the response object from the CreateNetworkMigrationDefinition operation.
    /// </summary>
    public partial class CreateNetworkMigrationDefinitionResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _createdAt;
        private string _description;
        private string _name;
        private string _networkMigrationDefinitionID;
        private Dictionary<string, string> _scopeTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<SourceConfiguration> _sourceConfigurations = AWSConfigs.InitializeCollections ? new List<SourceConfiguration>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private TargetDeployment _targetDeployment;
        private TargetNetwork _targetNetwork;
        private TargetS3Configuration _targets3Configuration;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the network migration definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the network migration definition was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
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
        /// A description of the network migration definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=600)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the network migration definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property NetworkMigrationDefinitionID. 
        /// <para>
        /// The unique identifier of the network migration definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=21, Max=21)]
        public string NetworkMigrationDefinitionID
        {
            get { return this._networkMigrationDefinitionID; }
            set { this._networkMigrationDefinitionID = value; }
        }

        // Check to see if NetworkMigrationDefinitionID property is set
        internal bool IsSetNetworkMigrationDefinitionID()
        {
            return this._networkMigrationDefinitionID != null;
        }

        /// <summary>
        /// Gets and sets the property ScopeTags. 
        /// <para>
        /// Scope tags for the network migration definition.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=40)]
        public Dictionary<string, string> ScopeTags
        {
            get { return this._scopeTags; }
            set { this._scopeTags = value; }
        }

        // Check to see if ScopeTags property is set
        internal bool IsSetScopeTags()
        {
            return this._scopeTags != null && (this._scopeTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceConfigurations. 
        /// <para>
        /// A list of source configurations for the network migration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<SourceConfiguration> SourceConfigurations
        {
            get { return this._sourceConfigurations; }
            set { this._sourceConfigurations = value; }
        }

        // Check to see if SourceConfigurations property is set
        internal bool IsSetSourceConfigurations()
        {
            return this._sourceConfigurations != null && (this._sourceConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags assigned to the network migration definition.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=50)]
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
        /// Gets and sets the property TargetDeployment. 
        /// <para>
        /// The target deployment configuration for the migrated network.
        /// </para>
        /// </summary>
        public TargetDeployment TargetDeployment
        {
            get { return this._targetDeployment; }
            set { this._targetDeployment = value; }
        }

        // Check to see if TargetDeployment property is set
        internal bool IsSetTargetDeployment()
        {
            return this._targetDeployment != null;
        }

        /// <summary>
        /// Gets and sets the property TargetNetwork. 
        /// <para>
        /// The target network configuration including topology and CIDR ranges.
        /// </para>
        /// </summary>
        public TargetNetwork TargetNetwork
        {
            get { return this._targetNetwork; }
            set { this._targetNetwork = value; }
        }

        // Check to see if TargetNetwork property is set
        internal bool IsSetTargetNetwork()
        {
            return this._targetNetwork != null;
        }

        /// <summary>
        /// Gets and sets the property TargetS3Configuration. 
        /// <para>
        /// The S3 configuration for storing the target network artifacts.
        /// </para>
        /// </summary>
        public TargetS3Configuration TargetS3Configuration
        {
            get { return this._targets3Configuration; }
            set { this._targets3Configuration = value; }
        }

        // Check to see if TargetS3Configuration property is set
        internal bool IsSetTargetS3Configuration()
        {
            return this._targets3Configuration != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the network migration definition was last updated.
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}