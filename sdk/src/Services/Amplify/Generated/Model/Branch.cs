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
    /// The branch for an Amplify app, which maps to a third-party repository branch.
    /// </summary>
    public partial class Branch
    {
        private string _activeJobId;
        private List<string> _associatedResources = new List<string>();
        private string _backendEnvironmentArn;
        private string _basicAuthCredentials;
        private string _branchArn;
        private string _branchName;
        private string _buildSpec;
        private DateTime? _createTime;
        private List<string> _customDomains = new List<string>();
        private string _description;
        private string _destinationBranch;
        private string _displayName;
        private bool? _enableAutoBuild;
        private bool? _enableBasicAuth;
        private bool? _enableNotification;
        private bool? _enablePerformanceMode;
        private bool? _enablePullRequestPreview;
        private Dictionary<string, string> _environmentVariables = new Dictionary<string, string>();
        private string _framework;
        private string _pullRequestEnvironmentName;
        private string _sourceBranch;
        private Stage _stage;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _thumbnailUrl;
        private string _totalNumberOfJobs;
        private string _ttl;
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property ActiveJobId. 
        /// <para>
        ///  The ID of the active job for a branch of an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1000)]
        public string ActiveJobId
        {
            get { return this._activeJobId; }
            set { this._activeJobId = value; }
        }

        // Check to see if ActiveJobId property is set
        internal bool IsSetActiveJobId()
        {
            return this._activeJobId != null;
        }

        /// <summary>
        /// Gets and sets the property AssociatedResources. 
        /// <para>
        ///  A list of custom resources that are linked to this branch. 
        /// </para>
        /// </summary>
        public List<string> AssociatedResources
        {
            get { return this._associatedResources; }
            set { this._associatedResources = value; }
        }

        // Check to see if AssociatedResources property is set
        internal bool IsSetAssociatedResources()
        {
            return this._associatedResources != null && this._associatedResources.Count > 0; 
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
        ///  The basic authorization credentials for a branch of an Amplify app. You must base64-encode
        /// the authorization credentials and provide them in the format <code>user:password</code>.
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
        /// Gets and sets the property BranchArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) for a branch that is part of an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1000)]
        public string BranchArn
        {
            get { return this._branchArn; }
            set { this._branchArn = value; }
        }

        // Check to see if BranchArn property is set
        internal bool IsSetBranchArn()
        {
            return this._branchArn != null;
        }

        /// <summary>
        /// Gets and sets the property BranchName. 
        /// <para>
        ///  The name for the branch that is part of an Amplify app. 
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
        ///  The build specification (build spec) content for the branch of an Amplify app. 
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
        /// Gets and sets the property CreateTime. 
        /// <para>
        ///  The creation date and time for a branch that is part of an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreateTime
        {
            get { return this._createTime.GetValueOrDefault(); }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomDomains. 
        /// <para>
        ///  The custom domains for a branch of an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public List<string> CustomDomains
        {
            get { return this._customDomains; }
            set { this._customDomains = value; }
        }

        // Check to see if CustomDomains property is set
        internal bool IsSetCustomDomains()
        {
            return this._customDomains != null && this._customDomains.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description for the branch that is part of an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1000)]
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
        /// Gets and sets the property DestinationBranch. 
        /// <para>
        ///  The destination branch if the branch is a pull request branch. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DestinationBranch
        {
            get { return this._destinationBranch; }
            set { this._destinationBranch = value; }
        }

        // Check to see if DestinationBranch property is set
        internal bool IsSetDestinationBranch()
        {
            return this._destinationBranch != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        ///  The display name for the branch. This is used as the default domain prefix. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
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
        ///  Enables auto-building on push for a branch of an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        ///  Enables basic authorization for a branch of an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        ///  Enables notifications for a branch that is part of an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        ///  Enables pull request previews for the branch. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        ///  The environment variables specific to a branch of an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        ///  The framework for a branch of an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
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
        /// Gets and sets the property SourceBranch. 
        /// <para>
        ///  The source branch if the branch is a pull request branch. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string SourceBranch
        {
            get { return this._sourceBranch; }
            set { this._sourceBranch = value; }
        }

        // Check to see if SourceBranch property is set
        internal bool IsSetSourceBranch()
        {
            return this._sourceBranch != null;
        }

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        ///  The current stage for the branch that is part of an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        ///  The tag for the branch of an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ThumbnailUrl. 
        /// <para>
        ///  The thumbnail URL for the branch of an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string ThumbnailUrl
        {
            get { return this._thumbnailUrl; }
            set { this._thumbnailUrl = value; }
        }

        // Check to see if ThumbnailUrl property is set
        internal bool IsSetThumbnailUrl()
        {
            return this._thumbnailUrl != null;
        }

        /// <summary>
        /// Gets and sets the property TotalNumberOfJobs. 
        /// <para>
        ///  The total number of jobs that are part of an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1000)]
        public string TotalNumberOfJobs
        {
            get { return this._totalNumberOfJobs; }
            set { this._totalNumberOfJobs = value; }
        }

        // Check to see if TotalNumberOfJobs property is set
        internal bool IsSetTotalNumberOfJobs()
        {
            return this._totalNumberOfJobs != null;
        }

        /// <summary>
        /// Gets and sets the property Ttl. 
        /// <para>
        ///  The content Time to Live (TTL) for the website in seconds. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=32)]
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

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        ///  The last updated date and time for a branch that is part of an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime UpdateTime
        {
            get { return this._updateTime.GetValueOrDefault(); }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

    }
}