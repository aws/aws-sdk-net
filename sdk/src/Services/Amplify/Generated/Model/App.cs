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
    /// Amplify App represents different branches of a repository for building, deploying,
    /// and hosting.
    /// </summary>
    public partial class App
    {
        private string _appArn;
        private string _appId;
        private string _basicAuthCredentials;
        private string _buildSpec;
        private DateTime? _createTime;
        private List<CustomRule> _customRules = new List<CustomRule>();
        private string _defaultDomain;
        private string _description;
        private bool? _enableBasicAuth;
        private bool? _enableBranchAutoBuild;
        private Dictionary<string, string> _environmentVariables = new Dictionary<string, string>();
        private string _iamServiceRoleArn;
        private string _name;
        private Platform _platform;
        private ProductionBranch _productionBranch;
        private string _repository;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property AppArn. 
        /// <para>
        ///  ARN for the Amplify App. 
        /// </para>
        /// </summary>
        public string AppArn
        {
            get { return this._appArn; }
            set { this._appArn = value; }
        }

        // Check to see if AppArn property is set
        internal bool IsSetAppArn()
        {
            return this._appArn != null;
        }

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        ///  Unique Id for the Amplify App. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property BasicAuthCredentials. 
        /// <para>
        ///  Basic Authorization credentials for branches for the Amplify App. 
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
        /// Gets and sets the property BuildSpec. 
        /// <para>
        ///  BuildSpec content for Amplify App. 
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
        ///  Create date / time for the Amplify App. 
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
        /// Gets and sets the property CustomRules. 
        /// <para>
        ///  Custom redirect / rewrite rules for the Amplify App. 
        /// </para>
        /// </summary>
        public List<CustomRule> CustomRules
        {
            get { return this._customRules; }
            set { this._customRules = value; }
        }

        // Check to see if CustomRules property is set
        internal bool IsSetCustomRules()
        {
            return this._customRules != null && this._customRules.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DefaultDomain. 
        /// <para>
        ///  Default domain for the Amplify App. 
        /// </para>
        /// </summary>
        public string DefaultDomain
        {
            get { return this._defaultDomain; }
            set { this._defaultDomain = value; }
        }

        // Check to see if DefaultDomain property is set
        internal bool IsSetDefaultDomain()
        {
            return this._defaultDomain != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  Description for the Amplify App. 
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
        /// Gets and sets the property EnableBasicAuth. 
        /// <para>
        ///  Enables Basic Authorization for branches for the Amplify App. 
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
        /// Gets and sets the property EnableBranchAutoBuild. 
        /// <para>
        ///  Enables auto-building of branches for the Amplify App. 
        /// </para>
        /// </summary>
        public bool EnableBranchAutoBuild
        {
            get { return this._enableBranchAutoBuild.GetValueOrDefault(); }
            set { this._enableBranchAutoBuild = value; }
        }

        // Check to see if EnableBranchAutoBuild property is set
        internal bool IsSetEnableBranchAutoBuild()
        {
            return this._enableBranchAutoBuild.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        ///  Environment Variables for the Amplify App. 
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
        /// Gets and sets the property IamServiceRoleArn. 
        /// <para>
        ///  IAM service role ARN for the Amplify App. 
        /// </para>
        /// </summary>
        public string IamServiceRoleArn
        {
            get { return this._iamServiceRoleArn; }
            set { this._iamServiceRoleArn = value; }
        }

        // Check to see if IamServiceRoleArn property is set
        internal bool IsSetIamServiceRoleArn()
        {
            return this._iamServiceRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  Name for the Amplify App. 
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        ///  Platform for the Amplify App. 
        /// </para>
        /// </summary>
        public Platform Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property ProductionBranch. 
        /// <para>
        ///  Structure with Production Branch information. 
        /// </para>
        /// </summary>
        public ProductionBranch ProductionBranch
        {
            get { return this._productionBranch; }
            set { this._productionBranch = value; }
        }

        // Check to see if ProductionBranch property is set
        internal bool IsSetProductionBranch()
        {
            return this._productionBranch != null;
        }

        /// <summary>
        /// Gets and sets the property Repository. 
        /// <para>
        ///  Repository for the Amplify App. 
        /// </para>
        /// </summary>
        public string Repository
        {
            get { return this._repository; }
            set { this._repository = value; }
        }

        // Check to see if Repository property is set
        internal bool IsSetRepository()
        {
            return this._repository != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  Tag for Amplify App. 
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
        /// Gets and sets the property UpdateTime. 
        /// <para>
        ///  Update date / time for the Amplify App. 
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