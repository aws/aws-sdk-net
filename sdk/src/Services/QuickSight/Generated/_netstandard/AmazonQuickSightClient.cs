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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.QuickSight.Model;
using Amazon.QuickSight.Model.Internal.MarshallTransformations;
using Amazon.QuickSight.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.QuickSight
{
    /// <summary>
    /// <para>Implementation for accessing QuickSight</para>
    ///
    /// Amazon QuickSight API Reference 
    /// <para>
    /// Amazon QuickSight is a fully managed, serverless business intelligence service for
    /// the Amazon Web Services Cloud that makes it easy to extend data and insights to every
    /// user in your organization. This API reference contains documentation for a programming
    /// interface that you can use to manage Amazon QuickSight. 
    /// </para>
    /// </summary>
    public partial class AmazonQuickSightClient : AmazonServiceClient, IAmazonQuickSight
    {
        private static IServiceMetadata serviceMetadata = new AmazonQuickSightMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonQuickSightClient with the credentials loaded from the application's
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
        public AmazonQuickSightClient()
            : base(new AmazonQuickSightConfig()) { }

        /// <summary>
        /// Constructs AmazonQuickSightClient with the credentials loaded from the application's
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
        public AmazonQuickSightClient(RegionEndpoint region)
            : base(new AmazonQuickSightConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonQuickSightClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonQuickSightClient Configuration Object</param>
        public AmazonQuickSightClient(AmazonQuickSightConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonQuickSightClient(AWSCredentials credentials)
            : this(credentials, new AmazonQuickSightConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQuickSightClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonQuickSightConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Credentials and an
        /// AmazonQuickSightClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonQuickSightClient Configuration Object</param>
        public AmazonQuickSightClient(AWSCredentials credentials, AmazonQuickSightConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonQuickSightClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQuickSightConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQuickSightClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQuickSightConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQuickSightClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonQuickSightClient Configuration Object</param>
        public AmazonQuickSightClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonQuickSightConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonQuickSightClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQuickSightConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQuickSightClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQuickSightConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQuickSightClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonQuickSightClient Configuration Object</param>
        public AmazonQuickSightClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonQuickSightConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IQuickSightPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IQuickSightPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new QuickSightPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonQuickSightEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonQuickSightAuthSchemeHandler());
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


        #region  BatchCreateTopicReviewedAnswer

        internal virtual BatchCreateTopicReviewedAnswerResponse BatchCreateTopicReviewedAnswer(BatchCreateTopicReviewedAnswerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreateTopicReviewedAnswerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateTopicReviewedAnswerResponseUnmarshaller.Instance;

            return Invoke<BatchCreateTopicReviewedAnswerResponse>(request, options);
        }



        /// <summary>
        /// Creates new reviewed answers for a Q Topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateTopicReviewedAnswer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchCreateTopicReviewedAnswer service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/BatchCreateTopicReviewedAnswer">REST API Reference for BatchCreateTopicReviewedAnswer Operation</seealso>
        public virtual Task<BatchCreateTopicReviewedAnswerResponse> BatchCreateTopicReviewedAnswerAsync(BatchCreateTopicReviewedAnswerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreateTopicReviewedAnswerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateTopicReviewedAnswerResponseUnmarshaller.Instance;

            return InvokeAsync<BatchCreateTopicReviewedAnswerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchDeleteTopicReviewedAnswer

        internal virtual BatchDeleteTopicReviewedAnswerResponse BatchDeleteTopicReviewedAnswer(BatchDeleteTopicReviewedAnswerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteTopicReviewedAnswerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteTopicReviewedAnswerResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteTopicReviewedAnswerResponse>(request, options);
        }



        /// <summary>
        /// Deletes reviewed answers for Q Topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteTopicReviewedAnswer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteTopicReviewedAnswer service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/BatchDeleteTopicReviewedAnswer">REST API Reference for BatchDeleteTopicReviewedAnswer Operation</seealso>
        public virtual Task<BatchDeleteTopicReviewedAnswerResponse> BatchDeleteTopicReviewedAnswerAsync(BatchDeleteTopicReviewedAnswerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteTopicReviewedAnswerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteTopicReviewedAnswerResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteTopicReviewedAnswerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CancelIngestion

        internal virtual CancelIngestionResponse CancelIngestion(CancelIngestionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelIngestionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelIngestionResponseUnmarshaller.Instance;

            return Invoke<CancelIngestionResponse>(request, options);
        }



        /// <summary>
        /// Cancels an ongoing ingestion of data into SPICE.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelIngestion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelIngestion service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CancelIngestion">REST API Reference for CancelIngestion Operation</seealso>
        public virtual Task<CancelIngestionResponse> CancelIngestionAsync(CancelIngestionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelIngestionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelIngestionResponseUnmarshaller.Instance;

            return InvokeAsync<CancelIngestionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAccountCustomization

        internal virtual CreateAccountCustomizationResponse CreateAccountCustomization(CreateAccountCustomizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccountCustomizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccountCustomizationResponseUnmarshaller.Instance;

            return Invoke<CreateAccountCustomizationResponse>(request, options);
        }



        /// <summary>
        /// Creates Amazon QuickSight customizations for the current Amazon Web Services Region.
        /// Currently, you can add a custom default theme by using the <c>CreateAccountCustomization</c>
        /// or <c>UpdateAccountCustomization</c> API operation. To further customize Amazon QuickSight
        /// by removing Amazon QuickSight sample assets and videos for all new users, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/customizing-quicksight.html">Customizing
        /// Amazon QuickSight</a> in the <i>Amazon QuickSight User Guide.</i> 
        /// 
        ///  
        /// <para>
        /// You can create customizations for your Amazon Web Services account or, if you specify
        /// a namespace, for a QuickSight namespace instead. Customizations that apply to a namespace
        /// always override customizations that apply to an Amazon Web Services account. To find
        /// out which customizations apply, use the <c>DescribeAccountCustomization</c> API operation.
        /// </para>
        ///  
        /// <para>
        /// Before you use the <c>CreateAccountCustomization</c> API operation to add a theme
        /// as the namespace default, make sure that you first share the theme with the namespace.
        /// If you don't share it with the namespace, the theme isn't visible to your users even
        /// if you make it the default theme. To check if the theme is shared, view the current
        /// permissions by using the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_DescribeThemePermissions.html">DescribeThemePermissions</a>
        /// </c> API operation. To share the theme, grant permissions by using the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_UpdateThemePermissions.html">UpdateThemePermissions</a>
        /// </c> API operation. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountCustomization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccountCustomization service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateAccountCustomization">REST API Reference for CreateAccountCustomization Operation</seealso>
        public virtual Task<CreateAccountCustomizationResponse> CreateAccountCustomizationAsync(CreateAccountCustomizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccountCustomizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccountCustomizationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAccountCustomizationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAccountSubscription

        internal virtual CreateAccountSubscriptionResponse CreateAccountSubscription(CreateAccountSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccountSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccountSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateAccountSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon QuickSight account, or subscribes to Amazon QuickSight Q.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Region for the account is derived from what is configured
        /// in the CLI or SDK.
        /// </para>
        ///  
        /// <para>
        /// Before you use this operation, make sure that you can connect to an existing Amazon
        /// Web Services account. If you don't have an Amazon Web Services account, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/setting-up-aws-sign-up.html">Sign
        /// up for Amazon Web Services</a> in the <i>Amazon QuickSight User Guide</i>. The person
        /// who signs up for Amazon QuickSight needs to have the correct Identity and Access Management
        /// (IAM) permissions. For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/iam-policy-examples.html">IAM
        /// Policy Examples for Amazon QuickSight</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If your IAM policy includes both the <c>Subscribe</c> and <c>CreateAccountSubscription</c>
        /// actions, make sure that both actions are set to <c>Allow</c>. If either action is
        /// set to <c>Deny</c>, the <c>Deny</c> action prevails and your API call fails.
        /// </para>
        ///  
        /// <para>
        /// You can't pass an existing IAM role to access other Amazon Web Services services using
        /// this API operation. To pass your existing IAM role to Amazon QuickSight, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/security_iam_service-with-iam.html#security-create-iam-role">Passing
        /// IAM roles to Amazon QuickSight</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can't set default resource access on the new account from the Amazon QuickSight
        /// API. Instead, add default resource access from the Amazon QuickSight console. For
        /// more information about setting default resource access to Amazon Web Services services,
        /// see <a href="https://docs.aws.amazon.com/quicksight/latest/user/scoping-policies-defaults.html">Setting
        /// default resource access to Amazon Web Services services</a> in the <i>Amazon QuickSight
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccountSubscription service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateAccountSubscription">REST API Reference for CreateAccountSubscription Operation</seealso>
        public virtual Task<CreateAccountSubscriptionResponse> CreateAccountSubscriptionAsync(CreateAccountSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccountSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccountSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAccountSubscriptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAnalysis

        internal virtual CreateAnalysisResponse CreateAnalysis(CreateAnalysisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAnalysisResponseUnmarshaller.Instance;

            return Invoke<CreateAnalysisResponse>(request, options);
        }



        /// <summary>
        /// Creates an analysis in Amazon QuickSight. Analyses can be created either from a template
        /// or from an <c>AnalysisDefinition</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAnalysis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAnalysis service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateAnalysis">REST API Reference for CreateAnalysis Operation</seealso>
        public virtual Task<CreateAnalysisResponse> CreateAnalysisAsync(CreateAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAnalysisResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAnalysisResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateBrand

        internal virtual CreateBrandResponse CreateBrand(CreateBrandRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBrandRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBrandResponseUnmarshaller.Instance;

            return Invoke<CreateBrandResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon QuickSight brand.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBrand service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBrand service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalServerException">
        /// An internal service exception.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateBrand">REST API Reference for CreateBrand Operation</seealso>
        public virtual Task<CreateBrandResponse> CreateBrandAsync(CreateBrandRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBrandRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBrandResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBrandResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateCustomPermissions

        internal virtual CreateCustomPermissionsResponse CreateCustomPermissions(CreateCustomPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomPermissionsResponseUnmarshaller.Instance;

            return Invoke<CreateCustomPermissionsResponse>(request, options);
        }



        /// <summary>
        /// Creates a custom permissions profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCustomPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateCustomPermissions">REST API Reference for CreateCustomPermissions Operation</seealso>
        public virtual Task<CreateCustomPermissionsResponse> CreateCustomPermissionsAsync(CreateCustomPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomPermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCustomPermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDashboard

        internal virtual CreateDashboardResponse CreateDashboard(CreateDashboardRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDashboardResponseUnmarshaller.Instance;

            return Invoke<CreateDashboardResponse>(request, options);
        }



        /// <summary>
        /// Creates a dashboard from either a template or directly with a <c>DashboardDefinition</c>.
        /// To first create a template, see the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_CreateTemplate.html">CreateTemplate</a>
        /// </c> API operation.
        /// 
        ///  
        /// <para>
        /// A dashboard is an entity in Amazon QuickSight that identifies Amazon QuickSight reports,
        /// created from analyses. You can share Amazon QuickSight dashboards. With the right
        /// permissions, you can create scheduled email reports from them. If you have the correct
        /// permissions, you can create a dashboard from a template that exists in a different
        /// Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDashboard service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDashboard">REST API Reference for CreateDashboard Operation</seealso>
        public virtual Task<CreateDashboardResponse> CreateDashboardAsync(CreateDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDashboardResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDashboardResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDataSet

        internal virtual CreateDataSetResponse CreateDataSet(CreateDataSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSetResponseUnmarshaller.Instance;

            return Invoke<CreateDataSetResponse>(request, options);
        }



        /// <summary>
        /// Creates a dataset. This operation doesn't support datasets that include uploaded files
        /// as a source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataSet service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDataSet">REST API Reference for CreateDataSet Operation</seealso>
        public virtual Task<CreateDataSetResponse> CreateDataSetAsync(CreateDataSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDataSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDataSource

        internal virtual CreateDataSourceResponse CreateDataSource(CreateDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceResponseUnmarshaller.Instance;

            return Invoke<CreateDataSourceResponse>(request, options);
        }



        /// <summary>
        /// Creates a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataSource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.CustomerManagedKeyUnavailableException">
        /// The customer managed key that is registered to your Amazon QuickSight account is unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        public virtual Task<CreateDataSourceResponse> CreateDataSourceAsync(CreateDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDataSourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateFolder

        internal virtual CreateFolderResponse CreateFolder(CreateFolderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFolderResponseUnmarshaller.Instance;

            return Invoke<CreateFolderResponse>(request, options);
        }



        /// <summary>
        /// Creates an empty shared folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFolder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFolder service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateFolder">REST API Reference for CreateFolder Operation</seealso>
        public virtual Task<CreateFolderResponse> CreateFolderAsync(CreateFolderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFolderResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFolderResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateFolderMembership

        internal virtual CreateFolderMembershipResponse CreateFolderMembership(CreateFolderMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFolderMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFolderMembershipResponseUnmarshaller.Instance;

            return Invoke<CreateFolderMembershipResponse>(request, options);
        }



        /// <summary>
        /// Adds an asset, such as a dashboard, analysis, or dataset into a folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFolderMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFolderMembership service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateFolderMembership">REST API Reference for CreateFolderMembership Operation</seealso>
        public virtual Task<CreateFolderMembershipResponse> CreateFolderMembershipAsync(CreateFolderMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFolderMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFolderMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFolderMembershipResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateGroup

        internal virtual CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return Invoke<CreateGroupResponse>(request, options);
        }



        /// <summary>
        /// Use the <c>CreateGroup</c> operation to create a group in Amazon QuickSight. You can
        /// create up to 10,000 groups in a namespace. If you want to create more than 10,000
        /// groups in a namespace, contact Amazon Web Services Support.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <c>arn:aws:quicksight:&lt;your-region&gt;:<i>&lt;relevant-aws-account-id&gt;</i>:group/default/<i>&lt;group-name&gt;</i>
        /// </c>.
        /// </para>
        ///  
        /// <para>
        /// The response is a group object.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateGroupMembership

        internal virtual CreateGroupMembershipResponse CreateGroupMembership(CreateGroupMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupMembershipResponseUnmarshaller.Instance;

            return Invoke<CreateGroupMembershipResponse>(request, options);
        }



        /// <summary>
        /// Adds an Amazon QuickSight user to an Amazon QuickSight group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGroupMembership service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroupMembership">REST API Reference for CreateGroupMembership Operation</seealso>
        public virtual Task<CreateGroupMembershipResponse> CreateGroupMembershipAsync(CreateGroupMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGroupMembershipResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateIAMPolicyAssignment

        internal virtual CreateIAMPolicyAssignmentResponse CreateIAMPolicyAssignment(CreateIAMPolicyAssignmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIAMPolicyAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIAMPolicyAssignmentResponseUnmarshaller.Instance;

            return Invoke<CreateIAMPolicyAssignmentResponse>(request, options);
        }



        /// <summary>
        /// Creates an assignment with one specified IAM policy, identified by its Amazon Resource
        /// Name (ARN). This policy assignment is attached to the specified groups or users of
        /// Amazon QuickSight. Assignment names are unique per Amazon Web Services account. To
        /// avoid overwriting rules in other namespaces, use assignment names that are unique.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIAMPolicyAssignment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIAMPolicyAssignment service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConcurrentUpdatingException">
        /// A resource is already in a state that indicates an operation is happening that must
        /// complete before a new update can be applied.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateIAMPolicyAssignment">REST API Reference for CreateIAMPolicyAssignment Operation</seealso>
        public virtual Task<CreateIAMPolicyAssignmentResponse> CreateIAMPolicyAssignmentAsync(CreateIAMPolicyAssignmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIAMPolicyAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIAMPolicyAssignmentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIAMPolicyAssignmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateIngestion

        internal virtual CreateIngestionResponse CreateIngestion(CreateIngestionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIngestionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIngestionResponseUnmarshaller.Instance;

            return Invoke<CreateIngestionResponse>(request, options);
        }



        /// <summary>
        /// Creates and starts a new SPICE ingestion for a dataset. You can manually refresh datasets
        /// in an Enterprise edition account 32 times in a 24-hour period. You can manually refresh
        /// datasets in a Standard edition account 8 times in a 24-hour period. Each 24-hour period
        /// is measured starting 24 hours before the current date and time.
        /// 
        ///  
        /// <para>
        /// Any ingestions operating on tagged datasets inherit the same tags automatically for
        /// use in access control. For an example, see <a href="http://aws.amazon.com/premiumsupport/knowledge-center/iam-ec2-resource-tags/">How
        /// do I create an IAM policy to control access to Amazon EC2 resources using tags?</a>
        /// in the Amazon Web Services Knowledge Center. Tags are visible on the tagged dataset,
        /// but not on the ingestion resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIngestion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIngestion service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateIngestion">REST API Reference for CreateIngestion Operation</seealso>
        public virtual Task<CreateIngestionResponse> CreateIngestionAsync(CreateIngestionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIngestionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIngestionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIngestionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateNamespace

        internal virtual CreateNamespaceResponse CreateNamespace(CreateNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNamespaceResponseUnmarshaller.Instance;

            return Invoke<CreateNamespaceResponse>(request, options);
        }



        /// <summary>
        /// (Enterprise edition only) Creates a new namespace for you to use with Amazon QuickSight.
        /// 
        ///  
        /// <para>
        /// A namespace allows you to isolate the Amazon QuickSight users and groups that are
        /// registered for that namespace. Users that access the namespace can share assets only
        /// with other users or groups in the same namespace. They can't see users and groups
        /// in other namespaces. You can create a namespace after your Amazon Web Services account
        /// is subscribed to Amazon QuickSight. The namespace must be unique within the Amazon
        /// Web Services account. By default, there is a limit of 100 namespaces per Amazon Web
        /// Services account. To increase your limit, create a ticket with Amazon Web ServicesSupport.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNamespace service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateNamespace">REST API Reference for CreateNamespace Operation</seealso>
        public virtual Task<CreateNamespaceResponse> CreateNamespaceAsync(CreateNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNamespaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateRefreshSchedule

        internal virtual CreateRefreshScheduleResponse CreateRefreshSchedule(CreateRefreshScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRefreshScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRefreshScheduleResponseUnmarshaller.Instance;

            return Invoke<CreateRefreshScheduleResponse>(request, options);
        }



        /// <summary>
        /// Creates a refresh schedule for a dataset. You can create up to 5 different schedules
        /// for a single dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRefreshSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRefreshSchedule service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateRefreshSchedule">REST API Reference for CreateRefreshSchedule Operation</seealso>
        public virtual Task<CreateRefreshScheduleResponse> CreateRefreshScheduleAsync(CreateRefreshScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRefreshScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRefreshScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRefreshScheduleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateRoleMembership

        internal virtual CreateRoleMembershipResponse CreateRoleMembership(CreateRoleMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRoleMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRoleMembershipResponseUnmarshaller.Instance;

            return Invoke<CreateRoleMembershipResponse>(request, options);
        }



        /// <summary>
        /// Use <c>CreateRoleMembership</c> to add an existing Amazon QuickSight group to an existing
        /// role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoleMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRoleMembership service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateRoleMembership">REST API Reference for CreateRoleMembership Operation</seealso>
        public virtual Task<CreateRoleMembershipResponse> CreateRoleMembershipAsync(CreateRoleMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRoleMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRoleMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRoleMembershipResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateTemplate

        internal virtual CreateTemplateResponse CreateTemplate(CreateTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateTemplateResponse>(request, options);
        }



        /// <summary>
        /// Creates a template either from a <c>TemplateDefinition</c> or from an existing Amazon
        /// QuickSight analysis or template. You can use the resulting template to create additional
        /// dashboards, templates, or analyses.
        /// 
        ///  
        /// <para>
        /// A <i>template</i> is an entity in Amazon QuickSight that encapsulates the metadata
        /// required to create an analysis and that you can use to create s dashboard. A template
        /// adds a layer of abstraction by using placeholders to replace the dataset associated
        /// with the analysis. You can use templates to create dashboards by replacing dataset
        /// placeholders with datasets that follow the same schema that was used to create the
        /// source analysis and template.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTemplate service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        public virtual Task<CreateTemplateResponse> CreateTemplateAsync(CreateTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateTemplateAlias

        internal virtual CreateTemplateAliasResponse CreateTemplateAlias(CreateTemplateAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTemplateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTemplateAliasResponseUnmarshaller.Instance;

            return Invoke<CreateTemplateAliasResponse>(request, options);
        }



        /// <summary>
        /// Creates a template alias for a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplateAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTemplateAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTemplateAlias">REST API Reference for CreateTemplateAlias Operation</seealso>
        public virtual Task<CreateTemplateAliasResponse> CreateTemplateAliasAsync(CreateTemplateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTemplateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTemplateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTemplateAliasResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateTheme

        internal virtual CreateThemeResponse CreateTheme(CreateThemeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateThemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateThemeResponseUnmarshaller.Instance;

            return Invoke<CreateThemeResponse>(request, options);
        }



        /// <summary>
        /// Creates a theme.
        /// 
        ///  
        /// <para>
        /// A <i>theme</i> is set of configuration options for color and layout. Themes apply
        /// to analyses and dashboards. For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/themes-in-quicksight.html">Using
        /// Themes in Amazon QuickSight</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTheme service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTheme service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTheme">REST API Reference for CreateTheme Operation</seealso>
        public virtual Task<CreateThemeResponse> CreateThemeAsync(CreateThemeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateThemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateThemeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateThemeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateThemeAlias

        internal virtual CreateThemeAliasResponse CreateThemeAlias(CreateThemeAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateThemeAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateThemeAliasResponseUnmarshaller.Instance;

            return Invoke<CreateThemeAliasResponse>(request, options);
        }



        /// <summary>
        /// Creates a theme alias for a theme.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateThemeAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateThemeAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateThemeAlias">REST API Reference for CreateThemeAlias Operation</seealso>
        public virtual Task<CreateThemeAliasResponse> CreateThemeAliasAsync(CreateThemeAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateThemeAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateThemeAliasResponseUnmarshaller.Instance;

            return InvokeAsync<CreateThemeAliasResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateTopic

        internal virtual CreateTopicResponse CreateTopic(CreateTopicRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTopicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTopicResponseUnmarshaller.Instance;

            return Invoke<CreateTopicResponse>(request, options);
        }



        /// <summary>
        /// Creates a new Q topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTopic service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTopic service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTopic">REST API Reference for CreateTopic Operation</seealso>
        public virtual Task<CreateTopicResponse> CreateTopicAsync(CreateTopicRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTopicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTopicResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTopicResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateTopicRefreshSchedule

        internal virtual CreateTopicRefreshScheduleResponse CreateTopicRefreshSchedule(CreateTopicRefreshScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTopicRefreshScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTopicRefreshScheduleResponseUnmarshaller.Instance;

            return Invoke<CreateTopicRefreshScheduleResponse>(request, options);
        }



        /// <summary>
        /// Creates a topic refresh schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTopicRefreshSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTopicRefreshSchedule service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateTopicRefreshSchedule">REST API Reference for CreateTopicRefreshSchedule Operation</seealso>
        public virtual Task<CreateTopicRefreshScheduleResponse> CreateTopicRefreshScheduleAsync(CreateTopicRefreshScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTopicRefreshScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTopicRefreshScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTopicRefreshScheduleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateVPCConnection

        internal virtual CreateVPCConnectionResponse CreateVPCConnection(CreateVPCConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVPCConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVPCConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateVPCConnectionResponse>(request, options);
        }



        /// <summary>
        /// Creates a new VPC connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVPCConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVPCConnection service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateVPCConnection">REST API Reference for CreateVPCConnection Operation</seealso>
        public virtual Task<CreateVPCConnectionResponse> CreateVPCConnectionAsync(CreateVPCConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVPCConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVPCConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVPCConnectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAccountCustomization

        internal virtual DeleteAccountCustomizationResponse DeleteAccountCustomization(DeleteAccountCustomizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccountCustomizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountCustomizationResponseUnmarshaller.Instance;

            return Invoke<DeleteAccountCustomizationResponse>(request, options);
        }



        /// <summary>
        /// Deletes all Amazon QuickSight customizations in this Amazon Web Services Region for
        /// the specified Amazon Web Services account and Amazon QuickSight namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountCustomization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccountCustomization service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteAccountCustomization">REST API Reference for DeleteAccountCustomization Operation</seealso>
        public virtual Task<DeleteAccountCustomizationResponse> DeleteAccountCustomizationAsync(DeleteAccountCustomizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccountCustomizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountCustomizationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAccountCustomizationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAccountSubscription

        internal virtual DeleteAccountSubscriptionResponse DeleteAccountSubscription(DeleteAccountSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccountSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteAccountSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Use the <c>DeleteAccountSubscription</c> operation to delete an Amazon QuickSight
        /// account. This operation will result in an error message if you have configured your
        /// account termination protection settings to <c>True</c>. To change this setting and
        /// delete your account, call the <c>UpdateAccountSettings</c> API and set the value of
        /// the <c>TerminationProtectionEnabled</c> parameter to <c>False</c>, then make another
        /// call to the <c>DeleteAccountSubscription</c> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccountSubscription service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteAccountSubscription">REST API Reference for DeleteAccountSubscription Operation</seealso>
        public virtual Task<DeleteAccountSubscriptionResponse> DeleteAccountSubscriptionAsync(DeleteAccountSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccountSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAccountSubscriptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAnalysis

        internal virtual DeleteAnalysisResponse DeleteAnalysis(DeleteAnalysisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnalysisResponseUnmarshaller.Instance;

            return Invoke<DeleteAnalysisResponse>(request, options);
        }



        /// <summary>
        /// Deletes an analysis from Amazon QuickSight. You can optionally include a recovery
        /// window during which you can restore the analysis. If you don't specify a recovery
        /// window value, the operation defaults to 30 days. Amazon QuickSight attaches a <c>DeletionTime</c>
        /// stamp to the response that specifies the end of the recovery window. At the end of
        /// the recovery window, Amazon QuickSight deletes the analysis permanently.
        /// 
        ///  
        /// <para>
        /// At any time before recovery window ends, you can use the <c>RestoreAnalysis</c> API
        /// operation to remove the <c>DeletionTime</c> stamp and cancel the deletion of the analysis.
        /// The analysis remains visible in the API until it's deleted, so you can describe it
        /// but you can't make a template from it.
        /// </para>
        ///  
        /// <para>
        /// An analysis that's scheduled for deletion isn't accessible in the Amazon QuickSight
        /// console. To access it in the console, restore it. Deleting an analysis doesn't delete
        /// the dashboards that you publish from it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnalysis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAnalysis service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteAnalysis">REST API Reference for DeleteAnalysis Operation</seealso>
        public virtual Task<DeleteAnalysisResponse> DeleteAnalysisAsync(DeleteAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnalysisResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAnalysisResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteBrand

        internal virtual DeleteBrandResponse DeleteBrand(DeleteBrandRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBrandRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBrandResponseUnmarshaller.Instance;

            return Invoke<DeleteBrandResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon QuickSight brand.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBrand service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBrand service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalServerException">
        /// An internal service exception.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteBrand">REST API Reference for DeleteBrand Operation</seealso>
        public virtual Task<DeleteBrandResponse> DeleteBrandAsync(DeleteBrandRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBrandRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBrandResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBrandResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteBrandAssignment

        internal virtual DeleteBrandAssignmentResponse DeleteBrandAssignment(DeleteBrandAssignmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBrandAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBrandAssignmentResponseUnmarshaller.Instance;

            return Invoke<DeleteBrandAssignmentResponse>(request, options);
        }



        /// <summary>
        /// Deletes a brand assignment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBrandAssignment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBrandAssignment service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalServerException">
        /// An internal service exception.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteBrandAssignment">REST API Reference for DeleteBrandAssignment Operation</seealso>
        public virtual Task<DeleteBrandAssignmentResponse> DeleteBrandAssignmentAsync(DeleteBrandAssignmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBrandAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBrandAssignmentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBrandAssignmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteCustomPermissions

        internal virtual DeleteCustomPermissionsResponse DeleteCustomPermissions(DeleteCustomPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomPermissionsResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomPermissionsResponse>(request, options);
        }



        /// <summary>
        /// Deletes a custom permissions profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCustomPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteCustomPermissions">REST API Reference for DeleteCustomPermissions Operation</seealso>
        public virtual Task<DeleteCustomPermissionsResponse> DeleteCustomPermissionsAsync(DeleteCustomPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomPermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCustomPermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDashboard

        internal virtual DeleteDashboardResponse DeleteDashboard(DeleteDashboardRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDashboardResponseUnmarshaller.Instance;

            return Invoke<DeleteDashboardResponse>(request, options);
        }



        /// <summary>
        /// Deletes a dashboard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDashboard service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDashboard">REST API Reference for DeleteDashboard Operation</seealso>
        public virtual Task<DeleteDashboardResponse> DeleteDashboardAsync(DeleteDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDashboardResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDashboardResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDataSet

        internal virtual DeleteDataSetResponse DeleteDataSet(DeleteDataSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSetResponseUnmarshaller.Instance;

            return Invoke<DeleteDataSetResponse>(request, options);
        }



        /// <summary>
        /// Deletes a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataSet service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDataSet">REST API Reference for DeleteDataSet Operation</seealso>
        public virtual Task<DeleteDataSetResponse> DeleteDataSetAsync(DeleteDataSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDataSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDataSetRefreshProperties

        internal virtual DeleteDataSetRefreshPropertiesResponse DeleteDataSetRefreshProperties(DeleteDataSetRefreshPropertiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataSetRefreshPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSetRefreshPropertiesResponseUnmarshaller.Instance;

            return Invoke<DeleteDataSetRefreshPropertiesResponse>(request, options);
        }



        /// <summary>
        /// Deletes the dataset refresh properties of the dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSetRefreshProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataSetRefreshProperties service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDataSetRefreshProperties">REST API Reference for DeleteDataSetRefreshProperties Operation</seealso>
        public virtual Task<DeleteDataSetRefreshPropertiesResponse> DeleteDataSetRefreshPropertiesAsync(DeleteDataSetRefreshPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataSetRefreshPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSetRefreshPropertiesResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDataSetRefreshPropertiesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDataSource

        internal virtual DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteDataSourceResponse>(request, options);
        }



        /// <summary>
        /// Deletes the data source permanently. This operation breaks all the datasets that reference
        /// the deleted data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataSource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual Task<DeleteDataSourceResponse> DeleteDataSourceAsync(DeleteDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDataSourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDefaultQBusinessApplication

        internal virtual DeleteDefaultQBusinessApplicationResponse DeleteDefaultQBusinessApplication(DeleteDefaultQBusinessApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDefaultQBusinessApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDefaultQBusinessApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteDefaultQBusinessApplicationResponse>(request, options);
        }



        /// <summary>
        /// Deletes a linked Amazon Q Business application from an Amazon QuickSight account
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDefaultQBusinessApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDefaultQBusinessApplication service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteDefaultQBusinessApplication">REST API Reference for DeleteDefaultQBusinessApplication Operation</seealso>
        public virtual Task<DeleteDefaultQBusinessApplicationResponse> DeleteDefaultQBusinessApplicationAsync(DeleteDefaultQBusinessApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDefaultQBusinessApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDefaultQBusinessApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDefaultQBusinessApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteFolder

        internal virtual DeleteFolderResponse DeleteFolder(DeleteFolderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFolderResponseUnmarshaller.Instance;

            return Invoke<DeleteFolderResponse>(request, options);
        }



        /// <summary>
        /// Deletes an empty folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFolder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFolder service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteFolder">REST API Reference for DeleteFolder Operation</seealso>
        public virtual Task<DeleteFolderResponse> DeleteFolderAsync(DeleteFolderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFolderResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFolderResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteFolderMembership

        internal virtual DeleteFolderMembershipResponse DeleteFolderMembership(DeleteFolderMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFolderMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFolderMembershipResponseUnmarshaller.Instance;

            return Invoke<DeleteFolderMembershipResponse>(request, options);
        }



        /// <summary>
        /// Removes an asset, such as a dashboard, analysis, or dataset, from a folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFolderMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFolderMembership service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteFolderMembership">REST API Reference for DeleteFolderMembership Operation</seealso>
        public virtual Task<DeleteFolderMembershipResponse> DeleteFolderMembershipAsync(DeleteFolderMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFolderMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFolderMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFolderMembershipResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteGroup

        internal virtual DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupResponse>(request, options);
        }



        /// <summary>
        /// Removes a user group from Amazon QuickSight.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteGroupMembership

        internal virtual DeleteGroupMembershipResponse DeleteGroupMembership(DeleteGroupMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupMembershipResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupMembershipResponse>(request, options);
        }



        /// <summary>
        /// Removes a user from a group so that the user is no longer a member of the group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGroupMembership service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroupMembership">REST API Reference for DeleteGroupMembership Operation</seealso>
        public virtual Task<DeleteGroupMembershipResponse> DeleteGroupMembershipAsync(DeleteGroupMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGroupMembershipResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteIAMPolicyAssignment

        internal virtual DeleteIAMPolicyAssignmentResponse DeleteIAMPolicyAssignment(DeleteIAMPolicyAssignmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIAMPolicyAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIAMPolicyAssignmentResponseUnmarshaller.Instance;

            return Invoke<DeleteIAMPolicyAssignmentResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing IAM policy assignment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIAMPolicyAssignment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIAMPolicyAssignment service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConcurrentUpdatingException">
        /// A resource is already in a state that indicates an operation is happening that must
        /// complete before a new update can be applied.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteIAMPolicyAssignment">REST API Reference for DeleteIAMPolicyAssignment Operation</seealso>
        public virtual Task<DeleteIAMPolicyAssignmentResponse> DeleteIAMPolicyAssignmentAsync(DeleteIAMPolicyAssignmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIAMPolicyAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIAMPolicyAssignmentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIAMPolicyAssignmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteIdentityPropagationConfig

        internal virtual DeleteIdentityPropagationConfigResponse DeleteIdentityPropagationConfig(DeleteIdentityPropagationConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIdentityPropagationConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdentityPropagationConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteIdentityPropagationConfigResponse>(request, options);
        }



        /// <summary>
        /// Deletes all access scopes and authorized targets that are associated with a service
        /// from the Amazon QuickSight IAM Identity Center application.
        /// 
        ///  
        /// <para>
        /// This operation is only supported for Amazon QuickSight accounts that use IAM Identity
        /// Center.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityPropagationConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIdentityPropagationConfig service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteIdentityPropagationConfig">REST API Reference for DeleteIdentityPropagationConfig Operation</seealso>
        public virtual Task<DeleteIdentityPropagationConfigResponse> DeleteIdentityPropagationConfigAsync(DeleteIdentityPropagationConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIdentityPropagationConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdentityPropagationConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIdentityPropagationConfigResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteNamespace

        internal virtual DeleteNamespaceResponse DeleteNamespace(DeleteNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNamespaceResponseUnmarshaller.Instance;

            return Invoke<DeleteNamespaceResponse>(request, options);
        }



        /// <summary>
        /// Deletes a namespace and the users and groups that are associated with the namespace.
        /// This is an asynchronous process. Assets including dashboards, analyses, datasets and
        /// data sources are not deleted. To delete these assets, you use the API operations for
        /// the relevant asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNamespace service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        public virtual Task<DeleteNamespaceResponse> DeleteNamespaceAsync(DeleteNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNamespaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteRefreshSchedule

        internal virtual DeleteRefreshScheduleResponse DeleteRefreshSchedule(DeleteRefreshScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRefreshScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRefreshScheduleResponseUnmarshaller.Instance;

            return Invoke<DeleteRefreshScheduleResponse>(request, options);
        }



        /// <summary>
        /// Deletes a refresh schedule from a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRefreshSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRefreshSchedule service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteRefreshSchedule">REST API Reference for DeleteRefreshSchedule Operation</seealso>
        public virtual Task<DeleteRefreshScheduleResponse> DeleteRefreshScheduleAsync(DeleteRefreshScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRefreshScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRefreshScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRefreshScheduleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteRoleCustomPermission

        internal virtual DeleteRoleCustomPermissionResponse DeleteRoleCustomPermission(DeleteRoleCustomPermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRoleCustomPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRoleCustomPermissionResponseUnmarshaller.Instance;

            return Invoke<DeleteRoleCustomPermissionResponse>(request, options);
        }



        /// <summary>
        /// Removes custom permissions from the role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoleCustomPermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRoleCustomPermission service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteRoleCustomPermission">REST API Reference for DeleteRoleCustomPermission Operation</seealso>
        public virtual Task<DeleteRoleCustomPermissionResponse> DeleteRoleCustomPermissionAsync(DeleteRoleCustomPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRoleCustomPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRoleCustomPermissionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRoleCustomPermissionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteRoleMembership

        internal virtual DeleteRoleMembershipResponse DeleteRoleMembership(DeleteRoleMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRoleMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRoleMembershipResponseUnmarshaller.Instance;

            return Invoke<DeleteRoleMembershipResponse>(request, options);
        }



        /// <summary>
        /// Removes a group from a role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoleMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRoleMembership service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteRoleMembership">REST API Reference for DeleteRoleMembership Operation</seealso>
        public virtual Task<DeleteRoleMembershipResponse> DeleteRoleMembershipAsync(DeleteRoleMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRoleMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRoleMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRoleMembershipResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTemplate

        internal virtual DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteTemplateResponse>(request, options);
        }



        /// <summary>
        /// Deletes a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTemplate service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        public virtual Task<DeleteTemplateResponse> DeleteTemplateAsync(DeleteTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTemplateAlias

        internal virtual DeleteTemplateAliasResponse DeleteTemplateAlias(DeleteTemplateAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTemplateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTemplateAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteTemplateAliasResponse>(request, options);
        }



        /// <summary>
        /// Deletes the item that the specified template alias points to. If you provide a specific
        /// alias, you delete the version of the template that the alias points to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplateAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTemplateAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTemplateAlias">REST API Reference for DeleteTemplateAlias Operation</seealso>
        public virtual Task<DeleteTemplateAliasResponse> DeleteTemplateAliasAsync(DeleteTemplateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTemplateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTemplateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTemplateAliasResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTheme

        internal virtual DeleteThemeResponse DeleteTheme(DeleteThemeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteThemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteThemeResponseUnmarshaller.Instance;

            return Invoke<DeleteThemeResponse>(request, options);
        }



        /// <summary>
        /// Deletes a theme.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTheme service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTheme service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTheme">REST API Reference for DeleteTheme Operation</seealso>
        public virtual Task<DeleteThemeResponse> DeleteThemeAsync(DeleteThemeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteThemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteThemeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteThemeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteThemeAlias

        internal virtual DeleteThemeAliasResponse DeleteThemeAlias(DeleteThemeAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteThemeAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteThemeAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteThemeAliasResponse>(request, options);
        }



        /// <summary>
        /// Deletes the version of the theme that the specified theme alias points to. If you
        /// provide a specific alias, you delete the version of the theme that the alias points
        /// to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteThemeAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteThemeAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteThemeAlias">REST API Reference for DeleteThemeAlias Operation</seealso>
        public virtual Task<DeleteThemeAliasResponse> DeleteThemeAliasAsync(DeleteThemeAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteThemeAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteThemeAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteThemeAliasResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTopic

        internal virtual DeleteTopicResponse DeleteTopic(DeleteTopicRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTopicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTopicResponseUnmarshaller.Instance;

            return Invoke<DeleteTopicResponse>(request, options);
        }



        /// <summary>
        /// Deletes a topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTopic service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTopic service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTopic">REST API Reference for DeleteTopic Operation</seealso>
        public virtual Task<DeleteTopicResponse> DeleteTopicAsync(DeleteTopicRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTopicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTopicResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTopicResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTopicRefreshSchedule

        internal virtual DeleteTopicRefreshScheduleResponse DeleteTopicRefreshSchedule(DeleteTopicRefreshScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTopicRefreshScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTopicRefreshScheduleResponseUnmarshaller.Instance;

            return Invoke<DeleteTopicRefreshScheduleResponse>(request, options);
        }



        /// <summary>
        /// Deletes a topic refresh schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTopicRefreshSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTopicRefreshSchedule service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteTopicRefreshSchedule">REST API Reference for DeleteTopicRefreshSchedule Operation</seealso>
        public virtual Task<DeleteTopicRefreshScheduleResponse> DeleteTopicRefreshScheduleAsync(DeleteTopicRefreshScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTopicRefreshScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTopicRefreshScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTopicRefreshScheduleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteUser

        internal virtual DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return Invoke<DeleteUserResponse>(request, options);
        }



        /// <summary>
        /// Deletes the Amazon QuickSight user that is associated with the identity of the IAM
        /// user or role that's making the call. The IAM user isn't deleted as a result of this
        /// call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteUserByPrincipalId

        internal virtual DeleteUserByPrincipalIdResponse DeleteUserByPrincipalId(DeleteUserByPrincipalIdRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserByPrincipalIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserByPrincipalIdResponseUnmarshaller.Instance;

            return Invoke<DeleteUserByPrincipalIdResponse>(request, options);
        }



        /// <summary>
        /// Deletes a user identified by its principal ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserByPrincipalId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUserByPrincipalId service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUserByPrincipalId">REST API Reference for DeleteUserByPrincipalId Operation</seealso>
        public virtual Task<DeleteUserByPrincipalIdResponse> DeleteUserByPrincipalIdAsync(DeleteUserByPrincipalIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserByPrincipalIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserByPrincipalIdResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserByPrincipalIdResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteUserCustomPermission

        internal virtual DeleteUserCustomPermissionResponse DeleteUserCustomPermission(DeleteUserCustomPermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserCustomPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserCustomPermissionResponseUnmarshaller.Instance;

            return Invoke<DeleteUserCustomPermissionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a custom permissions profile from a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserCustomPermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUserCustomPermission service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUserCustomPermission">REST API Reference for DeleteUserCustomPermission Operation</seealso>
        public virtual Task<DeleteUserCustomPermissionResponse> DeleteUserCustomPermissionAsync(DeleteUserCustomPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserCustomPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserCustomPermissionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserCustomPermissionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteVPCConnection

        internal virtual DeleteVPCConnectionResponse DeleteVPCConnection(DeleteVPCConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVPCConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVPCConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteVPCConnectionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a VPC connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVPCConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVPCConnection service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteVPCConnection">REST API Reference for DeleteVPCConnection Operation</seealso>
        public virtual Task<DeleteVPCConnectionResponse> DeleteVPCConnectionAsync(DeleteVPCConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVPCConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVPCConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVPCConnectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAccountCustomization

        internal virtual DescribeAccountCustomizationResponse DescribeAccountCustomization(DescribeAccountCustomizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountCustomizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountCustomizationResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountCustomizationResponse>(request, options);
        }



        /// <summary>
        /// Describes the customizations associated with the provided Amazon Web Services account
        /// and Amazon Amazon QuickSight namespace in an Amazon Web Services Region. The Amazon
        /// QuickSight console evaluates which customizations to apply by running this API operation
        /// with the <c>Resolved</c> flag included. 
        /// 
        ///  
        /// <para>
        /// To determine what customizations display when you run this command, it can help to
        /// visualize the relationship of the entities involved. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Amazon Web Services account</c> - The Amazon Web Services account exists at the
        /// top of the hierarchy. It has the potential to use all of the Amazon Web Services Regions
        /// and Amazon Web Services Services. When you subscribe to Amazon QuickSight, you choose
        /// one Amazon Web Services Region to use as your home Region. That's where your free
        /// SPICE capacity is located. You can use Amazon QuickSight in any supported Amazon Web
        /// Services Region. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Amazon Web Services Region</c> - In each Amazon Web Services Region where you
        /// sign in to Amazon QuickSight at least once, Amazon QuickSight acts as a separate instance
        /// of the same service. If you have a user directory, it resides in us-east-1, which
        /// is the US East (N. Virginia). Generally speaking, these users have access to Amazon
        /// QuickSight in any Amazon Web Services Region, unless they are constrained to a namespace.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To run the command in a different Amazon Web Services Region, you change your Region
        /// settings. If you're using the CLI, you can use one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-configure-options.html">command
        /// line options</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-configure-profiles.html">named
        /// profiles</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Run <c>aws configure</c> to change your default Amazon Web Services Region. Use Enter
        /// to key the same settings for your keys. For more information, see <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-chap-configure.html">Configuring
        /// the CLI</a>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>Namespace</c> - A QuickSight namespace is a partition that contains users and
        /// assets (data sources, datasets, dashboards, and so on). To access assets that are
        /// in a specific namespace, users and groups must also be part of the same namespace.
        /// People who share a namespace are completely isolated from users and assets in other
        /// namespaces, even if they are in the same Amazon Web Services account and Amazon Web
        /// Services Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Applied customizations</c> - Within an Amazon Web Services Region, a set of Amazon
        /// QuickSight customizations can apply to an Amazon Web Services account or to a namespace.
        /// Settings that you apply to a namespace override settings that you apply to an Amazon
        /// Web Services account. All settings are isolated to a single Amazon Web Services Region.
        /// To apply them in other Amazon Web Services Regions, run the <c>CreateAccountCustomization</c>
        /// command in each Amazon Web Services Region where you want to apply the same customizations.
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountCustomization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountCustomization service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAccountCustomization">REST API Reference for DescribeAccountCustomization Operation</seealso>
        public virtual Task<DescribeAccountCustomizationResponse> DescribeAccountCustomizationAsync(DescribeAccountCustomizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountCustomizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountCustomizationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountCustomizationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAccountSettings

        internal virtual DescribeAccountSettingsResponse DescribeAccountSettings(DescribeAccountSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountSettingsResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountSettingsResponse>(request, options);
        }



        /// <summary>
        /// Describes the settings that were used when your Amazon QuickSight subscription was
        /// first created in this Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountSettings service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAccountSettings">REST API Reference for DescribeAccountSettings Operation</seealso>
        public virtual Task<DescribeAccountSettingsResponse> DescribeAccountSettingsAsync(DescribeAccountSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAccountSubscription

        internal virtual DescribeAccountSubscriptionResponse DescribeAccountSubscription(DescribeAccountSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Use the DescribeAccountSubscription operation to receive a description of an Amazon
        /// QuickSight account's subscription. A successful API call returns an <c>AccountInfo</c>
        /// object that includes an account's name, subscription status, authentication type,
        /// edition, and notification email address.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountSubscription service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAccountSubscription">REST API Reference for DescribeAccountSubscription Operation</seealso>
        public virtual Task<DescribeAccountSubscriptionResponse> DescribeAccountSubscriptionAsync(DescribeAccountSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountSubscriptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAnalysis

        internal virtual DescribeAnalysisResponse DescribeAnalysis(DescribeAnalysisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAnalysisResponseUnmarshaller.Instance;

            return Invoke<DescribeAnalysisResponse>(request, options);
        }



        /// <summary>
        /// Provides a summary of the metadata for an analysis.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnalysis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAnalysis service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAnalysis">REST API Reference for DescribeAnalysis Operation</seealso>
        public virtual Task<DescribeAnalysisResponse> DescribeAnalysisAsync(DescribeAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAnalysisResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAnalysisResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAnalysisDefinition

        internal virtual DescribeAnalysisDefinitionResponse DescribeAnalysisDefinition(DescribeAnalysisDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAnalysisDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAnalysisDefinitionResponseUnmarshaller.Instance;

            return Invoke<DescribeAnalysisDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Provides a detailed description of the definition of an analysis.
        /// 
        ///  <note> 
        /// <para>
        /// If you do not need to know details about the content of an Analysis, for instance
        /// if you are trying to check the status of a recently created or updated Analysis, use
        /// the <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_DescribeAnalysis.html">
        /// <c>DescribeAnalysis</c> </a> instead. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnalysisDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAnalysisDefinition service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAnalysisDefinition">REST API Reference for DescribeAnalysisDefinition Operation</seealso>
        public virtual Task<DescribeAnalysisDefinitionResponse> DescribeAnalysisDefinitionAsync(DescribeAnalysisDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAnalysisDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAnalysisDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAnalysisDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAnalysisPermissions

        internal virtual DescribeAnalysisPermissionsResponse DescribeAnalysisPermissions(DescribeAnalysisPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAnalysisPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAnalysisPermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribeAnalysisPermissionsResponse>(request, options);
        }



        /// <summary>
        /// Provides the read and write permissions for an analysis.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnalysisPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAnalysisPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAnalysisPermissions">REST API Reference for DescribeAnalysisPermissions Operation</seealso>
        public virtual Task<DescribeAnalysisPermissionsResponse> DescribeAnalysisPermissionsAsync(DescribeAnalysisPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAnalysisPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAnalysisPermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAnalysisPermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAssetBundleExportJob

        internal virtual DescribeAssetBundleExportJobResponse DescribeAssetBundleExportJob(DescribeAssetBundleExportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssetBundleExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetBundleExportJobResponseUnmarshaller.Instance;

            return Invoke<DescribeAssetBundleExportJobResponse>(request, options);
        }



        /// <summary>
        /// Describes an existing export job.
        /// 
        ///  
        /// <para>
        /// Poll job descriptions after a job starts to know the status of the job. When a job
        /// succeeds, a URL is provided to download the exported assets' data from. Download URLs
        /// are valid for five minutes after they are generated. You can call the <c>DescribeAssetBundleExportJob</c>
        /// API for a new download URL as needed.
        /// </para>
        ///  
        /// <para>
        /// Job descriptions are available for 14 days after the job starts.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssetBundleExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAssetBundleExportJob service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAssetBundleExportJob">REST API Reference for DescribeAssetBundleExportJob Operation</seealso>
        public virtual Task<DescribeAssetBundleExportJobResponse> DescribeAssetBundleExportJobAsync(DescribeAssetBundleExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssetBundleExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetBundleExportJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAssetBundleExportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAssetBundleImportJob

        internal virtual DescribeAssetBundleImportJobResponse DescribeAssetBundleImportJob(DescribeAssetBundleImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssetBundleImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetBundleImportJobResponseUnmarshaller.Instance;

            return Invoke<DescribeAssetBundleImportJobResponse>(request, options);
        }



        /// <summary>
        /// Describes an existing import job.
        /// 
        ///  
        /// <para>
        /// Poll job descriptions after starting a job to know when it has succeeded or failed.
        /// Job descriptions are available for 14 days after job starts.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssetBundleImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAssetBundleImportJob service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeAssetBundleImportJob">REST API Reference for DescribeAssetBundleImportJob Operation</seealso>
        public virtual Task<DescribeAssetBundleImportJobResponse> DescribeAssetBundleImportJobAsync(DescribeAssetBundleImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssetBundleImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetBundleImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAssetBundleImportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeBrand

        internal virtual DescribeBrandResponse DescribeBrand(DescribeBrandRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBrandRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBrandResponseUnmarshaller.Instance;

            return Invoke<DescribeBrandResponse>(request, options);
        }



        /// <summary>
        /// Describes a brand.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBrand service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBrand service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalServerException">
        /// An internal service exception.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeBrand">REST API Reference for DescribeBrand Operation</seealso>
        public virtual Task<DescribeBrandResponse> DescribeBrandAsync(DescribeBrandRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBrandRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBrandResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeBrandResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeBrandAssignment

        internal virtual DescribeBrandAssignmentResponse DescribeBrandAssignment(DescribeBrandAssignmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBrandAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBrandAssignmentResponseUnmarshaller.Instance;

            return Invoke<DescribeBrandAssignmentResponse>(request, options);
        }



        /// <summary>
        /// Describes a brand assignment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBrandAssignment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBrandAssignment service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalServerException">
        /// An internal service exception.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeBrandAssignment">REST API Reference for DescribeBrandAssignment Operation</seealso>
        public virtual Task<DescribeBrandAssignmentResponse> DescribeBrandAssignmentAsync(DescribeBrandAssignmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBrandAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBrandAssignmentResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeBrandAssignmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeBrandPublishedVersion

        internal virtual DescribeBrandPublishedVersionResponse DescribeBrandPublishedVersion(DescribeBrandPublishedVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBrandPublishedVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBrandPublishedVersionResponseUnmarshaller.Instance;

            return Invoke<DescribeBrandPublishedVersionResponse>(request, options);
        }



        /// <summary>
        /// Describes the published version of the brand.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBrandPublishedVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBrandPublishedVersion service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalServerException">
        /// An internal service exception.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeBrandPublishedVersion">REST API Reference for DescribeBrandPublishedVersion Operation</seealso>
        public virtual Task<DescribeBrandPublishedVersionResponse> DescribeBrandPublishedVersionAsync(DescribeBrandPublishedVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBrandPublishedVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBrandPublishedVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeBrandPublishedVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeCustomPermissions

        internal virtual DescribeCustomPermissionsResponse DescribeCustomPermissions(DescribeCustomPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCustomPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomPermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribeCustomPermissionsResponse>(request, options);
        }



        /// <summary>
        /// Describes a custom permissions profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCustomPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeCustomPermissions">REST API Reference for DescribeCustomPermissions Operation</seealso>
        public virtual Task<DescribeCustomPermissionsResponse> DescribeCustomPermissionsAsync(DescribeCustomPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCustomPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomPermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCustomPermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDashboard

        internal virtual DescribeDashboardResponse DescribeDashboard(DescribeDashboardRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDashboardResponseUnmarshaller.Instance;

            return Invoke<DescribeDashboardResponse>(request, options);
        }



        /// <summary>
        /// Provides a summary for a dashboard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDashboard service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboard">REST API Reference for DescribeDashboard Operation</seealso>
        public virtual Task<DescribeDashboardResponse> DescribeDashboardAsync(DescribeDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDashboardResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDashboardResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDashboardDefinition

        internal virtual DescribeDashboardDefinitionResponse DescribeDashboardDefinition(DescribeDashboardDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDashboardDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDashboardDefinitionResponseUnmarshaller.Instance;

            return Invoke<DescribeDashboardDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Provides a detailed description of the definition of a dashboard.
        /// 
        ///  <note> 
        /// <para>
        /// If you do not need to know details about the content of a dashboard, for instance
        /// if you are trying to check the status of a recently created or updated dashboard,
        /// use the <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_DescribeDashboard.html">
        /// <c>DescribeDashboard</c> </a> instead. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboardDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDashboardDefinition service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboardDefinition">REST API Reference for DescribeDashboardDefinition Operation</seealso>
        public virtual Task<DescribeDashboardDefinitionResponse> DescribeDashboardDefinitionAsync(DescribeDashboardDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDashboardDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDashboardDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDashboardDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDashboardPermissions

        internal virtual DescribeDashboardPermissionsResponse DescribeDashboardPermissions(DescribeDashboardPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDashboardPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDashboardPermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribeDashboardPermissionsResponse>(request, options);
        }



        /// <summary>
        /// Describes read and write permissions for a dashboard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboardPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDashboardPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboardPermissions">REST API Reference for DescribeDashboardPermissions Operation</seealso>
        public virtual Task<DescribeDashboardPermissionsResponse> DescribeDashboardPermissionsAsync(DescribeDashboardPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDashboardPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDashboardPermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDashboardPermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDashboardSnapshotJob

        internal virtual DescribeDashboardSnapshotJobResponse DescribeDashboardSnapshotJob(DescribeDashboardSnapshotJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDashboardSnapshotJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDashboardSnapshotJobResponseUnmarshaller.Instance;

            return Invoke<DescribeDashboardSnapshotJobResponse>(request, options);
        }



        /// <summary>
        /// Describes an existing snapshot job.
        /// 
        ///  
        /// <para>
        /// Poll job descriptions after a job starts to know the status of the job. For information
        /// on available status codes, see <c>JobStatus</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboardSnapshotJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDashboardSnapshotJob service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboardSnapshotJob">REST API Reference for DescribeDashboardSnapshotJob Operation</seealso>
        public virtual Task<DescribeDashboardSnapshotJobResponse> DescribeDashboardSnapshotJobAsync(DescribeDashboardSnapshotJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDashboardSnapshotJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDashboardSnapshotJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDashboardSnapshotJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDashboardSnapshotJobResult

        internal virtual DescribeDashboardSnapshotJobResultResponse DescribeDashboardSnapshotJobResult(DescribeDashboardSnapshotJobResultRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDashboardSnapshotJobResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDashboardSnapshotJobResultResponseUnmarshaller.Instance;

            return Invoke<DescribeDashboardSnapshotJobResultResponse>(request, options);
        }



        /// <summary>
        /// Describes the result of an existing snapshot job that has finished running.
        /// 
        ///  
        /// <para>
        /// A finished snapshot job will return a <c>COMPLETED</c> or <c>FAILED</c> status when
        /// you poll the job with a <c>DescribeDashboardSnapshotJob</c> API call.
        /// </para>
        ///  
        /// <para>
        /// If the job has not finished running, this operation returns a message that says <c>Dashboard
        /// Snapshot Job with id &lt;SnapshotjobId&gt; has not reached a terminal state.</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboardSnapshotJobResult service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDashboardSnapshotJobResult service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboardSnapshotJobResult">REST API Reference for DescribeDashboardSnapshotJobResult Operation</seealso>
        public virtual Task<DescribeDashboardSnapshotJobResultResponse> DescribeDashboardSnapshotJobResultAsync(DescribeDashboardSnapshotJobResultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDashboardSnapshotJobResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDashboardSnapshotJobResultResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDashboardSnapshotJobResultResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDashboardsQAConfiguration

        internal virtual DescribeDashboardsQAConfigurationResponse DescribeDashboardsQAConfiguration(DescribeDashboardsQAConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDashboardsQAConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDashboardsQAConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeDashboardsQAConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Describes an existing dashboard QA configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboardsQAConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDashboardsQAConfiguration service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDashboardsQAConfiguration">REST API Reference for DescribeDashboardsQAConfiguration Operation</seealso>
        public virtual Task<DescribeDashboardsQAConfigurationResponse> DescribeDashboardsQAConfigurationAsync(DescribeDashboardsQAConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDashboardsQAConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDashboardsQAConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDashboardsQAConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDataSet

        internal virtual DescribeDataSetResponse DescribeDataSet(DescribeDataSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSetResponseUnmarshaller.Instance;

            return Invoke<DescribeDataSetResponse>(request, options);
        }



        /// <summary>
        /// Describes a dataset. This operation doesn't support datasets that include uploaded
        /// files as a source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataSet service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSet">REST API Reference for DescribeDataSet Operation</seealso>
        public virtual Task<DescribeDataSetResponse> DescribeDataSetAsync(DescribeDataSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDataSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDataSetPermissions

        internal virtual DescribeDataSetPermissionsResponse DescribeDataSetPermissions(DescribeDataSetPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSetPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSetPermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribeDataSetPermissionsResponse>(request, options);
        }



        /// <summary>
        /// Describes the permissions on a dataset.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <c>arn:aws:quicksight:region:aws-account-id:dataset/data-set-id</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSetPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataSetPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSetPermissions">REST API Reference for DescribeDataSetPermissions Operation</seealso>
        public virtual Task<DescribeDataSetPermissionsResponse> DescribeDataSetPermissionsAsync(DescribeDataSetPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSetPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSetPermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDataSetPermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDataSetRefreshProperties

        internal virtual DescribeDataSetRefreshPropertiesResponse DescribeDataSetRefreshProperties(DescribeDataSetRefreshPropertiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSetRefreshPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSetRefreshPropertiesResponseUnmarshaller.Instance;

            return Invoke<DescribeDataSetRefreshPropertiesResponse>(request, options);
        }



        /// <summary>
        /// Describes the refresh properties of a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSetRefreshProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataSetRefreshProperties service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSetRefreshProperties">REST API Reference for DescribeDataSetRefreshProperties Operation</seealso>
        public virtual Task<DescribeDataSetRefreshPropertiesResponse> DescribeDataSetRefreshPropertiesAsync(DescribeDataSetRefreshPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSetRefreshPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSetRefreshPropertiesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDataSetRefreshPropertiesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDataSource

        internal virtual DescribeDataSourceResponse DescribeDataSource(DescribeDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSourceResponseUnmarshaller.Instance;

            return Invoke<DescribeDataSourceResponse>(request, options);
        }



        /// <summary>
        /// Describes a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataSource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSource">REST API Reference for DescribeDataSource Operation</seealso>
        public virtual Task<DescribeDataSourceResponse> DescribeDataSourceAsync(DescribeDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDataSourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDataSourcePermissions

        internal virtual DescribeDataSourcePermissionsResponse DescribeDataSourcePermissions(DescribeDataSourcePermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSourcePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSourcePermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribeDataSourcePermissionsResponse>(request, options);
        }



        /// <summary>
        /// Describes the resource permissions for a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSourcePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataSourcePermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDataSourcePermissions">REST API Reference for DescribeDataSourcePermissions Operation</seealso>
        public virtual Task<DescribeDataSourcePermissionsResponse> DescribeDataSourcePermissionsAsync(DescribeDataSourcePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataSourcePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataSourcePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDataSourcePermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDefaultQBusinessApplication

        internal virtual DescribeDefaultQBusinessApplicationResponse DescribeDefaultQBusinessApplication(DescribeDefaultQBusinessApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDefaultQBusinessApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDefaultQBusinessApplicationResponseUnmarshaller.Instance;

            return Invoke<DescribeDefaultQBusinessApplicationResponse>(request, options);
        }



        /// <summary>
        /// Describes a Amazon Q Business application that is linked to an Amazon QuickSight account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultQBusinessApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDefaultQBusinessApplication service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeDefaultQBusinessApplication">REST API Reference for DescribeDefaultQBusinessApplication Operation</seealso>
        public virtual Task<DescribeDefaultQBusinessApplicationResponse> DescribeDefaultQBusinessApplicationAsync(DescribeDefaultQBusinessApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDefaultQBusinessApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDefaultQBusinessApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDefaultQBusinessApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeFolder

        internal virtual DescribeFolderResponse DescribeFolder(DescribeFolderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFolderResponseUnmarshaller.Instance;

            return Invoke<DescribeFolderResponse>(request, options);
        }



        /// <summary>
        /// Describes a folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFolder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFolder service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeFolder">REST API Reference for DescribeFolder Operation</seealso>
        public virtual Task<DescribeFolderResponse> DescribeFolderAsync(DescribeFolderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFolderResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFolderResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeFolderPermissions

        internal virtual DescribeFolderPermissionsResponse DescribeFolderPermissions(DescribeFolderPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFolderPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFolderPermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribeFolderPermissionsResponse>(request, options);
        }



        /// <summary>
        /// Describes permissions for a folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFolderPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFolderPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeFolderPermissions">REST API Reference for DescribeFolderPermissions Operation</seealso>
        public virtual Task<DescribeFolderPermissionsResponse> DescribeFolderPermissionsAsync(DescribeFolderPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFolderPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFolderPermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFolderPermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeFolderResolvedPermissions

        internal virtual DescribeFolderResolvedPermissionsResponse DescribeFolderResolvedPermissions(DescribeFolderResolvedPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFolderResolvedPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFolderResolvedPermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribeFolderResolvedPermissionsResponse>(request, options);
        }



        /// <summary>
        /// Describes the folder resolved permissions. Permissions consists of both folder direct
        /// permissions and the inherited permissions from the ancestor folders.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFolderResolvedPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFolderResolvedPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeFolderResolvedPermissions">REST API Reference for DescribeFolderResolvedPermissions Operation</seealso>
        public virtual Task<DescribeFolderResolvedPermissionsResponse> DescribeFolderResolvedPermissionsAsync(DescribeFolderResolvedPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFolderResolvedPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFolderResolvedPermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFolderResolvedPermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeGroup

        internal virtual DescribeGroupResponse DescribeGroup(DescribeGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeGroupResponse>(request, options);
        }



        /// <summary>
        /// Returns an Amazon QuickSight group's description and Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        public virtual Task<DescribeGroupResponse> DescribeGroupAsync(DescribeGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeGroupMembership

        internal virtual DescribeGroupMembershipResponse DescribeGroupMembership(DescribeGroupMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGroupMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGroupMembershipResponseUnmarshaller.Instance;

            return Invoke<DescribeGroupMembershipResponse>(request, options);
        }



        /// <summary>
        /// Use the <c>DescribeGroupMembership</c> operation to determine if a user is a member
        /// of the specified group. If the user exists and is a member of the specified group,
        /// an associated <c>GroupMember</c> object is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroupMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGroupMembership service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeGroupMembership">REST API Reference for DescribeGroupMembership Operation</seealso>
        public virtual Task<DescribeGroupMembershipResponse> DescribeGroupMembershipAsync(DescribeGroupMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGroupMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGroupMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGroupMembershipResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeIAMPolicyAssignment

        internal virtual DescribeIAMPolicyAssignmentResponse DescribeIAMPolicyAssignment(DescribeIAMPolicyAssignmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIAMPolicyAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIAMPolicyAssignmentResponseUnmarshaller.Instance;

            return Invoke<DescribeIAMPolicyAssignmentResponse>(request, options);
        }



        /// <summary>
        /// Describes an existing IAM policy assignment, as specified by the assignment name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIAMPolicyAssignment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIAMPolicyAssignment service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeIAMPolicyAssignment">REST API Reference for DescribeIAMPolicyAssignment Operation</seealso>
        public virtual Task<DescribeIAMPolicyAssignmentResponse> DescribeIAMPolicyAssignmentAsync(DescribeIAMPolicyAssignmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIAMPolicyAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIAMPolicyAssignmentResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeIAMPolicyAssignmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeIngestion

        internal virtual DescribeIngestionResponse DescribeIngestion(DescribeIngestionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIngestionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIngestionResponseUnmarshaller.Instance;

            return Invoke<DescribeIngestionResponse>(request, options);
        }



        /// <summary>
        /// Describes a SPICE ingestion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIngestion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIngestion service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeIngestion">REST API Reference for DescribeIngestion Operation</seealso>
        public virtual Task<DescribeIngestionResponse> DescribeIngestionAsync(DescribeIngestionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIngestionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIngestionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeIngestionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeIpRestriction

        internal virtual DescribeIpRestrictionResponse DescribeIpRestriction(DescribeIpRestrictionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIpRestrictionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIpRestrictionResponseUnmarshaller.Instance;

            return Invoke<DescribeIpRestrictionResponse>(request, options);
        }



        /// <summary>
        /// Provides a summary and status of IP rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIpRestriction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIpRestriction service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeIpRestriction">REST API Reference for DescribeIpRestriction Operation</seealso>
        public virtual Task<DescribeIpRestrictionResponse> DescribeIpRestrictionAsync(DescribeIpRestrictionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIpRestrictionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIpRestrictionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeIpRestrictionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeKeyRegistration

        internal virtual DescribeKeyRegistrationResponse DescribeKeyRegistration(DescribeKeyRegistrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeKeyRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeKeyRegistrationResponseUnmarshaller.Instance;

            return Invoke<DescribeKeyRegistrationResponse>(request, options);
        }



        /// <summary>
        /// Describes all customer managed key registrations in a Amazon QuickSight account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeyRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeKeyRegistration service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeKeyRegistration">REST API Reference for DescribeKeyRegistration Operation</seealso>
        public virtual Task<DescribeKeyRegistrationResponse> DescribeKeyRegistrationAsync(DescribeKeyRegistrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeKeyRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeKeyRegistrationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeKeyRegistrationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeNamespace

        internal virtual DescribeNamespaceResponse DescribeNamespace(DescribeNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNamespaceResponseUnmarshaller.Instance;

            return Invoke<DescribeNamespaceResponse>(request, options);
        }



        /// <summary>
        /// Describes the current namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNamespace service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeNamespace">REST API Reference for DescribeNamespace Operation</seealso>
        public virtual Task<DescribeNamespaceResponse> DescribeNamespaceAsync(DescribeNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNamespaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeQPersonalizationConfiguration

        internal virtual DescribeQPersonalizationConfigurationResponse DescribeQPersonalizationConfiguration(DescribeQPersonalizationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeQPersonalizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeQPersonalizationConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeQPersonalizationConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Describes a personalization configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeQPersonalizationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeQPersonalizationConfiguration service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeQPersonalizationConfiguration">REST API Reference for DescribeQPersonalizationConfiguration Operation</seealso>
        public virtual Task<DescribeQPersonalizationConfigurationResponse> DescribeQPersonalizationConfigurationAsync(DescribeQPersonalizationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeQPersonalizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeQPersonalizationConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeQPersonalizationConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeQuickSightQSearchConfiguration

        internal virtual DescribeQuickSightQSearchConfigurationResponse DescribeQuickSightQSearchConfiguration(DescribeQuickSightQSearchConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeQuickSightQSearchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeQuickSightQSearchConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeQuickSightQSearchConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Describes the state of a Amazon QuickSight Q Search configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeQuickSightQSearchConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeQuickSightQSearchConfiguration service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeQuickSightQSearchConfiguration">REST API Reference for DescribeQuickSightQSearchConfiguration Operation</seealso>
        public virtual Task<DescribeQuickSightQSearchConfigurationResponse> DescribeQuickSightQSearchConfigurationAsync(DescribeQuickSightQSearchConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeQuickSightQSearchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeQuickSightQSearchConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeQuickSightQSearchConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeRefreshSchedule

        internal virtual DescribeRefreshScheduleResponse DescribeRefreshSchedule(DescribeRefreshScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRefreshScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRefreshScheduleResponseUnmarshaller.Instance;

            return Invoke<DescribeRefreshScheduleResponse>(request, options);
        }



        /// <summary>
        /// Provides a summary of a refresh schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRefreshSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRefreshSchedule service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeRefreshSchedule">REST API Reference for DescribeRefreshSchedule Operation</seealso>
        public virtual Task<DescribeRefreshScheduleResponse> DescribeRefreshScheduleAsync(DescribeRefreshScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRefreshScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRefreshScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRefreshScheduleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeRoleCustomPermission

        internal virtual DescribeRoleCustomPermissionResponse DescribeRoleCustomPermission(DescribeRoleCustomPermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRoleCustomPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRoleCustomPermissionResponseUnmarshaller.Instance;

            return Invoke<DescribeRoleCustomPermissionResponse>(request, options);
        }



        /// <summary>
        /// Describes all custom permissions that are mapped to a role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRoleCustomPermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRoleCustomPermission service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeRoleCustomPermission">REST API Reference for DescribeRoleCustomPermission Operation</seealso>
        public virtual Task<DescribeRoleCustomPermissionResponse> DescribeRoleCustomPermissionAsync(DescribeRoleCustomPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRoleCustomPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRoleCustomPermissionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRoleCustomPermissionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeTemplate

        internal virtual DescribeTemplateResponse DescribeTemplate(DescribeTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTemplateResponseUnmarshaller.Instance;

            return Invoke<DescribeTemplateResponse>(request, options);
        }



        /// <summary>
        /// Describes a template's metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTemplate service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplate">REST API Reference for DescribeTemplate Operation</seealso>
        public virtual Task<DescribeTemplateResponse> DescribeTemplateAsync(DescribeTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeTemplateAlias

        internal virtual DescribeTemplateAliasResponse DescribeTemplateAlias(DescribeTemplateAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTemplateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTemplateAliasResponseUnmarshaller.Instance;

            return Invoke<DescribeTemplateAliasResponse>(request, options);
        }



        /// <summary>
        /// Describes the template alias for a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTemplateAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTemplateAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplateAlias">REST API Reference for DescribeTemplateAlias Operation</seealso>
        public virtual Task<DescribeTemplateAliasResponse> DescribeTemplateAliasAsync(DescribeTemplateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTemplateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTemplateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTemplateAliasResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeTemplateDefinition

        internal virtual DescribeTemplateDefinitionResponse DescribeTemplateDefinition(DescribeTemplateDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTemplateDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTemplateDefinitionResponseUnmarshaller.Instance;

            return Invoke<DescribeTemplateDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Provides a detailed description of the definition of a template.
        /// 
        ///  <note> 
        /// <para>
        /// If you do not need to know details about the content of a template, for instance if
        /// you are trying to check the status of a recently created or updated template, use
        /// the <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_DescribeTemplate.html">
        /// <c>DescribeTemplate</c> </a> instead. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTemplateDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTemplateDefinition service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplateDefinition">REST API Reference for DescribeTemplateDefinition Operation</seealso>
        public virtual Task<DescribeTemplateDefinitionResponse> DescribeTemplateDefinitionAsync(DescribeTemplateDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTemplateDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTemplateDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTemplateDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeTemplatePermissions

        internal virtual DescribeTemplatePermissionsResponse DescribeTemplatePermissions(DescribeTemplatePermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTemplatePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTemplatePermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribeTemplatePermissionsResponse>(request, options);
        }



        /// <summary>
        /// Describes read and write permissions on a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTemplatePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTemplatePermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTemplatePermissions">REST API Reference for DescribeTemplatePermissions Operation</seealso>
        public virtual Task<DescribeTemplatePermissionsResponse> DescribeTemplatePermissionsAsync(DescribeTemplatePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTemplatePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTemplatePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTemplatePermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeTheme

        internal virtual DescribeThemeResponse DescribeTheme(DescribeThemeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeThemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeThemeResponseUnmarshaller.Instance;

            return Invoke<DescribeThemeResponse>(request, options);
        }



        /// <summary>
        /// Describes a theme.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTheme service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTheme service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTheme">REST API Reference for DescribeTheme Operation</seealso>
        public virtual Task<DescribeThemeResponse> DescribeThemeAsync(DescribeThemeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeThemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeThemeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeThemeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeThemeAlias

        internal virtual DescribeThemeAliasResponse DescribeThemeAlias(DescribeThemeAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeThemeAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeThemeAliasResponseUnmarshaller.Instance;

            return Invoke<DescribeThemeAliasResponse>(request, options);
        }



        /// <summary>
        /// Describes the alias for a theme.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeThemeAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeThemeAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeThemeAlias">REST API Reference for DescribeThemeAlias Operation</seealso>
        public virtual Task<DescribeThemeAliasResponse> DescribeThemeAliasAsync(DescribeThemeAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeThemeAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeThemeAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeThemeAliasResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeThemePermissions

        internal virtual DescribeThemePermissionsResponse DescribeThemePermissions(DescribeThemePermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeThemePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeThemePermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribeThemePermissionsResponse>(request, options);
        }



        /// <summary>
        /// Describes the read and write permissions for a theme.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeThemePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeThemePermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeThemePermissions">REST API Reference for DescribeThemePermissions Operation</seealso>
        public virtual Task<DescribeThemePermissionsResponse> DescribeThemePermissionsAsync(DescribeThemePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeThemePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeThemePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeThemePermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeTopic

        internal virtual DescribeTopicResponse DescribeTopic(DescribeTopicRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTopicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTopicResponseUnmarshaller.Instance;

            return Invoke<DescribeTopicResponse>(request, options);
        }



        /// <summary>
        /// Describes a topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTopic service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTopic service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTopic">REST API Reference for DescribeTopic Operation</seealso>
        public virtual Task<DescribeTopicResponse> DescribeTopicAsync(DescribeTopicRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTopicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTopicResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTopicResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeTopicPermissions

        internal virtual DescribeTopicPermissionsResponse DescribeTopicPermissions(DescribeTopicPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTopicPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTopicPermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribeTopicPermissionsResponse>(request, options);
        }



        /// <summary>
        /// Describes the permissions of a topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTopicPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTopicPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTopicPermissions">REST API Reference for DescribeTopicPermissions Operation</seealso>
        public virtual Task<DescribeTopicPermissionsResponse> DescribeTopicPermissionsAsync(DescribeTopicPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTopicPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTopicPermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTopicPermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeTopicRefresh

        internal virtual DescribeTopicRefreshResponse DescribeTopicRefresh(DescribeTopicRefreshRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTopicRefreshRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTopicRefreshResponseUnmarshaller.Instance;

            return Invoke<DescribeTopicRefreshResponse>(request, options);
        }



        /// <summary>
        /// Describes the status of a topic refresh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTopicRefresh service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTopicRefresh service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTopicRefresh">REST API Reference for DescribeTopicRefresh Operation</seealso>
        public virtual Task<DescribeTopicRefreshResponse> DescribeTopicRefreshAsync(DescribeTopicRefreshRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTopicRefreshRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTopicRefreshResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTopicRefreshResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeTopicRefreshSchedule

        internal virtual DescribeTopicRefreshScheduleResponse DescribeTopicRefreshSchedule(DescribeTopicRefreshScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTopicRefreshScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTopicRefreshScheduleResponseUnmarshaller.Instance;

            return Invoke<DescribeTopicRefreshScheduleResponse>(request, options);
        }



        /// <summary>
        /// Deletes a topic refresh schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTopicRefreshSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTopicRefreshSchedule service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeTopicRefreshSchedule">REST API Reference for DescribeTopicRefreshSchedule Operation</seealso>
        public virtual Task<DescribeTopicRefreshScheduleResponse> DescribeTopicRefreshScheduleAsync(DescribeTopicRefreshScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTopicRefreshScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTopicRefreshScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTopicRefreshScheduleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeUser

        internal virtual DescribeUserResponse DescribeUser(DescribeUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserResponseUnmarshaller.Instance;

            return Invoke<DescribeUserResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a user, given the user name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        public virtual Task<DescribeUserResponse> DescribeUserAsync(DescribeUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeUserResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeVPCConnection

        internal virtual DescribeVPCConnectionResponse DescribeVPCConnection(DescribeVPCConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVPCConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVPCConnectionResponseUnmarshaller.Instance;

            return Invoke<DescribeVPCConnectionResponse>(request, options);
        }



        /// <summary>
        /// Describes a VPC connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVPCConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVPCConnection service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeVPCConnection">REST API Reference for DescribeVPCConnection Operation</seealso>
        public virtual Task<DescribeVPCConnectionResponse> DescribeVPCConnectionAsync(DescribeVPCConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVPCConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVPCConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVPCConnectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GenerateEmbedUrlForAnonymousUser

        internal virtual GenerateEmbedUrlForAnonymousUserResponse GenerateEmbedUrlForAnonymousUser(GenerateEmbedUrlForAnonymousUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateEmbedUrlForAnonymousUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateEmbedUrlForAnonymousUserResponseUnmarshaller.Instance;

            return Invoke<GenerateEmbedUrlForAnonymousUserResponse>(request, options);
        }



        /// <summary>
        /// Generates an embed URL that you can use to embed an Amazon QuickSight dashboard or
        /// visual in your website, without having to register any reader users. Before you use
        /// this action, make sure that you have configured the dashboards and permissions.
        /// 
        ///  
        /// <para>
        /// The following rules apply to the generated URL:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// It contains a temporary bearer token. It is valid for 5 minutes after it is generated.
        /// Once redeemed within this period, it cannot be re-used again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The URL validity period should not be confused with the actual session lifetime that
        /// can be customized using the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_GenerateEmbedUrlForAnonymousUser.html#QS-GenerateEmbedUrlForAnonymousUser-request-SessionLifetimeInMinutes">SessionLifetimeInMinutes</a>
        /// </c> parameter. The resulting user session is valid for 15 minutes (minimum) to 10
        /// hours (maximum). The default session duration is 10 hours.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You are charged only when the URL is used or there is interaction with Amazon QuickSight.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/embedded-analytics.html">Embedded
        /// Analytics</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the high-level steps for embedding and for an interactive
        /// demo of the ways you can customize embedding, visit the <a href="https://docs.aws.amazon.com/quicksight/latest/user/quicksight-dev-portal.html">Amazon
        /// QuickSight Developer Portal</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateEmbedUrlForAnonymousUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateEmbedUrlForAnonymousUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.SessionLifetimeInMinutesInvalidException">
        /// The number of minutes specified for the lifetime of a session isn't valid. The session
        /// lifetime must be 15-600 minutes.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedPricingPlanException">
        /// This error indicates that you are calling an embedding operation in Amazon QuickSight
        /// without the required pricing plan on your Amazon Web Services account. Before you
        /// can use embedding for anonymous users, a QuickSight administrator needs to add capacity
        /// pricing to Amazon QuickSight. You can do this on the <b>Manage Amazon QuickSight</b>
        /// page. 
        /// 
        ///  
        /// <para>
        /// After capacity pricing is added, you can use the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_GetDashboardEmbedUrl.html">GetDashboardEmbedUrl</a>
        /// </c> API operation with the <c>--identity-type ANONYMOUS</c> option.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GenerateEmbedUrlForAnonymousUser">REST API Reference for GenerateEmbedUrlForAnonymousUser Operation</seealso>
        public virtual Task<GenerateEmbedUrlForAnonymousUserResponse> GenerateEmbedUrlForAnonymousUserAsync(GenerateEmbedUrlForAnonymousUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateEmbedUrlForAnonymousUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateEmbedUrlForAnonymousUserResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateEmbedUrlForAnonymousUserResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GenerateEmbedUrlForRegisteredUser

        internal virtual GenerateEmbedUrlForRegisteredUserResponse GenerateEmbedUrlForRegisteredUser(GenerateEmbedUrlForRegisteredUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateEmbedUrlForRegisteredUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateEmbedUrlForRegisteredUserResponseUnmarshaller.Instance;

            return Invoke<GenerateEmbedUrlForRegisteredUserResponse>(request, options);
        }



        /// <summary>
        /// Generates an embed URL that you can use to embed an Amazon QuickSight experience in
        /// your website. This action can be used for any type of user registered in an Amazon
        /// QuickSight account. Before you use this action, make sure that you have configured
        /// the relevant Amazon QuickSight resource and permissions.
        /// 
        ///  
        /// <para>
        /// The following rules apply to the generated URL:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// It contains a temporary bearer token. It is valid for 5 minutes after it is generated.
        /// Once redeemed within this period, it cannot be re-used again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The URL validity period should not be confused with the actual session lifetime that
        /// can be customized using the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_GenerateEmbedUrlForRegisteredUser.html#QS-GenerateEmbedUrlForRegisteredUser-request-SessionLifetimeInMinutes">SessionLifetimeInMinutes</a>
        /// </c> parameter.
        /// </para>
        ///  
        /// <para>
        /// The resulting user session is valid for 15 minutes (minimum) to 10 hours (maximum).
        /// The default session duration is 10 hours.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You are charged only when the URL is used or there is interaction with Amazon QuickSight.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/embedded-analytics.html">Embedded
        /// Analytics</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the high-level steps for embedding and for an interactive
        /// demo of the ways you can customize embedding, visit the <a href="https://docs.aws.amazon.com/quicksight/latest/user/quicksight-dev-portal.html">Amazon
        /// QuickSight Developer Portal</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateEmbedUrlForRegisteredUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateEmbedUrlForRegisteredUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.QuickSightUserNotFoundException">
        /// The user with the provided name isn't found. This error can happen in any operation
        /// that requires finding a user based on a provided user name, such as <c>DeleteUser</c>,
        /// <c>DescribeUser</c>, and so on.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.SessionLifetimeInMinutesInvalidException">
        /// The number of minutes specified for the lifetime of a session isn't valid. The session
        /// lifetime must be 15-600 minutes.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedPricingPlanException">
        /// This error indicates that you are calling an embedding operation in Amazon QuickSight
        /// without the required pricing plan on your Amazon Web Services account. Before you
        /// can use embedding for anonymous users, a QuickSight administrator needs to add capacity
        /// pricing to Amazon QuickSight. You can do this on the <b>Manage Amazon QuickSight</b>
        /// page. 
        /// 
        ///  
        /// <para>
        /// After capacity pricing is added, you can use the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_GetDashboardEmbedUrl.html">GetDashboardEmbedUrl</a>
        /// </c> API operation with the <c>--identity-type ANONYMOUS</c> option.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GenerateEmbedUrlForRegisteredUser">REST API Reference for GenerateEmbedUrlForRegisteredUser Operation</seealso>
        public virtual Task<GenerateEmbedUrlForRegisteredUserResponse> GenerateEmbedUrlForRegisteredUserAsync(GenerateEmbedUrlForRegisteredUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateEmbedUrlForRegisteredUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateEmbedUrlForRegisteredUserResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateEmbedUrlForRegisteredUserResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GenerateEmbedUrlForRegisteredUserWithIdentity

        internal virtual GenerateEmbedUrlForRegisteredUserWithIdentityResponse GenerateEmbedUrlForRegisteredUserWithIdentity(GenerateEmbedUrlForRegisteredUserWithIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateEmbedUrlForRegisteredUserWithIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateEmbedUrlForRegisteredUserWithIdentityResponseUnmarshaller.Instance;

            return Invoke<GenerateEmbedUrlForRegisteredUserWithIdentityResponse>(request, options);
        }



        /// <summary>
        /// Generates an embed URL that you can use to embed an Amazon QuickSight experience in
        /// your website. This action can be used for any type of user that is registered in an
        /// Amazon QuickSight account that uses IAM Identity Center for authentication. This API
        /// requires <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/trustedidentitypropagation-overview.html#types-identity-enhanced-iam-role-sessions">identity-enhanced
        /// IAM Role sessions</a> for the authenticated user that the API call is being made for.
        /// 
        ///  
        /// <para>
        /// This API uses <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/trustedidentitypropagation.html">trusted
        /// identity propagation</a> to ensure that an end user is authenticated and receives
        /// the embed URL that is specific to that user. The IAM Identity Center application that
        /// the user has logged into needs to have <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/trustedidentitypropagation-using-customermanagedapps-specify-trusted-apps.html">trusted
        /// Identity Propagation enabled for Amazon QuickSight</a> with the scope value set to
        /// <c>quicksight:read</c>. Before you use this action, make sure that you have configured
        /// the relevant Amazon QuickSight resource and permissions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateEmbedUrlForRegisteredUserWithIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateEmbedUrlForRegisteredUserWithIdentity service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.QuickSightUserNotFoundException">
        /// The user with the provided name isn't found. This error can happen in any operation
        /// that requires finding a user based on a provided user name, such as <c>DeleteUser</c>,
        /// <c>DescribeUser</c>, and so on.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.SessionLifetimeInMinutesInvalidException">
        /// The number of minutes specified for the lifetime of a session isn't valid. The session
        /// lifetime must be 15-600 minutes.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedPricingPlanException">
        /// This error indicates that you are calling an embedding operation in Amazon QuickSight
        /// without the required pricing plan on your Amazon Web Services account. Before you
        /// can use embedding for anonymous users, a QuickSight administrator needs to add capacity
        /// pricing to Amazon QuickSight. You can do this on the <b>Manage Amazon QuickSight</b>
        /// page. 
        /// 
        ///  
        /// <para>
        /// After capacity pricing is added, you can use the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_GetDashboardEmbedUrl.html">GetDashboardEmbedUrl</a>
        /// </c> API operation with the <c>--identity-type ANONYMOUS</c> option.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GenerateEmbedUrlForRegisteredUserWithIdentity">REST API Reference for GenerateEmbedUrlForRegisteredUserWithIdentity Operation</seealso>
        public virtual Task<GenerateEmbedUrlForRegisteredUserWithIdentityResponse> GenerateEmbedUrlForRegisteredUserWithIdentityAsync(GenerateEmbedUrlForRegisteredUserWithIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateEmbedUrlForRegisteredUserWithIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateEmbedUrlForRegisteredUserWithIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateEmbedUrlForRegisteredUserWithIdentityResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDashboardEmbedUrl

        internal virtual GetDashboardEmbedUrlResponse GetDashboardEmbedUrl(GetDashboardEmbedUrlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDashboardEmbedUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDashboardEmbedUrlResponseUnmarshaller.Instance;

            return Invoke<GetDashboardEmbedUrlResponse>(request, options);
        }



        /// <summary>
        /// Generates a temporary session URL and authorization code(bearer token) that you can
        /// use to embed an Amazon QuickSight read-only dashboard in your website or application.
        /// Before you use this command, make sure that you have configured the dashboards and
        /// permissions. 
        /// 
        ///  
        /// <para>
        /// Currently, you can use <c>GetDashboardEmbedURL</c> only from the server, not from
        /// the user's browser. The following rules apply to the generated URL:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// They must be used together.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// They can be used one time only.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// They are valid for 5 minutes after you run this command.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You are charged only when the URL is used or there is interaction with Amazon QuickSight.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The resulting user session is valid for 15 minutes (default) up to 10 hours (maximum).
        /// You can use the optional <c>SessionLifetimeInMinutes</c> parameter to customize session
        /// duration.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/embedded-analytics-deprecated.html">Embedding
        /// Analytics Using GetDashboardEmbedUrl</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the high-level steps for embedding and for an interactive
        /// demo of the ways you can customize embedding, visit the <a href="https://docs.aws.amazon.com/quicksight/latest/user/quicksight-dev-portal.html">Amazon
        /// QuickSight Developer Portal</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDashboardEmbedUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDashboardEmbedUrl service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.DomainNotWhitelistedException">
        /// The domain specified isn't on the allow list. All domains for embedded dashboards
        /// must be added to the approved list by an Amazon QuickSight admin.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.IdentityTypeNotSupportedException">
        /// The identity type specified isn't supported. Supported identity types include <c>IAM</c>
        /// and <c>QUICKSIGHT</c>.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.QuickSightUserNotFoundException">
        /// The user with the provided name isn't found. This error can happen in any operation
        /// that requires finding a user based on a provided user name, such as <c>DeleteUser</c>,
        /// <c>DescribeUser</c>, and so on.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.SessionLifetimeInMinutesInvalidException">
        /// The number of minutes specified for the lifetime of a session isn't valid. The session
        /// lifetime must be 15-600 minutes.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedPricingPlanException">
        /// This error indicates that you are calling an embedding operation in Amazon QuickSight
        /// without the required pricing plan on your Amazon Web Services account. Before you
        /// can use embedding for anonymous users, a QuickSight administrator needs to add capacity
        /// pricing to Amazon QuickSight. You can do this on the <b>Manage Amazon QuickSight</b>
        /// page. 
        /// 
        ///  
        /// <para>
        /// After capacity pricing is added, you can use the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_GetDashboardEmbedUrl.html">GetDashboardEmbedUrl</a>
        /// </c> API operation with the <c>--identity-type ANONYMOUS</c> option.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GetDashboardEmbedUrl">REST API Reference for GetDashboardEmbedUrl Operation</seealso>
        public virtual Task<GetDashboardEmbedUrlResponse> GetDashboardEmbedUrlAsync(GetDashboardEmbedUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDashboardEmbedUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDashboardEmbedUrlResponseUnmarshaller.Instance;

            return InvokeAsync<GetDashboardEmbedUrlResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSessionEmbedUrl

        internal virtual GetSessionEmbedUrlResponse GetSessionEmbedUrl(GetSessionEmbedUrlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSessionEmbedUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionEmbedUrlResponseUnmarshaller.Instance;

            return Invoke<GetSessionEmbedUrlResponse>(request, options);
        }



        /// <summary>
        /// Generates a session URL and authorization code that you can use to embed the Amazon
        /// Amazon QuickSight console in your web server code. Use <c>GetSessionEmbedUrl</c> where
        /// you want to provide an authoring portal that allows users to create data sources,
        /// datasets, analyses, and dashboards. The users who access an embedded Amazon QuickSight
        /// console need belong to the author or admin security cohort. If you want to restrict
        /// permissions to some of these features, add a custom permissions profile to the user
        /// with the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_UpdateUser.html">UpdateUser</a>
        /// </c> API operation. Use <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_RegisterUser.html">RegisterUser</a>
        /// </c> API operation to add a new user with a custom permission profile attached. For
        /// more information, see the following sections in the <i>Amazon QuickSight User Guide</i>:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/quicksight/latest/user/embedded-analytics.html">Embedding
        /// Analytics</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/quicksight/latest/user/customizing-permissions-to-the-quicksight-console.html">Customizing
        /// Access to the Amazon QuickSight Console</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSessionEmbedUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSessionEmbedUrl service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.QuickSightUserNotFoundException">
        /// The user with the provided name isn't found. This error can happen in any operation
        /// that requires finding a user based on a provided user name, such as <c>DeleteUser</c>,
        /// <c>DescribeUser</c>, and so on.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.SessionLifetimeInMinutesInvalidException">
        /// The number of minutes specified for the lifetime of a session isn't valid. The session
        /// lifetime must be 15-600 minutes.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GetSessionEmbedUrl">REST API Reference for GetSessionEmbedUrl Operation</seealso>
        public virtual Task<GetSessionEmbedUrlResponse> GetSessionEmbedUrlAsync(GetSessionEmbedUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSessionEmbedUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionEmbedUrlResponseUnmarshaller.Instance;

            return InvokeAsync<GetSessionEmbedUrlResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAnalyses

        internal virtual ListAnalysesResponse ListAnalyses(ListAnalysesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAnalysesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnalysesResponseUnmarshaller.Instance;

            return Invoke<ListAnalysesResponse>(request, options);
        }



        /// <summary>
        /// Lists Amazon QuickSight analyses that exist in the specified Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnalyses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAnalyses service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListAnalyses">REST API Reference for ListAnalyses Operation</seealso>
        public virtual Task<ListAnalysesResponse> ListAnalysesAsync(ListAnalysesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAnalysesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnalysesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAnalysesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAssetBundleExportJobs

        internal virtual ListAssetBundleExportJobsResponse ListAssetBundleExportJobs(ListAssetBundleExportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssetBundleExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetBundleExportJobsResponseUnmarshaller.Instance;

            return Invoke<ListAssetBundleExportJobsResponse>(request, options);
        }



        /// <summary>
        /// Lists all asset bundle export jobs that have been taken place in the last 14 days.
        /// Jobs created more than 14 days ago are deleted forever and are not returned. If you
        /// are using the same job ID for multiple jobs, <c>ListAssetBundleExportJobs</c> only
        /// returns the most recent job that uses the repeated job ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssetBundleExportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssetBundleExportJobs service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListAssetBundleExportJobs">REST API Reference for ListAssetBundleExportJobs Operation</seealso>
        public virtual Task<ListAssetBundleExportJobsResponse> ListAssetBundleExportJobsAsync(ListAssetBundleExportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssetBundleExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetBundleExportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssetBundleExportJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAssetBundleImportJobs

        internal virtual ListAssetBundleImportJobsResponse ListAssetBundleImportJobs(ListAssetBundleImportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssetBundleImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetBundleImportJobsResponseUnmarshaller.Instance;

            return Invoke<ListAssetBundleImportJobsResponse>(request, options);
        }



        /// <summary>
        /// Lists all asset bundle import jobs that have taken place in the last 14 days. Jobs
        /// created more than 14 days ago are deleted forever and are not returned. If you are
        /// using the same job ID for multiple jobs, <c>ListAssetBundleImportJobs</c> only returns
        /// the most recent job that uses the repeated job ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssetBundleImportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssetBundleImportJobs service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListAssetBundleImportJobs">REST API Reference for ListAssetBundleImportJobs Operation</seealso>
        public virtual Task<ListAssetBundleImportJobsResponse> ListAssetBundleImportJobsAsync(ListAssetBundleImportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssetBundleImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetBundleImportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssetBundleImportJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListBrands

        internal virtual ListBrandsResponse ListBrands(ListBrandsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBrandsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBrandsResponseUnmarshaller.Instance;

            return Invoke<ListBrandsResponse>(request, options);
        }



        /// <summary>
        /// Lists all brands in an Amazon QuickSight account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBrands service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBrands service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalServerException">
        /// An internal service exception.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListBrands">REST API Reference for ListBrands Operation</seealso>
        public virtual Task<ListBrandsResponse> ListBrandsAsync(ListBrandsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBrandsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBrandsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBrandsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCustomPermissions

        internal virtual ListCustomPermissionsResponse ListCustomPermissions(ListCustomPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCustomPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomPermissionsResponseUnmarshaller.Instance;

            return Invoke<ListCustomPermissionsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all the custom permissions profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCustomPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListCustomPermissions">REST API Reference for ListCustomPermissions Operation</seealso>
        public virtual Task<ListCustomPermissionsResponse> ListCustomPermissionsAsync(ListCustomPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCustomPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomPermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCustomPermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDashboards

        internal virtual ListDashboardsResponse ListDashboards(ListDashboardsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDashboardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDashboardsResponseUnmarshaller.Instance;

            return Invoke<ListDashboardsResponse>(request, options);
        }



        /// <summary>
        /// Lists dashboards in an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDashboards service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDashboards service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDashboards">REST API Reference for ListDashboards Operation</seealso>
        public virtual Task<ListDashboardsResponse> ListDashboardsAsync(ListDashboardsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDashboardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDashboardsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDashboardsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDashboardVersions

        internal virtual ListDashboardVersionsResponse ListDashboardVersions(ListDashboardVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDashboardVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDashboardVersionsResponseUnmarshaller.Instance;

            return Invoke<ListDashboardVersionsResponse>(request, options);
        }



        /// <summary>
        /// Lists all the versions of the dashboards in the Amazon QuickSight subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDashboardVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDashboardVersions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDashboardVersions">REST API Reference for ListDashboardVersions Operation</seealso>
        public virtual Task<ListDashboardVersionsResponse> ListDashboardVersionsAsync(ListDashboardVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDashboardVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDashboardVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDashboardVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDataSets

        internal virtual ListDataSetsResponse ListDataSets(ListDataSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSetsResponseUnmarshaller.Instance;

            return Invoke<ListDataSetsResponse>(request, options);
        }



        /// <summary>
        /// Lists all of the datasets belonging to the current Amazon Web Services account in
        /// an Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <c>arn:aws:quicksight:region:aws-account-id:dataset/*</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSets service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDataSets">REST API Reference for ListDataSets Operation</seealso>
        public virtual Task<ListDataSetsResponse> ListDataSetsAsync(ListDataSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDataSetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDataSources

        internal virtual ListDataSourcesResponse ListDataSources(ListDataSourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourcesResponseUnmarshaller.Instance;

            return Invoke<ListDataSourcesResponse>(request, options);
        }



        /// <summary>
        /// Lists data sources in current Amazon Web Services Region that belong to this Amazon
        /// Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSources service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        public virtual Task<ListDataSourcesResponse> ListDataSourcesAsync(ListDataSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDataSourcesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListFolderMembers

        internal virtual ListFolderMembersResponse ListFolderMembers(ListFolderMembersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFolderMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFolderMembersResponseUnmarshaller.Instance;

            return Invoke<ListFolderMembersResponse>(request, options);
        }



        /// <summary>
        /// List all assets (<c>DASHBOARD</c>, <c>ANALYSIS</c>, and <c>DATASET</c>) in a folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFolderMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFolderMembers service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListFolderMembers">REST API Reference for ListFolderMembers Operation</seealso>
        public virtual Task<ListFolderMembersResponse> ListFolderMembersAsync(ListFolderMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFolderMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFolderMembersResponseUnmarshaller.Instance;

            return InvokeAsync<ListFolderMembersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListFolders

        internal virtual ListFoldersResponse ListFolders(ListFoldersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFoldersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFoldersResponseUnmarshaller.Instance;

            return Invoke<ListFoldersResponse>(request, options);
        }



        /// <summary>
        /// Lists all folders in an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFolders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFolders service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListFolders">REST API Reference for ListFolders Operation</seealso>
        public virtual Task<ListFoldersResponse> ListFoldersAsync(ListFoldersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFoldersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFoldersResponseUnmarshaller.Instance;

            return InvokeAsync<ListFoldersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListFoldersForResource

        internal virtual ListFoldersForResourceResponse ListFoldersForResource(ListFoldersForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFoldersForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFoldersForResourceResponseUnmarshaller.Instance;

            return Invoke<ListFoldersForResourceResponse>(request, options);
        }



        /// <summary>
        /// List all folders that a resource is a member of.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFoldersForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFoldersForResource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListFoldersForResource">REST API Reference for ListFoldersForResource Operation</seealso>
        public virtual Task<ListFoldersForResourceResponse> ListFoldersForResourceAsync(ListFoldersForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFoldersForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFoldersForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListFoldersForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListGroupMemberships

        internal virtual ListGroupMembershipsResponse ListGroupMemberships(ListGroupMembershipsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupMembershipsResponseUnmarshaller.Instance;

            return Invoke<ListGroupMembershipsResponse>(request, options);
        }



        /// <summary>
        /// Lists member users in a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMemberships service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroupMemberships service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroupMemberships">REST API Reference for ListGroupMemberships Operation</seealso>
        public virtual Task<ListGroupMembershipsResponse> ListGroupMembershipsAsync(ListGroupMembershipsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupMembershipsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGroupMembershipsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListGroups

        internal virtual ListGroupsResponse ListGroups(ListGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return Invoke<ListGroupsResponse>(request, options);
        }



        /// <summary>
        /// Lists all user groups in Amazon QuickSight.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListIAMPolicyAssignments

        internal virtual ListIAMPolicyAssignmentsResponse ListIAMPolicyAssignments(ListIAMPolicyAssignmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIAMPolicyAssignmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIAMPolicyAssignmentsResponseUnmarshaller.Instance;

            return Invoke<ListIAMPolicyAssignmentsResponse>(request, options);
        }



        /// <summary>
        /// Lists the IAM policy assignments in the current Amazon QuickSight account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIAMPolicyAssignments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIAMPolicyAssignments service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIAMPolicyAssignments">REST API Reference for ListIAMPolicyAssignments Operation</seealso>
        public virtual Task<ListIAMPolicyAssignmentsResponse> ListIAMPolicyAssignmentsAsync(ListIAMPolicyAssignmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIAMPolicyAssignmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIAMPolicyAssignmentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListIAMPolicyAssignmentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListIAMPolicyAssignmentsForUser

        internal virtual ListIAMPolicyAssignmentsForUserResponse ListIAMPolicyAssignmentsForUser(ListIAMPolicyAssignmentsForUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIAMPolicyAssignmentsForUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIAMPolicyAssignmentsForUserResponseUnmarshaller.Instance;

            return Invoke<ListIAMPolicyAssignmentsForUserResponse>(request, options);
        }



        /// <summary>
        /// Lists all of the IAM policy assignments, including the Amazon Resource Names (ARNs),
        /// for the IAM policies assigned to the specified user and group, or groups that the
        /// user belongs to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIAMPolicyAssignmentsForUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIAMPolicyAssignmentsForUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConcurrentUpdatingException">
        /// A resource is already in a state that indicates an operation is happening that must
        /// complete before a new update can be applied.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIAMPolicyAssignmentsForUser">REST API Reference for ListIAMPolicyAssignmentsForUser Operation</seealso>
        public virtual Task<ListIAMPolicyAssignmentsForUserResponse> ListIAMPolicyAssignmentsForUserAsync(ListIAMPolicyAssignmentsForUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIAMPolicyAssignmentsForUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIAMPolicyAssignmentsForUserResponseUnmarshaller.Instance;

            return InvokeAsync<ListIAMPolicyAssignmentsForUserResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListIdentityPropagationConfigs

        internal virtual ListIdentityPropagationConfigsResponse ListIdentityPropagationConfigs(ListIdentityPropagationConfigsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIdentityPropagationConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentityPropagationConfigsResponseUnmarshaller.Instance;

            return Invoke<ListIdentityPropagationConfigsResponse>(request, options);
        }



        /// <summary>
        /// Lists all services and authorized targets that the Amazon QuickSight IAM Identity
        /// Center application can access.
        /// 
        ///  
        /// <para>
        /// This operation is only supported for Amazon QuickSight accounts that use IAM Identity
        /// Center.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityPropagationConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIdentityPropagationConfigs service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIdentityPropagationConfigs">REST API Reference for ListIdentityPropagationConfigs Operation</seealso>
        public virtual Task<ListIdentityPropagationConfigsResponse> ListIdentityPropagationConfigsAsync(ListIdentityPropagationConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIdentityPropagationConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentityPropagationConfigsResponseUnmarshaller.Instance;

            return InvokeAsync<ListIdentityPropagationConfigsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListIngestions

        internal virtual ListIngestionsResponse ListIngestions(ListIngestionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIngestionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIngestionsResponseUnmarshaller.Instance;

            return Invoke<ListIngestionsResponse>(request, options);
        }



        /// <summary>
        /// Lists the history of SPICE ingestions for a dataset. Limited to 5 TPS per user and
        /// 25 TPS per account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIngestions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIngestions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListIngestions">REST API Reference for ListIngestions Operation</seealso>
        public virtual Task<ListIngestionsResponse> ListIngestionsAsync(ListIngestionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIngestionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIngestionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListIngestionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListNamespaces

        internal virtual ListNamespacesResponse ListNamespaces(ListNamespacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNamespacesResponseUnmarshaller.Instance;

            return Invoke<ListNamespacesResponse>(request, options);
        }



        /// <summary>
        /// Lists the namespaces for the specified Amazon Web Services account. This operation
        /// doesn't list deleted namespaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNamespaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNamespaces service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListNamespaces">REST API Reference for ListNamespaces Operation</seealso>
        public virtual Task<ListNamespacesResponse> ListNamespacesAsync(ListNamespacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNamespacesResponseUnmarshaller.Instance;

            return InvokeAsync<ListNamespacesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRefreshSchedules

        internal virtual ListRefreshSchedulesResponse ListRefreshSchedules(ListRefreshSchedulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRefreshSchedulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRefreshSchedulesResponseUnmarshaller.Instance;

            return Invoke<ListRefreshSchedulesResponse>(request, options);
        }



        /// <summary>
        /// Lists the refresh schedules of a dataset. Each dataset can have up to 5 schedules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRefreshSchedules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRefreshSchedules service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListRefreshSchedules">REST API Reference for ListRefreshSchedules Operation</seealso>
        public virtual Task<ListRefreshSchedulesResponse> ListRefreshSchedulesAsync(ListRefreshSchedulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRefreshSchedulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRefreshSchedulesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRefreshSchedulesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRoleMemberships

        internal virtual ListRoleMembershipsResponse ListRoleMemberships(ListRoleMembershipsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRoleMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoleMembershipsResponseUnmarshaller.Instance;

            return Invoke<ListRoleMembershipsResponse>(request, options);
        }



        /// <summary>
        /// Lists all groups that are associated with a role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoleMemberships service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRoleMemberships service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListRoleMemberships">REST API Reference for ListRoleMemberships Operation</seealso>
        public virtual Task<ListRoleMembershipsResponse> ListRoleMembershipsAsync(ListRoleMembershipsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRoleMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoleMembershipsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRoleMembershipsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists the tags assigned to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTemplateAliases

        internal virtual ListTemplateAliasesResponse ListTemplateAliases(ListTemplateAliasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTemplateAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplateAliasesResponseUnmarshaller.Instance;

            return Invoke<ListTemplateAliasesResponse>(request, options);
        }



        /// <summary>
        /// Lists all the aliases of a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateAliases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTemplateAliases service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplateAliases">REST API Reference for ListTemplateAliases Operation</seealso>
        public virtual Task<ListTemplateAliasesResponse> ListTemplateAliasesAsync(ListTemplateAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTemplateAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplateAliasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTemplateAliasesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTemplates

        internal virtual ListTemplatesResponse ListTemplates(ListTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListTemplatesResponse>(request, options);
        }



        /// <summary>
        /// Lists all the templates in the current Amazon QuickSight account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTemplates service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        public virtual Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTemplatesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTemplateVersions

        internal virtual ListTemplateVersionsResponse ListTemplateVersions(ListTemplateVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTemplateVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplateVersionsResponseUnmarshaller.Instance;

            return Invoke<ListTemplateVersionsResponse>(request, options);
        }



        /// <summary>
        /// Lists all the versions of the templates in the current Amazon QuickSight account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTemplateVersions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTemplateVersions">REST API Reference for ListTemplateVersions Operation</seealso>
        public virtual Task<ListTemplateVersionsResponse> ListTemplateVersionsAsync(ListTemplateVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTemplateVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplateVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTemplateVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListThemeAliases

        internal virtual ListThemeAliasesResponse ListThemeAliases(ListThemeAliasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThemeAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThemeAliasesResponseUnmarshaller.Instance;

            return Invoke<ListThemeAliasesResponse>(request, options);
        }



        /// <summary>
        /// Lists all the aliases of a theme.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThemeAliases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListThemeAliases service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListThemeAliases">REST API Reference for ListThemeAliases Operation</seealso>
        public virtual Task<ListThemeAliasesResponse> ListThemeAliasesAsync(ListThemeAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThemeAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThemeAliasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListThemeAliasesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListThemes

        internal virtual ListThemesResponse ListThemes(ListThemesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThemesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThemesResponseUnmarshaller.Instance;

            return Invoke<ListThemesResponse>(request, options);
        }



        /// <summary>
        /// Lists all the themes in the current Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThemes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListThemes service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListThemes">REST API Reference for ListThemes Operation</seealso>
        public virtual Task<ListThemesResponse> ListThemesAsync(ListThemesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThemesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThemesResponseUnmarshaller.Instance;

            return InvokeAsync<ListThemesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListThemeVersions

        internal virtual ListThemeVersionsResponse ListThemeVersions(ListThemeVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThemeVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThemeVersionsResponseUnmarshaller.Instance;

            return Invoke<ListThemeVersionsResponse>(request, options);
        }



        /// <summary>
        /// Lists all the versions of the themes in the current Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThemeVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListThemeVersions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListThemeVersions">REST API Reference for ListThemeVersions Operation</seealso>
        public virtual Task<ListThemeVersionsResponse> ListThemeVersionsAsync(ListThemeVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThemeVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThemeVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListThemeVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTopicRefreshSchedules

        internal virtual ListTopicRefreshSchedulesResponse ListTopicRefreshSchedules(ListTopicRefreshSchedulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTopicRefreshSchedulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTopicRefreshSchedulesResponseUnmarshaller.Instance;

            return Invoke<ListTopicRefreshSchedulesResponse>(request, options);
        }



        /// <summary>
        /// Lists all of the refresh schedules for a topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTopicRefreshSchedules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTopicRefreshSchedules service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTopicRefreshSchedules">REST API Reference for ListTopicRefreshSchedules Operation</seealso>
        public virtual Task<ListTopicRefreshSchedulesResponse> ListTopicRefreshSchedulesAsync(ListTopicRefreshSchedulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTopicRefreshSchedulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTopicRefreshSchedulesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTopicRefreshSchedulesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTopicReviewedAnswers

        internal virtual ListTopicReviewedAnswersResponse ListTopicReviewedAnswers(ListTopicReviewedAnswersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTopicReviewedAnswersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTopicReviewedAnswersResponseUnmarshaller.Instance;

            return Invoke<ListTopicReviewedAnswersResponse>(request, options);
        }



        /// <summary>
        /// Lists all reviewed answers for a Q Topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTopicReviewedAnswers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTopicReviewedAnswers service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTopicReviewedAnswers">REST API Reference for ListTopicReviewedAnswers Operation</seealso>
        public virtual Task<ListTopicReviewedAnswersResponse> ListTopicReviewedAnswersAsync(ListTopicReviewedAnswersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTopicReviewedAnswersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTopicReviewedAnswersResponseUnmarshaller.Instance;

            return InvokeAsync<ListTopicReviewedAnswersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTopics

        internal virtual ListTopicsResponse ListTopics(ListTopicsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTopicsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTopicsResponseUnmarshaller.Instance;

            return Invoke<ListTopicsResponse>(request, options);
        }



        /// <summary>
        /// Lists all of the topics within an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTopics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTopics service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListTopics">REST API Reference for ListTopics Operation</seealso>
        public virtual Task<ListTopicsResponse> ListTopicsAsync(ListTopicsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTopicsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTopicsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTopicsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListUserGroups

        internal virtual ListUserGroupsResponse ListUserGroups(ListUserGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserGroupsResponseUnmarshaller.Instance;

            return Invoke<ListUserGroupsResponse>(request, options);
        }



        /// <summary>
        /// Lists the Amazon QuickSight groups that an Amazon QuickSight user is a member of.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUserGroups service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUserGroups">REST API Reference for ListUserGroups Operation</seealso>
        public virtual Task<ListUserGroupsResponse> ListUserGroupsAsync(ListUserGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListUserGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListUsers

        internal virtual ListUsersResponse ListUsers(ListUsersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;

            return Invoke<ListUsersResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all of the Amazon QuickSight users belonging to this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;

            return InvokeAsync<ListUsersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListVPCConnections

        internal virtual ListVPCConnectionsResponse ListVPCConnections(ListVPCConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVPCConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVPCConnectionsResponseUnmarshaller.Instance;

            return Invoke<ListVPCConnectionsResponse>(request, options);
        }



        /// <summary>
        /// Lists all of the VPC connections in the current set Amazon Web Services Region of
        /// an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVPCConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVPCConnections service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListVPCConnections">REST API Reference for ListVPCConnections Operation</seealso>
        public virtual Task<ListVPCConnectionsResponse> ListVPCConnectionsAsync(ListVPCConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVPCConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVPCConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListVPCConnectionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PredictQAResults

        internal virtual PredictQAResultsResponse PredictQAResults(PredictQAResultsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PredictQAResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PredictQAResultsResponseUnmarshaller.Instance;

            return Invoke<PredictQAResultsResponse>(request, options);
        }



        /// <summary>
        /// Predicts existing visuals or generates new visuals to answer a given query.
        /// 
        ///  
        /// <para>
        /// This API uses <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/trustedidentitypropagation.html">trusted
        /// identity propagation</a> to ensure that an end user is authenticated and receives
        /// the embed URL that is specific to that user. The IAM Identity Center application that
        /// the user has logged into needs to have <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/trustedidentitypropagation-using-customermanagedapps-specify-trusted-apps.html">trusted
        /// Identity Propagation enabled for Amazon QuickSight</a> with the scope value set to
        /// <c>quicksight:read</c>. Before you use this action, make sure that you have configured
        /// the relevant Amazon QuickSight resource and permissions.
        /// </para>
        ///  
        /// <para>
        /// We recommend enabling the <c>QSearchStatus</c> API to unlock the full potential of
        /// <c>PredictQnA</c>. When <c>QSearchStatus</c> is enabled, it first checks the specified
        /// dashboard for any existing visuals that match the question. If no matching visuals
        /// are found, <c>PredictQnA</c> uses generative Q&amp;A to provide an answer. To update
        /// the <c>QSearchStatus</c>, see <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_UpdateQuickSightQSearchConfiguration.html">UpdateQuickSightQSearchConfiguration</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PredictQAResults service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PredictQAResults service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/PredictQAResults">REST API Reference for PredictQAResults Operation</seealso>
        public virtual Task<PredictQAResultsResponse> PredictQAResultsAsync(PredictQAResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PredictQAResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PredictQAResultsResponseUnmarshaller.Instance;

            return InvokeAsync<PredictQAResultsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutDataSetRefreshProperties

        internal virtual PutDataSetRefreshPropertiesResponse PutDataSetRefreshProperties(PutDataSetRefreshPropertiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDataSetRefreshPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDataSetRefreshPropertiesResponseUnmarshaller.Instance;

            return Invoke<PutDataSetRefreshPropertiesResponse>(request, options);
        }



        /// <summary>
        /// Creates or updates the dataset refresh properties for the dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDataSetRefreshProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutDataSetRefreshProperties service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/PutDataSetRefreshProperties">REST API Reference for PutDataSetRefreshProperties Operation</seealso>
        public virtual Task<PutDataSetRefreshPropertiesResponse> PutDataSetRefreshPropertiesAsync(PutDataSetRefreshPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDataSetRefreshPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDataSetRefreshPropertiesResponseUnmarshaller.Instance;

            return InvokeAsync<PutDataSetRefreshPropertiesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RegisterUser

        internal virtual RegisterUserResponse RegisterUser(RegisterUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterUserResponseUnmarshaller.Instance;

            return Invoke<RegisterUserResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon QuickSight user whose identity is associated with the Identity and
        /// Access Management (IAM) identity or role specified in the request. When you register
        /// a new user from the Amazon QuickSight API, Amazon QuickSight generates a registration
        /// URL. The user accesses this registration URL to create their account. Amazon QuickSight
        /// doesn't send a registration email to users who are registered from the Amazon QuickSight
        /// API. If you want new users to receive a registration email, then add those users in
        /// the Amazon QuickSight console. For more information on registering a new user in the
        /// Amazon QuickSight console, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/managing-users.html#inviting-users">
        /// Inviting users to access Amazon QuickSight</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/RegisterUser">REST API Reference for RegisterUser Operation</seealso>
        public virtual Task<RegisterUserResponse> RegisterUserAsync(RegisterUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterUserResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterUserResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RestoreAnalysis

        internal virtual RestoreAnalysisResponse RestoreAnalysis(RestoreAnalysisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreAnalysisResponseUnmarshaller.Instance;

            return Invoke<RestoreAnalysisResponse>(request, options);
        }



        /// <summary>
        /// Restores an analysis.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreAnalysis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreAnalysis service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/RestoreAnalysis">REST API Reference for RestoreAnalysis Operation</seealso>
        public virtual Task<RestoreAnalysisResponse> RestoreAnalysisAsync(RestoreAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreAnalysisResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreAnalysisResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchAnalyses

        internal virtual SearchAnalysesResponse SearchAnalyses(SearchAnalysesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchAnalysesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchAnalysesResponseUnmarshaller.Instance;

            return Invoke<SearchAnalysesResponse>(request, options);
        }



        /// <summary>
        /// Searches for analyses that belong to the user specified in the filter.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not reflect
        /// very recent updates and changes.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchAnalyses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchAnalyses service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchAnalyses">REST API Reference for SearchAnalyses Operation</seealso>
        public virtual Task<SearchAnalysesResponse> SearchAnalysesAsync(SearchAnalysesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchAnalysesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchAnalysesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchAnalysesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchDashboards

        internal virtual SearchDashboardsResponse SearchDashboards(SearchDashboardsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchDashboardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchDashboardsResponseUnmarshaller.Instance;

            return Invoke<SearchDashboardsResponse>(request, options);
        }



        /// <summary>
        /// Searches for dashboards that belong to a user. 
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not reflect
        /// very recent updates and changes.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchDashboards service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchDashboards service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchDashboards">REST API Reference for SearchDashboards Operation</seealso>
        public virtual Task<SearchDashboardsResponse> SearchDashboardsAsync(SearchDashboardsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchDashboardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchDashboardsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchDashboardsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchDataSets

        internal virtual SearchDataSetsResponse SearchDataSets(SearchDataSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchDataSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchDataSetsResponseUnmarshaller.Instance;

            return Invoke<SearchDataSetsResponse>(request, options);
        }



        /// <summary>
        /// Use the <c>SearchDataSets</c> operation to search for datasets that belong to an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchDataSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchDataSets service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchDataSets">REST API Reference for SearchDataSets Operation</seealso>
        public virtual Task<SearchDataSetsResponse> SearchDataSetsAsync(SearchDataSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchDataSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchDataSetsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchDataSetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchDataSources

        internal virtual SearchDataSourcesResponse SearchDataSources(SearchDataSourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchDataSourcesResponseUnmarshaller.Instance;

            return Invoke<SearchDataSourcesResponse>(request, options);
        }



        /// <summary>
        /// Use the <c>SearchDataSources</c> operation to search for data sources that belong
        /// to an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchDataSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchDataSources service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchDataSources">REST API Reference for SearchDataSources Operation</seealso>
        public virtual Task<SearchDataSourcesResponse> SearchDataSourcesAsync(SearchDataSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchDataSourcesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchDataSourcesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchFolders

        internal virtual SearchFoldersResponse SearchFolders(SearchFoldersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchFoldersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchFoldersResponseUnmarshaller.Instance;

            return Invoke<SearchFoldersResponse>(request, options);
        }



        /// <summary>
        /// Searches the subfolders in a folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchFolders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchFolders service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchFolders">REST API Reference for SearchFolders Operation</seealso>
        public virtual Task<SearchFoldersResponse> SearchFoldersAsync(SearchFoldersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchFoldersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchFoldersResponseUnmarshaller.Instance;

            return InvokeAsync<SearchFoldersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchGroups

        internal virtual SearchGroupsResponse SearchGroups(SearchGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchGroupsResponseUnmarshaller.Instance;

            return Invoke<SearchGroupsResponse>(request, options);
        }



        /// <summary>
        /// Use the <c>SearchGroups</c> operation to search groups in a specified Amazon QuickSight
        /// namespace using the supplied filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchGroups service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchGroups">REST API Reference for SearchGroups Operation</seealso>
        public virtual Task<SearchGroupsResponse> SearchGroupsAsync(SearchGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchTopics

        internal virtual SearchTopicsResponse SearchTopics(SearchTopicsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchTopicsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchTopicsResponseUnmarshaller.Instance;

            return Invoke<SearchTopicsResponse>(request, options);
        }



        /// <summary>
        /// Searches for any Q topic that exists in an Amazon QuickSight account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchTopics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchTopics service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/SearchTopics">REST API Reference for SearchTopics Operation</seealso>
        public virtual Task<SearchTopicsResponse> SearchTopicsAsync(SearchTopicsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchTopicsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchTopicsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchTopicsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartAssetBundleExportJob

        internal virtual StartAssetBundleExportJobResponse StartAssetBundleExportJob(StartAssetBundleExportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAssetBundleExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAssetBundleExportJobResponseUnmarshaller.Instance;

            return Invoke<StartAssetBundleExportJobResponse>(request, options);
        }



        /// <summary>
        /// Starts an Asset Bundle export job.
        /// 
        ///  
        /// <para>
        /// An Asset Bundle export job exports specified Amazon QuickSight assets. You can also
        /// choose to export any asset dependencies in the same job. Export jobs run asynchronously
        /// and can be polled with a <c>DescribeAssetBundleExportJob</c> API call. When a job
        /// is successfully completed, a download URL that contains the exported assets is returned.
        /// The URL is valid for 5 minutes and can be refreshed with a <c>DescribeAssetBundleExportJob</c>
        /// API call. Each Amazon QuickSight account can run up to 5 export jobs concurrently.
        /// </para>
        ///  
        /// <para>
        /// The API caller must have the necessary permissions in their IAM role to access each
        /// resource before the resources can be exported.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAssetBundleExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartAssetBundleExportJob service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/StartAssetBundleExportJob">REST API Reference for StartAssetBundleExportJob Operation</seealso>
        public virtual Task<StartAssetBundleExportJobResponse> StartAssetBundleExportJobAsync(StartAssetBundleExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAssetBundleExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAssetBundleExportJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartAssetBundleExportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartAssetBundleImportJob

        internal virtual StartAssetBundleImportJobResponse StartAssetBundleImportJob(StartAssetBundleImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAssetBundleImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAssetBundleImportJobResponseUnmarshaller.Instance;

            return Invoke<StartAssetBundleImportJobResponse>(request, options);
        }



        /// <summary>
        /// Starts an Asset Bundle import job.
        /// 
        ///  
        /// <para>
        /// An Asset Bundle import job imports specified Amazon QuickSight assets into an Amazon
        /// QuickSight account. You can also choose to import a naming prefix and specified configuration
        /// overrides. The assets that are contained in the bundle file that you provide are used
        /// to create or update a new or existing asset in your Amazon QuickSight account. Each
        /// Amazon QuickSight account can run up to 5 import jobs concurrently.
        /// </para>
        ///  
        /// <para>
        /// The API caller must have the necessary <c>"create"</c>, <c>"describe"</c>, and <c>"update"</c>
        /// permissions in their IAM role to access each resource type that is contained in the
        /// bundle file before the resources can be imported.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAssetBundleImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartAssetBundleImportJob service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/StartAssetBundleImportJob">REST API Reference for StartAssetBundleImportJob Operation</seealso>
        public virtual Task<StartAssetBundleImportJobResponse> StartAssetBundleImportJobAsync(StartAssetBundleImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAssetBundleImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAssetBundleImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartAssetBundleImportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartDashboardSnapshotJob

        internal virtual StartDashboardSnapshotJobResponse StartDashboardSnapshotJob(StartDashboardSnapshotJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDashboardSnapshotJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDashboardSnapshotJobResponseUnmarshaller.Instance;

            return Invoke<StartDashboardSnapshotJobResponse>(request, options);
        }



        /// <summary>
        /// Starts an asynchronous job that generates a snapshot of a dashboard's output. You
        /// can request one or several of the following format configurations in each API call.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// 1 Paginated PDF
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1 Excel workbook that includes up to 5 table or pivot table visuals
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 5 CSVs from table or pivot table visuals
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The status of a submitted job can be polled with the <c>DescribeDashboardSnapshotJob</c>
        /// API. When you call the <c>DescribeDashboardSnapshotJob</c> API, check the <c>JobStatus</c>
        /// field in the response. Once the job reaches a <c>COMPLETED</c> or <c>FAILED</c> status,
        /// use the <c>DescribeDashboardSnapshotJobResult</c> API to obtain the URLs for the generated
        /// files. If the job fails, the <c>DescribeDashboardSnapshotJobResult</c> API returns
        /// detailed information about the error that occurred.
        /// </para>
        ///  
        /// <para>
        ///  <b>StartDashboardSnapshotJob API throttling</b> 
        /// </para>
        ///  
        /// <para>
        /// Amazon QuickSight utilizes API throttling to create a more consistent user experience
        /// within a time span for customers when they call the <c>StartDashboardSnapshotJob</c>.
        /// By default, 12 jobs can run simlutaneously in one Amazon Web Services account and
        /// users can submit up 10 API requests per second before an account is throttled. If
        /// an overwhelming number of API requests are made by the same user in a short period
        /// of time, Amazon QuickSight throttles the API calls to maintin an optimal experience
        /// and reliability for all Amazon QuickSight users.
        /// </para>
        ///  
        /// <para>
        ///  <b>Common throttling scenarios</b> 
        /// </para>
        ///  
        /// <para>
        /// The following list provides information about the most commin throttling scenarios
        /// that can occur.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>A large number of <c>SnapshotExport</c> API jobs are running simultaneously on
        /// an Amazon Web Services account.</b> When a new <c>StartDashboardSnapshotJob</c> is
        /// created and there are already 12 jobs with the <c>RUNNING</c> status, the new job
        /// request fails and returns a <c>LimitExceededException</c> error. Wait for a current
        /// job to comlpete before you resubmit the new job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>A large number of API requests are submitted on an Amazon Web Services account.</b>
        /// When a user makes more than 10 API calls to the Amazon QuickSight API in one second,
        /// a <c>ThrottlingException</c> is returned.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If your use case requires a higher throttling limit, contact your account admin or
        /// <a href="http://aws.amazon.com/contact-us/">Amazon Web ServicesSupport</a> to explore
        /// options to tailor a more optimal expereince for your account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Best practices to handle throttling</b> 
        /// </para>
        ///  
        /// <para>
        /// If your use case projects high levels of API traffic, try to reduce the degree of
        /// frequency and parallelism of API calls as much as you can to avoid throttling. You
        /// can also perform a timing test to calculate an estimate for the total processing time
        /// of your projected load that stays within the throttling limits of the Amazon QuickSight
        /// APIs. For example, if your projected traffic is 100 snapshot jobs before 12:00 PM
        /// per day, start 12 jobs in parallel and measure the amount of time it takes to proccess
        /// all 12 jobs. Once you obtain the result, multiply the duration by 9, for example <c>(12
        /// minutes * 9 = 108 minutes)</c>. Use the new result to determine the latest time at
        /// which the jobs need to be started to meet your target deadline.
        /// </para>
        ///  
        /// <para>
        /// The time that it takes to process a job can be impacted by the following factors:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The dataset type (Direct Query or SPICE).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The size of the dataset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The complexity of the calculated fields that are used in the dashboard.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The number of visuals that are on a sheet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The types of visuals that are on the sheet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The number of formats and snapshots that are requested in the job configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The size of the generated snapshots.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDashboardSnapshotJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDashboardSnapshotJob service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedPricingPlanException">
        /// This error indicates that you are calling an embedding operation in Amazon QuickSight
        /// without the required pricing plan on your Amazon Web Services account. Before you
        /// can use embedding for anonymous users, a QuickSight administrator needs to add capacity
        /// pricing to Amazon QuickSight. You can do this on the <b>Manage Amazon QuickSight</b>
        /// page. 
        /// 
        ///  
        /// <para>
        /// After capacity pricing is added, you can use the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_GetDashboardEmbedUrl.html">GetDashboardEmbedUrl</a>
        /// </c> API operation with the <c>--identity-type ANONYMOUS</c> option.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/StartDashboardSnapshotJob">REST API Reference for StartDashboardSnapshotJob Operation</seealso>
        public virtual Task<StartDashboardSnapshotJobResponse> StartDashboardSnapshotJobAsync(StartDashboardSnapshotJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDashboardSnapshotJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDashboardSnapshotJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartDashboardSnapshotJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartDashboardSnapshotJobSchedule

        internal virtual StartDashboardSnapshotJobScheduleResponse StartDashboardSnapshotJobSchedule(StartDashboardSnapshotJobScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDashboardSnapshotJobScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDashboardSnapshotJobScheduleResponseUnmarshaller.Instance;

            return Invoke<StartDashboardSnapshotJobScheduleResponse>(request, options);
        }



        /// <summary>
        /// Starts an asynchronous job that runs an existing dashboard schedule and sends the
        /// dashboard snapshot through email. 
        /// 
        ///  
        /// <para>
        /// Only one job can run simultaneously in a given schedule. Repeated requests are skipped
        /// with a <c>202</c> HTTP status code.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/sending-reports.html">Scheduling
        /// and sending Amazon QuickSight reports by email</a> and <a href="https://docs.aws.amazon.com/quicksight/latest/user/email-reports-from-dashboard.html">Configuring
        /// email report settings for a Amazon QuickSight dashboard</a> in the <i>Amazon QuickSight
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDashboardSnapshotJobSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDashboardSnapshotJobSchedule service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/StartDashboardSnapshotJobSchedule">REST API Reference for StartDashboardSnapshotJobSchedule Operation</seealso>
        public virtual Task<StartDashboardSnapshotJobScheduleResponse> StartDashboardSnapshotJobScheduleAsync(StartDashboardSnapshotJobScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDashboardSnapshotJobScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDashboardSnapshotJobScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<StartDashboardSnapshotJobScheduleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified Amazon QuickSight resource.
        /// 
        /// 
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions, by granting a user permission to access or change only resources
        /// with certain tag values. You can use the <c>TagResource</c> operation with a resource
        /// that already has tags. If you specify a new tag key for the resource, this tag is
        /// appended to the list of tags associated with the resource. If you specify a tag key
        /// that is already associated with the resource, the new tag value that you specify replaces
        /// the previous value for that tag.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a resource. Amazon QuickSight supports tagging
        /// on data set, data source, dashboard, template, topic, and user. 
        /// </para>
        ///  
        /// <para>
        /// Tagging for Amazon QuickSight works in a similar way to tagging for other Amazon Web
        /// Services services, except for the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Tags are used to track costs for users in Amazon QuickSight. You can't tag other resources
        /// that Amazon QuickSight costs are based on, such as storage capacoty (SPICE), session
        /// usage, alert consumption, or reporting units.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon QuickSight doesn't currently support the tag editor for Resource Groups.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes a tag or tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAccountCustomization

        internal virtual UpdateAccountCustomizationResponse UpdateAccountCustomization(UpdateAccountCustomizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccountCustomizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountCustomizationResponseUnmarshaller.Instance;

            return Invoke<UpdateAccountCustomizationResponse>(request, options);
        }



        /// <summary>
        /// Updates Amazon QuickSight customizations for the current Amazon Web Services Region.
        /// Currently, the only customization that you can use is a theme.
        /// 
        ///  
        /// <para>
        /// You can use customizations for your Amazon Web Services account or, if you specify
        /// a namespace, for a Amazon QuickSight namespace instead. Customizations that apply
        /// to a namespace override customizations that apply to an Amazon Web Services account.
        /// To find out which customizations apply, use the <c>DescribeAccountCustomization</c>
        /// API operation. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountCustomization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccountCustomization service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateAccountCustomization">REST API Reference for UpdateAccountCustomization Operation</seealso>
        public virtual Task<UpdateAccountCustomizationResponse> UpdateAccountCustomizationAsync(UpdateAccountCustomizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccountCustomizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountCustomizationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAccountCustomizationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAccountSettings

        internal virtual UpdateAccountSettingsResponse UpdateAccountSettings(UpdateAccountSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateAccountSettingsResponse>(request, options);
        }



        /// <summary>
        /// Updates the Amazon QuickSight settings in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccountSettings service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateAccountSettings">REST API Reference for UpdateAccountSettings Operation</seealso>
        public virtual Task<UpdateAccountSettingsResponse> UpdateAccountSettingsAsync(UpdateAccountSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAccountSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAnalysis

        internal virtual UpdateAnalysisResponse UpdateAnalysis(UpdateAnalysisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAnalysisResponseUnmarshaller.Instance;

            return Invoke<UpdateAnalysisResponse>(request, options);
        }



        /// <summary>
        /// Updates an analysis in Amazon QuickSight
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnalysis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAnalysis service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateAnalysis">REST API Reference for UpdateAnalysis Operation</seealso>
        public virtual Task<UpdateAnalysisResponse> UpdateAnalysisAsync(UpdateAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAnalysisResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAnalysisResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAnalysisPermissions

        internal virtual UpdateAnalysisPermissionsResponse UpdateAnalysisPermissions(UpdateAnalysisPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAnalysisPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAnalysisPermissionsResponseUnmarshaller.Instance;

            return Invoke<UpdateAnalysisPermissionsResponse>(request, options);
        }



        /// <summary>
        /// Updates the read and write permissions for an analysis.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnalysisPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAnalysisPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateAnalysisPermissions">REST API Reference for UpdateAnalysisPermissions Operation</seealso>
        public virtual Task<UpdateAnalysisPermissionsResponse> UpdateAnalysisPermissionsAsync(UpdateAnalysisPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAnalysisPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAnalysisPermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAnalysisPermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateApplicationWithTokenExchangeGrant

        internal virtual UpdateApplicationWithTokenExchangeGrantResponse UpdateApplicationWithTokenExchangeGrant(UpdateApplicationWithTokenExchangeGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationWithTokenExchangeGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationWithTokenExchangeGrantResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationWithTokenExchangeGrantResponse>(request, options);
        }



        /// <summary>
        /// Updates an Amazon QuickSight application with a token exchange grant. This operation
        /// only supports Amazon QuickSight applications that are registered with IAM Identity
        /// Center.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationWithTokenExchangeGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplicationWithTokenExchangeGrant service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateApplicationWithTokenExchangeGrant">REST API Reference for UpdateApplicationWithTokenExchangeGrant Operation</seealso>
        public virtual Task<UpdateApplicationWithTokenExchangeGrantResponse> UpdateApplicationWithTokenExchangeGrantAsync(UpdateApplicationWithTokenExchangeGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationWithTokenExchangeGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationWithTokenExchangeGrantResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApplicationWithTokenExchangeGrantResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateBrand

        internal virtual UpdateBrandResponse UpdateBrand(UpdateBrandRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBrandRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBrandResponseUnmarshaller.Instance;

            return Invoke<UpdateBrandResponse>(request, options);
        }



        /// <summary>
        /// Updates a brand.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrand service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBrand service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalServerException">
        /// An internal service exception.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateBrand">REST API Reference for UpdateBrand Operation</seealso>
        public virtual Task<UpdateBrandResponse> UpdateBrandAsync(UpdateBrandRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBrandRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBrandResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBrandResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateBrandAssignment

        internal virtual UpdateBrandAssignmentResponse UpdateBrandAssignment(UpdateBrandAssignmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBrandAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBrandAssignmentResponseUnmarshaller.Instance;

            return Invoke<UpdateBrandAssignmentResponse>(request, options);
        }



        /// <summary>
        /// Updates a brand assignment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrandAssignment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBrandAssignment service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalServerException">
        /// An internal service exception.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateBrandAssignment">REST API Reference for UpdateBrandAssignment Operation</seealso>
        public virtual Task<UpdateBrandAssignmentResponse> UpdateBrandAssignmentAsync(UpdateBrandAssignmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBrandAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBrandAssignmentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBrandAssignmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateBrandPublishedVersion

        internal virtual UpdateBrandPublishedVersionResponse UpdateBrandPublishedVersion(UpdateBrandPublishedVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBrandPublishedVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBrandPublishedVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateBrandPublishedVersionResponse>(request, options);
        }



        /// <summary>
        /// Updates the published version of a brand.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrandPublishedVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBrandPublishedVersion service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalServerException">
        /// An internal service exception.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidRequestException">
        /// You don't have this feature activated for your account. To fix this issue, contact
        /// Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateBrandPublishedVersion">REST API Reference for UpdateBrandPublishedVersion Operation</seealso>
        public virtual Task<UpdateBrandPublishedVersionResponse> UpdateBrandPublishedVersionAsync(UpdateBrandPublishedVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBrandPublishedVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBrandPublishedVersionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBrandPublishedVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateCustomPermissions

        internal virtual UpdateCustomPermissionsResponse UpdateCustomPermissions(UpdateCustomPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCustomPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCustomPermissionsResponseUnmarshaller.Instance;

            return Invoke<UpdateCustomPermissionsResponse>(request, options);
        }



        /// <summary>
        /// Updates a custom permissions profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCustomPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateCustomPermissions">REST API Reference for UpdateCustomPermissions Operation</seealso>
        public virtual Task<UpdateCustomPermissionsResponse> UpdateCustomPermissionsAsync(UpdateCustomPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCustomPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCustomPermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCustomPermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDashboard

        internal virtual UpdateDashboardResponse UpdateDashboard(UpdateDashboardRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDashboardResponseUnmarshaller.Instance;

            return Invoke<UpdateDashboardResponse>(request, options);
        }



        /// <summary>
        /// Updates a dashboard in an Amazon Web Services account.
        /// 
        ///  <note> 
        /// <para>
        /// Updating a Dashboard creates a new dashboard version but does not immediately publish
        /// the new version. You can update the published version of a dashboard by using the
        /// <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_UpdateDashboardPublishedVersion.html">UpdateDashboardPublishedVersion</a>
        /// </c> API operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDashboard service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboard">REST API Reference for UpdateDashboard Operation</seealso>
        public virtual Task<UpdateDashboardResponse> UpdateDashboardAsync(UpdateDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDashboardResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDashboardResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDashboardLinks

        internal virtual UpdateDashboardLinksResponse UpdateDashboardLinks(UpdateDashboardLinksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDashboardLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDashboardLinksResponseUnmarshaller.Instance;

            return Invoke<UpdateDashboardLinksResponse>(request, options);
        }



        /// <summary>
        /// Updates the linked analyses on a dashboard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboardLinks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDashboardLinks service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardLinks">REST API Reference for UpdateDashboardLinks Operation</seealso>
        public virtual Task<UpdateDashboardLinksResponse> UpdateDashboardLinksAsync(UpdateDashboardLinksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDashboardLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDashboardLinksResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDashboardLinksResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDashboardPermissions

        internal virtual UpdateDashboardPermissionsResponse UpdateDashboardPermissions(UpdateDashboardPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDashboardPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDashboardPermissionsResponseUnmarshaller.Instance;

            return Invoke<UpdateDashboardPermissionsResponse>(request, options);
        }



        /// <summary>
        /// Updates read and write permissions on a dashboard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboardPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDashboardPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardPermissions">REST API Reference for UpdateDashboardPermissions Operation</seealso>
        public virtual Task<UpdateDashboardPermissionsResponse> UpdateDashboardPermissionsAsync(UpdateDashboardPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDashboardPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDashboardPermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDashboardPermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDashboardPublishedVersion

        internal virtual UpdateDashboardPublishedVersionResponse UpdateDashboardPublishedVersion(UpdateDashboardPublishedVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDashboardPublishedVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDashboardPublishedVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateDashboardPublishedVersionResponse>(request, options);
        }



        /// <summary>
        /// Updates the published version of a dashboard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboardPublishedVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDashboardPublishedVersion service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardPublishedVersion">REST API Reference for UpdateDashboardPublishedVersion Operation</seealso>
        public virtual Task<UpdateDashboardPublishedVersionResponse> UpdateDashboardPublishedVersionAsync(UpdateDashboardPublishedVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDashboardPublishedVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDashboardPublishedVersionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDashboardPublishedVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDashboardsQAConfiguration

        internal virtual UpdateDashboardsQAConfigurationResponse UpdateDashboardsQAConfiguration(UpdateDashboardsQAConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDashboardsQAConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDashboardsQAConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateDashboardsQAConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Updates a Dashboard QA configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboardsQAConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDashboardsQAConfiguration service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDashboardsQAConfiguration">REST API Reference for UpdateDashboardsQAConfiguration Operation</seealso>
        public virtual Task<UpdateDashboardsQAConfigurationResponse> UpdateDashboardsQAConfigurationAsync(UpdateDashboardsQAConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDashboardsQAConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDashboardsQAConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDashboardsQAConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDataSet

        internal virtual UpdateDataSetResponse UpdateDataSet(UpdateDataSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSetResponseUnmarshaller.Instance;

            return Invoke<UpdateDataSetResponse>(request, options);
        }



        /// <summary>
        /// Updates a dataset. This operation doesn't support datasets that include uploaded files
        /// as a source. Partial updates are not supported by this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataSet service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSet">REST API Reference for UpdateDataSet Operation</seealso>
        public virtual Task<UpdateDataSetResponse> UpdateDataSetAsync(UpdateDataSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDataSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDataSetPermissions

        internal virtual UpdateDataSetPermissionsResponse UpdateDataSetPermissions(UpdateDataSetPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSetPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSetPermissionsResponseUnmarshaller.Instance;

            return Invoke<UpdateDataSetPermissionsResponse>(request, options);
        }



        /// <summary>
        /// Updates the permissions on a dataset.
        /// 
        ///  
        /// <para>
        /// The permissions resource is <c>arn:aws:quicksight:region:aws-account-id:dataset/data-set-id</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSetPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataSetPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSetPermissions">REST API Reference for UpdateDataSetPermissions Operation</seealso>
        public virtual Task<UpdateDataSetPermissionsResponse> UpdateDataSetPermissionsAsync(UpdateDataSetPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSetPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSetPermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDataSetPermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDataSource

        internal virtual UpdateDataSourceResponse UpdateDataSource(UpdateDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return Invoke<UpdateDataSourceResponse>(request, options);
        }



        /// <summary>
        /// Updates a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataSource service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.CustomerManagedKeyUnavailableException">
        /// The customer managed key that is registered to your Amazon QuickSight account is unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual Task<UpdateDataSourceResponse> UpdateDataSourceAsync(UpdateDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDataSourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDataSourcePermissions

        internal virtual UpdateDataSourcePermissionsResponse UpdateDataSourcePermissions(UpdateDataSourcePermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSourcePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourcePermissionsResponseUnmarshaller.Instance;

            return Invoke<UpdateDataSourcePermissionsResponse>(request, options);
        }



        /// <summary>
        /// Updates the permissions to a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSourcePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataSourcePermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDataSourcePermissions">REST API Reference for UpdateDataSourcePermissions Operation</seealso>
        public virtual Task<UpdateDataSourcePermissionsResponse> UpdateDataSourcePermissionsAsync(UpdateDataSourcePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataSourcePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourcePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDataSourcePermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDefaultQBusinessApplication

        internal virtual UpdateDefaultQBusinessApplicationResponse UpdateDefaultQBusinessApplication(UpdateDefaultQBusinessApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDefaultQBusinessApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDefaultQBusinessApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateDefaultQBusinessApplicationResponse>(request, options);
        }



        /// <summary>
        /// Updates a Amazon Q Business application that is linked to a Amazon QuickSight account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDefaultQBusinessApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDefaultQBusinessApplication service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateDefaultQBusinessApplication">REST API Reference for UpdateDefaultQBusinessApplication Operation</seealso>
        public virtual Task<UpdateDefaultQBusinessApplicationResponse> UpdateDefaultQBusinessApplicationAsync(UpdateDefaultQBusinessApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDefaultQBusinessApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDefaultQBusinessApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDefaultQBusinessApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateFolder

        internal virtual UpdateFolderResponse UpdateFolder(UpdateFolderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFolderResponseUnmarshaller.Instance;

            return Invoke<UpdateFolderResponse>(request, options);
        }



        /// <summary>
        /// Updates the name of a folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFolder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFolder service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateFolder">REST API Reference for UpdateFolder Operation</seealso>
        public virtual Task<UpdateFolderResponse> UpdateFolderAsync(UpdateFolderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFolderResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFolderResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateFolderPermissions

        internal virtual UpdateFolderPermissionsResponse UpdateFolderPermissions(UpdateFolderPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFolderPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFolderPermissionsResponseUnmarshaller.Instance;

            return Invoke<UpdateFolderPermissionsResponse>(request, options);
        }



        /// <summary>
        /// Updates permissions of a folder.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFolderPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFolderPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateFolderPermissions">REST API Reference for UpdateFolderPermissions Operation</seealso>
        public virtual Task<UpdateFolderPermissionsResponse> UpdateFolderPermissionsAsync(UpdateFolderPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFolderPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFolderPermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFolderPermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateGroup

        internal virtual UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateGroupResponse>(request, options);
        }



        /// <summary>
        /// Changes a group description.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateIAMPolicyAssignment

        internal virtual UpdateIAMPolicyAssignmentResponse UpdateIAMPolicyAssignment(UpdateIAMPolicyAssignmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIAMPolicyAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIAMPolicyAssignmentResponseUnmarshaller.Instance;

            return Invoke<UpdateIAMPolicyAssignmentResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing IAM policy assignment. This operation updates only the optional
        /// parameter or parameters that are specified in the request. This overwrites all of
        /// the users included in <c>Identities</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIAMPolicyAssignment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIAMPolicyAssignment service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConcurrentUpdatingException">
        /// A resource is already in a state that indicates an operation is happening that must
        /// complete before a new update can be applied.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateIAMPolicyAssignment">REST API Reference for UpdateIAMPolicyAssignment Operation</seealso>
        public virtual Task<UpdateIAMPolicyAssignmentResponse> UpdateIAMPolicyAssignmentAsync(UpdateIAMPolicyAssignmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIAMPolicyAssignmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIAMPolicyAssignmentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIAMPolicyAssignmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateIdentityPropagationConfig

        internal virtual UpdateIdentityPropagationConfigResponse UpdateIdentityPropagationConfig(UpdateIdentityPropagationConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIdentityPropagationConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdentityPropagationConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateIdentityPropagationConfigResponse>(request, options);
        }



        /// <summary>
        /// Adds or updates services and authorized targets to configure what the Amazon QuickSight
        /// IAM Identity Center application can access.
        /// 
        ///  
        /// <para>
        /// This operation is only supported for Amazon QuickSight accounts using IAM Identity
        /// Center
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityPropagationConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIdentityPropagationConfig service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateIdentityPropagationConfig">REST API Reference for UpdateIdentityPropagationConfig Operation</seealso>
        public virtual Task<UpdateIdentityPropagationConfigResponse> UpdateIdentityPropagationConfigAsync(UpdateIdentityPropagationConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIdentityPropagationConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdentityPropagationConfigResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIdentityPropagationConfigResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateIpRestriction

        internal virtual UpdateIpRestrictionResponse UpdateIpRestriction(UpdateIpRestrictionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIpRestrictionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIpRestrictionResponseUnmarshaller.Instance;

            return Invoke<UpdateIpRestrictionResponse>(request, options);
        }



        /// <summary>
        /// Updates the content and status of IP rules. Traffic from a source is allowed when
        /// the source satisfies either the <c>IpRestrictionRule</c>, <c>VpcIdRestrictionRule</c>,
        /// or <c>VpcEndpointIdRestrictionRule</c>. To use this operation, you must provide the
        /// entire map of rules. You can use the <c>DescribeIpRestriction</c> operation to get
        /// the current rule map.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIpRestriction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIpRestriction service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateIpRestriction">REST API Reference for UpdateIpRestriction Operation</seealso>
        public virtual Task<UpdateIpRestrictionResponse> UpdateIpRestrictionAsync(UpdateIpRestrictionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIpRestrictionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIpRestrictionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIpRestrictionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateKeyRegistration

        internal virtual UpdateKeyRegistrationResponse UpdateKeyRegistration(UpdateKeyRegistrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateKeyRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKeyRegistrationResponseUnmarshaller.Instance;

            return Invoke<UpdateKeyRegistrationResponse>(request, options);
        }



        /// <summary>
        /// Updates a customer managed key in a Amazon QuickSight account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeyRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateKeyRegistration service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateKeyRegistration">REST API Reference for UpdateKeyRegistration Operation</seealso>
        public virtual Task<UpdateKeyRegistrationResponse> UpdateKeyRegistrationAsync(UpdateKeyRegistrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateKeyRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKeyRegistrationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateKeyRegistrationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdatePublicSharingSettings

        internal virtual UpdatePublicSharingSettingsResponse UpdatePublicSharingSettings(UpdatePublicSharingSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePublicSharingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePublicSharingSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdatePublicSharingSettingsResponse>(request, options);
        }



        /// <summary>
        /// Use the <c>UpdatePublicSharingSettings</c> operation to turn on or turn off the public
        /// sharing settings of an Amazon QuickSight dashboard.
        /// 
        ///  
        /// <para>
        /// To use this operation, turn on session capacity pricing for your Amazon QuickSight
        /// account.
        /// </para>
        ///  
        /// <para>
        /// Before you can turn on public sharing on your account, make sure to give public sharing
        /// permissions to an administrative user in the Identity and Access Management (IAM)
        /// console. For more information on using IAM with Amazon QuickSight, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/security_iam_service-with-iam.html">Using
        /// Amazon QuickSight with IAM</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePublicSharingSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePublicSharingSettings service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedPricingPlanException">
        /// This error indicates that you are calling an embedding operation in Amazon QuickSight
        /// without the required pricing plan on your Amazon Web Services account. Before you
        /// can use embedding for anonymous users, a QuickSight administrator needs to add capacity
        /// pricing to Amazon QuickSight. You can do this on the <b>Manage Amazon QuickSight</b>
        /// page. 
        /// 
        ///  
        /// <para>
        /// After capacity pricing is added, you can use the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_GetDashboardEmbedUrl.html">GetDashboardEmbedUrl</a>
        /// </c> API operation with the <c>--identity-type ANONYMOUS</c> option.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdatePublicSharingSettings">REST API Reference for UpdatePublicSharingSettings Operation</seealso>
        public virtual Task<UpdatePublicSharingSettingsResponse> UpdatePublicSharingSettingsAsync(UpdatePublicSharingSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePublicSharingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePublicSharingSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePublicSharingSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateQPersonalizationConfiguration

        internal virtual UpdateQPersonalizationConfigurationResponse UpdateQPersonalizationConfiguration(UpdateQPersonalizationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQPersonalizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQPersonalizationConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateQPersonalizationConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Updates a personalization configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQPersonalizationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateQPersonalizationConfiguration service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateQPersonalizationConfiguration">REST API Reference for UpdateQPersonalizationConfiguration Operation</seealso>
        public virtual Task<UpdateQPersonalizationConfigurationResponse> UpdateQPersonalizationConfigurationAsync(UpdateQPersonalizationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQPersonalizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQPersonalizationConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateQPersonalizationConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateQuickSightQSearchConfiguration

        internal virtual UpdateQuickSightQSearchConfigurationResponse UpdateQuickSightQSearchConfiguration(UpdateQuickSightQSearchConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQuickSightQSearchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQuickSightQSearchConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateQuickSightQSearchConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Updates the state of a Amazon QuickSight Q Search configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQuickSightQSearchConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateQuickSightQSearchConfiguration service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateQuickSightQSearchConfiguration">REST API Reference for UpdateQuickSightQSearchConfiguration Operation</seealso>
        public virtual Task<UpdateQuickSightQSearchConfigurationResponse> UpdateQuickSightQSearchConfigurationAsync(UpdateQuickSightQSearchConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQuickSightQSearchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQuickSightQSearchConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateQuickSightQSearchConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateRefreshSchedule

        internal virtual UpdateRefreshScheduleResponse UpdateRefreshSchedule(UpdateRefreshScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRefreshScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRefreshScheduleResponseUnmarshaller.Instance;

            return Invoke<UpdateRefreshScheduleResponse>(request, options);
        }



        /// <summary>
        /// Updates a refresh schedule for a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRefreshSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRefreshSchedule service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateRefreshSchedule">REST API Reference for UpdateRefreshSchedule Operation</seealso>
        public virtual Task<UpdateRefreshScheduleResponse> UpdateRefreshScheduleAsync(UpdateRefreshScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRefreshScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRefreshScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRefreshScheduleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateRoleCustomPermission

        internal virtual UpdateRoleCustomPermissionResponse UpdateRoleCustomPermission(UpdateRoleCustomPermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoleCustomPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoleCustomPermissionResponseUnmarshaller.Instance;

            return Invoke<UpdateRoleCustomPermissionResponse>(request, options);
        }



        /// <summary>
        /// Updates the custom permissions that are associated with a role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoleCustomPermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRoleCustomPermission service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateRoleCustomPermission">REST API Reference for UpdateRoleCustomPermission Operation</seealso>
        public virtual Task<UpdateRoleCustomPermissionResponse> UpdateRoleCustomPermissionAsync(UpdateRoleCustomPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoleCustomPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoleCustomPermissionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRoleCustomPermissionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSPICECapacityConfiguration

        internal virtual UpdateSPICECapacityConfigurationResponse UpdateSPICECapacityConfiguration(UpdateSPICECapacityConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSPICECapacityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSPICECapacityConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateSPICECapacityConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Updates the SPICE capacity configuration for a Amazon QuickSight account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSPICECapacityConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSPICECapacityConfiguration service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateSPICECapacityConfiguration">REST API Reference for UpdateSPICECapacityConfiguration Operation</seealso>
        public virtual Task<UpdateSPICECapacityConfigurationResponse> UpdateSPICECapacityConfigurationAsync(UpdateSPICECapacityConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSPICECapacityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSPICECapacityConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSPICECapacityConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateTemplate

        internal virtual UpdateTemplateResponse UpdateTemplate(UpdateTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateTemplateResponse>(request, options);
        }



        /// <summary>
        /// Updates a template from an existing Amazon QuickSight analysis or another template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTemplate service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        public virtual Task<UpdateTemplateResponse> UpdateTemplateAsync(UpdateTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateTemplateAlias

        internal virtual UpdateTemplateAliasResponse UpdateTemplateAlias(UpdateTemplateAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTemplateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplateAliasResponseUnmarshaller.Instance;

            return Invoke<UpdateTemplateAliasResponse>(request, options);
        }



        /// <summary>
        /// Updates the template alias of a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplateAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTemplateAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplateAlias">REST API Reference for UpdateTemplateAlias Operation</seealso>
        public virtual Task<UpdateTemplateAliasResponse> UpdateTemplateAliasAsync(UpdateTemplateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTemplateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTemplateAliasResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateTemplatePermissions

        internal virtual UpdateTemplatePermissionsResponse UpdateTemplatePermissions(UpdateTemplatePermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTemplatePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplatePermissionsResponseUnmarshaller.Instance;

            return Invoke<UpdateTemplatePermissionsResponse>(request, options);
        }



        /// <summary>
        /// Updates the resource permissions for a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplatePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTemplatePermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTemplatePermissions">REST API Reference for UpdateTemplatePermissions Operation</seealso>
        public virtual Task<UpdateTemplatePermissionsResponse> UpdateTemplatePermissionsAsync(UpdateTemplatePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTemplatePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplatePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTemplatePermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateTheme

        internal virtual UpdateThemeResponse UpdateTheme(UpdateThemeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateThemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThemeResponseUnmarshaller.Instance;

            return Invoke<UpdateThemeResponse>(request, options);
        }



        /// <summary>
        /// Updates a theme.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTheme service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTheme service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTheme">REST API Reference for UpdateTheme Operation</seealso>
        public virtual Task<UpdateThemeResponse> UpdateThemeAsync(UpdateThemeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateThemeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThemeResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateThemeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateThemeAlias

        internal virtual UpdateThemeAliasResponse UpdateThemeAlias(UpdateThemeAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateThemeAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThemeAliasResponseUnmarshaller.Instance;

            return Invoke<UpdateThemeAliasResponse>(request, options);
        }



        /// <summary>
        /// Updates an alias of a theme.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThemeAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateThemeAlias service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateThemeAlias">REST API Reference for UpdateThemeAlias Operation</seealso>
        public virtual Task<UpdateThemeAliasResponse> UpdateThemeAliasAsync(UpdateThemeAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateThemeAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThemeAliasResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateThemeAliasResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateThemePermissions

        internal virtual UpdateThemePermissionsResponse UpdateThemePermissions(UpdateThemePermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateThemePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThemePermissionsResponseUnmarshaller.Instance;

            return Invoke<UpdateThemePermissionsResponse>(request, options);
        }



        /// <summary>
        /// Updates the resource permissions for a theme. Permissions apply to the action to grant
        /// or revoke permissions on, for example <c>"quicksight:DescribeTheme"</c>.
        /// 
        ///  
        /// <para>
        /// Theme permissions apply in groupings. Valid groupings include the following for the
        /// three levels of permissions, which are user, owner, or no permissions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// User
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"quicksight:DescribeTheme"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:DescribeThemeAlias"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:ListThemeAliases"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:ListThemeVersions"</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Owner
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"quicksight:DescribeTheme"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:DescribeThemeAlias"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:ListThemeAliases"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:ListThemeVersions"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:DeleteTheme"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:UpdateTheme"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:CreateThemeAlias"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:DeleteThemeAlias"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:UpdateThemeAlias"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:UpdateThemePermissions"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"quicksight:DescribeThemePermissions"</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// To specify no permissions, omit the permissions list.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThemePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateThemePermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateThemePermissions">REST API Reference for UpdateThemePermissions Operation</seealso>
        public virtual Task<UpdateThemePermissionsResponse> UpdateThemePermissionsAsync(UpdateThemePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateThemePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThemePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateThemePermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateTopic

        internal virtual UpdateTopicResponse UpdateTopic(UpdateTopicRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTopicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTopicResponseUnmarshaller.Instance;

            return Invoke<UpdateTopicResponse>(request, options);
        }



        /// <summary>
        /// Updates a topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTopic service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTopic service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTopic">REST API Reference for UpdateTopic Operation</seealso>
        public virtual Task<UpdateTopicResponse> UpdateTopicAsync(UpdateTopicRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTopicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTopicResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTopicResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateTopicPermissions

        internal virtual UpdateTopicPermissionsResponse UpdateTopicPermissions(UpdateTopicPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTopicPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTopicPermissionsResponseUnmarshaller.Instance;

            return Invoke<UpdateTopicPermissionsResponse>(request, options);
        }



        /// <summary>
        /// Updates the permissions of a topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTopicPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTopicPermissions service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTopicPermissions">REST API Reference for UpdateTopicPermissions Operation</seealso>
        public virtual Task<UpdateTopicPermissionsResponse> UpdateTopicPermissionsAsync(UpdateTopicPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTopicPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTopicPermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTopicPermissionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateTopicRefreshSchedule

        internal virtual UpdateTopicRefreshScheduleResponse UpdateTopicRefreshSchedule(UpdateTopicRefreshScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTopicRefreshScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTopicRefreshScheduleResponseUnmarshaller.Instance;

            return Invoke<UpdateTopicRefreshScheduleResponse>(request, options);
        }



        /// <summary>
        /// Updates a topic refresh schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTopicRefreshSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTopicRefreshSchedule service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceExistsException">
        /// The resource specified already exists.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateTopicRefreshSchedule">REST API Reference for UpdateTopicRefreshSchedule Operation</seealso>
        public virtual Task<UpdateTopicRefreshScheduleResponse> UpdateTopicRefreshScheduleAsync(UpdateTopicRefreshScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTopicRefreshScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTopicRefreshScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTopicRefreshScheduleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateUser

        internal virtual UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return Invoke<UpdateUserResponse>(request, options);
        }



        /// <summary>
        /// Updates an Amazon QuickSight user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUserResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateUserCustomPermission

        internal virtual UpdateUserCustomPermissionResponse UpdateUserCustomPermission(UpdateUserCustomPermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserCustomPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserCustomPermissionResponseUnmarshaller.Instance;

            return Invoke<UpdateUserCustomPermissionResponse>(request, options);
        }



        /// <summary>
        /// Updates a custom permissions profile for a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserCustomPermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUserCustomPermission service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.PreconditionNotMetException">
        /// One or more preconditions aren't met.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceUnavailableException">
        /// This resource is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateUserCustomPermission">REST API Reference for UpdateUserCustomPermission Operation</seealso>
        public virtual Task<UpdateUserCustomPermissionResponse> UpdateUserCustomPermissionAsync(UpdateUserCustomPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserCustomPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserCustomPermissionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUserCustomPermissionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateVPCConnection

        internal virtual UpdateVPCConnectionResponse UpdateVPCConnection(UpdateVPCConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVPCConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVPCConnectionResponseUnmarshaller.Instance;

            return Invoke<UpdateVPCConnectionResponse>(request, options);
        }



        /// <summary>
        /// Updates a VPC connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVPCConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVPCConnection service method, as returned by QuickSight.</returns>
        /// <exception cref="Amazon.QuickSight.Model.AccessDeniedException">
        /// You don't have access to this item. The provided credentials couldn't be validated.
        /// You might not be authorized to carry out the request. Make sure that your account
        /// is authorized to use the Amazon QuickSight service, that your policies have the correct
        /// permissions, and that you are using the correct credentials.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.InvalidParameterValueException">
        /// One or more parameters has a value that isn't valid.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.LimitExceededException">
        /// A limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.ThrottlingException">
        /// Access is throttled.
        /// </exception>
        /// <exception cref="Amazon.QuickSight.Model.UnsupportedUserEditionException">
        /// This error indicates that you are calling an operation on an Amazon QuickSight subscription
        /// where the edition doesn't include support for that operation. Amazon Amazon QuickSight
        /// currently has Standard Edition and Enterprise Edition. Not every operation and capability
        /// is available in every edition.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateVPCConnection">REST API Reference for UpdateVPCConnection Operation</seealso>
        public virtual Task<UpdateVPCConnectionResponse> UpdateVPCConnectionAsync(UpdateVPCConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVPCConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVPCConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateVPCConnectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}