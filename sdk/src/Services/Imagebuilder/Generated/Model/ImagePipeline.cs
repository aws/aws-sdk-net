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
    /// Details of an image pipeline.
    /// </summary>
    public partial class ImagePipeline
    {
        private string _arn;
        private string _containerRecipeArn;
        private string _dateCreated;
        private string _dateLastRun;
        private string _dateNextRun;
        private string _dateUpdated;
        private string _description;
        private string _distributionConfigurationArn;
        private bool? _enhancedImageMetadataEnabled;
        private string _imageRecipeArn;
        private ImageScanningConfiguration _imageScanningConfiguration;
        private ImageTestsConfiguration _imageTestsConfiguration;
        private string _infrastructureConfigurationArn;
        private string _name;
        private Platform _platform;
        private Schedule _schedule;
        private PipelineStatus _status;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the image pipeline.
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
        /// Gets and sets the property ContainerRecipeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the container recipe that is used for this pipeline.
        /// </para>
        /// </summary>
        public string ContainerRecipeArn
        {
            get { return this._containerRecipeArn; }
            set { this._containerRecipeArn = value; }
        }

        // Check to see if ContainerRecipeArn property is set
        internal bool IsSetContainerRecipeArn()
        {
            return this._containerRecipeArn != null;
        }

        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The date on which this image pipeline was created.
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
        /// Gets and sets the property DateLastRun. 
        /// <para>
        /// This is no longer supported, and does not return a value.
        /// </para>
        /// </summary>
        public string DateLastRun
        {
            get { return this._dateLastRun; }
            set { this._dateLastRun = value; }
        }

        // Check to see if DateLastRun property is set
        internal bool IsSetDateLastRun()
        {
            return this._dateLastRun != null;
        }

        /// <summary>
        /// Gets and sets the property DateNextRun. 
        /// <para>
        /// This is no longer supported, and does not return a value.
        /// </para>
        /// </summary>
        public string DateNextRun
        {
            get { return this._dateNextRun; }
            set { this._dateNextRun = value; }
        }

        // Check to see if DateNextRun property is set
        internal bool IsSetDateNextRun()
        {
            return this._dateNextRun != null;
        }

        /// <summary>
        /// Gets and sets the property DateUpdated. 
        /// <para>
        /// The date on which this image pipeline was last updated.
        /// </para>
        /// </summary>
        public string DateUpdated
        {
            get { return this._dateUpdated; }
            set { this._dateUpdated = value; }
        }

        // Check to see if DateUpdated property is set
        internal bool IsSetDateUpdated()
        {
            return this._dateUpdated != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the image pipeline.
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
        /// Gets and sets the property DistributionConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the distribution configuration associated with this
        /// image pipeline.
        /// </para>
        /// </summary>
        public string DistributionConfigurationArn
        {
            get { return this._distributionConfigurationArn; }
            set { this._distributionConfigurationArn = value; }
        }

        // Check to see if DistributionConfigurationArn property is set
        internal bool IsSetDistributionConfigurationArn()
        {
            return this._distributionConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property EnhancedImageMetadataEnabled. 
        /// <para>
        /// Collects additional information about the image being created, including the operating
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
        /// Gets and sets the property ImageRecipeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the image recipe associated with this image pipeline.
        /// </para>
        /// </summary>
        public string ImageRecipeArn
        {
            get { return this._imageRecipeArn; }
            set { this._imageRecipeArn = value; }
        }

        // Check to see if ImageRecipeArn property is set
        internal bool IsSetImageRecipeArn()
        {
            return this._imageRecipeArn != null;
        }

        /// <summary>
        /// Gets and sets the property ImageScanningConfiguration. 
        /// <para>
        /// Contains settings for vulnerability scans.
        /// </para>
        /// </summary>
        public ImageScanningConfiguration ImageScanningConfiguration
        {
            get { return this._imageScanningConfiguration; }
            set { this._imageScanningConfiguration = value; }
        }

        // Check to see if ImageScanningConfiguration property is set
        internal bool IsSetImageScanningConfiguration()
        {
            return this._imageScanningConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ImageTestsConfiguration. 
        /// <para>
        /// The image tests configuration of the image pipeline.
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
        /// Gets and sets the property InfrastructureConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the infrastructure configuration associated with
        /// this image pipeline.
        /// </para>
        /// </summary>
        public string InfrastructureConfigurationArn
        {
            get { return this._infrastructureConfigurationArn; }
            set { this._infrastructureConfigurationArn = value; }
        }

        // Check to see if InfrastructureConfigurationArn property is set
        internal bool IsSetInfrastructureConfigurationArn()
        {
            return this._infrastructureConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the image pipeline.
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
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform of the image pipeline.
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
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule of the image pipeline.
        /// </para>
        /// </summary>
        public Schedule Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the image pipeline.
        /// </para>
        /// </summary>
        public PipelineStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags of this image pipeline.
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

    }
}