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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Defines the settings for a specific Region.
    /// </summary>
    public partial class Distribution
    {
        private AmiDistributionConfiguration _amiDistributionConfiguration;
        private ContainerDistributionConfiguration _containerDistributionConfiguration;
        private List<FastLaunchConfiguration> _fastLaunchConfigurations = AWSConfigs.InitializeCollections ? new List<FastLaunchConfiguration>() : null;
        private List<LaunchTemplateConfiguration> _launchTemplateConfigurations = AWSConfigs.InitializeCollections ? new List<LaunchTemplateConfiguration>() : null;
        private List<string> _licenseConfigurationArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _region;
        private S3ExportConfiguration _s3ExportConfiguration;
        private List<SsmParameterConfiguration> _ssmParameterConfigurations = AWSConfigs.InitializeCollections ? new List<SsmParameterConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property AmiDistributionConfiguration. 
        /// <para>
        /// The specific AMI settings; for example, launch permissions or AMI tags.
        /// </para>
        /// </summary>
        public AmiDistributionConfiguration AmiDistributionConfiguration
        {
            get { return this._amiDistributionConfiguration; }
            set { this._amiDistributionConfiguration = value; }
        }

        // Check to see if AmiDistributionConfiguration property is set
        internal bool IsSetAmiDistributionConfiguration()
        {
            return this._amiDistributionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerDistributionConfiguration. 
        /// <para>
        /// Container distribution settings for encryption, licensing, and sharing in a specific
        /// Region.
        /// </para>
        /// </summary>
        public ContainerDistributionConfiguration ContainerDistributionConfiguration
        {
            get { return this._containerDistributionConfiguration; }
            set { this._containerDistributionConfiguration = value; }
        }

        // Check to see if ContainerDistributionConfiguration property is set
        internal bool IsSetContainerDistributionConfiguration()
        {
            return this._containerDistributionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property FastLaunchConfigurations. 
        /// <para>
        /// The Windows faster-launching configurations to use for AMI distribution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public List<FastLaunchConfiguration> FastLaunchConfigurations
        {
            get { return this._fastLaunchConfigurations; }
            set { this._fastLaunchConfigurations = value; }
        }

        // Check to see if FastLaunchConfigurations property is set
        internal bool IsSetFastLaunchConfigurations()
        {
            return this._fastLaunchConfigurations != null && (this._fastLaunchConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LaunchTemplateConfigurations. 
        /// <para>
        /// A group of launchTemplateConfiguration settings that apply to image distribution for
        /// specified accounts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<LaunchTemplateConfiguration> LaunchTemplateConfigurations
        {
            get { return this._launchTemplateConfigurations; }
            set { this._launchTemplateConfigurations = value; }
        }

        // Check to see if LaunchTemplateConfigurations property is set
        internal bool IsSetLaunchTemplateConfigurations()
        {
            return this._launchTemplateConfigurations != null && (this._launchTemplateConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LicenseConfigurationArns. 
        /// <para>
        /// The License Manager Configuration to associate with the AMI in the specified Region.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<string> LicenseConfigurationArns
        {
            get { return this._licenseConfigurationArns; }
            set { this._licenseConfigurationArns = value; }
        }

        // Check to see if LicenseConfigurationArns property is set
        internal bool IsSetLicenseConfigurationArns()
        {
            return this._licenseConfigurationArns != null && (this._licenseConfigurationArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The target Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property S3ExportConfiguration. 
        /// <para>
        /// Configure export settings to deliver disk images created from your image build, using
        /// a file format that is compatible with your VMs in that Region.
        /// </para>
        /// </summary>
        public S3ExportConfiguration S3ExportConfiguration
        {
            get { return this._s3ExportConfiguration; }
            set { this._s3ExportConfiguration = value; }
        }

        // Check to see if S3ExportConfiguration property is set
        internal bool IsSetS3ExportConfiguration()
        {
            return this._s3ExportConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SsmParameterConfigurations. 
        /// <para>
        /// Contains settings to update Amazon Web Services Systems Manager (SSM) Parameter Store
        /// Parameters with output AMI IDs from the build by target Region.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SsmParameterConfiguration> SsmParameterConfigurations
        {
            get { return this._ssmParameterConfigurations; }
            set { this._ssmParameterConfigurations = value; }
        }

        // Check to see if SsmParameterConfigurations property is set
        internal bool IsSetSsmParameterConfigurations()
        {
            return this._ssmParameterConfigurations != null && (this._ssmParameterConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}