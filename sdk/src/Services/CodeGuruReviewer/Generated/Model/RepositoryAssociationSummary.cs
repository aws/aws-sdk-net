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
 * Do not modify this file. This file is generated from the codeguru-reviewer-2019-09-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruReviewer.Model
{
    /// <summary>
    /// Summary information about a repository association. The <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_ListRepositoryAssociations.html">
    /// <code>ListRepositoryAssociations</code> </a> operation returns a list of <code>RepositoryAssociationSummary</code>
    /// objects.
    /// </summary>
    public partial class RepositoryAssociationSummary
    {
        private string _associationArn;
        private string _associationId;
        private string _connectionArn;
        private DateTime? _lastUpdatedTimeStamp;
        private string _name;
        private string _owner;
        private ProviderType _providerType;
        private RepositoryAssociationState _state;

        /// <summary>
        /// Gets and sets the property AssociationArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_RepositoryAssociation.html">
        /// <code>RepositoryAssociation</code> </a> object. You can retrieve this ARN by calling
        /// <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_ListRepositoryAssociations.html">
        /// <code>ListRepositoryAssociations</code> </a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string AssociationArn
        {
            get { return this._associationArn; }
            set { this._associationArn = value; }
        }

        // Check to see if AssociationArn property is set
        internal bool IsSetAssociationArn()
        {
            return this._associationArn != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        ///  The repository association ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string AssociationId
        {
            get { return this._associationId; }
            set { this._associationId = value; }
        }

        // Check to see if AssociationId property is set
        internal bool IsSetAssociationId()
        {
            return this._associationId != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of an AWS CodeStar Connections connection. Its format
        /// is <code>arn:aws:codestar-connections:region-id:aws-account_id:connection/connection-id</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/codestar-connections/latest/APIReference/API_Connection.html">
        /// <code>Connection</code> </a> in the <i>AWS CodeStar Connections API Reference</i>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ConnectionArn
        {
            get { return this._connectionArn; }
            set { this._connectionArn = value; }
        }

        // Check to see if ConnectionArn property is set
        internal bool IsSetConnectionArn()
        {
            return this._connectionArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTimeStamp. 
        /// <para>
        /// The time, in milliseconds since the epoch, since the repository association was last
        /// updated. 
        /// </para>
        /// </summary>
        public DateTime LastUpdatedTimeStamp
        {
            get { return this._lastUpdatedTimeStamp.GetValueOrDefault(); }
            set { this._lastUpdatedTimeStamp = value; }
        }

        // Check to see if LastUpdatedTimeStamp property is set
        internal bool IsSetLastUpdatedTimeStamp()
        {
            return this._lastUpdatedTimeStamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the repository association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// The owner of the repository. For an AWS CodeCommit repository, this is the AWS account
        /// ID of the account that owns the repository. For a GitHub, GitHub Enterprise Server,
        /// or Bitbucket repository, this is the username for the account that owns the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property ProviderType. 
        /// <para>
        /// The provider type of the repository association.
        /// </para>
        /// </summary>
        public ProviderType ProviderType
        {
            get { return this._providerType; }
            set { this._providerType = value; }
        }

        // Check to see if ProviderType property is set
        internal bool IsSetProviderType()
        {
            return this._providerType != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the repository association.
        /// </para>
        ///  
        /// <para>
        /// The valid repository association states are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Associated</b>: The repository association is complete. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Associating</b>: CodeGuru Reviewer is: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Setting up pull request notifications. This is required for pull requests to trigger
        /// a CodeGuru Reviewer review. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  If your repository <code>ProviderType</code> is <code>GitHub</code>, <code>GitHub
        /// Enterprise Server</code>, or <code>Bitbucket</code>, CodeGuru Reviewer creates webhooks
        /// in your repository to trigger CodeGuru Reviewer reviews. If you delete these webhooks,
        /// reviews of code in your repository cannot be triggered. 
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  Setting up source code access. This is required for CodeGuru Reviewer to securely
        /// clone code in your repository. 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b>Failed</b>: The repository failed to associate or disassociate. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Disassociating</b>: CodeGuru Reviewer is removing the repository's pull request
        /// notifications and source code access. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Disassociated</b>: CodeGuru Reviewer successfully disassociated the repository.
        /// You can create a new association with this repository if you want to review source
        /// code in it later. You can control access to code reviews created in an associated
        /// repository with tags after it has been disassociated. For more information, see <a
        /// href="https://docs.aws.amazon.com/codeguru/latest/reviewer-ug/auth-and-access-control-using-tags.html">Using
        /// tags to control access to associated repositories</a> in the <i>Amazon CodeGuru Reviewer
        /// User Guide</i>. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public RepositoryAssociationState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}