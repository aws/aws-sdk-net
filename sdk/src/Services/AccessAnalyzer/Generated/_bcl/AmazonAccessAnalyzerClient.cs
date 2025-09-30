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
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.AccessAnalyzer
{
    /// <summary>
    /// <para>Implementation for accessing AccessAnalyzer</para>
    ///
    /// Identity and Access Management Access Analyzer helps you to set, verify, and refine
    /// your IAM policies by providing a suite of capabilities. Its features include findings
    /// for external and unused access, basic and custom policy checks for validating policies,
    /// and policy generation to generate fine-grained policies. To start using IAM Access
    /// Analyzer to identify external or unused access, you first need to create an analyzer.
    /// 
    ///  
    /// <para>
    ///  <b>External access analyzers</b> help identify potential risks of accessing resources
    /// by enabling you to identify any resource policies that grant access to an external
    /// principal. It does this by using logic-based reasoning to analyze resource-based policies
    /// in your Amazon Web Services environment. An external principal can be another Amazon
    /// Web Services account, a root user, an IAM user or role, a federated user, an Amazon
    /// Web Services service, or an anonymous user. You can also use IAM Access Analyzer to
    /// preview public and cross-account access to your resources before deploying permissions
    /// changes.
    /// </para>
    ///  
    /// <para>
    ///  <b>Unused access analyzers</b> help identify potential identity access risks by enabling
    /// you to identify unused IAM roles, unused access keys, unused console passwords, and
    /// IAM principals with unused service and action-level permissions.
    /// </para>
    ///  
    /// <para>
    /// Beyond findings, IAM Access Analyzer provides basic and custom policy checks to validate
    /// IAM policies before deploying permissions changes. You can use policy generation to
    /// refine permissions by attaching a policy generated using access activity logged in
    /// CloudTrail logs. 
    /// </para>
    ///  
    /// <para>
    /// This guide describes the IAM Access Analyzer operations that you can call programmatically.
    /// For general information about IAM Access Analyzer, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/what-is-access-analyzer.html">Identity
    /// and Access Management Access Analyzer</a> in the <b>IAM User Guide</b>.
    /// </para>
    /// </summary>
    public partial class AmazonAccessAnalyzerClient : AmazonServiceClient, IAmazonAccessAnalyzer
    {
        private static IServiceMetadata serviceMetadata = new AmazonAccessAnalyzerMetadata();
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
            : base(new AmazonAccessAnalyzerConfig()) { }

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
            : base(new AmazonAccessAnalyzerConfig{RegionEndpoint = region}) { }

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
            : base(config) { }

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

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAccessAnalyzerEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAccessAnalyzerAuthSchemeHandler());
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


        /// <summary>
        /// Retroactively applies the archive rule to existing findings that meet the archive
        /// rule criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplyArchiveRule service method.</param>
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
        public virtual ApplyArchiveRuleResponse ApplyArchiveRule(ApplyArchiveRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ApplyArchiveRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplyArchiveRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<ApplyArchiveRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelPolicyGeneration


        /// <summary>
        /// Cancels the requested policy generation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelPolicyGeneration service method.</param>
        /// 
        /// <returns>The response from the CancelPolicyGeneration service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CancelPolicyGeneration">REST API Reference for CancelPolicyGeneration Operation</seealso>
        public virtual CancelPolicyGenerationResponse CancelPolicyGeneration(CancelPolicyGenerationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelPolicyGenerationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelPolicyGenerationResponseUnmarshaller.Instance;

            return Invoke<CancelPolicyGenerationResponse>(request, options);
        }


        /// <summary>
        /// Cancels the requested policy generation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelPolicyGeneration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelPolicyGeneration service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CancelPolicyGeneration">REST API Reference for CancelPolicyGeneration Operation</seealso>
        public virtual Task<CancelPolicyGenerationResponse> CancelPolicyGenerationAsync(CancelPolicyGenerationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelPolicyGenerationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelPolicyGenerationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelPolicyGenerationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CheckAccessNotGranted


        /// <summary>
        /// Checks whether the specified access isn't allowed by a policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckAccessNotGranted service method.</param>
        /// 
        /// <returns>The response from the CheckAccessNotGranted service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InvalidParameterException">
        /// The specified parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.UnprocessableEntityException">
        /// The specified entity could not be processed.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CheckAccessNotGranted">REST API Reference for CheckAccessNotGranted Operation</seealso>
        public virtual CheckAccessNotGrantedResponse CheckAccessNotGranted(CheckAccessNotGrantedRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CheckAccessNotGrantedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckAccessNotGrantedResponseUnmarshaller.Instance;

            return Invoke<CheckAccessNotGrantedResponse>(request, options);
        }


        /// <summary>
        /// Checks whether the specified access isn't allowed by a policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckAccessNotGranted service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CheckAccessNotGranted service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InvalidParameterException">
        /// The specified parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.UnprocessableEntityException">
        /// The specified entity could not be processed.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CheckAccessNotGranted">REST API Reference for CheckAccessNotGranted Operation</seealso>
        public virtual Task<CheckAccessNotGrantedResponse> CheckAccessNotGrantedAsync(CheckAccessNotGrantedRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CheckAccessNotGrantedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckAccessNotGrantedResponseUnmarshaller.Instance;
            
            return InvokeAsync<CheckAccessNotGrantedResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CheckNoNewAccess


        /// <summary>
        /// Checks whether new access is allowed for an updated policy when compared to the existing
        /// policy.
        /// 
        ///  
        /// <para>
        /// You can find examples for reference policies and learn how to set up and run a custom
        /// policy check for new access in the <a href="https://github.com/aws-samples/iam-access-analyzer-custom-policy-check-samples">IAM
        /// Access Analyzer custom policy checks samples</a> repository on GitHub. The reference
        /// policies in this repository are meant to be passed to the <c>existingPolicyDocument</c>
        /// request parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckNoNewAccess service method.</param>
        /// 
        /// <returns>The response from the CheckNoNewAccess service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InvalidParameterException">
        /// The specified parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.UnprocessableEntityException">
        /// The specified entity could not be processed.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CheckNoNewAccess">REST API Reference for CheckNoNewAccess Operation</seealso>
        public virtual CheckNoNewAccessResponse CheckNoNewAccess(CheckNoNewAccessRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CheckNoNewAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckNoNewAccessResponseUnmarshaller.Instance;

            return Invoke<CheckNoNewAccessResponse>(request, options);
        }


        /// <summary>
        /// Checks whether new access is allowed for an updated policy when compared to the existing
        /// policy.
        /// 
        ///  
        /// <para>
        /// You can find examples for reference policies and learn how to set up and run a custom
        /// policy check for new access in the <a href="https://github.com/aws-samples/iam-access-analyzer-custom-policy-check-samples">IAM
        /// Access Analyzer custom policy checks samples</a> repository on GitHub. The reference
        /// policies in this repository are meant to be passed to the <c>existingPolicyDocument</c>
        /// request parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckNoNewAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CheckNoNewAccess service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InvalidParameterException">
        /// The specified parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.UnprocessableEntityException">
        /// The specified entity could not be processed.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CheckNoNewAccess">REST API Reference for CheckNoNewAccess Operation</seealso>
        public virtual Task<CheckNoNewAccessResponse> CheckNoNewAccessAsync(CheckNoNewAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CheckNoNewAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckNoNewAccessResponseUnmarshaller.Instance;
            
            return InvokeAsync<CheckNoNewAccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CheckNoPublicAccess


        /// <summary>
        /// Checks whether a resource policy can grant public access to the specified resource
        /// type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckNoPublicAccess service method.</param>
        /// 
        /// <returns>The response from the CheckNoPublicAccess service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InvalidParameterException">
        /// The specified parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.UnprocessableEntityException">
        /// The specified entity could not be processed.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CheckNoPublicAccess">REST API Reference for CheckNoPublicAccess Operation</seealso>
        public virtual CheckNoPublicAccessResponse CheckNoPublicAccess(CheckNoPublicAccessRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CheckNoPublicAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckNoPublicAccessResponseUnmarshaller.Instance;

            return Invoke<CheckNoPublicAccessResponse>(request, options);
        }


        /// <summary>
        /// Checks whether a resource policy can grant public access to the specified resource
        /// type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckNoPublicAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CheckNoPublicAccess service method, as returned by AccessAnalyzer.</returns>
        /// <exception cref="Amazon.AccessAnalyzer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InternalServerException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.InvalidParameterException">
        /// The specified parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.UnprocessableEntityException">
        /// The specified entity could not be processed.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CheckNoPublicAccess">REST API Reference for CheckNoPublicAccess Operation</seealso>
        public virtual Task<CheckNoPublicAccessResponse> CheckNoPublicAccessAsync(CheckNoPublicAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CheckNoPublicAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckNoPublicAccessResponseUnmarshaller.Instance;
            
            return InvokeAsync<CheckNoPublicAccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAccessPreview


        /// <summary>
        /// Creates an access preview that allows you to preview IAM Access Analyzer findings
        /// for your resource before deploying resource permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessPreview service method.</param>
        /// 
        /// <returns>The response from the CreateAccessPreview service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CreateAccessPreview">REST API Reference for CreateAccessPreview Operation</seealso>
        public virtual CreateAccessPreviewResponse CreateAccessPreview(CreateAccessPreviewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAccessPreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessPreviewResponseUnmarshaller.Instance;

            return Invoke<CreateAccessPreviewResponse>(request, options);
        }


        /// <summary>
        /// Creates an access preview that allows you to preview IAM Access Analyzer findings
        /// for your resource before deploying resource permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessPreview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccessPreview service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/CreateAccessPreview">REST API Reference for CreateAccessPreview Operation</seealso>
        public virtual Task<CreateAccessPreviewResponse> CreateAccessPreviewAsync(CreateAccessPreviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAccessPreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessPreviewResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAccessPreviewResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAnalyzer


        /// <summary>
        /// Creates an analyzer for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAnalyzer service method.</param>
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
        public virtual CreateAnalyzerResponse CreateAnalyzer(CreateAnalyzerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAnalyzerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAnalyzerResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAnalyzerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateArchiveRule


        /// <summary>
        /// Creates an archive rule for the specified analyzer. Archive rules automatically archive
        /// new findings that meet the criteria you define when you create the rule.
        /// 
        ///  
        /// <para>
        /// To learn about filter keys that you can use to create an archive rule, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access-analyzer-reference-filter-keys.html">IAM
        /// Access Analyzer filter keys</a> in the <b>IAM User Guide</b>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateArchiveRule service method.</param>
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
        public virtual CreateArchiveRuleResponse CreateArchiveRule(CreateArchiveRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateArchiveRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateArchiveRuleResponseUnmarshaller.Instance;

            return Invoke<CreateArchiveRuleResponse>(request, options);
        }


        /// <summary>
        /// Creates an archive rule for the specified analyzer. Archive rules automatically archive
        /// new findings that meet the criteria you define when you create the rule.
        /// 
        ///  
        /// <para>
        /// To learn about filter keys that you can use to create an archive rule, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access-analyzer-reference-filter-keys.html">IAM
        /// Access Analyzer filter keys</a> in the <b>IAM User Guide</b>.
        /// </para>
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateArchiveRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateArchiveRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateArchiveRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAnalyzer


        /// <summary>
        /// Deletes the specified analyzer. When you delete an analyzer, IAM Access Analyzer is
        /// disabled for the account or organization in the current or specific Region. All findings
        /// that were generated by the analyzer are deleted. You cannot undo this action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnalyzer service method.</param>
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
        public virtual DeleteAnalyzerResponse DeleteAnalyzer(DeleteAnalyzerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAnalyzerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnalyzerResponseUnmarshaller.Instance;

            return Invoke<DeleteAnalyzerResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified analyzer. When you delete an analyzer, IAM Access Analyzer is
        /// disabled for the account or organization in the current or specific Region. All findings
        /// that were generated by the analyzer are deleted. You cannot undo this action.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAnalyzerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnalyzerResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAnalyzerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteArchiveRule


        /// <summary>
        /// Deletes the specified archive rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteArchiveRule service method.</param>
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
        public virtual DeleteArchiveRuleResponse DeleteArchiveRule(DeleteArchiveRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteArchiveRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteArchiveRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteArchiveRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GenerateFindingRecommendation


        /// <summary>
        /// Creates a recommendation for an unused permissions finding.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateFindingRecommendation service method.</param>
        /// 
        /// <returns>The response from the GenerateFindingRecommendation service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GenerateFindingRecommendation">REST API Reference for GenerateFindingRecommendation Operation</seealso>
        public virtual GenerateFindingRecommendationResponse GenerateFindingRecommendation(GenerateFindingRecommendationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GenerateFindingRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateFindingRecommendationResponseUnmarshaller.Instance;

            return Invoke<GenerateFindingRecommendationResponse>(request, options);
        }


        /// <summary>
        /// Creates a recommendation for an unused permissions finding.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateFindingRecommendation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateFindingRecommendation service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GenerateFindingRecommendation">REST API Reference for GenerateFindingRecommendation Operation</seealso>
        public virtual Task<GenerateFindingRecommendationResponse> GenerateFindingRecommendationAsync(GenerateFindingRecommendationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GenerateFindingRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateFindingRecommendationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GenerateFindingRecommendationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccessPreview


        /// <summary>
        /// Retrieves information about an access preview for the specified analyzer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPreview service method.</param>
        /// 
        /// <returns>The response from the GetAccessPreview service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetAccessPreview">REST API Reference for GetAccessPreview Operation</seealso>
        public virtual GetAccessPreviewResponse GetAccessPreview(GetAccessPreviewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccessPreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessPreviewResponseUnmarshaller.Instance;

            return Invoke<GetAccessPreviewResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about an access preview for the specified analyzer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPreview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessPreview service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetAccessPreview">REST API Reference for GetAccessPreview Operation</seealso>
        public virtual Task<GetAccessPreviewResponse> GetAccessPreviewAsync(GetAccessPreviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccessPreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessPreviewResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAccessPreviewResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAnalyzedResource


        /// <summary>
        /// Retrieves information about a resource that was analyzed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnalyzedResource service method.</param>
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
        public virtual GetAnalyzedResourceResponse GetAnalyzedResource(GetAnalyzedResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAnalyzedResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnalyzedResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAnalyzedResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAnalyzer


        /// <summary>
        /// Retrieves information about the specified analyzer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnalyzer service method.</param>
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
        public virtual GetAnalyzerResponse GetAnalyzer(GetAnalyzerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAnalyzerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnalyzerResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAnalyzerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetArchiveRule


        /// <summary>
        /// Retrieves information about an archive rule.
        /// 
        ///  
        /// <para>
        /// To learn about filter keys that you can use to create an archive rule, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access-analyzer-reference-filter-keys.html">IAM
        /// Access Analyzer filter keys</a> in the <b>IAM User Guide</b>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveRule service method.</param>
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
        public virtual GetArchiveRuleResponse GetArchiveRule(GetArchiveRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetArchiveRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArchiveRuleResponseUnmarshaller.Instance;

            return Invoke<GetArchiveRuleResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about an archive rule.
        /// 
        ///  
        /// <para>
        /// To learn about filter keys that you can use to create an archive rule, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access-analyzer-reference-filter-keys.html">IAM
        /// Access Analyzer filter keys</a> in the <b>IAM User Guide</b>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetArchiveRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArchiveRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetArchiveRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFinding


        /// <summary>
        /// Retrieves information about the specified finding. GetFinding and GetFindingV2 both
        /// use <c>access-analyzer:GetFinding</c> in the <c>Action</c> element of an IAM policy
        /// statement. You must have permission to perform the <c>access-analyzer:GetFinding</c>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFinding service method.</param>
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
        public virtual GetFindingResponse GetFinding(GetFindingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingResponseUnmarshaller.Instance;

            return Invoke<GetFindingResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about the specified finding. GetFinding and GetFindingV2 both
        /// use <c>access-analyzer:GetFinding</c> in the <c>Action</c> element of an IAM policy
        /// statement. You must have permission to perform the <c>access-analyzer:GetFinding</c>
        /// action.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetFindingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFindingRecommendation


        /// <summary>
        /// Retrieves information about a finding recommendation for the specified analyzer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingRecommendation service method.</param>
        /// 
        /// <returns>The response from the GetFindingRecommendation service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetFindingRecommendation">REST API Reference for GetFindingRecommendation Operation</seealso>
        public virtual GetFindingRecommendationResponse GetFindingRecommendation(GetFindingRecommendationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFindingRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingRecommendationResponseUnmarshaller.Instance;

            return Invoke<GetFindingRecommendationResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about a finding recommendation for the specified analyzer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingRecommendation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFindingRecommendation service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetFindingRecommendation">REST API Reference for GetFindingRecommendation Operation</seealso>
        public virtual Task<GetFindingRecommendationResponse> GetFindingRecommendationAsync(GetFindingRecommendationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFindingRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingRecommendationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetFindingRecommendationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFindingsStatistics


        /// <summary>
        /// Retrieves a list of aggregated finding statistics for an external access or unused
        /// access analyzer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsStatistics service method.</param>
        /// 
        /// <returns>The response from the GetFindingsStatistics service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetFindingsStatistics">REST API Reference for GetFindingsStatistics Operation</seealso>
        public virtual GetFindingsStatisticsResponse GetFindingsStatistics(GetFindingsStatisticsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFindingsStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingsStatisticsResponseUnmarshaller.Instance;

            return Invoke<GetFindingsStatisticsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of aggregated finding statistics for an external access or unused
        /// access analyzer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFindingsStatistics service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetFindingsStatistics">REST API Reference for GetFindingsStatistics Operation</seealso>
        public virtual Task<GetFindingsStatisticsResponse> GetFindingsStatisticsAsync(GetFindingsStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFindingsStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingsStatisticsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetFindingsStatisticsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFindingV2


        /// <summary>
        /// Retrieves information about the specified finding. GetFinding and GetFindingV2 both
        /// use <c>access-analyzer:GetFinding</c> in the <c>Action</c> element of an IAM policy
        /// statement. You must have permission to perform the <c>access-analyzer:GetFinding</c>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingV2 service method.</param>
        /// 
        /// <returns>The response from the GetFindingV2 service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetFindingV2">REST API Reference for GetFindingV2 Operation</seealso>
        public virtual GetFindingV2Response GetFindingV2(GetFindingV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFindingV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingV2ResponseUnmarshaller.Instance;

            return Invoke<GetFindingV2Response>(request, options);
        }


        /// <summary>
        /// Retrieves information about the specified finding. GetFinding and GetFindingV2 both
        /// use <c>access-analyzer:GetFinding</c> in the <c>Action</c> element of an IAM policy
        /// statement. You must have permission to perform the <c>access-analyzer:GetFinding</c>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFindingV2 service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetFindingV2">REST API Reference for GetFindingV2 Operation</seealso>
        public virtual Task<GetFindingV2Response> GetFindingV2Async(GetFindingV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFindingV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingV2ResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetFindingV2Response>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetGeneratedPolicy


        /// <summary>
        /// Retrieves the policy that was generated using <c>StartPolicyGeneration</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGeneratedPolicy service method.</param>
        /// 
        /// <returns>The response from the GetGeneratedPolicy service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetGeneratedPolicy">REST API Reference for GetGeneratedPolicy Operation</seealso>
        public virtual GetGeneratedPolicyResponse GetGeneratedPolicy(GetGeneratedPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGeneratedPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGeneratedPolicyResponseUnmarshaller.Instance;

            return Invoke<GetGeneratedPolicyResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the policy that was generated using <c>StartPolicyGeneration</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGeneratedPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGeneratedPolicy service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/GetGeneratedPolicy">REST API Reference for GetGeneratedPolicy Operation</seealso>
        public virtual Task<GetGeneratedPolicyResponse> GetGeneratedPolicyAsync(GetGeneratedPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGeneratedPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGeneratedPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetGeneratedPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAccessPreviewFindings


        /// <summary>
        /// Retrieves a list of access preview findings generated by the specified access preview.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPreviewFindings service method.</param>
        /// 
        /// <returns>The response from the ListAccessPreviewFindings service method, as returned by AccessAnalyzer.</returns>
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
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListAccessPreviewFindings">REST API Reference for ListAccessPreviewFindings Operation</seealso>
        public virtual ListAccessPreviewFindingsResponse ListAccessPreviewFindings(ListAccessPreviewFindingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccessPreviewFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessPreviewFindingsResponseUnmarshaller.Instance;

            return Invoke<ListAccessPreviewFindingsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of access preview findings generated by the specified access preview.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPreviewFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccessPreviewFindings service method, as returned by AccessAnalyzer.</returns>
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
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListAccessPreviewFindings">REST API Reference for ListAccessPreviewFindings Operation</seealso>
        public virtual Task<ListAccessPreviewFindingsResponse> ListAccessPreviewFindingsAsync(ListAccessPreviewFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccessPreviewFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessPreviewFindingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAccessPreviewFindingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAccessPreviews


        /// <summary>
        /// Retrieves a list of access previews for the specified analyzer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPreviews service method.</param>
        /// 
        /// <returns>The response from the ListAccessPreviews service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListAccessPreviews">REST API Reference for ListAccessPreviews Operation</seealso>
        public virtual ListAccessPreviewsResponse ListAccessPreviews(ListAccessPreviewsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccessPreviewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessPreviewsResponseUnmarshaller.Instance;

            return Invoke<ListAccessPreviewsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of access previews for the specified analyzer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPreviews service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccessPreviews service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListAccessPreviews">REST API Reference for ListAccessPreviews Operation</seealso>
        public virtual Task<ListAccessPreviewsResponse> ListAccessPreviewsAsync(ListAccessPreviewsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccessPreviewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessPreviewsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAccessPreviewsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAnalyzedResources


        /// <summary>
        /// Retrieves a list of resources of the specified type that have been analyzed by the
        /// specified analyzer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnalyzedResources service method.</param>
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
        public virtual ListAnalyzedResourcesResponse ListAnalyzedResources(ListAnalyzedResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnalyzedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnalyzedResourcesResponseUnmarshaller.Instance;

            return Invoke<ListAnalyzedResourcesResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of resources of the specified type that have been analyzed by the
        /// specified analyzer.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnalyzedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnalyzedResourcesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAnalyzedResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAnalyzers


        /// <summary>
        /// Retrieves a list of analyzers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnalyzers service method.</param>
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
        public virtual ListAnalyzersResponse ListAnalyzers(ListAnalyzersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnalyzersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnalyzersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAnalyzersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListArchiveRules


        /// <summary>
        /// Retrieves a list of archive rules created for the specified analyzer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArchiveRules service method.</param>
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
        public virtual ListArchiveRulesResponse ListArchiveRules(ListArchiveRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListArchiveRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListArchiveRulesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListArchiveRulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFindings


        /// <summary>
        /// Retrieves a list of findings generated by the specified analyzer. ListFindings and
        /// ListFindingsV2 both use <c>access-analyzer:ListFindings</c> in the <c>Action</c> element
        /// of an IAM policy statement. You must have permission to perform the <c>access-analyzer:ListFindings</c>
        /// action.
        /// 
        ///  
        /// <para>
        /// To learn about filter keys that you can use to retrieve a list of findings, see <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access-analyzer-reference-filter-keys.html">IAM
        /// Access Analyzer filter keys</a> in the <b>IAM User Guide</b>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindings service method.</param>
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
        public virtual ListFindingsResponse ListFindings(ListFindingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingsResponseUnmarshaller.Instance;

            return Invoke<ListFindingsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of findings generated by the specified analyzer. ListFindings and
        /// ListFindingsV2 both use <c>access-analyzer:ListFindings</c> in the <c>Action</c> element
        /// of an IAM policy statement. You must have permission to perform the <c>access-analyzer:ListFindings</c>
        /// action.
        /// 
        ///  
        /// <para>
        /// To learn about filter keys that you can use to retrieve a list of findings, see <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access-analyzer-reference-filter-keys.html">IAM
        /// Access Analyzer filter keys</a> in the <b>IAM User Guide</b>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFindingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFindingsV2


        /// <summary>
        /// Retrieves a list of findings generated by the specified analyzer. ListFindings and
        /// ListFindingsV2 both use <c>access-analyzer:ListFindings</c> in the <c>Action</c> element
        /// of an IAM policy statement. You must have permission to perform the <c>access-analyzer:ListFindings</c>
        /// action.
        /// 
        ///  
        /// <para>
        /// To learn about filter keys that you can use to retrieve a list of findings, see <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access-analyzer-reference-filter-keys.html">IAM
        /// Access Analyzer filter keys</a> in the <b>IAM User Guide</b>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindingsV2 service method.</param>
        /// 
        /// <returns>The response from the ListFindingsV2 service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListFindingsV2">REST API Reference for ListFindingsV2 Operation</seealso>
        public virtual ListFindingsV2Response ListFindingsV2(ListFindingsV2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFindingsV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingsV2ResponseUnmarshaller.Instance;

            return Invoke<ListFindingsV2Response>(request, options);
        }


        /// <summary>
        /// Retrieves a list of findings generated by the specified analyzer. ListFindings and
        /// ListFindingsV2 both use <c>access-analyzer:ListFindings</c> in the <c>Action</c> element
        /// of an IAM policy statement. You must have permission to perform the <c>access-analyzer:ListFindings</c>
        /// action.
        /// 
        ///  
        /// <para>
        /// To learn about filter keys that you can use to retrieve a list of findings, see <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access-analyzer-reference-filter-keys.html">IAM
        /// Access Analyzer filter keys</a> in the <b>IAM User Guide</b>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindingsV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFindingsV2 service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListFindingsV2">REST API Reference for ListFindingsV2 Operation</seealso>
        public virtual Task<ListFindingsV2Response> ListFindingsV2Async(ListFindingsV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFindingsV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingsV2ResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFindingsV2Response>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPolicyGenerations


        /// <summary>
        /// Lists all of the policy generations requested in the last seven days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyGenerations service method.</param>
        /// 
        /// <returns>The response from the ListPolicyGenerations service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListPolicyGenerations">REST API Reference for ListPolicyGenerations Operation</seealso>
        public virtual ListPolicyGenerationsResponse ListPolicyGenerations(ListPolicyGenerationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPolicyGenerationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicyGenerationsResponseUnmarshaller.Instance;

            return Invoke<ListPolicyGenerationsResponse>(request, options);
        }


        /// <summary>
        /// Lists all of the policy generations requested in the last seven days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyGenerations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPolicyGenerations service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ListPolicyGenerations">REST API Reference for ListPolicyGenerations Operation</seealso>
        public virtual Task<ListPolicyGenerationsResponse> ListPolicyGenerationsAsync(ListPolicyGenerationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPolicyGenerationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicyGenerationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPolicyGenerationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Retrieves a list of tags applied to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartPolicyGeneration


        /// <summary>
        /// Starts the policy generation request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPolicyGeneration service method.</param>
        /// 
        /// <returns>The response from the StartPolicyGeneration service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/StartPolicyGeneration">REST API Reference for StartPolicyGeneration Operation</seealso>
        public virtual StartPolicyGenerationResponse StartPolicyGeneration(StartPolicyGenerationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartPolicyGenerationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPolicyGenerationResponseUnmarshaller.Instance;

            return Invoke<StartPolicyGenerationResponse>(request, options);
        }


        /// <summary>
        /// Starts the policy generation request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPolicyGeneration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartPolicyGeneration service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/StartPolicyGeneration">REST API Reference for StartPolicyGeneration Operation</seealso>
        public virtual Task<StartPolicyGenerationResponse> StartPolicyGenerationAsync(StartPolicyGenerationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartPolicyGenerationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPolicyGenerationResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartPolicyGenerationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartResourceScan


        /// <summary>
        /// Immediately starts a scan of the policies applied to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartResourceScan service method.</param>
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
        public virtual StartResourceScanResponse StartResourceScan(StartResourceScanRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartResourceScanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartResourceScanResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartResourceScanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds a tag to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAnalyzer


        /// <summary>
        /// Modifies the configuration of an existing analyzer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnalyzer service method.</param>
        /// 
        /// <returns>The response from the UpdateAnalyzer service method, as returned by AccessAnalyzer.</returns>
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
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/UpdateAnalyzer">REST API Reference for UpdateAnalyzer Operation</seealso>
        public virtual UpdateAnalyzerResponse UpdateAnalyzer(UpdateAnalyzerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAnalyzerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAnalyzerResponseUnmarshaller.Instance;

            return Invoke<UpdateAnalyzerResponse>(request, options);
        }


        /// <summary>
        /// Modifies the configuration of an existing analyzer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnalyzer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAnalyzer service method, as returned by AccessAnalyzer.</returns>
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
        /// <exception cref="Amazon.AccessAnalyzer.Model.ThrottlingException">
        /// Throttling limit exceeded error.
        /// </exception>
        /// <exception cref="Amazon.AccessAnalyzer.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/UpdateAnalyzer">REST API Reference for UpdateAnalyzer Operation</seealso>
        public virtual Task<UpdateAnalyzerResponse> UpdateAnalyzerAsync(UpdateAnalyzerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAnalyzerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAnalyzerResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAnalyzerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateArchiveRule


        /// <summary>
        /// Updates the criteria and values for the specified archive rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateArchiveRule service method.</param>
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
        public virtual UpdateArchiveRuleResponse UpdateArchiveRule(UpdateArchiveRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateArchiveRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateArchiveRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateArchiveRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFindings


        /// <summary>
        /// Updates the status for the specified findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFindings service method.</param>
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
        public virtual UpdateFindingsResponse UpdateFindings(UpdateFindingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFindingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateFindingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ValidatePolicy


        /// <summary>
        /// Requests the validation of a policy and returns a list of findings. The findings help
        /// you identify issues and provide actionable recommendations to resolve the issue and
        /// enable you to author functional policies that meet security best practices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidatePolicy service method.</param>
        /// 
        /// <returns>The response from the ValidatePolicy service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ValidatePolicy">REST API Reference for ValidatePolicy Operation</seealso>
        public virtual ValidatePolicyResponse ValidatePolicy(ValidatePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ValidatePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidatePolicyResponseUnmarshaller.Instance;

            return Invoke<ValidatePolicyResponse>(request, options);
        }


        /// <summary>
        /// Requests the validation of a policy and returns a list of findings. The findings help
        /// you identify issues and provide actionable recommendations to resolve the issue and
        /// enable you to author functional policies that meet security best practices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidatePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ValidatePolicy service method, as returned by AccessAnalyzer.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/accessanalyzer-2019-11-01/ValidatePolicy">REST API Reference for ValidatePolicy Operation</seealso>
        public virtual Task<ValidatePolicyResponse> ValidatePolicyAsync(ValidatePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ValidatePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidatePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<ValidatePolicyResponse>(request, options, cancellationToken);
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