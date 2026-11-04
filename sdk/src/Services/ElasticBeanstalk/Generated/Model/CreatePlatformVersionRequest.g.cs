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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the CreatePlatformVersion operation. Create a new
    /// version of your custom platform.
    /// </summary>
    public partial class CreatePlatformVersionRequest : AmazonElasticBeanstalkRequest
    {
        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the builder environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 40)]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentName property is set.
        /// </summary>
        internal bool IsSetEnvironmentName() => this.EnvironmentName != null;

        /// <summary>
        /// Gets and sets the property OptionSettings. 
        /// <para>
        /// The configuration option settings to apply to the builder environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConfigurationOptionSetting> OptionSettings { get; set; } = AWSConfigs.InitializeCollections ? new List<ConfigurationOptionSetting>() : null;

        /// <summary>
        /// Checks to see if the OptionSettings property is set.
        /// </summary>
        internal bool IsSetOptionSettings() => this.OptionSettings != null && (this.OptionSettings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PlatformDefinitionBundle. 
        /// <para>
        /// The location of the platform definition archive in Amazon S3.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public S3Location PlatformDefinitionBundle { get; set; }

        /// <summary>
        /// Checks to see if the PlatformDefinitionBundle property is set.
        /// </summary>
        internal bool IsSetPlatformDefinitionBundle() => this.PlatformDefinitionBundle != null;

        /// <summary>
        /// Gets and sets the property PlatformName. 
        /// <para>
        /// The name of your custom platform.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PlatformName { get; set; }

        /// <summary>
        /// Checks to see if the PlatformName property is set.
        /// </summary>
        internal bool IsSetPlatformName() => this.PlatformName != null;

        /// <summary>
        /// Gets and sets the property PlatformVersion. 
        /// <para>
        /// The number, such as 1.0.2, for the new platform version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PlatformVersion { get; set; }

        /// <summary>
        /// Checks to see if the PlatformVersion property is set.
        /// </summary>
        internal bool IsSetPlatformVersion() => this.PlatformVersion != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
