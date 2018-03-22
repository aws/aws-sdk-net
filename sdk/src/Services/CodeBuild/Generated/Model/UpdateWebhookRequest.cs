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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateWebhook operation.
    /// Updates the webhook associated with an AWS CodeBuild build project.
    /// </summary>
    public partial class UpdateWebhookRequest : AmazonCodeBuildRequest
    {
        private string _branchFilter;
        private string _projectName;
        private bool? _rotateSecret;

        /// <summary>
        /// Gets and sets the property BranchFilter. 
        /// <para>
        /// A regular expression used to determine which branches in a repository are built when
        /// a webhook is triggered. If the name of a branch matches the regular expression, then
        /// it is built. If it doesn't match, then it is not. If branchFilter is empty, then all
        /// branches are built.
        /// </para>
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
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the AWS CodeBuild project.
        /// </para>
        /// </summary>
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
        ///  A boolean value that specifies whether the associated repository's secret token should
        /// be updated. 
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