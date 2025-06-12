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
    /// Container for the parameters to the AssociateRepository operation.
    /// Use to associate an Amazon Web Services CodeCommit repository or a repository managed
    /// by Amazon Web Services CodeStar Connections with Amazon CodeGuru Reviewer. When you
    /// associate a repository, CodeGuru Reviewer reviews source code changes in the repository's
    /// pull requests and provides automatic recommendations. You can view recommendations
    /// using the CodeGuru Reviewer console. For more information, see <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-ug/recommendations.html">Recommendations
    /// in Amazon CodeGuru Reviewer</a> in the <i>Amazon CodeGuru Reviewer User Guide.</i>
    /// 
    /// 
    ///  
    /// <para>
    /// If you associate a CodeCommit or S3 repository, it must be in the same Amazon Web
    /// Services Region and Amazon Web Services account where its CodeGuru Reviewer code reviews
    /// are configured.
    /// </para>
    ///  
    /// <para>
    /// Bitbucket and GitHub Enterprise Server repositories are managed by Amazon Web Services
    /// CodeStar Connections to connect to CodeGuru Reviewer. For more information, see <a
    /// href="https://docs.aws.amazon.com/codeguru/latest/reviewer-ug/getting-started-associate-repository.html">Associate
    /// a repository</a> in the <i>Amazon CodeGuru Reviewer User Guide.</i> 
    /// </para>
    ///  <note> 
    /// <para>
    /// You cannot use the CodeGuru Reviewer SDK or the Amazon Web Services CLI to associate
    /// a GitHub repository with Amazon CodeGuru Reviewer. To associate a GitHub repository,
    /// use the console. For more information, see <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-ug/getting-started-with-guru.html">Getting
    /// started with CodeGuru Reviewer</a> in the <i>CodeGuru Reviewer User Guide.</i> 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AssociateRepositoryRequest : AmazonCodeGuruReviewerRequest
    {
        private string _clientRequestToken;
        private KMSKeyDetails _kmsKeyDetails;
        private Repository _repository;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Amazon CodeGuru Reviewer uses this value to prevent the accidental creation of duplicate
        /// repository associations if there are failures and retries.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

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
        public KMSKeyDetails KMSKeyDetails
        {
            get { return this._kmsKeyDetails; }
            set { this._kmsKeyDetails = value; }
        }

        // Check to see if KMSKeyDetails property is set
        internal bool IsSetKMSKeyDetails()
        {
            return this._kmsKeyDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Repository. 
        /// <para>
        /// The repository to associate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Repository Repository
        {
            get { return this._repository; }
            set { this._repository = value; }
        }

        // Check to see if Repository property is set
        internal bool IsSetRepository()
        {
            return this._repository != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs used to tag an associated repository. A tag is a custom
        /// attribute label with two parts:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A <i>tag key</i> (for example, <c>CostCenter</c>, <c>Environment</c>, <c>Project</c>,
        /// or <c>Secret</c>). Tag keys are case sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An optional field known as a <i>tag value</i> (for example, <c>111122223333</c>, <c>Production</c>,
        /// or a team name). Omitting the tag value is the same as using an empty string. Like
        /// tag keys, tag values are case sensitive.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}