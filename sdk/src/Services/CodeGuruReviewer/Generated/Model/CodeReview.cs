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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CodeGuruReviewer.Model
{
    /// <summary>
    /// Information about a code review. A code review belongs to the associated repository
    /// that contains the reviewed code.
    /// </summary>
    public partial class CodeReview
    {
        private List<string> _analysisTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _associationArn;
        private string _codeReviewArn;
        private ConfigFileState _configFileState;
        private DateTime? _createdTimeStamp;
        private DateTime? _lastUpdatedTimeStamp;
        private Metrics _metrics;
        private string _name;
        private string _owner;
        private ProviderType _providerType;
        private string _pullRequestId;
        private string _repositoryName;
        private SourceCodeType _sourceCodeType;
        private JobState _state;
        private string _stateReason;
        private Type _type;

        /// <summary>
        /// Gets and sets the property AnalysisTypes. 
        /// <para>
        /// The types of analysis performed during a repository analysis or a pull request review.
        /// You can specify either <c>Security</c>, <c>CodeQuality</c>, or both.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AnalysisTypes
        {
            get { return this._analysisTypes; }
            set { this._analysisTypes = value; }
        }

        // Check to see if AnalysisTypes property is set
        internal bool IsSetAnalysisTypes()
        {
            return this._analysisTypes != null && (this._analysisTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_RepositoryAssociation.html">RepositoryAssociation</a>
        /// that contains the reviewed source code. You can retrieve associated repository ARNs
        /// by calling <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_ListRepositoryAssociations.html">ListRepositoryAssociations</a>.
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
        /// Gets and sets the property CodeReviewArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_CodeReview.html">CodeReview</a>
        /// object. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string CodeReviewArn
        {
            get { return this._codeReviewArn; }
            set { this._codeReviewArn = value; }
        }

        // Check to see if CodeReviewArn property is set
        internal bool IsSetCodeReviewArn()
        {
            return this._codeReviewArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigFileState. 
        /// <para>
        /// The state of the <c>aws-codeguru-reviewer.yml</c> configuration file that allows the
        /// configuration of the CodeGuru Reviewer analysis. The file either exists, doesn't exist,
        /// or exists with errors at the root directory of your repository.
        /// </para>
        /// </summary>
        public ConfigFileState ConfigFileState
        {
            get { return this._configFileState; }
            set { this._configFileState = value; }
        }

        // Check to see if ConfigFileState property is set
        internal bool IsSetConfigFileState()
        {
            return this._configFileState != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTimeStamp. 
        /// <para>
        /// The time, in milliseconds since the epoch, when the code review was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimeStamp
        {
            get { return this._createdTimeStamp; }
            set { this._createdTimeStamp = value; }
        }

        // Check to see if CreatedTimeStamp property is set
        internal bool IsSetCreatedTimeStamp()
        {
            return this._createdTimeStamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTimeStamp. 
        /// <para>
        /// The time, in milliseconds since the epoch, when the code review was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTimeStamp
        {
            get { return this._lastUpdatedTimeStamp; }
            set { this._lastUpdatedTimeStamp = value; }
        }

        // Check to see if LastUpdatedTimeStamp property is set
        internal bool IsSetLastUpdatedTimeStamp()
        {
            return this._lastUpdatedTimeStamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// The statistics from the code review.
        /// </para>
        /// </summary>
        public Metrics Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the code review.
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
        /// The owner of the repository. For an Amazon Web Services CodeCommit repository, this
        /// is the Amazon Web Services account ID of the account that owns the repository. For
        /// a GitHub, GitHub Enterprise Server, or Bitbucket repository, this is the username
        /// for the account that owns the repository. For an S3 repository, it can be the username
        /// or Amazon Web Services account ID.
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
        /// The type of repository that contains the reviewed code (for example, GitHub or Bitbucket).
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
        /// Gets and sets the property PullRequestId. 
        /// <para>
        /// The pull request ID for the code review.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string PullRequestId
        {
            get { return this._pullRequestId; }
            set { this._pullRequestId = value; }
        }

        // Check to see if PullRequestId property is set
        internal bool IsSetPullRequestId()
        {
            return this._pullRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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

        /// <summary>
        /// Gets and sets the property SourceCodeType. 
        /// <para>
        /// The type of the source code for the code review.
        /// </para>
        /// </summary>
        public SourceCodeType SourceCodeType
        {
            get { return this._sourceCodeType; }
            set { this._sourceCodeType = value; }
        }

        // Check to see if SourceCodeType property is set
        internal bool IsSetSourceCodeType()
        {
            return this._sourceCodeType != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The valid code review states are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Completed</c>: The code review is complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Pending</c>: The code review started and has not completed or failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c>: The code review failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Deleting</c>: The code review is being deleted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public JobState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// The reason for the state of the code review.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string StateReason
        {
            get { return this._stateReason; }
            set { this._stateReason = value; }
        }

        // Check to see if StateReason property is set
        internal bool IsSetStateReason()
        {
            return this._stateReason != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of code review.
        /// </para>
        /// </summary>
        public Type Type
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