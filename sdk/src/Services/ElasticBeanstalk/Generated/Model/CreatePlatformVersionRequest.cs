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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
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
namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePlatformVersion operation.
    /// Create a new version of your custom platform.
    /// </summary>
    public partial class CreatePlatformVersionRequest : AmazonElasticBeanstalkRequest
    {
        private string _environmentName;
        private List<ConfigurationOptionSetting> _optionSettings = AWSConfigs.InitializeCollections ? new List<ConfigurationOptionSetting>() : null;
        private S3Location _platformDefinitionBundle;
        private string _platformName;
        private string _platformVersion;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the builder environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=40)]
        public string EnvironmentName
        {
            get { return this._environmentName; }
            set { this._environmentName = value; }
        }

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this._environmentName != null;
        }

        /// <summary>
        /// Gets and sets the property OptionSettings. 
        /// <para>
        /// The configuration option settings to apply to the builder environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConfigurationOptionSetting> OptionSettings
        {
            get { return this._optionSettings; }
            set { this._optionSettings = value; }
        }

        // Check to see if OptionSettings property is set
        internal bool IsSetOptionSettings()
        {
            return this._optionSettings != null && (this._optionSettings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PlatformDefinitionBundle. 
        /// <para>
        /// The location of the platform definition archive in Amazon S3.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3Location PlatformDefinitionBundle
        {
            get { return this._platformDefinitionBundle; }
            set { this._platformDefinitionBundle = value; }
        }

        // Check to see if PlatformDefinitionBundle property is set
        internal bool IsSetPlatformDefinitionBundle()
        {
            return this._platformDefinitionBundle != null;
        }

        /// <summary>
        /// Gets and sets the property PlatformName. 
        /// <para>
        /// The name of your custom platform.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PlatformName
        {
            get { return this._platformName; }
            set { this._platformName = value; }
        }

        // Check to see if PlatformName property is set
        internal bool IsSetPlatformName()
        {
            return this._platformName != null;
        }

        /// <summary>
        /// Gets and sets the property PlatformVersion. 
        /// <para>
        /// The number, such as 1.0.2, for the new platform version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PlatformVersion
        {
            get { return this._platformVersion; }
            set { this._platformVersion = value; }
        }

        // Check to see if PlatformVersion property is set
        internal bool IsSetPlatformVersion()
        {
            return this._platformVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specifies the tags applied to the new platform version.
        /// </para>
        ///  
        /// <para>
        /// Elastic Beanstalk applies these tags only to the platform version. Environments that
        /// you create using the platform version don't inherit the tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}