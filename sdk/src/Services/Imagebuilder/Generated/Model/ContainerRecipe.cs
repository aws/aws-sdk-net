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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// A container recipe.
    /// </summary>
    public partial class ContainerRecipe
    {
        private string _arn;
        private List<ComponentConfiguration> _components = new List<ComponentConfiguration>();
        private ContainerType _containerType;
        private string _dateCreated;
        private string _description;
        private string _dockerfileTemplateData;
        private bool? _encrypted;
        private InstanceConfiguration _instanceConfiguration;
        private string _kmsKeyId;
        private string _name;
        private string _owner;
        private string _parentImage;
        private Platform _platform;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private TargetContainerRepository _targetRepository;
        private string _version;
        private string _workingDirectory;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the container recipe.
        /// </para>
        ///  <note> 
        /// <para>
        /// Semantic versioning is included in each object's Amazon Resource Name (ARN), at the
        /// level that applies to that object as follows:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Versionless ARNs and Name ARNs do not include specific values in any of the nodes.
        /// The nodes are either left off entirely, or they are specified as wildcards, for example:
        /// x.x.x.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Version ARNs have only the first three nodes: &lt;major&gt;.&lt;minor&gt;.&lt;patch&gt;
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Build version ARNs have all four nodes, and point to a specific build for a specific
        /// version of an object.
        /// </para>
        ///  </li> </ol> </note>
        /// </summary>
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
        /// Gets and sets the property Components. 
        /// <para>
        /// Build and test components that are included in the container recipe. Recipes require
        /// a minimum of one build component, and can have a maximum of 20 build and test components
        /// in any combination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<ComponentConfiguration> Components
        {
            get { return this._components; }
            set { this._components = value; }
        }

        // Check to see if Components property is set
        internal bool IsSetComponents()
        {
            return this._components != null && this._components.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ContainerType. 
        /// <para>
        /// Specifies the type of container, such as Docker.
        /// </para>
        /// </summary>
        public ContainerType ContainerType
        {
            get { return this._containerType; }
            set { this._containerType = value; }
        }

        // Check to see if ContainerType property is set
        internal bool IsSetContainerType()
        {
            return this._containerType != null;
        }

        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The date when this container recipe was created.
        /// </para>
        /// </summary>
        public string DateCreated
        {
            get { return this._dateCreated; }
            set { this._dateCreated = value; }
        }

        // Check to see if DateCreated property is set
        internal bool IsSetDateCreated()
        {
            return this._dateCreated != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the container recipe.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property DockerfileTemplateData. 
        /// <para>
        /// Dockerfiles are text documents that are used to build Docker containers, and ensure
        /// that they contain all of the elements required by the application running inside.
        /// The template data consists of contextual variables where Image Builder places build
        /// information or scripts, based on your container image recipe.
        /// </para>
        /// </summary>
        public string DockerfileTemplateData
        {
            get { return this._dockerfileTemplateData; }
            set { this._dockerfileTemplateData = value; }
        }

        // Check to see if DockerfileTemplateData property is set
        internal bool IsSetDockerfileTemplateData()
        {
            return this._dockerfileTemplateData != null;
        }

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// A flag that indicates if the target container is encrypted.
        /// </para>
        /// </summary>
        public bool Encrypted
        {
            get { return this._encrypted.GetValueOrDefault(); }
            set { this._encrypted = value; }
        }

        // Check to see if Encrypted property is set
        internal bool IsSetEncrypted()
        {
            return this._encrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceConfiguration. 
        /// <para>
        /// A group of options that can be used to configure an instance for building and testing
        /// container images.
        /// </para>
        /// </summary>
        public InstanceConfiguration InstanceConfiguration
        {
            get { return this._instanceConfiguration; }
            set { this._instanceConfiguration = value; }
        }

        // Check to see if InstanceConfiguration property is set
        internal bool IsSetInstanceConfiguration()
        {
            return this._instanceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// Identifies which KMS key is used to encrypt the container image for distribution to
        /// the target Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the container recipe.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the container recipe.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property ParentImage. 
        /// <para>
        /// The base image for the container recipe.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ParentImage
        {
            get { return this._parentImage; }
            set { this._parentImage = value; }
        }

        // Check to see if ParentImage property is set
        internal bool IsSetParentImage()
        {
            return this._parentImage != null;
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The system platform for the container, such as Windows or Linux.
        /// </para>
        /// </summary>
        public Platform Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags that are attached to the container recipe.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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

        /// <summary>
        /// Gets and sets the property TargetRepository. 
        /// <para>
        /// The destination repository for the container image.
        /// </para>
        /// </summary>
        public TargetContainerRepository TargetRepository
        {
            get { return this._targetRepository; }
            set { this._targetRepository = value; }
        }

        // Check to see if TargetRepository property is set
        internal bool IsSetTargetRepository()
        {
            return this._targetRepository != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The semantic version of the container recipe.
        /// </para>
        ///  <note> 
        /// <para>
        /// The semantic version has four nodes: &lt;major&gt;.&lt;minor&gt;.&lt;patch&gt;/&lt;build&gt;.
        /// You can assign values for the first three, and can filter on all of them.
        /// </para>
        ///  
        /// <para>
        ///  <b>Assignment:</b> For the first three nodes you can assign any positive integer
        /// value, including zero, with an upper limit of 2^30-1, or 1073741823 for each node.
        /// Image Builder automatically assigns the build number to the fourth node.
        /// </para>
        ///  
        /// <para>
        ///  <b>Patterns:</b> You can use any numeric pattern that adheres to the assignment requirements
        /// for the nodes that you can assign. For example, you might choose a software version
        /// pattern, such as 1.0.0, or a date, such as 2021.01.01.
        /// </para>
        ///  
        /// <para>
        ///  <b>Filtering:</b> With semantic versioning, you have the flexibility to use wildcards
        /// (x) to specify the most recent versions or nodes when selecting the base image or
        /// components for your recipe. When you use a wildcard in any node, all nodes to the
        /// right of the first wildcard must also be wildcards.
        /// </para>
        ///  </note>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

        /// <summary>
        /// Gets and sets the property WorkingDirectory. 
        /// <para>
        /// The working directory for use during build and test workflows.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string WorkingDirectory
        {
            get { return this._workingDirectory; }
            set { this._workingDirectory = value; }
        }

        // Check to see if WorkingDirectory property is set
        internal bool IsSetWorkingDirectory()
        {
            return this._workingDirectory != null;
        }

    }
}