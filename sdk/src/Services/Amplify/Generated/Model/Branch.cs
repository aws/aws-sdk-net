/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Branch for an Amplify App, which maps to a 3rd party repository branch.
    /// </summary>
    public partial class Branch
    {
        private string _activeJobId;
        private string _basicAuthCredentials;
        private string _branchArn;
        private string _branchName;
        private string _buildSpec;
        private DateTime? _createTime;
        private List<string> _customDomains = new List<string>();
        private string _description;
        private string _displayName;
        private bool? _enableAutoBuild;
        private bool? _enableBasicAuth;
        private bool? _enableNotification;
        private Dictionary<string, string> _environmentVariables = new Dictionary<string, string>();
        private string _framework;
        private Stage _stage;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _thumbnailUrl;
        private string _totalNumberOfJobs;
        private string _ttl;
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property ActiveJobId. 
        /// <para>
        ///  Id of the active job for a branch, part of an Amplify App. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property BasicAuthCredentials. 
        /// <para>
        ///  Basic Authorization credentials for a branch, part of an Amplify App. 
        /// </para>
        /// </summary>
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
        ///  ARN for a branch, part of an Amplify App. 
        /// </para>
        /// </summary>
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
        ///  Name for a branch, part of an Amplify App. 
        /// </para>
        /// </summary>
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
        ///  BuildSpec content for branch for Amplify App. 
        /// </para>
        /// </summary>
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
        ///  Creation date and time for a branch, part of an Amplify App. 
        /// </para>
        /// </summary>
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
        ///  Custom domains for a branch, part of an Amplify App. 
        /// </para>
        /// </summary>
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
        ///  Description for a branch, part of an Amplify App. 
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        ///  Display name for a branch, part of an Amplify App. 
        /// </para>
        /// </summary>
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
        ///  Enables auto-building on push for a branch, part of an Amplify App. 
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
        ///  Enables Basic Authorization for a branch, part of an Amplify App. 
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
        ///  Enables notifications for a branch, part of an Amplify App. 
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
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        ///  Environment Variables specific to a branch, part of an Amplify App. 
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
        ///  Framework for a branch, part of an Amplify App. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Stage. 
        /// <para>
        ///  Stage for a branch, part of an Amplify App. 
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
        /// Gets and sets the property Tags. 
        /// <para>
        ///  Tag for branch for Amplify App. 
        /// </para>
        /// </summary>
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
        ///  Thumbnail Url for the branch. 
        /// </para>
        /// </summary>
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
        ///  Total number of Jobs part of an Amplify App. 
        /// </para>
        /// </summary>
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
        ///  The content TTL for the website in seconds. 
        /// </para>
        /// </summary>
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
        ///  Last updated date and time for a branch, part of an Amplify App. 
        /// </para>
        /// </summary>
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