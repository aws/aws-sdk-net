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
    /// Container for the parameters to the CreateCodeReview operation.
    /// Use to create a code review with a <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_CodeReviewType.html">CodeReviewType</a>
    /// of <c>RepositoryAnalysis</c>. This type of code review analyzes all code under a specified
    /// branch in an associated repository. <c>PullRequest</c> code reviews are automatically
    /// triggered by a pull request.
    /// </summary>
    public partial class CreateCodeReviewRequest : AmazonCodeGuruReviewerRequest
    {
        private string _clientRequestToken;
        private string _name;
        private string _repositoryAssociationArn;
        private CodeReviewType _type;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Amazon CodeGuru Reviewer uses this value to prevent the accidental creation of duplicate
        /// code reviews if there are failures and retries.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the code review. The name of each code review in your Amazon Web Services
        /// account must be unique.
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
        /// Gets and sets the property RepositoryAssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_RepositoryAssociation.html">RepositoryAssociation</a>
        /// object. You can retrieve this ARN by calling <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_ListRepositoryAssociations.html">ListRepositoryAssociations</a>.
        /// </para>
        ///  
        /// <para>
        /// A code review can only be created on an associated repository. This is the ARN of
        /// the associated repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string RepositoryAssociationArn
        {
            get { return this._repositoryAssociationArn; }
            set { this._repositoryAssociationArn = value; }
        }

        // Check to see if RepositoryAssociationArn property is set
        internal bool IsSetRepositoryAssociationArn()
        {
            return this._repositoryAssociationArn != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of code review to create. This is specified using a <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_CodeReviewType.html">CodeReviewType</a>
        /// object. You can create a code review only of type <c>RepositoryAnalysis</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CodeReviewType Type
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