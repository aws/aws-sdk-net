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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateBranch operation.
    /// Updates a branch for an Amplify app.
    /// </summary>
    public partial class UpdateBranchRequest : AmazonAmplifyRequest
    {
        private string _appId;
        private string _backendEnvironmentArn;
        private string _basicAuthCredentials;
        private string _branchName;
        private string _buildSpec;
        private string _description;
        private string _displayName;
        private bool? _enableAutoBuild;
        private bool? _enableBasicAuth;
        private bool? _enableNotification;
        private bool? _enablePerformanceMode;
        private bool? _enablePullRequestPreview;
        private Dictionary<string, string> _environmentVariables = new Dictionary<string, string>();
        private string _framework;
        private string _pullRequestEnvironmentName;
        private Stage _stage;
        private string _ttl;

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        ///  The unique ID for an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }

        /// <summary>
        /// Gets and sets the property BackendEnvironmentArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) for a backend environment that is part of an Amplify
        /// app. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string BackendEnvironmentArn
        {
            get { return this._backendEnvironmentArn; }
            set { this._backendEnvironmentArn = value; }
        }

        // Check to see if BackendEnvironmentArn property is set
        internal bool IsSetBackendEnvironmentArn()
        {
            return this._backendEnvironmentArn != null;
        }

        /// <summary>
        /// Gets and sets the property BasicAuthCredentials. 
        /// <para>
        ///  The basic authorization credentials for the branch. You must base64-encode the authorization
        /// credentials and provide them in the format <code>user:password</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=2000)]
        public string BasicAuthCredentials
        {
            get { return this._basicAuthCredentials; }
            set { this._basicAuthCredentials = value; }
        }

        // Check to see if BasicAuthCredentials property is set
        internal bool IsSetBasicAuthCredentials()
        {
            return this._basicAuthCredentials != null;
        }

        /// <summary>
        /// Gets and sets the property BranchName. 
        /// <para>
        ///  The name for the branch. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string BranchName
        {
            get { return this._branchName; }
            set { this._branchName = value; }
        }

        // Check to see if BranchName property is set
        internal bool IsSetBranchName()
        {
            return this._branchName != null;
        }

        /// <summary>
        /// Gets and sets the property BuildSpec. 
        /// <para>
        ///  The build specification (build spec) for the branch. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=25000)]
        public string BuildSpec
        {
            get { return this._buildSpec; }
            set { this._buildSpec = value; }
        }

        // Check to see if BuildSpec property is set
        internal bool IsSetBuildSpec()
        {
            return this._buildSpec != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description for the branch. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        ///  The display name for a branch. This is used as the default domain prefix. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property EnableAutoBuild. 
        /// <para>
        ///  Enables auto building for the branch. 
        /// </para>
        /// </summary>
        public bool EnableAutoBuild
        {
            get { return this._enableAutoBuild.GetValueOrDefault(); }
            set { this._enableAutoBuild = value; }
        }

        // Check to see if EnableAutoBuild property is set
        internal bool IsSetEnableAutoBuild()
        {
            return this._enableAutoBuild.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableBasicAuth. 
        /// <para>
        ///  Enables basic authorization for the branch. 
        /// </para>
        /// </summary>
        public bool EnableBasicAuth
        {
            get { return this._enableBasicAuth.GetValueOrDefault(); }
            set { this._enableBasicAuth = value; }
        }

        // Check to see if EnableBasicAuth property is set
        internal bool IsSetEnableBasicAuth()
        {
            return this._enableBasicAuth.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableNotification. 
        /// <para>
        ///  Enables notifications for the branch. 
        /// </para>
        /// </summary>
        public bool EnableNotification
        {
            get { return this._enableNotification.GetValueOrDefault(); }
            set { this._enableNotification = value; }
        }

        // Check to see if EnableNotification property is set
        internal bool IsSetEnableNotification()
        {
            return this._enableNotification.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnablePerformanceMode. 
        /// <para>
        /// Enables performance mode for the branch.
        /// </para>
        ///  
        /// <para>
        /// Performance mode optimizes for faster hosting performance by keeping content cached
        /// at the edge for a longer interval. When performance mode is enabled, hosting configuration
        /// or code changes can take up to 10 minutes to roll out. 
        /// </para>
        /// </summary>
        public bool EnablePerformanceMode
        {
            get { return this._enablePerformanceMode.GetValueOrDefault(); }
            set { this._enablePerformanceMode = value; }
        }

        // Check to see if EnablePerformanceMode property is set
        internal bool IsSetEnablePerformanceMode()
        {
            return this._enablePerformanceMode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnablePullRequestPreview. 
        /// <para>
        ///  Enables pull request previews for this branch. 
        /// </para>
        /// </summary>
        public bool EnablePullRequestPreview
        {
            get { return this._enablePullRequestPreview.GetValueOrDefault(); }
            set { this._enablePullRequestPreview = value; }
        }

        // Check to see if EnablePullRequestPreview property is set
        internal bool IsSetEnablePullRequestPreview()
        {
            return this._enablePullRequestPreview.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        ///  The environment variables for the branch. 
        /// </para>
        /// </summary>
        public Dictionary<string, string> EnvironmentVariables
        {
            get { return this._environmentVariables; }
            set { this._environmentVariables = value; }
        }

        // Check to see if EnvironmentVariables property is set
        internal bool IsSetEnvironmentVariables()
        {
            return this._environmentVariables != null && this._environmentVariables.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Framework. 
        /// <para>
        ///  The framework for the branch. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string Framework
        {
            get { return this._framework; }
            set { this._framework = value; }
        }

        // Check to see if Framework property is set
        internal bool IsSetFramework()
        {
            return this._framework != null;
        }

        /// <summary>
        /// Gets and sets the property PullRequestEnvironmentName. 
        /// <para>
        ///  The Amplify environment name for the pull request. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=20)]
        public string PullRequestEnvironmentName
        {
            get { return this._pullRequestEnvironmentName; }
            set { this._pullRequestEnvironmentName = value; }
        }

        // Check to see if PullRequestEnvironmentName property is set
        internal bool IsSetPullRequestEnvironmentName()
        {
            return this._pullRequestEnvironmentName != null;
        }

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        ///  Describes the current stage for the branch. 
        /// </para>
        /// </summary>
        public Stage Stage
        {
            get { return this._stage; }
            set { this._stage = value; }
        }

        // Check to see if Stage property is set
        internal bool IsSetStage()
        {
            return this._stage != null;
        }

        /// <summary>
        /// Gets and sets the property Ttl. 
        /// <para>
        ///  The content Time to Live (TTL) for the website in seconds. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=32)]
        public string Ttl
        {
            get { return this._ttl; }
            set { this._ttl = value; }
        }

        // Check to see if Ttl property is set
        internal bool IsSetTtl()
        {
            return this._ttl != null;
        }

    }
}