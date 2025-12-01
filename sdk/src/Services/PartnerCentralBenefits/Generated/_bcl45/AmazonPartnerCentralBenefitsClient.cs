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
 * Do not modify this file. This file is generated from the partnercentral-benefits-2018-05-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.PartnerCentralBenefits.Model;
using Amazon.PartnerCentralBenefits.Model.Internal.MarshallTransformations;
using Amazon.PartnerCentralBenefits.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.PartnerCentralBenefits
{
    /// <summary>
    /// <para>Implementation for accessing PartnerCentralBenefits</para>
    ///
    /// AWS Partner Central Benefits Service provides APIs for managing partner benefits,
    /// applications, and allocations within the AWS Partner Network ecosystem.
    /// </summary>
    public partial class AmazonPartnerCentralBenefitsClient : AmazonServiceClient, IAmazonPartnerCentralBenefits
    {
        private static IServiceMetadata serviceMetadata = new AmazonPartnerCentralBenefitsMetadata();
        private IPartnerCentralBenefitsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IPartnerCentralBenefitsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new PartnerCentralBenefitsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonPartnerCentralBenefitsClient with the credentials loaded from the application's
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
        public AmazonPartnerCentralBenefitsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPartnerCentralBenefitsConfig()) { }

        /// <summary>
        /// Constructs AmazonPartnerCentralBenefitsClient with the credentials loaded from the application's
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
        public AmazonPartnerCentralBenefitsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPartnerCentralBenefitsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPartnerCentralBenefitsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPartnerCentralBenefitsClient Configuration Object</param>
        public AmazonPartnerCentralBenefitsClient(AmazonPartnerCentralBenefitsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}

        /// <summary>
        /// Constructs AmazonPartnerCentralBenefitsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPartnerCentralBenefitsClient(AWSCredentials credentials)
            : this(credentials, new AmazonPartnerCentralBenefitsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralBenefitsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPartnerCentralBenefitsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPartnerCentralBenefitsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralBenefitsClient with AWS Credentials and an
        /// AmazonPartnerCentralBenefitsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPartnerCentralBenefitsClient Configuration Object</param>
        public AmazonPartnerCentralBenefitsClient(AWSCredentials credentials, AmazonPartnerCentralBenefitsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralBenefitsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPartnerCentralBenefitsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPartnerCentralBenefitsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralBenefitsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPartnerCentralBenefitsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPartnerCentralBenefitsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralBenefitsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPartnerCentralBenefitsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPartnerCentralBenefitsClient Configuration Object</param>
        public AmazonPartnerCentralBenefitsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPartnerCentralBenefitsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralBenefitsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPartnerCentralBenefitsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPartnerCentralBenefitsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralBenefitsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPartnerCentralBenefitsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPartnerCentralBenefitsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralBenefitsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPartnerCentralBenefitsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPartnerCentralBenefitsClient Configuration Object</param>
        public AmazonPartnerCentralBenefitsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPartnerCentralBenefitsConfig clientConfig)
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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPartnerCentralBenefitsEndpointResolver());
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


        #region  AmendBenefitApplication


        /// <summary>
        /// Modifies an existing benefit application by applying amendments to specific fields
        /// while maintaining revision control.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AmendBenefitApplication service method.</param>
        /// 
        /// <returns>The response from the AmendBenefitApplication service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/AmendBenefitApplication">REST API Reference for AmendBenefitApplication Operation</seealso>
        public virtual AmendBenefitApplicationResponse AmendBenefitApplication(AmendBenefitApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AmendBenefitApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AmendBenefitApplicationResponseUnmarshaller.Instance;

            return Invoke<AmendBenefitApplicationResponse>(request, options);
        }


        /// <summary>
        /// Modifies an existing benefit application by applying amendments to specific fields
        /// while maintaining revision control.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AmendBenefitApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AmendBenefitApplication service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/AmendBenefitApplication">REST API Reference for AmendBenefitApplication Operation</seealso>
        public virtual Task<AmendBenefitApplicationResponse> AmendBenefitApplicationAsync(AmendBenefitApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AmendBenefitApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AmendBenefitApplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<AmendBenefitApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateBenefitApplicationResource


        /// <summary>
        /// Links an AWS resource to an existing benefit application for tracking and management
        /// purposes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateBenefitApplicationResource service method.</param>
        /// 
        /// <returns>The response from the AssociateBenefitApplicationResource service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/AssociateBenefitApplicationResource">REST API Reference for AssociateBenefitApplicationResource Operation</seealso>
        public virtual AssociateBenefitApplicationResourceResponse AssociateBenefitApplicationResource(AssociateBenefitApplicationResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateBenefitApplicationResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateBenefitApplicationResourceResponseUnmarshaller.Instance;

            return Invoke<AssociateBenefitApplicationResourceResponse>(request, options);
        }


        /// <summary>
        /// Links an AWS resource to an existing benefit application for tracking and management
        /// purposes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateBenefitApplicationResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateBenefitApplicationResource service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/AssociateBenefitApplicationResource">REST API Reference for AssociateBenefitApplicationResource Operation</seealso>
        public virtual Task<AssociateBenefitApplicationResourceResponse> AssociateBenefitApplicationResourceAsync(AssociateBenefitApplicationResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateBenefitApplicationResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateBenefitApplicationResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateBenefitApplicationResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelBenefitApplication


        /// <summary>
        /// Cancels a benefit application that is currently in progress, preventing further processing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelBenefitApplication service method.</param>
        /// 
        /// <returns>The response from the CancelBenefitApplication service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/CancelBenefitApplication">REST API Reference for CancelBenefitApplication Operation</seealso>
        public virtual CancelBenefitApplicationResponse CancelBenefitApplication(CancelBenefitApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelBenefitApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelBenefitApplicationResponseUnmarshaller.Instance;

            return Invoke<CancelBenefitApplicationResponse>(request, options);
        }


        /// <summary>
        /// Cancels a benefit application that is currently in progress, preventing further processing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelBenefitApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelBenefitApplication service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/CancelBenefitApplication">REST API Reference for CancelBenefitApplication Operation</seealso>
        public virtual Task<CancelBenefitApplicationResponse> CancelBenefitApplicationAsync(CancelBenefitApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelBenefitApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelBenefitApplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelBenefitApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateBenefitApplication


        /// <summary>
        /// Creates a new benefit application for a partner to request access to AWS benefits
        /// and programs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBenefitApplication service method.</param>
        /// 
        /// <returns>The response from the CreateBenefitApplication service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/CreateBenefitApplication">REST API Reference for CreateBenefitApplication Operation</seealso>
        public virtual CreateBenefitApplicationResponse CreateBenefitApplication(CreateBenefitApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBenefitApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBenefitApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateBenefitApplicationResponse>(request, options);
        }


        /// <summary>
        /// Creates a new benefit application for a partner to request access to AWS benefits
        /// and programs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBenefitApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBenefitApplication service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/CreateBenefitApplication">REST API Reference for CreateBenefitApplication Operation</seealso>
        public virtual Task<CreateBenefitApplicationResponse> CreateBenefitApplicationAsync(CreateBenefitApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBenefitApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBenefitApplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateBenefitApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateBenefitApplicationResource


        /// <summary>
        /// Removes the association between an AWS resource and a benefit application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateBenefitApplicationResource service method.</param>
        /// 
        /// <returns>The response from the DisassociateBenefitApplicationResource service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/DisassociateBenefitApplicationResource">REST API Reference for DisassociateBenefitApplicationResource Operation</seealso>
        public virtual DisassociateBenefitApplicationResourceResponse DisassociateBenefitApplicationResource(DisassociateBenefitApplicationResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateBenefitApplicationResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateBenefitApplicationResourceResponseUnmarshaller.Instance;

            return Invoke<DisassociateBenefitApplicationResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes the association between an AWS resource and a benefit application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateBenefitApplicationResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateBenefitApplicationResource service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/DisassociateBenefitApplicationResource">REST API Reference for DisassociateBenefitApplicationResource Operation</seealso>
        public virtual Task<DisassociateBenefitApplicationResourceResponse> DisassociateBenefitApplicationResourceAsync(DisassociateBenefitApplicationResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateBenefitApplicationResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateBenefitApplicationResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateBenefitApplicationResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBenefit


        /// <summary>
        /// Retrieves detailed information about a specific benefit available in the partner catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBenefit service method.</param>
        /// 
        /// <returns>The response from the GetBenefit service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/GetBenefit">REST API Reference for GetBenefit Operation</seealso>
        public virtual GetBenefitResponse GetBenefit(GetBenefitRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBenefitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBenefitResponseUnmarshaller.Instance;

            return Invoke<GetBenefitResponse>(request, options);
        }


        /// <summary>
        /// Retrieves detailed information about a specific benefit available in the partner catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBenefit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBenefit service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/GetBenefit">REST API Reference for GetBenefit Operation</seealso>
        public virtual Task<GetBenefitResponse> GetBenefitAsync(GetBenefitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBenefitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBenefitResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetBenefitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBenefitAllocation


        /// <summary>
        /// Retrieves detailed information about a specific benefit allocation that has been granted
        /// to a partner.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBenefitAllocation service method.</param>
        /// 
        /// <returns>The response from the GetBenefitAllocation service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/GetBenefitAllocation">REST API Reference for GetBenefitAllocation Operation</seealso>
        public virtual GetBenefitAllocationResponse GetBenefitAllocation(GetBenefitAllocationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBenefitAllocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBenefitAllocationResponseUnmarshaller.Instance;

            return Invoke<GetBenefitAllocationResponse>(request, options);
        }


        /// <summary>
        /// Retrieves detailed information about a specific benefit allocation that has been granted
        /// to a partner.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBenefitAllocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBenefitAllocation service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/GetBenefitAllocation">REST API Reference for GetBenefitAllocation Operation</seealso>
        public virtual Task<GetBenefitAllocationResponse> GetBenefitAllocationAsync(GetBenefitAllocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBenefitAllocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBenefitAllocationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetBenefitAllocationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBenefitApplication


        /// <summary>
        /// Retrieves detailed information about a specific benefit application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBenefitApplication service method.</param>
        /// 
        /// <returns>The response from the GetBenefitApplication service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/GetBenefitApplication">REST API Reference for GetBenefitApplication Operation</seealso>
        public virtual GetBenefitApplicationResponse GetBenefitApplication(GetBenefitApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBenefitApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBenefitApplicationResponseUnmarshaller.Instance;

            return Invoke<GetBenefitApplicationResponse>(request, options);
        }


        /// <summary>
        /// Retrieves detailed information about a specific benefit application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBenefitApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBenefitApplication service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/GetBenefitApplication">REST API Reference for GetBenefitApplication Operation</seealso>
        public virtual Task<GetBenefitApplicationResponse> GetBenefitApplicationAsync(GetBenefitApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBenefitApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBenefitApplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetBenefitApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBenefitAllocations


        /// <summary>
        /// Retrieves a paginated list of benefit allocations based on specified filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBenefitAllocations service method.</param>
        /// 
        /// <returns>The response from the ListBenefitAllocations service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListBenefitAllocations">REST API Reference for ListBenefitAllocations Operation</seealso>
        public virtual ListBenefitAllocationsResponse ListBenefitAllocations(ListBenefitAllocationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBenefitAllocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBenefitAllocationsResponseUnmarshaller.Instance;

            return Invoke<ListBenefitAllocationsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a paginated list of benefit allocations based on specified filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBenefitAllocations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBenefitAllocations service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListBenefitAllocations">REST API Reference for ListBenefitAllocations Operation</seealso>
        public virtual Task<ListBenefitAllocationsResponse> ListBenefitAllocationsAsync(ListBenefitAllocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBenefitAllocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBenefitAllocationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListBenefitAllocationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBenefitApplications


        /// <summary>
        /// Retrieves a paginated list of benefit applications based on specified filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBenefitApplications service method.</param>
        /// 
        /// <returns>The response from the ListBenefitApplications service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListBenefitApplications">REST API Reference for ListBenefitApplications Operation</seealso>
        public virtual ListBenefitApplicationsResponse ListBenefitApplications(ListBenefitApplicationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBenefitApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBenefitApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListBenefitApplicationsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a paginated list of benefit applications based on specified filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBenefitApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBenefitApplications service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListBenefitApplications">REST API Reference for ListBenefitApplications Operation</seealso>
        public virtual Task<ListBenefitApplicationsResponse> ListBenefitApplicationsAsync(ListBenefitApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBenefitApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBenefitApplicationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListBenefitApplicationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBenefits


        /// <summary>
        /// Retrieves a paginated list of available benefits based on specified filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBenefits service method.</param>
        /// 
        /// <returns>The response from the ListBenefits service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListBenefits">REST API Reference for ListBenefits Operation</seealso>
        public virtual ListBenefitsResponse ListBenefits(ListBenefitsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBenefitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBenefitsResponseUnmarshaller.Instance;

            return Invoke<ListBenefitsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a paginated list of available benefits based on specified filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBenefits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBenefits service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListBenefits">REST API Reference for ListBenefits Operation</seealso>
        public virtual Task<ListBenefitsResponse> ListBenefitsAsync(ListBenefitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBenefitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBenefitsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListBenefitsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Retrieves all tags associated with a specific resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Retrieves all tags associated with a specific resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RecallBenefitApplication


        /// <summary>
        /// Recalls a submitted benefit application, returning it to draft status for further
        /// modifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecallBenefitApplication service method.</param>
        /// 
        /// <returns>The response from the RecallBenefitApplication service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/RecallBenefitApplication">REST API Reference for RecallBenefitApplication Operation</seealso>
        public virtual RecallBenefitApplicationResponse RecallBenefitApplication(RecallBenefitApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RecallBenefitApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecallBenefitApplicationResponseUnmarshaller.Instance;

            return Invoke<RecallBenefitApplicationResponse>(request, options);
        }


        /// <summary>
        /// Recalls a submitted benefit application, returning it to draft status for further
        /// modifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecallBenefitApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RecallBenefitApplication service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/RecallBenefitApplication">REST API Reference for RecallBenefitApplication Operation</seealso>
        public virtual Task<RecallBenefitApplicationResponse> RecallBenefitApplicationAsync(RecallBenefitApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RecallBenefitApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecallBenefitApplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<RecallBenefitApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SubmitBenefitApplication


        /// <summary>
        /// Submits a benefit application for review and processing by AWS.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitBenefitApplication service method.</param>
        /// 
        /// <returns>The response from the SubmitBenefitApplication service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/SubmitBenefitApplication">REST API Reference for SubmitBenefitApplication Operation</seealso>
        public virtual SubmitBenefitApplicationResponse SubmitBenefitApplication(SubmitBenefitApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SubmitBenefitApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubmitBenefitApplicationResponseUnmarshaller.Instance;

            return Invoke<SubmitBenefitApplicationResponse>(request, options);
        }


        /// <summary>
        /// Submits a benefit application for review and processing by AWS.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitBenefitApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SubmitBenefitApplication service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/SubmitBenefitApplication">REST API Reference for SubmitBenefitApplication Operation</seealso>
        public virtual Task<SubmitBenefitApplicationResponse> SubmitBenefitApplicationAsync(SubmitBenefitApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SubmitBenefitApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubmitBenefitApplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<SubmitBenefitApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or updates tags for a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ServiceQuotaExceededException">
        /// Thrown when the request would exceed the service quotas or limits for the account.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds or updates tags for a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ServiceQuotaExceededException">
        /// Thrown when the request would exceed the service quotas or limits for the account.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ServiceQuotaExceededException">
        /// Thrown when the request would exceed the service quotas or limits for the account.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ServiceQuotaExceededException">
        /// Thrown when the request would exceed the service quotas or limits for the account.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateBenefitApplication


        /// <summary>
        /// Updates an existing benefit application with new information while maintaining revision
        /// control.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBenefitApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateBenefitApplication service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/UpdateBenefitApplication">REST API Reference for UpdateBenefitApplication Operation</seealso>
        public virtual UpdateBenefitApplicationResponse UpdateBenefitApplication(UpdateBenefitApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBenefitApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBenefitApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateBenefitApplicationResponse>(request, options);
        }


        /// <summary>
        /// Updates an existing benefit application with new information while maintaining revision
        /// control.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBenefitApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBenefitApplication service method, as returned by PartnerCentralBenefits.</returns>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.AccessDeniedException">
        /// Thrown when the caller does not have sufficient permissions to perform the requested
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ConflictException">
        /// Thrown when the request conflicts with the current state of the resource, such as
        /// attempting to modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.InternalServerException">
        /// Thrown when an unexpected error occurs on the server side during request processing.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ResourceNotFoundException">
        /// Thrown when the requested resource cannot be found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ThrottlingException">
        /// Thrown when the request rate exceeds the allowed limits and the request is being throttled.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralBenefits.Model.ValidationException">
        /// Thrown when the request contains invalid parameters or fails input validation requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/UpdateBenefitApplication">REST API Reference for UpdateBenefitApplication Operation</seealso>
        public virtual Task<UpdateBenefitApplicationResponse> UpdateBenefitApplicationAsync(UpdateBenefitApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBenefitApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBenefitApplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateBenefitApplicationResponse>(request, options, cancellationToken);
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
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonPartnerCentralBenefitsEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}