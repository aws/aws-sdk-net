/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruReviewer.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateRepository operation.
    /// Associates an AWS CodeCommit repository with Amazon CodeGuru Reviewer. When you associate
    /// an AWS CodeCommit repository with Amazon CodeGuru Reviewer, Amazon CodeGuru Reviewer
    /// will provide recommendations for each pull request. You can view recommendations in
    /// the AWS CodeCommit repository.
    /// 
    ///  
    /// <para>
    /// You can associate a GitHub repository using the Amazon CodeGuru Reviewer console.
    /// </para>
    /// </summary>
    public partial class AssociateRepositoryRequest : AmazonCodeGuruReviewerRequest
    {
        private string _clientRequestToken;
        private Repository _repository;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        ///  
        /// <para>
        /// If you want to add a new repository association, this parameter specifies a unique
        /// identifier for the new repository association that helps ensure idempotency.
        /// </para>
        ///  
        /// <para>
        /// If you use the AWS CLI or one of the AWS SDK to call this operation, then you can
        /// leave this parameter empty. The CLI or SDK generates a random UUID for you and includes
        /// that in the request. If you don't use the SDK and instead generate a raw HTTP request
        /// to the Secrets Manager service endpoint, then you must generate a ClientRequestToken
        /// yourself for new versions and include that value in the request.
        /// </para>
        ///  
        /// <para>
        /// You typically only need to interact with this value if you implement your own retry
        /// logic and want to ensure that a given repository association is not created twice.
        /// We recommend that you generate a UUID-type value to ensure uniqueness within the specified
        /// repository association.
        /// </para>
        ///  
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

    }
}