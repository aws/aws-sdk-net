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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
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
    /// Container for the parameters to the CreateHostedConfigurationVersion operation.
    /// Creates a new configuration in the AppConfig hosted configuration store. If you're
    /// creating a feature flag, we recommend you familiarize yourself with the JSON schema
    /// for feature flag data. For more information, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/appconfig-creating-configuration-and-profile-feature-flags.html#appconfig-type-reference-feature-flags">Type
    /// reference for AWS.AppConfig.FeatureFlags</a> in the <i>AppConfig User Guide</i>.
    /// </summary>
    public partial class CreateHostedConfigurationVersionRequest : AmazonAppConfigRequest
    {
        private string _applicationId;
        private string _configurationProfileId;
        private MemoryStream _content;
        private string _contentType;
        private string _description;
        private int? _latestVersionNumber;
        private string _versionLabel;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The application ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationProfileId. 
        /// <para>
        /// The configuration profile ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConfigurationProfileId
        {
            get { return this._configurationProfileId; }
            set { this._configurationProfileId = value; }
        }

        // Check to see if ConfigurationProfileId property is set
        internal bool IsSetConfigurationProfileId()
        {
            return this._configurationProfileId != null;
        }

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
        [AWSProperty(Required=true, Sensitive=true)]
        public MemoryStream Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// A standard MIME type describing the format of the configuration content. For more
        /// information, see <a href="https://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.17">Content-Type</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return !string.IsNullOrEmpty(this._contentType);
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return !string.IsNullOrEmpty(this._description);
        }

        /// <summary>
        /// Gets and sets the property LatestVersionNumber. 
        /// <para>
        /// An optional locking token used to prevent race conditions from overwriting configuration
        /// updates when creating a new version. To ensure your data is not overwritten when creating
        /// multiple hosted configuration versions in rapid succession, specify the version number
        /// of the latest hosted configuration version.
        /// </para>
        /// </summary>
        public int LatestVersionNumber
        {
            get { return this._latestVersionNumber.GetValueOrDefault(); }
            set { this._latestVersionNumber = value; }
        }

        // Check to see if LatestVersionNumber property is set
        internal bool IsSetLatestVersionNumber()
        {
            return this._latestVersionNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VersionLabel. 
        /// <para>
        /// An optional, user-defined label for the AppConfig hosted configuration version. This
        /// value must contain at least one non-numeric character. For example, "v2.2.0".
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string VersionLabel
        {
            get { return this._versionLabel; }
            set { this._versionLabel = value; }
        }

        // Check to see if VersionLabel property is set
        internal bool IsSetVersionLabel()
        {
            return !string.IsNullOrEmpty(this._versionLabel);
        }

    }
}