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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
#endif
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
        /// Initiates the asynchronous execution of the AmendBenefitApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AmendBenefitApplication operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAmendBenefitApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/AmendBenefitApplication">REST API Reference for AmendBenefitApplication Operation</seealso>
        public virtual IAsyncResult BeginAmendBenefitApplication(AmendBenefitApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AmendBenefitApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AmendBenefitApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AmendBenefitApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAmendBenefitApplication.</param>
        /// 
        /// <returns>Returns a  AmendBenefitApplicationResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/AmendBenefitApplication">REST API Reference for AmendBenefitApplication Operation</seealso>
        public virtual AmendBenefitApplicationResponse EndAmendBenefitApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<AmendBenefitApplicationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the AssociateBenefitApplicationResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateBenefitApplicationResource operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateBenefitApplicationResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/AssociateBenefitApplicationResource">REST API Reference for AssociateBenefitApplicationResource Operation</seealso>
        public virtual IAsyncResult BeginAssociateBenefitApplicationResource(AssociateBenefitApplicationResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateBenefitApplicationResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateBenefitApplicationResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateBenefitApplicationResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateBenefitApplicationResource.</param>
        /// 
        /// <returns>Returns a  AssociateBenefitApplicationResourceResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/AssociateBenefitApplicationResource">REST API Reference for AssociateBenefitApplicationResource Operation</seealso>
        public virtual AssociateBenefitApplicationResourceResponse EndAssociateBenefitApplicationResource(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateBenefitApplicationResourceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CancelBenefitApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelBenefitApplication operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelBenefitApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/CancelBenefitApplication">REST API Reference for CancelBenefitApplication Operation</seealso>
        public virtual IAsyncResult BeginCancelBenefitApplication(CancelBenefitApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelBenefitApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelBenefitApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelBenefitApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelBenefitApplication.</param>
        /// 
        /// <returns>Returns a  CancelBenefitApplicationResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/CancelBenefitApplication">REST API Reference for CancelBenefitApplication Operation</seealso>
        public virtual CancelBenefitApplicationResponse EndCancelBenefitApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelBenefitApplicationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateBenefitApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBenefitApplication operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBenefitApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/CreateBenefitApplication">REST API Reference for CreateBenefitApplication Operation</seealso>
        public virtual IAsyncResult BeginCreateBenefitApplication(CreateBenefitApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBenefitApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBenefitApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBenefitApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBenefitApplication.</param>
        /// 
        /// <returns>Returns a  CreateBenefitApplicationResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/CreateBenefitApplication">REST API Reference for CreateBenefitApplication Operation</seealso>
        public virtual CreateBenefitApplicationResponse EndCreateBenefitApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBenefitApplicationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DisassociateBenefitApplicationResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateBenefitApplicationResource operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateBenefitApplicationResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/DisassociateBenefitApplicationResource">REST API Reference for DisassociateBenefitApplicationResource Operation</seealso>
        public virtual IAsyncResult BeginDisassociateBenefitApplicationResource(DisassociateBenefitApplicationResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateBenefitApplicationResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateBenefitApplicationResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateBenefitApplicationResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateBenefitApplicationResource.</param>
        /// 
        /// <returns>Returns a  DisassociateBenefitApplicationResourceResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/DisassociateBenefitApplicationResource">REST API Reference for DisassociateBenefitApplicationResource Operation</seealso>
        public virtual DisassociateBenefitApplicationResourceResponse EndDisassociateBenefitApplicationResource(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateBenefitApplicationResourceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetBenefit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBenefit operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBenefit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/GetBenefit">REST API Reference for GetBenefit Operation</seealso>
        public virtual IAsyncResult BeginGetBenefit(GetBenefitRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBenefitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBenefitResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBenefit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBenefit.</param>
        /// 
        /// <returns>Returns a  GetBenefitResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/GetBenefit">REST API Reference for GetBenefit Operation</seealso>
        public virtual GetBenefitResponse EndGetBenefit(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBenefitResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetBenefitAllocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBenefitAllocation operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBenefitAllocation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/GetBenefitAllocation">REST API Reference for GetBenefitAllocation Operation</seealso>
        public virtual IAsyncResult BeginGetBenefitAllocation(GetBenefitAllocationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBenefitAllocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBenefitAllocationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBenefitAllocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBenefitAllocation.</param>
        /// 
        /// <returns>Returns a  GetBenefitAllocationResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/GetBenefitAllocation">REST API Reference for GetBenefitAllocation Operation</seealso>
        public virtual GetBenefitAllocationResponse EndGetBenefitAllocation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBenefitAllocationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetBenefitApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBenefitApplication operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBenefitApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/GetBenefitApplication">REST API Reference for GetBenefitApplication Operation</seealso>
        public virtual IAsyncResult BeginGetBenefitApplication(GetBenefitApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBenefitApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBenefitApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBenefitApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBenefitApplication.</param>
        /// 
        /// <returns>Returns a  GetBenefitApplicationResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/GetBenefitApplication">REST API Reference for GetBenefitApplication Operation</seealso>
        public virtual GetBenefitApplicationResponse EndGetBenefitApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBenefitApplicationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListBenefitAllocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBenefitAllocations operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBenefitAllocations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListBenefitAllocations">REST API Reference for ListBenefitAllocations Operation</seealso>
        public virtual IAsyncResult BeginListBenefitAllocations(ListBenefitAllocationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBenefitAllocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBenefitAllocationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBenefitAllocations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBenefitAllocations.</param>
        /// 
        /// <returns>Returns a  ListBenefitAllocationsResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListBenefitAllocations">REST API Reference for ListBenefitAllocations Operation</seealso>
        public virtual ListBenefitAllocationsResponse EndListBenefitAllocations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBenefitAllocationsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListBenefitApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBenefitApplications operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBenefitApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListBenefitApplications">REST API Reference for ListBenefitApplications Operation</seealso>
        public virtual IAsyncResult BeginListBenefitApplications(ListBenefitApplicationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBenefitApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBenefitApplicationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBenefitApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBenefitApplications.</param>
        /// 
        /// <returns>Returns a  ListBenefitApplicationsResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListBenefitApplications">REST API Reference for ListBenefitApplications Operation</seealso>
        public virtual ListBenefitApplicationsResponse EndListBenefitApplications(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBenefitApplicationsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListBenefits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBenefits operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBenefits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListBenefits">REST API Reference for ListBenefits Operation</seealso>
        public virtual IAsyncResult BeginListBenefits(ListBenefitsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBenefitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBenefitsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBenefits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBenefits.</param>
        /// 
        /// <returns>Returns a  ListBenefitsResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListBenefits">REST API Reference for ListBenefits Operation</seealso>
        public virtual ListBenefitsResponse EndListBenefits(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBenefitsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  ListTagsForResourceResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the RecallBenefitApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RecallBenefitApplication operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRecallBenefitApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/RecallBenefitApplication">REST API Reference for RecallBenefitApplication Operation</seealso>
        public virtual IAsyncResult BeginRecallBenefitApplication(RecallBenefitApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RecallBenefitApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecallBenefitApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RecallBenefitApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRecallBenefitApplication.</param>
        /// 
        /// <returns>Returns a  RecallBenefitApplicationResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/RecallBenefitApplication">REST API Reference for RecallBenefitApplication Operation</seealso>
        public virtual RecallBenefitApplicationResponse EndRecallBenefitApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<RecallBenefitApplicationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the SubmitBenefitApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SubmitBenefitApplication operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSubmitBenefitApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/SubmitBenefitApplication">REST API Reference for SubmitBenefitApplication Operation</seealso>
        public virtual IAsyncResult BeginSubmitBenefitApplication(SubmitBenefitApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SubmitBenefitApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubmitBenefitApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SubmitBenefitApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSubmitBenefitApplication.</param>
        /// 
        /// <returns>Returns a  SubmitBenefitApplicationResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/SubmitBenefitApplication">REST API Reference for SubmitBenefitApplication Operation</seealso>
        public virtual SubmitBenefitApplicationResponse EndSubmitBenefitApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<SubmitBenefitApplicationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  TagResourceResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  UntagResourceResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateBenefitApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBenefitApplication operation on AmazonPartnerCentralBenefitsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBenefitApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/UpdateBenefitApplication">REST API Reference for UpdateBenefitApplication Operation</seealso>
        public virtual IAsyncResult BeginUpdateBenefitApplication(UpdateBenefitApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBenefitApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBenefitApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBenefitApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBenefitApplication.</param>
        /// 
        /// <returns>Returns a  UpdateBenefitApplicationResult from PartnerCentralBenefits.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-benefits-2018-05-10/UpdateBenefitApplication">REST API Reference for UpdateBenefitApplication Operation</seealso>
        public virtual UpdateBenefitApplicationResponse EndUpdateBenefitApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBenefitApplicationResponse>(asyncResult);
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