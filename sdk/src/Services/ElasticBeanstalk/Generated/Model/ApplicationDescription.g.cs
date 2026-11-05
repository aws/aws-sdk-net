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
    /// Describes the properties of an application.
    /// </summary>
    public partial class ApplicationDescription
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public ApplicationDescription() { }

        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the application.
        /// </para>
        /// </summary>
        public string ApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationArn property is set.
        /// </summary>
        internal bool IsSetApplicationArn() => this.ApplicationArn != null;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property ConfigurationTemplates. 
        /// <para>
        /// The names of the configuration templates associated with this application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ConfigurationTemplates { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ConfigurationTemplates property is set.
        /// </summary>
        internal bool IsSetConfigurationTemplates() => this.ConfigurationTemplates != null && (this.ConfigurationTemplates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The date when the application was created.
        /// </para>
        /// </summary>
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Checks to see if the DateCreated property is set.
        /// </summary>
        internal bool IsSetDateCreated() => this.DateCreated.HasValue;

        /// <summary>
        /// Gets and sets the property DateUpdated. 
        /// <para>
        /// The date when the application was last modified.
        /// </para>
        /// </summary>
        public DateTime? DateUpdated { get; set; }

        /// <summary>
        /// Checks to see if the DateUpdated property is set.
        /// </summary>
        internal bool IsSetDateUpdated() => this.DateUpdated.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// User-defined description of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ResourceLifecycleConfig. 
        /// <para>
        /// The lifecycle settings for the application.
        /// </para>
        /// </summary>
        public ApplicationResourceLifecycleConfig ResourceLifecycleConfig { get; set; }

        /// <summary>
        /// Checks to see if the ResourceLifecycleConfig property is set.
        /// </summary>
        internal bool IsSetResourceLifecycleConfig() => this.ResourceLifecycleConfig != null;

        /// <summary>
        /// Gets and sets the property Versions. 
        /// <para>
        /// The names of the versions for this application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Versions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Versions property is set.
        /// </summary>
        internal bool IsSetVersions() => this.Versions != null && (this.Versions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
