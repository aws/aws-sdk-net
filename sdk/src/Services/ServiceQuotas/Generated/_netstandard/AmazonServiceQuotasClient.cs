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

namespace Amazon.ServiceQuotas
{
    /// <summary>
    /// Implementation for accessing ServiceQuotas
    ///
    /// Service Quotas is a web service that you can use to manage many of your AWS service
    /// quotas. Quotas, also referred to as limits, are the maximum values for a resource,
    /// item, or operation. This guide provide descriptions of the Service Quotas actions
    /// that you can call from an API. For the Service Quotas user guide, which explains how
    /// to use Service Quotas from the console, see <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/intro.html">What
    /// is Service Quotas</a>. 
    /// 
    ///  <note> 
    /// <para>
    /// AWS provides SDKs that consist of libraries and sample code for programming languages
    /// and platforms (Java, Ruby, .NET, iOS, Android, etc...,). The SDKs provide a convenient
    /// way to create programmatic access to Service Quotas and AWS. For information about
    /// the AWS SDKs, including how to download and install them, see the <a href="https://docs.aws.amazon.com/aws.amazon.com/tools">Tools
    /// for Amazon Web Services</a> page.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AmazonServiceQuotasClient : AmazonServiceClient, IAmazonServiceQuotas
    {
        private static IServiceMetadata serviceMetadata = new AmazonServiceQuotasMetadata();
        
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonServiceQuotasConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonServiceQuotasConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


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
#if AWS_ASYNC_ENUMERABLES_API
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


        #region  AssociateServiceQuotaTemplate

        internal virtual AssociateServiceQuotaTemplateResponse AssociateServiceQuotaTemplate(AssociateServiceQuotaTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateServiceQuotaTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateServiceQuotaTemplateResponseUnmarshaller.Instance;

            return Invoke<AssociateServiceQuotaTemplateResponse>(request, options);
        }



        /// <summary>
        /// Associates the Service Quotas template with your organization so that when new accounts
        /// are created in your organization, the template submits increase requests for the specified
        /// service quotas. Use the Service Quotas template to request an increase for any adjustable
        /// quota value. After you define the Service Quotas template, use this operation to associate,
        /// or enable, the template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateServiceQuotaTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateServiceQuotaTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization. To enable, call <a>AssociateServiceQuotaTemplate</a>.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoAvailableOrganizationException">
        /// The account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.OrganizationNotInAllFeaturesModeException">
        /// The organization that your account belongs to, is not in All Features mode. To enable
        /// all features mode, see <a href="https://docs.aws.amazon.com/organizations/latest/APIReference/API_EnableAllFeatures.html">EnableAllFeatures</a>.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in the Region where you are making the
        /// request. Please make the request in us-east-1.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/AssociateServiceQuotaTemplate">REST API Reference for AssociateServiceQuotaTemplate Operation</seealso>
        public virtual Task<AssociateServiceQuotaTemplateResponse> AssociateServiceQuotaTemplateAsync(AssociateServiceQuotaTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateServiceQuotaTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateServiceQuotaTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateServiceQuotaTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteServiceQuotaIncreaseRequestFromTemplate

        internal virtual DeleteServiceQuotaIncreaseRequestFromTemplateResponse DeleteServiceQuotaIncreaseRequestFromTemplate(DeleteServiceQuotaIncreaseRequestFromTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceQuotaIncreaseRequestFromTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceQuotaIncreaseRequestFromTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceQuotaIncreaseRequestFromTemplateResponse>(request, options);
        }



        /// <summary>
        /// Removes a service quota increase request from the Service Quotas template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceQuotaIncreaseRequestFromTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteServiceQuotaIncreaseRequestFromTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization. To enable, call <a>AssociateServiceQuotaTemplate</a>.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoAvailableOrganizationException">
        /// The account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in the Region where you are making the
        /// request. Please make the request in us-east-1.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/DeleteServiceQuotaIncreaseRequestFromTemplate">REST API Reference for DeleteServiceQuotaIncreaseRequestFromTemplate Operation</seealso>
        public virtual Task<DeleteServiceQuotaIncreaseRequestFromTemplateResponse> DeleteServiceQuotaIncreaseRequestFromTemplateAsync(DeleteServiceQuotaIncreaseRequestFromTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceQuotaIncreaseRequestFromTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceQuotaIncreaseRequestFromTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteServiceQuotaIncreaseRequestFromTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateServiceQuotaTemplate

        internal virtual DisassociateServiceQuotaTemplateResponse DisassociateServiceQuotaTemplate(DisassociateServiceQuotaTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateServiceQuotaTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateServiceQuotaTemplateResponseUnmarshaller.Instance;

            return Invoke<DisassociateServiceQuotaTemplateResponse>(request, options);
        }



        /// <summary>
        /// Disables the Service Quotas template. Once the template is disabled, it does not request
        /// quota increases for new accounts in your organization. Disabling the quota template
        /// does not apply the quota increase requests from the template. 
        /// 
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To enable the quota template, call <a>AssociateServiceQuotaTemplate</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To delete a specific service quota from the template, use <a>DeleteServiceQuotaIncreaseRequestFromTemplate</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateServiceQuotaTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateServiceQuotaTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization. To enable, call <a>AssociateServiceQuotaTemplate</a>.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoAvailableOrganizationException">
        /// The account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceQuotaTemplateNotInUseException">
        /// The quota request template is not associated with your organization. 
        /// 
        ///  
        /// <para>
        /// To use the template, call <a>AssociateServiceQuotaTemplate</a>. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in the Region where you are making the
        /// request. Please make the request in us-east-1.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/DisassociateServiceQuotaTemplate">REST API Reference for DisassociateServiceQuotaTemplate Operation</seealso>
        public virtual Task<DisassociateServiceQuotaTemplateResponse> DisassociateServiceQuotaTemplateAsync(DisassociateServiceQuotaTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateServiceQuotaTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateServiceQuotaTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateServiceQuotaTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAssociationForServiceQuotaTemplate

        internal virtual GetAssociationForServiceQuotaTemplateResponse GetAssociationForServiceQuotaTemplate(GetAssociationForServiceQuotaTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssociationForServiceQuotaTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssociationForServiceQuotaTemplateResponseUnmarshaller.Instance;

            return Invoke<GetAssociationForServiceQuotaTemplateResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the <code>ServiceQuotaTemplateAssociationStatus</code> value from the service.
        /// Use this action to determine if the Service Quota template is associated, or enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssociationForServiceQuotaTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAssociationForServiceQuotaTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization. To enable, call <a>AssociateServiceQuotaTemplate</a>.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoAvailableOrganizationException">
        /// The account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceQuotaTemplateNotInUseException">
        /// The quota request template is not associated with your organization. 
        /// 
        ///  
        /// <para>
        /// To use the template, call <a>AssociateServiceQuotaTemplate</a>. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in the Region where you are making the
        /// request. Please make the request in us-east-1.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetAssociationForServiceQuotaTemplate">REST API Reference for GetAssociationForServiceQuotaTemplate Operation</seealso>
        public virtual Task<GetAssociationForServiceQuotaTemplateResponse> GetAssociationForServiceQuotaTemplateAsync(GetAssociationForServiceQuotaTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssociationForServiceQuotaTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssociationForServiceQuotaTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetAssociationForServiceQuotaTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAWSDefaultServiceQuota

        internal virtual GetAWSDefaultServiceQuotaResponse GetAWSDefaultServiceQuota(GetAWSDefaultServiceQuotaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAWSDefaultServiceQuotaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAWSDefaultServiceQuotaResponseUnmarshaller.Instance;

            return Invoke<GetAWSDefaultServiceQuotaResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the default service quotas values. The Value returned for each quota is
        /// the AWS default value, even if the quotas have been increased..
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAWSDefaultServiceQuota service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAWSDefaultServiceQuota service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAWSDefaultServiceQuotaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAWSDefaultServiceQuotaResponseUnmarshaller.Instance;

            return InvokeAsync<GetAWSDefaultServiceQuotaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRequestedServiceQuotaChange

        internal virtual GetRequestedServiceQuotaChangeResponse GetRequestedServiceQuotaChange(GetRequestedServiceQuotaChangeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRequestedServiceQuotaChangeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRequestedServiceQuotaChangeResponseUnmarshaller.Instance;

            return Invoke<GetRequestedServiceQuotaChangeResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details for a particular increase request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRequestedServiceQuotaChange service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRequestedServiceQuotaChange service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRequestedServiceQuotaChangeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRequestedServiceQuotaChangeResponseUnmarshaller.Instance;

            return InvokeAsync<GetRequestedServiceQuotaChangeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetServiceQuota

        internal virtual GetServiceQuotaResponse GetServiceQuota(GetServiceQuotaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceQuotaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceQuotaResponseUnmarshaller.Instance;

            return Invoke<GetServiceQuotaResponse>(request, options);
        }



        /// <summary>
        /// Returns the details for the specified service quota. This operation provides a different
        /// Value than the <code>GetAWSDefaultServiceQuota</code> operation. This operation returns
        /// the applied value for each quota. <code>GetAWSDefaultServiceQuota</code> returns the
        /// default AWS value for each quota.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceQuota service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServiceQuota service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceQuotaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceQuotaResponseUnmarshaller.Instance;

            return InvokeAsync<GetServiceQuotaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetServiceQuotaIncreaseRequestFromTemplate

        internal virtual GetServiceQuotaIncreaseRequestFromTemplateResponse GetServiceQuotaIncreaseRequestFromTemplate(GetServiceQuotaIncreaseRequestFromTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceQuotaIncreaseRequestFromTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceQuotaIncreaseRequestFromTemplateResponseUnmarshaller.Instance;

            return Invoke<GetServiceQuotaIncreaseRequestFromTemplateResponse>(request, options);
        }



        /// <summary>
        /// Returns the details of the service quota increase request in your template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceQuotaIncreaseRequestFromTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServiceQuotaIncreaseRequestFromTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization. To enable, call <a>AssociateServiceQuotaTemplate</a>.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoAvailableOrganizationException">
        /// The account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoSuchResourceException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in the Region where you are making the
        /// request. Please make the request in us-east-1.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/GetServiceQuotaIncreaseRequestFromTemplate">REST API Reference for GetServiceQuotaIncreaseRequestFromTemplate Operation</seealso>
        public virtual Task<GetServiceQuotaIncreaseRequestFromTemplateResponse> GetServiceQuotaIncreaseRequestFromTemplateAsync(GetServiceQuotaIncreaseRequestFromTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceQuotaIncreaseRequestFromTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceQuotaIncreaseRequestFromTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetServiceQuotaIncreaseRequestFromTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAWSDefaultServiceQuotas

        internal virtual ListAWSDefaultServiceQuotasResponse ListAWSDefaultServiceQuotas(ListAWSDefaultServiceQuotasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAWSDefaultServiceQuotasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAWSDefaultServiceQuotasResponseUnmarshaller.Instance;

            return Invoke<ListAWSDefaultServiceQuotasResponse>(request, options);
        }



        /// <summary>
        /// Lists all default service quotas for the specified AWS service or all AWS services.
        /// ListAWSDefaultServiceQuotas is similar to <a>ListServiceQuotas</a> except for the
        /// Value object. The Value object returned by <code>ListAWSDefaultServiceQuotas</code>
        /// is the default value assigned by AWS. This request returns a list of all service quotas
        /// for the specified service. The listing of each you'll see the default values are the
        /// values that AWS provides for the quotas. 
        /// 
        ///  <note> 
        /// <para>
        /// Always check the <code>NextToken</code> response parameter when calling any of the
        /// <code>List*</code> operations. These operations can return an unexpected list of results,
        /// even when there are more results available. When this happens, the <code>NextToken</code>
        /// response parameter contains a value to pass the next call to the same API to request
        /// the next part of the list.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAWSDefaultServiceQuotas service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAWSDefaultServiceQuotas service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAWSDefaultServiceQuotasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAWSDefaultServiceQuotasResponseUnmarshaller.Instance;

            return InvokeAsync<ListAWSDefaultServiceQuotasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRequestedServiceQuotaChangeHistory

        internal virtual ListRequestedServiceQuotaChangeHistoryResponse ListRequestedServiceQuotaChangeHistory(ListRequestedServiceQuotaChangeHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRequestedServiceQuotaChangeHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRequestedServiceQuotaChangeHistoryResponseUnmarshaller.Instance;

            return Invoke<ListRequestedServiceQuotaChangeHistoryResponse>(request, options);
        }



        /// <summary>
        /// Requests a list of the changes to quotas for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRequestedServiceQuotaChangeHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRequestedServiceQuotaChangeHistory service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRequestedServiceQuotaChangeHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRequestedServiceQuotaChangeHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<ListRequestedServiceQuotaChangeHistoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRequestedServiceQuotaChangeHistoryByQuota

        internal virtual ListRequestedServiceQuotaChangeHistoryByQuotaResponse ListRequestedServiceQuotaChangeHistoryByQuota(ListRequestedServiceQuotaChangeHistoryByQuotaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRequestedServiceQuotaChangeHistoryByQuotaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRequestedServiceQuotaChangeHistoryByQuotaResponseUnmarshaller.Instance;

            return Invoke<ListRequestedServiceQuotaChangeHistoryByQuotaResponse>(request, options);
        }



        /// <summary>
        /// Requests a list of the changes to specific service quotas. This command provides additional
        /// granularity over the <code>ListRequestedServiceQuotaChangeHistory</code> command.
        /// Once a quota change request has reached <code>CASE_CLOSED, APPROVED,</code> or <code>DENIED</code>,
        /// the history has been kept for 90 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRequestedServiceQuotaChangeHistoryByQuota service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRequestedServiceQuotaChangeHistoryByQuota service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRequestedServiceQuotaChangeHistoryByQuotaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRequestedServiceQuotaChangeHistoryByQuotaResponseUnmarshaller.Instance;

            return InvokeAsync<ListRequestedServiceQuotaChangeHistoryByQuotaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServiceQuotaIncreaseRequestsInTemplate

        internal virtual ListServiceQuotaIncreaseRequestsInTemplateResponse ListServiceQuotaIncreaseRequestsInTemplate(ListServiceQuotaIncreaseRequestsInTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceQuotaIncreaseRequestsInTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceQuotaIncreaseRequestsInTemplateResponseUnmarshaller.Instance;

            return Invoke<ListServiceQuotaIncreaseRequestsInTemplateResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of the quota increase requests in the template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceQuotaIncreaseRequestsInTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServiceQuotaIncreaseRequestsInTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization. To enable, call <a>AssociateServiceQuotaTemplate</a>.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoAvailableOrganizationException">
        /// The account making this call is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.ServiceException">
        /// Something went wrong.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TemplatesNotAvailableInRegionException">
        /// The Service Quotas template is not available in the Region where you are making the
        /// request. Please make the request in us-east-1.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/ListServiceQuotaIncreaseRequestsInTemplate">REST API Reference for ListServiceQuotaIncreaseRequestsInTemplate Operation</seealso>
        public virtual Task<ListServiceQuotaIncreaseRequestsInTemplateResponse> ListServiceQuotaIncreaseRequestsInTemplateAsync(ListServiceQuotaIncreaseRequestsInTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceQuotaIncreaseRequestsInTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceQuotaIncreaseRequestsInTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<ListServiceQuotaIncreaseRequestsInTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServiceQuotas

        internal virtual ListServiceQuotasResponse ListServiceQuotas(ListServiceQuotasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceQuotasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceQuotasResponseUnmarshaller.Instance;

            return Invoke<ListServiceQuotasResponse>(request, options);
        }



        /// <summary>
        /// Lists all service quotas for the specified AWS service. This request returns a list
        /// of the service quotas for the specified service. you'll see the default values are
        /// the values that AWS provides for the quotas. 
        /// 
        ///  <note> 
        /// <para>
        /// Always check the <code>NextToken</code> response parameter when calling any of the
        /// <code>List*</code> operations. These operations can return an unexpected list of results,
        /// even when there are more results available. When this happens, the <code>NextToken</code>
        /// response parameter contains a value to pass the next call to the same API to request
        /// the next part of the list.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceQuotas service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServiceQuotas service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceQuotasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceQuotasResponseUnmarshaller.Instance;

            return InvokeAsync<ListServiceQuotasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServices

        internal virtual ListServicesResponse ListServices(ListServicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicesResponseUnmarshaller.Instance;

            return Invoke<ListServicesResponse>(request, options);
        }



        /// <summary>
        /// Lists the AWS services available in Service Quotas. Not all AWS services are available
        /// in Service Quotas. To list the see the list of the service quotas for a specific service,
        /// use <a>ListServiceQuotas</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServices service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicesResponseUnmarshaller.Instance;

            return InvokeAsync<ListServicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutServiceQuotaIncreaseRequestIntoTemplate

        internal virtual PutServiceQuotaIncreaseRequestIntoTemplateResponse PutServiceQuotaIncreaseRequestIntoTemplate(PutServiceQuotaIncreaseRequestIntoTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutServiceQuotaIncreaseRequestIntoTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutServiceQuotaIncreaseRequestIntoTemplateResponseUnmarshaller.Instance;

            return Invoke<PutServiceQuotaIncreaseRequestIntoTemplateResponse>(request, options);
        }



        /// <summary>
        /// Defines and adds a quota to the service quota template. To add a quota to the template,
        /// you must provide the <code>ServiceCode</code>, <code>QuotaCode</code>, <code>AwsRegion</code>,
        /// and <code>DesiredValue</code>. Once you add a quota to the template, use <a>ListServiceQuotaIncreaseRequestsInTemplate</a>
        /// to see the list of quotas in the template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutServiceQuotaIncreaseRequestIntoTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutServiceQuotaIncreaseRequestIntoTemplate service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.AWSServiceAccessNotEnabledException">
        /// The action you attempted is not allowed unless Service Access with Service Quotas
        /// is enabled in your organization. To enable, call <a>AssociateServiceQuotaTemplate</a>.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.NoAvailableOrganizationException">
        /// The account making this call is not a member of an organization.
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
        /// The Service Quotas template is not available in the Region where you are making the
        /// request. Please make the request in us-east-1.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.TooManyRequestsException">
        /// Due to throttling, the request was denied. Slow down the rate of request calls, or
        /// request an increase for this quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/service-quotas-2019-06-24/PutServiceQuotaIncreaseRequestIntoTemplate">REST API Reference for PutServiceQuotaIncreaseRequestIntoTemplate Operation</seealso>
        public virtual Task<PutServiceQuotaIncreaseRequestIntoTemplateResponse> PutServiceQuotaIncreaseRequestIntoTemplateAsync(PutServiceQuotaIncreaseRequestIntoTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutServiceQuotaIncreaseRequestIntoTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutServiceQuotaIncreaseRequestIntoTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<PutServiceQuotaIncreaseRequestIntoTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RequestServiceQuotaIncrease

        internal virtual RequestServiceQuotaIncreaseResponse RequestServiceQuotaIncrease(RequestServiceQuotaIncreaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RequestServiceQuotaIncreaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestServiceQuotaIncreaseResponseUnmarshaller.Instance;

            return Invoke<RequestServiceQuotaIncreaseResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details of a service quota increase request. The response to this command
        /// provides the details in the <a>RequestedServiceQuotaChange</a> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestServiceQuotaIncrease service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RequestServiceQuotaIncrease service method, as returned by ServiceQuotas.</returns>
        /// <exception cref="Amazon.ServiceQuotas.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.DependencyAccessDeniedException">
        /// You can't perform this action because a dependency does not have access.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.IllegalArgumentException">
        /// Invalid input was provided.
        /// </exception>
        /// <exception cref="Amazon.ServiceQuotas.Model.InvalidResourceStateException">
        /// Invalid input was provided for the .
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
            var options = new InvokeOptions();
            options.RequestMarshaller = RequestServiceQuotaIncreaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestServiceQuotaIncreaseResponseUnmarshaller.Instance;

            return InvokeAsync<RequestServiceQuotaIncreaseResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}