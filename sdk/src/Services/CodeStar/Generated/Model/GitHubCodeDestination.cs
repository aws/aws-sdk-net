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
 * Do not modify this file. This file is generated from the codestar-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeStar.Model
{
    /// <summary>
    /// Information about the GitHub repository to be created in AWS CodeStar. This is where
    /// the source code files provided with the project request will be uploaded after project
    /// creation.
    /// </summary>
    public partial class GitHubCodeDestination
    {
        private string _description;
        private bool? _issuesEnabled;
        private string _name;
        private string _owner;
        private bool? _privateRepository;
        private string _token;
        private string _type;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description for the GitHub repository to be created in AWS CodeStar. This description
        /// displays in GitHub after the repository is created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// Gets and sets the property IssuesEnabled. 
        /// <para>
        /// Whether to enable issues for the GitHub repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool IssuesEnabled
        {
            get { return this._issuesEnabled.GetValueOrDefault(); }
            set { this._issuesEnabled = value; }
        }

        // Check to see if IssuesEnabled property is set
        internal bool IsSetIssuesEnabled()
        {
            return this._issuesEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the GitHub repository to be created in AWS CodeStar.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property Owner. 
        /// <para>
        /// The GitHub username for the owner of the GitHub repository to be created in AWS CodeStar.
        /// If this repository should be owned by a GitHub organization, provide its name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateRepository. 
        /// <para>
        /// Whether the GitHub repository is to be a private repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool PrivateRepository
        {
            get { return this._privateRepository.GetValueOrDefault(); }
            set { this._privateRepository = value; }
        }

        // Check to see if PrivateRepository property is set
        internal bool IsSetPrivateRepository()
        {
            return this._privateRepository.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Token. 
        /// <para>
        /// The GitHub user's personal access token for the GitHub repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1)]
        public string Token
        {
            get { return this._token; }
            set { this._token = value; }
        }

        // Check to see if Token property is set
        internal bool IsSetToken()
        {
            return this._token != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of GitHub repository to be created in AWS CodeStar. Valid values are User
        /// or Organization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}