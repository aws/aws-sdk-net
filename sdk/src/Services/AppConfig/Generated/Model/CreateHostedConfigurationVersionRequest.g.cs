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

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Container for the parameters to the CreateHostedConfigurationVersion operation. Creates
    /// a new configuration in the AppConfig hosted configuration store. If you're creating
    /// a feature flag, we recommend you familiarize yourself with the JSON schema for feature
    /// flag data. For more information, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/appconfig-type-reference-feature-flags.html">Type
    /// reference for AWS.AppConfig.FeatureFlags</a> in the <i>AppConfig User Guide</i>.
    /// </summary>
    public partial class CreateHostedConfigurationVersionRequest : AmazonAppConfigRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The application ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property ConfigurationProfileId. 
        /// <para>
        /// The configuration profile ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ConfigurationProfileId { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationProfileId property is set.
        /// </summary>
        internal bool IsSetConfigurationProfileId() => this.ConfigurationProfileId != null;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The configuration data, as bytes.
        /// </para>
        ///  <note> 
        /// <para>
        /// AppConfig accepts any type of data, including text formats like JSON or TOML, or binary
        /// formats like protocol buffers or compressed data.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public MemoryStream Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// A standard MIME type describing the format of the configuration content. For more
        /// information, see <a href="https://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.17">Content-Type</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the configuration.
        /// </para>
        ///  <note> 
        /// <para>
        /// Due to HTTP limitations, this field only supports ASCII characters.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LatestVersionNumber. 
        /// <para>
        /// An optional locking token used to prevent race conditions from overwriting configuration
        /// updates when creating a new version. To ensure your data is not overwritten when creating
        /// multiple hosted configuration versions in rapid succession, specify the version number
        /// of the latest hosted configuration version.
        /// </para>
        /// </summary>
        public int? LatestVersionNumber { get; set; }

        /// <summary>
        /// Checks to see if the LatestVersionNumber property is set.
        /// </summary>
        internal bool IsSetLatestVersionNumber() => this.LatestVersionNumber.HasValue;

        /// <summary>
        /// Gets and sets the property VersionLabel. 
        /// <para>
        /// An optional, user-defined label for the AppConfig hosted configuration version. This
        /// value must contain at least one non-numeric character. For example, "v2.2.0".
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string VersionLabel { get; set; }

        /// <summary>
        /// Checks to see if the VersionLabel property is set.
        /// </summary>
        internal bool IsSetVersionLabel() => this.VersionLabel != null;
    }
}
