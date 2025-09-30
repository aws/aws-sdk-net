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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Inspector2.Model;
using Amazon.Inspector2.Model.Internal.MarshallTransformations;
using Amazon.Inspector2.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Inspector2
{
    /// <summary>
    /// <para>Implementation for accessing Inspector2</para>
    ///
    /// Amazon Inspector is a vulnerability discovery service that automates continuous scanning
    /// for security vulnerabilities within your Amazon EC2, Amazon ECR, and Amazon Web Services
    /// Lambda environments.
    /// </summary>
    public partial class AmazonInspector2Client : AmazonServiceClient, IAmazonInspector2
    {
        private static IServiceMetadata serviceMetadata = new AmazonInspector2Metadata();
        private IInspector2PaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IInspector2PaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new Inspector2PaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonInspector2Client with the credentials loaded from the application's
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
        public AmazonInspector2Client()
            : base(new AmazonInspector2Config()) { }

        /// <summary>
        /// Constructs AmazonInspector2Client with the credentials loaded from the application's
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
        public AmazonInspector2Client(RegionEndpoint region)
            : base(new AmazonInspector2Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonInspector2Client with the credentials loaded from the application's
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
        /// <param name="config">The AmazonInspector2Client Configuration Object</param>
        public AmazonInspector2Client(AmazonInspector2Config config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonInspector2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonInspector2Client(AWSCredentials credentials)
            : this(credentials, new AmazonInspector2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonInspector2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonInspector2Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonInspector2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonInspector2Client with AWS Credentials and an
        /// AmazonInspector2Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonInspector2Client Configuration Object</param>
        public AmazonInspector2Client(AWSCredentials credentials, AmazonInspector2Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonInspector2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonInspector2Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonInspector2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonInspector2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonInspector2Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonInspector2Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonInspector2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonInspector2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonInspector2Client Configuration Object</param>
        public AmazonInspector2Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonInspector2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonInspector2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonInspector2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonInspector2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonInspector2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonInspector2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonInspector2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonInspector2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonInspector2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonInspector2Client Configuration Object</param>
        public AmazonInspector2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonInspector2Config clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonInspector2EndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonInspector2AuthSchemeHandler());
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


        #region  AssociateMember


        /// <summary>
        /// Associates an Amazon Web Services account with an Amazon Inspector delegated administrator.
        /// An HTTP 200 response indicates the association was successfully started, but doesn’t
        /// indicate whether it was completed. You can check if the association completed by using
        /// <a href="https://docs.aws.amazon.com/inspector/v2/APIReference/API_ListMembers.html">ListMembers</a>
        /// for multiple accounts or <a href="https://docs.aws.amazon.com/inspector/v2/APIReference/API_GetMember.html">GetMembers</a>
        /// for a single account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMember service method.</param>
        /// 
        /// <returns>The response from the AssociateMember service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/AssociateMember">REST API Reference for AssociateMember Operation</seealso>
        public virtual AssociateMemberResponse AssociateMember(AssociateMemberRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateMemberResponseUnmarshaller.Instance;

            return Invoke<AssociateMemberResponse>(request, options);
        }


        /// <summary>
        /// Associates an Amazon Web Services account with an Amazon Inspector delegated administrator.
        /// An HTTP 200 response indicates the association was successfully started, but doesn’t
        /// indicate whether it was completed. You can check if the association completed by using
        /// <a href="https://docs.aws.amazon.com/inspector/v2/APIReference/API_ListMembers.html">ListMembers</a>
        /// for multiple accounts or <a href="https://docs.aws.amazon.com/inspector/v2/APIReference/API_GetMember.html">GetMembers</a>
        /// for a single account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateMember service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/AssociateMember">REST API Reference for AssociateMember Operation</seealso>
        public virtual Task<AssociateMemberResponse> AssociateMemberAsync(AssociateMemberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateMemberResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateMemberResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchAssociateCodeSecurityScanConfiguration


        /// <summary>
        /// Associates multiple code repositories with an Amazon Inspector code security scan
        /// configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateCodeSecurityScanConfiguration service method.</param>
        /// 
        /// <returns>The response from the BatchAssociateCodeSecurityScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchAssociateCodeSecurityScanConfiguration">REST API Reference for BatchAssociateCodeSecurityScanConfiguration Operation</seealso>
        public virtual BatchAssociateCodeSecurityScanConfigurationResponse BatchAssociateCodeSecurityScanConfiguration(BatchAssociateCodeSecurityScanConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchAssociateCodeSecurityScanConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateCodeSecurityScanConfigurationResponseUnmarshaller.Instance;

            return Invoke<BatchAssociateCodeSecurityScanConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Associates multiple code repositories with an Amazon Inspector code security scan
        /// configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateCodeSecurityScanConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchAssociateCodeSecurityScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchAssociateCodeSecurityScanConfiguration">REST API Reference for BatchAssociateCodeSecurityScanConfiguration Operation</seealso>
        public virtual Task<BatchAssociateCodeSecurityScanConfigurationResponse> BatchAssociateCodeSecurityScanConfigurationAsync(BatchAssociateCodeSecurityScanConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchAssociateCodeSecurityScanConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateCodeSecurityScanConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchAssociateCodeSecurityScanConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDisassociateCodeSecurityScanConfiguration


        /// <summary>
        /// Disassociates multiple code repositories from an Amazon Inspector code security scan
        /// configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateCodeSecurityScanConfiguration service method.</param>
        /// 
        /// <returns>The response from the BatchDisassociateCodeSecurityScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchDisassociateCodeSecurityScanConfiguration">REST API Reference for BatchDisassociateCodeSecurityScanConfiguration Operation</seealso>
        public virtual BatchDisassociateCodeSecurityScanConfigurationResponse BatchDisassociateCodeSecurityScanConfiguration(BatchDisassociateCodeSecurityScanConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDisassociateCodeSecurityScanConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateCodeSecurityScanConfigurationResponseUnmarshaller.Instance;

            return Invoke<BatchDisassociateCodeSecurityScanConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Disassociates multiple code repositories from an Amazon Inspector code security scan
        /// configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateCodeSecurityScanConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDisassociateCodeSecurityScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchDisassociateCodeSecurityScanConfiguration">REST API Reference for BatchDisassociateCodeSecurityScanConfiguration Operation</seealso>
        public virtual Task<BatchDisassociateCodeSecurityScanConfigurationResponse> BatchDisassociateCodeSecurityScanConfigurationAsync(BatchDisassociateCodeSecurityScanConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDisassociateCodeSecurityScanConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateCodeSecurityScanConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchDisassociateCodeSecurityScanConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetAccountStatus


        /// <summary>
        /// Retrieves the Amazon Inspector status of multiple Amazon Web Services accounts within
        /// your environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetAccountStatus service method.</param>
        /// 
        /// <returns>The response from the BatchGetAccountStatus service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetAccountStatus">REST API Reference for BatchGetAccountStatus Operation</seealso>
        public virtual BatchGetAccountStatusResponse BatchGetAccountStatus(BatchGetAccountStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetAccountStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetAccountStatusResponseUnmarshaller.Instance;

            return Invoke<BatchGetAccountStatusResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the Amazon Inspector status of multiple Amazon Web Services accounts within
        /// your environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetAccountStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetAccountStatus service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetAccountStatus">REST API Reference for BatchGetAccountStatus Operation</seealso>
        public virtual Task<BatchGetAccountStatusResponse> BatchGetAccountStatusAsync(BatchGetAccountStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetAccountStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetAccountStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchGetAccountStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetCodeSnippet


        /// <summary>
        /// Retrieves code snippets from findings that Amazon Inspector detected code vulnerabilities
        /// in.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCodeSnippet service method.</param>
        /// 
        /// <returns>The response from the BatchGetCodeSnippet service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetCodeSnippet">REST API Reference for BatchGetCodeSnippet Operation</seealso>
        public virtual BatchGetCodeSnippetResponse BatchGetCodeSnippet(BatchGetCodeSnippetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetCodeSnippetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetCodeSnippetResponseUnmarshaller.Instance;

            return Invoke<BatchGetCodeSnippetResponse>(request, options);
        }


        /// <summary>
        /// Retrieves code snippets from findings that Amazon Inspector detected code vulnerabilities
        /// in.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCodeSnippet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetCodeSnippet service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetCodeSnippet">REST API Reference for BatchGetCodeSnippet Operation</seealso>
        public virtual Task<BatchGetCodeSnippetResponse> BatchGetCodeSnippetAsync(BatchGetCodeSnippetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetCodeSnippetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetCodeSnippetResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchGetCodeSnippetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetFindingDetails


        /// <summary>
        /// Gets vulnerability details for findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetFindingDetails service method.</param>
        /// 
        /// <returns>The response from the BatchGetFindingDetails service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetFindingDetails">REST API Reference for BatchGetFindingDetails Operation</seealso>
        public virtual BatchGetFindingDetailsResponse BatchGetFindingDetails(BatchGetFindingDetailsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetFindingDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetFindingDetailsResponseUnmarshaller.Instance;

            return Invoke<BatchGetFindingDetailsResponse>(request, options);
        }


        /// <summary>
        /// Gets vulnerability details for findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetFindingDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetFindingDetails service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetFindingDetails">REST API Reference for BatchGetFindingDetails Operation</seealso>
        public virtual Task<BatchGetFindingDetailsResponse> BatchGetFindingDetailsAsync(BatchGetFindingDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetFindingDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetFindingDetailsResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchGetFindingDetailsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetFreeTrialInfo


        /// <summary>
        /// Gets free trial status for multiple Amazon Web Services accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetFreeTrialInfo service method.</param>
        /// 
        /// <returns>The response from the BatchGetFreeTrialInfo service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetFreeTrialInfo">REST API Reference for BatchGetFreeTrialInfo Operation</seealso>
        public virtual BatchGetFreeTrialInfoResponse BatchGetFreeTrialInfo(BatchGetFreeTrialInfoRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetFreeTrialInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetFreeTrialInfoResponseUnmarshaller.Instance;

            return Invoke<BatchGetFreeTrialInfoResponse>(request, options);
        }


        /// <summary>
        /// Gets free trial status for multiple Amazon Web Services accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetFreeTrialInfo service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetFreeTrialInfo service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetFreeTrialInfo">REST API Reference for BatchGetFreeTrialInfo Operation</seealso>
        public virtual Task<BatchGetFreeTrialInfoResponse> BatchGetFreeTrialInfoAsync(BatchGetFreeTrialInfoRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetFreeTrialInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetFreeTrialInfoResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchGetFreeTrialInfoResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetMemberEc2DeepInspectionStatus


        /// <summary>
        /// Retrieves Amazon Inspector deep inspection activation status of multiple member accounts
        /// within your organization. You must be the delegated administrator of an organization
        /// in Amazon Inspector to use this API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetMemberEc2DeepInspectionStatus service method.</param>
        /// 
        /// <returns>The response from the BatchGetMemberEc2DeepInspectionStatus service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetMemberEc2DeepInspectionStatus">REST API Reference for BatchGetMemberEc2DeepInspectionStatus Operation</seealso>
        public virtual BatchGetMemberEc2DeepInspectionStatusResponse BatchGetMemberEc2DeepInspectionStatus(BatchGetMemberEc2DeepInspectionStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetMemberEc2DeepInspectionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetMemberEc2DeepInspectionStatusResponseUnmarshaller.Instance;

            return Invoke<BatchGetMemberEc2DeepInspectionStatusResponse>(request, options);
        }


        /// <summary>
        /// Retrieves Amazon Inspector deep inspection activation status of multiple member accounts
        /// within your organization. You must be the delegated administrator of an organization
        /// in Amazon Inspector to use this API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetMemberEc2DeepInspectionStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetMemberEc2DeepInspectionStatus service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchGetMemberEc2DeepInspectionStatus">REST API Reference for BatchGetMemberEc2DeepInspectionStatus Operation</seealso>
        public virtual Task<BatchGetMemberEc2DeepInspectionStatusResponse> BatchGetMemberEc2DeepInspectionStatusAsync(BatchGetMemberEc2DeepInspectionStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetMemberEc2DeepInspectionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetMemberEc2DeepInspectionStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchGetMemberEc2DeepInspectionStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchUpdateMemberEc2DeepInspectionStatus


        /// <summary>
        /// Activates or deactivates Amazon Inspector deep inspection for the provided member
        /// accounts in your organization. You must be the delegated administrator of an organization
        /// in Amazon Inspector to use this API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateMemberEc2DeepInspectionStatus service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateMemberEc2DeepInspectionStatus service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchUpdateMemberEc2DeepInspectionStatus">REST API Reference for BatchUpdateMemberEc2DeepInspectionStatus Operation</seealso>
        public virtual BatchUpdateMemberEc2DeepInspectionStatusResponse BatchUpdateMemberEc2DeepInspectionStatus(BatchUpdateMemberEc2DeepInspectionStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateMemberEc2DeepInspectionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateMemberEc2DeepInspectionStatusResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateMemberEc2DeepInspectionStatusResponse>(request, options);
        }


        /// <summary>
        /// Activates or deactivates Amazon Inspector deep inspection for the provided member
        /// accounts in your organization. You must be the delegated administrator of an organization
        /// in Amazon Inspector to use this API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateMemberEc2DeepInspectionStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdateMemberEc2DeepInspectionStatus service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/BatchUpdateMemberEc2DeepInspectionStatus">REST API Reference for BatchUpdateMemberEc2DeepInspectionStatus Operation</seealso>
        public virtual Task<BatchUpdateMemberEc2DeepInspectionStatusResponse> BatchUpdateMemberEc2DeepInspectionStatusAsync(BatchUpdateMemberEc2DeepInspectionStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateMemberEc2DeepInspectionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateMemberEc2DeepInspectionStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchUpdateMemberEc2DeepInspectionStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelFindingsReport


        /// <summary>
        /// Cancels the given findings report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelFindingsReport service method.</param>
        /// 
        /// <returns>The response from the CancelFindingsReport service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CancelFindingsReport">REST API Reference for CancelFindingsReport Operation</seealso>
        public virtual CancelFindingsReportResponse CancelFindingsReport(CancelFindingsReportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelFindingsReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelFindingsReportResponseUnmarshaller.Instance;

            return Invoke<CancelFindingsReportResponse>(request, options);
        }


        /// <summary>
        /// Cancels the given findings report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelFindingsReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelFindingsReport service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CancelFindingsReport">REST API Reference for CancelFindingsReport Operation</seealso>
        public virtual Task<CancelFindingsReportResponse> CancelFindingsReportAsync(CancelFindingsReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelFindingsReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelFindingsReportResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelFindingsReportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelSbomExport


        /// <summary>
        /// Cancels a software bill of materials (SBOM) report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSbomExport service method.</param>
        /// 
        /// <returns>The response from the CancelSbomExport service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CancelSbomExport">REST API Reference for CancelSbomExport Operation</seealso>
        public virtual CancelSbomExportResponse CancelSbomExport(CancelSbomExportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelSbomExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSbomExportResponseUnmarshaller.Instance;

            return Invoke<CancelSbomExportResponse>(request, options);
        }


        /// <summary>
        /// Cancels a software bill of materials (SBOM) report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSbomExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelSbomExport service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CancelSbomExport">REST API Reference for CancelSbomExport Operation</seealso>
        public virtual Task<CancelSbomExportResponse> CancelSbomExportAsync(CancelSbomExportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelSbomExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSbomExportResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelSbomExportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCisScanConfiguration


        /// <summary>
        /// Creates a CIS scan configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCisScanConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateCisScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateCisScanConfiguration">REST API Reference for CreateCisScanConfiguration Operation</seealso>
        public virtual CreateCisScanConfigurationResponse CreateCisScanConfiguration(CreateCisScanConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCisScanConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCisScanConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateCisScanConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Creates a CIS scan configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCisScanConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCisScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateCisScanConfiguration">REST API Reference for CreateCisScanConfiguration Operation</seealso>
        public virtual Task<CreateCisScanConfigurationResponse> CreateCisScanConfigurationAsync(CreateCisScanConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCisScanConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCisScanConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateCisScanConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCodeSecurityIntegration


        /// <summary>
        /// Creates a code security integration with a source code repository provider.
        /// 
        ///  
        /// <para>
        /// After calling the <c>CreateCodeSecurityIntegration</c> operation, you complete authentication
        /// and authorization with your provider. Next you call the <c>UpdateCodeSecurityIntegration</c>
        /// operation to provide the <c>details</c> to complete the integration setup
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeSecurityIntegration service method.</param>
        /// 
        /// <returns>The response from the CreateCodeSecurityIntegration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateCodeSecurityIntegration">REST API Reference for CreateCodeSecurityIntegration Operation</seealso>
        public virtual CreateCodeSecurityIntegrationResponse CreateCodeSecurityIntegration(CreateCodeSecurityIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCodeSecurityIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCodeSecurityIntegrationResponseUnmarshaller.Instance;

            return Invoke<CreateCodeSecurityIntegrationResponse>(request, options);
        }


        /// <summary>
        /// Creates a code security integration with a source code repository provider.
        /// 
        ///  
        /// <para>
        /// After calling the <c>CreateCodeSecurityIntegration</c> operation, you complete authentication
        /// and authorization with your provider. Next you call the <c>UpdateCodeSecurityIntegration</c>
        /// operation to provide the <c>details</c> to complete the integration setup
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeSecurityIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCodeSecurityIntegration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateCodeSecurityIntegration">REST API Reference for CreateCodeSecurityIntegration Operation</seealso>
        public virtual Task<CreateCodeSecurityIntegrationResponse> CreateCodeSecurityIntegrationAsync(CreateCodeSecurityIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCodeSecurityIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCodeSecurityIntegrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateCodeSecurityIntegrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCodeSecurityScanConfiguration


        /// <summary>
        /// Creates a scan configuration for code security scanning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeSecurityScanConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateCodeSecurityScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateCodeSecurityScanConfiguration">REST API Reference for CreateCodeSecurityScanConfiguration Operation</seealso>
        public virtual CreateCodeSecurityScanConfigurationResponse CreateCodeSecurityScanConfiguration(CreateCodeSecurityScanConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCodeSecurityScanConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCodeSecurityScanConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateCodeSecurityScanConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Creates a scan configuration for code security scanning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeSecurityScanConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCodeSecurityScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateCodeSecurityScanConfiguration">REST API Reference for CreateCodeSecurityScanConfiguration Operation</seealso>
        public virtual Task<CreateCodeSecurityScanConfigurationResponse> CreateCodeSecurityScanConfigurationAsync(CreateCodeSecurityScanConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCodeSecurityScanConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCodeSecurityScanConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateCodeSecurityScanConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFilter


        /// <summary>
        /// Creates a filter resource using specified filter criteria. When the filter action
        /// is set to <c>SUPPRESS</c> this action creates a suppression rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFilter service method.</param>
        /// 
        /// <returns>The response from the CreateFilter service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.BadRequestException">
        /// One or more tags submitted as part of the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateFilter">REST API Reference for CreateFilter Operation</seealso>
        public virtual CreateFilterResponse CreateFilter(CreateFilterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFilterResponseUnmarshaller.Instance;

            return Invoke<CreateFilterResponse>(request, options);
        }


        /// <summary>
        /// Creates a filter resource using specified filter criteria. When the filter action
        /// is set to <c>SUPPRESS</c> this action creates a suppression rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFilter service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.BadRequestException">
        /// One or more tags submitted as part of the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateFilter">REST API Reference for CreateFilter Operation</seealso>
        public virtual Task<CreateFilterResponse> CreateFilterAsync(CreateFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFilterResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateFilterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFindingsReport


        /// <summary>
        /// Creates a finding report. By default only <c>ACTIVE</c> findings are returned in the
        /// report. To see <c>SUPRESSED</c> or <c>CLOSED</c> findings you must specify a value
        /// for the <c>findingStatus</c> filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFindingsReport service method.</param>
        /// 
        /// <returns>The response from the CreateFindingsReport service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateFindingsReport">REST API Reference for CreateFindingsReport Operation</seealso>
        public virtual CreateFindingsReportResponse CreateFindingsReport(CreateFindingsReportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFindingsReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFindingsReportResponseUnmarshaller.Instance;

            return Invoke<CreateFindingsReportResponse>(request, options);
        }


        /// <summary>
        /// Creates a finding report. By default only <c>ACTIVE</c> findings are returned in the
        /// report. To see <c>SUPRESSED</c> or <c>CLOSED</c> findings you must specify a value
        /// for the <c>findingStatus</c> filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFindingsReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFindingsReport service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateFindingsReport">REST API Reference for CreateFindingsReport Operation</seealso>
        public virtual Task<CreateFindingsReportResponse> CreateFindingsReportAsync(CreateFindingsReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFindingsReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFindingsReportResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateFindingsReportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSbomExport


        /// <summary>
        /// Creates a software bill of materials (SBOM) report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSbomExport service method.</param>
        /// 
        /// <returns>The response from the CreateSbomExport service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateSbomExport">REST API Reference for CreateSbomExport Operation</seealso>
        public virtual CreateSbomExportResponse CreateSbomExport(CreateSbomExportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSbomExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSbomExportResponseUnmarshaller.Instance;

            return Invoke<CreateSbomExportResponse>(request, options);
        }


        /// <summary>
        /// Creates a software bill of materials (SBOM) report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSbomExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSbomExport service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/CreateSbomExport">REST API Reference for CreateSbomExport Operation</seealso>
        public virtual Task<CreateSbomExportResponse> CreateSbomExportAsync(CreateSbomExportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSbomExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSbomExportResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateSbomExportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCisScanConfiguration


        /// <summary>
        /// Deletes a CIS scan configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCisScanConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteCisScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DeleteCisScanConfiguration">REST API Reference for DeleteCisScanConfiguration Operation</seealso>
        public virtual DeleteCisScanConfigurationResponse DeleteCisScanConfiguration(DeleteCisScanConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCisScanConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCisScanConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteCisScanConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Deletes a CIS scan configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCisScanConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCisScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DeleteCisScanConfiguration">REST API Reference for DeleteCisScanConfiguration Operation</seealso>
        public virtual Task<DeleteCisScanConfigurationResponse> DeleteCisScanConfigurationAsync(DeleteCisScanConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCisScanConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCisScanConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteCisScanConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCodeSecurityIntegration


        /// <summary>
        /// Deletes a code security integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCodeSecurityIntegration service method.</param>
        /// 
        /// <returns>The response from the DeleteCodeSecurityIntegration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DeleteCodeSecurityIntegration">REST API Reference for DeleteCodeSecurityIntegration Operation</seealso>
        public virtual DeleteCodeSecurityIntegrationResponse DeleteCodeSecurityIntegration(DeleteCodeSecurityIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCodeSecurityIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCodeSecurityIntegrationResponseUnmarshaller.Instance;

            return Invoke<DeleteCodeSecurityIntegrationResponse>(request, options);
        }


        /// <summary>
        /// Deletes a code security integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCodeSecurityIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCodeSecurityIntegration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DeleteCodeSecurityIntegration">REST API Reference for DeleteCodeSecurityIntegration Operation</seealso>
        public virtual Task<DeleteCodeSecurityIntegrationResponse> DeleteCodeSecurityIntegrationAsync(DeleteCodeSecurityIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCodeSecurityIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCodeSecurityIntegrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteCodeSecurityIntegrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCodeSecurityScanConfiguration


        /// <summary>
        /// Deletes a code security scan configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCodeSecurityScanConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteCodeSecurityScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DeleteCodeSecurityScanConfiguration">REST API Reference for DeleteCodeSecurityScanConfiguration Operation</seealso>
        public virtual DeleteCodeSecurityScanConfigurationResponse DeleteCodeSecurityScanConfiguration(DeleteCodeSecurityScanConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCodeSecurityScanConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCodeSecurityScanConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteCodeSecurityScanConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Deletes a code security scan configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCodeSecurityScanConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCodeSecurityScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DeleteCodeSecurityScanConfiguration">REST API Reference for DeleteCodeSecurityScanConfiguration Operation</seealso>
        public virtual Task<DeleteCodeSecurityScanConfigurationResponse> DeleteCodeSecurityScanConfigurationAsync(DeleteCodeSecurityScanConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCodeSecurityScanConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCodeSecurityScanConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteCodeSecurityScanConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFilter


        /// <summary>
        /// Deletes a filter resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFilter service method.</param>
        /// 
        /// <returns>The response from the DeleteFilter service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DeleteFilter">REST API Reference for DeleteFilter Operation</seealso>
        public virtual DeleteFilterResponse DeleteFilter(DeleteFilterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFilterResponseUnmarshaller.Instance;

            return Invoke<DeleteFilterResponse>(request, options);
        }


        /// <summary>
        /// Deletes a filter resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFilter service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DeleteFilter">REST API Reference for DeleteFilter Operation</seealso>
        public virtual Task<DeleteFilterResponse> DeleteFilterAsync(DeleteFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFilterResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteFilterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeOrganizationConfiguration


        /// <summary>
        /// Describe Amazon Inspector configuration settings for an Amazon Web Services organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeOrganizationConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DescribeOrganizationConfiguration">REST API Reference for DescribeOrganizationConfiguration Operation</seealso>
        public virtual DescribeOrganizationConfigurationResponse DescribeOrganizationConfiguration(DescribeOrganizationConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOrganizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrganizationConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeOrganizationConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Describe Amazon Inspector configuration settings for an Amazon Web Services organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOrganizationConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DescribeOrganizationConfiguration">REST API Reference for DescribeOrganizationConfiguration Operation</seealso>
        public virtual Task<DescribeOrganizationConfigurationResponse> DescribeOrganizationConfigurationAsync(DescribeOrganizationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOrganizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrganizationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeOrganizationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Disable


        /// <summary>
        /// Disables Amazon Inspector scans for one or more Amazon Web Services accounts. Disabling
        /// all scan types in an account disables the Amazon Inspector service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Disable service method.</param>
        /// 
        /// <returns>The response from the Disable service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/Disable">REST API Reference for Disable Operation</seealso>
        public virtual DisableResponse Disable(DisableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableResponseUnmarshaller.Instance;

            return Invoke<DisableResponse>(request, options);
        }


        /// <summary>
        /// Disables Amazon Inspector scans for one or more Amazon Web Services accounts. Disabling
        /// all scan types in an account disables the Amazon Inspector service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Disable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Disable service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/Disable">REST API Reference for Disable Operation</seealso>
        public virtual Task<DisableResponse> DisableAsync(DisableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableDelegatedAdminAccount


        /// <summary>
        /// Disables the Amazon Inspector delegated administrator for your organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableDelegatedAdminAccount service method.</param>
        /// 
        /// <returns>The response from the DisableDelegatedAdminAccount service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DisableDelegatedAdminAccount">REST API Reference for DisableDelegatedAdminAccount Operation</seealso>
        public virtual DisableDelegatedAdminAccountResponse DisableDelegatedAdminAccount(DisableDelegatedAdminAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableDelegatedAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableDelegatedAdminAccountResponseUnmarshaller.Instance;

            return Invoke<DisableDelegatedAdminAccountResponse>(request, options);
        }


        /// <summary>
        /// Disables the Amazon Inspector delegated administrator for your organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableDelegatedAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableDelegatedAdminAccount service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DisableDelegatedAdminAccount">REST API Reference for DisableDelegatedAdminAccount Operation</seealso>
        public virtual Task<DisableDelegatedAdminAccountResponse> DisableDelegatedAdminAccountAsync(DisableDelegatedAdminAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableDelegatedAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableDelegatedAdminAccountResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisableDelegatedAdminAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateMember


        /// <summary>
        /// Disassociates a member account from an Amazon Inspector delegated administrator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMember service method.</param>
        /// 
        /// <returns>The response from the DisassociateMember service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DisassociateMember">REST API Reference for DisassociateMember Operation</seealso>
        public virtual DisassociateMemberResponse DisassociateMember(DisassociateMemberRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMemberResponseUnmarshaller.Instance;

            return Invoke<DisassociateMemberResponse>(request, options);
        }


        /// <summary>
        /// Disassociates a member account from an Amazon Inspector delegated administrator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateMember service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/DisassociateMember">REST API Reference for DisassociateMember Operation</seealso>
        public virtual Task<DisassociateMemberResponse> DisassociateMemberAsync(DisassociateMemberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMemberResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateMemberResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Enable


        /// <summary>
        /// Enables Amazon Inspector scans for one or more Amazon Web Services accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Enable service method.</param>
        /// 
        /// <returns>The response from the Enable service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/Enable">REST API Reference for Enable Operation</seealso>
        public virtual EnableResponse Enable(EnableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableResponseUnmarshaller.Instance;

            return Invoke<EnableResponse>(request, options);
        }


        /// <summary>
        /// Enables Amazon Inspector scans for one or more Amazon Web Services accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Enable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Enable service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/Enable">REST API Reference for Enable Operation</seealso>
        public virtual Task<EnableResponse> EnableAsync(EnableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableResponseUnmarshaller.Instance;
            
            return InvokeAsync<EnableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableDelegatedAdminAccount


        /// <summary>
        /// Enables the Amazon Inspector delegated administrator for your Organizations organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableDelegatedAdminAccount service method.</param>
        /// 
        /// <returns>The response from the EnableDelegatedAdminAccount service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/EnableDelegatedAdminAccount">REST API Reference for EnableDelegatedAdminAccount Operation</seealso>
        public virtual EnableDelegatedAdminAccountResponse EnableDelegatedAdminAccount(EnableDelegatedAdminAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableDelegatedAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableDelegatedAdminAccountResponseUnmarshaller.Instance;

            return Invoke<EnableDelegatedAdminAccountResponse>(request, options);
        }


        /// <summary>
        /// Enables the Amazon Inspector delegated administrator for your Organizations organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableDelegatedAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableDelegatedAdminAccount service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/EnableDelegatedAdminAccount">REST API Reference for EnableDelegatedAdminAccount Operation</seealso>
        public virtual Task<EnableDelegatedAdminAccountResponse> EnableDelegatedAdminAccountAsync(EnableDelegatedAdminAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableDelegatedAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableDelegatedAdminAccountResponseUnmarshaller.Instance;
            
            return InvokeAsync<EnableDelegatedAdminAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCisScanReport


        /// <summary>
        /// Retrieves a CIS scan report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCisScanReport service method.</param>
        /// 
        /// <returns>The response from the GetCisScanReport service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCisScanReport">REST API Reference for GetCisScanReport Operation</seealso>
        public virtual GetCisScanReportResponse GetCisScanReport(GetCisScanReportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCisScanReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCisScanReportResponseUnmarshaller.Instance;

            return Invoke<GetCisScanReportResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a CIS scan report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCisScanReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCisScanReport service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCisScanReport">REST API Reference for GetCisScanReport Operation</seealso>
        public virtual Task<GetCisScanReportResponse> GetCisScanReportAsync(GetCisScanReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCisScanReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCisScanReportResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCisScanReportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCisScanResultDetails


        /// <summary>
        /// Retrieves CIS scan result details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCisScanResultDetails service method.</param>
        /// 
        /// <returns>The response from the GetCisScanResultDetails service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCisScanResultDetails">REST API Reference for GetCisScanResultDetails Operation</seealso>
        public virtual GetCisScanResultDetailsResponse GetCisScanResultDetails(GetCisScanResultDetailsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCisScanResultDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCisScanResultDetailsResponseUnmarshaller.Instance;

            return Invoke<GetCisScanResultDetailsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves CIS scan result details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCisScanResultDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCisScanResultDetails service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCisScanResultDetails">REST API Reference for GetCisScanResultDetails Operation</seealso>
        public virtual Task<GetCisScanResultDetailsResponse> GetCisScanResultDetailsAsync(GetCisScanResultDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCisScanResultDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCisScanResultDetailsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCisScanResultDetailsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetClustersForImage


        /// <summary>
        /// Returns a list of clusters and metadata associated with an image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClustersForImage service method.</param>
        /// 
        /// <returns>The response from the GetClustersForImage service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetClustersForImage">REST API Reference for GetClustersForImage Operation</seealso>
        public virtual GetClustersForImageResponse GetClustersForImage(GetClustersForImageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetClustersForImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClustersForImageResponseUnmarshaller.Instance;

            return Invoke<GetClustersForImageResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of clusters and metadata associated with an image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClustersForImage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetClustersForImage service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetClustersForImage">REST API Reference for GetClustersForImage Operation</seealso>
        public virtual Task<GetClustersForImageResponse> GetClustersForImageAsync(GetClustersForImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetClustersForImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClustersForImageResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetClustersForImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCodeSecurityIntegration


        /// <summary>
        /// Retrieves information about a code security integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeSecurityIntegration service method.</param>
        /// 
        /// <returns>The response from the GetCodeSecurityIntegration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCodeSecurityIntegration">REST API Reference for GetCodeSecurityIntegration Operation</seealso>
        public virtual GetCodeSecurityIntegrationResponse GetCodeSecurityIntegration(GetCodeSecurityIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCodeSecurityIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCodeSecurityIntegrationResponseUnmarshaller.Instance;

            return Invoke<GetCodeSecurityIntegrationResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about a code security integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeSecurityIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCodeSecurityIntegration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCodeSecurityIntegration">REST API Reference for GetCodeSecurityIntegration Operation</seealso>
        public virtual Task<GetCodeSecurityIntegrationResponse> GetCodeSecurityIntegrationAsync(GetCodeSecurityIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCodeSecurityIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCodeSecurityIntegrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCodeSecurityIntegrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCodeSecurityScan


        /// <summary>
        /// Retrieves information about a specific code security scan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeSecurityScan service method.</param>
        /// 
        /// <returns>The response from the GetCodeSecurityScan service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCodeSecurityScan">REST API Reference for GetCodeSecurityScan Operation</seealso>
        public virtual GetCodeSecurityScanResponse GetCodeSecurityScan(GetCodeSecurityScanRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCodeSecurityScanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCodeSecurityScanResponseUnmarshaller.Instance;

            return Invoke<GetCodeSecurityScanResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about a specific code security scan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeSecurityScan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCodeSecurityScan service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCodeSecurityScan">REST API Reference for GetCodeSecurityScan Operation</seealso>
        public virtual Task<GetCodeSecurityScanResponse> GetCodeSecurityScanAsync(GetCodeSecurityScanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCodeSecurityScanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCodeSecurityScanResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCodeSecurityScanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCodeSecurityScanConfiguration


        /// <summary>
        /// Retrieves information about a code security scan configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeSecurityScanConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetCodeSecurityScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCodeSecurityScanConfiguration">REST API Reference for GetCodeSecurityScanConfiguration Operation</seealso>
        public virtual GetCodeSecurityScanConfigurationResponse GetCodeSecurityScanConfiguration(GetCodeSecurityScanConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCodeSecurityScanConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCodeSecurityScanConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetCodeSecurityScanConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about a code security scan configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeSecurityScanConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCodeSecurityScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetCodeSecurityScanConfiguration">REST API Reference for GetCodeSecurityScanConfiguration Operation</seealso>
        public virtual Task<GetCodeSecurityScanConfigurationResponse> GetCodeSecurityScanConfigurationAsync(GetCodeSecurityScanConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCodeSecurityScanConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCodeSecurityScanConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCodeSecurityScanConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConfiguration


        /// <summary>
        /// Retrieves setting configurations for Inspector scans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetConfiguration">REST API Reference for GetConfiguration Operation</seealso>
        public virtual GetConfigurationResponse GetConfiguration(GetConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Retrieves setting configurations for Inspector scans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetConfiguration">REST API Reference for GetConfiguration Operation</seealso>
        public virtual Task<GetConfigurationResponse> GetConfigurationAsync(GetConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDelegatedAdminAccount


        /// <summary>
        /// Retrieves information about the Amazon Inspector delegated administrator for your
        /// organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDelegatedAdminAccount service method.</param>
        /// 
        /// <returns>The response from the GetDelegatedAdminAccount service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetDelegatedAdminAccount">REST API Reference for GetDelegatedAdminAccount Operation</seealso>
        public virtual GetDelegatedAdminAccountResponse GetDelegatedAdminAccount(GetDelegatedAdminAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDelegatedAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDelegatedAdminAccountResponseUnmarshaller.Instance;

            return Invoke<GetDelegatedAdminAccountResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about the Amazon Inspector delegated administrator for your
        /// organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDelegatedAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDelegatedAdminAccount service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetDelegatedAdminAccount">REST API Reference for GetDelegatedAdminAccount Operation</seealso>
        public virtual Task<GetDelegatedAdminAccountResponse> GetDelegatedAdminAccountAsync(GetDelegatedAdminAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDelegatedAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDelegatedAdminAccountResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDelegatedAdminAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEc2DeepInspectionConfiguration


        /// <summary>
        /// Retrieves the activation status of Amazon Inspector deep inspection and custom paths
        /// associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEc2DeepInspectionConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetEc2DeepInspectionConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetEc2DeepInspectionConfiguration">REST API Reference for GetEc2DeepInspectionConfiguration Operation</seealso>
        public virtual GetEc2DeepInspectionConfigurationResponse GetEc2DeepInspectionConfiguration(GetEc2DeepInspectionConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEc2DeepInspectionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEc2DeepInspectionConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetEc2DeepInspectionConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the activation status of Amazon Inspector deep inspection and custom paths
        /// associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEc2DeepInspectionConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEc2DeepInspectionConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetEc2DeepInspectionConfiguration">REST API Reference for GetEc2DeepInspectionConfiguration Operation</seealso>
        public virtual Task<GetEc2DeepInspectionConfigurationResponse> GetEc2DeepInspectionConfigurationAsync(GetEc2DeepInspectionConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEc2DeepInspectionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEc2DeepInspectionConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetEc2DeepInspectionConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEncryptionKey


        /// <summary>
        /// Gets an encryption key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEncryptionKey service method.</param>
        /// 
        /// <returns>The response from the GetEncryptionKey service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetEncryptionKey">REST API Reference for GetEncryptionKey Operation</seealso>
        public virtual GetEncryptionKeyResponse GetEncryptionKey(GetEncryptionKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEncryptionKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEncryptionKeyResponseUnmarshaller.Instance;

            return Invoke<GetEncryptionKeyResponse>(request, options);
        }


        /// <summary>
        /// Gets an encryption key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEncryptionKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEncryptionKey service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetEncryptionKey">REST API Reference for GetEncryptionKey Operation</seealso>
        public virtual Task<GetEncryptionKeyResponse> GetEncryptionKeyAsync(GetEncryptionKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEncryptionKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEncryptionKeyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetEncryptionKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFindingsReportStatus


        /// <summary>
        /// Gets the status of a findings report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsReportStatus service method.</param>
        /// 
        /// <returns>The response from the GetFindingsReportStatus service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetFindingsReportStatus">REST API Reference for GetFindingsReportStatus Operation</seealso>
        public virtual GetFindingsReportStatusResponse GetFindingsReportStatus(GetFindingsReportStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFindingsReportStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingsReportStatusResponseUnmarshaller.Instance;

            return Invoke<GetFindingsReportStatusResponse>(request, options);
        }


        /// <summary>
        /// Gets the status of a findings report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsReportStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFindingsReportStatus service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetFindingsReportStatus">REST API Reference for GetFindingsReportStatus Operation</seealso>
        public virtual Task<GetFindingsReportStatusResponse> GetFindingsReportStatusAsync(GetFindingsReportStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFindingsReportStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFindingsReportStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetFindingsReportStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMember


        /// <summary>
        /// Gets member information for your organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMember service method.</param>
        /// 
        /// <returns>The response from the GetMember service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetMember">REST API Reference for GetMember Operation</seealso>
        public virtual GetMemberResponse GetMember(GetMemberRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMemberResponseUnmarshaller.Instance;

            return Invoke<GetMemberResponse>(request, options);
        }


        /// <summary>
        /// Gets member information for your organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMember service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetMember">REST API Reference for GetMember Operation</seealso>
        public virtual Task<GetMemberResponse> GetMemberAsync(GetMemberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMemberResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMemberResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSbomExport


        /// <summary>
        /// Gets details of a software bill of materials (SBOM) report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSbomExport service method.</param>
        /// 
        /// <returns>The response from the GetSbomExport service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetSbomExport">REST API Reference for GetSbomExport Operation</seealso>
        public virtual GetSbomExportResponse GetSbomExport(GetSbomExportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSbomExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSbomExportResponseUnmarshaller.Instance;

            return Invoke<GetSbomExportResponse>(request, options);
        }


        /// <summary>
        /// Gets details of a software bill of materials (SBOM) report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSbomExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSbomExport service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/GetSbomExport">REST API Reference for GetSbomExport Operation</seealso>
        public virtual Task<GetSbomExportResponse> GetSbomExportAsync(GetSbomExportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSbomExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSbomExportResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSbomExportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAccountPermissions


        /// <summary>
        /// Lists the permissions an account has to configure Amazon Inspector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountPermissions service method.</param>
        /// 
        /// <returns>The response from the ListAccountPermissions service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListAccountPermissions">REST API Reference for ListAccountPermissions Operation</seealso>
        public virtual ListAccountPermissionsResponse ListAccountPermissions(ListAccountPermissionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccountPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountPermissionsResponseUnmarshaller.Instance;

            return Invoke<ListAccountPermissionsResponse>(request, options);
        }


        /// <summary>
        /// Lists the permissions an account has to configure Amazon Inspector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccountPermissions service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListAccountPermissions">REST API Reference for ListAccountPermissions Operation</seealso>
        public virtual Task<ListAccountPermissionsResponse> ListAccountPermissionsAsync(ListAccountPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccountPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountPermissionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAccountPermissionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCisScanConfigurations


        /// <summary>
        /// Lists CIS scan configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCisScanConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListCisScanConfigurations service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCisScanConfigurations">REST API Reference for ListCisScanConfigurations Operation</seealso>
        public virtual ListCisScanConfigurationsResponse ListCisScanConfigurations(ListCisScanConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCisScanConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCisScanConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListCisScanConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Lists CIS scan configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCisScanConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCisScanConfigurations service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCisScanConfigurations">REST API Reference for ListCisScanConfigurations Operation</seealso>
        public virtual Task<ListCisScanConfigurationsResponse> ListCisScanConfigurationsAsync(ListCisScanConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCisScanConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCisScanConfigurationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCisScanConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCisScanResultsAggregatedByChecks


        /// <summary>
        /// Lists scan results aggregated by checks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCisScanResultsAggregatedByChecks service method.</param>
        /// 
        /// <returns>The response from the ListCisScanResultsAggregatedByChecks service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCisScanResultsAggregatedByChecks">REST API Reference for ListCisScanResultsAggregatedByChecks Operation</seealso>
        public virtual ListCisScanResultsAggregatedByChecksResponse ListCisScanResultsAggregatedByChecks(ListCisScanResultsAggregatedByChecksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCisScanResultsAggregatedByChecksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCisScanResultsAggregatedByChecksResponseUnmarshaller.Instance;

            return Invoke<ListCisScanResultsAggregatedByChecksResponse>(request, options);
        }


        /// <summary>
        /// Lists scan results aggregated by checks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCisScanResultsAggregatedByChecks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCisScanResultsAggregatedByChecks service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCisScanResultsAggregatedByChecks">REST API Reference for ListCisScanResultsAggregatedByChecks Operation</seealso>
        public virtual Task<ListCisScanResultsAggregatedByChecksResponse> ListCisScanResultsAggregatedByChecksAsync(ListCisScanResultsAggregatedByChecksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCisScanResultsAggregatedByChecksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCisScanResultsAggregatedByChecksResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCisScanResultsAggregatedByChecksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCisScanResultsAggregatedByTargetResource


        /// <summary>
        /// Lists scan results aggregated by a target resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCisScanResultsAggregatedByTargetResource service method.</param>
        /// 
        /// <returns>The response from the ListCisScanResultsAggregatedByTargetResource service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCisScanResultsAggregatedByTargetResource">REST API Reference for ListCisScanResultsAggregatedByTargetResource Operation</seealso>
        public virtual ListCisScanResultsAggregatedByTargetResourceResponse ListCisScanResultsAggregatedByTargetResource(ListCisScanResultsAggregatedByTargetResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCisScanResultsAggregatedByTargetResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCisScanResultsAggregatedByTargetResourceResponseUnmarshaller.Instance;

            return Invoke<ListCisScanResultsAggregatedByTargetResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists scan results aggregated by a target resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCisScanResultsAggregatedByTargetResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCisScanResultsAggregatedByTargetResource service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCisScanResultsAggregatedByTargetResource">REST API Reference for ListCisScanResultsAggregatedByTargetResource Operation</seealso>
        public virtual Task<ListCisScanResultsAggregatedByTargetResourceResponse> ListCisScanResultsAggregatedByTargetResourceAsync(ListCisScanResultsAggregatedByTargetResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCisScanResultsAggregatedByTargetResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCisScanResultsAggregatedByTargetResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCisScanResultsAggregatedByTargetResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCisScans


        /// <summary>
        /// Returns a CIS scan list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCisScans service method.</param>
        /// 
        /// <returns>The response from the ListCisScans service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCisScans">REST API Reference for ListCisScans Operation</seealso>
        public virtual ListCisScansResponse ListCisScans(ListCisScansRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCisScansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCisScansResponseUnmarshaller.Instance;

            return Invoke<ListCisScansResponse>(request, options);
        }


        /// <summary>
        /// Returns a CIS scan list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCisScans service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCisScans service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCisScans">REST API Reference for ListCisScans Operation</seealso>
        public virtual Task<ListCisScansResponse> ListCisScansAsync(ListCisScansRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCisScansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCisScansResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCisScansResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCodeSecurityIntegrations


        /// <summary>
        /// Lists all code security integrations in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeSecurityIntegrations service method.</param>
        /// 
        /// <returns>The response from the ListCodeSecurityIntegrations service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCodeSecurityIntegrations">REST API Reference for ListCodeSecurityIntegrations Operation</seealso>
        public virtual ListCodeSecurityIntegrationsResponse ListCodeSecurityIntegrations(ListCodeSecurityIntegrationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCodeSecurityIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeSecurityIntegrationsResponseUnmarshaller.Instance;

            return Invoke<ListCodeSecurityIntegrationsResponse>(request, options);
        }


        /// <summary>
        /// Lists all code security integrations in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeSecurityIntegrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCodeSecurityIntegrations service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCodeSecurityIntegrations">REST API Reference for ListCodeSecurityIntegrations Operation</seealso>
        public virtual Task<ListCodeSecurityIntegrationsResponse> ListCodeSecurityIntegrationsAsync(ListCodeSecurityIntegrationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCodeSecurityIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeSecurityIntegrationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCodeSecurityIntegrationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCodeSecurityScanConfigurationAssociations


        /// <summary>
        /// Lists the associations between code repositories and Amazon Inspector code security
        /// scan configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeSecurityScanConfigurationAssociations service method.</param>
        /// 
        /// <returns>The response from the ListCodeSecurityScanConfigurationAssociations service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCodeSecurityScanConfigurationAssociations">REST API Reference for ListCodeSecurityScanConfigurationAssociations Operation</seealso>
        public virtual ListCodeSecurityScanConfigurationAssociationsResponse ListCodeSecurityScanConfigurationAssociations(ListCodeSecurityScanConfigurationAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCodeSecurityScanConfigurationAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeSecurityScanConfigurationAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListCodeSecurityScanConfigurationAssociationsResponse>(request, options);
        }


        /// <summary>
        /// Lists the associations between code repositories and Amazon Inspector code security
        /// scan configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeSecurityScanConfigurationAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCodeSecurityScanConfigurationAssociations service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCodeSecurityScanConfigurationAssociations">REST API Reference for ListCodeSecurityScanConfigurationAssociations Operation</seealso>
        public virtual Task<ListCodeSecurityScanConfigurationAssociationsResponse> ListCodeSecurityScanConfigurationAssociationsAsync(ListCodeSecurityScanConfigurationAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCodeSecurityScanConfigurationAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeSecurityScanConfigurationAssociationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCodeSecurityScanConfigurationAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCodeSecurityScanConfigurations


        /// <summary>
        /// Lists all code security scan configurations in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeSecurityScanConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListCodeSecurityScanConfigurations service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCodeSecurityScanConfigurations">REST API Reference for ListCodeSecurityScanConfigurations Operation</seealso>
        public virtual ListCodeSecurityScanConfigurationsResponse ListCodeSecurityScanConfigurations(ListCodeSecurityScanConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCodeSecurityScanConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeSecurityScanConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListCodeSecurityScanConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Lists all code security scan configurations in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeSecurityScanConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCodeSecurityScanConfigurations service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCodeSecurityScanConfigurations">REST API Reference for ListCodeSecurityScanConfigurations Operation</seealso>
        public virtual Task<ListCodeSecurityScanConfigurationsResponse> ListCodeSecurityScanConfigurationsAsync(ListCodeSecurityScanConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCodeSecurityScanConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeSecurityScanConfigurationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCodeSecurityScanConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCoverage


        /// <summary>
        /// Lists coverage details for your environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCoverage service method.</param>
        /// 
        /// <returns>The response from the ListCoverage service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCoverage">REST API Reference for ListCoverage Operation</seealso>
        public virtual ListCoverageResponse ListCoverage(ListCoverageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCoverageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCoverageResponseUnmarshaller.Instance;

            return Invoke<ListCoverageResponse>(request, options);
        }


        /// <summary>
        /// Lists coverage details for your environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCoverage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCoverage service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCoverage">REST API Reference for ListCoverage Operation</seealso>
        public virtual Task<ListCoverageResponse> ListCoverageAsync(ListCoverageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCoverageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCoverageResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCoverageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCoverageStatistics


        /// <summary>
        /// Lists Amazon Inspector coverage statistics for your environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCoverageStatistics service method.</param>
        /// 
        /// <returns>The response from the ListCoverageStatistics service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCoverageStatistics">REST API Reference for ListCoverageStatistics Operation</seealso>
        public virtual ListCoverageStatisticsResponse ListCoverageStatistics(ListCoverageStatisticsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCoverageStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCoverageStatisticsResponseUnmarshaller.Instance;

            return Invoke<ListCoverageStatisticsResponse>(request, options);
        }


        /// <summary>
        /// Lists Amazon Inspector coverage statistics for your environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCoverageStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCoverageStatistics service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListCoverageStatistics">REST API Reference for ListCoverageStatistics Operation</seealso>
        public virtual Task<ListCoverageStatisticsResponse> ListCoverageStatisticsAsync(ListCoverageStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCoverageStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCoverageStatisticsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCoverageStatisticsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDelegatedAdminAccounts


        /// <summary>
        /// Lists information about the Amazon Inspector delegated administrator of your organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDelegatedAdminAccounts service method.</param>
        /// 
        /// <returns>The response from the ListDelegatedAdminAccounts service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListDelegatedAdminAccounts">REST API Reference for ListDelegatedAdminAccounts Operation</seealso>
        public virtual ListDelegatedAdminAccountsResponse ListDelegatedAdminAccounts(ListDelegatedAdminAccountsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDelegatedAdminAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDelegatedAdminAccountsResponseUnmarshaller.Instance;

            return Invoke<ListDelegatedAdminAccountsResponse>(request, options);
        }


        /// <summary>
        /// Lists information about the Amazon Inspector delegated administrator of your organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDelegatedAdminAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDelegatedAdminAccounts service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListDelegatedAdminAccounts">REST API Reference for ListDelegatedAdminAccounts Operation</seealso>
        public virtual Task<ListDelegatedAdminAccountsResponse> ListDelegatedAdminAccountsAsync(ListDelegatedAdminAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDelegatedAdminAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDelegatedAdminAccountsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDelegatedAdminAccountsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFilters


        /// <summary>
        /// Lists the filters associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFilters service method.</param>
        /// 
        /// <returns>The response from the ListFilters service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListFilters">REST API Reference for ListFilters Operation</seealso>
        public virtual ListFiltersResponse ListFilters(ListFiltersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFiltersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFiltersResponseUnmarshaller.Instance;

            return Invoke<ListFiltersResponse>(request, options);
        }


        /// <summary>
        /// Lists the filters associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFilters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFilters service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListFilters">REST API Reference for ListFilters Operation</seealso>
        public virtual Task<ListFiltersResponse> ListFiltersAsync(ListFiltersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFiltersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFiltersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFiltersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFindingAggregations


        /// <summary>
        /// Lists aggregated finding data for your environment based on specific criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindingAggregations service method.</param>
        /// 
        /// <returns>The response from the ListFindingAggregations service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListFindingAggregations">REST API Reference for ListFindingAggregations Operation</seealso>
        public virtual ListFindingAggregationsResponse ListFindingAggregations(ListFindingAggregationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFindingAggregationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingAggregationsResponseUnmarshaller.Instance;

            return Invoke<ListFindingAggregationsResponse>(request, options);
        }


        /// <summary>
        /// Lists aggregated finding data for your environment based on specific criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindingAggregations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFindingAggregations service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListFindingAggregations">REST API Reference for ListFindingAggregations Operation</seealso>
        public virtual Task<ListFindingAggregationsResponse> ListFindingAggregationsAsync(ListFindingAggregationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFindingAggregationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingAggregationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFindingAggregationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFindings


        /// <summary>
        /// Lists findings for your environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindings service method.</param>
        /// 
        /// <returns>The response from the ListFindings service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListFindings">REST API Reference for ListFindings Operation</seealso>
        public virtual ListFindingsResponse ListFindings(ListFindingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingsResponseUnmarshaller.Instance;

            return Invoke<ListFindingsResponse>(request, options);
        }


        /// <summary>
        /// Lists findings for your environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFindings service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListFindings">REST API Reference for ListFindings Operation</seealso>
        public virtual Task<ListFindingsResponse> ListFindingsAsync(ListFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFindingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMembers


        /// <summary>
        /// List members associated with the Amazon Inspector delegated administrator for your
        /// organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
        /// 
        /// <returns>The response from the ListMembers service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListMembers">REST API Reference for ListMembers Operation</seealso>
        public virtual ListMembersResponse ListMembers(ListMembersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembersResponseUnmarshaller.Instance;

            return Invoke<ListMembersResponse>(request, options);
        }


        /// <summary>
        /// List members associated with the Amazon Inspector delegated administrator for your
        /// organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMembers service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListMembers">REST API Reference for ListMembers Operation</seealso>
        public virtual Task<ListMembersResponse> ListMembersAsync(ListMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMembersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags attached to a given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists all tags attached to a given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListUsageTotals


        /// <summary>
        /// Lists the Amazon Inspector usage totals over the last 30 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsageTotals service method.</param>
        /// 
        /// <returns>The response from the ListUsageTotals service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListUsageTotals">REST API Reference for ListUsageTotals Operation</seealso>
        public virtual ListUsageTotalsResponse ListUsageTotals(ListUsageTotalsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListUsageTotalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsageTotalsResponseUnmarshaller.Instance;

            return Invoke<ListUsageTotalsResponse>(request, options);
        }


        /// <summary>
        /// Lists the Amazon Inspector usage totals over the last 30 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsageTotals service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUsageTotals service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ListUsageTotals">REST API Reference for ListUsageTotals Operation</seealso>
        public virtual Task<ListUsageTotalsResponse> ListUsageTotalsAsync(ListUsageTotalsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListUsageTotalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsageTotalsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListUsageTotalsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetEncryptionKey


        /// <summary>
        /// Resets an encryption key. After the key is reset your resources will be encrypted
        /// by an Amazon Web Services owned key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetEncryptionKey service method.</param>
        /// 
        /// <returns>The response from the ResetEncryptionKey service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ResetEncryptionKey">REST API Reference for ResetEncryptionKey Operation</seealso>
        public virtual ResetEncryptionKeyResponse ResetEncryptionKey(ResetEncryptionKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetEncryptionKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetEncryptionKeyResponseUnmarshaller.Instance;

            return Invoke<ResetEncryptionKeyResponse>(request, options);
        }


        /// <summary>
        /// Resets an encryption key. After the key is reset your resources will be encrypted
        /// by an Amazon Web Services owned key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetEncryptionKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetEncryptionKey service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/ResetEncryptionKey">REST API Reference for ResetEncryptionKey Operation</seealso>
        public virtual Task<ResetEncryptionKeyResponse> ResetEncryptionKeyAsync(ResetEncryptionKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetEncryptionKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetEncryptionKeyResponseUnmarshaller.Instance;
            
            return InvokeAsync<ResetEncryptionKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchVulnerabilities


        /// <summary>
        /// Lists Amazon Inspector coverage details for a specific vulnerability.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchVulnerabilities service method.</param>
        /// 
        /// <returns>The response from the SearchVulnerabilities service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/SearchVulnerabilities">REST API Reference for SearchVulnerabilities Operation</seealso>
        public virtual SearchVulnerabilitiesResponse SearchVulnerabilities(SearchVulnerabilitiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchVulnerabilitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchVulnerabilitiesResponseUnmarshaller.Instance;

            return Invoke<SearchVulnerabilitiesResponse>(request, options);
        }


        /// <summary>
        /// Lists Amazon Inspector coverage details for a specific vulnerability.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchVulnerabilities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchVulnerabilities service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/SearchVulnerabilities">REST API Reference for SearchVulnerabilities Operation</seealso>
        public virtual Task<SearchVulnerabilitiesResponse> SearchVulnerabilitiesAsync(SearchVulnerabilitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchVulnerabilitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchVulnerabilitiesResponseUnmarshaller.Instance;
            
            return InvokeAsync<SearchVulnerabilitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendCisSessionHealth


        /// <summary>
        /// Sends a CIS session health. This API is used by the Amazon Inspector SSM plugin to
        /// communicate with the Amazon Inspector service. The Amazon Inspector SSM plugin calls
        /// this API to start a CIS scan session for the scan ID supplied by the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendCisSessionHealth service method.</param>
        /// 
        /// <returns>The response from the SendCisSessionHealth service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/SendCisSessionHealth">REST API Reference for SendCisSessionHealth Operation</seealso>
        public virtual SendCisSessionHealthResponse SendCisSessionHealth(SendCisSessionHealthRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendCisSessionHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendCisSessionHealthResponseUnmarshaller.Instance;

            return Invoke<SendCisSessionHealthResponse>(request, options);
        }


        /// <summary>
        /// Sends a CIS session health. This API is used by the Amazon Inspector SSM plugin to
        /// communicate with the Amazon Inspector service. The Amazon Inspector SSM plugin calls
        /// this API to start a CIS scan session for the scan ID supplied by the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendCisSessionHealth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendCisSessionHealth service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/SendCisSessionHealth">REST API Reference for SendCisSessionHealth Operation</seealso>
        public virtual Task<SendCisSessionHealthResponse> SendCisSessionHealthAsync(SendCisSessionHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendCisSessionHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendCisSessionHealthResponseUnmarshaller.Instance;
            
            return InvokeAsync<SendCisSessionHealthResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendCisSessionTelemetry


        /// <summary>
        /// Sends a CIS session telemetry. This API is used by the Amazon Inspector SSM plugin
        /// to communicate with the Amazon Inspector service. The Amazon Inspector SSM plugin
        /// calls this API to start a CIS scan session for the scan ID supplied by the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendCisSessionTelemetry service method.</param>
        /// 
        /// <returns>The response from the SendCisSessionTelemetry service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/SendCisSessionTelemetry">REST API Reference for SendCisSessionTelemetry Operation</seealso>
        public virtual SendCisSessionTelemetryResponse SendCisSessionTelemetry(SendCisSessionTelemetryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendCisSessionTelemetryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendCisSessionTelemetryResponseUnmarshaller.Instance;

            return Invoke<SendCisSessionTelemetryResponse>(request, options);
        }


        /// <summary>
        /// Sends a CIS session telemetry. This API is used by the Amazon Inspector SSM plugin
        /// to communicate with the Amazon Inspector service. The Amazon Inspector SSM plugin
        /// calls this API to start a CIS scan session for the scan ID supplied by the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendCisSessionTelemetry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendCisSessionTelemetry service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/SendCisSessionTelemetry">REST API Reference for SendCisSessionTelemetry Operation</seealso>
        public virtual Task<SendCisSessionTelemetryResponse> SendCisSessionTelemetryAsync(SendCisSessionTelemetryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendCisSessionTelemetryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendCisSessionTelemetryResponseUnmarshaller.Instance;
            
            return InvokeAsync<SendCisSessionTelemetryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartCisSession


        /// <summary>
        /// Starts a CIS session. This API is used by the Amazon Inspector SSM plugin to communicate
        /// with the Amazon Inspector service. The Amazon Inspector SSM plugin calls this API
        /// to start a CIS scan session for the scan ID supplied by the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCisSession service method.</param>
        /// 
        /// <returns>The response from the StartCisSession service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/StartCisSession">REST API Reference for StartCisSession Operation</seealso>
        public virtual StartCisSessionResponse StartCisSession(StartCisSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartCisSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCisSessionResponseUnmarshaller.Instance;

            return Invoke<StartCisSessionResponse>(request, options);
        }


        /// <summary>
        /// Starts a CIS session. This API is used by the Amazon Inspector SSM plugin to communicate
        /// with the Amazon Inspector service. The Amazon Inspector SSM plugin calls this API
        /// to start a CIS scan session for the scan ID supplied by the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCisSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartCisSession service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/StartCisSession">REST API Reference for StartCisSession Operation</seealso>
        public virtual Task<StartCisSessionResponse> StartCisSessionAsync(StartCisSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartCisSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCisSessionResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartCisSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartCodeSecurityScan


        /// <summary>
        /// Initiates a code security scan on a specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCodeSecurityScan service method.</param>
        /// 
        /// <returns>The response from the StartCodeSecurityScan service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/StartCodeSecurityScan">REST API Reference for StartCodeSecurityScan Operation</seealso>
        public virtual StartCodeSecurityScanResponse StartCodeSecurityScan(StartCodeSecurityScanRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartCodeSecurityScanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCodeSecurityScanResponseUnmarshaller.Instance;

            return Invoke<StartCodeSecurityScanResponse>(request, options);
        }


        /// <summary>
        /// Initiates a code security scan on a specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCodeSecurityScan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartCodeSecurityScan service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/StartCodeSecurityScan">REST API Reference for StartCodeSecurityScan Operation</seealso>
        public virtual Task<StartCodeSecurityScanResponse> StartCodeSecurityScanAsync(StartCodeSecurityScanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartCodeSecurityScanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCodeSecurityScanResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartCodeSecurityScanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopCisSession


        /// <summary>
        /// Stops a CIS session. This API is used by the Amazon Inspector SSM plugin to communicate
        /// with the Amazon Inspector service. The Amazon Inspector SSM plugin calls this API
        /// to stop a CIS scan session for the scan ID supplied by the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCisSession service method.</param>
        /// 
        /// <returns>The response from the StopCisSession service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/StopCisSession">REST API Reference for StopCisSession Operation</seealso>
        public virtual StopCisSessionResponse StopCisSession(StopCisSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopCisSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCisSessionResponseUnmarshaller.Instance;

            return Invoke<StopCisSessionResponse>(request, options);
        }


        /// <summary>
        /// Stops a CIS session. This API is used by the Amazon Inspector SSM plugin to communicate
        /// with the Amazon Inspector service. The Amazon Inspector SSM plugin calls this API
        /// to stop a CIS scan session for the scan ID supplied by the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCisSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopCisSession service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/StopCisSession">REST API Reference for StopCisSession Operation</seealso>
        public virtual Task<StopCisSessionResponse> StopCisSessionAsync(StopCisSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopCisSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCisSessionResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopCisSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.BadRequestException">
        /// One or more tags submitted as part of the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.BadRequestException">
        /// One or more tags submitted as part of the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCisScanConfiguration


        /// <summary>
        /// Updates a CIS scan configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCisScanConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateCisScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateCisScanConfiguration">REST API Reference for UpdateCisScanConfiguration Operation</seealso>
        public virtual UpdateCisScanConfigurationResponse UpdateCisScanConfiguration(UpdateCisScanConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCisScanConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCisScanConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateCisScanConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Updates a CIS scan configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCisScanConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCisScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateCisScanConfiguration">REST API Reference for UpdateCisScanConfiguration Operation</seealso>
        public virtual Task<UpdateCisScanConfigurationResponse> UpdateCisScanConfigurationAsync(UpdateCisScanConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCisScanConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCisScanConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateCisScanConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCodeSecurityIntegration


        /// <summary>
        /// Updates an existing code security integration.
        /// 
        ///  
        /// <para>
        /// After calling the <c>CreateCodeSecurityIntegration</c> operation, you complete authentication
        /// and authorization with your provider. Next you call the <c>UpdateCodeSecurityIntegration</c>
        /// operation to provide the <c>details</c> to complete the integration setup
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCodeSecurityIntegration service method.</param>
        /// 
        /// <returns>The response from the UpdateCodeSecurityIntegration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateCodeSecurityIntegration">REST API Reference for UpdateCodeSecurityIntegration Operation</seealso>
        public virtual UpdateCodeSecurityIntegrationResponse UpdateCodeSecurityIntegration(UpdateCodeSecurityIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCodeSecurityIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCodeSecurityIntegrationResponseUnmarshaller.Instance;

            return Invoke<UpdateCodeSecurityIntegrationResponse>(request, options);
        }


        /// <summary>
        /// Updates an existing code security integration.
        /// 
        ///  
        /// <para>
        /// After calling the <c>CreateCodeSecurityIntegration</c> operation, you complete authentication
        /// and authorization with your provider. Next you call the <c>UpdateCodeSecurityIntegration</c>
        /// operation to provide the <c>details</c> to complete the integration setup
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCodeSecurityIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCodeSecurityIntegration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateCodeSecurityIntegration">REST API Reference for UpdateCodeSecurityIntegration Operation</seealso>
        public virtual Task<UpdateCodeSecurityIntegrationResponse> UpdateCodeSecurityIntegrationAsync(UpdateCodeSecurityIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCodeSecurityIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCodeSecurityIntegrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateCodeSecurityIntegrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCodeSecurityScanConfiguration


        /// <summary>
        /// Updates an existing code security scan configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCodeSecurityScanConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateCodeSecurityScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateCodeSecurityScanConfiguration">REST API Reference for UpdateCodeSecurityScanConfiguration Operation</seealso>
        public virtual UpdateCodeSecurityScanConfigurationResponse UpdateCodeSecurityScanConfiguration(UpdateCodeSecurityScanConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCodeSecurityScanConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCodeSecurityScanConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateCodeSecurityScanConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Updates an existing code security scan configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCodeSecurityScanConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCodeSecurityScanConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ConflictException">
        /// A conflict occurred. This exception occurs when the same resource is being modified
        /// by concurrent requests.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateCodeSecurityScanConfiguration">REST API Reference for UpdateCodeSecurityScanConfiguration Operation</seealso>
        public virtual Task<UpdateCodeSecurityScanConfigurationResponse> UpdateCodeSecurityScanConfigurationAsync(UpdateCodeSecurityScanConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCodeSecurityScanConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCodeSecurityScanConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateCodeSecurityScanConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateConfiguration


        /// <summary>
        /// Updates setting configurations for your Amazon Inspector account. When you use this
        /// API as an Amazon Inspector delegated administrator this updates the setting for all
        /// accounts you manage. Member accounts in an organization cannot update this setting.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateConfiguration">REST API Reference for UpdateConfiguration Operation</seealso>
        public virtual UpdateConfigurationResponse UpdateConfiguration(UpdateConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Updates setting configurations for your Amazon Inspector account. When you use this
        /// API as an Amazon Inspector delegated administrator this updates the setting for all
        /// accounts you manage. Member accounts in an organization cannot update this setting.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateConfiguration">REST API Reference for UpdateConfiguration Operation</seealso>
        public virtual Task<UpdateConfigurationResponse> UpdateConfigurationAsync(UpdateConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEc2DeepInspectionConfiguration


        /// <summary>
        /// Activates, deactivates Amazon Inspector deep inspection, or updates custom paths for
        /// your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEc2DeepInspectionConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateEc2DeepInspectionConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateEc2DeepInspectionConfiguration">REST API Reference for UpdateEc2DeepInspectionConfiguration Operation</seealso>
        public virtual UpdateEc2DeepInspectionConfigurationResponse UpdateEc2DeepInspectionConfiguration(UpdateEc2DeepInspectionConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEc2DeepInspectionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEc2DeepInspectionConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateEc2DeepInspectionConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Activates, deactivates Amazon Inspector deep inspection, or updates custom paths for
        /// your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEc2DeepInspectionConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEc2DeepInspectionConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateEc2DeepInspectionConfiguration">REST API Reference for UpdateEc2DeepInspectionConfiguration Operation</seealso>
        public virtual Task<UpdateEc2DeepInspectionConfigurationResponse> UpdateEc2DeepInspectionConfigurationAsync(UpdateEc2DeepInspectionConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEc2DeepInspectionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEc2DeepInspectionConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateEc2DeepInspectionConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEncryptionKey


        /// <summary>
        /// Updates an encryption key. A <c>ResourceNotFoundException</c> means that an Amazon
        /// Web Services owned key is being used for encryption.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEncryptionKey service method.</param>
        /// 
        /// <returns>The response from the UpdateEncryptionKey service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateEncryptionKey">REST API Reference for UpdateEncryptionKey Operation</seealso>
        public virtual UpdateEncryptionKeyResponse UpdateEncryptionKey(UpdateEncryptionKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEncryptionKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEncryptionKeyResponseUnmarshaller.Instance;

            return Invoke<UpdateEncryptionKeyResponse>(request, options);
        }


        /// <summary>
        /// Updates an encryption key. A <c>ResourceNotFoundException</c> means that an Amazon
        /// Web Services owned key is being used for encryption.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEncryptionKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEncryptionKey service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateEncryptionKey">REST API Reference for UpdateEncryptionKey Operation</seealso>
        public virtual Task<UpdateEncryptionKeyResponse> UpdateEncryptionKeyAsync(UpdateEncryptionKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEncryptionKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEncryptionKeyResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateEncryptionKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFilter


        /// <summary>
        /// Specifies the action that is to be applied to the findings that match the filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFilter service method.</param>
        /// 
        /// <returns>The response from the UpdateFilter service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateFilter">REST API Reference for UpdateFilter Operation</seealso>
        public virtual UpdateFilterResponse UpdateFilter(UpdateFilterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFilterResponseUnmarshaller.Instance;

            return Invoke<UpdateFilterResponse>(request, options);
        }


        /// <summary>
        /// Specifies the action that is to be applied to the findings that match the filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFilter service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ResourceNotFoundException">
        /// The operation tried to access an invalid resource. Make sure the resource is specified
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateFilter">REST API Reference for UpdateFilter Operation</seealso>
        public virtual Task<UpdateFilterResponse> UpdateFilterAsync(UpdateFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFilterResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateFilterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateOrganizationConfiguration


        /// <summary>
        /// Updates the configurations for your Amazon Inspector organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateOrganizationConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateOrganizationConfiguration">REST API Reference for UpdateOrganizationConfiguration Operation</seealso>
        public virtual UpdateOrganizationConfigurationResponse UpdateOrganizationConfiguration(UpdateOrganizationConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOrganizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOrganizationConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateOrganizationConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Updates the configurations for your Amazon Inspector organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateOrganizationConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateOrganizationConfiguration">REST API Reference for UpdateOrganizationConfiguration Operation</seealso>
        public virtual Task<UpdateOrganizationConfigurationResponse> UpdateOrganizationConfigurationAsync(UpdateOrganizationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOrganizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOrganizationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateOrganizationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateOrgEc2DeepInspectionConfiguration


        /// <summary>
        /// Updates the Amazon Inspector deep inspection custom paths for your organization. You
        /// must be an Amazon Inspector delegated administrator to use this API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrgEc2DeepInspectionConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateOrgEc2DeepInspectionConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateOrgEc2DeepInspectionConfiguration">REST API Reference for UpdateOrgEc2DeepInspectionConfiguration Operation</seealso>
        public virtual UpdateOrgEc2DeepInspectionConfigurationResponse UpdateOrgEc2DeepInspectionConfiguration(UpdateOrgEc2DeepInspectionConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOrgEc2DeepInspectionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOrgEc2DeepInspectionConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateOrgEc2DeepInspectionConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Updates the Amazon Inspector deep inspection custom paths for your organization. You
        /// must be an Amazon Inspector delegated administrator to use this API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrgEc2DeepInspectionConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateOrgEc2DeepInspectionConfiguration service method, as returned by Inspector2.</returns>
        /// <exception cref="Amazon.Inspector2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        ///  For <c>Enable</c>, you receive this error if you attempt to use a feature in an unsupported
        /// Amazon Web Services Region. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.InternalServerException">
        /// The request has failed due to an internal failure of the Amazon Inspector service.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Inspector2.Model.ValidationException">
        /// The request has failed validation due to missing required fields or having invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector2-2020-06-08/UpdateOrgEc2DeepInspectionConfiguration">REST API Reference for UpdateOrgEc2DeepInspectionConfiguration Operation</seealso>
        public virtual Task<UpdateOrgEc2DeepInspectionConfigurationResponse> UpdateOrgEc2DeepInspectionConfigurationAsync(UpdateOrgEc2DeepInspectionConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOrgEc2DeepInspectionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOrgEc2DeepInspectionConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateOrgEc2DeepInspectionConfigurationResponse>(request, options, cancellationToken);
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