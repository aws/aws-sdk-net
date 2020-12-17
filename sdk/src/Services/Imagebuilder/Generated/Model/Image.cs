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
    /// An image build version.
    /// </summary>
    public partial class Image
    {
        private string _arn;
        private ContainerRecipe _containerRecipe;
        private string _dateCreated;
        private DistributionConfiguration _distributionConfiguration;
        private bool? _enhancedImageMetadataEnabled;
        private ImageRecipe _imageRecipe;
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
        /// Gets and sets the property ContainerRecipe. 
        /// <para>
        /// The container recipe used to create the container image type.
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
        /// The date on which this image was created.
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
        /// The distribution configuration used when creating this image.
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
        ///  Collects additional information about the image being created, including the operating
        /// system (OS) version and package list. This information is used to enhance the overall
        /// experience of using EC2 Image Builder. Enabled by default. 
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
        /// The image recipe used when creating the image.
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
        /// Gets and sets the property ImageTestsConfiguration. 
        /// <para>
        /// The image tests configuration used when creating this image.
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
        /// The infrastructure used when creating this image.
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
        /// The operating system version of the instance. For example, Amazon Linux 2, Ubuntu
        /// 18, or Microsoft Windows Server 2019. 
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
        /// The output resources produced when creating this image.
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
        /// The platform of the image.
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
        /// The tags of the image.
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
        /// Specifies whether this is an AMI or container image.
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