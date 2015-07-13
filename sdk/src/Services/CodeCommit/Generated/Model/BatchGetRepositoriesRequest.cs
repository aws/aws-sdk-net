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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetRepositories operation.
    /// Gets information about one or more repositories.
    /// 
    ///  <note>
    /// <para>
    /// The description field for a repository accepts all HTML characters and all valid Unicode
    /// characters. Applications that do not HTML-encode the description and display it in
    /// a web page could expose users to potentially malicious code. Make sure that you HTML-encode
    /// the description field in any application that uses this API to display the repository
    /// description on a web page.
    /// </para>
    /// </note>
    /// </summary>
    public partial class BatchGetRepositoriesRequest : AmazonCodeCommitRequest
    {
        private List<string> _repositoryNames = new List<string>();

        /// <summary>
        /// Gets and sets the property RepositoryNames. 
        /// <para>
        /// The names of the repositories to get information about.
        /// </para>
        /// </summary>
        public List<string> RepositoryNames
        {
            get { return this._repositoryNames; }
            set { this._repositoryNames = value; }
        }

        // Check to see if RepositoryNames property is set
        internal bool IsSetRepositoryNames()
        {
            return this._repositoryNames != null && this._repositoryNames.Count > 0; 
        }

    }
}