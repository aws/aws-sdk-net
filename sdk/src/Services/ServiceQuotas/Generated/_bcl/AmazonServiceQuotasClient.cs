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
 * Do not modify this file. This file is generated from the service-quotas-2019-06-24.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ServiceQuotas.Model;
using Amazon.ServiceQuotas.Model.Internal.MarshallTransformations;
using Amazon.ServiceQuotas.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.ServiceQuotas
{
    /// <summary>
    /// <para>Implementation for accessing ServiceQuotas</para>
    ///
    /// With Service Quotas, you can view and manage your quotas easily as your Amazon Web
    /// Services workloads grow. Quotas, also referred to as limits, are the maximum number
    /// of resources that you can create in your Amazon Web Services account. For more information,
    /// see the <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/">Service
    /// Quotas User Guide</a>.
    /// 
    ///  
    /// <para>
    /// You need Amazon Web Services CLI version 2.13.20 or higher to view and manage resource-level
    /// quotas such as <c>Instances per domain</c> for Amazon OpenSearch Service.
    /// </para>
    /// </summary>
    public partial class AmazonServiceQuotasClient : AmazonServiceClient, IAmazonServiceQuotas
    {
        private static IServiceMetadata serviceMetadata = new AmazonServiceQuotasMetadata();
        private IServiceQuotasPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IServiceQuotasPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ServiceQuotasPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonServiceQuotasClient with the credentials loaded from the application's
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
        public AmazonServiceQuotasClient()
            : base(new AmazonServiceQuotasConfig()) { }

        /// <summary>
        /// Constructs AmazonServiceQuotasClient with the credentials loaded from the application's
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
        public AmazonServiceQuotasClient(RegionEndpoint region)
            : base(new AmazonServiceQuotasConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonServiceQuotasClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonServiceQuotasClient Configuration Object</param>
        public AmazonServiceQuotasClient(AmazonServiceQuotasConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonServiceQuotasClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonServiceQuotasClient(AWSCredentials credentials)
            : this(credentials, new AmazonServiceQuotasConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonServiceQuotasClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonServiceQuotasClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonServiceQuotasConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonServiceQuotasClient with AWS Credentials and an
        /// AmazonServiceQuotasClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonServiceQuotasClient Configuration Object</param>
        public AmazonServiceQuotasClient(AWSCredentials credentials, AmazonServiceQuotasConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonServiceQuotasClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonServiceQuotasClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonServiceQuotasConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonServiceQuotasClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonServiceQuotasClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonServiceQuotasConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonServiceQuotasClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonServiceQuotasClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonServiceQuotasClient Configuration Object</param>
        public AmazonServiceQuotasClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonServiceQuotasConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonServiceQuotasClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonServiceQuotasClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonServiceQuotasConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonServiceQuotasClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonServiceQuotasClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonServiceQuotasConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonServiceQuotasClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonServiceQuotasClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonServiceQuotasClient Configuration Object</param>
        public AmazonServiceQuotasClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonServiceQuotasConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonServiceQuotasEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonServiceQuotasAuthSchemeHandler());
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


        #region  AssociateServiceQuotaTemplate


        /// <summary>
        /// Associates your quota request template with your organization. When a new Amazon Web
        /// Services account is created in your organization, the quota increase requests in the
        /// template are automatically applied to the account. You can add a quota increase request
        /// for any adjustable quota to your template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateServiceQuotaTemplate service method.</param>
        /// 
        /// <returns>The response from the AssociateServiceQuotaTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoAvailableOrganizationException">
        /// The Amazon Web Services account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.OrganizationNotInAllFeaturesModeException">
        /// The organization that your Amazon Web Services account belongs to is not in All Features
        /// mode.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in this Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/AssociateServiceQuotaTemplate">REST API Reference for AssociateServiceQuotaTemplate Operation</seealso>
        public virtual AssociateServiceQuotaTemplateResponse AssociateServiceQuotaTemplate(AssociateServiceQuotaTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateServiceQuotaTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateServiceQuotaTemplateResponseUnmarshaller.Instance;

            return Invoke<AssociateServiceQuotaTemplateResponse>(request, options);
        }


        /// <summary>
        /// Associates your quota request template with your organization. When a new Amazon Web
        /// Services account is created in your organization, the quota increase requests in the
        /// template are automatically applied to the account. You can add a quota increase request
        /// for any adjustable quota to your template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateServiceQuotaTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateServiceQuotaTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoAvailableOrganizationException">
        /// The Amazon Web Services account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.OrganizationNotInAllFeaturesModeException">
        /// The organization that your Amazon Web Services account belongs to is not in All Features
        /// mode.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in this Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/AssociateServiceQuotaTemplate">REST API Reference for AssociateServiceQuotaTemplate Operation</seealso>
        public virtual Task<AssociateServiceQuotaTemplateResponse> AssociateServiceQuotaTemplateAsync(AssociateServiceQuotaTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateServiceQuotaTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateServiceQuotaTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateServiceQuotaTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSupportCase


        /// <summary>
        /// Creates a Support case for an existing quota increase request. This call only creates
        /// a Support case if the request has a <c>Pending</c> status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSupportCase service method.</param>
        /// 
        /// <returns>The response from the CreateSupportCase service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.InvalidResourceStateException">
        /// The resource is in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/CreateSupportCase">REST API Reference for CreateSupportCase Operation</seealso>
        public virtual CreateSupportCaseResponse CreateSupportCase(CreateSupportCaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSupportCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSupportCaseResponseUnmarshaller.Instance;

            return Invoke<CreateSupportCaseResponse>(request, options);
        }


        /// <summary>
        /// Creates a Support case for an existing quota increase request. This call only creates
        /// a Support case if the request has a <c>Pending</c> status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSupportCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSupportCase service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.InvalidResourceStateException">
        /// The resource is in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/CreateSupportCase">REST API Reference for CreateSupportCase Operation</seealso>
        public virtual Task<CreateSupportCaseResponse> CreateSupportCaseAsync(CreateSupportCaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSupportCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSupportCaseResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateSupportCaseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteServiceQuotaIncreaseRequestFromTemplate


        /// <summary>
        /// Deletes the quota increase request for the specified quota from your quota request
        /// template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceQuotaIncreaseRequestFromTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteServiceQuotaIncreaseRequestFromTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoAvailableOrganizationException">
        /// The Amazon Web Services account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in this Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/DeleteServiceQuotaIncreaseRequestFromTemplate">REST API Reference for DeleteServiceQuotaIncreaseRequestFromTemplate Operation</seealso>
        public virtual DeleteServiceQuotaIncreaseRequestFromTemplateResponse DeleteServiceQuotaIncreaseRequestFromTemplate(DeleteServiceQuotaIncreaseRequestFromTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteServiceQuotaIncreaseRequestFromTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceQuotaIncreaseRequestFromTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceQuotaIncreaseRequestFromTemplateResponse>(request, options);
        }


        /// <summary>
        /// Deletes the quota increase request for the specified quota from your quota request
        /// template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceQuotaIncreaseRequestFromTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteServiceQuotaIncreaseRequestFromTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoAvailableOrganizationException">
        /// The Amazon Web Services account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in this Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/DeleteServiceQuotaIncreaseRequestFromTemplate">REST API Reference for DeleteServiceQuotaIncreaseRequestFromTemplate Operation</seealso>
        public virtual Task<DeleteServiceQuotaIncreaseRequestFromTemplateResponse> DeleteServiceQuotaIncreaseRequestFromTemplateAsync(DeleteServiceQuotaIncreaseRequestFromTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteServiceQuotaIncreaseRequestFromTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceQuotaIncreaseRequestFromTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteServiceQuotaIncreaseRequestFromTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateServiceQuotaTemplate


        /// <summary>
        /// Disables your quota request template. After a template is disabled, the quota increase
        /// requests in the template are not applied to new Amazon Web Services accounts in your
        /// organization. Disabling a quota request template does not apply its quota increase
        /// requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateServiceQuotaTemplate service method.</param>
        /// 
        /// <returns>The response from the DisassociateServiceQuotaTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoAvailableOrganizationException">
        /// The Amazon Web Services account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceQuotaTemplateNotInUseException">
        /// The quota request template is not associated with your organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in this Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/DisassociateServiceQuotaTemplate">REST API Reference for DisassociateServiceQuotaTemplate Operation</seealso>
        public virtual DisassociateServiceQuotaTemplateResponse DisassociateServiceQuotaTemplate(DisassociateServiceQuotaTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateServiceQuotaTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateServiceQuotaTemplateResponseUnmarshaller.Instance;

            return Invoke<DisassociateServiceQuotaTemplateResponse>(request, options);
        }


        /// <summary>
        /// Disables your quota request template. After a template is disabled, the quota increase
        /// requests in the template are not applied to new Amazon Web Services accounts in your
        /// organization. Disabling a quota request template does not apply its quota increase
        /// requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateServiceQuotaTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateServiceQuotaTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoAvailableOrganizationException">
        /// The Amazon Web Services account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceQuotaTemplateNotInUseException">
        /// The quota request template is not associated with your organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in this Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/DisassociateServiceQuotaTemplate">REST API Reference for DisassociateServiceQuotaTemplate Operation</seealso>
        public virtual Task<DisassociateServiceQuotaTemplateResponse> DisassociateServiceQuotaTemplateAsync(DisassociateServiceQuotaTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateServiceQuotaTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateServiceQuotaTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateServiceQuotaTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAssociationForServiceQuotaTemplate


        /// <summary>
        /// Retrieves the status of the association for the quota request template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssociationForServiceQuotaTemplate service method.</param>
        /// 
        /// <returns>The response from the GetAssociationForServiceQuotaTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoAvailableOrganizationException">
        /// The Amazon Web Services account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceQuotaTemplateNotInUseException">
        /// The quota request template is not associated with your organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in this Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetAssociationForServiceQuotaTemplate">REST API Reference for GetAssociationForServiceQuotaTemplate Operation</seealso>
        public virtual GetAssociationForServiceQuotaTemplateResponse GetAssociationForServiceQuotaTemplate(GetAssociationForServiceQuotaTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssociationForServiceQuotaTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssociationForServiceQuotaTemplateResponseUnmarshaller.Instance;

            return Invoke<GetAssociationForServiceQuotaTemplateResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the status of the association for the quota request template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssociationForServiceQuotaTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAssociationForServiceQuotaTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoAvailableOrganizationException">
        /// The Amazon Web Services account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceQuotaTemplateNotInUseException">
        /// The quota request template is not associated with your organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in this Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetAssociationForServiceQuotaTemplate">REST API Reference for GetAssociationForServiceQuotaTemplate Operation</seealso>
        public virtual Task<GetAssociationForServiceQuotaTemplateResponse> GetAssociationForServiceQuotaTemplateAsync(GetAssociationForServiceQuotaTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssociationForServiceQuotaTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssociationForServiceQuotaTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAssociationForServiceQuotaTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAWSDefaultServiceQuota


        /// <summary>
        /// Retrieves the default value for the specified quota. The default value does not reflect
        /// any quota increases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAWSDefaultServiceQuota service method.</param>
        /// 
        /// <returns>The response from the GetAWSDefaultServiceQuota service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetAWSDefaultServiceQuota">REST API Reference for GetAWSDefaultServiceQuota Operation</seealso>
        public virtual GetAWSDefaultServiceQuotaResponse GetAWSDefaultServiceQuota(GetAWSDefaultServiceQuotaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAWSDefaultServiceQuotaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAWSDefaultServiceQuotaResponseUnmarshaller.Instance;

            return Invoke<GetAWSDefaultServiceQuotaResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the default value for the specified quota. The default value does not reflect
        /// any quota increases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAWSDefaultServiceQuota service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAWSDefaultServiceQuota service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetAWSDefaultServiceQuota">REST API Reference for GetAWSDefaultServiceQuota Operation</seealso>
        public virtual Task<GetAWSDefaultServiceQuotaResponse> GetAWSDefaultServiceQuotaAsync(GetAWSDefaultServiceQuotaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAWSDefaultServiceQuotaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAWSDefaultServiceQuotaResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAWSDefaultServiceQuotaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRequestedServiceQuotaChange


        /// <summary>
        /// Retrieves information about the specified quota increase request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRequestedServiceQuotaChange service method.</param>
        /// 
        /// <returns>The response from the GetRequestedServiceQuotaChange service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetRequestedServiceQuotaChange">REST API Reference for GetRequestedServiceQuotaChange Operation</seealso>
        public virtual GetRequestedServiceQuotaChangeResponse GetRequestedServiceQuotaChange(GetRequestedServiceQuotaChangeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRequestedServiceQuotaChangeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRequestedServiceQuotaChangeResponseUnmarshaller.Instance;

            return Invoke<GetRequestedServiceQuotaChangeResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about the specified quota increase request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRequestedServiceQuotaChange service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRequestedServiceQuotaChange service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetRequestedServiceQuotaChange">REST API Reference for GetRequestedServiceQuotaChange Operation</seealso>
        public virtual Task<GetRequestedServiceQuotaChangeResponse> GetRequestedServiceQuotaChangeAsync(GetRequestedServiceQuotaChangeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRequestedServiceQuotaChangeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRequestedServiceQuotaChangeResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRequestedServiceQuotaChangeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetServiceQuota


        /// <summary>
        /// Retrieves the applied quota value for the specified account-level or resource-level
        /// quota. For some quotas, only the default values are available. If the applied quota
        /// value is not available for a quota, the quota is not retrieved.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceQuota service method.</param>
        /// 
        /// <returns>The response from the GetServiceQuota service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetServiceQuota">REST API Reference for GetServiceQuota Operation</seealso>
        public virtual GetServiceQuotaResponse GetServiceQuota(GetServiceQuotaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetServiceQuotaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceQuotaResponseUnmarshaller.Instance;

            return Invoke<GetServiceQuotaResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the applied quota value for the specified account-level or resource-level
        /// quota. For some quotas, only the default values are available. If the applied quota
        /// value is not available for a quota, the quota is not retrieved.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceQuota service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServiceQuota service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetServiceQuota">REST API Reference for GetServiceQuota Operation</seealso>
        public virtual Task<GetServiceQuotaResponse> GetServiceQuotaAsync(GetServiceQuotaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetServiceQuotaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceQuotaResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetServiceQuotaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetServiceQuotaIncreaseRequestFromTemplate


        /// <summary>
        /// Retrieves information about the specified quota increase request in your quota request
        /// template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceQuotaIncreaseRequestFromTemplate service method.</param>
        /// 
        /// <returns>The response from the GetServiceQuotaIncreaseRequestFromTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoAvailableOrganizationException">
        /// The Amazon Web Services account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in this Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetServiceQuotaIncreaseRequestFromTemplate">REST API Reference for GetServiceQuotaIncreaseRequestFromTemplate Operation</seealso>
        public virtual GetServiceQuotaIncreaseRequestFromTemplateResponse GetServiceQuotaIncreaseRequestFromTemplate(GetServiceQuotaIncreaseRequestFromTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetServiceQuotaIncreaseRequestFromTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceQuotaIncreaseRequestFromTemplateResponseUnmarshaller.Instance;

            return Invoke<GetServiceQuotaIncreaseRequestFromTemplateResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about the specified quota increase request in your quota request
        /// template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceQuotaIncreaseRequestFromTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServiceQuotaIncreaseRequestFromTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoAvailableOrganizationException">
        /// The Amazon Web Services account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in this Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetServiceQuotaIncreaseRequestFromTemplate">REST API Reference for GetServiceQuotaIncreaseRequestFromTemplate Operation</seealso>
        public virtual Task<GetServiceQuotaIncreaseRequestFromTemplateResponse> GetServiceQuotaIncreaseRequestFromTemplateAsync(GetServiceQuotaIncreaseRequestFromTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetServiceQuotaIncreaseRequestFromTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceQuotaIncreaseRequestFromTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetServiceQuotaIncreaseRequestFromTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAWSDefaultServiceQuotas


        /// <summary>
        /// Lists the default values for the quotas for the specified Amazon Web Services service.
        /// A default value does not reflect any quota increases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAWSDefaultServiceQuotas service method.</param>
        /// 
        /// <returns>The response from the ListAWSDefaultServiceQuotas service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.InvalidPaginationTokenException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListAWSDefaultServiceQuotas">REST API Reference for ListAWSDefaultServiceQuotas Operation</seealso>
        public virtual ListAWSDefaultServiceQuotasResponse ListAWSDefaultServiceQuotas(ListAWSDefaultServiceQuotasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAWSDefaultServiceQuotasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAWSDefaultServiceQuotasResponseUnmarshaller.Instance;

            return Invoke<ListAWSDefaultServiceQuotasResponse>(request, options);
        }


        /// <summary>
        /// Lists the default values for the quotas for the specified Amazon Web Services service.
        /// A default value does not reflect any quota increases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAWSDefaultServiceQuotas service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAWSDefaultServiceQuotas service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.InvalidPaginationTokenException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListAWSDefaultServiceQuotas">REST API Reference for ListAWSDefaultServiceQuotas Operation</seealso>
        public virtual Task<ListAWSDefaultServiceQuotasResponse> ListAWSDefaultServiceQuotasAsync(ListAWSDefaultServiceQuotasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAWSDefaultServiceQuotasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAWSDefaultServiceQuotasResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAWSDefaultServiceQuotasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRequestedServiceQuotaChangeHistory


        /// <summary>
        /// Retrieves the quota increase requests for the specified Amazon Web Services service.
        /// Filter responses to return quota requests at either the account level, resource level,
        /// or all levels. Responses include any open or closed requests within 90 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRequestedServiceQuotaChangeHistory service method.</param>
        /// 
        /// <returns>The response from the ListRequestedServiceQuotaChangeHistory service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.InvalidPaginationTokenException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListRequestedServiceQuotaChangeHistory">REST API Reference for ListRequestedServiceQuotaChangeHistory Operation</seealso>
        public virtual ListRequestedServiceQuotaChangeHistoryResponse ListRequestedServiceQuotaChangeHistory(ListRequestedServiceQuotaChangeHistoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRequestedServiceQuotaChangeHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRequestedServiceQuotaChangeHistoryResponseUnmarshaller.Instance;

            return Invoke<ListRequestedServiceQuotaChangeHistoryResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the quota increase requests for the specified Amazon Web Services service.
        /// Filter responses to return quota requests at either the account level, resource level,
        /// or all levels. Responses include any open or closed requests within 90 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRequestedServiceQuotaChangeHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRequestedServiceQuotaChangeHistory service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.InvalidPaginationTokenException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListRequestedServiceQuotaChangeHistory">REST API Reference for ListRequestedServiceQuotaChangeHistory Operation</seealso>
        public virtual Task<ListRequestedServiceQuotaChangeHistoryResponse> ListRequestedServiceQuotaChangeHistoryAsync(ListRequestedServiceQuotaChangeHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRequestedServiceQuotaChangeHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRequestedServiceQuotaChangeHistoryResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRequestedServiceQuotaChangeHistoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRequestedServiceQuotaChangeHistoryByQuota


        /// <summary>
        /// Retrieves the quota increase requests for the specified quota. Filter responses to
        /// return quota requests at either the account level, resource level, or all levels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRequestedServiceQuotaChangeHistoryByQuota service method.</param>
        /// 
        /// <returns>The response from the ListRequestedServiceQuotaChangeHistoryByQuota service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.InvalidPaginationTokenException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListRequestedServiceQuotaChangeHistoryByQuota">REST API Reference for ListRequestedServiceQuotaChangeHistoryByQuota Operation</seealso>
        public virtual ListRequestedServiceQuotaChangeHistoryByQuotaResponse ListRequestedServiceQuotaChangeHistoryByQuota(ListRequestedServiceQuotaChangeHistoryByQuotaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRequestedServiceQuotaChangeHistoryByQuotaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRequestedServiceQuotaChangeHistoryByQuotaResponseUnmarshaller.Instance;

            return Invoke<ListRequestedServiceQuotaChangeHistoryByQuotaResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the quota increase requests for the specified quota. Filter responses to
        /// return quota requests at either the account level, resource level, or all levels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRequestedServiceQuotaChangeHistoryByQuota service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRequestedServiceQuotaChangeHistoryByQuota service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.InvalidPaginationTokenException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListRequestedServiceQuotaChangeHistoryByQuota">REST API Reference for ListRequestedServiceQuotaChangeHistoryByQuota Operation</seealso>
        public virtual Task<ListRequestedServiceQuotaChangeHistoryByQuotaResponse> ListRequestedServiceQuotaChangeHistoryByQuotaAsync(ListRequestedServiceQuotaChangeHistoryByQuotaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRequestedServiceQuotaChangeHistoryByQuotaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRequestedServiceQuotaChangeHistoryByQuotaResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRequestedServiceQuotaChangeHistoryByQuotaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServiceQuotaIncreaseRequestsInTemplate


        /// <summary>
        /// Lists the quota increase requests in the specified quota request template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceQuotaIncreaseRequestsInTemplate service method.</param>
        /// 
        /// <returns>The response from the ListServiceQuotaIncreaseRequestsInTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoAvailableOrganizationException">
        /// The Amazon Web Services account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in this Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListServiceQuotaIncreaseRequestsInTemplate">REST API Reference for ListServiceQuotaIncreaseRequestsInTemplate Operation</seealso>
        public virtual ListServiceQuotaIncreaseRequestsInTemplateResponse ListServiceQuotaIncreaseRequestsInTemplate(ListServiceQuotaIncreaseRequestsInTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServiceQuotaIncreaseRequestsInTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceQuotaIncreaseRequestsInTemplateResponseUnmarshaller.Instance;

            return Invoke<ListServiceQuotaIncreaseRequestsInTemplateResponse>(request, options);
        }


        /// <summary>
        /// Lists the quota increase requests in the specified quota request template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceQuotaIncreaseRequestsInTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServiceQuotaIncreaseRequestsInTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoAvailableOrganizationException">
        /// The Amazon Web Services account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in this Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListServiceQuotaIncreaseRequestsInTemplate">REST API Reference for ListServiceQuotaIncreaseRequestsInTemplate Operation</seealso>
        public virtual Task<ListServiceQuotaIncreaseRequestsInTemplateResponse> ListServiceQuotaIncreaseRequestsInTemplateAsync(ListServiceQuotaIncreaseRequestsInTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServiceQuotaIncreaseRequestsInTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceQuotaIncreaseRequestsInTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListServiceQuotaIncreaseRequestsInTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServiceQuotas


        /// <summary>
        /// Lists the applied quota values for the specified Amazon Web Services service. For
        /// some quotas, only the default values are available. If the applied quota value is
        /// not available for a quota, the quota is not retrieved. Filter responses to return
        /// applied quota values at either the account level, resource level, or all levels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceQuotas service method.</param>
        /// 
        /// <returns>The response from the ListServiceQuotas service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.InvalidPaginationTokenException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListServiceQuotas">REST API Reference for ListServiceQuotas Operation</seealso>
        public virtual ListServiceQuotasResponse ListServiceQuotas(ListServiceQuotasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServiceQuotasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceQuotasResponseUnmarshaller.Instance;

            return Invoke<ListServiceQuotasResponse>(request, options);
        }


        /// <summary>
        /// Lists the applied quota values for the specified Amazon Web Services service. For
        /// some quotas, only the default values are available. If the applied quota value is
        /// not available for a quota, the quota is not retrieved. Filter responses to return
        /// applied quota values at either the account level, resource level, or all levels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceQuotas service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServiceQuotas service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.InvalidPaginationTokenException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListServiceQuotas">REST API Reference for ListServiceQuotas Operation</seealso>
        public virtual Task<ListServiceQuotasResponse> ListServiceQuotasAsync(ListServiceQuotasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServiceQuotasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceQuotasResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListServiceQuotasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServices


        /// <summary>
        /// Lists the names and codes for the Amazon Web Services services integrated with Service
        /// Quotas.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// 
        /// <returns>The response from the ListServices service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.InvalidPaginationTokenException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListServices">REST API Reference for ListServices Operation</seealso>
        public virtual ListServicesResponse ListServices(ListServicesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicesResponseUnmarshaller.Instance;

            return Invoke<ListServicesResponse>(request, options);
        }


        /// <summary>
        /// Lists the names and codes for the Amazon Web Services services integrated with Service
        /// Quotas.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServices service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.InvalidPaginationTokenException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListServices">REST API Reference for ListServices Operation</seealso>
        public virtual Task<ListServicesResponse> ListServicesAsync(ListServicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListServicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns a list of the tags assigned to the specified applied quota.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of the tags assigned to the specified applied quota.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutServiceQuotaIncreaseRequestIntoTemplate


        /// <summary>
        /// Adds a quota increase request to your quota request template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutServiceQuotaIncreaseRequestIntoTemplate service method.</param>
        /// 
        /// <returns>The response from the PutServiceQuotaIncreaseRequestIntoTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoAvailableOrganizationException">
        /// The Amazon Web Services account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.QuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in this Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/PutServiceQuotaIncreaseRequestIntoTemplate">REST API Reference for PutServiceQuotaIncreaseRequestIntoTemplate Operation</seealso>
        public virtual PutServiceQuotaIncreaseRequestIntoTemplateResponse PutServiceQuotaIncreaseRequestIntoTemplate(PutServiceQuotaIncreaseRequestIntoTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutServiceQuotaIncreaseRequestIntoTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutServiceQuotaIncreaseRequestIntoTemplateResponseUnmarshaller.Instance;

            return Invoke<PutServiceQuotaIncreaseRequestIntoTemplateResponse>(request, options);
        }


        /// <summary>
        /// Adds a quota increase request to your quota request template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutServiceQuotaIncreaseRequestIntoTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutServiceQuotaIncreaseRequestIntoTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoAvailableOrganizationException">
        /// The Amazon Web Services account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.QuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in this Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/PutServiceQuotaIncreaseRequestIntoTemplate">REST API Reference for PutServiceQuotaIncreaseRequestIntoTemplate Operation</seealso>
        public virtual Task<PutServiceQuotaIncreaseRequestIntoTemplateResponse> PutServiceQuotaIncreaseRequestIntoTemplateAsync(PutServiceQuotaIncreaseRequestIntoTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutServiceQuotaIncreaseRequestIntoTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutServiceQuotaIncreaseRequestIntoTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutServiceQuotaIncreaseRequestIntoTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RequestServiceQuotaIncrease


        /// <summary>
        /// Submits a quota increase request for the specified quota at the account or resource
        /// level.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestServiceQuotaIncrease service method.</param>
        /// 
        /// <returns>The response from the RequestServiceQuotaIncrease service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.InvalidResourceStateException">
        /// The resource is in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.QuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/RequestServiceQuotaIncrease">REST API Reference for RequestServiceQuotaIncrease Operation</seealso>
        public virtual RequestServiceQuotaIncreaseResponse RequestServiceQuotaIncrease(RequestServiceQuotaIncreaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RequestServiceQuotaIncreaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestServiceQuotaIncreaseResponseUnmarshaller.Instance;

            return Invoke<RequestServiceQuotaIncreaseResponse>(request, options);
        }


        /// <summary>
        /// Submits a quota increase request for the specified quota at the account or resource
        /// level.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestServiceQuotaIncrease service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RequestServiceQuotaIncrease service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.InvalidResourceStateException">
        /// The resource is in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.QuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/RequestServiceQuotaIncrease">REST API Reference for RequestServiceQuotaIncrease Operation</seealso>
        public virtual Task<RequestServiceQuotaIncreaseResponse> RequestServiceQuotaIncreaseAsync(RequestServiceQuotaIncreaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RequestServiceQuotaIncreaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestServiceQuotaIncreaseResponseUnmarshaller.Instance;
            
            return InvokeAsync<RequestServiceQuotaIncreaseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to the specified applied quota. You can include one or more tags to add
        /// to the quota.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TagPolicyViolationException">
        /// The specified tag is a reserved word and cannot be used.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyTagsException">
        /// You've exceeded the number of tags allowed for a resource. For more information, see
        /// <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/sq-tagging.html#sq-tagging-restrictions">Tag
        /// restrictions</a> in the <i>Service Quotas User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds tags to the specified applied quota. You can include one or more tags to add
        /// to the quota.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TagPolicyViolationException">
        /// The specified tag is a reserved word and cannot be used.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyTagsException">
        /// You've exceeded the number of tags allowed for a resource. For more information, see
        /// <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/sq-tagging.html#sq-tagging-restrictions">Tag
        /// restrictions</a> in the <i>Service Quotas User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes tags from the specified applied quota. You can specify one or more tags to
        /// remove.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes tags from the specified applied quota. You can specify one or more tags to
        /// remove.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
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