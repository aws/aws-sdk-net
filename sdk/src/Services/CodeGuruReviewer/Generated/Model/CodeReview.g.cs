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

namespace Amazon.CodeGuruReviewer.Model
{
    /// <summary>
    /// Information about a code review. A code review belongs to the associated repository
    /// that contains the reviewed code.
    /// </summary>
    public partial class CodeReview
    {
        /// <summary>
        /// Gets and sets the property AnalysisTypes. 
        /// <para>
        /// The types of analysis performed during a repository analysis or a pull request review.
        /// You can specify either <c>Security</c>, <c>CodeQuality</c>, or both.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AnalysisTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AnalysisTypes property is set.
        /// </summary>
        internal bool IsSetAnalysisTypes() => this.AnalysisTypes != null && (this.AnalysisTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_RepositoryAssociation.html">RepositoryAssociation</a>
        /// that contains the reviewed source code. You can retrieve associated repository ARNs
        /// by calling <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_ListRepositoryAssociations.html">ListRepositoryAssociations</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string AssociationArn { get; set; }

        /// <summary>
        /// Checks to see if the AssociationArn property is set.
        /// </summary>
        internal bool IsSetAssociationArn() => this.AssociationArn != null;

        /// <summary>
        /// Gets and sets the property CodeReviewArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_CodeReview.html">CodeReview</a>
        /// object. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string CodeReviewArn { get; set; }

        /// <summary>
        /// Checks to see if the CodeReviewArn property is set.
        /// </summary>
        internal bool IsSetCodeReviewArn() => this.CodeReviewArn != null;

        /// <summary>
        /// Gets and sets the property ConfigFileState. 
        /// <para>
        /// The state of the <c>aws-codeguru-reviewer.yml</c> configuration file that allows the
        /// configuration of the CodeGuru Reviewer analysis. The file either exists, doesn't exist,
        /// or exists with errors at the root directory of your repository.
        /// </para>
        /// </summary>
        public ConfigFileState ConfigFileState { get; set; }

        /// <summary>
        /// Checks to see if the ConfigFileState property is set.
        /// </summary>
        internal bool IsSetConfigFileState() => this.ConfigFileState != null;

        /// <summary>
        /// Gets and sets the property CreatedTimeStamp. 
        /// <para>
        /// The time, in milliseconds since the epoch, when the code review was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimeStamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimeStamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimeStamp() => this.CreatedTimeStamp.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedTimeStamp. 
        /// <para>
        /// The time, in milliseconds since the epoch, when the code review was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTimeStamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTimeStamp property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTimeStamp() => this.LastUpdatedTimeStamp.HasValue;

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// The statistics from the code review.
        /// </para>
        /// </summary>
        public Metrics Metrics { get; set; }

        /// <summary>
        /// Checks to see if the Metrics property is set.
        /// </summary>
        internal bool IsSetMetrics() => this.Metrics != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the code review.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

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
        [AWSProperty(Min = 1, Max = 100)]
        public string Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property ProviderType. 
        /// <para>
        /// The type of repository that contains the reviewed code (for example, GitHub or Bitbucket).
        /// </para>
        /// </summary>
        public ProviderType ProviderType { get; set; }

        /// <summary>
        /// Checks to see if the ProviderType property is set.
        /// </summary>
        internal bool IsSetProviderType() => this.ProviderType != null;

        /// <summary>
        /// Gets and sets the property PullRequestId. 
        /// <para>
        /// The pull request ID for the code review.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string PullRequestId { get; set; }

        /// <summary>
        /// Checks to see if the PullRequestId property is set.
        /// </summary>
        internal bool IsSetPullRequestId() => this.PullRequestId != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;

        /// <summary>
        /// Gets and sets the property SourceCodeType. 
        /// <para>
        /// The type of the source code for the code review.
        /// </para>
        /// </summary>
        public SourceCodeType SourceCodeType { get; set; }

        /// <summary>
        /// Checks to see if the SourceCodeType property is set.
        /// </summary>
        internal bool IsSetSourceCodeType() => this.SourceCodeType != null;

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
        public JobState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// The reason for the state of the code review.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string StateReason { get; set; }

        /// <summary>
        /// Checks to see if the StateReason property is set.
        /// </summary>
        internal bool IsSetStateReason() => this.StateReason != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of code review.
        /// </para>
        /// </summary>
        public Type Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
