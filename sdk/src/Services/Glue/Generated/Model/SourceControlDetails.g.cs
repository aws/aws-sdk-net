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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AuthStrategy. 
        /// <para>
        /// The type of authentication, which can be an authentication token stored in Amazon
        /// Web Services Secrets Manager, or a personal access token.
        /// </para>
        /// </summary>
        public SourceControlAuthStrategy AuthStrategy { get; set; }

        /// <summary>
        /// Checks to see if the AuthStrategy property is set.
        /// </summary>
        internal bool IsSetAuthStrategy() => this.AuthStrategy != null;

        /// <summary>
        /// Gets and sets the property AuthToken. 
        /// <para>
        /// The value of an authorization token.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string AuthToken { get; set; }

        /// <summary>
        /// Checks to see if the AuthToken property is set.
        /// </summary>
        internal bool IsSetAuthToken() => this.AuthToken != null;

        /// <summary>
        /// Gets and sets the property Branch. 
        /// <para>
        /// An optional branch in the remote repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string Branch { get; set; }

        /// <summary>
        /// Checks to see if the Branch property is set.
        /// </summary>
        internal bool IsSetBranch() => this.Branch != null;

        /// <summary>
        /// Gets and sets the property Folder. 
        /// <para>
        /// An optional folder in the remote repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string Folder { get; set; }

        /// <summary>
        /// Checks to see if the Folder property is set.
        /// </summary>
        internal bool IsSetFolder() => this.Folder != null;

        /// <summary>
        /// Gets and sets the property LastCommitId. 
        /// <para>
        /// The last commit ID for a commit in the remote repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string LastCommitId { get; set; }

        /// <summary>
        /// Checks to see if the LastCommitId property is set.
        /// </summary>
        internal bool IsSetLastCommitId() => this.LastCommitId != null;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the remote repository that contains the job artifacts.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The provider for the remote repository.
        /// </para>
        /// </summary>
        public SourceControlProvider Provider { get; set; }

        /// <summary>
        /// Checks to see if the Provider property is set.
        /// </summary>
        internal bool IsSetProvider() => this.Provider != null;

        /// <summary>
        /// Gets and sets the property Repository. 
        /// <para>
        /// The name of the remote repository that contains the job artifacts.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string Repository { get; set; }

        /// <summary>
        /// Checks to see if the Repository property is set.
        /// </summary>
        internal bool IsSetRepository() => this.Repository != null;
    }
}
