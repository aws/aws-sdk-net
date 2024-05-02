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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// The details for a source control configuration for a job, allowing synchronization
    /// of job artifacts to or from a remote repository.
    /// </summary>
    public partial class SourceControlDetails
    {
        private SourceControlAuthStrategy _authStrategy;
        private string _authToken;
        private string _branch;
        private string _folder;
        private string _lastCommitId;
        private string _owner;
        private SourceControlProvider _provider;
        private string _repository;

        /// <summary>
        /// Gets and sets the property AuthStrategy. 
        /// <para>
        /// The type of authentication, which can be an authentication token stored in Amazon
        /// Web Services Secrets Manager, or a personal access token.
        /// </para>
        /// </summary>
        public SourceControlAuthStrategy AuthStrategy
        {
            get { return this._authStrategy; }
            set { this._authStrategy = value; }
        }

        // Check to see if AuthStrategy property is set
        internal bool IsSetAuthStrategy()
        {
            return this._authStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property AuthToken. 
        /// <para>
        /// The value of an authorization token.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string AuthToken
        {
            get { return this._authToken; }
            set { this._authToken = value; }
        }

        // Check to see if AuthToken property is set
        internal bool IsSetAuthToken()
        {
            return this._authToken != null;
        }

        /// <summary>
        /// Gets and sets the property Branch. 
        /// <para>
        /// An optional branch in the remote repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string Branch
        {
            get { return this._branch; }
            set { this._branch = value; }
        }

        // Check to see if Branch property is set
        internal bool IsSetBranch()
        {
            return this._branch != null;
        }

        /// <summary>
        /// Gets and sets the property Folder. 
        /// <para>
        /// An optional folder in the remote repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string Folder
        {
            get { return this._folder; }
            set { this._folder = value; }
        }

        // Check to see if Folder property is set
        internal bool IsSetFolder()
        {
            return this._folder != null;
        }

        /// <summary>
        /// Gets and sets the property LastCommitId. 
        /// <para>
        /// The last commit ID for a commit in the remote repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string LastCommitId
        {
            get { return this._lastCommitId; }
            set { this._lastCommitId = value; }
        }

        // Check to see if LastCommitId property is set
        internal bool IsSetLastCommitId()
        {
            return this._lastCommitId != null;
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the remote repository that contains the job artifacts.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
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
        /// Gets and sets the property Provider. 
        /// <para>
        /// The provider for the remote repository.
        /// </para>
        /// </summary>
        public SourceControlProvider Provider
        {
            get { return this._provider; }
            set { this._provider = value; }
        }

        // Check to see if Provider property is set
        internal bool IsSetProvider()
        {
            return this._provider != null;
        }

        /// <summary>
        /// Gets and sets the property Repository. 
        /// <para>
        /// The name of the remote repository that contains the job artifacts.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
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

    }
}