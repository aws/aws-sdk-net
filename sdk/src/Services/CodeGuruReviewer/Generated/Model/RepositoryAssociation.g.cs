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
    /// Information about a repository association. The <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_DescribeRepositoryAssociation.html">DescribeRepositoryAssociation</a>
    /// operation returns a <c>RepositoryAssociation</c> object.
    /// </summary>
    public partial class RepositoryAssociation
    {
        /// <summary>
        /// Gets and sets the property AssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) identifying the repository association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string AssociationArn { get; set; }

        /// <summary>
        /// Checks to see if the AssociationArn property is set.
        /// </summary>
        internal bool IsSetAssociationArn() => this.AssociationArn != null;

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The ID of the repository association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AssociationId property is set.
        /// </summary>
        internal bool IsSetAssociationId() => this.AssociationId != null;

        /// <summary>
        /// Gets and sets the property ConnectionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Amazon Web Services CodeStar Connections connection.
        /// Its format is <c>arn:aws:codestar-connections:region-id:aws-account_id:connection/connection-id</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/codestar-connections/latest/APIReference/API_Connection.html">Connection</a>
        /// in the <i>Amazon Web Services CodeStar Connections API Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ConnectionArn { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionArn property is set.
        /// </summary>
        internal bool IsSetConnectionArn() => this.ConnectionArn != null;

        /// <summary>
        /// Gets and sets the property CreatedTimeStamp. 
        /// <para>
        /// The time, in milliseconds since the epoch, when the repository association was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimeStamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimeStamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimeStamp() => this.CreatedTimeStamp.HasValue;

        /// <summary>
        /// Gets and sets the property KMSKeyDetails. 
        /// <para>
        /// A <c>KMSKeyDetails</c> object that contains:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The encryption option for this repository association. It is either owned by Amazon
        /// Web Services Key Management Service (KMS) (<c>AWS_OWNED_CMK</c>) or customer managed
        /// (<c>CUSTOMER_MANAGED_CMK</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ID of the Amazon Web Services KMS key that is associated with this repository
        /// association.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public KMSKeyDetails KMSKeyDetails { get; set; }

        /// <summary>
        /// Checks to see if the KMSKeyDetails property is set.
        /// </summary>
        internal bool IsSetKMSKeyDetails() => this.KMSKeyDetails != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTimeStamp. 
        /// <para>
        /// The time, in milliseconds since the epoch, when the repository association was last
        /// updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTimeStamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTimeStamp property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTimeStamp() => this.LastUpdatedTimeStamp.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the repository.
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
        /// The provider type of the repository association.
        /// </para>
        /// </summary>
        public ProviderType ProviderType { get; set; }

        /// <summary>
        /// Checks to see if the ProviderType property is set.
        /// </summary>
        internal bool IsSetProviderType() => this.ProviderType != null;

        /// <summary>
        /// Gets and sets the property S3RepositoryDetails.
        /// </summary>
        public S3RepositoryDetails S3RepositoryDetails { get; set; }

        /// <summary>
        /// Checks to see if the S3RepositoryDetails property is set.
        /// </summary>
        internal bool IsSetS3RepositoryDetails() => this.S3RepositoryDetails != null;

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
        /// Setting up pull request notifications. This is required for pull requests to trigger
        /// a CodeGuru Reviewer review.
        /// </para>
        ///  <note> 
        /// <para>
        /// If your repository <c>ProviderType</c> is <c>GitHub</c>, <c>GitHub Enterprise Server</c>,
        /// or <c>Bitbucket</c>, CodeGuru Reviewer creates webhooks in your repository to trigger
        /// CodeGuru Reviewer reviews. If you delete these webhooks, reviews of code in your repository
        /// cannot be triggered.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// Setting up source code access. This is required for CodeGuru Reviewer to securely
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
        /// code in it later. You can control access to code reviews created in anassociated repository
        /// with tags after it has been disassociated. For more information, see <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-ug/auth-and-access-control-using-tags.html">Using
        /// tags to control access to associated repositories</a> in the <i>Amazon CodeGuru Reviewer
        /// User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public RepositoryAssociationState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// A description of why the repository association is in the current state.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string StateReason { get; set; }

        /// <summary>
        /// Checks to see if the StateReason property is set.
        /// </summary>
        internal bool IsSetStateReason() => this.StateReason != null;
    }
}
