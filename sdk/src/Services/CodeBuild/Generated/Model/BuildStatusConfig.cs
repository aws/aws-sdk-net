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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Contains information that defines how the CodeBuild build project reports the build
    /// status to the source provider.
    /// </summary>
    public partial class BuildStatusConfig
    {
        private string _context;
        private string _targetUrl;

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// Specifies the context of the build status CodeBuild sends to the source provider.
        /// The usage of this parameter depends on the source provider.
        /// </para>
        ///  <dl> <dt>Bitbucket</dt> <dd> 
        /// <para>
        /// This parameter is used for the <c>name</c> parameter in the Bitbucket commit status.
        /// For more information, see <a href="https://developer.atlassian.com/bitbucket/api/2/reference/resource/repositories/%7Bworkspace%7D/%7Brepo_slug%7D/commit/%7Bnode%7D/statuses/build">build</a>
        /// in the Bitbucket API documentation.
        /// </para>
        ///  </dd> <dt>GitHub/GitHub Enterprise Server</dt> <dd> 
        /// <para>
        /// This parameter is used for the <c>context</c> parameter in the GitHub commit status.
        /// For more information, see <a href="https://developer.github.com/v3/repos/statuses/#create-a-commit-status">Create
        /// a commit status</a> in the GitHub developer guide.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public string Context
        {
            get { return this._context; }
            set { this._context = value; }
        }

        // Check to see if Context property is set
        internal bool IsSetContext()
        {
            return this._context != null;
        }

        /// <summary>
        /// Gets and sets the property TargetUrl. 
        /// <para>
        /// Specifies the target url of the build status CodeBuild sends to the source provider.
        /// The usage of this parameter depends on the source provider.
        /// </para>
        ///  <dl> <dt>Bitbucket</dt> <dd> 
        /// <para>
        /// This parameter is used for the <c>url</c> parameter in the Bitbucket commit status.
        /// For more information, see <a href="https://developer.atlassian.com/bitbucket/api/2/reference/resource/repositories/%7Bworkspace%7D/%7Brepo_slug%7D/commit/%7Bnode%7D/statuses/build">build</a>
        /// in the Bitbucket API documentation.
        /// </para>
        ///  </dd> <dt>GitHub/GitHub Enterprise Server</dt> <dd> 
        /// <para>
        /// This parameter is used for the <c>target_url</c> parameter in the GitHub commit status.
        /// For more information, see <a href="https://developer.github.com/v3/repos/statuses/#create-a-commit-status">Create
        /// a commit status</a> in the GitHub developer guide.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public string TargetUrl
        {
            get { return this._targetUrl; }
            set { this._targetUrl = value; }
        }

        // Check to see if TargetUrl property is set
        internal bool IsSetTargetUrl()
        {
            return this._targetUrl != null;
        }

    }
}