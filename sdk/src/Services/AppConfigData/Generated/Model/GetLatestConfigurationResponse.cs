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
 * Do not modify this file. This file is generated from the appconfigdata-2021-11-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppConfigData.Model
{
    /// <summary>
    /// This is the response object from the GetLatestConfiguration operation.
    /// </summary>
    public partial class GetLatestConfigurationResponse : AmazonWebServiceResponse
    {
        private MemoryStream _configuration;
        private string _contentType;
        private string _nextPollConfigurationToken;
        private int? _nextPollIntervalInSeconds;
        private string _versionLabel;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The data of the configuration. This may be empty if the client already has the latest
        /// version of configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public MemoryStream Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// A standard MIME type describing the format of the configuration content.
        /// </para>
        /// </summary>
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property NextPollConfigurationToken. 
        /// <para>
        /// The latest token describing the current state of the configuration session. This <i>must</i>
        /// be provided to the next call to <code>GetLatestConfiguration.</code> 
        /// </para>
        ///  <important> 
        /// <para>
        /// This token should only be used once. To support long poll use cases, the token is
        /// valid for up to 24 hours. If a <code>GetLatestConfiguration</code> call uses an expired
        /// token, the system returns <code>BadRequestException</code>.
        /// </para>
        ///  </important>
        /// </summary>
        public string NextPollConfigurationToken
        {
            get { return this._nextPollConfigurationToken; }
            set { this._nextPollConfigurationToken = value; }
        }

        // Check to see if NextPollConfigurationToken property is set
        internal bool IsSetNextPollConfigurationToken()
        {
            return this._nextPollConfigurationToken != null;
        }

        /// <summary>
        /// Gets and sets the property NextPollIntervalInSeconds. 
        /// <para>
        /// The amount of time the client should wait before polling for configuration updates
        /// again. Use <code>RequiredMinimumPollIntervalInSeconds</code> to set the desired poll
        /// interval.
        /// </para>
        /// </summary>
        public int NextPollIntervalInSeconds
        {
            get { return this._nextPollIntervalInSeconds.GetValueOrDefault(); }
            set { this._nextPollIntervalInSeconds = value; }
        }

        // Check to see if NextPollIntervalInSeconds property is set
        internal bool IsSetNextPollIntervalInSeconds()
        {
            return this._nextPollIntervalInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VersionLabel. 
        /// <para>
        /// The user-defined label for the AppConfig hosted configuration version. This attribute
        /// doesn't apply if the configuration is not from an AppConfig hosted configuration version.
        /// If the client already has the latest version of the configuration data, this value
        /// is empty.
        /// </para>
        /// </summary>
        public string VersionLabel
        {
            get { return this._versionLabel; }
            set { this._versionLabel = value; }
        }

        // Check to see if VersionLabel property is set
        internal bool IsSetVersionLabel()
        {
            return this._versionLabel != null;
        }

    }
}