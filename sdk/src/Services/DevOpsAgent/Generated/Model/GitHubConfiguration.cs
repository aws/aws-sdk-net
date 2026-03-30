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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Configuration for GitHub repository integration.
    /// </summary>
    public partial class GitHubConfiguration
    {
        private string _instanceIdentifier;
        private string _owner;
        private GithubRepoOwnerType _ownerType;
        private string _repoId;
        private string _repoName;

        /// <summary>
        /// Gets and sets the property InstanceIdentifier. 
        /// <para>
        /// GitHub instance identifier (e.g., github.com or github.enterprise.com)
        /// </para>
        /// </summary>
        public string InstanceIdentifier
        {
            get { return this._instanceIdentifier; }
            set { this._instanceIdentifier = value; }
        }

        // Check to see if InstanceIdentifier property is set
        internal bool IsSetInstanceIdentifier()
        {
            return this._instanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The GitHub repository owner name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property OwnerType.
        /// </summary>
        [AWSProperty(Required=true)]
        public GithubRepoOwnerType OwnerType
        {
            get { return this._ownerType; }
            set { this._ownerType = value; }
        }

        // Check to see if OwnerType property is set
        internal bool IsSetOwnerType()
        {
            return this._ownerType != null;
        }

        /// <summary>
        /// Gets and sets the property RepoId. 
        /// <para>
        /// Associated Github repo ID
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RepoId
        {
            get { return this._repoId; }
            set { this._repoId = value; }
        }

        // Check to see if RepoId property is set
        internal bool IsSetRepoId()
        {
            return this._repoId != null;
        }

        /// <summary>
        /// Gets and sets the property RepoName. 
        /// <para>
        /// Associated Github repo name
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RepoName
        {
            get { return this._repoName; }
            set { this._repoName = value; }
        }

        // Check to see if RepoName property is set
        internal bool IsSetRepoName()
        {
            return this._repoName != null;
        }

    }
}