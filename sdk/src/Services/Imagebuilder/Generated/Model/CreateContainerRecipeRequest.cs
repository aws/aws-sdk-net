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
    /// Container for the parameters to the CreateContainerRecipe operation.
    /// Creates a new container recipe. Container recipes define how images are configured,
    /// tested, and assessed.
    /// </summary>
    public partial class CreateContainerRecipeRequest : AmazonImagebuilderRequest
    {
        private string _clientToken;
        private List<ComponentConfiguration> _components = new List<ComponentConfiguration>();
        private ContainerType _containerType;
        private string _description;
        private string _dockerfileTemplateData;
        private string _dockerfileTemplateUri;
        private string _imageOsVersionOverride;
        private InstanceConfiguration _instanceConfiguration;
        private string _kmsKeyId;
        private string _name;
        private string _parentImage;
        private Platform _platformOverride;
        private string _semanticVersion;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private TargetContainerRepository _targetRepository;
        private string _workingDirectory;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client token used to make this request idempotent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
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
        /// Gets and sets the property Components. 
        /// <para>
        /// Components for build and test that are included in the container recipe. Recipes require
        /// a minimum of one build component, and can have a maximum of 20 build and test components
        /// in any combination.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// The type of container to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The Dockerfile template used to build your image as an inline data blob.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16000)]
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
        /// Gets and sets the property DockerfileTemplateUri. 
        /// <para>
        /// The Amazon S3 URI for the Dockerfile that will be used to build your container image.
        /// </para>
        /// </summary>
        public string DockerfileTemplateUri
        {
            get { return this._dockerfileTemplateUri; }
            set { this._dockerfileTemplateUri = value; }
        }

        // Check to see if DockerfileTemplateUri property is set
        internal bool IsSetDockerfileTemplateUri()
        {
            return this._dockerfileTemplateUri != null;
        }

        /// <summary>
        /// Gets and sets the property ImageOsVersionOverride. 
        /// <para>
        /// Specifies the operating system version for the base image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ImageOsVersionOverride
        {
            get { return this._imageOsVersionOverride; }
            set { this._imageOsVersionOverride = value; }
        }

        // Check to see if ImageOsVersionOverride property is set
        internal bool IsSetImageOsVersionOverride()
        {
            return this._imageOsVersionOverride != null;
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
        /// Identifies which KMS key is used to encrypt the container image.
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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ParentImage. 
        /// <para>
        /// The base image for the container recipe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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
        /// Gets and sets the property PlatformOverride. 
        /// <para>
        /// Specifies the operating system platform when you use a custom base image.
        /// </para>
        /// </summary>
        public Platform PlatformOverride
        {
            get { return this._platformOverride; }
            set { this._platformOverride = value; }
        }

        // Check to see if PlatformOverride property is set
        internal bool IsSetPlatformOverride()
        {
            return this._platformOverride != null;
        }

        /// <summary>
        /// Gets and sets the property SemanticVersion. 
        /// <para>
        /// The semantic version of the container recipe. This version follows the semantic version
        /// syntax.
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
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SemanticVersion
        {
            get { return this._semanticVersion; }
            set { this._semanticVersion = value; }
        }

        // Check to see if SemanticVersion property is set
        internal bool IsSetSemanticVersion()
        {
            return this._semanticVersion != null;
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
        [AWSProperty(Required=true)]
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