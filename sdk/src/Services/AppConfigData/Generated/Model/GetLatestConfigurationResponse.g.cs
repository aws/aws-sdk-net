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

namespace Amazon.AppConfigData.Model
{
    /// <summary>
    /// This is the response object from the GetLatestConfiguration operation.
    /// </summary>
    public partial class GetLatestConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The data of the configuration. This may be empty if the client already has the latest
        /// version of configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public MemoryStream Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// A standard MIME type describing the format of the configuration content.
        /// </para>
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property NextPollConfigurationToken. 
        /// <para>
        /// The latest token describing the current state of the configuration session. This <i>must</i>
        /// be provided to the next call to <c>GetLatestConfiguration.</c> 
        /// </para>
        ///  <important> 
        /// <para>
        /// This token should only be used once. To support long poll use cases, the token is
        /// valid for up to 24 hours. If a <c>GetLatestConfiguration</c> call uses an expired
        /// token, the system returns <c>BadRequestException</c>.
        /// </para>
        ///  </important>
        /// </summary>
        public string NextPollConfigurationToken { get; set; }

        /// <summary>
        /// Checks to see if the NextPollConfigurationToken property is set.
        /// </summary>
        internal bool IsSetNextPollConfigurationToken() => this.NextPollConfigurationToken != null;

        /// <summary>
        /// Gets and sets the property NextPollIntervalInSeconds. 
        /// <para>
        /// The amount of time the client should wait before polling for configuration updates
        /// again. Use <c>RequiredMinimumPollIntervalInSeconds</c> to set the desired poll interval.
        /// </para>
        /// </summary>
        public int? NextPollIntervalInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the NextPollIntervalInSeconds property is set.
        /// </summary>
        internal bool IsSetNextPollIntervalInSeconds() => this.NextPollIntervalInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property VersionLabel. 
        /// <para>
        /// The user-defined label for the AppConfig hosted configuration version. This attribute
        /// doesn't apply if the configuration is not from an AppConfig hosted configuration version.
        /// If the client already has the latest version of the configuration data, this value
        /// is empty.
        /// </para>
        /// </summary>
        public string VersionLabel { get; set; }

        /// <summary>
        /// Checks to see if the VersionLabel property is set.
        /// </summary>
        internal bool IsSetVersionLabel() => this.VersionLabel != null;
    }
}
