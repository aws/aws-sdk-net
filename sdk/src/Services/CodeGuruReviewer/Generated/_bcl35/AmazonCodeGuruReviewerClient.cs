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
using System.Net;

using Amazon.CodeGuruReviewer.Model;
using Amazon.CodeGuruReviewer.Model.Internal.MarshallTransformations;
using Amazon.CodeGuruReviewer.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CodeGuruReviewer
{
    /// <summary>
    /// Implementation for accessing CodeGuruReviewer
    ///
    /// This section provides documentation for the Amazon CodeGuru Reviewer API operations.
    /// CodeGuru Reviewer is a service that uses program analysis and machine learning to
    /// detect potential defects that are difficult for developers to find and recommends
    /// fixes in your Java code.
    /// 
    ///  
    /// <para>
    /// By proactively detecting and providing recommendations for addressing code defects
    /// and implementing best practices, CodeGuru Reviewer improves the overall quality and
    /// maintainability of your code base during the code review stage. For more information
    /// about CodeGuru Reviewer, see the <i> <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-ug/welcome.html">Amazon
    /// CodeGuru Reviewer User Guide</a>.</i> 
    /// </para>
    ///  
    /// <para>
    ///  To improve the security of your CodeGuru Reviewer API calls, you can establish a
    /// private connection between your VPC and CodeGuru Reviewer by creating an <i>interface
    /// VPC endpoint</i>. For more information, see <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-ug/vpc-interface-endpoints.html">CodeGuru
    /// Reviewer and interface VPC endpoints (AWS PrivateLink)</a> in the <i>Amazon CodeGuru
    /// Reviewer User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class AmazonCodeGuruReviewerClient : AmazonServiceClient, IAmazonCodeGuruReviewer
    {
        private static IServiceMetadata serviceMetadata = new AmazonCodeGuruReviewerMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonCodeGuruReviewerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonCodeGuruReviewerClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCodeGuruReviewerConfig()) { }

        /// <summary>
        /// Constructs AmazonCodeGuruReviewerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeGuruReviewerClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCodeGuruReviewerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCodeGuruReviewerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonCodeGuruReviewerClient Configuration Object</param>
        public AmazonCodeGuruReviewerClient(AmazonCodeGuruReviewerConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonCodeGuruReviewerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCodeGuruReviewerClient(AWSCredentials credentials)
            : this(credentials, new AmazonCodeGuruReviewerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruReviewerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeGuruReviewerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCodeGuruReviewerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruReviewerClient with AWS Credentials and an
        /// AmazonCodeGuruReviewerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCodeGuruReviewerClient Configuration Object</param>
        public AmazonCodeGuruReviewerClient(AWSCredentials credentials, AmazonCodeGuruReviewerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruReviewerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCodeGuruReviewerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodeGuruReviewerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruReviewerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeGuruReviewerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodeGuruReviewerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruReviewerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodeGuruReviewerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCodeGuruReviewerClient Configuration Object</param>
        public AmazonCodeGuruReviewerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCodeGuruReviewerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruReviewerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCodeGuruReviewerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodeGuruReviewerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruReviewerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeGuruReviewerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodeGuruReviewerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruReviewerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodeGuruReviewerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCodeGuruReviewerClient Configuration Object</param>
        public AmazonCodeGuruReviewerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCodeGuruReviewerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AssociateRepository

        /// <summary>
        /// Use to associate an AWS CodeCommit repository or a repostory managed by AWS CodeStar
        /// Connections with Amazon CodeGuru Reviewer. When you associate a repository, CodeGuru
        /// Reviewer reviews source code changes in the repository's pull requests and provides
        /// automatic recommendations. You can view recommendations using the CodeGuru Reviewer
        /// console. For more information, see <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-ug/recommendations.html">Recommendations
        /// in Amazon CodeGuru Reviewer</a> in the <i>Amazon CodeGuru Reviewer User Guide.</i>
        /// 
        /// 
        ///  
        /// <para>
        /// If you associate a CodeCommit repository, it must be in the same AWS Region and AWS
        /// account where its CodeGuru Reviewer code reviews are configured.
        /// </para>
        ///  
        /// <para>
        /// Bitbucket and GitHub Enterprise Server repositories are managed by AWS CodeStar Connections
        /// to connect to CodeGuru Reviewer. For more information, see <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-ug/reviewer-ug/step-one.html#select-repository-source-provider">Connect
        /// to a repository source provider</a> in the <i>Amazon CodeGuru Reviewer User Guide.</i>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        ///  You cannot use the CodeGuru Reviewer SDK or the AWS CLI to associate a GitHub repository
        /// with Amazon CodeGuru Reviewer. To associate a GitHub repository, use the console.
        /// For more information, see <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-ug/getting-started-with-guru.html">Getting
        /// started with CodeGuru Reviewer</a> in the <i>CodeGuru Reviewer User Guide.</i> 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateRepository service method.</param>
        /// 
        /// <returns>The response from the AssociateRepository service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/AssociateRepository">REST API Reference for AssociateRepository Operation</seealso>
        public virtual AssociateRepositoryResponse AssociateRepository(AssociateRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateRepositoryResponseUnmarshaller.Instance;

            return Invoke<AssociateRepositoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateRepository operation on AmazonCodeGuruReviewerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/AssociateRepository">REST API Reference for AssociateRepository Operation</seealso>
        public virtual IAsyncResult BeginAssociateRepository(AssociateRepositoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateRepositoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateRepository.</param>
        /// 
        /// <returns>Returns a  AssociateRepositoryResult from CodeGuruReviewer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/AssociateRepository">REST API Reference for AssociateRepository Operation</seealso>
        public virtual AssociateRepositoryResponse EndAssociateRepository(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateRepositoryResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCodeReview

        /// <summary>
        /// Use to create a code review with a <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_CodeReviewType.html">
        /// <code>CodeReviewType</code> </a> of <code>RepositoryAnalysis</code>. This type of
        /// code review analyzes all code under a specified branch in an associated repository.
        /// <code>PullRequest</code> code reviews are automatically triggered by a pull request
        /// so cannot be created using this method.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeReview service method.</param>
        /// 
        /// <returns>The response from the CreateCodeReview service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/CreateCodeReview">REST API Reference for CreateCodeReview Operation</seealso>
        public virtual CreateCodeReviewResponse CreateCodeReview(CreateCodeReviewRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCodeReviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCodeReviewResponseUnmarshaller.Instance;

            return Invoke<CreateCodeReviewResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCodeReview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeReview operation on AmazonCodeGuruReviewerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCodeReview
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/CreateCodeReview">REST API Reference for CreateCodeReview Operation</seealso>
        public virtual IAsyncResult BeginCreateCodeReview(CreateCodeReviewRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCodeReviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCodeReviewResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCodeReview operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCodeReview.</param>
        /// 
        /// <returns>Returns a  CreateCodeReviewResult from CodeGuruReviewer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/CreateCodeReview">REST API Reference for CreateCodeReview Operation</seealso>
        public virtual CreateCodeReviewResponse EndCreateCodeReview(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCodeReviewResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCodeReview

        /// <summary>
        /// Returns the metadata associated with the code review along with its status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCodeReview service method.</param>
        /// 
        /// <returns>The response from the DescribeCodeReview service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/DescribeCodeReview">REST API Reference for DescribeCodeReview Operation</seealso>
        public virtual DescribeCodeReviewResponse DescribeCodeReview(DescribeCodeReviewRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCodeReviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCodeReviewResponseUnmarshaller.Instance;

            return Invoke<DescribeCodeReviewResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCodeReview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCodeReview operation on AmazonCodeGuruReviewerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCodeReview
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/DescribeCodeReview">REST API Reference for DescribeCodeReview Operation</seealso>
        public virtual IAsyncResult BeginDescribeCodeReview(DescribeCodeReviewRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCodeReviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCodeReviewResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCodeReview operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCodeReview.</param>
        /// 
        /// <returns>Returns a  DescribeCodeReviewResult from CodeGuruReviewer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/DescribeCodeReview">REST API Reference for DescribeCodeReview Operation</seealso>
        public virtual DescribeCodeReviewResponse EndDescribeCodeReview(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCodeReviewResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRecommendationFeedback

        /// <summary>
        /// Describes the customer feedback for a CodeGuru Reviewer recommendation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecommendationFeedback service method.</param>
        /// 
        /// <returns>The response from the DescribeRecommendationFeedback service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/DescribeRecommendationFeedback">REST API Reference for DescribeRecommendationFeedback Operation</seealso>
        public virtual DescribeRecommendationFeedbackResponse DescribeRecommendationFeedback(DescribeRecommendationFeedbackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecommendationFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecommendationFeedbackResponseUnmarshaller.Instance;

            return Invoke<DescribeRecommendationFeedbackResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRecommendationFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecommendationFeedback operation on AmazonCodeGuruReviewerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRecommendationFeedback
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/DescribeRecommendationFeedback">REST API Reference for DescribeRecommendationFeedback Operation</seealso>
        public virtual IAsyncResult BeginDescribeRecommendationFeedback(DescribeRecommendationFeedbackRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecommendationFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecommendationFeedbackResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRecommendationFeedback operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRecommendationFeedback.</param>
        /// 
        /// <returns>Returns a  DescribeRecommendationFeedbackResult from CodeGuruReviewer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/DescribeRecommendationFeedback">REST API Reference for DescribeRecommendationFeedback Operation</seealso>
        public virtual DescribeRecommendationFeedbackResponse EndDescribeRecommendationFeedback(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRecommendationFeedbackResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRepositoryAssociation

        /// <summary>
        /// Returns a <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_RepositoryAssociation.html">
        /// <code>RepositoryAssociation</code> </a> object that contains information about the
        /// requested repository association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRepositoryAssociation service method.</param>
        /// 
        /// <returns>The response from the DescribeRepositoryAssociation service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.NotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/DescribeRepositoryAssociation">REST API Reference for DescribeRepositoryAssociation Operation</seealso>
        public virtual DescribeRepositoryAssociationResponse DescribeRepositoryAssociation(DescribeRepositoryAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRepositoryAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRepositoryAssociationResponseUnmarshaller.Instance;

            return Invoke<DescribeRepositoryAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRepositoryAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRepositoryAssociation operation on AmazonCodeGuruReviewerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRepositoryAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/DescribeRepositoryAssociation">REST API Reference for DescribeRepositoryAssociation Operation</seealso>
        public virtual IAsyncResult BeginDescribeRepositoryAssociation(DescribeRepositoryAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRepositoryAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRepositoryAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRepositoryAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRepositoryAssociation.</param>
        /// 
        /// <returns>Returns a  DescribeRepositoryAssociationResult from CodeGuruReviewer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/DescribeRepositoryAssociation">REST API Reference for DescribeRepositoryAssociation Operation</seealso>
        public virtual DescribeRepositoryAssociationResponse EndDescribeRepositoryAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRepositoryAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateRepository

        /// <summary>
        /// Removes the association between Amazon CodeGuru Reviewer and a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRepository service method.</param>
        /// 
        /// <returns>The response from the DisassociateRepository service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.NotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/DisassociateRepository">REST API Reference for DisassociateRepository Operation</seealso>
        public virtual DisassociateRepositoryResponse DisassociateRepository(DisassociateRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateRepositoryResponseUnmarshaller.Instance;

            return Invoke<DisassociateRepositoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRepository operation on AmazonCodeGuruReviewerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/DisassociateRepository">REST API Reference for DisassociateRepository Operation</seealso>
        public virtual IAsyncResult BeginDisassociateRepository(DisassociateRepositoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateRepositoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateRepository.</param>
        /// 
        /// <returns>Returns a  DisassociateRepositoryResult from CodeGuruReviewer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/DisassociateRepository">REST API Reference for DisassociateRepository Operation</seealso>
        public virtual DisassociateRepositoryResponse EndDisassociateRepository(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateRepositoryResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCodeReviews

        /// <summary>
        /// Lists all the code reviews that the customer has created in the past 90 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeReviews service method.</param>
        /// 
        /// <returns>The response from the ListCodeReviews service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/ListCodeReviews">REST API Reference for ListCodeReviews Operation</seealso>
        public virtual ListCodeReviewsResponse ListCodeReviews(ListCodeReviewsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCodeReviewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeReviewsResponseUnmarshaller.Instance;

            return Invoke<ListCodeReviewsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCodeReviews operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCodeReviews operation on AmazonCodeGuruReviewerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCodeReviews
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/ListCodeReviews">REST API Reference for ListCodeReviews Operation</seealso>
        public virtual IAsyncResult BeginListCodeReviews(ListCodeReviewsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCodeReviewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeReviewsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCodeReviews operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCodeReviews.</param>
        /// 
        /// <returns>Returns a  ListCodeReviewsResult from CodeGuruReviewer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/ListCodeReviews">REST API Reference for ListCodeReviews Operation</seealso>
        public virtual ListCodeReviewsResponse EndListCodeReviews(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCodeReviewsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRecommendationFeedback

        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_RecommendationFeedbackSummary.html">
        /// <code>RecommendationFeedbackSummary</code> </a> objects that contain customer recommendation
        /// feedback for all CodeGuru Reviewer users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendationFeedback service method.</param>
        /// 
        /// <returns>The response from the ListRecommendationFeedback service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/ListRecommendationFeedback">REST API Reference for ListRecommendationFeedback Operation</seealso>
        public virtual ListRecommendationFeedbackResponse ListRecommendationFeedback(ListRecommendationFeedbackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecommendationFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationFeedbackResponseUnmarshaller.Instance;

            return Invoke<ListRecommendationFeedbackResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecommendationFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendationFeedback operation on AmazonCodeGuruReviewerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecommendationFeedback
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/ListRecommendationFeedback">REST API Reference for ListRecommendationFeedback Operation</seealso>
        public virtual IAsyncResult BeginListRecommendationFeedback(ListRecommendationFeedbackRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecommendationFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationFeedbackResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecommendationFeedback operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecommendationFeedback.</param>
        /// 
        /// <returns>Returns a  ListRecommendationFeedbackResult from CodeGuruReviewer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/ListRecommendationFeedback">REST API Reference for ListRecommendationFeedback Operation</seealso>
        public virtual ListRecommendationFeedbackResponse EndListRecommendationFeedback(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRecommendationFeedbackResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRecommendations

        /// <summary>
        /// Returns the list of all recommendations for a completed code review.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendations service method.</param>
        /// 
        /// <returns>The response from the ListRecommendations service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        public virtual ListRecommendationsResponse ListRecommendations(ListRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ListRecommendationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendations operation on AmazonCodeGuruReviewerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        public virtual IAsyncResult BeginListRecommendations(ListRecommendationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecommendations.</param>
        /// 
        /// <returns>Returns a  ListRecommendationsResult from CodeGuruReviewer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        public virtual ListRecommendationsResponse EndListRecommendations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRecommendationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRepositoryAssociations

        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_RepositoryAssociationSummary.html">
        /// <code>RepositoryAssociationSummary</code> </a> objects that contain summary information
        /// about a repository association. You can filter the returned list by <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_RepositoryAssociationSummary.html#reviewer-Type-RepositoryAssociationSummary-ProviderType">
        /// <code>ProviderType</code> </a>, <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_RepositoryAssociationSummary.html#reviewer-Type-RepositoryAssociationSummary-Name">
        /// <code>Name</code> </a>, <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_RepositoryAssociationSummary.html#reviewer-Type-RepositoryAssociationSummary-State">
        /// <code>State</code> </a>, and <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_RepositoryAssociationSummary.html#reviewer-Type-RepositoryAssociationSummary-Owner">
        /// <code>Owner</code> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRepositoryAssociations service method.</param>
        /// 
        /// <returns>The response from the ListRepositoryAssociations service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/ListRepositoryAssociations">REST API Reference for ListRepositoryAssociations Operation</seealso>
        public virtual ListRepositoryAssociationsResponse ListRepositoryAssociations(ListRepositoryAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRepositoryAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRepositoryAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListRepositoryAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRepositoryAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRepositoryAssociations operation on AmazonCodeGuruReviewerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRepositoryAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/ListRepositoryAssociations">REST API Reference for ListRepositoryAssociations Operation</seealso>
        public virtual IAsyncResult BeginListRepositoryAssociations(ListRepositoryAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRepositoryAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRepositoryAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRepositoryAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRepositoryAssociations.</param>
        /// 
        /// <returns>Returns a  ListRepositoryAssociationsResult from CodeGuruReviewer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/ListRepositoryAssociations">REST API Reference for ListRepositoryAssociations Operation</seealso>
        public virtual ListRepositoryAssociationsResponse EndListRepositoryAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRepositoryAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Returns the list of tags associated with an associated repository resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonCodeGuruReviewerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from CodeGuruReviewer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PutRecommendationFeedback

        /// <summary>
        /// Stores customer feedback for a CodeGuru Reviewer recommendation. When this API is
        /// called again with different reactions the previous feedback is overwritten.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRecommendationFeedback service method.</param>
        /// 
        /// <returns>The response from the PutRecommendationFeedback service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/PutRecommendationFeedback">REST API Reference for PutRecommendationFeedback Operation</seealso>
        public virtual PutRecommendationFeedbackResponse PutRecommendationFeedback(PutRecommendationFeedbackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRecommendationFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRecommendationFeedbackResponseUnmarshaller.Instance;

            return Invoke<PutRecommendationFeedbackResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutRecommendationFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRecommendationFeedback operation on AmazonCodeGuruReviewerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRecommendationFeedback
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/PutRecommendationFeedback">REST API Reference for PutRecommendationFeedback Operation</seealso>
        public virtual IAsyncResult BeginPutRecommendationFeedback(PutRecommendationFeedbackRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRecommendationFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRecommendationFeedbackResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutRecommendationFeedback operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRecommendationFeedback.</param>
        /// 
        /// <returns>Returns a  PutRecommendationFeedbackResult from CodeGuruReviewer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/PutRecommendationFeedback">REST API Reference for PutRecommendationFeedback Operation</seealso>
        public virtual PutRecommendationFeedbackResponse EndPutRecommendationFeedback(IAsyncResult asyncResult)
        {
            return EndInvoke<PutRecommendationFeedbackResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds one or more tags to an associated repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonCodeGuruReviewerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from CodeGuruReviewer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes a tag from an associated repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonCodeGuruReviewerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from CodeGuruReviewer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
    }
}