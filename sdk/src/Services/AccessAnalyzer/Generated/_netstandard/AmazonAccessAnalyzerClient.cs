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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.AccessAnalyzer.Model;
using Amazon.AccessAnalyzer.Model.Internal.MarshallTransformations;
using Amazon.AccessAnalyzer.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AccessAnalyzer
{
    /// <summary>
    /// Implementation for accessing AccessAnalyzer
    ///
    /// AWS IAM Access Analyzer helps identify potential resource-access risks by enabling
    /// you to identify any policies that grant access to an external principal. It does this
    /// by using logic-based reasoning to analyze resource-based policies in your AWS environment.
    /// An external principal can be another AWS account, a root user, an IAM user or role,
    /// a federated user, an AWS service, or an anonymous user. This guide describes the AWS
    /// IAM Access Analyzer operations that you can call programmatically. For general information
    /// about Access Analyzer, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/what-is-access-analyzer.html">AWS
    /// IAM Access Analyzer</a> in the <b>IAM User Guide</b>.
    /// 
    ///  
    /// <para>
    /// To start using Access Analyzer, you first need to create an analyzer.
    /// </para>
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial class AmazonAccessAnalyzerClient : AmazonServiceClient, IAmazonAccessAnalyzer
    {
        private static IServiceMetadata serviceMetadata = new AmazonAccessAnalyzerMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonAccessAnalyzerClient with the credentials loaded from the application's
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
        public AmazonAccessAnalyzerClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAccessAnalyzerConfig()) { }

        /// <summary>
        /// Constructs AmazonAccessAnalyzerClient with the credentials loaded from the application's
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
        public AmazonAccessAnalyzerClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAccessAnalyzerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAccessAnalyzerClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAccessAnalyzerClient Configuration Object</param>
        public AmazonAccessAnalyzerClient(AmazonAccessAnalyzerConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonAccessAnalyzerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAccessAnalyzerClient(AWSCredentials credentials)
            : this(credentials, new AmazonAccessAnalyzerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAccessAnalyzerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAccessAnalyzerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAccessAnalyzerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAccessAnalyzerClient with AWS Credentials and an
        /// AmazonAccessAnalyzerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAccessAnalyzerClient Configuration Object</param>
        public AmazonAccessAnalyzerClient(AWSCredentials credentials, AmazonAccessAnalyzerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAccessAnalyzerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAccessAnalyzerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAccessAnalyzerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAccessAnalyzerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAccessAnalyzerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAccessAnalyzerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAccessAnalyzerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAccessAnalyzerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAccessAnalyzerClient Configuration Object</param>
        public AmazonAccessAnalyzerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAccessAnalyzerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAccessAnalyzerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAccessAnalyzerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAccessAnalyzerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAccessAnalyzerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAccessAnalyzerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAccessAnalyzerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAccessAnalyzerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAccessAnalyzerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAccessAnalyzerClient Configuration Object</param>
        public AmazonAccessAnalyzerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAccessAnalyzerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IAccessAnalyzerPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IAccessAnalyzerPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new AccessAnalyzerPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

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


        #region  ApplyArchiveRule

        internal virtual ApplyArchiveRuleResponse ApplyArchiveRule(ApplyArchiveRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ApplyArchiveRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplyArchiveRuleResponseUnmarshaller.Instance;

            return Invoke<ApplyArchiveRuleResponse>(request, options);
        }



        /// <summary>
        /// Retroactively applies the archive rule to existing findings that meet the archive
        /// rule criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplyArchiveRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ApplyArchiveRule service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ApplyArchiveRule">REST API Reference for ApplyArchiveRule Operation</seealso>
        public virtual Task<ApplyArchiveRuleResponse> ApplyArchiveRuleAsync(ApplyArchiveRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ApplyArchiveRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplyArchiveRuleResponseUnmarshaller.Instance;

            return InvokeAsync<ApplyArchiveRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAnalyzer

        internal virtual CreateAnalyzerResponse CreateAnalyzer(CreateAnalyzerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAnalyzerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAnalyzerResponseUnmarshaller.Instance;

            return Invoke<CreateAnalyzerResponse>(request, options);
        }



        /// <summary>
        /// Creates an analyzer for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAnalyzer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAnalyzer service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ConflictException">
        /// A conflict exception error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ServiceQuotaExceededException">
        /// Service quote met error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CreateAnalyzer">REST API Reference for CreateAnalyzer Operation</seealso>
        public virtual Task<CreateAnalyzerResponse> CreateAnalyzerAsync(CreateAnalyzerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAnalyzerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAnalyzerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAnalyzerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateArchiveRule

        internal virtual CreateArchiveRuleResponse CreateArchiveRule(CreateArchiveRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateArchiveRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateArchiveRuleResponseUnmarshaller.Instance;

            return Invoke<CreateArchiveRuleResponse>(request, options);
        }



        /// <summary>
        /// Creates an archive rule for the specified analyzer. Archive rules automatically archive
        /// new findings that meet the criteria you define when you create the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateArchiveRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateArchiveRule service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ConflictException">
        /// A conflict exception error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ServiceQuotaExceededException">
        /// Service quote met error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CreateArchiveRule">REST API Reference for CreateArchiveRule Operation</seealso>
        public virtual Task<CreateArchiveRuleResponse> CreateArchiveRuleAsync(CreateArchiveRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateArchiveRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateArchiveRuleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateArchiveRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAnalyzer

        internal virtual DeleteAnalyzerResponse DeleteAnalyzer(DeleteAnalyzerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAnalyzerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnalyzerResponseUnmarshaller.Instance;

            return Invoke<DeleteAnalyzerResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified analyzer. When you delete an analyzer, Access Analyzer is disabled
        /// for the account in the current or specific Region. All findings that were generated
        /// by the analyzer are deleted. You cannot undo this action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnalyzer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAnalyzer service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/DeleteAnalyzer">REST API Reference for DeleteAnalyzer Operation</seealso>
        public virtual Task<DeleteAnalyzerResponse> DeleteAnalyzerAsync(DeleteAnalyzerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAnalyzerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnalyzerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAnalyzerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteArchiveRule

        internal virtual DeleteArchiveRuleResponse DeleteArchiveRule(DeleteArchiveRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteArchiveRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteArchiveRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteArchiveRuleResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified archive rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteArchiveRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteArchiveRule service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/DeleteArchiveRule">REST API Reference for DeleteArchiveRule Operation</seealso>
        public virtual Task<DeleteArchiveRuleResponse> DeleteArchiveRuleAsync(DeleteArchiveRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteArchiveRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteArchiveRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteArchiveRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAnalyzedResource

        internal virtual GetAnalyzedResourceResponse GetAnalyzedResource(GetAnalyzedResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAnalyzedResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnalyzedResourceResponseUnmarshaller.Instance;

            return Invoke<GetAnalyzedResourceResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a resource that was analyzed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnalyzedResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAnalyzedResource service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetAnalyzedResource">REST API Reference for GetAnalyzedResource Operation</seealso>
        public virtual Task<GetAnalyzedResourceResponse> GetAnalyzedResourceAsync(GetAnalyzedResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAnalyzedResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnalyzedResourceResponseUnmarshaller.Instance;

            return InvokeAsync<GetAnalyzedResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAnalyzer

        internal virtual GetAnalyzerResponse GetAnalyzer(GetAnalyzerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAnalyzerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnalyzerResponseUnmarshaller.Instance;

            return Invoke<GetAnalyzerResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about the specified analyzer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnalyzer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAnalyzer service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetAnalyzer">REST API Reference for GetAnalyzer Operation</seealso>
        public virtual Task<GetAnalyzerResponse> GetAnalyzerAsync(GetAnalyzerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAnalyzerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnalyzerResponseUnmarshaller.Instance;

            return InvokeAsync<GetAnalyzerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetArchiveRule

        internal virtual GetArchiveRuleResponse GetArchiveRule(GetArchiveRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetArchiveRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArchiveRuleResponseUnmarshaller.Instance;

            return Invoke<GetArchiveRuleResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about an archive rule.
        /// 
        ///  
        /// <para>
        /// To learn about filter keys that you can use to create an archive rule, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access-analyzer-reference-filter-keys.html">Access
        /// Analyzer filter keys</a> in the <b>IAM User Guide</b>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetArchiveRule service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetArchiveRule">REST API Reference for GetArchiveRule Operation</seealso>
        public virtual Task<GetArchiveRuleResponse> GetArchiveRuleAsync(GetArchiveRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetArchiveRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArchiveRuleResponseUnmarshaller.Instance;

            return InvokeAsync<GetArchiveRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFinding

        internal virtual GetFindingResponse GetFinding(GetFindingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingResponseUnmarshaller.Instance;

            return Invoke<GetFindingResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about the specified finding.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFinding service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFinding service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetFinding">REST API Reference for GetFinding Operation</seealso>
        public virtual Task<GetFindingResponse> GetFindingAsync(GetFindingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingResponseUnmarshaller.Instance;

            return InvokeAsync<GetFindingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAnalyzedResources

        internal virtual ListAnalyzedResourcesResponse ListAnalyzedResources(ListAnalyzedResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAnalyzedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnalyzedResourcesResponseUnmarshaller.Instance;

            return Invoke<ListAnalyzedResourcesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of resources of the specified type that have been analyzed by the
        /// specified analyzer..
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnalyzedResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAnalyzedResources service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListAnalyzedResources">REST API Reference for ListAnalyzedResources Operation</seealso>
        public virtual Task<ListAnalyzedResourcesResponse> ListAnalyzedResourcesAsync(ListAnalyzedResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAnalyzedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnalyzedResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAnalyzedResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAnalyzers

        internal virtual ListAnalyzersResponse ListAnalyzers(ListAnalyzersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAnalyzersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnalyzersResponseUnmarshaller.Instance;

            return Invoke<ListAnalyzersResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of analyzers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnalyzers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAnalyzers service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListAnalyzers">REST API Reference for ListAnalyzers Operation</seealso>
        public virtual Task<ListAnalyzersResponse> ListAnalyzersAsync(ListAnalyzersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAnalyzersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnalyzersResponseUnmarshaller.Instance;

            return InvokeAsync<ListAnalyzersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListArchiveRules

        internal virtual ListArchiveRulesResponse ListArchiveRules(ListArchiveRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListArchiveRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListArchiveRulesResponseUnmarshaller.Instance;

            return Invoke<ListArchiveRulesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of archive rules created for the specified analyzer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArchiveRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListArchiveRules service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListArchiveRules">REST API Reference for ListArchiveRules Operation</seealso>
        public virtual Task<ListArchiveRulesResponse> ListArchiveRulesAsync(ListArchiveRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListArchiveRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListArchiveRulesResponseUnmarshaller.Instance;

            return InvokeAsync<ListArchiveRulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFindings

        internal virtual ListFindingsResponse ListFindings(ListFindingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingsResponseUnmarshaller.Instance;

            return Invoke<ListFindingsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of findings generated by the specified analyzer.
        /// 
        ///  
        /// <para>
        /// To learn about filter keys that you can use to create an archive rule, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access-analyzer-reference-filter-keys.html">Access
        /// Analyzer filter keys</a> in the <b>IAM User Guide</b>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFindings service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListFindings">REST API Reference for ListFindings Operation</seealso>
        public virtual Task<ListFindingsResponse> ListFindingsAsync(ListFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFindingsResponse>(request, options, cancellationToken);
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
        /// Retrieves a list of tags applied to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartResourceScan

        internal virtual StartResourceScanResponse StartResourceScan(StartResourceScanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartResourceScanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartResourceScanResponseUnmarshaller.Instance;

            return Invoke<StartResourceScanResponse>(request, options);
        }



        /// <summary>
        /// Immediately starts a scan of the policies applied to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartResourceScan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartResourceScan service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/StartResourceScan">REST API Reference for StartResourceScan Operation</seealso>
        public virtual Task<StartResourceScanResponse> StartResourceScanAsync(StartResourceScanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartResourceScanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartResourceScanResponseUnmarshaller.Instance;

            return InvokeAsync<StartResourceScanResponse>(request, options, cancellationToken);
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
        /// Adds a tag to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes a tag from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateArchiveRule

        internal virtual UpdateArchiveRuleResponse UpdateArchiveRule(UpdateArchiveRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateArchiveRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateArchiveRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateArchiveRuleResponse>(request, options);
        }



        /// <summary>
        /// Updates the criteria and values for the specified archive rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateArchiveRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateArchiveRule service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/UpdateArchiveRule">REST API Reference for UpdateArchiveRule Operation</seealso>
        public virtual Task<UpdateArchiveRuleResponse> UpdateArchiveRuleAsync(UpdateArchiveRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateArchiveRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateArchiveRuleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateArchiveRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFindings

        internal virtual UpdateFindingsResponse UpdateFindings(UpdateFindingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFindingsResponseUnmarshaller.Instance;

            return Invoke<UpdateFindingsResponse>(request, options);
        }



        /// <summary>
        /// Updates the status for the specified findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFindings service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/UpdateFindings">REST API Reference for UpdateFindings Operation</seealso>
        public virtual Task<UpdateFindingsResponse> UpdateFindingsAsync(UpdateFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFindingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}