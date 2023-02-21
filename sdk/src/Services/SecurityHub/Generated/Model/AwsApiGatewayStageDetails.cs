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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides information about a version 1 Amazon API Gateway stage.
    /// </summary>
    public partial class AwsApiGatewayStageDetails
    {
        private AwsApiGatewayAccessLogSettings _accessLogSettings;
        private bool? _cacheClusterEnabled;
        private string _cacheClusterSize;
        private string _cacheClusterStatus;
        private AwsApiGatewayCanarySettings _canarySettings;
        private string _clientCertificateId;
        private string _createdDate;
        private string _deploymentId;
        private string _description;
        private string _documentationVersion;
        private string _lastUpdatedDate;
        private List<AwsApiGatewayMethodSettings> _methodSettings = new List<AwsApiGatewayMethodSettings>();
        private string _stageName;
        private bool? _tracingEnabled;
        private Dictionary<string, string> _variables = new Dictionary<string, string>();
        private string _webAclArn;

        /// <summary>
        /// Gets and sets the property AccessLogSettings. 
        /// <para>
        /// Settings for logging access for the stage.
        /// </para>
        /// </summary>
        public AwsApiGatewayAccessLogSettings AccessLogSettings
        {
            get { return this._accessLogSettings; }
            set { this._accessLogSettings = value; }
        }

        // Check to see if AccessLogSettings property is set
        internal bool IsSetAccessLogSettings()
        {
            return this._accessLogSettings != null;
        }

        /// <summary>
        /// Gets and sets the property CacheClusterEnabled. 
        /// <para>
        /// Indicates whether a cache cluster is enabled for the stage.
        /// </para>
        /// </summary>
        public bool CacheClusterEnabled
        {
            get { return this._cacheClusterEnabled.GetValueOrDefault(); }
            set { this._cacheClusterEnabled = value; }
        }

        // Check to see if CacheClusterEnabled property is set
        internal bool IsSetCacheClusterEnabled()
        {
            return this._cacheClusterEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CacheClusterSize. 
        /// <para>
        /// If a cache cluster is enabled, the size of the cache cluster.
        /// </para>
        /// </summary>
        public string CacheClusterSize
        {
            get { return this._cacheClusterSize; }
            set { this._cacheClusterSize = value; }
        }

        // Check to see if CacheClusterSize property is set
        internal bool IsSetCacheClusterSize()
        {
            return this._cacheClusterSize != null;
        }

        /// <summary>
        /// Gets and sets the property CacheClusterStatus. 
        /// <para>
        /// If a cache cluster is enabled, the status of the cache cluster.
        /// </para>
        /// </summary>
        public string CacheClusterStatus
        {
            get { return this._cacheClusterStatus; }
            set { this._cacheClusterStatus = value; }
        }

        // Check to see if CacheClusterStatus property is set
        internal bool IsSetCacheClusterStatus()
        {
            return this._cacheClusterStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CanarySettings. 
        /// <para>
        /// Information about settings for canary deployment in the stage.
        /// </para>
        /// </summary>
        public AwsApiGatewayCanarySettings CanarySettings
        {
            get { return this._canarySettings; }
            set { this._canarySettings = value; }
        }

        // Check to see if CanarySettings property is set
        internal bool IsSetCanarySettings()
        {
            return this._canarySettings != null;
        }

        /// <summary>
        /// Gets and sets the property ClientCertificateId. 
        /// <para>
        /// The identifier of the client certificate for the stage.
        /// </para>
        /// </summary>
        public string ClientCertificateId
        {
            get { return this._clientCertificateId; }
            set { this._clientCertificateId = value; }
        }

        // Check to see if ClientCertificateId property is set
        internal bool IsSetClientCertificateId()
        {
            return this._clientCertificateId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// Indicates when the stage was created.
        /// </para>
        ///  
        /// <para>
        /// Uses the <code>date-time</code> format specified in <a href="https://tools.ietf.org/html/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. The value cannot contain spaces,
        /// and date and time should be separated by <code>T</code>. For example, <code>2020-03-22T13:22:13.933Z</code>.
        /// </para>
        /// </summary>
        public string CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        /// The identifier of the deployment that the stage points to.
        /// </para>
        /// </summary>
        public string DeploymentId
        {
            get { return this._deploymentId; }
            set { this._deploymentId = value; }
        }

        // Check to see if DeploymentId property is set
        internal bool IsSetDeploymentId()
        {
            return this._deploymentId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the stage.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DocumentationVersion. 
        /// <para>
        /// The version of the API documentation that is associated with the stage.
        /// </para>
        /// </summary>
        public string DocumentationVersion
        {
            get { return this._documentationVersion; }
            set { this._documentationVersion = value; }
        }

        // Check to see if DocumentationVersion property is set
        internal bool IsSetDocumentationVersion()
        {
            return this._documentationVersion != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// Indicates when the stage was most recently updated.
        /// </para>
        ///  
        /// <para>
        /// Uses the <code>date-time</code> format specified in <a href="https://tools.ietf.org/html/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. The value cannot contain spaces,
        /// and date and time should be separated by <code>T</code>. For example, <code>2020-03-22T13:22:13.933Z</code>.
        /// </para>
        /// </summary>
        public string LastUpdatedDate
        {
            get { return this._lastUpdatedDate; }
            set { this._lastUpdatedDate = value; }
        }

        // Check to see if LastUpdatedDate property is set
        internal bool IsSetLastUpdatedDate()
        {
            return this._lastUpdatedDate != null;
        }

        /// <summary>
        /// Gets and sets the property MethodSettings. 
        /// <para>
        /// Defines the method settings for the stage.
        /// </para>
        /// </summary>
        public List<AwsApiGatewayMethodSettings> MethodSettings
        {
            get { return this._methodSettings; }
            set { this._methodSettings = value; }
        }

        // Check to see if MethodSettings property is set
        internal bool IsSetMethodSettings()
        {
            return this._methodSettings != null && this._methodSettings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StageName. 
        /// <para>
        /// The name of the stage.
        /// </para>
        /// </summary>
        public string StageName
        {
            get { return this._stageName; }
            set { this._stageName = value; }
        }

        // Check to see if StageName property is set
        internal bool IsSetStageName()
        {
            return this._stageName != null;
        }

        /// <summary>
        /// Gets and sets the property TracingEnabled. 
        /// <para>
        /// Indicates whether active tracing with X-Ray is enabled for the stage.
        /// </para>
        /// </summary>
        public bool TracingEnabled
        {
            get { return this._tracingEnabled.GetValueOrDefault(); }
            set { this._tracingEnabled = value; }
        }

        // Check to see if TracingEnabled property is set
        internal bool IsSetTracingEnabled()
        {
            return this._tracingEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Variables. 
        /// <para>
        /// A map that defines the stage variables for the stage.
        /// </para>
        ///  
        /// <para>
        /// Variable names can have alphanumeric and underscore characters.
        /// </para>
        ///  
        /// <para>
        /// Variable values can contain the following characters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Uppercase and lowercase letters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Numbers
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Special characters -._~:/?#&amp;=,
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Dictionary<string, string> Variables
        {
            get { return this._variables; }
            set { this._variables = value; }
        }

        // Check to see if Variables property is set
        internal bool IsSetVariables()
        {
            return this._variables != null && this._variables.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WebAclArn. 
        /// <para>
        /// The ARN of the web ACL associated with the stage.
        /// </para>
        /// </summary>
        public string WebAclArn
        {
            get { return this._webAclArn; }
            set { this._webAclArn = value; }
        }

        // Check to see if WebAclArn property is set
        internal bool IsSetWebAclArn()
        {
            return this._webAclArn != null;
        }

    }
}