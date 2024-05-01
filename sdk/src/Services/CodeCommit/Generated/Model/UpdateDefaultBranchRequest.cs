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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
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
namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDefaultBranch operation.
    /// Sets or changes the default branch name for the specified repository.
    /// 
    ///  <note> 
    /// <para>
    /// If you use this operation to change the default branch name to the current default
    /// branch name, a success message is returned even though the default branch did not
    /// change.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateDefaultBranchRequest : AmazonCodeCommitRequest
    {
        private string _defaultBranchName;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property DefaultBranchName. 
        /// <para>
        /// The name of the branch to set as the default branch.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string DefaultBranchName
        {
            get { return this._defaultBranchName; }
            set { this._defaultBranchName = value; }
        }

        // Check to see if DefaultBranchName property is set
        internal bool IsSetDefaultBranchName()
        {
            return this._defaultBranchName != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository for which you want to set or change the default branch.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string RepositoryName
        {
            get { return this._repositoryName; }
            set { this._repositoryName = value; }
        }

        // Check to see if RepositoryName property is set
        internal bool IsSetRepositoryName()
        {
            return this._repositoryName != null;
        }

    }
}