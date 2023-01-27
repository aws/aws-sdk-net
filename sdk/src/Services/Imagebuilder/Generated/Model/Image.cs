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
    /// An Image Builder image. You must specify exactly one recipe for the image – either
    /// a container recipe (<code>containerRecipe</code>), which creates a container image,
    /// or an image recipe (<code>imageRecipe</code>), which creates an AMI.
    /// </summary>
    public partial class Image
    {
        private string _arn;
        private BuildType _buildType;
        private ContainerRecipe _containerRecipe;
        private string _dateCreated;
        private DistributionConfiguration _distributionConfiguration;
        private bool? _enhancedImageMetadataEnabled;
        private ImageRecipe _imageRecipe;
        private ImageSource _imageSource;
        private ImageTestsConfiguration _imageTestsConfiguration;
        private InfrastructureConfiguration _infrastructureConfiguration;
        private string _name;
        private string _osVersion;
        private OutputResources _outputResources;
        private Platform _platform;
        private string _sourcePipelineArn;
        private string _sourcePipelineName;
        private ImageState _state;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private ImageType _type;
        private string _version;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the image.
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
        /// Gets and sets the property BuildType. 
        /// <para>
        /// Indicates the type of build that created this image. The build can be initiated in
        /// the following ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>USER_INITIATED</b> – A manual pipeline build request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>SCHEDULED</b> – A pipeline build initiated by a cron expression in the Image Builder
        /// pipeline, or from EventBridge.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IMPORT</b> – A VM import created the image to use as the base image for the recipe.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BuildType BuildType
        {
            get { return this._buildType; }
            set { this._buildType = value; }
        }

        // Check to see if BuildType property is set
        internal bool IsSetBuildType()
        {
            return this._buildType != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerRecipe. 
        /// <para>
        /// For container images, this is the container recipe that Image Builder used to create
        /// the image. For images that distribute an AMI, this is empty.
        /// </para>
        /// </summary>
        public ContainerRecipe ContainerRecipe
        {
            get { return this._containerRecipe; }
            set { this._containerRecipe = value; }
        }

        // Check to see if ContainerRecipe property is set
        internal bool IsSetContainerRecipe()
        {
            return this._containerRecipe != null;
        }

        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The date on which Image Builder created this image.
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
        /// Gets and sets the property DistributionConfiguration. 
        /// <para>
        /// The distribution configuration that Image Builder used to create this image.
        /// </para>
        /// </summary>
        public DistributionConfiguration DistributionConfiguration
        {
            get { return this._distributionConfiguration; }
            set { this._distributionConfiguration = value; }
        }

        // Check to see if DistributionConfiguration property is set
        internal bool IsSetDistributionConfiguration()
        {
            return this._distributionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property EnhancedImageMetadataEnabled. 
        /// <para>
        /// Indicates whether Image Builder collects additional information about the image, such
        /// as the operating system (OS) version and package list.
        /// </para>
        /// </summary>
        public bool EnhancedImageMetadataEnabled
        {
            get { return this._enhancedImageMetadataEnabled.GetValueOrDefault(); }
            set { this._enhancedImageMetadataEnabled = value; }
        }

        // Check to see if EnhancedImageMetadataEnabled property is set
        internal bool IsSetEnhancedImageMetadataEnabled()
        {
            return this._enhancedImageMetadataEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageRecipe. 
        /// <para>
        /// For images that distribute an AMI, this is the image recipe that Image Builder used
        /// to create the image. For container images, this is empty.
        /// </para>
        /// </summary>
        public ImageRecipe ImageRecipe
        {
            get { return this._imageRecipe; }
            set { this._imageRecipe = value; }
        }

        // Check to see if ImageRecipe property is set
        internal bool IsSetImageRecipe()
        {
            return this._imageRecipe != null;
        }

        /// <summary>
        /// Gets and sets the property ImageSource. 
        /// <para>
        /// The origin of the base image that Image Builder used to build this image.
        /// </para>
        /// </summary>
        public ImageSource ImageSource
        {
            get { return this._imageSource; }
            set { this._imageSource = value; }
        }

        // Check to see if ImageSource property is set
        internal bool IsSetImageSource()
        {
            return this._imageSource != null;
        }

        /// <summary>
        /// Gets and sets the property ImageTestsConfiguration. 
        /// <para>
        /// The image tests that ran when that Image Builder created this image.
        /// </para>
        /// </summary>
        public ImageTestsConfiguration ImageTestsConfiguration
        {
            get { return this._imageTestsConfiguration; }
            set { this._imageTestsConfiguration = value; }
        }

        // Check to see if ImageTestsConfiguration property is set
        internal bool IsSetImageTestsConfiguration()
        {
            return this._imageTestsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property InfrastructureConfiguration. 
        /// <para>
        /// The infrastructure that Image Builder used to create this image.
        /// </para>
        /// </summary>
        public InfrastructureConfiguration InfrastructureConfiguration
        {
            get { return this._infrastructureConfiguration; }
            set { this._infrastructureConfiguration = value; }
        }

        // Check to see if InfrastructureConfiguration property is set
        internal bool IsSetInfrastructureConfiguration()
        {
            return this._infrastructureConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the image.
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
        /// Gets and sets the property OsVersion. 
        /// <para>
        /// The operating system version for instances that launch from this image. For example,
        /// Amazon Linux 2, Ubuntu 18, or Microsoft Windows Server 2019.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string OsVersion
        {
            get { return this._osVersion; }
            set { this._osVersion = value; }
        }

        // Check to see if OsVersion property is set
        internal bool IsSetOsVersion()
        {
            return this._osVersion != null;
        }

        /// <summary>
        /// Gets and sets the property OutputResources. 
        /// <para>
        /// The output resources that Image Builder produces for this image.
        /// </para>
        /// </summary>
        public OutputResources OutputResources
        {
            get { return this._outputResources; }
            set { this._outputResources = value; }
        }

        // Check to see if OutputResources property is set
        internal bool IsSetOutputResources()
        {
            return this._outputResources != null;
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The image operating system platform, such as Linux or Windows.
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
        /// Gets and sets the property SourcePipelineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the image pipeline that created this image.
        /// </para>
        /// </summary>
        public string SourcePipelineArn
        {
            get { return this._sourcePipelineArn; }
            set { this._sourcePipelineArn = value; }
        }

        // Check to see if SourcePipelineArn property is set
        internal bool IsSetSourcePipelineArn()
        {
            return this._sourcePipelineArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourcePipelineName. 
        /// <para>
        /// The name of the image pipeline that created this image.
        /// </para>
        /// </summary>
        public string SourcePipelineName
        {
            get { return this._sourcePipelineName; }
            set { this._sourcePipelineName = value; }
        }

        // Check to see if SourcePipelineName property is set
        internal bool IsSetSourcePipelineName()
        {
            return this._sourcePipelineName != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the image.
        /// </para>
        /// </summary>
        public ImageState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that apply to this image.
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
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies whether this image produces an AMI or a container image.
        /// </para>
        /// </summary>
        public ImageType Type
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
        /// Gets and sets the property Version. 
        /// <para>
        /// The semantic version of the image.
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

    }
}