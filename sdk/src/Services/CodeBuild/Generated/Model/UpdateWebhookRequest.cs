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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateWebhook operation.
    /// Updates the webhook associated with an AWS CodeBuild build project. 
    /// 
    ///  <note> 
    /// <para>
    ///  If you use Bitbucket for your repository, <code>rotateSecret</code> is ignored. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateWebhookRequest : AmazonCodeBuildRequest
    {
        private string _branchFilter;
        private WebhookBuildType _buildType;
        private List<List<WebhookFilter>> _filterGroups = new List<List<WebhookFilter>>();
        private string _projectName;
        private bool? _rotateSecret;

        /// <summary>
        /// Gets and sets the property BranchFilter. 
        /// <para>
        /// A regular expression used to determine which repository branches are built when a
        /// webhook is triggered. If the name of a branch matches the regular expression, then
        /// it is built. If <code>branchFilter</code> is empty, then all branches are built.
        /// </para>
        ///  <note> 
        /// <para>
        ///  It is recommended that you use <code>filterGroups</code> instead of <code>branchFilter</code>.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        public string BranchFilter
        {
            get { return this._branchFilter; }
            set { this._branchFilter = value; }
        }

        // Check to see if BranchFilter property is set
        internal bool IsSetBranchFilter()
        {
            return this._branchFilter != null;
        }

        /// <summary>
        /// Gets and sets the property BuildType. 
        /// <para>
        /// Specifies the type of build this webhook will trigger.
        /// </para>
        /// </summary>
        public WebhookBuildType BuildType
        {
            get { return this._buildType; }
            set { this._buildType = value; }
        }

        // Check to see if BuildType property is set
        internal bool IsSetBuildType()
        {
            return this._buildType != null;
        }

        /// <summary>
        /// Gets and sets the property FilterGroups. 
        /// <para>
        ///  An array of arrays of <code>WebhookFilter</code> objects used to determine if a webhook
        /// event can trigger a build. A filter group must contain at least one <code>EVENT</code>
        /// <code>WebhookFilter</code>. 
        /// </para>
        /// </summary>
        public List<List<WebhookFilter>> FilterGroups
        {
            get { return this._filterGroups; }
            set { this._filterGroups = value; }
        }

        // Check to see if FilterGroups property is set
        internal bool IsSetFilterGroups()
        {
            return this._filterGroups != null && this._filterGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the AWS CodeBuild project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=255)]
        public string ProjectName
        {
            get { return this._projectName; }
            set { this._projectName = value; }
        }

        // Check to see if ProjectName property is set
        internal bool IsSetProjectName()
        {
            return this._projectName != null;
        }

        /// <summary>
        /// Gets and sets the property RotateSecret. 
        /// <para>
        ///  A boolean value that specifies whether the associated GitHub repository's secret
        /// token should be updated. If you use Bitbucket for your repository, <code>rotateSecret</code>
        /// is ignored. 
        /// </para>
        /// </summary>
        public bool RotateSecret
        {
            get { return this._rotateSecret.GetValueOrDefault(); }
            set { this._rotateSecret = value; }
        }

        // Check to see if RotateSecret property is set
        internal bool IsSetRotateSecret()
        {
            return this._rotateSecret.HasValue; 
        }

    }
}