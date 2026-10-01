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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// This is the response object from the GetBrowserSession operation.
    /// </summary>
    public partial class GetBrowserSessionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BrowserIdentifier. 
        /// <para>
        /// The identifier of the browser.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BrowserIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the BrowserIdentifier property is set.
        /// </summary>
        internal bool IsSetBrowserIdentifier() => this.BrowserIdentifier != null;

        /// <summary>
        /// Gets and sets the property Certificates. 
        /// <para>
        /// The list of certificates installed in the browser session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public List<Certificate> Certificates { get; set; } = AWSConfigs.InitializeCollections ? new List<Certificate>() : null;

        /// <summary>
        /// Checks to see if the Certificates property is set.
        /// </summary>
        internal bool IsSetCertificates() => this.Certificates != null && (this.Certificates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the browser session was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EnterprisePolicies. 
        /// <para>
        /// A list of files containing enterprise policies for the browser session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<BrowserEnterprisePolicy> EnterprisePolicies { get; set; } = AWSConfigs.InitializeCollections ? new List<BrowserEnterprisePolicy>() : null;

        /// <summary>
        /// Checks to see if the EnterprisePolicies property is set.
        /// </summary>
        internal bool IsSetEnterprisePolicies() => this.EnterprisePolicies != null && (this.EnterprisePolicies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Extensions. 
        /// <para>
        /// The list of browser extensions that are configured in the browser session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<BrowserExtension> Extensions { get; set; } = AWSConfigs.InitializeCollections ? new List<BrowserExtension>() : null;

        /// <summary>
        /// Checks to see if the Extensions property is set.
        /// </summary>
        internal bool IsSetExtensions() => this.Extensions != null && (this.Extensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FilesystemConfigurations. 
        /// <para>
        /// The file system configurations for the browser session. Each entry describes an access
        /// point and its mount path.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<ToolsFileSystemConfiguration> FilesystemConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<ToolsFileSystemConfiguration>() : null;

        /// <summary>
        /// Checks to see if the FilesystemConfigurations property is set.
        /// </summary>
        internal bool IsSetFilesystemConfigurations() => this.FilesystemConfigurations != null && (this.FilesystemConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The time at which the browser session was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the browser session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProfileConfiguration. 
        /// <para>
        /// The browser profile configuration associated with this session. Contains the profile
        /// identifier that links to persistent browser data such as cookies and local storage.
        /// </para>
        /// </summary>
        public BrowserProfileConfiguration ProfileConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProfileConfiguration property is set.
        /// </summary>
        internal bool IsSetProfileConfiguration() => this.ProfileConfiguration != null;

        /// <summary>
        /// Gets and sets the property ProxyConfiguration. 
        /// <para>
        /// The active proxy configuration for this browser session. This field is only present
        /// if proxy configuration was provided when the session was started using <c>StartBrowserSession</c>.
        /// The configuration includes proxy servers, domain bypass rules and the proxy authentication
        /// credentials.
        /// </para>
        /// </summary>
        public ProxyConfiguration ProxyConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProxyConfiguration property is set.
        /// </summary>
        internal bool IsSetProxyConfiguration() => this.ProxyConfiguration != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier of the browser session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property SessionReplayArtifact. 
        /// <para>
        /// The artifact containing the session replay information.
        /// </para>
        /// </summary>
        public string SessionReplayArtifact { get; set; }

        /// <summary>
        /// Checks to see if the SessionReplayArtifact property is set.
        /// </summary>
        internal bool IsSetSessionReplayArtifact() => this.SessionReplayArtifact != null;

        /// <summary>
        /// Gets and sets the property SessionTimeoutSeconds. 
        /// <para>
        /// The timeout period for the browser session in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 28800)]
        public int? SessionTimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the SessionTimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetSessionTimeoutSeconds() => this.SessionTimeoutSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the browser session. Possible values include ACTIVE, STOPPING,
        /// and STOPPED.
        /// </para>
        /// </summary>
        public BrowserSessionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Streams. 
        /// <para>
        /// The streams associated with this browser session. These include the automation stream
        /// and live view stream.
        /// </para>
        /// </summary>
        public BrowserSessionStream Streams { get; set; }

        /// <summary>
        /// Checks to see if the Streams property is set.
        /// </summary>
        internal bool IsSetStreams() => this.Streams != null;

        /// <summary>
        /// Gets and sets the property ViewPort.
        /// </summary>
        public ViewPort ViewPort { get; set; }

        /// <summary>
        /// Checks to see if the ViewPort property is set.
        /// </summary>
        internal bool IsSetViewPort() => this.ViewPort != null;
    }
}
