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
 * Do not modify this file. This file is generated from the ssm-sap-2018-05-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SsmSap.Model;
using Amazon.SsmSap.Model.Internal.MarshallTransformations;
using Amazon.SsmSap.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.SsmSap
{
    /// <summary>
    /// <para>Implementation for accessing SsmSap</para>
    ///
    /// This API reference provides descriptions, syntax, and other details about each of
    /// the actions and data types for AWS Systems Manager for SAP. The topic for each action
    /// shows the API request parameters and responses.
    /// </summary>
    public partial class AmazonSsmSapClient : AmazonServiceClient, IAmazonSsmSap
    {
        private static IServiceMetadata serviceMetadata = new AmazonSsmSapMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonSsmSapClient with the credentials loaded from the application's
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
        public AmazonSsmSapClient()
            : base(new AmazonSsmSapConfig()) { }

        /// <summary>
        /// Constructs AmazonSsmSapClient with the credentials loaded from the application's
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
        public AmazonSsmSapClient(RegionEndpoint region)
            : base(new AmazonSsmSapConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSsmSapClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSsmSapClient Configuration Object</param>
        public AmazonSsmSapClient(AmazonSsmSapConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonSsmSapClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSsmSapClient(AWSCredentials credentials)
            : this(credentials, new AmazonSsmSapConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSsmSapClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSsmSapClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSsmSapConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSsmSapClient with AWS Credentials and an
        /// AmazonSsmSapClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSsmSapClient Configuration Object</param>
        public AmazonSsmSapClient(AWSCredentials credentials, AmazonSsmSapConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSsmSapClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSsmSapClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSsmSapConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSsmSapClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSsmSapClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSsmSapConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSsmSapClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSsmSapClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSsmSapClient Configuration Object</param>
        public AmazonSsmSapClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSsmSapConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSsmSapClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSsmSapClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSsmSapConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSsmSapClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSsmSapClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSsmSapConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSsmSapClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSsmSapClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSsmSapClient Configuration Object</param>
        public AmazonSsmSapClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSsmSapConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ISsmSapPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISsmSapPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SsmSapPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSsmSapEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSsmSapAuthSchemeHandler());
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


        #region  DeleteResourcePermission

        internal virtual DeleteResourcePermissionResponse DeleteResourcePermission(DeleteResourcePermissionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourcePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePermissionResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePermissionResponse>(request, options);
        }



        /// <summary>
        /// Removes permissions associated with the target database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourcePermission service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/DeleteResourcePermission">REST API Reference for DeleteResourcePermission Operation</seealso>
        public virtual Task<DeleteResourcePermissionResponse> DeleteResourcePermissionAsync(DeleteResourcePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourcePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePermissionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourcePermissionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeregisterApplication

        internal virtual DeregisterApplicationResponse DeregisterApplication(DeregisterApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterApplicationResponseUnmarshaller.Instance;

            return Invoke<DeregisterApplicationResponse>(request, options);
        }



        /// <summary>
        /// Deregister an SAP application with AWS Systems Manager for SAP. This action does not
        /// aﬀect the existing setup of your SAP workloads on Amazon EC2.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterApplication service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.UnauthorizedException">
        /// The request is not authorized.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/DeregisterApplication">REST API Reference for DeregisterApplication Operation</seealso>
        public virtual Task<DeregisterApplicationResponse> DeregisterApplicationAsync(DeregisterApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetApplication

        internal virtual GetApplicationResponse GetApplication(GetApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationResponseUnmarshaller.Instance;

            return Invoke<GetApplicationResponse>(request, options);
        }



        /// <summary>
        /// Gets an application registered with AWS Systems Manager for SAP. It also returns the
        /// components of the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetApplication">REST API Reference for GetApplication Operation</seealso>
        public virtual Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<GetApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetComponent

        internal virtual GetComponentResponse GetComponent(GetComponentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentResponseUnmarshaller.Instance;

            return Invoke<GetComponentResponse>(request, options);
        }



        /// <summary>
        /// Gets the component of an application registered with AWS Systems Manager for SAP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetComponent service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.UnauthorizedException">
        /// The request is not authorized.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetComponent">REST API Reference for GetComponent Operation</seealso>
        public virtual Task<GetComponentResponse> GetComponentAsync(GetComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentResponseUnmarshaller.Instance;

            return InvokeAsync<GetComponentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetConfigurationCheckOperation

        internal virtual GetConfigurationCheckOperationResponse GetConfigurationCheckOperation(GetConfigurationCheckOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfigurationCheckOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationCheckOperationResponseUnmarshaller.Instance;

            return Invoke<GetConfigurationCheckOperationResponse>(request, options);
        }



        /// <summary>
        /// Gets the details of a configuration check operation by specifying the operation ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfigurationCheckOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConfigurationCheckOperation service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetConfigurationCheckOperation">REST API Reference for GetConfigurationCheckOperation Operation</seealso>
        public virtual Task<GetConfigurationCheckOperationResponse> GetConfigurationCheckOperationAsync(GetConfigurationCheckOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConfigurationCheckOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigurationCheckOperationResponseUnmarshaller.Instance;

            return InvokeAsync<GetConfigurationCheckOperationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDatabase

        internal virtual GetDatabaseResponse GetDatabase(GetDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatabaseResponseUnmarshaller.Instance;

            return Invoke<GetDatabaseResponse>(request, options);
        }



        /// <summary>
        /// Gets the SAP HANA database of an application registered with AWS Systems Manager for
        /// SAP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDatabase service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetDatabase">REST API Reference for GetDatabase Operation</seealso>
        public virtual Task<GetDatabaseResponse> GetDatabaseAsync(GetDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<GetDatabaseResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetOperation

        internal virtual GetOperationResponse GetOperation(GetOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOperationResponseUnmarshaller.Instance;

            return Invoke<GetOperationResponse>(request, options);
        }



        /// <summary>
        /// Gets the details of an operation by specifying the operation ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOperation service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetOperation">REST API Reference for GetOperation Operation</seealso>
        public virtual Task<GetOperationResponse> GetOperationAsync(GetOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOperationResponseUnmarshaller.Instance;

            return InvokeAsync<GetOperationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetResourcePermission

        internal virtual GetResourcePermissionResponse GetResourcePermission(GetResourcePermissionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePermissionResponseUnmarshaller.Instance;

            return Invoke<GetResourcePermissionResponse>(request, options);
        }



        /// <summary>
        /// Gets permissions associated with the target database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePermission service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/GetResourcePermission">REST API Reference for GetResourcePermission Operation</seealso>
        public virtual Task<GetResourcePermissionResponse> GetResourcePermissionAsync(GetResourcePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePermissionResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourcePermissionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListApplications

        internal virtual ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationsResponse>(request, options);
        }



        /// <summary>
        /// Lists all the applications registered with AWS Systems Manager for SAP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListComponents

        internal virtual ListComponentsResponse ListComponents(ListComponentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentsResponseUnmarshaller.Instance;

            return Invoke<ListComponentsResponse>(request, options);
        }



        /// <summary>
        /// Lists all the components registered with AWS Systems Manager for SAP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListComponents service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.UnauthorizedException">
        /// The request is not authorized.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListComponents">REST API Reference for ListComponents Operation</seealso>
        public virtual Task<ListComponentsResponse> ListComponentsAsync(ListComponentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListComponentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListConfigurationCheckDefinitions

        internal virtual ListConfigurationCheckDefinitionsResponse ListConfigurationCheckDefinitions(ListConfigurationCheckDefinitionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationCheckDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationCheckDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationCheckDefinitionsResponse>(request, options);
        }



        /// <summary>
        /// Lists all configuration check types supported by AWS Systems Manager for SAP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationCheckDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConfigurationCheckDefinitions service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListConfigurationCheckDefinitions">REST API Reference for ListConfigurationCheckDefinitions Operation</seealso>
        public virtual Task<ListConfigurationCheckDefinitionsResponse> ListConfigurationCheckDefinitionsAsync(ListConfigurationCheckDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationCheckDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationCheckDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListConfigurationCheckDefinitionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListConfigurationCheckOperations

        internal virtual ListConfigurationCheckOperationsResponse ListConfigurationCheckOperations(ListConfigurationCheckOperationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationCheckOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationCheckOperationsResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationCheckOperationsResponse>(request, options);
        }



        /// <summary>
        /// Lists the configuration check operations performed by AWS Systems Manager for SAP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationCheckOperations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConfigurationCheckOperations service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListConfigurationCheckOperations">REST API Reference for ListConfigurationCheckOperations Operation</seealso>
        public virtual Task<ListConfigurationCheckOperationsResponse> ListConfigurationCheckOperationsAsync(ListConfigurationCheckOperationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationCheckOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationCheckOperationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListConfigurationCheckOperationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDatabases

        internal virtual ListDatabasesResponse ListDatabases(ListDatabasesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatabasesResponseUnmarshaller.Instance;

            return Invoke<ListDatabasesResponse>(request, options);
        }



        /// <summary>
        /// Lists the SAP HANA databases of an application registered with AWS Systems Manager
        /// for SAP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatabases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatabases service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListDatabases">REST API Reference for ListDatabases Operation</seealso>
        public virtual Task<ListDatabasesResponse> ListDatabasesAsync(ListDatabasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatabasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDatabasesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListOperationEvents

        internal virtual ListOperationEventsResponse ListOperationEvents(ListOperationEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOperationEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOperationEventsResponseUnmarshaller.Instance;

            return Invoke<ListOperationEventsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of operations events.
        /// 
        ///  
        /// <para>
        /// Available parameters include <c>OperationID</c>, as well as optional parameters <c>MaxResults</c>,
        /// <c>NextToken</c>, and <c>Filters</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOperationEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOperationEvents service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListOperationEvents">REST API Reference for ListOperationEvents Operation</seealso>
        public virtual Task<ListOperationEventsResponse> ListOperationEventsAsync(ListOperationEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOperationEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOperationEventsResponseUnmarshaller.Instance;

            return InvokeAsync<ListOperationEventsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListOperations

        internal virtual ListOperationsResponse ListOperations(ListOperationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOperationsResponseUnmarshaller.Instance;

            return Invoke<ListOperationsResponse>(request, options);
        }



        /// <summary>
        /// Lists the operations performed by AWS Systems Manager for SAP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOperations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOperations service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListOperations">REST API Reference for ListOperations Operation</seealso>
        public virtual Task<ListOperationsResponse> ListOperationsAsync(ListOperationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOperationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListOperationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSubCheckResults

        internal virtual ListSubCheckResultsResponse ListSubCheckResults(ListSubCheckResultsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubCheckResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubCheckResultsResponseUnmarshaller.Instance;

            return Invoke<ListSubCheckResultsResponse>(request, options);
        }



        /// <summary>
        /// Lists the sub-check results of a specified configuration check operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubCheckResults service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubCheckResults service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListSubCheckResults">REST API Reference for ListSubCheckResults Operation</seealso>
        public virtual Task<ListSubCheckResultsResponse> ListSubCheckResultsAsync(ListSubCheckResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubCheckResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubCheckResultsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSubCheckResultsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSubCheckRuleResults

        internal virtual ListSubCheckRuleResultsResponse ListSubCheckRuleResults(ListSubCheckRuleResultsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubCheckRuleResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubCheckRuleResultsResponseUnmarshaller.Instance;

            return Invoke<ListSubCheckRuleResultsResponse>(request, options);
        }



        /// <summary>
        /// Lists the rules of a specified sub-check belonging to a configuration check operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubCheckRuleResults service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubCheckRuleResults service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListSubCheckRuleResults">REST API Reference for ListSubCheckRuleResults Operation</seealso>
        public virtual Task<ListSubCheckRuleResultsResponse> ListSubCheckRuleResultsAsync(ListSubCheckRuleResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubCheckRuleResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubCheckRuleResultsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSubCheckRuleResultsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists all tags on an SAP HANA application and/or database registered with AWS Systems
        /// Manager for SAP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.ConflictException">
        /// A conflict has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutResourcePermission

        internal virtual PutResourcePermissionResponse PutResourcePermission(PutResourcePermissionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourcePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePermissionResponseUnmarshaller.Instance;

            return Invoke<PutResourcePermissionResponse>(request, options);
        }



        /// <summary>
        /// Adds permissions to the target database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourcePermission service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/PutResourcePermission">REST API Reference for PutResourcePermission Operation</seealso>
        public virtual Task<PutResourcePermissionResponse> PutResourcePermissionAsync(PutResourcePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourcePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePermissionResponseUnmarshaller.Instance;

            return InvokeAsync<PutResourcePermissionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RegisterApplication

        internal virtual RegisterApplicationResponse RegisterApplication(RegisterApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterApplicationResponseUnmarshaller.Instance;

            return Invoke<RegisterApplicationResponse>(request, options);
        }



        /// <summary>
        /// Register an SAP application with AWS Systems Manager for SAP. You must meet the following
        /// requirements before registering. 
        /// 
        ///  
        /// <para>
        /// The SAP application you want to register with AWS Systems Manager for SAP is running
        /// on Amazon EC2.
        /// </para>
        ///  
        /// <para>
        /// AWS Systems Manager Agent must be setup on an Amazon EC2 instance along with the required
        /// IAM permissions.
        /// </para>
        ///  
        /// <para>
        /// Amazon EC2 instance(s) must have access to the secrets created in AWS Secrets Manager
        /// to manage SAP applications and components.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterApplication service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.ConflictException">
        /// A conflict has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/RegisterApplication">REST API Reference for RegisterApplication Operation</seealso>
        public virtual Task<RegisterApplicationResponse> RegisterApplicationAsync(RegisterApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartApplication

        internal virtual StartApplicationResponse StartApplication(StartApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartApplicationResponseUnmarshaller.Instance;

            return Invoke<StartApplicationResponse>(request, options);
        }



        /// <summary>
        /// Request is an operation which starts an application.
        /// 
        ///  
        /// <para>
        /// Parameter <c>ApplicationId</c> is required.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartApplication service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.ConflictException">
        /// A conflict has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/StartApplication">REST API Reference for StartApplication Operation</seealso>
        public virtual Task<StartApplicationResponse> StartApplicationAsync(StartApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<StartApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartApplicationRefresh

        internal virtual StartApplicationRefreshResponse StartApplicationRefresh(StartApplicationRefreshRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartApplicationRefreshRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartApplicationRefreshResponseUnmarshaller.Instance;

            return Invoke<StartApplicationRefreshResponse>(request, options);
        }



        /// <summary>
        /// Refreshes a registered application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartApplicationRefresh service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartApplicationRefresh service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.ConflictException">
        /// A conflict has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.UnauthorizedException">
        /// The request is not authorized.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/StartApplicationRefresh">REST API Reference for StartApplicationRefresh Operation</seealso>
        public virtual Task<StartApplicationRefreshResponse> StartApplicationRefreshAsync(StartApplicationRefreshRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartApplicationRefreshRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartApplicationRefreshResponseUnmarshaller.Instance;

            return InvokeAsync<StartApplicationRefreshResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartConfigurationChecks

        internal virtual StartConfigurationChecksResponse StartConfigurationChecks(StartConfigurationChecksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartConfigurationChecksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartConfigurationChecksResponseUnmarshaller.Instance;

            return Invoke<StartConfigurationChecksResponse>(request, options);
        }



        /// <summary>
        /// Initiates configuration check operations against a specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartConfigurationChecks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartConfigurationChecks service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.ConflictException">
        /// A conflict has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/StartConfigurationChecks">REST API Reference for StartConfigurationChecks Operation</seealso>
        public virtual Task<StartConfigurationChecksResponse> StartConfigurationChecksAsync(StartConfigurationChecksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartConfigurationChecksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartConfigurationChecksResponseUnmarshaller.Instance;

            return InvokeAsync<StartConfigurationChecksResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopApplication

        internal virtual StopApplicationResponse StopApplication(StopApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopApplicationResponseUnmarshaller.Instance;

            return Invoke<StopApplicationResponse>(request, options);
        }



        /// <summary>
        /// Request is an operation to stop an application.
        /// 
        ///  
        /// <para>
        /// Parameter <c>ApplicationId</c> is required. Parameters <c>StopConnectedEntity</c>
        /// and <c>IncludeEc2InstanceShutdown</c> are optional.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopApplication service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.ConflictException">
        /// A conflict has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/StopApplication">REST API Reference for StopApplication Operation</seealso>
        public virtual Task<StopApplicationResponse> StopApplicationAsync(StopApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<StopApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Creates tag for a resource by specifying the ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.ConflictException">
        /// A conflict has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Delete the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.ConflictException">
        /// A conflict has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateApplicationSettings

        internal virtual UpdateApplicationSettingsResponse UpdateApplicationSettings(UpdateApplicationSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApplicationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationSettingsResponse>(request, options);
        }



        /// <summary>
        /// Updates the settings of an application registered with AWS Systems Manager for SAP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplicationSettings service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.ConflictException">
        /// A conflict has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.UnauthorizedException">
        /// The request is not authorized.
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-sap-2018-05-10/UpdateApplicationSettings">REST API Reference for UpdateApplicationSettings Operation</seealso>
        public virtual Task<UpdateApplicationSettingsResponse> UpdateApplicationSettingsAsync(UpdateApplicationSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApplicationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApplicationSettingsResponse>(request, options, cancellationToken);
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